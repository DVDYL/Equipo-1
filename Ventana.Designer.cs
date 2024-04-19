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
            this.btnRestaurarForm = new System.Windows.Forms.PictureBox();
            this.btnMinimizarForm = new System.Windows.Forms.PictureBox();
            this.btnMaximizarForm = new System.Windows.Forms.PictureBox();
            this.btnCerrarForm = new System.Windows.Forms.PictureBox();
            BarraVentana = new System.Windows.Forms.Panel();
            BarraVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraVentana
            // 
            BarraVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(46)))));
            BarraVentana.Controls.Add(this.label2);
            BarraVentana.Controls.Add(this.btnRestaurarForm);
            BarraVentana.Controls.Add(this.btnMinimizarForm);
            BarraVentana.Controls.Add(this.btnMaximizarForm);
            BarraVentana.Controls.Add(this.btnCerrarForm);
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
            // 
            // btnRestaurarForm
            // 
            this.btnRestaurarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnRestaurarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarForm.Image")));
            this.btnRestaurarForm.Location = new System.Drawing.Point(715, 0);
            this.btnRestaurarForm.Name = "btnRestaurarForm";
            this.btnRestaurarForm.Size = new System.Drawing.Size(40, 39);
            this.btnRestaurarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurarForm.TabIndex = 2;
            this.btnRestaurarForm.TabStop = false;
            this.btnRestaurarForm.UseWaitCursor = true;
            this.btnRestaurarForm.Visible = false;
            this.btnRestaurarForm.Click += new System.EventHandler(this.btnRestaurarForm_Click);
            // 
            // btnMinimizarForm
            // 
            this.btnMinimizarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarForm.Image")));
            this.btnMinimizarForm.Location = new System.Drawing.Point(677, -9);
            this.btnMinimizarForm.Name = "btnMinimizarForm";
            this.btnMinimizarForm.Size = new System.Drawing.Size(31, 35);
            this.btnMinimizarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarForm.TabIndex = 2;
            this.btnMinimizarForm.TabStop = false;
            this.btnMinimizarForm.Click += new System.EventHandler(this.btnMinimizarForm_Click);
            // 
            // btnMaximizarForm
            // 
            this.btnMaximizarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizarForm.Image")));
            this.btnMaximizarForm.Location = new System.Drawing.Point(725, 4);
            this.btnMaximizarForm.Name = "btnMaximizarForm";
            this.btnMaximizarForm.Size = new System.Drawing.Size(30, 32);
            this.btnMaximizarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizarForm.TabIndex = 2;
            this.btnMaximizarForm.TabStop = false;
            this.btnMaximizarForm.Click += new System.EventHandler(this.btnMaximizarForm_Click);
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarForm.Image")));
            this.btnCerrarForm.Location = new System.Drawing.Point(758, 0);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(39, 42);
            this.btnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarForm.TabIndex = 2;
            this.btnCerrarForm.TabStop = false;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click);
            // 
            // Ventana
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(BarraVentana);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ventana";
            BarraVentana.ResumeLayout(false);
            BarraVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrarForm;
        private System.Windows.Forms.PictureBox btnMaximizarForm;
        private System.Windows.Forms.PictureBox btnMinimizarForm;
        private System.Windows.Forms.PictureBox btnRestaurarForm;
        private System.Windows.Forms.Label label2;
    }
}