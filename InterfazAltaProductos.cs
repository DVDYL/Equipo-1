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
        public InterfazAltaProductos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado

            ComboBox_Categoria.DropDownStyle = ComboBoxStyle.DropDownList; // Configurar para que el usuario no pueda escribir
            ComboBox_Categoria.Items.Add("Audio");
            ComboBox_Categoria.Items.Add("Celulares");
            ComboBox_Categoria.Items.Add("ElectroHogar");
            ComboBox_Categoria.Items.Add("Informática");
            ComboBox_Categoria.Items.Add("Smart TV");
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
                                            "70b37dc1-8fde-4840-be47-9ababd0ee7e5",
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
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
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
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
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
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }
            return ContarErrores;
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                CrearProducto();

                // Mostrar un cuadro de diálogo de confirmación al usuario
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la operación de alta para el producto {Box_Nombre.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    // Mostrar mensaje de éxito con el nombre de usuario generado
                    MessageBox.Show($"Se ha realizado la operación de alta para el producto {Box_Nombre.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Preguntar al usuario si desea continuar en el Maestro de Usuarios
                    DialogResult resultadoContinuar = MessageBox.Show("¿Desea seguir cargando productos?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoContinuar == DialogResult.No)
                    {
                        this.Close();
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
            Precio_Error.Visible = false;  //Faltan Agregar

            // Ocultar todos los tooltips
            MayudaCategoria.Visible = false;
            MayudaNombre.Visible = false;
            MayudaPrecio.Visible = false;
            MayudaStock.Visible = false;
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea volver al listado de productos?. Los cambios no se guardarán", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Ocultar la ventana actual
                this.Hide();

                // Crear una instancia de la ventana InterfazMenu
                InterfazListaProductos ListaProductos = new InterfazListaProductos(); 

                // Mostrar la ventana InterfazMenu
                ListaProductos.Show();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazListaProductos ListaProductos = new InterfazListaProductos(); // Redirigir al formulario de inicio de sesión (LogIn)
                    ListaProductos.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}
