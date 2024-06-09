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
    public partial class InterfazModificarProductos : Ventana
    {
        private string idProducto;
        public InterfazModificarProductos(string idProducto)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
            this.idProducto = idProducto;
        }

        public void ActualizarTextBox(int precio, int stock)
        {
            Box_Precio.Text = precio.ToString();
            Box_Stock.Text = stock.ToString();
            
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0;

            string errorPrecio = Validar.EsStock(Box_Precio.Text.ToString(),"Precio");
            if (errorPrecio != null)
            {
                Precio_Error.Text = errorPrecio;
                Precio_Error.Visible = true;
                MessageBox.Show(errorPrecio, "Revisar el dato:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaPrecio.Visible = true;
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

            string errorStock = Validar.EsStock(Box_Stock.Text.ToString(), "Stock");
            if (errorStock != null)
            {
                Stock_Error.Text = errorStock;
                Stock_Error.Visible = true;
                MessageBox.Show(errorStock, "Revisar el dato:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaStock.Visible = true;
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

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea cancelar la modificación?\n\nNo se guardará ningún cambio.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoConfirmacion == DialogResult.Yes)
            {
                Close();
                InterfazListaProductos listaProductos = new InterfazListaProductos();
                listaProductos.Show();
            }
            else
            {
                // No hacer nada si se elige que no. 
            }
        }

        public void ModificarProductos(string idProducto)
        {
            string idUsuario = "70b37dc1-8fde-4840-be47-9ababd0ee7e5"; 

            ProductoNegocio ProductoNegocio = new ProductoNegocio();
            ProductoNegocio.ModificarProducto(
                                            idProducto,
                                            idUsuario,
                                            Convert.ToInt32(Box_Precio.Text),
                                            Convert.ToInt32(Box_Stock.Text)
                                         );
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al listado de productos?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    InterfazListaProductos ListaProductos = new InterfazListaProductos();
                    ListaProductos.Show();
                    Hide(); 
                }
                // Si el usuario elige "No", no hacer nada
            }
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    ModificarProductos(idProducto);

                    MessageBox.Show($"Se ha realizado la modificación con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                    InterfazListaProductos listaProductos = new InterfazListaProductos();
                    listaProductos.Show();
                }
                else
                {
                    // No hacer nada si se elige que no. 
                }
            }
        }
    }
}