﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class InterfazAltaUsuarios : Ventana
    {
        public InterfazAltaUsuarios() // Esta Función prepara el formulario y sus restricciones
        {
            InitializeComponent(); // Inicializamos el formulario.
            this.StartPosition = FormStartPosition.CenterScreen; // Establecer la posición de inicio en el centro de la pantalla
            this.KeyPreview = true; // Permitir que el formulario capture los eventos de teclado

            Rol_Null.Visible = false; // Ocultar el TextBox Rol_Null

            // Establecer el formato de visualización predeterminado para la fecha de nacimiento
            Calendario_Nacimiento.Format = DateTimePickerFormat.Custom;
            Calendario_Nacimiento.CustomFormat = "dd/MM/yyyy";

        } 

        private void Limpiar() // Blanquea el Formulario de usuarios
        {
            // Reiniciar los valores de todos los campos del formulario a sus valores predeterminados

            ComboBox_Rol.SelectedIndex = -1;
            Box_Nombre.Text = "";
            Box_Apellido.Text = "";
            Box_DNI.Text = "";
            Calendario_Nacimiento.Value = DateTime.Today;
            Box_Calle.Text = "";
            Box_Telefono.Text = "";
            Box_Mail.Text = "";
            Box_Mail_Confirm.Text = "";
            Box_Pass.Text = "";
            Box_Pass_Confirm.Text = "";

            // Volver a ocultar todos los mensajes de error

            Rol_Null.Visible = false;
            Nombre_Error.Visible = false;
            Apellido_Error.Visible = false;
            DNI_Error.Visible = false;
            Edad_Error.Visible = false;
            Calle_Error.Visible = false;
            Telefono_Error.Visible = false;
            Mail_Error.Visible = false;
            ConfirmMail_Error.Visible = false;
            Pass_Error.Visible = false;
            ConfirmPass_Error.Visible = false;

            // Ocultar todos los tooltips

            MayudaApellido.Visible = false;
            MayudaCalle.Visible = false;
            MayudaConfirContra.Visible = false;
            MayudaConfirMail.Visible = false;
            MayudaContra.Visible = false;
            MayudaDNI.Visible = false;
            MayudaFechaNacimiento.Visible = false;
            MayudaMail.Visible = false;
            MayudaNombre.Visible = false;
            MayudaRol.Visible = false;
            MayudaTelefono.Visible = false;

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
                                !string.IsNullOrWhiteSpace(Box_Mail_Confirm.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Pass.Text) ||
                                !string.IsNullOrWhiteSpace(Box_Pass_Confirm.Text);

            // Verificar si los ComboBoxes no han sido desplegados y se ha seleccionado una opción
            bool comboBoxesLlenos = ComboBox_Rol.DroppedDown == false && ComboBox_Rol.SelectedItem != null;

            // Retorna verdadero si al menos uno de los campos de texto está lleno y los ComboBoxes no están desplegados y tienen una selección
            return camposLlenos || comboBoxesLlenos;
        } 

        private string GenerarNombreUsuario(string nombre, string apellido, DateTime fechaNacimiento)
        {
            // Obtener las tres primeras letras del nombre
            string primerasTresLetrasNombre = nombre.Length >= 3 ? nombre.Substring(0, 3) : nombre;

            // Obtener las tres primeras letras del apellido
            string primerasTresLetrasApellido = apellido.Length >= 3 ? apellido.Substring(0, 3) : apellido;

            // Obtener los cuatro dígitos del año de nacimiento
            string añoNacimiento = fechaNacimiento.Year.ToString().Substring(2, 2);

            // Combinar las partes para formar el nombre de usuario
            string nombreUsuario = $"{primerasTresLetrasNombre.ToUpper()}{primerasTresLetrasApellido.ToUpper()}{añoNacimiento}";

            return nombreUsuario;
        } // Función para autogenerar el nombre del usuario

        private void ComboBox_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        } // Detecta Cambios en el campo "Rol"

        private void Boton_Confirmar_Click(object sender, EventArgs e)
        {

            if (ComboBox_Rol.SelectedIndex == -1)
            {
                Rol_Null.Visible = true; // Mostrar el TextBox Rol_Null

                // Mostrar mensaje de advertencia cuando el tipo de usuario está en blanco
                MessageBox.Show("No se seleccionó ningún tipo de usuario.\n\nPor favor, seleccione un tipo de usuario y vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_Rol.Focus();
                MayudaRol.Visible = true;
                return;
            } // Verifica que el combobox de tipo de usuario no sea vacío.
            else
            {
                Rol_Null.Visible = false; // Ocultar el TextBox Rol_Null si el combobox Rol no es Null
            }

            string errorNombre = Validar.EsNombre(Box_Nombre.Text, "Nombre");
            if (errorNombre != null)
            {
                // Completar el contenido del TextBox Nombre_Error con el error
                Nombre_Error.Text = errorNombre;
                Nombre_Error.Visible = true;
                MessageBox.Show(errorNombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaNombre.Visible = true;
                return;
            }
            else
            {
                Nombre_Error.Visible = false; // Ocultar el TextBox Nombre_Error si el campo nombre no tiene errores.
            }

            string errorApellido = Validar.EsNombre(Box_Apellido.Text, "Apellido");
            if (errorApellido != null)
            {
                // Completar el contenido del TextBox Apellido_Error con el error
                Apellido_Error.Text = errorApellido;
                Apellido_Error.Visible = true;
                MessageBox.Show(errorApellido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaApellido.Visible = true;
                return;
            }
            else
            {
                Apellido_Error.Visible = false; // Ocultar el TextBox Nombre_Error si el campo nombre no tiene errores.
            }

            string errorDNI = Validar.EsDNI(Box_DNI.Text);
            if (errorDNI != null)
            {
                // Completar el contenido del TextBox DNI_Error con el error
                DNI_Error.Text = errorDNI;
                DNI_Error.Visible = true;

                MessageBox.Show(errorDNI, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaDNI.Visible = true;
                return;
            }
            else
            {
                DNI_Error.Visible = false; // Ocultar el TextBox Nombre_Error si el campo nombre no tiene errores.
            }

            DateTime fechaNacimiento = Calendario_Nacimiento.Value; // Verifica que el usuario tenga sea mayor de 18 años y menor de 65 a partir de hoy.
            string errorEdad = Validar.EsEdadLaboral(fechaNacimiento);
            if (errorEdad != null)
            {
                Edad_Error.Text = errorEdad;
                Edad_Error.Visible = true;
                // Mostrar mensaje de advertencia si la edad no es válida
                MessageBox.Show(errorEdad, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaFechaNacimiento.Visible = true;
                return;
            }
            else
            {
                Edad_Error.Visible=false; 
            }

            string errorCalle = Validar.EsCalle(Box_Calle.Text);
            if (errorCalle != null)
            {
                // Completar el contenido del TextBox Calle_Error con el error
                Calle_Error.Text = errorCalle;
                Calle_Error.Visible = true;
                MessageBox.Show(errorCalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaCalle.Visible = true;
                return;
            }
            else
            {
                Calle_Error.Visible = false; // Ocultar el TextBox Calle_Error si el campo Calle no tiene errores.
            }

            string errorTelefono = Validar.EsTelefono(Box_Telefono.Text);
            if (errorTelefono != null)
            {
                Telefono_Error.Text = errorTelefono;
                Telefono_Error.Visible = true;
                MessageBox.Show(errorTelefono, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaTelefono.Visible = true;
                return;
            }
            else
            {
                Telefono_Error.Visible = false;
            }

            string errorMail = Validar.EsMail(Box_Mail.Text);
            if (errorMail !=null) //Si NO cumple con la validación, mostrará el mensaje.
            {
                Mail_Error.Text = errorMail;
                Mail_Error.Visible = true;
                MessageBox.Show(errorMail, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MayudaMail.Visible = true;
                return;
            }
            else
            {
                Mail_Error.Visible = false;
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
                return;
            }
            else
            {
                ConfirmMail_Error.Visible = false;
            }

            string errorContraseña = Validar.EsContraseña(Box_Pass.Text);
            if (errorContraseña != null)
            {
                Pass_Error.Text = errorContraseña;
                Pass_Error.Visible = true;
                MessageBox.Show(errorContraseña, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaContra.Visible = true;
                return;
            }
            else 
            {
                Pass_Error.Visible = false;
            }

            string contraseña = Box_Pass.Text;
            string contraseñaConfirmada = Box_Pass_Confirm.Text;
            string errorConfirmarContraseña = Validar.ConfirmarContraseña(contraseña, contraseñaConfirmada);

            if (errorConfirmarContraseña != null) 
            {
                ConfirmPass_Error.Text = errorConfirmarContraseña;
                ConfirmPass_Error.Visible = true;
                MessageBox.Show(errorConfirmarContraseña, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MayudaConfirContra.Visible = true;
                return;
            }
            else
            {
                ConfirmPass_Error.Visible = false;
            }

            // Si todas las validaciones pasan, mostrar mensaje de éxito.

            string nombreUsuario = GenerarNombreUsuario(Box_Nombre.Text, Box_Apellido.Text, Calendario_Nacimiento.Value); // Generar el nombre de usuario


            // Mostrar un cuadro de diálogo de confirmación al usuario
            DialogResult resultadoConfirmacion = MessageBox.Show($"¿Desea realizar la operación de alta para el usuario {nombreUsuario}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultadoConfirmacion == DialogResult.Yes)
            {
                // Mostrar mensaje de éxito con el nombre de usuario generado
                MessageBox.Show($"Se ha realizado la operación de alta para el usuario {nombreUsuario}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Preguntar al usuario si desea continuar en el Maestro de Usuarios
                DialogResult resultadoContinuar = MessageBox.Show("¿Desea continuar en el ABM de Usuarios?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultadoContinuar == DialogResult.No)
                {
                    // Cerrar el formulario actual (UserAdmin.cs)
                    this.Close();
                }
                else
                {
                    // Restablecer todos los campos del formulario
                    Limpiar();
                }
            }
            // Si el usuario elige "No" en el cuadro de diálogo de confirmación, no hacemos nada

        } // Confirma todos los campos, si está todo correcto, genera un ID de usuario.

        private void Boton_Limpiar_Click(object sender, EventArgs e)
        {
            // Verificar si al menos un campo está completo
            if (CamposCompletos())
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult confirmacion = MessageBox.Show("¿Desea borrar todos los datos?\n\nSe perderán todos los cambios que no se hayan guardado.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    Limpiar();  // Si el usuario elige "Sí", llamar al método para resetear los campos
                }
                // Si el usuario elige "No", no hacer nada
            }
            else
            {
                // Mostrar un mensaje de error
                MessageBox.Show("No hay datos para limpiar.\n\nCódigo de Error: 004", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // Maneja el evento del botón "Limpiar"

        private void Boton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación y volver al menú principal?\n\nSe perderán todos los datos que no se hayan guardado", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cerrar el formulario actual (UserAdmin.cs)
                this.Close(); // Esto cerrará el formulario UserAdmin y volverá automáticamente al formulario Menu si es que fue abierto desde allí
            }
        } // Maneja el evento del botón "Cancelar"

        private void UserAdmin_KeyDown(object sender, KeyEventArgs e) // Reacciona al evento de apretar la tecla ESC 
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult resultado = MessageBox.Show("¿Desea cancelar la operación y volver al menú principal?\n\nSe perderán todos los datos que no se hayan guardado", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Cerrar el formulario actual (UserAdmin.cs)
                    this.Close(); // Esto cerrará el formulario UserAdmin y volverá automáticamente al formulario Menu si es que fue abierto desde allí
                }
            }
        } 

        private void IconoListaUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Crear una instancia del formulario InterfazListaUsuarios
            InterfazListaUsuarios InterfazListaUsuarios = new InterfazListaUsuarios();

            // Mostrar el formulario WWUsuario
            InterfazListaUsuarios.Show();
        }

        private void IconoMenu_Click(object sender, EventArgs e) // Evento para volver al menú cuando se hace clic en el ícono del banner 
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar esta ventana? No se guardarán los cambios.", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {

                this.Hide();   // Ocultar la ventana actual (InterfazABM)

                // Verificar si ya existe una instancia de InterfazMenu
                InterfazMenu menuForm = Application.OpenForms.OfType<InterfazMenu>().FirstOrDefault();
                if (menuForm == null)
                {
                    // Si no existe, crear una nueva instancia
                    menuForm = new InterfazMenu();
                }

                // Mostrar la ventana InterfazMenu
                menuForm.Show();
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void IconoCerrarSesion_Click(object sender, EventArgs e) // Evento para volver al inicio de sesión cuando se hace clic en el ícono del banner 
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar la sesión? No se guardarán los cambios.", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Ocultar la ventana de menú (InterfazMenu)
                this.Hide();

                // Crear una nueva instancia de la ventana InterfazLogIn
                InterfazLogIn loginForm = new InterfazLogIn();

                // Manejar el evento FormClosed de InterfazLogIn para mostrar nuevamente la ventana de menú
                loginForm.FormClosed += (s, args) =>
                {
                    // Mostrar la ventana de menú (InterfazMenu) cuando se cierre la ventana de inicio de sesión
                    this.Show();
                };

                // Mostrar la ventana InterfazLogIn
                loginForm.Show();
            }
            // Si el usuario elige "No", no hacer nada
        }

        private void IconoCerrarSistema_Click(object sender, EventArgs e) // Evento para volver al inicio de sesión cuando se hace clic en el ícono del banner  
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar el programa? No se guardarán los cambios.", "Cerrar programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Cerrar la aplicación
                Application.Exit();
            }
            // Si el usuario elige "No", no hacer nada
        }
    }
}