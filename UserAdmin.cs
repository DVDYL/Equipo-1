using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // importamos librería

namespace Equipo1
{
    public partial class UserAdmin : Form
    {
        private Dictionary<string, List<string>> usuariosPorRol = new Dictionary<string, List<string>>();

        public UserAdmin()
        {

            InitializeComponent(); // Inicializamos el formulario.
            
            Operacion_Null.Visible = false; // Ocultar el TextBox Operacion_Null
            Rol_Null.Visible = false; // Ocultar el TextBox Rol_Null
            Label_Usuario.Visible = false; // Ocultar el TextBox Label_Usuario
            ComboBox_Usuario.Visible = false;


           

            // Agregar opciones al ComboBox de tipo de ABM una sola vez al cargar el formulario
            ComboBox_ABM.Items.Add("Alta");
            ComboBox_ABM.Items.Add("Modificación");
            ComboBox_ABM.Items.Add("Baja");

            // Agregar opciones al ComboBox del rol una sola vez al cargar el formulario
            ComboBox_Rol.Items.Add("Administrador");
            ComboBox_Rol.Items.Add("Supervisor");
            ComboBox_Rol.Items.Add("Vendedor");

            // Asociar usuarios a roles
            usuariosPorRol.Add("Administrador", new List<string> { "01 - ADMINI24" });
            usuariosPorRol.Add("Supervisor", new List<string> { "02 - SUPERV24" });
            usuariosPorRol.Add("Vendedor", new List<string> { "03 - VENDED24" });

            // Manejar el evento SelectedIndexChanged del primer ComboBox
            ComboBox_Rol.SelectedIndexChanged += ComboBox_Rol_SelectedIndexChanged;

            // Desactivar la capacidad de edición de los tres ComboBox

            ComboBox_ABM.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Usuario.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establecer el formato de visualización predeterminado para la fecha de nacimiento
            Calendario_Nacimiento.Format = DateTimePickerFormat.Custom;
            Calendario_Nacimiento.CustomFormat = "dd/MM/yyyy";

        } // Esta Función prepara el formulario y sus restricciones

        private void ResetearCampos()
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados
            ComboBox_ABM.SelectedIndex = -1;
            ComboBox_Rol.SelectedIndex = -1;
            ComboBox_Usuario.SelectedIndex = -1;
            Box_Nombre.Text = "";
            Box_Apellido.Text = "";
            Box_DNI.Text = "";
            Calendario_Nacimiento.Value = DateTime.Today;
            Box_Calle.Text = "";
            Box_Altura.Text = "";
            Box_Depto.Text = "";
            Box_Telefono.Text = "";
            Box_Mail.Text = "";
            Box_Mail_Confirm.Text = "";
            Box_Pass.Text = "";
            Box_Pass_Confirm.Text = "";

            // Volver a ocultar todos los mensajes de error
            Operacion_Null.Visible = false;
            Rol_Null.Visible = false;
            Nombre_Error.Visible = false;
            Apellido_Error.Visible = false;
            DNI_Error.Visible = false;
            Edad_Error.Visible = false;
            Calle_Error.Visible = false;
            Altura_Error.Visible = false;
            Depto_Error.Visible = false;
            Telefono_Error.Visible = false;
            Mail_Error.Visible = false;
            ConfirmMail_Error.Visible = false;
            Pass_Error.Visible = false;
            ConfirmPass_Error.Visible = false;

            // Volver a ocultar el Combobox_Usuario
            Label_Usuario.Visible = false; 
            ComboBox_Usuario.Visible = false;

        } // Blanquea el Formulario

        private string GenerarNombreUsuario(string nombre, string apellido, DateTime fechaNacimiento)
        {
            // Obtener las tres primeras letras del nombre
            string primerasTresLetrasNombre = nombre.Length >= 3 ? nombre.Substring(0, 3) : nombre;

            // Obtener las tres primeras letras del apellido
            string primerasTresLetrasApellido = apellido.Length >= 3 ? apellido.Substring(0, 3) : apellido;

            // Obtener los cuatro dígitos del año de nacimiento
            string añoNacimiento = fechaNacimiento.Year.ToString().Substring(2, 2);

            // Combinar las partes para formar el nombre de usuario
            string nombreUsuario = $"{primerasTresLetrasNombre.ToUpper()}{primerasTresLetrasApellido.ToUpper()}{añoNacimiento}";

            return nombreUsuario;
        } // Función para autogenerar el nombre del usuario

        private void ComboBox_ABM_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento en ComboBox_ABM
            if (ComboBox_ABM.SelectedIndex != -1)
            {
                // Verificar si se seleccionó "Modificación" o "Baja"
                if (ComboBox_ABM.SelectedItem.ToString() == "Modificación" || ComboBox_ABM.SelectedItem.ToString() == "Baja")
                {
                    // Mostrar ComboBox_Usuario y Label_Usuario
                    ComboBox_Usuario.Visible = true;
                    Label_Usuario.Visible = true;
                }
                else
                {
                    // Ocultar ComboBox_Usuario y Label_Usuario
                    ComboBox_Usuario.Visible = false;
                    Label_Usuario.Visible = false;
                }
            }
            else
            {
                // Si no se ha seleccionado ningún elemento en ComboBox_ABM, ocultar ComboBox_Usuario y Label_Usuario
                ComboBox_Usuario.Visible = false;
                Label_Usuario.Visible = false;
            }
        } // Detecta Cambios en el campo "Operación"

        private void ComboBox_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar ComboBox_Usuario
            ComboBox_Usuario.Items.Clear();

            // Verificar si hay un elemento seleccionado en ComboBox_Rol
            if (ComboBox_Rol.SelectedItem != null)
            {
                // Obtener el rol seleccionado
                string selectedRol = ComboBox_Rol.SelectedItem.ToString();

                // Verificar si el rol seleccionado existe en el diccionario
                if (usuariosPorRol.ContainsKey(selectedRol))
                {
                    // Agregar usuarios asociados al rol seleccionado
                    foreach (string usuario in usuariosPorRol[selectedRol])
                    {
                        ComboBox_Usuario.Items.Add(usuario);
                    }
                }
            }
        } // Detecta Cambios en el campo "Rol"

        private void Box_Nombre_TextChanged(object sender, EventArgs e)
        {
            // No necesitamos hacer nada en este evento para esta validación
        } // Detecta Cambios en el campo "Nombre"

        private void Box_Apellido_TextChanged(object sender, EventArgs e)
        {

        } // Detecta Cambios en el campo "Apellido"

        private void Box_DNI_TextChanged(object sender, EventArgs e)
        {
            // No necesitamos hacer nada en este evento para esta validación
        } // Detecta Cambios en el campo "DNI"

        private void Box_Calle_TextChanged(object sender, EventArgs e)
        {
 
        } // Detecta Cambios en el campo "Calle"
 
        private void Box_Altura_TextChanged(object sender, EventArgs e)
        {
 
        } // Detecta Cambios en el campo "Altura"
 
        private void Box_Depto_TextChanged(object sender, EventArgs e)
        {
 
        } // Detecta Cambios en el campo "Departamento"

        private void Box_Mail_TextChanged(object sender, EventArgs e)
        {

        } // Detecta cambios en el campo "Email"

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            if (ComboBox_ABM.SelectedIndex == -1)
            {
                Operacion_Null.Visible = true; // Mostrar el TextBox Operacion_Null

                MessageBox.Show("No se seleccionó ningún tipo de operación.\n\nPor favor, seleccione una operación y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Mostrar mensaje de advertencia cuando la operación está en blanco
                ComboBox_ABM.Focus();
                MayudaOper.Visible = true;  
                return;
            } // Verifica que el combobox de tipo de operación no sea vacío.
            else
            {
                Operacion_Null.Visible = false; // Ocultar el TextBox Operacion_Null si el combobox ABM no es Null
            }

            if (ComboBox_Rol.SelectedIndex == -1)
            {
                Rol_Null.Visible = true; // Mostrar el TextBox Rol_Null

                // Mostrar mensaje de advertencia cuando el tipo de usuario está en blanco
                MessageBox.Show("No se seleccionó ningún tipo de usuario.\n\nPor favor, seleccione un tipo de usuario y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Rol.Focus();
                MayudaRol.Visible = true;
                return;
            } // Verifica que el combobox de tipo de usuario no sea vacío.
            else
            {
                Rol_Null.Visible = false; // Ocultar el TextBox Rol_Null si el combobox Rol no es Null
            }

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                // Completar el contenido del TextBox Nombre_Error con el error
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaNombre.Visible = true;
                return;
            }
            else
            {
                Nombre_Error.Visible = false; // Ocultar el TextBox Nombre_Error si el campo nombre no tiene errores.
            }

            string errorApellido = Validar.EsNombre(Box_Apellido.Text, "Apellido");
            if (errorApellido != null)
            {
                // Completar el contenido del TextBox Apellido_Error con el error
                Apellido_Error.Text = errorApellido;
                Apellido_Error.Visible = true;
                MessageBox.Show(errorApellido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaApellido.Visible = true;
                return;
            }
            else
            {
                Apellido_Error.Visible = false; // Ocultar el TextBox Nombre_Error si el campo nombre no tiene errores.
            }

            string errorDNI = Validar.EsDNI(Box_DNI.Text);
            if (errorDNI != null)
            {
                // Completar el contenido del TextBox DNI_Error con el error
                DNI_Error.Text = errorDNI;
                DNI_Error.Visible = true;

                MessageBox.Show(errorDNI, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaDNI.Visible = true;
                return;
            }
            else
            {
                DNI_Error.Visible = false; // Ocultar el TextBox Nombre_Error si el campo nombre no tiene errores.
            }

            DateTime fechaNacimiento = Calendario_Nacimiento.Value; // Verifica que el usuario tenga sea mayor de 18 años y menor de 65 a partir de hoy.
            string errorEdad = Validar.EsEdadLaboral(fechaNacimiento);
            if (errorEdad != null)
            {
                Edad_Error.Text = errorEdad;
                Edad_Error.Visible = true;
                // Mostrar mensaje de advertencia si la edad no es válida
                MessageBox.Show(errorEdad, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaFechaNacimiento.Visible = true;
                return;
            }
            else
            {
                Edad_Error.Visible=false; 
            }

            string errorCalle = Validar.EsCalle(Box_Calle.Text);
            if (errorCalle != null)
            {
                // Completar el contenido del TextBox Calle_Error con el error
                Calle_Error.Text = errorCalle;
                Calle_Error.Visible = true;
                MessageBox.Show(errorCalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaCalle.Visible = true;
                return;
            }
            else
            {
                Calle_Error.Visible = false; // Ocultar el TextBox Calle_Error si el campo Calle no tiene errores.
            }

            string errorAltura = Validar.EsAltura(Box_Altura.Text);
            if (errorAltura != null)
            {
                Altura_Error.Text = errorAltura; // Completar el contenido del TextBox Altura_Error con el error
                Altura_Error.Visible = true;
                MessageBox.Show(errorAltura, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaAltura.Visible = true;
                return;
            }
            else
            {
                Altura_Error.Visible = false; // Ocultar el TextBox Altura_Error si el campo Altura no tiene errores.
            }

            string errorDepartamento = Validar.EsDepartamento(Box_Depto.Text);
            if (errorDepartamento != null)
            {
                Depto_Error.Text = errorDepartamento; // Completar el contenido del TextBox Depto_Error con el error
                Depto_Error.Visible = true;
                MessageBox.Show(errorDepartamento, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaDepto.Visible = true;
                return;
            }
            else
            {
                Depto_Error.Visible = false;
            }

            string errorTelefono = Validar.EsTelefono(Box_Telefono.Text);
            if (errorTelefono != null)
            {
                Telefono_Error.Text = errorTelefono;
                Telefono_Error.Visible = true;
                MessageBox.Show(errorTelefono, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaTelefono.Visible = true;
                return;
            }
            else
            {
                Telefono_Error.Visible = false;
            }

            string errorMail = Validar.EsMail(Box_Mail.Text);
            if (errorMail !=null) //Si NO cumple con la validación, mostrará el mensaje.
            {
                Mail_Error.Text = errorMail;
                Mail_Error.Visible = true;
                MessageBox.Show(errorMail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaMail.Visible = true;
                return;
            }
            else
            {
                Mail_Error.Visible = false;
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
                return;
            }
            else
            {
                ConfirmMail_Error.Visible = false;
            }

            string errorContraseña = Validar.EsContraseña(Box_Pass.Text);
            if (errorContraseña != null)
            {
                Pass_Error.Text = errorContraseña;
                Pass_Error.Visible = true;
                MessageBox.Show(errorContraseña, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaContra.Visible = true;
                return;
            }
            else 
            {
                Pass_Error.Visible = false;
            }

            string contraseña = Box_Pass.Text;
            string contraseñaConfirmada = Box_Pass_Confirm.Text;
            string errorConfirmarContraseña = Validar.ConfirmarContraseña(contraseña, contraseñaConfirmada);

            if (errorConfirmarContraseña != null) 
            {
                ConfirmPass_Error.Text = errorConfirmarContraseña;
                ConfirmPass_Error.Visible = true;
                MessageBox.Show(errorConfirmarContraseña, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaConfirContra.Visible = true;
                return;
            }
            else
            {
                ConfirmPass_Error.Visible = false;
            }

            // Si todas las validaciones pasan, mostrar mensaje de éxito.

            string nombreUsuario = GenerarNombreUsuario(Box_Nombre.Text, Box_Apellido.Text, Calendario_Nacimiento.Value); // Generar el nombre de usuario
            string operacionSeleccionada = ComboBox_ABM.SelectedItem.ToString();

            // Mostrar un cuadro de diálogo de confirmación al usuario
            DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la operación de {operacionSeleccionada} para el usuario {nombreUsuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoConfirmacion == DialogResult.Yes)
            {
                // Mostrar mensaje de éxito con el nombre de usuario generado
                MessageBox.Show($"Se ha realizado la operación de {operacionSeleccionada} para el usuario {nombreUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Preguntar al usuario si desea continuar en el Maestro de Usuarios
                DialogResult resultadoContinuar = MessageBox.Show("¿Desea continuar en el ABM de Usuarios?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoContinuar == DialogResult.No)
                {
                    // Cerrar el formulario actual (UserAdmin.cs)
                    this.Close();
                }
                else
                {
                    // Restablecer todos los campos del formulario
                    ResetearCampos();
                }
            }
            // Si el usuario elige "No" en el cuadro de diálogo de confirmación, no hacemos nada

        } // Confirma todos los campos, si está todo correcto, genera un ID de usuario.

        private bool CamposCompletos()
        {
            // Verificar si al menos uno de los campos está lleno
            return !string.IsNullOrWhiteSpace(Box_Nombre.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Apellido.Text) ||
                   !string.IsNullOrWhiteSpace(Box_DNI.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Calle.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Altura.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Depto.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Telefono.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Mail.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Mail_Confirm.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Pass.Text) ||
                   !string.IsNullOrWhiteSpace(Box_Pass_Confirm.Text);
        } // Función auxiliar que ayuda a detectar que haya al menos un campo completo para que el botón "Limpiar" sea interactivo.

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            // Verificar si al menos un campo está completo
            if (CamposCompletos())
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult confirmacion = MessageBox.Show("¿Desea borrar todos los datos?\n\nSe perderán todos los cambios que no se hayan guardado.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    // Si el usuario elige "Sí", llamar al método para resetear los campos
                    ResetearCampos();
                }
                // Si el usuario elige "No", no hacer nada
            }
            else
            {
                // Mostrar un mensaje de error
                MessageBox.Show("No hay datos para limpiar.\n\nCódigo de Error: 004", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación y volver al menú principal?\n\nSe perderán todos los datos que no se hayan guardado", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cerrar el formulario actual (UserAdmin.cs)
                this.Close(); // Esto cerrará el formulario UserAdmin y volverá automáticamente al formulario Menu si es que fue abierto desde allí
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Cancelar la operación y volver al menú principal?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cerrar el formulario actual (UserAdmin.cs)
                this.Close();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void form1_Load(object sender, EventArgs e) // importamos código para poder mover la ventana
        {

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e) // Le asignamos los eventos a la barra de título (header)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}