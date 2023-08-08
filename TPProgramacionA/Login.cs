using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPProgramacionA.ClasesModuloUsuarios;
using TPProgramacionA.GestionDeUsuarios;
using MySql.Data.MySqlClient;
using TPProgramacionA.clases;


namespace TPProgramacionA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validarCampos();
            autentificarUsuario();

            

        }

        private void LinkOlvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            this.Hide();    
            recuperarPassword recuperarPassword = new recuperarPassword();           
            recuperarPassword.FormClosed += (s,args) => this.Close();
            recuperarPassword.Show();
            
        }
        private bool validarCampos()
        {
            //Creamos variable booleana. La iniciamos en Verdadero.
            bool error = true;


            //Si el texto está VACIO, ingresa al if.
            if (TXT1.Text == "")
            {
                //Error pasa a Falso y se SETEA el Texto del errorProvider.
                error = false;
                errorProvider1.SetError(TXT1, "Ingrese su usuario");
            }
            else
            {
                //Si el campo no está vacío, se vacia el texto que pueda contener el Error.
                //En caso de que haya quedado cargado anteriormente.
                errorProvider1.Clear();
            }

            if (TXT2.Text == "")
            {
                error = false;
                errorProvider1.SetError(TXT2, "Ingrese su contraseña");
            }
            else
            {
                errorProvider1.Clear();
            }

            return error;

        }
        

        public void autentificarUsuario()
        {
            string server = "localhost";
            string user = "root";
            string pwd = "";
            string DB = "programacion";
            string cadenaConexion = "server=" + server + ";user=" + user + ";pwd=" + pwd + ";database=" + DB;


            string MysqlValidarUser = @"SELECT username, password 
                                        FROM usuario WHERE username='" + TXT1.Text + 
                                        "'and password ='" + TXT2.Text +
                                        "' and activo = 1";

          
            try
            {
                
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);

                conectar.Open();

                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectamos = new MySqlConnection();
                codigo.Connection = conectar;
                

                MySqlCommand comandoValidarPasswordEncriptada = new MySqlCommand(MysqlValidarUser, conectar);
                //string passEncriptada = ClasesModuloUsuarios.HashCode.CodificacionPassword(TXT2.Text); // SOLO SI USAN ENCRIPTACION

                comandoValidarPasswordEncriptada.Parameters.AddWithValue("@username", TXT1.Text);
                //NO ME TOMA LAS PW ENCRIPTADAS.
                comandoValidarPasswordEncriptada.Parameters.AddWithValue("@password", TXT2.Text);


                comandoValidarPasswordEncriptada.CommandText = MysqlValidarUser;
                MySqlDataReader leer = comandoValidarPasswordEncriptada.ExecuteReader();
                if (leer.Read())
                {
                    this.Hide(); // hago invisible el form actual
                    menuUsuario OBJMenuUsuario = new menuUsuario();
                    OBJMenuUsuario.FormClosed += (s, args) => this.Close(); // cuando cierro este form, cierro el programa.
                    OBJMenuUsuario.LBUsuario.Text = TXT1.Text;//Le envío el valor del TXTUusuario al Label del otro form
                    //Para que pueda recibirlo, tengo que poner público el Label del otro form.
                    OBJMenuUsuario.Show(); //Con este método abro otro form
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña erronea");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "error");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
