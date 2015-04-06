using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICambiarContraseña" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IContraseña
    {
      [OperationContract]
        string CambContraseña(string usuario, string nuevaContraseña, string contraseña2);

        [OperationContract]
        string ValidaContraseñaActual(string usuario, string contraseña);
    }
    
}
