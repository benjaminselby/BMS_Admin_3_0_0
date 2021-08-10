<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ViewRollsBtn = New System.Windows.Forms.Button()
        Me.InternalSuspensionBtn = New System.Windows.Forms.Button()
        Me.DetentionAfterSchoolBtn = New System.Windows.Forms.Button()
        Me.DetentionLunchBtn = New System.Windows.Forms.Button()
        Me.CatchUpClassBtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StudentProfileBtn = New System.Windows.Forms.Button()
        Me.TutorGroupsBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PrepareEmailRunBtn = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.StudentSanctionsBtn = New System.Windows.Forms.Button()
        Me.RoleManagementBtn = New System.Windows.Forms.Button()
        Me.SanctionCountsChartRpt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.UnhandledReportsOfConcernLbl = New System.Windows.Forms.Label()
        Me.ReportsOfConcernBtn = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MakeBookingBtn = New System.Windows.Forms.Button()
        Me.ShowNamesBtn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PointsBtn = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ViewRollsBtn)
        Me.GroupBox1.Controls.Add(Me.InternalSuspensionBtn)
        Me.GroupBox1.Controls.Add(Me.DetentionAfterSchoolBtn)
        Me.GroupBox1.Controls.Add(Me.DetentionLunchBtn)
        Me.GroupBox1.Controls.Add(Me.CatchUpClassBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(57, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 272)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Electronic Roll"
        '
        'ViewRollsBtn
        '
        Me.ViewRollsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ViewRollsBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewRollsBtn.Location = New System.Drawing.Point(12, 223)
        Me.ViewRollsBtn.Name = "ViewRollsBtn"
        Me.ViewRollsBtn.Size = New System.Drawing.Size(203, 36)
        Me.ViewRollsBtn.TabIndex = 4
        Me.ViewRollsBtn.Text = "View Rolls"
        Me.ViewRollsBtn.UseVisualStyleBackColor = False
        '
        'InternalSuspensionBtn
        '
        Me.InternalSuspensionBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.InternalSuspensionBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InternalSuspensionBtn.Location = New System.Drawing.Point(13, 175)
        Me.InternalSuspensionBtn.Name = "InternalSuspensionBtn"
        Me.InternalSuspensionBtn.Size = New System.Drawing.Size(203, 36)
        Me.InternalSuspensionBtn.TabIndex = 3
        Me.InternalSuspensionBtn.Text = "Internal Suspension"
        Me.InternalSuspensionBtn.UseVisualStyleBackColor = False
        '
        'DetentionAfterSchoolBtn
        '
        Me.DetentionAfterSchoolBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DetentionAfterSchoolBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetentionAfterSchoolBtn.Location = New System.Drawing.Point(13, 128)
        Me.DetentionAfterSchoolBtn.Name = "DetentionAfterSchoolBtn"
        Me.DetentionAfterSchoolBtn.Size = New System.Drawing.Size(203, 36)
        Me.DetentionAfterSchoolBtn.TabIndex = 2
        Me.DetentionAfterSchoolBtn.Text = "Detention (After School)"
        Me.DetentionAfterSchoolBtn.UseVisualStyleBackColor = False
        '
        'DetentionLunchBtn
        '
        Me.DetentionLunchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DetentionLunchBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetentionLunchBtn.Location = New System.Drawing.Point(13, 81)
        Me.DetentionLunchBtn.Name = "DetentionLunchBtn"
        Me.DetentionLunchBtn.Size = New System.Drawing.Size(203, 36)
        Me.DetentionLunchBtn.TabIndex = 1
        Me.DetentionLunchBtn.Text = "Detention (Lunch)"
        Me.DetentionLunchBtn.UseVisualStyleBackColor = False
        '
        'CatchUpClassBtn
        '
        Me.CatchUpClassBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CatchUpClassBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatchUpClassBtn.Location = New System.Drawing.Point(12, 34)
        Me.CatchUpClassBtn.Name = "CatchUpClassBtn"
        Me.CatchUpClassBtn.Size = New System.Drawing.Size(203, 36)
        Me.CatchUpClassBtn.TabIndex = 0
        Me.CatchUpClassBtn.Text = "Catch Up Class"
        Me.CatchUpClassBtn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.StudentProfileBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(297, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 80)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profiles"
        '
        'StudentProfileBtn
        '
        Me.StudentProfileBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StudentProfileBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentProfileBtn.Location = New System.Drawing.Point(12, 32)
        Me.StudentProfileBtn.Name = "StudentProfileBtn"
        Me.StudentProfileBtn.Size = New System.Drawing.Size(203, 36)
        Me.StudentProfileBtn.TabIndex = 0
        Me.StudentProfileBtn.Text = "Student"
        Me.StudentProfileBtn.UseVisualStyleBackColor = False
        '
        'TutorGroupsBtn
        '
        Me.TutorGroupsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TutorGroupsBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TutorGroupsBtn.Location = New System.Drawing.Point(12, 98)
        Me.TutorGroupsBtn.Name = "TutorGroupsBtn"
        Me.TutorGroupsBtn.Size = New System.Drawing.Size(203, 36)
        Me.TutorGroupsBtn.TabIndex = 1
        Me.TutorGroupsBtn.Text = "Tutor Groups"
        Me.TutorGroupsBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PrepareEmailRunBtn)
        Me.GroupBox3.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(57, 181)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 80)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Absentees"
        '
        'PrepareEmailRunBtn
        '
        Me.PrepareEmailRunBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PrepareEmailRunBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrepareEmailRunBtn.Location = New System.Drawing.Point(12, 32)
        Me.PrepareEmailRunBtn.Name = "PrepareEmailRunBtn"
        Me.PrepareEmailRunBtn.Size = New System.Drawing.Size(203, 36)
        Me.PrepareEmailRunBtn.TabIndex = 0
        Me.PrepareEmailRunBtn.Text = "Prepare Email Run"
        Me.PrepareEmailRunBtn.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.StudentSanctionsBtn)
        Me.GroupBox4.Controls.Add(Me.RoleManagementBtn)
        Me.GroupBox4.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(297, 420)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(227, 122)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Maintenance"
        '
        'StudentSanctionsBtn
        '
        Me.StudentSanctionsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StudentSanctionsBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!)
        Me.StudentSanctionsBtn.Location = New System.Drawing.Point(12, 32)
        Me.StudentSanctionsBtn.Name = "StudentSanctionsBtn"
        Me.StudentSanctionsBtn.Size = New System.Drawing.Size(203, 36)
        Me.StudentSanctionsBtn.TabIndex = 10
        Me.StudentSanctionsBtn.Text = "Sanctions"
        Me.StudentSanctionsBtn.UseVisualStyleBackColor = False
        '
        'RoleManagementBtn
        '
        Me.RoleManagementBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RoleManagementBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleManagementBtn.Location = New System.Drawing.Point(12, 74)
        Me.RoleManagementBtn.Name = "RoleManagementBtn"
        Me.RoleManagementBtn.Size = New System.Drawing.Size(203, 36)
        Me.RoleManagementBtn.TabIndex = 2
        Me.RoleManagementBtn.Text = "Role Management"
        Me.RoleManagementBtn.UseVisualStyleBackColor = False
        '
        'SanctionCountsChartRpt
        '
        Me.SanctionCountsChartRpt.AutoScroll = True
        Me.SanctionCountsChartRpt.BackColor = System.Drawing.Color.Azure
        Me.SanctionCountsChartRpt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SanctionCountsChartRpt.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SanctionCountsChartRpt.Location = New System.Drawing.Point(540, 190)
        Me.SanctionCountsChartRpt.Margin = New System.Windows.Forms.Padding(0)
        Me.SanctionCountsChartRpt.Name = "SanctionCountsChartRpt"
        Me.SanctionCountsChartRpt.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.SanctionCountsChartRpt.PromptAreaCollapsed = True
        Me.SanctionCountsChartRpt.ServerReport.ReportPath = "/Behaviour Monitoring System/70DaysNoNames"
        Me.SanctionCountsChartRpt.ServerReport.ReportServerUrl = New System.Uri("http://testserver2.woodcroft.sa.edu.au/reportserver", System.UriKind.Absolute)
        Me.SanctionCountsChartRpt.ServerReport.Timeout = 60000
        Me.SanctionCountsChartRpt.ShowBackButton = False
        Me.SanctionCountsChartRpt.ShowContextMenu = False
        Me.SanctionCountsChartRpt.ShowCredentialPrompts = False
        Me.SanctionCountsChartRpt.ShowDocumentMapButton = False
        Me.SanctionCountsChartRpt.ShowExportButton = False
        Me.SanctionCountsChartRpt.ShowFindControls = False
        Me.SanctionCountsChartRpt.ShowPageNavigationControls = False
        Me.SanctionCountsChartRpt.ShowParameterPrompts = False
        Me.SanctionCountsChartRpt.ShowPrintButton = False
        Me.SanctionCountsChartRpt.ShowProgress = False
        Me.SanctionCountsChartRpt.ShowPromptAreaButton = False
        Me.SanctionCountsChartRpt.ShowRefreshButton = False
        Me.SanctionCountsChartRpt.ShowStopButton = False
        Me.SanctionCountsChartRpt.ShowToolBar = False
        Me.SanctionCountsChartRpt.ShowZoomControl = False
        Me.SanctionCountsChartRpt.Size = New System.Drawing.Size(660, 420)
        Me.SanctionCountsChartRpt.TabIndex = 4
        Me.SanctionCountsChartRpt.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.UnhandledReportsOfConcernLbl)
        Me.GroupBox5.Controls.Add(Me.TutorGroupsBtn)
        Me.GroupBox5.Controls.Add(Me.ReportsOfConcernBtn)
        Me.GroupBox5.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(297, 181)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(227, 140)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Monitoring"
        '
        'UnhandledReportsOfConcernLbl
        '
        Me.UnhandledReportsOfConcernLbl.AutoSize = True
        Me.UnhandledReportsOfConcernLbl.Font = New System.Drawing.Font("Gill Sans MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnhandledReportsOfConcernLbl.Location = New System.Drawing.Point(212, 68)
        Me.UnhandledReportsOfConcernLbl.Name = "UnhandledReportsOfConcernLbl"
        Me.UnhandledReportsOfConcernLbl.Size = New System.Drawing.Size(0, 16)
        Me.UnhandledReportsOfConcernLbl.TabIndex = 2
        Me.UnhandledReportsOfConcernLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReportsOfConcernBtn
        '
        Me.ReportsOfConcernBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ReportsOfConcernBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsOfConcernBtn.Location = New System.Drawing.Point(12, 32)
        Me.ReportsOfConcernBtn.Name = "ReportsOfConcernBtn"
        Me.ReportsOfConcernBtn.Size = New System.Drawing.Size(203, 36)
        Me.ReportsOfConcernBtn.TabIndex = 0
        Me.ReportsOfConcernBtn.Text = "Reports of Concern"
        Me.ReportsOfConcernBtn.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.MakeBookingBtn)
        Me.GroupBox6.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(57, 551)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(227, 80)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Student Bookings"
        '
        'MakeBookingBtn
        '
        Me.MakeBookingBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MakeBookingBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MakeBookingBtn.Location = New System.Drawing.Point(12, 33)
        Me.MakeBookingBtn.Name = "MakeBookingBtn"
        Me.MakeBookingBtn.Size = New System.Drawing.Size(203, 36)
        Me.MakeBookingBtn.TabIndex = 0
        Me.MakeBookingBtn.Text = "Make Booking"
        Me.MakeBookingBtn.UseVisualStyleBackColor = False
        '
        'ShowNamesBtn
        '
        Me.ShowNamesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ShowNamesBtn.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowNamesBtn.Location = New System.Drawing.Point(1098, 617)
        Me.ShowNamesBtn.Name = "ShowNamesBtn"
        Me.ShowNamesBtn.Size = New System.Drawing.Size(101, 28)
        Me.ShowNamesBtn.TabIndex = 0
        Me.ShowNamesBtn.Text = "Show Names"
        Me.ShowNamesBtn.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(140, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(767, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Woodcroft College Behaviour Monitoring System"
        '
        'PointsBtn
        '
        Me.PointsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PointsBtn.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PointsBtn.Location = New System.Drawing.Point(12, 31)
        Me.PointsBtn.Name = "PointsBtn"
        Me.PointsBtn.Size = New System.Drawing.Size(203, 36)
        Me.PointsBtn.TabIndex = 11
        Me.PointsBtn.Text = "Points"
        Me.PointsBtn.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.PointsBtn)
        Me.GroupBox7.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(297, 551)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(227, 80)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DoSS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BMS_Admin.My.Resources.Resources.Woodcroft_College_CMYK_TransBack_v2
        Me.PictureBox1.Location = New System.Drawing.Point(38, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1211, 693)
        Me.Controls.Add(Me.SanctionCountsChartRpt)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShowNamesBtn)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "BMS Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DetentionAfterSchoolBtn As System.Windows.Forms.Button
    Friend WithEvents DetentionLunchBtn As System.Windows.Forms.Button
    Friend WithEvents CatchUpClassBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TutorGroupsBtn As System.Windows.Forms.Button
    Friend WithEvents StudentProfileBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PrepareEmailRunBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ReportsOfConcernBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents MakeBookingBtn As System.Windows.Forms.Button
    Friend WithEvents InternalSuspensionBtn As System.Windows.Forms.Button
    Friend WithEvents ShowNamesBtn As System.Windows.Forms.Button
    Friend WithEvents RoleManagementBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentSanctionsBtn As System.Windows.Forms.Button
    Private WithEvents SanctionCountsChartRpt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PointsBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ViewRollsBtn As System.Windows.Forms.Button
    Friend WithEvents UnhandledReportsOfConcernLbl As Label
End Class
