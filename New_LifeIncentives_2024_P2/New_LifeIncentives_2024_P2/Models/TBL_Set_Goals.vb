Imports System.Data.SqlClient

Public Class TBL_Set_Goals
    inherits Entity

    Public Shared Display_Set_Goals_ID as Boolean = true
    Public Shared Display_Child_ID as Boolean = true
    Public Shared Display_Parent_ID as Boolean = true
    Public Shared Display_Incentives_ID as Boolean = true
    Public Shared Display_StartDateTime as Boolean = true
    Public Shared Display_EndDateTime as Boolean = true
    Public Shared Display_Category as Boolean = true
    Public Shared Display_Description as Boolean = true
    Public Shared Display_TimePeriod as Boolean = true
    Public Shared Display_Amount as Boolean = true
    Public Shared Display_Status as Boolean = true

    Private I_Display_Set_Goals_ID as Boolean = true
    Private I_Display_Child_ID as Boolean = true
    Private I_Display_Parent_ID as Boolean = true
    Private I_Display_Incentives_ID as Boolean = true
    Private I_Display_StartDateTime as Boolean = true
    Private I_Display_EndDateTime as Boolean = true
    Private I_Display_Category as Boolean = true
    Private I_Display_Description as Boolean = true
    Private I_Display_TimePeriod as Boolean = true
    Private I_Display_Amount as Boolean = true
    Private I_Display_Status as Boolean = True

    Public previous_Set_Goals_ID As System.String

    Public Set_Goals_ID As System.String
    Public Child_ID As System.String
    Public Parent_ID As System.String
    Public Incentives_ID As System.String
    Public StartDateTime as nullable(of System.DateTime)
    Public EndDateTime as nullable(of System.DateTime)
    Public Category as System.String
    Public Description as System.String
    Public TimePeriod as nullable(of System.Int32)
    Public Amount as nullable(of System.Double)
    Public Status as System.String
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag as boolean)
        Display_Set_Goals_ID = display_flag
        Display_Child_ID = display_flag
        Display_Parent_ID = display_flag
        Display_Incentives_ID = display_flag
        Display_StartDateTime = display_flag
        Display_EndDateTime = display_flag
        Display_Category = display_flag
        Display_Description = display_flag
        Display_TimePeriod = display_flag
        Display_Amount = display_flag
        Display_Status = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Set_Goals (Set_Goals_ID,Child_ID,Parent_ID,Incentives_ID,StartDateTime,EndDateTime,Category,Description,TimePeriod,Amount,Status)"
        cmd.CommandText = cmd.CommandText & "values(@Set_Goals_ID,@Child_ID,@Parent_ID,@Incentives_ID,@StartDateTime,@EndDateTime,@Category,@Description,@TimePeriod,@Amount,@Status)"

        cmd.Parameters.Add("@Set_Goals_ID", 22, 255, "Set_Goals_ID")
        cmd.Parameters("@Set_Goals_ID").Value = SetNull(Set_Goals_ID)
        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = SetNull(Child_ID)
        cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        cmd.Parameters("@Parent_ID").Value = SetNull(Parent_ID)
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)
        cmd.Parameters.Add("@StartDateTime", 4, 0, "StartDateTime")
        cmd.Parameters("@StartDateTime").Value = SetNull(StartDateTime)
        cmd.Parameters.Add("@EndDateTime", 4, 0, "EndDateTime")
        cmd.Parameters("@EndDateTime").Value = SetNull(EndDateTime)
        cmd.Parameters.Add("@Category", 22, 50, "Category")
        cmd.Parameters("@Category").Value = SetNull(Category)
        cmd.Parameters.Add("@Description", 22, 255, "Description")
        cmd.Parameters("@Description").Value = SetNull(Description)
        cmd.Parameters.Add("@TimePeriod", 8, 0, "TimePeriod")
        cmd.Parameters("@TimePeriod").Value = SetNull(TimePeriod)
        cmd.Parameters.Add("@Amount", 6, 0, "Amount")
        cmd.Parameters("@Amount").Value = SetNull(Amount)
        cmd.Parameters.Add("@Status", 22, 20, "Status")
        cmd.Parameters("@Status").Value = SetNull(Status)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Set_Goals where Set_Goals_ID=@previous_Set_Goals_ID"
        cmd.Parameters.Add("@previous_Set_Goals_ID", 22, 255, "previous_Set_Goals_ID")
        cmd.Parameters("@previous_Set_Goals_ID").Value = Me.previous_Set_Goals_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Set_Goals_ID as System.Int32) As TBL_Set_Goals
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Set_Goals_ID,"
        if Display_Child_ID = true then cmd.CommandText = cmd.CommandText & "Child_ID,"
        if Display_Parent_ID = true then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        if Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        if Display_StartDateTime = true then cmd.CommandText = cmd.CommandText & "StartDateTime,"
        if Display_EndDateTime = true then cmd.CommandText = cmd.CommandText & "EndDateTime,"
        if Display_Category = true then cmd.CommandText = cmd.CommandText & "Category,"
        if Display_Description = true then cmd.CommandText = cmd.CommandText & "Description,"
        if Display_TimePeriod = true then cmd.CommandText = cmd.CommandText & "TimePeriod,"
        if Display_Amount = true then cmd.CommandText = cmd.CommandText & "Amount,"
        if Display_Status = true then cmd.CommandText = cmd.CommandText & "Status,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Set_Goals where Set_Goals_ID=@Set_Goals_ID"
        cmd.Parameters.Add("@Set_Goals_ID", 22, 255, "Set_Goals_ID")
        cmd.Parameters("@Set_Goals_ID").Value = Set_Goals_ID

        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Set_Goals
        For i = 0 To dt.Rows.Count - 1
            p.Set_Goals_ID = checknull(dt.Rows(i)("Set_Goals_ID"))
            p.I_Display_Set_Goals_ID = Display_Set_Goals_ID
            if Display_Child_ID = true then p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            if Display_Parent_ID = true then p.Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            if Display_Incentives_ID = true then p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_StartDateTime = true then p.StartDateTime = checknull(dt.Rows(i)("StartDateTime"))
            p.I_Display_StartDateTime = Display_StartDateTime
            if Display_EndDateTime = true then p.EndDateTime = checknull(dt.Rows(i)("EndDateTime"))
            p.I_Display_EndDateTime = Display_EndDateTime
            if Display_Category = true then p.Category = checknull(dt.Rows(i)("Category"))
            p.I_Display_Category = Display_Category
            if Display_Description = true then p.Description = checknull(dt.Rows(i)("Description"))
            p.I_Display_Description = Display_Description
            if Display_TimePeriod = true then p.TimePeriod = checknull(dt.Rows(i)("TimePeriod"))
            p.I_Display_TimePeriod = Display_TimePeriod
            if Display_Amount = true then p.Amount = checknull(dt.Rows(i)("Amount"))
            p.I_Display_Amount = Display_Amount
            if Display_Status = true then p.Status = checknull(dt.Rows(i)("Status"))
            p.I_Display_Status = Display_Status
            p.previous_Set_Goals_ID = checknull(dt.Rows(i)("Set_Goals_ID"))
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
        cmd.CommandText = "update TBL_Set_Goals set "
        cmd.CommandText = cmd.CommandText & " Set_Goals_ID=@Set_Goals_ID,"
        if I_Display_Child_ID = true then cmd.CommandText = cmd.CommandText & " Child_ID=@Child_ID,"
        if I_Display_Parent_ID = true then cmd.CommandText = cmd.CommandText & " Parent_ID=@Parent_ID,"
        if I_Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & " Incentives_ID=@Incentives_ID,"
        if I_Display_StartDateTime = true then cmd.CommandText = cmd.CommandText & " StartDateTime=@StartDateTime,"
        if I_Display_EndDateTime = true then cmd.CommandText = cmd.CommandText & " EndDateTime=@EndDateTime,"
        if I_Display_Category = true then cmd.CommandText = cmd.CommandText & " Category=@Category,"
        if I_Display_Description = true then cmd.CommandText = cmd.CommandText & " Description=@Description,"
        if I_Display_TimePeriod = true then cmd.CommandText = cmd.CommandText & " TimePeriod=@TimePeriod,"
        if I_Display_Amount = true then cmd.CommandText = cmd.CommandText & " Amount=@Amount,"
        if I_Display_Status = true then cmd.CommandText = cmd.CommandText & " Status=@Status,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Set_Goals_ID=@previous_Set_Goals_ID"


        cmd.Parameters.Add("@Set_Goals_ID", 22, 255, "Set_Goals_ID")
        cmd.Parameters("@Set_Goals_ID").Value = SetNull(Set_Goals_ID)

        If I_Display_Child_ID = True Then cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        If I_Display_Child_ID = true then cmd.Parameters("@Child_ID").Value = SetNull(Child_ID)

        If I_Display_Parent_ID = True Then cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        If I_Display_Parent_ID = true then cmd.Parameters("@Parent_ID").Value = SetNull(Parent_ID)

        If I_Display_Incentives_ID = True Then cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        If I_Display_Incentives_ID = true then cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)

        if I_Display_StartDateTime = true then cmd.Parameters.Add("@StartDateTime", 4, 0, "StartDateTime")
        if I_Display_StartDateTime = true then cmd.Parameters("@StartDateTime").Value = SetNull(StartDateTime)

        if I_Display_EndDateTime = true then cmd.Parameters.Add("@EndDateTime", 4, 0, "EndDateTime")
        if I_Display_EndDateTime = true then cmd.Parameters("@EndDateTime").Value = SetNull(EndDateTime)

        if I_Display_Category = true then cmd.Parameters.Add("@Category", 22, 50, "Category")
        if I_Display_Category = true then cmd.Parameters("@Category").Value = SetNull(Category)

        if I_Display_Description = true then cmd.Parameters.Add("@Description", 22, 255, "Description")
        if I_Display_Description = true then cmd.Parameters("@Description").Value = SetNull(Description)

        if I_Display_TimePeriod = true then cmd.Parameters.Add("@TimePeriod", 8, 0, "TimePeriod")
        if I_Display_TimePeriod = true then cmd.Parameters("@TimePeriod").Value = SetNull(TimePeriod)

        if I_Display_Amount = true then cmd.Parameters.Add("@Amount", 6, 0, "Amount")
        if I_Display_Amount = true then cmd.Parameters("@Amount").Value = SetNull(Amount)

        if I_Display_Status = true then cmd.Parameters.Add("@Status", 22, 20, "Status")
        if I_Display_Status = true then cmd.Parameters("@Status").Value = SetNull(Status)


        cmd.Parameters.Add("@previous_Set_Goals_ID", 22, 255, "previous_Set_Goals_ID")
        cmd.Parameters("@previous_Set_Goals_ID").Value = Me.previous_Set_Goals_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Set_Goals)
        Dim ps As New Generic.List(Of TBL_Set_Goals)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Set_Goals_ID,"
        if Display_Child_ID = true then cmd.CommandText = cmd.CommandText & "Child_ID,"
        if Display_Parent_ID = true then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        if Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        if Display_StartDateTime = true then cmd.CommandText = cmd.CommandText & "StartDateTime,"
        if Display_EndDateTime = true then cmd.CommandText = cmd.CommandText & "EndDateTime,"
        if Display_Category = true then cmd.CommandText = cmd.CommandText & "Category,"
        if Display_Description = true then cmd.CommandText = cmd.CommandText & "Description,"
        if Display_TimePeriod = true then cmd.CommandText = cmd.CommandText & "TimePeriod,"
        if Display_Amount = true then cmd.CommandText = cmd.CommandText & "Amount,"
        if Display_Status = true then cmd.CommandText = cmd.CommandText & "Status,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Set_Goals " & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Set_Goals
            p.Set_Goals_ID = checknull(dt.Rows(i)("Set_Goals_ID"))
            p.I_Display_Set_Goals_ID = Display_Set_Goals_ID
            if Display_Child_ID = true then p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            if Display_Parent_ID = true then p.Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            if Display_Incentives_ID = true then p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_StartDateTime = true then p.StartDateTime = checknull(dt.Rows(i)("StartDateTime"))
            p.I_Display_StartDateTime = Display_StartDateTime
            if Display_EndDateTime = true then p.EndDateTime = checknull(dt.Rows(i)("EndDateTime"))
            p.I_Display_EndDateTime = Display_EndDateTime
            if Display_Category = true then p.Category = checknull(dt.Rows(i)("Category"))
            p.I_Display_Category = Display_Category
            if Display_Description = true then p.Description = checknull(dt.Rows(i)("Description"))
            p.I_Display_Description = Display_Description
            if Display_TimePeriod = true then p.TimePeriod = checknull(dt.Rows(i)("TimePeriod"))
            p.I_Display_TimePeriod = Display_TimePeriod
            if Display_Amount = true then p.Amount = checknull(dt.Rows(i)("Amount"))
            p.I_Display_Amount = Display_Amount
            if Display_Status = true then p.Status = checknull(dt.Rows(i)("Status"))
            p.I_Display_Status = Display_Status
            p.previous_Set_Goals_ID = checknull(dt.Rows(i)("Set_Goals_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Set_Goals)
        Dim ps As New Generic.List(Of TBL_Set_Goals)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Set_Goals_ID from TBL_Set_Goals" & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Set_Goals
            p.Set_Goals_ID = checknull(dt.Rows(i)("Set_Goals_ID"))
            p.previous_Set_Goals_ID = checknull(dt.Rows(i)("Set_Goals_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class