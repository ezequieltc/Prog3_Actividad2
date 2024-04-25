using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        List<Marca> listado = new List<Marca>();

        public List<Marca> listarMarcas()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.configurarConsulta("SELECT Id, Descripcion from MARCAS");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Marca tmp = new Marca();
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
    }
}
