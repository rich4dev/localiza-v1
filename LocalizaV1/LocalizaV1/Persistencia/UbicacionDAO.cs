using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LocalizaV1.Dominio;
using System.Data.SqlClient;

namespace LocalizaV1.Persistencia
{
    public class UbicacionDAO
    {
        public string registraUbicacion(Ubicacion ubicacion)
        {

            string sql = "INSERT INTO t_ubicacion VALUES (@usu, @pas, @estado)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@usu", ubicacion.idEnvio));
                    com.Parameters.Add(new SqlParameter("@pas", ubicacion.latitud));
                    com.Parameters.Add(new SqlParameter("@estado", ubicacion.longitud));
                    com.ExecuteNonQuery();
                }

            }
            return "Ubicacion actualizada";
        }

        public string actualizaUbicacion(Ubicacion ubicacion)
        {

            string sql = "update t_ubicacion set latitud=@pas, longitud=@estado where idEnvio=@usu";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@usu", ubicacion.idEnvio));
                    com.Parameters.Add(new SqlParameter("@pas", ubicacion.latitud));
                    com.Parameters.Add(new SqlParameter("@estado", ubicacion.longitud));
                    com.ExecuteNonQuery();
                }

            }
            return "Ubicacion actualizada";
        }

        public Ubicacion ObtenerUbicacion(string idEnvio)
        {
            Ubicacion envioEncontrado = null;
            string sql = "SELECT * FROM t_ubicacion WHERE idEnvio=@idEnvio";
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
                            envioEncontrado = new Ubicacion()
                            {
                                idEnvio = (string)resultado["idEnvio"],
                                latitud = (double)resultado["latitud"],
                                longitud = (double)resultado["longitud"]
                            };
                        }
                    }
                }
            }
            return envioEncontrado;
        }
    }
}