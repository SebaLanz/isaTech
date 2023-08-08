namespace TPProgramacionA.GestionDeUsuarios
{
    partial class bajaDeUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGWUser = new System.Windows.Forms.DataGridView();
            this.BTTMostrar = new System.Windows.Forms.Button();
            this.BTTBajaUsuario = new System.Windows.Forms.Button();
            this.TXTUser = new System.Windows.Forms.TextBox();
            this.LBIncorrecto = new System.Windows.Forms.Label();
            this.BTTBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGWUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWUser
            // 
            this.DGWUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGWUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGWUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWUser.Location = new System.Drawing.Point(149, 166);
            this.DGWUser.Name = "DGWUser";
            this.DGWUser.Size = new System.Drawing.Size(710, 316);
            this.DGWUser.TabIndex = 0;
            this.DGWUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWUser_CellContentClick);
            // 
            // BTTMostrar
            // 
            this.BTTMostrar.Location = new System.Drawing.Point(429, 116);
            this.BTTMostrar.Name = "BTTMostrar";
            this.BTTMostrar.Size = new System.Drawing.Size(147, 35);
            this.BTTMostrar.TabIndex = 1;
            this.BTTMostrar.Text = "Mostrar Usuarios";
            this.BTTMostrar.UseVisualStyleBackColor = true;
            this.BTTMostrar.Click += new System.EventHandler(this.BTTBuscar_Click);
            // 
            // BTTBajaUsuario
            // 
            this.BTTBajaUsuario.Location = new System.Drawing.Point(660, 116);
            this.BTTBajaUsuario.Name = "BTTBajaUsuario";
            this.BTTBajaUsuario.Size = new System.Drawing.Size(147, 35);
            this.BTTBajaUsuario.TabIndex = 2;
            this.BTTBajaUsuario.Text = "Dar de baja";
            this.BTTBajaUsuario.UseVisualStyleBackColor = true;
            this.BTTBajaUsuario.Click += new System.EventHandler(this.BTTBajaUsuario_Click);
            // 
            // TXTUser
            // 
            this.TXTUser.Location = new System.Drawing.Point(172, 83);
            this.TXTUser.Name = "TXTUser";
            this.TXTUser.Size = new System.Drawing.Size(147, 20);
            this.TXTUser.TabIndex = 3;
            // 
            // LBIncorrecto
            // 
            this.LBIncorrecto.AutoSize = true;
            this.LBIncorrecto.Location = new System.Drawing.Point(366, 127);
            this.LBIncorrecto.Name = "LBIncorrecto";
            this.LBIncorrecto.Size = new System.Drawing.Size(0, 13);
            this.LBIncorrecto.TabIndex = 4;
            // 
            // BTTBuscar
            // 
            this.BTTBuscar.Location = new System.Drawing.Point(172, 116);
            this.BTTBuscar.Name = "BTTBuscar";
            this.BTTBuscar.Size = new System.Drawing.Size(147, 35);
            this.BTTBuscar.TabIndex = 6;
            this.BTTBuscar.Text = "Buscar Usuario";
            this.BTTBuscar.UseVisualStyleBackColor = true;
            this.BTTBuscar.Click += new System.EventHandler(this.BTTBuscar_Click_1);
            // 
            // bajaDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1154, 690);
            this.Controls.Add(this.BTTBuscar);
            this.Controls.Add(this.LBIncorrecto);
            this.Controls.Add(this.TXTUser);
            this.Controls.Add(this.BTTBajaUsuario);
            this.Controls.Add(this.BTTMostrar);
            this.Controls.Add(this.DGWUser);
            this.Name = "bajaDeUsuario";
            this.Text = "bajaDeUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.DGWUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGWUser;
        private System.Windows.Forms.Button BTTMostrar;
        private System.Windows.Forms.Button BTTBajaUsuario;
        private System.Windows.Forms.TextBox TXTUser;
        private System.Windows.Forms.Label LBIncorrecto;
        private System.Windows.Forms.Button BTTBuscar;
    }
}