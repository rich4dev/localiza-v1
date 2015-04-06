using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using LocalizaV1.Dominio;

namespace LocalizaV1.Persistencia
{
    public class ContraseñaDAO
    {
        public string validaContraseñaActual(string usuario, string password)
        {
            string contraseña = null;

            string sql = "SELECT [password] FROM t_usuario WHERE usuario=@idEnvio and password=@pas";
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
                            contraseña = (string)resultado["password"];

                        }
                    }
                }
            }

            if (contraseña == null)
            {
                return "La contraseña actual es incorrecta";
            }
            else
            {
                return null;
            }

        }

        public Usuario cambiarContraseña(string usuario, string nuevaContraseña, string contraseña, DateTime nuevaFecha)
        {
            Usuario cambiarContraseña = null;

            if (nuevaContraseña == contraseña)
            {
                string sql = "update t_usuario set [password] = @npas, [fechaCreacion] = @nfecha WHERE usuario=@idEnvio";
                using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
                {
                    con.Open();
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        com.Parameters.Add(new SqlParameter("@idEnvio", usuario));
                        com.Parameters.Add(new SqlParameter("@npas", nuevaContraseña));
                        com.Parameters.Add(new SqlParameter("@nfecha", nuevaFecha));
                        using (SqlDataReader resultado = com.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                cambiarContraseña = new Usuario()
                                {
                                    usuario = (string)resultado["usuario"],
                                    password = (string)resultado["password"],
                                    fechaCreacion = (DateTime)resultado["fechaCreacion"]
                                };
                            }
                        }
                    }
                }
                return cambiarContraseña;
            }
            return null;
        }
    }
}