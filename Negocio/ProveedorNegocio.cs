using Datos;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class ProveedorNegocio
    {
        private ProveedorService proveedorService = new ProveedorService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<TraerProveedores> listarProveedores()
        {
            return proveedorService.GetProveedores();
        }

        public void AgregarProveedor(string nombre, string apellido, string cuit, string email)
        {
            AltaProveedor altaProveedor = new AltaProveedor(idAdministrador, nombre, apellido, cuit, email);
            proveedorService.AgregarProveedor(altaProveedor);

        }

        public void ModificarProveedor(Guid idProveedor, Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            proveedorService.ModificarProveedor(idProveedor, idUsuario, nombre, apellido, email, cuit);

        }

        public void BorrarProveedor(Guid idProveedor)
        {
            proveedorService.BorrarProveedor(idProveedor);
        }
    }
}
