Imports Localiza_VB.EnviosService
Public Class Envios
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub E_DNI_TextChanged(sender As Object, e As EventArgs) Handles E_CODIGO.TextChanged

    End Sub

    Protected Sub E_Guardar_Click(sender As Object, e As EventArgs) Handles E_Guardar.Click
        Dim rest As EnviosSVCClient = New EnviosSVCClient()
        Dim codigo As String = E_CODIGO.Text
        Dim DNI As String = E_DNI.Text
        Dim cantidad As String = E_Cantidad.Text
        Dim peso As String = E_Peso.Text
        Dim destinoInicio As String = E_DestinoIni.Text
        Dim destinoFinal As String = E_DestinoF.Text
        Dim chofer As String = E_Chofer.Text
        Dim ESTADO As String = "1"

        rest.CrearEnvio()
    End Sub

    Protected Sub tipoEnvio()

        Dim codigo As String = E_CODIGO.Text
        Dim DNI As String = E_DNI.Text
        Dim cantidad As String = E_Cantidad.Text
        Dim peso As String = E_Peso.Text
        Dim destinoInicio As String = E_DestinoIni.Text
        Dim destinoFinal As String = E_DestinoF.Text
        Dim chofer As String = E_Chofer.Text
        Dim ESTADO As String = "1"

    End Sub


End Class