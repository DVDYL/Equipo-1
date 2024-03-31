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

        public static string EsCalle(string texto)
        {
            // Verificar si la cadena está vacía o es nula
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "El campo Calle no puede estar vacío.";
            }

            // Verificar la longitud mínima y máxima
            if (texto.Length < 3 || texto.Length > 50)
            {
                return "El campo Calle debe tener entre 3 y 50 caracteres.";
            }

            // Verificar si la cadena contiene caracteres especiales
            if (!texto.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                return "El campo Calle no puede contener caracteres especiales.";
            }

            // Si se cumplen todas las condiciones, la calle es válida
            return null;
        }

        public static string EsAltura(string texto)
        {
            // Verificar si la cadena está vacía o es nula
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "El campo Altura no puede estar vacío.";
            }

            // Verificar la longitud mínima y máxima
            if (texto.Length < 1 || texto.Length > 8)
            {
                return "El campo Altura debe tener entre 1 y 8 caracteres.";
            }

            // Verificar si la cadena contiene caracteres especiales
            if (!texto.All(char.IsDigit))
            {
                return "El campo Altura no puede contener caracteres especiales.";
            }

            // Si se cumplen todas las condiciones, la altura es válida
            return null;
        }

        public static string EsDepartamento(string texto)
        {
            // Verificar si la cadena está vacía o es nula
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "El campo Departamento no puede estar vacío.";
            }

            // Verificar la longitud mínima y máxima
            if (texto.Length < 2 || texto.Length > 5)
            {
                return "El campo Departamento debe tener entre 2 y 5 caracteres.";
            }

            // Si se cumplen todas las condiciones, el departamento es válido
            return null;
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
            if (numero && mayuscula && Contraseña.Length >= 8 && Contraseña.Length < 15)
            {
                return true;
            }
            return false;

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


    }
}