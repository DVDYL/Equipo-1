using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class BajaProveedor
    {
        Guid _id;
        Guid _idUsuario;

        public BajaProveedor()
        {
            //
        }

        public BajaProveedor(Guid idProveedor, Guid idUsuario)
        {
            _id = idProveedor;
            _idUsuario = idUsuario;
        }

        public Guid idProveedor { get => _id; set => _id = value; }

        public Guid idUsuario { get => _idUsuario; set => _idUsuario = value; }

    }
}
