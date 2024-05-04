using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using Negocio;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Collections.Generic;
using Datos;

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
            string errorUsuario = Validar.CampoEnBlanco(Usuario);
            string errorContraseña = Validar.CampoEnBlanco(Contraseña);

            if (errorUsuario == "1") // Verificar si hay errores en el nombre de usuario y contraseña
            {
                MessageBox.Show("No se ingresó el usuario.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir del método sin continuar con el inicio de sesión ni contar errores
            }

            if (errorContraseña == "1") // Verificar si hay errores en el nombre de usuario y contraseña
            {
                MessageBox.Show("No se ingresó la contraseña.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir del método sin continuar con el inicio de sesión ni contar errores
            }

            if (Usuario == UsuarioDefault && Contraseña == ContraseñaDefault)
            {
                Host = Validar.NumeroHost(Usuario); // capturo el host para usarlo en el menú.
                this.DialogResult = DialogResult.OK;
                this.Close();
                return; // Salir del método después de permitir el acceso al administrador
            }

            if (Validar.EsID(id.Substring(1, 36)) == 0)
            {
                MessageBox.Show("El usuario no existe en el servidor o\n\nEl servidor está caído", "ERROR 101", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Validar.EsID(id.Substring(1, 36)) == 2) //Hay que llamar a esto solamente cuando la contraseña está mal, pero el usuario existe
            {
                MessageBox.Show("Credenciales Incorrectas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarTXT(Usuario); 
            }

            if (Validar.EsID(id.Substring(1, 36)) == 1) // El hash es válido, permitir el acceso
            {
                ResetearIntentosFallidos(Usuario); // volver el contador de errores a 0.
                if (Usuario == Contraseña)
                {
                    Box_Usuario.Enabled = false;
                    Box_Pass.Enabled = false;
                    NewPass.Visible = true;
                    NewPass.Enabled = true;
                    ConfirmNewPass.Visible = true;
                    ConfirmNewPass.Enabled = true;
                    Label_NewPass.Visible = true;
                    Label_NewPass.Enabled = true;
                    Label_ConfirmNewPass.Visible = true;
                    Label_ConfirmNewPass.Enabled = true;
                    Boton_Ingresar.Visible = false;
                    CambiarClave.Visible = true;
                    PassViewImg.Enabled = false;

                    MessageBox.Show("Por favor, ingrese una nueva contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else if(Validar.ContraseñaExpirada(Usuario))     //Valido si la contraseña expiró
                {
                    MessageBox.Show("La contraseña expiró. Debe cambiarla antes de continuar.", "Contraseña Expirada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Box_Usuario.Enabled = false;
                    Box_Pass.Enabled = false;
                    NewPass.Visible = true;
                    NewPass.Enabled = true;
                    ConfirmNewPass.Visible = true;
                    ConfirmNewPass.Enabled = true;
                    Label_NewPass.Visible = true;
                    Label_NewPass.Enabled = true;
                    Label_ConfirmNewPass.Visible = true;
                    Label_ConfirmNewPass.Enabled = true;
                    Boton_Ingresar.Visible = false;
                    CambiarClave.Visible = true;
                    PassViewImg.Enabled = false;
                }
                else
                {
                    Host = Validar.NumeroHost(Usuario); // Guardar el número de host del usuario


                    this.DialogResult = DialogResult.OK;
                    this.Hide(); // cerrar el login.
                }
            }
        }

        private void CargarTXT(string Usuario)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            List<UsuariosActivos> listaUsuarios = negocio.ListarUsuarios();

            // Filtrar usuarios cuyo NombreUsuario empiece por "G1"
            listaUsuarios = listaUsuarios.Where(u => u.NombreUsuario.StartsWith("G1")).ToList();

            UsuariosActivos usuarioEncontrado = listaUsuarios.Find(u => u.NombreUsuario == Usuario);

            if (usuarioEncontrado != null)
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
        }

        private void ResetearIntentosFallidos(string Usuario)
        {
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
                    SetearSession(Usuario);
                }
                else
                {
                    string[] lineasTXT = File.ReadAllLines(path);
                    bool ExisteUsuario = false;

                    for (int i = 0; i < lineasTXT.Length; i++)
                    {
                        if (lineasTXT[i].StartsWith(Usuario + ";"))
                        {
                            string[] parametros = lineasTXT[i].Split(';');
                            lineasTXT[i] = Usuario + ";" + "0" + ";" + parametros[2]; //Actualizo el valor de intentos fallidos a 0

                            SetearSession(Usuario);

                            ExisteUsuario = true;

                            break;
                        }
                    }

                    if (!ExisteUsuario)
                    {
                        string[] nuevaLinea = {Usuario + ";0;"};
                        List<string> lineasLista = lineasTXT.ToList();
                        lineasLista.AddRange(nuevaLinea);
                        lineasTXT = lineasLista.ToArray();

                        SetearSession(Usuario);
                    }

                    File.WriteAllLines(path, lineasTXT);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        } // No está usando el host del método de validar?

        private void SetearSession(string NombreUsuario)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            List<UsuariosActivos> listaUsuarios = negocio.ListarUsuarios();
            listaUsuarios = listaUsuarios.Where(u => u.NombreUsuario.StartsWith("G1")).ToList();
            UsuariosActivos usuario = listaUsuarios.FirstOrDefault(u => u.NombreUsuario == NombreUsuario);

            if (usuario != null)
            {
                //this.Tag = new SessionData { Usuario = NombreUsuario, Host = usuario.Host};
            }
        } // Ya se captura el hash desde la clase validar. Eliminar método? si

        private void Boton_Ingresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void CambiarClave_Click(object sender, EventArgs e)
        {
            string usuario = Box_Usuario.Text;
            string contraseña = Box_Pass.Text;
            string nuevaContraseña = NewPass.Text;
            string confirmacionContraseña = ConfirmNewPass.Text;

            string errorNuevaContraseña = Validar.ConfirmarContraseña(nuevaContraseña, confirmacionContraseña);
            if (errorNuevaContraseña != null)
            {
                MessageBox.Show(errorNuevaContraseña, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                errorNuevaContraseña = Validar.EsContraseña(nuevaContraseña);
                if (errorNuevaContraseña != null)
                {
                    MessageBox.Show(errorNuevaContraseña, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (contraseña == nuevaContraseña)
                {
                    MessageBox.Show("La contraseña no puede ser igual a la actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        UsuarioNegocio negocio = new UsuarioNegocio();
                        negocio.CambiarContraseña(usuario, contraseña, nuevaContraseña);
                        Host = Validar.NumeroHost(usuario);
                        MessageBox.Show("Contraseña actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarFechaTXT(usuario);
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cambiar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
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
        private void ActualizarFechaTXT(string usuario) //Acá va a cargar la fecha de cambio de contraseña
        {
            string nombreArchivo = "Usuarios.txt";
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string path = Path.Combine(directorio, nombreArchivo);

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
                string[] lineasTXT = File.ReadAllLines(path);
            for (int i = 0; i < lineasTXT.Length; i++)
            {
                if (lineasTXT[i].StartsWith(usuario + ";"))
                {
                    string[] parametros = lineasTXT[i].Split(';');
                    lineasTXT[i] = usuario + ";" + parametros[1] + ";" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    File.WriteAllLines(path, lineasTXT);
                    break;
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(path))
                    {
                        writer.WriteLine(usuario + ";0;" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                }
            }
        }

    }
}





/*private bool primerLogin = true; // Variable para controlar si es el primer inicio de sesión

private void Boton_Ingresar_Click(object sender, EventArgs e)
{
    if (primerLogin)
    {
        // Si es el primer inicio de sesión, realizamos el cambio de clave
        string usuario = Box_Usuario.Text;
        string contraseña = Box_Pass.Text;
        string nuevaContraseña = NewPass.Text;
        string confirmacionContraseña = ConfirmNewPass.Text;

        if (nuevaContraseña != confirmacionContraseña)
        {
            MessageBox.Show("La nueva contraseña y la confirmación no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string errorNuevaContraseña = Validar.EsContraseña(nuevaContraseña);
        if (errorNuevaContraseña != null)
        {
            MessageBox.Show(errorNuevaContraseña, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            negocio.CambiarContraseña(usuario, contraseña, nuevaContraseña);
            Host = Validar.NumeroHost(usuario);

            // Cambiamos el texto del botón y la bandera primerLogin
            Boton_Ingresar.Text = "Iniciar Sesión";
            primerLogin = false;

            MessageBox.Show("Contraseña cambiada correctamente. Por favor, inicie sesión con su nueva contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cambiar la contraseña: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    else
    {
        // Si no es el primer inicio de sesión, simplemente iniciamos sesión
        IniciarSesion();
    }
}*/