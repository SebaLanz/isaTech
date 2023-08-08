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
    public partial class bajaDeUsuario : Form
    {
        public bajaDeUsuario()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void BTTBuscar_Click(object sender, EventArgs e)
        {
            Mostrar();


        }
        public void Buscar()
        {
            string sqlBuscar = "SELECT username AS Usuario, mail as Mail from usuario WHERE username =@username";
            try{
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
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        public void Mostrar(){

            string sqlBuscar = @"SELECT U.id_usuario, U.username, U.mail, P.nombre, P.apellido, P.dni, P.contacto, P.cuit, P.puesto
                                 FROM usuario U
                                 INNER JOIN usuario_perfil UP ON U.id_usuario = UP.id_usuario
                                 INNER JOIN perfil P ON UP.id_perfil = P.id_perfil
                                 WHERE activo = 1";
            try{
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);
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
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        public void BajaUsuario(){
            string sqlBuscar = @"UPDATE usuario
                                 SET activo = @activo
                                 WHERE id_usuario = @id_usuario";
            try{
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);
                MySqlCommand comandoBaja = new MySqlCommand(sqlBuscar, conectar);
                comandoBaja.Parameters.AddWithValue("activo", 0);
                comandoBaja.Parameters.AddWithValue("id_usuario",int.Parse(DGWUser.CurrentRow.Cells[0].Value.ToString()));                
                conectar.Open();
                comandoBaja.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("Usuario dado de baja");
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
        private void BTTBajaUsuario_Click(object sender, EventArgs e)
        {
            BajaUsuario();
        }

        private void DGWUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTTBuscar_Click_1(object sender, EventArgs e)
        {           
            Buscar();
        }
    }
}
