using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPProgramacionA.GestionDeInforme
{
    public partial class menuInforme : Form
    {
        public menuInforme()
        {
            InitializeComponent();
        }

        private void BTNUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeInforme.informeDeUsuario OBJMenuInforme = new GestionDeInforme.informeDeUsuario();
            OBJMenuInforme.LBUsuario.Text = LBUsuario.Text;
            OBJMenuInforme.FormClosed += (s, args) => this.Close();
            OBJMenuInforme.Show();
        }

        private void BTBLicencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeInforme.informeLicencia OBJInformeLicencia = new GestionDeInforme.informeLicencia();
            OBJInformeLicencia.LBUsuario.Text = LBUsuario.Text;
            OBJInformeLicencia.FormClosed += (s, args) => this.Close();
            OBJInformeLicencia.Show();
        }
    }
}
