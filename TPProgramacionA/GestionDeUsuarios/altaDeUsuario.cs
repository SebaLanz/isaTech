using MySql.Data.MySqlClient;
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


namespace TPProgramacionA.GestionDeUsuarios
{
    public partial class altaDeUsuario : Form
    {
        public altaDeUsuario()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            SqlAltaUserYPerfil();
        }


        private void altaDeUsuario_Load(object sender, EventArgs e)
        {

        }
        public void SqlAltaUserYPerfil()
        {
            string server = "localhost";
            string user = "root";
            string pwd = "";
            string DB = "programacion";
            string cadenaConexion = "server=" + server + ";user=" + user + ";pwd=" + pwd + ";database=" + DB;
            Boolean Validado = false;

            

            try{
                string SqlInsertPerfil = @"INSERT INTO perfil (nombre, apellido, dni, direccion, contacto, cuit, fecha_nacimiento, puesto)
                                   VALUES (@nombre, @apellido, @dni,@direccion, @contacto,@cuit, @fecha_nacimiento, @puesto)
                                    ";

                string SqlInsertUser = @"INSERT INTO usuario (username, password, mail, activo,bloqueado, fecha_creacion)
                                   VALUES (@username, @password, @mail, 1, 0, @fecha_creacion)";

                string SqlValidarUser = @"SELECT username FROM usuario WHERE username = @username";

                string SqlInsertIdUserPerfil = @"INSERT INTO usuario_perfil (id_usuario, id_perfil)
                                               VALUES (@id_usuario, @id_perfil)";

                
                

                /*Creo un objeto de conexión "Conectar" basado en MysqlConnection
                  Le paso CadenaConexion como parametro*/
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);

               
                /*Creo un objeto para validar el nombre del usuario basado en MySqlCommand
                 Le paso la sentencia SQL ValidarUser y el objeto creado en base a la Conexión*/
                MySqlCommand comandoValidarUser = new MySqlCommand(SqlValidarUser, conectar);

                /*Con el objeto creado comandoValidarUser, le paso como parametro el TextBox del usuario
                 Y se compara con el USERNAME de la sentencia SQL 'SqlValidarUser' */
                comandoValidarUser.Parameters.AddWithValue("username", TXTUsuario.Text);
                conectar.Open();

                /*Creo un objeto basado en la clase MySqlDataReader, le paso el comando comandoValidarUser
                 y hago una lectura de la cadena SQL y buscar si el usuario de la BDD es igual al TextBox */
                MySqlDataReader leerDBTablaUsuario = comandoValidarUser.ExecuteReader();

                /*Si leerDBTablaUsuario pasó al estado True la variable Booleana "Validad" pasa a "true"
                 *Si leerDBTablaUsuario sigue en "False" Se cierra la conexión y Pasa al Else  */
                if (leerDBTablaUsuario.Read() == true)
                {
                    Validado = true;
                    conectar.Close();
                }else{
                    conectar.Close();
                }if (Validado == true){
                    MessageBox.Show("El nombre de usuario está siendo utilizado");
                    return;
                }else{

                    /* Creo un objeto para insertar los datos del Perfil del usuario Basado en la clase MySqlCommand
                    Le paso la sentencia SQL InsertPerfil y el objeto creado en base a la conexión*/
                    MySqlCommand comandoPerfil = new MySqlCommand(SqlInsertPerfil, conectar);
                    comandoPerfil.Parameters.AddWithValue("@nombre", TXTNombre.Text);
                    comandoPerfil.Parameters.AddWithValue("@apellido", TXTApellido.Text);
                    comandoPerfil.Parameters.AddWithValue("@dni", TXTDni.Text);
                    comandoPerfil.Parameters.AddWithValue("@direccion", TXTDireccion.Text);
                    comandoPerfil.Parameters.AddWithValue("@contacto", TXTContacto.Text);
                    comandoPerfil.Parameters.AddWithValue("@cuit", TXTCuit.Text);
                    comandoPerfil.Parameters.AddWithValue("@fecha_nacimiento", TXTFechaNacimiento.Text);
                    comandoPerfil.Parameters.AddWithValue("@puesto", TXTPuesto.Text);
                    comandoPerfil.CommandText = SqlInsertPerfil;
                    conectar.Open();
                    comandoPerfil.ExecuteNonQuery();
                    long idPerfil = comandoPerfil.LastInsertedId;
                    conectar.Close();

                    /* Creo un objeto para insertar los datos de la tabla Usuario Basado en la clase MySqlCommand
                    Le paso la sentencia SQL InsertUser y el objeto creado en base a la conexión*/
                    MySqlCommand comandoUser = new MySqlCommand(SqlInsertUser, conectar);
                    comandoUser.Parameters.AddWithValue("@username", TXTUsuario.Text);
                    comandoUser.Parameters.AddWithValue("@password", TXTPass.Text);//falta encritar.
                    comandoUser.Parameters.AddWithValue("@mail", TXTMail.Text);
                    comandoUser.Parameters.AddWithValue("@fecha_creacion", DateTime.Now.ToString("ddMMddyyyy"));
                    comandoUser.CommandText = SqlInsertUser;
                    conectar.Open();
                    comandoUser.ExecuteNonQuery();
                    long idUsuario = comandoUser.LastInsertedId;
                    conectar.Close();

                    MySqlCommand comandoIdUserYPerfil = new MySqlCommand(SqlInsertIdUserPerfil, conectar);
                    comandoIdUserYPerfil.Parameters.AddWithValue("@id_usuario",idUsuario);
                    comandoIdUserYPerfil.Parameters.AddWithValue("@id_perfil", idPerfil);
                    conectar.Open();
                    comandoIdUserYPerfil.ExecuteNonQuery();
                    conectar.Close();

                    MessageBox.Show("usuario creado");

                }
            }catch (Exception ex){
                    label1.Text = "error" + ex;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTPuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
