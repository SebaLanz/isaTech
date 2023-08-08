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
    public partial class solicitarLicencia : Form
    {
        public solicitarLicencia()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void solicitarLicencia_Load(object sender, EventArgs e)
        {
            mostrarLicencias();
         
        }

        private void mostrarLicencias()
        {

            CBLicencia.DataSource = null;
            CBLicencia.Items.Clear();
            string sqlComando = "select tipo from tipo_licencia";

            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            conectar.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sqlComando, conectar);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                CBLicencia.DisplayMember = "tipo";
                CBLicencia.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guardarLicencia()
        {
            
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlIdUsuario = @"SELECT id_usuario from usuario where username = '" + LBUsuario.Text + "'";
            string sqlIdTipoLicencia = @"SELECT id_tipo_licencia from tipo_licencia where tipo = '" + CBLicencia.Text + "'";


            // OBTENER ID DE USUARIO
            string idUsuario="";
            MySqlCommand comandoID = new MySqlCommand(SqlIdUsuario, conectar);
            conectar.Open();
            // Utilizo MySqlDataReader para leer la query que comandoID trae desde SqlObtenerId
            MySqlDataReader leerSql = comandoID.ExecuteReader();
            if (leerSql.Read())
            {
                idUsuario = leerSql["id_usuario"].ToString();
            }
            conectar.Close();

            // OBTENER ID DE ESTADO.
            string idLicencia="";
            MySqlCommand comandoIdLicencia = new MySqlCommand(sqlIdTipoLicencia, conectar);
            conectar.Open();
            // Utilizo MySqlDataReader para leer la query que comandoID trae desde SqlObtenerId
            MySqlDataReader leerSqlDeLicencia = comandoIdLicencia.ExecuteReader();
            if (leerSqlDeLicencia.Read())
            {
                idLicencia = leerSqlDeLicencia["id_tipo_licencia"].ToString();
            }
            conectar.Close();
            try
            {
                string SqlInsertLicencia = @"INSERT INTO usuario_tipolicencia_estado (id_usuario,id_estado,id_tipo_licencia,fecha_inicio,fecha_fin)
                                         VALUES (@id_usuario,@id_estado,@id_tipo_licencia,@fecha_inicio,@fecha_fin)";
              
                    
                    MySqlCommand comandoIdUserYPeermiso = new MySqlCommand(SqlInsertLicencia, conectar);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_usuario",idUsuario);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_estado",2);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_tipo_licencia",idLicencia);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("fecha_inicio", Convert.ToDateTime(DTInicio.Text.ToString()));
                    comandoIdUserYPeermiso.Parameters.AddWithValue("fecha_fin", Convert.ToDateTime(DTFinal.Text.ToString()));
                    conectar.Open();
                    comandoIdUserYPeermiso.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("licencia guardada");
            }

            catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        private void enviarLicencia()
        {
            
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlIdUsuario = @"SELECT id_usuario from usuario where username = '" + LBUsuario.Text + "'";
            string SqlIdTipoLicencia = @"SELECT id_tipo_licencia from tipo_licencia where tipo = '" + CBLicencia.Text + "'";
            


            // OBTENER ID DE USUARIO
            string idUsuario = "";
            MySqlCommand comandoID = new MySqlCommand(SqlIdUsuario, conectar);
            conectar.Open();
            // Utilizo MySqlDataReader para leer la query que comandoID trae desde SqlObtenerId
            MySqlDataReader leerSql = comandoID.ExecuteReader();
            if (leerSql.Read())
            {
                idUsuario = leerSql["id_usuario"].ToString();
            }
            conectar.Close();

            // OBTENER ID DE ESTADO.
            string idLicencia = "";
            MySqlCommand comandoIdLicencia = new MySqlCommand(SqlIdTipoLicencia, conectar);
            conectar.Open();
            // Utilizo MySqlDataReader para leer la query que comandoIDLidcencia trae desde SqlObtenerId
            MySqlDataReader leerSqlDeLicencia = comandoIdLicencia.ExecuteReader();
            if (leerSqlDeLicencia.Read()){
                idLicencia = leerSqlDeLicencia["id_tipo_licencia"].ToString();
            }         
            conectar.Close();


            // OBTENER CANTIDAD DE DÍAS DISPONIBLES DE LA BDD.
            conectar.Open();
            string diasDisponibles = "";
            string SqlDiasDisponibles = @"SELECT dias_disponibles FROM tipo_licencia WHERE id_tipo_licencia ='" + idLicencia + "'";
            MySqlCommand comandoDiasDisponibles = new MySqlCommand(SqlDiasDisponibles, conectar);
            MySqlDataReader leerSqlDeDias = comandoDiasDisponibles.ExecuteReader();
            if (leerSqlDeDias.Read()){
                diasDisponibles = leerSqlDeDias["dias_disponibles"].ToString();
            }
            conectar.Close();

            //Creo el objeto dias que contiene los días que hay entre la fecha inicial y la final de las licencias.
            DateTime fechaInicial = DTInicio.Value.Date;
            DateTime fechaFinal = DTFinal.Value.Date;
            //Ahora creo objeto que va a contener la cantidad de días que hay entre la fecha inicial y final de los DTime.
            TimeSpan obtenerDias = fechaFinal - fechaInicial;
            // le asigno los días a la variable entera.
            int diasATomar = obtenerDias.Days;
            int diasDisponiblesEnBDD = Convert.ToInt32(diasDisponibles);
            if ((diasDisponiblesEnBDD - diasATomar) < 0){
                MessageBox.Show("Cantidad de días insuficientes");
            }
            else{ 
                try{
                    string SqlInsertLicencia = @"INSERT INTO usuario_tipolicencia_estado (id_usuario,id_estado,id_tipo_licencia,fecha_inicio,fecha_fin)
                                             VALUES (@id_usuario,@id_estado,@id_tipo_licencia,@fecha_inicio,@fecha_fin)";


                    MySqlCommand comandoIdUserYPeermiso = new MySqlCommand(SqlInsertLicencia, conectar);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_usuario", idUsuario);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_estado", 1);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_tipo_licencia", idLicencia);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("fecha_inicio", Convert.ToDateTime(DTInicio.Text.ToString()));
                    comandoIdUserYPeermiso.Parameters.AddWithValue("fecha_fin", Convert.ToDateTime(DTFinal.Text.ToString()));
                    conectar.Open();
                    comandoIdUserYPeermiso.ExecuteNonQuery();
                    conectar.Close();

                    string SqlInsertDiasDisponibles = @"INSERT INTO dias_disponibles_licencia (id_usuario,id_tipo_licencia,dias_disponibles)
                                            VALUES (@id_usuario,@id_tipo_licencia,@dias_disponibles)";


                        MySqlCommand comandoDiasDisponiblesLicencia = new MySqlCommand(SqlInsertDiasDisponibles, conectar);
                        comandoDiasDisponiblesLicencia.Parameters.AddWithValue("id_usuario", idUsuario);
                        comandoDiasDisponiblesLicencia.Parameters.AddWithValue("id_tipo_licencia", idLicencia);
                        comandoDiasDisponiblesLicencia.Parameters.AddWithValue("dias_disponibles", diasATomar);
                        conectar.Open();
                        comandoDiasDisponiblesLicencia.ExecuteNonQuery();
                        conectar.Close();
                        MessageBox.Show("Licencia/Vacaciones Enviada para su Aprobación.");
                }

                catch (MySqlException ex){
                    MessageBox.Show(ex.Message,"Cantidad de días insuficientes.");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            guardarLicencia();
            
        }

        private void BTNEnviar_Click(object sender, EventArgs e)
        {
            enviarLicencia();
        }

        private void CBLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
