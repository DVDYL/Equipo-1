namespace Presentacion
{
    partial class InterfazListaProveedores
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
            this.Proveedores = new System.Windows.Forms.DataGridView();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.Boton_AltaUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.BuscadorCUIT = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProveedoresBuscador = new System.Windows.Forms.TextBox();
            this.UsuariosLupa = new System.Windows.Forms.PictureBox();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.AllowUserToAddRows = false;
            this.Proveedores.AllowUserToDeleteRows = false;
            this.Proveedores.AllowUserToResizeColumns = false;
            this.Proveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Proveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Proveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Proveedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueba});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Proveedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.Proveedores.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Proveedores.Location = new System.Drawing.Point(24, 204);
            this.Proveedores.MultiSelect = false;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.ReadOnly = true;
            this.Proveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Proveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Proveedores.RowHeadersWidth = 15;
            this.Proveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Proveedores.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.RowTemplate.Height = 40;
            this.Proveedores.RowTemplate.ReadOnly = true;
            this.Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Proveedores.Size = new System.Drawing.Size(753, 569);
            this.Proveedores.TabIndex = 1;
            this.Proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Proveedores_CellContentClick);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(571, 829);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(190, 42);
            this.Boton_Salir.TabIndex = 28;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Boton_AltaUsuario
            // 
            this.Boton_AltaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_AltaUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_AltaUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_AltaUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_AltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_AltaUsuario.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaUsuario.Location = new System.Drawing.Point(611, 91);
            this.Boton_AltaUsuario.Name = "Boton_AltaUsuario";
            this.Boton_AltaUsuario.Size = new System.Drawing.Size(157, 49);
            this.Boton_AltaUsuario.TabIndex = 27;
            this.Boton_AltaUsuario.Text = "+ Nuevo";
            this.Boton_AltaUsuario.UseVisualStyleBackColor = true;
            this.Boton_AltaUsuario.Click += new System.EventHandler(this.Boton_AltaUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Buscar por CUIT";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(27, 75);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(202, 28);
            this.Label_Email.TabIndex = 40;
            this.Label_Email.Text = "Buscar por Nombre";
            // 
            // BuscadorCUIT
            // 
            this.BuscadorCUIT.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscadorCUIT.Location = new System.Drawing.Point(246, 131);
            this.BuscadorCUIT.Name = "BuscadorCUIT";
            this.BuscadorCUIT.Size = new System.Drawing.Size(278, 32);
            this.BuscadorCUIT.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.pictureBox1.Location = new System.Drawing.Point(543, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.LupaBuscar_Click);
            // 
            // ProveedoresBuscador
            // 
            this.ProveedoresBuscador.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedoresBuscador.Location = new System.Drawing.Point(246, 74);
            this.ProveedoresBuscador.Name = "ProveedoresBuscador";
            this.ProveedoresBuscador.Size = new System.Drawing.Size(278, 32);
            this.ProveedoresBuscador.TabIndex = 37;
            // 
            // UsuariosLupa
            // 
            this.UsuariosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.UsuariosLupa.Location = new System.Drawing.Point(543, 74);
            this.UsuariosLupa.Name = "UsuariosLupa";
            this.UsuariosLupa.Size = new System.Drawing.Size(49, 34);
            this.UsuariosLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsuariosLupa.TabIndex = 36;
            this.UsuariosLupa.TabStop = false;
            this.UsuariosLupa.Click += new System.EventHandler(this.ProveedoresLupa_Click);
            // 
            // BorrarFiltro
            // 
            this.BorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarFiltro.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFiltro.Location = new System.Drawing.Point(321, 829);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(194, 42);
            this.BorrarFiltro.TabIndex = 42;
            this.BorrarFiltro.Text = "Borrar Filtros";
            this.BorrarFiltro.UseVisualStyleBackColor = true;
            this.BorrarFiltro.Click += new System.EventHandler(this.BorrarFiltro_Click);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Modificar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Modificar.Location = new System.Drawing.Point(79, 829);
            this.Boton_Modificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(190, 42);
            this.Boton_Modificar.TabIndex = 43;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            // 
            // Prueba
            // 
            this.Prueba.Frozen = true;
            this.Prueba.HeaderText = "Acciones";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            this.Prueba.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prueba.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Prueba.Width = 105;
            // 
            // InterfazListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.BorrarFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.BuscadorCUIT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProveedoresBuscador);
            this.Controls.Add(this.UsuariosLupa);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.Boton_AltaUsuario);
            this.Controls.Add(this.Proveedores);
            this.Name = "InterfazListaProveedores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfazListaProveedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Proveedores;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Button Boton_AltaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.TextBox BuscadorCUIT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ProveedoresBuscador;
        private System.Windows.Forms.PictureBox UsuariosLupa;
        private System.Windows.Forms.Button BorrarFiltro;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
    }
}