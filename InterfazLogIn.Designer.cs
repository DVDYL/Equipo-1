namespace Presentacion
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
            this.LogoInicio = new System.Windows.Forms.PictureBox();
            this.Label_TituloVentana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassViewImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_Usuario
            // 
            this.Box_Usuario.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Usuario.Location = new System.Drawing.Point(396, 433);
            this.Box_Usuario.Name = "Box_Usuario";
            this.Box_Usuario.Size = new System.Drawing.Size(343, 31);
            this.Box_Usuario.TabIndex = 1;
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_Usuario.Location = new System.Drawing.Point(36, 429);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(305, 37);
            this.Label_Usuario.TabIndex = 1;
            this.Label_Usuario.Text = "Nombre de Usuario:";
            // 
            // Label_Pass
            // 
            this.Label_Pass.AutoSize = true;
            this.Label_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Pass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label_Pass.Location = new System.Drawing.Point(36, 525);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(192, 37);
            this.Label_Pass.TabIndex = 3;
            this.Label_Pass.Text = "Contraseña:";
            // 
            // Box_Pass
            // 
            this.Box_Pass.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Pass.Location = new System.Drawing.Point(396, 529);
            this.Box_Pass.Name = "Box_Pass";
            this.Box_Pass.Size = new System.Drawing.Size(343, 31);
            this.Box_Pass.TabIndex = 2;
            this.Box_Pass.UseSystemPasswordChar = true;
            // 
            // Boton_Ingresar
            // 
            this.Boton_Ingresar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Ingresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Ingresar.FlatAppearance.BorderSize = 0;
            this.Boton_Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Ingresar.Location = new System.Drawing.Point(120, 792);
            this.Boton_Ingresar.Name = "Boton_Ingresar";
            this.Boton_Ingresar.Size = new System.Drawing.Size(200, 50);
            this.Boton_Ingresar.TabIndex = 3;
            this.Boton_Ingresar.Text = "Ingresar";
            this.Boton_Ingresar.UseVisualStyleBackColor = false;
            this.Boton_Ingresar.Click += new System.EventHandler(this.Boton_Ingresar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Cancelar.FlatAppearance.BorderSize = 0;
            this.Boton_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(483, 792);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(200, 50);
            this.Boton_Cancelar.TabIndex = 4;
            this.Boton_Cancelar.Text = "Salir";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Label_NewPass
            // 
            this.Label_NewPass.AutoSize = true;
            this.Label_NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NewPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label_NewPass.Location = new System.Drawing.Point(36, 628);
            this.Label_NewPass.Name = "Label_NewPass";
            this.Label_NewPass.Size = new System.Drawing.Size(293, 37);
            this.Label_NewPass.TabIndex = 7;
            this.Label_NewPass.Text = "Nueva Contraseña:";
            this.Label_NewPass.Visible = false;
            // 
            // NewPass
            // 
            this.NewPass.BackColor = System.Drawing.Color.Gainsboro;
            this.NewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPass.Enabled = false;
            this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.Location = new System.Drawing.Point(396, 632);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(343, 31);
            this.NewPass.TabIndex = 6;
            this.NewPass.Visible = false;
            // 
            // Label_ConfirmNewPass
            // 
            this.Label_ConfirmNewPass.AutoSize = true;
            this.Label_ConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmNewPass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label_ConfirmNewPass.Location = new System.Drawing.Point(36, 703);
            this.Label_ConfirmNewPass.Name = "Label_ConfirmNewPass";
            this.Label_ConfirmNewPass.Size = new System.Drawing.Size(343, 37);
            this.Label_ConfirmNewPass.TabIndex = 9;
            this.Label_ConfirmNewPass.Text = "Confirmar Contraseña:";
            this.Label_ConfirmNewPass.Visible = false;
            // 
            // ConfirmNewPass
            // 
            this.ConfirmNewPass.BackColor = System.Drawing.Color.Gainsboro;
            this.ConfirmNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmNewPass.Enabled = false;
            this.ConfirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNewPass.Location = new System.Drawing.Point(396, 707);
            this.ConfirmNewPass.Name = "ConfirmNewPass";
            this.ConfirmNewPass.Size = new System.Drawing.Size(343, 31);
            this.ConfirmNewPass.TabIndex = 8;
            this.ConfirmNewPass.Visible = false;
            // 
            // PassViewImg
            // 
            this.PassViewImg.BackColor = System.Drawing.Color.Transparent;
            this.PassViewImg.Image = global::Presentacion.Properties.Resources.ojo1;
            this.PassViewImg.Location = new System.Drawing.Point(744, 529);
            this.PassViewImg.Name = "PassViewImg";
            this.PassViewImg.Size = new System.Drawing.Size(41, 34);
            this.PassViewImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassViewImg.TabIndex = 12;
            this.PassViewImg.TabStop = false;
            this.PassViewImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassViewImg_MouseDown);
            this.PassViewImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PassViewImg_MouseUp);
            // 
            // LogoInicio
            // 
            this.LogoInicio.Image = global::Presentacion.Properties.Resources.electro_hogar1;
            this.LogoInicio.Location = new System.Drawing.Point(4, 62);
            this.LogoInicio.Name = "LogoInicio";
            this.LogoInicio.Size = new System.Drawing.Size(790, 331);
            this.LogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoInicio.TabIndex = 48;
            this.LogoInicio.TabStop = false;
            this.LogoInicio.Click += new System.EventHandler(this.LogoInicio_Click);
            // 
            // Label_TituloVentana
            // 
            this.Label_TituloVentana.AutoSize = true;
            this.Label_TituloVentana.BackColor = System.Drawing.Color.Transparent;
            this.Label_TituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TituloVentana.Location = new System.Drawing.Point(2, 0);
            this.Label_TituloVentana.Name = "Label_TituloVentana";
            this.Label_TituloVentana.Size = new System.Drawing.Size(164, 25);
            this.Label_TituloVentana.TabIndex = 49;
            this.Label_TituloVentana.Text = "Inicio de Sesión";
            // 
            // InterfazLogIn
            // 
            this.AcceptButton = this.Boton_Ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.Label_TituloVentana);
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
            this.Controls.Add(this.LogoInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "InterfazLogIn";
            this.Text = "Iniciar Sesión";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.InterfazLogIn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogIn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PassViewImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoInicio)).EndInit();
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
        private System.Windows.Forms.PictureBox LogoInicio;
        private System.Windows.Forms.Label Label_TituloVentana;
    }
}