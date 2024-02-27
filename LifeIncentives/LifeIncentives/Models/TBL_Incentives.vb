Imports System.Data.SqlClient

Public Class TBL_Incentives
    Inherits ENTITY

    Public Shared Display_Incentives_ID As Boolean = True
    Public Shared Display_Child_ID As Boolean = True
    Public Shared Display_Financial_Information_ID As Boolean = True
    Public Shared Display_Incentive_Type As Boolean = True
    Public Shared Display_Incentive_Increase As Boolean = True
    Public Shared Display_Incentive_Decrease As Boolean = True
    Public Shared Display_Incentive_Amount As Boolean = True

    Private I_Display_Incentives_ID As Boolean = True
    Private I_Display_Child_ID As Boolean = True
    Private I_Display_Financial_Information_ID As Boolean = True
    Private I_Display_Incentive_Type As Boolean = True
    Private I_Display_Incentive_Increase As Boolean = True
    Private I_Display_Incentive_Decrease As Boolean = True
    Private I_Display_Incentive_Amount As Boolean = True

    Public previous_Incentives_ID As System.String

    Public Incentives_ID As System.String
    Public Child_ID As System.String
    Public Financial_Information_ID As System.String
    Public Incentive_Type As System.String
    Public Incentive_Increase As Nullable(Of System.Int32)
    Public Incentive_Decrease As Nullable(Of System.Int32)
    Public Incentive_Amount As Nullable(Of System.Double)
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag As Boolean)
        Display_Incentives_ID = display_flag
        Display_Child_ID = display_flag
        Display_Financial_Information_ID = display_flag
        Display_Incentive_Type = display_flag
        Display_Incentive_Increase = display_flag
        Display_Incentive_Decrease = display_flag
        Display_Incentive_Amount = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New SqlCommand
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
        cmd.Parameters("@Incentive_Type").Value = setNull(Incentive_Type)
        cmd.Parameters.Add("@Incentive_Increase", 8, 0, "Incentive_Increase")
        cmd.Parameters("@Incentive_Increase").Value = setNull(Incentive_Increase)
        cmd.Parameters.Add("@Incentive_Decrease", 8, 0, "Incentive_Decrease")
        cmd.Parameters("@Incentive_Decrease").Value = setNull(Incentive_Decrease)
        cmd.Parameters.Add("@Incentive_Amount", 6, 0, "Incentive_Amount")
        cmd.Parameters("@Incentive_Amount").Value = setNull(Incentive_Amount)
        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Incentives where Incentives_ID=@previous_Incentives_ID"
        cmd.Parameters.Add("@previous_Incentives_ID", 22, 255, "previous_Incentives_ID")
        cmd.Parameters("@previous_Incentives_ID").Value = Me.previous_Incentives_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Incentives_ID As System.Int32) As TBL_Incentives
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        If Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_Financial_Information_ID = True Then cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        If Display_Incentive_Type = True Then cmd.CommandText = cmd.CommandText & "Incentive_Type,"
        If Display_Incentive_Increase = True Then cmd.CommandText = cmd.CommandText & "Incentive_Increase,"
        If Display_Incentive_Decrease = True Then cmd.CommandText = cmd.CommandText & "Incentive_Decrease,"
        If Display_Incentive_Amount = True Then cmd.CommandText = cmd.CommandText & "Incentive_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Incentives where Incentives_ID=@Incentives_ID"
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = Incentives_ID

        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Incentives
        For i = 0 To dt.Rows.Count - 1
            p.Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            If Display_Child_ID = True Then p.Child_ID = checkNull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_Financial_Information_ID = True Then p.Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            If Display_Incentive_Type = True Then p.Incentive_Type = checkNull(dt.Rows(i)("Incentive_Type"))
            p.I_Display_Incentive_Type = Display_Incentive_Type
            If Display_Incentive_Increase = True Then p.Incentive_Increase = checkNull(dt.Rows(i)("Incentive_Increase"))
            p.I_Display_Incentive_Increase = Display_Incentive_Increase
            If Display_Incentive_Decrease = True Then p.Incentive_Decrease = checkNull(dt.Rows(i)("Incentive_Decrease"))
            p.I_Display_Incentive_Decrease = Display_Incentive_Decrease
            If Display_Incentive_Amount = True Then p.Incentive_Amount = checkNull(dt.Rows(i)("Incentive_Amount"))
            p.I_Display_Incentive_Amount = Display_Incentive_Amount
            p.previous_Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
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
        cmd.CommandText = "update TBL_Incentives set "
        cmd.CommandText = cmd.CommandText & " Incentives_ID=@Incentives_ID,"
        If I_Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & " Child_ID=@Child_ID,"
        If I_Display_Financial_Information_ID = True Then cmd.CommandText = cmd.CommandText & " Financial_Information_ID=@Financial_Information_ID,"
        If I_Display_Incentive_Type = True Then cmd.CommandText = cmd.CommandText & " Incentive_Type=@Incentive_Type,"
        If I_Display_Incentive_Increase = True Then cmd.CommandText = cmd.CommandText & " Incentive_Increase=@Incentive_Increase,"
        If I_Display_Incentive_Decrease = True Then cmd.CommandText = cmd.CommandText & " Incentive_Decrease=@Incentive_Decrease,"
        If I_Display_Incentive_Amount = True Then cmd.CommandText = cmd.CommandText & " Incentive_Amount=@Incentive_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Incentives_ID=@previous_Incentives_ID"


        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = setNull(Incentives_ID)

        If I_Display_Child_ID = True Then cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        If I_Display_Child_ID = True Then cmd.Parameters("@Child_ID").Value = setNull(Child_ID)

        If I_Display_Financial_Information_ID = True Then cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        If I_Display_Financial_Information_ID = True Then cmd.Parameters("@Financial_Information_ID").Value = setNull(Financial_Information_ID)

        If I_Display_Incentive_Type = True Then cmd.Parameters.Add("@Incentive_Type", 22, 50, "Incentive_Type")
        If I_Display_Incentive_Type = True Then cmd.Parameters("@Incentive_Type").Value = setNull(Incentive_Type)

        If I_Display_Incentive_Increase = True Then cmd.Parameters.Add("@Incentive_Increase", 8, 0, "Incentive_Increase")
        If I_Display_Incentive_Increase = True Then cmd.Parameters("@Incentive_Increase").Value = setNull(Incentive_Increase)

        If I_Display_Incentive_Decrease = True Then cmd.Parameters.Add("@Incentive_Decrease", 8, 0, "Incentive_Decrease")
        If I_Display_Incentive_Decrease = True Then cmd.Parameters("@Incentive_Decrease").Value = setNull(Incentive_Decrease)

        If I_Display_Incentive_Amount = True Then cmd.Parameters.Add("@Incentive_Amount", 6, 0, "Incentive_Amount")
        If I_Display_Incentive_Amount = True Then cmd.Parameters("@Incentive_Amount").Value = setNull(Incentive_Amount)



        cmd.Parameters.Add("@previous_Incentives_ID", 22, 255, "previous_Incentives_ID")
        cmd.Parameters("@previous_Incentives_ID").Value = Me.previous_Incentives_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Incentives)
        Dim ps As New Generic.List(Of TBL_Incentives)
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        If Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_Financial_Information_ID = True Then cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        If Display_Incentive_Type = True Then cmd.CommandText = cmd.CommandText & "Incentive_Type,"
        If Display_Incentive_Increase = True Then cmd.CommandText = cmd.CommandText & "Incentive_Increase,"
        If Display_Incentive_Decrease = True Then cmd.CommandText = cmd.CommandText & "Incentive_Decrease,"
        If Display_Incentive_Amount = True Then cmd.CommandText = cmd.CommandText & "Incentive_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Incentives " & filterstr & " " & sortstr
        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Incentives
            p.Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            If Display_Child_ID = True Then p.Child_ID = checkNull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_Financial_Information_ID = True Then p.Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            If Display_Incentive_Type = True Then p.Incentive_Type = checkNull(dt.Rows(i)("Incentive_Type"))
            p.I_Display_Incentive_Type = Display_Incentive_Type
            If Display_Incentive_Increase = True Then p.Incentive_Increase = checkNull(dt.Rows(i)("Incentive_Increase"))
            p.I_Display_Incentive_Increase = Display_Incentive_Increase
            If Display_Incentive_Decrease = True Then p.Incentive_Decrease = checkNull(dt.Rows(i)("Incentive_Decrease"))
            p.I_Display_Incentive_Decrease = Display_Incentive_Decrease
            If Display_Incentive_Amount = True Then p.Incentive_Amount = checkNull(dt.Rows(i)("Incentive_Amount"))
            p.I_Display_Incentive_Amount = Display_Incentive_Amount
            p.previous_Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.newinstance = False
            ps.Add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Incentives)
        Dim ps As New Generic.List(Of TBL_Incentives)
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Incentives_ID from TBL_Incentives" & filterstr & " " & sortstr
        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Incentives
            p.Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.previous_Incentives_ID = checkNull(dt.Rows(i)("Incentives_ID"))
            p.newinstance = False
            ps.Add(p)
        Next
        Return ps
    End Function


End Class