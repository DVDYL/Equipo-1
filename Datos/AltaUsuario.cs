using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AltaUsuario
    {
        String _idUsuario;
        int _host;
        String _nombre;
        String _apellido;
        int _dni;
        String _direccion;
        String _telefono;
        String _email;
        DateTime _fechaNacimiento;
        String _nombreUsuario;
        String _constraseña;


        public AltaUsuario(
            string idUsuario,
            int host,
            string nombre,
            string apellido,
            int dni,
            string direccion,
            string telefono,
            string email,
            DateTime fechaNacimiento,
            string NombreUsuario,
            string Contraseña
            )
        {
            _idUsuario = idUsuario;
            _host = host;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _fechaNacimiento = fechaNacimiento;
            _nombreUsuario = NombreUsuario;
            _constraseña = Contraseña;
        }

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public int Host { get => _host; set => _host = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        public int DNI { get => _dni; set => _dni = value; }

        public string Direccion { get => _direccion; set => _direccion = value; }

        public string Telefono { get => _telefono; set => _telefono = value; }

        public string Email { get => _email; set => _email = value; }

        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        public string Contraseña { get => _constraseña; set => _constraseña = value; }
    }
}
