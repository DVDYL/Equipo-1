namespace Form_Equipo1
{
    partial class LogIn
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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.Label_Pass = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Boton_Ingresar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.Label_NewPass = new System.Windows.Forms.Label();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.Label_ConfirmNewPass = new System.Windows.Forms.Label();
            this.ConfirmNewPass = new System.Windows.Forms.TextBox();
            this.RecuperaPass = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Usuario.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(415, 148);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(343, 34);
            this.Usuario.TabIndex = 0;
            this.Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.Location = new System.Drawing.Point(92, 154);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(170, 28);
            this.Label_Usuario.TabIndex = 1;
            this.Label_Usuario.Text = "Email o Usuario:";
            // 
            // Label_Pass
            // 
            this.Label_Pass.AutoSize = true;
            this.Label_Pass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pass.Location = new System.Drawing.Point(92, 238);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(130, 28);
            this.Label_Pass.TabIndex = 3;
            this.Label_Pass.Text = "Contraseña:";
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Pass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(415, 233);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(343, 34);
            this.Pass.TabIndex = 2;
            // 
            // Boton_Ingresar
            // 
            this.Boton_Ingresar.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Ingresar.Location = new System.Drawing.Point(176, 560);
            this.Boton_Ingresar.Name = "Boton_Ingresar";
            this.Boton_Ingresar.Size = new System.Drawing.Size(174, 41);
            this.Boton_Ingresar.TabIndex = 4;
            this.Boton_Ingresar.Text = "Ingresar";
            this.Boton_Ingresar.UseVisualStyleBackColor = true;
            this.Boton_Ingresar.Click += new System.EventHandler(this.Boton_Ingresar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(483, 559);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(174, 41);
            this.Boton_Cancelar.TabIndex = 5;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Label_NewPass
            // 
            this.Label_NewPass.AutoSize = true;
            this.Label_NewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NewPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label_NewPass.Location = new System.Drawing.Point(92, 322);
            this.Label_NewPass.Name = "Label_NewPass";
            this.Label_NewPass.Size = new System.Drawing.Size(198, 28);
            this.Label_NewPass.TabIndex = 7;
            this.Label_NewPass.Text = "Nueva Contraseña:";
            // 
            // NewPass
            // 
            this.NewPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.Location = new System.Drawing.Point(415, 318);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(343, 34);
            this.NewPass.TabIndex = 6;
            // 
            // Label_ConfirmNewPass
            // 
            this.Label_ConfirmNewPass.AutoSize = true;
            this.Label_ConfirmNewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmNewPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label_ConfirmNewPass.Location = new System.Drawing.Point(92, 406);
            this.Label_ConfirmNewPass.Name = "Label_ConfirmNewPass";
            this.Label_ConfirmNewPass.Size = new System.Drawing.Size(301, 28);
            this.Label_ConfirmNewPass.TabIndex = 9;
            this.Label_ConfirmNewPass.Text = "Confirmar Nueva Contraseña:";
            // 
            // ConfirmNewPass
            // 
            this.ConfirmNewPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ConfirmNewPass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPass.Location = new System.Drawing.Point(415, 403);
            this.ConfirmNewPass.Name = "ConfirmNewPass";
            this.ConfirmNewPass.Size = new System.Drawing.Size(343, 34);
            this.ConfirmNewPass.TabIndex = 8;
            // 
            // RecuperaPass
            // 
            this.RecuperaPass.AutoSize = true;
            this.RecuperaPass.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecuperaPass.Location = new System.Drawing.Point(320, 495);
            this.RecuperaPass.Name = "RecuperaPass";
            this.RecuperaPass.Size = new System.Drawing.Size(183, 21);
            this.RecuperaPass.TabIndex = 10;
            this.RecuperaPass.Text = "¿Olvidó su Contraseña?";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Logo.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(264, 32);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(308, 66);
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            this.Logo.Text = "LOGO";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 636);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.RecuperaPass);
            this.Controls.Add(this.Label_ConfirmNewPass);
            this.Controls.Add(this.ConfirmNewPass);
            this.Controls.Add(this.Label_NewPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Ingresar);
            this.Controls.Add(this.Label_Pass);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.Usuario);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label Label_Usuario;
        private System.Windows.Forms.Label Label_Pass;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button Boton_Ingresar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Label Label_NewPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.Label Label_ConfirmNewPass;
        private System.Windows.Forms.TextBox ConfirmNewPass;
        private System.Windows.Forms.Label RecuperaPass;
        private System.Windows.Forms.GroupBox Logo;
    }
}