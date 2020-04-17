<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.Email_lbl = New System.Windows.Forms.Label()
        Me.Password_lbl = New System.Windows.Forms.Label()
        Me.LogIn_btn = New System.Windows.Forms.Button()
        Me.Email_txtb = New System.Windows.Forms.TextBox()
        Me.Password_txtb = New System.Windows.Forms.TextBox()
        Me.SignUp_ll = New System.Windows.Forms.LinkLabel()
        Me.StaffArea_ll = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Location = New System.Drawing.Point(100, 49)
        Me.Email_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(32, 13)
        Me.Email_lbl.TabIndex = 0
        Me.Email_lbl.Text = "Email"
        '
        'Password_lbl
        '
        Me.Password_lbl.AutoSize = True
        Me.Password_lbl.Location = New System.Drawing.Point(104, 84)
        Me.Password_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Password_lbl.Name = "Password_lbl"
        Me.Password_lbl.Size = New System.Drawing.Size(53, 13)
        Me.Password_lbl.TabIndex = 1
        Me.Password_lbl.Text = "Password"
        '
        'LogIn_btn
        '
        Me.LogIn_btn.Location = New System.Drawing.Point(191, 149)
        Me.LogIn_btn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LogIn_btn.Name = "LogIn_btn"
        Me.LogIn_btn.Size = New System.Drawing.Size(76, 40)
        Me.LogIn_btn.TabIndex = 2
        Me.LogIn_btn.Text = "Log In"
        Me.LogIn_btn.UseVisualStyleBackColor = True
        '
        'Email_txtb
        '
        Me.Email_txtb.Location = New System.Drawing.Point(191, 49)
        Me.Email_txtb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Email_txtb.Name = "Email_txtb"
        Me.Email_txtb.Size = New System.Drawing.Size(122, 20)
        Me.Email_txtb.TabIndex = 3
        '
        'Password_txtb
        '
        Me.Password_txtb.Location = New System.Drawing.Point(191, 84)
        Me.Password_txtb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Password_txtb.Name = "Password_txtb"
        Me.Password_txtb.Size = New System.Drawing.Size(122, 20)
        Me.Password_txtb.TabIndex = 4
        '
        'SignUp_ll
        '
        Me.SignUp_ll.AutoSize = True
        Me.SignUp_ll.Location = New System.Drawing.Point(22, 259)
        Me.SignUp_ll.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SignUp_ll.Name = "SignUp_ll"
        Me.SignUp_ll.Size = New System.Drawing.Size(114, 13)
        Me.SignUp_ll.TabIndex = 5
        Me.SignUp_ll.TabStop = True
        Me.SignUp_ll.Text = "New member? Sign up"
        '
        'StaffArea_ll
        '
        Me.StaffArea_ll.AutoSize = True
        Me.StaffArea_ll.Location = New System.Drawing.Point(426, 259)
        Me.StaffArea_ll.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StaffArea_ll.Name = "StaffArea_ll"
        Me.StaffArea_ll.Size = New System.Drawing.Size(54, 13)
        Me.StaffArea_ll.TabIndex = 6
        Me.StaffArea_ll.TabStop = True
        Me.StaffArea_ll.Text = "Staff Area"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 290)
        Me.Controls.Add(Me.StaffArea_ll)
        Me.Controls.Add(Me.SignUp_ll)
        Me.Controls.Add(Me.Password_txtb)
        Me.Controls.Add(Me.Email_txtb)
        Me.Controls.Add(Me.LogIn_btn)
        Me.Controls.Add(Me.Password_lbl)
        Me.Controls.Add(Me.Email_lbl)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MainPage"
        Me.Text = "Main Page.VB"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Email_lbl As Label
    Friend WithEvents Password_lbl As Label
    Friend WithEvents LogIn_btn As Button
    Friend WithEvents Email_txtb As TextBox
    Friend WithEvents Password_txtb As TextBox
    Friend WithEvents SignUp_ll As LinkLabel
    Friend WithEvents StaffArea_ll As LinkLabel
End Class
