Imports System.Data.SqlClient
Public Class SQLControl
    Dim con As New SqlConnection With {.ConnectionString = "Server=Alienator-pc;Database=LoginDB;User=sa;pwd=*Glorious#2"}

    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Public ds As DataSet

    Public Function HasConnection() As Boolean
        Try
            con.Open()
            con.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False

    End Function
    Public Sub RunQuery(Query As String)
        Try
            con.Open()
            cmd = New SqlCommand(Query, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

End Class
