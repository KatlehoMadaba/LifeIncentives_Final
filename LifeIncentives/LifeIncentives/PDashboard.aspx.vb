Public Class PDashboard
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


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadName()
            childIDlb.Text = Session("childID").ToString()
            TotalGov()
            TotalParent()

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
    Public Class Parent_User
        Public Property Parent_ID As String
        Public Property Parent_Name As String
        Public Property Parent_Surname As String
        Public Property Email As String
        Public Property Employment As String
        Public Property Child_ID As String
    End Class


    Protected Sub LoadName()

        Dim childId As String = Session("childID")
        'Dim childObj As TBL_Child_User = TBL_Child_User.load(childId)
        'Debug.WriteLine(childObj.Child_Age)- Displaying a certain users information using theload function 
        'The repeaters are used to dipaly multiple users 

        Dim pName As String = ""
        If childId IsNot Nothing AndAlso Not String.IsNullOrEmpty(childId.ToString()) Then
            Dim columnNameAsList As List(Of TBL_Parent_User) = TBL_Parent_User.listall($"where Child_ID= '{childId}'")
            'childnameLabel.Text = columnNameAsList(0).ToString()
            For Each dp As TBL_Parent_User In columnNameAsList
                Parent_Name.Add(dp.Parent_Name)
            Next
        End If
        childnameLabel.Text = Parent_Name(0).ToString


    End Sub
    Public Class Financial_Information
        Public Property School_Fees_Price As Single
        Public Property Stationery_Price As Single
        Public Property Allowance_Price As Single
        Public Property Transport_Price As Single
        Public Property Membership_Price As Single
        Public Property ExternalClass_Price As Single
        Public Property Gadgets_Price As Single
        Public Property Celebration_Price As Single
    End Class
    Protected Sub TotalGov()
        Dim fi_Id As String = Session("financialId")
        Dim fi As New TBL_Financial_Information
        Dim govTotal As Decimal = 0
        'fi = TBL_Financial_Information.load(fi_Id)

        If fi_Id IsNot Nothing AndAlso Not String.IsNullOrEmpty(fi_Id.ToString()) Then
            Dim columnNameAsList As List(Of TBL_Financial_Information) = TBL_Financial_Information.listall($"where Financial_Information_ID= '{fi_Id}'")
            'Dim columnNameAsList2 As List(Of TBL_Incentives) = TBL_Incentives.listall($"where Incentives_ID= {fi_Id}")
            If Session("Funding_Type") = "Goverment" Then
                Dim objFinancial As TBL_Financial_Information = TBL_Financial_Information.load(fi_Id)
                govTotal = objFinancial.School_Fees_Price
                govAmountlb.Text = govTotal.ToString
            Else
                govAmountlb.Text = govTotal.ToString
            End If

        End If

    End Sub

    Protected Sub TotalParent()
        Dim fi_Id As String = Session("financialId")
        Dim fi As New TBL_Financial_Information
        Dim schoolFeesPrice As Decimal = 0
        Dim parentTotal As Decimal = 0
        If fi_Id IsNot Nothing AndAlso Not String.IsNullOrEmpty(fi_Id.ToString()) Then
            Dim columnNameAsList As List(Of TBL_Financial_Information) = TBL_Financial_Information.listall($"where Financial_Information_ID= '{fi_Id}'")
            Dim objFinancial As TBL_Financial_Information = TBL_Financial_Information.load(fi_Id)
            If Session("Funding_Type") = "Self-Funded" Then
                schoolFeesPrice = objFinancial.School_Fees_Price
            End If
            Dim Accommodation As Decimal = objFinancial.Accommodation_Price
            Dim Stationery_Price As Decimal = objFinancial.Stationery_Price
            Dim Allowance_Price As Decimal = objFinancial.Allowance_Price
            Dim Transport_Price As Decimal = objFinancial.Transport_Price
            Dim Accommodation_Price As Decimal = objFinancial.Accommodation_Price
            Dim Membership_Price As Decimal = objFinancial.Membership_Price
            Dim ExternalClass_Prices As Decimal = objFinancial.ExternalClass_Prices
            Dim Gadgets_Price As Decimal = objFinancial.Gadgets_Price
            Dim Celebration_Price As Decimal = objFinancial.Celebration_Price
            parentTotal = Stationery_Price + Allowance_Price + Transport_Price + Accommodation_Price + Membership_Price + ExternalClass_Prices + Gadgets_Price + Celebration_Price + schoolFeesPrice
            lbParentAmount.Text = parentTotal.ToString()
        End If
    End Sub

    Protected Sub btnPdashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPtransaction_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPgoals_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Unnamed_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPprofile_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPIncParent_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPDecParent_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGDecParent_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGIncParent_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubPInc_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubPDec_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubGInc_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubGDec_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPIncreseParent_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPDecParent_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGIncParent_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGDecParent_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubPinc_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubPdec_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSsubGinc_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubGdec_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnInGovParent_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubGovIncP_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnDecGovP_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnIncParentP_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnDecParentP_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnApproveReq_Click(sender As Object, e As EventArgs)

    End Sub
End Class