namespace TPProgramacionA.GestionDeUsuarios
{
    partial class consultaUsuario
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
            this.TXTUser = new System.Windows.Forms.TextBox();
            this.BTTConsultar = new System.Windows.Forms.Button();
            this.DGWUser = new System.Windows.Forms.DataGridView();
            this.LBIncorrecto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGWUser)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTUser
            // 
            this.TXTUser.Location = new System.Drawing.Point(449, 98);
            this.TXTUser.Name = "TXTUser";
            this.TXTUser.Size = new System.Drawing.Size(111, 20);
            this.TXTUser.TabIndex = 0;
            // 
            // BTTConsultar
            // 
            this.BTTConsultar.Location = new System.Drawing.Point(449, 132);
            this.BTTConsultar.Name = "BTTConsultar";
            this.BTTConsultar.Size = new System.Drawing.Size(111, 46);
            this.BTTConsultar.TabIndex = 3;
            this.BTTConsultar.Text = "Consultar";
            this.BTTConsultar.UseVisualStyleBackColor = true;
            this.BTTConsultar.Click += new System.EventHandler(this.BTTConsultar_Click);
            // 
            // DGWUser
            // 
            this.DGWUser.BackgroundColor = System.Drawing.Color.White;
            this.DGWUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWUser.Location = new System.Drawing.Point(46, 204);
            this.DGWUser.Name = "DGWUser";
            this.DGWUser.Size = new System.Drawing.Size(938, 222);
            this.DGWUser.TabIndex = 4;
            this.DGWUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWUser_CellContentClick);
            // 
            // LBIncorrecto
            // 
            this.LBIncorrecto.AutoSize = true;
            this.LBIncorrecto.Location = new System.Drawing.Point(588, 101);
            this.LBIncorrecto.Name = "LBIncorrecto";
            this.LBIncorrecto.Size = new System.Drawing.Size(0, 13);
            this.LBIncorrecto.TabIndex = 5;
            this.LBIncorrecto.Click += new System.EventHandler(this.label1_Click);
            // 
            // consultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 618);
            this.Controls.Add(this.LBIncorrecto);
            this.Controls.Add(this.DGWUser);
            this.Controls.Add(this.BTTConsultar);
            this.Controls.Add(this.TXTUser);
            this.Name = "consultaUsuario";
            this.Text = "consultaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DGWUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTUser;
        private System.Windows.Forms.Button BTTConsultar;
        private System.Windows.Forms.DataGridView DGWUser;
        private System.Windows.Forms.Label LBIncorrecto;
    }
}