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
            this.Boton_Cancelar.TabIndex = 7;
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
            this.SeparatorProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Nombre_Label.Location = new System.Drawing.Point(70, 260);
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
            this.Box_Nombre.Location = new System.Drawing.Point(431, 263);
            this.Box_Nombre.Name = "Box_Nombre";
            this.Box_Nombre.Size = new System.Drawing.Size(250, 32);
            this.Box_Nombre.TabIndex = 100;
            // 
            // Precio_Label
            // 
            this.Precio_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Precio_Label.Location = new System.Drawing.Point(70, 366);
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
            this.Box_Precio.Location = new System.Drawing.Point(433, 369);
            this.Box_Precio.Name = "Box_Precio";
            this.Box_Precio.Size = new System.Drawing.Size(250, 32);
            this.Box_Precio.TabIndex = 112;
            // 
            // Stock_Label
            // 
            this.Stock_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Stock_Label.Location = new System.Drawing.Point(70, 472);
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
            this.Box_Stock.Location = new System.Drawing.Point(431, 475);
            this.Box_Stock.Name = "Box_Stock";
            this.Box_Stock.Size = new System.Drawing.Size(251, 32);
            this.Box_Stock.TabIndex = 114;
            // 
            // ComboBox_Categoria
            // 
            this.ComboBox_Categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox_Categoria.Font = new System.Drawing.Font("Nunito", 14.25F);
            this.ComboBox_Categoria.FormattingEnabled = true;
            this.ComboBox_Categoria.Location = new System.Drawing.Point(431, 154);
            this.ComboBox_Categoria.Name = "ComboBox_Categoria";
            this.ComboBox_Categoria.Size = new System.Drawing.Size(250, 33);
            this.ComboBox_Categoria.TabIndex = 115;
            // 
            // Categoria_Label
            // 
            this.Categoria_Label.Font = new System.Drawing.Font("Nunito", 21.75F);
            this.Categoria_Label.Location = new System.Drawing.Point(70, 154);
            this.Categoria_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categoria_Label.Name = "Categoria_Label";
            this.Categoria_Label.Size = new System.Drawing.Size(136, 39);
            this.Categoria_Label.TabIndex = 108;
            this.Categoria_Label.Text = "Categoria:";
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
            this.Boton_Limpiar.TabIndex = 116;
            this.Boton_Limpiar.Text = "Limpiar";
            this.Boton_Limpiar.UseVisualStyleBackColor = false;
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
            this.Boton_Confirmar.TabIndex = 117;
            this.Boton_Confirmar.Text = "Confirmar";
            this.Boton_Confirmar.UseVisualStyleBackColor = false;
            // 
            // InterfazAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
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
    }
}