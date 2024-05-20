namespace Presentacion
{
    partial class InterfazRepoVentas
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
            this.SuspendLayout();
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.Location = new System.Drawing.Point(416, 352);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(150, 41);
            this.Boton_Salir.TabIndex = 1;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = true;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click_1);
            // 
            // InterfazRepoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_Salir);
            this.Name = "InterfazRepoVentas";
            this.Text = "InterfazRepoVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_Salir;
    }
}