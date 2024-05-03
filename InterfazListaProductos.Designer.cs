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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.ProductoDescripcion = new System.Windows.Forms.Label();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.Box_BuscarDNI = new System.Windows.Forms.TextBox();
            this.LupaDNI = new System.Windows.Forms.PictureBox();
            this.UsuariosBuscador = new System.Windows.Forms.TextBox();
            this.UsuariosLupa = new System.Windows.Forms.PictureBox();
            this.Boton_AltaProducto = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.DataGridView();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).BeginInit();
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
            this.Boton_Modificar.Location = new System.Drawing.Point(79, 696);
            this.Boton_Modificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(152, 42);
            this.Boton_Modificar.TabIndex = 56;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            // 
            // BorrarFiltro
            // 
            this.BorrarFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarFiltro.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFiltro.Location = new System.Drawing.Point(409, 696);
            this.BorrarFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(191, 42);
            this.BorrarFiltro.TabIndex = 55;
            this.BorrarFiltro.Text = "Borrar Filtros";
            this.BorrarFiltro.UseVisualStyleBackColor = false;
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(623, 696);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(137, 42);
            this.Boton_Salir.TabIndex = 54;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // ProductoDescripcion
            // 
            this.ProductoDescripcion.AutoSize = true;
            this.ProductoDescripcion.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoDescripcion.Location = new System.Drawing.Point(21, 141);
            this.ProductoDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoDescripcion.Name = "ProductoDescripcion";
            this.ProductoDescripcion.Size = new System.Drawing.Size(229, 32);
            this.ProductoDescripcion.TabIndex = 53;
            this.ProductoDescripcion.Text = "Buscar Descripción";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.Location = new System.Drawing.Point(21, 70);
            this.ProductoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(200, 32);
            this.ProductoLabel.TabIndex = 52;
            this.ProductoLabel.Text = "Buscar Producto";
            // 
            // Box_BuscarDNI
            // 
            this.Box_BuscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_BuscarDNI.Location = new System.Drawing.Point(254, 143);
            this.Box_BuscarDNI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Box_BuscarDNI.Name = "Box_BuscarDNI";
            this.Box_BuscarDNI.Size = new System.Drawing.Size(278, 29);
            this.Box_BuscarDNI.TabIndex = 51;
            // 
            // LupaDNI
            // 
            this.LupaDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LupaDNI.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.LupaDNI.Location = new System.Drawing.Point(540, 139);
            this.LupaDNI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LupaDNI.Name = "LupaDNI";
            this.LupaDNI.Size = new System.Drawing.Size(49, 33);
            this.LupaDNI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LupaDNI.TabIndex = 50;
            this.LupaDNI.TabStop = false;
            // 
            // UsuariosBuscador
            // 
            this.UsuariosBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosBuscador.Location = new System.Drawing.Point(254, 75);
            this.UsuariosBuscador.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsuariosBuscador.Name = "UsuariosBuscador";
            this.UsuariosBuscador.Size = new System.Drawing.Size(278, 29);
            this.UsuariosBuscador.TabIndex = 49;
            // 
            // UsuariosLupa
            // 
            this.UsuariosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.UsuariosLupa.Location = new System.Drawing.Point(540, 71);
            this.UsuariosLupa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsuariosLupa.Name = "UsuariosLupa";
            this.UsuariosLupa.Size = new System.Drawing.Size(49, 33);
            this.UsuariosLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsuariosLupa.TabIndex = 48;
            this.UsuariosLupa.TabStop = false;
            // 
            // Boton_AltaProducto
            // 
            this.Boton_AltaProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_AltaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_AltaProducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_AltaProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_AltaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_AltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_AltaProducto.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaProducto.Location = new System.Drawing.Point(602, 96);
            this.Boton_AltaProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_AltaProducto.Name = "Boton_AltaProducto";
            this.Boton_AltaProducto.Size = new System.Drawing.Size(158, 48);
            this.Boton_AltaProducto.TabIndex = 47;
            this.Boton_AltaProducto.Text = "+ Nuevo";
            this.Boton_AltaProducto.UseVisualStyleBackColor = false;
            this.Boton_AltaProducto.Click += new System.EventHandler(this.Boton_AltaProducto_Click);
            // 
            // Productos
            // 
            this.Productos.AllowUserToAddRows = false;
            this.Productos.AllowUserToDeleteRows = false;
            this.Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Productos.Location = new System.Drawing.Point(20, 215);
            this.Productos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Productos.MultiSelect = false;
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            this.Productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Productos.Size = new System.Drawing.Size(750, 450);
            this.Productos.TabIndex = 46;
            this.Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Productos_CellContentClick);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Nunito", 20.25F);
            this.Boton_Eliminar.Location = new System.Drawing.Point(254, 696);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(136, 42);
            this.Boton_Eliminar.TabIndex = 57;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // InterfazListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.BorrarFiltro);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.ProductoDescripcion);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.Box_BuscarDNI);
            this.Controls.Add(this.LupaDNI);
            this.Controls.Add(this.UsuariosBuscador);
            this.Controls.Add(this.UsuariosLupa);
            this.Controls.Add(this.Boton_AltaProducto);
            this.Controls.Add(this.Productos);
            this.Name = "InterfazListaProductos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfazListaProductos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button BorrarFiltro;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Label ProductoDescripcion;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.TextBox Box_BuscarDNI;
        private System.Windows.Forms.PictureBox LupaDNI;
        private System.Windows.Forms.TextBox UsuariosBuscador;
        private System.Windows.Forms.PictureBox UsuariosLupa;
        private System.Windows.Forms.Button Boton_AltaProducto;
        private System.Windows.Forms.DataGridView Productos;
        private System.Windows.Forms.Button Boton_Eliminar;
    }
}