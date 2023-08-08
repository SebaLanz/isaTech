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
    public partial class aprobarLicencia : Form
    {
        public aprobarLicencia()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void aprobarLicencia_Load(object sender, EventArgs e)
        {
            cargarUsuarios(); mostrarLicencia();
        }

        public void cargarUsuarios() // Método para mostrar usuario.
        {
            CMBUsuario.DataSource = null;
            CMBUsuario.Items.Clear();
            string sqlComando = @"SELECT  u.username
                                FROM usuario u
                                INNER JOIN usuario_tipolicencia_estado ute ON u.id_usuario = ute.id_usuario
                                INNER JOIN estado e ON ute.id_estado = e.id_estado
                                WHERE ute.id_estado = 1";

            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            conectar.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqlComando, conectar);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                CMBUsuario.ValueMember = "id_usuario";
                CMBUsuario.DisplayMember = "username";
                CMBUsuario.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void mostrarLicencia()
        {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string sqlComando = @"SELECT ute.id_usuario_tipoLicencia_estado AS ID, u.username AS Usuario, tl.tipo AS Tipo, ute.fecha_inicio AS 'Fecha de solicitud',
                                    ute.fecha_fin AS 'Hasta'
                                    FROM usuario u
                                    INNER JOIN usuario_tipolicencia_estado ute ON u.id_usuario = ute.id_usuario
                                    INNER JOIN tipo_licencia tl ON ute.id_tipo_licencia = tl.id_tipo_licencia
                                    WHERE ute.id_estado = 1
                                    ORDER BY ute.fecha_inicio";
            try
            {

                MySqlCommand comandoBuscar = new MySqlCommand(sqlComando, conectar);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                DGVLicencia.DataSource = dt;
                conectar.Close();
                // }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rechazarLicencia()
        {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlComandoRechazar = @"UPDATE usuario_tipolicencia_estado ute
                                          SET ute.id_estado = @ute.id_estado ,ute.motivoRechazo=@ute.motivoRechazo
                                          WHERE ute.id_usuario_tipoLicencia_estado = @ute.id_usuario_tipoLicencia_estado";

            conectar.Open();
            MySqlCommand comandoRechazar = new MySqlCommand(SqlComandoRechazar, conectar);
            comandoRechazar.Parameters.AddWithValue("ute.id_estado", 4);
            comandoRechazar.Parameters.AddWithValue("ute.motivoRechazo", TXTRazon.Text);
            comandoRechazar.Parameters.AddWithValue("ute.id_usuario_tipoLicencia_estado", DGVLicencia.CurrentRow.Cells[0].Value.ToString());
            comandoRechazar.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("licencia rechazada");
        }

        private void aprobarLicencias(){
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlComandoRechazar = @"UPDATE usuario_tipolicencia_estado ute
                                          SET ute.id_estado = @ute.id_estado
                                          WHERE ute.id_usuario_tipoLicencia_estado = @ute.id_usuario_tipoLicencia_estado";

            conectar.Open();
            MySqlCommand comandoRechazar = new MySqlCommand(SqlComandoRechazar, conectar);
            comandoRechazar.Parameters.AddWithValue("ute.id_estado", 3);
            comandoRechazar.Parameters.AddWithValue("ute.id_usuario_tipoLicencia_estado", DGVLicencia.CurrentRow.Cells[0].Value.ToString());
            comandoRechazar.ExecuteNonQuery();
            conectar.Close();
            MessageBox.Show("Licencias/Vacaciones Aprobadas.");

        }
        private void button1_Click(object sender, EventArgs e)//btn Aprobar
        {
            aprobarLicencias();mostrarLicencia();
        }

   

        private void BTNRechazar_Click_1(object sender, EventArgs e)
        {
            if (TXTRazon.Text == "") {
                MessageBox.Show("Debe indicar el motivo del rechazo.");
            }
            else{
                rechazarLicencia(); mostrarLicencia();
            }
        }

        private void CMBUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
