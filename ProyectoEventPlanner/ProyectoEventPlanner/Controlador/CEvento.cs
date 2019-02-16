using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoEventPlanner.Controlador
{
    class CEvento : Conexion
    {

        public CEvento() {
            
        }


        public virtual DataTable Mostrar()
        {

            string query = "SELECT * FROM Contactos";
            abrirConexion();
            SqlCommand comando = new SqlCommand(query, conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            //DataGridView = tabla;
            return tabla;


        }

    }
}
