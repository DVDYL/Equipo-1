using System;

namespace Datos
{
    public class AltaProveedor
    {
        String _idUsuario;
        String _nombre;
        String _apellido;
        String _email;
        String _cuit;

        public AltaProveedor(string idUsuario, string Nombre, string Apellido, string email, string CUIT)
        {
            _idUsuario = idUsuario;
            _nombre = Nombre;
            _apellido = Apellido;
            _email = email;
            _cuit = CUIT;
        }

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        public string Email { get => _email; set => _email = value; }

        public string CUIT { get => _cuit; set => _cuit = value; }

    }
}
