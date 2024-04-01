namespace Form_Equipo1
{
    partial class Menu
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
            this.MenuUserAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuLogOut = new System.Windows.Forms.Button();
            this.UserAdminImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserAdminImg)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuUserAdmin
            // 
            this.MenuUserAdmin.AutoSize = true;
            this.MenuUserAdmin.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuUserAdmin.Location = new System.Drawing.Point(174, 215);
            this.MenuUserAdmin.Name = "MenuUserAdmin";
            this.MenuUserAdmin.Size = new System.Drawing.Size(126, 36);
            this.MenuUserAdmin.TabIndex = 0;
            this.MenuUserAdmin.Text = "Usuarios";
            this.MenuUserAdmin.Click += new System.EventHandler(this.MenuUserAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(644, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(1146, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(165, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(689, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(1154, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ventas";
            // 
            // MenuLogOut
            // 
            this.MenuLogOut.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLogOut.Location = new System.Drawing.Point(1134, 672);
            this.MenuLogOut.Name = "MenuLogOut";
            this.MenuLogOut.Size = new System.Drawing.Size(223, 46);
            this.MenuLogOut.TabIndex = 6;
            this.MenuLogOut.Text = "Cerrar Sesión";
            this.MenuLogOut.UseVisualStyleBackColor = true;
            this.MenuLogOut.Click += new System.EventHandler(this.MenuLogOut_Click);
            // 
            // UserAdminImg
            // 
            this.UserAdminImg.Image = global::Form_Equipo1.Properties.Resources.UserAdmin1;
            this.UserAdminImg.Location = new System.Drawing.Point(125, 41);
            this.UserAdminImg.Name = "UserAdminImg";
            this.UserAdminImg.Size = new System.Drawing.Size(215, 171);
            this.UserAdminImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserAdminImg.TabIndex = 7;
            this.UserAdminImg.TabStop = false;
            this.UserAdminImg.Click += new System.EventHandler(this.UserAdminImg_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 749);
            this.Controls.Add(this.UserAdminImg);
            this.Controls.Add(this.MenuLogOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuUserAdmin);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.UserAdminImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuUserAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MenuLogOut;
        private System.Windows.Forms.PictureBox UserAdminImg;
    }
}