
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ConfigHandler

    Public ReadOnly sanctionNonAttendanceEmailSender As String
    Public ReadOnly nonAttendanceEmailRecipients As List(Of String)
    Public ReadOnly bmsPaths As List(Of String)

    Public Sub New()

        sanctionNonAttendanceEmailSender = GetConfigValue("sanctionNonAttendanceEmailSender")
        nonAttendanceEmailRecipients = GetConfigList("sanctionNonAttendanceEmailRecipients")
        bmsPaths = GetConfigList("bmsInstallPath")

    End Sub


    Private Function GetConfigValue(keyValue As String) As String

        ' This will only return the first record found in the config table which matches the key. 
        ' If multiple records are expected, use the GetConfigList procedure. 

        Using synergyConn As New SqlConnection(ConfigurationManager.ConnectionStrings("SynergyOne").ToString())

            Using configCmd As New SqlCommand(ConfigurationManager.AppSettings("GetConfigValuesProc"), synergyConn)

                configCmd.CommandType = CommandType.StoredProcedure
                configCmd.Parameters.AddWithValue("Key1", "config")
                configCmd.Parameters.AddWithValue("Key2", "admin")
                configCmd.Parameters.AddWithValue("Key3", keyValue)

                synergyConn.Open()

                Using configDataReader As SqlDataReader = configCmd.ExecuteReader()

                    If configDataReader.HasRows Then
                        configDataReader.Read()
                        Return configDataReader("Value").ToString
                    Else
                        Return Nothing
                    End If

                End Using
            End Using
        End Using

    End Function

    Private Function GetConfigList(keyValue As String) As List(Of String)

        Dim returnValue As New List(Of String)

        Using synergyConn As New SqlConnection(ConfigurationManager.ConnectionStrings("SynergyOne").ToString())

            Using configCmd As New SqlCommand(ConfigurationManager.AppSettings("GetConfigValuesProc"), synergyConn)

                configCmd.CommandType = CommandType.StoredProcedure
                configCmd.Parameters.AddWithValue("Key1", "config")
                configCmd.Parameters.AddWithValue("Key2", "admin")
                configCmd.Parameters.AddWithValue("Key3", keyValue)

                synergyConn.Open()

                Using configDataReader As SqlDataReader = configCmd.ExecuteReader()

                    If configDataReader.HasRows Then
                        While configDataReader.Read()
                            returnValue.Add(configDataReader("Value").ToString)
                        End While
                        Return returnValue
                    Else
                        Return Nothing
                    End If

                End Using
            End Using
        End Using

    End Function



End Class
