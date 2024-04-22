using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuariosActivos
    {
        Guid _id;
        String _nombre;
        String _apellido;
        int _dni;
        String _direccion;
        String _nombreUsuario;
        String _host;

        public UsuariosActivos()
        {
            //
        }

        public UsuariosActivos(string Nombre, string Apellido, int DNI, string Direccion, string Usuario, string Rol)
        {
            _id = Id;
            _nombre = Nombre;
            _apellido = Apellido;
            _dni = DNI;
            _direccion = Direccion;
            _nombreUsuario = Usuario;
            _host = Rol;
        }

        public Guid Id { get => _id; set => _id = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        public int DNI { get => _dni; set => _dni = value; }

        public string Usuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        public string Rol { get => _host; set => _host = value; }

        public String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.DNI + ")";
        }

    }
}
