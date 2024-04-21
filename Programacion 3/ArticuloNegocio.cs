using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Programacion_3
{
    class ArticuloNegocio
    {

            public List<Articulo> listarArticulos()
        {
            List<Articulo> listado = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conexion.ConnectionString = "server=" + Configs.DbServer +"; database=" + Configs.Database + "; integrated security=" + Configs.SecurityIntegrated;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Codigo, Nombre, Descripcion, Precio from ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Articulo tmp = new Articulo();
                    tmp.Codigo = (string)reader["Codigo"];
                    tmp.Nombre = (string)reader["Nombre"];
                    tmp.Descripcion = (string)reader["Descripcion"];
                    tmp.Precio = (decimal)reader["Precio"];

                    listado.Add(tmp);
                }

                return listado;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la DB\nError: " + ex);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        

    }
}
