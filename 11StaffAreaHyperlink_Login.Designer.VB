<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffArea_Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.LogIn_btn = New System.Windows.Forms.Button()
        Me.Username_txtb = New System.Windows.Forms.TextBox()
        Me.Password_txtb = New System.Windows.Forms.TextBox()
        Me.AddNewStaff_ll = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Menu_btn
        '
        Me.Menu_btn.Location = New System.Drawing.Point(484, 12)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(75, 23)
        Me.Menu_btn.TabIndex = 2
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'LogIn_btn
        '
        Me.LogIn_btn.Location = New System.Drawing.Point(195, 249)
        Me.LogIn_btn.Name = "LogIn_btn"
        Me.LogIn_btn.Size = New System.Drawing.Size(151, 70)
        Me.LogIn_btn.TabIndex = 3
        Me.LogIn_btn.Text = "Log In"
        Me.LogIn_btn.UseVisualStyleBackColor = True
        '
        'Username_txtb
        '
        Me.Username_txtb.Location = New System.Drawing.Point(211, 101)
        Me.Username_txtb.Name = "Username_txtb"
        Me.Username_txtb.Size = New System.Drawing.Size(157, 22)
        Me.Username_txtb.TabIndex = 4
        '
        'Password_txtb
        '
        Me.Password_txtb.Location = New System.Drawing.Point(211, 150)
        Me.Password_txtb.Name = "Password_txtb"
        Me.Password_txtb.Size = New System.Drawing.Size(157, 22)
        Me.Password_txtb.TabIndex = 5
        '
        'AddNewStaff_ll
        '
        Me.AddNewStaff_ll.AutoSize = True
        Me.AddNewStaff_ll.Location = New System.Drawing.Point(208, 18)
        Me.AddNewStaff_ll.Name = "AddNewStaff_ll"
        Me.AddNewStaff_ll.Size = New System.Drawing.Size(148, 17)
        Me.AddNewStaff_ll.TabIndex = 6
        Me.AddNewStaff_ll.TabStop = True
        Me.AddNewStaff_ll.Text = "Add new staff member"
        '
        'StaffArea_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 387)
        Me.Controls.Add(Me.AddNewStaff_ll)
        Me.Controls.Add(Me.Password_txtb)
        Me.Controls.Add(Me.Username_txtb)
        Me.Controls.Add(Me.LogIn_btn)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffArea_Login"
        Me.Text = "StaffArea_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Menu_btn As Button
    Friend WithEvents LogIn_btn As Button
    Friend WithEvents Username_txtb As TextBox
    Friend WithEvents Password_txtb As TextBox
    Friend WithEvents AddNewStaff_ll As LinkLabel
End Class
