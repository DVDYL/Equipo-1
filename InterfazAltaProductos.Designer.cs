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
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.SeparatorProducto = new System.Windows.Forms.Label();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.Nombre_Box = new System.Windows.Forms.TextBox();
            this.Precio_Label = new System.Windows.Forms.Label();
            this.Precio_Box = new System.Windows.Forms.TextBox();
            this.Stock_Label = new System.Windows.Forms.Label();
            this.Stock_Box = new System.Windows.Forms.TextBox();
            this.ComboBox_Categoria = new System.Windows.Forms.ComboBox();
            this.Categoria_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(561, 672);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(190, 42);
            this.Boton_Salir.TabIndex = 7;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
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
            // Nombre_Box
            // 
            this.Nombre_Box.BackColor = System.Drawing.Color.Gainsboro;
            this.Nombre_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre_Box.Font = new System.Drawing.Font("Nunito", 18F);
            this.Nombre_Box.Location = new System.Drawing.Point(431, 263);
            this.Nombre_Box.Name = "Nombre_Box";
            this.Nombre_Box.Size = new System.Drawing.Size(250, 32);
            this.Nombre_Box.TabIndex = 100;
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
            // Precio_Box
            // 
            this.Precio_Box.BackColor = System.Drawing.Color.Gainsboro;
            this.Precio_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Precio_Box.Font = new System.Drawing.Font("Nunito", 18F);
            this.Precio_Box.Location = new System.Drawing.Point(433, 369);
            this.Precio_Box.Name = "Precio_Box";
            this.Precio_Box.Size = new System.Drawing.Size(250, 32);
            this.Precio_Box.TabIndex = 112;
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
            // Stock_Box
            // 
            this.Stock_Box.BackColor = System.Drawing.Color.Gainsboro;
            this.Stock_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock_Box.Font = new System.Drawing.Font("Nunito", 18F);
            this.Stock_Box.Location = new System.Drawing.Point(431, 475);
            this.Stock_Box.Name = "Stock_Box";
            this.Stock_Box.Size = new System.Drawing.Size(251, 32);
            this.Stock_Box.TabIndex = 114;
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
            // InterfazAltaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.Categoria_Label);
            this.Controls.Add(this.ComboBox_Categoria);
            this.Controls.Add(this.Stock_Box);
            this.Controls.Add(this.Stock_Label);
            this.Controls.Add(this.Precio_Box);
            this.Controls.Add(this.Precio_Label);
            this.Controls.Add(this.Nombre_Box);
            this.Controls.Add(this.Nombre_Label);
            this.Controls.Add(this.SeparatorProducto);
            this.Controls.Add(this.Boton_Salir);
            this.Name = "InterfazAltaProductos";
            this.Text = "Alta de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Label SeparatorProducto;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.TextBox Nombre_Box;
        private System.Windows.Forms.Label Precio_Label;
        private System.Windows.Forms.TextBox Precio_Box;
        private System.Windows.Forms.Label Stock_Label;
        private System.Windows.Forms.TextBox Stock_Box;
        private System.Windows.Forms.ComboBox ComboBox_Categoria;
        private System.Windows.Forms.Label Categoria_Label;
    }
}