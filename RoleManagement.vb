Imports System.Data.SqlClient
Imports System.Configuration


Public Class RoleManagement

    Dim headsOfYearDset As New DataSet

    Private Sub RoleManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try

            Using synergyConn As New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)

                Using headsOfYearAdapter As New SqlDataAdapter(
                        ConfigurationManager.AppSettings("GetHeadsOfYearProc"), synergyConn)

                    synergyConn.Open()
                    headsOfYearAdapter.Fill(headsOfYearDset)

                End Using
            End Using

            HeadsOfYearDgv.DataSource = headsOfYearDset.Tables(0)
            HeadsOfYearDgv.Columns(1).ReadOnly = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub HeadsOfYearDgv_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) _
            Handles HeadsOfYearDgv.DataError

        MsgBox("The value you have just entered is not in the correct format. Please review your edit and try again." &
               vbCrLf & "If this problem persists, please contact Data Management for assistance.",
                MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Data Format Error")

    End Sub



    Private Sub RoleManagement_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) _
            Handles Me.FormClosing

        Try
            Dim headsOfYearDsetChanges As DataSet = headsOfYearDset.GetChanges()
            If headsOfYearDsetChanges IsNot Nothing Then

                If MsgBox("Do you want to save your changes?",
                          MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Save Changes?") = MsgBoxResult.Yes Then

                    For Each headsOfYearRow As DataRow In headsOfYearDsetChanges.Tables(0).Rows

                        Using synergyConn As New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)
                            Using updateHeadOfYearCmd As New SqlCommand(
                                    ConfigurationManager.AppSettings("UpdateHeadOfYearProc"), synergyConn)

                                updateHeadOfYearCmd.CommandType = CommandType.StoredProcedure
                                updateHeadOfYearCmd.Parameters.AddWithValue("YearLevel", headsOfYearRow("Year Level"))
                                updateHeadOfYearCmd.Parameters.AddWithValue("StaffId", headsOfYearRow("HOY_ID"))

                                synergyConn.Open()
                                updateHeadOfYearCmd.ExecuteNonQuery()

                            End Using
                        End Using
                    Next

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class