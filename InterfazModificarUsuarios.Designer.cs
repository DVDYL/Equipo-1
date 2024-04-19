namespace Presentacion
{
    partial class InterfazModificarUsuarios
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
            this.Operacion_Null = new System.Windows.Forms.TextBox();
            this.MayudaOper = new System.Windows.Forms.Label();
            this.Label_Operacion = new System.Windows.Forms.Label();
            this.ComboBox_ABM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Operacion_Null
            // 
            this.Operacion_Null.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Operacion_Null.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operacion_Null.ForeColor = System.Drawing.Color.Red;
            this.Operacion_Null.Location = new System.Drawing.Point(303, 248);
            this.Operacion_Null.Name = "Operacion_Null";
            this.Operacion_Null.Size = new System.Drawing.Size(194, 16);
            this.Operacion_Null.TabIndex = 47;
            this.Operacion_Null.Text = "Este campo no puede estar vacío";
            // 
            // MayudaOper
            // 
            this.MayudaOper.AutoSize = true;
            this.MayudaOper.BackColor = System.Drawing.Color.LightGray;
            this.MayudaOper.Location = new System.Drawing.Point(509, 222);
            this.MayudaOper.Name = "MayudaOper";
            this.MayudaOper.Size = new System.Drawing.Size(18, 20);
            this.MayudaOper.TabIndex = 46;
            this.MayudaOper.Text = "?";
            this.MayudaOper.Visible = false;
            // 
            // Label_Operacion
            // 
            this.Label_Operacion.AutoSize = true;
            this.Label_Operacion.Font = new System.Drawing.Font("Nunito", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Operacion.Location = new System.Drawing.Point(273, 187);
            this.Label_Operacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Operacion.Name = "Label_Operacion";
            this.Label_Operacion.Size = new System.Drawing.Size(90, 23);
            this.Label_Operacion.TabIndex = 45;
            this.Label_Operacion.Text = "Operación";
            // 
            // ComboBox_ABM
            // 
            this.ComboBox_ABM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_ABM.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_ABM.FormattingEnabled = true;
            this.ComboBox_ABM.Location = new System.Drawing.Point(294, 213);
            this.ComboBox_ABM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_ABM.Name = "ComboBox_ABM";
            this.ComboBox_ABM.Size = new System.Drawing.Size(208, 29);
            this.ComboBox_ABM.TabIndex = 44;
            // 
            // InterfazModificarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Operacion_Null);
            this.Controls.Add(this.MayudaOper);
            this.Controls.Add(this.Label_Operacion);
            this.Controls.Add(this.ComboBox_ABM);
            this.Name = "InterfazModificarUsuarios";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Operacion_Null;
        private System.Windows.Forms.Label MayudaOper;
        private System.Windows.Forms.Label Label_Operacion;
        private System.Windows.Forms.ComboBox ComboBox_ABM;
    }
}