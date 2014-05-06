Public Class Login
    Private sql As New SQLControl
    Private AuthUser As String


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If sql.HasConnection() Then
            If IsAuthenticated() = True Then
                AuthUser = txtUname.Text
                MsgBox("login Succesfull")
                GetUserInfo()

            End If
        End If
    End Sub
    Private Function IsAuthenticated() As Boolean
        If sql.ds IsNot Nothing Then
            sql.ds.Clear()
        End If
        sql.RunQuery("Select Count(userName)As UserCount " & _
                     "From members " & _
                     "Where username ='" & txtUname.Text & "' " & _
                     "And password ='" & txtPwd.Text & "' Collate SQL_Latin1_General_CP1_CS_AS ")
      
        If sql.ds.Tables(0).Rows(0).Item("UserCount") = 1 Then
            Return True
        Else
            MsgBox("invalid user credentials")
            Return False
        End If


    End Function
    Public Sub GetUserInfo()
        sql.RunQuery("Select username,website,email,lastlogindate " & _
                     "FROM members " & _
                     "where username='" & AuthUser & "' ")
        For Each i As Object In sql.ds.Tables(0).Rows
            txtUserDetail.Text = "Memeber:" & i.Item("username") & vbCrLf & _
                                "Website:" & i.Item("website") & vbCrLf & _
                                "Email:" & i.Item("email") & vbCrLf & _
                                "last Login : " & i.Item("lastlogindate")


        Next

    End Sub
End Class