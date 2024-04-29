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
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.BotonAltaProveedores = new System.Windows.Forms.Button();
            this.CUIT_Label = new System.Windows.Forms.Label();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.CUITBuscador = new System.Windows.Forms.TextBox();
            this.CUITLupa = new System.Windows.Forms.PictureBox();
            this.ProveedoresBuscador = new System.Windows.Forms.TextBox();
            this.ProveedoresLupa = new System.Windows.Forms.PictureBox();
            this.Boton_BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUITLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresLupa)).BeginInit();
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
            this.Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Proveedores.Size = new System.Drawing.Size(750, 570);
            this.Proveedores.TabIndex = 1;
            this.Proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Proveedores_CellContentClick);
            // 
            // Prueba
            // 
            this.Prueba.Frozen = true;
            this.Prueba.HeaderText = "Acciones";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            this.Prueba.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prueba.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Prueba.Width = 58;
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
            // BotonAltaProveedores
            // 
            this.BotonAltaProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAltaProveedores.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BotonAltaProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.BotonAltaProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BotonAltaProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAltaProveedores.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAltaProveedores.Location = new System.Drawing.Point(611, 91);
            this.BotonAltaProveedores.Name = "BotonAltaProveedores";
            this.BotonAltaProveedores.Size = new System.Drawing.Size(157, 49);
            this.BotonAltaProveedores.TabIndex = 27;
            this.BotonAltaProveedores.Text = "+ Nuevo";
            this.BotonAltaProveedores.UseVisualStyleBackColor = true;
            this.BotonAltaProveedores.Click += new System.EventHandler(this.BotonAltaProveedores_Click);
            // 
            // CUIT_Label
            // 
            this.CUIT_Label.AutoSize = true;
            this.CUIT_Label.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUIT_Label.Location = new System.Drawing.Point(27, 135);
            this.CUIT_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CUIT_Label.Name = "CUIT_Label";
            this.CUIT_Label.Size = new System.Drawing.Size(173, 28);
            this.CUIT_Label.TabIndex = 41;
            this.CUIT_Label.Text = "Buscar por CUIT";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Label.Location = new System.Drawing.Point(27, 75);
            this.Nombre_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(202, 28);
            this.Nombre_Label.TabIndex = 40;
            this.Nombre_Label.Text = "Buscar por Nombre";
            // 
            // CUITBuscador
            // 
            this.CUITBuscador.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUITBuscador.Location = new System.Drawing.Point(246, 131);
            this.CUITBuscador.Name = "CUITBuscador";
            this.CUITBuscador.Size = new System.Drawing.Size(278, 32);
            this.CUITBuscador.TabIndex = 39;
            // 
            // CUITLupa
            // 
            this.CUITLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CUITLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.CUITLupa.Location = new System.Drawing.Point(543, 131);
            this.CUITLupa.Name = "CUITLupa";
            this.CUITLupa.Size = new System.Drawing.Size(49, 34);
            this.CUITLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CUITLupa.TabIndex = 38;
            this.CUITLupa.TabStop = false;
            this.CUITLupa.Click += new System.EventHandler(this.CUITLupa_Click);
            // 
            // ProveedoresBuscador
            // 
            this.ProveedoresBuscador.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedoresBuscador.Location = new System.Drawing.Point(246, 74);
            this.ProveedoresBuscador.Name = "ProveedoresBuscador";
            this.ProveedoresBuscador.Size = new System.Drawing.Size(278, 32);
            this.ProveedoresBuscador.TabIndex = 37;
            // 
            // ProveedoresLupa
            // 
            this.ProveedoresLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProveedoresLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.ProveedoresLupa.Location = new System.Drawing.Point(543, 74);
            this.ProveedoresLupa.Name = "ProveedoresLupa";
            this.ProveedoresLupa.Size = new System.Drawing.Size(49, 34);
            this.ProveedoresLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProveedoresLupa.TabIndex = 36;
            this.ProveedoresLupa.TabStop = false;
            this.ProveedoresLupa.Click += new System.EventHandler(this.ProveedoresLupa_Click);
            // 
            // Boton_BorrarFiltro
            // 
            this.Boton_BorrarFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_BorrarFiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_BorrarFiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_BorrarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_BorrarFiltro.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_BorrarFiltro.Location = new System.Drawing.Point(321, 829);
            this.Boton_BorrarFiltro.Name = "Boton_BorrarFiltro";
            this.Boton_BorrarFiltro.Size = new System.Drawing.Size(194, 42);
            this.Boton_BorrarFiltro.TabIndex = 42;
            this.Boton_BorrarFiltro.Text = "Borrar Filtros";
            this.Boton_BorrarFiltro.UseVisualStyleBackColor = true;
            this.Boton_BorrarFiltro.Click += new System.EventHandler(this.Boton_BorrarFiltro_Click);
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
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // InterfazListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_BorrarFiltro);
            this.Controls.Add(this.CUIT_Label);
            this.Controls.Add(this.Nombre_Label);
            this.Controls.Add(this.CUITBuscador);
            this.Controls.Add(this.CUITLupa);
            this.Controls.Add(this.ProveedoresBuscador);
            this.Controls.Add(this.ProveedoresLupa);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.BotonAltaProveedores);
            this.Controls.Add(this.Proveedores);
            this.Name = "InterfazListaProveedores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfazListaProveedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUITLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Proveedores;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Button BotonAltaProveedores;
        private System.Windows.Forms.Label CUIT_Label;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.TextBox CUITBuscador;
        private System.Windows.Forms.PictureBox CUITLupa;
        private System.Windows.Forms.TextBox ProveedoresBuscador;
        private System.Windows.Forms.PictureBox ProveedoresLupa;
        private System.Windows.Forms.Button Boton_BorrarFiltro;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
    }
}