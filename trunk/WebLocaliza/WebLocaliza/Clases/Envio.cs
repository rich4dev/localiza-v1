using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLocaliza.Clases
{
    public class Envio
    {
        public string IdEnvio { get; set; }

        public string IdCliente { get; set; }

        public string Cantidad { get; set; }

        public string Peso { get; set; }

        public string DestinoInicio { get; set; }

        public string DestinoFin { get; set; }

        public string IdTransporte { get; set; }

        public string Estado { get; set; }
    }
}