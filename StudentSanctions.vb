Imports System.Data.SqlClient
Imports System.Configuration


Public Class StudentSanctions

    Private sanctionListDset As New DataSet
    Private currentStudent As Student

    Private Sub StudentSanctions_Load(sender As System.Object, e As System.EventArgs) _
                Handles MyBase.Load

        Try
            Me.WindowState = FormWindowState.Maximized

            studentListCbx.Items.Clear()

            Using synergyConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)
                Using studentListCmd As New SqlCommand(ConfigurationManager.AppSettings("GetAllStudentsProc"), synergyConnection)

                    studentListCmd.CommandType = CommandType.StoredProcedure

                    synergyConnection.Open()

                    Using studentDataRdr As SqlDataReader = studentListCmd.ExecuteReader()

                        If studentDataRdr.HasRows Then
                            Do While studentDataRdr.Read()
                                studentListCbx.Items.Add(New Student(
                                    FirstName:=studentDataRdr("FirstName"),
                                    Surname:=studentDataRdr("Surname"),
                                    YearLevel:=studentDataRdr("YearLevel"),
                                    ID:=studentDataRdr("ID")))
                            Loop
                        Else
                            MsgBox("There was a problem obtaining the student list for this form." &
                                   vbCrLf & "Please contact Data Management for assistance.",
                                    MsgBoxStyle.Exclamation, "Error!")
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub sanctionListDgv_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) _
            Handles sanctionListDgv.DataError

        MsgBox("The value you have just entered is not in the correct format. Please review your edit and try again." &
               vbCrLf & "If this problem persists, please contact Data Management for assistance.",
                MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Data Format Error")

    End Sub


    Private Sub StudentSanctions_ConfirmAndSaveChanges(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) _
                Handles Me.FormClosing

        ConfirmAndSaveChanges()

    End Sub


    Private Sub studentListCbx_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) _
                Handles studentListCbx.SelectedIndexChanged

        ConfirmAndSaveChanges()

        currentStudent = studentListCbx.SelectedItem

        sanctionListDgv.DataSource = Nothing
        sanctionListDset.Clear()

        Using synergyConnection As New SqlConnection(
                ConfigurationManager.ConnectionStrings("synergy").ConnectionString)
            Using sanctionListAdapter = New SqlDataAdapter(
                    ConfigurationManager.AppSettings("GetSanctionsForStudentProc"), synergyConnection)

                sanctionListAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                sanctionListAdapter.SelectCommand.Parameters.AddWithValue(
                                "StudentId", CType(studentListCbx.SelectedItem, Student).id)

                synergyConnection.Open()
                sanctionListAdapter.Fill(sanctionListDset)

            End Using
        End Using

        sanctionListDgv.DataSource = sanctionListDset.Tables(0)

        sanctionListDgv.Columns(0).Visible = False ' Sanction Sequence Number
        sanctionListDgv.Columns(1).Visible = False ' Staff ID
        sanctionListDgv.Columns(4).Visible = False ' Student ID

        ' Define the width of the StaffReason comment column because it can contain some long text.
        sanctionListDgv.Columns(8).Width = 400


        For columnIndex As Integer = 0 To sanctionListDgv.Columns.Count - 1
            With sanctionListDgv.Columns(columnIndex)
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Resizable = DataGridViewTriState.True
                .ReadOnly = If(columnIndex <= 3, True, False)
            End With
        Next

    End Sub


    Private Sub ConfirmAndSaveChanges()

        If sanctionListDset IsNot Nothing AndAlso sanctionListDset.GetChanges IsNot Nothing Then
            If MsgBox(
                    String.Format(
                        "Do you wish to save your changes to the sanctions for {0}?",
                        currentStudent.FullName),
                    MsgBoxStyle.YesNo,
                    "Save changes to Synergy") = MsgBoxResult.Yes Then

                SaveChanges()

            End If
        End If

    End Sub


    Private Sub SaveChanges()

        Try

            ' We can't use a CommandBuilder UPDATE statement here because the DataSet behind 
            ' the DataGridView is based on a joined selection from multiple tables. 

            Dim sanctionDsetChanges As DataSet = sanctionListDset.GetChanges()

            If sanctionDsetChanges IsNot Nothing Then

                Using synergyConn = New SqlConnection(ConfigurationManager.ConnectionStrings("synergy").ConnectionString)

                    Using updateCmd = New SqlCommand(
                            ConfigurationManager.AppSettings("UpdateSanctionProc"),
                            synergyConn)

                        updateCmd.CommandType = CommandType.StoredProcedure

                        synergyConn.Open()

                        For Each sanctionRow As DataRow In sanctionDsetChanges.Tables(0).Rows

                            updateCmd.Parameters.AddWithValue("SanctionSeq", sanctionRow("SanctionSeq"))
                            updateCmd.Parameters.AddWithValue("StudentID", sanctionRow("StudentId"))
                            updateCmd.Parameters.AddWithValue("SanctionDate", sanctionRow("SanctionDate"))
                            updateCmd.Parameters.AddWithValue("SanctionCode", sanctionRow("SanctionCode"))
                            updateCmd.Parameters.AddWithValue("ReasonType", sanctionRow("ReasonType"))
                            updateCmd.Parameters.AddWithValue("StaffReason", sanctionRow("StaffReason"))
                            updateCmd.Parameters.AddWithValue("Present", sanctionRow("Present"))
                            updateCmd.Parameters.AddWithValue("Completed", sanctionRow("Completed"))
                            updateCmd.Parameters.AddWithValue("Removed", sanctionRow("Removed"))
                            updateCmd.Parameters.AddWithValue("CurrentGrade", sanctionRow("CurrentGrade"))
                            updateCmd.Parameters.AddWithValue("SummativeDueDate", sanctionRow("SummativeDueDate"))
                            updateCmd.Parameters.AddWithValue("SummativeTaskName", sanctionRow("SummativeTaskName"))
                            updateCmd.Parameters.AddWithValue("HOYNotes", sanctionRow("HOYNotes"))
                            updateCmd.Parameters.AddWithValue("HOSNotes", sanctionRow("HOSNotes"))
                            updateCmd.Parameters.AddWithValue("CounsNotes", sanctionRow("CounsNotes"))
                            updateCmd.Parameters.AddWithValue("OtherNotes", sanctionRow("OtherNotes"))
                            updateCmd.Parameters.AddWithValue("ClassCode", sanctionRow("ClassCode"))

                            updateCmd.ExecuteNonQuery()

                        Next

                    End Using
                End Using

            End If

        Catch ex As Exception

            MsgBox(
                "WARNING: Your changes may not have been saved correctly!" & vbCrLf &
                "Please try again." & vbCrLf &
                "If this problem persists, contact Data Management for assistance." & vbCrLf & vbCrLf &
                "========" & vbCrLf &
                "EXCEPTION DETAILS:" & vbCrLf &
                ex.ToString, MsgBoxStyle.Critical, "Database error!")

        End Try

    End Sub

End Class
