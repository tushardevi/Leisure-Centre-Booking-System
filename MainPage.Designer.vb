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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Email_lbl = New System.Windows.Forms.Label()
        Me.Password_lbl = New System.Windows.Forms.Label()
        Me.LogIn_btn = New System.Windows.Forms.Button()
        Me.Email_txtb = New System.Windows.Forms.TextBox()
        Me.Password_txtb = New System.Windows.Forms.TextBox()
        Me.SignUp_ll = New System.Windows.Forms.LinkLabel()
        Me.StaffArea_ll = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Email_lbl
        '
        Me.Email_lbl.AutoSize = True
        Me.Email_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_lbl.Location = New System.Drawing.Point(166, 136)
        Me.Email_lbl.Name = "Email_lbl"
        Me.Email_lbl.Size = New System.Drawing.Size(56, 20)
        Me.Email_lbl.TabIndex = 0
        Me.Email_lbl.Text = "Email"
        '
        'Password_lbl
        '
        Me.Password_lbl.AutoSize = True
        Me.Password_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_lbl.Location = New System.Drawing.Point(166, 179)
        Me.Password_lbl.Name = "Password_lbl"
        Me.Password_lbl.Size = New System.Drawing.Size(91, 20)
        Me.Password_lbl.TabIndex = 1
        Me.Password_lbl.Text = "Password"
        '
        'LogIn_btn
        '
        Me.LogIn_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.LogIn_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.LogIn_btn.Image = CType(resources.GetObject("LogIn_btn.Image"), System.Drawing.Image)
        Me.LogIn_btn.Location = New System.Drawing.Point(282, 254)
        Me.LogIn_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LogIn_btn.Name = "LogIn_btn"
        Me.LogIn_btn.Size = New System.Drawing.Size(121, 50)
        Me.LogIn_btn.TabIndex = 2
        Me.LogIn_btn.Text = "Log In"
        Me.LogIn_btn.UseVisualStyleBackColor = True
        '
        'Email_txtb
        '
        Me.Email_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_txtb.Location = New System.Drawing.Point(282, 136)
        Me.Email_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Email_txtb.Name = "Email_txtb"
        Me.Email_txtb.Size = New System.Drawing.Size(161, 27)
        Me.Email_txtb.TabIndex = 3
        '
        'Password_txtb
        '
        Me.Password_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txtb.Location = New System.Drawing.Point(282, 179)
        Me.Password_txtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Password_txtb.Name = "Password_txtb"
        Me.Password_txtb.Size = New System.Drawing.Size(161, 27)
        Me.Password_txtb.TabIndex = 4
        Me.Password_txtb.UseSystemPasswordChar = True
        '
        'SignUp_ll
        '
        Me.SignUp_ll.AutoSize = True
        Me.SignUp_ll.BackColor = System.Drawing.Color.Yellow
        Me.SignUp_ll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUp_ll.ForeColor = System.Drawing.SystemColors.Desktop
        Me.SignUp_ll.Location = New System.Drawing.Point(232, 70)
        Me.SignUp_ll.Name = "SignUp_ll"
        Me.SignUp_ll.Size = New System.Drawing.Size(197, 20)
        Me.SignUp_ll.TabIndex = 5
        Me.SignUp_ll.TabStop = True
        Me.SignUp_ll.Text = "New member? Sign up"
        '
        'StaffArea_ll
        '
        Me.StaffArea_ll.AutoSize = True
        Me.StaffArea_ll.BackColor = System.Drawing.Color.Maroon
        Me.StaffArea_ll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffArea_ll.LinkColor = System.Drawing.Color.White
        Me.StaffArea_ll.Location = New System.Drawing.Point(544, 12)
        Me.StaffArea_ll.Name = "StaffArea_ll"
        Me.StaffArea_ll.Size = New System.Drawing.Size(94, 20)
        Me.StaffArea_ll.TabIndex = 6
        Me.StaffArea_ll.TabStop = True
        Me.StaffArea_ll.Text = "Staff Area"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 357)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StaffArea_ll)
        Me.Controls.Add(Me.SignUp_ll)
        Me.Controls.Add(Me.Password_txtb)
        Me.Controls.Add(Me.Email_txtb)
        Me.Controls.Add(Me.LogIn_btn)
        Me.Controls.Add(Me.Password_lbl)
        Me.Controls.Add(Me.Email_lbl)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainPage"
        Me.Text = "Main Page.VB"
        Me.TransparencyKey = System.Drawing.Color.Black
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
