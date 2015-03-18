using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocalizaV1.Persistencia;
using LocalizaV1.Dominio;

namespace LocalizaV1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteSVC" in code, svc and config file together.
    public class ClienteSVC : IClienteSVC
    {
        private ClienteDAO clienteDAO = null;
        private ClienteDAO ClienteDAO
        {
            get
            {
                if (clienteDAO == null)
                    clienteDAO = new ClienteDAO();
                return clienteDAO;
            }
        }

        public Cliente CrearCliente(string nombre, string paterno, string materno, string genero, string dni, string email, string telefono, string direccion, string distrito)
        {
            Cliente cliente = new Cliente()
            {
                nombre=nombre,
                apPaterno=paterno,
                apMaterno=materno,
                genero=genero,
                dni=dni,
                email=email,
                telefono=telefono,
                direccion=direccion,
                distrito=distrito
            };

            return ClienteDAO.Crear(cliente);
        }

        public Cliente ObtenerCliente(int codigo)
        {
            return ClienteDAO.Obtener(codigo);
        }

        public Cliente ModificarCliente(int codigo, string nombre, string paterno, string materno, string genero, string dni, string email, string telefono, string direccion, string distrito)
        {
            Cliente cliente = new Cliente()
            {
                idCliente=codigo,
                nombre = nombre,
                apMaterno = materno,
                apPaterno = paterno,
                genero = genero,
                dni = dni,
                email = email,
                telefono = telefono,
                direccion = direccion,
                distrito = distrito
            };

            return ClienteDAO.Modificar(cliente);
        }

        public void EliminarCliente(int codigo)
        {
            Cliente clienteexiste = clienteDAO.Obtener(codigo);
            clienteDAO.Eliminar(clienteexiste);
        }

        public List<Cliente> ListarCliente()
        {
            return clienteDAO.ListarTodos().ToList();
        }


        public bool validaDni(string dni)
        {
             bool result = false;

            int cantidadDigitos = dni.Trim().Length;

            if (cantidadDigitos == 8)
            {
                result =  true;
            }
            else
            {
                result = false;
            };

            return result;
            
        }


        public string mensajes(int valor)
        {

            string mensaje = "";

            if (valor==1){
                mensaje="La cantidad de digitos debe ser 8";
            }else if(valor==2){
                mensaje="El cliente ya esta registrado";
            }else if(valor==3)
            {
                mensaje = "";
            };

            return mensaje;
        }


        public bool validaCliente(string dni)
        {
            throw new NotImplementedException();
        }
    }
}
