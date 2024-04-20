using System;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instanciar y mostrar el formulario de inicio de sesión
            InterfazLogIn loginForm = new InterfazLogIn();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el inicio de sesión es exitoso, iniciar la aplicación principal
                Application.Run(new Presentacion.InterfazMenu()); // Agregado el espacio de nombres completo del formulario personalizado
            }
            else
            {
                // Si el inicio de sesión falla (por ejemplo, si se cierra el formulario de inicio de sesión), salir de la aplicación
                Application.Exit();
            }
        }
    }
}