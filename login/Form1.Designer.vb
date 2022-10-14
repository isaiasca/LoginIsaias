<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpassw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(209, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(110, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(110, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(181, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(199, 125)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(153, 23)
        Me.txtemail.TabIndex = 4
        '
        'txtpassw
        '
        Me.txtpassw.Location = New System.Drawing.Point(199, 172)
        Me.txtpassw.Name = "txtpassw"
        Me.txtpassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassw.Size = New System.Drawing.Size(153, 23)
        Me.txtpassw.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(483, 450)
        Me.Controls.Add(Me.txtpassw)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpassw As TextBox
End Class
