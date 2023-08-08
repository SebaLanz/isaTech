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
    public partial class modificarUsuarioNormal : Form
    {
        public modificarUsuarioNormal()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void button1_Click(object sender, EventArgs e)
        {

            ActualizarPerfil();
           ActualizarUsuario();
        }

        public void Buscar()
        {
            
            // string sqlBuscar = "SELECT * FROM usuario WHERE username LIKE '%' + @username + '%";
            string sqlBuscar = @"SELECT U.mail, P.nombre, P.apellido, P.dni, P.contacto, P.cuit, P.puesto, P.direccion, P.fecha_nacimiento
                                FROM usuario U
                                INNER JOIN usuario_perfil UP ON U.id_usuario = UP.id_usuario
                                INNER JOIN perfil P ON UP.id_perfil = P.id_perfil
                                WHERE username = '" + LBUsuario.Text +"'";

            try
            {
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);
                // Abro conexión
                //conectar.Open();
                // Creo objeto comandoBuscar que se conecta a la BDD y busca con la sentencia sqlBuscar.
                MySqlCommand comandoBuscar = new MySqlCommand(sqlBuscar, conectar);


                conectar.Open();
                MySqlDataReader registro = comandoBuscar.ExecuteReader();
                if (registro.Read())
                {
                    TXTMail.Text = registro["mail"].ToString();
                    TXTNombre.Text = registro["nombre"].ToString();
                    TXTApellido.Text = registro["apellido"].ToString();
                    TXTDni.Text = registro["dni"].ToString();
                    TXTDireccion.Text = registro["direccion"].ToString();
                    TXTContacto.Text = registro["contacto"].ToString();
                    TXTCuit.Text = registro["cuit"].ToString();
                    TXTFechaNacimiento.Text = registro["fecha_nacimiento"].ToString();
                    TXTPuesto.Text = registro["puesto"].ToString();

                }
                else
                {
                    ///
                }
                conectar.Close();   
                // }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTTMostrar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void ActualizarUsuario()
        {

            string sqlBuscar = @"UPDATE usuario
                                 SET mail = @mail
                                 WHERE username = '"+ LBUsuario.Text +"'";

            // Creo objeto conectar para realizar la conexión a la BDD con la clase MySqlConection


            try
            {
                MySqlConnection conectar = new MySqlConnection(cadenaConexion);
                MySqlCommand comandoActualizar = new MySqlCommand(sqlBuscar, conectar);
                comandoActualizar.Parameters.AddWithValue("mail", TXTMail.Text);
                conectar.Open();
                comandoActualizar.ExecuteNonQuery();
                conectar.Close();
                //MessageBox.Show("Datos actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarPerfil()
        {
            string SqlObtenerId = @"SELECT id_usuario FROM usuario WHERE username ='"+ LBUsuario.Text + "'";

            string idUsuario = "";

            //Necesito ejecutar la query SqlObtenerId para obtener el ID del usuario Logeado


            // Creo objeto conectar para realizar la conexión a la BDD con la clase MySqlConection
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);

            MySqlCommand comandoID = new MySqlCommand(SqlObtenerId, conectar);
            
            conectar.Open();
            // Utilizo MySqlDataReader para leer la query que comandoID trae desde SqlObtenerId
            MySqlDataReader leerSql = comandoID.ExecuteReader();
            if (leerSql.Read()){
                idUsuario = leerSql["id_usuario"].ToString();
            }
            conectar.Close();
            // al terminar este if, obtengo el id del usuario logeado en el sistema, la asigno a la variable idUsuario.

            string sqlUpdatePerfil = @"UPDATE perfil P
                                       JOIN usuario U ON P.id_perfil = U.id_usuario 
                                       SET P.nombre = @nombre, P.apellido = @apellido, P.dni = @dni,
                                           P.direccion = @direccion, P.contacto = @contacto,
                                           P.cuit = @cuit, P.fecha_nacimiento = @fecha_nacimiento,
                                           P.puesto = @puesto
                                       WHERE U.id_usuario =" + idUsuario + "";

            try
            {
                MySqlCommand comandoPerfil = new MySqlCommand(sqlUpdatePerfil, conectar);
                comandoPerfil.Parameters.AddWithValue("@nombre", TXTNombre.Text);
                comandoPerfil.Parameters.AddWithValue("@apellido", TXTApellido.Text);
                comandoPerfil.Parameters.AddWithValue("@dni", TXTDni.Text);
                comandoPerfil.Parameters.AddWithValue("@direccion", TXTDireccion.Text);
                comandoPerfil.Parameters.AddWithValue("@contacto", TXTContacto.Text);
                comandoPerfil.Parameters.AddWithValue("@cuit", TXTCuit.Text);
                comandoPerfil.Parameters.AddWithValue("@fecha_nacimiento", TXTFechaNacimiento.Text);
                comandoPerfil.Parameters.AddWithValue("@puesto", TXTPuesto.Text);
                
                
                conectar.Open();
                comandoPerfil.ExecuteNonQuery();                
                conectar.Close();

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
