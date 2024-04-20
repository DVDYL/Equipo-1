using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class InterfazListaUsuarios : Ventana
    {

        public InterfazListaUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
        }

        private void WWUsuario_Load(object sender, EventArgs e)
        {
            //    var bindingList = new BindingList<Cliente>(Cliente);
            //    var source = new BindingSource(bindingList, null);
            //    dataGridView1.DataSource = source;
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
            InterfazAltaUsuarios Btn = new InterfazAltaUsuarios();
            Btn.Show();
        }

        private void Boton_AltaUsuario_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario InterfazAltaUsuarios
            InterfazAltaUsuarios formInterfazAltaUsuarios = new InterfazAltaUsuarios();

            // Ocultar el formulario actual (InterfazListaUsuarios)
            this.Hide();

            // Mostrar el formulario
            formInterfazAltaUsuarios.Show();
        }

        private void CheckActivo_CheckedChanged(object sender, EventArgs e) // Detecta cambios en el check "De Baja" 
        {
            // Establecer que el usuario se pase a inactivo cuando se tilde esta opción
        }
    }
}