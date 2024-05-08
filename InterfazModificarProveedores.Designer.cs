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
            this.ConfirMail_Error = new System.Windows.Forms.TextBox();
            this.Mail_Error = new System.Windows.Forms.TextBox();
            this.CUIT_Error = new System.Windows.Forms.TextBox();
            this.Apellido_Error = new System.Windows.Forms.TextBox();
            this.Nombre_Error = new System.Windows.Forms.TextBox();
            this.MayudaCUIT = new System.Windows.Forms.Label();
            this.MayudaConfirMail = new System.Windows.Forms.Label();
            this.MayudaMail = new System.Windows.Forms.Label();
            this.MayudaApellido = new System.Windows.Forms.Label();
            this.MayudaNombre = new System.Windows.Forms.Label();
            this.Box_ConfirMail = new System.Windows.Forms.TextBox();
            this.CUIT_Box = new System.Windows.Forms.TextBox();
            this.Box_Mail = new System.Windows.Forms.TextBox();
            this.Box_Apellido = new System.Windows.Forms.TextBox();
            this.Box_Nombre = new System.Windows.Forms.TextBox();
            this.Label_ConfirmarEmail = new System.Windows.Forms.Label();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_CUIT = new System.Windows.Forms.Label();
            this.Label_Apellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(429, 676);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(210, 43);
            this.Boton_Cancelar.TabIndex = 99;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Confirmar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(165, 676);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(210, 43);
            this.Boton_Confirmar.TabIndex = 98;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = false;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // SeparatorPersona
            // 
            this.SeparatorPersona.BackColor = System.Drawing.Color.Gainsboro;
            this.SeparatorPersona.Font = new System.Drawing.Font("Nunito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparatorPersona.Location = new System.Drawing.Point(41, 73);
            this.SeparatorPersona.Name = "SeparatorPersona";
            this.SeparatorPersona.Size = new System.Drawing.Size(717, 40);
            this.SeparatorPersona.TabIndex = 87;
            this.SeparatorPersona.TabStop = false;
            this.SeparatorPersona.Text = "Modificar Proveedor";
            // 
            // ConfirMail_Error
            // 
            this.ConfirMail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirMail_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirMail_Error.ForeColor = System.Drawing.Color.Red;
            this.ConfirMail_Error.Location = new System.Drawing.Point(423, 509);
            this.ConfirMail_Error.Multiline = true;
            this.ConfirMail_Error.Name = "ConfirMail_Error";
            this.ConfirMail_Error.Size = new System.Drawing.Size(311, 20);
            this.ConfirMail_Error.TabIndex = 97;
            // 
            // Mail_Error
            // 
            this.Mail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mail_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_Error.ForeColor = System.Drawing.Color.Red;
            this.Mail_Error.Location = new System.Drawing.Point(423, 397);
            this.Mail_Error.Multiline = true;
            this.Mail_Error.Name = "Mail_Error";
            this.Mail_Error.Size = new System.Drawing.Size(311, 20);
            this.Mail_Error.TabIndex = 96;
            // 
            // CUIT_Error
            // 
            this.CUIT_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CUIT_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUIT_Error.ForeColor = System.Drawing.Color.Red;
            this.CUIT_Error.Location = new System.Drawing.Point(423, 623);
            this.CUIT_Error.Multiline = true;
            this.CUIT_Error.Name = "CUIT_Error";
            this.CUIT_Error.Size = new System.Drawing.Size(307, 20);
            this.CUIT_Error.TabIndex = 95;
            // 
            // Apellido_Error
            // 
            this.Apellido_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_Error.ForeColor = System.Drawing.Color.Red;
            this.Apellido_Error.Location = new System.Drawing.Point(423, 282);
            this.Apellido_Error.Multiline = true;
            this.Apellido_Error.Name = "Apellido_Error";
            this.Apellido_Error.Size = new System.Drawing.Size(311, 20);
            this.Apellido_Error.TabIndex = 94;
            // 
            // Nombre_Error
            // 
            this.Nombre_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Error.ForeColor = System.Drawing.Color.Red;
            this.Nombre_Error.Location = new System.Drawing.Point(423, 183);
            this.Nombre_Error.Multiline = true;
            this.Nombre_Error.Name = "Nombre_Error";
            this.Nombre_Error.Size = new System.Drawing.Size(311, 20);
            this.Nombre_Error.TabIndex = 93;
            // 
            // MayudaCUIT
            // 
            this.MayudaCUIT.AutoSize = true;
            this.MayudaCUIT.BackColor = System.Drawing.Color.LightGray;
            this.MayudaCUIT.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaCUIT.Location = new System.Drawing.Point(712, 595);
            this.MayudaCUIT.Name = "MayudaCUIT";
            this.MayudaCUIT.Size = new System.Drawing.Size(15, 17);
            this.MayudaCUIT.TabIndex = 92;
            this.MayudaCUIT.Text = "?";
            this.MayudaCUIT.Visible = false;
            // 
            // MayudaConfirMail
            // 
            this.MayudaConfirMail.AutoSize = true;
            this.MayudaConfirMail.BackColor = System.Drawing.Color.LightGray;
            this.MayudaConfirMail.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaConfirMail.Location = new System.Drawing.Point(712, 480);
            this.MayudaConfirMail.Name = "MayudaConfirMail";
            this.MayudaConfirMail.Size = new System.Drawing.Size(15, 17);
            this.MayudaConfirMail.TabIndex = 91;
            this.MayudaConfirMail.Text = "?";
            this.MayudaConfirMail.Visible = false;
            // 
            // MayudaMail
            // 
            this.MayudaMail.AutoSize = true;
            this.MayudaMail.BackColor = System.Drawing.Color.LightGray;
            this.MayudaMail.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaMail.Location = new System.Drawing.Point(712, 367);
            this.MayudaMail.Name = "MayudaMail";
            this.MayudaMail.Size = new System.Drawing.Size(15, 17);
            this.MayudaMail.TabIndex = 90;
            this.MayudaMail.Text = "?";
            this.MayudaMail.Visible = false;
            // 
            // MayudaApellido
            // 
            this.MayudaApellido.AutoSize = true;
            this.MayudaApellido.BackColor = System.Drawing.Color.LightGray;
            this.MayudaApellido.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaApellido.Location = new System.Drawing.Point(712, 251);
            this.MayudaApellido.Name = "MayudaApellido";
            this.MayudaApellido.Size = new System.Drawing.Size(15, 17);
            this.MayudaApellido.TabIndex = 89;
            this.MayudaApellido.Text = "?";
            this.MayudaApellido.Visible = false;
            // 
            // MayudaNombre
            // 
            this.MayudaNombre.AutoSize = true;
            this.MayudaNombre.BackColor = System.Drawing.Color.LightGray;
            this.MayudaNombre.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaNombre.Location = new System.Drawing.Point(712, 152);
            this.MayudaNombre.Name = "MayudaNombre";
            this.MayudaNombre.Size = new System.Drawing.Size(15, 17);
            this.MayudaNombre.TabIndex = 88;
            this.MayudaNombre.Text = "?";
            this.MayudaNombre.Visible = false;
            // 
            // Box_ConfirMail
            // 
            this.Box_ConfirMail.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_ConfirMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_ConfirMail.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_ConfirMail.Location = new System.Drawing.Point(423, 472);
            this.Box_ConfirMail.Name = "Box_ConfirMail";
            this.Box_ConfirMail.Size = new System.Drawing.Size(251, 31);
            this.Box_ConfirMail.TabIndex = 5;
            // 
            // CUIT_Box
            // 
            this.CUIT_Box.BackColor = System.Drawing.Color.Gainsboro;
            this.CUIT_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CUIT_Box.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUIT_Box.Location = new System.Drawing.Point(423, 586);
            this.CUIT_Box.Name = "CUIT_Box";
            this.CUIT_Box.Size = new System.Drawing.Size(250, 31);
            this.CUIT_Box.TabIndex = 6;
            // 
            // Box_Mail
            // 
            this.Box_Mail.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Mail.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Mail.Location = new System.Drawing.Point(423, 360);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(251, 31);
            this.Box_Mail.TabIndex = 3;
            // 
            // Box_Apellido
            // 
            this.Box_Apellido.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Apellido.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Apellido.Location = new System.Drawing.Point(423, 245);
            this.Box_Apellido.Name = "Box_Apellido";
            this.Box_Apellido.Size = new System.Drawing.Size(250, 31);
            this.Box_Apellido.TabIndex = 2;
            // 
            // Box_Nombre
            // 
            this.Box_Nombre.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Nombre.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Nombre.Location = new System.Drawing.Point(423, 146);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(250, 31);
            this.Box_Nombre.TabIndex = 1;
            // 
            // Label_ConfirmarEmail
            // 
            this.Label_ConfirmarEmail.AutoSize = true;
            this.Label_ConfirmarEmail.Font = new System.Drawing.Font("Nunito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarEmail.Location = new System.Drawing.Point(61, 467);
            this.Label_ConfirmarEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConfirmarEmail.Name = "Label_ConfirmarEmail";
            this.Label_ConfirmarEmail.Size = new System.Drawing.Size(244, 39);
            this.Label_ConfirmarEmail.TabIndex = 86;
            this.Label_ConfirmarEmail.Text = "Confirmar Email:";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Font = new System.Drawing.Font("Nunito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Label.Location = new System.Drawing.Point(61, 141);
            this.Nombre_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(136, 39);
            this.Nombre_Label.TabIndex = 85;
            this.Nombre_Label.Text = "Nombre:";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Nunito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(61, 355);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(100, 39);
            this.Label_Email.TabIndex = 83;
            this.Label_Email.Text = "Email:";
            // 
            // Label_CUIT
            // 
            this.Label_CUIT.AutoSize = true;
            this.Label_CUIT.Font = new System.Drawing.Font("Nunito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CUIT.Location = new System.Drawing.Point(61, 581);
            this.Label_CUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_CUIT.Name = "Label_CUIT";
            this.Label_CUIT.Size = new System.Drawing.Size(93, 39);
            this.Label_CUIT.TabIndex = 82;
            this.Label_CUIT.Text = "CUIT:";
            // 
            // Label_Apellido
            // 
            this.Label_Apellido.AutoSize = true;
            this.Label_Apellido.Font = new System.Drawing.Font("Nunito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Apellido.Location = new System.Drawing.Point(61, 240);
            this.Label_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Apellido.Name = "Label_Apellido";
            this.Label_Apellido.Size = new System.Drawing.Size(134, 39);
            this.Label_Apellido.TabIndex = 79;
            this.Label_Apellido.Text = "Apellido:";
            // 
            // InterfazModificarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Confirmar);
            this.Controls.Add(this.SeparatorPersona);
            this.Controls.Add(this.ConfirMail_Error);
            this.Controls.Add(this.Mail_Error);
            this.Controls.Add(this.CUIT_Error);
            this.Controls.Add(this.Apellido_Error);
            this.Controls.Add(this.Nombre_Error);
            this.Controls.Add(this.MayudaCUIT);
            this.Controls.Add(this.MayudaConfirMail);
            this.Controls.Add(this.MayudaMail);
            this.Controls.Add(this.MayudaApellido);
            this.Controls.Add(this.MayudaNombre);
            this.Controls.Add(this.Box_ConfirMail);
            this.Controls.Add(this.CUIT_Box);
            this.Controls.Add(this.Box_Mail);
            this.Controls.Add(this.Box_Apellido);
            this.Controls.Add(this.Box_Nombre);
            this.Controls.Add(this.Label_ConfirmarEmail);
            this.Controls.Add(this.Nombre_Label);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_CUIT);
            this.Controls.Add(this.Label_Apellido);
            this.Name = "InterfazModificarProveedores";
            this.Text = "Modificar Proveedor";
            //this.Load += new System.EventHandler(this.InterfazModificarProveedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.GroupBox SeparatorPersona;
        private System.Windows.Forms.TextBox ConfirMail_Error;
        private System.Windows.Forms.TextBox Mail_Error;
        private System.Windows.Forms.TextBox CUIT_Error;
        private System.Windows.Forms.TextBox Apellido_Error;
        private System.Windows.Forms.TextBox Nombre_Error;
        private System.Windows.Forms.Label MayudaCUIT;
        private System.Windows.Forms.Label MayudaConfirMail;
        private System.Windows.Forms.Label MayudaMail;
        private System.Windows.Forms.Label MayudaApellido;
        private System.Windows.Forms.Label MayudaNombre;
        private System.Windows.Forms.TextBox Box_ConfirMail;
        private System.Windows.Forms.TextBox CUIT_Box;
        private System.Windows.Forms.TextBox Box_Mail;
        private System.Windows.Forms.TextBox Box_Apellido;
        private System.Windows.Forms.TextBox Box_Nombre;
        private System.Windows.Forms.Label Label_ConfirmarEmail;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_CUIT;
        private System.Windows.Forms.Label Label_Apellido;
    }
}