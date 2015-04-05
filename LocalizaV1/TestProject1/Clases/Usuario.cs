using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1.Clases
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public int idTipoUsuario { get; set; }
        public string password { get; set; }
        public string estado { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
