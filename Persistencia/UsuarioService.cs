using Datos;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Persistencia
{
    public class UsuarioService
    {
        public List<UsuariosActivos> GetUsuarios()
        {
            String path = "/api/Usuario/TraerUsuariosActivos?id=70b37dc1-8fde-4840-be47-9ababd0ee7e5";
            List<UsuariosActivos> Usuarios = new List<UsuariosActivos>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<UsuariosActivos> listadoUsuarios = JsonConvert.DeserializeObject<List<UsuariosActivos>>(contentStream);
                    return listadoUsuarios;
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
            return Usuarios;
        }

        public void ModificarUsuario(Guid idUsuario, String direccion, String telefono, String email)
        {
            String path = "/api/Usuario/PatchUsuario";
            Dictionary<string, string> map = new Dictionary<string, string>
            {
                { "id", idUsuario.ToString() },
                { "direccion", direccion },
                { "telefono", telefono },
                { "email", email }
            };

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

        public void AgregarUsuario(AltaUsuario AltaUsuario)
        {
            String path = "/api/Usuario/AgregarUsuario";

            var jsonRequest = JsonConvert.SerializeObject(AltaUsuario);

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

        public void BorrarUsuario(Guid idUsuario)
        {
            String path = "/api/Cliente/BajaUsuario?id=" + idUsuario;

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

        public string IniciarSesion(LogIn IniciarSesion)
        {
            string id = null; // Variable para almacenar el id

            string path = "/api/Usuario/Login";
            var jsonRequest = JsonConvert.SerializeObject(IniciarSesion);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStreamAsync().Result;
                    using (var reader = new StreamReader(contentStream))
                    {
                        string responseContent = reader.ReadToEnd();
                        id = responseContent; // Asignar el id del body
                        Console.WriteLine($"Hash: {id}");
                    }
                }
                else
                {
                    var contentStream = response.Content.ReadAsStreamAsync().Result;
                    using (var reader = new StreamReader(contentStream))
                    {
                        string responseContent = reader.ReadToEnd();
                        id = responseContent; // Asignar el id del body
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return id; // Retornar el id obtenido
        }
        public void CambiarContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            /*string path = "/api/Usuario/CambiarContraseña";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);*/
        }

    }
}

