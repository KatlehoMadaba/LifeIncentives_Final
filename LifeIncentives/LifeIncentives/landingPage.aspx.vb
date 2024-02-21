Public Class landingPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)

        Response.Redirect("parentLogin.aspx")


    End Sub

    Protected Sub SignupButton_Click(sender As Object, e As EventArgs)

    End Sub
    'Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList.SelectedIndexChanged
    '    'Response.Redirect(DropDownList.SelectedItem.Value)
    'End Sub

End Class