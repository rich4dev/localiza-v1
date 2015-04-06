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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CambiarContraseña" en el código, en svc y en el archivo de configuración a la vez.
    public class CambiarContraseña : IContraseña
    {
        ContraseñaDAO dao = new ContraseñaDAO();
        public string CambContraseña(string usuario, string contraseña1, string contraseña2)
        {
            Usuario usuario2 = new Usuario();

            usuario2.usuario = usuario;
            usuario2.password = contraseña1;

            if (contraseña1 == contraseña2)
            {
                dao.cambiarContraseña(usuario, contraseña1, contraseña2, DateTime.Now);

                return "1";
            }
            else
            {
                return "Las contraseñas no coinciden";
            }
        }
        
        public string ValidaContraseñaActual(string usuario, string password)
        {
            return dao.validaContraseñaActual(usuario, password);
        }
    }
}
