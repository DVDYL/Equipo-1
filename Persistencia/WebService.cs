using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http; //Importamos código para WS.
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class WebService
    {
        private readonly HttpClient _client;  // Declaramos un campo privado de tipo HttpClient llamado _client

        public WebService() // Constructor de la clase WebService
        {
            _client = new HttpClient(); // Inicializamos el campo _client con un nuevo objeto HttpClient
            _client.BaseAddress = new Uri("https://cai-tp.azurewebsites.net/api/"); // Establecemos URL base del WS donde se va a conectar el cliente HttpClient
        }

        // De acá en adelante, pondremos los métodos correspondientes, luego de la explicación del profesor.
        //Una vez que tengamos los métodos correspondientes, los llamaremos en las instancias que correspondan
    }
}
