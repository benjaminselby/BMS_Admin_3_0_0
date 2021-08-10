Imports System.Data.SqlClient
Imports System.Configuration


Public Class EmailAbsences

    Private minimumFormHeight = 300

    Private sanctionsToNotify As New DataSet

    Private Sub Email_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try

            Using synergyConn As New SqlConnection(ConfigurationManager.ConnectionStrings("Synergy").ConnectionString)

                Using absenteeListAdp As New SqlDataAdapter(
                        ConfigurationManager.AppSettings("GetAbsencesForNotificationsProc"), synergyConn)

                    absenteeListAdp.SelectCommand.CommandType = CommandType.StoredProcedure

                    synergyConn.Open()
                    absenteeListAdp.Fill(sanctionsToNotify)
                    synergyConn.Close()

                    absenteeListDgv.DataSource = sanctionsToNotify.Tables(0)

                End Using
            End Using

            For i As Integer = 0 To absenteeListDgv.Columns.Count - 1
                absenteeListDgv.Columns(i).ReadOnly = True
                absenteeListDgv.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            With absenteeListDgv
                .Columns(0).Visible = False     ' DateOfBooking
                .Columns(1).Visible = True      ' Sanction Date
                .Columns(2).Visible = False     ' StaffReason
                .Columns(3).Visible = False     ' Completed
                .Columns(4).Visible = False     ' Removed
                .Columns(5).Visible = False     ' Present
                .Columns(6).Visible = False     ' StaffId
                .Columns(7).Visible = True      ' StaffName
                .Columns(8).Visible = False     ' StaffEmail
                .Columns(9).Visible = False     ' StudentId
                .Columns(10).Visible = True     ' StudentName
                .Columns(11).Visible = True     ' StudentTutorGroup
                .Columns(12).Visible = True     ' StudentYearLevel
                .Columns(13).Visible = True     ' Sanction Code
                .Columns(14).Visible = True     ' HoyName
                .Columns(15).Visible = False    ' HoyEmail
                .Columns(16).Visible = False    ' Sanction record sequence number.
            End With

            absenteeListDgv.Width = absenteeListDgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 1
            absenteeListDgv.Height = absenteeListDgv.Rows.GetRowsHeight(DataGridViewElementStates.Visible) _
                    + absenteeListDgv.ColumnHeadersHeight

            Me.Width = absenteeListDgv.Width + 64
            Dim myHeight As Integer = absenteeListDgv.Height + Me.DeliverEmailNoticesBtn.Height _
                + Me.Height - Me.ClientSize.Height + 84
            Me.Height = If(myHeight < minimumFormHeight, minimumFormHeight, myHeight)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub DeliverEmailNoticesBtn_Click(
            sender As System.Object, e As System.EventArgs) Handles DeliverEmailNoticesBtn.Click

        Me.Cursor = Cursors.WaitCursor

        Try

            Dim nEmailsToSend = sanctionsToNotify.Tables(0).Rows.Count
            Dim nEmailsSent As Integer = 0

            For Each sanctionRow As DataRow In sanctionsToNotify.Tables(0).Rows

                Dim recipientEmail As String = If(
                        Strings.Left(sanctionRow("SanctionCode"), 9) = "Detention" _
                            Or sanctionRow("SanctionCode") = "Internal Suspension",
                    sanctionRow("HoyEmail"),
                    sanctionRow("StaffEmail"))

                ' ====================================================================================
                ' ====================================================================================
                SendEmail(
                    sanctionDate:=sanctionRow("SanctionDate"),
                    studentName:=sanctionRow("StudentName"),
                    sanctionCode:=sanctionRow("SanctionCode"),
                    recipientEmail:=recipientEmail)
                ' ====================================================================================
                ' ====================================================================================

                nEmailsSent += 1
                ProgressBar1.Value = (nEmailsSent / nEmailsToSend) * 100

                ' Mark emails as sent by updating REMOVED to 1.

                Using synergyConn As New SqlConnection(ConfigurationManager.ConnectionStrings("Synergy").ConnectionString)
                    Using updateSanctionsEmailSentCmd As New SqlCommand(
                        "UPDATE dbo.uStudentSanctions 
                        SET Removed = 1,
                            Present = 0,
                            StaffReason = 'Failed to attend: ' + staffreason 
                        WHERE Seq = @SanctionSeq",
                        synergyConn)

                        updateSanctionsEmailSentCmd.Parameters.AddWithValue("SanctionSeq", sanctionRow("Seq"))

                        synergyConn.Open()

                        updateSanctionsEmailSentCmd.ExecuteNonQuery()

                    End Using
                End Using

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default
        DeliverEmailNoticesBtn.Enabled = False
        MsgBox("All Emails Sent.", MsgBoxStyle.OkOnly)

    End Sub


    Private Sub SendEmail(sanctionDate As String, studentName As String,
            sanctionCode As String, recipientEmail As String)

        Try
            Dim nonAttendanceNotification As New Net.Mail.MailMessage(
                    from:=Main.configHandler.sanctionNonAttendanceEmailSender,
                    to:=recipientEmail)

            ' Add additional admin staff to the notification email recipients list. 
            For Each recipient As String In Main.configHandler.nonAttendanceEmailRecipients
                If recipient <> "" And recipient IsNot Nothing Then
                    nonAttendanceNotification.To.Add(recipient)
                End If
            Next

            nonAttendanceNotification.IsBodyHtml = True

            nonAttendanceNotification.Subject = "Notice of non-attendance for " & studentName
            nonAttendanceNotification.Body = String.Format("<h3>Notice of Non-Attendance</h3>
                <p>&nbsp;</p>
                <p>Please be aware that {0} failed to attend {1} on {2}. 
                Kindly re-issue a sanction through the Behaviour Monitoring System.</p>",
                studentName, sanctionCode, sanctionDate)

            Dim client As New Net.Mail.SmtpClient("<MAIL_SERVER_NAME>")
            client.Port = 25

            ' ====================================================================================
            ' ====================================================================================
            client.Send(nonAttendanceNotification)
            ' ====================================================================================
            ' ====================================================================================

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
