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
    public partial class InterfazModificarProveedores : Ventana
    {
        private string idProveedor;

        public InterfazModificarProveedores(string idProveedor)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado
            this.idProveedor = idProveedor;
        }

        public void ActualizarTextBox(string nombre, string apellido, string mail, string CUIT)
        {
            Box_Nombre.Text = nombre;
            Box_Apellido.Text = apellido;
            Box_Mail.Text = mail;
            CUIT_Box.Text = CUIT;
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores
            string correoOriginal = Box_Mail.Text; // Almaceno el correo para ver si cuando se cambia, el nuevo ya existe.

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                // Completar el contenido del TextBox Calle_Error con el error
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                Nombre_Error.Visible = false;
                MayudaNombre.Visible = false;// Ocultar el TextBox Calle_Error si el campo Calle no tiene errores.
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorApellido = Validar.EsNombre(Box_Nombre.Text, "Apellido");
            if (errorApellido != null)
            {
                // Completar el contenido del TextBox Calle_Error con el error
                Nombre_Error.Text = errorApellido;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorApellido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                Nombre_Error.Visible = false;
                MayudaApellido.Visible = false;// Ocultar el TextBox Calle_Error si el campo Calle no tiene errores.
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
                ConfirMail_Error.Text = errorConfirmarMail;
                ConfirMail_Error.Visible = true;
                MessageBox.Show(errorConfirmarMail, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorCUIT = Validar.EsCUIT(CUIT_Box.Text);
            if (errorCUIT != null)
            {
                // Completar el contenido del TextBox DNI_Error con el error
                CUIT_Error.Text = errorCUIT;
                CUIT_Error.Visible = true;

                MessageBox.Show(errorCUIT, "Verificar CUIT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MayudaCUIT.Visible = true;
                ContarErrores++;
            }
            else
            {
                CUIT_Error.Visible = false;
                MayudaCUIT.Visible = true;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            return ContarErrores; // Devolver true si no hay errores, false si hay errores
        } // Cómo harías para llevarlo a la validadora? Es necesario?

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                // Mostrar un cuadro de diálogo de confirmación al usuario
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la modificación al proveedor {Box_Nombre.Text + " " + Box_Apellido.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    ModificarProveedores(idProveedor);

                    MessageBox.Show($"Se ha realizado la modificación con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    InterfazListaProveedores ListaProveedores = new InterfazListaProveedores();
                    ListaProveedores.Show();
                }
                else
                {
                    // No hacer nada si se elige que no. 
                }
            }
        }

        public void ModificarProveedores(string idProveedor)
        {
            string idUsuario = idProveedor; // Por ahora tomo el parámetro para replicarlo, hay que pasar otro id diferente? No entiendo la diferencia.

           ProveedorNegocio ProveedorNegocio = new ProveedorNegocio();
            ProveedorNegocio.ModificarProveedor(
                                            idProveedor,
                                            idUsuario,
                                            Box_Nombre.Text,
                                            Box_Apellido.Text,
                                            Box_ConfirMail.Text,
                                            CUIT_Box.Text
                                         );
        }

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al listado de proveedores?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
            {
                InterfazListaProveedores Proveedores = new InterfazListaProveedores(); // Redirigir al formulario de proveedores
                Proveedores.Show();
                this.Hide(); // Ocultar el formulario actual
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al listado de proveedores?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes) // Si el usuario elige "Sí", cerrar la sesión
                {
                    InterfazListaProveedores Proveedores = new InterfazListaProveedores(); // Redirigir al formulario de proveedores
                    Proveedores.Show();
                    this.Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}
