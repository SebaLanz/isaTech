namespace TPProgramacionA.GestionDeUsuarios
{
    partial class menuGestionUsuario
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
            this.BTTAltaUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LBUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTTAltaUsuario
            // 
            this.BTTAltaUsuario.Location = new System.Drawing.Point(187, 135);
            this.BTTAltaUsuario.Name = "BTTAltaUsuario";
            this.BTTAltaUsuario.Size = new System.Drawing.Size(148, 57);
            this.BTTAltaUsuario.TabIndex = 0;
            this.BTTAltaUsuario.Text = "Alta de usuario";
            this.BTTAltaUsuario.UseVisualStyleBackColor = true;
            this.BTTAltaUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificación de usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Consulta de usuario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Baja de usuario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(0, 0);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(0, 13);
            this.LBUsuario.TabIndex = 4;
            // 
            // menuGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBUsuario);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTTAltaUsuario);
            this.Name = "menuGestionUsuario";
            this.Text = "menuGestionUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTTAltaUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label LBUsuario;
    }
}