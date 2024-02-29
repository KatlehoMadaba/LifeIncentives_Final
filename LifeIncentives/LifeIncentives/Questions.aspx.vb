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
        Else
            PayFees.Visible = False
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

    Protected Sub SubmitClick(sender As Object, e As EventArgs)


        fi.Financial_Information_ID = Guid.NewGuid.ToString

        fi.School_Level = RadioButtonList6.SelectedValue
        fi.School_Type = RadioButtonList12.SelectedValue

        fi.School_Fees_Funding_Status = RadioButtonList2.SelectedValue
        If fi.School_Fees_Funding_Status = "Yes" Then
            fi.School_Fees_Price = TextBox6.Text

        Else
            fi.School_Fees_Price = 0
        End If

        fi.Stationery_Funding_Status = RadioButtonList3.SelectedValue
        If fi.Stationery_Funding_Status = "Yes" Then
            fi.Stationery_Price = TextBox7.Text

        Else
            fi.Stationery_Price = 0
        End If

        fi.Allowance_Status = RadioButtonList4.SelectedValue
        If fi.Allowance_Status = "Yes" Then
            fi.Allowance_Price = TextBox8.Text
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
            fi.Accommodation_Price = TextBox10.Text

        Else
            fi.Accommodation_Price = 0
        End If

        fi.Membership_Status = RadioButtonList8.SelectedValue
        If fi.Membership_Status = "Yes" Then
            fi.Membership_Price = TextBox11.Text

        Else
            fi.Membership_Price = 0
        End If

        fi.ExternalClasses_Status = RadioButtonList9.SelectedValue
        If fi.ExternalClasses_Status = "Yes" Then
            fi.ExternalClass_Prices = TextBox12.Text

        Else
            fi.ExternalClass_Prices = 0
        End If

        fi.Gadgets_Status = RadioButtonList10.SelectedValue
        If fi.Gadgets_Status = "Yes" Then
            fi.Gadgets_Price = TextBox13.Text

        Else
            fi.Gadgets_Price = 0
        End If

        fi.Celebration_Status = RadioButtonList11.SelectedValue
        If fi.Celebration_Status = "Yes" Then
            fi.Celebration_Price = TextBox14.Text

        Else
            fi.Celebration_Price = 0
        End If

        fi.update()

        Response.Redirect("parentLogin.aspx")

    End Sub




End Class
