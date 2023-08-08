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
    public partial class verLicencia : Form
    {
        public verLicencia()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void verLicencia_Load(object sender, EventArgs e)
        {
            mostrarLicencias(); mostrarLicenciasCB();
        }
        private void mostrarLicenciasCB()
        {
            CBLicencia.DataSource = null;
            CBLicencia.Items.Clear();
            string sqlComando = "select estado from estado";

            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            conectar.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sqlComando, conectar);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);
                CBLicencia.DisplayMember = "estado";
                CBLicencia.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }    
        private void mostrarLicencias(){
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlIdUsuario = @"SELECT id_usuario from usuario where username = '" + LBUsuario.Text + "'";
            // OBTENER ID DE USUARIO
            string idUsuario = "";
            MySqlCommand comandoID = new MySqlCommand(SqlIdUsuario, conectar);
            conectar.Open();
            MySqlDataReader leerSql = comandoID.ExecuteReader();
            if (leerSql.Read()){
                idUsuario = leerSql["id_usuario"].ToString();}
            conectar.Close();
            if (CBLicencia.Text == "Denegado"){
                string sqlprueba = @"SELECT u.username AS Usuario,e.estado AS Estado, ute.fecha_inicio AS Inicio, ute.fecha_fin AS Hasta, ute.motivoRechazo AS 'Motivo Rechazo'
                                FROM usuario u
                                INNER JOIN usuario_tipolicencia_estado ute ON u.id_usuario = ute.id_usuario
                                INNER JOIN estado e ON ute.id_estado = e.id_estado
                                WHERE u.id_usuario ='" + idUsuario + "' AND e.estado = '" + CBLicencia.Text.ToString() + "'";
                conectar.Open();
                try{
                    MySqlCommand comandoBuscar = new MySqlCommand(sqlprueba, conectar);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    DGVLicencia.DataSource = dt;
                    conectar.Close();
                }catch (MySqlException ex){
                    MessageBox.Show(ex.Message);
                }
            }else{
                string sqlprueba = @"SELECT ute.id_usuario_tipoLicencia_estado AS ID, u.username AS Usuario,e.estado AS Estado, ute.fecha_inicio AS Inicio, ute.fecha_fin AS Hasta
                                FROM usuario u
                                INNER JOIN usuario_tipolicencia_estado ute ON u.id_usuario = ute.id_usuario
                                INNER JOIN estado e ON ute.id_estado = e.id_estado
                                WHERE u.id_usuario ='" + idUsuario + "' AND e.estado = '" + CBLicencia.Text.ToString() + "'";
                conectar.Open();
                try{
                    MySqlCommand comandoBuscar = new MySqlCommand(sqlprueba, conectar);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    DGVLicencia.DataSource = dt;
                    conectar.Close();
                }catch (MySqlException ex){
                    MessageBox.Show(ex.Message);
                } 
            }
        }

        private void actualizarLicencia()
        {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);

            if (CBLicencia.Text == "Enviado" || CBLicencia.Text == "Proceso")
            {

                string SqlActualizarFechas = @"UPDATE usuario_tipolicencia_estado ute
                                        SET ute.fecha_inicio=@ute.fecha_inicio, ute.fecha_fin=@ute.fecha_fin
                                        WHERE ute.id_usuario_tipoLicencia_estado = @ute.id_usuario_tipoLicencia_estado";
                try
                {

                    conectar.Open();
                    MySqlCommand comandoRechazar = new MySqlCommand(SqlActualizarFechas, conectar);
                    comandoRechazar.Parameters.AddWithValue("ute.fecha_inicio", Convert.ToDateTime(DTInicio.Text.ToString()));
                    comandoRechazar.Parameters.AddWithValue("ute.fecha_fin", Convert.ToDateTime(DTFinal.Text.ToString()));
                    comandoRechazar.Parameters.AddWithValue("ute.id_usuario_tipoLicencia_estado", DGVLicencia.CurrentRow.Cells[0].Value.ToString());
                    comandoRechazar.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("Licencias/Vacaciones Modificadas.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else{
                MessageBox.Show("Solo se puede modificar las vacaciones en Proceso o Enviadas");
            }
        }
        private void CBLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNMostrar_Click(object sender, EventArgs e){
            mostrarLicencias();
        }

        private void BTNEditar_Click(object sender, EventArgs e){           
            actualizarLicencia();
        }
    }
}
