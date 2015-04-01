using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using REST.Dominio;
using System.Data.SqlClient;

namespace REST.Persistencia
{
    public class EnvioDAO
    {
         public Envio Crear(Envio envioACrear)
        {
            Envio envioCreado = null;
            string sql = "INSERT INTO t_envio VALUES (@idEnvio, @idCliente, @cantidad, @peso, @destinoInicio, @destinoFin, @idTransporte, @estado)";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idEnvio", envioACrear.IdEnvio));
                    com.Parameters.Add(new SqlParameter("@idCliente", envioACrear.IdCliente));
                    com.Parameters.Add(new SqlParameter("@cantidad", envioACrear.Cantidad));
                    com.Parameters.Add(new SqlParameter("@peso", envioACrear.Peso));
                    com.Parameters.Add(new SqlParameter("@destinoInicio", envioACrear.DestinoInicio));
                    com.Parameters.Add(new SqlParameter("@destinoFin", envioACrear.DestinoFin));
                    com.Parameters.Add(new SqlParameter("@idTransporte", envioACrear.IdTransporte));
                    com.Parameters.Add(new SqlParameter("@estado", envioACrear.Estado));
                    com.ExecuteNonQuery();
                }

            }
            envioCreado = Obtener(envioACrear.IdEnvio);
            return envioCreado;
        }

        public Envio Obtener(string idEnvio)
        {
            Envio envioEncontrado = null;
            string sql = "SELECT * FROM t_envio WHERE idEnvio=@idEnvio";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idEnvio", idEnvio));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            envioEncontrado = new Envio()
                            {
                                IdEnvio = (string)resultado["idEnvio"],
                                IdCliente = (string)resultado["idCliente"],
                                Cantidad = (string)resultado["cantidad"],
                                Peso = (string)resultado["peso"],
                                DestinoInicio = (string)resultado["destinoInicio"],
                                DestinoFin = (string)resultado["destinoFin"],
                                IdTransporte = (string)resultado["idTransporte"],
                                Estado = (string)resultado["estado"]
                            };
                        }
                    }
                }
            }
            return envioEncontrado;
        }

        public Envio Modificar(Envio envioAModificar)
        {
            return null;
        }

        public void Eliminar(string idEnvio)
        {
            string sql = "delete from t_envio where idEnvio=@idEnvio";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idEnvio", idEnvio));
                    com.ExecuteNonQuery();
                }
            }
        }

        public List<Envio> ListarTodos()
        {
            return null;
        }
    }
}
