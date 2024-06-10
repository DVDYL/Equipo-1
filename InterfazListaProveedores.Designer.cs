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
            this.BotonAltaProveedores = new System.Windows.Forms.Button();
            this.CUIT_Label = new System.Windows.Forms.Label();
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.CUITBuscador = new System.Windows.Forms.TextBox();
            this.CUITLupa = new System.Windows.Forms.PictureBox();
            this.ProveedoresBuscador = new System.Windows.Forms.TextBox();
            this.ProveedoresLupa = new System.Windows.Forms.PictureBox();
            this.Boton_BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUITLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Proveedores
            // 
            this.Proveedores.AllowUserToAddRows = false;
            this.Proveedores.AllowUserToDeleteRows = false;
            this.Proveedores.AllowUserToResizeColumns = false;
            this.Proveedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Proveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Proveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Proveedores.BackgroundColor = System.Drawing.Color.White;
            this.Proveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Proveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Proveedores.ColumnHeadersHeight = 40;
            this.Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Proveedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.Proveedores.EnableHeadersVisualStyles = false;
            this.Proveedores.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Proveedores.Location = new System.Drawing.Point(47, 160);
            this.Proveedores.MultiSelect = false;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.ReadOnly = true;
            this.Proveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Proveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Proveedores.RowHeadersWidth = 15;
            this.Proveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Proveedores.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proveedores.RowTemplate.Height = 40;
            this.Proveedores.RowTemplate.ReadOnly = true;
            this.Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Proveedores.Size = new System.Drawing.Size(1260, 496);
            this.Proveedores.TabIndex = 4;
            this.Proveedores.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Listado_RowHeaderMouseClick);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Salir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Salir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(1170, 695);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(150, 40);
            this.Boton_Salir.TabIndex = 7;
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
            this.BotonAltaProveedores.Location = new System.Drawing.Point(1150, 75);
            this.BotonAltaProveedores.Name = "BotonAltaProveedores";
            this.BotonAltaProveedores.Size = new System.Drawing.Size(135, 40);
            this.BotonAltaProveedores.TabIndex = 3;
            this.BotonAltaProveedores.Text = "Crear";
            this.BotonAltaProveedores.UseVisualStyleBackColor = true;
            this.BotonAltaProveedores.Click += new System.EventHandler(this.BotonAltaProveedores_Click);
            // 
            // CUIT_Label
            // 
            this.CUIT_Label.AutoSize = true;
            this.CUIT_Label.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUIT_Label.Location = new System.Drawing.Point(600, 80);
            this.CUIT_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CUIT_Label.Name = "CUIT_Label";
            this.CUIT_Label.Size = new System.Drawing.Size(198, 32);
            this.CUIT_Label.TabIndex = 41;
            this.CUIT_Label.Text = "Buscar por CUIT";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Label.Location = new System.Drawing.Point(50, 80);
            this.Nombre_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(215, 32);
            this.Nombre_Label.TabIndex = 40;
            this.Nombre_Label.Text = "Buscar Proveedor";
            // 
            // CUITBuscador
            // 
            this.CUITBuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.CUITBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CUITBuscador.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUITBuscador.Location = new System.Drawing.Point(803, 80);
            this.CUITBuscador.Name = "CUITBuscador";
            this.CUITBuscador.Size = new System.Drawing.Size(220, 31);
            this.CUITBuscador.TabIndex = 2;
            // 
            // CUITLupa
            // 
            this.CUITLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CUITLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.CUITLupa.Location = new System.Drawing.Point(1031, 80);
            this.CUITLupa.Name = "CUITLupa";
            this.CUITLupa.Size = new System.Drawing.Size(49, 34);
            this.CUITLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CUITLupa.TabIndex = 38;
            this.CUITLupa.TabStop = false;
            this.CUITLupa.Click += new System.EventHandler(this.CUITLupa_Click);
            // 
            // ProveedoresBuscador
            // 
            this.ProveedoresBuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.ProveedoresBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProveedoresBuscador.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedoresBuscador.Location = new System.Drawing.Point(270, 80);
            this.ProveedoresBuscador.Name = "ProveedoresBuscador";
            this.ProveedoresBuscador.Size = new System.Drawing.Size(220, 31);
            this.ProveedoresBuscador.TabIndex = 1;
            // 
            // ProveedoresLupa
            // 
            this.ProveedoresLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProveedoresLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.ProveedoresLupa.Location = new System.Drawing.Point(498, 80);
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
            this.Boton_BorrarFiltro.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_BorrarFiltro.Location = new System.Drawing.Point(35, 697);
            this.Boton_BorrarFiltro.Name = "Boton_BorrarFiltro";
            this.Boton_BorrarFiltro.Size = new System.Drawing.Size(185, 35);
            this.Boton_BorrarFiltro.TabIndex = 4;
            this.Boton_BorrarFiltro.Text = "Borrar Filtros";
            this.Boton_BorrarFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Boton_Modificar.Location = new System.Drawing.Point(803, 695);
            this.Boton_Modificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(150, 40);
            this.Boton_Modificar.TabIndex = 5;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Boton_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Nunito", 20.25F);
            this.Boton_Eliminar.Location = new System.Drawing.Point(988, 695);
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
            this.pictureBox1.Location = new System.Drawing.Point(37, 700);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // InterfazListaProveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Boton_Eliminar);
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
            this.Text = "Lista de Proveedores";
            this.Load += new System.EventHandler(this.InterfazListaProveedores_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUITLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}