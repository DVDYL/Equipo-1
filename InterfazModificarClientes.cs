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
    public partial class InterfazModificarClientes : Ventana
    {
        private string idCliente;

        public InterfazModificarClientes(string idCliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
            this.idCliente = idCliente;
        }

        public void ActualizarTextBox(string direccion, string telefono, string email)
        {
            Box_Direccion.Text = direccion;
            Box_Telefono.Text = telefono;
            Box_Mail.Text = email;
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores
            string correoOriginal = Box_Mail.Text; // Almaceno el correo para ver si cuando se cambia, el nuevo ya existe.

            string errorCalle = Validar.EsDepartamento(Box_Direccion.Text);
            if (errorCalle != null)
            {
                // Completar el contenido del TextBox Calle_Error con el error
                Calle_Error.Text = errorCalle;
                Calle_Error.Visible = true;
                MessageBox.Show(errorCalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaCalle.Visible = true;
                ContarErrores++;
            }
            else
            {
                Calle_Error.Visible = false;
                MayudaCalle.Visible = false;// Ocultar el TextBox Calle_Error si el campo Calle no tiene errores.
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorTelefono = Validar.EsTelefono(Box_Telefono.Text);
            if (errorTelefono != null)
            {
                Telefono_Error.Text = errorTelefono;
                Telefono_Error.Visible = true;
                MessageBox.Show(errorTelefono, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaTelefono.Visible = true;
                ContarErrores++;
            }
            else
            {
                Telefono_Error.Visible = false;
                MayudaTelefono.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            if (Box_Mail.Text != correoOriginal)
            {
                string errorMail = Validar.MailCliente(Box_Mail.Text);

            if (errorMail != null) //Si NO cumple con la validación, mostrará el mensaje.
            {
                Mail_Error.Text = errorMail;
                Mail_Error.Visible = true;
                MessageBox.Show(errorMail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaMail.Visible = true;
                ContarErrores++;
            }
            else
            {
                Mail_Error.Visible = false;
                MayudaMail.Visible = false;
            }
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string correo = Box_Mail.Text;
            string correoConfirmado = Box_ConfirMail.Text;
            string errorConfirmarMail = Validar.ConfirmarMail(correo, correoConfirmado);

            if (errorConfirmarMail != null)
            {
                ConfirmMail_Error.Text = errorConfirmarMail;
                ConfirmMail_Error.Visible = true;
                MessageBox.Show(errorConfirmarMail, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaConfirMail.Visible = true;
                ContarErrores++;
            }
            else
            {
                ConfirmMail_Error.Visible = false;
                MayudaConfirMail.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }
            return ContarErrores; // Devolver true si no hay errores, false si hay errores
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                // Mostrar un cuadro de diálogo de confirmación al usuario
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la modificación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    ModificarCliente(idCliente);

                    MessageBox.Show($"Se ha realizado la modificación con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    InterfazListaClientes ListaClientes = new InterfazListaClientes();
                    ListaClientes.Show();
                }
                else
                {
                        // No hacer nada si se elige que no. 
                }
            }
        } // Confirma todos los campos, si está todo correcto, se modifica al cliente.

        public void ModificarCliente(string idCliente)
        {
            // Crear un nuevo objeto ModificarCliente con los datos del formulario
            ClienteNegocio ClienteNegocio = new ClienteNegocio();
            ClienteNegocio.modificarCliente(
                                            idCliente,
                                            Box_Direccion.Text,
                                            Box_Telefono.Text,
                                            Box_ConfirMail.Text
                                         );
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación al usuario
            DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea cancelar la modificación?\n\nNo se guardará ningún cambio.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoConfirmacion == DialogResult.Yes)
            {
                this.Close();
                InterfazListaClientes ListaClientes = new InterfazListaClientes();
                ListaClientes.Show();
            }
            else
            {
                // No hacer nada si se elige que no. 
            }
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea salir? \n\nNo se guardarán los cambios realizados.", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazListaClientes ListaClientes = new InterfazListaClientes(); // Redirigir al listado de clientes
                    ListaClientes.Show();
                    this.Close(); // Cerrar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}
