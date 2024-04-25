using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        List<Articulo> listado = new List<Articulo>();
        //SqlConnection conexion = new SqlConnection();
        //SqlCommand comando = new SqlCommand();
        //SqlDataReader reader;
        AccesoDatos datos;


        public List<Articulo> listarArticulos()
        {

            try
            {
                //conexion.ConnectionString = "server=" + Configs.DbServer + "; database=" + Configs.Database + "; integrated security=" + Configs.SecurityIntegrated;
                //comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "SELECT Codigo, Nombre, Descripcion, Precio from ARTICULOS";
                //comando.Connection = conexion;

                //conexion.Open();

                //reader = comando.ExecuteReader();

                datos = new AccesoDatos();
                datos.configurarConsulta("SELECT Codigo, Nombre, Descripcion, Precio from ARTICULOS");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Articulo tmp = new Articulo();
                    tmp.Codigo = (string)datos.Lector["Codigo"];
                    tmp.Nombre = (string)datos.Lector["Nombre"];
                    tmp.Descripcion = (string)datos.Lector["Descripcion"];
                    tmp.Precio = (decimal)datos.Lector["Precio"];

                    listado.Add(tmp);
                }
                datos.cerrarConexion();
                return listado;

            }
            catch (Exception ex)
            {
                // MessageBox.Show("Error al conectarse a la DB\nError: " + ex);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void insertar(Articulo articulo)
        {
            try
            {
                //conexion.ConnectionString = "server=" + Configs.DbServer + "; database=" + Configs.Database + "; integrated security=" + Configs.SecurityIntegrated;
                //comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "INSERT INTO ARTICULOS VALUES (" + articulo.Codigo + "," + articulo.Nombre + "," + articulo.Descripcion + ")";

                //comando.ExecuteReader();


            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}

