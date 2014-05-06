Imports System.Data
Imports System.Data.SqlClient

Public Class Form3
    Dim con As SqlConnection
    Dim mycom As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection()
        con.ConnectionString = "Data Source=Alienator-pc;Initial Catalog=StepSample;User Id=sa;pwd=*Glorious#2"
        con.Open()
        mycom = New SqlCommand()
        mycom.Connection = con
       

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = " INSERT INTO Customer VALUES ( "
        str = str & " ' " & TextBox1.Text & " ' , "
        str = str & " ' " & TextBox2.Text & " ' , "
        str = str & " ' " & TextBox3.Text & " ' , "
        str = str & " ' " & TextBox4.Text & " ' , "
        str = str & " ' " & TextBox5.Text & " ' ) "
        mycom.CommandText = str
        Try
            If mycom.ExecuteNonQuery() Then
                MsgBox("Inserted successfully")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
