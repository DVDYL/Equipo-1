using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class InterfazMenu : Ventana
    {
        public InterfazMenu() // Inicializa el menú de navegación 
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        } 

        private void UsuariosIcono_Click(object sender, EventArgs e)  
        {
            InterfazListaUsuarios InterfazListaUsuarios = new InterfazListaUsuarios(); // Crear una instancia del formulario InterfazABM

            this.Hide(); // Ocultar el formulario Menu

            InterfazListaUsuarios.FormClosed += (s, args) => this.Close(); // Cerrar la aplicación cuando se cierre UserAdmin
            InterfazListaUsuarios.Show(); // Mostrar el formulario InterfazABM
        }

        private void ProveedoresIcono_Click(object sender, EventArgs e)
        {
            InterfazListaProveedores ListaProveedores = new InterfazListaProveedores(); // Crear una instancia del formulario InterfazABM

            this.Hide(); // Ocultar el formulario Menu

            ListaProveedores.FormClosed += (s, args) => this.Close(); // Cerrar la aplicación cuando se cierre UserAdmin
            ListaProveedores.Show(); // Mostrar el formulario InterfazABM
        }

        private void ClientesIcono_Click(object sender, EventArgs e)
        {
            InterfazListaClientes ListaClientes = new InterfazListaClientes();
            this.Hide(); // Ocultar el formulario actual
            ListaClientes.FormClosed += (s, args) => this.Close();
            ListaClientes.Show();
        }

        private void ProductosIcono_Click(object sender, EventArgs e)
        {
            InterfazListaProductos ListaProductos = new InterfazListaProductos();
            this.Hide(); // Ocultar el formulario actual
            ListaProductos.FormClosed += (s, args) => this.Close();
            ListaProductos.Show();
        }

        private void VentasIcono_Click(object sender, EventArgs e)
        {
            InterfazVentas ListaVentas = new InterfazVentas();
            this.Hide(); // Ocultar el formulario actual
            ListaVentas.FormClosed += (s, args) => this.Close();
            ListaVentas.Show();
        }

        private void ReportesIcono_Click(object sender, EventArgs e)
        {
            InterfazReportes ListaReportes = new InterfazReportes();
            this.Hide(); // Ocultar el formulario actual
            ListaReportes.FormClosed += (s, args) => this.Close();
            ListaReportes.Show();
        }

        private void BotonSalir_Click(object sender, EventArgs e) // Le pregunta al usuario si está seguro de que quiere cerrar la sesión 
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al inicio de sesión?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
            {
                InterfazLogIn LogIn = new InterfazLogIn(); // Redirigir al formulario de inicio de sesión (LogIn)
                LogIn.Show();
                this.Hide(); // Ocultar el formulario actual
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al inicio de sesión?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazLogIn LogIn = new InterfazLogIn(); // Redirigir al formulario de inicio de sesión (LogIn)
                    LogIn.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}