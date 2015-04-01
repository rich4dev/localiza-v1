using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace REST.Persistencia
{
    public class TransporteDAO
    {
        public void ActualizarCarga(int idTransp,int peso,int cantidad)
        {

            string sql = "update t_transporte set cargaActual=@peso where idTransporte=@idEnvio";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@idEnvio", idTransp));
                    com.Parameters.Add(new SqlParameter("@peso", peso*cantidad));
                    com.ExecuteNonQuery();
                }
            }
        }

        public bool ValidarCarga(int idTransp, int peso, int cantidad)
        {
            int cargaActual=0;
            int cargaMax=0;

            string sql = "select * from t_transporte where idTransporte=@cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", idTransp));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            cargaActual = (int)resultado["cargaActual"];
                            cargaMax = (int)resultado["cargaMax"];
                        }
                    }
                }
            }

            if (peso*cantidad + cargaActual <= cargaMax)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}