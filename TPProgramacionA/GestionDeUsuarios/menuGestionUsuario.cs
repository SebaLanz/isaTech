using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPProgramacionA.GestionDeUsuarios;


namespace TPProgramacionA.GestionDeUsuarios
{
    public partial class menuGestionUsuario : Form
    {
        public menuGestionUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            altaDeUsuario OBJAltaUsuario = new altaDeUsuario();
            OBJAltaUsuario.Show(); //Con este método abro otro form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (LBUsuario.Text == "admin")
                {
                    modificarUsuarioAdmin ObjModificarPorAdmin = new modificarUsuarioAdmin();
                    ObjModificarPorAdmin.LBUsuario.Text = LBUsuario.Text;
                    ObjModificarPorAdmin.Show();
                }else
                {
                    modificarUsuarioNormal ObjModificarPorUser = new modificarUsuarioNormal();
                    ObjModificarPorUser.LBUsuario.Text = LBUsuario.Text;
                    ObjModificarPorUser.Show();
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            consultaUsuario OBJModificacionUsuario = new consultaUsuario();
            OBJModificacionUsuario.Show(); //Con este método abro otro form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bajaDeUsuario OBJBajaUsuario = new bajaDeUsuario();
            OBJBajaUsuario.Show(); //Con este método abro otro form
        }
    }
}
