using Equipo1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Equipo1
{
    public partial class Menu : FormBase
    {
        public Menu()
        {
            InitializeComponent();
            TituloBarra = "Menú";
        }

        private void MenuUserAdmin_Click(object sender, EventArgs e) // Si hago click en la el nombre "usuarios", entro al ABM de Usuarios 
        {
            // Ocultar el formulario Menu
            this.Hide();

            // Crear una instancia del formulario UserAdmin
            UserAdmin userAdminForm = new UserAdmin();

            // Mostrar el formulario UserAdmin
            userAdminForm.FormClosed += (s, args) => this.Show(); // Mostrar nuevamente el formulario Menu cuando se cierre UserAdmin
            userAdminForm.Show();
        } 

        private void UserAdminImg_Click(object sender, EventArgs e) // Si hago click en la imagen de usuarios, entro al ABM de Usuarios
        {
            // Ocultar el formulario Menu
            this.Hide();

            // Crear una instancia del formulario UserAdmin
            UserAdmin userAdminForm = new UserAdmin();

            // Mostrar el formulario UserAdmin
            userAdminForm.FormClosed += (s, args) => this.Show(); // Mostrar nuevamente el formulario Menu cuando se cierre UserAdmin
            userAdminForm.Show();
        } 

        private void MenuLogOut_Click(object sender, EventArgs e) // Le pregunta al usuario si está seguro de que quiere cerrar la sesión
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al inicio de sesión?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cerrar la sesión
                // Aquí puedes agregar cualquier lógica necesaria para cerrar la sesión, como restablecer las variables de sesión, etc.

                // Por ejemplo, podrías borrar los datos de sesión o redirigir al formulario de inicio de sesión

                // Redirigir al formulario de inicio de sesión (LogIn)
                LogIn loginForm = new LogIn();
                loginForm.Show();
                this.Hide(); // Ocultar el formulario actual
            }
            // Si el usuario elige "No", no hacer nada
        }


    }
}
