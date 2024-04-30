using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Negocio
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

            // Verificar si el texto contiene caracteres especiales excepto espacios
            if (text.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                return $"El {nombreCampo} no puede tener caracteres especiales."; // Saco al espaciado como "caracter especial".
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

            // Verificar si el número de DNI ya existe en la lista de usuarios

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            List<UsuariosActivos> usuarios = usuarioNegocio.ListarUsuarios();
            usuarios = usuarios.Where(u => u.NombreUsuario.StartsWith("G1")).ToList(); // Filtrar usuarios cuyo NombreUsuario empiece por "G1"

            string dni = texto;
            int dniNumero;
            if (int.TryParse(dni, out dniNumero))
            {
                if (usuarios.Exists(u => u.DNI == dniNumero))
                {
                    return "No se puede dar de alta un DNI en uso.";
                }
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

        public static string EsDepartamento(string texto)
        {
            // Verificar si la cadena está vacía o es nula
            if (string.IsNullOrWhiteSpace(texto))
            {
                return "El campo Departamento no puede estar vacío.";
            }

            // Verificar la longitud mínima y máxima
            if (texto.Length < 3 || texto.Length > 50)
            {
                return "El campo Departamento debe tener entre 3 y 50 caracteres.";
            }

            // Verificar si la cadena contiene caracteres especiales
            if (!texto.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                return "El campo Departamento no puede contener caracteres especiales.";
            }

            // Si se cumplen todas las condiciones, la calle es válida
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

            // Verificar si los correos electrónicos coinciden ignorando mayúsculas y minúsculas
            if (correo.Equals(confirmation, StringComparison.OrdinalIgnoreCase))
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

        public static string UserLogin(string usuario)   // Verificar cómo se ingresa el usuario en el login
        {
            string errorMessage = "Las credenciales ingresadas son incorrectas"; // Inicializar el mensaje de error como nulo

            // Verificar si el usuario tiene al menos 6 caracteres
            if (usuario.Length < 6)
            {
                return errorMessage;
            }

            // Verificar si el usuario termina en dos dígitos
            if (!char.IsDigit(usuario[usuario.Length - 1]) || !char.IsDigit(usuario[usuario.Length - 2]))
            {
                return errorMessage;
            }

            // Verificar si el usuario contiene espacios o caracteres especiales
            if (Regex.IsMatch(usuario, @"\s"))
            {
                return errorMessage;
            }
            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9]+$"))
            {
                return errorMessage;
            }

            return null; // Si pasa todas las validaciones, el usuario es válido
        }

        public static string PassLogin(string Contraseña)
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

            return "Las credenciales ingresadas son incorrectas";
        }

        public static int EsID(string texto) // VALIDAR ??
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return 0; // Devuelve 0 si el texto está vacío
            }

            // Expresión regular para validar un UUID en formato de hash
            string patron = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";

            // Verifica si el texto coincide con el patrón de expresión regular
            if (Regex.IsMatch(texto, patron))
            {
                return 1; // Devuelve 1 si el texto es un hash UUID válido
            }
            else
            {
                return 2; // Devuelve 2 si el texto no es un hash UUID válido
            }
        }

        public static string MailProveedor(string texto)
        {
            // Verificar si el correo está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo de correo electrónico no puede estar vacío.";
            }

            // Patrón de expresión regular para validar un correo electrónico con dominio @G1.com
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@G1\.com$";

            // Verificar si el correo cumple con el patrón
            if (!Regex.IsMatch(texto, patronCorreo))
            {
                return "El correo electrónico debe tener el dominio @G1.com.";
            }

            //// Verificar si el mail ya existe en la lista de usuarios

            //ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            //List<TraerProveedores> Proveedores = ProveedorNegocio.listarProveedores();
            //Proveedores = ProveedorNegocio.listarProveedores().Where(u => u.Email.Equals(texto)).ToList();

            //// Verificar si se encontró algún Mail
            //if (Proveedores.Count > 0)
            //{
            //    // Si se encontró al menos un CUIT, significa que ya está en uso
            //    return "No se puede dar de alta un Mail en uso.";
            //}

            return null;
        }

        public static string EsCUIT(string texto)
        {
            // Verificar si el texto está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo CUIT no puede estar vacío.";
            }

            // Verificar si el texto tiene longitud diferente de 11 dígitos
            if (texto.Length != 11)
            {
                return "El campo CUIT debe tener exactamente 11 dígitos.";
            }

            // Verificar si el texto contiene algún carácter que no sea un dígito
            if (!texto.All(char.IsDigit))
            {
                return "El campo CUIT debe contener solo dígitos numéricos.";
            }

            // Verificar si el número de CUIT ya existe en la lista de usuarios

            ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            List<TraerProveedores> Proveedores = ProveedorNegocio.listarProveedores();
            Proveedores = ProveedorNegocio.listarProveedores().Where(u => u.CUIT.Contains(texto)).ToList();
            // Proveedores = ProveedorNegocio.listarProveedores().Where(u => u.Email.Contains("G1") && u.CUIT.Contains(texto)).ToList();

            // Verificar si se encontró algún CUIT
            if (Proveedores.Count > 0)
            {
                // Si se encontró al menos un CUIT, significa que ya está en uso
                return "No se puede dar de alta un CUIT en uso.";
            }

            // Si se cumplen todas las condiciones, el campo es válido
            return null;
        }
    }
}
