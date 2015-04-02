using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace LocalizaV1.Persistencia
{
    public class TransporteDAO
    {
        public DataTable listaVehiculos()
        {
            SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena());
            SqlDataAdapter da = new SqlDataAdapter("select * from t_transporte", con);

            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
            
    }
}