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
    public partial class menuGestionDePermiso : Form
    {
        public menuGestionDePermiso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            crearPermiso OBJMenuCrearPermiso= new crearPermiso();
            OBJMenuCrearPermiso.LBUsuario.Text = LBUsuario.Text;
            OBJMenuCrearPermiso.FormClosed += (s, args) => this.Close();
            OBJMenuCrearPermiso.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            asignarPermisos OBJAsignarPermiso = new asignarPermisos();
            OBJAsignarPermiso.LBUsuario.Text = LBUsuario.Text;
            OBJAsignarPermiso.FormClosed += (s, args) => this.Close();
            OBJAsignarPermiso.Show();
        }
    }
}
