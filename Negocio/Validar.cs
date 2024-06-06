using Datos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

            // Verificar si el número de DNI ya existe en la lista de usuarios, clientes y proveedores

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            List<UsuariosActivos> usuarios = usuarioNegocio.ListarUsuarios();
            usuarios = usuarios.Where(u => u.NombreUsuario.StartsWith("G1")).ToList(); // Filtrar usuarios cuyo NombreUsuario empiece por "G1"

            string dni = texto;
            int dniNumero;

            if (int.TryParse(dni, out dniNumero))
            {
                if (usuarios.Exists(u => u.DNI == dniNumero))
                {
                    return "Este DNI ya existe como usuario.";
                }
            }

            ClienteNegocio clientenegocio = new ClienteNegocio();
            List<Cliente> clientes = clientenegocio.listarClientes();
            // clientes = clientes.Where(u => u.NombreUsuario.StartsWith("G1")).ToList(); // Filtrar usuarios cuyo NombreUsuario empiece por "G1"


            if (int.TryParse(dni, out dniNumero))
            {
                if (clientes.Exists(u => u.DNI == dniNumero))
                {
                    return "Este DNI ya existe como cliente.";
                }
            } // Verificar si el número de DNI asociado ya existe en la lista de clientes

            // Verificar si el número de DNI ya existe en la lista de proveedores

            ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            List<TraerProveedores> Proveedores = ProveedorNegocio.listarProveedores();
            Proveedores = ProveedorNegocio.listarProveedores().Where(u => u.CUIT.Contains(texto)).ToList();

            // Verificar si se encontró algún CUIT
            if (Proveedores.Count > 0)
            {
                // Si se encontró al menos un CUIT, significa que ya está en uso
                return "No se puede dar de alta al DNI de un proveedor.";
            }
            // Si se cumplen todas las condiciones, el campo es válido
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

            // Verificar si el número de CUIT empieza en 2 o en 3
            if (texto[0] != '2' && texto[0] != '3')
            {
                return "El primer dígito del CUIT debe ser 2 o 3.";
            }

            // Verificar si el número de CUIT ya existe en la lista de proveedores

            ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            List<TraerProveedores> Proveedores = ProveedorNegocio.listarProveedores();
            Proveedores = ProveedorNegocio.listarProveedores().Where(u => u.CUIT.Contains(texto)).ToList();

            // Verificar si se encontró algún CUIT
            if (Proveedores.Count > 0)
            {
                // Si se encontró al menos un CUIT, significa que ya está en uso
                return "No se puede dar de alta un CUIT en uso.";
            }

            // Verificar si el número de DNI asociado ya existe en la lista de usuarios
            if (int.TryParse(texto.Substring(2, 8), out int DNI))
            {
                UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
                List<UsuariosActivos> usuarios = UsuarioNegocio.ListarUsuarios();
                usuarios = UsuarioNegocio.ListarUsuarios().Where(u => u.DNI == DNI).ToList();

                // Verificar si se encontró algún CUIT
                if (usuarios.Count > 0)
                {
                    // Si se encontró al menos un CUIT, significa que ya está en uso
                    return "No se puede dar de alta un como proveedor a un usuario.";
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

        public static string EsMail(string texto)
        {
            // Verificar si el correo está vacío
            if (string.IsNullOrEmpty(texto))
            {
                return "El campo de correo electrónico no puede estar vacío.";
            }

            // Patrón de expresión regular para validar un correo electrónico con dominio @G1.com
            string patronCorreo = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            string patronDominio = @"@G1\.com$";

            // Verificar si el correo cumple con el patrón
            if (!Regex.IsMatch(texto, patronCorreo))
            {
                return "El correo electrónico es inválido.";
            }

            if (texto.Contains(" "))
            {
                return "El correo electrónico no puede contener espacios en blanco.";
            }
            if (!Regex.IsMatch(texto, patronDominio))
            {
                return "El correo electrónico ser del dominio @G1.com";
            }

            // Verificar si el mail ya existe en la lista de proveedores

            ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            List<TraerProveedores> Proveedores = ProveedorNegocio.listarProveedores();

            if (Proveedores.Any(u => u != null && u.Email != null && u.Email.Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return "No se puede dar de alta un correo electrónico de un proveedor para un usuario.";
            }

            // Verificar si el mail ya existe en la lista de clientes

            ClienteNegocio clientenegocio = new ClienteNegocio();
            List<Cliente> clientes = clientenegocio.listarClientes();

            if (clientes.Any(u => u != null && u.Email != null && u.Email.Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return "No se puede dar de alta un correo electrónico de un cliente para un usuario.";
            }

            return null;
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

        public static string CampoEnBlanco(string texto)   // Verificar cómo se ingresa el usuario en el login
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "1";
            }

            return "0";
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

        public static string EsNumero(string valor, string campo)
        {

            string error = "";

            if (string.IsNullOrEmpty(valor))
            {
                return "El campo " + campo + " no puede estar vacío.";
            }

            if (!int.TryParse(valor, out int salida))
            {
                error = "El campo " + campo + " no es numérico." + Environment.NewLine;
            }
            else if (salida <= 0)
            {
                error = "El campo " + campo + " no es positivo." + Environment.NewLine;
            }

            return null;
        }

        public static string EsStock(string valor, string campo)
        {
            // Verificar si el valor está vacío o nulo
            if (string.IsNullOrEmpty(valor))
            {
                return "El campo " + campo + " no puede estar vacío.";
            }

            // Verificar si el valor contiene caracteres no numéricos
            if (!int.TryParse(valor, out _))
            {
                return "El campo " + campo + " no puede contener letras ni caracteres especiales.";
            }

            // Convertir el valor a entero
            int stock = int.Parse(valor);

            // Verificar si el valor es menor o igual a cero
            if (stock <= 0)
            {
                return "El campo " + campo + " debe ser un número positivo.";
            }

            // Verificar si el valor es mayor a 1000
            if (stock > 1000)
            {
                return "El campo " + campo + " no puede ser mayor a 1000.";
            }

            // Si todas las validaciones pasan, devolver null
            return null;
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

            if (texto.Contains(" "))
            {
                return "El correo electrónico no puede contener espacios en blanco.";
            }

            // Verificar si el mail ya existe en la lista de proveedores

            ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            List<TraerProveedores> Proveedores = ProveedorNegocio.listarProveedores();

            if (Proveedores.Any(u => u != null && u.Email != null && u.Email.Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return "No se puede dar de alta un correo electrónico en uso.";
            }

            // Verificar si el mail ya existe en la lista de clientes

            ClienteNegocio clientenegocio = new ClienteNegocio();
            List<Cliente> clientes = clientenegocio.listarClientes();

            if (clientes.Any(u => u != null && u.Email != null && u.Email.Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return "No se puede dar de alta un correo electrónico de un cliente para un proveedor.";
            }

            return null;
        }

        public static string MailCliente(string texto)
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

            if (texto.Contains(" "))
            {
                return "El correo electrónico no puede contener espacios en blanco.";
            }

            // Verificar si el mail ya existe en la lista de clientes

            ClienteNegocio clientenegocio = new ClienteNegocio();
            List<Cliente> clientes = clientenegocio.listarClientes();

            if (clientes.Any(u => u != null && u.Email != null && u.Email.Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return "No se puede dar de alta un correo electrónico en uso.";
            }

            // Verificar si el mail ya existe en la lista de proveedores

            ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            List<TraerProveedores> Proveedores = ProveedorNegocio.listarProveedores();

            if (Proveedores.Any(u => u != null && u.Email != null && u.Email.Trim().Equals(texto.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return "No se puede dar de alta el correo electrónico de un proveedor para un cliente.";
            }

            return null;
        }

        public static string NumeroHost(string nombreUsuario)
        {
            if (nombreUsuario == "ADMINI24")
            {
                // Devuelves el número de host para el administrador
                return "1";
            }

            // Listar todos los usuarios activos
            UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
            List<UsuariosActivos> usuarios = UsuarioNegocio.ListarUsuarios();

            // Buscar el usuario por el nombre de usuario ingresado
            UsuariosActivos usuarioEncontrado = usuarios.FirstOrDefault(u => u.NombreUsuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));

            // Si se encuentra el usuario, devolver su número de host
            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado.Host;
            }
            else
            {
                return null;

                // throw new InvalidOperationException("El usuario ingresado no se encuentra en la lista de usuarios activos.");
            }
        }
        public static bool UsuarioInactivo(string usuario)
        {
            string nombreArchivo = "Usuarios.txt";
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string path = Path.Combine(directorio, nombreArchivo);
            try
            {
                if (File.Exists(path))
                {
                    string[] lineasTXT = File.ReadAllLines(path);

                    foreach (string linea in lineasTXT)
                    {
                        if (linea.StartsWith(usuario + ";"))
                        {
                            string[] parametros = linea.Split(';');
                            if (parametros.Length > 3)
                            {
                                string estado = parametros[3];
                                if (estado == "inactivo")
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public static bool ContraseñaExpirada(string usuario)
        {
            string nombreArchivo = "Usuarios.txt";
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string path = Path.Combine(directorio, nombreArchivo);
            try
            {
                if (File.Exists(path))
                {
                    string[] lineasTXT = File.ReadAllLines(path);

                    foreach (string linea in lineasTXT)
                    {
                        if (linea.StartsWith(usuario + ";"))
                        {
                            string[] parametros = linea.Split(';');
                            if (parametros.Length > 2)
                            {
                                string UltimoCambio = parametros[2];
                                DateTime fechaUltimoCambio = DateTime.ParseExact(UltimoCambio, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                                int diasExpiracion = 30; // Si pasaron 30 días
                                if (DateTime.Now.Subtract(fechaUltimoCambio).TotalDays > diasExpiracion)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        //public static int CodigoProducto(string msj) // Pedir un número entre 1 y 37 
            //{
            //    int valor;
            //    bool valido = true;

            //    do
            //    {
            //        Console.WriteLine("\n------------\n\nIngresá un código de producto del 1 al 37.");

            //        if (int.TryParse(Console.ReadLine(), out valor) && valor >= 1 && valor <= 37)
            //        {
            //            valido = false; // Si no se cumple la condición, establece 'valido' en falso y sale del bucle.
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nError: No elegíste un código de producto del 1 al 37. Intentá de nuevo.");
            //        }

            //    } while (valido);

            //    return valor;
            //}

            //public static int Precio(string msj) // Pedir un número entero, de 1 a 800
            //{
            //    int valor;
            //    bool valido = true;

            //    do
            //    {
            //        Console.WriteLine(msj);

            //        if (int.TryParse(Console.ReadLine(), out valor) && valor >= 0 && valor <= 800)
            //        {
            //            valido = false; // Si es un entero positivo, establece 'valido' en falso y sale del bucle.
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nERROR: El precio del producto debe estar entre 1 y 800.\n");
            //        }

            //    } while (valido);

            //    return valor;
            //}

            //public static bool StockVacio()
            //{
            //    bool StockVacio = false;

            //    for (int i = 0; i < ListadoProductos.GetLength(0); i++)
            //    {
            //        if (int.TryParse(ListadoProductos[i, 3], out int stock) && stock != 0)
            //        {
            //            StockVacio = true;
            //            break;
            //        }
            //    }

            //    if (!StockVacio)
            //    {
            //        Console.WriteLine("\nError: No hay productos con stock en el inventario para realizar esta operación.\n → Para poder tomar productos del inventario, deberás tener al menos un producto con stock disponible.\nVolviendo al menú anterior...");
            //        return false;
            //    }

            //    return true;
            //} // Verifica si el inventario tiene todas las cantidades en 0.

            //public static bool VerificarInventario()
            //{
            //    bool PrecioVacio = false;
            //    bool StockVacio = false;

            //    for (int i = 0; i < ListadoProductos.GetLength(0); i++)
            //    {
            //        if (int.TryParse(ListadoProductos[i, 2], out int precio) && precio != 0)
            //        {
            //            PrecioVacio = true;
            //            break;
            //        }
            //    }

            //    for (int i = 0; i < ListadoProductos.GetLength(0); i++)
            //    {
            //        if (int.TryParse(ListadoProductos[i, 3], out int stock) && stock != 0)
            //        {
            //            StockVacio = true;
            //            break;
            //        }
            //    }

            //    if (!PrecioVacio && !StockVacio)
            //    {
            //        Console.WriteLine("\nError: Todas las cantidades y precios del inventario están en 0 (cero).\n → Para poder iniciar una venta, deberás cargar el precio y cantidad(es) de al menos un producto.\nVolviendo al menú anterior...");
            //        return false;
            //    }

            //    if (!PrecioVacio)
            //    {
            //        Console.WriteLine("\nError: No hay productos con precio para realizar la venta.\n → Para poder iniciar una venta, deberás cargar el precio de al menos un producto.\nVolviendo al menú anterior...");
            //        return false;
            //    }

            //    if (!StockVacio)
            //    {
            //        Console.WriteLine("\nError: No hay productos con stock para realizar la venta.\n → Para poder iniciar una venta, deberás tener al menos un producto con stock disponible.\nVolviendo al menú anterior...");
            //        return false;
            //    }

            //    return true;
            //} // Control para saber si la matriz tiene precios y stock en 0 para todos sus productos.

            //public void Carrito()
            //{
            //    if (!VerificarInventario())
            //    {
            //        return; // La verificación del inventario falló, por lo que no continuamos con la venta.
            //    } // Antes de iniciar la venta, controlo que el inventario tenga al menos un producto con cantidad y precio.

            //    // Títulos del carrito de compras (oculto, ya que calcula todos los ingresos del usuario para imprimir la matriz acumulada)
            //    Carrito[0, 0] = "ORDEN";
            //    Carrito[0, 1] = "CÓDIGO";
            //    Carrito[0, 2] = "DETALLE";
            //    Carrito[0, 3] = "CANTIDAD";
            //    Carrito[0, 4] = "PRECIO";
            //    Carrito[0, 5] = "TOTAL";

            //    int opcion;

            //    do
            //    {
            //        opcion = Validar.OpcionMenu($"\n-------\n\n1: Cargar productos a la venta n°{NuevaVenta}\n2: Ver el Carrito y sus productos añadidos\n3: Cerrar la venta para poder cobrarla.\n0: Volver al menú anterior\n", 0, 3);

            //        if (opcion == 0)
            //        {
            //            Console.WriteLine($"\nSaliendo de la venta n°{NuevaVenta}.\n → Volviendo al menú anterior...");
            //            return;
            //        }

            //        if (opcion == 1)
            //        {
            //            if (Ventas[NuevaVenta, 4] == "SI")
            //            {
            //                Console.WriteLine($"\nERROR: La venta n°{NuevaVenta} se encuentra CERRADA y no se pueden añadir más productos al carrito.\n → Para iniciar la venta n° {NuevaVenta + 1}, deberás primero cobrar la venta n°{NuevaVenta}.");
            //                break;
            //            } // Si la venta está cerrada, no se pueden ingresar más productos.

            //            if (QCarrito() == 175)
            //            {
            //                Console.WriteLine($"\nERROR: La venta n°{NuevaVenta} alcanzó las 25 unidades en sus 7 productos y no se pueden añadir más productos al carrito.\n → Para iniciar la venta n° {NuevaVenta + 1}, deberás primero cerrar y cobrar la venta n°{NuevaVenta}.");
            //                break;
            //            } // Si todos los productos llegaron a 25 unidades, no se pueden seguir cargando más cosas en el carrito..

            //            int i;
            //            for (i = 1; i <= 176; i++) // Supuesto: puedo tener hasta 175 ingresos de una sola unidad → 25 u de los 7 productos + Fila de encabezado.
            //            {
            //                {
            //                    int
            //                        Codigo; // Pregunto por el código de producto
            //                    Codigo = Validar.CodigoProducto("");

            //                    if (Codigo == 0)
            //                    {
            //                        Console.WriteLine("\nAVISO: No seleccionaste ningún código de producto, por lo que no se añadió ningún producto al carrito.\n → Volviendo al menú anterior...");
            //                        break;
            //                    } // Si el usuario ingresa 0, finalizo la venta

            //                    int Stock; // Verifico que haya stock antes de permitir tomar el producto del inventario

            //                    if (int.TryParse(ListadoProductos[Codigo, 3], out Stock))

            //                        if (Stock == 0)
            //                        {
            //                            Console.WriteLine($"\nERROR: No hay {ListadoProductos[Codigo, 1]} en stock.\n → No se puede vender más {ListadoProductos[Codigo, 1]} hasta que se repongan más unidades.");
            //                            i--; // Decrementar el índice para repetir la consulta del mismo producto
            //                            continue; // Volver al inicio del bucle
            //                        } // Verificar que el producto no tenga stock 0.

            //                    int Precio; // Verifico que el precio del producto no sea 0.

            //                    if (int.TryParse(ListadoProductos[Codigo, 2], out Precio))

            //                        if (Precio == 0)
            //                        {
            //                            Console.WriteLine("\nERROR: El producto vale $0.\n → Cambiá el precio primero y volvé a intentarlo otra vez.\n");
            //                            i--; // Decrementar el índice para repetir la consulta del mismo producto
            //                            continue; // Volver al inicio del bucle
            //                        }

            //                    bool codigoExistente = false;
            //                    int indiceExistente = -1;

            //                    for (int j = 0; j < cantidadCodigosEnCarrito; j++)
            //                    {
            //                        if (codigosEnCarrito[j] == Codigo)
            //                        {
            //                            codigoExistente = true;
            //                            indiceExistente = j;
            //                            break;
            //                        }
            //                    } // Verificar si el código ya está en el carrito

            //                    if (cantidadCodigosEnCarrito >= 7 && !codigoExistente)
            //                    {
            //                        Console.WriteLine($"\nERROR: Superaste los 7 productos diferentes permitidos para esta venta.\n → No se pueden agregar más productos al carrito.\n → El carrito aún tiene {(175 - QCarrito())} unidades que podés completar con los productos ya seleccionados.\n\n--------");
            //                        break;
            //                    } // Verificar si ya se alcanzó el límite de códigos en el carrito

            //                    if (!codigoExistente)
            //                    {
            //                        codigosEnCarrito[cantidadCodigosEnCarrito] = Codigo;
            //                        cantidadCodigosEnCarrito++;
            //                    } // Agregar el código al array de códigos en uso.

            //                    int Unidades; // Verifico que el producto a cargar no tenga 25 unidades en el carrito.

            //                    if (int.TryParse(Carrito[Codigo, 3], out Unidades))

            //                        if (Unidades == 25)
            //                        {
            //                            Console.WriteLine($"\nERROR: No podés agregar más {ListadoProductos[Codigo, 1]}.\n → Ya tenés las 25 unidades permitidas de este producto en el carrito.\n\n--------");
            //                            // Salgo del bucle si ya se alcanzó el límite de unidades en el carrito.
            //                            break;
            //                        } // Verifico que el producto no tenga 25 unidades en el carrito

            //                    if (CarritoLleno())
            //                    {
            //                        break;  // Salir del bucle si el carrito está lleno
            //                    }

            //                    int Cantidad;

            //                    do
            //                    {
            //                        Cantidad = Validar.Cantidad($"Ingresá la cantidad de {ListadoProductos[Codigo, 1]} a vender.\nHay {Stock} unidades en el inventario. Se pueden agregar sólo 25 como máximo a esta venta.\n → Para volver al menú anterior, presioná 0");

            //                        if (Cantidad == 0)
            //                        {
            //                            Console.WriteLine($"\nOperación de carga cancelada.\n → AVISO: No sacaste ninguna unidad de {ListadoProductos[Codigo, 1]} del inventario.\n → Total de {ListadoProductos[Codigo, 1]} en stock: {Stock} unidad(es).\n → Volviendo al menú anterior...");
            //                            break;
            //                        } // Si se ingresa 0, se cancela la carga de las cantidades..

            //                        else if (Cantidad > Stock)
            //                        {
            //                            Console.WriteLine($"\nERROR: No hay suficientes unidades disponibles.\n → Solo hay {Stock} unidad(es) disponible(s) en el stock.\n\n--------");
            //                            break;
            //                        } // Si la cantidad ingresada supera al stock disponible, se reinicia el bucle.

            //                        else if ((Cantidad + Unidades) > 25)
            //                        {
            //                            Console.WriteLine($"\nERROR: El máximo permitido de {ListadoProductos[Codigo, 1]} es de 25 unidades.\n → Ya cargaste {Unidades} unidad(es) hasta el momento. \n → Podés cargar {25 - Unidades} unidad(es) más de {ListadoProductos[Codigo, 1]}.\n\n--------");
            //                        } // Si la cantidad ingresada sumada a la cantidad del producto actual suma más de 25, se reinicia el bucle.

            //                    } while (Cantidad > Stock || (Cantidad + Unidades) > 25); // Bucle para pedir cantidades

            //                    int indiceProducto = BuscarProducto(Carrito, Codigo);

            //                    if ((Cantidad + Unidades) <= 25 && indiceProducto == -1 && Cantidad != 0)
            //                    {
            //                        Carrito[qCarrito, 0] = ("Producto " + (qCarrito));
            //                        Carrito[qCarrito, 1] = ListadoProductos[Codigo, 0];
            //                        Carrito[qCarrito, 2] = ListadoProductos[Codigo, 1];
            //                        Carrito[qCarrito, 3] = Cantidad.ToString();
            //                        Carrito[qCarrito, 4] = ListadoProductos[Codigo, 2];
            //                        Carrito[qCarrito, 5] = (int.Parse(ListadoProductos[Codigo, 2]) * Cantidad).ToString();
            //                        qCarrito++;

            //                        ListadoProductos[Codigo, 3] = (Stock - Cantidad).ToString();

            //                        Console.WriteLine($"\nAVISO: Cargaste {Cantidad} unidad(es) de {ListadoProductos[Codigo, 1]} al carrito.\n → Podés cargar hasta {25 - (Unidades + Cantidad)} unidad(es) más de {ListadoProductos[Codigo, 1]}.");
            //                    }
            //                    else if (indiceProducto >= 0 && Cantidad != 0)
            //                    {
            //                        int cantidadAhora = int.Parse(Carrito[indiceProducto, 3]);
            //                        int cantidadNueva = cantidadAhora + Cantidad;

            //                        if (cantidadNueva <= 25)
            //                        {
            //                            Carrito[indiceProducto, 3] = cantidadNueva.ToString();
            //                            Carrito[indiceProducto, 5] = (int.Parse(Carrito[indiceProducto, 4]) * cantidadNueva).ToString();

            //                            ListadoProductos[Codigo, 3] = (Stock - Cantidad).ToString(); // Resto la cantidad al stock actual

            //                            Console.WriteLine($"\nAVISO: Se agregó {Cantidad} unidad(es) de {ListadoProductos[Codigo, 1]}.\n → Hay {cantidadNueva} unidad(es) de {ListadoProductos[Codigo, 1]} en el carrito en este momento."); // Confirmación al usuario
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine($"\nLa cantidad total de {ListadoProductos[Codigo, 1]} disponibles para sumar es de {25 - cantidadAhora}.\n → Hay {cantidadAhora} en el carrito.");
            //                        }
            //                    } // Si el producto ya está en el carrito, sumo la cantidad a la venta

            //                } // Itero 7 productos diferentes como máximo (o hasta que se completen las 25 unidades de los 7 productos → 7 * 25 = 175 veces si se cargara siempre de a 1(una) unidad)

            //            }
            //        } // Valido que se ingresen cantidades de 7 productos, 25 unidades como máximo, con stock disponible y precio definido.

            //        if (QCarrito() == 0 && opcion == 2)
            //        {
            //            Console.WriteLine($"\nAVISO: El carrito de compras aún no tiene ningún producto cargado.\n → La Venta n°{NuevaVenta} está vacía.");
            //            break;
            //        } // Si no se agregan productos, cancelar la venta.

            //        else if (opcion == 2 || CarritoLleno())
            //        {
            //            Console.WriteLine($"\nEste es el carrito resumen de la venta n°{NuevaVenta}\n");

            //            Console.Write($"{"ORDEN",-10} ");
            //            Console.Write($"{"CÓDIGO",-10} ");
            //            Console.Write($"{"DETALLE",-20} ");
            //            Console.Write($"{"CANTIDAD",-10} ");
            //            Console.Write($"{"PRECIO",-10} ");
            //            Console.Write($"{"TOTAL",-10} ");
            //            Console.WriteLine();

            //            // Matrices adicionales para almacenar información agrupada

            //            string[] CarritoDetalle = new string[qCarrito];
            //            int[] CarritoCodigo = new int[qCarrito];
            //            int[] CarritoCantidad = new int[qCarrito];
            //            int[] CarritoPrecio = new int[qCarrito];
            //            int[] CarritoTotal = new int[qCarrito];

            //            for (int i = 0; i < qCarrito; i++)
            //            {
            //                CarritoDetalle[i] = "";
            //                CarritoCodigo[i] = 0;
            //                CarritoCantidad[i] = 0;
            //                CarritoPrecio[i] = 0;
            //                CarritoTotal[i] = 0;
            //            } // Empezar con la matriz llena de ceros por defecto.

            //            int indice = 0;

            //            for (int i = 1; i < qCarrito; i++)
            //            {
            //                string Detalle = Carrito[i, 2];
            //                int Codigo = int.Parse(Carrito[i, 1]);
            //                int Cantidad = int.Parse(Carrito[i, 3]);
            //                int Precio = int.Parse(Carrito[i, 4]);
            //                int Total = int.Parse(Carrito[i, 5]);

            //                bool detalleExistente = false;

            //                for (int j = 0; j < indice; j++)
            //                {
            //                    if (CarritoCodigo[j] == Codigo)
            //                    {
            //                        CarritoCantidad[j] += Cantidad;
            //                        CarritoTotal[j] += Total;
            //                        detalleExistente = true;
            //                        break;
            //                    } // Si el detalle ya existe, actualizar las cantidades y totales
            //                } // Verificar si el detalle ya existe en las matrices agrupadas

            //                if (!detalleExistente)
            //                {
            //                    CarritoDetalle[indice] = Detalle;
            //                    CarritoCodigo[indice] = Codigo;
            //                    CarritoCantidad[indice] = Cantidad;
            //                    CarritoPrecio[indice] = Precio;
            //                    CarritoTotal[indice] = Total;
            //                    indice++;
            //                } // Si el detalle no existe, agregarlo a las matrices agrupadas
            //            }   // Iterar sobre los productos en el carrito

            //            for (int i = 0; i < indice; i++)
            //            {
            //                Console.Write($"{i + 1,-10} "); // Número de producto
            //                Console.Write($"{CarritoCodigo[i],-10} ");
            //                Console.Write($"{CarritoDetalle[i],-20} ");
            //                Console.Write($"{CarritoCantidad[i],-10} ");
            //                Console.Write($"{CarritoPrecio[i],-10} ");
            //                Console.Write($"{CarritoTotal[i],-10} ");
            //                Console.WriteLine();

            //            } // Imprimir la información agrupada
            //        } // Impresión del Carrito

            //        else if (opcion == 3 && QCarrito() == 0)
            //        {
            //            Console.WriteLine($"\nERROR: No se puede cerrar la venta n°{NuevaVenta} porque no tiene ningún producto cargado.\n → Volviendo al menú anterior...");
            //            break;
            //        } // Mensaje de error para cuando intento cerrar una venta que no tiene productos cargados.

            //        else if (opcion == 3 && (Ventas[NuevaVenta, 4] == "SI"))
            //        {
            //            Console.WriteLine($"\nERROR: No se puede cerrar la Venta n°{NuevaVenta}.\n → Ya cerraste esta venta antes y no se puede volver a cerrar.");
            //            break;
            //        } // Mensaje de error para intentos de cierre de ventas ya cerradas.

            //        else if (opcion == 3 || CarritoLleno())
            //        {
            //            Ventas[NuevaVenta, 0] = NuevaVenta.ToString(); // Número de Venta
            //            Ventas[NuevaVenta, 1] = QCarrito().ToString(); // Cantidad de Productos
            //            Ventas[NuevaVenta, 2] = Carrito[qCarrito - 1, 5]; // Total de la Venta
            //            Ventas[NuevaVenta, 3] = "NO"; // Marcar la venta como no cobrada
            //            Ventas[NuevaVenta, 4] = "SI"; // Marcar la venta como cerrada (No se pueden añadir más productos).
            //            Console.WriteLine($"\nAVISO: La venta n°{NuevaVenta} se cerró con éxito.\n → Volviendo al menú anterior...");
            //            break;
            //        } // Cierre de venta
            //    }
            //    while (opcion != 0 && (opcion != 2 || !CarritoLleno()) || opcion != 3); // Bucle para armar ventas

            //public static void Cobrar()
            //{
            //    int NumeroVenta;
            //    do
            //    {
            //        Console.Write($"\n------------\n\nIngresá el número de venta que querés cobrar.\n → Actualmente se encuentra activa la Venta n°{NuevaVenta}.\n → Para volver al menú anterior, ingresá 0.\n");

            //        NumeroVenta = Validar.OpcionMenu("", 0, 20); // Le pido al usuario que ingrese el número de la venta que quiere cobrar.

            //        if (NumeroVenta == 0)
            //        {
            //            Console.WriteLine($"\nAVISO: No elegiste ninguna venta para cobrar. Operación de cobranza cancelada.\n → Volviendo al menú anterior...");
            //            break;
            //        } // Si el usuario ingresa cero, la cobranza no se hace. 

            //        if (Ventas[NumeroVenta, 3] == "SI")
            //        {
            //            Console.WriteLine($"\nERROR: La venta n°{NumeroVenta} ya fue cobrada anteriormente.\n → Actualmente se encuentra activa la Venta n°{NuevaVenta}.");
            //            break;
            //        } // Si la venta elegida ya fue cobrada, no se puede cobrar.

            //        if (NumeroVenta != NuevaVenta)
            //        {
            //            Console.WriteLine($"\nERROR: La venta n°{NumeroVenta} no se encuentra disponible para ser cobrada.\n → La última venta registrada fue la n°{NuevaVenta}.");
            //            continue;
            //        } // Si el número de venta no es el último número de venta realizada, no se puede cobrar.

            //        if (Ventas[NumeroVenta, 4] != "SI")
            //        {
            //            Console.WriteLine($"\nERROR: La venta n°{NumeroVenta} no está cerrada, esto puede deberse a que aún se quiera añadir más unidades al carrito.\n → Para poder cobrar esta venta, primero deberás cerrarla.");
            //            break;
            //        } // Si la venta elegida no fue cerrada, no se puede cobrar.

            //        if (Ventas[NumeroVenta, 3] == "NO") // Si la venta no fue cobrada antes, puedo avanzar.
            //        {
            //            double Total = double.Parse(Ventas[NumeroVenta, 2]);

            //            // Calcular descuento

            //            double Descuento = 0.0;
            //            if (Total > 16000)
            //            {
            //                Descuento = 0.10; // Descuento del 10% si el total es mayor a $16000
            //            }
            //            else if (Total > 8000)
            //            {
            //                Descuento = 0.08; // Descuento del 8% si el total es mayor a $8000
            //            }
            //            else if (Total > 4000)
            //            {
            //                Descuento = 0.06; // Descuento del 6% si el total es mayor a $4000
            //            }

            //            // Calcular total a cobrar con y sin descuento
            //            int Neto = (int)(Total);
            //            int TotDesc = (int)(Total - (Total * Descuento));

            //            Console.WriteLine($"\nTotal a cobrar por la venta n°{NumeroVenta}: ${Neto}.\n → Descuento por aplicar: {Descuento * 100}%.\n → Total cobrado: ${TotDesc}.\n → El cobro fue realiado con éxito y se registró en la caja");
            //            Ventas[NuevaVenta, 3] = "SI"; // Marcar la venta como cobrada en la matriz de ventas.
            //            NuevaVenta++; // Habilitar la venta n+1
            //            break;
            //        }

            //        else
            //        {
            //            Console.WriteLine($"ERROR: No existe la venta n°{NumeroVenta}. → La última venta registrada fue la n°{NuevaVenta}.");
            //            break;
            //        }

            //    } while (NumeroVenta != 0);
            //} // Opción 4 → Cobrar una venta ya realizada

            //public override void Caja()
            //{
            //    double ConDescuento = 0;
            //    double SinDescuento = 0;
            //    int CantidadVendida = 0;

            //    for (int i = 1; i < NuevaVenta; i++)
            //    {
            //        if (Ventas[i, 3] == "SI") // Verificar si ya la cobré
            //        {
            //            double Total = double.Parse(Ventas[i, 1]);
            //            ConDescuento += Total;

            //            if (Ventas[i, 2] != null) // Verificar si hay descuento aplicado
            //            {
            //                double TotDesc = double.Parse(Ventas[i, 2]);
            //                ConDescuento += TotDesc;
            //            }

            //            if (Ventas[i, 1] != null) // Verificar si hay información sobre la cantidad de productos
            //            {
            //                int CantidadProductos = int.Parse(Ventas[i, 1]);
            //                CantidadVendida += CantidadProductos;
            //            }
            //        }
            //    }

            //    double PromSdescuento = SinDescuento / CantidadVendida;
            //    double PromCdescuento = ConDescuento / CantidadVendida;

            //    Console.WriteLine($"\n------ RESUMEN DE COBRANZAS ------");
            //    Console.WriteLine($"\nCantidad de Ventas: {NuevaVenta - 1}");
            //    Console.WriteLine($"\nMonto total cobrado de ventas que no tuvieron descuento: ${SinDescuento}");
            //    Console.WriteLine($"Monto total cobrado de ventas que sí tuvieron descuento: ${ConDescuento}");
            //    Console.WriteLine($"\nCantidad total de productos vendidos: {CantidadVendida}");
            //    Console.WriteLine($"\nPromedio de cobranzas sin descuento sobre productos vendidos: ${PromSdescuento}");
            //    Console.WriteLine($"Promedio de cobranzas con descuento sobre productos vendidos: ${PromCdescuento:F0}");

            //} // Opción 5 → Resumen de Cobranzas
            //}

        }
    }
