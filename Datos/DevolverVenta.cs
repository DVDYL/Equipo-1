using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DevolverVenta
    {
        Guid _id;
        Guid _idUsuario;

        public DevolverVenta()
        {
            //
        }

        public DevolverVenta(Guid idVenta, Guid idUsuario)
        {
            _id = idVenta;
            _idUsuario = idUsuario;
        }

        public Guid idVenta { get => _id; set => _id = value; }
        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }
    }

    

 

}
