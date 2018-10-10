<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.connPass = New System.Windows.Forms.TextBox()
        Me.connName = New System.Windows.Forms.TextBox()
        Me.connBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'connPass
        '
        Me.connPass.Location = New System.Drawing.Point(79, 64)
        Me.connPass.Name = "connPass"
        Me.connPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.connPass.Size = New System.Drawing.Size(100, 20)
        Me.connPass.TabIndex = 2
        '
        'connName
        '
        Me.connName.Location = New System.Drawing.Point(79, 32)
        Me.connName.Name = "connName"
        Me.connName.Size = New System.Drawing.Size(100, 20)
        Me.connName.TabIndex = 3
        '
        'connBtn
        '
        Me.connBtn.Location = New System.Drawing.Point(46, 90)
        Me.connBtn.Name = "connBtn"
        Me.connBtn.Size = New System.Drawing.Size(98, 23)
        Me.connBtn.TabIndex = 4
        Me.connBtn.Text = "Connect"
        Me.connBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(713, 415)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(75, 23)
        Me.closeBtn.TabIndex = 5
        Me.closeBtn.Text = "Exit"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.connBtn)
        Me.GroupBox1.Controls.Add(Me.connPass)
        Me.GroupBox1.Controls.Add(Me.connName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 125)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.closeBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents connPass As TextBox
    Friend WithEvents connName As TextBox
    Friend WithEvents connBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
