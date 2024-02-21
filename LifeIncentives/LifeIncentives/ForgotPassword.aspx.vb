Public Class ForgotPassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SendSimpleMail()


        Dim Message As New Mail.MailMessage
        Dim utilisateur As String
        Dim pass As String
        Dim server As String

        utilisateur = ConfigurationSettings.AppSettings("StmpUtilisateur")
        pass = ConfigurationSettings.AppSettings("SmtpPassword")
        server = ConfigurationSettings.AppSettings("SmtpServer")

        Message.From = "superman@gmail.com"
        Message.To = "superman@gmail.com"
        Message.Subject = "test"
        Message.Body = "salut je voulais savoir comment tu allais"


        Message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
        Message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", utilisateur)
        Message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtppassworld", pass)
        SmtpMail.SmtpServer = server
        Try
            SmtpMail.Send(Message)
        Catch ex As Exception
            Label1.Text = ex.Message
        End Try


    End Sub
End Class