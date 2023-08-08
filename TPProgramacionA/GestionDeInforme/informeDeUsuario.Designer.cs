namespace TPProgramacionA.GestionDeInforme
{
    partial class informeDeUsuario
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
            this.DGVUsuario = new System.Windows.Forms.DataGridView();
            this.CBUsuario = new System.Windows.Forms.ComboBox();
            this.BTNUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNInforme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).BeginInit();
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
            // DGVUsuario
            // 
            this.DGVUsuario.BackgroundColor = System.Drawing.Color.White;
            this.DGVUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuario.Location = new System.Drawing.Point(203, 82);
            this.DGVUsuario.Name = "DGVUsuario";
            this.DGVUsuario.Size = new System.Drawing.Size(585, 239);
            this.DGVUsuario.TabIndex = 0;
            // 
            // CBUsuario
            // 
            this.CBUsuario.FormattingEnabled = true;
            this.CBUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBUsuario.Location = new System.Drawing.Point(39, 105);
            this.CBUsuario.Name = "CBUsuario";
            this.CBUsuario.Size = new System.Drawing.Size(121, 21);
            this.CBUsuario.TabIndex = 1;
            // 
            // BTNUsuario
            // 
            this.BTNUsuario.Location = new System.Drawing.Point(39, 160);
            this.BTNUsuario.Name = "BTNUsuario";
            this.BTNUsuario.Size = new System.Drawing.Size(121, 29);
            this.BTNUsuario.TabIndex = 2;
            this.BTNUsuario.Text = "Mostrar Usuarios";
            this.BTNUsuario.UseVisualStyleBackColor = true;
            this.BTNUsuario.Click += new System.EventHandler(this.BTNUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar Estado de Usuario";
            // 
            // BTNInforme
            // 
            this.BTNInforme.Location = new System.Drawing.Point(372, 344);
            this.BTNInforme.Name = "BTNInforme";
            this.BTNInforme.Size = new System.Drawing.Size(144, 33);
            this.BTNInforme.TabIndex = 4;
            this.BTNInforme.Text = "Importar Informe";
            this.BTNInforme.UseVisualStyleBackColor = true;
            this.BTNInforme.Click += new System.EventHandler(this.BTNInforme_Click);
            // 
            // informeDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNInforme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNUsuario);
            this.Controls.Add(this.CBUsuario);
            this.Controls.Add(this.DGVUsuario);
            this.Controls.Add(this.LBUsuario);
            this.Name = "informeDeUsuario";
            this.Text = "informeDeUsuario";
            this.Load += new System.EventHandler(this.informeDeUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.DataGridView DGVUsuario;
        private System.Windows.Forms.ComboBox CBUsuario;
        private System.Windows.Forms.Button BTNUsuario;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNInforme;
    }
}