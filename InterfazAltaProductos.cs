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
    public partial class InterfazAltaProductos : Ventana
    {
        private ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();

        public InterfazAltaProductos()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
            KeyPreview = true;

            // Configurar el combobox para la categoría de producto
            ComboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Categoria.Items.Add("Audio");
            ComboBox_Categoria.Items.Add("Celulares");
            ComboBox_Categoria.Items.Add("ElectroHogar");
            ComboBox_Categoria.Items.Add("Informática");
            ComboBox_Categoria.Items.Add("Smart TV");

            List<TraerProveedores> Proveedor = ProveedorNegocio.listarProveedores();

            if (Proveedor != null)
            {
                Proveedor = Proveedor.Where(u => u != null && u.Email != null && u.Email.Contains("@G1") && u.FechaBaja == null).ToList();
            }

            ComboBox_Proveedor.DataSource = Proveedor;
            ComboBox_Proveedor.DisplayMember = "nombre"; //+"apellido"
            ComboBox_Proveedor.ValueMember = "id";
        }

        private void CrearProducto()
        {
            int idCategoria;

            if (ComboBox_Categoria.SelectedIndex != -1) // Verifica si se ha seleccionado un ítem en el ComboBox
            {
                if (ComboBox_Categoria.SelectedItem.ToString() == "Audio")
                {
                    idCategoria = 1;
                }
                else if (ComboBox_Categoria.SelectedItem.ToString() == "Celulares")
                {
                    idCategoria = 2;
                }
                else if (ComboBox_Categoria.SelectedItem.ToString() == "ElectroHogar")
                {
                    idCategoria = 3;
                }
                else if (ComboBox_Categoria.SelectedItem.ToString() == "Informática")
                {
                    idCategoria = 4;
                }
                else
                {
                    idCategoria = 5;
                }
            }
            else
            {
                // En caso de que no se haya seleccionado ningún ítem en el ComboBox
                MessageBox.Show("Por favor, seleccione un tipo de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Categoria.Focus();
                return; // Sale del método sin continuar la validación
            }

            // Crear un nuevo objeto AltaUsuario con los datos del formulario
            ProductoNegocio Producto = new ProductoNegocio();
            Producto.AgregarProductos(
                                            idCategoria,
                                            "70b37dc1-8fde-4840-be47-9ababd0ee7e5",
                                            ComboBox_Proveedor.SelectedItem.ToString(),
                                            Box_Nombre.Text + " (G1)", // Acá va el G1 con el que se va a hacer la búsqueda
                                            int.Parse(Box_Precio.Text),
                                            int.Parse(Box_Stock.Text)
                                         ); 
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            if (ComboBox_Categoria.SelectedIndex == -1)
            {
                Categoria_Error.Visible = true;

                // Mostrar mensaje de advertencia cuando el tipo de categoría está en blanco
                MessageBox.Show("No se seleccionó ningún tipo de Categoria.\n\nPor favor, seleccione un tipo de Categoria y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Categoria.Focus();
                MayudaCategoria.Visible = true;
                ContarErrores++;
            }
            else
            {
                Categoria_Error.Visible = false;
                MayudaCategoria.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                Nombre_Error.Visible = false;
                MayudaNombre.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; 
            }

            string errorPrecio = Validar.EsStock(Box_Precio.Text, "Precio");
            if (errorPrecio != null)
            {
                Precio_Error.Text = errorPrecio;
                Precio_Error.Visible = true;
                MessageBox.Show(errorPrecio, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContarErrores++;
            }
            else
            {
                Precio_Error.Visible = false;
                MayudaPrecio.Visible = false;
            }
            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorStock = Validar.EsStock(Box_Stock.Text, "Stock");
            if (errorStock != null)
            {
                Stock_Error.Text = errorStock;
                Stock_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContarErrores++;
            }
            else
            {
                Stock_Error.Visible = false;
                MayudaStock.Visible = false;
            }
            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }
            return ContarErrores;
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                CrearProducto();

                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la operación de alta para el producto {Box_Nombre.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    MessageBox.Show($"Se ha realizado la operación de alta para el producto {Box_Nombre.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultadoContinuar = MessageBox.Show("¿Desea seguir cargando productos?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoContinuar == DialogResult.No)
                    {
                        Close();
                        InterfazListaProductos ListaProductos = new InterfazListaProductos();
                        ListaProductos.Show();
                    }
                    else
                    {
                        Limpiar(); // Restablecer todos los campos del formulario
                    }
                }
            }
        }

        private void Limpiar()
        {
            ComboBox_Categoria.SelectedIndex = -1;
            Box_Nombre.Text = "";
            Box_Precio.Text = "";
            Box_Stock.Text = "";

            Categoria_Error.Visible = false;
            Nombre_Error.Visible = false;
            Stock_Error.Visible = false;
            Precio_Error.Visible = false;

            MayudaCategoria.Visible = false;
            MayudaNombre.Visible = false;
            MayudaPrecio.Visible = false;
            MayudaStock.Visible = false;
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al listado de productos?. Los cambios no se guardarán", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazListaProductos ListaProductos = new InterfazListaProductos(); 
                ListaProductos.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    InterfazListaProductos ListaProductos = new InterfazListaProductos();
                    ListaProductos.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }

    }
}
