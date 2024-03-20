Public Class landingPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("parentLogin.aspx")

    End Sub

    Protected Sub btnSignUp_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("signUp.aspx")
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub


End Class