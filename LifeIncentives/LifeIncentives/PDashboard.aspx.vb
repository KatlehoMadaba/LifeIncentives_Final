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
    Public Shared Incentive_Type As New List(Of String)()
    Public Shared Incentive_Increase As New List(Of Single)()
    Public Shared Incentive_Decrease As New List(Of Single)()
    Public Shared Incentive_Amount As New List(Of Single)()


    Dim incentivescobj As New TBL_Incentives


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
    Public Class Parent_User
        Public Property Parent_ID As String
        Public Property Parent_Name As String
        Public Property Parent_Surname As String
        Public Property Email As String
        Public Property Employment As String
        Public Property Child_ID As String
    End Class
    Public Class Incentives
        Public Property Incentives_ID As String
        Public Property Child_ID As String
        Public Property Financial_Information_ID As String
        Public Property Incentive_Type As String
        Public Property Incentive_Increase As Single
        Public Property Incentive_Decrease As Single
        Public Property Incentive_Amount As Single
    End Class


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
        childnameLabel.Text = Parent_Name(0).ToString
        childIDlb.Text = Child_ID(0).ToString
    End Sub
    Protected Sub LoadParentTotal()
        Dim loginSessionId As String = Session("loginSessionId")
        If loginSessionId IsNot Nothing AndAlso Not String.IsNullOrEmpty(loginSessionId.ToString()) Then
            Dim columnNameList1 As List(Of TBL_Incentives) = TBL_Incentives.listall($"Where Child_ID='{loginSessionId}' AND Incentive_Type='ParentTotal'")
            For Each dp As TBL_Incentives In columnNameList1
                Incentive_Amount.Add(dp.Incentive_Amount)
            Next
        End If
        lbParentAmount.Text = Incentive_Amount(0).ToString
    End Sub

    Protected Sub LoadGovermentTotal()
        Dim loginSessionId As String = Session("loginSessionId")
        If loginSessionId IsNot Nothing AndAlso Not String.IsNullOrEmpty(loginSessionId.ToString()) Then
            Dim columnNameList2 As List(Of TBL_Incentives) = TBL_Incentives.listall($"Where Child_ID='{loginSessionId}' AND Incentive_Type='GovermentTotal'")
            For Each pp As TBL_Incentives In columnNameList2
                Incentive_Amount.Add(pp.Incentive_Amount)
            Next
        End If
        govAmountlb.Text = Incentive_Amount(1).ToString
    End Sub

    Protected Sub btnIncParentP_Click(sender As Object, e As EventArgs)
        Dim incAmount As Decimal = 0
        incentivescobj.Incentives_ID = Guid.NewGuid.ToString
        incentivescobj.Child_ID = Session("loginSessionId")
        incentivescobj.Financial_Information_ID = Session("financialId")
        incentivescobj.Incentive_Type = "Increase Parent Incentive"
        incentivescobj.Incentive_Increase = Integer.Parse(txtIncParent.Text)
        incentivescobj.Incentive_Decrease = 0
        incAmount = incentivescobj.Incentive_Increase + incentivescobj.Incentive_Decrease
        incentivescobj.Incentive_Amount = incAmount
        incentivescobj.update()
        lbParentAmount.Text = incAmount
    End Sub

    Protected Sub btnSubPdec_Click1(sender As Object, e As EventArgs)
        Dim decAmount As Decimal = 0
        incentivescobj.Incentives_ID = Guid.NewGuid.ToString
        incentivescobj.Child_ID = Session("loginSessionId")
        incentivescobj.Financial_Information_ID = Session("financialId")
        incentivescobj.Incentive_Type = "Decrease Parent Incentive"
        incentivescobj.Incentive_Increase = "NO"
        incentivescobj.Incentive_Decrease = "YES"
        Decimal.TryParse(txtDecParentP.Text, decAmount)
        incentivescobj.Incentive_Amount = decAmount
        incentivescobj.update()
    End Sub
    Protected Sub btnSubGovIncP_Click(sender As Object, e As EventArgs)
        Dim incAmountG As Decimal = 0
        incentivescobj.Incentives_ID = Guid.NewGuid.ToString
        incentivescobj.Child_ID = Session("loginSessionId")
        incentivescobj.Financial_Information_ID = Session("financialId")
        incentivescobj.Incentive_Type = "Increase Goverment Incentive"
        incentivescobj.Incentive_Increase = "YES"
        incentivescobj.Incentive_Decrease = "NO"
        Decimal.TryParse(txtIncGovP.Text, incAmountG)
        incentivescobj.Incentive_Amount = incAmountG
        incentivescobj.update()
    End Sub

    Protected Sub btnDecGovP_Click(sender As Object, e As EventArgs)
        Dim decAmountG As Decimal = 0
        incentivescobj.Incentives_ID = Guid.NewGuid.ToString
        incentivescobj.Child_ID = Session("loginSessionId")
        incentivescobj.Financial_Information_ID = Session("financialId")
        incentivescobj.Incentive_Type = "Decrease Goverment Incentive"
        incentivescobj.Incentive_Increase = "NO"
        incentivescobj.Incentive_Decrease = "YES"
        Decimal.TryParse(txtDecGovP.Text, decAmountG)
        incentivescobj.Incentive_Amount = decAmountG
        incentivescobj.update()
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


    Protected Sub btnSsubGinc_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubGdec_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnInGovParent_Click(sender As Object, e As EventArgs)

    End Sub


    Protected Sub btnDecParentP_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnApproveReq_Click(sender As Object, e As EventArgs)

    End Sub
End Class