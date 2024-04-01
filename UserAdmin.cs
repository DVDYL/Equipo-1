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
        public UserAdmin()
        {
            InitializeComponent(); // Inicializamos el formulario.

            // Agregar opciones al ComboBox de tipo de ABM una sola vez al cargar el formulario
            ComboBox_ABM.Items.Add("01 - Alta");
            ComboBox_ABM.Items.Add("02 - Modificación");
            ComboBox_ABM.Items.Add("03 - Baja");

            // Desactivar la capacidad de edición del ComboBox_ABM
            ComboBox_ABM.DropDownStyle = ComboBoxStyle.DropDownList;

            // Agregar opciones al ComboBox de tipo de usuario una sola vez al cargar el formulario
            ComboBox_Rol.Items.Add("01 - Administrador");
            ComboBox_Rol.Items.Add("02 - Supervisor");
            ComboBox_Rol.Items.Add("03 - Vendedor");

            // Desactivar la capacidad de edición del ComboBox_Rol
            ComboBox_Rol.DropDownStyle = ComboBoxStyle.DropDownList;

            // Establecer el formato de visualización predeterminado para la fecha de nacimiento
            Calendario_Nacimiento.Format = DateTimePickerFormat.Custom;
            Calendario_Nacimiento.CustomFormat = "dd/MM/yyyy";
        } // Esta Función prepara el formulario y sus restricciones

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
            // La validación de este componente se deberá realizar cuando el usuario haga clic en el evento "Confirmar"
        } // Detecta Cambios en el campo "Operación"

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

        private void Calendario_Nacimiento_ValueChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fecha válida
            if (Calendario_Nacimiento.Checked && Calendario_Nacimiento.Value != DateTime.MinValue)
            {
                // Obtener la fecha seleccionada
                DateTime fechaSeleccionada = Calendario_Nacimiento.Value;

                // Verificar si la fecha seleccionada es posterior al día de hoy
                if (fechaSeleccionada > DateTime.Today)
                {
                    // Mostrar mensaje de advertencia
                    MessageBox.Show("No se puede seleccionar una fecha posterior al día de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Establecer la fecha de hoy como valor seleccionado
                    Calendario_Nacimiento.Value = DateTime.Today;
                }

            }
        } // Detecta cambios en la fecha de nacimiento y evalúa que no sea posterior a hoy.

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
                // Mostrar mensaje de advertencia cuando la operación está en blanco
                MessageBox.Show("Por favor, seleccione una operación y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_ABM.Focus();
                return;
            } // Verifica que el combobox de tipo de operación no sea vacío.

            else if (ComboBox_Rol.SelectedIndex == -1)
            {
                // Mostrar mensaje de advertencia cuando el tipo de usuario está en blanco
                MessageBox.Show("Por favor, seleccione un tipo de usuario y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Rol.Focus();
                return;
            } // Verifica que el combobox de tipo de usuario no sea vacío.

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorApellido = Validar.EsNombre(Box_Apellido.Text, "Apellido");
            if (errorApellido != null)
            {
                MessageBox.Show(errorApellido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorDNI = Validar.EsDNI(Box_DNI.Text);
            if (errorDNI != null)
            {
                MessageBox.Show(errorDNI, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaNacimiento = Calendario_Nacimiento.Value; // Verifica que el usuario tenga sea mayor de 18 años y menor de 65 a partir de hoy.
            if (!Validar.EsEdadLaboral(fechaNacimiento))
            {
                // Mostrar mensaje de advertencia si la edad no es válida
                MessageBox.Show("El usuario debe ser mayor de 18 años y menor de 65.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string errorCalle = Validar.EsCalle(Box_Calle.Text);
            if (errorCalle != null)
            {
                MessageBox.Show(errorCalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorAltura = Validar.EsAltura(Box_Altura.Text);
            if (errorAltura != null)
            {
                MessageBox.Show(errorAltura, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorDepartamento = Validar.EsDepartamento(Box_Depto.Text);
            if (errorDepartamento != null)
            {
                MessageBox.Show(errorDepartamento, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorTelefono = Validar.EsTelefono(Box_Telefono.Text);
            if (errorTelefono != null)
            {
                MessageBox.Show(errorTelefono, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorMail = Box_Mail.Text;
            if (string.IsNullOrEmpty(errorMail))
            {
                MessageBox.Show("El campo Email no puede estar vacío. Por favor, ingrese un Email.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Validar.EsMail(errorMail)) //Si NO cumple con la validación, mostrará el mensaje.
            {
                MessageBox.Show("El Email ingresado es inválido, por favor, ingrese un mail válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorConfirmarMail = Box_Mail_Confirm.Text;
            if (string.IsNullOrEmpty(errorConfirmarMail))
            {
                MessageBox.Show("El campo Email no puede estar vacío. Por favor, confirme su Email.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Validar.ConfirmarMail(errorMail,errorConfirmarMail))
            {
                MessageBox.Show("El Email ingresado es diferente al ingresado en el paso anterior. Por favor, confirme nuevamente el Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorContraseña = Box_Pass.Text;
            if (string.IsNullOrEmpty(errorContraseña))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío. Por favor, ingrese una Contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Validar.EsContraseñaValida(errorContraseña)) //Si NO cumple con la validación, mostrará el mensaje.
            {
                MessageBox.Show("La Contraseña ingresada es inválida.\n\nUna contraseña válida contiene al menos una mayúscula, un número y tiene como mínimo 8 caracteres.\n\nPor favor, ingrese una Contraseña válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorConfirmarContraseña = Box_Pass_Confirm.Text;
            if (string.IsNullOrEmpty(errorConfirmarContraseña))
            {
                MessageBox.Show("El campo no puede estar vacío. Por favor, ingrese una Contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Validar.ConfirmarContraseña(errorContraseña, errorConfirmarContraseña))
            {
                MessageBox.Show("La Contraseña ingresada es diferente a la ingresada en el paso anterior. Por favor, confirme nuevamente la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones pasan, mostrar mensaje de éxito

            // Generar el nombre de usuario
            string nombreUsuario = GenerarNombreUsuario(Box_Nombre.Text, Box_Apellido.Text, Calendario_Nacimiento.Value);

            // Mensaje de éxito con el nombre de usuario generado
            MessageBox.Show($"El usuario {nombreUsuario} fue dado de alta con éxito con el ID: 1", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar la ventana actual
            this.Close();
        } // Confirma todos los campos, si está todo correcto, genera un ID de usuario.

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación y volver al menú principal?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
