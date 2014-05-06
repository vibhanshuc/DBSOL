<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.grpUsrDetails = New System.Windows.Forms.GroupBox()
        Me.txtUserDetail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpUsrDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.lblPwd)
        Me.GroupBox1.Controls.Add(Me.txtPwd)
        Me.GroupBox1.Controls.Add(Me.lblUname)
        Me.GroupBox1.Controls.Add(Me.txtUname)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(83, 115)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(74, 27)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.Location = New System.Drawing.Point(14, 74)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(53, 13)
        Me.lblPwd.TabIndex = 3
        Me.lblPwd.Text = "Password"
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(83, 74)
        Me.txtPwd.MaxLength = 30
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(223, 20)
        Me.txtPwd.TabIndex = 2
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Location = New System.Drawing.Point(14, 48)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(63, 13)
        Me.lblUname.TabIndex = 1
        Me.lblUname.Text = "User Name "
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(83, 48)
        Me.txtUname.MaxLength = 30
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(223, 20)
        Me.txtUname.TabIndex = 0
        '
        'grpUsrDetails
        '
        Me.grpUsrDetails.Controls.Add(Me.txtUserDetail)
        Me.grpUsrDetails.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.grpUsrDetails.Location = New System.Drawing.Point(27, 208)
        Me.grpUsrDetails.Name = "grpUsrDetails"
        Me.grpUsrDetails.Size = New System.Drawing.Size(512, 201)
        Me.grpUsrDetails.TabIndex = 1
        Me.grpUsrDetails.TabStop = False
        Me.grpUsrDetails.Text = "User Profile"
        '
        'txtUserDetail
        '
        Me.txtUserDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserDetail.Location = New System.Drawing.Point(7, 20)
        Me.txtUserDetail.Multiline = True
        Me.txtUserDetail.Name = "txtUserDetail"
        Me.txtUserDetail.ReadOnly = True
        Me.txtUserDetail.Size = New System.Drawing.Size(499, 175)
        Me.txtUserDetail.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(358, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 433)
        Me.Controls.Add(Me.grpUsrDetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpUsrDetails.ResumeLayout(False)
        Me.grpUsrDetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents lblPwd As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents lblUname As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents grpUsrDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserDetail As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
