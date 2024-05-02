using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using Negocio;
using System.Drawing.Drawing2D;
using System.Linq;

namespace Presentacion
{
    public partial class InterfazLogIn : Ventana
    {
        // Variable miembro para almacenar el número de host del usuario
        public string Host { get; set; }

        public static InterfazLogIn Instancia { get; private set; }

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
            Instancia = this;
        }

        public void IniciarSesion()
        {
            UsuarioNegocio iniciarSesion = new UsuarioNegocio();

            string id = iniciarSesion.IniciarSesion(Box_Usuario.Text, Box_Pass.Text); // Almacenar el hash del id de usuario
            string Usuario = Box_Usuario.Text.ToUpper(); // Permitir que la persona ingrese minusculas en el campo "Nombre de usuario"
            string Contraseña = Box_Pass.Text;
            string errorUsuario = null;// Validar.UserLogin(Usuario);
            string errorContraseña = null;// Validar.PassLogin(Contraseña);




            // Validar si se ingresó usuario y contraseña
            if (string.IsNullOrWhiteSpace(Box_Usuario.Text) || string.IsNullOrWhiteSpace(Box_Pass.Text))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin continuar con el inicio de sesión
            }

            // Verificar si el usuario es el administrador
            if (Usuario == UsuarioDefault && Contraseña == ContraseñaDefault)
            {
                Host = Validar.NumeroHost(Usuario);
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
                    // Guardar el número de host del usuario
                    Host = Validar.NumeroHost(Usuario);
                    ResetearIntentosFallidos(Usuario);
                    // El hash es válido, permitir el acceso
                    this.DialogResult = DialogResult.OK;
                    this.Hide();                
                }
                else if (Validar.EsID(id.Substring(1, 36)) == 0)
                {
                    MessageBox.Show("El usuario no existe en el servidor o\n\nEl servidor está caído", "ERROR 102", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Validar.EsID(id.Substring(1, 36)) == 2)
                {
                    // Las credenciales son incorrectas, mostrar mensaje de error
                    MessageBox.Show("Credenciales Incorrectas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarTXT(Usuario);
                    //Hay que llamar a esto solamente cuando la contraseña está mal, pero el usuario existe
                }
            }
            else
            {
                // Mostrar mensaje si las credenciales son incorrectas
                MessageBox.Show("Por favor, ingrese un usuario y contraseña válidos.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir del método sin continuar con el inicio de sesión ni contar errores
            }
        }

        private void CargarTXT(string Usuario)
        {
            //Cargo la ruta del TXT
            string nombreArchivo = "Usuarios.txt";
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string path = Path.Combine(directorio, nombreArchivo);
            try
            {
                if (!Directory.Exists(directorio))  //Crea las carpetas si no existen
                {
                    Directory.CreateDirectory(directorio);
                }
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, Usuario + ";1" + Environment.NewLine);
                }
                else
                {
                    string[] lineasTXT = File.ReadAllLines(path);
                    bool UsuarioExiste = lineasTXT.Any(linea => linea.StartsWith(Usuario + ";"));


                    if (!UsuarioExiste)
                    {
                        using (StreamWriter writer = File.AppendText(path))
                        {
                            writer.WriteLine(Usuario + ";1;");   //Si llega acá es porque ya falló un intento.
                        }
                    }
                    else
                    {
                        // Si existe tenemos que editarlo
                        int indexUsuario = -1;
                        for (int i = 0; i < lineasTXT.Length; i++) //Acá ubico el index en el array del usuario que está ingresando
                        {
                            if (lineasTXT[i].StartsWith(Usuario + ";"))
                            {
                                indexUsuario = i;
                                break;
                            }
                        }

                        if (indexUsuario != -1)
                        {
                            string[] parametros = lineasTXT[indexUsuario].Split(';');
                            int intentos = int.Parse(parametros[1]);
                            intentos++;
                            // Mantener la fecha del último cambio de contraseña
                            string fechaUltimoCambio = parametros.Length > 2 ? parametros[2] : ""; //Esto es un condicional. Si existe parametro 2 lo pone. si no existe pone vacío

                            lineasTXT[indexUsuario] = Usuario + ";" + intentos.ToString() + ";" + fechaUltimoCambio;

                            File.WriteAllLines(path, lineasTXT);

                            if (intentos == 3)
                            {
                                // falta validación para 3 errores + 4to exitoso.
                                MessageBox.Show("Se han alcanzado los tres intentos permitidos para iniciar sesión.\n\nDe haber un intento fallido más, el usuario será bloqueado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (intentos >= 4)
                            {
                                MessageBox.Show("El usuario ha sido bloqueado. Contacte al Administrador del Sistema para reactivarlo nuevamente", "Usuario Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                // Llamar a un método que pase el usuario a inactivo.

                                Application.Exit();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ResetearIntentosFallidos(string Usuario)
        {
            Console.WriteLine("Reseteando intentos fallidos para el usuario: " + Usuario); // Mensaje de depuración
            string nombreArchivo = "Usuarios.txt";
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string path = Path.Combine(directorio, nombreArchivo);
            try
            {
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                if (!File.Exists(path))
                {
                    // Si el archivo no existe, lo creamos y escribimos la información del usuario actual
                    File.WriteAllText(path, Usuario + ";0;");
                }
                else
                {
                    string[] lineasTXT = File.ReadAllLines(path);
                    for (int i = 0; i < lineasTXT.Length; i++)
                    {
                        if (lineasTXT[i].StartsWith(Usuario + ";"))
                        {
                            string[] parametros = lineasTXT[i].Split(';');
                            lineasTXT[i] = Usuario + ";" + parametros[1] + ";" + parametros[2];
                            break;
                        }
                    }
                    File.WriteAllLines(path, lineasTXT);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();


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