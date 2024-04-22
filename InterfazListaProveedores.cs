using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazListaProveedores : Ventana
    {
        private ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();

        public InterfazListaProveedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
        }

        private void InterfazListaProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            try
            {
                List<TraerProveedores> Proveedor = ProveedorNegocio.listarProveedores();

                var bindingList = new BindingList<TraerProveedores>(Proveedor);
                var source = new BindingSource(bindingList, null);
                Proveedores.DataSource = source;
                Proveedores.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Proveedores: " + ex.Message);
            }
        }

        private void Proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
