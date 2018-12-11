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
        Me.Bold = New System.Windows.Forms.CheckBox()
        Me.Italic = New System.Windows.Forms.CheckBox()
        Me.Underline = New System.Windows.Forms.CheckBox()
        Me.Strikeout = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Bold
        '
        Me.Bold.AutoSize = True
        Me.Bold.Location = New System.Drawing.Point(44, 65)
        Me.Bold.Name = "Bold"
        Me.Bold.Size = New System.Drawing.Size(47, 17)
        Me.Bold.TabIndex = 0
        Me.Bold.Text = "Bold"
        Me.Bold.UseVisualStyleBackColor = True
        '
        'Italic
        '
        Me.Italic.AutoSize = True
        Me.Italic.Location = New System.Drawing.Point(131, 65)
        Me.Italic.Name = "Italic"
        Me.Italic.Size = New System.Drawing.Size(48, 17)
        Me.Italic.TabIndex = 1
        Me.Italic.Text = "Italic"
        Me.Italic.UseVisualStyleBackColor = True
        '
        'Underline
        '
        Me.Underline.AutoSize = True
        Me.Underline.Location = New System.Drawing.Point(218, 65)
        Me.Underline.Name = "Underline"
        Me.Underline.Size = New System.Drawing.Size(71, 17)
        Me.Underline.TabIndex = 2
        Me.Underline.Text = "Underline"
        Me.Underline.UseVisualStyleBackColor = True
        '
        'Strikeout
        '
        Me.Strikeout.AutoSize = True
        Me.Strikeout.Location = New System.Drawing.Point(306, 65)
        Me.Strikeout.Name = "Strikeout"
        Me.Strikeout.Size = New System.Drawing.Size(68, 17)
        Me.Strikeout.TabIndex = 3
        Me.Strikeout.Text = "Strikeout"
        Me.Strikeout.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(44, 131)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(330, 64)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Simpletext"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 249)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Strikeout)
        Me.Controls.Add(Me.Underline)
        Me.Controls.Add(Me.Italic)
        Me.Controls.Add(Me.Bold)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bold As CheckBox
    Friend WithEvents Italic As CheckBox
    Friend WithEvents Underline As CheckBox
    Friend WithEvents Strikeout As CheckBox
    Friend WithEvents TextBox1 As TextBox
End Class
