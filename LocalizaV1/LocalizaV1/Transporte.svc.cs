using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using LocalizaV1.Persistencia;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Transporte" en el código, en svc y en el archivo de configuración a la vez.
    public class Transporte : ITransporte
    {
        TransporteDAO tdao = new TransporteDAO();
        public DataTable ListarTransporte()
        {
            return tdao.listaVehiculos();
        }
    }
}
