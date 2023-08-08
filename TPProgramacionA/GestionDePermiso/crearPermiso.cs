using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TPProgramacionA.clases;

namespace TPProgramacionA.GestionDePermiso
{
    public partial class crearPermiso : Form
    {
        public crearPermiso()
        {
            InitializeComponent();
        }
        string cadenaConexion = "server=localhost;user=root;pwd='';database=programacion";
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection(cadenaConexion);

            try
            {
                
                MessageBox.Show("permiso creado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Clase existente");
            }
        }
    }
}
