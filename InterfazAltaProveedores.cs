using Negocio;
using Datos;
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
    public partial class InterfazAltaProveedores : Ventana
    {
        public InterfazAltaProveedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            string errorNombre = Validar.EsNombre(Nombre_Box.Text, "Nombre");
            if (errorNombre != null)
            {
                
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                MayudaNombre.Visible = true;

            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorApellido = Validar.EsNombre(Apellido_Box.Text, "Apellido");
            if (errorApellido != null)
            {
                // Completar el contenido del TextBox Apellido_Error con el error
              
                MessageBox.Show(errorApellido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaApellido.Visible = true;
                ContarErrores++;
            }
            else
            {
                
                MayudaApellido.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            //Faktan Validaciones de Mail/Confirmar Mail(Ya existen), Habria que agregar CUIT en clase Validar. 

            return ContarErrores; // Devolver true si no hay errores, false si hay errores
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            // Crear un nuevo objeto AgregarProveedor con los datos del formulario
            ProveedorNegocio AltaProveedor = new ProveedorNegocio();
            AltaProveedor.AgregarProveedor("70b37dc1-8fde-4840-be47-9ababd0ee7e5", Nombre_Box.Text,Apellido_Box.Text,ConfirMail_Box.Text,CUIT_Box.Text);
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación al usuario
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar el alta del proveedor?\n\nLos cambios no se guardarán.", "Cancelar Alta de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Crear una nueva instancia del formulario InterfazListaProveedores
                InterfazListaProveedores listaProveedores = new InterfazListaProveedores();

                // Mostrar el formulario InterfazListaProveedores
                listaProveedores.Show();

                // Cerrar el formulario actual
                this.Close();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir del programa?\n\nSe cerrará la ventana y no se guardarán los datos.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)             // Verificar la respuesta del usuario
                {
                    this.Close();                 // Si el usuario selecciona "Sí", cierra el formulario
                }
            }
        }  // Evento KeyDown para cerrar la ventana con la tecla ESC

        private void Nombre_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void MayudaDNI_Click(object sender, EventArgs e)
        {

        }
    }
}
