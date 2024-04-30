using Datos;
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
    public partial class InterfazListaProductos : Ventana
    {
        private ProductoNegocio ProductoNegocio = new ProductoNegocio();
        public InterfazListaProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        private void InterfazListaProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        private void Boton_AltaProducto_Click(object sender, EventArgs e)
        {
            InterfazAltaProductos AltaProductos = new InterfazAltaProductos();
            this.Hide();
            AltaProductos.Show();
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Ocultar la ventana actual
                this.Hide();

                // Crear una instancia de la ventana InterfazMenu
                InterfazMenu ventanaMenu = new InterfazMenu();

                // Mostrar la ventana InterfazMenu
                ventanaMenu.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazMenu InterfazMenu = new InterfazMenu(); // Redirigir al formulario de inicio de sesión (LogIn)
                    InterfazMenu.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }

        private void CargarProductos()
        {
            try
            {
                List<TraerProductos> Producto = ProductoNegocio.listarProductos();

               

                var bindingList = new BindingList<TraerProductos>(Producto);
                var source = new BindingSource(bindingList, null);
                Productos.DataSource = source;
                Productos.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Productos: " + ex.Message);
            }
        }

        private void Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
