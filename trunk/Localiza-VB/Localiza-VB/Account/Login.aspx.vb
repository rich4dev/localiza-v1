Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
    End Sub

    Protected Sub LoginUser_Authenticate(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AuthenticateEventArgs) Handles LoginUser.Authenticate

    End Sub

    Protected Sub ChangePasswordButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("ChangePassword.aspx")
    End Sub

End Class