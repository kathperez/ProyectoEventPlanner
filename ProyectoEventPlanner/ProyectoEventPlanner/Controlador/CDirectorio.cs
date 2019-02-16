using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace ProyectoEventPlanner.Controlador
{

    class CDirectorio : Conexion
    {

        public override DataTable Mostrar()
        {

            string query = "SELECT * FROM Contactos";
            abrirConexion();
            SqlCommand comando = new SqlCommand(query, conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;


        }

        public void agregar(Modelo.MDirectorio datos)
        {

            try
            {
                string query = "INSERT INTO Contactos (NombreEmpresa, Nombre, PrimerApellido, SegundoApellido, TelefonoPrincipal, TelefonoOpcional, Direccion, PaginaWeb, Area, Comentarios) VALUES (@nombreempresa, @nombre, @primerapellido, @segundoapellido, @telefonoprincipal, @telefonoopcinal, @direccion, @paginaweb, @area, @comentarios )";

                abrirConexion();
                SqlCommand comando = new SqlCommand(query, conectar);
                comando.Parameters.AddWithValue("@nombreempresa", datos.nombreEmpresa);
                comando.Parameters.AddWithValue("@nombre", datos.nombre);
                comando.Parameters.AddWithValue("@primerapellido", datos.PrimerApellido);
                comando.Parameters.AddWithValue("@segundoapellido", datos.SegundoApellido);
                comando.Parameters.AddWithValue("@telefonoprincipal", datos.telPrincipal);
                comando.Parameters.AddWithValue("@telefonoopcinal", datos.telOpcional);
                comando.Parameters.AddWithValue("@direccion", datos.direccion);
                comando.Parameters.AddWithValue("@area", datos.area);
                comando.Parameters.AddWithValue("@paginaweb", datos.paginaWeb);
                comando.Parameters.AddWithValue("@comentarios", datos.comentarios);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se agregó exitosamente");
                cerrarConexion();
                //listo
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e.Message);
            }
        }

        public void editar(Modelo.MDirectorio datos, int contactoID)
        {
            try
            {
                string query = "UPDATE Contactos SET NombreEmpresa = @nombreEmpresa , Nombre = @nombre , PrimerApellido = @primerApellido , SegundoApellido = @segundoApellido , TelefonoPrincipal = @telPrincipal , TelefonoOpcional = @telOpcional , Direccion = @direccion , PaginaWeb = @paginaWeb , Area = @area , Comentarios = @comentarios WHERE ContactoID = "+ contactoID;

                abrirConexion();
                SqlCommand comando = new SqlCommand(query, conectar);
                comando.Parameters.AddWithValue("@nombreEmpresa", datos.nombreEmpresa);
                comando.Parameters.AddWithValue("@nombre", datos.nombre);
                comando.Parameters.AddWithValue("@primerApellido", datos.PrimerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", datos.SegundoApellido);
                comando.Parameters.AddWithValue("@telPrincipal", datos.telPrincipal);
                comando.Parameters.AddWithValue("@telOpcional", datos.telOpcional);
                comando.Parameters.AddWithValue("@direccion", datos.direccion);
                comando.Parameters.AddWithValue("@area", datos.area);
                comando.Parameters.AddWithValue("@paginaWeb", datos.paginaWeb);
                comando.Parameters.AddWithValue("@comentarios", datos.comentarios);
                comando.ExecuteNonQuery();
                MessageBox.Show("Se actualizó exitosamente");
                cerrarConexion();
            }
            catch (Exception e) {

                MessageBox.Show("Error al actualizar, contacte a su administrador" + e);

            }
        }

        public  DataTable Buscar(string buscar)
        {

            string query = "SELECT * FROM Contactos WHERE NombreEmpresa like '%" + buscar + "%' order by ContactoID " ;
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
