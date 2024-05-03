using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegocio
    {
        private ProductoService ProductoService = new ProductoService();
        public String idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public List<TraerProductos> listarProductos()
        {
            return ProductoService.GetProductos();
        }

        public void AgregarProductos(int idCategoria, string idUsuario, string idProveedor, string Nombre, int Precio, int Stock)
        {
            AltaProducto altaProducto= new AltaProducto(idCategoria,idUsuario,idProveedor,Nombre, Precio, Stock);
            ProductoService.AgregarProductos(altaProducto);
        }

        public void ModificarProducto(Guid idProducto, Guid idUsuario, int Precio, int Stock)
        {
            ProductoService.ModificarProducto(idProducto, idUsuario, Precio, Stock);

        }

        public void BorrarProducto(Guid idProducto)
        {
            ProductoService.BorrarProducto(idProducto);
        }
    }
}
