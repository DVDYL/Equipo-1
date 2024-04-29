using Datos;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ProveedorNegocio
    {
        private ProveedorService ProveedorService = new ProveedorService();
        public String idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<TraerProveedores> listarProveedores()
        {
            return ProveedorService.GetProveedores();
        }

        public void AgregarProveedor(string idUsuario, string Nombre, string Apellido, string CUIT, string email)
        {
            AltaProveedor altaProveedor = new AltaProveedor(idUsuario, Nombre, Apellido, CUIT, email);
            ProveedorService.AgregarProveedor(altaProveedor);
        }

        public void ModificarProveedor(Guid idProveedor, Guid idUsuario, string Nombre, string Apellido, string email, string CUIT)
        {
            ProveedorService.ModificarProveedor(idProveedor, idUsuario, Nombre, Apellido, email, CUIT);

        }

        public void BorrarProveedor(Guid idProveedor)
        {
            ProveedorService.BorrarProveedor(idProveedor);
        }
    }
}
