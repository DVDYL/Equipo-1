using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        private  ClienteService clienteService = new ClienteService();
        private String idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public void agregarCliente(string idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            AltaCliente altaCliente = new AltaCliente(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, "1");
            clienteService.AgregarCliente(altaCliente);
        }

        public void modificarCliente(Guid idCliente, string direccion, string telefono, string email)
        {
            clienteService.ModificarCliente(idCliente, direccion, telefono, email);

        }

        public List<Cliente> listarClientes()
        {
            return clienteService.getClientes();
        }

        public void borrarCliente(Guid idCliente)
        {
            clienteService.BorrarCliente(idCliente);
        }
    }
}
