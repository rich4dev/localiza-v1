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
            string contraseñaExpirada = proxy.ContraseñaExpirada(UserName.Text);

            if (msg != "1" && msg != "2")
            {
                FailureText.Text = msg;
            }
            else
            {
                if (contraseñaExpirada != "1")
                {
                    HyperLink1.Text = "Aqui";
                    HyperLink1.NavigateUrl = "~/Paginas/CambiarContraseña.aspx?dato="+UserName.Text;
                    FailureText.Text = contraseñaExpirada + ". Haz click para cambiarla ";

                }else if (msg == "2")
                {
                    Response.Redirect("~/Paginas/Envio.aspx");

                }
                else if (msg == "1")
                {
                    Response.Redirect("~/Paginas/Seguimiento.aspx");
                }
                else
                {
                    FailureText.Text = msg;
                }
            }
        }
    }
}