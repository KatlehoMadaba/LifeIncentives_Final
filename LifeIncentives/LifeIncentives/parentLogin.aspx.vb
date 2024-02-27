Imports System.Data.SqlClient
Imports System.Web.Services.Description

Public Class parentLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub btnParentLogin_Click(sender As Object, e As EventArgs) Handles btnParentLogin.Click

    End Sub

    Protected Sub btnChildLogin_Click(sender As Object, e As EventArgs) Handles btnChildLogin.Click
        Response.Redirect("child_Login.aspx")
    End Sub
End Class