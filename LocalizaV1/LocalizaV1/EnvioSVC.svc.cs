using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LocalizaV1.Dominio;
using LocalizaV1.Persistencia;

namespace LocalizaV1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "EnvioSVC" en el código, en svc y en el archivo de configuración a la vez.
    public class EnvioSVC : IEnvioSVC
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

        public Envio ModificarEnvio(Envio envioAModificar)
        {
            throw new NotImplementedException();
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
