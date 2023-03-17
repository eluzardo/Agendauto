using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int id;
        ConexionBD conexion = new ConexionBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           cargarCombos();
        }

       

        private void cargarCombos()
        {
            string query;
            SqlCommand adaptador;
            SqlDataReader dr;
            //combo marcas
            query = "select * from marcas";
            conexion.abrir();
            adaptador = new SqlCommand(query, conexion.ToSqlConnection());
            dr = adaptador.ExecuteReader();
            while (dr.Read())
            {
                cboMarca.Items.Add(dr[1].ToString());
                cboMarcaModelo.Items.Add(dr[1].ToString());
            }
           
            conexion.cerrar();  

            //combo marcas
            conexion.abrir();
            query = "select * from modelos";
            adaptador = new SqlCommand(query, conexion.ToSqlConnection());
            dr = adaptador.ExecuteReader();
            while (dr.Read())
            {
                cboModelo.Items.Add(dr[1].ToString());
            }
            conexion.cerrar();

                        
        }

       

        

        private void btnGuardarAuto_Click(object sender, EventArgs e)
        {
            //ConexionBD conexion = new ConexionBD();
            try
            {
                var patente = txtPatente.Text.Trim();
                var marca=cboMarca.Text.Trim();
                var modelo=cboModelo.Text.Trim();
                var anio= txtAño.Text.Trim().ToString();
                string query = string.Format("insert into autos (patente,marca,modelo,anio) values ('{0}','{1}','{2}','{3}')", patente,marca, modelo, anio);
                conexion.abrir();
                ejecutarAdaptador(query,conexion.ToSqlConnection());
                conexion.cerrar();
                txtPatente.Text = "";
                cboMarca.Text = "";
                cboModelo.Text = "";
                txtAño.Text="";

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos. Error: " + ex.Message);
            }            
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into marcas values ('{0}')", txtMarcaNueva.Text);
                conexion.abrir();
                ejecutarAdaptador( query,conexion.ToSqlConnection());
                conexion.cerrar();
                cargarCombos();
                txtMarcaNueva.Text = "";
            
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {            
            try
            {
                //conexion a la base
                conexion.abrir();
                var marca = cboMarcaModelo.Text.ToString();
                var modelo = txtModeloNuevo.Text;
                string query2 = string.Format("select top 1 * from marcas where marca='{0}'",marca);
                SqlCommand adaptador2 = new SqlCommand(query2, conexion.ToSqlConnection());
                SqlDataReader dr = adaptador2.ExecuteReader();
                while (dr.Read())
                {
                    id = Int32.Parse((dr[0].ToString()));
                }

                string query = string.Format("insert into modelos (modelo,idMarca) values ('{0}',{1})", modelo, id);
                dr.Close();
                ejecutarAdaptador(query, conexion.ToSqlConnection());
                conexion.cerrar();
                cargarCombos();
                txtModeloNuevo.Text = "";
                cboMarcaModelo.Text = "";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ejecutarAdaptador(string query, SqlConnection conexion)
        {
            SqlCommand adaptador = new SqlCommand(query, conexion);
        }
    }
}
