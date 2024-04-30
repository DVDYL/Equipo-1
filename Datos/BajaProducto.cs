using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BajaProducto
    {
        Guid _id;
        Guid _idUsuario;

        public BajaProducto()
        {
            //
        }

        public BajaProducto(Guid idProducto, Guid idUsuario)
        {
            _id = idProducto;
            _idUsuario = idUsuario;
        }

        public Guid idProducto { get => _id; set => _id = value; }

        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }

    }
}
