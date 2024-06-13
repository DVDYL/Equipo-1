using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Datos
{
    public class VentasTXT
    {
        public int IdTransaccion { get; set; }
        public string NombreVendedor { get; set; }
        public string NombreCliente { get; set; }
        public List<string> Productos { get; set; } = new List<string>();
        public string MontoTotal { get; set; }

    }
}
