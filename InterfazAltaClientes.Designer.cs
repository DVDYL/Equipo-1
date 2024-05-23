namespace Presentacion
{
    partial class InterfazAltaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.SeparatorPersona = new System.Windows.Forms.GroupBox();
            this.Edad_Error = new System.Windows.Forms.TextBox();
            this.Telefono_Error = new System.Windows.Forms.TextBox();
            this.Calle_Error = new System.Windows.Forms.TextBox();
            this.DNI_Error = new System.Windows.Forms.TextBox();
            this.Apellido_Error = new System.Windows.Forms.TextBox();
            this.Nombre_Error = new System.Windows.Forms.TextBox();
            this.MayudaFechaNacimiento = new System.Windows.Forms.Label();
            this.MayudaTelefono = new System.Windows.Forms.Label();
            this.MayudaCalle = new System.Windows.Forms.Label();
            this.MayudaDNI = new System.Windows.Forms.Label();
            this.MayudaApellido = new System.Windows.Forms.Label();
            this.MayudaNombre = new System.Windows.Forms.Label();
            this.Box_Telefono = new System.Windows.Forms.TextBox();
            this.Box_Calle = new System.Windows.Forms.TextBox();
            this.Box_DNI = new System.Windows.Forms.TextBox();
            this.Box_Apellido = new System.Windows.Forms.TextBox();
            this.Box_Nombre = new System.Windows.Forms.TextBox();
            this.Calendario_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.Label_F_Nacimiento = new System.Windows.Forms.Label();
            this.Label_DNI = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Direccion = new System.Windows.Forms.Label();
            this.Label_Apellido = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.ConfirmMail_Error = new System.Windows.Forms.TextBox();
            this.Mail_Error = new System.Windows.Forms.TextBox();
            this.MayudaConfirMail = new System.Windows.Forms.Label();
            this.MayudaMail = new System.Windows.Forms.Label();
            this.Box_Mail_Confirm = new System.Windows.Forms.TextBox();
            this.Box_Mail = new System.Windows.Forms.TextBox();
            this.Label_ConfirmarEmail = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Boton_Limpiar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Boton_Confirmar = new System.Windows.Forms.Button();
            this.Importar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(1361, 814);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(190, 42);
            this.Boton_Salir.TabIndex = 6;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // SeparatorPersona
            // 
            this.SeparatorPersona.BackColor = System.Drawing.Color.Gainsboro;
            this.SeparatorPersona.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparatorPersona.Location = new System.Drawing.Point(32, 71);
            this.SeparatorPersona.Name = "SeparatorPersona";
            this.SeparatorPersona.Size = new System.Drawing.Size(719, 40);
            this.SeparatorPersona.TabIndex = 70;
            this.SeparatorPersona.TabStop = false;
            this.SeparatorPersona.Text = "Alta de Cliente";
            // 
            // Edad_Error
            // 
            this.Edad_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Edad_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad_Error.ForeColor = System.Drawing.Color.Red;
            this.Edad_Error.Location = new System.Drawing.Point(437, 207);
            this.Edad_Error.Multiline = true;
            this.Edad_Error.Name = "Edad_Error";
            this.Edad_Error.Size = new System.Drawing.Size(320, 20);
            this.Edad_Error.TabIndex = 81;
            // 
            // Telefono_Error
            // 
            this.Telefono_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefono_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_Error.ForeColor = System.Drawing.Color.Red;
            this.Telefono_Error.Location = new System.Drawing.Point(437, 476);
            this.Telefono_Error.Multiline = true;
            this.Telefono_Error.Name = "Telefono_Error";
            this.Telefono_Error.Size = new System.Drawing.Size(320, 20);
            this.Telefono_Error.TabIndex = 80;
            // 
            // Calle_Error
            // 
            this.Calle_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calle_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calle_Error.ForeColor = System.Drawing.Color.Red;
            this.Calle_Error.Location = new System.Drawing.Point(73, 476);
            this.Calle_Error.Multiline = true;
            this.Calle_Error.Name = "Calle_Error";
            this.Calle_Error.Size = new System.Drawing.Size(320, 20);
            this.Calle_Error.TabIndex = 79;
            // 
            // DNI_Error
            // 
            this.DNI_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DNI_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI_Error.ForeColor = System.Drawing.Color.Red;
            this.DNI_Error.Location = new System.Drawing.Point(73, 207);
            this.DNI_Error.Multiline = true;
            this.DNI_Error.Name = "DNI_Error";
            this.DNI_Error.Size = new System.Drawing.Size(320, 20);
            this.DNI_Error.TabIndex = 78;
            // 
            // Apellido_Error
            // 
            this.Apellido_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_Error.ForeColor = System.Drawing.Color.Red;
            this.Apellido_Error.Location = new System.Drawing.Point(437, 340);
            this.Apellido_Error.Multiline = true;
            this.Apellido_Error.Name = "Apellido_Error";
            this.Apellido_Error.Size = new System.Drawing.Size(320, 20);
            this.Apellido_Error.TabIndex = 77;
            // 
            // Nombre_Error
            // 
            this.Nombre_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Error.ForeColor = System.Drawing.Color.Red;
            this.Nombre_Error.Location = new System.Drawing.Point(73, 340);
            this.Nombre_Error.Multiline = true;
            this.Nombre_Error.Name = "Nombre_Error";
            this.Nombre_Error.Size = new System.Drawing.Size(320, 20);
            this.Nombre_Error.TabIndex = 76;
            // 
            // MayudaFechaNacimiento
            // 
            this.MayudaFechaNacimiento.AutoSize = true;
            this.MayudaFechaNacimiento.BackColor = System.Drawing.Color.LightGray;
            this.MayudaFechaNacimiento.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaFechaNacimiento.Location = new System.Drawing.Point(693, 176);
            this.MayudaFechaNacimiento.Name = "MayudaFechaNacimiento";
            this.MayudaFechaNacimiento.Size = new System.Drawing.Size(12, 15);
            this.MayudaFechaNacimiento.TabIndex = 75;
            this.MayudaFechaNacimiento.Text = "?";
            this.MayudaFechaNacimiento.Visible = false;
            // 
            // MayudaTelefono
            // 
            this.MayudaTelefono.AutoSize = true;
            this.MayudaTelefono.BackColor = System.Drawing.Color.LightGray;
            this.MayudaTelefono.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaTelefono.Location = new System.Drawing.Point(693, 448);
            this.MayudaTelefono.Name = "MayudaTelefono";
            this.MayudaTelefono.Size = new System.Drawing.Size(12, 15);
            this.MayudaTelefono.TabIndex = 74;
            this.MayudaTelefono.Text = "?";
            this.MayudaTelefono.Visible = false;
            // 
            // MayudaCalle
            // 
            this.MayudaCalle.AutoSize = true;
            this.MayudaCalle.BackColor = System.Drawing.Color.LightGray;
            this.MayudaCalle.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaCalle.Location = new System.Drawing.Point(329, 449);
            this.MayudaCalle.Name = "MayudaCalle";
            this.MayudaCalle.Size = new System.Drawing.Size(12, 15);
            this.MayudaCalle.TabIndex = 73;
            this.MayudaCalle.Text = "?";
            this.MayudaCalle.Visible = false;
            // 
            // MayudaDNI
            // 
            this.MayudaDNI.AutoSize = true;
            this.MayudaDNI.BackColor = System.Drawing.Color.LightGray;
            this.MayudaDNI.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaDNI.Location = new System.Drawing.Point(329, 176);
            this.MayudaDNI.Name = "MayudaDNI";
            this.MayudaDNI.Size = new System.Drawing.Size(12, 15);
            this.MayudaDNI.TabIndex = 72;
            this.MayudaDNI.Text = "?";
            this.MayudaDNI.Visible = false;
            // 
            // MayudaApellido
            // 
            this.MayudaApellido.AutoSize = true;
            this.MayudaApellido.BackColor = System.Drawing.Color.LightGray;
            this.MayudaApellido.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaApellido.Location = new System.Drawing.Point(693, 308);
            this.MayudaApellido.Name = "MayudaApellido";
            this.MayudaApellido.Size = new System.Drawing.Size(12, 15);
            this.MayudaApellido.TabIndex = 71;
            this.MayudaApellido.Text = "?";
            this.MayudaApellido.Visible = false;
            // 
            // MayudaNombre
            // 
            this.MayudaNombre.AutoSize = true;
            this.MayudaNombre.BackColor = System.Drawing.Color.LightGray;
            this.MayudaNombre.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaNombre.Location = new System.Drawing.Point(329, 308);
            this.MayudaNombre.Name = "MayudaNombre";
            this.MayudaNombre.Size = new System.Drawing.Size(12, 15);
            this.MayudaNombre.TabIndex = 69;
            this.MayudaNombre.Text = "?";
            this.MayudaNombre.Visible = false;
            // 
            // Box_Telefono
            // 
            this.Box_Telefono.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Telefono.Location = new System.Drawing.Point(437, 438);
            this.Box_Telefono.Name = "Box_Telefono";
            this.Box_Telefono.Size = new System.Drawing.Size(250, 33);
            this.Box_Telefono.TabIndex = 6;
            // 
            // Box_Calle
            // 
            this.Box_Calle.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Calle.Location = new System.Drawing.Point(73, 438);
            this.Box_Calle.Name = "Box_Calle";
            this.Box_Calle.Size = new System.Drawing.Size(250, 33);
            this.Box_Calle.TabIndex = 5;
            // 
            // Box_DNI
            // 
            this.Box_DNI.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_DNI.Location = new System.Drawing.Point(73, 165);
            this.Box_DNI.Name = "Box_DNI";
            this.Box_DNI.Size = new System.Drawing.Size(250, 33);
            this.Box_DNI.TabIndex = 1;
            // 
            // Box_Apellido
            // 
            this.Box_Apellido.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Apellido.Location = new System.Drawing.Point(437, 298);
            this.Box_Apellido.Name = "Box_Apellido";
            this.Box_Apellido.Size = new System.Drawing.Size(250, 33);
            this.Box_Apellido.TabIndex = 4;
            // 
            // Box_Nombre
            // 
            this.Box_Nombre.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Nombre.Location = new System.Drawing.Point(73, 298);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(250, 33);
            this.Box_Nombre.TabIndex = 3;
            // 
            // Calendario_Nacimiento
            // 
            this.Calendario_Nacimiento.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario_Nacimiento.Location = new System.Drawing.Point(437, 165);
            this.Calendario_Nacimiento.MaxDate = new System.DateTime(2025, 4, 2, 0, 0, 0, 0);
            this.Calendario_Nacimiento.MinDate = new System.DateTime(1958, 1, 1, 0, 0, 0, 0);
            this.Calendario_Nacimiento.Name = "Calendario_Nacimiento";
            this.Calendario_Nacimiento.Size = new System.Drawing.Size(250, 33);
            this.Calendario_Nacimiento.TabIndex = 2;
            this.Calendario_Nacimiento.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // Label_F_Nacimiento
            // 
            this.Label_F_Nacimiento.AutoSize = true;
            this.Label_F_Nacimiento.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_F_Nacimiento.Location = new System.Drawing.Point(420, 131);
            this.Label_F_Nacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_F_Nacimiento.Name = "Label_F_Nacimiento";
            this.Label_F_Nacimiento.Size = new System.Drawing.Size(209, 29);
            this.Label_F_Nacimiento.TabIndex = 68;
            this.Label_F_Nacimiento.Text = "Fecha de Nacimiento";
            // 
            // Label_DNI
            // 
            this.Label_DNI.AutoSize = true;
            this.Label_DNI.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DNI.Location = new System.Drawing.Point(58, 131);
            this.Label_DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DNI.Name = "Label_DNI";
            this.Label_DNI.Size = new System.Drawing.Size(50, 29);
            this.Label_DNI.TabIndex = 67;
            this.Label_DNI.Text = "DNI";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Telefono.Location = new System.Drawing.Point(420, 404);
            this.Label_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(94, 29);
            this.Label_Telefono.TabIndex = 66;
            this.Label_Telefono.Text = "Teléfono";
            // 
            // Label_Direccion
            // 
            this.Label_Direccion.AutoSize = true;
            this.Label_Direccion.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Direccion.Location = new System.Drawing.Point(58, 404);
            this.Label_Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Direccion.Name = "Label_Direccion";
            this.Label_Direccion.Size = new System.Drawing.Size(101, 29);
            this.Label_Direccion.TabIndex = 65;
            this.Label_Direccion.Text = "Dirección";
            // 
            // Label_Apellido
            // 
            this.Label_Apellido.AutoSize = true;
            this.Label_Apellido.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Apellido.Location = new System.Drawing.Point(420, 264);
            this.Label_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Apellido.Name = "Label_Apellido";
            this.Label_Apellido.Size = new System.Drawing.Size(90, 29);
            this.Label_Apellido.TabIndex = 64;
            this.Label_Apellido.Text = "Apellido";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(58, 264);
            this.Label_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(89, 29);
            this.Label_Nombre.TabIndex = 63;
            this.Label_Nombre.Text = "Nombre";
            // 
            // ConfirmMail_Error
            // 
            this.ConfirmMail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmMail_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmMail_Error.ForeColor = System.Drawing.Color.Red;
            this.ConfirmMail_Error.Location = new System.Drawing.Point(438, 614);
            this.ConfirmMail_Error.Multiline = true;
            this.ConfirmMail_Error.Name = "ConfirmMail_Error";
            this.ConfirmMail_Error.Size = new System.Drawing.Size(319, 20);
            this.ConfirmMail_Error.TabIndex = 89;
            // 
            // Mail_Error
            // 
            this.Mail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mail_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_Error.ForeColor = System.Drawing.Color.Red;
            this.Mail_Error.Location = new System.Drawing.Point(88, 614);
            this.Mail_Error.Multiline = true;
            this.Mail_Error.Name = "Mail_Error";
            this.Mail_Error.Size = new System.Drawing.Size(320, 20);
            this.Mail_Error.TabIndex = 88;
            // 
            // MayudaConfirMail
            // 
            this.MayudaConfirMail.AutoSize = true;
            this.MayudaConfirMail.BackColor = System.Drawing.Color.LightGray;
            this.MayudaConfirMail.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaConfirMail.Location = new System.Drawing.Point(695, 583);
            this.MayudaConfirMail.Name = "MayudaConfirMail";
            this.MayudaConfirMail.Size = new System.Drawing.Size(12, 15);
            this.MayudaConfirMail.TabIndex = 87;
            this.MayudaConfirMail.Text = "?";
            this.MayudaConfirMail.Visible = false;
            // 
            // MayudaMail
            // 
            this.MayudaMail.AutoSize = true;
            this.MayudaMail.BackColor = System.Drawing.Color.LightGray;
            this.MayudaMail.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaMail.Location = new System.Drawing.Point(329, 583);
            this.MayudaMail.Name = "MayudaMail";
            this.MayudaMail.Size = new System.Drawing.Size(12, 15);
            this.MayudaMail.TabIndex = 86;
            this.MayudaMail.Text = "?";
            this.MayudaMail.Visible = false;
            // 
            // Box_Mail_Confirm
            // 
            this.Box_Mail_Confirm.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Mail_Confirm.Location = new System.Drawing.Point(438, 572);
            this.Box_Mail_Confirm.Name = "Box_Mail_Confirm";
            this.Box_Mail_Confirm.Size = new System.Drawing.Size(251, 33);
            this.Box_Mail_Confirm.TabIndex = 8;
            // 
            // Box_Mail
            // 
            this.Box_Mail.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Mail.Location = new System.Drawing.Point(73, 572);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(251, 33);
            this.Box_Mail.TabIndex = 7;
            // 
            // Label_ConfirmarEmail
            // 
            this.Label_ConfirmarEmail.AutoSize = true;
            this.Label_ConfirmarEmail.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarEmail.Location = new System.Drawing.Point(416, 538);
            this.Label_ConfirmarEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConfirmarEmail.Name = "Label_ConfirmarEmail";
            this.Label_ConfirmarEmail.Size = new System.Drawing.Size(162, 29);
            this.Label_ConfirmarEmail.TabIndex = 85;
            this.Label_ConfirmarEmail.Text = "Confirmar Email";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(58, 538);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(64, 29);
            this.Label_Email.TabIndex = 84;
            this.Label_Email.Text = "Email";
            // 
            // Boton_Limpiar
            // 
            this.Boton_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Boton_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Limpiar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Limpiar.Location = new System.Drawing.Point(385, 682);
            this.Boton_Limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Limpiar.Name = "Boton_Limpiar";
            this.Boton_Limpiar.Size = new System.Drawing.Size(153, 43);
            this.Boton_Limpiar.TabIndex = 10;
            this.Boton_Limpiar.Text = "Limpiar";
            this.Boton_Limpiar.UseVisualStyleBackColor = false;
            this.Boton_Limpiar.Click += new System.EventHandler(this.Boton_Limpiar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(567, 682);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(153, 43);
            this.Boton_Cancelar.TabIndex = 11;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Confirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Confirmar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(32, 682);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(153, 43);
            this.Boton_Confirmar.TabIndex = 9;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = false;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // Importar
            // 
            this.Importar.BackColor = System.Drawing.Color.Beige;
            this.Importar.Location = new System.Drawing.Point(206, 683);
            this.Importar.Name = "Importar";
            this.Importar.Size = new System.Drawing.Size(153, 42);
            this.Importar.TabIndex = 90;
            this.Importar.Text = "Importar";
            this.Importar.UseVisualStyleBackColor = false;
            this.Importar.Click += new System.EventHandler(this.Importar_Click);
            // 
            // InterfazAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.Boton_Limpiar);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Confirmar);
            this.Controls.Add(this.ConfirmMail_Error);
            this.Controls.Add(this.Mail_Error);
            this.Controls.Add(this.MayudaConfirMail);
            this.Controls.Add(this.MayudaMail);
            this.Controls.Add(this.Box_Mail_Confirm);
            this.Controls.Add(this.Box_Mail);
            this.Controls.Add(this.Label_ConfirmarEmail);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.SeparatorPersona);
            this.Controls.Add(this.Edad_Error);
            this.Controls.Add(this.Telefono_Error);
            this.Controls.Add(this.Calle_Error);
            this.Controls.Add(this.DNI_Error);
            this.Controls.Add(this.Apellido_Error);
            this.Controls.Add(this.Nombre_Error);
            this.Controls.Add(this.MayudaFechaNacimiento);
            this.Controls.Add(this.MayudaTelefono);
            this.Controls.Add(this.MayudaCalle);
            this.Controls.Add(this.MayudaDNI);
            this.Controls.Add(this.MayudaApellido);
            this.Controls.Add(this.MayudaNombre);
            this.Controls.Add(this.Box_Telefono);
            this.Controls.Add(this.Box_Calle);
            this.Controls.Add(this.Box_DNI);
            this.Controls.Add(this.Box_Apellido);
            this.Controls.Add(this.Box_Nombre);
            this.Controls.Add(this.Calendario_Nacimiento);
            this.Controls.Add(this.Label_F_Nacimiento);
            this.Controls.Add(this.Label_DNI);
            this.Controls.Add(this.Label_Telefono);
            this.Controls.Add(this.Label_Direccion);
            this.Controls.Add(this.Label_Apellido);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.Importar);
            this.Name = "InterfazAltaClientes";
            this.Text = "Alta de Clientes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.GroupBox SeparatorPersona;
        private System.Windows.Forms.TextBox Edad_Error;
        private System.Windows.Forms.TextBox Telefono_Error;
        private System.Windows.Forms.TextBox Calle_Error;
        private System.Windows.Forms.TextBox DNI_Error;
        private System.Windows.Forms.TextBox Apellido_Error;
        private System.Windows.Forms.TextBox Nombre_Error;
        private System.Windows.Forms.Label MayudaFechaNacimiento;
        private System.Windows.Forms.Label MayudaTelefono;
        private System.Windows.Forms.Label MayudaCalle;
        private System.Windows.Forms.Label MayudaDNI;
        private System.Windows.Forms.Label MayudaApellido;
        private System.Windows.Forms.Label MayudaNombre;
        private System.Windows.Forms.TextBox Box_Telefono;
        private System.Windows.Forms.TextBox Box_Calle;
        private System.Windows.Forms.TextBox Box_DNI;
        private System.Windows.Forms.TextBox Box_Apellido;
        private System.Windows.Forms.TextBox Box_Nombre;
        private System.Windows.Forms.DateTimePicker Calendario_Nacimiento;
        private System.Windows.Forms.Label Label_F_Nacimiento;
        private System.Windows.Forms.Label Label_DNI;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Direccion;
        private System.Windows.Forms.Label Label_Apellido;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.TextBox ConfirmMail_Error;
        private System.Windows.Forms.TextBox Mail_Error;
        private System.Windows.Forms.Label MayudaConfirMail;
        private System.Windows.Forms.Label MayudaMail;
        private System.Windows.Forms.TextBox Box_Mail_Confirm;
        private System.Windows.Forms.TextBox Box_Mail;
        private System.Windows.Forms.Label Label_ConfirmarEmail;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Button Boton_Limpiar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.Button Importar;
    }
}