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
    public partial class InterfazAltaProductos : Ventana
    {
        public InterfazAltaProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
            ComboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList; // Configurar el estilo para que el usuario no pueda escribir
            ComboBox_Categoria.Items.Add("Audio");
            ComboBox_Categoria.Items.Add("Celulares");
            ComboBox_Categoria.Items.Add("ElectroHogar");
            ComboBox_Categoria.Items.Add("Informatica");
            ComboBox_Categoria.Items.Add("Smart TV");

        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea volver al listado de productos?. Los cambios no se guardarán", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Ocultar la ventana actual
                this.Hide();

                // Crear una instancia de la ventana InterfazMenu
                InterfazListaProductos ListaProductos = new InterfazListaProductos(); 

                // Mostrar la ventana InterfazMenu
                ListaProductos.Show();
            }
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                //Nombre_Error.Text = errorNombre;
                //Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                //Nombre_Error.Visible = false;
                //MayudaNombre.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            if (ComboBox_Categoria.SelectedIndex == -1)
            {
               //Categoria_Null.Visible = true; // Mostrar el TextBox Rol_Null

                // Mostrar mensaje de advertencia cuando el tipo de usuario está en blanco
                MessageBox.Show("No se seleccionó ningún tipo de Categoria.\n\nPor favor, seleccione un tipo de Categoria y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Categoria.Focus();
                //MayudaCategoria.Visible = true;
                ContarErrores++;
            } // Verifica que el combobox de tipo de usuario no sea vacío.
            else
            {
                //Categoria_Null.Visible = false; // Ocultar el TextBox Rol_Null si el combobox Rol no es Null
                //MayudaCategoria.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            return ContarErrores;


        }

        private void LimpiarCampos()
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados

            ComboBox_Categoria.SelectedIndex = -1;
            Box_Nombre.Text = "";
            Box_Precio.Text = "";
            Box_Stock.Text = "";

            //Categoria_Null.Visible = false;
            //Nombre_Error.Visible = false;
            //Apellido_Error.Visible = false;
            //Stock_Error.Visible = false;
            //Precio_Error.Visible = false;  //Faltan Agregar

            // Ocultar todos los tooltips
            //MayudaNombre.Visible = false;
            //MayudaRol.Visible = false;
            //MayudaStock.Visible = false;
            //MayudaPrecio.Visible = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
