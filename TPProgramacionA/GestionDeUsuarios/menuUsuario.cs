using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPProgramacionA.clases;
using TPProgramacionA.GestionDeUsuarios;

namespace TPProgramacionA.GestionDeUsuarios
{
    public partial class menuUsuario : Form
    {
        public menuUsuario()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void BTTGestionUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuGestionUsuario OBJMenuGestionUsuario = new menuGestionUsuario();
            OBJMenuGestionUsuario.LBUsuario.Text = LBUsuario.Text;
            OBJMenuGestionUsuario.FormClosed += (s, args) => this.Close();
            OBJMenuGestionUsuario.Show();
        }

        private void BTTGestionPermiso_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDePermiso.menuGestionDePermiso OBJMenuGestionPermiso = new GestionDePermiso.menuGestionDePermiso();
            OBJMenuGestionPermiso.LBUsuario.Text = LBUsuario.Text;
            OBJMenuGestionPermiso.FormClosed += (s, args) => this.Close();
            OBJMenuGestionPermiso.Show();
        }
        private void volverLogin()
        {
            this.Hide(); // hago invisible el form actual
            Login OBJMenuLogin = new Login();
            OBJMenuLogin.FormClosed += (s, args) => this.Close(); // cuando cierro este form, cierro el programa.

            //Para que pueda recibirlo, tengo que poner público el Label del otro form.
            OBJMenuLogin.Show(); //Con este método abro otro form
        }
        private void visibilizarBotones()
        {
            
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);


            string seleccionarPermiso = @"SELECT p.permiso
                                          FROM usuario u
                                          INNER JOIN usuario_permiso up ON u.id_usuario = up.id_usuario
                                          INNER JOIN permisos p ON up.id_permiso = p.id_permiso
                                          WHERE u.username ='" + LBUsuario.Text+"'";
            conectar.Open();
            MySqlCommand comandoValidarPermiso = new MySqlCommand(seleccionarPermiso, conectar);                                
            MySqlDataReader leerbd = comandoValidarPermiso.ExecuteReader();

            while (leerbd.Read()) { 
                if (leerbd["permiso"].ToString() == "admin"){
                    BTTGestionInforme.Enabled = true; BTTGestionPermiso.Enabled = true; BTTGestionRecurso.Enabled = true; BTTGestionUsuario.Enabled = true;
                    break;
                }
                if (leerbd["permiso"].ToString() == "user" || leerbd["permiso"].ToString() == "gestor" || leerbd["permiso"].ToString() == "analyst")
                {
                    BTTGestionInforme.Enabled = true; BTTGestionPermiso.Enabled = false; BTTGestionRecurso.Enabled = true; BTTGestionUsuario.Enabled = true;
                    break ;
                }
                if (leerbd["permiso"].ToString() == "invitado")
                {
                    BTTGestionInforme.Enabled = true; BTTGestionPermiso.Enabled = false; BTTGestionRecurso.Enabled = false; BTTGestionUsuario.Enabled = false;
                }
               
            }
            conectar.Close();        
        }

    
        private void menuUsuario_Load(object sender, EventArgs e)
        {
           

            BTTGestionInforme.Enabled = false;BTTGestionPermiso.Enabled = false;BTTGestionRecurso.Enabled = false;BTTGestionUsuario.Enabled = false;
            visibilizarBotones();
            if (BTTGestionInforme.Enabled == false & BTTGestionPermiso.Enabled == false & BTTGestionRecurso.Enabled == false & BTTGestionUsuario.Enabled == false)
            {
                MessageBox.Show("Usted no tiene permisos para operar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            volverLogin();
        }

        private void BTTGestionRecurso_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeRecurso.menuRecurso OBJMenuGestionRecurso = new GestionDeRecurso.menuRecurso();
            OBJMenuGestionRecurso.LBUsuario.Text = LBUsuario.Text;
            OBJMenuGestionRecurso.FormClosed += (s, args) => this.Close();
            OBJMenuGestionRecurso.Show();
        }

        private void BTTGestionInforme_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeInforme.menuInforme OBJMenuInforme = new GestionDeInforme.menuInforme();
            OBJMenuInforme.LBUsuario.Text = LBUsuario.Text;
            OBJMenuInforme.FormClosed += (s, args) => this.Close();
            OBJMenuInforme.Show();
        }
    }
}
