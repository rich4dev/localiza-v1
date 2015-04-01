using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using REST.Dominio;
using REST.Persistencia;

namespace REST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnviosSVC" in code, svc and config file together.
    public class EnviosSVC : IEnviosSVC
    {
        private EnvioDAO dao = new EnvioDAO();

        public Envio CrearEnvio(Envio envioACrear)
        {
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
