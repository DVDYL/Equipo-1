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
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            string errorNombre = Validar.EsNombre(Nombre_Box.Text, "Nombre");
            if (errorNombre != null)
            {
                MessageBox.Show(errorNombre, "Verificar el Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                MayudaNombre.Visible = false;
                Nombre_Error.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorApellido = Validar.EsNombre(Apellido_Box.Text, "Apellido");
            if (errorApellido != null)
            {
                MessageBox.Show(errorApellido, "Verificar el Apellido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Apellido_Error.Text = errorApellido;
                Apellido_Error.Visible = true;
                MayudaApellido.Visible = true;
                ContarErrores++;
            }
            else
            {
                Apellido_Error.Visible = false;
                MayudaApellido.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorMail = Validar.MailProveedor(Email_Box.Text);
            if (errorMail != null)
            {
                Mail_Error.Text = errorMail;
                Mail_Error.Visible = true;
                MessageBox.Show(errorMail, "Verificar el Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MayudaMail.Visible = true;
                ContarErrores++;
            }
            else
            {
                Mail_Error.Visible = false;
                MayudaMail.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string correo = Email_Box.Text;
            string correoConfirmado = ConfirMail_Box.Text;
            string errorConfirmarMail = Validar.ConfirmarMail(correo, correoConfirmado);

            if (errorConfirmarMail != null)
            {
                ConfirMail_Error.Text = errorConfirmarMail;
                ConfirMail_Error.Visible = true;
                MessageBox.Show(errorConfirmarMail, "Verificar confirmación del Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MayudaConfirMail.Visible = true;
                ContarErrores++;
            }
            else
            {
                ConfirMail_Error.Visible = false;
                MayudaConfirMail.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorCUIT = Validar.EsCUIT(CUIT_Box.Text);
            if (errorCUIT != null)
            {
                CUIT_Error.Text = errorCUIT;
                CUIT_Error.Visible = true;

                MessageBox.Show(errorCUIT, "Verificar CUIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MayudaCUIT.Visible = true;
                ContarErrores++;
            }
            else
            {
                CUIT_Error.Visible = false;
                MayudaCUIT.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            return ContarErrores; // Devolver true si no hay errores, false si hay errores
        }

        private void CrearProveedor()
        {
            // Está bien, pero tengo que obtener una fecha de alta, podría ser la fecha de hoy y quedar grabado defintivamente.
            // Esa fecha, dónde la guardás? En el .txt?

            ProveedorNegocio AltaProveedor = new ProveedorNegocio();
            AltaProveedor.AgregarProveedor("70b37dc1-8fde-4840-be47-9ababd0ee7e5", Nombre_Box.Text, Apellido_Box.Text, ConfirMail_Box.Text, CUIT_Box.Text);
        }

        private void Limpiar() // Blanquea el Formulario de usuarios
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados
            Nombre_Box.Text = "";
            Apellido_Box.Text = "";
            Email_Box.Text = "";
            ConfirMail_Box.Text = "";
            CUIT_Box.Text = "";

            // Volver a ocultar todos los mensajes de error
            Nombre_Error.Visible = false;
            Mail_Error.Visible = false;
            Apellido_Error.Visible = false;
            ConfirMail_Error.Visible = false;
            CUIT_Error.Visible = false;

            // Ocultar todos los tooltips
            MayudaNombre.Visible = false;
            MayudaApellido.Visible = false;
            MayudaMail.Visible = false;
            MayudaConfirMail.Visible = false;
            MayudaCUIT.Visible = false;
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                CrearProveedor();           

                DialogResult resultadoConfirmacion = MessageBox.Show("¿Desea realizar la operación de alta para el Proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    MessageBox.Show("Se ha realizado la operación de alta para el Proveedor", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultadoContinuar = MessageBox.Show("¿Desea continuar dando de alta proveedores?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoContinuar == DialogResult.No)
                    {
                        Close();
                        InterfazListaProveedores InterfazListaProveedores = new InterfazListaProveedores();
                        InterfazListaProveedores.Show();
                    }
                    else
                    {
                       Limpiar();
                    }
                }
            }
        } // Confirma todos los campos, si está todo correcto, genera un ID de proveedor.

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar el alta del proveedor?\n\nLos cambios no se guardarán.", "Cancelar Alta de Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                InterfazListaProveedores listaProveedores = new InterfazListaProveedores();
                listaProveedores.Show();
                Close();
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir del programa?\n\nSe cerrará la ventana y no se guardarán los datos.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Close();
                }
            }
        }  // Evento KeyDown para cerrar la ventana con la tecla ESC
    }
}