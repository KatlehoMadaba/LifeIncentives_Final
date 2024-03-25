Imports System.Data.SqlClient

Public Class childDashboard
    Inherits System.Web.UI.Page

    Public Shared Parent_ID As New List(Of String)()
    Public Shared Parent_Name As New List(Of String)()
    Public Shared Parent_Surname As New List(Of String)()
    Public Shared Email As New List(Of String)()
    Public Shared Password As New List(Of String)()
    Public Shared Employment As New List(Of String)()
    Public Shared Child_ID As New List(Of String)()
    Public Shared Financial_Information_ID As New List(Of String)()
    Public Shared Incentives_ID As New List(Of String)()
    Public Shared School_Type As New List(Of String)()
    Public Shared School_Level As New List(Of String)()
    Public Shared School_Fees_Funding_Status As New List(Of String)()
    Public Shared School_Fees_Price As New List(Of Single)()
    Public Shared Stationery_Funding_Status As New List(Of String)()
    Public Shared Stationery_Price As New List(Of Single)()
    Public Shared Allowance_Status As New List(Of String)()
    Public Shared Allowance_Price As New List(Of Single)()
    Public Shared Transport_Status As New List(Of String)()
    Public Shared Transport_Price As New List(Of Single)()
    Public Shared Accommodation_Status As New List(Of String)()
    Public Shared Accommodation_Price As New List(Of Single)()
    Public Shared Membership_Status As New List(Of String)()
    Public Shared Membership_Price As New List(Of Single)()
    Public Shared ExternalClasses_Status As New List(Of String)()
    Public Shared ExternalClass_Prices As New List(Of Single)()
    Public Shared Gadgets_Status As New List(Of String)()
    Public Shared Gadgets_Price As New List(Of Single)()
    Public Shared Celebration_Status As New List(Of String)()
    Public Shared Celebration_Price As New List(Of Single)()
    Public Shared Incentive_Type As New List(Of String)()
    Public Shared Incentive_Increase As New List(Of Single)()
    Public Shared Incentive_Decrease As New List(Of Single)()
    Public Shared Incentive_Amount As New List(Of Single)()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadName()
            LoadParentTotal()
            LoadGovermentTotal()
        End If
        If Not IsPostBack Then
            Parent_ID.Clear() 'Removing duplicates  there will be additional duplicates 
            Parent_Name.Clear()
            Parent_Surname.Clear()
            Email.Clear()
            Password.Clear()
            Employment.Clear()
            Child_ID.Clear()
            Financial_Information_ID.Clear()

        End If
    End Sub


    Protected Sub LoadName()
        Dim loginSessionId As String = Session("loginSessionId")
        'Dim childObj As TBL_Child_User = TBL_Child_User.load(childId)
        'Debug.WriteLine(childObj.Child_Age)- Displaying a certain users information using theload function 
        'The repeaters are used to dipaly multiple users 
        Dim pName As String = ""
        If loginSessionId IsNot Nothing AndAlso Not String.IsNullOrEmpty(loginSessionId.ToString()) Then
            Dim columnNameAsList As List(Of TBL_Parent_User) = TBL_Parent_User.listall($"where Child_ID= '{loginSessionId}'")
            'childnameLabel.Text = columnNameAsList(0).ToString()
            For Each dp As TBL_Parent_User In columnNameAsList
                Parent_Name.Add(dp.Parent_Name)
                Child_ID.Add(dp.Child_ID)
            Next
        End If
        lbChildName.Text = Parent_Name(0).ToString
        lbChildID.Text = Child_ID(0).ToString
    End Sub
    Protected Function LoadParentTotal() As Decimal
        Dim parentTotal As Decimal = 0
        Dim loginSessionId As String = Session("loginSessionId")
        If loginSessionId IsNot Nothing AndAlso Not String.IsNullOrEmpty(loginSessionId.ToString()) Then
            Dim columnNameList1 As List(Of TBL_Incentives) = TBL_Incentives.listall($"Where Child_ID='{loginSessionId}' AND Incentive_Type='ParentTotal'")
            For Each dp As TBL_Incentives In columnNameList1
                Incentive_Amount.Add(dp.Incentive_Amount)
            Next
        End If
        lbParentAmount.Text = Incentive_Amount(0).ToString
        Return parentTotal = Incentive_Amount(0).ToString
    End Function
    Protected Function LoadGovermentTotal() As Decimal
        Dim loginSessionId As String = Session("loginSessionId")
        Dim govTotal As Decimal = 0
        If loginSessionId IsNot Nothing AndAlso Not String.IsNullOrEmpty(loginSessionId.ToString()) Then
            Dim columnNameList2 As List(Of TBL_Incentives) = TBL_Incentives.listall($"Where Child_ID='{loginSessionId}' AND Incentive_Type='GovermentTotal'")
            For Each pp As TBL_Incentives In columnNameList2
                Incentive_Amount.Add(pp.Incentive_Amount)
            Next
        End If
        govAmountlb.Text = Incentive_Amount(1).ToString
        Return govTotal = Incentive_Amount(1).ToString
    End Function


End Class