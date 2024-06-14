using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazVentasDevolver : Ventana
    {
        public InterfazVentasDevolver()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
            Boton_Devolver.Visible = false;

            // Llamar al método para cargar el CSV en el DataGridView
            CargarDevolucionesCSV();
        }

        private void CargarDevolucionesCSV()
        {
            // Construir la ruta del archivo relativa al directorio base de la aplicación
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string filePath = Path.Combine(directoryPath, "ventas.csv");

            if (File.Exists(filePath))
            {
                DataTable dataTable = new DataTable();

                // Leer todas las líneas del archivo CSV
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    // Obtener los encabezados del archivo CSV
                    string[] headers = lines[0].Split(',');
                    foreach (string header in headers)
                    {
                        // Cambiar nombres de columnas según especificación
                        if (header.Trim() == "Categorías")
                            dataTable.Columns.Add("Categoría");
                        else if (header.Trim() == "Cantidades")
                            dataTable.Columns.Add("Cantidad");
                        else
                            dataTable.Columns.Add(header.Trim());
                    }

                    // Leer las líneas de datos del archivo CSV (comenzando desde la segunda línea)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(',');

                        // Asegurarse de que hay suficientes columnas en el DataTable
                        while (dataTable.Columns.Count < data.Length)
                        {
                            // Si hay más columnas en los datos que en el DataTable, agregar una columna nueva
                            dataTable.Columns.Add("Columna Extra");
                        }

                        // En este punto, data contiene: Venta Nro.,Fecha,Vendedor,Cliente,Productos,Cantidades,Categorías,Monto,Estado
                        string[] productos = data[4].Split('|');
                        string[] cantidades = data[5].Split('|');
                        string[] categorias = data[6].Split('|');

                        // Asegurarse de que productos, cantidades y categorías tengan la misma longitud
                        int maxLength = Math.Max(productos.Length, Math.Max(cantidades.Length, categorias.Length));

                        for (int j = 0; j < maxLength; j++)
                        {
                            // Crear una nueva fila para cada producto
                            DataRow newRow = dataTable.NewRow();

                            // Copiar los datos principales (Venta Nro., Fecha, Vendedor, Cliente)
                            for (int k = 0; k < 4; k++)
                            {
                                if (k < data.Length)
                                {
                                    newRow[k] = data[k].Trim();
                                }
                            }

                            // Agregar datos de cada producto, cantidad y categoría
                            if (j < productos.Length)
                            {
                                newRow["Productos"] = productos[j].Trim();
                            }
                            if (j < cantidades.Length)
                            {
                                newRow["Cantidad"] = cantidades[j].Trim();
                            }
                            if (j < categorias.Length)
                            {
                                newRow["Categoria"] = categorias[j].Trim();
                            }

                            // Convertir el estado a texto (0 -> Devolución, 1 -> Finalizada)
                            if (data.Length > 8 && data[8].Trim() == "0")
                            {
                                newRow["Estado"] = "Devolución";
                            }
                            else if (data.Length > 8 && data[8].Trim() == "1")
                            {
                                newRow["Estado"] = "Finalizada";
                            }

                            // Agregar la fila al DataTable
                            dataTable.Rows.Add(newRow);
                        }
                    }

                    // Asignar el DataTable al DataGridView si Devoluciones está inicializado
                    if (Devoluciones != null)
                    {
                        Devoluciones.DataSource = dataTable;

                        // Ocultar la columna Monto si existe
                        if (dataTable.Columns.Contains("Monto"))
                        {
                            Devoluciones.Columns["Monto"].Visible = false;
                            Devoluciones.Columns["Categoria"].Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El DataGridView 'Devoluciones' no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo ventas.csv está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo ventas.csv no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Listado_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Boton_Devolver.Visible = true;
        }

        private void Boton_Devolver_Click(object sender, EventArgs e)
        {
            if (Devoluciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Devoluciones.SelectedRows[0];
                string idTransaccion = selectedRow.Cells["Venta Nro."].Value.ToString();
                string estadoActual = selectedRow.Cells["Estado"].Value.ToString();

                if (estadoActual == "Devolución")
                {
                    MessageBox.Show("Esta venta ya ha sido devuelta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Está seguro de que desea devolver la venta con ID {idTransaccion}? Esta acción no se puede deshacer.", "Confirmación de devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    // Construir la ruta del archivo relativa al directorio base de la aplicación
                    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
                    string filePath = Path.Combine(directoryPath, "ventas.csv");

                    if (File.Exists(filePath))
                    {
                        string[] lines = File.ReadAllLines(filePath);
                        bool ventaDevuelta = false;

                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] data = lines[i].Split(',');
                            if (data[0].Trim() == idTransaccion)
                            {
                                if (data[data.Length - 1].Trim() == "1")
                                {
                                    data[data.Length - 1] = "0"; // Cambiar el estado a 0 (Devolución)
                                    lines[i] = string.Join(",", data);
                                    ventaDevuelta = true;
                                    break;
                                }
                                else if (data[data.Length - 1].Trim() == "0")
                                {
                                    MessageBox.Show("Esta venta ya ha sido devuelta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                        }

                        if (ventaDevuelta)
                        {
                            File.WriteAllLines(filePath, lines);
                            MessageBox.Show("La venta ha sido devuelta exitosamente.", "Devolución exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargar el DataGridView
                            CargarDevolucionesCSV();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo ventas.csv no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una venta para devolver.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void Ventana_KeyDown(object sender, KeyEventArgs e)
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
    }
}
