namespace TPProgramacionA.GestionDeRecurso
{
    partial class menuRecurso
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
            this.BTBSolicitar = new System.Windows.Forms.Button();
            this.BTNVer = new System.Windows.Forms.Button();
            this.BTNAprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(2, 9);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(9, 13);
            this.LBUsuario.TabIndex = 0;
            this.LBUsuario.Text = "l";
            // 
            // BTBSolicitar
            // 
            this.BTBSolicitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBSolicitar.Location = new System.Drawing.Point(86, 149);
            this.BTBSolicitar.Name = "BTBSolicitar";
            this.BTBSolicitar.Size = new System.Drawing.Size(148, 103);
            this.BTBSolicitar.TabIndex = 1;
            this.BTBSolicitar.Text = "Solicitar Licencia";
            this.BTBSolicitar.UseVisualStyleBackColor = true;
            this.BTBSolicitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNVer
            // 
            this.BTNVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVer.Location = new System.Drawing.Point(516, 149);
            this.BTNVer.Name = "BTNVer";
            this.BTNVer.Size = new System.Drawing.Size(148, 103);
            this.BTNVer.TabIndex = 2;
            this.BTNVer.Text = "Ver Licencias - Vacaciones Solicitadas";
            this.BTNVer.UseVisualStyleBackColor = true;
            this.BTNVer.Click += new System.EventHandler(this.BTNVer_Click);
            // 
            // BTNAprobar
            // 
            this.BTNAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAprobar.Location = new System.Drawing.Point(299, 149);
            this.BTNAprobar.Name = "BTNAprobar";
            this.BTNAprobar.Size = new System.Drawing.Size(148, 103);
            this.BTNAprobar.TabIndex = 3;
            this.BTNAprobar.Text = "Licencias - Vacaciones Pendientes de Aprobar";
            this.BTNAprobar.UseVisualStyleBackColor = true;
            this.BTNAprobar.Visible = false;
            this.BTNAprobar.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNAprobar);
            this.Controls.Add(this.BTNVer);
            this.Controls.Add(this.BTBSolicitar);
            this.Controls.Add(this.LBUsuario);
            this.Name = "menuRecurso";
            this.Text = "menuRecurso";
            this.Load += new System.EventHandler(this.menuRecurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.Button BTBSolicitar;
        private System.Windows.Forms.Button BTNVer;
        private System.Windows.Forms.Button BTNAprobar;
    }
}