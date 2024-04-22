using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        
        Guid _id;
        String _nombre;
        String _apellido;
        int _dni;
        String _direccion;
        String _telefono;
        String _email;
        DateTime _fechaNacimiento;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        String _host;
        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _fechaNacimiento = fechaNacimiento;
        }

        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public string Host { get => _host; set => _host = value; }

        public String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.Dni + ")";
        }
    }
}
