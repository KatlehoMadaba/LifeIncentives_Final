Imports System.Net
Imports System.Net.Mail


Public Class ForgotPassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnForgetPassword_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim recipient As String = txtEmail.Text
        Dim subject As String = "Forget Password"
        Dim body As String = "This is just a test run for the email recovery method"


        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("glenmulangs@gmail.com")
            mail.[To].Add(recipient)
            mail.Subject = subject
            mail.Body = body

            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential("glenmulangs@gmail.com", "vxsw eqbq jrar bstt")
            smtpServer.EnableSsl = True

            smtpServer.Send(mail)

            MsgBox("Email sent successfully.")
        Catch ex As Exception
            MsgBox("Failed to send email. Error: " & ex.Message)
        End Try

    End Sub

End Class