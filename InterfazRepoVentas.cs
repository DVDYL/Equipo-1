using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazRepoVentas : Ventana
    {
        public InterfazRepoVentas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;

            CargarVentasPorVendedor();
        }

        public class VentasPorMes
        {
            public int CantidadVentas { get; set; }
            public decimal MontoTotal { get; set; }

            public VentasPorMes()
            {
                CantidadVentas = 0;
                MontoTotal = 0;
            }
        }

        private void CargarVentasPorVendedor()
        {
            // Ruta del archivo CSV
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CAI", "Equipo1");
            string filePath = Path.Combine(directoryPath, "ventas.csv");

            // Verificar si el archivo existe
            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo ventas.csv no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Diccionario para almacenar las ventas por vendedor y mes
            Dictionary<string, Dictionary<string, VentasPorMes>> ventasPorVendedorYMes =
                new Dictionary<string, Dictionary<string, VentasPorMes>>();

            try
            {
                // Leer todas las líneas del archivo CSV excepto la primera (encabezados)
                string[] lines = File.ReadAllLines(filePath).Skip(1).ToArray();

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 9)
                    {
                        string vendedor = data[2].Trim();
                        string fechaVentaString = data[1].Trim();
                        string montoString = data[8].Trim().Replace("$", "").Replace(",", "");

                        if (decimal.TryParse(montoString, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal monto))
                        {
                            if (DateTime.TryParseExact(fechaVentaString, "d/M/yyyy H:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaVenta))
                            {
                                string mes = fechaVenta.ToString("MMMM yyyy");

                                if (!ventasPorVendedorYMes.TryGetValue(vendedor, out Dictionary<string, VentasPorMes> ventasPorMes))
                                {
                                    ventasPorMes = new Dictionary<string, VentasPorMes>();
                                    ventasPorVendedorYMes[vendedor] = ventasPorMes;
                                }

                                if (!ventasPorMes.TryGetValue(mes, out VentasPorMes ventasPorMesActual))
                                {
                                    ventasPorMesActual = new VentasPorMes();
                                    ventasPorMes[mes] = ventasPorMesActual;
                                }

                                ventasPorMesActual.CantidadVentas++;
                                ventasPorMesActual.MontoTotal += monto;
                            }
                            else
                            {
                                Console.WriteLine($"Error al parsear la fecha: {fechaVentaString}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Error al parsear el monto: {montoString}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Línea incompleta o mal formada: {line}");
                    }
                }

                // Mostrar los resultados en el DataGridView
                MostrarResultadosEnDataGridView(ventasPorVendedorYMes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultadosEnDataGridView(Dictionary<string, Dictionary<string, VentasPorMes>> ventasPorVendedorYMes)
        {
            // Crear un DataTable para mostrar los resultados
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Vendedor");
            dataTable.Columns.Add("Mes");
            dataTable.Columns.Add("Ventas", typeof(int));
            dataTable.Columns.Add("Monto Total", typeof(decimal));

            // Llenar el DataTable con los datos del diccionario
            foreach (var kvpVendedor in ventasPorVendedorYMes)
            {
                string vendedor = kvpVendedor.Key;
                foreach (var kvpMes in kvpVendedor.Value)
                {
                    string mes = kvpMes.Key;
                    int cantidadVentas = kvpMes.Value.CantidadVentas;
                    decimal montoTotal = kvpMes.Value.MontoTotal;
                    dataTable.Rows.Add(vendedor, mes, cantidadVentas, montoTotal);
                }
            }

            // Asignar el DataTable al DataGridView si VentasPorVendedor está inicializado
            if (VentasPorVendedor != null)
            {
                VentasPorVendedor.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("El DataGridView 'VentasPorVendedor' no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
