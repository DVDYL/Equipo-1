using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TraerProveedores
    {
        Guid _id;
        String _nombre;
        String _apellido;
        String _email;
        int _cuit;
        DateTime _FechaAlta;
        DateTime? _FechaBaja;

        public TraerProveedores()
        {
            //
        }

        public TraerProveedores(string Nombre, string Apellido,string Email, int CUIT, DateTime FechaAlta, DateTime FechaBaja)
        {
            _id = Id;
            _nombre = Nombre;
            _apellido = Apellido;
            _email = Email;
            _cuit = CUIT;
            _FechaAlta = FechaAlta;
            _FechaBaja = FechaBaja;
        }

        public Guid Id { get => _id; set => _id = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        public string Email { get => _email; set => _email = value; }

        public int CUIT { get => _cuit; set => _cuit = value; }

        public DateTime FechaAlta { get => _FechaAlta; set => _FechaAlta = value; }

        public DateTime? FechaBaja { get => _FechaBaja; set => _FechaBaja = value; }

    }
}