using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void ComboBox_ABM_SelectedIndexChanged(object sender, EventArgs e) 
        {
            // La validación de este componente se deberá realizar cuando el usuario haga clic en el evento "Confirmar"
        }

        private void Box_Nombre_TextChanged(object sender, EventArgs e)
        {
            // No necesitamos hacer nada en este evento para esta validación
        }

        private void Box_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                // Obtener el texto del TextBox
                string texto = Box_Nombre.Text;

                // Realizar la validación
                if (string.IsNullOrWhiteSpace(texto) ||
                    texto.Length < 3 ||
                    texto.Any(char.IsDigit) ||
                    texto.Any(c => !char.IsLetterOrDigit(c)))
                {
                    // Mostrar mensaje de error
                    MessageBox.Show("El campo no cumple con los requisitos de validación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Prevenir que el tabulador avance al siguiente control
                    e.Handled = true;
                }
            }
        }

        private void Box_Nombre_Leave(object sender, EventArgs e)
        {
            // Aquí no necesitamos hacer nada, pero este evento puede ser útil para ejecutar acciones después de la validación
        }

        private void Box_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_DNI_TextChanged(object sender, EventArgs e)
        {
            // No necesitamos hacer nada en este evento para esta validación
        }

        private void Box_DNI_Leave(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox
            string texto = Box_DNI.Text.Trim();

            // Verificar si el campo está en blanco
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El campo DNI no puede estar en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el texto contiene caracteres que no son números
            if (!texto.All(char.IsDigit))
            {
                MessageBox.Show("El campo DNI solo puede contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar la longitud del DNI y preguntar al usuario si desea completar con 0s al principio si es menor a 8 dígitos
            if (texto.Length < 8)
            {
                DialogResult result = MessageBox.Show("El DNI debe tener al menos 8 dígitos. ¿Desea completar con 0s al principio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    texto = texto.PadLeft(8, '0');
                    Box_DNI.Text = texto;
                }
                else
                {
                    // Si el usuario elige No, limpiar el TextBox
                    Box_DNI.Clear();
                }
            }
        }

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
                else
                {
                    // Calcular la fecha límite para tener al menos 18 años
                    DateTime fechaLimite = DateTime.Today.AddYears(-18);

                    // Verificar si la fecha seleccionada es posterior a la fecha límite
                    if (fechaSeleccionada > fechaLimite)
                    {
                        // Mostrar mensaje de advertencia
                        MessageBox.Show("Debe tener al menos 18 años de edad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e) // Preguntar al usuario si está seguro de cancelar cuando clickea "Cancelar"
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
            {
                this.Close();                 // Si el usuario selecciona "Sí", cierra el formulario
            }
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e) // Esto es un botón
        {
            // Verificar si el campo "Operación" está en blanco
            if (ComboBox_ABM.SelectedIndex == -1)
            {
                // Mostrar mensaje de advertencia cuando la operación está en blanco
                MessageBox.Show("Por favor, seleccione una operación y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Enfocar el ComboBox "Operación" para que el usuario tenga que volver a él
                ComboBox_ABM.Focus();
            }
            // Verificar si el campo "Tipo de Usuario" está en blanco
            else if (ComboBox_Rol.SelectedIndex == -1)
            {
                // Mostrar mensaje de advertencia cuando el tipo de usuario está en blanco
                MessageBox.Show("Por favor, seleccione un tipo de usuario y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Enfocar el ComboBox "Tipo de Usuario" para que el usuario tenga que volver a él
                ComboBox_Rol.Focus();
            }
        }
    }
}
