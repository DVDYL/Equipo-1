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
            UsuarioNegocio iniciarSesion = new UsuarioNegocio();

            string hash = iniciarSesion.IniciarSesion(Box_Usuario.Text, Box_Pass.Text); // almacenar el hash del id de usuario.
            string Usuario = Box_Usuario.Text;
            string Contraseña = Box_Pass.Text;
            string errorUsuario = Validar.UserLogin(Usuario);
            string errorContraseña = Validar.PassLogin(Contraseña);

            if (Usuario == UsuarioDefault && Contraseña == ContraseñaDefault) // si el usuario es el administrador, iniciar sesión directamente.
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            if (errorUsuario == null || errorContraseña == null) // si la consistencia del nombre de usuario y contraseña son correctos, buscar el id.
            {
                if (string.IsNullOrEmpty(hash)) // si no es usuario, advertirlo?.
                {
                    intentosFallidos++; // esto está raro, puedo no obtener un hash cuando las credenciales son incorrectas, pero a qué usuario bloqueo?
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                intentosFallidos++;
            }
        }

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            // Validar si se ingresó usuario y contraseña
            if (string.IsNullOrWhiteSpace(Box_Usuario.Text) || string.IsNullOrWhiteSpace(Box_Pass.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin continuar con el inicio de sesión
            }

            IniciarSesion();

            if (intentosFallidos == 3)
            {
                MessageBox.Show("Se han alcanzado los tres intentos permitidos para iniciar sesión\n\nDe haber un intento fallido más, el usuario será bloqueado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (intentosFallidos == 4)
            {
                MessageBox.Show("El usuario ha sido bloqueado. Contacte al Administrador para reactivarlo nuevamente", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Llamar a un método que pase el usuario a inactivo.

                this.Close();
            }
        }

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