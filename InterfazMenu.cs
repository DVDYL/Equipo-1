using System;
using System.Windows.Forms;

namespace Equipo1
{
    public partial class InterfazMenu : FormBase
    {
        public InterfazMenu()
        {
            InitializeComponent();
            TituloBarra = "Menú";
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        } // Inicializa el menú de navegación.

        private void MenuUserAdmin_Click(object sender, EventArgs e) // Si hago click en "usuarios", entro al ABM de Usuarios 
        {
            // Ocultar el formulario Menu
            this.Hide();

            // Crear una instancia del formulario InterfazABM
            InterfazABM userAdminForm = new InterfazABM();

            // Mostrar el formulario InterfazABM
            userAdminForm.FormClosed += (s, args) => this.Show(); // Mostrar nuevamente el formulario Menu cuando se cierre UserAdmin
            userAdminForm.Show();
        }

        private void UserAdminImg_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario InterfazABM
            InterfazABM userAdminForm = new InterfazABM();

            // Ocultar el formulario actual (Menu)
            this.Hide();

            // Mostrar el formulario InterfazABM
            userAdminForm.FormClosed += (s, args) => this.Close(); // Cerrar la aplicación cuando se cierre UserAdmin
            userAdminForm.Show();
        }

        private void MenuLogOut_Click(object sender, EventArgs e) // Le pregunta al usuario si está seguro de que quiere cerrar la sesión
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al inicio de sesión?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
            {
                InterfazLogIn loginForm = new InterfazLogIn(); // Redirigir al formulario de inicio de sesión (LogIn)
                loginForm.Show();
                this.Hide(); // Ocultar el formulario actual
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al inicio de sesión?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazLogIn loginForm = new InterfazLogIn(); // Redirigir al formulario de inicio de sesión (LogIn)
                    loginForm.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        } // Manejo para el evento de apretar ESC en una ventana.
    }
}
