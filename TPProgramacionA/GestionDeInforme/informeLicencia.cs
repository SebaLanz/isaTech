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

namespace TPProgramacionA.GestionDeInforme
{
    public partial class informeLicencia : Form
    {
        public informeLicencia()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void prueba() {
             string cadena = "";
            foreach (object itemChecked in checkedListBox1.CheckedItems){
                if (itemChecked.ToString() == "Fecha de Inicio de Licencia"){
                    cadena = "ute.fecha_inicio AS 'Fecha de Inicio'";
                }
                if (cadena != ""){
                    if (itemChecked.ToString() == "Fecha de Fin de Licencia"){
                        cadena = cadena + ",ute.fecha_fin AS 'Fecha Final Licencia'";
                    }
                }
                if (cadena == ""){
                    if (itemChecked.ToString() == "Fecha de Fin de Licencia"){
                        cadena = "ute.fecha_fin AS 'Fecha Final Licencia'";
                    }
                }
                if (cadena != ""){
                    if (itemChecked.ToString() == "Solicitante"){
                        cadena = cadena + ",u.username AS 'Usuario Solicitante'";
                    }
                }
                if (cadena == ""){
                    if (itemChecked.ToString() == "Solicitante"){
                        cadena = "u.username AS 'Usuario Solicitante'";
                    }
                }
                if (cadena != ""){
                    if (itemChecked.ToString() == "Tipo de Licencia"){ 
                        cadena = cadena + ",tp.tipo AS 'Tipo de Licencia'";
                    }
                }
                if (cadena == ""){
                    if (itemChecked.ToString() == "Tipo de Licencia"){
                        cadena = "tp.tipo AS 'Tipo de Licencia'";
                    }
                }
                if (cadena != "")
                {
                    if (itemChecked.ToString() == "Estado de la licencia")
                    {
                        cadena = cadena + ",e.estado AS 'Estado'";
                    }
                }
                if (cadena == "")
                {
                    if (itemChecked.ToString() == "Estado de la licencia")
                    {
                        cadena = "e.estado AS 'Estado'";
                    }
                }
            }
            try{
                if (cadena == ""){
                    cadena = @"ute.fecha_inicio AS 'Fecha de Inicio', tp.tipo AS 'Tipo de Licencia',
                                tp.tipo AS 'Tipo de Licencia',u.username AS 'Usuario Solicitante', e.estado AS 'Estado'";
                }
                string sqlprueba = @"SELECT "+cadena+" " +
                    "FROM estado e " +
                    "LEFT JOIN usuario_tipolicencia_estado ute ON e.id_estado = ute.id_estado " +
                    "LEFT JOIN tipo_licencia tp ON ute.id_tipo_licencia = tp.id_tipo_licencia " +
                    "inner JOIN dias_disponibles_licencia " +
                    "ddl ON tp.id_tipo_licencia = ddl.id_tipo_licencia " +
                    "inner JOIN usuario u ON ddl.id_usuario = u.id_usuario " +
                    "ORDER BY ute.fecha_inicio, e.estado = 1";
                MySqlConnection conectar = new MySqlConnection(cadenaConexion); //obj conexión
                MySqlCommand comandoBuscar = new MySqlCommand(sqlprueba, conectar); // onj conexión + query
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comandoBuscar); 
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
                conectar.Close();
                cadena = "";
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
                  
        }
        private void exportarExcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns){
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;
            }
            int indiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows){
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns) {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        private void informeLicencia_Load(object sender, EventArgs e)
        {

        }

        private void BTNConsultar_Click(object sender, EventArgs e){
            prueba();
        }

        private void button1_Click(object sender, EventArgs e){
            if((dataGridView1.ColumnCount) ==0){
                MessageBox.Show("No se puede importar una Lista vacía");
            }else{ 
            exportarExcel(dataGridView1);
            }
        }
    }
}
