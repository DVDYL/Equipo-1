using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazListaClientes : Ventana
    {
        private ClienteNegocio ClienteNegocio = new ClienteNegocio();

        public InterfazListaClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
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

                var bindingList = new BindingList<Cliente>(Cliente);
                var source = new BindingSource(bindingList, null);
                Clientes.DataSource = source;
                Clientes.Columns["id"].Visible = false;
                Clientes.Columns["fechaBaja"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Boton_AltaCliente_Click(object sender, EventArgs e)
        {
            InterfazAltaClientes AltaClientes = new InterfazAltaClientes();
            this.Hide();
            AltaClientes.Show();
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
