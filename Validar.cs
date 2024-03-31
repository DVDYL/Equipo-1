using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipo1
{
    public static class Validar
    {
        public static string EsNombre(string text, string nombreCampo)
        {
            // Verificar si el texto tiene menos de 3 caracteres
            if (text.Length < 3)
            {
                return $"El {nombreCampo} debe tener al menos 3 caracteres.";
            }

            // Verificar si el texto está vacío
            if (string.IsNullOrWhiteSpace(text))
            {
                return $"No se especificó el {nombreCampo}.";
            }

            // Verificar si el texto contiene números
            if (text.Any(char.IsDigit))
            {
                return $"El {nombreCampo} no puede tener números.";
            }

            // Verificar si el texto contiene caracteres especiales
            if (text.Any(c => !char.IsLetterOrDigit(c)))
            {
                return $"El {nombreCampo} no puede tener caracteres especiales.";
            }

            // Si pasa todas las condiciones, el texto es válido
            return null; // Retorna null si el nombre es válido
        }

        public static string EsDNI(string texto)
        {
            // Verificar si el texto tiene longitud diferente de 8 dígitos
            if (texto.Length != 8)
            {
                return "El campo DNI debe tener exactamente 8 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo DNI debe contener únicamente dígitos numéricos.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }

        public static bool EsEdadLaboral(DateTime fechaNacimiento)
        {
            // Calcular fecha de hace 18 años
            DateTime fechaHace18 = DateTime.Today.AddYears(-18);
            // Calcular fecha de hace 65 años
            DateTime fechaHace65 = DateTime.Today.AddYears(-65);

            // Verificar si la fecha de nacimiento está entre hace 18 y hace 65 años
            return (fechaNacimiento < fechaHace18 && fechaNacimiento > fechaHace65);
        }

        public static string EsTelefono(string texto)
        {
            // Verificar si el texto tiene longitud fuera del rango de 8 a 12 dígitos
            if (texto.Length < 8 || texto.Length > 12)
            {
                return "El campo Teléfono debe tener entre 8 y 12 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo Teléfono debe contener únicamente dígitos numéricos.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }

        public static bool EsMail(string correo)
        {
            // Patrón de expresión regular para validar un correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            
            // Lo que hacemos acá es asegurar que la persona ingrese el mail cumpliendo con el patrón.
            if (Regex.IsMatch(correo, patronCorreo))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool ConfirmarMail(string correo, string confirmation)
        {
            if (correo == confirmation)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool ConfirmarContraseña(string Contraseña, string confirmation)
        {
            if (Contraseña == confirmation)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool EsContraseñaValida(string Contraseña)
        {
            bool mayuscula = false;
            bool numero = false;

            for (int i = 0; i < Contraseña.Length; i++)
            {
                if (Char.IsUpper(Contraseña, i))
                {
                    mayuscula = true;
                }
                else if (Char.IsDigit(Contraseña, i))
                {
                    numero = true;
                }
            }
            if (numero && mayuscula && Contraseña.Length > 8 && Contraseña.Length < 15)
            {
                return true;
            }
            return false;

        }
    }
}