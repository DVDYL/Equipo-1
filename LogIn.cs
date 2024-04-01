using Equipo1;
using System;
using System.Windows.Forms;

namespace Form_Equipo1
{
    public partial class LogIn : Form
    {
        // Definir las credenciales de administrador
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

            // Verificar si el usuario existe
            bool usuarioExiste = Validar.EsUsuario(usuarioIngresado);

            if (usuarioExiste)
            {
                // Verificar si la contraseña ingresada es válida
                bool contraseñaValida = Validar.EsContraseñaValida(contraseñaIngresada);

                if (contraseñaValida)
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
                        MessageBox.Show("La contraseña ingresada para el usuario no es la correcta.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // La contraseña ingresada no es válida
                    MessageBox.Show("La Contraseña ingresada es inválida.\n\nUna contraseña válida contiene al menos una mayúscula, un número y tiene como mínimo 8 caracteres.\n\nPor favor, ingrese una Contraseña válida.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // El usuario no existe
                MessageBox.Show("El Usuario no Existe", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // Controla que el usuario exista y que la contraseña sea válida.

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
            {
                this.Close();                 // Si el usuario selecciona "Sí", cierra el formulario
            }
        } // Pide confirmar la cancelación y si se acepta, sale del programa.

        private void PassViewImg_MouseDown(object sender, MouseEventArgs e) // Muestra la contraseña al hacer click en el ojo
        {
            Pass.UseSystemPasswordChar = false; 
        }

        private void PassViewImg_MouseUp(object sender, MouseEventArgs e)
        {
            Pass.UseSystemPasswordChar = true; // Oculta la contraseña
        } // Muestra la contraseña al hacer click en el ojo
    }
}