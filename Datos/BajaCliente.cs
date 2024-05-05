using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BajaCliente
    {
        string _id;

        public BajaCliente()
        {
            //
        }

        public BajaCliente(string idCliente)
        {
            _id = idCliente;
        }

        public string idCliente { get => _id; set => _id = value; }

    }
}
