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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RDMale = New System.Windows.Forms.RadioButton()
        Me.RDFemale = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkThai = New System.Windows.Forms.CheckBox()
        Me.chkEnglish = New System.Windows.Forms.CheckBox()
        Me.chkJapan = New System.Windows.Forms.CheckBox()
        Me.chkChina = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.TextBoxOther = New System.Windows.Forms.TextBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelConfirm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm-Password"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(94, 24)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxUsername.TabIndex = 3
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(94, 51)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxPassword.TabIndex = 4
        '
        'TextBoxConfirm
        '
        Me.TextBoxConfirm.Location = New System.Drawing.Point(94, 77)
        Me.TextBoxConfirm.Name = "TextBoxConfirm"
        Me.TextBoxConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirm.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxConfirm.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender"
        '
        'RDMale
        '
        Me.RDMale.AutoSize = True
        Me.RDMale.Location = New System.Drawing.Point(94, 106)
        Me.RDMale.Name = "RDMale"
        Me.RDMale.Size = New System.Drawing.Size(48, 17)
        Me.RDMale.TabIndex = 7
        Me.RDMale.TabStop = True
        Me.RDMale.Text = "Male"
        Me.RDMale.UseVisualStyleBackColor = True
        '
        'RDFemale
        '
        Me.RDFemale.AutoSize = True
        Me.RDFemale.Location = New System.Drawing.Point(158, 106)
        Me.RDFemale.Name = "RDFemale"
        Me.RDFemale.Size = New System.Drawing.Size(59, 17)
        Me.RDFemale.TabIndex = 8
        Me.RDFemale.TabStop = True
        Me.RDFemale.Text = "Female"
        Me.RDFemale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Language"
        '
        'chkThai
        '
        Me.chkThai.AutoSize = True
        Me.chkThai.Location = New System.Drawing.Point(94, 137)
        Me.chkThai.Name = "chkThai"
        Me.chkThai.Size = New System.Drawing.Size(47, 17)
        Me.chkThai.TabIndex = 10
        Me.chkThai.Text = "Thai"
        Me.chkThai.UseVisualStyleBackColor = True
        '
        'chkEnglish
        '
        Me.chkEnglish.AutoSize = True
        Me.chkEnglish.Location = New System.Drawing.Point(94, 161)
        Me.chkEnglish.Name = "chkEnglish"
        Me.chkEnglish.Size = New System.Drawing.Size(60, 17)
        Me.chkEnglish.TabIndex = 11
        Me.chkEnglish.Text = "English"
        Me.chkEnglish.UseVisualStyleBackColor = True
        '
        'chkJapan
        '
        Me.chkJapan.AutoSize = True
        Me.chkJapan.Location = New System.Drawing.Point(94, 185)
        Me.chkJapan.Name = "chkJapan"
        Me.chkJapan.Size = New System.Drawing.Size(55, 17)
        Me.chkJapan.TabIndex = 12
        Me.chkJapan.Text = "Japan"
        Me.chkJapan.UseVisualStyleBackColor = True
        '
        'chkChina
        '
        Me.chkChina.AutoSize = True
        Me.chkChina.Location = New System.Drawing.Point(94, 209)
        Me.chkChina.Name = "chkChina"
        Me.chkChina.Size = New System.Drawing.Size(64, 17)
        Me.chkChina.TabIndex = 13
        Me.chkChina.Text = "Chinese"
        Me.chkChina.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Location = New System.Drawing.Point(94, 233)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(58, 17)
        Me.chkOther.TabIndex = 14
        Me.chkOther.Text = "Other :"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'TextBoxOther
        '
        Me.TextBoxOther.Enabled = False
        Me.TextBoxOther.Location = New System.Drawing.Point(158, 230)
        Me.TextBoxOther.Name = "TextBoxOther"
        Me.TextBoxOther.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOther.TabIndex = 15
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(26, 269)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(82, 36)
        Me.ButtonRegister.TabIndex = 16
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(130, 269)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(82, 36)
        Me.ButtonReset.TabIndex = 17
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'LabelPassword
        '
        Me.LabelPassword.Location = New System.Drawing.Point(259, 54)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(100, 23)
        Me.LabelPassword.TabIndex = 18
        '
        'LabelConfirm
        '
        Me.LabelConfirm.Location = New System.Drawing.Point(260, 80)
        Me.LabelConfirm.Name = "LabelConfirm"
        Me.LabelConfirm.Size = New System.Drawing.Size(100, 23)
        Me.LabelConfirm.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 326)
        Me.Controls.Add(Me.LabelConfirm)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.TextBoxOther)
        Me.Controls.Add(Me.chkOther)
        Me.Controls.Add(Me.chkChina)
        Me.Controls.Add(Me.chkJapan)
        Me.Controls.Add(Me.chkEnglish)
        Me.Controls.Add(Me.chkThai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RDFemale)
        Me.Controls.Add(Me.RDMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxConfirm)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
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
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxConfirm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RDMale As RadioButton
    Friend WithEvents RDFemale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents chkThai As CheckBox
    Friend WithEvents chkEnglish As CheckBox
    Friend WithEvents chkJapan As CheckBox
    Friend WithEvents chkChina As CheckBox
    Friend WithEvents chkOther As CheckBox
    Friend WithEvents TextBoxOther As TextBox
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelConfirm As Label
End Class
