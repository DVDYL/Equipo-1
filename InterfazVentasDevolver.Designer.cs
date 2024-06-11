namespace Presentacion
{
    partial class InterfazVentasDevolver
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
            this.Boton_Devolver = new System.Windows.Forms.Button();
            this.BuscarCliente_Label = new System.Windows.Forms.Label();
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
            this.Boton_Salir.Location = new System.Drawing.Point(1178, 696);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(150, 40);
            this.Boton_Salir.TabIndex = 9;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Boton_Devolver
            // 
            this.Boton_Devolver.BackColor = System.Drawing.Color.Gainsboro;
            this.Boton_Devolver.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Devolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Boton_Devolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Devolver.Font = new System.Drawing.Font("Nunito", 20.25F);
            this.Boton_Devolver.Location = new System.Drawing.Point(969, 696);
            this.Boton_Devolver.Name = "Boton_Devolver";
            this.Boton_Devolver.Size = new System.Drawing.Size(150, 40);
            this.Boton_Devolver.TabIndex = 10;
            this.Boton_Devolver.Text = "Devolver";
            this.Boton_Devolver.UseVisualStyleBackColor = false;
            this.Boton_Devolver.Click += new System.EventHandler(this.Boton_Devolver_Click);
            // 
            // BuscarCliente_Label
            // 
            this.BuscarCliente_Label.AutoSize = true;
            this.BuscarCliente_Label.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCliente_Label.Location = new System.Drawing.Point(61, 86);
            this.BuscarCliente_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuscarCliente_Label.Name = "BuscarCliente_Label";
            this.BuscarCliente_Label.Size = new System.Drawing.Size(1100, 36);
            this.BuscarCliente_Label.TabIndex = 42;
            this.BuscarCliente_Label.Text = " IdVenta - IdVendedor - FechaComprobante - NombreProducto - IdCategoria - $Monto";
            // 
            // InterfazVentasDevolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.BuscarCliente_Label);
            this.Controls.Add(this.Boton_Devolver);
            this.Controls.Add(this.Boton_Salir);
            this.Name = "InterfazVentasDevolver";
            this.Text = "InterfazVentasDevolver";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Button Boton_Devolver;
        private System.Windows.Forms.Label BuscarCliente_Label;
    }
}