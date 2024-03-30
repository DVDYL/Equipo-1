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
        } // Esta Función prepara el formulario y sus restricciones

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
        } // Detecta Cambios en el campo "Apellido"

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
        } // Evalúa que el usuario no tenga menos de 18 años.

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            if (ComboBox_ABM.SelectedIndex == -1)
            {
                // Mostrar mensaje de advertencia cuando la operación está en blanco
                MessageBox.Show("Por favor, seleccione una operación y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_ABM.Focus();
                return;
            }

            else if (ComboBox_Rol.SelectedIndex == -1)
            {
                // Mostrar mensaje de advertencia cuando el tipo de usuario está en blanco
                MessageBox.Show("Por favor, seleccione un tipo de usuario y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Rol.Focus();
                return;
            }

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

            string errorCampoNumerico = Validar.EsDNI(Box_DNI.Text);
            if (errorCampoNumerico != null)
            {
                MessageBox.Show(errorCampoNumerico, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones pasan, mostrar mensaje de éxito
            MessageBox.Show("El Usuario fue dado de alta con éxito con el ID: 1", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cerrar la ventana actual
            this.Close();
        } // Confirma todos los campos, si está todo correcto, genera un ID de usuario.

        private void Boton_Cancelar_Click(object sender, EventArgs e) // Preguntar al usuario si está seguro de cancelar cuando clickea "Cancelar"
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
            {
                this.Close();                 // Si el usuario selecciona "Sí", cierra el formulario
            }
        }

    }
}
