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
            this.Clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Email = new System.Windows.Forms.Label();
            this.Box_BuscarDNI = new System.Windows.Forms.TextBox();
            this.LupaDNI = new System.Windows.Forms.PictureBox();
            this.UsuariosBuscador = new System.Windows.Forms.TextBox();
            this.UsuariosLupa = new System.Windows.Forms.PictureBox();
            this.Boton_AltaCliente = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Clientes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clientes.Location = new System.Drawing.Point(25, 200);
            this.Clientes.MultiSelect = false;
            this.Clientes.Name = "Clientes";
            this.Clientes.ReadOnly = true;
            this.Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Clientes.Size = new System.Drawing.Size(750, 570);
            this.Clientes.TabIndex = 1;
            this.Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clientes_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buscar por DNI";
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(19, 73);
            this.Label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(202, 28);
            this.Label_Email.TabIndex = 41;
            this.Label_Email.Text = "Buscar por Nombre";
            // 
            // Box_BuscarDNI
            // 
            this.Box_BuscarDNI.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_BuscarDNI.Location = new System.Drawing.Point(238, 140);
            this.Box_BuscarDNI.Name = "Box_BuscarDNI";
            this.Box_BuscarDNI.Size = new System.Drawing.Size(278, 32);
            this.Box_BuscarDNI.TabIndex = 40;
            // 
            // LupaDNI
            // 
            this.LupaDNI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LupaDNI.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.LupaDNI.Location = new System.Drawing.Point(535, 140);
            this.LupaDNI.Name = "LupaDNI";
            this.LupaDNI.Size = new System.Drawing.Size(49, 34);
            this.LupaDNI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LupaDNI.TabIndex = 39;
            this.LupaDNI.TabStop = false;
            // 
            // UsuariosBuscador
            // 
            this.UsuariosBuscador.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosBuscador.Location = new System.Drawing.Point(238, 72);
            this.UsuariosBuscador.Name = "UsuariosBuscador";
            this.UsuariosBuscador.Size = new System.Drawing.Size(278, 32);
            this.UsuariosBuscador.TabIndex = 38;
            // 
            // UsuariosLupa
            // 
            this.UsuariosLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosLupa.Image = global::Presentacion.Properties.Resources.Lupa2;
            this.UsuariosLupa.Location = new System.Drawing.Point(535, 72);
            this.UsuariosLupa.Name = "UsuariosLupa";
            this.UsuariosLupa.Size = new System.Drawing.Size(49, 34);
            this.UsuariosLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsuariosLupa.TabIndex = 37;
            this.UsuariosLupa.TabStop = false;
            // 
            // Boton_AltaCliente
            // 
            this.Boton_AltaCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Boton_AltaCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_AltaCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_AltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Boton_AltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.Boton_AltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_AltaCliente.Font = new System.Drawing.Font("Nunito", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaCliente.Location = new System.Drawing.Point(620, 100);
            this.Boton_AltaCliente.Name = "Boton_AltaCliente";
            this.Boton_AltaCliente.Size = new System.Drawing.Size(157, 49);
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
            this.Boton_Modificar.Location = new System.Drawing.Point(72, 827);
            this.Boton_Modificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(190, 42);
            this.Boton_Modificar.TabIndex = 45;
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
            this.BorrarFiltro.Location = new System.Drawing.Point(310, 827);
            this.BorrarFiltro.Name = "BorrarFiltro";
            this.BorrarFiltro.Size = new System.Drawing.Size(193, 42);
            this.BorrarFiltro.TabIndex = 44;
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
            this.Boton_Salir.Location = new System.Drawing.Point(554, 827);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(190, 42);
            this.Boton_Salir.TabIndex = 43;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // InterfazListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 900);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.BorrarFiltro);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Email);
            this.Controls.Add(this.Box_BuscarDNI);
            this.Controls.Add(this.LupaDNI);
            this.Controls.Add(this.UsuariosBuscador);
            this.Controls.Add(this.UsuariosLupa);
            this.Controls.Add(this.Boton_AltaCliente);
            this.Controls.Add(this.Clientes);
            this.Name = "InterfazListaClientes";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.InterfazListaClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupaDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.TextBox Box_BuscarDNI;
        private System.Windows.Forms.PictureBox LupaDNI;
        private System.Windows.Forms.TextBox UsuariosBuscador;
        private System.Windows.Forms.PictureBox UsuariosLupa;
        private System.Windows.Forms.Button Boton_AltaCliente;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button BorrarFiltro;
        private System.Windows.Forms.Button Boton_Salir;
    }
}