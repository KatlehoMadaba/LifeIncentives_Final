Imports System.Data.SqlClient
Imports System.Web.Services.Description

Public Class child_Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(HttpContext.Current.Session("conn")) Then
            HttpContext.Current.Session("conn") = DBInterface.connect(ConfigurationManager.ConnectionStrings("conn2").ConnectionString)
        End If
    End Sub


    Protected Sub Login_Click(sender As Object, e As EventArgs)

        Dim Name As String = txtName.Text
        Dim Password As String = txtID.Text

        If IsValidUser(Name, Password) Then
            Session("password") = Password
            Response.Redirect("childDashboard.aspx")
        End If
    End Sub

    Protected Sub btnParentLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
        Response.Redirect("parentLogin.aspx")

    End Sub
    Private Function IsValidUser(ByVal name As String, ByVal password As String) As Boolean
        Dim isValid As Boolean = False
        Using connection As New SqlConnection("Data Source=ASUSVIVOBOOK;Initial Catalog=LifeIncentive;Integrated Security=True")
            Dim query As String = "SELECT COUNT(*) FROM TBL_Child_User WHERE Child_Name = @Child_Name AND Child_Password = @Child_Password"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Child_Name", name)
                command.Parameters.AddWithValue("@Child_Password", password)
                connection.Open()
                Dim count As Integer = CInt(command.ExecuteScalar())
                If count > 0 Then
                    isValid = True
                End If
            End Using
        End Using
        Return isValid
    End Function

End Class