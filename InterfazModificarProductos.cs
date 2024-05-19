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
    public partial class InterfazModificarProductos : Ventana
    {
        public InterfazModificarProductos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true; 
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {

        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al listado de productos?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    InterfazListaProductos ListaProductos = new InterfazListaProductos();
                    ListaProductos.Show();
                    Hide(); 
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}