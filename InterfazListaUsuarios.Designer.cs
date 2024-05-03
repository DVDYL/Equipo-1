namespace Presentacion
{
    partial class InterfazListaUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TituloVentana = new System.Windows.Forms.Label();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.Boton_AltaUsuario = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.DataGridView();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuariosLupa = new System.Windows.Forms.PictureBox();
            this.UsuariosBuscador = new System.Windows.Forms.TextBox();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Box_BuscarDNI = new System.Windows.Forms.TextBox();
            this.LupaDNI = new System.Windows.Forms.PictureBox();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.DNI_Label = new System.Windows.Forms.Label();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloVentana
            // 
            this.TituloVentana.AutoSize = true;
            this.TituloVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloVentana.Location = new System.Drawing.Point(5, 5);
            this.TituloVentana.Name = "TituloVentana";
            this.TituloVentana.Size = new System.Drawing.Size(75, 25);
            this.TituloVentana.TabIndex = 27;
            this.TituloVentana.Text = "DEMO";
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(573, 695);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(190, 42);
            this.Boton_Salir.TabIndex = 5;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Boton_AltaUsuario
            // 
            this.Boton_AltaUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_AltaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_AltaUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_AltaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_AltaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_AltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_AltaUsuario.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaUsuario.Location = new System.Drawing.Point(610, 100);
            this.Boton_AltaUsuario.Name = "Boton_AltaUsuario";
            this.Boton_AltaUsuario.Size = new System.Drawing.Size(157, 49);
            this.Boton_AltaUsuario.TabIndex = 3;
            this.Boton_AltaUsuario.Text = "+ Nuevo";
            this.Boton_AltaUsuario.UseVisualStyleBackColor = false;
            this.Boton_AltaUsuario.Click += new System.EventHandler(this.Boton_AltaUsuario_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.AllowUserToAddRows = false;
            this.Usuarios.AllowUserToDeleteRows = false;
            this.Usuarios.AllowUserToResizeColumns = false;
            this.Usuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.Usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Usuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Usuarios.ColumnHeadersHeight = 25;
            this.Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueba});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.DefaultCellStyle = dataGridViewCellStyle8;
            this.Usuarios.EnableHeadersVisualStyles = false;
            this.Usuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usuarios.Location = new System.Drawing.Point(25, 215);
            this.Usuarios.MultiSelect = false;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            this.Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Usuarios.RowHeadersWidth = 15;
            this.Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.Usuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.RowTemplate.Height = 40;
            this.Usuarios.RowTemplate.ReadOnly = true;
            this.Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuarios.Size = new System.Drawing.Size(750, 451);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Usuarios_CellContentClick);
            // 
            // Prueba
            // 
            this.Prueba.Frozen = true;
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            this.Prueba.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Prueba.Width = 48;
            // 
            // UsuariosLupa
            // 
            this.UsuariosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.UsuariosLupa.Location = new System.Drawing.Point(535, 72);
            this.UsuariosLupa.Name = "UsuariosLupa";
            this.UsuariosLupa.Size = new System.Drawing.Size(49, 34);
            this.UsuariosLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsuariosLupa.TabIndex = 28;
            this.UsuariosLupa.TabStop = false;
            this.UsuariosLupa.Click += new System.EventHandler(this.UsuariosLupa_Click);
            // 
            // UsuariosBuscador
            // 
            this.UsuariosBuscador.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosBuscador.Location = new System.Drawing.Point(238, 72);
            this.UsuariosBuscador.Name = "UsuariosBuscador";
            this.UsuariosBuscador.Size = new System.Drawing.Size(278, 32);
            this.UsuariosBuscador.TabIndex = 1;
            this.UsuariosBuscador.Enter += new System.EventHandler(this.UsuariosLupa_Click);
            // 
            // BorrarFiltro
            // 
            this.BorrarFiltro.BackColor = System.Drawing.Color.Khaki;
            this.BorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarFiltro.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFiltro.Location = new System.Drawing.Point(129, 695);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(193, 42);
            this.BorrarFiltro.TabIndex = 4;
            this.BorrarFiltro.Text = "Borrar Filtros";
            this.BorrarFiltro.UseVisualStyleBackColor = false;
            this.BorrarFiltro.Click += new System.EventHandler(this.BorrarFiltro_Click);
            // 
            // Box_BuscarDNI
            // 
            this.Box_BuscarDNI.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_BuscarDNI.Location = new System.Drawing.Point(238, 140);
            this.Box_BuscarDNI.Name = "Box_BuscarDNI";
            this.Box_BuscarDNI.Size = new System.Drawing.Size(278, 32);
            this.Box_BuscarDNI.TabIndex = 2;
            this.Box_BuscarDNI.Enter += new System.EventHandler(this.UsuariosLupa_Click);
            // 
            // LupaDNI
            // 
            this.LupaDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LupaDNI.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.LupaDNI.Location = new System.Drawing.Point(535, 140);
            this.LupaDNI.Name = "LupaDNI";
            this.LupaDNI.Size = new System.Drawing.Size(49, 34);
            this.LupaDNI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LupaDNI.TabIndex = 32;
            this.LupaDNI.TabStop = false;
            this.LupaDNI.Click += new System.EventHandler(this.LupaDNI_Click);
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Label.Location = new System.Drawing.Point(19, 73);
            this.Nombre_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(164, 28);
            this.Nombre_Label.TabIndex = 34;
            this.Nombre_Label.Text = "Buscar Nombre";
            // 
            // DNI_Label
            // 
            this.DNI_Label.AutoSize = true;
            this.DNI_Label.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI_Label.Location = new System.Drawing.Point(19, 144);
            this.DNI_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNI_Label.Name = "DNI_Label";
            this.DNI_Label.Size = new System.Drawing.Size(162, 28);
            this.DNI_Label.TabIndex = 35;
            this.DNI_Label.Text = "Buscar por DNI";
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Nunito", 20.25F);
            this.Boton_Eliminar.Location = new System.Drawing.Point(372, 695);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(161, 42);
            this.Boton_Eliminar.TabIndex = 36;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // InterfazListaUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.DNI_Label);
            this.Controls.Add(this.Nombre_Label);
            this.Controls.Add(this.Box_BuscarDNI);
            this.Controls.Add(this.LupaDNI);
            this.Controls.Add(this.BorrarFiltro);
            this.Controls.Add(this.UsuariosBuscador);
            this.Controls.Add(this.UsuariosLupa);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.TituloVentana);
            this.Controls.Add(this.Boton_AltaUsuario);
            this.Name = "InterfazListaUsuarios";
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.InterfazListaUsuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Boton_AltaUsuario;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Label TituloVentana;
        private System.Windows.Forms.DataGridView Usuarios;
        private System.Windows.Forms.PictureBox UsuariosLupa;
        private System.Windows.Forms.TextBox UsuariosBuscador;
        private System.Windows.Forms.Button BorrarFiltro;
        private System.Windows.Forms.TextBox Box_BuscarDNI;
        private System.Windows.Forms.PictureBox LupaDNI;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.Label DNI_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.Button Boton_Eliminar;
    }
}