Imports System.Data.SqlClient

Public Class TBL_Financial_Information
    inherits Entity

    Public Shared Display_Financial_Information_ID as Boolean = true
    Public Shared Display_Parent_ID as Boolean = true
    Public Shared Display_Incentives_ID as Boolean = true
    Public Shared Display_School_Type as Boolean = true
    Public Shared Display_School_Level as Boolean = true
    Public Shared Display_School_Fees_Funding_Status as Boolean = true
    Public Shared Display_School_Fees_Price as Boolean = true
    Public Shared Display_Stationery_Funding_Status as Boolean = true
    Public Shared Display_Stationery_Price as Boolean = true
    Public Shared Display_Allowance_Status as Boolean = true
    Public Shared Display_Allowance_Price as Boolean = true
    Public Shared Display_Transport_Status as Boolean = true
    Public Shared Display_Transport_Price as Boolean = true
    Public Shared Display_Accommodation_Status as Boolean = true
    Public Shared Display_Accommodation_Price as Boolean = true
    Public Shared Display_Membership_Status as Boolean = true
    Public Shared Display_Membership_Price as Boolean = true
    Public Shared Display_ExternalClasses_Status as Boolean = true
    Public Shared Display_ExternalClass_Prices as Boolean = true
    Public Shared Display_Gadgets_Status as Boolean = true
    Public Shared Display_Gadgets_Price as Boolean = true
    Public Shared Display_Celebration_Status as Boolean = true
    Public Shared Display_Celebration_Price as Boolean = true

    Private I_Display_Financial_Information_ID as Boolean = true
    Private I_Display_Parent_ID as Boolean = true
    Private I_Display_Incentives_ID as Boolean = true
    Private I_Display_School_Type as Boolean = true
    Private I_Display_School_Level as Boolean = true
    Private I_Display_School_Fees_Funding_Status as Boolean = true
    Private I_Display_School_Fees_Price as Boolean = true
    Private I_Display_Stationery_Funding_Status as Boolean = true
    Private I_Display_Stationery_Price as Boolean = true
    Private I_Display_Allowance_Status as Boolean = true
    Private I_Display_Allowance_Price as Boolean = true
    Private I_Display_Transport_Status as Boolean = true
    Private I_Display_Transport_Price as Boolean = true
    Private I_Display_Accommodation_Status as Boolean = true
    Private I_Display_Accommodation_Price as Boolean = true
    Private I_Display_Membership_Status as Boolean = true
    Private I_Display_Membership_Price as Boolean = true
    Private I_Display_ExternalClasses_Status as Boolean = true
    Private I_Display_ExternalClass_Prices as Boolean = true
    Private I_Display_Gadgets_Status as Boolean = true
    Private I_Display_Gadgets_Price as Boolean = true
    Private I_Display_Celebration_Status as Boolean = true
    Private I_Display_Celebration_Price as Boolean = True

    Public previous_Financial_Information_ID As System.String

    Public Financial_Information_ID As System.String
    Public Parent_ID As System.String
    Public Incentives_ID As System.String
    Public School_Type as System.String
    Public School_Level as System.String
    Public School_Fees_Funding_Status as System.String
    Public School_Fees_Price as nullable(of System.Double)
    Public Stationery_Funding_Status as System.String
    Public Stationery_Price as nullable(of System.Double)
    Public Allowance_Status as System.String
    Public Allowance_Price as nullable(of System.Double)
    Public Transport_Status as System.String
    Public Transport_Price as nullable(of System.Double)
    Public Accommodation_Status as System.String
    Public Accommodation_Price as nullable(of System.Double)
    Public Membership_Status as System.String
    Public Membership_Price as nullable(of System.Double)
    Public ExternalClasses_Status as System.String
    Public ExternalClass_Prices as nullable(of System.Double)
    Public Gadgets_Status as System.String
    Public Gadgets_Price as nullable(of System.Double)
    Public Celebration_Status as System.String
    Public Celebration_Price as nullable(of System.Double)
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag as boolean)
        Display_Financial_Information_ID = display_flag
        Display_Parent_ID = display_flag
        Display_Incentives_ID = display_flag
        Display_School_Type = display_flag
        Display_School_Level = display_flag
        Display_School_Fees_Funding_Status = display_flag
        Display_School_Fees_Price = display_flag
        Display_Stationery_Funding_Status = display_flag
        Display_Stationery_Price = display_flag
        Display_Allowance_Status = display_flag
        Display_Allowance_Price = display_flag
        Display_Transport_Status = display_flag
        Display_Transport_Price = display_flag
        Display_Accommodation_Status = display_flag
        Display_Accommodation_Price = display_flag
        Display_Membership_Status = display_flag
        Display_Membership_Price = display_flag
        Display_ExternalClasses_Status = display_flag
        Display_ExternalClass_Prices = display_flag
        Display_Gadgets_Status = display_flag
        Display_Gadgets_Price = display_flag
        Display_Celebration_Status = display_flag
        Display_Celebration_Price = display_flag
    End Sub


    Private Sub insert()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Financial_Information (Financial_Information_ID,Parent_ID,Incentives_ID,School_Type,School_Level,School_Fees_Funding_Status,School_Fees_Price,Stationery_Funding_Status,Stationery_Price,Allowance_Status,Allowance_Price,Transport_Status,Transport_Price,Accommodation_Status,Accommodation_Price,Membership_Status,Membership_Price,ExternalClasses_Status,ExternalClass_Prices,Gadgets_Status,Gadgets_Price,Celebration_Status,Celebration_Price)"
        cmd.CommandText = cmd.CommandText & "values(@Financial_Information_ID,@Parent_ID,@Incentives_ID,@School_Type,@School_Level,@School_Fees_Funding_Status,@School_Fees_Price,@Stationery_Funding_Status,@Stationery_Price,@Allowance_Status,@Allowance_Price,@Transport_Status,@Transport_Price,@Accommodation_Status,@Accommodation_Price,@Membership_Status,@Membership_Price,@ExternalClasses_Status,@ExternalClass_Prices,@Gadgets_Status,@Gadgets_Price,@Celebration_Status,@Celebration_Price)"

        cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        cmd.Parameters("@Financial_Information_ID").Value = SetNull(Financial_Information_ID)
        cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        cmd.Parameters("@Parent_ID").Value = SetNull(Parent_ID)
        cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)
        cmd.Parameters.Add("@School_Type", 22, 10, "School_Type")
        cmd.Parameters("@School_Type").Value = SetNull(School_Type)
        cmd.Parameters.Add("@School_Level", 22, 10, "School_Level")
        cmd.Parameters("@School_Level").Value = SetNull(School_Level)
        cmd.Parameters.Add("@School_Fees_Funding_Status", 22, 10, "School_Fees_Funding_Status")
        cmd.Parameters("@School_Fees_Funding_Status").Value = SetNull(School_Fees_Funding_Status)
        cmd.Parameters.Add("@School_Fees_Price", 6, 0, "School_Fees_Price")
        cmd.Parameters("@School_Fees_Price").Value = SetNull(School_Fees_Price)
        cmd.Parameters.Add("@Stationery_Funding_Status", 22, 10, "Stationery_Funding_Status")
        cmd.Parameters("@Stationery_Funding_Status").Value = SetNull(Stationery_Funding_Status)
        cmd.Parameters.Add("@Stationery_Price", 6, 0, "Stationery_Price")
        cmd.Parameters("@Stationery_Price").Value = SetNull(Stationery_Price)
        cmd.Parameters.Add("@Allowance_Status", 22, 10, "Allowance_Status")
        cmd.Parameters("@Allowance_Status").Value = SetNull(Allowance_Status)
        cmd.Parameters.Add("@Allowance_Price", 6, 0, "Allowance_Price")
        cmd.Parameters("@Allowance_Price").Value = SetNull(Allowance_Price)
        cmd.Parameters.Add("@Transport_Status", 22, 10, "Transport_Status")
        cmd.Parameters("@Transport_Status").Value = SetNull(Transport_Status)
        cmd.Parameters.Add("@Transport_Price", 6, 0, "Transport_Price")
        cmd.Parameters("@Transport_Price").Value = SetNull(Transport_Price)
        cmd.Parameters.Add("@Accommodation_Status", 22, 10, "Accommodation_Status")
        cmd.Parameters("@Accommodation_Status").Value = SetNull(Accommodation_Status)
        cmd.Parameters.Add("@Accommodation_Price", 6, 0, "Accommodation_Price")
        cmd.Parameters("@Accommodation_Price").Value = SetNull(Accommodation_Price)
        cmd.Parameters.Add("@Membership_Status", 22, 10, "Membership_Status")
        cmd.Parameters("@Membership_Status").Value = SetNull(Membership_Status)
        cmd.Parameters.Add("@Membership_Price", 6, 0, "Membership_Price")
        cmd.Parameters("@Membership_Price").Value = SetNull(Membership_Price)
        cmd.Parameters.Add("@ExternalClasses_Status", 22, 10, "ExternalClasses_Status")
        cmd.Parameters("@ExternalClasses_Status").Value = SetNull(ExternalClasses_Status)
        cmd.Parameters.Add("@ExternalClass_Prices", 6, 0, "ExternalClass_Prices")
        cmd.Parameters("@ExternalClass_Prices").Value = SetNull(ExternalClass_Prices)
        cmd.Parameters.Add("@Gadgets_Status", 22, 10, "Gadgets_Status")
        cmd.Parameters("@Gadgets_Status").Value = SetNull(Gadgets_Status)
        cmd.Parameters.Add("@Gadgets_Price", 6, 0, "Gadgets_Price")
        cmd.Parameters("@Gadgets_Price").Value = SetNull(Gadgets_Price)
        cmd.Parameters.Add("@Celebration_Status", 22, 10, "Celebration_Status")
        cmd.Parameters("@Celebration_Status").Value = SetNull(Celebration_Status)
        cmd.Parameters.Add("@Celebration_Price", 6, 0, "Celebration_Price")
        cmd.Parameters("@Celebration_Price").Value = SetNull(Celebration_Price)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Financial_Information where Financial_Information_ID=@previous_Financial_Information_ID"
        cmd.Parameters.Add("@previous_Financial_Information_ID", 22, 255, "previous_Financial_Information_ID")
        cmd.Parameters("@previous_Financial_Information_ID").Value = Me.previous_Financial_Information_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Financial_Information_ID as System.Int32) As TBL_Financial_Information
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        if Display_Parent_ID = true then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        if Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        if Display_School_Type = true then cmd.CommandText = cmd.CommandText & "School_Type,"
        if Display_School_Level = true then cmd.CommandText = cmd.CommandText & "School_Level,"
        if Display_School_Fees_Funding_Status = true then cmd.CommandText = cmd.CommandText & "School_Fees_Funding_Status,"
        if Display_School_Fees_Price = true then cmd.CommandText = cmd.CommandText & "School_Fees_Price,"
        if Display_Stationery_Funding_Status = true then cmd.CommandText = cmd.CommandText & "Stationery_Funding_Status,"
        if Display_Stationery_Price = true then cmd.CommandText = cmd.CommandText & "Stationery_Price,"
        if Display_Allowance_Status = true then cmd.CommandText = cmd.CommandText & "Allowance_Status,"
        if Display_Allowance_Price = true then cmd.CommandText = cmd.CommandText & "Allowance_Price,"
        if Display_Transport_Status = true then cmd.CommandText = cmd.CommandText & "Transport_Status,"
        if Display_Transport_Price = true then cmd.CommandText = cmd.CommandText & "Transport_Price,"
        if Display_Accommodation_Status = true then cmd.CommandText = cmd.CommandText & "Accommodation_Status,"
        if Display_Accommodation_Price = true then cmd.CommandText = cmd.CommandText & "Accommodation_Price,"
        if Display_Membership_Status = true then cmd.CommandText = cmd.CommandText & "Membership_Status,"
        if Display_Membership_Price = true then cmd.CommandText = cmd.CommandText & "Membership_Price,"
        if Display_ExternalClasses_Status = true then cmd.CommandText = cmd.CommandText & "ExternalClasses_Status,"
        if Display_ExternalClass_Prices = true then cmd.CommandText = cmd.CommandText & "ExternalClass_Prices,"
        if Display_Gadgets_Status = true then cmd.CommandText = cmd.CommandText & "Gadgets_Status,"
        if Display_Gadgets_Price = true then cmd.CommandText = cmd.CommandText & "Gadgets_Price,"
        if Display_Celebration_Status = true then cmd.CommandText = cmd.CommandText & "Celebration_Status,"
        if Display_Celebration_Price = true then cmd.CommandText = cmd.CommandText & "Celebration_Price,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Financial_Information where Financial_Information_ID=@Financial_Information_ID"
        cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        cmd.Parameters("@Financial_Information_ID").Value = Financial_Information_ID

        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Financial_Information
        For i = 0 To dt.Rows.Count - 1
            p.Financial_Information_ID = checknull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            if Display_Parent_ID = true then p.Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            if Display_Incentives_ID = true then p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_School_Type = true then p.School_Type = checknull(dt.Rows(i)("School_Type"))
            p.I_Display_School_Type = Display_School_Type
            if Display_School_Level = true then p.School_Level = checknull(dt.Rows(i)("School_Level"))
            p.I_Display_School_Level = Display_School_Level
            if Display_School_Fees_Funding_Status = true then p.School_Fees_Funding_Status = checknull(dt.Rows(i)("School_Fees_Funding_Status"))
            p.I_Display_School_Fees_Funding_Status = Display_School_Fees_Funding_Status
            if Display_School_Fees_Price = true then p.School_Fees_Price = checknull(dt.Rows(i)("School_Fees_Price"))
            p.I_Display_School_Fees_Price = Display_School_Fees_Price
            if Display_Stationery_Funding_Status = true then p.Stationery_Funding_Status = checknull(dt.Rows(i)("Stationery_Funding_Status"))
            p.I_Display_Stationery_Funding_Status = Display_Stationery_Funding_Status
            if Display_Stationery_Price = true then p.Stationery_Price = checknull(dt.Rows(i)("Stationery_Price"))
            p.I_Display_Stationery_Price = Display_Stationery_Price
            if Display_Allowance_Status = true then p.Allowance_Status = checknull(dt.Rows(i)("Allowance_Status"))
            p.I_Display_Allowance_Status = Display_Allowance_Status
            if Display_Allowance_Price = true then p.Allowance_Price = checknull(dt.Rows(i)("Allowance_Price"))
            p.I_Display_Allowance_Price = Display_Allowance_Price
            if Display_Transport_Status = true then p.Transport_Status = checknull(dt.Rows(i)("Transport_Status"))
            p.I_Display_Transport_Status = Display_Transport_Status
            if Display_Transport_Price = true then p.Transport_Price = checknull(dt.Rows(i)("Transport_Price"))
            p.I_Display_Transport_Price = Display_Transport_Price
            if Display_Accommodation_Status = true then p.Accommodation_Status = checknull(dt.Rows(i)("Accommodation_Status"))
            p.I_Display_Accommodation_Status = Display_Accommodation_Status
            if Display_Accommodation_Price = true then p.Accommodation_Price = checknull(dt.Rows(i)("Accommodation_Price"))
            p.I_Display_Accommodation_Price = Display_Accommodation_Price
            if Display_Membership_Status = true then p.Membership_Status = checknull(dt.Rows(i)("Membership_Status"))
            p.I_Display_Membership_Status = Display_Membership_Status
            if Display_Membership_Price = true then p.Membership_Price = checknull(dt.Rows(i)("Membership_Price"))
            p.I_Display_Membership_Price = Display_Membership_Price
            if Display_ExternalClasses_Status = true then p.ExternalClasses_Status = checknull(dt.Rows(i)("ExternalClasses_Status"))
            p.I_Display_ExternalClasses_Status = Display_ExternalClasses_Status
            if Display_ExternalClass_Prices = true then p.ExternalClass_Prices = checknull(dt.Rows(i)("ExternalClass_Prices"))
            p.I_Display_ExternalClass_Prices = Display_ExternalClass_Prices
            if Display_Gadgets_Status = true then p.Gadgets_Status = checknull(dt.Rows(i)("Gadgets_Status"))
            p.I_Display_Gadgets_Status = Display_Gadgets_Status
            if Display_Gadgets_Price = true then p.Gadgets_Price = checknull(dt.Rows(i)("Gadgets_Price"))
            p.I_Display_Gadgets_Price = Display_Gadgets_Price
            if Display_Celebration_Status = true then p.Celebration_Status = checknull(dt.Rows(i)("Celebration_Status"))
            p.I_Display_Celebration_Status = Display_Celebration_Status
            if Display_Celebration_Price = true then p.Celebration_Price = checknull(dt.Rows(i)("Celebration_Price"))
            p.I_Display_Celebration_Price = Display_Celebration_Price
            p.previous_Financial_Information_ID = checknull(dt.Rows(i)("Financial_Information_ID"))
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
        cmd.CommandText = "update TBL_Financial_Information set "
        cmd.CommandText = cmd.CommandText & " Financial_Information_ID=@Financial_Information_ID,"
        if I_Display_Parent_ID = true then cmd.CommandText = cmd.CommandText & " Parent_ID=@Parent_ID,"
        if I_Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & " Incentives_ID=@Incentives_ID,"
        if I_Display_School_Type = true then cmd.CommandText = cmd.CommandText & " School_Type=@School_Type,"
        if I_Display_School_Level = true then cmd.CommandText = cmd.CommandText & " School_Level=@School_Level,"
        if I_Display_School_Fees_Funding_Status = true then cmd.CommandText = cmd.CommandText & " School_Fees_Funding_Status=@School_Fees_Funding_Status,"
        if I_Display_School_Fees_Price = true then cmd.CommandText = cmd.CommandText & " School_Fees_Price=@School_Fees_Price,"
        if I_Display_Stationery_Funding_Status = true then cmd.CommandText = cmd.CommandText & " Stationery_Funding_Status=@Stationery_Funding_Status,"
        if I_Display_Stationery_Price = true then cmd.CommandText = cmd.CommandText & " Stationery_Price=@Stationery_Price,"
        if I_Display_Allowance_Status = true then cmd.CommandText = cmd.CommandText & " Allowance_Status=@Allowance_Status,"
        if I_Display_Allowance_Price = true then cmd.CommandText = cmd.CommandText & " Allowance_Price=@Allowance_Price,"
        if I_Display_Transport_Status = true then cmd.CommandText = cmd.CommandText & " Transport_Status=@Transport_Status,"
        if I_Display_Transport_Price = true then cmd.CommandText = cmd.CommandText & " Transport_Price=@Transport_Price,"
        if I_Display_Accommodation_Status = true then cmd.CommandText = cmd.CommandText & " Accommodation_Status=@Accommodation_Status,"
        if I_Display_Accommodation_Price = true then cmd.CommandText = cmd.CommandText & " Accommodation_Price=@Accommodation_Price,"
        if I_Display_Membership_Status = true then cmd.CommandText = cmd.CommandText & " Membership_Status=@Membership_Status,"
        if I_Display_Membership_Price = true then cmd.CommandText = cmd.CommandText & " Membership_Price=@Membership_Price,"
        if I_Display_ExternalClasses_Status = true then cmd.CommandText = cmd.CommandText & " ExternalClasses_Status=@ExternalClasses_Status,"
        if I_Display_ExternalClass_Prices = true then cmd.CommandText = cmd.CommandText & " ExternalClass_Prices=@ExternalClass_Prices,"
        if I_Display_Gadgets_Status = true then cmd.CommandText = cmd.CommandText & " Gadgets_Status=@Gadgets_Status,"
        if I_Display_Gadgets_Price = true then cmd.CommandText = cmd.CommandText & " Gadgets_Price=@Gadgets_Price,"
        if I_Display_Celebration_Status = true then cmd.CommandText = cmd.CommandText & " Celebration_Status=@Celebration_Status,"
        if I_Display_Celebration_Price = true then cmd.CommandText = cmd.CommandText & " Celebration_Price=@Celebration_Price,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Financial_Information_ID=@previous_Financial_Information_ID"


        cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        cmd.Parameters("@Financial_Information_ID").Value = SetNull(Financial_Information_ID)

        If I_Display_Parent_ID = True Then cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        If I_Display_Parent_ID = true then cmd.Parameters("@Parent_ID").Value = SetNull(Parent_ID)

        If I_Display_Incentives_ID = True Then cmd.Parameters.Add("@Incentives_ID", 22, 255, "Incentives_ID")
        If I_Display_Incentives_ID = true then cmd.Parameters("@Incentives_ID").Value = SetNull(Incentives_ID)

        if I_Display_School_Type = true then cmd.Parameters.Add("@School_Type", 22, 10, "School_Type")
        if I_Display_School_Type = true then cmd.Parameters("@School_Type").Value = SetNull(School_Type)

        if I_Display_School_Level = true then cmd.Parameters.Add("@School_Level", 22, 10, "School_Level")
        if I_Display_School_Level = true then cmd.Parameters("@School_Level").Value = SetNull(School_Level)

        if I_Display_School_Fees_Funding_Status = true then cmd.Parameters.Add("@School_Fees_Funding_Status", 22, 10, "School_Fees_Funding_Status")
        if I_Display_School_Fees_Funding_Status = true then cmd.Parameters("@School_Fees_Funding_Status").Value = SetNull(School_Fees_Funding_Status)

        if I_Display_School_Fees_Price = true then cmd.Parameters.Add("@School_Fees_Price", 6, 0, "School_Fees_Price")
        if I_Display_School_Fees_Price = true then cmd.Parameters("@School_Fees_Price").Value = SetNull(School_Fees_Price)

        if I_Display_Stationery_Funding_Status = true then cmd.Parameters.Add("@Stationery_Funding_Status", 22, 10, "Stationery_Funding_Status")
        if I_Display_Stationery_Funding_Status = true then cmd.Parameters("@Stationery_Funding_Status").Value = SetNull(Stationery_Funding_Status)

        if I_Display_Stationery_Price = true then cmd.Parameters.Add("@Stationery_Price", 6, 0, "Stationery_Price")
        if I_Display_Stationery_Price = true then cmd.Parameters("@Stationery_Price").Value = SetNull(Stationery_Price)

        if I_Display_Allowance_Status = true then cmd.Parameters.Add("@Allowance_Status", 22, 10, "Allowance_Status")
        if I_Display_Allowance_Status = true then cmd.Parameters("@Allowance_Status").Value = SetNull(Allowance_Status)

        if I_Display_Allowance_Price = true then cmd.Parameters.Add("@Allowance_Price", 6, 0, "Allowance_Price")
        if I_Display_Allowance_Price = true then cmd.Parameters("@Allowance_Price").Value = SetNull(Allowance_Price)

        if I_Display_Transport_Status = true then cmd.Parameters.Add("@Transport_Status", 22, 10, "Transport_Status")
        if I_Display_Transport_Status = true then cmd.Parameters("@Transport_Status").Value = SetNull(Transport_Status)

        if I_Display_Transport_Price = true then cmd.Parameters.Add("@Transport_Price", 6, 0, "Transport_Price")
        if I_Display_Transport_Price = true then cmd.Parameters("@Transport_Price").Value = SetNull(Transport_Price)

        if I_Display_Accommodation_Status = true then cmd.Parameters.Add("@Accommodation_Status", 22, 10, "Accommodation_Status")
        if I_Display_Accommodation_Status = true then cmd.Parameters("@Accommodation_Status").Value = SetNull(Accommodation_Status)

        if I_Display_Accommodation_Price = true then cmd.Parameters.Add("@Accommodation_Price", 6, 0, "Accommodation_Price")
        if I_Display_Accommodation_Price = true then cmd.Parameters("@Accommodation_Price").Value = SetNull(Accommodation_Price)

        if I_Display_Membership_Status = true then cmd.Parameters.Add("@Membership_Status", 22, 10, "Membership_Status")
        if I_Display_Membership_Status = true then cmd.Parameters("@Membership_Status").Value = SetNull(Membership_Status)

        if I_Display_Membership_Price = true then cmd.Parameters.Add("@Membership_Price", 6, 0, "Membership_Price")
        if I_Display_Membership_Price = true then cmd.Parameters("@Membership_Price").Value = SetNull(Membership_Price)

        if I_Display_ExternalClasses_Status = true then cmd.Parameters.Add("@ExternalClasses_Status", 22, 10, "ExternalClasses_Status")
        if I_Display_ExternalClasses_Status = true then cmd.Parameters("@ExternalClasses_Status").Value = SetNull(ExternalClasses_Status)

        if I_Display_ExternalClass_Prices = true then cmd.Parameters.Add("@ExternalClass_Prices", 6, 0, "ExternalClass_Prices")
        if I_Display_ExternalClass_Prices = true then cmd.Parameters("@ExternalClass_Prices").Value = SetNull(ExternalClass_Prices)

        if I_Display_Gadgets_Status = true then cmd.Parameters.Add("@Gadgets_Status", 22, 10, "Gadgets_Status")
        if I_Display_Gadgets_Status = true then cmd.Parameters("@Gadgets_Status").Value = SetNull(Gadgets_Status)

        if I_Display_Gadgets_Price = true then cmd.Parameters.Add("@Gadgets_Price", 6, 0, "Gadgets_Price")
        if I_Display_Gadgets_Price = true then cmd.Parameters("@Gadgets_Price").Value = SetNull(Gadgets_Price)

        if I_Display_Celebration_Status = true then cmd.Parameters.Add("@Celebration_Status", 22, 10, "Celebration_Status")
        if I_Display_Celebration_Status = true then cmd.Parameters("@Celebration_Status").Value = SetNull(Celebration_Status)

        if I_Display_Celebration_Price = true then cmd.Parameters.Add("@Celebration_Price", 6, 0, "Celebration_Price")
        if I_Display_Celebration_Price = true then cmd.Parameters("@Celebration_Price").Value = SetNull(Celebration_Price)



        cmd.Parameters.Add("@previous_Financial_Information_ID", 8, 0, "previous_Financial_Information_ID")
        cmd.Parameters("@previous_Financial_Information_ID").Value = Me.previous_Financial_Information_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Financial_Information)
        Dim ps As New Generic.List(Of TBL_Financial_Information)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        if Display_Parent_ID = true then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        if Display_Incentives_ID = true then cmd.CommandText = cmd.CommandText & "Incentives_ID,"
        if Display_School_Type = true then cmd.CommandText = cmd.CommandText & "School_Type,"
        if Display_School_Level = true then cmd.CommandText = cmd.CommandText & "School_Level,"
        if Display_School_Fees_Funding_Status = true then cmd.CommandText = cmd.CommandText & "School_Fees_Funding_Status,"
        if Display_School_Fees_Price = true then cmd.CommandText = cmd.CommandText & "School_Fees_Price,"
        if Display_Stationery_Funding_Status = true then cmd.CommandText = cmd.CommandText & "Stationery_Funding_Status,"
        if Display_Stationery_Price = true then cmd.CommandText = cmd.CommandText & "Stationery_Price,"
        if Display_Allowance_Status = true then cmd.CommandText = cmd.CommandText & "Allowance_Status,"
        if Display_Allowance_Price = true then cmd.CommandText = cmd.CommandText & "Allowance_Price,"
        if Display_Transport_Status = true then cmd.CommandText = cmd.CommandText & "Transport_Status,"
        if Display_Transport_Price = true then cmd.CommandText = cmd.CommandText & "Transport_Price,"
        if Display_Accommodation_Status = true then cmd.CommandText = cmd.CommandText & "Accommodation_Status,"
        if Display_Accommodation_Price = true then cmd.CommandText = cmd.CommandText & "Accommodation_Price,"
        if Display_Membership_Status = true then cmd.CommandText = cmd.CommandText & "Membership_Status,"
        if Display_Membership_Price = true then cmd.CommandText = cmd.CommandText & "Membership_Price,"
        if Display_ExternalClasses_Status = true then cmd.CommandText = cmd.CommandText & "ExternalClasses_Status,"
        if Display_ExternalClass_Prices = true then cmd.CommandText = cmd.CommandText & "ExternalClass_Prices,"
        if Display_Gadgets_Status = true then cmd.CommandText = cmd.CommandText & "Gadgets_Status,"
        if Display_Gadgets_Price = true then cmd.CommandText = cmd.CommandText & "Gadgets_Price,"
        if Display_Celebration_Status = true then cmd.CommandText = cmd.CommandText & "Celebration_Status,"
        if Display_Celebration_Price = true then cmd.CommandText = cmd.CommandText & "Celebration_Price,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Financial_Information " & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Financial_Information
            p.Financial_Information_ID = checknull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            if Display_Parent_ID = true then p.Parent_ID = checknull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            if Display_Incentives_ID = true then p.Incentives_ID = checknull(dt.Rows(i)("Incentives_ID"))
            p.I_Display_Incentives_ID = Display_Incentives_ID
            if Display_School_Type = true then p.School_Type = checknull(dt.Rows(i)("School_Type"))
            p.I_Display_School_Type = Display_School_Type
            if Display_School_Level = true then p.School_Level = checknull(dt.Rows(i)("School_Level"))
            p.I_Display_School_Level = Display_School_Level
            if Display_School_Fees_Funding_Status = true then p.School_Fees_Funding_Status = checknull(dt.Rows(i)("School_Fees_Funding_Status"))
            p.I_Display_School_Fees_Funding_Status = Display_School_Fees_Funding_Status
            if Display_School_Fees_Price = true then p.School_Fees_Price = checknull(dt.Rows(i)("School_Fees_Price"))
            p.I_Display_School_Fees_Price = Display_School_Fees_Price
            if Display_Stationery_Funding_Status = true then p.Stationery_Funding_Status = checknull(dt.Rows(i)("Stationery_Funding_Status"))
            p.I_Display_Stationery_Funding_Status = Display_Stationery_Funding_Status
            if Display_Stationery_Price = true then p.Stationery_Price = checknull(dt.Rows(i)("Stationery_Price"))
            p.I_Display_Stationery_Price = Display_Stationery_Price
            if Display_Allowance_Status = true then p.Allowance_Status = checknull(dt.Rows(i)("Allowance_Status"))
            p.I_Display_Allowance_Status = Display_Allowance_Status
            if Display_Allowance_Price = true then p.Allowance_Price = checknull(dt.Rows(i)("Allowance_Price"))
            p.I_Display_Allowance_Price = Display_Allowance_Price
            if Display_Transport_Status = true then p.Transport_Status = checknull(dt.Rows(i)("Transport_Status"))
            p.I_Display_Transport_Status = Display_Transport_Status
            if Display_Transport_Price = true then p.Transport_Price = checknull(dt.Rows(i)("Transport_Price"))
            p.I_Display_Transport_Price = Display_Transport_Price
            if Display_Accommodation_Status = true then p.Accommodation_Status = checknull(dt.Rows(i)("Accommodation_Status"))
            p.I_Display_Accommodation_Status = Display_Accommodation_Status
            if Display_Accommodation_Price = true then p.Accommodation_Price = checknull(dt.Rows(i)("Accommodation_Price"))
            p.I_Display_Accommodation_Price = Display_Accommodation_Price
            if Display_Membership_Status = true then p.Membership_Status = checknull(dt.Rows(i)("Membership_Status"))
            p.I_Display_Membership_Status = Display_Membership_Status
            if Display_Membership_Price = true then p.Membership_Price = checknull(dt.Rows(i)("Membership_Price"))
            p.I_Display_Membership_Price = Display_Membership_Price
            if Display_ExternalClasses_Status = true then p.ExternalClasses_Status = checknull(dt.Rows(i)("ExternalClasses_Status"))
            p.I_Display_ExternalClasses_Status = Display_ExternalClasses_Status
            if Display_ExternalClass_Prices = true then p.ExternalClass_Prices = checknull(dt.Rows(i)("ExternalClass_Prices"))
            p.I_Display_ExternalClass_Prices = Display_ExternalClass_Prices
            if Display_Gadgets_Status = true then p.Gadgets_Status = checknull(dt.Rows(i)("Gadgets_Status"))
            p.I_Display_Gadgets_Status = Display_Gadgets_Status
            if Display_Gadgets_Price = true then p.Gadgets_Price = checknull(dt.Rows(i)("Gadgets_Price"))
            p.I_Display_Gadgets_Price = Display_Gadgets_Price
            if Display_Celebration_Status = true then p.Celebration_Status = checknull(dt.Rows(i)("Celebration_Status"))
            p.I_Display_Celebration_Status = Display_Celebration_Status
            if Display_Celebration_Price = true then p.Celebration_Price = checknull(dt.Rows(i)("Celebration_Price"))
            p.I_Display_Celebration_Price = Display_Celebration_Price
            p.previous_Financial_Information_ID = checknull(dt.Rows(i)("Financial_Information_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Financial_Information)
        Dim ps As New Generic.List(Of TBL_Financial_Information)
        Dim cmd As New sqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Financial_Information_ID from TBL_Financial_Information" & filterstr & " " & sortstr
        Dim pl As New sqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Financial_Information
            p.Financial_Information_ID = checknull(dt.Rows(i)("Financial_Information_ID"))
            p.previous_Financial_Information_ID = checknull(dt.Rows(i)("Financial_Information_ID"))
            p.newinstance = False
            ps.add(p)
        Next
        Return ps
    End Function


End Class