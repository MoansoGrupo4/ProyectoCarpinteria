namespace MantenedorClientes
{
    partial class MantenedorGridCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.Inhabilitar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Insertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaClientes
            // 
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Location = new System.Drawing.Point(16, 74);
            this.tablaClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaClientes.MultiSelect = false;
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.RowHeadersWidth = 51;
            this.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaClientes.Size = new System.Drawing.Size(945, 331);
            this.tablaClientes.TabIndex = 3;
            this.tablaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaClientes_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1039, 160);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Inhabilitar
            // 
            this.Inhabilitar.Location = new System.Drawing.Point(1039, 220);
            this.Inhabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inhabilitar.Name = "Inhabilitar";
            this.Inhabilitar.Size = new System.Drawing.Size(100, 41);
            this.Inhabilitar.TabIndex = 6;
            this.Inhabilitar.Text = "Inhabilitar";
            this.Inhabilitar.UseVisualStyleBackColor = true;
            this.Inhabilitar.Click += new System.EventHandler(this.Inhabilitar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(1039, 293);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(100, 41);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(163, 37);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(684, 22);
            this.txtRazonSocial.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Razon Social:";
            // 
            // Insertar
            // 
            this.Insertar.Location = new System.Drawing.Point(1039, 85);
            this.Insertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Insertar.Name = "Insertar";
            this.Insertar.Size = new System.Drawing.Size(100, 41);
            this.Insertar.TabIndex = 4;
            this.Insertar.Text = "Nuevo";
            this.Insertar.UseVisualStyleBackColor = true;
            this.Insertar.Click += new System.EventHandler(this.Insertar_Click);
            // 
            // MantenedorGridCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Inhabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.Insertar);
            this.Controls.Add(this.tablaClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenedorGridCliente";
            this.Text = "Mantenedor de Clientes";
            this.Load += new System.EventHandler(this.MantenedorGridCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaClientes;
        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button Inhabilitar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insertar;
       
    }
}

