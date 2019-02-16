using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace ProyectoEventPlanner.Controlador
{
    class Conexion
    {
       protected string conConexion = "Data Source = LAPTOP-FIEONJPC\\SQLEXPRESS;Initial Catalog = EventPlanner; Integrated Security = True";
        protected SqlConnection conectar = new SqlConnection();

        public Conexion() {
            conectar.ConnectionString = conConexion;      
        }

        public void abrirConexion() {
            try
            {
                conectar.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al abrir base de datos " + e);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conectar.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al cerrar base de datos " + e);
            }
        }


        public virtual DataTable Mostrar() {
            string query = "";
            abrirConexion();
            SqlCommand comando = new SqlCommand(query, conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;

        }



    }



  
}
