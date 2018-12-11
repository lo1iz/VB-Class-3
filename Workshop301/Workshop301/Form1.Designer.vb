<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BBQ
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
        Me.TextBoxNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.RDFriends = New System.Windows.Forms.RadioButton()
        Me.RDBuddy = New System.Windows.Forms.RadioButton()
        Me.RDNo = New System.Windows.Forms.RadioButton()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "จำนวนลูกค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "คน ต่อโต๊ะ"
        '
        'TextBoxNum
        '
        Me.TextBoxNum.Location = New System.Drawing.Point(124, 59)
        Me.TextBoxNum.Name = "TextBoxNum"
        Me.TextBoxNum.Size = New System.Drawing.Size(43, 20)
        Me.TextBoxNum.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ประเภทบัตรสมาชิก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ราคารวม"
        '
        'LabelTotal
        '
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotal.Location = New System.Drawing.Point(124, 181)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(100, 23)
        Me.LabelTotal.TabIndex = 8
        '
        'RDFriends
        '
        Me.RDFriends.AutoSize = True
        Me.RDFriends.Location = New System.Drawing.Point(125, 103)
        Me.RDFriends.Name = "RDFriends"
        Me.RDFriends.Size = New System.Drawing.Size(84, 17)
        Me.RDFriends.TabIndex = 9
        Me.RDFriends.TabStop = True
        Me.RDFriends.Text = "BBQ Friends"
        Me.RDFriends.UseVisualStyleBackColor = True
        '
        'RDBuddy
        '
        Me.RDBuddy.AutoSize = True
        Me.RDBuddy.Location = New System.Drawing.Point(125, 127)
        Me.RDBuddy.Name = "RDBuddy"
        Me.RDBuddy.Size = New System.Drawing.Size(80, 17)
        Me.RDBuddy.TabIndex = 10
        Me.RDBuddy.TabStop = True
        Me.RDBuddy.Text = "BBQ Buddy"
        Me.RDBuddy.UseVisualStyleBackColor = True
        '
        'RDNo
        '
        Me.RDNo.AutoSize = True
        Me.RDNo.Location = New System.Drawing.Point(125, 151)
        Me.RDNo.Name = "RDNo"
        Me.RDNo.Size = New System.Drawing.Size(97, 17)
        Me.RDNo.TabIndex = 11
        Me.RDNo.TabStop = True
        Me.RDNo.Text = "ไม่มีบัตรสมาชิก"
        Me.RDNo.UseVisualStyleBackColor = True
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Enabled = False
        Me.ButtonCalculate.Location = New System.Drawing.Point(47, 240)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(84, 35)
        Me.ButtonCalculate.TabIndex = 12
        Me.ButtonCalculate.Text = "คำนวณราคา"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Enabled = False
        Me.ButtonClear.Location = New System.Drawing.Point(147, 240)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(81, 35)
        Me.ButtonClear.TabIndex = 13
        Me.ButtonClear.Text = "ล้างข้อมูล"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'BBQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 316)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.RDNo)
        Me.Controls.Add(Me.RDBuddy)
        Me.Controls.Add(Me.RDFriends)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BBQ"
        Me.Text = "BBQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents RDFriends As RadioButton
    Friend WithEvents RDBuddy As RadioButton
    Friend WithEvents RDNo As RadioButton
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button
End Class
