﻿namespace TPProgramacionA.GestionDeRecurso
{
    partial class solicitarLicencia
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
            this.CBLicencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTInicio = new System.Windows.Forms.DateTimePicker();
            this.DTFinal = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(12, 9);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(0, 13);
            this.LBUsuario.TabIndex = 0;
            // 
            // CBLicencia
            // 
            this.CBLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLicencia.FormattingEnabled = true;
            this.CBLicencia.Location = new System.Drawing.Point(28, 156);
            this.CBLicencia.Name = "CBLicencia";
            this.CBLicencia.Size = new System.Drawing.Size(158, 28);
            this.CBLicencia.TabIndex = 1;
            this.CBLicencia.SelectedIndexChanged += new System.EventHandler(this.CBLicencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione su tipo de licencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione su Fecha de inicio ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seleccione hasta que fecha solicita.";
            // 
            // DTInicio
            // 
            this.DTInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTInicio.Location = new System.Drawing.Point(28, 278);
            this.DTInicio.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DTInicio.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DTInicio.Name = "DTInicio";
            this.DTInicio.Size = new System.Drawing.Size(158, 26);
            this.DTInicio.TabIndex = 5;
            this.DTInicio.Value = new System.DateTime(2022, 9, 30, 11, 10, 0, 0);
            // 
            // DTFinal
            // 
            this.DTFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFinal.Location = new System.Drawing.Point(324, 278);
            this.DTFinal.Name = "DTFinal";
            this.DTFinal.Size = new System.Drawing.Size(158, 26);
            this.DTFinal.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar Solicitud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNEnviar
            // 
            this.BTNEnviar.Location = new System.Drawing.Point(425, 415);
            this.BTNEnviar.Name = "BTNEnviar";
            this.BTNEnviar.Size = new System.Drawing.Size(173, 50);
            this.BTNEnviar.TabIndex = 8;
            this.BTNEnviar.Text = "Enviar Solicitud";
            this.BTNEnviar.UseVisualStyleBackColor = true;
            this.BTNEnviar.Click += new System.EventHandler(this.BTNEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(171, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(602, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Formulario para solicitar las Licencias / Vacaciones";
            // 
            // solicitarLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 605);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTNEnviar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTFinal);
            this.Controls.Add(this.DTInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBLicencia);
            this.Controls.Add(this.LBUsuario);
            this.Name = "solicitarLicencia";
            this.Text = "solicitarLicencia";
            this.Load += new System.EventHandler(this.solicitarLicencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.ComboBox CBLicencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTInicio;
        private System.Windows.Forms.DateTimePicker DTFinal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNEnviar;
        private System.Windows.Forms.Label label4;
    }
}