Imports System.Data.SqlClient

Public Class TaskItem
    Public Property Category As String
    Public Property Task As String
    Public Property Price As Integer
    Public Property NumDays As Integer

End Class


Partial Public Class Parent_Goals
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CalculateTotalAmount()
        End If
    End Sub

    Protected Sub GridView1_RowDeleted(ByVal sender As Object, ByVal e As GridViewDeletedEventArgs) Handles GridView1.RowDeleted
        GridView1.DataBind()
        CalculateTotalAmount()
    End Sub


    Private Sub CalculateTotalAmount()
        Dim totalAmount As Decimal = 0

        For Each row As GridViewRow In GridView1.Rows
            If row.RowType = DataControlRowType.DataRow Then
                Dim amount As Decimal = 0
                If Decimal.TryParse(row.Cells(5).Text, amount) Then
                    totalAmount += amount
                End If
            End If
        Next

        ' Display the total amount somewhere, for example in a Label
        lblTotalAmount.Text = "Total Amount: R " & totalAmount.ToString("N2")
    End Sub


    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged

        ' Check if any row is selected
        If GridView2.SelectedIndex >= 0 Then
            ' Access the data from the selected row
            Dim selectedCategory As String = GridView2.SelectedRow.Cells(0).Text
            Dim selectedTask As String = GridView2.SelectedRow.Cells(1).Text
            Dim selectedAmount As Integer = GridView2.SelectedRow.Cells(2).Text
            Dim selectedDays As Integer = GridView2.SelectedRow.Cells(3).Text

            GridView2.SelectedIndex = -1

            txtCat.Text = selectedCategory
            txtDes.Text = selectedTask
            txtPrice.Text = selectedAmount
            txtDays.Text = selecteddays

        End If
    End Sub


    Dim sg As New TBL_Set_Goals

    Protected Sub Add(sender As Object, e As EventArgs)

        If Not IsDescriptionExists(txtDes.Text) Then

            sg.Set_Goals_ID = Guid.NewGuid.ToString
            sg.Category = txtCat.Text
            sg.StartDateTime = DateTime.Now
            sg.Description = txtDes.Text
            sg.Amount = txtPrice.Text
            sg.TimePeriod = txtDays.Text

            Dim currentDate As DateTime = DateTime.Now
            sg.EndDateTime = currentDate.AddDays(sg.TimePeriod)
            sg.Status = "Selected"
            sg.update()
            GridView1.DataBind()
            CalculateTotalAmount()
        End If

    End Sub

    Protected Sub Submit(sender As Object, e As EventArgs)

        Dim cols As List(Of TBL_Set_Goals) = TBL_Set_Goals.listall($" where Status='Selected'") ' retrieve each row as a list. specify which rows you want in the ( )
        For Each sg As TBL_Set_Goals In cols ' loop through each row
            sg.Status = "Incomplete" ' assign value to specific variable
            sg.update() ' update the database
            GridView1.DataBind() ' update the gridview
            CalculateTotalAmount() ' ignore
        Next

    End Sub

    Private Function IsDescriptionExists(description As String) As Boolean
        For Each row As GridViewRow In GridView1.Rows
            If row.RowType = DataControlRowType.DataRow Then
                If row.Cells(3).Text = description Then
                    Return True ' Return True if the description exists
                End If
            End If
        Next

        Return False ' Return False if the description doesn't exist
    End Function


End Class
