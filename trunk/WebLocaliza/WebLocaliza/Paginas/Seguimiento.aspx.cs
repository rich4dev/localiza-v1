using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;
using System.Drawing;
using WebLocaliza.UbicacionService;
using System.ServiceModel;
namespace WebLocaliza.Paginas
{
    public partial class Seguimiento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) {
               
            }
        }

        protected void btnBUscar_Click(object sender, EventArgs e)
        {
            UbicacionServiceClient proxy = new UbicacionServiceClient();
            Ubicacion ubi = new Ubicacion();

            

            try
            {
                ubi = proxy.listaUbicacion(TextBox1.Text);
                GLatLng milocacion = new GLatLng(ubi.latitud, ubi.longitud);
                GMap1.setCenter(milocacion, 14);

                XPinLetter Xpin = new XPinLetter(PinShapes.pin_star, "H", Color.Blue, Color.White, Color.Chocolate);
                GMap1.Add(new GMarker(milocacion, new GMarkerOptions(new GIcon(Xpin.ToString(), Xpin.Shadow()))));
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }
    }
}