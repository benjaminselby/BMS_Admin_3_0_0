Imports System.Data.SqlClient
Imports System.Configuration


Public Class ElectronicRoll

    Public sanctionType As String

    Private rollDset As New DataSet
    Private minimumFormHeight As Integer = 300

    Private Sub Form_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        Try

            headingLbl.Text = "Electronic Roll for " & FormatDateTime(Today, DateFormat.LongDate) & ": " & sanctionType

            Using synergyConn = New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)

                synergyConn.Open()

                Using electronicRollAdapter = New SqlDataAdapter(
                        ConfigurationManager.AppSettings("GetElectronicRollProc"),
                        synergyConn)

                    electronicRollAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                    electronicRollAdapter.SelectCommand.Parameters.AddWithValue("SanctionCode", Me.sanctionType)

                    electronicRollAdapter.Fill(rollDset)
                    rollDgv.DataSource = rollDset.Tables(0)

                End Using

                For Each col As DataGridViewColumn In rollDgv.Columns
                    With col
                        .SortMode = DataGridViewColumnSortMode.NotSortable
                        .Resizable = DataGridViewTriState.False
                        .Frozen = True
                        .ReadOnly = True
                    End With
                Next

                With rollDgv

                    .Columns("SanctionSeq").Visible = False
                    .Columns("StudentId").Visible = False

                    .Columns("Preferred").Resizable = True
                    .Columns("Preferred").DisplayIndex = 0

                    .Columns("Surname").Resizable = True
                    .Columns("Surname").DisplayIndex = 1

                    .Columns("Present").ReadOnly = False
                    .Columns("Present").DisplayIndex = 2
                    .Columns("Present").DefaultCellStyle.BackColor = Color.LightGray
                    .Columns("Present").DefaultCellStyle.SelectionBackColor = Color.LightGray

                    .Columns("Tutor").HeaderText = "Tutor Group"
                    .Columns("SanctionDate").Visible = False
                    .Columns("ReasonType").HeaderText = "Type"
                    .Columns("SanctionCode").Visible = False

                    .Columns("StaffReason").HeaderText = "Notes"
                    .Columns("StaffReason").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    .Columns("StaffReason").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .Columns("StaffReason").Width = 300

                    .Columns("HOYNotes").HeaderText = "YLM Notes (optional)"
                    .Columns("HOYNotes").ReadOnly = False
                    .Columns("HOYNotes").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    .Columns("HOYNotes").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    .Columns("HOYNotes").Width = 300

                End With

                rollDgv.Width = rollDgv.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 1
                rollDgv.Height = rollDgv.Rows.GetRowsHeight(DataGridViewElementStates.None) + rollDgv.ColumnHeadersHeight

                Me.Width = Math.Max(rollDgv.Width, headingLbl.Width) + 44
                Dim myHeight As Integer = rollDgv.Height + Me.headingLbl.Height + Me.Height - Me.ClientSize.Height + 44
                Me.Height = Math.Max(minimumFormHeight, myHeight)

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ElectronicRoll_FormClosing(
            ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            Dim changesDset As DataSet = rollDset.GetChanges
            If changesDset IsNot Nothing Then

                Using synergyConn = New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)

                    synergyConn.Open()

                    Using rollUpdateCmd As New SqlCommand(
                            ConfigurationManager.AppSettings("UpdateSanctionAttendanceProc"), synergyConn)

                        rollUpdateCmd.CommandType = CommandType.StoredProcedure

                        For Each row As DataRow In changesDset.Tables(0).Rows

                            rollUpdateCmd.Parameters.AddWithValue("Present", row("Present"))
                            rollUpdateCmd.Parameters.AddWithValue("HoyNotes", row("HoyNotes"))
                            rollUpdateCmd.Parameters.AddWithValue("SanctionSeq", row("SanctionSeq"))

                            rollUpdateCmd.ExecuteNonQuery()

                            rollUpdateCmd.Parameters.Clear()

                        Next

                    End Using
                End Using

            End If
        Catch ex As Exception
            MsgBox(
                "WARNING: Your changes may not have been saved correctly!" & vbCrLf &
                "Please try again." & vbCrLf &
                "If this problem persists, contact Data Management." & vbCrLf & vbCrLf &
                "========" & vbCrLf &
                "EXCEPTION DETAILS:" & vbCrLf &
                ex.ToString, MsgBoxStyle.Critical, "Database error!")
        End Try

    End Sub

End Class

