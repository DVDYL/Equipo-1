using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class InterfazLogIn : Ventana
    {
        // Definir las credenciales de administrador
        private const string UsuarioDefault = "ADMINI24";
        private const string ContraseñaDefault = "CAI20241";

        // Iniciar el contador de ingresos fallidos en 0.
        private int intentosFallidos = 0;

        public InterfazLogIn() // Función que inicia la ventana de Log In
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        public void IniciarSesion()
        {
            UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
            UsuarioNegocio.IniciarSesion(Box_Usuario.Text, Box_Usuario.Text);

            MessageBox.Show("Número de hash:", "Este es tu Hash", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            // Obtener las credenciales ingresadas por el usuario
            string Usuario = Box_Usuario.Text;
            string Contraseña = Box_Pass.Text;
            string errorUsuario = Validar.UserLogin(Usuario);
            string errorContraseña = Validar.PassLogin(Contraseña);

            // Verificar primero si el usuario es el administrador
            if (Usuario == UsuarioDefault && Contraseña == ContraseñaDefault)
            {
                this.DialogResult = DialogResult.OK; // Si las credenciales son del administrador, ingresar directamente.
                this.Close(); // Cerrar el formulario de inicio de sesión
            }
            else
            {

                if (errorContraseña == null || errorUsuario == null)
                {
                    IniciarSesion();
                }
                else
                {
                    MessageBox.Show(errorContraseña, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Incrementar el contador de intentos fallidos
                    intentosFallidos++;

                    // Si el usuario ha excedido el límite de intentos fallidos, bloquearlo
                    if (intentosFallidos == 4) //Habria que armar una funcion que resuleva esta logica.
                    {
                        MessageBox.Show("El usuario ha sido bloqueado. Contacte al Administrador para reactivarlo nuevamente", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Queda pendiente agregar que se inactivo el usuario. Pasa a estado INACTIVO

                        this.Close();
                        // Se cierra la Pantalla de Login
                    }
                    else
                    {
                        if (intentosFallidos == 3)
                        {
                            MessageBox.Show("Le queda un intento para iniciar sesion, sino su usuario sera bloqueado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        } // Tomar de este método el contador de errores


        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?\n\nSe cerrará la ventana y no se guardarán los datos.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
            {
                Application.Exit();               // Si el usuario selecciona "Sí", cierra el formulario
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