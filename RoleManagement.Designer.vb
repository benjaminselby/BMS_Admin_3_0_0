<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoleManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoleManagement))
        Me.HeadsOfYearDgv = New System.Windows.Forms.DataGridView()
        CType(Me.HeadsOfYearDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeadsOfYearDgv
        '
        Me.HeadsOfYearDgv.AllowUserToAddRows = False
        Me.HeadsOfYearDgv.AllowUserToDeleteRows = False
        Me.HeadsOfYearDgv.BackgroundColor = System.Drawing.Color.Azure
        Me.HeadsOfYearDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HeadsOfYearDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeadsOfYearDgv.Location = New System.Drawing.Point(0, 0)
        Me.HeadsOfYearDgv.Name = "HeadsOfYearDgv"
        Me.HeadsOfYearDgv.Size = New System.Drawing.Size(245, 217)
        Me.HeadsOfYearDgv.TabIndex = 0
        '
        'RoleManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 217)
        Me.Controls.Add(Me.HeadsOfYearDgv)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RoleManagement"
        Me.Text = "YLM Role Management"
        CType(Me.HeadsOfYearDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeadsOfYearDgv As System.Windows.Forms.DataGridView
End Class
