using System;

namespace Datos
{
    public class ModificarCliente
    {
        public Guid IdCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public ModificarCliente(Guid idCliente, string direccion, string telefono, string email)
        {
            IdCliente = idCliente;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
    }
}
