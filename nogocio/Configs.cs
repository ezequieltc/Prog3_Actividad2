using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class Configs
    {
        //Datos de conexion a la DDBB
        static public string DbServer { get { return ".\\"; } }

        static public string Database { get { return "CATALOGO_P3_DB"; } }

        static public bool SecurityIntegrated { get { return true; }  }

    }
}
