<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsOfConcern
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportsOfConcern))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MarkAsCompleteBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Year12Rbtn = New System.Windows.Forms.RadioButton()
        Me.Year11Rbtn = New System.Windows.Forms.RadioButton()
        Me.Year10Rbtn = New System.Windows.Forms.RadioButton()
        Me.Year9Rbtn = New System.Windows.Forms.RadioButton()
        Me.Year8Rbtn = New System.Windows.Forms.RadioButton()
        Me.Year7Rbtn = New System.Windows.Forms.RadioButton()
        Me.Year6Rbtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(182, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewer1.PromptAreaCollapsed = True
        Me.ReportViewer1.ServerReport.ReportPath = "/Behaviour Monitoring System/ReportOfConcern"
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://testserver2.woodcroft.sa.edu.au/reportserver", System.UriKind.Absolute)
        Me.ReportViewer1.Size = New System.Drawing.Size(718, 644)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.Visible = False
        '
        'MarkAsCompleteBtn
        '
        Me.MarkAsCompleteBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MarkAsCompleteBtn.Enabled = False
        Me.MarkAsCompleteBtn.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarkAsCompleteBtn.Location = New System.Drawing.Point(25, 277)
        Me.MarkAsCompleteBtn.Name = "MarkAsCompleteBtn"
        Me.MarkAsCompleteBtn.Size = New System.Drawing.Size(130, 42)
        Me.MarkAsCompleteBtn.TabIndex = 1
        Me.MarkAsCompleteBtn.Text = "Mark Displayed Reports as Handled"
        Me.MarkAsCompleteBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Year12Rbtn)
        Me.GroupBox1.Controls.Add(Me.Year11Rbtn)
        Me.GroupBox1.Controls.Add(Me.Year10Rbtn)
        Me.GroupBox1.Controls.Add(Me.Year9Rbtn)
        Me.GroupBox1.Controls.Add(Me.Year8Rbtn)
        Me.GroupBox1.Controls.Add(Me.Year7Rbtn)
        Me.GroupBox1.Controls.Add(Me.Year6Rbtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Gill Sans MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 261)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Year Level "
        '
        'Year12Rbtn
        '
        Me.Year12Rbtn.AutoSize = True
        Me.Year12Rbtn.Location = New System.Drawing.Point(46, 220)
        Me.Year12Rbtn.Name = "Year12Rbtn"
        Me.Year12Rbtn.Size = New System.Drawing.Size(42, 25)
        Me.Year12Rbtn.TabIndex = 6
        Me.Year12Rbtn.TabStop = True
        Me.Year12Rbtn.Text = "12"
        Me.Year12Rbtn.UseVisualStyleBackColor = True
        '
        'Year11Rbtn
        '
        Me.Year11Rbtn.AutoSize = True
        Me.Year11Rbtn.Location = New System.Drawing.Point(46, 188)
        Me.Year11Rbtn.Name = "Year11Rbtn"
        Me.Year11Rbtn.Size = New System.Drawing.Size(42, 25)
        Me.Year11Rbtn.TabIndex = 5
        Me.Year11Rbtn.TabStop = True
        Me.Year11Rbtn.Text = "11"
        Me.Year11Rbtn.UseVisualStyleBackColor = True
        '
        'Year10Rbtn
        '
        Me.Year10Rbtn.AutoSize = True
        Me.Year10Rbtn.Location = New System.Drawing.Point(46, 156)
        Me.Year10Rbtn.Name = "Year10Rbtn"
        Me.Year10Rbtn.Size = New System.Drawing.Size(42, 25)
        Me.Year10Rbtn.TabIndex = 4
        Me.Year10Rbtn.TabStop = True
        Me.Year10Rbtn.Text = "10"
        Me.Year10Rbtn.UseVisualStyleBackColor = True
        '
        'Year9Rbtn
        '
        Me.Year9Rbtn.AutoSize = True
        Me.Year9Rbtn.Location = New System.Drawing.Point(46, 124)
        Me.Year9Rbtn.Name = "Year9Rbtn"
        Me.Year9Rbtn.Size = New System.Drawing.Size(35, 25)
        Me.Year9Rbtn.TabIndex = 3
        Me.Year9Rbtn.TabStop = True
        Me.Year9Rbtn.Text = "9"
        Me.Year9Rbtn.UseVisualStyleBackColor = True
        '
        'Year8Rbtn
        '
        Me.Year8Rbtn.AutoSize = True
        Me.Year8Rbtn.Location = New System.Drawing.Point(46, 92)
        Me.Year8Rbtn.Name = "Year8Rbtn"
        Me.Year8Rbtn.Size = New System.Drawing.Size(35, 25)
        Me.Year8Rbtn.TabIndex = 2
        Me.Year8Rbtn.TabStop = True
        Me.Year8Rbtn.Text = "8"
        Me.Year8Rbtn.UseVisualStyleBackColor = True
        '
        'Year7Rbtn
        '
        Me.Year7Rbtn.AutoSize = True
        Me.Year7Rbtn.Location = New System.Drawing.Point(46, 60)
        Me.Year7Rbtn.Name = "Year7Rbtn"
        Me.Year7Rbtn.Size = New System.Drawing.Size(35, 25)
        Me.Year7Rbtn.TabIndex = 1
        Me.Year7Rbtn.TabStop = True
        Me.Year7Rbtn.Text = "7"
        Me.Year7Rbtn.UseVisualStyleBackColor = True
        '
        'Year6Rbtn
        '
        Me.Year6Rbtn.AutoSize = True
        Me.Year6Rbtn.Location = New System.Drawing.Point(46, 28)
        Me.Year6Rbtn.Name = "Year6Rbtn"
        Me.Year6Rbtn.Size = New System.Drawing.Size(35, 25)
        Me.Year6Rbtn.TabIndex = 0
        Me.Year6Rbtn.TabStop = True
        Me.Year6Rbtn.Text = "6"
        Me.Year6Rbtn.UseVisualStyleBackColor = True
        '
        'ReportsOfConcern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(926, 675)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MarkAsCompleteBtn)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportsOfConcern"
        Me.Text = "Reports of Concern"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MarkAsCompleteBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Year12Rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Year11Rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Year10Rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Year9Rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Year8Rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Year7Rbtn As System.Windows.Forms.RadioButton
    Friend WithEvents Year6Rbtn As System.Windows.Forms.RadioButton
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
