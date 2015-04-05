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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuarioService" en el código, en svc y en el archivo de configuración a la vez.
    public class UsuarioService : IUsuarioService
    {
        UsuarioDAO dao = new UsuarioDAO();
        public string crearUsuario(string dni, string nombre, string aparterno)
        {
           
            Usuario usuario = new Usuario();
            string a = nombre.Substring(0, 1).ToLower(); ;

            string user = a + aparterno.ToLower() ;
            string password= a+aparterno.Substring(0,1).ToLower()+dni.Substring(4,4);

            usuario.idTipoUsuario=1;
            usuario.usuario = user;
            usuario.password = password;
            usuario.estado = "1";
            usuario.fechaCreacion = DateTime.Now;

            dao.crearUsuario(usuario);

            return user;
        }

        public string ValidaUsuario(string usuario, string password)
        {
            return dao.validaUsuario(usuario, password);
        }
    }
}
