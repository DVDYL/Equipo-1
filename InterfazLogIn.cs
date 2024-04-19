using System;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class InterfazLogIn : Ventana
    {
        // Definir las credenciales de administrador
        private const string UsuarioPorDefecto = "ADMINI24";
        private const string ContraseñaPorDefecto = "CAI20241";

        // Iniciar el contador de ingresos fallidos en 0.
        private int intentosFallidos = 0;

        public InterfazLogIn() // Función que inicia la ventana de Log In
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }


        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            // Obtener las credenciales ingresadas por el usuario
            string usuarioIngresado = Box_Usuario.Text;
            string contraseñaIngresada = Box_Pass.Text;
            string errorMessage; // Variable para almacenar el mensaje de error de la validación

            // Verificar si el usuario existe y obtener el mensaje de error si no es válido
            bool UsuarioCorrecto = Validar.UsuarioValido(usuarioIngresado, out errorMessage);

            if (UsuarioCorrecto)
            {
                // Verificar si la contraseña ingresada es válida
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
                        MessageBox.Show(errorContraseña + "\n\nCódigo de Error: 001", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Incrementar el contador de intentos fallidos
                        intentosFallidos++;
                    }
                }
                else
                {
                    // Mostrar el mensaje de error devuelto por ContraseñaValida
                    MessageBox.Show(errorContraseña, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Incrementar el contador de intentos fallidos
                    intentosFallidos++;

                    // Si el usuario ha excedido el límite de intentos fallidos, bloquearlo
                    if (intentosFallidos == 3) //Habria que armar una funcion que resuleva esta logica.
                    {
                        MessageBox.Show("El usuario ha sido bloqueado. Contacte al Administrador para reactivarlo nuevamente", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Queda pendiente agregar que se inactivo el usuario. Pasa a estado INACTIVO

                        this.Close();
                        // Se cierra la Pantalla de Login
                    }
                    else
                    {
                        MessageBox.Show("Le quedan " + (3 - intentosFallidos) + " intentos posibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                // El usuario no existe, mostrar el mensaje de error obtenido de UsuarioValido
                MessageBox.Show(errorMessage, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        } // Valida las credenciales de usuario

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
            Box_Pass.UseSystemPasswordChar = true; 
        } // Oculta la contraseña al hacer click en el ojo

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir del programa?\n\nSe cerrará la ventana y no se guardarán los datos.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
                {
                    this.Close();                 // Si el usuario selecciona "Sí", cierra el formulario
                }
            }
        }  // Evento KeyDown para cerrar la ventana con la tecla ESC
    }
}