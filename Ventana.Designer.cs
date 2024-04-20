namespace Presentacion
{
    partial class Ventana
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
            System.Windows.Forms.Panel BarraVentana;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.label2 = new System.Windows.Forms.Label();
            this.Boton_Minimizar = new System.Windows.Forms.PictureBox();
            this.Boton_Cerrar = new System.Windows.Forms.PictureBox();
            BarraVentana = new System.Windows.Forms.Panel();
            BarraVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraVentana
            // 
            BarraVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(46)))));
            BarraVentana.Controls.Add(this.label2);
            BarraVentana.Controls.Add(this.Boton_Minimizar);
            BarraVentana.Controls.Add(this.Boton_Cerrar);
            BarraVentana.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            BarraVentana.Dock = System.Windows.Forms.DockStyle.Top;
            BarraVentana.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BarraVentana.Location = new System.Drawing.Point(0, 0);
            BarraVentana.Name = "BarraVentana";
            BarraVentana.Size = new System.Drawing.Size(800, 38);
            BarraVentana.TabIndex = 0;
            BarraVentana.UseWaitCursor = true;
            BarraVentana.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BarraTituloForm_MouseDoubleClick);
            BarraVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloForm_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 1;
            this.label2.UseWaitCursor = true;
            // 
            // Boton_Minimizar
            // 
            this.Boton_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Boton_Minimizar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Boton_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Minimizar.Image")));
            this.Boton_Minimizar.Location = new System.Drawing.Point(721, -1);
            this.Boton_Minimizar.Name = "Boton_Minimizar";
            this.Boton_Minimizar.Size = new System.Drawing.Size(31, 35);
            this.Boton_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boton_Minimizar.TabIndex = 2;
            this.Boton_Minimizar.TabStop = false;
            this.Boton_Minimizar.UseWaitCursor = true;
            this.Boton_Minimizar.Click += new System.EventHandler(this.Boton_Minimizar_Click);
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Boton_Cerrar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Boton_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Boton_Cerrar.Image")));
            this.Boton_Cerrar.Location = new System.Drawing.Point(758, 0);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(39, 42);
            this.Boton_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boton_Cerrar.TabIndex = 2;
            this.Boton_Cerrar.TabStop = false;
            this.Boton_Cerrar.UseWaitCursor = true;
            this.Boton_Cerrar.Click += new System.EventHandler(this.Boton_Cerrar_Click);
            // 
            // Ventana
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(BarraVentana);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ventana";
            BarraVentana.ResumeLayout(false);
            BarraVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Boton_Cerrar;
        private System.Windows.Forms.PictureBox Boton_Minimizar;
        private System.Windows.Forms.Label label2;
    }
}