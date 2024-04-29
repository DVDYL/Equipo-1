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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Boton_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(569, 823);
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
            this.Boton_AltaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaUsuario.Location = new System.Drawing.Point(620, 100);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Usuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Usuarios.ColumnHeadersHeight = 25;
            this.Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueba});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.Usuarios.EnableHeadersVisualStyles = false;
            this.Usuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usuarios.Location = new System.Drawing.Point(25, 200);
            this.Usuarios.MultiSelect = false;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            this.Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Usuarios.RowHeadersWidth = 15;
            this.Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Usuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.RowTemplate.Height = 40;
            this.Usuarios.RowTemplate.ReadOnly = true;
            this.Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuarios.Size = new System.Drawing.Size(750, 570);
            this.Usuarios.TabIndex = 0;
            // 
            // Prueba
            // 
            this.Prueba.Frozen = true;
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            this.Prueba.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Prueba.Width = 47;
            // 
            // UsuariosLupa
            // 
            this.UsuariosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosLupa.Image = global::Presentacion.Properties.Resources.lupa_fuerte;
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
            this.UsuariosBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosBuscador.Location = new System.Drawing.Point(238, 72);
            this.UsuariosBuscador.Name = "UsuariosBuscador";
            this.UsuariosBuscador.Size = new System.Drawing.Size(278, 29);
            this.UsuariosBuscador.TabIndex = 1;
            this.UsuariosBuscador.Enter += new System.EventHandler(this.UsuariosLupa_Click);
            // 
            // BorrarFiltro
            // 
            this.BorrarFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFiltro.Location = new System.Drawing.Point(325, 823);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(193, 42);
            this.BorrarFiltro.TabIndex = 4;
            this.BorrarFiltro.Text = "Borrar Filtros";
            this.BorrarFiltro.UseVisualStyleBackColor = false;
            this.BorrarFiltro.Click += new System.EventHandler(this.BorrarFiltro_Click);
            // 
            // Box_BuscarDNI
            // 
            this.Box_BuscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_BuscarDNI.Location = new System.Drawing.Point(238, 140);
            this.Box_BuscarDNI.Name = "Box_BuscarDNI";
            this.Box_BuscarDNI.Size = new System.Drawing.Size(278, 29);
            this.Box_BuscarDNI.TabIndex = 2;
            this.Box_BuscarDNI.Enter += new System.EventHandler(this.UsuariosLupa_Click);
            // 
            // LupaDNI
            // 
            this.LupaDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LupaDNI.Image = global::Presentacion.Properties.Resources.lupa_fuerte;
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
            this.Nombre_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Nombre_Label.Location = new System.Drawing.Point(19, 73);
            this.Nombre_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(197, 25);
            this.Nombre_Label.TabIndex = 34;
            this.Nombre_Label.Text = "Buscar por Nombre";
            // 
            // DNI_Label
            // 
            this.DNI_Label.AutoSize = true;
            this.DNI_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI_Label.Location = new System.Drawing.Point(19, 144);
            this.DNI_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNI_Label.Name = "DNI_Label";
            this.DNI_Label.Size = new System.Drawing.Size(157, 25);
            this.DNI_Label.TabIndex = 35;
            this.DNI_Label.Text = "Buscar por DNI";
            // 
            // InterfazListaUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(800, 788);
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
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
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
    }
}