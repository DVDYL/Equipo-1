using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazListaClientes : Ventana
    {
        private ClienteNegocio ClienteNegocio = new ClienteNegocio();

        public InterfazListaClientes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void InterfazListaClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                List<Cliente> Cliente = ClienteNegocio.listarClientes();

                if (Cliente != null)
                {
                    Cliente = Cliente.Where(u => u != null && u.Email != null && u.Email.Contains("@G1")).ToList();
                }

                var bindingList = new BindingList<Cliente>(Cliente);
                var source = new BindingSource(bindingList, null);
                Clientes.DataSource = source;
                Clientes.Columns["id"].Visible = false;
                Clientes.Columns["Host"].Visible = false;
                Clientes.Columns["fechaBaja"].Visible = false;
                Clientes.Columns["fechaAlta"].Visible = false;
                Clientes.Columns["fechaNacimiento"].HeaderText = "Nacimiento";
                Clientes.Columns["Direccion"].HeaderText = "Dirección";
                Clientes.Columns["Telefono"].HeaderText = "Teléfono";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void ClienteLupa_Click(object sender, EventArgs e)
        {
            string textoBusqueda = ClienteBuscador.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarClientes();
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            if (Clientes.DataSource == null || Clientes.Rows.Count == 0) // Verificar si la lista de usuarios es nula o está vacía
            {
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay clientes para buscar.");
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            else
            {
                // Lista para almacenar los usuarios que coinciden con la búsqueda
                List<Cliente> ClientesFiltrados = new List<Cliente>();

                // Recorrer cada fila en el DataGridView Usuarios
                foreach (DataGridViewRow fila in Clientes.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del usuario
                    string nombreProveedor = fila.Cells["Nombre"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de usuario actual
                    if (!string.IsNullOrEmpty(nombreProveedor) && nombreProveedor.ToLower().Contains(textoBusqueda.ToLower()))
                    {
                        // Agregar el usuario a la lista de usuarios filtrados
                        ClientesFiltrados.Add((Cliente)fila.DataBoundItem);
                    }
                }

                if (ClientesFiltrados.Count > 0) // Verificar si se encontraron usuarios que coinciden con la búsqueda
                {
                    // Actualizar el DataSource del DataGridView con los usuarios filtrados
                    var bindingList = new BindingList<Cliente>(ClientesFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Clientes.DataSource = source;
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes que coincidan con la búsqueda.");
                }
            }
        }

        private void LupaDNI_Click(object sender, EventArgs e)
        {
            string textoBusqueda = Box_BuscarDNI.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarClientes();
                Boton_Eliminar.Visible = true;
                Boton_Modificar.Visible = true;
            }

            // Verificar si la lista de Clientes es nula o está vacía
            if (Clientes.DataSource == null || Clientes.Rows.Count == 0)
            {
                // Manejar el caso en el que la lista de Cliente es nula o vacía
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay clientes para buscar.");
                Boton_Eliminar.Visible = true;
            }
            else
            {
                // Lista para almacenar los Cliente que coinciden con la búsqueda
                List<Cliente> ClientesFiltrados = new List<Cliente>();

                // Recorrer cada fila en el DataGridView Cliente
                foreach (DataGridViewRow fila in Clientes.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del usuario
                    string DNI = fila.Cells["DNI"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de usuario actual
                    if (!string.IsNullOrEmpty(DNI) && DNI.Contains(textoBusqueda))
                    {
                        // Agregar el usuario a la lista de Cliente filtrados
                        ClientesFiltrados.Add((Cliente)fila.DataBoundItem);
                    }
                }

                // Verificar si se encontraron Cliente que coinciden con la búsqueda
                if (ClientesFiltrados.Count > 0)
                {
                    // Actualizar el DataSource del DataGridView con los Cliente filtrados
                    var bindingList = new BindingList<Cliente>(ClientesFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Clientes.DataSource = source;
                    Boton_Eliminar.Visible = true;
                    Boton_Modificar.Visible = true;
                }
                else
                {
                    // Mostrar un mensaje si no se encontraron Cliente que coincidan con la búsqueda
                    MessageBox.Show("No se encontraron clientes que coincidan con este DNI.");
                }
            }
        }

        private void Boton_AltaCliente_Click(object sender, EventArgs e)
        {
            InterfazAltaClientes AltaClientes = new InterfazAltaClientes();
            Hide();
            AltaClientes.Show();
        }

        private void BorrarFiltro_Click(object sender, EventArgs e)
        {
            CargarClientes();
            Limpiar();
        }

        private void Limpiar() 
        {
            ClienteBuscador.Text = "";
            Box_BuscarDNI.Text = "";
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void Listado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Boton_Modificar.Visible = true;
            Boton_Eliminar.Visible = true;
        }

        public void Boton_Modificar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (Clientes.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = Clientes.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string idCliente = filaSeleccionada.Cells["id"].Value.ToString(); // Lo voy a reutilizar para el patch y el delete

                string direccion = filaSeleccionada.Cells["Direccion"].Value.ToString();
                string telefono = filaSeleccionada.Cells["Telefono"].Value.ToString();
                string email = filaSeleccionada.Cells["Email"].Value.ToString();

                InterfazModificarClientes modificarClientes = new InterfazModificarClientes(idCliente);
                modificarClientes.ActualizarTextBox(direccion, telefono, email); // Levanto los datos de la lista y me los llevo a otra ventana.

                modificarClientes.Show();
                Hide(); // ocultar la lista de usuarios momentáneamente.
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de hacer clic en Modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarCliente(string idCliente)
        {
            ClienteNegocio BajaCliente = new ClienteNegocio();
            BajaCliente.BorrarCliente(idCliente);
            CargarClientes();
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            if (Clientes.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow filaSeleccionada = Clientes.SelectedRows[0];

                // Obtener los valores de las celdas de la fila seleccionada
                string idCliente = filaSeleccionada.Cells["id"].Value.ToString();

                // Mostrar un cuadro de diálogo de confirmación al usuario
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Está seguro que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    EliminarCliente(idCliente);
                    CargarClientes(); // Insertar acá el código para volver a llamar a la lista de clientes actualizada, así evitamos que se intente modificar algo dado de baja.
                }
                else
                {
                    MessageBox.Show("La eliminación del cliente ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de intentar eliminar.");
            }
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
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

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazMenu InterfazMenu = new InterfazMenu(); // Redirigir al formulario de inicio de sesión (LogIn)
                    InterfazMenu.Show();
                    Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}