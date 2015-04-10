using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocalizaV1.Dominio;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUbicacionService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUbicacionService
    {
        [OperationContract]
        string actualizaUbicacion(Ubicacion ubicacion);

        [OperationContract]
        Ubicacion listaUbicacion(string idenvio);
    }
}
