namespace Presentacion
{
    partial class InterfazAltaProductos
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
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.SeparatorProducto = new System.Windows.Forms.Label();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.Box_Nombre = new System.Windows.Forms.TextBox();
            this.Precio_Label = new System.Windows.Forms.Label();
            this.Box_Precio = new System.Windows.Forms.TextBox();
            this.Stock_Label = new System.Windows.Forms.Label();
            this.Box_Stock = new System.Windows.Forms.TextBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.Categoria_Label = new System.Windows.Forms.Label();
            this.Boton_Limpiar = new System.Windows.Forms.Button();
            this.Boton_Confirmar = new System.Windows.Forms.Button();
            this.Stock_Error = new System.Windows.Forms.TextBox();
            this.Precio_Error = new System.Windows.Forms.TextBox();
            this.Nombre_Error = new System.Windows.Forms.TextBox();
            this.Categoria_Error = new System.Windows.Forms.TextBox();
            this.MayudaStock = new System.Windows.Forms.Label();
            this.MayudaPrecio = new System.Windows.Forms.Label();
            this.MayudaNombre = new System.Windows.Forms.Label();
            this.MayudaCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_Proveedor = new System.Windows.Forms.ComboBox();
            this.Proveedor_Error = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(567, 682);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(153, 43);
            this.Boton_Cancelar.TabIndex = 8;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            this.Boton_Cancelar.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // SeparatorProducto
            // 
            this.SeparatorProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.SeparatorProducto.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.SeparatorProducto.Location = new System.Drawing.Point(42, 73);
            this.SeparatorProducto.Margin = new System.Windows.Forms.Padding(3);
            this.SeparatorProducto.Name = "SeparatorProducto";
            this.SeparatorProducto.Size = new System.Drawing.Size(717, 40);
            this.SeparatorProducto.TabIndex = 110;
            this.SeparatorProducto.Text = "Crear Producto";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Nombre_Label.Location = new System.Drawing.Point(59, 338);
            this.Nombre_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(136, 39);
            this.Nombre_Label.TabIndex = 108;
            this.Nombre_Label.Text = "Nombre:";
            // 
            // Box_Nombre
            // 
            this.Box_Nombre.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Nombre.Font = new System.Drawing.Font("Nunito", 18F);
            this.Box_Nombre.Location = new System.Drawing.Point(455, 345);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(250, 31);
            this.Box_Nombre.TabIndex = 3;
            // 
            // Precio_Label
            // 
            this.Precio_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Precio_Label.Location = new System.Drawing.Point(59, 438);
            this.Precio_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Precio_Label.Name = "Precio_Label";
            this.Precio_Label.Size = new System.Drawing.Size(136, 39);
            this.Precio_Label.TabIndex = 111;
            this.Precio_Label.Text = "Precio:";
            // 
            // Box_Precio
            // 
            this.Box_Precio.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Precio.Font = new System.Drawing.Font("Nunito", 18F);
            this.Box_Precio.Location = new System.Drawing.Point(455, 446);
            this.Box_Precio.Name = "Box_Precio";
            this.Box_Precio.Size = new System.Drawing.Size(250, 31);
            this.Box_Precio.TabIndex = 4;
            // 
            // Stock_Label
            // 
            this.Stock_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Stock_Label.Location = new System.Drawing.Point(59, 551);
            this.Stock_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Stock_Label.Name = "Stock_Label";
            this.Stock_Label.Size = new System.Drawing.Size(136, 39);
            this.Stock_Label.TabIndex = 113;
            this.Stock_Label.Text = "Stock:";
            // 
            // Box_Stock
            // 
            this.Box_Stock.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_Stock.Font = new System.Drawing.Font("Nunito", 18F);
            this.Box_Stock.Location = new System.Drawing.Point(455, 559);
            this.Box_Stock.Name = "Box_Stock";
            this.Box_Stock.Size = new System.Drawing.Size(251, 31);
            this.Box_Stock.TabIndex = 5;
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_Categoria.Font = new System.Drawing.Font("Nunito", 14.25F);
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(455, 241);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(250, 33);
            this.ComboBox_Categoria.TabIndex = 2;
            // 
            // Categoria_Label
            // 
            this.Categoria_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Categoria_Label.Location = new System.Drawing.Point(59, 235);
            this.Categoria_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categoria_Label.Name = "Categoria_Label";
            this.Categoria_Label.Size = new System.Drawing.Size(161, 39);
            this.Categoria_Label.TabIndex = 108;
            this.Categoria_Label.Text = "Categoría:";
            // 
            // Boton_Limpiar
            // 
            this.Boton_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Boton_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Limpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Limpiar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Limpiar.Location = new System.Drawing.Point(369, 682);
            this.Boton_Limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Limpiar.Name = "Boton_Limpiar";
            this.Boton_Limpiar.Size = new System.Drawing.Size(153, 43);
            this.Boton_Limpiar.TabIndex = 7;
            this.Boton_Limpiar.Text = "Limpiar";
            this.Boton_Limpiar.UseVisualStyleBackColor = false;
            this.Boton_Limpiar.Click += new System.EventHandler(this.Boton_Limpiar_Click);
            // 
            // Boton_Confirmar
            // 
            this.Boton_Confirmar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Confirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Confirmar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Confirmar.Location = new System.Drawing.Point(171, 682);
            this.Boton_Confirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Confirmar.Name = "Boton_Confirmar";
            this.Boton_Confirmar.Size = new System.Drawing.Size(153, 43);
            this.Boton_Confirmar.TabIndex = 6;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = false;
            this.Boton_Confirmar.Click += new System.EventHandler(this.Boton_Confirmar_Click);
            // 
            // Stock_Error
            // 
            this.Stock_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_Error.ForeColor = System.Drawing.Color.Red;
            this.Stock_Error.Location = new System.Drawing.Point(455, 593);
            this.Stock_Error.Multiline = true;
            this.Stock_Error.Name = "Stock_Error";
            this.Stock_Error.Size = new System.Drawing.Size(311, 20);
            this.Stock_Error.TabIndex = 125;
            // 
            // Precio_Error
            // 
            this.Precio_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Precio_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio_Error.ForeColor = System.Drawing.Color.Red;
            this.Precio_Error.Location = new System.Drawing.Point(455, 481);
            this.Precio_Error.Multiline = true;
            this.Precio_Error.Name = "Precio_Error";
            this.Precio_Error.Size = new System.Drawing.Size(311, 20);
            this.Precio_Error.TabIndex = 124;
            // 
            // Nombre_Error
            // 
            this.Nombre_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Error.ForeColor = System.Drawing.Color.Red;
            this.Nombre_Error.Location = new System.Drawing.Point(455, 379);
            this.Nombre_Error.Multiline = true;
            this.Nombre_Error.Name = "Nombre_Error";
            this.Nombre_Error.Size = new System.Drawing.Size(311, 20);
            this.Nombre_Error.TabIndex = 123;
            // 
            // Categoria_Error
            // 
            this.Categoria_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Categoria_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria_Error.ForeColor = System.Drawing.Color.Red;
            this.Categoria_Error.Location = new System.Drawing.Point(455, 277);
            this.Categoria_Error.Multiline = true;
            this.Categoria_Error.Name = "Categoria_Error";
            this.Categoria_Error.Size = new System.Drawing.Size(311, 20);
            this.Categoria_Error.TabIndex = 122;
            // 
            // MayudaStock
            // 
            this.MayudaStock.AutoSize = true;
            this.MayudaStock.BackColor = System.Drawing.Color.LightGray;
            this.MayudaStock.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaStock.Location = new System.Drawing.Point(711, 570);
            this.MayudaStock.Name = "MayudaStock";
            this.MayudaStock.Size = new System.Drawing.Size(15, 17);
            this.MayudaStock.TabIndex = 121;
            this.MayudaStock.Text = "?";
            this.MayudaStock.Visible = false;
            // 
            // MayudaPrecio
            // 
            this.MayudaPrecio.AutoSize = true;
            this.MayudaPrecio.BackColor = System.Drawing.Color.LightGray;
            this.MayudaPrecio.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaPrecio.Location = new System.Drawing.Point(711, 457);
            this.MayudaPrecio.Name = "MayudaPrecio";
            this.MayudaPrecio.Size = new System.Drawing.Size(15, 17);
            this.MayudaPrecio.TabIndex = 120;
            this.MayudaPrecio.Text = "?";
            this.MayudaPrecio.Visible = false;
            // 
            // MayudaNombre
            // 
            this.MayudaNombre.AutoSize = true;
            this.MayudaNombre.BackColor = System.Drawing.Color.LightGray;
            this.MayudaNombre.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaNombre.Location = new System.Drawing.Point(711, 356);
            this.MayudaNombre.Name = "MayudaNombre";
            this.MayudaNombre.Size = new System.Drawing.Size(15, 17);
            this.MayudaNombre.TabIndex = 119;
            this.MayudaNombre.Text = "?";
            this.MayudaNombre.Visible = false;
            // 
            // MayudaCategoria
            // 
            this.MayudaCategoria.AutoSize = true;
            this.MayudaCategoria.BackColor = System.Drawing.Color.LightGray;
            this.MayudaCategoria.Font = new System.Drawing.Font("Nunito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayudaCategoria.Location = new System.Drawing.Point(711, 249);
            this.MayudaCategoria.Name = "MayudaCategoria";
            this.MayudaCategoria.Size = new System.Drawing.Size(15, 17);
            this.MayudaCategoria.TabIndex = 118;
            this.MayudaCategoria.Text = "?";
            this.MayudaCategoria.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.label1.Location = new System.Drawing.Point(59, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 39);
            this.label1.TabIndex = 126;
            this.label1.Text = "Proveedor:";
            // 
            // ComboBox_Proveedor
            // 
            this.ComboBox_Proveedor.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Proveedor.FormattingEnabled = true;
            this.ComboBox_Proveedor.Location = new System.Drawing.Point(455, 149);
            this.ComboBox_Proveedor.Name = "ComboBox_Proveedor";
            this.ComboBox_Proveedor.Size = new System.Drawing.Size(250, 33);
            this.ComboBox_Proveedor.TabIndex = 1;
            // 
            // Proveedor_Error
            // 
            this.Proveedor_Error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Proveedor_Error.Font = new System.Drawing.Font("Nunito", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedor_Error.ForeColor = System.Drawing.Color.Red;
            this.Proveedor_Error.Location = new System.Drawing.Point(455, 188);
            this.Proveedor_Error.Multiline = true;
            this.Proveedor_Error.Name = "Proveedor_Error";
            this.Proveedor_Error.Size = new System.Drawing.Size(311, 20);
            this.Proveedor_Error.TabIndex = 128;
            // 
            // InterfazAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.Proveedor_Error);
            this.Controls.Add(this.ComboBox_Proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stock_Error);
            this.Controls.Add(this.Precio_Error);
            this.Controls.Add(this.Nombre_Error);
            this.Controls.Add(this.Categoria_Error);
            this.Controls.Add(this.MayudaStock);
            this.Controls.Add(this.MayudaPrecio);
            this.Controls.Add(this.MayudaNombre);
            this.Controls.Add(this.MayudaCategoria);
            this.Controls.Add(this.Boton_Confirmar);
            this.Controls.Add(this.Boton_Limpiar);
            this.Controls.Add(this.Categoria_Label);
            this.Controls.Add(this.ComboBox_Categoria);
            this.Controls.Add(this.Box_Stock);
            this.Controls.Add(this.Stock_Label);
            this.Controls.Add(this.Box_Precio);
            this.Controls.Add(this.Precio_Label);
            this.Controls.Add(this.Box_Nombre);
            this.Controls.Add(this.Nombre_Label);
            this.Controls.Add(this.SeparatorProducto);
            this.Controls.Add(this.Boton_Cancelar);
            this.Name = "InterfazAltaProductos";
            this.Text = "Alta de Productos";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.Label SeparatorProducto;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.TextBox Box_Nombre;
        private System.Windows.Forms.Label Precio_Label;
        private System.Windows.Forms.TextBox Box_Precio;
        private System.Windows.Forms.Label Stock_Label;
        private System.Windows.Forms.TextBox Box_Stock;
        private System.Windows.Forms.ComboBox ComboBox_Categoria;
        private System.Windows.Forms.Label Categoria_Label;
        private System.Windows.Forms.Button Boton_Limpiar;
        private System.Windows.Forms.Button Boton_Confirmar;
        private System.Windows.Forms.TextBox Stock_Error;
        private System.Windows.Forms.TextBox Precio_Error;
        private System.Windows.Forms.TextBox Nombre_Error;
        private System.Windows.Forms.TextBox Categoria_Error;
        private System.Windows.Forms.Label MayudaStock;
        private System.Windows.Forms.Label MayudaPrecio;
        private System.Windows.Forms.Label MayudaNombre;
        private System.Windows.Forms.Label MayudaCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_Proveedor;
        private System.Windows.Forms.TextBox Proveedor_Error;
    }
}