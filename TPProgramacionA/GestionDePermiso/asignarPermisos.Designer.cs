namespace TPProgramacionA.GestionDePermiso
{
    partial class asignarPermisos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVPermisos = new System.Windows.Forms.DataGridView();
            this.CMBUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBPermiso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lberror = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(12, 9);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(9, 13);
            this.LBUsuario.TabIndex = 0;
            this.LBUsuario.Text = "l";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVPermisos);
            this.groupBox1.Location = new System.Drawing.Point(56, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DGVPermisos
            // 
            this.DGVPermisos.AllowUserToAddRows = false;
            this.DGVPermisos.AllowUserToDeleteRows = false;
            this.DGVPermisos.BackgroundColor = System.Drawing.Color.White;
            this.DGVPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPermisos.Location = new System.Drawing.Point(19, 19);
            this.DGVPermisos.Name = "DGVPermisos";
            this.DGVPermisos.ReadOnly = true;
            this.DGVPermisos.Size = new System.Drawing.Size(320, 213);
            this.DGVPermisos.TabIndex = 0;
            this.DGVPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPermisos_CellContentClick);
            // 
            // CMBUsuario
            // 
            this.CMBUsuario.FormattingEnabled = true;
            this.CMBUsuario.Location = new System.Drawing.Point(447, 82);
            this.CMBUsuario.Name = "CMBUsuario";
            this.CMBUsuario.Size = new System.Drawing.Size(132, 21);
            this.CMBUsuario.TabIndex = 4;
            this.CMBUsuario.SelectedIndexChanged += new System.EventHandler(this.CMBUsuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione un usuario";
            // 
            // CMBPermiso
            // 
            this.CMBPermiso.FormattingEnabled = true;
            this.CMBPermiso.Location = new System.Drawing.Point(625, 82);
            this.CMBPermiso.Name = "CMBPermiso";
            this.CMBPermiso.Size = new System.Drawing.Size(132, 21);
            this.CMBPermiso.TabIndex = 6;
            this.CMBPermiso.SelectedIndexChanged += new System.EventHandler(this.CMBPermiso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione un permiso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lberror
            // 
            this.lberror.AutoSize = true;
            this.lberror.Location = new System.Drawing.Point(444, 225);
            this.lberror.Name = "lberror";
            this.lberror.Size = new System.Drawing.Size(0, 13);
            this.lberror.TabIndex = 10;
            // 
            // asignarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lberror);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBPermiso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBUsuario);
            this.Name = "asignarPermisos";
            this.Text = "asignarPermisos";
            this.Load += new System.EventHandler(this.asignarPermisos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVPermisos;
        private System.Windows.Forms.ComboBox CMBUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBPermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lberror;
    }
}