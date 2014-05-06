Public Class ImageUploader

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim img As Image
        Dim filechooser As OpenFileDialog = New OpenFileDialog()
        filechooser.Filter = " Image Files|*.jpg;*.png;*.gif;*.jpeg"
        Dim result As DialogResult = filechooser.ShowDialog()
        Dim filename As String
        If result = Windows.Forms.DialogResult.Cancel Then
            Return
            
        End If
        filename = filechooser.FileName
        Try
            img = Image.FromFile(filename)
            PictureBox1.Image = img
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

    End Sub
End Class