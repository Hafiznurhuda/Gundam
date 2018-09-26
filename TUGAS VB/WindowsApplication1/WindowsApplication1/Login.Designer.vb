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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBUser = New System.Windows.Forms.TextBox()
        Me.TBpw = New System.Windows.Forms.TextBox()
        Me.BTLogin = New System.Windows.Forms.Button()
        Me.BTClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(88, 27)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(156, 20)
        Me.TBUser.TabIndex = 2
        '
        'TBpw
        '
        Me.TBpw.Location = New System.Drawing.Point(88, 76)
        Me.TBpw.Name = "TBpw"
        Me.TBpw.Size = New System.Drawing.Size(156, 20)
        Me.TBpw.TabIndex = 3
        '
        'BTLogin
        '
        Me.BTLogin.Location = New System.Drawing.Point(88, 115)
        Me.BTLogin.Name = "BTLogin"
        Me.BTLogin.Size = New System.Drawing.Size(75, 23)
        Me.BTLogin.TabIndex = 4
        Me.BTLogin.Text = "Login"
        Me.BTLogin.UseVisualStyleBackColor = True
        '
        'BTClose
        '
        Me.BTClose.Location = New System.Drawing.Point(169, 115)
        Me.BTClose.Name = "BTClose"
        Me.BTClose.Size = New System.Drawing.Size(75, 23)
        Me.BTClose.TabIndex = 5
        Me.BTClose.Text = "Close"
        Me.BTClose.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 155)
        Me.Controls.Add(Me.BTClose)
        Me.Controls.Add(Me.BTLogin)
        Me.Controls.Add(Me.TBpw)
        Me.Controls.Add(Me.TBUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBUser As System.Windows.Forms.TextBox
    Friend WithEvents TBpw As System.Windows.Forms.TextBox
    Friend WithEvents BTLogin As System.Windows.Forms.Button
    Friend WithEvents BTClose As System.Windows.Forms.Button
End Class
