using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebLocaliza.UsuarioService;

namespace WebLocaliza.Paginas
{
    public partial class Logueo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            UsuarioServiceClient proxy = new UsuarioServiceClient();

            string msg = proxy.ValidaUsuario(UserName.Text, Password.Text);

            if (msg=="2"){
                Response.Redirect("~/Paginas/Envio.aspx");
            }
            else if (msg == "1")
            {
                Response.Redirect("~/Paginas/Logueo.aspx");
            }else
            {
                FailureText.Text=msg;
            }
           
        }
    }
}