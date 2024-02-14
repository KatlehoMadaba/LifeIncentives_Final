Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail
Imports Microsoft.VisualBasic.FileIO

Public Class RevisionSchedule
    Public revisonDate As DateTime
    Public revisionStage As String

End Class


Public Class genfunctions
    Public Shared dtsettings As New DataSet
    Public Shared apppath As String
    Public Shared connectstr As String
    Public Shared eod_report As String
    Public Shared eod_user As String
    Public Shared eod_running As Boolean
    Public Shared eod_conn As SqlConnection
    Public Shared eod_trans As SqlTransaction
    Public Shared eod_percent_done As Decimal
    Public Shared CSV_dir As String = HttpContext.Current.Server.MapPath("~/CSV")

    Shared Sub initi(ByVal apppath As String)
        Try
            genfunctions.apppath = apppath
            genfunctions.dtsettings.ReadXmlSchema(apppath & "\" & "appsettings.xsd")
            genfunctions.dtsettings.ReadXml(apppath & "\" & "appsettings.xml")
            connectstr = "Data Source=" & dtsettings.Tables("gensettings").Rows(0)("dbserver") & ";Initial Catalog=" & dtsettings.Tables("gensettings").Rows(0)("dbname") & ";Persist Security Info=True;"
            connectstr = connectstr & "User ID=" & dtsettings.Tables("gensettings").Rows(0)("dbuserid") & ";"
            Dim password As String = dtsettings.Tables("gensettings").Rows(0)("dbpassword")
            connectstr = connectstr & "Password=" & password & ";"

        Catch ex As Exception
            LogException(ex)
        End Try
    End Sub
    Public Shared Sub LogException(ByVal ex As Exception)
        Dim nrow As DataRow = dtsettings.Tables("exceptions").NewRow()
        nrow("DATA") = ex.ToString
        nrow("DATETIMEOCCURED") = Now
        If Not ex.InnerException Is Nothing Then
            nrow("INNEREXCEPTION_DATA") = ex.InnerException.ToString
        End If
        dtsettings.Tables("exceptions").Rows.Add(nrow)
        dtsettings.WriteXml(apppath & "\" & "appsettings.xml")
    End Sub

    Public Shared Sub LogExceptionToTxt(exc As Exception, source As String)
        Dim logfile As String = "~/App_Errors/ErrorLog.txt"
        logfile = HttpContext.Current.Server.MapPath(logfile)

        Dim sw As StreamWriter = New StreamWriter(logfile, True)
        sw.WriteLine("********** {0} **********", DateTime.Now)

        If Not IsNothing(exc.InnerException) Then
            sw.Write("Inner Exception Type: ")
            sw.WriteLine(exc.InnerException.GetType().ToString())
            sw.Write("Inner Exception: ")
            sw.WriteLine(exc.InnerException.Message)
            sw.Write("Inner Source: ")
            sw.WriteLine(exc.InnerException.Source)
            If Not IsNothing(exc.InnerException.StackTrace) Then
                sw.WriteLine("Inner Stack Trace: ")
                sw.WriteLine(exc.InnerException.StackTrace)
            End If
        End If

        sw.Write("Exception Type: ")
        sw.WriteLine(exc.GetType().ToString())
        sw.WriteLine("Exception: " + exc.Message)
        sw.WriteLine("Source: " + source)
        sw.WriteLine("Stack Trace: ")

        If Not IsNothing(exc.StackTrace) Then
            sw.WriteLine(exc.StackTrace)
            sw.WriteLine()
        End If
        sw.Close()
    End Sub

    Shared Sub SendEmail(ByVal mailto As String, ByVal subject As String, ByVal body As String)
        Dim smtpservername As String = dtsettings.Tables("mailsettings").Rows(0)("smtpserverip")
        Dim smtpserverport As String = dtsettings.Tables("mailsettings").Rows(0)("smtpserverport")
        Dim smtpfrom As String = dtsettings.Tables("mailsettings").Rows(0)("smtpfrom")
        Dim smail As New SmtpClient
        smail.Port = smtpserverport
        smail.Host = smtpservername
        smail.Send(smtpfrom, mailto, subject, body)
    End Sub
    Shared Sub SendEmailWithAttachment(ByVal mailto As String, ByVal cc As String, ByVal bcc As String, ByVal subject As String, ByVal body As String, ByVal attachments As Generic.List(Of String))
        Dim smail As New SmtpClient, i As Integer
        Dim smessage As New MailMessage
        If Not attachments Is Nothing Then
            For i = 0 To attachments.Count - 1
                smessage.Attachments.Add(New Attachment(attachments(i)))
            Next
        End If

        smail.Port = dtsettings.Tables("mailsettings").Rows(0)("smtpserverport")
        smail.Host = dtsettings.Tables("mailsettings").Rows(0)("smtpserverip")
        'smail.UseDefaultCredentials = False
        'smail.EnableSsl = True

        smail.DeliveryMethod = SmtpDeliveryMethod.Network
        smail.Credentials = New System.Net.NetworkCredential("adeibijola@yahoo.ca", "password")
        'smail.Credentials = New System.Net.NetworkCredential("adeibijola@yahoo.ca", "password")
        smessage.Body = body
        smessage.To.Add(mailto)
        If Not (ENTITY.checkNull(bcc) Is Nothing) Then
            smessage.Bcc.Add(bcc)
        End If
        If Not (ENTITY.checkNull(bcc) Is Nothing) Then
            smessage.CC.Add(cc)
        End If
        smessage.From = New System.Net.Mail.MailAddress(dtsettings.Tables("mailsettings").Rows(0)("replyto"), dtsettings.Tables("mailsettings").Rows(0)("smtpfrom"))
        smessage.IsBodyHtml = False
        smessage.Subject = subject
        smessage.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess

        smail.Send(smessage)
        smessage.Dispose()
    End Sub

    Public Shared Function LoadSingleLineItems(filename As String) As ArrayList
        Dim retval As New ArrayList

        Dim field As String()
        Dim delimiter As String = "\n"
        Using parser As New TextFieldParser(filename)
            parser.SetDelimiters(delimiter)
            While Not parser.EndOfData
                ' Read in the fields for the current line
                field = parser.ReadFields()
                ' Add code here to use data in fields variable.

                retval.Add(field(0))
            End While
        End Using
        Return retval
    End Function



End Class
