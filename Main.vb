Imports System.Data.SqlClient
Imports System.Configuration


Public Class Main

    Private versionNumber As String = "3.0.3"

    Private intScreenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Private intScreenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Private decWidthRatio As Decimal
    Private decHeightRatio As Decimal
    Public configHandler As ConfigHandler = New ConfigHandler()

    Private Sub Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Text = Me.Text & " v" & versionNumber

        Try
            ' Scale form components based on display resolution. 

            decWidthRatio = FormatNumber(intScreenWidth / Me.Width, 3)
            decHeightRatio = FormatNumber(intScreenHeight / Me.Height, 3)

            Me.WindowState = FormWindowState.Maximized

            For Each ctrl As Control In Me.Controls

                ResizeRelocateControl(ctrl)

                If TypeOf ctrl Is GroupBox Then
                    For Each childCtrl As Control In ctrl.Controls
                        ResizeRelocateControl(childCtrl)
                    Next
                End If

            Next

            ShowNamesBtn.Left = SanctionCountsChartRpt.Left + SanctionCountsChartRpt.Width - ShowNamesBtn.Width
            ShowNamesBtn.Top = SanctionCountsChartRpt.Top + SanctionCountsChartRpt.Height + 14

            ShowUnhandledReportsOfConcernCount()

            Me.SanctionCountsChartRpt.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ResizeRelocateControl(ByRef ctl As Control)

        Dim intOriginalWidth As Integer = ctl.Width
        Dim intOriginalHeight As Integer = ctl.Height

        ctl.Font = New Font(ctl.Font.Name, CInt(ctl.Font.Size * decHeightRatio), ctl.Font.Style)
        ctl.Width = CInt(ctl.Width * decWidthRatio)
        ctl.Height = CInt(ctl.Height * decHeightRatio)
        ctl.Location = New Point(CInt(ctl.Location.X * decWidthRatio), CInt(ctl.Location.Y * decHeightRatio))

    End Sub


    Private Sub PrepareEmailRunBtn_Click(sender As System.Object, e As System.EventArgs) _
                Handles PrepareEmailRunBtn.Click
        EmailAbsences.Show()
    End Sub


    Private Sub ReportsOfConcernBtn_Click(sender As System.Object, e As System.EventArgs) _
                Handles ReportsOfConcernBtn.Click
        ReportsOfConcern.Show()
    End Sub


    Private Sub MakeBookingBtn_Click(sender As System.Object, e As System.EventArgs) Handles MakeBookingBtn.Click

        ' A set of installation paths of the BMS program is stored in a config list. This allows us 
        ' to search across multiple potential installations to find at least one launchable version 
        ' of BMS. If none is found, we launch the one included in this platform (not recommended because 
        ' it may be out of date. 

        Dim bmsLaunchPath As String = Nothing
        For Each configPath In configHandler.bmsPaths
            If System.IO.File.Exists(configPath) Then
                bmsLaunchPath = configPath
                Exit For
            End If
        Next

        If bmsLaunchPath Is Nothing Then
            BMS_Main.Show()
        Else
            Process.Start(bmsLaunchPath)
        End If

    End Sub


    Private Sub ElectronicRollBtn_Click(sender As Button, e As System.EventArgs) _
       Handles InternalSuspensionBtn.Click,
                CatchUpClassBtn.Click,
                DetentionLunchBtn.Click,
                DetentionAfterSchoolBtn.Click

        Select Case sender.Name
            Case "CatchUpClassBtn"
                ElectronicRoll.sanctionType = "Catch Up Class"
            Case "DetentionLunchBtn"
                ElectronicRoll.sanctionType = "Detention (Level 1: Lunchtime)"
            Case "DetentionAfterSchoolBtn"
                ElectronicRoll.sanctionType = "Detention (Level 2: After School)"
            Case "InternalSuspensionBtn"
                ElectronicRoll.sanctionType = "Internal Suspension"
            Case Else
                Throw New Exception(sender.ToString() & ": Event handler for this object not implemented yet.")
        End Select

        ElectronicRoll.Show()

    End Sub


    Private Sub StudentProfileBtn_Click(sender As System.Object, e As System.EventArgs) Handles StudentProfileBtn.Click
        StudentProfile.Show()
    End Sub


    Private Sub ShowNamesBtn_Click(sender As System.Object, e As System.EventArgs) Handles ShowNamesBtn.Click
        Try
            If ShowNamesBtn.Text = "Show Names" Then
                SanctionCountsChartRpt.ServerReport.ReportPath = "/Behaviour Monitoring System/70DaysNamed"
                SanctionCountsChartRpt.RefreshReport()
                ShowNamesBtn.Text = "Hide Names"
            Else
                SanctionCountsChartRpt.ServerReport.ReportPath = "/Behaviour Monitoring System/70DaysNoNames"
                SanctionCountsChartRpt.RefreshReport()
                ShowNamesBtn.Text = "Show Names"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TutorGroupsBtn_Click(sender As System.Object, e As System.EventArgs) _
            Handles TutorGroupsBtn.Click
        TutorGroup.Show()
    End Sub


    Private Sub RoleManagementBtn_Click(sender As System.Object, e As System.EventArgs) _
            Handles RoleManagementBtn.Click
        RoleManagement.Show()
    End Sub


    Private Sub StudentSanctionsBtn_Click(sender As System.Object, e As System.EventArgs) _
            Handles StudentSanctionsBtn.Click
        StudentSanctions.Show()
    End Sub


    Private Sub PointsBtn_Click(sender As Object, e As EventArgs) _
            Handles PointsBtn.Click
        Points.Show()
    End Sub


    Private Sub ViewRollsBtn_Click(sender As Object, e As EventArgs) Handles ViewRollsBtn.Click
        ViewRolls.Show()
    End Sub


    Public Sub ShowUnhandledReportsOfConcernCount()

        ' Add number of unhandled Reports of Concern to label under RoC button.
        Using rocCountConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)
            Using CommandROCCount As New SqlCommand(
                    ConfigurationManager.AppSettings("GetUnhandledReportsOfConcernCountProc"),
                    rocCountConnection)

                rocCountConnection.Open()

                Dim nReportsUnhandled As Integer = CommandROCCount.ExecuteScalar()
                UnhandledReportsOfConcernLbl.Text = nReportsUnhandled & " currently unhandled"
                UnhandledReportsOfConcernLbl.Left = ReportsOfConcernBtn.Left _
                    + ReportsOfConcernBtn.Width - UnhandledReportsOfConcernLbl.Width
                Me.Refresh()

            End Using
        End Using

    End Sub

End Class
