﻿using System;
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

    }
}
