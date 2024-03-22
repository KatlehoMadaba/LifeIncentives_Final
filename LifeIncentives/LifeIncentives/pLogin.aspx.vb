Imports System.Data.SqlClient

Public Class pLogin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(HttpContext.Current.Session("conn")) Then
            HttpContext.Current.Session("conn") = DBInterface.connect(ConfigurationManager.ConnectionStrings("conn2").ConnectionString)
        End If
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)
        Dim Email As String = emailtxt.Text

        Dim loginSessionId As String = idttxt.Text

        Session("loginSessionId") = loginSessionId
        Response.Redirect("PDashboard.aspx")
    End Sub
    'Private Function IsValidUser(ByVal Email As String, ByVal password As String) As Boolean
    '    Dim isValid As Boolean = False
    '    Using connection As New SqlConnection("Data Source=ASUSVIVOBOOK;Initial Catalog=LifeIncentive;Integrated Security=True")
    '        Dim query As String = "SELECT COUNT(*) FROM TBL_Parent_User WHERE Email = @Email AND Password = @Password"
    '        Using command As New SqlCommand(query, connection)
    '            command.Parameters.AddWithValue("@Email", Email)
    '            command.Parameters.AddWithValue("@Password", password)
    '            connection.Open()
    '            Dim count As Integer = CInt(command.ExecuteScalar())
    '            If count > 0 Then
    '                isValid = True
    '            End If
    '        End Using
    '    End Using
    '    Return isValid
    'End Function
    'Private Function IsValidUser()
    '    Dim validId As String = idttxt.Text.ToString()

    'End Function
    'Private Function IsValidUser(ByVal Email As String, ByVal password As String, ByVal ID As String) As Boolean
    '    Dim isValid As Boolean = False
    '    If childId IsNot Nothing AndAlso Not String.IsNullOrEmpty(childId.ToString()) Then
    '        Dim columnNameAsList As List(Of TBL_Parent_User) = TBL_Parent_User.listall($"where Child_ID= '{childId}'")
    '        'childnameLabel.Text = columnNameAsList(0).ToString()
    '        For Each dp As TBL_Parent_User In columnNameAsList
    '            Parent_Name.Add(dp.Parent_Name)
    '        Next
    '    End If
    '    'Using connection As New SqlConnection("Data Source=.;Initial Catalog=LifeIncentive;Integrated Security=True")
    '    '    Dim query As String = "SELECT COUNT(*) FROM TBL_Parent_User WHERE Email = @Email AND Password = @Password"
    '    '    Using command As New SqlCommand(query, connection)
    '    '        command.Parameters.AddWithValue("@Email", Email)
    '    '        command.Parameters.AddWithValue("@Password", password)
    '    '        connection.Open()
    '    '        Dim count As Integer = CInt(command.ExecuteScalar())
    '    '        If count > 0 Then
    '    '            isValid = True
    '    '        End If
    '    '    End Using
    '    'End Using
    '    Return isValid
    'End Function
End Class