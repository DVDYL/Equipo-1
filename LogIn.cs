using System;
using System.Windows.Forms;

namespace Form_Equipo1
{
    public partial class LogIn : Form
    {
        // Definir las credenciales del usuario por defecto
        private const string UsuarioPorDefecto = "ELECTROADMIN24";
        private const string ContraseñaPorDefecto = "CAI20241";

        public LogIn()
        {
            InitializeComponent();
        } // Función que inicia la ventana de Log In

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            // Obtener las credenciales ingresadas por el usuario
            string usuarioIngresado = Usuario.Text;
            string contraseñaIngresada = Pass.Text;

            // Verificar si las credenciales coinciden con el usuario por defecto
            if (usuarioIngresado == UsuarioPorDefecto && contraseñaIngresada == ContraseñaPorDefecto)
            {
                // Si las credenciales son correctas, establecer DialogResult.OK
                this.DialogResult = DialogResult.OK;
                // Cerrar el formulario de inicio de sesión
                this.Close();
            }

            else
            {
                // Si las credenciales son incorrectas, mostrar un mensaje de error
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // Verifica el usuario y contraseña e ingresa al menú principal

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
            {
                this.Close();                 // Si el usuario selecciona "Sí", cierra el formulario
            }
        } // Pide confirmar la cancelación y si se acepta, sale del programa.

        private void PassViewImg_MouseDown(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = false; // Muestra la contraseña
        }

        private void PassViewImg_MouseUp(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = true; // Oculta la contraseña
        }
    }
}