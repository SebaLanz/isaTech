namespace TPProgramacionA.GestionDeUsuarios
{
    partial class modificarUsuarioAdmin
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
            this.CBUsuario = new System.Windows.Forms.ComboBox();
            this.BTTMostrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTPuesto = new System.Windows.Forms.TextBox();
            this.TXTCuit = new System.Windows.Forms.TextBox();
            this.TXTContacto = new System.Windows.Forms.TextBox();
            this.TXTDireccion = new System.Windows.Forms.TextBox();
            this.TXTDni = new System.Windows.Forms.TextBox();
            this.TXTApellido = new System.Windows.Forms.TextBox();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.TXTMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DTFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(0, 0);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(0, 13);
            this.LBUsuario.TabIndex = 0;
            // 
            // CBUsuario
            // 
            this.CBUsuario.FormattingEnabled = true;
            this.CBUsuario.Location = new System.Drawing.Point(63, 22);
            this.CBUsuario.Name = "CBUsuario";
            this.CBUsuario.Size = new System.Drawing.Size(131, 21);
            this.CBUsuario.TabIndex = 46;
            this.CBUsuario.SelectedIndexChanged += new System.EventHandler(this.CBUsuario_SelectedIndexChanged);
            // 
            // BTTMostrar
            // 
            this.BTTMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTTMostrar.Location = new System.Drawing.Point(198, 369);
            this.BTTMostrar.Name = "BTTMostrar";
            this.BTTMostrar.Size = new System.Drawing.Size(177, 31);
            this.BTTMostrar.TabIndex = 87;
            this.BTTMostrar.Text = "Mostrar Datos";
            this.BTTMostrar.UseVisualStyleBackColor = true;
            this.BTTMostrar.Click += new System.EventHandler(this.BTTMostrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(194, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 20);
            this.label11.TabIndex = 86;
            this.label11.Text = "Puesto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 84;
            this.label9.Text = "Cuit:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Contacto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(194, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 82;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Mail:";
            // 
            // TXTPuesto
            // 
            this.TXTPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPuesto.Location = new System.Drawing.Point(391, 310);
            this.TXTPuesto.Name = "TXTPuesto";
            this.TXTPuesto.Size = new System.Drawing.Size(215, 26);
            this.TXTPuesto.TabIndex = 77;
            // 
            // TXTCuit
            // 
            this.TXTCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCuit.Location = new System.Drawing.Point(391, 243);
            this.TXTCuit.Name = "TXTCuit";
            this.TXTCuit.Size = new System.Drawing.Size(215, 26);
            this.TXTCuit.TabIndex = 75;
            // 
            // TXTContacto
            // 
            this.TXTContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTContacto.Location = new System.Drawing.Point(391, 212);
            this.TXTContacto.Name = "TXTContacto";
            this.TXTContacto.Size = new System.Drawing.Size(215, 26);
            this.TXTContacto.TabIndex = 74;
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDireccion.Location = new System.Drawing.Point(391, 182);
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.Size = new System.Drawing.Size(215, 26);
            this.TXTDireccion.TabIndex = 73;
            // 
            // TXTDni
            // 
            this.TXTDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDni.Location = new System.Drawing.Point(391, 150);
            this.TXTDni.Name = "TXTDni";
            this.TXTDni.Size = new System.Drawing.Size(215, 26);
            this.TXTDni.TabIndex = 72;
            // 
            // TXTApellido
            // 
            this.TXTApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTApellido.Location = new System.Drawing.Point(391, 116);
            this.TXTApellido.Name = "TXTApellido";
            this.TXTApellido.Size = new System.Drawing.Size(215, 26);
            this.TXTApellido.TabIndex = 71;
            // 
            // TXTNombre
            // 
            this.TXTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombre.Location = new System.Drawing.Point(391, 86);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(215, 26);
            this.TXTNombre.TabIndex = 70;
            // 
            // TXTMail
            // 
            this.TXTMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMail.Location = new System.Drawing.Point(391, 50);
            this.TXTMail.Name = "TXTMail";
            this.TXTMail.Size = new System.Drawing.Size(215, 26);
            this.TXTMail.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(429, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 31);
            this.button1.TabIndex = 68;
            this.button1.Text = "Modificar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DTFecha
            // 
            this.DTFecha.Location = new System.Drawing.Point(391, 276);
            this.DTFecha.Name = "DTFecha";
            this.DTFecha.Size = new System.Drawing.Size(215, 20);
            this.DTFecha.TabIndex = 88;
            this.DTFecha.ValueChanged += new System.EventHandler(this.DTFecha_ValueChanged);
            // 
            // modificarUsuarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 487);
            this.Controls.Add(this.DTFecha);
            this.Controls.Add(this.BTTMostrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTPuesto);
            this.Controls.Add(this.TXTCuit);
            this.Controls.Add(this.TXTContacto);
            this.Controls.Add(this.TXTDireccion);
            this.Controls.Add(this.TXTDni);
            this.Controls.Add(this.TXTApellido);
            this.Controls.Add(this.TXTNombre);
            this.Controls.Add(this.TXTMail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBUsuario);
            this.Controls.Add(this.LBUsuario);
            this.Name = "modificarUsuarioAdmin";
            this.Text = "modificarUsuarioAdmin";
            this.Load += new System.EventHandler(this.modificarUsuarioAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.ComboBox CBUsuario;
        private System.Windows.Forms.Button BTTMostrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTPuesto;
        private System.Windows.Forms.TextBox TXTCuit;
        private System.Windows.Forms.TextBox TXTContacto;
        private System.Windows.Forms.TextBox TXTDireccion;
        private System.Windows.Forms.TextBox TXTDni;
        private System.Windows.Forms.TextBox TXTApellido;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.TextBox TXTMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DTFecha;
    }
}