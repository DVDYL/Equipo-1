namespace Presentacion
{
    partial class InterfazListaUsuarios
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
            this.Usuarios = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boton_AltaUsuario = new System.Windows.Forms.Button();
            this.Boton_Cancelar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuarios
            // 
            this.Usuarios.AllowUserToAddRows = false;
            this.Usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Usuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Usuarios.ColumnHeadersHeight = 45;
            this.Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Usuario,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.EMail,
            this.FechaNacimiento,
            this.FechaAlta});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Usuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.Usuarios.EnableHeadersVisualStyles = false;
            this.Usuarios.Location = new System.Drawing.Point(104, 183);
            this.Usuarios.MultiSelect = false;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            this.Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nunito", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Usuarios.RowHeadersWidth = 130;
            this.Usuarios.RowTemplate.Height = 40;
            this.Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuarios.Size = new System.Drawing.Size(1412, 528);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Usuarios_CellContentClickEditar);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.ToolTipText = "Editar";
            this.Editar.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "E-Mail";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // FechaAlta
            // 
            this.FechaAlta.HeaderText = "Fecha de Alta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            // 
            // Boton_AltaUsuario
            // 
            this.Boton_AltaUsuario.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_AltaUsuario.Location = new System.Drawing.Point(1397, 86);
            this.Boton_AltaUsuario.Name = "Boton_AltaUsuario";
            this.Boton_AltaUsuario.Size = new System.Drawing.Size(105, 43);
            this.Boton_AltaUsuario.TabIndex = 1;
            this.Boton_AltaUsuario.Text = "+ Nuevo";
            this.Boton_AltaUsuario.UseVisualStyleBackColor = true;
            this.Boton_AltaUsuario.Click += new System.EventHandler(this.Boton_AltaUsuario_Click);
            // 
            // Boton_Cancelar
            // 
            this.Boton_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Boton_Cancelar.FlatAppearance.BorderSize = 0;
            this.Boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_Cancelar.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Cancelar.Location = new System.Drawing.Point(1286, 745);
            this.Boton_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Cancelar.Name = "Boton_Cancelar";
            this.Boton_Cancelar.Size = new System.Drawing.Size(216, 33);
            this.Boton_Cancelar.TabIndex = 17;
            this.Boton_Cancelar.Text = "Cancelar";
            this.Boton_Cancelar.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(117, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1258, 94);
            this.listBox1.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 804);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // InterfazListaUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(1561, 803);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Boton_Cancelar);
            this.Controls.Add(this.Boton_AltaUsuario);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "InterfazListaUsuarios";
            this.Load += new System.EventHandler(this.WWUsuario_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Usuarios, 0);
            this.Controls.SetChildIndex(this.Boton_AltaUsuario, 0);
            this.Controls.SetChildIndex(this.Boton_Cancelar, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView Usuarios;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
        private System.Windows.Forms.Button Boton_AltaUsuario;
        private System.Windows.Forms.Button Boton_Cancelar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}