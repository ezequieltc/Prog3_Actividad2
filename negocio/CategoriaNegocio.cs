using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        List<Categoria> listado = new List<Categoria>();

        public List<Categoria> listarCategorias()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.configurarConsulta("SELECT Id, Descripcion from CATEGORIAS");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Categoria tmp = new Categoria();
                    tmp.Id = (int)datos.Lector["Id"];
                    tmp.Descripcion = (string)datos.Lector["Descripcion"];

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
        public void agregar(string categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.configurarConsulta("insert into CATEGORIAS values('" + categoria + "')");
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
