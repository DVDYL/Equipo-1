using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CambiarContraseña
    {
        string _nombreUsuario;
        string _contraseña;
        string _contraseñaNueva;
        public CambiarContraseña()
        {
            //
        }
        public CambiarContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            _nombreUsuario = nombreUsuario;
            _contraseña = contraseña;
            _contraseñaNueva = contraseñaNueva;
        }
    }
}