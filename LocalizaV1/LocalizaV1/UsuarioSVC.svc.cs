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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UsuarioSVC" en el código, en svc y en el archivo de configuración a la vez.
    public class UsuarioSVC : IUsuarioSVC
    {
        private UsuarioDAO usuarioDAO = null;
        private UsuarioDAO UsuarioDAO
        {
            get
            {
                if (usuarioDAO == null)
                    usuarioDAO = new UsuarioDAO();
                return usuarioDAO;
            }
        }

        public Usuario CrearUsuario(string nombre, string correo, string password)
        {
            
            Usuario usuarioACrear = new Usuario()
            {
                Nombre = nombre,
                Correo = correo,
                Password = password,

            };
            return UsuarioDAO.Crear(usuarioACrear);
        }

        public Usuario ObtenerUsuario(int codigo)
        {
            return UsuarioDAO.Obtener(codigo);
        }

        public Usuario ModificarUsuario(int codigo, string nombre, string correo, string password)
        {
           
            Usuario usuarioAModificar = new Usuario()
            {
                Codigo = codigo,
                Nombre = nombre,
                Correo = correo,
                Password = password,

            };
            return UsuarioDAO.Modificar(usuarioAModificar);
        }

        public void EliminarUsuario(int codigo)
        {
            Usuario usuarioExistente = UsuarioDAO.Obtener(codigo);
            UsuarioDAO.Eliminar(usuarioExistente);
        }

        public List<Usuario> ListarUsuarios()
        {
            return UsuarioDAO.ListarTodos().ToList();
        }
    }
}
