namespace Equipo1
{
    partial class UserAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Boton_Confirmar = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_Rol = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_ABM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Calendario_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Box_Nombre = new System.Windows.Forms.TextBox();
            this.Box_Apellido = new System.Windows.Forms.TextBox();
            this.Box_DNI = new System.Windows.Forms.TextBox();
            this.Box_Dir = new System.Windows.Forms.TextBox();
            this.Box_Mail = new System.Windows.Forms.TextBox();
            this.Box_Pass = new System.Windows.Forms.TextBox();
            this.Box_Telefono = new System.Windows.Forms.TextBox();
            this.Box_Mail_Confirm = new System.Windows.Forms.TextBox();
            this.Box_Pass_Confirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(834, 599);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(88, 27);
            this.Boton_Confirmar.TabIndex = 0;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = true;
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(980, 599);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(88, 27);
            this.Boton_Cancelar.TabIndex = 1;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "ABM de Usuarios";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ComboBox_Rol
            // 
            this.ComboBox_Rol.FormattingEnabled = true;
            this.ComboBox_Rol.Location = new System.Drawing.Point(852, 90);
            this.ComboBox_Rol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_Rol.Name = "ComboBox_Rol";
            this.ComboBox_Rol.Size = new System.Drawing.Size(140, 23);
            this.ComboBox_Rol.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ComboBox_ABM
            // 
            this.ComboBox_ABM.FormattingEnabled = true;
            this.ComboBox_ABM.Location = new System.Drawing.Point(432, 90);
            this.ComboBox_ABM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_ABM.Name = "ComboBox_ABM";
            this.ComboBox_ABM.Size = new System.Drawing.Size(140, 23);
            this.ComboBox_ABM.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operación";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(632, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(632, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 377);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "DNI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fecha de Nacimiento";
            // 
            // Calendario_Nacimiento
            // 
            this.Calendario_Nacimiento.Location = new System.Drawing.Point(852, 229);
            this.Calendario_Nacimiento.Name = "Calendario_Nacimiento";
            this.Calendario_Nacimiento.Size = new System.Drawing.Size(200, 22);
            this.Calendario_Nacimiento.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(632, 377);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Confirmar Email";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(239, 455);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Contraseña";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(632, 455);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Confirmar Contraseña";
            // 
            // Box_Nombre
            // 
            this.Box_Nombre.Location = new System.Drawing.Point(432, 161);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(100, 22);
            this.Box_Nombre.TabIndex = 19;
            // 
            // Box_Apellido
            // 
            this.Box_Apellido.Location = new System.Drawing.Point(852, 163);
            this.Box_Apellido.Name = "Box_Apellido";
            this.Box_Apellido.Size = new System.Drawing.Size(100, 22);
            this.Box_Apellido.TabIndex = 20;
            // 
            // Box_DNI
            // 
            this.Box_DNI.Location = new System.Drawing.Point(432, 232);
            this.Box_DNI.Name = "Box_DNI";
            this.Box_DNI.Size = new System.Drawing.Size(100, 22);
            this.Box_DNI.TabIndex = 21;
            // 
            // Box_Dir
            // 
            this.Box_Dir.Location = new System.Drawing.Point(432, 302);
            this.Box_Dir.Name = "Box_Dir";
            this.Box_Dir.Size = new System.Drawing.Size(100, 22);
            this.Box_Dir.TabIndex = 22;
            // 
            // Box_Mail
            // 
            this.Box_Mail.Location = new System.Drawing.Point(432, 378);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(100, 22);
            this.Box_Mail.TabIndex = 23;
            // 
            // Box_Pass
            // 
            this.Box_Pass.Location = new System.Drawing.Point(432, 456);
            this.Box_Pass.Name = "Box_Pass";
            this.Box_Pass.Size = new System.Drawing.Size(100, 22);
            this.Box_Pass.TabIndex = 24;
            // 
            // Box_Telefono
            // 
            this.Box_Telefono.Location = new System.Drawing.Point(852, 303);
            this.Box_Telefono.Name = "Box_Telefono";
            this.Box_Telefono.Size = new System.Drawing.Size(100, 22);
            this.Box_Telefono.TabIndex = 25;
            // 
            // Box_Mail_Confirm
            // 
            this.Box_Mail_Confirm.Location = new System.Drawing.Point(852, 375);
            this.Box_Mail_Confirm.Name = "Box_Mail_Confirm";
            this.Box_Mail_Confirm.Size = new System.Drawing.Size(100, 22);
            this.Box_Mail_Confirm.TabIndex = 26;
            // 
            // Box_Pass_Confirm
            // 
            this.Box_Pass_Confirm.Location = new System.Drawing.Point(852, 453);
            this.Box_Pass_Confirm.Name = "Box_Pass_Confirm";
            this.Box_Pass_Confirm.Size = new System.Drawing.Size(100, 22);
            this.Box_Pass_Confirm.TabIndex = 27;
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 661);
            this.Controls.Add(this.Box_Pass_Confirm);
            this.Controls.Add(this.Box_Mail_Confirm);
            this.Controls.Add(this.Box_Telefono);
            this.Controls.Add(this.Box_Pass);
            this.Controls.Add(this.Box_Mail);
            this.Controls.Add(this.Box_Dir);
            this.Controls.Add(this.Box_DNI);
            this.Controls.Add(this.Box_Apellido);
            this.Controls.Add(this.Box_Nombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Calendario_Nacimiento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBox_ABM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBox_Rol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Confirmar);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserAdmin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_Rol;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_ABM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Calendario_Nacimiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox Box_Nombre;
        private System.Windows.Forms.TextBox Box_Apellido;
        private System.Windows.Forms.TextBox Box_DNI;
        private System.Windows.Forms.TextBox Box_Dir;
        private System.Windows.Forms.TextBox Box_Mail;
        private System.Windows.Forms.TextBox Box_Pass;
        private System.Windows.Forms.TextBox Box_Telefono;
        private System.Windows.Forms.TextBox Box_Mail_Confirm;
        private System.Windows.Forms.TextBox Box_Pass_Confirm;
=======
>>>>>>> 1df17a4e25fe7dd08e7c3598571c7f4795a0b0d6
    }
}

