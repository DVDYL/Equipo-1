namespace Presentacion
{
    partial class InterfazModificarProveedores
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
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Boton_Confirmar = new System.Windows.Forms.Button();
            this.SeparatorPersona = new System.Windows.Forms.GroupBox();
            this.ConfirmMail_Error = new System.Windows.Forms.TextBox();
            this.Mail_Error = new System.Windows.Forms.TextBox();
            this.Telefono_Error = new System.Windows.Forms.TextBox();
            this.Calle_Error = new System.Windows.Forms.TextBox();
            this.DNI_Error = new System.Windows.Forms.TextBox();
            this.MayudaTelefono = new System.Windows.Forms.Label();
            this.MayudaConfirMail = new System.Windows.Forms.Label();
            this.MayudaMail = new System.Windows.Forms.Label();
            this.MayudaCalle = new System.Windows.Forms.Label();
            this.MayudaDNI = new System.Windows.Forms.Label();
            this.Box_Mail_Confirm = new System.Windows.Forms.TextBox();
            this.Box_Telefono = new System.Windows.Forms.TextBox();
            this.Box_Mail = new System.Windows.Forms.TextBox();
            this.Box_Calle = new System.Windows.Forms.TextBox();
            this.Box_DNI = new System.Windows.Forms.TextBox();
            this.Label_ConfirmarEmail = new System.Windows.Forms.Label();
            this.Label_DNI = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Direccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.FlatAppearance.BorderSize = 0;
            this.Boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(432, 813);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(210, 43);
            this.Boton_Cancelar.TabIndex = 99;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(46)))));
            this.Boton_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(46)))));
            this.Boton_Confirmar.FlatAppearance.BorderSize = 0;
            this.Boton_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(53)))));
            this.Boton_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(168, 813);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(210, 43);
            this.Boton_Confirmar.TabIndex = 98;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = false;
            // 
            // SeparatorPersona
            // 
            this.SeparatorPersona.BackColor = System.Drawing.Color.Gainsboro;
            this.SeparatorPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparatorPersona.Location = new System.Drawing.Point(0, 34);
            this.SeparatorPersona.Name = "SeparatorPersona";
            this.SeparatorPersona.Size = new System.Drawing.Size(796, 49);
            this.SeparatorPersona.TabIndex = 87;
            this.SeparatorPersona.TabStop = false;
            this.SeparatorPersona.Text = "Datos del Proveedor";
            this.SeparatorPersona.Enter += new System.EventHandler(this.SeparatorPersona_Enter);
            // 
            // ConfirmMail_Error
            // 
            this.ConfirmMail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmMail_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmMail_Error.ForeColor = System.Drawing.Color.Red;
            this.ConfirmMail_Error.Location = new System.Drawing.Point(259, 770);
            this.ConfirmMail_Error.Multiline = true;
            this.ConfirmMail_Error.Name = "ConfirmMail_Error";
            this.ConfirmMail_Error.Size = new System.Drawing.Size(311, 20);
            this.ConfirmMail_Error.TabIndex = 97;
            // 
            // Mail_Error
            // 
            this.Mail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mail_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_Error.ForeColor = System.Drawing.Color.Red;
            this.Mail_Error.Location = new System.Drawing.Point(259, 638);
            this.Mail_Error.Multiline = true;
            this.Mail_Error.Name = "Mail_Error";
            this.Mail_Error.Size = new System.Drawing.Size(311, 20);
            this.Mail_Error.TabIndex = 96;
            // 
            // Telefono_Error
            // 
            this.Telefono_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefono_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_Error.ForeColor = System.Drawing.Color.Red;
            this.Telefono_Error.Location = new System.Drawing.Point(254, 505);
            this.Telefono_Error.Multiline = true;
            this.Telefono_Error.Name = "Telefono_Error";
            this.Telefono_Error.Size = new System.Drawing.Size(307, 20);
            this.Telefono_Error.TabIndex = 95;
            // 
            // Calle_Error
            // 
            this.Calle_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calle_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calle_Error.ForeColor = System.Drawing.Color.Red;
            this.Calle_Error.Location = new System.Drawing.Point(257, 363);
            this.Calle_Error.Multiline = true;
            this.Calle_Error.Name = "Calle_Error";
            this.Calle_Error.Size = new System.Drawing.Size(311, 20);
            this.Calle_Error.TabIndex = 94;
            // 
            // DNI_Error
            // 
            this.DNI_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DNI_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI_Error.ForeColor = System.Drawing.Color.Red;
            this.DNI_Error.Location = new System.Drawing.Point(257, 223);
            this.DNI_Error.Multiline = true;
            this.DNI_Error.Name = "DNI_Error";
            this.DNI_Error.Size = new System.Drawing.Size(311, 20);
            this.DNI_Error.TabIndex = 93;
            // 
            // MayudaTelefono
            // 
            this.MayudaTelefono.AutoSize = true;
            this.MayudaTelefono.BackColor = System.Drawing.Color.LightGray;
            this.MayudaTelefono.Location = new System.Drawing.Point(501, 462);
            this.MayudaTelefono.Name = "MayudaTelefono";
            this.MayudaTelefono.Size = new System.Drawing.Size(13, 13);
            this.MayudaTelefono.TabIndex = 92;
            this.MayudaTelefono.Text = "?";
            this.MayudaTelefono.Visible = false;
            // 
            // MayudaConfirMail
            // 
            this.MayudaConfirMail.AutoSize = true;
            this.MayudaConfirMail.BackColor = System.Drawing.Color.LightGray;
            this.MayudaConfirMail.Location = new System.Drawing.Point(502, 733);
            this.MayudaConfirMail.Name = "MayudaConfirMail";
            this.MayudaConfirMail.Size = new System.Drawing.Size(13, 13);
            this.MayudaConfirMail.TabIndex = 91;
            this.MayudaConfirMail.Text = "?";
            this.MayudaConfirMail.Visible = false;
            // 
            // MayudaMail
            // 
            this.MayudaMail.AutoSize = true;
            this.MayudaMail.BackColor = System.Drawing.Color.LightGray;
            this.MayudaMail.Location = new System.Drawing.Point(502, 595);
            this.MayudaMail.Name = "MayudaMail";
            this.MayudaMail.Size = new System.Drawing.Size(13, 13);
            this.MayudaMail.TabIndex = 90;
            this.MayudaMail.Text = "?";
            this.MayudaMail.Visible = false;
            // 
            // MayudaCalle
            // 
            this.MayudaCalle.AutoSize = true;
            this.MayudaCalle.BackColor = System.Drawing.Color.LightGray;
            this.MayudaCalle.Location = new System.Drawing.Point(502, 324);
            this.MayudaCalle.Name = "MayudaCalle";
            this.MayudaCalle.Size = new System.Drawing.Size(13, 13);
            this.MayudaCalle.TabIndex = 89;
            this.MayudaCalle.Text = "?";
            this.MayudaCalle.Visible = false;
            // 
            // MayudaDNI
            // 
            this.MayudaDNI.AutoSize = true;
            this.MayudaDNI.BackColor = System.Drawing.Color.LightGray;
            this.MayudaDNI.Location = new System.Drawing.Point(502, 186);
            this.MayudaDNI.Name = "MayudaDNI";
            this.MayudaDNI.Size = new System.Drawing.Size(13, 13);
            this.MayudaDNI.TabIndex = 88;
            this.MayudaDNI.Text = "?";
            this.MayudaDNI.Visible = false;
            // 
            // Box_Mail_Confirm
            // 
            this.Box_Mail_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Mail_Confirm.Location = new System.Drawing.Point(245, 722);
            this.Box_Mail_Confirm.Name = "Box_Mail_Confirm";
            this.Box_Mail_Confirm.Size = new System.Drawing.Size(251, 29);
            this.Box_Mail_Confirm.TabIndex = 84;
            // 
            // Box_Telefono
            // 
            this.Box_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Telefono.Location = new System.Drawing.Point(245, 451);
            this.Box_Telefono.Name = "Box_Telefono";
            this.Box_Telefono.Size = new System.Drawing.Size(250, 29);
            this.Box_Telefono.TabIndex = 80;
            // 
            // Box_Mail
            // 
            this.Box_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Mail.Location = new System.Drawing.Point(245, 584);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(251, 29);
            this.Box_Mail.TabIndex = 81;
            // 
            // Box_Calle
            // 
            this.Box_Calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Calle.Location = new System.Drawing.Point(245, 313);
            this.Box_Calle.Name = "Box_Calle";
            this.Box_Calle.Size = new System.Drawing.Size(250, 29);
            this.Box_Calle.TabIndex = 78;
            // 
            // Box_DNI
            // 
            this.Box_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_DNI.Location = new System.Drawing.Point(245, 175);
            this.Box_DNI.Name = "Box_DNI";
            this.Box_DNI.Size = new System.Drawing.Size(250, 29);
            this.Box_DNI.TabIndex = 77;
            // 
            // Label_ConfirmarEmail
            // 
            this.Label_ConfirmarEmail.AutoSize = true;
            this.Label_ConfirmarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_ConfirmarEmail.Location = new System.Drawing.Point(240, 661);
            this.Label_ConfirmarEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConfirmarEmail.Name = "Label_ConfirmarEmail";
            this.Label_ConfirmarEmail.Size = new System.Drawing.Size(164, 25);
            this.Label_ConfirmarEmail.TabIndex = 86;
            this.Label_ConfirmarEmail.Text = "Confirmar Email";
            // 
            // Label_DNI
            // 
            this.Label_DNI.AutoSize = true;
            this.Label_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DNI.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_DNI.Location = new System.Drawing.Point(240, 125);
            this.Label_DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DNI.Name = "Label_DNI";
            this.Label_DNI.Size = new System.Drawing.Size(60, 25);
            this.Label_DNI.TabIndex = 85;
            this.Label_DNI.Text = "CUIT";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_Email.Location = new System.Drawing.Point(240, 527);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(65, 25);
            this.Label_Email.TabIndex = 83;
            this.Label_Email.Text = "Email";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Telefono.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_Telefono.Location = new System.Drawing.Point(240, 393);
            this.Label_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(96, 25);
            this.Label_Telefono.TabIndex = 82;
            this.Label_Telefono.Text = "Teléfono";
            // 
            // Label_Direccion
            // 
            this.Label_Direccion.AutoSize = true;
            this.Label_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Direccion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_Direccion.Location = new System.Drawing.Point(240, 259);
            this.Label_Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Direccion.Name = "Label_Direccion";
            this.Label_Direccion.Size = new System.Drawing.Size(102, 25);
            this.Label_Direccion.TabIndex = 79;
            this.Label_Direccion.Text = "Dirección";
            // 
            // InterfazModificarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Confirmar);
            this.Controls.Add(this.SeparatorPersona);
            this.Controls.Add(this.ConfirmMail_Error);
            this.Controls.Add(this.Mail_Error);
            this.Controls.Add(this.Telefono_Error);
            this.Controls.Add(this.Calle_Error);
            this.Controls.Add(this.DNI_Error);
            this.Controls.Add(this.MayudaTelefono);
            this.Controls.Add(this.MayudaConfirMail);
            this.Controls.Add(this.MayudaMail);
            this.Controls.Add(this.MayudaCalle);
            this.Controls.Add(this.MayudaDNI);
            this.Controls.Add(this.Box_Mail_Confirm);
            this.Controls.Add(this.Box_Telefono);
            this.Controls.Add(this.Box_Mail);
            this.Controls.Add(this.Box_Calle);
            this.Controls.Add(this.Box_DNI);
            this.Controls.Add(this.Label_ConfirmarEmail);
            this.Controls.Add(this.Label_DNI);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_Telefono);
            this.Controls.Add(this.Label_Direccion);
            this.Name = "InterfazModificarProveedores";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.GroupBox SeparatorPersona;
        private System.Windows.Forms.TextBox ConfirmMail_Error;
        private System.Windows.Forms.TextBox Mail_Error;
        private System.Windows.Forms.TextBox Telefono_Error;
        private System.Windows.Forms.TextBox Calle_Error;
        private System.Windows.Forms.TextBox DNI_Error;
        private System.Windows.Forms.Label MayudaTelefono;
        private System.Windows.Forms.Label MayudaConfirMail;
        private System.Windows.Forms.Label MayudaMail;
        private System.Windows.Forms.Label MayudaCalle;
        private System.Windows.Forms.Label MayudaDNI;
        private System.Windows.Forms.TextBox Box_Mail_Confirm;
        private System.Windows.Forms.TextBox Box_Telefono;
        private System.Windows.Forms.TextBox Box_Mail;
        private System.Windows.Forms.TextBox Box_Calle;
        private System.Windows.Forms.TextBox Box_DNI;
        private System.Windows.Forms.Label Label_ConfirmarEmail;
        private System.Windows.Forms.Label Label_DNI;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Direccion;
    }
}