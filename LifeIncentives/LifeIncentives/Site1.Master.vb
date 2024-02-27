Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsNothing(HttpContext.Current.Session("conn")) Then
            HttpContext.Current.Session("conn") = DBInterface.connect(ConfigurationManager.ConnectionStrings("conn2").ConnectionString)
        End If
    End Sub

    Protected Sub btnHome_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnParentDash_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Pdashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Ptransactions_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub PGoals_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPdashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPtransactions_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPgoals_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPGoals_Click1(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnPprofile_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGdashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGtransations_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGgoals_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnGprofile_Click(sender As Object, e As EventArgs)

    End Sub
End Class