namespace Presentacion
{
    partial class InterfazRepoMenu
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
            this.BotonSalir = new System.Windows.Forms.Button();
            this.RepoMasVendido_Icono = new System.Windows.Forms.PictureBox();
            this.RepoVentas_Icono = new System.Windows.Forms.PictureBox();
            this.RepoStock_Icono = new System.Windows.Forms.PictureBox();
            this.RepoStock_Texto = new System.Windows.Forms.Label();
            this.RepoVentas_Texto = new System.Windows.Forms.Label();
            this.RepoMasVendido_Texto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RepoMasVendido_Icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoVentas_Icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoStock_Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BotonSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BotonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.BotonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BotonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSalir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSalir.Location = new System.Drawing.Point(1134, 678);
            this.BotonSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(183, 49);
            this.BotonSalir.TabIndex = 7;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = false;
            this.BotonSalir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // RepoMasVendido_Icono
            // 
            this.RepoMasVendido_Icono.Image = global::Presentacion.Properties.Resources.Reporte6;
            this.RepoMasVendido_Icono.Location = new System.Drawing.Point(973, 187);
            this.RepoMasVendido_Icono.Name = "RepoMasVendido_Icono";
            this.RepoMasVendido_Icono.Size = new System.Drawing.Size(315, 265);
            this.RepoMasVendido_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RepoMasVendido_Icono.TabIndex = 8;
            this.RepoMasVendido_Icono.TabStop = false;
            this.RepoMasVendido_Icono.Click += new System.EventHandler(this.RepoMasVendido_Icono_Click);
            // 
            // RepoVentas_Icono
            // 
            this.RepoVentas_Icono.Image = global::Presentacion.Properties.Resources.Reporte5;
            this.RepoVentas_Icono.Location = new System.Drawing.Point(519, 187);
            this.RepoVentas_Icono.Name = "RepoVentas_Icono";
            this.RepoVentas_Icono.Size = new System.Drawing.Size(315, 265);
            this.RepoVentas_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RepoVentas_Icono.TabIndex = 9;
            this.RepoVentas_Icono.TabStop = false;
            this.RepoVentas_Icono.Click += new System.EventHandler(this.RepoVentas_Icono_Click);
            // 
            // RepoStock_Icono
            // 
            this.RepoStock_Icono.Image = global::Presentacion.Properties.Resources.Reporte4;
            this.RepoStock_Icono.Location = new System.Drawing.Point(71, 187);
            this.RepoStock_Icono.Name = "RepoStock_Icono";
            this.RepoStock_Icono.Size = new System.Drawing.Size(315, 265);
            this.RepoStock_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RepoStock_Icono.TabIndex = 10;
            this.RepoStock_Icono.TabStop = false;
            this.RepoStock_Icono.Click += new System.EventHandler(this.RepoStock_Icono_Click);
            // 
            // RepoStock_Texto
            // 
            this.RepoStock_Texto.AutoSize = true;
            this.RepoStock_Texto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepoStock_Texto.Font = new System.Drawing.Font("Nunito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoStock_Texto.Location = new System.Drawing.Point(123, 455);
            this.RepoStock_Texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepoStock_Texto.Name = "RepoStock_Texto";
            this.RepoStock_Texto.Size = new System.Drawing.Size(210, 43);
            this.RepoStock_Texto.TabIndex = 12;
            this.RepoStock_Texto.Text = "Stock Crítico";
            this.RepoStock_Texto.Click += new System.EventHandler(this.RepoStock_Icono_Click);
            // 
            // RepoVentas_Texto
            // 
            this.RepoVentas_Texto.AutoSize = true;
            this.RepoVentas_Texto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepoVentas_Texto.Font = new System.Drawing.Font("Nunito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoVentas_Texto.Location = new System.Drawing.Point(508, 453);
            this.RepoVentas_Texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepoVentas_Texto.Name = "RepoVentas_Texto";
            this.RepoVentas_Texto.Size = new System.Drawing.Size(337, 43);
            this.RepoVentas_Texto.TabIndex = 13;
            this.RepoVentas_Texto.Text = "Ventas por Vendedor";
            this.RepoVentas_Texto.Click += new System.EventHandler(this.RepoVentas_Icono_Click);
            // 
            // RepoMasVendido_Texto
            // 
            this.RepoMasVendido_Texto.AutoSize = true;
            this.RepoMasVendido_Texto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepoMasVendido_Texto.Font = new System.Drawing.Font("Nunito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepoMasVendido_Texto.Location = new System.Drawing.Point(1007, 455);
            this.RepoMasVendido_Texto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepoMasVendido_Texto.Name = "RepoMasVendido_Texto";
            this.RepoMasVendido_Texto.Size = new System.Drawing.Size(263, 43);
            this.RepoMasVendido_Texto.TabIndex = 14;
            this.RepoMasVendido_Texto.Text = "Lo Más Vendido";
            this.RepoMasVendido_Texto.Click += new System.EventHandler(this.RepoMasVendido_Icono_Click);
            // 
            // InterfazRepoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.RepoMasVendido_Texto);
            this.Controls.Add(this.RepoVentas_Texto);
            this.Controls.Add(this.RepoStock_Texto);
            this.Controls.Add(this.RepoStock_Icono);
            this.Controls.Add(this.RepoVentas_Icono);
            this.Controls.Add(this.RepoMasVendido_Icono);
            this.Controls.Add(this.BotonSalir);
            this.Name = "InterfazRepoMenu";
            this.Text = "InterfazRepoMenu";
            ((System.ComponentModel.ISupportInitialize)(this.RepoMasVendido_Icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoVentas_Icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoStock_Icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.PictureBox RepoMasVendido_Icono;
        private System.Windows.Forms.PictureBox RepoVentas_Icono;
        private System.Windows.Forms.PictureBox RepoStock_Icono;
        private System.Windows.Forms.Label RepoStock_Texto;
        private System.Windows.Forms.Label RepoVentas_Texto;
        private System.Windows.Forms.Label RepoMasVendido_Texto;
    }
}