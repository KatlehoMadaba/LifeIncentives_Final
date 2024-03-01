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
        Dim ChildID As String = txtChildID.Text

        If IsValidUser(Email, Password, childID) Then
            Session("email") = Email
            Response.Redirect("parentDashboard.aspx")
        End If
    End Sub

    Private Function IsValidUser(ByVal Email As String, ByVal password As String, ByVal childID As String) As Boolean
        Dim isValid As Boolean = False
        Using connection As New SqlConnection("Data Source=ASUSVIVOBOOK;Initial Catalog=LifeIncentive;Integrated Security=True")
            Dim query As String = "SELECT COUNT(*) FROM TBL_Parent_User WHERE Email = @Email AND Password = @Password AND Child_ID=@Child_ID"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", Email)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@Child_ID", childID)
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