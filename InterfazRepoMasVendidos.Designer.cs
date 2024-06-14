namespace Presentacion
{
    partial class InterfazRepoMasVendidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Boton_Salir = new System.Windows.Forms.Button();
            this.MasVendidos_Label = new System.Windows.Forms.Label();
            this.MasVendidosPorCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MasVendidosPorCategoria)).BeginInit();
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
            this.Boton_Salir.Location = new System.Drawing.Point(642, 695);
            this.Boton_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(133, 42);
            this.Boton_Salir.TabIndex = 61;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click);
            // 
            // MasVendidos_Label
            // 
            this.MasVendidos_Label.AutoSize = true;
            this.MasVendidos_Label.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasVendidos_Label.Location = new System.Drawing.Point(45, 92);
            this.MasVendidos_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MasVendidos_Label.Name = "MasVendidos_Label";
            this.MasVendidos_Label.Size = new System.Drawing.Size(659, 36);
            this.MasVendidos_Label.TabIndex = 63;
            this.MasVendidos_Label.Text = "Reporte de Productos Más Vendidos por Categoría";
            // 
            // MasVendidosPorCategoria
            // 
            this.MasVendidosPorCategoria.AllowUserToAddRows = false;
            this.MasVendidosPorCategoria.AllowUserToDeleteRows = false;
            this.MasVendidosPorCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.MasVendidosPorCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.MasVendidosPorCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MasVendidosPorCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.MasVendidosPorCategoria.BackgroundColor = System.Drawing.Color.White;
            this.MasVendidosPorCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasVendidosPorCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.MasVendidosPorCategoria.ColumnHeadersHeight = 40;
            this.MasVendidosPorCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MasVendidosPorCategoria.DefaultCellStyle = dataGridViewCellStyle18;
            this.MasVendidosPorCategoria.EnableHeadersVisualStyles = false;
            this.MasVendidosPorCategoria.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MasVendidosPorCategoria.Location = new System.Drawing.Point(30, 165);
            this.MasVendidosPorCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MasVendidosPorCategoria.MultiSelect = false;
            this.MasVendidosPorCategoria.Name = "MasVendidosPorCategoria";
            this.MasVendidosPorCategoria.ReadOnly = true;
            this.MasVendidosPorCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MasVendidosPorCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.MasVendidosPorCategoria.RowHeadersWidth = 15;
            this.MasVendidosPorCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.MasVendidosPorCategoria.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.MasVendidosPorCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MasVendidosPorCategoria.Size = new System.Drawing.Size(740, 508);
            this.MasVendidosPorCategoria.TabIndex = 62;
            // 
            // InterfazRepoMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 768);
            this.Controls.Add(this.MasVendidos_Label);
            this.Controls.Add(this.MasVendidosPorCategoria);
            this.Controls.Add(this.Boton_Salir);
            this.Name = "InterfazRepoMasVendidos";
            this.Text = "InterfazMasVendidos";
            this.Load += new System.EventHandler(this.InterfazRepoMasVendidos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventana_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MasVendidosPorCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_Salir;
        private System.Windows.Forms.Label MasVendidos_Label;
        private System.Windows.Forms.DataGridView MasVendidosPorCategoria;
    }
}