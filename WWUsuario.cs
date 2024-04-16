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
            // AdjustDatagridviewHeight();
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
