Imports Localiza_VB.ServiceCliente

Public Class Cliente
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        C_Nombre.Enabled = False
        C_ApPaterno.Enabled = False
        C_ApeMaterno.Enabled = False
        C_Genero.Enabled = False
        C_Correo.Enabled = False
        C_Telefono.Enabled = False
        C_Direccion.Enabled = False
        C_Distrito.Enabled = False
        C_Guardar.Enabled = False

    End Sub

    Protected Sub C_Guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles C_Guardar.Click

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
            lbltexto.Text = ""
            C_Nombre.Enabled = True
            C_ApPaterno.Enabled = True
            C_ApeMaterno.Enabled = True
            C_Genero.Enabled = True
            C_Correo.Enabled = True
            C_Telefono.Enabled = True
            C_Direccion.Enabled = True
            C_Distrito.Enabled = True
            C_Guardar.Enabled = True
            lbltexto.Text = proxy.mensajes(1)
        End If


    End Sub


    Protected Sub C_Consultar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles C_Consultar.Click
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
        Dim dniExiste As Boolean = proxy.encuentraDni(dni)

        If dniExiste = True Then
            C_Nombre.Text = nombre
            C_ApPaterno.Text = paterno
            C_ApeMaterno.Text = materno
            C_Genero.Text = genero
            C_DNI.Text = dni
            C_Correo.Text = email
            C_Telefono.Text = telefono
            C_Direccion.Text = direccion
            C_Distrito.Text = distrito

            lbltexto.Text = proxy.mensajes(2)


        Else

            lbltexto.Text = ""
            C_Nombre.Enabled = True
            C_ApPaterno.Enabled = True
            C_ApeMaterno.Enabled = True
            C_Genero.Enabled = True
            C_Correo.Enabled = True
            C_Telefono.Enabled = True
            C_Direccion.Enabled = True
            C_Distrito.Enabled = True
            C_Guardar.Enabled = True

        End If

    End Sub
End Class