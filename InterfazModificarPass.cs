using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazModificarPass : Ventana
    {
        private Dictionary<string, List<string>> usuariosPorRol = new Dictionary<string, List<string>>(); // Lista de usuarios para validar sin WS

        public InterfazModificarPass()
        {
            InitializeComponent();
            Operacion_Null.Visible = false; // Ocultar el TextBox Operacion_Null
            Label_Usuario.Visible = false; // Ocultar el TextBox Label_Usuario
            ComboBox_Usuario.Visible = false; // No mostrar el combobox de usuario por defecto
            CheckActivo.Visible = false; // No mostrar el check "De Baja" por defecto

            // Agregar opciones al ComboBox de tipo de ABM una sola vez al cargar el formulario
            ComboBox_ABM.Items.Add("Modificación");
            ComboBox_ABM.Items.Add("Baja");

            // Agregar opciones al ComboBox del rol una sola vez al cargar el formulario
            ComboBox_Rol.Items.Add("Administrador");
            ComboBox_Rol.Items.Add("Supervisor");
            ComboBox_Rol.Items.Add("Vendedor");

            // Asociar usuarios a roles (ELIMINAR AL CONECTAR EL WS)
            usuariosPorRol.Add("Administrador", new List<string> { "01 - ADMINI24" });
            usuariosPorRol.Add("Supervisor", new List<string> { "02 - SUPERV24" });
            usuariosPorRol.Add("Vendedor", new List<string> { "03 - VENDED24" });

            // Desactivar la capacidad de edición de los tres Comboboxes para evitar ingresos accidentales.
            ComboBox_ABM.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Rol.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Usuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Limpiar() // Blanquea el Formulario de usuarios
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados
            ComboBox_ABM.SelectedIndex = -1;
            ComboBox_Rol.SelectedIndex = -1;
            ComboBox_Usuario.SelectedIndex = -1;
            Box_Pass.Text = "";


            // Volver a ocultar todos los mensajes de error
            Operacion_Null.Visible = false;
            Rol_Null.Visible = false;
            Pass_Error.Visible = false;
            ConfirmPass_Error.Visible = false;

            // Ocultar todos los tooltips
            MayudaOper.Visible = false;
            MayudaConfirContra.Visible = false;
            MayudaContra.Visible = false;
            MayudaOper.Visible = false;
            MayudaRol.Visible = false;

            // Volver a ocultar el Combobox_Usuario y el check "De Baja"
            Label_Usuario.Visible = false;
            ComboBox_Usuario.Visible = false;
            CheckActivo.Visible = false;

        }

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
                    CheckActivo.Visible = true;
                }
                else
                {
                    // Ocultar ComboBox_Usuario y Label_Usuario
                    ComboBox_Usuario.Visible = false;
                    Label_Usuario.Visible = false;
                    CheckActivo.Visible = false;
                }
            }
            else
            {
                // Si no se ha seleccionado ningún elemento en ComboBox_ABM, ocultar ComboBox_Usuario y Label_Usuario
                ComboBox_Usuario.Visible = false;
                Label_Usuario.Visible = false;
                CheckActivo.Visible = false;
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

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {

        } // Confirma todos los campos, si está todo correcto, cambia la contraseña.
    }
}
