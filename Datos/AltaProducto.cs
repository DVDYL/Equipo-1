using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AltaProducto
    {
        int _idCategoria;
        Guid _idUsuario;
        Guid _idProveedor;
        String _nombre;
        int _precio;
        int _stock;

        public AltaProducto(int idCategoria, Guid idUsuario, Guid idProveedor, string Nombre, int Precio, int Stock)
        {
            _idCategoria = idCategoria;
            _idUsuario = idUsuario;
            _idProveedor = idProveedor;
            _nombre = Nombre;
            _precio = Precio;
            _stock = Stock;
        }

        public int IdCategoria{ get => _idCategoria; set => _idCategoria = value; }

        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public Guid idProveedor { get => _idProveedor; set => _idProveedor= value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public int Precio { get => _precio; set => _precio= value; }
        public int Stock { get => _stock; set => _stock= value; }

    }
}
