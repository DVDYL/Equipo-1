using Equipo1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Presentacion
{
    public partial class WWUsuario : Form
    {
        public WWUsuario()
        {
            InitializeComponent();
        }

        private void WWUsuario_Load(object sender, EventArgs e)
        {
                var bindingList = new BindingList<Cliente>(Cliente);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
             //   dataGridView1.Columns["id"].Visible = false;
             //   dataGridView1.Columns["fechaBaja"].Visible = false;
        }

        private void AdjustDatagridviewHeight()
        {
            var height = dataGridView1.ColumnHeadersHeight;
            foreach (DataGridViewColumn dr in dataGridView1.Rows) 
            { 
                height += /*dr.*/Height;
            }
            dataGridView1.Height = height;
        }

        private void Usuarios_CellContentClickEditar(object sender, DataGridViewCellEventArgs e)
        {
            InterfazABM Btn = new InterfazABM();
            Btn.Show();
        }
    }
}
