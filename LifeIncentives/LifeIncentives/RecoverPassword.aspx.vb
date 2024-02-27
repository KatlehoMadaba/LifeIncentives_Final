Imports System.Net.Mail

Public Class RecoverPassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSendEmail_Click(sender As Object, e As EventArgs)
        Try
            Dim fromAddress As New MailAddress("enochessien05@gmail.com", "eNOCH")
            Dim toAddress As New MailAddress("drewnjokejr@gmail.com", "drew")
            Dim subject As String = "Test Email"
            Dim body As String = "This is a test email sent from VB.NET."

            Dim smtpClient As New SmtpClient()
            smtpClient.Host = "smtp.gmail.com" ' Gmail SMTP server address
            smtpClient.Port = 587 ' Gmail SMTP port
            smtpClient.EnableSsl = True ' Enable SSL/TLS
            smtpClient.UseDefaultCredentials = False ' Disable default credentials
            smtpClient.Credentials = New System.Net.NetworkCredential("enochessien05@gmail.com", "") ' Gmail email credentials

            Dim message As New MailMessage(fromAddress, toAddress)
            message.Subject = subject
            message.Body = body

            smtpClient.Send(message)
            ' Optionally, you can provide feedback to the user here
            Response.Write("Email sent successfully.")
        Catch ex As Exception
            ' Optionally, you can provide feedback to the user here
            Response.Write("Error sending email: " & ex.Message)
        End Try
    End Sub
End Class


