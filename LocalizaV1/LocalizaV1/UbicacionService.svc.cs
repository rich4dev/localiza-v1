using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocalizaV1.Dominio;
using LocalizaV1.Persistencia;
using System.Messaging;
using System.Net;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UbicacionService" en el código, en svc y en el archivo de configuración a la vez.
    public class UbicacionService : IUbicacionService
    {
        UbicacionDAO tdao = new UbicacionDAO();
        public string actualizaUbicacion(Ubicacion ubicacion)
        {
            string rutaCola = @".\private$\proyecto";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);

            MessageQueue cola = new MessageQueue(rutaCola);
            Message mensaje = new Message();
            mensaje.Label = "Registro la intencion";
            mensaje.Body = new Ubicacion() { idEnvio = ubicacion.idEnvio, latitud=ubicacion.latitud,longitud=ubicacion.longitud };
            cola.Send(mensaje);

            return ubicacion.idEnvio;
        }

        public string ubicacion(Ubicacion ubicacion)
        {
            

            Ubicacion valida = tdao.ObtenerUbicacion(ubicacion.idEnvio);

            if (valida != null)
            {

                return tdao.actualizaUbicacion(ubicacion);
            }
            else
            {
                return tdao.registraUbicacion(ubicacion);
            }
           
        }
        public Ubicacion listaUbicacion(string idenvio)
        {
            string rutaCola = @".\private$\proyecto";
            if (!MessageQueue.Exists(rutaCola))
                MessageQueue.Create(rutaCola);
            MessageQueue cola = new MessageQueue(rutaCola);



            ///regularizar peidos
            int x = cola.GetAllMessages().Count();

            for (int i = 1; i <= x; i++)
            {

                cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Ubicacion) });

                Message mensaje = cola.Receive();
                Ubicacion nota = (Ubicacion)mensaje.Body;

                string pedido = ubicacion(nota);

            }

          //Ubicacion ubi = tdao.ObtenerUbicacion(idenvio);
  
          //  //if(ubi==null){

            //    throw new FaultException("No tiene pedidos en ruta", FaultCode.CreateSenderFaultCode("Fallo", "No tiene pedidos en ruta"),"G");

            //}

            return tdao.ObtenerUbicacion(idenvio);
               
        }
    }
}
