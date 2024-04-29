using System;

namespace Datos
{
    public class ModificarProveedor
    {
        Guid _id;
        Guid _idUsuario;
        String _nombre;
        String _apellido;
        String _email;
        String _cuit;

        public ModificarProveedor()
        {
            //
        }

        public ModificarProveedor(Guid idProveedor, Guid idUsuario, string Nombre, string Apellido, string email, string CUIT)
        {
            _id = idProveedor;
            _idUsuario = idUsuario;
            _nombre = Nombre;
            _apellido = Apellido;
            _email = email;
            _cuit = CUIT;
        }

        public Guid idProveedor { get => _id; set => _id = value; }

        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public string Apellido { get => _apellido; set => _apellido = value; }

        public string email { get => _email; set => _email = value; }

        public string CUIT { get => _cuit; set => _cuit = value; }
    }
}