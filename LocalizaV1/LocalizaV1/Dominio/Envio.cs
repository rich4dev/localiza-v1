using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace LocalizaV1.Dominio
{
    public class Envio
    {
        [DataMember]
        public string IdEnvio { get; set; }
        [DataMember]
        public string IdCliente { get; set; }
        [DataMember]
        public string Cantidad { get; set; }
        [DataMember]
        public string Peso { get; set; }
        [DataMember]
        public string DestinoInicio { get; set; }
        [DataMember]
        public string DestinoFin { get; set; }
        [DataMember]
        public string IdTransporte { get; set; }
        [DataMember]
        public string Estado { get; set; }
    }

}