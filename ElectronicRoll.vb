Imports System.Data.SqlClient
Imports System.Configuration


Public Class ElectronicRoll

    Public sanctionType As String

    Private rollDset As New DataSet
    Private minimumFormHeight As Integer = 300

    Private Sub electronicRoll_Load(
            ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
                    .AutoResizeColumns()
                    .Columns(0).Visible = False
                    .Columns(1).Visible = False
                    .Columns(3).Resizable = True
                    .Columns(5).HeaderText = "Tutor Group"
                    .Columns(6).Visible = False
                    .Columns(7).HeaderText = "Type"
                    .Columns(8).Visible = False
                    .Columns(9).HeaderText = "Notes"
                    .Columns(10).ReadOnly = False
                    .Columns(11).HeaderText = "YLM Notes (optional)"
                    .Columns(11).ReadOnly = False
                    .Columns(11).Width = 300
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
