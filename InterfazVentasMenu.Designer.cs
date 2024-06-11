namespace Presentacion
{
    partial class InterfazVentasMenu
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
            this.Vender_Icono = new System.Windows.Forms.PictureBox();
            this.Devolver_Icono = new System.Windows.Forms.PictureBox();
            this.Vender = new System.Windows.Forms.Label();
            this.Label_Devolver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Vender_Icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Devolver_Icono)).BeginInit();
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
            this.Boton_Salir.Location = new System.Drawing.Point(618, 481);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(150, 40);
            this.Boton_Salir.TabIndex = 8;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Vender_Icono
            // 
            this.Vender_Icono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vender_Icono.Image = global::Presentacion.Properties.Resources.AgregarVenta;
            this.Vender_Icono.InitialImage = global::Presentacion.Properties.Resources.AgregarVenta;
            this.Vender_Icono.Location = new System.Drawing.Point(49, 100);
            this.Vender_Icono.Name = "Vender_Icono";
            this.Vender_Icono.Size = new System.Drawing.Size(315, 265);
            this.Vender_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Vender_Icono.TabIndex = 9;
            this.Vender_Icono.TabStop = false;
            this.Vender_Icono.Click += new System.EventHandler(this.Vender_Icono_Click);
            // 
            // Devolver_Icono
            // 
            this.Devolver_Icono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Devolver_Icono.Image = global::Presentacion.Properties.Resources.DevolverVenta;
            this.Devolver_Icono.InitialImage = global::Presentacion.Properties.Resources.DevolverVenta;
            this.Devolver_Icono.Location = new System.Drawing.Point(436, 100);
            this.Devolver_Icono.Name = "Devolver_Icono";
            this.Devolver_Icono.Size = new System.Drawing.Size(315, 265);
            this.Devolver_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Devolver_Icono.TabIndex = 10;
            this.Devolver_Icono.TabStop = false;
            this.Devolver_Icono.Click += new System.EventHandler(this.Devolver_Icono_Click);
            // 
            // Vender
            // 
            this.Vender.AutoSize = true;
            this.Vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vender.Location = new System.Drawing.Point(154, 368);
            this.Vender.Name = "Vender";
            this.Vender.Size = new System.Drawing.Size(105, 36);
            this.Vender.TabIndex = 11;
            this.Vender.Text = "Vender";
            this.Vender.Click += new System.EventHandler(this.Vender_Icono_Click);
            // 
            // Label_Devolver
            // 
            this.Label_Devolver.AutoSize = true;
            this.Label_Devolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Devolver.Location = new System.Drawing.Point(530, 368);
            this.Label_Devolver.Name = "Label_Devolver";
            this.Label_Devolver.Size = new System.Drawing.Size(126, 36);
            this.Label_Devolver.TabIndex = 12;
            this.Label_Devolver.Text = "Devolver";
            this.Label_Devolver.Click += new System.EventHandler(this.Vender_Icono_Click);
            // 
            // InterfazVentasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.Label_Devolver);
            this.Controls.Add(this.Vender);
            this.Controls.Add(this.Devolver_Icono);
            this.Controls.Add(this.Vender_Icono);
            this.Controls.Add(this.Boton_Salir);
            this.Name = "InterfazVentasMenu";
            this.Text = "Menú Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.Vender_Icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Devolver_Icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.PictureBox Vender_Icono;
        private System.Windows.Forms.PictureBox Devolver_Icono;
        private System.Windows.Forms.Label Vender;
        private System.Windows.Forms.Label Label_Devolver;
    }
}