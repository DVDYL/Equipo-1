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
            this.UsuariosLupa = new System.Windows.Forms.PictureBox();
            this.UsuariosBuscador = new System.Windows.Forms.TextBox();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Box_BuscarDNI = new System.Windows.Forms.TextBox();
            this.LupaDNI = new System.Windows.Forms.PictureBox();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.DNI_Label = new System.Windows.Forms.Label();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Boton_Salir.Location = new System.Drawing.Point(1167, 696);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(150, 40);
            this.Boton_Salir.TabIndex = 6;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Boton_AltaUsuario
            // 
            this.Boton_AltaUsuario.BackColor = System.Drawing.Color.White;
            this.Boton_AltaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_AltaUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_AltaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_AltaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_AltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_AltaUsuario.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaUsuario.Location = new System.Drawing.Point(1150, 75);
            this.Boton_AltaUsuario.Name = "Boton_AltaUsuario";
            this.Boton_AltaUsuario.Size = new System.Drawing.Size(134, 40);
            this.Boton_AltaUsuario.TabIndex = 3;
            this.Boton_AltaUsuario.Text = "Crear";
            this.Boton_AltaUsuario.UseVisualStyleBackColor = false;
            this.Boton_AltaUsuario.Click += new System.EventHandler(this.Boton_AltaUsuario_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.AllowUserToAddRows = false;
            this.Usuarios.AllowUserToDeleteRows = false;
            this.Usuarios.AllowUserToResizeColumns = false;
            this.Usuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Usuarios.BackgroundColor = System.Drawing.Color.White;
            this.Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Usuarios.ColumnHeadersHeight = 40;
            this.Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.Usuarios.EnableHeadersVisualStyles = false;
            this.Usuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Usuarios.Location = new System.Drawing.Point(42, 150);
            this.Usuarios.MultiSelect = false;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            this.Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Usuarios.RowHeadersWidth = 15;
            this.Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Usuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarios.RowTemplate.Height = 40;
            this.Usuarios.RowTemplate.ReadOnly = true;
            this.Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuarios.Size = new System.Drawing.Size(1253, 505);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Listado_RowHeaderMouseClick);
            // 
            // UsuariosLupa
            // 
            this.UsuariosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.UsuariosLupa.Location = new System.Drawing.Point(457, 79);
            this.UsuariosLupa.Name = "UsuariosLupa";
            this.UsuariosLupa.Size = new System.Drawing.Size(49, 34);
            this.UsuariosLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsuariosLupa.TabIndex = 28;
            this.UsuariosLupa.TabStop = false;
            this.UsuariosLupa.Click += new System.EventHandler(this.UsuariosLupa_Click);
            // 
            // UsuariosBuscador
            // 
            this.UsuariosBuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.UsuariosBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuariosBuscador.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosBuscador.Location = new System.Drawing.Point(231, 81);
            this.UsuariosBuscador.Name = "UsuariosBuscador";
            this.UsuariosBuscador.Size = new System.Drawing.Size(220, 31);
            this.UsuariosBuscador.TabIndex = 1;
            // 
            // BorrarFiltro
            // 
            this.BorrarFiltro.BackColor = System.Drawing.Color.White;
            this.BorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarFiltro.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFiltro.Location = new System.Drawing.Point(26, 696);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(185, 35);
            this.BorrarFiltro.TabIndex = 4;
            this.BorrarFiltro.Text = "Borrar Filtros";
            this.BorrarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarFiltro.UseVisualStyleBackColor = true;
            this.BorrarFiltro.Click += new System.EventHandler(this.BorrarFiltro_Click);
            // 
            // Box_BuscarDNI
            // 
            this.Box_BuscarDNI.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_BuscarDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_BuscarDNI.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_BuscarDNI.Location = new System.Drawing.Point(797, 82);
            this.Box_BuscarDNI.Name = "Box_BuscarDNI";
            this.Box_BuscarDNI.Size = new System.Drawing.Size(220, 31);
            this.Box_BuscarDNI.TabIndex = 2;
            // 
            // LupaDNI
            // 
            this.LupaDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LupaDNI.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.LupaDNI.Location = new System.Drawing.Point(1023, 80);
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
            this.Nombre_Label.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Label.Location = new System.Drawing.Point(36, 80);
            this.Nombre_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(184, 32);
            this.Nombre_Label.TabIndex = 34;
            this.Nombre_Label.Text = "Buscar Usuario";
            // 
            // DNI_Label
            // 
            this.DNI_Label.AutoSize = true;
            this.DNI_Label.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI_Label.Location = new System.Drawing.Point(602, 81);
            this.DNI_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNI_Label.Name = "DNI_Label";
            this.DNI_Label.Size = new System.Drawing.Size(185, 32);
            this.DNI_Label.TabIndex = 35;
            this.DNI_Label.Text = "Buscar por DNI";
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Boton_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Nunito", 20.25F);
            this.Boton_Eliminar.Location = new System.Drawing.Point(939, 696);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(150, 40);
            this.Boton_Eliminar.TabIndex = 5;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Trash;
            this.pictureBox1.Location = new System.Drawing.Point(30, 700);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // InterfazListaUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
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
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}