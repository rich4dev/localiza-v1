using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocalizaV1.Dominio;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarioSVC" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUsuarioSVC
    {
        [OperationContract]
        Usuario CrearUsuario(string nombre, string correo, string password);
        [OperationContract]
        Usuario ObtenerUsuario(int codigo);
        [OperationContract]
        Usuario ModificarUsuario(int codigo, string nombre, string correo, string password);
        [OperationContract]
        void EliminarUsuario(int codigo);
        [OperationContract]
        List<Usuario> ListarUsuarios();

    }
}
