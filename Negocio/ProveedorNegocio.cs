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
    }
}
