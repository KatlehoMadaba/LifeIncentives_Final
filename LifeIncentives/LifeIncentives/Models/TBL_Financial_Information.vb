Imports System.Data.SqlClient

Public Class TBL_Financial_Information
    Inherits ENTITY

    Public Shared Display_Financial_Information_ID As Boolean = True
    Public Shared Display_Parent_ID As Boolean = True
    Public Shared Display_Child_ID As Boolean = True
    Public Shared Display_School_Type As Boolean = True
    Public Shared Display_School_Level As Boolean = True
    Public Shared Display_School_Fees_Funding_Status As Boolean = True
    Public Shared Display_School_Fees_Price As Boolean = True
    Public Shared Display_Stationery_Funding_Status As Boolean = True
    Public Shared Display_Stationery_Price As Boolean = True
    Public Shared Display_Allowance_Status As Boolean = True
    Public Shared Display_Allowance_Price As Boolean = True
    Public Shared Display_Transport_Status As Boolean = True
    Public Shared Display_Transport_Price As Boolean = True
    Public Shared Display_Accommodation_Status As Boolean = True
    Public Shared Display_Accommodation_Price As Boolean = True
    Public Shared Display_Membership_Status As Boolean = True
    Public Shared Display_Membership_Price As Boolean = True
    Public Shared Display_ExternalClasses_Status As Boolean = True
    Public Shared Display_ExternalClass_Prices As Boolean = True
    Public Shared Display_Gadgets_Status As Boolean = True
    Public Shared Display_Gadgets_Price As Boolean = True
    Public Shared Display_Celebration_Status As Boolean = True
    Public Shared Display_Celebration_Price As Boolean = True

    Private I_Display_Financial_Information_ID As Boolean = True
    Private I_Display_Parent_ID As Boolean = True
    Private I_Display_Child_ID As Boolean = True
    Private I_Display_School_Type As Boolean = True
    Private I_Display_School_Level As Boolean = True
    Private I_Display_School_Fees_Funding_Status As Boolean = True
    Private I_Display_School_Fees_Price As Boolean = True
    Private I_Display_Stationery_Funding_Status As Boolean = True
    Private I_Display_Stationery_Price As Boolean = True
    Private I_Display_Allowance_Status As Boolean = True
    Private I_Display_Allowance_Price As Boolean = True
    Private I_Display_Transport_Status As Boolean = True
    Private I_Display_Transport_Price As Boolean = True
    Private I_Display_Accommodation_Status As Boolean = True
    Private I_Display_Accommodation_Price As Boolean = True
    Private I_Display_Membership_Status As Boolean = True
    Private I_Display_Membership_Price As Boolean = True
    Private I_Display_ExternalClasses_Status As Boolean = True
    Private I_Display_ExternalClass_Prices As Boolean = True
    Private I_Display_Gadgets_Status As Boolean = True
    Private I_Display_Gadgets_Price As Boolean = True
    Private I_Display_Celebration_Status As Boolean = True
    Private I_Display_Celebration_Price As Boolean = True

    Public previous_Financial_Information_ID As System.String

    Public Financial_Information_ID As System.String
    Public Parent_ID As System.String
    Public Child_ID As System.String
    Public School_Type As System.String
    Public School_Level As System.String
    Public School_Fees_Funding_Status As System.String
    Public School_Fees_Price As Nullable(Of System.Double)
    Public Stationery_Funding_Status As System.String
    Public Stationery_Price As Nullable(Of System.Double)
    Public Allowance_Status As System.String
    Public Allowance_Price As Nullable(Of System.Double)
    Public Transport_Status As System.String
    Public Transport_Price As Nullable(Of System.Double)
    Public Accommodation_Status As System.String
    Public Accommodation_Price As Nullable(Of System.Double)
    Public Membership_Status As System.String
    Public Membership_Price As Nullable(Of System.Double)
    Public ExternalClasses_Status As System.String
    Public ExternalClass_Prices As Nullable(Of System.Double)
    Public Gadgets_Status As System.String
    Public Gadgets_Price As Nullable(Of System.Double)
    Public Celebration_Status As System.String
    Public Celebration_Price As Nullable(Of System.Double)
    Private newinstance As Boolean = True

    Shared Sub Set_Display_Field_All(display_flag As Boolean)
        Display_Financial_Information_ID = display_flag
        Display_Parent_ID = display_flag
        Display_Child_ID = display_flag
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
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into TBL_Financial_Information (Financial_Information_ID,Parent_ID,Child_ID,School_Type,School_Level,School_Fees_Funding_Status,School_Fees_Price,Stationery_Funding_Status,Stationery_Price,Allowance_Status,Allowance_Price,Transport_Status,Transport_Price,Accommodation_Status,Accommodation_Price,Membership_Status,Membership_Price,ExternalClasses_Status,ExternalClass_Prices,Gadgets_Status,Gadgets_Price,Celebration_Status,Celebration_Price)"
        cmd.CommandText = cmd.CommandText & "values(@Financial_Information_ID,@Parent_ID,@Child_ID,@School_Type,@School_Level,@School_Fees_Funding_Status,@School_Fees_Price,@Stationery_Funding_Status,@Stationery_Price,@Allowance_Status,@Allowance_Price,@Transport_Status,@Transport_Price,@Accommodation_Status,@Accommodation_Price,@Membership_Status,@Membership_Price,@ExternalClasses_Status,@ExternalClass_Prices,@Gadgets_Status,@Gadgets_Price,@Celebration_Status,@Celebration_Price)"
        cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        cmd.Parameters("@Financial_Information_ID").Value = setNull(Financial_Information_ID)
        cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        cmd.Parameters("@Parent_ID").Value = setNull(Parent_ID)
        cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        cmd.Parameters("@Child_ID").Value = setNull(Child_ID)
        cmd.Parameters.Add("@School_Type", 22, 10, "School_Type")
        cmd.Parameters("@School_Type").Value = setNull(School_Type)
        cmd.Parameters.Add("@School_Level", 22, 10, "School_Level")
        cmd.Parameters("@School_Level").Value = setNull(School_Level)
        cmd.Parameters.Add("@School_Fees_Funding_Status", 22, 10, "School_Fees_Funding_Status")
        cmd.Parameters("@School_Fees_Funding_Status").Value = setNull(School_Fees_Funding_Status)
        cmd.Parameters.Add("@School_Fees_Price", 6, 0, "School_Fees_Price")
        cmd.Parameters("@School_Fees_Price").Value = setNull(School_Fees_Price)
        cmd.Parameters.Add("@Stationery_Funding_Status", 22, 10, "Stationery_Funding_Status")
        cmd.Parameters("@Stationery_Funding_Status").Value = setNull(Stationery_Funding_Status)
        cmd.Parameters.Add("@Stationery_Price", 6, 0, "Stationery_Price")
        cmd.Parameters("@Stationery_Price").Value = setNull(Stationery_Price)
        cmd.Parameters.Add("@Allowance_Status", 22, 10, "Allowance_Status")
        cmd.Parameters("@Allowance_Status").Value = setNull(Allowance_Status)
        cmd.Parameters.Add("@Allowance_Price", 6, 0, "Allowance_Price")
        cmd.Parameters("@Allowance_Price").Value = setNull(Allowance_Price)
        cmd.Parameters.Add("@Transport_Status", 22, 10, "Transport_Status")
        cmd.Parameters("@Transport_Status").Value = setNull(Transport_Status)
        cmd.Parameters.Add("@Transport_Price", 6, 0, "Transport_Price")
        cmd.Parameters("@Transport_Price").Value = setNull(Transport_Price)
        cmd.Parameters.Add("@Accommodation_Status", 22, 10, "Accommodation_Status")
        cmd.Parameters("@Accommodation_Status").Value = setNull(Accommodation_Status)
        cmd.Parameters.Add("@Accommodation_Price", 6, 0, "Accommodation_Price")
        cmd.Parameters("@Accommodation_Price").Value = setNull(Accommodation_Price)
        cmd.Parameters.Add("@Membership_Status", 22, 10, "Membership_Status")
        cmd.Parameters("@Membership_Status").Value = setNull(Membership_Status)
        cmd.Parameters.Add("@Membership_Price", 6, 0, "Membership_Price")
        cmd.Parameters("@Membership_Price").Value = setNull(Membership_Price)
        cmd.Parameters.Add("@ExternalClasses_Status", 22, 10, "ExternalClasses_Status")
        cmd.Parameters("@ExternalClasses_Status").Value = setNull(ExternalClasses_Status)
        cmd.Parameters.Add("@ExternalClass_Prices", 6, 0, "ExternalClass_Prices")
        cmd.Parameters("@ExternalClass_Prices").Value = setNull(ExternalClass_Prices)
        cmd.Parameters.Add("@Gadgets_Status", 22, 10, "Gadgets_Status")
        cmd.Parameters("@Gadgets_Status").Value = setNull(Gadgets_Status)
        cmd.Parameters.Add("@Gadgets_Price", 6, 0, "Gadgets_Price")
        cmd.Parameters("@Gadgets_Price").Value = setNull(Gadgets_Price)
        cmd.Parameters.Add("@Celebration_Status", 22, 10, "Celebration_Status")
        cmd.Parameters("@Celebration_Status").Value = setNull(Celebration_Status)
        cmd.Parameters.Add("@Celebration_Price", 6, 0, "Celebration_Price")
        cmd.Parameters("@Celebration_Price").Value = setNull(Celebration_Price)


        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Sub delete()
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from TBL_Financial_Information where Financial_Information_ID=@previous_Financial_Information_ID"
        cmd.Parameters.Add("@previous_Financial_Information_ID", 22, 255, "previous_Financial_Information_ID")
        cmd.Parameters("@previous_Financial_Information_ID").Value = Me.previous_Financial_Information_ID

        cmd.ExecuteNonQuery()
    End Sub


    Shared Function load(Financial_Information_ID As System.Int32) As TBL_Financial_Information
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        If Display_Parent_ID = True Then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        If Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_School_Type = True Then cmd.CommandText = cmd.CommandText & "School_Type,"
        If Display_School_Level = True Then cmd.CommandText = cmd.CommandText & "School_Level,"
        If Display_School_Fees_Funding_Status = True Then cmd.CommandText = cmd.CommandText & "School_Fees_Funding_Status,"
        If Display_School_Fees_Price = True Then cmd.CommandText = cmd.CommandText & "School_Fees_Price,"
        If Display_Stationery_Funding_Status = True Then cmd.CommandText = cmd.CommandText & "Stationery_Funding_Status,"
        If Display_Stationery_Price = True Then cmd.CommandText = cmd.CommandText & "Stationery_Price,"
        If Display_Allowance_Status = True Then cmd.CommandText = cmd.CommandText & "Allowance_Status,"
        If Display_Allowance_Price = True Then cmd.CommandText = cmd.CommandText & "Allowance_Price,"
        If Display_Transport_Status = True Then cmd.CommandText = cmd.CommandText & "Transport_Status,"
        If Display_Transport_Price = True Then cmd.CommandText = cmd.CommandText & "Transport_Price,"
        If Display_Accommodation_Status = True Then cmd.CommandText = cmd.CommandText & "Accommodation_Status,"
        If Display_Accommodation_Price = True Then cmd.CommandText = cmd.CommandText & "Accommodation_Price,"
        If Display_Membership_Status = True Then cmd.CommandText = cmd.CommandText & "Membership_Status,"
        If Display_Membership_Price = True Then cmd.CommandText = cmd.CommandText & "Membership_Price,"
        If Display_ExternalClasses_Status = True Then cmd.CommandText = cmd.CommandText & "ExternalClasses_Status,"
        If Display_ExternalClass_Prices = True Then cmd.CommandText = cmd.CommandText & "ExternalClass_Prices,"
        If Display_Gadgets_Status = True Then cmd.CommandText = cmd.CommandText & "Gadgets_Status,"
        If Display_Gadgets_Price = True Then cmd.CommandText = cmd.CommandText & "Gadgets_Price,"
        If Display_Celebration_Status = True Then cmd.CommandText = cmd.CommandText & "Celebration_Status,"
        If Display_Celebration_Price = True Then cmd.CommandText = cmd.CommandText & "Celebration_Price,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Financial_Information where Financial_Information_ID=@Financial_Information_ID"
        cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        cmd.Parameters("@Financial_Information_ID").Value = Financial_Information_ID

        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        Dim p As New TBL_Financial_Information
        For i = 0 To dt.Rows.Count - 1
            p.Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            If Display_Parent_ID = True Then p.Parent_ID = checkNull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            If Display_Child_ID = True Then p.Child_ID = checkNull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_School_Type = True Then p.School_Type = checkNull(dt.Rows(i)("School_Type"))
            p.I_Display_School_Type = Display_School_Type
            If Display_School_Level = True Then p.School_Level = checkNull(dt.Rows(i)("School_Level"))
            p.I_Display_School_Level = Display_School_Level
            If Display_School_Fees_Funding_Status = True Then p.School_Fees_Funding_Status = checkNull(dt.Rows(i)("School_Fees_Funding_Status"))
            p.I_Display_School_Fees_Funding_Status = Display_School_Fees_Funding_Status
            If Display_School_Fees_Price = True Then p.School_Fees_Price = checkNull(dt.Rows(i)("School_Fees_Price"))
            p.I_Display_School_Fees_Price = Display_School_Fees_Price
            If Display_Stationery_Funding_Status = True Then p.Stationery_Funding_Status = checkNull(dt.Rows(i)("Stationery_Funding_Status"))
            p.I_Display_Stationery_Funding_Status = Display_Stationery_Funding_Status
            If Display_Stationery_Price = True Then p.Stationery_Price = checkNull(dt.Rows(i)("Stationery_Price"))
            p.I_Display_Stationery_Price = Display_Stationery_Price
            If Display_Allowance_Status = True Then p.Allowance_Status = checkNull(dt.Rows(i)("Allowance_Status"))
            p.I_Display_Allowance_Status = Display_Allowance_Status
            If Display_Allowance_Price = True Then p.Allowance_Price = checkNull(dt.Rows(i)("Allowance_Price"))
            p.I_Display_Allowance_Price = Display_Allowance_Price
            If Display_Transport_Status = True Then p.Transport_Status = checkNull(dt.Rows(i)("Transport_Status"))
            p.I_Display_Transport_Status = Display_Transport_Status
            If Display_Transport_Price = True Then p.Transport_Price = checkNull(dt.Rows(i)("Transport_Price"))
            p.I_Display_Transport_Price = Display_Transport_Price
            If Display_Accommodation_Status = True Then p.Accommodation_Status = checkNull(dt.Rows(i)("Accommodation_Status"))
            p.I_Display_Accommodation_Status = Display_Accommodation_Status
            If Display_Accommodation_Price = True Then p.Accommodation_Price = checkNull(dt.Rows(i)("Accommodation_Price"))
            p.I_Display_Accommodation_Price = Display_Accommodation_Price
            If Display_Membership_Status = True Then p.Membership_Status = checkNull(dt.Rows(i)("Membership_Status"))
            p.I_Display_Membership_Status = Display_Membership_Status
            If Display_Membership_Price = True Then p.Membership_Price = checkNull(dt.Rows(i)("Membership_Price"))
            p.I_Display_Membership_Price = Display_Membership_Price
            If Display_ExternalClasses_Status = True Then p.ExternalClasses_Status = checkNull(dt.Rows(i)("ExternalClasses_Status"))
            p.I_Display_ExternalClasses_Status = Display_ExternalClasses_Status
            If Display_ExternalClass_Prices = True Then p.ExternalClass_Prices = checkNull(dt.Rows(i)("ExternalClass_Prices"))
            p.I_Display_ExternalClass_Prices = Display_ExternalClass_Prices
            If Display_Gadgets_Status = True Then p.Gadgets_Status = checkNull(dt.Rows(i)("Gadgets_Status"))
            p.I_Display_Gadgets_Status = Display_Gadgets_Status
            If Display_Gadgets_Price = True Then p.Gadgets_Price = checkNull(dt.Rows(i)("Gadgets_Price"))
            p.I_Display_Gadgets_Price = Display_Gadgets_Price
            If Display_Celebration_Status = True Then p.Celebration_Status = checkNull(dt.Rows(i)("Celebration_Status"))
            p.I_Display_Celebration_Status = Display_Celebration_Status
            If Display_Celebration_Price = True Then p.Celebration_Price = checkNull(dt.Rows(i)("Celebration_Price"))
            p.I_Display_Celebration_Price = Display_Celebration_Price
            p.previous_Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
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
        cmd.CommandText = "update TBL_Financial_Information set "
        cmd.CommandText = cmd.CommandText & " Financial_Information_ID=@Financial_Information_ID,"
        If I_Display_Parent_ID = True Then cmd.CommandText = cmd.CommandText & " Parent_ID=@Parent_ID,"
        If I_Display_Child_ID = True Then cmd.CommandText = cmd.CommandText & " Child_ID=@Child_ID,"
        If I_Display_School_Type = True Then cmd.CommandText = cmd.CommandText & " School_Type=@School_Type,"
        If I_Display_School_Level = True Then cmd.CommandText = cmd.CommandText & " School_Level=@School_Level,"
        If I_Display_School_Fees_Funding_Status = True Then cmd.CommandText = cmd.CommandText & " School_Fees_Funding_Status=@School_Fees_Funding_Status,"
        If I_Display_School_Fees_Price = True Then cmd.CommandText = cmd.CommandText & " School_Fees_Price=@School_Fees_Price,"
        If I_Display_Stationery_Funding_Status = True Then cmd.CommandText = cmd.CommandText & " Stationery_Funding_Status=@Stationery_Funding_Status,"
        If I_Display_Stationery_Price = True Then cmd.CommandText = cmd.CommandText & " Stationery_Price=@Stationery_Price,"
        If I_Display_Allowance_Status = True Then cmd.CommandText = cmd.CommandText & " Allowance_Status=@Allowance_Status,"
        If I_Display_Allowance_Price = True Then cmd.CommandText = cmd.CommandText & " Allowance_Price=@Allowance_Price,"
        If I_Display_Transport_Status = True Then cmd.CommandText = cmd.CommandText & " Transport_Status=@Transport_Status,"
        If I_Display_Transport_Price = True Then cmd.CommandText = cmd.CommandText & " Transport_Price=@Transport_Price,"
        If I_Display_Accommodation_Status = True Then cmd.CommandText = cmd.CommandText & " Accommodation_Status=@Accommodation_Status,"
        If I_Display_Accommodation_Price = True Then cmd.CommandText = cmd.CommandText & " Accommodation_Price=@Accommodation_Price,"
        If I_Display_Membership_Status = True Then cmd.CommandText = cmd.CommandText & " Membership_Status=@Membership_Status,"
        If I_Display_Membership_Price = True Then cmd.CommandText = cmd.CommandText & " Membership_Price=@Membership_Price,"
        If I_Display_ExternalClasses_Status = True Then cmd.CommandText = cmd.CommandText & " ExternalClasses_Status=@ExternalClasses_Status,"
        If I_Display_ExternalClass_Prices = True Then cmd.CommandText = cmd.CommandText & " ExternalClass_Prices=@ExternalClass_Prices,"
        If I_Display_Gadgets_Status = True Then cmd.CommandText = cmd.CommandText & " Gadgets_Status=@Gadgets_Status,"
        If I_Display_Gadgets_Price = True Then cmd.CommandText = cmd.CommandText & " Gadgets_Price=@Gadgets_Price,"
        If I_Display_Celebration_Status = True Then cmd.CommandText = cmd.CommandText & " Celebration_Status=@Celebration_Status,"
        If I_Display_Celebration_Price = True Then cmd.CommandText = cmd.CommandText & " Celebration_Price=@Celebration_Price,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " where Financial_Information_ID=@previous_Financial_Information_ID"


        cmd.Parameters.Add("@Financial_Information_ID", 22, 255, "Financial_Information_ID")
        cmd.Parameters("@Financial_Information_ID").Value = setNull(Financial_Information_ID)

        If I_Display_Parent_ID = True Then cmd.Parameters.Add("@Parent_ID", 22, 255, "Parent_ID")
        If I_Display_Parent_ID = True Then cmd.Parameters("@Parent_ID").Value = setNull(Parent_ID)

        If I_Display_Child_ID = True Then cmd.Parameters.Add("@Child_ID", 22, 255, "Child_ID")
        If I_Display_Child_ID = True Then cmd.Parameters("@Child_ID").Value = setNull(Child_ID)

        If I_Display_School_Type = True Then cmd.Parameters.Add("@School_Type", 22, 10, "School_Type")
        If I_Display_School_Type = True Then cmd.Parameters("@School_Type").Value = setNull(School_Type)

        If I_Display_School_Level = True Then cmd.Parameters.Add("@School_Level", 22, 10, "School_Level")
        If I_Display_School_Level = True Then cmd.Parameters("@School_Level").Value = setNull(School_Level)

        If I_Display_School_Fees_Funding_Status = True Then cmd.Parameters.Add("@School_Fees_Funding_Status", 22, 10, "School_Fees_Funding_Status")
        If I_Display_School_Fees_Funding_Status = True Then cmd.Parameters("@School_Fees_Funding_Status").Value = setNull(School_Fees_Funding_Status)

        If I_Display_School_Fees_Price = True Then cmd.Parameters.Add("@School_Fees_Price", 6, 0, "School_Fees_Price")
        If I_Display_School_Fees_Price = True Then cmd.Parameters("@School_Fees_Price").Value = setNull(School_Fees_Price)

        If I_Display_Stationery_Funding_Status = True Then cmd.Parameters.Add("@Stationery_Funding_Status", 22, 10, "Stationery_Funding_Status")
        If I_Display_Stationery_Funding_Status = True Then cmd.Parameters("@Stationery_Funding_Status").Value = setNull(Stationery_Funding_Status)

        If I_Display_Stationery_Price = True Then cmd.Parameters.Add("@Stationery_Price", 6, 0, "Stationery_Price")
        If I_Display_Stationery_Price = True Then cmd.Parameters("@Stationery_Price").Value = setNull(Stationery_Price)

        If I_Display_Allowance_Status = True Then cmd.Parameters.Add("@Allowance_Status", 22, 10, "Allowance_Status")
        If I_Display_Allowance_Status = True Then cmd.Parameters("@Allowance_Status").Value = setNull(Allowance_Status)

        If I_Display_Allowance_Price = True Then cmd.Parameters.Add("@Allowance_Price", 6, 0, "Allowance_Price")
        If I_Display_Allowance_Price = True Then cmd.Parameters("@Allowance_Price").Value = setNull(Allowance_Price)

        If I_Display_Transport_Status = True Then cmd.Parameters.Add("@Transport_Status", 22, 10, "Transport_Status")
        If I_Display_Transport_Status = True Then cmd.Parameters("@Transport_Status").Value = setNull(Transport_Status)

        If I_Display_Transport_Price = True Then cmd.Parameters.Add("@Transport_Price", 6, 0, "Transport_Price")
        If I_Display_Transport_Price = True Then cmd.Parameters("@Transport_Price").Value = setNull(Transport_Price)

        If I_Display_Accommodation_Status = True Then cmd.Parameters.Add("@Accommodation_Status", 22, 10, "Accommodation_Status")
        If I_Display_Accommodation_Status = True Then cmd.Parameters("@Accommodation_Status").Value = setNull(Accommodation_Status)

        If I_Display_Accommodation_Price = True Then cmd.Parameters.Add("@Accommodation_Price", 6, 0, "Accommodation_Price")
        If I_Display_Accommodation_Price = True Then cmd.Parameters("@Accommodation_Price").Value = setNull(Accommodation_Price)

        If I_Display_Membership_Status = True Then cmd.Parameters.Add("@Membership_Status", 22, 10, "Membership_Status")
        If I_Display_Membership_Status = True Then cmd.Parameters("@Membership_Status").Value = setNull(Membership_Status)

        If I_Display_Membership_Price = True Then cmd.Parameters.Add("@Membership_Price", 6, 0, "Membership_Price")
        If I_Display_Membership_Price = True Then cmd.Parameters("@Membership_Price").Value = setNull(Membership_Price)

        If I_Display_ExternalClasses_Status = True Then cmd.Parameters.Add("@ExternalClasses_Status", 22, 10, "ExternalClasses_Status")
        If I_Display_ExternalClasses_Status = True Then cmd.Parameters("@ExternalClasses_Status").Value = setNull(ExternalClasses_Status)

        If I_Display_ExternalClass_Prices = True Then cmd.Parameters.Add("@ExternalClass_Prices", 6, 0, "ExternalClass_Prices")
        If I_Display_ExternalClass_Prices = True Then cmd.Parameters("@ExternalClass_Prices").Value = setNull(ExternalClass_Prices)

        If I_Display_Gadgets_Status = True Then cmd.Parameters.Add("@Gadgets_Status", 22, 10, "Gadgets_Status")
        If I_Display_Gadgets_Status = True Then cmd.Parameters("@Gadgets_Status").Value = setNull(Gadgets_Status)

        If I_Display_Gadgets_Price = True Then cmd.Parameters.Add("@Gadgets_Price", 6, 0, "Gadgets_Price")
        If I_Display_Gadgets_Price = True Then cmd.Parameters("@Gadgets_Price").Value = setNull(Gadgets_Price)

        If I_Display_Celebration_Status = True Then cmd.Parameters.Add("@Celebration_Status", 22, 10, "Celebration_Status")
        If I_Display_Celebration_Status = True Then cmd.Parameters("@Celebration_Status").Value = setNull(Celebration_Status)

        If I_Display_Celebration_Price = True Then cmd.Parameters.Add("@Celebration_Price", 6, 0, "Celebration_Price")
        If I_Display_Celebration_Price = True Then cmd.Parameters("@Celebration_Price").Value = setNull(Celebration_Price)



        cmd.Parameters.Add("@previous_Financial_Information_ID", 8, 0, "previous_Financial_Information_ID")
        cmd.Parameters("@previous_Financial_Information_ID").Value = Me.previous_Financial_Information_ID



        cmd.ExecuteNonQuery()
        newinstance = False
    End Sub


    Shared Function listall(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Financial_Information)
        Dim ps As New Generic.List(Of TBL_Financial_Information)
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select "
        cmd.CommandText = cmd.CommandText & "Financial_Information_ID,"
        If Display_Parent_ID = True Then cmd.CommandText = cmd.CommandText & "Parent_ID,"
        If Display_Parent_ID = True Then cmd.CommandText = cmd.CommandText & "Child_ID,"
        If Display_School_Type = True Then cmd.CommandText = cmd.CommandText & "School_Type,"
        If Display_School_Level = True Then cmd.CommandText = cmd.CommandText & "School_Level,"
        If Display_School_Fees_Funding_Status = True Then cmd.CommandText = cmd.CommandText & "School_Fees_Funding_Status,"
        If Display_School_Fees_Price = True Then cmd.CommandText = cmd.CommandText & "School_Fees_Price,"
        If Display_Stationery_Funding_Status = True Then cmd.CommandText = cmd.CommandText & "Stationery_Funding_Status,"
        If Display_Stationery_Price = True Then cmd.CommandText = cmd.CommandText & "Stationery_Price,"
        If Display_Allowance_Status = True Then cmd.CommandText = cmd.CommandText & "Allowance_Status,"
        If Display_Allowance_Price = True Then cmd.CommandText = cmd.CommandText & "Allowance_Price,"
        If Display_Transport_Status = True Then cmd.CommandText = cmd.CommandText & "Transport_Status,"
        If Display_Transport_Price = True Then cmd.CommandText = cmd.CommandText & "Transport_Price,"
        If Display_Accommodation_Status = True Then cmd.CommandText = cmd.CommandText & "Accommodation_Status,"
        If Display_Accommodation_Price = True Then cmd.CommandText = cmd.CommandText & "Accommodation_Price,"
        If Display_Membership_Status = True Then cmd.CommandText = cmd.CommandText & "Membership_Status,"
        If Display_Membership_Price = True Then cmd.CommandText = cmd.CommandText & "Membership_Price,"
        If Display_ExternalClasses_Status = True Then cmd.CommandText = cmd.CommandText & "ExternalClasses_Status,"
        If Display_ExternalClass_Prices = True Then cmd.CommandText = cmd.CommandText & "ExternalClass_Prices,"
        If Display_Gadgets_Status = True Then cmd.CommandText = cmd.CommandText & "Gadgets_Status,"
        If Display_Gadgets_Price = True Then cmd.CommandText = cmd.CommandText & "Gadgets_Price,"
        If Display_Celebration_Status = True Then cmd.CommandText = cmd.CommandText & "Celebration_Status,"
        If Display_Celebration_Price = True Then cmd.CommandText = cmd.CommandText & "Celebration_Price,"
        cmd.CommandText = cmd.CommandText.Substring(0, cmd.CommandText.Length - 1)
        cmd.CommandText = cmd.CommandText & " from TBL_Financial_Information " & filterstr & " " & sortstr
        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Financial_Information
            p.Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.I_Display_Financial_Information_ID = Display_Financial_Information_ID
            If Display_Parent_ID = True Then p.Parent_ID = checkNull(dt.Rows(i)("Parent_ID"))
            p.I_Display_Parent_ID = Display_Parent_ID
            If Display_Child_ID = True Then p.Child_ID = checkNull(dt.Rows(i)("Child_ID"))
            p.I_Display_Child_ID = Display_Child_ID
            If Display_School_Type = True Then p.School_Type = checkNull(dt.Rows(i)("School_Type"))
            p.I_Display_School_Type = Display_School_Type
            If Display_School_Level = True Then p.School_Level = checkNull(dt.Rows(i)("School_Level"))
            p.I_Display_School_Level = Display_School_Level
            If Display_School_Fees_Funding_Status = True Then p.School_Fees_Funding_Status = checkNull(dt.Rows(i)("School_Fees_Funding_Status"))
            p.I_Display_School_Fees_Funding_Status = Display_School_Fees_Funding_Status
            If Display_School_Fees_Price = True Then p.School_Fees_Price = checkNull(dt.Rows(i)("School_Fees_Price"))
            p.I_Display_School_Fees_Price = Display_School_Fees_Price
            If Display_Stationery_Funding_Status = True Then p.Stationery_Funding_Status = checkNull(dt.Rows(i)("Stationery_Funding_Status"))
            p.I_Display_Stationery_Funding_Status = Display_Stationery_Funding_Status
            If Display_Stationery_Price = True Then p.Stationery_Price = checkNull(dt.Rows(i)("Stationery_Price"))
            p.I_Display_Stationery_Price = Display_Stationery_Price
            If Display_Allowance_Status = True Then p.Allowance_Status = checkNull(dt.Rows(i)("Allowance_Status"))
            p.I_Display_Allowance_Status = Display_Allowance_Status
            If Display_Allowance_Price = True Then p.Allowance_Price = checkNull(dt.Rows(i)("Allowance_Price"))
            p.I_Display_Allowance_Price = Display_Allowance_Price
            If Display_Transport_Status = True Then p.Transport_Status = checkNull(dt.Rows(i)("Transport_Status"))
            p.I_Display_Transport_Status = Display_Transport_Status
            If Display_Transport_Price = True Then p.Transport_Price = checkNull(dt.Rows(i)("Transport_Price"))
            p.I_Display_Transport_Price = Display_Transport_Price
            If Display_Accommodation_Status = True Then p.Accommodation_Status = checkNull(dt.Rows(i)("Accommodation_Status"))
            p.I_Display_Accommodation_Status = Display_Accommodation_Status
            If Display_Accommodation_Price = True Then p.Accommodation_Price = checkNull(dt.Rows(i)("Accommodation_Price"))
            p.I_Display_Accommodation_Price = Display_Accommodation_Price
            If Display_Membership_Status = True Then p.Membership_Status = checkNull(dt.Rows(i)("Membership_Status"))
            p.I_Display_Membership_Status = Display_Membership_Status
            If Display_Membership_Price = True Then p.Membership_Price = checkNull(dt.Rows(i)("Membership_Price"))
            p.I_Display_Membership_Price = Display_Membership_Price
            If Display_ExternalClasses_Status = True Then p.ExternalClasses_Status = checkNull(dt.Rows(i)("ExternalClasses_Status"))
            p.I_Display_ExternalClasses_Status = Display_ExternalClasses_Status
            If Display_ExternalClass_Prices = True Then p.ExternalClass_Prices = checkNull(dt.Rows(i)("ExternalClass_Prices"))
            p.I_Display_ExternalClass_Prices = Display_ExternalClass_Prices
            If Display_Gadgets_Status = True Then p.Gadgets_Status = checkNull(dt.Rows(i)("Gadgets_Status"))
            p.I_Display_Gadgets_Status = Display_Gadgets_Status
            If Display_Gadgets_Price = True Then p.Gadgets_Price = checkNull(dt.Rows(i)("Gadgets_Price"))
            p.I_Display_Gadgets_Price = Display_Gadgets_Price
            If Display_Celebration_Status = True Then p.Celebration_Status = checkNull(dt.Rows(i)("Celebration_Status"))
            p.I_Display_Celebration_Status = Display_Celebration_Status
            If Display_Celebration_Price = True Then p.Celebration_Price = checkNull(dt.Rows(i)("Celebration_Price"))
            p.I_Display_Celebration_Price = Display_Celebration_Price
            p.previous_Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.newinstance = False
            ps.Add(p)
        Next
        Return ps
    End Function


    Shared Function listallPKOnly(Optional ByVal filterstr As String = Nothing, Optional ByVal sortstr As String = Nothing) As System.Collections.Generic.List(Of TBL_Financial_Information)
        Dim ps As New Generic.List(Of TBL_Financial_Information)
        Dim cmd As New SqlCommand
        cmd.Connection = HttpContext.Current.Session("conn")
        If Not IsNothing(HttpContext.Current.Session("trans")) Then cmd.Transaction = HttpContext.Current.Session("trans")
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select Financial_Information_ID from TBL_Financial_Information" & filterstr & " " & sortstr
        Dim pl As New SqlDataAdapter, dt As New DataTable, i As Integer
        pl.SelectCommand = cmd
        pl.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            Dim p As New TBL_Financial_Information
            p.Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.previous_Financial_Information_ID = checkNull(dt.Rows(i)("Financial_Information_ID"))
            p.newinstance = False
            ps.Add(p)
        Next
        Return ps
    End Function


End Class