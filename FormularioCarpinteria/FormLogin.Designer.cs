namespace FormularioCarpinteria
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbNomEmpresa = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomEmpresa
            // 
            this.lbNomEmpresa.AutoSize = true;
            this.lbNomEmpresa.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbNomEmpresa.Location = new System.Drawing.Point(98, 43);
            this.lbNomEmpresa.Name = "lbNomEmpresa";
            this.lbNomEmpresa.Size = new System.Drawing.Size(240, 33);
            this.lbNomEmpresa.TabIndex = 0;
            this.lbNomEmpresa.Text = "Carpintería Aguilar";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLogin.Location = new System.Drawing.Point(151, 316);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(124, 38);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "LOGIN";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbUsuario.Location = new System.Drawing.Point(44, 400);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(72, 22);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(47, 425);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(320, 28);
            this.txtUsuario.TabIndex = 4;
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbContra.Location = new System.Drawing.Point(44, 481);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(95, 20);
            this.lbContra.TabIndex = 5;
            this.lbContra.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(47, 504);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(320, 28);
            this.txtContra.TabIndex = 4;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMensaje.Location = new System.Drawing.Point(45, 545);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(101, 15);
            this.lbMensaje.TabIndex = 6;
            this.lbMensaje.Text = "Mensaje de error";
            // 
            // btnAcceder
            // 
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAcceder.Location = new System.Drawing.Point(146, 613);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(148, 48);
            this.btnAcceder.TabIndex = 7;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormularioCarpinteria.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(134, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(10)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(423, 695);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNomEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Button btnAcceder;
    }
}

