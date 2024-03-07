Imports System.Data.SqlClient

Public Class TBL_Incentives
    inherits Entity

    Public Shared Display_Incentives_ID as Boolean = True
    Public Shared Display_Child_ID As Boolean = True
    Public Shared Display_Financial_Information_ID As Boolean = True
    Public Shared Display_Incentive_Type as Boolean = true
    Public Shared Display_Incentive_Increase as Boolean = true
    Public Shared Display_Incentive_Decrease as Boolean = true
    Public Shared Display_Incentive_Amount as Boolean = true

    Private I_Display_Incentives_ID as Boolean = True
    Private I_Display_Child_ID As Boolean = True
    Private I_Display_Financial_Information_ID As Boolean = True
    Private I_Display_Incentive_Type as Boolean = true
    Private I_Display_Incentive_Increase as Boolean = true
    Private I_Display_Incentive_Decrease as Boolean = true
    Private I_Display_Incentive_Amount as Boolean = True

    Public previous_Incentives_ID As System.String

    Public Incentives_ID As System.String
    Public Child_ID As System.String
    Public Financial_Information_ID As System.String
    Public Incentive_Type As System.String
    Public Incentive_Increase As String
    Public Incentive_Decrease As String
    Public Incentive_Amount As Nullable(Of System.Double)
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag as boolean)
        Display_Incentives_ID = display_flag
        Display_Child_ID = display_flag
        Display_Financial_Information_ID = display_flag
        Display_Incentive_Type = display_flag
        Display_Incentive_Increase = display_flag
        Display_Incentive_Decrease = display_flag
        Display_Incentive_Amount = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Incentives (Incentives_ID,Child_ID,Financial_Information_ID,Incentive_Type,Incentive_Increase,Incentive_Decrease,Incentive_Amount)"
        cmd.CommandText = cmd.CommandText & "values(@Incentives_ID,@Child_ID,@Financial_Information_ID,@Incentive_Type,@Incentive_Increase,@Incentive_Decrease,@Incentive_Amount)"
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = setNull(Incentives_ID)
        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = setNull(Child_ID)
        cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        cmd.Parameters("@Financial_Information_ID").Value = setNull(Financial_Information_ID)
        cmd.Parameters.Add("@Incentive_Type", 22, 50, "Incentive_Type")
        cmd.Parameters("@Incentive_Type").Value = SetNull(Incentive_Type)
        cmd.Parameters.Add("@Incentive_Increase", 8, 0, "Incentive_Increase")
        cmd.Parameters("@Incentive_Increase").Value = SetNull(Incentive_Increase)
        cmd.Parameters.Add("@Incentive_Decrease", 8, 0, "Incentive_Decrease")
        cmd.Parameters("@Incentive_Decrease").Value = SetNull(Incentive_Decrease)
        cmd.Parameters.Add("@Incentive_Amount", 6, 0, "Incentive_Amount")
        cmd.Parameters("@Incentive_Amount").Value = setNull(Incentive_Amount)
        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Incentives where Incentives_ID=@previous_Incentives_ID"
        cmd.Parameters.Add("@previous_Incentives_ID", 22, 255, "previous_Incentives_ID")
        cmd.Parameters("@previous_Incentives_ID").Value = Me.previous_Incentives_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Incentives_ID as System.Int32) As TBL_Incentives
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        If Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_Financial_Information_ID = True Then cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        If Display_Incentive_Type = true then cmd.CommandText = cmd.CommandText & "Incentive_Type,"
        if Display_Incentive_Increase = true then cmd.CommandText = cmd.CommandText & "Incentive_Increase,"
        if Display_Incentive_Decrease = true then cmd.CommandText = cmd.CommandText & "Incentive_Decrease,"
        if Display_Incentive_Amount = true then cmd.CommandText = cmd.CommandText & "Incentive_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Incentives where Incentives_ID=@Incentives_ID"
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = Incentives_ID

        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Incentives
        For i = 0 To dt.Rows.Count - 1
            p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_Child_ID = true then p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_Financial_Information_ID = True Then p.Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            If Display_Incentive_Type = true then p.Incentive_Type = checknull(dt.Rows(i)("Incentive_Type"))
            p.I_Display_Incentive_Type = Display_Incentive_Type
            if Display_Incentive_Increase = true then p.Incentive_Increase = checknull(dt.Rows(i)("Incentive_Increase"))
            p.I_Display_Incentive_Increase = Display_Incentive_Increase
            if Display_Incentive_Decrease = true then p.Incentive_Decrease = checknull(dt.Rows(i)("Incentive_Decrease"))
            p.I_Display_Incentive_Decrease = Display_Incentive_Decrease
            if Display_Incentive_Amount = true then p.Incentive_Amount = checknull(dt.Rows(i)("Incentive_Amount"))
            p.I_Display_Incentive_Amount = Display_Incentive_Amount
            p.previous_Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
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
        cmd.CommandText = "update TBL_Incentives set "
        cmd.CommandText = cmd.CommandText & " Incentives_ID=@Incentives_ID,"
        If I_Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & " Child_ID=@Child_ID,"
        If I_Display_Financial_Information_ID = True Then cmd.CommandText = cmd.CommandText & " Financial_Information_ID=@Financial_Information_ID,"
        If I_Display_Incentive_Type = true then cmd.CommandText = cmd.CommandText & " Incentive_Type=@Incentive_Type,"
        if I_Display_Incentive_Increase = true then cmd.CommandText = cmd.CommandText & " Incentive_Increase=@Incentive_Increase,"
        if I_Display_Incentive_Decrease = true then cmd.CommandText = cmd.CommandText & " Incentive_Decrease=@Incentive_Decrease,"
        if I_Display_Incentive_Amount = true then cmd.CommandText = cmd.CommandText & " Incentive_Amount=@Incentive_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Incentives_ID=@previous_Incentives_ID"


        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = setNull(Incentives_ID)

        If I_Display_Child_ID = True Then cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        If I_Display_Child_ID = True Then cmd.Parameters("@Child_ID").Value = setNull(Child_ID)

        If I_Display_Financial_Information_ID = True Then cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        If I_Display_Financial_Information_ID = True Then cmd.Parameters("@Financial_Information_ID").Value = setNull(Financial_Information_ID)

        If I_Display_Incentive_Type = true then cmd.Parameters.Add("@Incentive_Type", 22, 50, "Incentive_Type")
        if I_Display_Incentive_Type = true then cmd.Parameters("@Incentive_Type").Value = SetNull(Incentive_Type)

        if I_Display_Incentive_Increase = true then cmd.Parameters.Add("@Incentive_Increase", 8, 0, "Incentive_Increase")
        if I_Display_Incentive_Increase = true then cmd.Parameters("@Incentive_Increase").Value = SetNull(Incentive_Increase)

        if I_Display_Incentive_Decrease = true then cmd.Parameters.Add("@Incentive_Decrease", 8, 0, "Incentive_Decrease")
        if I_Display_Incentive_Decrease = true then cmd.Parameters("@Incentive_Decrease").Value = SetNull(Incentive_Decrease)

        if I_Display_Incentive_Amount = true then cmd.Parameters.Add("@Incentive_Amount", 6, 0, "Incentive_Amount")
        if I_Display_Incentive_Amount = true then cmd.Parameters("@Incentive_Amount").Value = SetNull(Incentive_Amount)



        cmd.Parameters.Add("@previous_Incentives_ID", 22, 255, "previous_Incentives_ID")
        'cmd.Parameters("@previous_Incentives_ID").Value = Me.previous_Incentives_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Incentives)
        Dim ps As New Generic.List(Of TBL_Incentives)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        If Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_Financial_Information_ID = True Then cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        If Display_Incentive_Type = true then cmd.CommandText = cmd.CommandText & "Incentive_Type,"
        if Display_Incentive_Increase = true then cmd.CommandText = cmd.CommandText & "Incentive_Increase,"
        if Display_Incentive_Decrease = true then cmd.CommandText = cmd.CommandText & "Incentive_Decrease,"
        if Display_Incentive_Amount = true then cmd.CommandText = cmd.CommandText & "Incentive_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Incentives " & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Incentives
            p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_Child_ID = true then p.Child_ID = checknull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_Financial_Information_ID = True Then p.Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            If Display_Incentive_Type = true then p.Incentive_Type = checknull(dt.Rows(i)("Incentive_Type"))
            p.I_Display_Incentive_Type = Display_Incentive_Type
            if Display_Incentive_Increase = true then p.Incentive_Increase = checknull(dt.Rows(i)("Incentive_Increase"))
            p.I_Display_Incentive_Increase = Display_Incentive_Increase
            if Display_Incentive_Decrease = true then p.Incentive_Decrease = checknull(dt.Rows(i)("Incentive_Decrease"))
            p.I_Display_Incentive_Decrease = Display_Incentive_Decrease
            if Display_Incentive_Amount = true then p.Incentive_Amount = checknull(dt.Rows(i)("Incentive_Amount"))
            p.I_Display_Incentive_Amount = Display_Incentive_Amount
            p.previous_Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Incentives)
        Dim ps As New Generic.List(Of TBL_Incentives)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Incentives_ID from TBL_Incentives" & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Incentives
            p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.previous_Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class