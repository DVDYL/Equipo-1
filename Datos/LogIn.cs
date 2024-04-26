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
        String _constraseña;

        public LogIn()
        {
            //
        }

        public LogIn(string NombreUsuario, string Contraseña)
        {
            _nombreUsuario = NombreUsuario;
            _constraseña = Contraseña;
        }

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        public string Contraseña { get => _constraseña; set => _constraseña = value; }
        
    }
}
