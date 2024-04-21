using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Proveedor
    {
        Guid _id;
        Guid _idcatproducto;
        String _nombre;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        int _cuit;
        string _email;
        string _apellido;
        Guid _idusuario;


        public Proveedor()
        {
            //
        }

        public Proveedor(string nombre, string apellido,string email, int cuit)
        {
            _nombre = nombre;
            _apellido = apellido;
            _cuit = cuit;
            _email = email;
        }
        public Guid Id { get => _id; set => _id = value; }

        public Guid Idcatproducto { get => _idcatproducto; set => _idcatproducto = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }

        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }

        public int Cuit { get => _cuit; set => _cuit = value; }

        public string Email { get => _email; set => _email = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        public Guid IdUsuario { get => _idusuario; set => _idusuario = value; }


    }
}
