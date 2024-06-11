using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class InterfazMenu : Ventana
    {
        public InterfazMenu() // Inicializa el menú de navegación 
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        private void UsuariosIcono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if (interfazLogIn.Host == "3")
            {
                InterfazListaUsuarios InterfazListaUsuarios = new InterfazListaUsuarios(); 

                Hide(); 

                InterfazListaUsuarios.FormClosed += (s, args) => Close(); 
                InterfazListaUsuarios.Show(); 
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Usuarios", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ProveedoresIcono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if ( interfazLogIn.Host == "3")
            {
                Hide(); 

                InterfazListaProveedores ListaProveedores = new InterfazListaProveedores(); 

                ListaProveedores.FormClosed += (s, args) => Close(); 
                ListaProveedores.Show(); 
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Proveedores", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClientesIcono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if (interfazLogIn.Host == "3") 
            {
                InterfazListaClientes ListaClientes = new InterfazListaClientes();
                Hide();
                ListaClientes.FormClosed += (s, args) => Close();
                ListaClientes.Show();
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Clientes", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ProductosIcono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if (interfazLogIn.Host == "2" || interfazLogIn.Host == "3")
            {
                InterfazListaProductos ListaProductos = new InterfazListaProductos();
                Hide();
                ListaProductos.FormClosed += (s, args) => Close();
                ListaProductos.Show();
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Productos", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VentasIcono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if (interfazLogIn.Host == "1" || interfazLogIn.Host == "2" || interfazLogIn.Host == "3") // SACAR EL 3 PARA LA ENTREGA FINAL
            {
                InterfazVentasMenu MenuVentas = new InterfazVentasMenu();
                Hide();
                MenuVentas.FormClosed += (s, args) => Close();
                MenuVentas.Show();
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Ventas", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ReportesIcono_Click(object sender, EventArgs e)
        {
            InterfazRepoMenu MenuReportes = new InterfazRepoMenu();
            Hide(); // Ocultar el formulario actual
            MenuReportes.FormClosed += (s, args) => Close();
            MenuReportes.Show();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea volver al inicio de sesión?\n\nSe cerrará la sesión actual.", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
            {
                InterfazLogIn LogIn = new InterfazLogIn(); // Redirigir al LogIn
                LogIn.Show();
                Hide();
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Desea volver al inicio de sesión?\n\nSe cerrará la sesión actual.", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazLogIn LogIn = new InterfazLogIn();
                    LogIn.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}