using Datos;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazVentas : Ventana
    {
        //private string idCliente;
        private ClienteNegocio ClienteNegocio = new ClienteNegocio();
        private ProductoNegocio ProductoNegocio = new ProductoNegocio();
        private VentaNegocio VentaNegocio = new VentaNegocio();

        public InterfazVentas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            KeyPreview = true; // Permitir que el formulario capture los eventos de teclado

            // Configurar todos los comboboxes:

            ComboBox_Clientes.DropDownStyle = ComboBoxStyle.DropDownList; // Configurar el estilo para que el usuario no pueda escribir
            ComboBox_Clientes.SelectedIndex = -1; // Establecer el elemento vacío como seleccionado por defecto
            ComboBox_Producto1.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Producto1.SelectedIndex = -1;
            ComboBox_Producto2.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Producto2.SelectedIndex = -1;
            ComboBox_Producto3.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Producto3.SelectedIndex = -1;
            ComboBox_Producto4.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Producto4.SelectedIndex = -1;
            Combobox_Producto1Cantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            Combobox_Producto1Cantidad.SelectedIndex = -1;
            Combobox_Producto2Cantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            Combobox_Producto2Cantidad.SelectedIndex = -1;
            Combobox_Producto3Cantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            Combobox_Producto3Cantidad.SelectedIndex = -1;
            Combobox_Producto4Cantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            Combobox_Producto4Cantidad.SelectedIndex = -1;

            // Ocultar las promociones por defecto
            Promocion_text.Visible = false;
            MontoPromocion1.Visible = false;
            Promocion2_text.Visible = false;
            MontoPromocion2.Visible = false;

            // Asociar el evento SelectedIndexChanged al ComboBox_Clientes
            ComboBox_Clientes.SelectedIndexChanged += ComboBox_Clientes_SelectedIndexChanged;

            // Cargar la lista de clientes y productos en los comboboxes:

            CargarClientes(); // Acá tengo que traerme la lista de nombres de los clientes.
            CargarProductos(); // Acá tengo que traerme la lista de productos.

            // Establecer la fecha por defecto del calendario a hoy
            Calendario_Operacion.Value = DateTime.Now;

            // Deshabilitar la edición del DateTimePicker
            Calendario_Operacion.Enabled = false;
        }

        private void CargarClientes()
        {
            try
            {
                List<Cliente> Cliente = ClienteNegocio.listarClientes();

                if (Cliente != null)
                {
                    Cliente = Cliente.Where(u => u != null && u.Email != null && u.Email.Contains("@G1")).ToList();
                }

                foreach (var cliente in Cliente)
                {
                    ComboBox_Clientes.Items.Add(cliente.Apellido + " " + cliente.Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void Calendario_Operacion_ValueChanged(object sender, EventArgs e)
        {
            this.Calendario_Operacion.ValueChanged += new System.EventHandler(this.Calendario_Operacion_ValueChanged);
        }

        public void ActualizarCliente(string DNI, string direccion, string telefono, string email)
        {
            Box_DNI.Text = DNI;
            Box_Direccion.Text = direccion;
            Box_Telefono.Text = telefono;
            Box_Mail.Text = email;
        }

        private void ComboBox_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado una opción válida en el ComboBox
                if (ComboBox_Clientes.SelectedIndex != -1) // Una opción válida está seleccionada
                {
                    // Mostrar los TextBox
                    Promocion_text.Visible = true;
                    MontoPromocion1.Visible = true;
                    Promocion2_text.Visible = true;
                    MontoPromocion2.Visible = true;

                    // Obtener el nombre del cliente seleccionado en el ComboBox
                    string nombreCliente = ComboBox_Clientes.SelectedItem.ToString();

                    // Buscar el cliente en la lista de clientes utilizando su nombre
                    List<Cliente> listarClientes = ClienteNegocio.listarClientes();
                    Cliente clienteSeleccionado = listarClientes.FirstOrDefault(c => (c.Apellido + " " + c.Nombre) == nombreCliente);

                    // Verificar si se encontró el cliente
                    if (clienteSeleccionado != null)
                    {
                        // Obtener los datos del cliente
                        string DNI = clienteSeleccionado.DNI.ToString();
                        string direccion = clienteSeleccionado.Direccion;
                        string telefono = clienteSeleccionado.Telefono;
                        string email = clienteSeleccionado.Email;

                        // Actualizar los campos de texto con los datos del cliente seleccionado
                        ActualizarCliente(DNI, direccion, telefono, email);
                        ExisteVentaCliente();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente seleccionado.");
                    }
                }
                else
                {
                    // Ocultar los TextBox si no hay una opción válida seleccionada
                    Promocion_text.Visible = false;
                    MontoPromocion1.Visible = false;
                    Promocion2_text.Visible = false;
                    MontoPromocion2.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del cliente: " + ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                List<TraerProductos> Productos = ProductoNegocio.listarProductos();

                foreach (var producto in Productos)
                {
                    ComboBox_Producto1.Items.Add(producto.IDCategoria);
                    ComboBox_Producto2.Items.Add(producto.IDCategoria);
                    ComboBox_Producto3.Items.Add(producto.IDCategoria);
                    ComboBox_Producto4.Items.Add(producto.IDCategoria);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Productos: " + ex.Message);
            }
        }

        public void ActualizarProducto1(string Nombre1, string Precio1, string Cantidad1)
        {
            Producto1_Descripcion.Text = Nombre1;
            Producto1_MontoUnitario.Text = Precio1;

            string CantidadesDisponibles = Cantidad1;

            // Establecer el valor predeterminado como vacío (-1)
            Combobox_Producto1Cantidad.SelectedItem = null;

            // Limpiar el ComboBox de cantidad antes de agregar las nuevas opciones
            Combobox_Producto1Cantidad.Items.Clear();

            // Agregar las opciones al ComboBox de cantidad
            for (int i = 1; i <= CantidadesDisponibles.Max(); i++)
            {
                Combobox_Producto1Cantidad.Items.Add(i);
            }
        }

        public void CalcularMontoTotal1()
        {
            // Verificar si ComboBox_Producto1 y ComboBox_Producto1Cantidad no están vacíos
            if (ComboBox_Producto1.SelectedItem != null && Combobox_Producto1Cantidad.SelectedItem != null)
            {
                // Obtener la cantidad seleccionada como un entero
                if (int.TryParse(Combobox_Producto1Cantidad.SelectedItem.ToString(), out int cantidad) &&
                    int.TryParse(Producto1_MontoUnitario.Text, out int precioUnitario))
                {
                    // Calcular el monto total
                    int montoTotal = cantidad * precioUnitario;

                    // Mostrar el monto total en el TextBox Producto1_MontoTotal
                    Producto1_MontoTotal.Text = montoTotal.ToString();
                    CalcularMontoFinal();
                }
                else
                {
                    MessageBox.Show("Error de formato al convertir los datos. Asegúrese de que la cantidad y el precio unitario sean números enteros válidos.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto y especificar una cantidad.");
            }
        }

        private void ComboBox_Producto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del producto seleccionado en el ComboBox
                string idCategoriaString = ComboBox_Producto1.SelectedItem.ToString();
                int idCategoria = int.Parse(idCategoriaString); // Convertir la cadena a un entero

                // Buscar el producto en la lista de productos utilizando su ID
                List<TraerProductos> VerProductos = ProductoNegocio.listarProductos();
                TraerProductos Producto1 = VerProductos.FirstOrDefault(p => p.IDCategoria == idCategoria);

                // Verificar si se encontró el producto
                if (Producto1 != null)
                {
                    // Obtener los datos del producto
                    string Nombre1 = Producto1.Nombre;
                    string Precio1 = Producto1.Precio.ToString();
                    string Cantidad1 = Producto1.Stock.ToString();

                    // Actualizar los campos de texto con los datos del producto seleccionado
                    ActualizarProducto1(Nombre1, Precio1, Cantidad1);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message);
            }
        }

        private void Combobox_Producto1Cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal1();
        }

        public void ActualizarProducto2(string Nombre2, string Precio2, string Cantidad2)
        {
            Producto2_Descripcion.Text = Nombre2;
            Producto2_MontoUnitario.Text = Precio2;

            string CantidadesDisponibles = Cantidad2;

            // Establecer el valor predeterminado como vacío (-2)
            Combobox_Producto2Cantidad.SelectedItem = null;

            // Limpiar el ComboBox de cantidad antes de agregar las nuevas opciones
            Combobox_Producto2Cantidad.Items.Clear();

            // Agregar las opciones al ComboBox de cantidad
            for (int i = 1; i <= CantidadesDisponibles.Max(); i++)
            {
                Combobox_Producto2Cantidad.Items.Add(i);
            }
        }

        public void CalcularMontoTotal2()
        {
            // Verificar si ComboBox_Producto2 y ComboBox_Producto2Cantidad no están vacíos
            if (ComboBox_Producto2.SelectedItem != null && Combobox_Producto2Cantidad.SelectedItem != null)
            {
                // Obtener la cantidad seleccionada como un entero
                if (int.TryParse(Combobox_Producto2Cantidad.SelectedItem.ToString(), out int cantidad) &&
                    int.TryParse(Producto2_MontoUnitario.Text, out int precioUnitario))
                {
                    // Calcular el monto total
                    int montoTotal = cantidad * precioUnitario;

                    // Mostrar el monto total en el TextBox Producto2_MontoTotal
                    Producto2_MontoTotal.Text = montoTotal.ToString();
                    CalcularMontoFinal();
                }
                else
                {
                    MessageBox.Show("Error de formato al convertir los datos. Asegúrese de que la cantidad y el precio unitario sean números enteros válidos.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto y especificar una cantidad.");
            }
        }

        private void ComboBox_Producto2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del producto seleccionado en el ComboBox
                string idCategoriaString = ComboBox_Producto2.SelectedItem.ToString();
                int idCategoria = int.Parse(idCategoriaString); // Convertir la cadena a un entero

                // Buscar el producto en la lista de productos utilizando su ID
                List<TraerProductos> VerProductos = ProductoNegocio.listarProductos();
                TraerProductos Producto2 = VerProductos.FirstOrDefault(p => p.IDCategoria == idCategoria);

                // Verificar si se encontró el producto
                if (Producto2 != null)
                {
                    // Obtener los datos del producto
                    string Nombre2 = Producto2.Nombre;
                    string Precio2 = Producto2.Precio.ToString();
                    string Cantidad2 = Producto2.Stock.ToString();

                    // Actualizar los campos de texto con los datos del producto seleccionado
                    ActualizarProducto2(Nombre2, Precio2, Cantidad2);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message);
            }
        }

        private void Combobox_Producto2Cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal2();
        }

        public void ActualizarProducto3(string Nombre3, string Precio3, string Cantidad3)
        {
            Producto3_Descripcion.Text = Nombre3;
            Producto3_MontoUnitario.Text = Precio3;

            string CantidadesDisponibles = Cantidad3;

            // Establecer el valor predeterminado como vacío (-3)
            Combobox_Producto3Cantidad.SelectedItem = null;

            // Limpiar el ComboBox de cantidad antes de agregar las nuevas opciones
            Combobox_Producto3Cantidad.Items.Clear();

            // Agregar las opciones al ComboBox de cantidad
            for (int i = 1; i <= CantidadesDisponibles.Max(); i++)
            {
                Combobox_Producto3Cantidad.Items.Add(i);
            }
        }

        public void CalcularMontoTotal3()
        {
            // Verificar si ComboBox_Producto3 y ComboBox_Producto3Cantidad no están vacíos
            if (ComboBox_Producto3.SelectedItem != null && Combobox_Producto3Cantidad.SelectedItem != null)
            {
                // Obtener la cantidad seleccionada como un entero
                if (int.TryParse(Combobox_Producto3Cantidad.SelectedItem.ToString(), out int cantidad) &&
                    int.TryParse(Producto3_MontoUnitario.Text, out int precioUnitario))
                {
                    // Calcular el monto total
                    int montoTotal = cantidad * precioUnitario;

                    // Mostrar el monto total en el TextBox Producto3_MontoTotal
                    Producto3_MontoTotal.Text = montoTotal.ToString();
                    CalcularMontoFinal();
                }
                else
                {
                    MessageBox.Show("Error de formato al convertir los datos. Asegúrese de que la cantidad y el precio unitario sean números enteros válidos.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto y especificar una cantidad.");
            }
        }

        private void ComboBox_Producto3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del producto seleccionado en el ComboBox
                string idCategoriaString = ComboBox_Producto3.SelectedItem.ToString();
                int idCategoria = int.Parse(idCategoriaString); // Convertir la cadena a un entero

                // Buscar el producto en la lista de productos utilizando su ID
                List<TraerProductos> VerProductos = ProductoNegocio.listarProductos();
                TraerProductos Producto3 = VerProductos.FirstOrDefault(p => p.IDCategoria == idCategoria);

                // Verificar si se encontró el producto
                if (Producto3 != null)
                {
                    // Obtener los datos del producto
                    string Nombre3 = Producto3.Nombre;
                    string Precio3 = Producto3.Precio.ToString();
                    string Cantidad3 = Producto3.Stock.ToString();

                    // Actualizar los campos de texto con los datos del producto seleccionado
                    ActualizarProducto3(Nombre3, Precio3, Cantidad3);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message);
            }
        }

        private void Combobox_Producto3Cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal3();
        }

        public void ActualizarProducto4(string Nombre4, string Precio4, string Cantidad4)
        {
            Producto4_Descripcion.Text = Nombre4;
            Producto4_MontoUnitario.Text = Precio4;

            string CantidadesDisponibles = Cantidad4;

            // Establecer el valor predeterminado como vacío (-4)
            Combobox_Producto4Cantidad.SelectedItem = null;

            // Limpiar el ComboBox de cantidad antes de agregar las nuevas opciones
            Combobox_Producto4Cantidad.Items.Clear();

            // Agregar las opciones al ComboBox de cantidad
            for (int i = 1; i <= CantidadesDisponibles.Max(); i++)
            {
                Combobox_Producto4Cantidad.Items.Add(i);
            }
        }

        public void CalcularMontoTotal4()
        {
            // Verificar si ComboBox_Producto4 y ComboBox_Producto4Cantidad no están vacíos
            if (ComboBox_Producto4.SelectedItem != null && Combobox_Producto4Cantidad.SelectedItem != null)
            {
                // Obtener la cantidad seleccionada como un entero
                if (int.TryParse(Combobox_Producto4Cantidad.SelectedItem.ToString(), out int cantidad) &&
                    int.TryParse(Producto4_MontoUnitario.Text, out int precioUnitario))
                {
                    // Calcular el monto total
                    int montoTotal = cantidad * precioUnitario;

                    // Mostrar el monto total en el TextBox Producto4_MontoTotal
                    Producto4_MontoTotal.Text = montoTotal.ToString();
                    CalcularMontoFinal();
                }
                else
                {
                    MessageBox.Show("Error de formato al convertir los datos. Asegúrese de que la cantidad y el precio unitario sean números enteros válidos.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto y especificar una cantidad.");
            }
        }

        private void ComboBox_Producto4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del producto seleccionado en el ComboBox
                string idCategoriaString = ComboBox_Producto4.SelectedItem.ToString();
                int idCategoria = int.Parse(idCategoriaString); // Convertir la cadena a un entero

                // Buscar el producto en la lista de productos utilizando su ID
                List<TraerProductos> VerProductos = ProductoNegocio.listarProductos();
                TraerProductos Producto4 = VerProductos.FirstOrDefault(p => p.IDCategoria == idCategoria);

                // Verificar si se encontró el producto
                if (Producto4 != null)
                {
                    // Obtener los datos del producto
                    string Nombre4 = Producto4.Nombre;
                    string Precio4 = Producto4.Precio.ToString();
                    string Cantidad4 = Producto4.Stock.ToString();

                    // Actualizar los campos de texto con los datos del producto seleccionado
                    ActualizarProducto4(Nombre4, Precio4, Cantidad4);
                }
                else
                {
                    MessageBox.Show("No se encontró el producto seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message);
            }
        }

        private void Combobox_Producto4Cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMontoTotal4();
        }

        public void CalcularMontoFinal()
        {
            int Monto1 = 0;
            int Monto2 = 0;
            int Monto3 = 0;
            int Monto4 = 0;

            // Usar int.TryParse para evitar errores de formato y asignar 0 si la conversión falla
            if (!string.IsNullOrEmpty(Producto1_MontoTotal.Text))
            {
                int.TryParse(Producto1_MontoTotal.Text, out Monto1);
            }

            if (!string.IsNullOrEmpty(Producto2_MontoTotal.Text))
            {
                int.TryParse(Producto2_MontoTotal.Text, out Monto2);
            }

            if (!string.IsNullOrEmpty(Producto3_MontoTotal.Text))
            {
                int.TryParse(Producto3_MontoTotal.Text, out Monto3);
            }

            if (!string.IsNullOrEmpty(Producto4_MontoTotal.Text))
            {
                int.TryParse(Producto4_MontoTotal.Text, out Monto4);
            }

            // Sumar los montos para obtener el monto final
            int MontoFinal = Monto1 + Monto2 + Monto3 + Monto4;

            // Calcular y restar el descuento
            double descuento = CalcularDescuentoElectroHogar();
            MontoFinal -= (int)descuento;

            // Verificar si es la primera compra y aplicar el descuento correspondiente
            bool PrimeraCompra = ExisteVentaCliente();
            if (PrimeraCompra)
            {
                double DescuentoPrimeraCompra = MontoFinal * 0.05;
                MontoFinal = MontoFinal - (int)DescuentoPrimeraCompra;
                MontoPromocion2.Text = "$" + DescuentoPrimeraCompra.ToString("F2"); // Formato de 2 decimales
                Promocion2_text.Text = "Promo Cliente Nuevo";
            }
            else
            {
                MontoPromocion2.Text = "$0.00";
                Promocion2_text.Text = "No aplica Cliente Nuevo";
            }

            // Mostrar el monto final en el TextBox correspondiente
            Monto_Final.Text = "$" + MontoFinal.ToString();
        }

        public void CalcularDescuentoClienteNuevo()
        {
            //Acá tendríamos que poner el calculo del descuento teniendo en cuenta si el cliente tiene registrada alguna venta o no (deberíamos utilizar el GetVentaByCliente)
        }

        public double CalcularDescuentoElectroHogar()
        {
            int Monto1 = 0;
            int Monto2 = 0;
            int Monto3 = 0;
            int Monto4 = 0;

            // Usar int.TryParse para evitar errores de formato y asignar 0 si la conversión falla
            int.TryParse(Producto1_MontoTotal.Text, out Monto1);
            int.TryParse(Producto2_MontoTotal.Text, out Monto2);
            int.TryParse(Producto3_MontoTotal.Text, out Monto3);
            int.TryParse(Producto4_MontoTotal.Text, out Monto4);

            int MontoAEvaluar = 0;
            double descuento = 0.0;

            // Verificar la selección del producto en los ComboBox y acumular el monto si cumple la condición
            if (ComboBox_Producto1.SelectedItem != null && ComboBox_Producto1.SelectedItem.ToString() == "3")
            {
                MontoAEvaluar += Monto1;
            }
            if (ComboBox_Producto2.SelectedItem != null && ComboBox_Producto2.SelectedItem.ToString() == "3")
            {
                MontoAEvaluar += Monto2;
            }
            if (ComboBox_Producto3.SelectedItem != null && ComboBox_Producto3.SelectedItem.ToString() == "3")
            {
                MontoAEvaluar += Monto3;
            }
            if (ComboBox_Producto4.SelectedItem != null && ComboBox_Producto4.SelectedItem.ToString() == "3")
            {
                MontoAEvaluar += Monto4;
            }

            // Aplicar el descuento si el monto acumulado supera el umbral
            if (MontoAEvaluar > 100000)
            {
                descuento = MontoAEvaluar * 0.05;
                MontoPromocion1.Text = "$" + descuento.ToString("F2"); // Formato de 2 decimales
                Promocion_text.Text = "Descuento ElectroHogar";
            }
            else
            {
                MontoPromocion1.Text = "$0.00";
                Promocion_text.Text = "No aplica descuentos";
            }

            return descuento;
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazMenu Menu = new InterfazMenu();
                Menu.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InterfazMenu Menu = new InterfazMenu();
                    Menu.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            Producto1_Descripcion.Text = "";
            Producto1_MontoUnitario.Text = "";
            Producto2_Descripcion.Text = "";
            Producto2_MontoUnitario.Text = "";
            Producto3_Descripcion.Text = "";
            Producto3_MontoUnitario.Text = "";
            Producto4_Descripcion.Text = "";
            Producto4_MontoUnitario.Text = "";
            Combobox_Producto1Cantidad.Items.Clear();
            ComboBox_Producto1.Items.Clear();
            Combobox_Producto2Cantidad.Items.Clear();
            ComboBox_Producto2.Items.Clear();
            Combobox_Producto3Cantidad.Items.Clear();
            ComboBox_Producto3.Items.Clear();
            Combobox_Producto4Cantidad.Items.Clear();
            ComboBox_Producto4.Items.Clear();
            ComboBox_Clientes.Items.Clear();
            Box_DNI.Text = "";
            Box_Direccion.Text = "";
            Box_Telefono.Text = "";
            Box_Mail.Text = "";
            Producto1_MontoTotal.Text = "";
            Producto2_MontoTotal.Text = "";
            Producto3_MontoTotal.Text = "";
            Producto4_MontoTotal.Text = "";
            Monto_Final.Text = "";
            Promocion_text.Text = "";
            MontoPromocion1.Text = "";

            CargarClientes(); // Acá tengo que traerme la lista de nombres de los clientes.
            CargarProductos(); // Acá tengo que traerme la lista de productos.
        }

        private void CrearVenta()
        {
            // Está bien, pero tengo que obtener una fecha de alta, podría ser la fecha de hoy y quedar grabado defintivamente.
            // Esa fecha, dónde la guardás? En el .txt?

            VentaNegocio AltaVenta = new VentaNegocio();
            AltaVenta.agregarVenta("70b37dc1-8fde-4840-be47-9ababd0ee7e5", "", "", 7);
        }

        public bool ExisteVentaCliente()
        {
            // Obtener el nombre del cliente seleccionado en el ComboBox
            string nombreCliente = ComboBox_Clientes.SelectedItem.ToString();
            // Buscar el cliente en la lista de clientes utilizando su nombre
            List<Cliente> listarClientes = ClienteNegocio.listarClientes();
            Cliente clienteSeleccionado = listarClientes.FirstOrDefault(c => (c.Apellido + " " + c.Nombre) == nombreCliente);

            // Verificar si se encontró el cliente
            if (clienteSeleccionado != null)
            {
                // Obtener el ID del cliente
                string idCliente = clienteSeleccionado.Id;
                // Se busca en base al ID seleccionado si tiene alguna venta registrada
                List<TraerVentaPorCliente> TraerVentaPorCliente = VentaNegocio.GetTraerVentaPorClientes(idCliente);

                if (TraerVentaPorCliente.Count == 0)
                {

                    return true;

                }
                else
                {
                    return false;
                }
            }

            return false;


        }

    }
}