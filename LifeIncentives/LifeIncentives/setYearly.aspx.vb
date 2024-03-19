Public Class setYearly
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            TotalGov()
            TotalParentAmount()
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
    Public Class Financial_Information
        Public Property Financial_Infotmation_ID As String
        Public Property Child_ID As String
        Public Property School_Fees_Price As Single
        Public Property Stationery_Price As Single
        Public Property Allowance_Price As Single
        Public Property Transport_Price As Single
        Public Property Membership_Price As Single
        Public Property ExternalClass_Price As Single
        Public Property Gadgets_Price As Single
        Public Property Celebration_Price As Single
    End Class

    Protected Function TotalGov() As Decimal
        Dim govTotal As Decimal = 0
        Dim fi_Id As String = Session("financialId")
        If fi_Id IsNot Nothing AndAlso Not String.IsNullOrEmpty(fi_Id.ToString()) Then
            Dim columnNameAsList As List(Of TBL_Financial_Information) = TBL_Financial_Information.listall($"where Financial_Information_ID= '{fi_Id}'")
            Dim objFinancial As TBL_Financial_Information = TBL_Financial_Information.load(fi_Id)
            Dim schoolFeesStatus = objFinancial.School_Fees_Funding_Status
            Dim schoolFeesPrice = objFinancial.School_Fees_Price
            If schoolFeesStatus = "No" And Session("Funding_Type") = "Goverment" Then
                govTotal = 33026
            Else
                govTotal = 0
            End If
            totalGovlb.Text = govTotal.ToString
        End If
        Return govTotal
    End Function
    Protected Function TotalParentAmount() As Decimal
        Dim parentTotal As Decimal = 0
        Dim fi_Id As String = Session("financialId")
        Dim fi As New TBL_Financial_Information
        Dim schoolFeesPrice As Decimal = 0
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
        End If
        totalParentlb.Text = parentTotal.ToString
        Return parentTotal
    End Function

    Public Class Incentives
        Public Property Incentives_ID As String
        Public Property Child_ID As String
        Public Property Financial_Information_ID As String
        Public Property Incentive_Type As String
        Public Property Incentive_Increase As Single
        Public Property Incentive_Decrease As Single
        Public Property Incentive_Amount As Single
    End Class
    Public Class Set_Goals
        Public Property Set_Goals_ID As String
        Public Property Child_ID As String
        Public Property Parent_ID As String
        Public Property Incentive_ID As String
        Public Property StartDateTime As String
        Public Property EndDateTime As String
        Public Property Category As String
        Public Property Description As String
        Public Property TimePeriod As String
        Public Property Amount As Single
        Public Property Status As String
    End Class




    Protected Sub gTotalInsert()
        Dim incentivescobj As New TBL_Incentives
        incentivescobj.Incentives_ID = Guid.NewGuid.ToString
        Session("govIncentiveID") = incentivescobj.Incentives_ID
        incentivescobj.Child_ID = Session("childID")
        incentivescobj.Financial_Information_ID = Session("financialId")
        incentivescobj.Incentive_Type = "ParentTotal"
        incentivescobj.Incentive_Increase = 0
        incentivescobj.Incentive_Decrease = 0
        incentivescobj.Incentive_Amount = TotalParentAmount()
        incentivescobj.update()
    End Sub
    'Inserting the goverment total In incentive table
    Protected Sub pTotalInsert()
        Dim incentivescobj2 As New TBL_Incentives
        incentivescobj2.Incentives_ID = Guid.NewGuid.ToString
        Session("parIncentiveID") = incentivescobj2.Incentives_ID
        incentivescobj2.Child_ID = Session("childID")
        incentivescobj2.Financial_Information_ID = Session("financialId")
        incentivescobj2.Incentive_Type = "GovermentTotal"
        incentivescobj2.Incentive_Increase = 0
        incentivescobj2.Incentive_Decrease = 0
        incentivescobj2.Incentive_Amount = TotalGov()
        incentivescobj2.update()
    End Sub
    Protected Sub btngovermentGoalsub_Click()
        gTotalInsert()
        Dim objsetG As New TBL_Set_Goals
        objsetG.Set_Goals_ID = Guid.NewGuid.ToString
        objsetG.Child_ID = Session("childID")
        objsetG.Parent_ID = Session("Parent_ID")
        objsetG.Incentives_ID = Session("govIncentiveID")
        'objsetG.StartDateTime
        'objsetG.EndDateTime
        objsetG.Category = "GovermentYearGoal"
        objsetG.Description = "GovermentYearGoal"
        'objsetG.TimePeriod=
        objsetG.Amount = govermentYeargoal()
        objsetG.Status = "first"
        objsetG.update()
    End Sub
    Protected Function parentYeargoal() As Decimal
        Dim parSelectedValue As Integer = percentOptionsGov.SelectedValue
        Dim parPercentage As Decimal = parSelectedValue / 100
        Dim parParentYgoal As Decimal = TotalParentAmount() * parPercentage
        Return parParentYgoal
    End Function
    Protected Function govermentYeargoal() As Decimal
        Dim govSelectedValue As Integer = percentOptionsPar.SelectedValue
        Dim govPercentage As Decimal = govSelectedValue / 100
        Dim govParentYgoal As Decimal = TotalGov() * govPercentage
        Return govParentYgoal
    End Function
    Protected Sub btnparentGoalsub_Click()
        pTotalInsert()
        Dim objsetG2 As New TBL_Set_Goals
        objsetG2.Set_Goals_ID = Guid.NewGuid.ToString
        objsetG2.Child_ID = Session("childID")
        objsetG2.Parent_ID = Session("Parent_ID")
        objsetG2.Incentives_ID = Session("parIncentiveID")
        objsetG2.StartDateTime = Date.Today
        objsetG2.StartDateTime = Date.Today.AddYears(1)
        objsetG2.Category = "ParentYearGoal"
        objsetG2.Description = "ParentYearGoal"
        objsetG2.Amount = parentYeargoal()
        objsetG2.Status = "first"
        objsetG2.update()
    End Sub

    Protected Sub btnNext_Click(sender As Object, e As EventArgs)
        Response.Redirect("pLogin.aspx")
    End Sub
End Class