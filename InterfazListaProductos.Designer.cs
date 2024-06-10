namespace Presentacion
{
    partial class InterfazListaProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.ProductoDescripcion = new System.Windows.Forms.Label();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.ProductoBuscador = new System.Windows.Forms.TextBox();
            this.ProductosLupa = new System.Windows.Forms.PictureBox();
            this.Boton_AltaProducto = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.DataGridView();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Modificar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Modificar.Location = new System.Drawing.Point(789, 696);
            this.Boton_Modificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(150, 40);
            this.Boton_Modificar.TabIndex = 5;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // BorrarFiltro
            // 
            this.BorrarFiltro.BackColor = System.Drawing.Color.White;
            this.BorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarFiltro.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFiltro.Location = new System.Drawing.Point(35, 696);
            this.BorrarFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(185, 35);
            this.BorrarFiltro.TabIndex = 4;
            this.BorrarFiltro.Text = "Borrar Filtros";
            this.BorrarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarFiltro.UseVisualStyleBackColor = false;
            this.BorrarFiltro.Click += new System.EventHandler(this.BorrarFiltro_Click);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(1180, 696);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(150, 40);
            this.Boton_Salir.TabIndex = 7;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // ProductoDescripcion
            // 
            this.ProductoDescripcion.AutoSize = true;
            this.ProductoDescripcion.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoDescripcion.Location = new System.Drawing.Point(655, 81);
            this.ProductoDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoDescripcion.Name = "ProductoDescripcion";
            this.ProductoDescripcion.Size = new System.Drawing.Size(240, 32);
            this.ProductoDescripcion.TabIndex = 53;
            this.ProductoDescripcion.Text = "Filtrar por Categoría";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.Location = new System.Drawing.Point(62, 81);
            this.ProductoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(200, 32);
            this.ProductoLabel.TabIndex = 52;
            this.ProductoLabel.Text = "Buscar Producto";
            // 
            // ProductoBuscador
            // 
            this.ProductoBuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.ProductoBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductoBuscador.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoBuscador.Location = new System.Drawing.Point(266, 82);
            this.ProductoBuscador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductoBuscador.Name = "ProductoBuscador";
            this.ProductoBuscador.Size = new System.Drawing.Size(220, 31);
            this.ProductoBuscador.TabIndex = 1;
            // 
            // ProductosLupa
            // 
            this.ProductosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductosLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.ProductosLupa.Location = new System.Drawing.Point(494, 81);
            this.ProductosLupa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductosLupa.Name = "ProductosLupa";
            this.ProductosLupa.Size = new System.Drawing.Size(49, 33);
            this.ProductosLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductosLupa.TabIndex = 48;
            this.ProductosLupa.TabStop = false;
            this.ProductosLupa.Click += new System.EventHandler(this.ProductosLupa_Click);
            // 
            // Boton_AltaProducto
            // 
            this.Boton_AltaProducto.BackColor = System.Drawing.Color.White;
            this.Boton_AltaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_AltaProducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_AltaProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_AltaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_AltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_AltaProducto.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaProducto.Location = new System.Drawing.Point(1150, 77);
            this.Boton_AltaProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_AltaProducto.Name = "Boton_AltaProducto";
            this.Boton_AltaProducto.Size = new System.Drawing.Size(135, 40);
            this.Boton_AltaProducto.TabIndex = 3;
            this.Boton_AltaProducto.Text = "Crear";
            this.Boton_AltaProducto.UseVisualStyleBackColor = false;
            this.Boton_AltaProducto.Click += new System.EventHandler(this.Boton_AltaProducto_Click);
            // 
            // Productos
            // 
            this.Productos.AllowUserToAddRows = false;
            this.Productos.AllowUserToDeleteRows = false;
            this.Productos.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.Productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Productos.BackgroundColor = System.Drawing.Color.White;
            this.Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Productos.ColumnHeadersHeight = 40;
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Productos.DefaultCellStyle = dataGridViewCellStyle18;
            this.Productos.EnableHeadersVisualStyles = false;
            this.Productos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Productos.Location = new System.Drawing.Point(50, 148);
            this.Productos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Productos.MultiSelect = false;
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.Productos.RowHeadersWidth = 15;
            this.Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.Productos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productos.Size = new System.Drawing.Size(1260, 512);
            this.Productos.TabIndex = 46;
            this.Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellContentClick);
            this.Productos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Listado_RowHeaderMouseClick);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Boton_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Nunito", 20.25F);
            this.Boton_Eliminar.Location = new System.Drawing.Point(988, 696);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(150, 40);
            this.Boton_Eliminar.TabIndex = 6;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Trash;
            this.pictureBox1.Location = new System.Drawing.Point(39, 697);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(902, 79);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(121, 36);
            this.ComboBox_Categoria.TabIndex = 2;
            this.ComboBox_Categoria.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Categoria_SelectedIndexChanged);
            // 
            // InterfazListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.ComboBox_Categoria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.BorrarFiltro);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.ProductoDescripcion);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.ProductoBuscador);
            this.Controls.Add(this.ProductosLupa);
            this.Controls.Add(this.Boton_AltaProducto);
            this.Controls.Add(this.Productos);
            this.Name = "InterfazListaProductos";
            this.Text = "Lista de Productos";
            this.Load += new System.EventHandler(this.InterfazListaProductos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button BorrarFiltro;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Label ProductoDescripcion;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.TextBox ProductoBuscador;
        private System.Windows.Forms.PictureBox ProductosLupa;
        private System.Windows.Forms.Button Boton_AltaProducto;
        private System.Windows.Forms.DataGridView Productos;
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ComboBox_Categoria;
    }
}