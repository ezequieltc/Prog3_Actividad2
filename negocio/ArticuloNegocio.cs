using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        List<Articulo> listado = new List<Articulo>();

        public List<Articulo> listarArticulos()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.configurarConsulta("" +
                    "SELECT ARTICULOS.Id as id_Art,Codigo, Nombre, Precio, ARTICULOS.Descripcion as descArt, MARCAS.Descripcion as descMarca, CATEGORIAS.Descripcion as descCat, MARCAS.Id as Id_Marca, CATEGORIAS.Id as Id_Categoria from ARTICULOS INNER JOIN MARCAS ON ARTICULOS.IdMarca = MARCAS.Id INNER JOIN CATEGORIAS ON ARTICULOS.Id = CATEGORIAS.Id");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Marca tmpMarca = new Marca();
                    Categoria tmpCat = new Categoria();
                    Articulo tmp = new Articulo();
                    tmp.Id = (int)datos.Lector["id_Art"];
                    tmp.Codigo = (string)datos.Lector["Codigo"];
                    tmp.Nombre = (string)datos.Lector["Nombre"];
                    tmp.Descripcion = (string)datos.Lector["descArt"];
                    tmp.Precio = (decimal)datos.Lector["Precio"];
                    tmpMarca.Descripcion = (string)datos.Lector["descMarca"];
                    tmpMarca.Id = (int)datos.Lector["Id_Marca"];
                    tmp.Marca = tmpMarca;
                    tmpCat.Descripcion = (string)datos.Lector["descCat"];
                    tmpCat.Id = (int)datos.Lector["Id_Categoria"];
                    tmp.Categoria = tmpCat;

                    listado.Add(tmp);
                }
                datos.cerrarConexion();
                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void insertar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.configurarConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion, precio) values('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "', " + articulo.Precio + ")");
               
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void actualizar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.configurarConsulta("UPDATE ARTICULOS SET Codigo = '" + articulo.Codigo +"',Nombre = '" + articulo.Nombre + "',Descripcion = '" + articulo.Descripcion + "',IdMarca = " + articulo.Marca.Id + " ,IdCategoria = "+ articulo.Categoria.Id + ",Precio = " + articulo.Precio + " WHERE Id = " + articulo.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
}

