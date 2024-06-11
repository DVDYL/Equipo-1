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

        // Stock crítico: 2 y 3
        // Ventas por vendedor: todos
        // Productos más vendidos por categoría: 2 y 3


        public InterfazRepoMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }

        private void RepoStock_Icono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            // Verificar el valor de Host para filtrar visibilidad
            if (interfazLogIn.Host == "2" || interfazLogIn.Host == "3")
            {
                InterfazRepoStockCritico InterfazRepoStockCritico = new InterfazRepoStockCritico(); // Crear una instancia del formulario InterfazRepoStockCritico

                Hide(); // Ocultar el formulario RepoMenu

                InterfazRepoStockCritico.FormClosed += (s, args) => Close(); // Cerrar la aplicación cuando se cierre UserAdmin
                InterfazRepoStockCritico.Show(); // Mostrar el formulario InterfazRepoStockCritico
            }
            else
            {
                MessageBox.Show("ERROR 201: Este nivel de usuario no tiene acceso al reporte de Stock Crítico", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RepoVentas_Icono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            // Verificar el valor de Host para filtrar visibilidad
            if (interfazLogIn.Host == "1" || interfazLogIn.Host == "2" || interfazLogIn.Host == "3") //En teoría, todos los usuarios pueden acceder.
            {
                InterfazRepoVentas InterfazRepoVentas = new InterfazRepoVentas(); // Crear una instancia del formulario InterfazRepoVentas

                Hide(); // Ocultar el formulario RepoMenu

                InterfazRepoVentas.FormClosed += (s, args) => Close(); // Cerrar la aplicación cuando se cierre UserAdmin
                InterfazRepoVentas.Show(); // Mostrar el formulario InterfazStockCritico
            }
            else
            {
                MessageBox.Show("ERROR 201: Este nivel de usuario no tiene acceso al reporte de las ventas por vendedor", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RepoMasVendido_Icono_Click(object sender, EventArgs e)
        {
            InterfazLogIn interfazLogIn = InterfazLogIn.Instancia;

            // Verificar el valor de Host para filtrar visibilidad
            if (interfazLogIn.Host == "2" || interfazLogIn.Host == "3")
            {
                InterfazRepoMasVendidos InterfazMasVendidos = new InterfazRepoMasVendidos(); // Crear una instancia del formulario InterfazRepoMasVendidos

                Hide(); // Ocultar el formulario RepoMenu

                InterfazMasVendidos.FormClosed += (s, args) => Close(); // Cerrar la aplicación cuando se cierre UserAdmin
                InterfazMasVendidos.Show(); // Mostrar el formulario InterfazRepoMasVendidos
            }
            else
            {
                MessageBox.Show("ERROR 201: Este nivel de usuario no tiene acceso al reporte de los productos mas vendidos", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
