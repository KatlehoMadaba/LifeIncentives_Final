Public Class signUpParent
    Inherits System.Web.UI.Page

    Dim pu As New TBL_Parent_User
    Dim cu As New TBL_Child_User


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(HttpContext.Current.Session("conn")) Then
            HttpContext.Current.Session("conn") = DBInterface.connect(ConfigurationManager.ConnectionStrings("conn2").ConnectionString)
        End If
    End Sub

    Protected Sub ParentRegister(sender As Object, e As EventArgs)

        pu.Parent_ID = Guid.NewGuid.ToString
        pu.Parent_Name = FirstName.Text
        pu.Parent_Surname = LastName.Text
        pu.Email = Email.Text
        pu.Password = Password.Text
        pu.Employment = "Yes"

        pu.Child_ID = Session("childID").ToString()


        pu.update()

        Response.Redirect("Questions.aspx")

    End Sub



End Class