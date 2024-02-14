Imports System.Data.SqlClient
Imports System.Web.Services.Description

Public Class parentLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(HttpContext.Current.Session("conn")) Then
            HttpContext.Current.Session("conn") = DBInterface.connect(ConfigurationManager.ConnectionStrings("conn2").ConnectionString)
        End If
    End Sub


    Protected Sub Login_Click(sender As Object, e As EventArgs)
        Dim Email As String = txtEmail.Text
        Dim Password As String = txtPassword.Text

    End Sub





End Class