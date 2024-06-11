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
    public partial class InterfazVentasDevolver : Ventana
    {
        public InterfazVentasDevolver()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
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

        private void Ventana_KeyDown(object sender, KeyEventArgs e)
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

        private void Boton_Devolver_Click(object sender, EventArgs e)
        {
            // Lógica para, obtenida una venta, mandar el dato al swagger y devolverla.
        }
    }
}
