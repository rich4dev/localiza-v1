using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using LocalizaV1.Dominio;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IEnvioSVC" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IEnvioSVC
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Envios", ResponseFormat = WebMessageFormat.Json)]
        Envio CrearEnvio(Envio envioACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Envios/{idEnvio}", ResponseFormat = WebMessageFormat.Json)]
        Envio ObtenerEnvio(string idEnvio);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Envios", ResponseFormat = WebMessageFormat.Json)]
        Envio ModificarEnvio(Envio envioAModificar);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Eliminar/{idEnvio}", ResponseFormat = WebMessageFormat.Json)]
        string EliminarEnvio(string idEnvio);

        [OperationContract]
        List<Envio> ListarEnvios();
    }
}
