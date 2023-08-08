using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TPProgramacionA.clases
{
    public class permiso
    {
       

        public void AgregarRole(string permiso)
        {
           
            string cadenaConexion = "server=localhost;user=root;pwd='';database=programacioon";

            string SQLAgregar = @"INSERT INTO permisos (permiso)
                                  VALUES (@permiso)";

            string SQLValidar = @"SELECT * FROM permisos WHERE permiso=@permiso";

            MySqlConnection conectar = new MySqlConnection(cadenaConexion);
            {
                try
                {
                    MySqlCommand commandValidar = new MySqlCommand(SQLValidar, conectar);
                    MySqlCommand comandoAgregar = new MySqlCommand(SQLAgregar, conectar);

                    
                    // commandValidar.Parameters.AddWithValue("permiso", permiso);
                    comandoAgregar.Parameters.AddWithValue("@permiso", permiso);
                    comandoAgregar.CommandText = SQLAgregar;
                    conectar.Open();               
                    
                    comandoAgregar.ExecuteNonQuery();
                    conectar.Close();
                    
                }
                catch (Exception ex)
                {
                    return ;
                }
            }
        }
    }
}
