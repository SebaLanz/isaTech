namespace TPProgramacionA.GestionDeUsuarios
{
    partial class menuUsuario
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
            this.BTTGestionUsuario = new System.Windows.Forms.Button();
            this.BTTGestionPermiso = new System.Windows.Forms.Button();
            this.BTTGestionRecurso = new System.Windows.Forms.Button();
            this.BTTGestionInforme = new System.Windows.Forms.Button();
            this.LBUsuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTTGestionUsuario
            // 
            this.BTTGestionUsuario.Location = new System.Drawing.Point(206, 127);
            this.BTTGestionUsuario.Name = "BTTGestionUsuario";
            this.BTTGestionUsuario.Size = new System.Drawing.Size(155, 72);
            this.BTTGestionUsuario.TabIndex = 0;
            this.BTTGestionUsuario.Text = "Gestión de usuario";
            this.BTTGestionUsuario.UseVisualStyleBackColor = true;
            this.BTTGestionUsuario.Click += new System.EventHandler(this.BTTGestionUsuario_Click);
            // 
            // BTTGestionPermiso
            // 
            this.BTTGestionPermiso.Location = new System.Drawing.Point(397, 127);
            this.BTTGestionPermiso.Name = "BTTGestionPermiso";
            this.BTTGestionPermiso.Size = new System.Drawing.Size(155, 72);
            this.BTTGestionPermiso.TabIndex = 1;
            this.BTTGestionPermiso.Text = "Gestionar permiso";
            this.BTTGestionPermiso.UseVisualStyleBackColor = true;
            this.BTTGestionPermiso.Click += new System.EventHandler(this.BTTGestionPermiso_Click);
            // 
            // BTTGestionRecurso
            // 
            this.BTTGestionRecurso.Location = new System.Drawing.Point(206, 231);
            this.BTTGestionRecurso.Name = "BTTGestionRecurso";
            this.BTTGestionRecurso.Size = new System.Drawing.Size(155, 72);
            this.BTTGestionRecurso.TabIndex = 2;
            this.BTTGestionRecurso.Text = "Gestión de recurso";
            this.BTTGestionRecurso.UseVisualStyleBackColor = true;
            this.BTTGestionRecurso.Click += new System.EventHandler(this.BTTGestionRecurso_Click);
            // 
            // BTTGestionInforme
            // 
            this.BTTGestionInforme.Location = new System.Drawing.Point(397, 231);
            this.BTTGestionInforme.Name = "BTTGestionInforme";
            this.BTTGestionInforme.Size = new System.Drawing.Size(155, 72);
            this.BTTGestionInforme.TabIndex = 3;
            this.BTTGestionInforme.Text = "Gestionar informe";
            this.BTTGestionInforme.UseVisualStyleBackColor = true;
            this.BTTGestionInforme.Click += new System.EventHandler(this.BTTGestionInforme_Click);
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(12, 9);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(0, 13);
            this.LBUsuario.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBUsuario);
            this.Controls.Add(this.BTTGestionInforme);
            this.Controls.Add(this.BTTGestionRecurso);
            this.Controls.Add(this.BTTGestionPermiso);
            this.Controls.Add(this.BTTGestionUsuario);
            this.Name = "menuUsuario";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.menuUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTTGestionUsuario;
        private System.Windows.Forms.Button BTTGestionPermiso;
        private System.Windows.Forms.Button BTTGestionRecurso;
        private System.Windows.Forms.Button BTTGestionInforme;
        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.Button button1;
    }
}