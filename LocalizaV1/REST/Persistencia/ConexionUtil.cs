﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena
        {
            get
            {
                return "Data Source=.;Initial Catalog=Localiza;Integrated Security=SSPI;";
            }
        }
    }
}