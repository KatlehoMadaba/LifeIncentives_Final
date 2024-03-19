
Public Class signUp
    Inherits System.Web.UI.Page

    Dim pu As New TBL_Parent_User
    Dim cu As New TBL_Child_User
    Dim fi As New TBL_Financial_Information



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(HttpContext.Current.Session("conn")) Then
            HttpContext.Current.Session("conn") = DBInterface.connect(ConfigurationManager.ConnectionStrings("conn2").ConnectionString)
        End If
    End Sub

    Protected Sub Register(sender As Object, e As EventArgs)

        cu.Child_ID = ChildID.Text
        cu.Child_Name = ChildName.Text
        cu.Child_Surname = ChildSurname.Text
        cu.Child_Age = Integer.Parse(ChildAge.Text)
        cu.Child_Password = ChildPassword.Text
        Session("childID") = cu.Child_ID ' Session created 
        cu.update()

        Response.Redirect("signUpParent.aspx")

    End Sub

    Protected Sub Registerbtn_Click(sender As Object, e As EventArgs)
        cu.Child_ID = ChildID.Text
        cu.Child_Name = ChildName.Text
        cu.Child_Surname = ChildSurname.Text
        cu.Child_Age = Integer.Parse(ChildAge.Text)
        cu.Child_Password = ChildPassword.Text
        Session("childID") = cu.Child_ID ' Session created 
        cu.update()

        Response.Redirect("signUpParent.aspx")
    End Sub
End Class
