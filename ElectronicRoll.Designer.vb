<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElectronicRoll
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElectronicRoll))
        Me.rollDgv = New System.Windows.Forms.DataGridView()
        Me.headingLbl = New System.Windows.Forms.Label()
        CType(Me.rollDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rollDgv
        '
        Me.rollDgv.AllowUserToAddRows = False
        Me.rollDgv.AllowUserToDeleteRows = False
        Me.rollDgv.AllowUserToResizeColumns = False
        Me.rollDgv.AllowUserToResizeRows = False
        Me.rollDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.rollDgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rollDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rollDgv.DefaultCellStyle = DataGridViewCellStyle1
        Me.rollDgv.Location = New System.Drawing.Point(12, 43)
        Me.rollDgv.MultiSelect = False
        Me.rollDgv.Name = "rollDgv"
        Me.rollDgv.RowHeadersVisible = False
        Me.rollDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.rollDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rollDgv.Size = New System.Drawing.Size(1090, 356)
        Me.rollDgv.TabIndex = 9
        '
        'headingLbl
        '
        Me.headingLbl.AutoSize = True
        Me.headingLbl.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headingLbl.Location = New System.Drawing.Point(11, 17)
        Me.headingLbl.Name = "headingLbl"
        Me.headingLbl.Size = New System.Drawing.Size(53, 23)
        Me.headingLbl.TabIndex = 11
        Me.headingLbl.Text = "Label1"
        '
        'ElectronicRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1115, 411)
        Me.Controls.Add(Me.headingLbl)
        Me.Controls.Add(Me.rollDgv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ElectronicRoll"
        Me.Text = "Electronic Roll"
        CType(Me.rollDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rollDgv As System.Windows.Forms.DataGridView
    Friend WithEvents headingLbl As System.Windows.Forms.Label

End Class
