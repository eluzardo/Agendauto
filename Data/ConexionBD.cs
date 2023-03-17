using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class ConexionBD
    {
        string cadena = "Data Source=DESKTOP-RL0UTEQ\\EMILIANO; Initial Catalog=agenda; Integrated Security=True";
        public SqlConnection conectarbd= new SqlConnection();

        public ConexionBD() 
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");
                
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }

        public SqlConnection ToSqlConnection()
        {
            return conectarbd;
        }
    }
}
