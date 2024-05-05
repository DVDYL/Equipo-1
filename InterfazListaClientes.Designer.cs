namespace Presentacion
{
    partial class InterfazListaClientes
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
            this.Clientes = new System.Windows.Forms.DataGridView();
            this.DNILabel = new System.Windows.Forms.Label();
            this.BuscarCliente_Label = new System.Windows.Forms.Label();
            this.Box_BuscarDNI = new System.Windows.Forms.TextBox();
            this.LupaDNI = new System.Windows.Forms.PictureBox();
            this.ClienteBuscador = new System.Windows.Forms.TextBox();
            this.ClienteLupa = new System.Windows.Forms.PictureBox();
            this.Boton_AltaCliente = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.AllowUserToAddRows = false;
            this.Clientes.AllowUserToDeleteRows = false;
            this.Clientes.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Clientes.BackgroundColor = System.Drawing.Color.White;
            this.Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Clientes.ColumnHeadersHeight = 40;
            this.Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Clientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.Clientes.EnableHeadersVisualStyles = false;
            this.Clientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clientes.Location = new System.Drawing.Point(50, 200);
            this.Clientes.MultiSelect = false;
            this.Clientes.Name = "Clientes";
            this.Clientes.ReadOnly = true;
            this.Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Clientes.RowHeadersWidth = 15;
            this.Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Clientes.Size = new System.Drawing.Size(1260, 460);
            this.Clientes.TabIndex = 1;
            this.Clientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Listado_RowHeaderMouseClick);
            // 
            // DNILabel
            // 
            this.DNILabel.AutoSize = true;
            this.DNILabel.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNILabel.Location = new System.Drawing.Point(600, 80);
            this.DNILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNILabel.Name = "DNILabel";
            this.DNILabel.Size = new System.Drawing.Size(185, 32);
            this.DNILabel.TabIndex = 42;
            this.DNILabel.Text = "Buscar por DNI";
            // 
            // BuscarCliente_Label
            // 
            this.BuscarCliente_Label.AutoSize = true;
            this.BuscarCliente_Label.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCliente_Label.Location = new System.Drawing.Point(50, 80);
            this.BuscarCliente_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuscarCliente_Label.Name = "BuscarCliente_Label";
            this.BuscarCliente_Label.Size = new System.Drawing.Size(178, 32);
            this.BuscarCliente_Label.TabIndex = 41;
            this.BuscarCliente_Label.Text = "Buscar Cliente";
            // 
            // Box_BuscarDNI
            // 
            this.Box_BuscarDNI.BackColor = System.Drawing.Color.Gainsboro;
            this.Box_BuscarDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Box_BuscarDNI.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_BuscarDNI.Location = new System.Drawing.Point(793, 80);
            this.Box_BuscarDNI.Name = "Box_BuscarDNI";
            this.Box_BuscarDNI.Size = new System.Drawing.Size(220, 31);
            this.Box_BuscarDNI.TabIndex = 40;
            // 
            // LupaDNI
            // 
            this.LupaDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LupaDNI.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.LupaDNI.Location = new System.Drawing.Point(1028, 80);
            this.LupaDNI.Name = "LupaDNI";
            this.LupaDNI.Size = new System.Drawing.Size(49, 34);
            this.LupaDNI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LupaDNI.TabIndex = 39;
            this.LupaDNI.TabStop = false;
            this.LupaDNI.Click += new System.EventHandler(this.LupaDNI_Click);
            // 
            // ClienteBuscador
            // 
            this.ClienteBuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.ClienteBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClienteBuscador.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteBuscador.Location = new System.Drawing.Point(235, 80);
            this.ClienteBuscador.Name = "ClienteBuscador";
            this.ClienteBuscador.Size = new System.Drawing.Size(220, 31);
            this.ClienteBuscador.TabIndex = 38;
            // 
            // ClienteLupa
            // 
            this.ClienteLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClienteLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.ClienteLupa.Location = new System.Drawing.Point(467, 80);
            this.ClienteLupa.Name = "ClienteLupa";
            this.ClienteLupa.Size = new System.Drawing.Size(49, 34);
            this.ClienteLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClienteLupa.TabIndex = 37;
            this.ClienteLupa.TabStop = false;
            this.ClienteLupa.Click += new System.EventHandler(this.ClienteLupa_Click);
            // 
            // Boton_AltaCliente
            // 
            this.Boton_AltaCliente.BackColor = System.Drawing.Color.White;
            this.Boton_AltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_AltaCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_AltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_AltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_AltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_AltaCliente.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaCliente.Location = new System.Drawing.Point(1150, 75);
            this.Boton_AltaCliente.Name = "Boton_AltaCliente";
            this.Boton_AltaCliente.Size = new System.Drawing.Size(135, 40);
            this.Boton_AltaCliente.TabIndex = 36;
            this.Boton_AltaCliente.Text = "+ Nuevo";
            this.Boton_AltaCliente.UseVisualStyleBackColor = false;
            this.Boton_AltaCliente.Click += new System.EventHandler(this.Boton_AltaCliente_Click);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.BackColor = System.Drawing.Color.Khaki;
            this.Boton_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Modificar.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Modificar.Location = new System.Drawing.Point(783, 695);
            this.Boton_Modificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(150, 40);
            this.Boton_Modificar.TabIndex = 45;
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
            this.BorrarFiltro.Location = new System.Drawing.Point(50, 150);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(185, 35);
            this.BorrarFiltro.TabIndex = 44;
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
            this.Boton_Salir.Location = new System.Drawing.Point(1175, 695);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(150, 40);
            this.Boton_Salir.TabIndex = 43;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.Boton_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.Boton_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Nunito", 20.25F);
            this.Boton_Eliminar.Location = new System.Drawing.Point(979, 695);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(150, 40);
            this.Boton_Eliminar.TabIndex = 46;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Trash;
            this.pictureBox1.Location = new System.Drawing.Point(50, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // InterfazListaClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.BorrarFiltro);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.DNILabel);
            this.Controls.Add(this.BuscarCliente_Label);
            this.Controls.Add(this.Box_BuscarDNI);
            this.Controls.Add(this.LupaDNI);
            this.Controls.Add(this.ClienteBuscador);
            this.Controls.Add(this.ClienteLupa);
            this.Controls.Add(this.Boton_AltaCliente);
            this.Controls.Add(this.Clientes);
            this.Name = "InterfazListaClientes";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.InterfazListaClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Clientes;
        private System.Windows.Forms.Label DNILabel;
        private System.Windows.Forms.Label BuscarCliente_Label;
        private System.Windows.Forms.TextBox Box_BuscarDNI;
        private System.Windows.Forms.PictureBox LupaDNI;
        private System.Windows.Forms.TextBox ClienteBuscador;
        private System.Windows.Forms.PictureBox ClienteLupa;
        private System.Windows.Forms.Button Boton_AltaCliente;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button BorrarFiltro;
        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}