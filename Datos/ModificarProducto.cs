using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ModificarProducto
    {
        string _id;
        string _idUsuario;
        int _precio;
        int _stock;

        public ModificarProducto()
        {
            //
        }

        public ModificarProducto(string idProducto, string idUsuario, int Precio, int Stock)
        {
            _id = idProducto;
            _idUsuario = idUsuario;
            _precio = Precio;
            _stock = Stock;
        }

        public string idProducto { get => _id; set => _id = value; }

        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }

        public int Precio { get => _precio; set => _precio= value; }

        public int Stock { get => _stock; set => _stock= value; }

    }
}
