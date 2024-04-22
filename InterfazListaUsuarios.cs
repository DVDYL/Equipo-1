using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Datos;
using Negocio;


namespace Presentacion
{
    public partial class InterfazListaUsuarios : Ventana
    {
        private UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();

        public InterfazListaUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView1.CellClick += Usuarios_CellClick;
        }

        private void InterfazListaUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                List<UsuariosActivos> Usuario = UsuarioNegocio.ListarUsuarios();

                var bindingList = new BindingList<UsuariosActivos>(Usuario);
                var source = new BindingSource(bindingList, null);
                Usuarios.DataSource = source;
                Usuarios.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Usuarios: " + ex.Message);
            }
        }

        private void Boton_AltaUsuario_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario InterfazAltaUsuarios
            InterfazAltaUsuarios formInterfazAltaUsuarios = new InterfazAltaUsuarios();

            // Ocultar el formulario actual (InterfazListaUsuarios)
            this.Hide();

            // Mostrar el formulario
            formInterfazAltaUsuarios.Show();
        } // Evento cuando se hace clic en el Botón "+ Nuevo"

        private void CheckActivo_CheckedChanged(object sender, EventArgs e) // Detecta cambios en el check "De Baja" 
        {
            // Establecer que el usuario se pase a inactivo cuando se tilde esta opción
        }

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar la acción
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Ocultar la ventana actual
                this.Hide();

                // Crear una instancia de la ventana InterfazMenu
                InterfazMenu ventanaMenu = new InterfazMenu();

                // Mostrar la ventana InterfazMenu
                ventanaMenu.Show();
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
                    InterfazMenu InterfazMenu = new InterfazMenu(); // Redirigir al formulario de inicio de sesión (LogIn)
                    InterfazMenu.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
        private void Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count)
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                if (column.Name == "Visualizar")
                {
                    Console.WriteLine("Clic en Visualizar");
                    string Mode = "DSP";
                    MessageBox.Show("El valor de Mode es: " + Mode);
                }
                else
                {
                    MessageBox.Show("Clic en Visualizar");
                }
            }
            else
            {
                Console.WriteLine("prueba");
            }
        }
    }
}