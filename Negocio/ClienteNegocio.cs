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
        private  String id = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public void agregarCliente(string idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, string host)
        {
            AltaCliente altaCliente = new AltaCliente(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, "1");
            clienteService.AgregarCliente(altaCliente);
        }

        public void modificarCliente(string id, string direccion, string telefono, string email)
        {
            clienteService.ModificarCliente(id, direccion, telefono, email);
        }

        public List<Cliente> listarClientes()
        {
            return clienteService.getClientes();
        }

        //public void TraerCliente(string idUsuario, string nombre, string apellido, int dni, string direccion, string telefono, string email, DateTime fechaNacimiento, DateTime fechaAlta, DateTime fechaBaja, string host)
        //{
        //    Cliente VerCliente = new Cliente(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, fechaAlta, fechaBaja, host);
        //    VerCliente.TraerCliente(VerCliente);
        //}

        public void BorrarCliente(string idCliente)
        {
            clienteService.BorrarCliente(idCliente);
        }
    }
}
