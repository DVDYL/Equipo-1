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
    public partial class InterfazVentasMenu : Ventana
    {
        public InterfazVentasMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        private void Vender_Icono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if (interfazLogIn.Host == "1" || interfazLogIn.Host == "3") // SACAR EL 3 PARA LA ENTREGA FINAL
            {
                InterfazVentas CrearVenta = new InterfazVentas();
                Hide();
                CrearVenta.FormClosed += (s, args) => Close();
                CrearVenta.Show();
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Ventas", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Devolver_Icono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            if (interfazLogIn.Host == "2" || interfazLogIn.Host == "3") // SACAR EL 3 PARA LA ENTREGA FINAL
            {
                InterfazVentasDevolver DevolverVenta = new InterfazVentasDevolver();
                Hide();
                DevolverVenta.FormClosed += (s, args) => Close();
                DevolverVenta.Show();
            }
            else
            {
                MessageBox.Show("Este nivel de usuario no tiene acceso al módulo de Devoluciones", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
