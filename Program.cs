using Form_Equipo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipo1
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
            LogIn loginForm = new LogIn();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el inicio de sesión es exitoso, iniciar la aplicación principal
                Application.Run(new UserAdmin());
            }
            else
            {
                // Si el inicio de sesión falla (por ejemplo, si se cierra el formulario de inicio de sesión), salir de la aplicación
                Application.Exit();
            }
        }
    }
}
