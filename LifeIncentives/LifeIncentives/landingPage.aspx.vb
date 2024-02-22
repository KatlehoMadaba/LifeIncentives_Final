Public Class landingPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Redirect to the parentLogin.aspx page or add your login logic here

        ' Get the selected value of the dropdown
        Dim selectedValue As String = DropDownList.SelectedValue

        ' Redirect to the corresponding page based on the value
        Response.Redirect(selectedValue & ".aspx")


    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList.SelectedIndexChanged
        Response.Redirect(DropDownList.SelectedItem.Value)
    End Sub

End Class