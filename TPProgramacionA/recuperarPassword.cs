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
using TPProgramacionA.ClasesModuloUsuarios;

namespace TPProgramacionA
{
    public partial class recuperarPassword : Form
    {
        public recuperarPassword()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            recuperarPass();
          
        }

        public void recuperarPass() {

            //lberror.Text = "";
            string cambiarPassword = @"UPDATE Usuario 
                                            SET password = @password
                                            WHERE mail = @mail";
            //Conectamos 
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            //Creamos objeto para realizar consulta a la BDD
            conectar.Open();

            MySqlCommand SqlConsulta = new MySqlCommand();
            SqlConsulta.Connection = conectar;
            SqlConsulta.CommandText = ("select * from usuario where mail= '" + TXT1.Text + "' and activo = '1'");

            MySqlDataReader leer = SqlConsulta.ExecuteReader();
            if (leer.Read()){
                conectar.Close();
                // Si existe el usuario, le cambio la pw a contraseñaAleatorio
                //creo objeto para realizar un núm aleatorio
                Random contraseñaAleatorio = new Random();
                //Genero número random de 6 digitos.
                int nRandom = contraseñaAleatorio.Next(100000, 999999);
                //encripto la contraseña nueva realizada por el método .Next
                string nuevaPassword = HashCode.CodificacionPassword(nRandom.ToString());
                MySqlCommand cmdActualizar = new MySqlCommand(cambiarPassword, conectar);
                //cambio pw por la  encriptada
                cmdActualizar.Parameters.AddWithValue("password", nuevaPassword);
                cmdActualizar.Parameters.AddWithValue("mail", TXT1.Text);

                conectar.Open();
                cmdActualizar.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("Contraseña modificada, se le enviará a su casilla de correo la nueva contraseña");
                ClasesModuloUsuarios.EnvioMail.EnvioDeMail(TXT1.Text,"Contraseña restablecida", "Su contraseña en UmbrellaCorp fue reestablecida. " +
                "Su nueva contraseña es: " + nRandom + " .Ingrese a la página para modificarla.");
               
            }else{
                MessageBox.Show("Mail Erroneo");
            }

        }
    }
}