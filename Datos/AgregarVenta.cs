using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AgregarVenta
    {
        
        string _idCliente;
        string _idUsuario;
        string _idProducto;
        int _cantidad;
       

        public AgregarVenta(string idCliente, string idUsuario, string idProducto, int cantidad)
        {
            
            _idCliente = idCliente;
            _idUsuario = idUsuario;
            _idProducto = idProducto;
            _cantidad = cantidad;
            
        }

        public string IdUsuario { get => _idUsuario; set => _idUsuario = value;}

        public string IdCliente { get => _idCliente; set => _idCliente = value; }

        public string IdProducto { get => _idProducto; set => _idProducto= value; }

        public int Cantidad { get => _cantidad; set => _cantidad = value; }
    }
}
