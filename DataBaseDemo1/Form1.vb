Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim mycom As SqlCommand
    Dim myreader As SqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection()
        con.ConnectionString = "Data Source=Alienator-pc;Initial Catalog=StepSample;User Id=sa;pwd=*Glorious#2"
        con.Open()
        mycom = New SqlCommand()
        mycom.Connection = con
        Dim query As String
        query = "Select * From Customer"
        mycom.CommandText = query
        myreader = mycom.ExecuteReader()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If myreader.Read() Then
                TextBox1.Text = myreader.GetString(0)
                TextBox2.Text = myreader.GetString(1)
                TextBox3.Text = myreader.GetString(2)
                TextBox4.Text = myreader.GetString(3)
                TextBox5.Text = myreader.GetString(4)

            Else
                TextBox1.Text = "end of Record"
                TextBox2.Text = "end of Record"
                TextBox3.Text = "end of Record"
                TextBox4.Text = "end of Record"
                TextBox5.Text = "end of Record"
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
