using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LocalizaV1.Dominio;
using System.Data.SqlClient;

namespace LocalizaV1.Persistencia
{
    public class UsuarioDAO
    {
        public Usuario crearUsuario(Usuario usuario)
        {
       
            Usuario envioCreado = null;
            string sql = "INSERT INTO t_usuario VALUES (@usu, @tipo, @pas, @estado, @fecha)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@usu", usuario.usuario));
                    com.Parameters.Add(new SqlParameter("@tipo", usuario.idTipoUsuario));
                    com.Parameters.Add(new SqlParameter("@pas", usuario.password));
                    com.Parameters.Add(new SqlParameter("@estado", usuario.estado));
                    com.Parameters.Add(new SqlParameter("@fecha", usuario.fechaCreacion));
                    com.ExecuteNonQuery();
                }

            }
            envioCreado = Obtener(usuario.usuario);
            return envioCreado;
        }

        public Usuario Obtener(string idEnvio)
        {
            Usuario envioEncontrado = null;
            string sql = "SELECT * FROM t_usuario WHERE usuario=@idEnvio";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idEnvio", idEnvio));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            envioEncontrado = new Usuario()
                            {
                                idUsuario = (int)resultado["idUsuario"],
                                usuario = (string)resultado["usuario"],
                                idTipoUsuario = (int)resultado["idTipoUsuario"],
                                password = (string)resultado["password"],
                                estado = (string)resultado["estado"],
                                fechaCreacion = (DateTime)resultado["fechaCreacion"]
                            };
                        }
                    }
                }
            }
            return envioEncontrado;
        }

        public string validaUsuario(string usuario,string password)
        {
            int tipo = 0;

            string sql = "SELECT idtipousuario FROM t_usuario WHERE usuario=@idEnvio and password=@pas";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idEnvio", usuario));
                    com.Parameters.Add(new SqlParameter("@pas", password));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            tipo = (int)resultado["idTipoUsuario"];
                           
                        }
                    }
                }
            }

            if (tipo == 0)
            {
                return "Usuario y/o Passsword esta incorrecta";
            }
            else
            {
                return tipo.ToString();
            }
            
        }
            
    }
}