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

            string id = iniciarSesion.IniciarSesion(Box_Usuario.Text, Box_Pass.Text); // Almacenar el hash del id de usuario
            string Usuario = Box_Usuario.Text.ToUpper(); // Permitir que la persona ingrese minusculas en el campo "Nombre de usuario"
            string Contraseña = Box_Pass.Text;
            string errorUsuario = Validar.UserLogin(Usuario);
            string errorContraseña = Validar.PassLogin(Contraseña);

            // Validar si se ingresó usuario y contraseña
            if (string.IsNullOrWhiteSpace(Box_Usuario.Text) || string.IsNullOrWhiteSpace(Box_Pass.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin continuar con el inicio de sesión
            }

            // Verificar si el usuario es el administrador
            if (Usuario == UsuarioDefault && Contraseña == ContraseñaDefault)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return; // Salir del método después de permitir el acceso al administrador
            }

            // Verificar si hay errores en el nombre de usuario y contraseña
            if (errorUsuario == null && errorContraseña == null)
            {
                // Acá iría una lógica para buscar al usuario en la lista de usuarios.
                // Si está:
                if (Validar.EsID(id.Substring(1, 36)) == 1)
                {
                    // El hash es válido, permitir el acceso
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (Validar.EsID(id.Substring(1, 36)) == 0)
                {
                    MessageBox.Show("El usuario no existe en el servidor o\n\nEl servidor está caído", "ERROR 102", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Validar.EsID(id.Substring(1, 36)) == 2)
                {
                    // Las credenciales son incorrectas, mostrar mensaje de error
                    MessageBox.Show("Credenciales Incorrectas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    intentosFallidos++;
                }
            }
            else
            {
                // Mostrar mensaje si las credenciales son incorrectas
                MessageBox.Show("Por favor, ingrese un usuario y contraseña válidos.", "Atención!.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir del método sin continuar con el inicio de sesión ni contar errores
            }
        }

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();

            if (intentosFallidos == 3)
            {
                // falta validación para 3 errores + 4to exitoso.
                MessageBox.Show("Se han alcanzado los tres intentos permitidos para iniciar sesión\n\nDe haber un intento fallido más, el usuario será bloqueado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (intentosFallidos == 4)
            {
                MessageBox.Show("El usuario ha sido bloqueado. Contacte al Administrador para reactivarlo nuevamente", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Llamar a un método que pase el usuario a inactivo.
                // ++intentosFallidos al .txt

                Application.Exit();
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