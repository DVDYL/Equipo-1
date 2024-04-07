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
            // Verificar si el texto está vacío
            if (string.IsNullOrWhiteSpace(text))
            {
                return $"No se especificó el {nombreCampo}.";
            }

            // Verificar si el texto tiene menos de 3 caracteres
            if (text.Length < 3)
            {
                return $"El {nombreCampo} debe tener al menos 3 caracteres.";
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
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo DNI no puede estar vacío.";
            }

            // Verificar si el texto tiene longitud diferente de 8 dígitos
            if (texto.Length != 8)
            {
                return "El campo DNI debe tener exactamente 8 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo DNI debe contener solo dígitos numéricos.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }

        public static string EsEdadLaboral(DateTime fechaNacimiento)
        {
            {
                DateTime fechaHoy = DateTime.Today;// Obtener la fecha de hoy
                if
                (fechaNacimiento >= fechaHoy) // Verificar si la fecha de nacimiento es mayor o igual al día de hoy
                {
                    return
                    "No se puede seleccionar un día posterior a hoy."
                    ;
                }

                else
                {
                    DateTime fechaHace18 = fechaHoy.AddYears(-18);
                    // Calcular fecha de hace 18 años
                    DateTime fechaHace65 = fechaHoy.AddYears(-65);
                    // Calcular fecha de hace 65 años

                    if
                    (fechaNacimiento >= fechaHace18) // Verificar si la fecha de nacimiento está entre hace 18 y hace 65 años

                    {
                        return
                        "No se permite incorporar usuarios menores de edad."
                        ;
                    }

                    else if
                    (fechaNacimiento <= fechaHace65)
                    {
                        return
                        "No se permite incorporar usuarios en edad jubilatoria."
                        ;
                    }

                    else
                    {
                        return
                        null; // Si la fecha de nacimiento cumple con los requisitos, no hay error
                    }
                }
            }
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
           // if (string.IsNullOrWhiteSpace(texto))
            //{
              //  return "El campo Departamento no puede estar vacío.";
           //}  Se quita Validacion, se deja codigo.

            // Verificar la longitud mínima y máxima
            if (texto.Length > 5)
            {
                return "El campo Departamento debe tener como maximo 5 caracteres.";
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

        public static string EsMail(string correo)
        {
            // Verificar si el correo está vacío
            if (string.IsNullOrEmpty(correo))
            {
                return "El campo de correo electrónico no puede estar vacío.";
            }

            // Patrón de expresión regular para validar un correo electrónico
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verificar si el correo cumple con el patrón
            if (Regex.IsMatch(correo, patronCorreo))
            {
                return null; // Si el correo es válido, retornar null indicando que no hay error
            }
            else
            {
                return "El formato del correo electrónico no es válido.";
            }
        }

        public static string ConfirmarMail(string correo, string confirmation)
        {
            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(confirmation))
            {
                return "Ambos campos de correo electrónico son obligatorios.";
            }

            // Verificar si los correos electrónicos coinciden
            if (correo == confirmation)
            {
                return null; // Si los correos coinciden, retornar null indicando que no hay error
            }
            else
            {
                return "Los correos electrónicos no coinciden.";
            }
        }

        public static string EsContraseña(string Contraseña)
        {
            // Verificar si la contraseña está vacía
            if (string.IsNullOrEmpty(Contraseña))
            {
                return "El campo de contraseña no puede estar vacío.";
            }

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

            // Verificar si la contraseña cumple con los criterios de validez
            if (numero && mayuscula && Contraseña.Length >= 8 && Contraseña.Length < 15)
            {
                return null; // Si la contraseña es válida, retornar null indicando que no hay error
            }

            return "La contraseña debe tener al menos una mayúscula, un número y tener entre 8 y 14 caracteres.";
        }

        public static string ConfirmarContraseña(string Contraseña, string confirmation)
        {
            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(Contraseña) || string.IsNullOrEmpty(confirmation))
            {
                return "Ambos campos de contraseña son obligatorios.";
            }

            // Verificar si las contraseñas coinciden
            if (Contraseña == confirmation)
            {
                return null; // Si las contraseñas coinciden, retornar null indicando que no hay error
            }
            else
            {
                return "Las contraseñas no coinciden.";
            }
        }

        public static bool EsUsuario(string usuario, out string errorMessage)
        {
            errorMessage = null; // Inicializar el mensaje de error como nulo

            // Verificar si el usuario tiene al menos 6 caracteres
            if (usuario.Length < 6)
            {
                errorMessage = "El usuario debe tener al menos 6 caracteres.";
                return false;
            }

            // Verificar si el usuario termina en dos dígitos
            if (!char.IsDigit(usuario[usuario.Length - 1]) || !char.IsDigit(usuario[usuario.Length - 2]))
            {
                errorMessage = "El usuario debe terminar en dos dígitos.";
                return false;
            }

            // Verificar si el usuario contiene espacios o caracteres especiales
            if (Regex.IsMatch(usuario, @"\s"))
            {
                errorMessage = "El usuario no puede contener espacios.";
                return false;
            }
            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9]+$"))
            {
                errorMessage = "El usuario solo puede contener letras y números.";
                return false;
            }

            // Si pasa todas las validaciones, el usuario es válido
            return true;
        }
    }
}