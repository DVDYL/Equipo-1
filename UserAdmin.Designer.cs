﻿namespace Equipo1
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
            this.Label_Calle = new System.Windows.Forms.Label();
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
            this.Box_Calle = new System.Windows.Forms.TextBox();
            this.Box_Mail = new System.Windows.Forms.TextBox();
            this.Box_Pass = new System.Windows.Forms.TextBox();
            this.Box_Telefono = new System.Windows.Forms.TextBox();
            this.Box_Mail_Confirm = new System.Windows.Forms.TextBox();
            this.Box_Pass_Confirm = new System.Windows.Forms.TextBox();
            this.Label_Altura = new System.Windows.Forms.Label();
            this.Label_Departamento = new System.Windows.Forms.Label();
            this.Box_Altura = new System.Windows.Forms.TextBox();
            this.Box_Depto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Boton_Confirmar.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(1530, 792);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(88, 27);
            this.Boton_Confirmar.TabIndex = 14;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = true;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(1658, 791);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(88, 27);
            this.Boton_Cancelar.TabIndex = 15;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = true;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Cancelar_Click);
            // 
            // Label_ABM_Usuarios
            // 
            this.Label_ABM_Usuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_ABM_Usuarios.AutoSize = true;
            this.Label_ABM_Usuarios.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ABM_Usuarios.Location = new System.Drawing.Point(53, 31);
            this.Label_ABM_Usuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ABM_Usuarios.Name = "Label_ABM_Usuarios";
            this.Label_ABM_Usuarios.Size = new System.Drawing.Size(185, 28);
            this.Label_ABM_Usuarios.TabIndex = 20;
            this.Label_ABM_Usuarios.Text = "ABM de Usuarios";
            // 
            // ComboBox_Rol
            // 
            this.ComboBox_Rol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_Rol.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Rol.FormattingEnabled = true;
            this.ComboBox_Rol.Location = new System.Drawing.Point(779, 111);
            this.ComboBox_Rol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_Rol.Name = "ComboBox_Rol";
            this.ComboBox_Rol.Size = new System.Drawing.Size(140, 25);
            this.ComboBox_Rol.TabIndex = 1;
            // 
            // Label_Tipo_Usuario
            // 
            this.Label_Tipo_Usuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Tipo_Usuario.AutoSize = true;
            this.Label_Tipo_Usuario.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Tipo_Usuario.Location = new System.Drawing.Point(559, 113);
            this.Label_Tipo_Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Tipo_Usuario.Name = "Label_Tipo_Usuario";
            this.Label_Tipo_Usuario.Size = new System.Drawing.Size(122, 20);
            this.Label_Tipo_Usuario.TabIndex = 4;
            this.Label_Tipo_Usuario.Text = "Tipo de Usuario";
            // 
            // ComboBox_ABM
            // 
            this.ComboBox_ABM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBox_ABM.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_ABM.FormattingEnabled = true;
            this.ComboBox_ABM.Location = new System.Drawing.Point(359, 111);
            this.ComboBox_ABM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBox_ABM.Name = "ComboBox_ABM";
            this.ComboBox_ABM.Size = new System.Drawing.Size(140, 25);
            this.ComboBox_ABM.TabIndex = 0;
            this.ComboBox_ABM.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ABM_SelectedIndexChanged);
            // 
            // Label_Operacion
            // 
            this.Label_Operacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Operacion.AutoSize = true;
            this.Label_Operacion.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Operacion.Location = new System.Drawing.Point(166, 113);
            this.Label_Operacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Operacion.Name = "Label_Operacion";
            this.Label_Operacion.Size = new System.Drawing.Size(81, 20);
            this.Label_Operacion.TabIndex = 6;
            this.Label_Operacion.Text = "Operación";
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre.Location = new System.Drawing.Point(166, 244);
            this.Label_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(66, 20);
            this.Label_Nombre.TabIndex = 7;
            this.Label_Nombre.Text = "Nombre";
            // 
            // Label_Apellido
            // 
            this.Label_Apellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Apellido.AutoSize = true;
            this.Label_Apellido.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Apellido.Location = new System.Drawing.Point(559, 243);
            this.Label_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Apellido.Name = "Label_Apellido";
            this.Label_Apellido.Size = new System.Drawing.Size(67, 20);
            this.Label_Apellido.TabIndex = 8;
            this.Label_Apellido.Text = "Apellido";
            // 
            // Label_Calle
            // 
            this.Label_Calle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Calle.AutoSize = true;
            this.Label_Calle.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Calle.Location = new System.Drawing.Point(166, 375);
            this.Label_Calle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Calle.Name = "Label_Calle";
            this.Label_Calle.Size = new System.Drawing.Size(43, 20);
            this.Label_Calle.TabIndex = 9;
            this.Label_Calle.Text = "Calle";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Telefono.Location = new System.Drawing.Point(1366, 374);
            this.Label_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(71, 20);
            this.Label_Telefono.TabIndex = 10;
            this.Label_Telefono.Text = "Teléfono";
            // 
            // Label_Email
            // 
            this.Label_Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(166, 506);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(48, 20);
            this.Label_Email.TabIndex = 11;
            this.Label_Email.Text = "Email";
            // 
            // Label_DNI
            // 
            this.Label_DNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_DNI.AutoSize = true;
            this.Label_DNI.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_DNI.Location = new System.Drawing.Point(1008, 243);
            this.Label_DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_DNI.Name = "Label_DNI";
            this.Label_DNI.Size = new System.Drawing.Size(36, 20);
            this.Label_DNI.TabIndex = 12;
            this.Label_DNI.Text = "DNI";
            // 
            // Label_F_Nacimiento
            // 
            this.Label_F_Nacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_F_Nacimiento.AutoSize = true;
            this.Label_F_Nacimiento.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_F_Nacimiento.Location = new System.Drawing.Point(1366, 243);
            this.Label_F_Nacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_F_Nacimiento.Name = "Label_F_Nacimiento";
            this.Label_F_Nacimiento.Size = new System.Drawing.Size(156, 20);
            this.Label_F_Nacimiento.TabIndex = 13;
            this.Label_F_Nacimiento.Text = "Fecha de Nacimiento";
            // 
            // Calendario_Nacimiento
            // 
            this.Calendario_Nacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Calendario_Nacimiento.Location = new System.Drawing.Point(1566, 242);
            this.Calendario_Nacimiento.Name = "Calendario_Nacimiento";
            this.Calendario_Nacimiento.Size = new System.Drawing.Size(140, 22);
            this.Calendario_Nacimiento.TabIndex = 5;
            this.Calendario_Nacimiento.ValueChanged += new System.EventHandler(this.Calendario_Nacimiento_ValueChanged);
            // 
            // Label_ConfirmarEmail
            // 
            this.Label_ConfirmarEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_ConfirmarEmail.AutoSize = true;
            this.Label_ConfirmarEmail.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarEmail.Location = new System.Drawing.Point(559, 506);
            this.Label_ConfirmarEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConfirmarEmail.Name = "Label_ConfirmarEmail";
            this.Label_ConfirmarEmail.Size = new System.Drawing.Size(124, 20);
            this.Label_ConfirmarEmail.TabIndex = 16;
            this.Label_ConfirmarEmail.Text = "Confirmar Email";
            // 
            // Label_Contraseña
            // 
            this.Label_Contraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Contraseña.AutoSize = true;
            this.Label_Contraseña.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Contraseña.Location = new System.Drawing.Point(166, 637);
            this.Label_Contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Contraseña.Name = "Label_Contraseña";
            this.Label_Contraseña.Size = new System.Drawing.Size(89, 20);
            this.Label_Contraseña.TabIndex = 17;
            this.Label_Contraseña.Text = "Contraseña";
            // 
            // Label_ConfirmarContraseña
            // 
            this.Label_ConfirmarContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_ConfirmarContraseña.AutoSize = true;
            this.Label_ConfirmarContraseña.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarContraseña.Location = new System.Drawing.Point(559, 640);
            this.Label_ConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ConfirmarContraseña.Name = "Label_ConfirmarContraseña";
            this.Label_ConfirmarContraseña.Size = new System.Drawing.Size(165, 20);
            this.Label_ConfirmarContraseña.TabIndex = 18;
            this.Label_ConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // Box_Nombre
            // 
            this.Box_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Nombre.Location = new System.Drawing.Point(359, 242);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(140, 22);
            this.Box_Nombre.TabIndex = 2;
            this.Box_Nombre.TextChanged += new System.EventHandler(this.Box_Nombre_TextChanged);
            // 
            // Box_Apellido
            // 
            this.Box_Apellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Apellido.Location = new System.Drawing.Point(779, 242);
            this.Box_Apellido.Name = "Box_Apellido";
            this.Box_Apellido.Size = new System.Drawing.Size(140, 22);
            this.Box_Apellido.TabIndex = 3;
            this.Box_Apellido.TextChanged += new System.EventHandler(this.Box_Apellido_TextChanged);
            // 
            // Box_DNI
            // 
            this.Box_DNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_DNI.Location = new System.Drawing.Point(1149, 242);
            this.Box_DNI.Name = "Box_DNI";
            this.Box_DNI.Size = new System.Drawing.Size(140, 22);
            this.Box_DNI.TabIndex = 4;
            this.Box_DNI.TextChanged += new System.EventHandler(this.Box_DNI_TextChanged);
            // 
            // Box_Calle
            // 
            this.Box_Calle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Calle.Location = new System.Drawing.Point(359, 373);
            this.Box_Calle.Name = "Box_Calle";
            this.Box_Calle.Size = new System.Drawing.Size(140, 22);
            this.Box_Calle.TabIndex = 6;
            this.Box_Calle.TextChanged += new System.EventHandler(this.Box_Calle_TextChanged);
            // 
            // Box_Mail
            // 
            this.Box_Mail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Mail.Location = new System.Drawing.Point(359, 507);
            this.Box_Mail.Name = "Box_Mail";
            this.Box_Mail.Size = new System.Drawing.Size(140, 22);
            this.Box_Mail.TabIndex = 10;
            this.Box_Mail.TextChanged += new System.EventHandler(this.Box_Mail_TextChanged);
            // 
            // Box_Pass
            // 
            this.Box_Pass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Pass.Location = new System.Drawing.Point(359, 641);
            this.Box_Pass.Name = "Box_Pass";
            this.Box_Pass.Size = new System.Drawing.Size(140, 22);
            this.Box_Pass.TabIndex = 12;
            // 
            // Box_Telefono
            // 
            this.Box_Telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Telefono.Location = new System.Drawing.Point(1566, 373);
            this.Box_Telefono.Name = "Box_Telefono";
            this.Box_Telefono.Size = new System.Drawing.Size(140, 22);
            this.Box_Telefono.TabIndex = 9;
            // 
            // Box_Mail_Confirm
            // 
            this.Box_Mail_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Mail_Confirm.Location = new System.Drawing.Point(779, 504);
            this.Box_Mail_Confirm.Name = "Box_Mail_Confirm";
            this.Box_Mail_Confirm.Size = new System.Drawing.Size(140, 22);
            this.Box_Mail_Confirm.TabIndex = 11;
            // 
            // Box_Pass_Confirm
            // 
            this.Box_Pass_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Pass_Confirm.Location = new System.Drawing.Point(779, 638);
            this.Box_Pass_Confirm.Name = "Box_Pass_Confirm";
            this.Box_Pass_Confirm.Size = new System.Drawing.Size(140, 22);
            this.Box_Pass_Confirm.TabIndex = 13;
            // 
            // Label_Altura
            // 
            this.Label_Altura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Altura.AutoSize = true;
            this.Label_Altura.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Altura.Location = new System.Drawing.Point(559, 374);
            this.Label_Altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Altura.Name = "Label_Altura";
            this.Label_Altura.Size = new System.Drawing.Size(52, 20);
            this.Label_Altura.TabIndex = 21;
            this.Label_Altura.Text = "Altura";
            // 
            // Label_Departamento
            // 
            this.Label_Departamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_Departamento.AutoSize = true;
            this.Label_Departamento.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Departamento.Location = new System.Drawing.Point(1008, 374);
            this.Label_Departamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Departamento.Name = "Label_Departamento";
            this.Label_Departamento.Size = new System.Drawing.Size(109, 20);
            this.Label_Departamento.TabIndex = 22;
            this.Label_Departamento.Text = "Departamento";
            // 
            // Box_Altura
            // 
            this.Box_Altura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Altura.Location = new System.Drawing.Point(779, 373);
            this.Box_Altura.Name = "Box_Altura";
            this.Box_Altura.Size = new System.Drawing.Size(140, 22);
            this.Box_Altura.TabIndex = 7;
            this.Box_Altura.TextChanged += new System.EventHandler(this.Box_Altura_TextChanged);
            // 
            // Box_Depto
            // 
            this.Box_Depto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Depto.Location = new System.Drawing.Point(1149, 373);
            this.Box_Depto.Name = "Box_Depto";
            this.Box_Depto.Size = new System.Drawing.Size(140, 22);
            this.Box_Depto.TabIndex = 8;
            this.Box_Depto.TextChanged += new System.EventHandler(this.Box_Depto_TextChanged);
            // 
            // UserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 850);
            this.Controls.Add(this.Box_Depto);
            this.Controls.Add(this.Box_Altura);
            this.Controls.Add(this.Label_Departamento);
            this.Controls.Add(this.Label_Altura);
            this.Controls.Add(this.Box_Pass_Confirm);
            this.Controls.Add(this.Box_Mail_Confirm);
            this.Controls.Add(this.Box_Telefono);
            this.Controls.Add(this.Box_Pass);
            this.Controls.Add(this.Box_Mail);
            this.Controls.Add(this.Box_Calle);
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
            this.Controls.Add(this.Label_Calle);
            this.Controls.Add(this.Label_Apellido);
            this.Controls.Add(this.Label_Nombre);
            this.Controls.Add(this.Label_Operacion);
            this.Controls.Add(this.ComboBox_ABM);
            this.Controls.Add(this.Label_Tipo_Usuario);
            this.Controls.Add(this.ComboBox_Rol);
            this.Controls.Add(this.Label_ABM_Usuarios);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_Confirmar);
            this.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label Label_Calle;
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
        private System.Windows.Forms.TextBox Box_Calle;
        private System.Windows.Forms.TextBox Box_Mail;
        private System.Windows.Forms.TextBox Box_Pass;
        private System.Windows.Forms.TextBox Box_Telefono;
        private System.Windows.Forms.TextBox Box_Mail_Confirm;
        private System.Windows.Forms.TextBox Box_Pass_Confirm;
        private System.Windows.Forms.Label Label_Altura;
        private System.Windows.Forms.Label Label_Departamento;
        private System.Windows.Forms.TextBox Box_Altura;
        private System.Windows.Forms.TextBox Box_Depto;
    }
}

