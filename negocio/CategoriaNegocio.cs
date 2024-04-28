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
        private List<Categoria> listado = new List<Categoria>();
        private AccesoDatos datos;

        public CategoriaNegocio()
        {
            datos = new AccesoDatos();
        }

        public List<Categoria> listarCategorias()
        {
            
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

            try
            {
                datos.configurarConsulta("insert into CATEGORIAS values(@categoria)");
                datos.setearParametros("@categoria", categoria);
                datos.ejecutarAccionNoEscalar();
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

        public void eliminar(Categoria categoria)
        {

            try
            {
                datos.configurarConsulta("DELETE FROM CATEGORIAS WHERE Id = @idCategoria");
                datos.setearParametros("@idCategoria", categoria.Id);
                datos.ejecutarAccionNoEscalar();

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

        public void actualizar(Categoria categoria)
        {

            try
            {
                datos.configurarConsulta("UPDATE CATEGORIAS SET  Descripcion = @descripcion WHERE Id = @idCategoria");
                datos.setearParametros("@idCategoria", categoria.Id);
                datos.setearParametros("@descripcion", categoria.Descripcion);
                datos.ejecutarAccionNoEscalar();

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
