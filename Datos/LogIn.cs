using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LogIn
    {
        String _nombreUsuario;
        String _contraseña;

        public LogIn()
        {
            //
        }

        public LogIn(string NombreUsuario, string Contraseña)
        {
            _nombreUsuario = NombreUsuario;
            _contraseña = Contraseña;
        }

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        public string Contraseña { get => _contraseña; set => _contraseña = value; }
        
    }
}
