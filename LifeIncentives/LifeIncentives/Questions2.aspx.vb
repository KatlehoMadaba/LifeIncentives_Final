Imports System.Web.UI

Public Class Questions
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If IsNothing(HttpContext.Current.Session("conn")) Then
            HttpContext.Current.Session("conn") = DBInterface.connect(ConfigurationManager.ConnectionStrings("conn2").ConnectionString)
        End If
    End Sub


    Protected Sub RadioButtonList2_SelectedIndexChanged1(sender As Object, e As EventArgs)
        If RadioButtonList2.SelectedValue = "Yes" Then
            PayFees.Visible = True
            NoPayFees.Visible = False
            Session("Funding_Type") = "Self-Funded"
        ElseIf RadioButtonList2.SelectedValue = "No" Then
            NoPayFees.Visible = True
            PayFees.Visible = False
        End If
    End Sub
    Protected Sub RadioButtonList7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList7.SelectedIndexChanged
        If RadioButtonList7.SelectedValue = "Bursary" Then
            Session("Funding_Type") = "Bursary"
        ElseIf RadioButtonList7.SelectedValue = "Goverment" Then
            Session("Funding_Type") = "Goverment"
        End If
    End Sub

    Protected Sub RadioButtonList3_SelectedIndexChanged1(sender As Object, e As EventArgs)
        If RadioButtonList3.SelectedValue = "Yes" Then
            Stationary.Visible = True
        Else
            Stationary.Visible = False
        End If
    End Sub

    Protected Sub RadioButtonList4_SelectedIndexChanged(sender As Object, e As EventArgs)
        If RadioButtonList4.SelectedValue = "Yes" Then
            allowance.Visible = True
        Else
            allowance.Visible = False
        End If
    End Sub

    Protected Sub RadioButtonList5_SelectedIndexChanged1(sender As Object, e As EventArgs)
        If RadioButtonList5.SelectedValue = "Yes" Then
            Transport.Visible = True
        Else
            Transport.Visible = False
        End If
    End Sub

    Protected Sub RadioButtonList13_SelectedIndexChanged1(sender As Object, e As EventArgs)
        If RadioButtonList13.SelectedValue = "Yes" Then
            accommodtion.Visible = True
        Else
            accommodtion.Visible = False
        End If
    End Sub



    Protected Sub RadioButtonList8_SelectedIndexChanged(sender As Object, e As EventArgs)
        If RadioButtonList8.SelectedValue = "Yes" Then
            memberships.Visible = True
        Else
            memberships.Visible = False
        End If
    End Sub

    Protected Sub RadioButtonList9_SelectedIndexChanged(sender As Object, e As EventArgs)
        If RadioButtonList9.SelectedValue = "Yes" Then
            classes.Visible = True
        Else
            classes.Visible = False
        End If
    End Sub


    Protected Sub RadioButtonList10_SelectedIndexChanged(sender As Object, e As EventArgs)
        If RadioButtonList10.SelectedValue = "Yes" Then
            gadgets.Visible = True
        Else
            gadgets.Visible = False
        End If
    End Sub

    Protected Sub RadioButtonList11_SelectedIndexChanged(sender As Object, e As EventArgs)
        If RadioButtonList11.SelectedValue = "Yes" Then
            celebrations.Visible = True
        Else
            celebrations.Visible = False
        End If
    End Sub

    Dim fi As New TBL_Financial_Information

    ' fi.Financial_Information_ID = Guid.NewGuid.ToString

    'Session("childID") = cu.Child_ID ' Session created 

    'Session("financialId") = fi.Child_ID ' Session created 
    Protected Sub submitQ_Click(sender As Object, e As EventArgs)
        fi.Financial_Information_ID = Guid.NewGuid.ToString()
        Session("financialId") = fi.Financial_Information_ID ' Session created' 
        fi.Parent_ID = Session("Parent_ID")
        fi.Child_ID = Session("childID")
        fi.School_Type = RadioButtonList12.SelectedValue
        fi.School_Level = RadioButtonList6.SelectedValue


        fi.School_Fees_Funding_Status = RadioButtonList2.SelectedValue
        If fi.School_Fees_Funding_Status = "Yes" Then
            fi.School_Fees_Price = Double.Parse(TextBox6.Text.Trim())
            Session("Funding_Type") = "Self-Funded"

        ElseIf fi.School_Fees_Funding_Status = "No" Then
            Select Case RadioButtonList7.SelectedValue
                Case "Bursary"
                    fi.School_Fees_Price = 0
                    Session("Funding_Type") = "Bursary"
                Case "Goverment"
                    fi.School_Fees_Price = 33026
                    Session("Funding_Type") = "Goverment"
            End Select
        End If

        fi.Stationery_Funding_Status = RadioButtonList3.SelectedValue
        If fi.Stationery_Funding_Status = "Yes" Then
            fi.Stationery_Price = Double.Parse(TextBox7.Text.Trim())

        Else
            fi.Stationery_Price = 0
        End If

        fi.Allowance_Status = RadioButtonList4.SelectedValue
        If fi.Allowance_Status = "Yes" Then
            fi.Allowance_Price = Double.Parse(TextBox8.Text.Trim())
        Else
            fi.Allowance_Price = 0
        End If

        fi.Transport_Status = RadioButtonList5.SelectedValue
        If fi.Transport_Status = "Yes" Then
            fi.Transport_Price = TextBox9.Text

        Else
            fi.Transport_Price = 0
        End If

        fi.Accommodation_Status = RadioButtonList13.SelectedValue
        If fi.Accommodation_Status = "Yes" Then
            fi.Accommodation_Price = Double.Parse(TextBox10.Text.Trim())

        Else
            fi.Accommodation_Price = 0
        End If

        fi.Membership_Status = RadioButtonList8.SelectedValue
        If fi.Membership_Status = "Yes" Then
            fi.Membership_Price = Double.Parse(TextBox11.Text.Trim())

        Else
            fi.Membership_Price = 0
        End If

        fi.ExternalClasses_Status = RadioButtonList9.SelectedValue
        If fi.ExternalClasses_Status = "Yes" Then
            fi.ExternalClass_Prices = Double.Parse(TextBox12.Text.Trim())

        Else
            fi.ExternalClass_Prices = 0
        End If

        fi.Gadgets_Status = RadioButtonList10.SelectedValue
        If fi.Gadgets_Status = "Yes" Then
            fi.Gadgets_Price = Double.Parse(TextBox13.Text.Trim())

        Else
            fi.Gadgets_Price = 0
        End If

        fi.Celebration_Status = RadioButtonList11.SelectedValue
        If fi.Celebration_Status = "Yes" Then
            fi.Celebration_Price = Double.Parse(TextBox14.Text.Trim())

        Else
            fi.Celebration_Price = 0
        End If

        fi.update()
    End Sub
    Protected Sub Submit_Click(sender As Object, e As EventArgs)
        fi.Financial_Information_ID = Guid.NewGuid.ToString()
        Session("financialId") = fi.Financial_Information_ID ' Session created' 
        fi.Parent_ID = Session("Parent_ID")
        fi.Child_ID = Session("childID")
        fi.School_Type = RadioButtonList12.SelectedValue
        fi.School_Level = RadioButtonList6.SelectedValue


        fi.School_Fees_Funding_Status = RadioButtonList2.SelectedValue
        If fi.School_Fees_Funding_Status = "Yes" Then
            fi.School_Fees_Price = Double.Parse(TextBox6.Text.Trim())
            Session("Funding_Type") = "Self-Funded"

        ElseIf fi.School_Fees_Funding_Status = "No" Then
            Select Case RadioButtonList7.SelectedValue
                Case "Bursary"
                    fi.School_Fees_Price = 0
                    Session("Funding_Type") = "Bursary"
                Case "Goverment"
                    fi.School_Fees_Price = 33026
                    Session("Funding_Type") = "Goverment"
            End Select
        End If

        fi.Stationery_Funding_Status = RadioButtonList3.SelectedValue
        If fi.Stationery_Funding_Status = "Yes" Then
            fi.Stationery_Price = Double.Parse(TextBox7.Text.Trim())

        Else
            fi.Stationery_Price = 0
        End If

        fi.Allowance_Status = RadioButtonList4.SelectedValue
        If fi.Allowance_Status = "Yes" Then
            fi.Allowance_Price = Double.Parse(TextBox8.Text.Trim())
        Else
            fi.Allowance_Price = 0
        End If

        fi.Transport_Status = RadioButtonList5.SelectedValue
        If fi.Transport_Status = "Yes" Then
            fi.Transport_Price = TextBox9.Text

        Else
            fi.Transport_Price = 0
        End If

        fi.Accommodation_Status = RadioButtonList13.SelectedValue
        If fi.Accommodation_Status = "Yes" Then
            fi.Accommodation_Price = Double.Parse(TextBox10.Text.Trim())

        Else
            fi.Accommodation_Price = 0
        End If

        fi.Membership_Status = RadioButtonList8.SelectedValue
        If fi.Membership_Status = "Yes" Then
            fi.Membership_Price = Double.Parse(TextBox11.Text.Trim())

        Else
            fi.Membership_Price = 0
        End If

        fi.ExternalClasses_Status = RadioButtonList9.SelectedValue
        If fi.ExternalClasses_Status = "Yes" Then
            fi.ExternalClass_Prices = Double.Parse(TextBox12.Text.Trim())

        Else
            fi.ExternalClass_Prices = 0
        End If

        fi.Gadgets_Status = RadioButtonList10.SelectedValue
        If fi.Gadgets_Status = "Yes" Then
            fi.Gadgets_Price = Double.Parse(TextBox13.Text.Trim())

        Else
            fi.Gadgets_Price = 0
        End If

        fi.Celebration_Status = RadioButtonList11.SelectedValue
        If fi.Celebration_Status = "Yes" Then
            fi.Celebration_Price = Double.Parse(TextBox14.Text.Trim())

        Else
            fi.Celebration_Price = 0
        End If

        fi.update()

        Response.Redirect("SetYearlyGoals.aspx")
    End Sub
    Protected Sub SubmitClick(sender As Object, e As EventArgs)


    End Sub

    Protected Sub CalculateTotal()

    End Sub
    Protected Sub YearlyGoal(sender As Object, e As EventArgs)

    End Sub

    Protected Sub RadioBntfunded_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)

    End Sub
End Class