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
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
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
           //   Proveedores.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Proveedores: " + ex.Message);
            }
        }

        private void Proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al menú principal?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazMenu InterfazMenu = new InterfazMenu(); // Redirigir al formulario de inicio de sesión (LogIn)
                    InterfazMenu.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}
