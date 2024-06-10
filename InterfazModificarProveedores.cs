using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InterfazModificarProveedores : Ventana
    {
        private string idProveedor;
        private string originalCUIT;

        public InterfazModificarProveedores(string idProveedor)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true; 
            this.idProveedor = idProveedor;
            this.Load += new EventHandler(InterfazModificarProveedores_Load); // Agregar manejador del evento Load
        }

        private void InterfazModificarProveedores_Load(object sender, EventArgs e)
        {
            // Almacenar el valor original del CUIT_Box una vez que el formulario se ha cargado
            originalCUIT = CUIT_Box.Text;
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
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Verificar el Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                Nombre_Error.Visible = false;
                MayudaNombre.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            string errorApellido = Validar.EsNombre(Box_Nombre.Text, "Apellido");
            if (errorApellido != null)
            {
                Nombre_Error.Text = errorApellido;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorApellido, "Verificar el Apellido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaNombre.Visible = true;
                ContarErrores++;
            }
            else
            {
                Nombre_Error.Visible = false;
                MayudaApellido.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; 
            }

            if (Box_Mail.Text != correoOriginal)
            {
                string errorMail = Validar.MailCliente(Box_Mail.Text);

                if (errorMail != null)
                {
                    Mail_Error.Text = errorMail;
                    Mail_Error.Visible = true;
                    MessageBox.Show(errorMail, "Verificar el Mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (CUIT_Box.Text != originalCUIT) // Validar CUIT solo si su contenido ha cambiado
            {
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
            }

            return ContarErrores; // Devolver true si no hay errores, false si hay errores
        } 

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la modificación al proveedor {Box_Nombre.Text + " " + Box_Apellido.Text}?", "Confirmar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    ModificarProveedores(idProveedor);

                    MessageBox.Show($"Se ha realizado la modificación con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
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

            if (result == DialogResult.Yes) 
            {
                InterfazListaProveedores Proveedores = new InterfazListaProveedores();
                Proveedores.Show();
                Hide();
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void Ventana_KeyDown(object sender, KeyEventArgs e) // Manejo para el evento de apretar ESC en una ventana 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea volver al listado de proveedores?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    InterfazListaProveedores Proveedores = new InterfazListaProveedores(); 
                    Proveedores.Show();
                    Hide();
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}
