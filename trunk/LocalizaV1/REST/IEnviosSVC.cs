using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using REST.Dominio;

namespace REST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnviosSVC" in both code and config file together.
    [ServiceContract]
    public interface IEnviosSVC
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Envios", ResponseFormat = WebMessageFormat.Json)]
        Envio CrearEnvio(Envio envioACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Envios/{idEnvio}", ResponseFormat = WebMessageFormat.Json)]
        Envio ObtenerEnvio(string idEnvio);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Eliminar/{idEnvio}", ResponseFormat = WebMessageFormat.Json)]
        string EliminarEnvio(string idEnvio);

        [OperationContract]
        List<Envio> ListarEnvios();
    }
}
