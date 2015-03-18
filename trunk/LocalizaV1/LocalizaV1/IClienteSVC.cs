using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocalizaV1.Dominio;

namespace LocalizaV1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClienteSVC" in both code and config file together.
    [ServiceContract]
    public interface IClienteSVC
    {
        [OperationContract]
        Cliente CrearCliente(string nombre, string paterno, string materno, string genero, string dni, string email,
                             string telefono, string direccion, string distrito);
        [OperationContract]
        Cliente ObtenerCliente(int codigo);
        [OperationContract]
        Cliente ModificarCliente(int codigo, string nombre, string paterno, string materno, string genero, string dni, string email,
                             string telefono, string direccion, string distrito);
        [OperationContract]
        void EliminarCliente(int codigo);
        [OperationContract]
        List<Cliente> ListarCliente();

        [OperationContract]
        bool validaDni(string dni);

        [OperationContract]
        bool validaCliente(string dni);

        [OperationContract]
        string mensajes(int valor);
    }
}
