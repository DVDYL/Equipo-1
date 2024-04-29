using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazListaProveedores : Ventana
    {
        private ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();

        public InterfazListaProveedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        private void InterfazListaProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                List<TraerProveedores> Proveedor = ProveedorNegocio.listarProveedores();

                //    Proveedor = ProveedorNegocio.listarProveedores().Where(u => u.Email.Contains("@G1")).ToList();

                // Acá iría algún filtro para que solo se vean nuestros proveedores.

                var bindingList = new BindingList<TraerProveedores>(Proveedor);
                var source = new BindingSource(bindingList, null);
                Proveedores.DataSource = source;
                Proveedores.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Proveedores: " + ex.Message);
            }
        }

        private void Proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Maneja la selección de una línea en la tabla.
        }

        private void ProveedoresLupa_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox UsuariosBuscador
            string textoBusqueda = ProveedoresBuscador.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProveedores();
            }

            // Verificar si la lista de usuarios es nula o está vacía
            if (Proveedores.DataSource == null || Proveedores.Rows.Count == 0)
            {
                // Manejar el caso en el que la lista de usuarios es nula o vacía
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay usuarios para buscar.");
            }
            else
            {
                // Lista para almacenar los usuarios que coinciden con la búsqueda
                List<TraerProveedores> proveedoresFiltrados = new List<TraerProveedores>();

                // Recorrer cada fila en el DataGridView Usuarios
                foreach (DataGridViewRow fila in Proveedores.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del usuario
                    string nombreProveedor = fila.Cells["Nombre"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de usuario actual
                    if (!string.IsNullOrEmpty(nombreProveedor) && nombreProveedor.Contains(textoBusqueda))
                    {
                        // Agregar el usuario a la lista de usuarios filtrados
                        proveedoresFiltrados.Add((TraerProveedores)fila.DataBoundItem);
                    }
                }

                // Verificar si se encontraron usuarios que coinciden con la búsqueda
                if (proveedoresFiltrados.Count > 0)
                {
                    // Actualizar el DataSource del DataGridView con los usuarios filtrados
                    var bindingList = new BindingList<TraerProveedores>(proveedoresFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Proveedores.DataSource = source;
                }
                else
                {
                    // Mostrar un mensaje si no se encontraron usuarios que coincidan con la búsqueda
                    MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.");
                }
            }
        }

        private void CUITLupa_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox UsuariosBuscador
            string textoBusqueda = CUITBuscador.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProveedores();
            }

            // Verificar si la lista de usuarios es nula o está vacía
            if (Proveedores.DataSource == null || Proveedores.Rows.Count == 0)
            {
                // Manejar el caso en el que la lista de usuarios es nula o vacía
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay proveedores para buscar.");
            }
            else
            {
                // Lista para almacenar los usuarios que coinciden con la búsqueda
                List<TraerProveedores> proveedoresFiltrados = new List<TraerProveedores>();

                // Recorrer cada fila en el DataGridView Usuarios
                foreach (DataGridViewRow fila in Proveedores.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del usuario
                    string CUIT = fila.Cells["CUIT"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de usuario actual
                    if (!string.IsNullOrEmpty(CUIT) && CUIT.Contains(textoBusqueda))
                    {
                        // Agregar el usuario a la lista de usuarios filtrados
                        proveedoresFiltrados.Add((TraerProveedores)fila.DataBoundItem);
                    }
                }

                // Verificar si se encontraron usuarios que coinciden con la búsqueda
                if (proveedoresFiltrados.Count > 0)
                {
                    // Actualizar el DataSource del DataGridView con los usuarios filtrados
                    var bindingList = new BindingList<TraerProveedores>(proveedoresFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Proveedores.DataSource = source;
                }
                else
                {
                    // Mostrar un mensaje si no se encontraron usuarios que coincidan con la búsqueda
                    MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.");
                }
            }

        }

        private void BotonAltaProveedores_Click(object sender, EventArgs e)
        {
            InterfazAltaProveedores AltaProveedores = new InterfazAltaProveedores();
            this.Hide();
            AltaProveedores.Show(); // Mostrar el formulario
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            InterfazModificarProveedores ModificarProveedores = new InterfazModificarProveedores();
            this.Hide();
            ModificarProveedores.Show(); // Mostrar el formulario
        }

        private void Boton_BorrarFiltro_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Ocultar la ventana actual
                this.Hide();

                // Crear una instancia de la ventana InterfazMenu
                InterfazMenu ventanaMenu = new InterfazMenu();

                // Mostrar la ventana InterfazMenu
                ventanaMenu.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazMenu InterfazMenu = new InterfazMenu(); // Redirigir al formulario de inicio de sesión (LogIn)
                    InterfazMenu.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}
