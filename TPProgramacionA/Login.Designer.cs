namespace TPProgramacionA
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDD = new TPProgramacionA.BDD();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.TXT2 = new System.Windows.Forms.TextBox();
            this.BTNIngresar = new System.Windows.Forms.Button();
            this.LinkOlvido = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // bDDBindingSource
            // 
            this.bDDBindingSource.DataSource = this.bDD;
            this.bDDBindingSource.Position = 0;
            // 
            // bDD
            // 
            this.bDD.DataSetName = "BDD";
            this.bDD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TXT1
            // 
            this.TXT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT1.Location = new System.Drawing.Point(358, 122);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(100, 26);
            this.TXT1.TabIndex = 0;
            // 
            // TXT2
            // 
            this.TXT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT2.Location = new System.Drawing.Point(358, 162);
            this.TXT2.Name = "TXT2";
            this.TXT2.PasswordChar = '*';
            this.TXT2.Size = new System.Drawing.Size(100, 26);
            this.TXT2.TabIndex = 1;
            // 
            // BTNIngresar
            // 
            this.BTNIngresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNIngresar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.BTNIngresar.FlatAppearance.BorderSize = 2;
            this.BTNIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIngresar.Location = new System.Drawing.Point(358, 215);
            this.BTNIngresar.Name = "BTNIngresar";
            this.BTNIngresar.Size = new System.Drawing.Size(100, 42);
            this.BTNIngresar.TabIndex = 2;
            this.BTNIngresar.Text = "Ingresar";
            this.BTNIngresar.UseVisualStyleBackColor = false;
            this.BTNIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LinkOlvido
            // 
            this.LinkOlvido.AutoSize = true;
            this.LinkOlvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkOlvido.Location = new System.Drawing.Point(172, 284);
            this.LinkOlvido.Name = "LinkOlvido";
            this.LinkOlvido.Size = new System.Drawing.Size(170, 20);
            this.LinkOlvido.TabIndex = 3;
            this.LinkOlvido.TabStop = true;
            this.LinkOlvido.Text = "¿Olvidó la contrasena?";
            this.LinkOlvido.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkOlvido_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(522, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNIngresar);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.LinkOlvido);
            this.Controls.Add(this.TXT2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.BindingSource bDDBindingSource;
        private BDD bDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkOlvido;
        private System.Windows.Forms.Button BTNIngresar;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.TextBox TXT2;
    }
}

