namespace TPProgramacionA.GestionDeInforme
{
    partial class menuInforme
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
            this.LBUsuario = new System.Windows.Forms.Label();
            this.BTNUsuario = new System.Windows.Forms.Button();
            this.BTBLicencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(12, 9);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(35, 13);
            this.LBUsuario.TabIndex = 0;
            this.LBUsuario.Text = "label1";
            // 
            // BTNUsuario
            // 
            this.BTNUsuario.Location = new System.Drawing.Point(193, 161);
            this.BTNUsuario.Name = "BTNUsuario";
            this.BTNUsuario.Size = new System.Drawing.Size(126, 63);
            this.BTNUsuario.TabIndex = 1;
            this.BTNUsuario.Text = "Informe de Usuarios";
            this.BTNUsuario.UseVisualStyleBackColor = true;
            this.BTNUsuario.Click += new System.EventHandler(this.BTNUsuario_Click);
            // 
            // BTBLicencia
            // 
            this.BTBLicencia.Location = new System.Drawing.Point(423, 161);
            this.BTBLicencia.Name = "BTBLicencia";
            this.BTBLicencia.Size = new System.Drawing.Size(126, 63);
            this.BTBLicencia.TabIndex = 2;
            this.BTBLicencia.Text = "Informe de Solicitudes de Licencias";
            this.BTBLicencia.UseVisualStyleBackColor = true;
            this.BTBLicencia.Click += new System.EventHandler(this.BTBLicencia_Click);
            // 
            // menuInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTBLicencia);
            this.Controls.Add(this.BTNUsuario);
            this.Controls.Add(this.LBUsuario);
            this.Name = "menuInforme";
            this.Text = "menuInforme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.Button BTNUsuario;
        private System.Windows.Forms.Button BTBLicencia;
    }
}