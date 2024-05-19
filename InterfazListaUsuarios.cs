using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Datos;
using Negocio;


namespace Presentacion
{
    public partial class InterfazListaUsuarios : Ventana
    {
        private UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();

        public InterfazListaUsuarios() // Las filas 1 y 2 están raras, las tenés que declarar sí o sí acá? Por qué? En otros formularios no fue necesario.
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
       //     dataGridView1 = new DataGridView(); // 1
       //     dataGridView1.CellClick += Usuarios_CellClick; // 2
            Boton_Eliminar.Visible = false;
        }

        private void InterfazListaUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        public void CargarUsuarios()
        {
            try
            {
                List<UsuariosActivos> usuarios = UsuarioNegocio.ListarUsuarios();

                // Filtrar usuarios cuyo NombreUsuario empiece por "G1"
                usuarios = usuarios.Where(u => u.NombreUsuario.StartsWith("G1")).ToList();

                // Reemplazar los valores de la columna HOST
                foreach (UsuariosActivos usuario in usuarios)
                {
                    // Convertir Host a tipo numérico antes de la comparación
                    int hostValue = Convert.ToInt32(usuario.Host);

                    // Reemplazar los valores numéricos por su equivalente en texto
                    if (hostValue == 1)
                    {
                        usuario.Host = "Administrador";
                    }
                    else if (hostValue == 2)
                    {
                        usuario.Host = "Supervisor";
                    }
                    else if (hostValue == 3)
                    {
                        usuario.Host = "Vendedor";
                    }
                }

                var bindingList = new BindingList<UsuariosActivos>(usuarios);
                var source = new BindingSource(bindingList, null);
                Usuarios.DataSource = source;
                Usuarios.Columns["Host"].HeaderText = "Rol";
                Usuarios.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Usuarios: " + ex.Message);
            }
        }

        private void Boton_AltaUsuario_Click(object sender, EventArgs e)
        {
            InterfazAltaUsuarios InterfazAltaUsuarios = new InterfazAltaUsuarios();
            Hide();
            InterfazAltaUsuarios.Show();
        } 

        //private void Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
        //    {
        //        DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
        //        if (column.Name == "Visualizar")
        //        {
        //            Console.WriteLine("Clic en Visualizar");
        //            string Mode = "DSP";
        //            MessageBox.Show("El valor de Mode es: " + Mode);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Clic en Visualizar");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("prueba");
        //    }
        //} // ¿Esta función no hace nada?, la eliminamos??

        private void Limpiar() 
        {
            Box_BuscarDNI.Text = "";
            UsuariosBuscador.Text = "";
            Boton_Eliminar.Visible = false; 
        }

        private void UsuariosLupa_Click(object sender, EventArgs e)
        {
            string textoBusqueda = UsuariosBuscador.Text; // Obtener el texto ingresado en el TextBox UsuariosBuscador

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarUsuarios();
                Limpiar();
                Boton_Eliminar.Visible = false;
            }

            // Verificar si la lista de usuarios es nula o está vacía
            if (Usuarios.DataSource == null || Usuarios.Rows.Count == 0)
            {
                // Manejar el caso en el que la lista de usuarios es nula o vacía
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay usuarios para buscar.");
                Boton_Eliminar.Visible = false;
            }
            else
            {
                // Lista para almacenar los usuarios que coinciden con la búsqueda
                List<UsuariosActivos> usuariosFiltrados = new List<UsuariosActivos>();

                // Recorrer cada fila en el DataGridView Usuarios
                foreach (DataGridViewRow fila in Usuarios.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del usuario
                    string nombreUsuario = fila.Cells["Nombre"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de usuario actual (No importa mayúscula o minúscula)
                    if (!string.IsNullOrEmpty(nombreUsuario) && nombreUsuario.ToLower().Contains(textoBusqueda.ToLower()))
                    {
                        // Agregar el usuario a la lista de usuarios filtrados
                        usuariosFiltrados.Add((UsuariosActivos)fila.DataBoundItem);
                    }
                }

                // Verificar si se encontraron usuarios que coinciden con la búsqueda
                if (usuariosFiltrados.Count > 0)
                {
                    // Actualizar el DataSource del DataGridView con los usuarios filtrados
                    var bindingList = new BindingList<UsuariosActivos>(usuariosFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Usuarios.DataSource = source;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    // Mostrar un mensaje si no se encontraron usuarios que coincidan con la búsqueda
                    MessageBox.Show("No se encontraron usuarios que coincidan con este nombre.");
                }
            }
        }

        private void LupaDNI_Click(object sender, EventArgs e)
        {
            string textoBusqueda = Box_BuscarDNI.Text; // Obtener el texto ingresado en el TextBox UsuariosBuscador

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarUsuarios();
                Limpiar();
                Boton_Eliminar.Visible = false;
            }

            // Verificar si la lista de usuarios es nula o está vacía
            if (Usuarios.DataSource == null || Usuarios.Rows.Count == 0)
            {
                // Manejar el caso en el que la lista de usuarios es nula o vacía
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay usuarios para buscar.");
                Boton_Eliminar.Visible = false;
            }
            else
            {
                // Lista para almacenar los usuarios que coinciden con la búsqueda
                List<UsuariosActivos> usuariosFiltrados = new List<UsuariosActivos>();

                // Recorrer cada fila en el DataGridView Usuarios
                foreach (DataGridViewRow fila in Usuarios.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del usuario
                    string DNI = fila.Cells["DNI"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de usuario actual
                    if (!string.IsNullOrEmpty(DNI) && DNI.Contains(textoBusqueda))
                    {
                        // Agregar el usuario a la lista de usuarios filtrados
                        usuariosFiltrados.Add((UsuariosActivos)fila.DataBoundItem);
                    }
                }

                // Verificar si se encontraron usuarios que coinciden con la búsqueda
                if (usuariosFiltrados.Count > 0)
                {
                    // Actualizar el DataSource del DataGridView con los usuarios filtrados
                    var bindingList = new BindingList<UsuariosActivos>(usuariosFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Usuarios.DataSource = source;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    // Mostrar un mensaje si no se encontraron usuarios que coincidan con la búsqueda
                    MessageBox.Show("No se encontraron usuarios que coincidan con este DNI.");
                }
            }
        }

        private void BorrarFiltro_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
            Limpiar();
            Boton_Eliminar.Visible = false;
        }

        private void EliminarUsuario() // EliminarUsuario(idUsuario)
        {
            UsuarioNegocio BajaUsuario = new UsuarioNegocio();
            //BajaUsuario.BorrarUsuario(ACÁ SE DEBERÍA ESPECIFICAR DE QUÉ CELDA SALE EL DATO DEL ID/IDUsuario);
            
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada dentro del GRID
            if (Usuarios.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = Usuarios.SelectedRows[0].Index;

                // Obtener el valor de la celda "ID" de la fila seleccionada
                string id = Usuarios.Rows[indiceFila].Cells["ID"].Value.ToString();

                EliminarUsuario(); // EliminarUsuario(idUsuario)
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de intentar eliminar.");
            }
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazMenu ventanaMenu = new InterfazMenu();
                ventanaMenu.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InterfazMenu InterfazMenu = new InterfazMenu();
                    InterfazMenu.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}