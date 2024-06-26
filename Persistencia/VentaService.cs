﻿using Datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class VentaService
    {
        public TraerVenta TraerVenta()
        {
            String path = "/api/Venta/GetVenta";
            TraerVenta venta = null;

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    venta = JsonConvert.DeserializeObject<TraerVenta>(contentStream);
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

            return venta;
        }

        public void DevolverVenta(string idVenta, string idUsuario)
        {
            String path = "/api/Venta/DevolverVenta";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", idVenta);
            map.Add("idUsuario", idUsuario);

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

        public void AgregarVenta(AgregarVenta agregarVenta)
        {
            String path = "/api/Venta/AgregarVenta";

            var jsonRequest = JsonConvert.SerializeObject(agregarVenta);

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

        

        public List<TraerVentaPorCliente> GetVentasCliente(string idCliente)
        {
            String path = "/api/Venta/GetVentaByCliente?id=" + idCliente;
            List<TraerVentaPorCliente> VentasCliente = new List<TraerVentaPorCliente>();

            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    List<TraerVentaPorCliente> listadoVentasCliente = JsonConvert.DeserializeObject<List<TraerVentaPorCliente>>(contentStream);
                    return listadoVentasCliente;
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
            return VentasCliente;
        }

    }
}
