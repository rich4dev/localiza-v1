Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization


Public Class Envios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub E_DNI_TextChanged(sender As Object, e As EventArgs) Handles E_CODIGO.TextChanged

    End Sub

    Protected Sub E_Guardar_Click(sender As Object, e As EventArgs) Handles E_Guardar.Click


        Dim request As HttpWebRequest = DirectCast(HttpWebRequest.Create("http://localhost:31030/EnviosSVC.svc/Envios"), HttpWebRequest)
        Dim data As String = "{\'IdEnvio\':\'2\',\'IdCliente\':\'1\',\'Cantidad\':\'2\',\'Peso\':\'500\',\'DestinoInicio\':\'Lima\',\'DestinoFin\':\'trujillo\',\'IdTransporte\':\'2\',\'Estado\':\'1\'}"
        ''Dim data As String = 
        request.Method = "POST"
        request.ContentType = "application/json"

        Dim encoding As New System.Text.UTF8Encoding()
        Dim bytes As Byte() = encoding.GetBytes(data)

        request.ContentLength = bytes.Length

        Using requestStream As Stream = request.GetRequestStream()
            ' Send the data.
            requestStream.Write(bytes, 0, bytes.Length)
        End Using

        Dim var As HttpWebResponse = request.GetResponse()
        Dim reader As StreamReader = New StreamReader(var.GetResponseStream())
        Dim jason As String = reader.ReadToEnd()
        Dim js As JavaScriptSerializer = New JavaScriptSerializer()
        Dim envio As Envios = js.Deserialize(Of Envios)(jason)






    End Sub



End Class