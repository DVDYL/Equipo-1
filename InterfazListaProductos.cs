using Datos;
using Negocio;
using System;
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
    public partial class InterfazListaProductos : Ventana
    {
        private ProductoNegocio ProductoNegocio = new ProductoNegocio();

        public InterfazListaProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
            Boton_Modificar.Visible = false;
            Boton_Eliminar.Visible = false;
        }

        private void CargarProductos()
        {
            try
            {
                List<TraerProductos> Producto = ProductoNegocio.listarProductos();

                var bindingList = new BindingList<TraerProductos>(Producto);
                var source = new BindingSource(bindingList, null);
                Productos.DataSource = source;
                Productos.Columns["id"].Visible = false;
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

        private void Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boton_Modificar.Visible = true;
            Boton_Eliminar.Visible = true;
        }

        private void ProductosLupa_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox ProductosBuscador
            string textoBusqueda = ProductoBuscador.Text;

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                CargarProductos();
                Boton_Modificar.Visible = false;
                Boton_Eliminar.Visible = false;
            }

            // Verificar si la lista de Productos es nula o está vacía
            if (Productos.DataSource == null || Productos.Rows.Count == 0)
            {
                // Manejar el caso en el que la lista de Productos es nula o vacía
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay productos para buscar.");
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
                    // Mostrar un mensaje si no se encontraron Productos que coincidan con la búsqueda
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

            // Verificar si la lista de Productos es nula o está vacía
            if (Productos.DataSource == null || Productos.Rows.Count == 0)
            {
                // Manejar el caso en el que la lista de Productos es nula o vacía
                MessageBox.Show("La lista se encuentra vacía.\n\nNo hay productos para buscar.");
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
            this.Hide();
            AltaProductos.Show();
        }

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
        }

        private void EliminarProducto()
        {
            ProductoNegocio BajaProproducto = new ProductoNegocio();
            //BajaProducto.BorrarProproducto(ACÁ SE DEBERÍA ESPECIFICAR DE QUÉ CELDA SALE EL DATO DEL IDPRODUCTO);
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

                // Por medio del id, eliminamos el proveedor
                // Por ejemplo:
                EliminarProducto(); //Acá debería ir el id dentro del método.
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de intentar eliminar.");
            }
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del Producto
            if (resultado == DialogResult.Yes)
            {
                // Ocultar la ventana actual
                this.Hide();

                // Crear una instancia de la ventana InterfazMenu
                InterfazMenu ventanaMenu = new InterfazMenu();

                // Mostrar la ventana InterfazMenu
                ventanaMenu.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del Producto
                if (result == DialogResult.Yes) // Si el Producto elige "Sí", cerrar la sesión
                {
                    InterfazMenu InterfazMenu = new InterfazMenu(); // Redirigir al formulario de inicio de sesión (LogIn)
                    InterfazMenu.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el Producto elige "No", no hacer nada
            }
        }
    }
}
