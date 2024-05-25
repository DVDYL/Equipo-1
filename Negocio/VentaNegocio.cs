using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaNegocio
    {
        private VentaService ventaService = new VentaService();
        private String id = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";


        public TraerVenta traerVenta()
        {
            return ventaService.TraerVenta();
        }
        public void agregarVenta(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            AgregarVenta agregarVenta = new AgregarVenta(idCliente, idUsuario, idProducto, cantidad);
            ventaService.AgregarVenta(agregarVenta);

        }

        public void devolverVenta(string idVenta, string idUsuario)
        {
            ventaService.DevolverVenta(idVenta,idUsuario);
        }

    }

}
