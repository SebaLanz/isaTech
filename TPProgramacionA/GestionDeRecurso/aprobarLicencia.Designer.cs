namespace TPProgramacionA.GestionDeRecurso
{
    partial class aprobarLicencia
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBUsuario = new System.Windows.Forms.Label();
            this.CMBUsuario = new System.Windows.Forms.ComboBox();
            this.DGVLicencia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAprobar = new System.Windows.Forms.Button();
            this.BTNRechazar = new System.Windows.Forms.Button();
            this.TXTRazon = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLicencia)).BeginInit();
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
            // CMBUsuario
            // 
            this.CMBUsuario.FormattingEnabled = true;
            this.CMBUsuario.Location = new System.Drawing.Point(70, 82);
            this.CMBUsuario.Name = "CMBUsuario";
            this.CMBUsuario.Size = new System.Drawing.Size(185, 21);
            this.CMBUsuario.TabIndex = 1;
            this.CMBUsuario.SelectedIndexChanged += new System.EventHandler(this.CMBUsuario_SelectedIndexChanged);
            // 
            // DGVLicencia
            // 
            this.DGVLicencia.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLicencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVLicencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLicencia.Location = new System.Drawing.Point(288, 82);
            this.DGVLicencia.Name = "DGVLicencia";
            this.DGVLicencia.Size = new System.Drawing.Size(444, 219);
            this.DGVLicencia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuarios solicitantes";
            // 
            // BTNAprobar
            // 
            this.BTNAprobar.Location = new System.Drawing.Point(70, 271);
            this.BTNAprobar.Name = "BTNAprobar";
            this.BTNAprobar.Size = new System.Drawing.Size(86, 30);
            this.BTNAprobar.TabIndex = 7;
            this.BTNAprobar.Text = "Aprobar";
            this.BTNAprobar.UseVisualStyleBackColor = true;
            this.BTNAprobar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNRechazar
            // 
            this.BTNRechazar.Location = new System.Drawing.Point(169, 271);
            this.BTNRechazar.Name = "BTNRechazar";
            this.BTNRechazar.Size = new System.Drawing.Size(86, 30);
            this.BTNRechazar.TabIndex = 8;
            this.BTNRechazar.Text = "Rechazar";
            this.BTNRechazar.UseVisualStyleBackColor = true;
            this.BTNRechazar.Click += new System.EventHandler(this.BTNRechazar_Click_1);
            // 
            // TXTRazon
            // 
            this.TXTRazon.Location = new System.Drawing.Point(70, 178);
            this.TXTRazon.Name = "TXTRazon";
            this.TXTRazon.Size = new System.Drawing.Size(185, 20);
            this.TXTRazon.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(48, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Indicar Razón de Rechazo.";
            // 
            // aprobarLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTRazon);
            this.Controls.Add(this.BTNRechazar);
            this.Controls.Add(this.BTNAprobar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVLicencia);
            this.Controls.Add(this.CMBUsuario);
            this.Controls.Add(this.LBUsuario);
            this.Name = "aprobarLicencia";
            this.Text = "aprobarLicencia";
            this.Load += new System.EventHandler(this.aprobarLicencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLicencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.ComboBox CMBUsuario;
        private System.Windows.Forms.DataGridView DGVLicencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNAprobar;
        private System.Windows.Forms.Button BTNRechazar;
        private System.Windows.Forms.TextBox TXTRazon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
    }
}