using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalizaV1.Dominio
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }

    }
}