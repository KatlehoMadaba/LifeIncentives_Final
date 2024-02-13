Imports System.Data.SqlClient

Public Class TBL_Parent_User
    inherits Entity

    Public Shared Display_Parent_ID as Boolean = true
    Public Shared Display_Parent_Name as Boolean = true
    Public Shared Display_Parent_Surname as Boolean = true
    Public Shared Display_Email as Boolean = true
    Public Shared Display_Password as Boolean = true
    Public Shared Display_Employment as Boolean = true
    Public Shared Display_Child_ID as Boolean = true

    Private I_Display_Parent_ID as Boolean = true
    Private I_Display_Parent_Name as Boolean = true
    Private I_Display_Parent_Surname as Boolean = true
    Private I_Display_Email as Boolean = true
    Private I_Display_Password as Boolean = true
    Private I_Display_Employment as Boolean = true
    Private I_Display_Child_ID as Boolean = True

    Public previous_Parent_ID As System.String

    Public Parent_ID As System.String
    Public Parent_Name as System.String
    Public Parent_Surname as System.String
    Public Email as System.String
    Public Password as System.String
    Public Employment as System.String
    Public Child_ID As System.String
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag as boolean)
        Display_Parent_ID = display_flag
        Display_Parent_Name = display_flag
        Display_Parent_Surname = display_flag
        Display_Email = display_flag
        Display_Password = display_flag
        Display_Employment = display_flag
        Display_Child_ID = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Parent_User (Parent_ID,Parent_Name,Parent_Surname,Email,Password,Employment,Child_ID)"
        cmd.CommandText = cmd.CommandText & "values(@Parent_ID,@Parent_Name,@Parent_Surname,@Email,@Password,@Employment,@Child_ID)"

        cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        cmd.Parameters("@Parent_ID").Value = SetNull(Parent_ID)
        cmd.Parameters.Add("@Parent_Name", 22, 50, "Parent_Name")
        cmd.Parameters("@Parent_Name").Value = SetNull(Parent_Name)
        cmd.Parameters.Add("@Parent_Surname", 22, 50, "Parent_Surname")
        cmd.Parameters("@Parent_Surname").Value = SetNull(Parent_Surname)
        cmd.Parameters.Add("@Email", 22, 100, "Email")
        cmd.Parameters("@Email").Value = SetNull(Email)
        cmd.Parameters.Add("@Password", 22, 50, "Password")
        cmd.Parameters("@Password").Value = SetNull(Password)
        cmd.Parameters.Add("@Employment", 22, 50, "Employment")
        cmd.Parameters("@Employment").Value = SetNull(Employment)
        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = SetNull(Child_ID)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Parent_User where Parent_ID=@previous_Parent_ID"
        cmd.Parameters.Add("@previous_Parent_ID", 22, 255, "previous_Parent_ID")
        cmd.Parameters("@previous_Parent_ID").Value = Me.previous_Parent_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Parent_ID as System.Int32) As TBL_Parent_User
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Parent_ID,"
        if Display_Parent_Name = true then cmd.CommandText = cmd.CommandText & "Parent_Name,"
        if Display_Parent_Surname = true then cmd.CommandText = cmd.CommandText & "Parent_Surname,"
        if Display_Email = true then cmd.CommandText = cmd.CommandText & "Email,"
        if Display_Password = true then cmd.CommandText = cmd.CommandText & "Password,"
        if Display_Employment = true then cmd.CommandText = cmd.CommandText & "Employment,"
        if Display_Child_ID = true then cmd.CommandText = cmd.CommandText & "Child_ID,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Parent_User where Parent_ID=@Parent_ID"
        cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        cmd.Parameters("@Parent_ID").Value = Parent_ID

        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Parent_User
        For i = 0 To dt.Rows.Count - 1
            p.Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            if Display_Parent_Name = true then p.Parent_Name = checknull(dt.Rows(i)("Parent_Name"))
            p.I_Display_Parent_Name = Display_Parent_Name
            if Display_Parent_Surname = true then p.Parent_Surname = checknull(dt.Rows(i)("Parent_Surname"))
            p.I_Display_Parent_Surname = Display_Parent_Surname
            if Display_Email = true then p.Email = checknull(dt.Rows(i)("Email"))
            p.I_Display_Email = Display_Email
            if Display_Password = true then p.Password = checknull(dt.Rows(i)("Password"))
            p.I_Display_Password = Display_Password
            if Display_Employment = true then p.Employment = checknull(dt.Rows(i)("Employment"))
            p.I_Display_Employment = Display_Employment
            if Display_Child_ID = true then p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            p.previous_Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.newinstance = False
            Return p
        Next
        Return Nothing
    End Function


    Sub update()
        If newinstance = True Then
            insert()
            Return
        End If

        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update TBL_Parent_User set "
        cmd.CommandText = cmd.CommandText & " Parent_ID=@Parent_ID,"
        if I_Display_Parent_Name = true then cmd.CommandText = cmd.CommandText & " Parent_Name=@Parent_Name,"
        if I_Display_Parent_Surname = true then cmd.CommandText = cmd.CommandText & " Parent_Surname=@Parent_Surname,"
        if I_Display_Email = true then cmd.CommandText = cmd.CommandText & " Email=@Email,"
        if I_Display_Password = true then cmd.CommandText = cmd.CommandText & " Password=@Password,"
        if I_Display_Employment = true then cmd.CommandText = cmd.CommandText & " Employment=@Employment,"
        if I_Display_Child_ID = true then cmd.CommandText = cmd.CommandText & " Child_ID=@Child_ID,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Parent_ID=@previous_Parent_ID"


        cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        cmd.Parameters("@Parent_ID").Value = SetNull(Parent_ID)

        if I_Display_Parent_Name = true then cmd.Parameters.Add("@Parent_Name", 22, 50, "Parent_Name")
        if I_Display_Parent_Name = true then cmd.Parameters("@Parent_Name").Value = SetNull(Parent_Name)

        if I_Display_Parent_Surname = true then cmd.Parameters.Add("@Parent_Surname", 22, 50, "Parent_Surname")
        if I_Display_Parent_Surname = true then cmd.Parameters("@Parent_Surname").Value = SetNull(Parent_Surname)

        if I_Display_Email = true then cmd.Parameters.Add("@Email", 22, 100, "Email")
        if I_Display_Email = true then cmd.Parameters("@Email").Value = SetNull(Email)

        if I_Display_Password = true then cmd.Parameters.Add("@Password", 22, 50, "Password")
        if I_Display_Password = true then cmd.Parameters("@Password").Value = SetNull(Password)

        if I_Display_Employment = true then cmd.Parameters.Add("@Employment", 22, 50, "Employment")
        if I_Display_Employment = true then cmd.Parameters("@Employment").Value = SetNull(Employment)

        if I_Display_Child_ID = true then cmd.Parameters.Add("@Child_ID", 8, 0, "Child_ID")
        if I_Display_Child_ID = true then cmd.Parameters("@Child_ID").Value = SetNull(Child_ID)



        cmd.Parameters.Add("@previous_Parent_ID", 22, 255, "previous_Parent_ID")
        cmd.Parameters("@previous_Parent_ID").Value = Me.previous_Parent_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Parent_User)
        Dim ps As New Generic.List(Of TBL_Parent_User)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Parent_ID,"
        if Display_Parent_Name = true then cmd.CommandText = cmd.CommandText & "Parent_Name,"
        if Display_Parent_Surname = true then cmd.CommandText = cmd.CommandText & "Parent_Surname,"
        if Display_Email = true then cmd.CommandText = cmd.CommandText & "Email,"
        if Display_Password = true then cmd.CommandText = cmd.CommandText & "Password,"
        if Display_Employment = true then cmd.CommandText = cmd.CommandText & "Employment,"
        if Display_Child_ID = true then cmd.CommandText = cmd.CommandText & "Child_ID,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Parent_User " & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Parent_User
            p.Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            if Display_Parent_Name = true then p.Parent_Name = checknull(dt.Rows(i)("Parent_Name"))
            p.I_Display_Parent_Name = Display_Parent_Name
            if Display_Parent_Surname = true then p.Parent_Surname = checknull(dt.Rows(i)("Parent_Surname"))
            p.I_Display_Parent_Surname = Display_Parent_Surname
            if Display_Email = true then p.Email = checknull(dt.Rows(i)("Email"))
            p.I_Display_Email = Display_Email
            if Display_Password = true then p.Password = checknull(dt.Rows(i)("Password"))
            p.I_Display_Password = Display_Password
            if Display_Employment = true then p.Employment = checknull(dt.Rows(i)("Employment"))
            p.I_Display_Employment = Display_Employment
            if Display_Child_ID = true then p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            p.previous_Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Parent_User)
        Dim ps As New Generic.List(Of TBL_Parent_User)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Parent_ID from TBL_Parent_User" & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Parent_User
            p.Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.previous_Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class