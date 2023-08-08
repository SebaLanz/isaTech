using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPProgramacionA.GestionDeRecurso
{
    public partial class menuRecurso : Form
    {
        public menuRecurso()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void visibilizarBotones() //Método para visibilizar el módulo de Aprobar licencia
        {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlVerificar = @"SELECT username 
                                    FROM usuario u
                                    WHERE u.username ='" + LBUsuario.Text + "' AND u.supervisor = 1";
            conectar.Open();
            MySqlCommand comandoValidarUsuario = new MySqlCommand(SqlVerificar, conectar);           
            MySqlDataReader leerbd = comandoValidarUsuario.ExecuteReader();
            if (leerbd.Read()){
                BTNAprobar.Visible = true;
                conectar.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeRecurso.solicitarLicencia OBJSolicitarLicencia = new GestionDeRecurso.solicitarLicencia();
            OBJSolicitarLicencia.LBUsuario.Text = LBUsuario.Text;
            OBJSolicitarLicencia.FormClosed += (s, args) => this.Close();
            OBJSolicitarLicencia.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeRecurso.aprobarLicencia OBJAprobarLicencia = new GestionDeRecurso.aprobarLicencia();
            OBJAprobarLicencia.LBUsuario.Text = LBUsuario.Text;
            OBJAprobarLicencia.FormClosed += (s, args) => this.Close();
            OBJAprobarLicencia.Show();
        }

        private void menuRecurso_Load(object sender, EventArgs e)
        {
            visibilizarBotones();
        }

        private void BTNVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeRecurso.verLicencia OBJVerLicencia = new GestionDeRecurso.verLicencia();
            OBJVerLicencia.LBUsuario.Text = LBUsuario.Text;
            OBJVerLicencia.FormClosed += (s, args) => this.Close();
            OBJVerLicencia.Show();
        }
    }
}
