using Equipo1;
using System;
using System.Windows.Forms;

namespace Form_Equipo1
{
    public partial class LogIn : FormBase
    {
        // Definir las credenciales de administrador
        private const string UsuarioPorDefecto = "ADMINI24";
        private const string ContraseñaPorDefecto = "CAI20241";

        public LogIn()
        {
            InitializeComponent();
            TituloBarra = "LogIn"; // Establezco nombre que irá en el título de la barra
        } // Función que inicia la ventana de Log In

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            // Obtener las credenciales ingresadas por el usuario
            string usuarioIngresado = Box_Usuario.Text;
            string contraseñaIngresada = Box_Pass.Text;
            string errorMessage; // Variable para almacenar el mensaje de error de la validación

            // Verificar si el usuario existe y obtener el mensaje de error si no es válido
            //bool usuarioExiste = Validar.EsUsuario(usuarioIngresado, out errorMessage);
            //comentado para que no revele información de la seguridad en el login. Cambio la validación solamente
            //a un bien/mal.
            bool UsuarioCorrecto = Validar.UsuarioValido(usuarioIngresado, out errorMessage);
                
            if (UsuarioCorrecto)
            {
                // Verificar si la contraseña ingresada es válida
                //string errorContraseña = Validar.EsContraseña(contraseñaIngresada);
                //comentado para que no revele información de la seguridad en el login. Cambio la validación solamente
                //a un bien/mal.
                string errorContraseña = Validar.ContraseñaValida(contraseñaIngresada);

                if (errorContraseña == null)
                {
                    // Verificar si el usuario es el administrador
                    if (usuarioIngresado == UsuarioPorDefecto && contraseñaIngresada == ContraseñaPorDefecto)
                    {
                        // Si las credenciales son correctas, establecer DialogResult.OK
                        this.DialogResult = DialogResult.OK;
                        // Cerrar el formulario de inicio de sesión
                        this.Close();
                    }
                    else
                    {
                        // El usuario existe pero la contraseña no es la correcta
                        MessageBox.Show( errorContraseña + "\n\nCódigo de Error: 001", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Mostrar el mensaje de error devuelto por EsContraseña
                    MessageBox.Show(errorContraseña, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // El usuario no existe, mostrar el mensaje de error obtenido de EsUsuario
                MessageBox.Show(errorMessage, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?\n\nSe cerrará la ventana y no se guardarán los datos.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
            {
                this.Close();                 // Si el usuario selecciona "Sí", cierra el formulario
            }
        } // Pide confirmar la cancelación y si se acepta, sale del programa.

        private void PassViewImg_MouseDown(object sender, MouseEventArgs e) // Muestra la contraseña al hacer click en el ojo
        {
            Box_Pass.UseSystemPasswordChar = false; 
        }

        private void PassViewImg_MouseUp(object sender, MouseEventArgs e)
        {
            Box_Pass.UseSystemPasswordChar = true; // Oculta la contraseña
        } // Muestra la contraseña al hacer click en el ojo

        private void Box_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecuperaPass_Click(object sender, EventArgs e)
        {

        }
    }
}