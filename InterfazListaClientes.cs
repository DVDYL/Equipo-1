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
    public partial class InterfazListaClientes : Ventana
    {
        private ClienteNegocio ClienteNegocio = new ClienteNegocio();
        public InterfazListaClientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
        }

        private void InterfazListaUsuarios_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                List<Cliente> Cliente = ClienteNegocio.listarClientes();

                var bindingList = new BindingList<Cliente>(Cliente);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["fechaBaja"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        
        private void Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
