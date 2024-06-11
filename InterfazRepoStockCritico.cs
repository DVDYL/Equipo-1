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
    public partial class InterfazRepoStockCritico : Ventana
    {
        private List<TraerProductos> productosCompleta; // Lista completa de productos
        private ProductoNegocio ProductoNegocio = new ProductoNegocio();
        private ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();

        public InterfazRepoStockCritico()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;

            // Preparar ComboBox_Categoria
            ComboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Categoria.Items.Add("Todas");
            for (int i = 1; i <= 5; i++)
            {
                ComboBox_Categoria.Items.Add(i.ToString());
            }
            ComboBox_Categoria.SelectedIndex = 0; // Establecer "Todas" como selección predeterminada
            ComboBox_Categoria.SelectedIndexChanged += ComboBox_Categoria_SelectedIndexChanged;  // Suscribir al evento SelectedIndexChanged

            CargarProductos();
        }

        private void ComboBox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textoCategoria = ComboBox_Categoria.SelectedItem.ToString();

            if (textoCategoria == "Todas")
            {
                ActualizarDataGridView(productosCompleta);
                MostrarAvisoLabel(productosCompleta.Count(p => Validar.EsStockCritico(p)));
            }
            else
            {
                // Filtrar la lista completa de productos por la categoría seleccionada
                List<TraerProductos> ProductosFiltrados = productosCompleta
                    .Where(p => p.IDCategoria.ToString() == textoCategoria)
                    .ToList();

                if (ProductosFiltrados.Count > 0)
                {
                    ActualizarDataGridView(ProductosFiltrados);
                    MostrarAvisoLabel(ProductosFiltrados.Count(p => Validar.EsStockCritico(p)));
                }
                else
                {
                    MessageBox.Show("No se encontraron productos para la categoría seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MostrarAvisoLabel(0);
                }
            }
        }

        private void MostrarAvisoLabel(int cantidadProductosCriticos)
        {
            if (cantidadProductosCriticos > 0)
            {
                Aviso_Label.Text = $"Cuidado: Hay {cantidadProductosCriticos} productos con stock crítico";
                Aviso_Label.ForeColor = Color.Red;
            }
            else
            {
                Aviso_Label.Text = "No hay productos en stock crítico para esta categoría";
                Aviso_Label.ForeColor = Color.Black;
            }
        }

        private void CargarProductos()
        {
            try
            {
                productosCompleta = ProductoNegocio.listarProductos(); // Cargar la lista completa de productos
                List<TraerProveedores> Proveedor = ProveedorNegocio.listarProveedores();

                if (productosCompleta != null)
                {
                    productosCompleta = productosCompleta
                        .Where(u => u != null && u.Nombre != null && u.Nombre.Contains("G1") && Validar.EsStockCritico(u))
                        .ToList();
                }

                // Mostrar todos los productos al cargar inicialmente
                ActualizarDataGridView(productosCompleta);

                // Mostrar el aviso según la cantidad de productos críticos
                MostrarAvisoLabel(productosCompleta.Count);

                Productos.CellFormatting += Productos_CellFormatting; // Suscribirse al evento CellFormatting
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Productos: " + ex.Message);
            }
        }

        private void ActualizarDataGridView(List<TraerProductos> productos)
        {
            var bindingList = new BindingList<TraerProductos>(productos ?? new List<TraerProductos>());
            var source = new BindingSource(bindingList, null);
            Productos.DataSource = source;
            Productos.Columns["id"].Visible = false;
            Productos.Columns["fechaBaja"].Visible = false;
            Productos.Columns["fechaAlta"].Visible = false;
            Productos.Columns["Precio"].Visible = false;
            Productos.Columns["IDCategoria"].HeaderText = "Categoría";
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
                // Obtener el valor de la celda de la columna "Stock"
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int stockValue))
                {
                    // Obtener la categoría correspondiente de la fila actual (ajustar el índice de la columna de categoría según sea necesario)
                    string categoria = Productos.Rows[e.RowIndex].Cells["IDCategoria"].Value.ToString();

                    // Determinar el umbral de stock según la categoría
                    int umbralStock = int.MaxValue; // Valor por defecto si la categoría no coincide con ninguna de las especificadas
                    switch (categoria)
                    {
                        case "Categoría 1":
                            umbralStock = 100;
                            break;
                        case "Categoría 2":
                            umbralStock = 200;
                            break;
                        case "Categoría 3":
                            umbralStock = 300;
                            break;
                        case "Categoría 4":
                            umbralStock = 400;
                            break;
                        case "Categoría 5":
                            umbralStock = 500;
                            break;
                    }

                    // Verificar si el stock es igual o menor al 25% del umbral
                    if (stockValue <= (umbralStock * 0.25))
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
                else
                {
                    // Restablecer el color del texto al valor predeterminado si el valor del stock no es válido
                    e.CellStyle.ForeColor = Productos.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú de Reportes?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InterfazRepoMenu RepoMenu = new InterfazRepoMenu();
                    RepoMenu.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú de Reportes?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazRepoMenu RepoMenu = new InterfazRepoMenu();
                RepoMenu.Show();
            }
        }
    }
}