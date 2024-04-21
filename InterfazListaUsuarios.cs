using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Datos;
using Negocio;


namespace Presentacion
{
    public partial class InterfazListaUsuarios : Ventana
    {
        private ClienteNegocio ClienteNegocio = new ClienteNegocio();

        public InterfazListaUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
        }

        private void InterfazListaUsuarios_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                List<Cliente> clientes = ClienteNegocio.listarClientes();

                var bindingList = new BindingList<Cliente>(clientes);
                var source = new BindingSource(bindingList, null);
                Usuarios.DataSource = source;
                Usuarios.Columns["id"].Visible = false;
                Usuarios.Columns["fechaBaja"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void Boton_AltaUsuario_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario InterfazAltaUsuarios
            InterfazAltaUsuarios formInterfazAltaUsuarios = new InterfazAltaUsuarios();

            // Ocultar el formulario actual (InterfazListaUsuarios)
            this.Hide();

            // Mostrar el formulario
            formInterfazAltaUsuarios.Show();
        } // Evento cuando se hace clic en el Botón "+ Nuevo"

        private void CheckActivo_CheckedChanged(object sender, EventArgs e) // Detecta cambios en el check "De Baja" 
        {
            // Establecer que el usuario se pase a inactivo cuando se tilde esta opción
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
    }
}