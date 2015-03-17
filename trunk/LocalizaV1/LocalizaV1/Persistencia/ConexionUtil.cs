using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalizaV1.Persistencia
{
    public class ConexionUtil
    {

        public static string ObtenerCadena()
        {
            return "Data Source=(local); Initial Catalog=Localiza;Integrated Security=SSPI;";

        }
    }
}