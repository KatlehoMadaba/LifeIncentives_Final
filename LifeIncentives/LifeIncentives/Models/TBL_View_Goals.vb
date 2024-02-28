Imports System.Data.SqlClient

Public Class TBL_View_Goals
    inherits ENTITY

    Public Shared Display_View_Goals_ID As Boolean = True
    Public Shared Display_Child_ID As Boolean = True
    Public Shared Display_Parent_ID As Boolean = True
    Public Shared Display_Incentives_ID As Boolean = True
    Public Shared Display_StartDateTime As Boolean = True
    Public Shared Display_EndDateTime As Boolean = True
    Public Shared Display_Category As Boolean = True
    Public Shared Display_Description As Boolean = True
    Public Shared Display_TimePeriod As Boolean = True
    Public Shared Display_Amount As Boolean = True
    Public Shared Display_Status As Boolean = True

    Private I_Display_View_Goals_ID As Boolean = True
    Private I_Display_Child_ID As Boolean = True
    Private I_Display_Parent_ID As Boolean = True
    Private I_Display_Incentives_ID As Boolean = True
    Private I_Display_StartDateTime As Boolean = True
    Private I_Display_EndDateTime As Boolean = True
    Private I_Display_Category As Boolean = True
    Private I_Display_Description As Boolean = True
    Private I_Display_TimePeriod As Boolean = True
    Private I_Display_Amount As Boolean = True
    Private I_Display_Status As Boolean = True

    Public previous_View_Goals_ID As Nullable(Of System.Int32)

    Public View_Goals_ID As System.String
    Public Child_ID As System.String
    Public Parent_ID As System.String
    Public Incentives_ID As System.String
    Public StartDateTime As Nullable(Of System.DateTime)
    Public EndDateTime As Nullable(Of System.DateTime)
    Public Category As System.String
    Public Description As System.String
    Public TimePeriod As Nullable(Of System.Int32)
    Public Amount As Nullable(Of System.Double)
    Public Status As System.String
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag As Boolean)
        Display_View_Goals_ID = display_flag
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
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_View_Goals (View_Goals_ID,Child_ID,Parent_ID,Incentives_ID,StartDateTime,EndDateTime,Category,Description,TimePeriod,Amount,Status)"
        cmd.CommandText = cmd.CommandText & "values(@View_Goals_ID,@Child_ID,@Parent_ID,@Incentives_ID,@StartDateTime,@EndDateTime,@Category,@Description,@TimePeriod,@Amount,@Status)"

        cmd.Parameters.Add("@View_Goals_ID", 22, 255, "View_Goals_ID")
        cmd.Parameters("@View_Goals_ID").Value = setNull(View_Goals_ID)
        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = setNull(Child_ID)
        cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        cmd.Parameters("@Parent_ID").Value = setNull(Parent_ID)
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = setNull(Incentives_ID)
        cmd.Parameters.Add("@StartDateTime", 4, 0, "StartDateTime")
        cmd.Parameters("@StartDateTime").Value = setNull(StartDateTime)
        cmd.Parameters.Add("@EndDateTime", 4, 0, "EndDateTime")
        cmd.Parameters("@EndDateTime").Value = setNull(EndDateTime)
        cmd.Parameters.Add("@Category", 22, 50, "Category")
        cmd.Parameters("@Category").Value = setNull(Category)
        cmd.Parameters.Add("@Description", 22, 255, "Description")
        cmd.Parameters("@Description").Value = setNull(Description)
        cmd.Parameters.Add("@TimePeriod", 8, 0, "TimePeriod")
        cmd.Parameters("@TimePeriod").Value = setNull(TimePeriod)
        cmd.Parameters.Add("@Amount", 6, 0, "Amount")
        cmd.Parameters("@Amount").Value = setNull(Amount)
        cmd.Parameters.Add("@Status", 22, 20, "Status")
        cmd.Parameters("@Status").Value = setNull(Status)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_View_Goals where View_Goals_ID=@previous_View_Goals_ID"
        cmd.Parameters.Add("@previous_View_Goals_ID", 22, 255, "previous_View_Goals_ID")
        cmd.Parameters("@previous_View_Goals_ID").Value = Me.previous_View_Goals_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(View_Goals_ID As System.Int32) As TBL_View_Goals
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "View_Goals_ID,"
        If Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_Parent_ID = True Then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        If Display_Incentives_ID = True Then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        If Display_StartDateTime = True Then cmd.CommandText = cmd.CommandText & "StartDateTime,"
        If Display_EndDateTime = True Then cmd.CommandText = cmd.CommandText & "EndDateTime,"
        If Display_Category = True Then cmd.CommandText = cmd.CommandText & "Category,"
        If Display_Description = True Then cmd.CommandText = cmd.CommandText & "Description,"
        If Display_TimePeriod = True Then cmd.CommandText = cmd.CommandText & "TimePeriod,"
        If Display_Amount = True Then cmd.CommandText = cmd.CommandText & "Amount,"
        If Display_Status = True Then cmd.CommandText = cmd.CommandText & "Status,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_View_Goals where View_Goals_ID=@View_Goals_ID"
        cmd.Parameters.Add("@View_Goals_ID", 8, 0, "View_Goals_ID")
        cmd.Parameters("@View_Goals_ID").Value = View_Goals_ID

        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_View_Goals
        For i = 0 To dt.Rows.Count - 1
            p.View_Goals_ID = checkNull(dt.Rows(i)("View_Goals_ID"))
            p.I_Display_View_Goals_ID = Display_View_Goals_ID
            If Display_Child_ID = True Then p.Child_ID = checkNull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_Parent_ID = True Then p.Parent_ID = checkNull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            If Display_Incentives_ID = True Then p.Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            If Display_StartDateTime = True Then p.StartDateTime = checkNull(dt.Rows(i)("StartDateTime"))
            p.I_Display_StartDateTime = Display_StartDateTime
            If Display_EndDateTime = True Then p.EndDateTime = checkNull(dt.Rows(i)("EndDateTime"))
            p.I_Display_EndDateTime = Display_EndDateTime
            If Display_Category = True Then p.Category = checkNull(dt.Rows(i)("Category"))
            p.I_Display_Category = Display_Category
            If Display_Description = True Then p.Description = checkNull(dt.Rows(i)("Description"))
            p.I_Display_Description = Display_Description
            If Display_TimePeriod = True Then p.TimePeriod = checkNull(dt.Rows(i)("TimePeriod"))
            p.I_Display_TimePeriod = Display_TimePeriod
            If Display_Amount = True Then p.Amount = checkNull(dt.Rows(i)("Amount"))
            p.I_Display_Amount = Display_Amount
            If Display_Status = True Then p.Status = checkNull(dt.Rows(i)("Status"))
            p.I_Display_Status = Display_Status
            p.previous_View_Goals_ID = checkNull(dt.Rows(i)("View_Goals_ID"))
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

        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update TBL_View_Goals set "
        cmd.CommandText = cmd.CommandText & " View_Goals_ID=@View_Goals_ID,"
        If I_Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & " Child_ID=@Child_ID,"
        If I_Display_Parent_ID = True Then cmd.CommandText = cmd.CommandText & " Parent_ID=@Parent_ID,"
        If I_Display_Incentives_ID = True Then cmd.CommandText = cmd.CommandText & " Incentives_ID=@Incentives_ID,"
        If I_Display_StartDateTime = True Then cmd.CommandText = cmd.CommandText & " StartDateTime=@StartDateTime,"
        If I_Display_EndDateTime = True Then cmd.CommandText = cmd.CommandText & " EndDateTime=@EndDateTime,"
        If I_Display_Category = True Then cmd.CommandText = cmd.CommandText & " Category=@Category,"
        If I_Display_Description = True Then cmd.CommandText = cmd.CommandText & " Description=@Description,"
        If I_Display_TimePeriod = True Then cmd.CommandText = cmd.CommandText & " TimePeriod=@TimePeriod,"
        If I_Display_Amount = True Then cmd.CommandText = cmd.CommandText & " Amount=@Amount,"
        If I_Display_Status = True Then cmd.CommandText = cmd.CommandText & " Status=@Status,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where View_Goals_ID=@previous_View_Goals_ID"


        cmd.Parameters.Add("@View_Goals_ID", 22, 255, "View_Goals_ID")
        cmd.Parameters("@View_Goals_ID").Value = setNull(View_Goals_ID)

        If I_Display_Child_ID = True Then cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        If I_Display_Child_ID = True Then cmd.Parameters("@Child_ID").Value = setNull(Child_ID)

        If I_Display_Parent_ID = True Then cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        If I_Display_Parent_ID = True Then cmd.Parameters("@Parent_ID").Value = setNull(Parent_ID)

        If I_Display_Incentives_ID = True Then cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        If I_Display_Incentives_ID = True Then cmd.Parameters("@Incentives_ID").Value = setNull(Incentives_ID)

        If I_Display_StartDateTime = True Then cmd.Parameters.Add("@StartDateTime", 4, 0, "StartDateTime")
        If I_Display_StartDateTime = True Then cmd.Parameters("@StartDateTime").Value = setNull(StartDateTime)

        If I_Display_EndDateTime = True Then cmd.Parameters.Add("@EndDateTime", 4, 0, "EndDateTime")
        If I_Display_EndDateTime = True Then cmd.Parameters("@EndDateTime").Value = setNull(EndDateTime)

        If I_Display_Category = True Then cmd.Parameters.Add("@Category", 22, 50, "Category")
        If I_Display_Category = True Then cmd.Parameters("@Category").Value = setNull(Category)

        If I_Display_Description = True Then cmd.Parameters.Add("@Description", 22, 255, "Description")
        If I_Display_Description = True Then cmd.Parameters("@Description").Value = setNull(Description)

        If I_Display_TimePeriod = True Then cmd.Parameters.Add("@TimePeriod", 8, 0, "TimePeriod")
        If I_Display_TimePeriod = True Then cmd.Parameters("@TimePeriod").Value = setNull(TimePeriod)

        If I_Display_Amount = True Then cmd.Parameters.Add("@Amount", 6, 0, "Amount")
        If I_Display_Amount = True Then cmd.Parameters("@Amount").Value = setNull(Amount)

        If I_Display_Status = True Then cmd.Parameters.Add("@Status", 22, 20, "Status")
        If I_Display_Status = True Then cmd.Parameters("@Status").Value = setNull(Status)



        cmd.Parameters.Add("@previous_View_Goals_ID", 22, 255, "previous_View_Goals_ID")
        cmd.Parameters("@previous_View_Goals_ID").Value = Me.previous_View_Goals_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_View_Goals)
        Dim ps As New Generic.List(Of TBL_View_Goals)
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "View_Goals_ID,"
        If Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_Parent_ID = True Then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        If Display_Incentives_ID = True Then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        If Display_StartDateTime = True Then cmd.CommandText = cmd.CommandText & "StartDateTime,"
        If Display_EndDateTime = True Then cmd.CommandText = cmd.CommandText & "EndDateTime,"
        If Display_Category = True Then cmd.CommandText = cmd.CommandText & "Category,"
        If Display_Description = True Then cmd.CommandText = cmd.CommandText & "Description,"
        If Display_TimePeriod = True Then cmd.CommandText = cmd.CommandText & "TimePeriod,"
        If Display_Amount = True Then cmd.CommandText = cmd.CommandText & "Amount,"
        If Display_Status = True Then cmd.CommandText = cmd.CommandText & "Status,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_View_Goals " & filterstr & " " & sortstr
        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_View_Goals
            p.View_Goals_ID = checkNull(dt.Rows(i)("View_Goals_ID"))
            p.I_Display_View_Goals_ID = Display_View_Goals_ID
            If Display_Child_ID = True Then p.Child_ID = checkNull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_Parent_ID = True Then p.Parent_ID = checkNull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            If Display_Incentives_ID = True Then p.Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            If Display_StartDateTime = True Then p.StartDateTime = checkNull(dt.Rows(i)("StartDateTime"))
            p.I_Display_StartDateTime = Display_StartDateTime
            If Display_EndDateTime = True Then p.EndDateTime = checkNull(dt.Rows(i)("EndDateTime"))
            p.I_Display_EndDateTime = Display_EndDateTime
            If Display_Category = True Then p.Category = checkNull(dt.Rows(i)("Category"))
            p.I_Display_Category = Display_Category
            If Display_Description = True Then p.Description = checkNull(dt.Rows(i)("Description"))
            p.I_Display_Description = Display_Description
            If Display_TimePeriod = True Then p.TimePeriod = checkNull(dt.Rows(i)("TimePeriod"))
            p.I_Display_TimePeriod = Display_TimePeriod
            If Display_Amount = True Then p.Amount = checkNull(dt.Rows(i)("Amount"))
            p.I_Display_Amount = Display_Amount
            If Display_Status = True Then p.Status = checkNull(dt.Rows(i)("Status"))
            p.I_Display_Status = Display_Status
            p.previous_View_Goals_ID = checkNull(dt.Rows(i)("View_Goals_ID"))
            p.newinstance = False
            ps.Add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_View_Goals)
        Dim ps As New Generic.List(Of TBL_View_Goals)
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select View_Goals_ID from TBL_View_Goals" & filterstr & " " & sortstr
        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_View_Goals
            p.View_Goals_ID = checkNull(dt.Rows(i)("View_Goals_ID"))
            p.previous_View_Goals_ID = checkNull(dt.Rows(i)("View_Goals_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class