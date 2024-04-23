using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class Proveedor
    {
        Guid _id;
        String _nombre;
        String _apellido;
        String _email;
        int _cuit;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;

        public Proveedor()
        {
        }

        public Proveedor(string nombre, string apellido, int cuit, string email, DateTime fechaAlta, DateTime fechaBaja)
        {
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _cuit = cuit;
            _fechaAlta = fechaAlta;
            _fechaBaja = fechaBaja;
        }

        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Cuit { get => _cuit; set => _cuit = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

        public String ToString()
        {
            return this.Apellido + ", " + this.Nombre + " (" + this.Cuit + ")";
        }
    }
}
