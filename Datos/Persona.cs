using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipo1
{
    public abstract class Persona     // Define la clase abstracta Persona
    {

        public string Nombre { get; set; }         // Propiedades de la clase Persona
        public int Edad { get; set; }

        public abstract void Saludar();         // Método abstracto que debe ser implementado por las clases derivadas
    }
}
