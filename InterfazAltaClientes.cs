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
    public partial class InterfazAltaClientes : Ventana
    {
        public InterfazAltaClientes()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;

            // Establecer el formato de visualización predeterminado para la fecha de nacimiento
            Calendario_Nacimiento.Format = DateTimePickerFormat.Custom;
            Calendario_Nacimiento.CustomFormat = "dd/MM/yyyy";
        }

        private int ControlarCampos()
        {
            int ContarErrores = 0; // Contador de errores

            string errorDNI = Validar.EsDNI(Box_DNI.Text);
            if (errorDNI != null)
            {
                // Completar el contenido del TextBox DNI_Error con el error
                DNI_Error.Text = errorDNI;
                DNI_Error.Visible = true;

                MessageBox.Show(errorDNI, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaDNI.Visible = true;
                ContarErrores++;
            }
            else
            {
                DNI_Error.Visible = false;
                MayudaDNI.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores; // Detener la ejecución y devolver el contador de errores
            }

            DateTime fechaNacimiento = Calendario_Nacimiento.Value; // Verifica que el usuario tenga sea mayor de 18 años y menor de 65 a partir de hoy.
            string errorEdad = Validar.EsEdadLaboral(fechaNacimiento);
            if (errorEdad != null)
            {
                Edad_Error.Text = errorEdad;
                Edad_Error.Visible = true;
                MessageBox.Show(errorEdad, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaFechaNacimiento.Visible = true;
                ContarErrores++;
            }
            else
            {
                Edad_Error.Visible = false;
                MayudaFechaNacimiento.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
            }

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return ContarErrores;
            }

            string errorApellido = Validar.EsNombre(Box_Apellido.Text, "Apellido");
            if (errorApellido != null)
            {
                Apellido_Error.Text = errorApellido;
                Apellido_Error.Visible = true;
                MessageBox.Show(errorApellido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string errorCalle = Validar.EsDepartamento(Box_Calle.Text);
            if (errorCalle != null)
            {
                Calle_Error.Text = errorCalle;
                Calle_Error.Visible = true;
                MessageBox.Show(errorCalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaCalle.Visible = true;
                ContarErrores++;
            }
            else
            {
                Calle_Error.Visible = false;
                MayudaCalle.Visible = false;
            }

            if (ContarErrores >= 1)
            {
                return ContarErrores;
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
                return ContarErrores; 
            }

            string errorMail = Validar.MailCliente(Box_Mail.Text);
            if (errorMail != null) 
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

            if (ContarErrores >= 1)
            {
                return ContarErrores; 
            }

            string correo = Box_Mail.Text;
            string correoConfirmado = Box_Mail_Confirm.Text;
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
                return ContarErrores;
            }
            return ContarErrores; // Devolver true si no hay errores, false si hay errores
        }

        private bool CamposCompletos() // Evalúa qué campos del formulario están completos
        {
            // Verificar si al menos uno de los campos está lleno
            bool camposLlenos = !string.IsNullOrWhiteSpace(Box_Nombre.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Apellido.Text) ||
                                !string.IsNullOrWhiteSpace(Box_DNI.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Calle.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Telefono.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Mail.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Mail_Confirm.Text);

            // Retorna verdadero si al menos uno de los campos de texto está lleno y los ComboBoxes no están desplegados y tienen una selección
            return camposLlenos;
        }

        private void Limpiar() // Blanquea el Formulario de usuarios
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados

            Box_Nombre.Text = "";
            Box_Apellido.Text = "";
            Box_DNI.Text = "";
            Calendario_Nacimiento.Value = DateTime.Today;
            Box_Calle.Text = "";
            Box_Telefono.Text = "";
            Box_Mail.Text = "";
            Box_Mail_Confirm.Text = "";

            // Volver a ocultar todos los mensajes de error

            Nombre_Error.Visible = false;
            Apellido_Error.Visible = false;
            DNI_Error.Visible = false;
            Edad_Error.Visible = false;
            Calle_Error.Visible = false;
            Telefono_Error.Visible = false;
            Mail_Error.Visible = false;
            ConfirmMail_Error.Visible = false;

            // Ocultar todos los tooltips

            MayudaApellido.Visible = false;
            MayudaCalle.Visible = false;
            MayudaConfirMail.Visible = false;
            MayudaDNI.Visible = false;
            MayudaFechaNacimiento.Visible = false;
            MayudaMail.Visible = false;
            MayudaNombre.Visible = false;
            MayudaTelefono.Visible = false;

        }

        private void CrearCliente()
        {
            string host;
            host = "1";
            
            // Crear un nuevo objeto AltaUsuario con los datos del formulario
            ClienteNegocio ClienteNegocio = new ClienteNegocio();
            ClienteNegocio.agregarCliente(
                                            "70b37dc1-8fde-4840-be47-9ababd0ee7e5",
                                            Box_Nombre.Text,
                                            Box_Apellido.Text,
                                            int.Parse(Box_DNI.Text),
                                            Box_Calle.Text,
                                            Box_Telefono.Text,
                                            Box_Mail_Confirm.Text,
                                            Calendario_Nacimiento.Value,
                                            host
                                         );
        }

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {
            int contadorErrores = ControlarCampos();

            if (contadorErrores == 0)
            {
                CrearCliente();

                DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la operación de alta para el cliente {Box_Nombre.Text + " " + Box_Apellido.Text}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    MessageBox.Show($"Se ha realizado la operación de alta para el cliente {Box_Nombre.Text + " " + Box_Apellido.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultadoContinuar = MessageBox.Show("¿Desea seguir cargando clientes?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoContinuar == DialogResult.No)
                    {
                        Close();
                        InterfazListaClientes ListaUsuarios = new InterfazListaClientes();
                        ListaUsuarios.Show();
                    }
                    else
                    {
                        Limpiar();
                    }
                }
            }
        } // Confirma todos los campos, si está todo correcto, genera un ID de usuario.

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            if (CamposCompletos()) // Verificar si al menos un campo está completo
            {
                DialogResult confirmacion = MessageBox.Show("¿Desea borrar todos los datos?\n\nSe perderán todos los cambios que no se hayan guardado.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    Limpiar();
                }
                // Si el usuario elige "No", no hacer nada
            }
            else
            {
                MessageBox.Show("No hay datos para limpiar.", "Formulario Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // Maneja el evento del botón "Limpiar"

        private void Boton_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al listado de usuarios?\n\nLos cambios realizados no se guardarán.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Hide();
                InterfazListaClientes ListaClientes = new InterfazListaClientes();
                ListaClientes.Show();
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
                    Hide(); // Ocultar el formulario actual
                }
                // Si el usuario elige "No", no hacer nada
            }
        }
    }
}
