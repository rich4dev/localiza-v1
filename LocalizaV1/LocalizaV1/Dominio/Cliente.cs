using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalizaV1.Dominio
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string genero { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }

    }
}