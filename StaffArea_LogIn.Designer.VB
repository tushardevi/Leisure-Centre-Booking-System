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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffArea_Login))
        Me.StaffID_lbl = New System.Windows.Forms.Label()
        Me.Password__lbl = New System.Windows.Forms.Label()
        Me.Menu_btn = New System.Windows.Forms.Button()
        Me.LogIn_btn = New System.Windows.Forms.Button()
        Me.StaffID_txtb = New System.Windows.Forms.TextBox()
        Me.Password_txtb = New System.Windows.Forms.TextBox()
        Me.AddNewStaff_ll = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'StaffID_lbl
        '
        Me.StaffID_lbl.AutoSize = True
        Me.StaffID_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffID_lbl.Location = New System.Drawing.Point(122, 101)
        Me.StaffID_lbl.Name = "StaffID_lbl"
        Me.StaffID_lbl.Size = New System.Drawing.Size(74, 20)
        Me.StaffID_lbl.TabIndex = 0
        Me.StaffID_lbl.Text = "Staff ID"
        '
        'Password__lbl
        '
        Me.Password__lbl.AutoSize = True
        Me.Password__lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password__lbl.Location = New System.Drawing.Point(114, 150)
        Me.Password__lbl.Name = "Password__lbl"
        Me.Password__lbl.Size = New System.Drawing.Size(91, 20)
        Me.Password__lbl.TabIndex = 1
        Me.Password__lbl.Text = "Password"
        '
        'Menu_btn
        '
        Me.Menu_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Menu_btn.Image = CType(resources.GetObject("Menu_btn.Image"), System.Drawing.Image)
        Me.Menu_btn.Location = New System.Drawing.Point(477, 12)
        Me.Menu_btn.Name = "Menu_btn"
        Me.Menu_btn.Size = New System.Drawing.Size(82, 31)
        Me.Menu_btn.TabIndex = 2
        Me.Menu_btn.Text = "Menu"
        Me.Menu_btn.UseVisualStyleBackColor = True
        '
        'LogIn_btn
        '
        Me.LogIn_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn_btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LogIn_btn.Image = CType(resources.GetObject("LogIn_btn.Image"), System.Drawing.Image)
        Me.LogIn_btn.Location = New System.Drawing.Point(195, 249)
        Me.LogIn_btn.Name = "LogIn_btn"
        Me.LogIn_btn.Size = New System.Drawing.Size(151, 70)
        Me.LogIn_btn.TabIndex = 3
        Me.LogIn_btn.Text = "Log In"
        Me.LogIn_btn.UseVisualStyleBackColor = True
        '
        'StaffID_txtb
        '
        Me.StaffID_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffID_txtb.Location = New System.Drawing.Point(211, 101)
        Me.StaffID_txtb.Name = "StaffID_txtb"
        Me.StaffID_txtb.Size = New System.Drawing.Size(157, 27)
        Me.StaffID_txtb.TabIndex = 4
        '
        'Password_txtb
        '
        Me.Password_txtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txtb.Location = New System.Drawing.Point(211, 150)
        Me.Password_txtb.Name = "Password_txtb"
        Me.Password_txtb.Size = New System.Drawing.Size(157, 27)
        Me.Password_txtb.TabIndex = 5
        Me.Password_txtb.UseSystemPasswordChar = True
        '
        'AddNewStaff_ll
        '
        Me.AddNewStaff_ll.AutoSize = True
        Me.AddNewStaff_ll.BackColor = System.Drawing.Color.Lime
        Me.AddNewStaff_ll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewStaff_ll.ForeColor = System.Drawing.Color.Yellow
        Me.AddNewStaff_ll.LinkColor = System.Drawing.Color.White
        Me.AddNewStaff_ll.Location = New System.Drawing.Point(191, 15)
        Me.AddNewStaff_ll.Name = "AddNewStaff_ll"
        Me.AddNewStaff_ll.Size = New System.Drawing.Size(197, 20)
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
        Me.Controls.Add(Me.StaffID_txtb)
        Me.Controls.Add(Me.LogIn_btn)
        Me.Controls.Add(Me.Menu_btn)
        Me.Controls.Add(Me.Password__lbl)
        Me.Controls.Add(Me.StaffID_lbl)
        Me.Name = "StaffArea_Login"
        Me.Text = "StaffArea_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StaffID_lbl As Label
    Friend WithEvents Password__lbl As Label
    Friend WithEvents Menu_btn As Button
    Friend WithEvents LogIn_btn As Button
    Friend WithEvents StaffID_txtb As TextBox
    Friend WithEvents Password_txtb As TextBox
    Friend WithEvents AddNewStaff_ll As LinkLabel
End Class
