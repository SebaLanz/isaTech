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
using Microsoft.Office.Interop.Excel;

namespace TPProgramacionA.GestionDeInforme
{
    public partial class informeDeUsuario : Form
    {
        public informeDeUsuario()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void informeDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void mostrarUsuario()
        {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            if (CBUsuario.Text == ""){
                MessageBox.Show("Debe filtrar el estado del usuario");
            }
            if (CBUsuario.Text == "Activo"){
                string sqlprueba = @"SELECT u.username AS 'Usuario', p.nombre AS 'Nombre', p.apellido AS 'Apellido', u.fechaUltimoIngreso AS 'Último ingreso'
                                    , p.puesto AS 'Puesto', p.dni AS 'Dni', p.direccion AS 'Dirección', p.cuit AS 'CUIT', p.fecha_nacimiento AS 'Edad'
                                    FROM perfil p 
                                    LEFT JOIN usuario_perfil up ON p.id_perfil = up.id_perfil
                                    inner JOIN usuario u ON up.id_usuario = u.id_usuario
                                    WHERE u.activo = 1";
                conectar.Open();
                try
                {
                    MySqlCommand comandoBuscar = new MySqlCommand(sqlprueba, conectar);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adaptador.Fill(dt);
                    DGVUsuario.DataSource = dt;
                    conectar.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(CBUsuario.Text == "Inactivo")
            {
                string sqlprueba = @"SELECT u.username AS 'Usuario', p.nombre AS 'Nombre', p.apellido AS 'Apellido',
                                   u.fechaInactivo
                                   FROM perfil p 
                                   LEFT JOIN usuario_perfil up ON p.id_perfil = up.id_perfil
                                   inner JOIN usuario u ON up.id_usuario = u.id_usuario
                                   WHERE u.activo = 0";        
                conectar.Open();
                try
                {
                    MySqlCommand comandoBuscar = new MySqlCommand(sqlprueba, conectar);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adaptador.Fill(dt);
                    DGVUsuario.DataSource = dt;
                    conectar.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exportarExcel(DataGridView tabla){

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            foreach (DataGridViewColumn col  in tabla.Columns) // columnas
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;
            }

            int indiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows) //fila
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        private void BTNUsuario_Click(object sender, EventArgs e)
        {
            mostrarUsuario();
        }

        private void BTNInforme_Click(object sender, EventArgs e)
        {
            exportarExcel(DGVUsuario);
            MessageBox.Show("Informe creado!");
        }
    }
}
