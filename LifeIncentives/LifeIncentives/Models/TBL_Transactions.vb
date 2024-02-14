Imports System.Data.SqlClient

Public Class TBL_Transactions
    inherits Entity

    Public Shared Display_Transaction_ID as Boolean = true
    Public Shared Display_Incentives_ID as Boolean = true
    Public Shared Display_Transaction_Name as Boolean = true
    Public Shared Display_Transaction_Incentive as Boolean = true
    Public Shared Display_Transaction_Type as Boolean = true
    Public Shared Display_Transaction_Amount as Boolean = true

    Private I_Display_Transaction_ID as Boolean = true
    Private I_Display_Incentives_ID as Boolean = true
    Private I_Display_Transaction_Name as Boolean = true
    Private I_Display_Transaction_Incentive as Boolean = true
    Private I_Display_Transaction_Type as Boolean = true
    Private I_Display_Transaction_Amount as Boolean = True

    Public previous_Transaction_ID As System.String

    Public Transaction_ID As System.String
    Public Incentives_ID As System.String
    Public Transaction_Name as System.String
    Public Transaction_Incentive as nullable(of System.Int32)
    Public Transaction_Type as System.String
    Public Transaction_Amount as nullable(of System.Double)
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag as boolean)
        Display_Transaction_ID = display_flag
        Display_Incentives_ID = display_flag
        Display_Transaction_Name = display_flag
        Display_Transaction_Incentive = display_flag
        Display_Transaction_Type = display_flag
        Display_Transaction_Amount = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Transactions (Transaction_ID,Incentives_ID,Transaction_Name,Transaction_Incentive,Transaction_Type,Transaction_Amount)"
        cmd.CommandText = cmd.CommandText & "values(@Transaction_ID,@Incentives_ID,@Transaction_Name,@Transaction_Incentive,@Transaction_Type,@Transaction_Amount)"

        cmd.Parameters.Add("@Transaction_ID", 22, 255, "Transaction_ID")
        cmd.Parameters("@Transaction_ID").Value = SetNull(Transaction_ID)
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)
        cmd.Parameters.Add("@Transaction_Name", 22, 50, "Transaction_Name")
        cmd.Parameters("@Transaction_Name").Value = SetNull(Transaction_Name)
        cmd.Parameters.Add("@Transaction_Incentive", 8, 0, "Transaction_Incentive")
        cmd.Parameters("@Transaction_Incentive").Value = SetNull(Transaction_Incentive)
        cmd.Parameters.Add("@Transaction_Type", 22, 50, "Transaction_Type")
        cmd.Parameters("@Transaction_Type").Value = SetNull(Transaction_Type)
        cmd.Parameters.Add("@Transaction_Amount", 6, 0, "Transaction_Amount")
        cmd.Parameters("@Transaction_Amount").Value = SetNull(Transaction_Amount)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Transactions where Transaction_ID=@previous_Transaction_ID"
        cmd.Parameters.Add("@previous_Transaction_ID", 22, 255, "previous_Transaction_ID")
        cmd.Parameters("@previous_Transaction_ID").Value = Me.previous_Transaction_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Transaction_ID as System.Int32) As TBL_Transactions
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Transaction_ID,"
        if Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        if Display_Transaction_Name = true then cmd.CommandText = cmd.CommandText & "Transaction_Name,"
        if Display_Transaction_Incentive = true then cmd.CommandText = cmd.CommandText & "Transaction_Incentive,"
        if Display_Transaction_Type = true then cmd.CommandText = cmd.CommandText & "Transaction_Type,"
        if Display_Transaction_Amount = true then cmd.CommandText = cmd.CommandText & "Transaction_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Transactions where Transaction_ID=@Transaction_ID"
        cmd.Parameters.Add("@Transaction_ID", 22, 255, "Transaction_ID")
        cmd.Parameters("@Transaction_ID").Value = Transaction_ID

        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Transactions
        For i = 0 To dt.Rows.Count - 1
            p.Transaction_ID = checknull(dt.Rows(i)("Transaction_ID"))
            p.I_Display_Transaction_ID = Display_Transaction_ID
            if Display_Incentives_ID = true then p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_Transaction_Name = true then p.Transaction_Name = checknull(dt.Rows(i)("Transaction_Name"))
            p.I_Display_Transaction_Name = Display_Transaction_Name
            if Display_Transaction_Incentive = true then p.Transaction_Incentive = checknull(dt.Rows(i)("Transaction_Incentive"))
            p.I_Display_Transaction_Incentive = Display_Transaction_Incentive
            if Display_Transaction_Type = true then p.Transaction_Type = checknull(dt.Rows(i)("Transaction_Type"))
            p.I_Display_Transaction_Type = Display_Transaction_Type
            if Display_Transaction_Amount = true then p.Transaction_Amount = checknull(dt.Rows(i)("Transaction_Amount"))
            p.I_Display_Transaction_Amount = Display_Transaction_Amount
            p.previous_Transaction_ID = checknull(dt.Rows(i)("Transaction_ID"))
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
        cmd.CommandText = "update TBL_Transactions set "
        cmd.CommandText = cmd.CommandText & " Transaction_ID=@Transaction_ID,"
        if I_Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & " Incentives_ID=@Incentives_ID,"
        if I_Display_Transaction_Name = true then cmd.CommandText = cmd.CommandText & " Transaction_Name=@Transaction_Name,"
        if I_Display_Transaction_Incentive = true then cmd.CommandText = cmd.CommandText & " Transaction_Incentive=@Transaction_Incentive,"
        if I_Display_Transaction_Type = true then cmd.CommandText = cmd.CommandText & " Transaction_Type=@Transaction_Type,"
        if I_Display_Transaction_Amount = true then cmd.CommandText = cmd.CommandText & " Transaction_Amount=@Transaction_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Transaction_ID=@previous_Transaction_ID"


        cmd.Parameters.Add("@Transaction_ID", 22, 255, "Transaction_ID")
        cmd.Parameters("@Transaction_ID").Value = SetNull(Transaction_ID)

        If I_Display_Incentives_ID = True Then cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        If I_Display_Incentives_ID = true then cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)

        if I_Display_Transaction_Name = true then cmd.Parameters.Add("@Transaction_Name", 22, 50, "Transaction_Name")
        if I_Display_Transaction_Name = true then cmd.Parameters("@Transaction_Name").Value = SetNull(Transaction_Name)

        if I_Display_Transaction_Incentive = true then cmd.Parameters.Add("@Transaction_Incentive", 8, 0, "Transaction_Incentive")
        if I_Display_Transaction_Incentive = true then cmd.Parameters("@Transaction_Incentive").Value = SetNull(Transaction_Incentive)

        if I_Display_Transaction_Type = true then cmd.Parameters.Add("@Transaction_Type", 22, 50, "Transaction_Type")
        if I_Display_Transaction_Type = true then cmd.Parameters("@Transaction_Type").Value = SetNull(Transaction_Type)

        if I_Display_Transaction_Amount = true then cmd.Parameters.Add("@Transaction_Amount", 6, 0, "Transaction_Amount")
        if I_Display_Transaction_Amount = true then cmd.Parameters("@Transaction_Amount").Value = SetNull(Transaction_Amount)



        cmd.Parameters.Add("@previous_Transaction_ID", 22, 255, "previous_Transaction_ID")
        cmd.Parameters("@previous_Transaction_ID").Value = Me.previous_Transaction_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Transactions)
        Dim ps As New Generic.List(Of TBL_Transactions)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Transaction_ID,"
        if Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        if Display_Transaction_Name = true then cmd.CommandText = cmd.CommandText & "Transaction_Name,"
        if Display_Transaction_Incentive = true then cmd.CommandText = cmd.CommandText & "Transaction_Incentive,"
        if Display_Transaction_Type = true then cmd.CommandText = cmd.CommandText & "Transaction_Type,"
        if Display_Transaction_Amount = true then cmd.CommandText = cmd.CommandText & "Transaction_Amount,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Transactions " & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Transactions
            p.Transaction_ID = checknull(dt.Rows(i)("Transaction_ID"))
            p.I_Display_Transaction_ID = Display_Transaction_ID
            if Display_Incentives_ID = true then p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_Transaction_Name = true then p.Transaction_Name = checknull(dt.Rows(i)("Transaction_Name"))
            p.I_Display_Transaction_Name = Display_Transaction_Name
            if Display_Transaction_Incentive = true then p.Transaction_Incentive = checknull(dt.Rows(i)("Transaction_Incentive"))
            p.I_Display_Transaction_Incentive = Display_Transaction_Incentive
            if Display_Transaction_Type = true then p.Transaction_Type = checknull(dt.Rows(i)("Transaction_Type"))
            p.I_Display_Transaction_Type = Display_Transaction_Type
            if Display_Transaction_Amount = true then p.Transaction_Amount = checknull(dt.Rows(i)("Transaction_Amount"))
            p.I_Display_Transaction_Amount = Display_Transaction_Amount
            p.previous_Transaction_ID = checknull(dt.Rows(i)("Transaction_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Transactions)
        Dim ps As New Generic.List(Of TBL_Transactions)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Transaction_ID from TBL_Transactions" & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Transactions
            p.Transaction_ID = checknull(dt.Rows(i)("Transaction_ID"))
            p.previous_Transaction_ID = checknull(dt.Rows(i)("Transaction_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class