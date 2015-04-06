using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarioService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        string crearUsuario(string dni,string nombre,string aparterno);

        [OperationContract]
        string ValidaUsuario(string usuario,string password);

        [OperationContract]
        string ContraseñaExpirada(string usuario);
    }
}
