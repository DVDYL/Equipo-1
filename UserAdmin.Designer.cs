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
            this.Label_ABM_Usuarios = new System.Windows.Forms.Label();
            this.ComboBox_Rol = new System.Windows.Forms.ComboBox();
            this.Label_Tipo_Usuario = new System.Windows.Forms.Label();
            this.ComboBox_ABM = new System.Windows.Forms.ComboBox();
            this.Label_Operacion = new System.Windows.Forms.Label();
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Label_Apellido = new System.Windows.Forms.Label();
            this.Label_Direccion = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Label_DNI = new System.Windows.Forms.Label();
            this.Label_F_Nacimiento = new System.Windows.Forms.Label();
            this.Calendario_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.Label_ConfirmarEmail = new System.Windows.Forms.Label();
            this.Label_Contraseña = new System.Windows.Forms.Label();
            this.Label_ConfirmarContraseña = new System.Windows.Forms.Label();
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
            this.Boton_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(834, 599);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(88, 27);
            this.Boton_Confirmar.TabIndex = 12;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = true;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(980, 599);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(88, 27);
            this.Boton_Cancelar.TabIndex = 13;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Label_ABM_Usuarios
            // 
            this.Label_ABM_Usuarios.AutoSize = true;
            this.Label_ABM_Usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ABM_Usuarios.Location = new System.Drawing.Point(31, 35);
            this.Label_ABM_Usuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ABM_Usuarios.Name = "Label_ABM_Usuarios";
            this.Label_ABM_Usuarios.Size = new System.Drawing.Size(179, 25);
            this.Label_ABM_Usuarios.TabIndex = 20;
            this.Label_ABM_Usuarios.Text = "ABM de Usuarios";
            // 
            // ComboBox_Rol
            // 
            this.ComboBox_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Rol.FormattingEnabled = true;
            this.ComboBox_Rol.Location = new System.Drawing.Point(852, 120);
            this.ComboBox_Rol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_Rol.Name = "ComboBox_Rol";
            this.ComboBox_Rol.Size = new System.Drawing.Size(140, 24);
            this.ComboBox_Rol.TabIndex = 1;
            this.ComboBox_Rol.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Rol_SelectedIndexChanged);
            // 
            // Label_Tipo_Usuario
            // 
            this.Label_Tipo_Usuario.AutoSize = true;
            this.Label_Tipo_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tipo_Usuario.Location = new System.Drawing.Point(632, 123);
            this.Label_Tipo_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Tipo_Usuario.Name = "Label_Tipo_Usuario";
            this.Label_Tipo_Usuario.Size = new System.Drawing.Size(113, 18);
            this.Label_Tipo_Usuario.TabIndex = 4;
            this.Label_Tipo_Usuario.Text = "Tipo de Usuario";
            // 
            // ComboBox_ABM
            // 
            this.ComboBox_ABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_ABM.FormattingEnabled = true;
            this.ComboBox_ABM.Location = new System.Drawing.Point(432, 120);
            this.ComboBox_ABM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_ABM.Name = "ComboBox_ABM";
            this.ComboBox_ABM.Size = new System.Drawing.Size(140, 24);
            this.ComboBox_ABM.TabIndex = 0;
            this.ComboBox_ABM.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ABM_SelectedIndexChanged);
            // 
            // Label_Operacion
            // 
            this.Label_Operacion.AutoSize = true;
            this.Label_Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Operacion.Location = new System.Drawing.Point(239, 123);
            this.Label_Operacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Operacion.Name = "Label_Operacion";
            this.Label_Operacion.Size = new System.Drawing.Size(77, 18);
            this.Label_Operacion.TabIndex = 6;
            this.Label_Operacion.Text = "Operación";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(239, 192);
            this.Label_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(62, 18);
            this.Label_Nombre.TabIndex = 7;
            this.Label_Nombre.Text = "Nombre";
            // 
            // Label_Apellido
            // 
            this.Label_Apellido.AutoSize = true;
            this.Label_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Apellido.Location = new System.Drawing.Point(632, 192);
            this.Label_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Apellido.Name = "Label_Apellido";
            this.Label_Apellido.Size = new System.Drawing.Size(59, 18);
            this.Label_Apellido.TabIndex = 8;
            this.Label_Apellido.Text = "Apellido";
            // 
            // Label_Direccion
            // 
            this.Label_Direccion.AutoSize = true;
            this.Label_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Direccion.Location = new System.Drawing.Point(239, 332);
            this.Label_Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Direccion.Name = "Label_Direccion";
            this.Label_Direccion.Size = new System.Drawing.Size(71, 18);
            this.Label_Direccion.TabIndex = 9;
            this.Label_Direccion.Text = "Dirección";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Telefono.Location = new System.Drawing.Point(632, 332);
            this.Label_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(66, 18);
            this.Label_Telefono.TabIndex = 10;
            this.Label_Telefono.Text = "Teléfono";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(239, 407);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(45, 18);
            this.Label_Email.TabIndex = 11;
            this.Label_Email.Text = "Email";
            // 
            // Label_DNI
            // 
            this.Label_DNI.AutoSize = true;
            this.Label_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DNI.Location = new System.Drawing.Point(239, 261);
            this.Label_DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DNI.Name = "Label_DNI";
            this.Label_DNI.Size = new System.Drawing.Size(33, 18);
            this.Label_DNI.TabIndex = 12;
            this.Label_DNI.Text = "DNI";
            // 
            // Label_F_Nacimiento
            // 
            this.Label_F_Nacimiento.AutoSize = true;
            this.Label_F_Nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_F_Nacimiento.Location = new System.Drawing.Point(632, 261);
            this.Label_F_Nacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_F_Nacimiento.Name = "Label_F_Nacimiento";
            this.Label_F_Nacimiento.Size = new System.Drawing.Size(148, 18);
            this.Label_F_Nacimiento.TabIndex = 13;
            this.Label_F_Nacimiento.Text = "Fecha de Nacimiento";
            // 
            // Calendario_Nacimiento
            // 
            this.Calendario_Nacimiento.Location = new System.Drawing.Point(852, 259);
            this.Calendario_Nacimiento.Name = "Calendario_Nacimiento";
            this.Calendario_Nacimiento.Size = new System.Drawing.Size(140, 20);
            this.Calendario_Nacimiento.TabIndex = 5;
            this.Calendario_Nacimiento.ValueChanged += new System.EventHandler(this.Calendario_Nacimiento_ValueChanged);
            // 
            // Label_ConfirmarEmail
            // 
            this.Label_ConfirmarEmail.AutoSize = true;
            this.Label_ConfirmarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarEmail.Location = new System.Drawing.Point(632, 407);
            this.Label_ConfirmarEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConfirmarEmail.Name = "Label_ConfirmarEmail";
            this.Label_ConfirmarEmail.Size = new System.Drawing.Size(115, 18);
            this.Label_ConfirmarEmail.TabIndex = 16;
            this.Label_ConfirmarEmail.Text = "Confirmar Email";
            // 
            // Label_Contraseña
            // 
            this.Label_Contraseña.AutoSize = true;
            this.Label_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Contraseña.Location = new System.Drawing.Point(239, 485);
            this.Label_Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Contraseña.Name = "Label_Contraseña";
            this.Label_Contraseña.Size = new System.Drawing.Size(85, 18);
            this.Label_Contraseña.TabIndex = 17;
            this.Label_Contraseña.Text = "Contraseña";
            // 
            // Label_ConfirmarContraseña
            // 
            this.Label_ConfirmarContraseña.AutoSize = true;
            this.Label_ConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarContraseña.Location = new System.Drawing.Point(632, 485);
            this.Label_ConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConfirmarContraseña.Name = "Label_ConfirmarContraseña";
            this.Label_ConfirmarContraseña.Size = new System.Drawing.Size(155, 18);
            this.Label_ConfirmarContraseña.TabIndex = 18;
            this.Label_ConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // Box_Nombre
            // 
            this.Box_Nombre.Location = new System.Drawing.Point(432, 191);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(140, 20);
            this.Box_Nombre.TabIndex = 2;
            this.Box_Nombre.TextChanged += new System.EventHandler(this.Box_Nombre_TextChanged);
            // 
            // Box_Apellido
            // 
            this.Box_Apellido.Location = new System.Drawing.Point(852, 193);
            this.Box_Apellido.Name = "Box_Apellido";
            this.Box_Apellido.Size = new System.Drawing.Size(140, 20);
            this.Box_Apellido.TabIndex = 3;
            this.Box_Apellido.TextChanged += new System.EventHandler(this.Box_Apellido_TextChanged);
            // 
            // Box_DNI
            // 
            this.Box_DNI.Location = new System.Drawing.Point(432, 262);
            this.Box_DNI.Name = "Box_DNI";
            this.Box_DNI.Size = new System.Drawing.Size(140, 20);
            this.Box_DNI.TabIndex = 4;
            this.Box_DNI.TextChanged += new System.EventHandler(this.Box_DNI_TextChanged);
            // 
            // Box_Dir
            // 
            this.Box_Dir.Location = new System.Drawing.Point(432, 332);
            this.Box_Dir.Name = "Box_Dir";
            this.Box_Dir.Size = new System.Drawing.Size(140, 20);
            this.Box_Dir.TabIndex = 6;
            // 
            // Box_Mail
            // 
            this.Box_Mail.Location = new System.Drawing.Point(432, 408);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(140, 20);
            this.Box_Mail.TabIndex = 8;
            // 
            // Box_Pass
            // 
            this.Box_Pass.Location = new System.Drawing.Point(432, 486);
            this.Box_Pass.Name = "Box_Pass";
            this.Box_Pass.Size = new System.Drawing.Size(140, 20);
            this.Box_Pass.TabIndex = 10;
            // 
            // Box_Telefono
            // 
            this.Box_Telefono.Location = new System.Drawing.Point(852, 333);
            this.Box_Telefono.Name = "Box_Telefono";
            this.Box_Telefono.Size = new System.Drawing.Size(140, 20);
            this.Box_Telefono.TabIndex = 7;
            // 
            // Box_Mail_Confirm
            // 
            this.Box_Mail_Confirm.Location = new System.Drawing.Point(852, 405);
            this.Box_Mail_Confirm.Name = "Box_Mail_Confirm";
            this.Box_Mail_Confirm.Size = new System.Drawing.Size(140, 20);
            this.Box_Mail_Confirm.TabIndex = 9;
            // 
            // Box_Pass_Confirm
            // 
            this.Box_Pass_Confirm.Location = new System.Drawing.Point(852, 483);
            this.Box_Pass_Confirm.Name = "Box_Pass_Confirm";
            this.Box_Pass_Confirm.Size = new System.Drawing.Size(140, 20);
            this.Box_Pass_Confirm.TabIndex = 11;
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.Add(this.Label_ConfirmarContraseña);
            this.Controls.Add(this.Label_Contraseña);
            this.Controls.Add(this.Label_ConfirmarEmail);
            this.Controls.Add(this.Calendario_Nacimiento);
            this.Controls.Add(this.Label_F_Nacimiento);
            this.Controls.Add(this.Label_DNI);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Label_Telefono);
            this.Controls.Add(this.Label_Direccion);
            this.Controls.Add(this.Label_Apellido);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Label_Operacion);
            this.Controls.Add(this.ComboBox_ABM);
            this.Controls.Add(this.Label_Tipo_Usuario);
            this.Controls.Add(this.ComboBox_Rol);
            this.Controls.Add(this.Label_ABM_Usuarios);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Confirmar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserAdmin";
            this.Text = "ABM de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Label Label_ABM_Usuarios;
        private System.Windows.Forms.ComboBox ComboBox_Rol;
        private System.Windows.Forms.Label Label_Tipo_Usuario;
        private System.Windows.Forms.ComboBox ComboBox_ABM;
        private System.Windows.Forms.Label Label_Operacion;
        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Apellido;
        private System.Windows.Forms.Label Label_Direccion;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.Label Label_DNI;
        private System.Windows.Forms.Label Label_F_Nacimiento;
        private System.Windows.Forms.DateTimePicker Calendario_Nacimiento;
        private System.Windows.Forms.Label Label_ConfirmarEmail;
        private System.Windows.Forms.Label Label_Contraseña;
        private System.Windows.Forms.Label Label_ConfirmarContraseña;
        private System.Windows.Forms.TextBox Box_Nombre;
        private System.Windows.Forms.TextBox Box_Apellido;
        private System.Windows.Forms.TextBox Box_DNI;
        private System.Windows.Forms.TextBox Box_Dir;
        private System.Windows.Forms.TextBox Box_Mail;
        private System.Windows.Forms.TextBox Box_Pass;
        private System.Windows.Forms.TextBox Box_Telefono;
        private System.Windows.Forms.TextBox Box_Mail_Confirm;
        private System.Windows.Forms.TextBox Box_Pass_Confirm;

    }
}

