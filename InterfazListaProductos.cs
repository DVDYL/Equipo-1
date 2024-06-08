using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazListaProductos : Ventana
    {
        private ProductoNegocio ProductoNegocio = new ProductoNegocio();
        private ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();

        // Acá falta encapsular el host del usuario para que se puedan usar determinadas opciones.

        public InterfazListaProductos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void CargarProductos()
        {
            try
            {
                List<TraerProductos> Producto = ProductoNegocio.listarProductos();
                List<TraerProveedores> Proveedor = ProveedorNegocio.listarProveedores();

                if (Proveedor != null)
                {
                    Proveedor = Proveedor.Where(u => u != null && u.Email != null && u.Email.Contains("@G1")).ToList();
                }

                var bindingList = new BindingList<TraerProductos>(Producto);
                var source = new BindingSource(bindingList, null);
                Productos.DataSource = source;
                Productos.Columns["id"].Visible = false;
                Productos.Columns["fechaBaja"].Visible = false;
                Productos.Columns["fechaAlta"].Visible = false;
                Productos.Columns["IDCategoria"].HeaderText = "Categoría";

                // Suscribirse al evento CellFormatting
                Productos.CellFormatting += Productos_CellFormatting;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Productos: " + ex.Message);
            }
        }

        private void InterfazListaProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void Productos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la celda pertenece a la columna "Stock"
            if (Productos.Columns[e.ColumnIndex].Name == "Stock")
            {
                // Verificar si el valor de la celda es "0"
                if (e.Value != null && e.Value.ToString() == "0")
                {
                    // Cambiar el color del texto a rojo
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    // Restablecer el color del texto al valor predeterminado
                    e.CellStyle.ForeColor = Productos.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boton_Modificar.Visible = true;
            Boton_Eliminar.Visible = true;
        }

        private void ProductosLupa_Click(object sender, EventArgs e)
        {
            string textoBusqueda = ProductoBuscador.Text; // Obtener el texto ingresado en el TextBox ProductosBuscador

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProductos();
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            if (Productos.DataSource == null || Productos.Rows.Count == 0) // Verificar si la lista de Productos es nula o está vacía
            {
                MessageBox.Show("La lista de productos se encuentra vacía.\n\nNo hay productos para buscar."); // Manejar el caso en el que la lista de Productos es nula o vacía
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            else
            {
                // Lista para almacenar los Productos que coinciden con la búsqueda
                List<TraerProductos> ProductosFiltrados = new List<TraerProductos>();

                // Recorrer cada fila en el DataGridView Productos
                foreach (DataGridViewRow fila in Productos.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del Producto
                    string nombreProducto = fila.Cells["Nombre"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre de Producto actual
                    if (!string.IsNullOrEmpty(nombreProducto) && nombreProducto.ToLower().Contains(textoBusqueda.ToLower()))
                    {
                        // Agregar el Producto a la lista de Productos filtrados
                        ProductosFiltrados.Add((TraerProductos)fila.DataBoundItem);
                    }
                }

                if (ProductosFiltrados.Count > 0) // Verificar si se encontraron Productos que coinciden con la búsqueda
                {
                    var bindingList = new BindingList<TraerProductos>(ProductosFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Productos.DataSource = source;
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.");
                }
            }
        }

        private void DescripcionLupa_Click(object sender, EventArgs e)
        {
            string textoBusqueda = ProductoBuscador.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProductos();
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            if (Productos.DataSource == null || Productos.Rows.Count == 0) // Verificar si la lista de Productos es nula o está vacía
            {
                MessageBox.Show("La lista de productos se encuentra vacía.\n\nNo hay productos para buscar.");
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }
            else
            {
                // Lista para almacenar los Productos que coinciden con la búsqueda
                List<TraerProductos> ProductosFiltrados = new List<TraerProductos>();

                // Recorrer cada fila en el DataGridView Productos
                foreach (DataGridViewRow fila in Productos.Rows)
                {
                    // Obtener el valor de la celda que contiene el nombre del Producto
                    string nombreProducto = fila.Cells["idCategoria"].Value?.ToString();

                    // Comparar si el texto de búsqueda coincide con el nombre del Producto actual
                    if (!string.IsNullOrEmpty(nombreProducto) && nombreProducto.ToLower().Contains(textoBusqueda.ToLower()))
                    {
                        // Agregar el Producto a la lista de Productos filtrados
                        ProductosFiltrados.Add((TraerProductos)fila.DataBoundItem);
                    }
                }

                // Verificar si se encontraron Productos que coinciden con la búsqueda
                if (ProductosFiltrados.Count > 0)
                {
                    // Actualizar el DataSource del DataGridView con los Productos filtrados
                    var bindingList = new BindingList<TraerProductos>(ProductosFiltrados);
                    var source = new BindingSource(bindingList, null);
                    Productos.DataSource = source;
                    Boton_Modificar.Visible = true;
                    Boton_Eliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.");
                }
            }
        }

        private void Boton_AltaProducto_Click(object sender, EventArgs e)
        {
            InterfazAltaProductos AltaProductos = new InterfazAltaProductos();
            Hide();
            AltaProductos.Show();
        } // OJO ACÁ → A esta opción sólo puede entrar el host 1 y 2

        private void BorrarFiltro_Click(object sender, EventArgs e)
        {
            CargarProductos();
            Limpiar();
        }

        private void Limpiar() 
        {
            ProductoBuscador.Text = "";
            DescripcionBuscador.Text = "";
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void Boton_Modificar_Click(object sender, EventArgs e)
        {
            // Falta desarrollar cómo llamar al servicio.
            // Pero primero falta la redirección a la ventana de modificación! Ahí va el servicio. No acá.
            // OJO ACÁ → A esta opción sólo puede entrar el host 2
        }

        private void EliminarProducto() // EliminarProducto(idProducto)
        {
        //    ProductoNegocio BajaProproducto = new ProductoNegocio();
            // BajaProducto.BorrarProproducto(ACÁ SE DEBERÍA ESPECIFICAR DE QUÉ CELDA SALE EL DATO DEL IDPRODUCTO);
            // Usen el código con el que ya hicimos usuarios, proveedores, etc. La lógica debería ser idéntica.
        }

        private void Boton_Eliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada dentro del GRID
            if (Productos.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = Productos.SelectedRows[0].Index;

                // Obtener el valor de la celda "ID" de la fila seleccionada
                string id = Productos.Rows[indiceFila].Cells["ID"].Value.ToString();

                EliminarProducto(); // EliminarProducto(idProducto)
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de intentar eliminar.");
            }
        } // OJO ACÁ → A esta opción sólo puede entrar el host 1 y 2

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazMenu ventanaMenu = new InterfazMenu();
                ventanaMenu.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InterfazMenu InterfazMenu = new InterfazMenu();
                    InterfazMenu.Show();
                    Hide();
                }
                // Si el Producto elige "No", no hacer nada
            }
        }
    }
}
