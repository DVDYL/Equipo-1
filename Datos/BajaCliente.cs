using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BajaCliente
    {
        Guid _id;
       

        public BajaCliente()
        {
            //
        }

        public BajaCliente(Guid idCliente)
        {
            _id = idCliente;
        }

        public Guid idCliente { get => _id; set => _id = value; }


    }
}
