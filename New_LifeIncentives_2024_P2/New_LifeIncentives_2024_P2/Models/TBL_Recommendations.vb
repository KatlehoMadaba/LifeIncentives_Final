Imports System.Data.SqlClient

Public Class TBL_Recommendations
    inherits Entity

    Public Shared Display_Recommendation_ID as Boolean = true
    Public Shared Display_Incentives_ID as Boolean = true
    Public Shared Display_Category as Boolean = true
    Public Shared Display_Task as Boolean = true
    Public Shared Display_Default_Price as Boolean = true
    Public Shared Display_Default_Time as Boolean = true

    Private I_Display_Recommendation_ID as Boolean = true
    Private I_Display_Incentives_ID as Boolean = true
    Private I_Display_Category as Boolean = true
    Private I_Display_Task as Boolean = true
    Private I_Display_Default_Price as Boolean = true
    Private I_Display_Default_Time as Boolean = True

    Public previous_Recommendation_ID As System.String

    Public Recommendation_ID As System.String
    Public Incentives_ID As System.String
    Public Category as System.String
    Public Task as System.String
    Public Default_Price as nullable(of System.Double)
    Public Default_Time as nullable(of System.Int32)
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag as boolean)
        Display_Recommendation_ID = display_flag
        Display_Incentives_ID = display_flag
        Display_Category = display_flag
        Display_Task = display_flag
        Display_Default_Price = display_flag
        Display_Default_Time = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Recommendations (Recommendation_ID,Incentives_ID,Category,Task,Default_Price,Default_Time)"
        cmd.CommandText = cmd.CommandText & "values(@Recommendation_ID,@Incentives_ID,@Category,@Task,@Default_Price,@Default_Time)"

        cmd.Parameters.Add("@Recommendation_ID", 22, 255, "Recommendation_ID")
        cmd.Parameters("@Recommendation_ID").Value = SetNull(Recommendation_ID)
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)
        cmd.Parameters.Add("@Category", 22, 50, "Category")
        cmd.Parameters("@Category").Value = SetNull(Category)
        cmd.Parameters.Add("@Task", 22, 100, "Task")
        cmd.Parameters("@Task").Value = SetNull(Task)
        cmd.Parameters.Add("@Default_Price", 6, 0, "Default_Price")
        cmd.Parameters("@Default_Price").Value = SetNull(Default_Price)
        cmd.Parameters.Add("@Default_Time", 8, 0, "Default_Time")
        cmd.Parameters("@Default_Time").Value = SetNull(Default_Time)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Recommendations where Recommendation_ID=@previous_Recommendation_ID"
        cmd.Parameters.Add("@previous_Recommendation_ID", 22, 255, "previous_Recommendation_ID")
        cmd.Parameters("@previous_Recommendation_ID").Value = Me.previous_Recommendation_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Recommendation_ID As System.String) As TBL_Recommendations
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Recommendation_ID,"
        If Display_Incentives_ID = True Then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        If Display_Category = True Then cmd.CommandText = cmd.CommandText & "Category,"
        If Display_Task = True Then cmd.CommandText = cmd.CommandText & "Task,"
        If Display_Default_Price = True Then cmd.CommandText = cmd.CommandText & "Default_Price,"
        If Display_Default_Time = True Then cmd.CommandText = cmd.CommandText & "Default_Time,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Recommendations where Recommendation_ID=@Recommendation_ID"
        cmd.Parameters.Add("@Recommendation_ID", 22, 255, "Recommendation_ID")
        cmd.Parameters("@Recommendation_ID").Value = Recommendation_ID

        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Recommendations
        For i = 0 To dt.Rows.Count - 1
            p.Recommendation_ID = checkNull(dt.Rows(i)("Recommendation_ID"))
            p.I_Display_Recommendation_ID = Display_Recommendation_ID
            If Display_Incentives_ID = True Then p.Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            If Display_Category = True Then p.Category = checkNull(dt.Rows(i)("Category"))
            p.I_Display_Category = Display_Category
            If Display_Task = True Then p.Task = checkNull(dt.Rows(i)("Task"))
            p.I_Display_Task = Display_Task
            If Display_Default_Price = True Then p.Default_Price = checkNull(dt.Rows(i)("Default_Price"))
            p.I_Display_Default_Price = Display_Default_Price
            If Display_Default_Time = True Then p.Default_Time = checkNull(dt.Rows(i)("Default_Time"))
            p.I_Display_Default_Time = Display_Default_Time
            p.previous_Recommendation_ID = checkNull(dt.Rows(i)("Recommendation_ID"))
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
        cmd.CommandText = "update TBL_Recommendations set "
        cmd.CommandText = cmd.CommandText & " Recommendation_ID=@Recommendation_ID,"
        if I_Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & " Incentives_ID=@Incentives_ID,"
        if I_Display_Category = true then cmd.CommandText = cmd.CommandText & " Category=@Category,"
        if I_Display_Task = true then cmd.CommandText = cmd.CommandText & " Task=@Task,"
        if I_Display_Default_Price = true then cmd.CommandText = cmd.CommandText & " Default_Price=@Default_Price,"
        if I_Display_Default_Time = true then cmd.CommandText = cmd.CommandText & " Default_Time=@Default_Time,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Recommendation_ID=@previous_Recommendation_ID"


        cmd.Parameters.Add("@Recommendation_ID", 22, 255, "Recommendation_ID")
        cmd.Parameters("@Recommendation_ID").Value = SetNull(Recommendation_ID)

        If I_Display_Incentives_ID = True Then cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        If I_Display_Incentives_ID = true then cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)

        if I_Display_Category = true then cmd.Parameters.Add("@Category", 22, 50, "Category")
        if I_Display_Category = true then cmd.Parameters("@Category").Value = SetNull(Category)

        if I_Display_Task = true then cmd.Parameters.Add("@Task", 22, 100, "Task")
        if I_Display_Task = true then cmd.Parameters("@Task").Value = SetNull(Task)

        if I_Display_Default_Price = true then cmd.Parameters.Add("@Default_Price", 6, 0, "Default_Price")
        if I_Display_Default_Price = true then cmd.Parameters("@Default_Price").Value = SetNull(Default_Price)

        if I_Display_Default_Time = true then cmd.Parameters.Add("@Default_Time", 8, 0, "Default_Time")
        if I_Display_Default_Time = true then cmd.Parameters("@Default_Time").Value = SetNull(Default_Time)



        cmd.Parameters.Add("@previous_Recommendation_ID", 22, 255, "previous_Recommendation_ID")
        cmd.Parameters("@previous_Recommendation_ID").Value = Me.previous_Recommendation_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Recommendations)
        Dim ps As New Generic.List(Of TBL_Recommendations)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Recommendation_ID,"
        if Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        if Display_Category = true then cmd.CommandText = cmd.CommandText & "Category,"
        if Display_Task = true then cmd.CommandText = cmd.CommandText & "Task,"
        if Display_Default_Price = true then cmd.CommandText = cmd.CommandText & "Default_Price,"
        if Display_Default_Time = true then cmd.CommandText = cmd.CommandText & "Default_Time,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Recommendations " & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Recommendations
            p.Recommendation_ID = checknull(dt.Rows(i)("Recommendation_ID"))
            p.I_Display_Recommendation_ID = Display_Recommendation_ID
            if Display_Incentives_ID = true then p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_Category = true then p.Category = checknull(dt.Rows(i)("Category"))
            p.I_Display_Category = Display_Category
            if Display_Task = true then p.Task = checknull(dt.Rows(i)("Task"))
            p.I_Display_Task = Display_Task
            if Display_Default_Price = true then p.Default_Price = checknull(dt.Rows(i)("Default_Price"))
            p.I_Display_Default_Price = Display_Default_Price
            if Display_Default_Time = true then p.Default_Time = checknull(dt.Rows(i)("Default_Time"))
            p.I_Display_Default_Time = Display_Default_Time
            p.previous_Recommendation_ID = checknull(dt.Rows(i)("Recommendation_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Recommendations)
        Dim ps As New Generic.List(Of TBL_Recommendations)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Recommendation_ID from TBL_Recommendations" & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Recommendations
            p.Recommendation_ID = checknull(dt.Rows(i)("Recommendation_ID"))
            p.previous_Recommendation_ID = checknull(dt.Rows(i)("Recommendation_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class