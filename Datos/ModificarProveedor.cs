using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ModificarProveedor
    {
        public Guid IdProveedor { get; set; }
        public Guid IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Cuit { get; set; }

        public ModificarProveedor(Guid idProveedor,Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            IdProveedor = idProveedor;
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email; 
            Cuit = cuit;
        }
    }
}
