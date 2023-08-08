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

namespace TPProgramacionA.GestionDeUsuarios
{
    public partial class consultaUsuario : Form
    {
        public consultaUsuario()
        {
            InitializeComponent();
        }

        private void BTTConsultar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            string server = "localhost";
            string user = "root";
            string pwd = "";
            string DB = "programacion";
            string cadenaConexion = "server=" + server + ";user=" + user + ";pwd=" + pwd + ";database=" + DB;
            string sqlBuscar = @"SELECT U.username, U.mail, P.nombre, P.apellido, P.dni, P.contacto, P.cuit, P.puesto
                                 FROM usuario U
                                 LEFT JOIN usuario_perfil UP ON U.id_usuario = UP.id_usuario
                                 LEFT JOIN perfil P ON UP.id_perfil = P.id_perfil
                                 WHERE U.username = @username AND U.activo = 1";

            // Creo objeto conectar para realizar la conexión a la BDD con la clase MySqlConection


            try
            {
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);
                // Abro conexión
                //conectar.Open();
                // Creo objeto comandoBuscar que se conecta a la BDD y busca con la sentencia sqlBuscar.
                MySqlCommand comandoBuscar = new MySqlCommand(sqlBuscar, conectar);
                //Con una propiedad de mysqlcommand comparo el username de la BDD con el TextBoxUsuario.
                comandoBuscar.Parameters.AddWithValue("username", TXTUser.Text);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    DGWUser.DataSource = dt;
                    
                    LBIncorrecto.Text = " ";
                    conectar.Close();
               // }
                
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGWUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
