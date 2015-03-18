Imports Localiza_VB.ServiceCliente




Public Class Cliente
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub C_Guardar_Click(sender As Object, e As EventArgs) Handles C_Guardar.Click

        Dim proxy As ClienteSVCClient = New ClienteSVCClient()


        Dim nombre As String = C_Nombre.Text
        Dim paterno As String = C_ApPaterno.Text
        Dim materno As String = C_ApeMaterno.Text
        Dim genero As String = C_Genero.Text
        Dim dni As String = C_DNI.Text
        Dim email As String = C_Correo.Text
        Dim telefono As String = C_Telefono.Text
        Dim direccion As String = C_Direccion.Text
        Dim distrito As String = C_Distrito.Text

        Dim valida As Boolean = proxy.validaDni(dni)

        If valida = True Then

            proxy.CrearCliente(nombre, paterno, materno, genero, dni, email, telefono, direccion, distrito)

            lbltexto.Text = "Usuario registrado"
        Else


            lbltexto.Text = proxy.mensajes(1)

        End If




    End Sub

   
End Class