namespace TPProgramacionA.GestionDeRecurso
{
    partial class verLicencia
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.DGVLicencia = new System.Windows.Forms.DataGridView();
            this.CBLicencia = new System.Windows.Forms.ComboBox();
            this.BTNMostrar = new System.Windows.Forms.Button();
            this.BTNEditar = new System.Windows.Forms.Button();
            this.DTInicio = new System.Windows.Forms.DateTimePicker();
            this.DTFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
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
            // DGVLicencia
            // 
            this.DGVLicencia.BackgroundColor = System.Drawing.Color.White;
            this.DGVLicencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLicencia.Location = new System.Drawing.Point(171, 90);
            this.DGVLicencia.Name = "DGVLicencia";
            this.DGVLicencia.Size = new System.Drawing.Size(544, 192);
            this.DGVLicencia.TabIndex = 2;
            // 
            // CBLicencia
            // 
            this.CBLicencia.FormattingEnabled = true;
            this.CBLicencia.Location = new System.Drawing.Point(3, 90);
            this.CBLicencia.Name = "CBLicencia";
            this.CBLicencia.Size = new System.Drawing.Size(150, 21);
            this.CBLicencia.TabIndex = 3;
            this.CBLicencia.SelectedIndexChanged += new System.EventHandler(this.CBLicencia_SelectedIndexChanged);
            // 
            // BTNMostrar
            // 
            this.BTNMostrar.BackColor = System.Drawing.Color.Moccasin;
            this.BTNMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNMostrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMostrar.Location = new System.Drawing.Point(356, 307);
            this.BTNMostrar.Name = "BTNMostrar";
            this.BTNMostrar.Size = new System.Drawing.Size(134, 34);
            this.BTNMostrar.TabIndex = 4;
            this.BTNMostrar.Text = "Mostrar licencias";
            this.BTNMostrar.UseVisualStyleBackColor = false;
            this.BTNMostrar.Click += new System.EventHandler(this.BTNMostrar_Click);
            // 
            // BTNEditar
            // 
            this.BTNEditar.BackColor = System.Drawing.Color.Moccasin;
            this.BTNEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNEditar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEditar.Location = new System.Drawing.Point(597, 41);
            this.BTNEditar.Name = "BTNEditar";
            this.BTNEditar.Size = new System.Drawing.Size(61, 34);
            this.BTNEditar.TabIndex = 5;
            this.BTNEditar.Text = "Editar";
            this.BTNEditar.UseVisualStyleBackColor = false;
            this.BTNEditar.Click += new System.EventHandler(this.BTNEditar_Click);
            // 
            // DTInicio
            // 
            this.DTInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTInicio.Location = new System.Drawing.Point(288, 47);
            this.DTInicio.Name = "DTInicio";
            this.DTInicio.Size = new System.Drawing.Size(102, 20);
            this.DTInicio.TabIndex = 6;
            // 
            // DTFinal
            // 
            this.DTFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTFinal.Location = new System.Drawing.Point(440, 47);
            this.DTFinal.Name = "DTFinal";
            this.DTFinal.Size = new System.Drawing.Size(102, 20);
            this.DTFinal.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modificar Fechas de Licencias / Vacaciones";
            // 
            // verLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTFinal);
            this.Controls.Add(this.DTInicio);
            this.Controls.Add(this.BTNEditar);
            this.Controls.Add(this.BTNMostrar);
            this.Controls.Add(this.CBLicencia);
            this.Controls.Add(this.DGVLicencia);
            this.Controls.Add(this.LBUsuario);
            this.Name = "verLicencia";
            this.Text = "verLicencia";
            this.Load += new System.EventHandler(this.verLicencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLicencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView DGVLicencia;
        private System.Windows.Forms.ComboBox CBLicencia;
        private System.Windows.Forms.Button BTNMostrar;
        private System.Windows.Forms.Button BTNEditar;
        private System.Windows.Forms.DateTimePicker DTInicio;
        private System.Windows.Forms.DateTimePicker DTFinal;
        public System.Windows.Forms.Label label1;
    }
}