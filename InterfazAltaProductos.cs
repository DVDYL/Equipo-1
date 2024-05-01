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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
