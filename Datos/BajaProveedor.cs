using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BajaProveedor
    {
        string _id;
        string _idUsuario;

        public BajaProveedor()
        {
            //
        }

        public BajaProveedor(string idProveedor, string idUsuario)
        {
            _id = idProveedor;
            _idUsuario = idUsuario;
        }

        public string idProveedor { get => _id; set => _id = value; }

        public string idUsuario { get => _idUsuario; set => _idUsuario = value; }

    }
}
