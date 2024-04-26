using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Persistencia
{
    public class ProveedorService
    {
        public List<TraerProveedores> GetProveedores()
        {
            String path = "/api/Proveedor/TraerProveedores";
            List<TraerProveedores> Proveedores = new List<TraerProveedores>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<TraerProveedores> listadoProveedores = JsonConvert.DeserializeObject<List<TraerProveedores>>(contentStream);
                    return listadoProveedores;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return Proveedores;
        }

        public void AgregarProveedor(AltaProveedor altaProveedor)
        {
            String path = "/api/Proveedor/AgregarProveedor";

            var jsonRequest = JsonConvert.SerializeObject(altaProveedor);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void ModificarProveedor(Guid idProveedor, Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            String path = "/api/Proveedor/ModificarProveedor";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idProveedor.ToString());
            map.Add("idUsuario", idUsuario.ToString());
            map.Add("nombre", nombre);
            map.Add("apellido", apellido);
            map.Add("email", email);
            map.Add("cuit", cuit);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void BorrarProveedor(Guid idProveedor) //Validar Tema de Parametro
        {
            String path = "/api/Proveedor/BajaProveedor" + idProveedor;

            try
            {
                HttpResponseMessage response = WebHelper.Delete(path);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

    }
}
