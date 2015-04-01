using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using REST.Dominio;
using REST.Persistencia;
using System.ServiceModel.Web;
using System.Net;

namespace REST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnviosSVC" in code, svc and config file together.
    public class EnviosSVC : IEnviosSVC
    {
        private EnvioDAO dao = new EnvioDAO();
        private TransporteDAO tdao = new TransporteDAO();

        public Envio CrearEnvio(Envio envioACrear)
        {
            bool valida = false;

            valida = tdao.ValidarCarga(Convert.ToInt32(envioACrear.IdTransporte), Convert.ToInt32(envioACrear.Peso), Convert.ToInt32(envioACrear.Cantidad));

            if (valida==false){

                throw new WebFaultException<string>("El Peso excede el Peso Maximo del transporte, asigne otro tranpsorte", HttpStatusCode.InternalServerError);
            }

            tdao.ActualizarCarga(Convert.ToInt32(envioACrear.IdTransporte), Convert.ToInt32(envioACrear.Peso), Convert.ToInt32(envioACrear.Cantidad));
            return dao.Crear(envioACrear);
        }

        public Envio ObtenerEnvio(string idEnvio)
        {
            return dao.Obtener(idEnvio);
        }

        public string EliminarEnvio(string idEnvio)
        {
            dao.Eliminar(idEnvio);
            return "Envio eliminado";
        }

        public List<Envio> ListarEnvios()
        {
            throw new NotImplementedException();
        }
    }
}
