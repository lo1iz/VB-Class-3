Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, Underline.CheckedChanged, Strikeout.CheckedChanged, Italic.CheckedChanged, Bold.CheckedChanged
        Dim fontstyle As FontStyle = FontStyle.Regular
        If Bold.Checked Then
            fontstyle += FontStyle.Bold

        End If
        If Italic.Checked Then
            fontstyle += FontStyle.Italic
        End If
        If Underline.Checked Then
            fontstyle += FontStyle.Underline
        End If
        If Strikeout.Checked Then
            fontstyle += FontStyle.Strikeout
        End If
        TextBox1.Font = New Font("Areial", 20, fontstyle)
    End Sub
End Class
