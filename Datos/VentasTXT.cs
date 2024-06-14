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
        public DateTime FechaVenta { get; set; } // Nueva propiedad para la fecha

        public int IdTransaccion { get; set; }

        public string NombreVendedor { get; set; }

        public string NombreCliente { get; set; }

        public List<string> Productos { get; set; } = new List<string>();

        public List<string> Categorias { get; set; } // Debe ser List<string> si almacena categorías

        public List<int> Cantidades { get; set; } // Debe ser List<int> si almacena cantidades

        public string MontoTotal { get; set; }

    }
}
