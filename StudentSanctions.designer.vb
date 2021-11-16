<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentSanctions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.studentListCbx = New System.Windows.Forms.ComboBox()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.sanctionListDgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.sanctionListDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentListCbx
        '
        Me.studentListCbx.DisplayMember = "FullName"
        Me.studentListCbx.FormattingEnabled = True
        Me.studentListCbx.Location = New System.Drawing.Point(117, 3)
        Me.studentListCbx.Name = "studentListCbx"
        Me.studentListCbx.Size = New System.Drawing.Size(173, 21)
        Me.studentListCbx.TabIndex = 0
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(171, 3)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(0, 13)
        Me.lblStudent.TabIndex = 2
        '
        'sanctionListDgv
        '
        Me.sanctionListDgv.AllowUserToAddRows = False
        Me.sanctionListDgv.AllowUserToDeleteRows = False
        Me.sanctionListDgv.AllowUserToResizeColumns = False
        Me.sanctionListDgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sanctionListDgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.sanctionListDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sanctionListDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.sanctionListDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.sanctionListDgv.BackgroundColor = System.Drawing.Color.Azure
        Me.sanctionListDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sanctionListDgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.sanctionListDgv.Location = New System.Drawing.Point(12, 30)
        Me.sanctionListDgv.MultiSelect = False
        Me.sanctionListDgv.Name = "sanctionListDgv"
        Me.sanctionListDgv.RowHeadersVisible = False
        Me.sanctionListDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.sanctionListDgv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.sanctionListDgv.Size = New System.Drawing.Size(1153, 579)
        Me.sanctionListDgv.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Student"
        '
        'StudentSanctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1177, 621)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sanctionListDgv)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.studentListCbx)
        Me.Name = "StudentSanctions"
        Me.Text = "Sanction Maintenance"
        CType(Me.sanctionListDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents studentListCbx As System.Windows.Forms.ComboBox
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents sanctionListDgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
