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

namespace TPProgramacionA.GestionDePermiso
{
    public partial class asignarPermisos : Form
    {
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";

        public asignarPermisos()
        {
            InitializeComponent();

        }

        public void cargarDatos() // Método para mostrar usuario.
        {
            CMBUsuario.DataSource = null;
            CMBUsuario.Items.Clear();
            string sqlComando = "select username from usuario where activo = 1";

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
        private void cargarPermisos()
        {
            CMBPermiso.DataSource = null;
            CMBPermiso.Items.Clear();
            string sqlComando = "select permiso from permisos";

            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            conectar.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sqlComando, conectar);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                data.Fill(dt);

                CMBPermiso.ValueMember = "id_permiso";
                CMBPermiso.DisplayMember = "permiso";
                CMBPermiso.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void mostrarPermiso(){ 
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string sqlComando = @"SELECT u.id_usuario,p.permiso
                                  FROM usuario u
                                  left JOIN usuario_permiso up ON u.id_usuario = up.id_usuario
                                  left JOIN permisos p ON up.id_permiso = p.id_permiso
                                  WHERE u.username ='" + CMBUsuario.Text + "'";
            try{

                MySqlCommand comandoBuscar = new MySqlCommand(sqlComando, conectar);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                DGVPermisos.DataSource = dt;
                conectar.Close();
                // }
            }catch (MySqlException ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarPermiso()
        {
            Boolean Validado = false;
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlEliminarPermiso = @"DELETE up
                                          FROM usuario u
                                          left JOIN usuario_permiso up ON u.id_usuario = up.id_usuario
                                          left JOIN permisos p ON up.id_permiso = p.id_permiso
                                          WHERE u.username =@u.username and p.permiso=@p.permiso";
            string SqlValidarPermiso = @"SELECT p.permiso,u.username
                                         FROM usuario u
                                         left JOIN usuario_permiso up ON u.id_usuario = up.id_usuario
                                         left JOIN permisos p ON up.id_permiso = p.id_permiso
                                         WHERE u.username =@u.username and p.permiso=@p.permiso";

            MySqlCommand comandoValidarPermiso = new MySqlCommand(SqlValidarPermiso, conectar);
            comandoValidarPermiso.Parameters.AddWithValue("p.permiso", CMBPermiso.Text);
            comandoValidarPermiso.Parameters.AddWithValue("u.username", CMBUsuario.Text);
            conectar.Open();

            MySqlDataReader leerbd = comandoValidarPermiso.ExecuteReader();                 
                if (leerbd.Read() == true){
                    Validado = true;
                    conectar.Close();
                }
                else{
                    conectar.Close();
                }
                if (Validado == true){
                    conectar.Open();
                    MySqlCommand comandoEliminarPermiso = new MySqlCommand(SqlEliminarPermiso, conectar);
                    comandoEliminarPermiso.Parameters.AddWithValue("p.permiso", CMBPermiso.Text);
                    comandoEliminarPermiso.Parameters.AddWithValue("u.username", CMBUsuario.Text);
                    comandoEliminarPermiso.ExecuteNonQuery();
                    conectar.Close();
                    MessageBox.Show("Permiso Eliminado");
                }
                else{
                    MessageBox.Show("El usuario no tiene el permiso marcado");
                    return;
                }
        }
        private void agregarPermiso() {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            string SqlInsertIdUserPermiso= @"INSERT INTO usuario_permiso (id_usuario, id_permiso)
                                                                  VALUES (@id_usuario, @id_permiso)";
            string SqlValidarPermiso =     @"SELECT p.permiso,u.username
                                             FROM usuario u
                                             left JOIN usuario_permiso up ON u.id_usuario = up.id_usuario
                                             left JOIN permisos p ON up.id_permiso = p.id_permiso
                                             WHERE u.username =@u.username and p.permiso=@p.permiso";
            MySqlCommand comandoValidarPermiso = new MySqlCommand(SqlValidarPermiso, conectar);
            comandoValidarPermiso.Parameters.AddWithValue("p.permiso", CMBPermiso.Text);
            comandoValidarPermiso.Parameters.AddWithValue("u.username", CMBUsuario.Text);
            conectar.Open();
            MySqlDataReader leerbd = comandoValidarPermiso.ExecuteReader();

            int id_permiso = 0;            
            if (leerbd.Read()){
                MessageBox.Show("El permiso está siendo utilizado");
                conectar.Close();            
            }else{
                conectar.Close();
                try{
                    if (CMBPermiso.Text == "admin"){id_permiso = 1;}
                    if (CMBPermiso.Text == "user"){id_permiso = 2;}
                    if (CMBPermiso.Text == "invitado"){id_permiso = 3;}
                    if (CMBPermiso.Text == "gestor"){id_permiso = 4;}
                    if (CMBPermiso.Text == "analyst"){id_permiso = 5;}
                    
                    MySqlCommand comandoIdUserYPeermiso= new MySqlCommand(SqlInsertIdUserPermiso, conectar);
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_usuario", int.Parse(DGVPermisos.CurrentRow.Cells[0].Value.ToString()));
                    comandoIdUserYPeermiso.Parameters.AddWithValue("id_permiso", id_permiso);
                    conectar.Open();
                    comandoIdUserYPeermiso.ExecuteNonQuery();
                    conectar.Close();                       
                    MessageBox.Show("Permiso Agregado");   
                    
                }catch (MySqlException ex){
                    MessageBox.Show(ex.Message);
                }
            }
        }
            private void DGVPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void asignarPermisos_Load(object sender, EventArgs e)
            {
                cargarDatos();cargarPermisos();mostrarPermiso();
            }

            private void CMBUsuario_SelectedIndexChanged(object sender, EventArgs e)
            {
                mostrarPermiso();
            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                agregarPermiso();                
            }

        private void CMBPermiso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult btnApretado = MessageBox.Show("¿Está seguro de eliminar el permiso?","Eliminar Permiso",MessageBoxButtons.OKCancel);
            if(btnApretado==DialogResult.Cancel){
                //
            }
            else
            {
                //MessageBox.Show("Permiso eliminado");
                eliminarPermiso();
            }
        }
    }

    
}
