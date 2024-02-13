Imports System.Data.SqlClient

Public Class TBL_Child_User
    inherits Entity

    Public Shared Display_Child_ID as Boolean = true
    Public Shared Display_Child_Name as Boolean = true
    Public Shared Display_Child_Surname as Boolean = true
    Public Shared Display_Child_Age as Boolean = true
    Public Shared Display_Child_Password as Boolean = true

    Private I_Display_Child_ID as Boolean = true
    Private I_Display_Child_Name as Boolean = true
    Private I_Display_Child_Surname as Boolean = true
    Private I_Display_Child_Age as Boolean = true
    Private I_Display_Child_Password as Boolean = True

    Public previous_Child_ID As System.String

    Public Child_ID As System.String
    Public Child_Name as System.String
    Public Child_Surname as System.String
    Public Child_Age as nullable(of System.Int32)
    Public Child_Password as System.String
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag as boolean)
        Display_Child_ID = display_flag
        Display_Child_Name = display_flag
        Display_Child_Surname = display_flag
        Display_Child_Age = display_flag
        Display_Child_Password = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Child_User (Child_ID,Child_Name,Child_Surname,Child_Age,Child_Password)"
        cmd.CommandText = cmd.CommandText & "values(@Child_ID,@Child_Name,@Child_Surname,@Child_Age,@Child_Password)"

        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = SetNull(Child_ID)
        cmd.Parameters.Add("@Child_Name", 22, 50, "Child_Name")
        cmd.Parameters("@Child_Name").Value = SetNull(Child_Name)
        cmd.Parameters.Add("@Child_Surname", 22, 50, "Child_Surname")
        cmd.Parameters("@Child_Surname").Value = SetNull(Child_Surname)
        cmd.Parameters.Add("@Child_Age", 8, 0, "Child_Age")
        cmd.Parameters("@Child_Age").Value = SetNull(Child_Age)
        cmd.Parameters.Add("@Child_Password", 22, 50, "Child_Password")
        cmd.Parameters("@Child_Password").Value = SetNull(Child_Password)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Child_User where Child_ID=@previous_Child_ID"
        cmd.Parameters.Add("@previous_Child_ID", 22, 255, "previous_Child_ID")
        cmd.Parameters("@previous_Child_ID").Value = Me.previous_Child_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Child_ID as System.Int32) As TBL_Child_User
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Child_ID,"
        if Display_Child_Name = true then cmd.CommandText = cmd.CommandText & "Child_Name,"
        if Display_Child_Surname = true then cmd.CommandText = cmd.CommandText & "Child_Surname,"
        if Display_Child_Age = true then cmd.CommandText = cmd.CommandText & "Child_Age,"
        if Display_Child_Password = true then cmd.CommandText = cmd.CommandText & "Child_Password,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Child_User where Child_ID=@Child_ID"
        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = Child_ID

        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Child_User
        For i = 0 To dt.Rows.Count - 1
            p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            if Display_Child_Name = true then p.Child_Name = checknull(dt.Rows(i)("Child_Name"))
            p.I_Display_Child_Name = Display_Child_Name
            if Display_Child_Surname = true then p.Child_Surname = checknull(dt.Rows(i)("Child_Surname"))
            p.I_Display_Child_Surname = Display_Child_Surname
            if Display_Child_Age = true then p.Child_Age = checknull(dt.Rows(i)("Child_Age"))
            p.I_Display_Child_Age = Display_Child_Age
            if Display_Child_Password = true then p.Child_Password = checknull(dt.Rows(i)("Child_Password"))
            p.I_Display_Child_Password = Display_Child_Password
            p.previous_Child_ID = checknull(dt.Rows(i)("Child_ID"))
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
        cmd.CommandText = "update TBL_Child_User set "
        cmd.CommandText = cmd.CommandText & " Child_ID=@Child_ID,"
        if I_Display_Child_Name = true then cmd.CommandText = cmd.CommandText & " Child_Name=@Child_Name,"
        if I_Display_Child_Surname = true then cmd.CommandText = cmd.CommandText & " Child_Surname=@Child_Surname,"
        if I_Display_Child_Age = true then cmd.CommandText = cmd.CommandText & " Child_Age=@Child_Age,"
        if I_Display_Child_Password = true then cmd.CommandText = cmd.CommandText & " Child_Password=@Child_Password,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Child_ID=@previous_Child_ID"


        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = SetNull(Child_ID)

        if I_Display_Child_Name = true then cmd.Parameters.Add("@Child_Name", 22, 50, "Child_Name")
        if I_Display_Child_Name = true then cmd.Parameters("@Child_Name").Value = SetNull(Child_Name)

        if I_Display_Child_Surname = true then cmd.Parameters.Add("@Child_Surname", 22, 50, "Child_Surname")
        if I_Display_Child_Surname = true then cmd.Parameters("@Child_Surname").Value = SetNull(Child_Surname)

        if I_Display_Child_Age = true then cmd.Parameters.Add("@Child_Age", 8, 0, "Child_Age")
        if I_Display_Child_Age = true then cmd.Parameters("@Child_Age").Value = SetNull(Child_Age)

        if I_Display_Child_Password = true then cmd.Parameters.Add("@Child_Password", 22, 50, "Child_Password")
        if I_Display_Child_Password = true then cmd.Parameters("@Child_Password").Value = SetNull(Child_Password)



        cmd.Parameters.Add("@previous_Child_ID", 22, 255, "previous_Child_ID")
        cmd.Parameters("@previous_Child_ID").Value = Me.previous_Child_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Child_User)
        Dim ps As New Generic.List(Of TBL_Child_User)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Child_ID,"
        if Display_Child_Name = true then cmd.CommandText = cmd.CommandText & "Child_Name,"
        if Display_Child_Surname = true then cmd.CommandText = cmd.CommandText & "Child_Surname,"
        if Display_Child_Age = true then cmd.CommandText = cmd.CommandText & "Child_Age,"
        if Display_Child_Password = true then cmd.CommandText = cmd.CommandText & "Child_Password,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Child_User " & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Child_User
            p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            if Display_Child_Name = true then p.Child_Name = checknull(dt.Rows(i)("Child_Name"))
            p.I_Display_Child_Name = Display_Child_Name
            if Display_Child_Surname = true then p.Child_Surname = checknull(dt.Rows(i)("Child_Surname"))
            p.I_Display_Child_Surname = Display_Child_Surname
            if Display_Child_Age = true then p.Child_Age = checknull(dt.Rows(i)("Child_Age"))
            p.I_Display_Child_Age = Display_Child_Age
            if Display_Child_Password = true then p.Child_Password = checknull(dt.Rows(i)("Child_Password"))
            p.I_Display_Child_Password = Display_Child_Password
            p.previous_Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Child_User)
        Dim ps As New Generic.List(Of TBL_Child_User)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Child_ID from TBL_Child_User" & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Child_User
            p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.previous_Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class