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
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
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

                if (Proveedor != null)
                {
                    Proveedor = Proveedor.Where(u => u != null && u.Email != null && u.Email.Contains("@G1")).ToList();
                }

                var bindingList = new BindingList<TraerProveedores>(Proveedor);
                var source = new BindingSource(bindingList, null);
                Proveedores.DataSource = source;
                Proveedores.Columns["ID"].Visible = false;
                Proveedores.Columns["fechaBaja"].Visible = false;
                Proveedores.Columns["fechaAlta"].HeaderText = "Fecha de Alta";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Proveedores: " + ex.Message);
            }
        }

        private void Listado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Boton_Modificar.Visible = true;
            Boton_Eliminar.Visible = true;
        }

        private void ProveedoresLupa_Click(object sender, EventArgs e)
        {
            string textoBusqueda = ProveedoresBuscador.Text; // Obtener el texto ingresado en el TextBox UsuariosBuscador

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProveedores();
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            // Verificar si la lista de usuarios es nula o está vacía
            if (Proveedores.DataSource == null || Proveedores.Rows.Count == 0)
            {
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay usuarios para buscar.");
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
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
                    if (!string.IsNullOrEmpty(nombreProveedor) && nombreProveedor.ToLower().Contains(textoBusqueda.ToLower()))
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
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.");
                }
            }
        }

        private void CUITLupa_Click(object sender, EventArgs e)
        {
            string textoBusqueda = CUITBuscador.Text; // Obtener el texto ingresado en el TextBox UsuariosBuscador

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
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron usuarios que coincidan con la búsqueda.");
                    Boton_Modificar.Visible = false;
                    Boton_Eliminar.Visible = false;
                }
            }
        }

        private void Limpiar() // Blanquea campos de búsqueda
        {
            ProveedoresBuscador.Text = "";
            CUITBuscador.Text = "";
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void Boton_BorrarFiltro_Click(object sender, EventArgs e)
        {
            CargarProveedores();
            Limpiar();
        }

        private void BotonAltaProveedores_Click(object sender, EventArgs e)
        {
            InterfazAltaProveedores AltaProveedores = new InterfazAltaProveedores();
            Hide();
            AltaProveedores.Show();
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (Proveedores.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = Proveedores.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string idProveedor = filaSeleccionada.Cells["id"].Value.ToString(); // Lo voy a reutilizar para el patch y el delete
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();
                string CUIT = filaSeleccionada.Cells["CUIT"].Value.ToString();

                InterfazModificarProveedores ModificarProveedores = new InterfazModificarProveedores(idProveedor);
                ModificarProveedores.ActualizarTextBox(nombre, apellido, email, CUIT); // Levanto los datos de la lista y me los llevo a otra ventana.

                Hide();
                ModificarProveedores.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de hacer clic en Modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarProveedor(string idProveedor)
        {
            ProveedorNegocio BajaProveedor = new ProveedorNegocio();
            BajaProveedor.BorrarProveedor(idProveedor);
            CargarProveedores();
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            if (Proveedores.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = Proveedores.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string idProveedor = filaSeleccionada.Cells["id"].Value.ToString();

                // Mostrar un cuadro de diálogo de confirmación al usuario
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Está seguro que desea eliminar este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    EliminarProveedor(idProveedor);
                    // CargarProveedores();
                    // Insertar acá el código para volver a llamar a la lista de Proveedores actualizada, así evitamos que se intente modificar algo dado de baja.
                }
                else
                {
                    MessageBox.Show("La eliminación del proveedor ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void Ventana_KeyDown(object sender, KeyEventArgs e) 
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
