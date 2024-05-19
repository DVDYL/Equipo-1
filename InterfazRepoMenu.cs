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
    public partial class InterfazRepoMenu : Ventana
    {
        // Falta traer el host del usuario porque:
        // Stock crítico: 1 y 2
        // Ventas por vendedor: todos
        // Productos más vendidos por categoría: 1 y 2
        // Recomiendo simplificar esto y que hagamos un sub-menú igual al menú, tres íconos y le damos al usuario posibilidad de elegir.

        public InterfazRepoMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }

        private void RepoStock_Icono_Click(object sender, EventArgs e)
        {
            // Stock crítico: 1 y 2
        }

        private void RepoVentas_Icono_Click(object sender, EventArgs e)
        {
            // Ventas por vendedor: todos
        }

        private void RepoMasVendido_Icono_Click(object sender, EventArgs e)
        {
            // Productos más vendidos por categoría: 1 y 2
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InterfazMenu Menu = new InterfazMenu();
                    Menu.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazMenu Menu = new InterfazMenu();
                Menu.Show();
            }
        }
    }
}
