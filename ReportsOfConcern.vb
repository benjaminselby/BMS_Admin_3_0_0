Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.Configuration


Public Class ReportsOfConcern

    Private currentYearLevel As Integer

    Private Sub RoC_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate

        Main.ShowUnhandledReportsOfConcernCount()

    End Sub



    Private Sub MarkAsCompleteBtn_Click(sender As System.Object, e As System.EventArgs) _
            Handles MarkAsCompleteBtn.Click


        If MsgBox(String.Format(
                  "This will set all Reports of Concern for Year {0} to 'Completed'. " _
                    & vbCrLf _
                    & "Are you sure you want to proceed?", currentYearLevel),
                MsgBoxStyle.Question + MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then
            Return
        End If


        Try
            'Update ustudent sanctions so that all Reports of Concern for a single Year level
            ' are marked as complete (ie handled).
            Using synergyConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)
                Using updateSanctionsCmd As New SqlCommand(
                        ConfigurationManager.AppSettings("SetReportsOfConcernCompleteProc"),
                        synergyConnection)

                    updateSanctionsCmd.Parameters.AddWithValue("YearLevel", Me.currentYearLevel)
                    updateSanctionsCmd.CommandType = CommandType.StoredProcedure

                    synergyConnection.Open()

                    updateSanctionsCmd.ExecuteNonQuery()
                    ReportViewer1.RefreshReport()

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub ShowReportForYear(YearLevel As Integer)

        Try
            Me.currentYearLevel = YearLevel
            Me.ReportViewer1.Visible = True
            Dim Params As New List(Of ReportParameter) From {
                New ReportParameter("YearLevel", Me.currentYearLevel)
            }
            Me.ReportViewer1.ServerReport.SetParameters(Params)
            Me.ReportViewer1.RefreshReport()
            MarkAsCompleteBtn.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub RadioButton_CheckedChanged(sender As RadioButton, e As System.EventArgs) _
        Handles Year6Rbtn.CheckedChanged,
            Year7Rbtn.CheckedChanged,
            Year8Rbtn.CheckedChanged,
            Year9Rbtn.CheckedChanged,
            Year10Rbtn.CheckedChanged,
            Year11Rbtn.CheckedChanged,
            Year12Rbtn.CheckedChanged

        If sender.Checked Then
            Select Case sender.Name
                Case "Year6Rbtn"
                    ShowReportForYear(6)
                Case "Year7Rbtn"
                    ShowReportForYear(7)
                Case "Year8Rbtn"
                    ShowReportForYear(8)
                Case "Year9Rbtn"
                    ShowReportForYear(9)
                Case "Year10Rbtn"
                    ShowReportForYear(10)
                Case "Year11Rbtn"
                    ShowReportForYear(11)
                Case "Year12Rbtn"
                    ShowReportForYear(12)
            End Select
        End If

    End Sub

End Class