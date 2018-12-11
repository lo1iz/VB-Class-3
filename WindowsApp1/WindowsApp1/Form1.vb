Public Class Form1
    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength >= 1 Then
            Label1.Text = "Low"
            Label1.BackColor = Color.Red
        End If
        If TextBox1.TextLength >= 7 Then
            Label1.Text = "Medium"
            Label1.BackColor = Color.Orange
        End If
        If TextBox1.TextLength >= 10 Then
            Label1.Text = "High"
            Label1.BackColor = Color.Green
        End If
    End Sub
End Class
