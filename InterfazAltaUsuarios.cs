using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class InterfazAltaUsuarios : Ventana
    {
        public InterfazAltaUsuarios() // Esta Función prepara el formulario y sus restricciones
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            Rol_Null.Visible = false; // Ocultar el TextBox Rol_Null

            // Establecer el formato de visualización predeterminado para la fecha de nacimiento
            Calendario_Nacimiento.Format = DateTimePickerFormat.Custom;
            Calendario_Nacimiento.CustomFormat = "dd/MM/yyyy";

            // Configurar el combobox del rol por asignar
            ComboBox_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Rol.Items.Add("Administrador");
            ComboBox_Rol.Items.Add("Supervisor");
            ComboBox_Rol.Items.Add("Vendedor");
            ComboBox_Rol.SelectedIndex = -1; // Establecer el elemento vacío como seleccionado por defecto
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            string errorDNI = Validar.EsDNI(Box_DNI.Text);
            if (errorDNI != null)
            {
                DNI_Error.Text = errorDNI;
                DNI_Error.Visible = true;

                MessageBox.Show(errorDNI, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaDNI.Visible = true;
                ContarErrores++;
            }
            else
            {
                DNI_Error.Visible = false;
                MayudaDNI.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            DateTime fechaNacimiento = Calendario_Nacimiento.Value; 
            
            string errorEdad = Validar.EsEdadLaboral(fechaNacimiento);
            if (errorEdad != null) // Verifica que el usuario tenga sea mayor de 18 años y menor de 65 a partir de hoy.
            {
                Edad_Error.Text = errorEdad;
                Edad_Error.Visible = true;
                MessageBox.Show(errorEdad, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaFechaNacimiento.Visible = true;
                ContarErrores++;
            }
            else
            {
                Edad_Error.Visible = false;
                MayudaFechaNacimiento.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; 
            }

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                Nombre_Error.Visible = false;
                MayudaNombre.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorApellido = Validar.EsNombre(Box_Apellido.Text, "Apellido");
            if (errorApellido != null)
            {
                Apellido_Error.Text = errorApellido;
                Apellido_Error.Visible = true;
                MessageBox.Show(errorApellido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaApellido.Visible = true;
                ContarErrores++;
            }
            else
            {
                Apellido_Error.Visible = false;
                MayudaApellido.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorCalle = Validar.EsDireccion(Box_Calle.Text);
            if (errorCalle != null)
            {
                Calle_Error.Text = errorCalle;
                Calle_Error.Visible = true;
                MessageBox.Show(errorCalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaCalle.Visible = true;
                ContarErrores++;
            }
            else
            {
                Calle_Error.Visible = false;
                MayudaCalle.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; 
            }

            string errorTelefono = Validar.EsTelefono(Box_Telefono.Text);
            if (errorTelefono != null)
            {
                Telefono_Error.Text = errorTelefono;
                Telefono_Error.Visible = true;
                MessageBox.Show(errorTelefono, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaTelefono.Visible = true;
                ContarErrores++;
            }
            else
            {
                Telefono_Error.Visible = false;
                MayudaTelefono.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorMail = Validar.EsMail(Box_Mail.Text);
            if (errorMail != null) 
            {
                Mail_Error.Text = errorMail;
                Mail_Error.Visible = true;
                MessageBox.Show(errorMail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaMail.Visible = true;
                ContarErrores++;
            }
            else
            {
                Mail_Error.Visible = false;
                MayudaMail.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; 
            }

            string correo = Box_Mail.Text;
            string correoConfirmado = Box_Mail_Confirm.Text;
            string errorConfirmarMail = Validar.ConfirmarMail(correo, correoConfirmado);

            if (errorConfirmarMail != null)
            {
                ConfirmMail_Error.Text = errorConfirmarMail;
                ConfirmMail_Error.Visible = true;
                MessageBox.Show(errorConfirmarMail, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaConfirMail.Visible = true;
                ContarErrores++;
            }
            else
            {
                ConfirmMail_Error.Visible = false;
                MayudaConfirMail.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; 
            }

            if (ComboBox_Rol.SelectedIndex == -1) // Verifica que el combobox de tipo de usuario no sea vacío.
            {
                Rol_Null.Visible = true;

                MessageBox.Show("No se seleccionó ningún tipo de usuario.\n\nPor favor, seleccione un tipo de usuario y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Rol.Focus();
                MayudaRol.Visible = true;
                ContarErrores++;
            } 
            else
            {
                Rol_Null.Visible = false; 
                MayudaRol.Visible = false;
            }
            return ContarErrores; 
        }

        private bool CamposCompletos() // Evalúa qué campos del formulario están completos
        {
            // Verificar si al menos uno de los campos está lleno
            bool camposLlenos = !string.IsNullOrWhiteSpace(Box_Nombre.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Apellido.Text) ||
                                !string.IsNullOrWhiteSpace(Box_DNI.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Calle.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Telefono.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Mail.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Mail_Confirm.Text);

            // Verificar si los ComboBoxes no han sido desplegados y se ha seleccionado una opción
            bool comboBoxesLlenos = ComboBox_Rol.DroppedDown == false && ComboBox_Rol.SelectedItem != null;

            // Retorna verdadero si al menos uno de los campos de texto está lleno y los ComboBoxes no están desplegados y tienen una selección
            return camposLlenos || comboBoxesLlenos;
        }

        private void Limpiar() // Blanquea el Formulario de usuarios
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados

            ComboBox_Rol.SelectedIndex = -1;
            Box_Nombre.Text = "";
            Box_Apellido.Text = "";
            Box_DNI.Text = "";
            Calendario_Nacimiento.Value = DateTime.Today;
            Box_Calle.Text = "";
            Box_Telefono.Text = "";
            Box_Mail.Text = "";
            Box_Mail_Confirm.Text = "";

            // Volver a ocultar todos los mensajes de error

            Rol_Null.Visible = false;
            Nombre_Error.Visible = false;
            Apellido_Error.Visible = false;
            DNI_Error.Visible = false;
            Edad_Error.Visible = false;
            Calle_Error.Visible = false;
            Telefono_Error.Visible = false;
            Mail_Error.Visible = false;
            ConfirmMail_Error.Visible = false;

            // Ocultar todos los tooltips

            MayudaApellido.Visible = false;
            MayudaCalle.Visible = false;
            MayudaConfirMail.Visible = false;
            MayudaDNI.Visible = false;
            MayudaFechaNacimiento.Visible = false;
            MayudaMail.Visible = false;
            MayudaNombre.Visible = false;
            MayudaRol.Visible = false;
            MayudaTelefono.Visible = false;

        }

        private string GenerarCredenciales(string nombre, string apellido, string dni)
        {
            // Obtener las dos primeras letras del nombre
            string dosPrimerasLetrasNombre = nombre.Length >= 2 ? nombre.Substring(0, 2) : nombre;

            // Obtener las dos primeras letras del apellido
            string dosPrimerasLetrasApellido = apellido.Length >= 2 ? apellido.Substring(0, 2) : apellido;

            // Obtener los tres últimos dígitos del DNI
            string tresUltimosDigitosDNI = dni.Substring(dni.Length - 3);

            // Combinar las partes para formar el nombre de usuario
            string nombreUsuario = $"G1{dosPrimerasLetrasNombre.ToUpper()}{dosPrimerasLetrasApellido.ToUpper()}{tresUltimosDigitosDNI}";

            return nombreUsuario;
        }

        private void CrearUsuario()
        {
            int host;

            if (ComboBox_Rol.SelectedIndex != -1) // Verifica si se ha seleccionado un ítem en el ComboBox
            {
                if (ComboBox_Rol.SelectedItem.ToString() == "Administrador")
                {
                    host = 3;
                }
                else if (ComboBox_Rol.SelectedItem.ToString() == "Supervisor")
                {
                    host = 2;
                }
                else
                {
                    host = 1; // Vendedor
                }
            }
            else
            {
                // En caso de que no se haya seleccionado ningún ítem en el ComboBox
                MessageBox.Show("Por favor, seleccione un tipo de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Rol.Focus();
                return; // Sale del método sin continuar la validación
            }

            // Crear un nuevo objeto AltaUsuario con los datos del formulario
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            usuarioNegocio.AgregarUsuario(
                                            "70b37dc1-8fde-4840-be47-9ababd0ee7e5",
                                            host,
                                            Box_Nombre.Text,
                                            Box_Apellido.Text,
                                            int.Parse(Box_DNI.Text),
                                            Box_Calle.Text,
                                            Box_Telefono.Text,
                                            Box_Mail_Confirm.Text,
                                            Calendario_Nacimiento.Value,
                                            GenerarCredenciales(Box_Nombre.Text, Box_Apellido.Text, Box_DNI.Text),
                                            GenerarCredenciales(Box_Nombre.Text, Box_Apellido.Text, Box_DNI.Text)
                                         );
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                CrearUsuario(); // Si todas las validaciones pasan y el usuario se creó, mostrar un mensaje de éxito.

                string nombreUsuario = GenerarCredenciales(Box_Nombre.Text, Box_Apellido.Text, Box_DNI.Text); // Generar el nombre de usuario

                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la operación de alta para el usuario {nombreUsuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    MessageBox.Show($"Se ha realizado la operación de alta para el usuario {nombreUsuario}.\n\nSu contraseña es la misma que su nombre de usuario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultadoContinuar = MessageBox.Show("¿Desea continuar dando de alta Usuarios?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoContinuar == DialogResult.No)
                    {
                        Close();
                        InterfazListaUsuarios InterfazListaUsuarios = new InterfazListaUsuarios();
                        InterfazListaUsuarios.Show();
                    }
                    else
                    {
                        Limpiar(); // Restablecer todos los campos del formulario
                    }
                }
            }
        } // Confirma todos los campos, si está todo correcto, genera un ID de usuario.

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            if (CamposCompletos())  // Verificar si al menos un campo está completo
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea borrar todos los datos?\n\nSe perderán todos los cambios que no se hayan guardado.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    Limpiar(); 
                }
                // Si el usuario elige "No", no hacer nada
            }
            else
            {
                MessageBox.Show("No hay datos para limpiar.", "Formulario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // Maneja el evento del botón "Limpiar"

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación y volver al listado de usuarios?\n\nSe perderán todos los datos que no se hayan guardado", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazListaUsuarios InterfazListaUsuarios = new InterfazListaUsuarios();
                InterfazListaUsuarios.Show();
            }
        } // Maneja el evento del botón "Cancelar"

        private void UserAdmin_KeyDown(object sender, KeyEventArgs e) // Reacciona al evento de apretar la tecla ESC 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación y volver al menú principal?\n\nSe perderán todos los datos que no se hayan guardado", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Close(); 
                }
            }
        }

        private void IconoListaUsuarios_Click(object sender, EventArgs e)
        {
            if (CamposCompletos())
            {
                var result = MessageBox.Show("¿Desea abandonar los cambios y continuar?","Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    // El usuario eligió quedarse en la pantalla, no hacer nada
                    return;
                }
            }

            // Si no hay cambios en curso o el usuario eligió continuar, ocultar esta ventana y mostrar la lista de usuarios
            Hide();
            InterfazListaUsuarios interfazListaUsuarios = new InterfazListaUsuarios();
            interfazListaUsuarios.Show();
        }

        private void IconoMenu_Click(object sender, EventArgs e) // Evento para volver al menú cuando se hace clic en el ícono del banner 
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar esta ventana?\n\nNo se guardarán los cambios.", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Hide();

                InterfazMenu menuForm = Application.OpenForms.OfType<InterfazMenu>().FirstOrDefault(); // Verificar si ya existe una instancia de InterfazMenu
                if (menuForm == null)
                {
                    menuForm = new InterfazMenu(); // Si no existe, crear una nueva instancia
                }
                menuForm.Show();
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void IconoCerrarSesion_Click(object sender, EventArgs e) // Evento para volver al inicio de sesión cuando se hace clic en el ícono del banner 
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar la sesión? No se guardarán los cambios.", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Hide(); // Por qué no es close?

                InterfazLogIn loginForm = new InterfazLogIn();

                loginForm.FormClosed += (s, args) =>
                {
                    Show();
                };

                loginForm.Show();
            }
            // Si el usuario elige "No", no hacer nada
        }
    }
}