using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using WebLocaliza.TransporteService;


namespace WebLocaliza.Account
{
    public partial class Envio : System.Web.UI.Page
    {
        Transporte proxy = new Transporte();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //cbotransporte.DataSource = proxy.ListarTransporte();
            //cbotransporte.DataTextField = "descripcion";
            //cbotransporte.DataValueField = "idTransporte";
            //cbotransporte.DataBind();

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            //string postdata = "{\"IdEnvio\":\"5\",\"IdCliente\":\"1\",\"Cantidad\":\"2\",\"Peso\":\"500\",\"DestinoInicio\":\"Lima\",\"DestinoFin\":\"trujillo\",\"IdTransporte\":\"1\",\"Estado\":\"1\"}";
            string postdata = "{\"IdEnvio\":" + "\"" + txtcodigo.Text + "\"" + "," +
                              "\"IdCliente\":" + "\"" + txtdni.Text + "\"" + "," +
                              "\"Cantidad\":" + "\"" + txtcantidad.Text + "\"" + "," +
                              "\"Peso\":" + "\"" + txtpeso.Text + "\"" + "," +
                              "\"DestinoInicio\":" + "\"" + cboorigen.SelectedItem.ToString() + "\"" + "," +
                              "\"DestinoFin\":" + "\"" + cbodestino.SelectedItem.ToString() + "\"" + "," +
                              "\"IdTransporte\":" + "\"" + cbotransporte.SelectedValue.ToString() + "\"" + "," +
                              "\"Estado\":" + "\"" + 1 + "\"" + "}";
                
            //{"IdEnvio":"5","IdCliente":"1","Cantidad":"2","Peso":"500","DestinoInicio":"Lima","DestinoFin":"trujillo","IdTransporte":"1","Estado":"1"}                
            //{"IdEnvio":"6","IdCliente":"1212","Cantidad":"1","Peso":"1","DestinoInicio":"Lima","DestinoFin":"Lima","IdTransporte":"1","Estado":"1"} 
            Label1.Text = postdata;
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:31030/EnviosSVC.svc/Envios");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string clientejson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Envio crear = js.Deserialize<Envio>(clientejson);

                Label1.Text = "Envio Registrado";

            }
            catch (WebException ex)
            {
                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                string message = ((HttpWebResponse)ex.Response).StatusDescription;
                StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);

                Label1.Text = mensaje;
            }
        }

     
    }
}