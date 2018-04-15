Imports System.Configuration
Imports System.Data.SqlClient
Imports QLNGDAL
Imports QLNYDTO

Public Class NguoiGhetDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(ng As NYDTO) As Integer
        Dim query As String = String.Empty

        query &= " insert INTO [dbo].[tblnguoighet]"
        query &= "(        [id]"
        query &= "        ,[hoten]"
        query &= "        ,[diachi])"
        query &= "  VALUES"
        query &= "        (@id"
        query &= "        ,@hoten"
        query &= "        ,@diachi)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@id", ng.IId1)
                    .Parameters.AddWithValue("@hoten", ng.StrHoTen1)
                    .Parameters.AddWithValue("@diachi", ng.StrDiaChi1)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return 1
                End Try
            End Using
        End Using

        Return 0 ' thanh cong
    End Function
End Class
