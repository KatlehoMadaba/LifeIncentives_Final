Public Class landingPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Redirect to the parentLogin.aspx page or add your login logic here
        Response.Redirect("parentLogin.aspx")
    End Sub

    Protected Sub SignupButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Redirect to the parentLogin.aspx page or add your login logic here
        Response.Redirect("parentLogin.aspx")
    End Sub
End Class