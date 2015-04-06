using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLocaliza.ContraseñaService;

namespace WebLocaliza.Paginas
{
    public partial class CambiarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = this.Request.QueryString.Get(0);
        }

        protected void BtnCambiar_Click(object sender, EventArgs e)
        {
            string username = this.Request.QueryString.Get(0);
            ContraseñaClient proxy = new ContraseñaClient();

            string msg = proxy.ValidaContraseñaActual(username, txtContraseñaActual.Text);
            string cambiarContraseña = proxy.CambContraseña(username, txtNuevaContraseña.Text, txTconfirmacionContraseña.Text);

            if (msg != null)
            {
                FailureText.Text = msg;

            }
            else
            {
                if (cambiarContraseña == "1")
                {
                    FailureText.Text = "La contraseña se cambio correctamente";
                }
                else
                {
                    FailureText.Text = cambiarContraseña;
                }
            }
        }
    }
}