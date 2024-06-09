namespace Presentacion
{
    partial class InterfazModificarProductos
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
            this.Stock_Error = new System.Windows.Forms.TextBox();
            this.Precio_Error = new System.Windows.Forms.TextBox();
            this.MayudaTelefono = new System.Windows.Forms.Label();
            this.MayudaStock = new System.Windows.Forms.Label();
            this.MayudaPrecio = new System.Windows.Forms.Label();
            this.Box_Stock = new System.Windows.Forms.TextBox();
            this.Box_Precio = new System.Windows.Forms.TextBox();
            this.Label_Precio = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Stock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(439, 688);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(190, 42);
            this.Boton_Cancelar.TabIndex = 44;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(46)))));
            this.Boton_Confirmar.FlatAppearance.BorderSize = 0;
            this.Boton_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(53)))));
            this.Boton_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Confirmar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(175, 687);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(210, 43);
            this.Boton_Confirmar.TabIndex = 97;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = false;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // SeparatorPersona
            // 
            this.SeparatorPersona.BackColor = System.Drawing.Color.Gainsboro;
            this.SeparatorPersona.Font = new System.Drawing.Font("Nunito", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparatorPersona.Location = new System.Drawing.Point(34, 63);
            this.SeparatorPersona.Name = "SeparatorPersona";
            this.SeparatorPersona.Size = new System.Drawing.Size(717, 40);
            this.SeparatorPersona.TabIndex = 86;
            this.SeparatorPersona.TabStop = false;
            this.SeparatorPersona.Text = "Modificar Producto";
            // 
            // ConfirmMail_Error
            // 
            this.ConfirmMail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmMail_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmMail_Error.ForeColor = System.Drawing.Color.Red;
            this.ConfirmMail_Error.Location = new System.Drawing.Point(439, 642);
            this.ConfirmMail_Error.Multiline = true;
            this.ConfirmMail_Error.Name = "ConfirmMail_Error";
            this.ConfirmMail_Error.Size = new System.Drawing.Size(311, 20);
            this.ConfirmMail_Error.TabIndex = 96;
            // 
            // Mail_Error
            // 
            this.Mail_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mail_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_Error.ForeColor = System.Drawing.Color.Red;
            this.Mail_Error.Location = new System.Drawing.Point(442, 523);
            this.Mail_Error.Multiline = true;
            this.Mail_Error.Name = "Mail_Error";
            this.Mail_Error.Size = new System.Drawing.Size(311, 20);
            this.Mail_Error.TabIndex = 95;
            // 
            // Telefono_Error
            // 
            this.Telefono_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefono_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_Error.ForeColor = System.Drawing.Color.Red;
            this.Telefono_Error.Location = new System.Drawing.Point(440, 406);
            this.Telefono_Error.Multiline = true;
            this.Telefono_Error.Name = "Telefono_Error";
            this.Telefono_Error.Size = new System.Drawing.Size(307, 20);
            this.Telefono_Error.TabIndex = 94;
            // 
            // Stock_Error
            // 
            this.Stock_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_Error.ForeColor = System.Drawing.Color.Red;
            this.Stock_Error.Location = new System.Drawing.Point(440, 289);
            this.Stock_Error.Multiline = true;
            this.Stock_Error.Name = "Stock_Error";
            this.Stock_Error.Size = new System.Drawing.Size(311, 20);
            this.Stock_Error.TabIndex = 93;
            // 
            // Precio_Error
            // 
            this.Precio_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Precio_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_Error.ForeColor = System.Drawing.Color.Red;
            this.Precio_Error.Location = new System.Drawing.Point(440, 175);
            this.Precio_Error.Multiline = true;
            this.Precio_Error.Name = "Precio_Error";
            this.Precio_Error.Size = new System.Drawing.Size(311, 20);
            this.Precio_Error.TabIndex = 92;
            // 
            // MayudaTelefono
            // 
            this.MayudaTelefono.AutoSize = true;
            this.MayudaTelefono.BackColor = System.Drawing.Color.LightGray;
            this.MayudaTelefono.Location = new System.Drawing.Point(707, 381);
            this.MayudaTelefono.Name = "MayudaTelefono";
            this.MayudaTelefono.Size = new System.Drawing.Size(0, 36);
            this.MayudaTelefono.TabIndex = 91;
            this.MayudaTelefono.Visible = false;
            // 
            // MayudaStock
            // 
            this.MayudaStock.AutoSize = true;
            this.MayudaStock.BackColor = System.Drawing.Color.LightGray;
            this.MayudaStock.Location = new System.Drawing.Point(707, 265);
            this.MayudaStock.Name = "MayudaStock";
            this.MayudaStock.Size = new System.Drawing.Size(29, 36);
            this.MayudaStock.TabIndex = 88;
            this.MayudaStock.Text = "?";
            this.MayudaStock.Visible = false;
            // 
            // MayudaPrecio
            // 
            this.MayudaPrecio.AutoSize = true;
            this.MayudaPrecio.BackColor = System.Drawing.Color.LightGray;
            this.MayudaPrecio.Location = new System.Drawing.Point(707, 149);
            this.MayudaPrecio.Name = "MayudaPrecio";
            this.MayudaPrecio.Size = new System.Drawing.Size(29, 36);
            this.MayudaPrecio.TabIndex = 87;
            this.MayudaPrecio.Text = "?";
            this.MayudaPrecio.Visible = false;
            // 
            // Box_Stock
            // 
            this.Box_Stock.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Stock.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Stock.Location = new System.Drawing.Point(440, 256);
            this.Box_Stock.Name = "Box_Stock";
            this.Box_Stock.Size = new System.Drawing.Size(250, 27);
            this.Box_Stock.TabIndex = 77;
            // 
            // Box_Precio
            // 
            this.Box_Precio.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Precio.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Precio.Location = new System.Drawing.Point(440, 140);
            this.Box_Precio.Name = "Box_Precio";
            this.Box_Precio.Size = new System.Drawing.Size(250, 27);
            this.Box_Precio.TabIndex = 76;
            // 
            // Label_Precio
            // 
            this.Label_Precio.AutoSize = true;
            this.Label_Precio.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Precio.Location = new System.Drawing.Point(70, 134);
            this.Label_Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Precio.Name = "Label_Precio";
            this.Label_Precio.Size = new System.Drawing.Size(94, 36);
            this.Label_Precio.TabIndex = 84;
            this.Label_Precio.Text = "Precio";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Telefono.Location = new System.Drawing.Point(70, 366);
            this.Label_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(0, 36);
            this.Label_Telefono.TabIndex = 81;
            // 
            // Label_Stock
            // 
            this.Label_Stock.AutoSize = true;
            this.Label_Stock.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Stock.Location = new System.Drawing.Point(70, 250);
            this.Label_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Stock.Name = "Label_Stock";
            this.Label_Stock.Size = new System.Drawing.Size(85, 36);
            this.Label_Stock.TabIndex = 78;
            this.Label_Stock.Text = "Stock";
            // 
            // InterfazModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.Boton_Confirmar);
            this.Controls.Add(this.SeparatorPersona);
            this.Controls.Add(this.ConfirmMail_Error);
            this.Controls.Add(this.Mail_Error);
            this.Controls.Add(this.Telefono_Error);
            this.Controls.Add(this.Stock_Error);
            this.Controls.Add(this.Precio_Error);
            this.Controls.Add(this.MayudaTelefono);
            this.Controls.Add(this.MayudaStock);
            this.Controls.Add(this.MayudaPrecio);
            this.Controls.Add(this.Box_Stock);
            this.Controls.Add(this.Box_Precio);
            this.Controls.Add(this.Label_Precio);
            this.Controls.Add(this.Label_Telefono);
            this.Controls.Add(this.Label_Stock);
            this.Controls.Add(this.Boton_Cancelar);
            this.Name = "InterfazModificarProductos";
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
        private System.Windows.Forms.TextBox Stock_Error;
        private System.Windows.Forms.TextBox Precio_Error;
        private System.Windows.Forms.Label MayudaTelefono;
        private System.Windows.Forms.Label MayudaStock;
        private System.Windows.Forms.Label MayudaPrecio;
        private System.Windows.Forms.TextBox Box_Stock;
        private System.Windows.Forms.TextBox Box_Precio;
        private System.Windows.Forms.Label Label_Precio;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Stock;
    }
}