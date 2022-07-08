namespace FormularioCarpinteria
{
    partial class FormDatosModelo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosModelo));
            this.dgvDatosModelo = new System.Windows.Forms.DataGridView();
            this.CodModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTipoMadera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVentaPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVentaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTipoMueble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosModelo
            // 
            this.dgvDatosModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosModelo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosModelo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.dgvDatosModelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosModelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosModelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodModelo,
            this.DesModelo,
            this.CodTipoMadera,
            this.ColorModelo,
            this.PrecioVentaPU,
            this.PrecioVentaPM,
            this.CodTipoMueble,
            this.EstadoModelo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosModelo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatosModelo.EnableHeadersVisualStyles = false;
            this.dgvDatosModelo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.dgvDatosModelo.Location = new System.Drawing.Point(10, 106);
            this.dgvDatosModelo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosModelo.Name = "dgvDatosModelo";
            this.dgvDatosModelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosModelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatosModelo.RowHeadersVisible = false;
            this.dgvDatosModelo.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.dgvDatosModelo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatosModelo.RowTemplate.Height = 24;
            this.dgvDatosModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosModelo.Size = new System.Drawing.Size(700, 269);
            this.dgvDatosModelo.TabIndex = 0;
            // 
            // CodModelo
            // 
            this.CodModelo.DataPropertyName = "CodModelo";
            this.CodModelo.HeaderText = "Código";
            this.CodModelo.MinimumWidth = 6;
            this.CodModelo.Name = "CodModelo";
            this.CodModelo.Width = 81;
            // 
            // DesModelo
            // 
            this.DesModelo.DataPropertyName = "DesModelo";
            this.DesModelo.HeaderText = "Descripción";
            this.DesModelo.MinimumWidth = 6;
            this.DesModelo.Name = "DesModelo";
            this.DesModelo.Width = 106;
            // 
            // CodTipoMadera
            // 
            this.CodTipoMadera.DataPropertyName = "CodTipoMadera";
            this.CodTipoMadera.HeaderText = "Tipo";
            this.CodTipoMadera.MinimumWidth = 6;
            this.CodTipoMadera.Name = "CodTipoMadera";
            this.CodTipoMadera.Width = 57;
            // 
            // ColorModelo
            // 
            this.ColorModelo.DataPropertyName = "ColorModelo";
            this.ColorModelo.HeaderText = "Color";
            this.ColorModelo.MinimumWidth = 6;
            this.ColorModelo.Name = "ColorModelo";
            this.ColorModelo.Width = 67;
            // 
            // PrecioVentaPU
            // 
            this.PrecioVentaPU.DataPropertyName = "PrecioVentaPU";
            this.PrecioVentaPU.HeaderText = "Precio";
            this.PrecioVentaPU.MinimumWidth = 6;
            this.PrecioVentaPU.Name = "PrecioVentaPU";
            this.PrecioVentaPU.Width = 71;
            // 
            // PrecioVentaPM
            // 
            this.PrecioVentaPM.DataPropertyName = "PrecioVentaPM";
            this.PrecioVentaPM.HeaderText = "Precio por Mayor";
            this.PrecioVentaPM.MinimumWidth = 6;
            this.PrecioVentaPM.Name = "PrecioVentaPM";
            this.PrecioVentaPM.Width = 128;
            // 
            // CodTipoMueble
            // 
            this.CodTipoMueble.DataPropertyName = "CodTipoMueble";
            this.CodTipoMueble.HeaderText = "Mueble";
            this.CodTipoMueble.MinimumWidth = 6;
            this.CodTipoMueble.Name = "CodTipoMueble";
            this.CodTipoMueble.Width = 78;
            // 
            // EstadoModelo
            // 
            this.EstadoModelo.DataPropertyName = "EstadoModelo";
            this.EstadoModelo.HeaderText = "Estado";
            this.EstadoModelo.MinimumWidth = 6;
            this.EstadoModelo.Name = "EstadoModelo";
            this.EstadoModelo.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Reporte Modelos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(93, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(618, 23);
            this.txtBuscar.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(561, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 40);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormDatosModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(720, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDatosModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatosModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDatosModelo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoMadera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVentaPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVentaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoMueble;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSalir;
    }
}