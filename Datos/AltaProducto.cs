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
        string _idUsuario;
        string _idProveedor;
        string _nombre;
        int _precio;
        int _stock;

        public AltaProducto(int idCategoria, string idUsuario, string idProveedor, string Nombre, int Precio, int Stock)
        {
            _idCategoria = idCategoria;
            _idUsuario = idUsuario;
            _idProveedor = idProveedor;
            _nombre = Nombre;
            _precio = Precio;
            _stock = Stock;
        }

        public int IdCategoria{ get => _idCategoria; set => _idCategoria = value; }

        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public string idProveedor { get => _idProveedor; set => _idProveedor= value; }

        public string Nombre { get => _nombre; set => _nombre = value; }

        public int Precio { get => _precio; set => _precio= value; }
        public int Stock { get => _stock; set => _stock= value; }

    }
}
