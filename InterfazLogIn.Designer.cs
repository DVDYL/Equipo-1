namespace Equipo1
{
    partial class InterfazLogIn
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
            this.Box_Usuario = new System.Windows.Forms.TextBox();
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.Label_Pass = new System.Windows.Forms.Label();
            this.Box_Pass = new System.Windows.Forms.TextBox();
            this.Boton_Ingresar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Label_NewPass = new System.Windows.Forms.Label();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.Label_ConfirmNewPass = new System.Windows.Forms.Label();
            this.ConfirmNewPass = new System.Windows.Forms.TextBox();
            this.PassViewImg = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PassViewImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_Usuario
            // 
            this.Box_Usuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Box_Usuario.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Usuario.Location = new System.Drawing.Point(504, 236);
            this.Box_Usuario.Name = "Box_Usuario";
            this.Box_Usuario.Size = new System.Drawing.Size(343, 34);
            this.Box_Usuario.TabIndex = 0;
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.Location = new System.Drawing.Point(92, 242);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(170, 28);
            this.Label_Usuario.TabIndex = 1;
            this.Label_Usuario.Text = "Email o Usuario:";
            // 
            // Label_Pass
            // 
            this.Label_Pass.AutoSize = true;
            this.Label_Pass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pass.Location = new System.Drawing.Point(92, 326);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(130, 28);
            this.Label_Pass.TabIndex = 3;
            this.Label_Pass.Text = "Contraseña:";
            // 
            // Box_Pass
            // 
            this.Box_Pass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Box_Pass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Pass.Location = new System.Drawing.Point(504, 321);
            this.Box_Pass.Name = "Box_Pass";
            this.Box_Pass.Size = new System.Drawing.Size(343, 34);
            this.Box_Pass.TabIndex = 1;
            this.Box_Pass.UseSystemPasswordChar = true;
            // 
            // Boton_Ingresar
            // 
            this.Boton_Ingresar.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Ingresar.Location = new System.Drawing.Point(275, 566);
            this.Boton_Ingresar.Name = "Boton_Ingresar";
            this.Boton_Ingresar.Size = new System.Drawing.Size(174, 41);
            this.Boton_Ingresar.TabIndex = 2;
            this.Boton_Ingresar.Text = "Ingresar";
            this.Boton_Ingresar.UseVisualStyleBackColor = true;
            this.Boton_Ingresar.Click += new System.EventHandler(this.Boton_Ingresar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(504, 566);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(174, 41);
            this.Boton_Cancelar.TabIndex = 5;
            this.Boton_Cancelar.Text = "Salir";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Label_NewPass
            // 
            this.Label_NewPass.AutoSize = true;
            this.Label_NewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NewPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label_NewPass.Location = new System.Drawing.Point(92, 410);
            this.Label_NewPass.Name = "Label_NewPass";
            this.Label_NewPass.Size = new System.Drawing.Size(198, 28);
            this.Label_NewPass.TabIndex = 7;
            this.Label_NewPass.Text = "Nueva Contraseña:";
            // 
            // NewPass
            // 
            this.NewPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NewPass.Enabled = false;
            this.NewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.Location = new System.Drawing.Point(504, 406);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(343, 34);
            this.NewPass.TabIndex = 6;
            // 
            // Label_ConfirmNewPass
            // 
            this.Label_ConfirmNewPass.AutoSize = true;
            this.Label_ConfirmNewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmNewPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label_ConfirmNewPass.Location = new System.Drawing.Point(92, 494);
            this.Label_ConfirmNewPass.Name = "Label_ConfirmNewPass";
            this.Label_ConfirmNewPass.Size = new System.Drawing.Size(301, 28);
            this.Label_ConfirmNewPass.TabIndex = 9;
            this.Label_ConfirmNewPass.Text = "Confirmar Nueva Contraseña:";
            // 
            // ConfirmNewPass
            // 
            this.ConfirmNewPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ConfirmNewPass.Enabled = false;
            this.ConfirmNewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPass.Location = new System.Drawing.Point(504, 491);
            this.ConfirmNewPass.Name = "ConfirmNewPass";
            this.ConfirmNewPass.Size = new System.Drawing.Size(343, 34);
            this.ConfirmNewPass.TabIndex = 8;
            // 
            // PassViewImg
            // 
            this.PassViewImg.Image = global::Form_Equipo1.Properties.Resources.PassView;
            this.PassViewImg.Location = new System.Drawing.Point(854, 322);
            this.PassViewImg.Name = "PassViewImg";
            this.PassViewImg.Size = new System.Drawing.Size(41, 34);
            this.PassViewImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassViewImg.TabIndex = 12;
            this.PassViewImg.TabStop = false;
            this.PassViewImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassViewImg_MouseDown);
            this.PassViewImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PassViewImg_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form_Equipo1.Properties.Resources.Logo___Nunito_Sin_Fondo;
            this.pictureBox2.Location = new System.Drawing.Point(353, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // InterfazLogIn
            // 
            this.AcceptButton = this.Boton_Ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 637);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PassViewImg);
            this.Controls.Add(this.Label_ConfirmNewPass);
            this.Controls.Add(this.ConfirmNewPass);
            this.Controls.Add(this.Label_NewPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Ingresar);
            this.Controls.Add(this.Label_Pass);
            this.Controls.Add(this.Box_Pass);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.Box_Usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "InterfazLogIn";
            this.Text = "Log In";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogIn_KeyDown);
            this.Controls.SetChildIndex(this.Box_Usuario, 0);
            this.Controls.SetChildIndex(this.Label_Usuario, 0);
            this.Controls.SetChildIndex(this.Box_Pass, 0);
            this.Controls.SetChildIndex(this.Label_Pass, 0);
            this.Controls.SetChildIndex(this.Boton_Ingresar, 0);
            this.Controls.SetChildIndex(this.Boton_Cancelar, 0);
            this.Controls.SetChildIndex(this.NewPass, 0);
            this.Controls.SetChildIndex(this.Label_NewPass, 0);
            this.Controls.SetChildIndex(this.ConfirmNewPass, 0);
            this.Controls.SetChildIndex(this.Label_ConfirmNewPass, 0);
            this.Controls.SetChildIndex(this.PassViewImg, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PassViewImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box_Usuario;
        private System.Windows.Forms.Label Label_Usuario;
        private System.Windows.Forms.Label Label_Pass;
        private System.Windows.Forms.TextBox Box_Pass;
        private System.Windows.Forms.Button Boton_Ingresar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Label Label_NewPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.Label Label_ConfirmNewPass;
        private System.Windows.Forms.TextBox ConfirmNewPass;
        private System.Windows.Forms.PictureBox PassViewImg;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}