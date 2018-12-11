Public Class Form1
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If TextBoxUsername.Text = "" Then
            MessageBox.Show("Please insert Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If TextBoxPassword.Text = "" Then
            MessageBox.Show("Please insert Password or Confirm-Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If RDFemale.Checked = False And RDMale.Checked = False Then
            MessageBox.Show("Please Choose your gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If chkThai.Checked = False And chkEnglish.Checked = False And chkJapan.Checked = False And chkChina.Checked = False Then
            MessageBox.Show("Please Choose language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If chkOther.Checked = True And TextboxOther.text = "" Then
            MessageBox.Show("Please insert Other language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim gender As String
        If RDFemale.Checked = True Then
            gender = "Female"
        End If
        If RDMale.Checked = True Then
            gender = "Male"
        End If
        Dim lan As String
        If chkThai.Checked Then
            lan += "Thai"
        End If
        If chkEnglish.Checked Then
            lan += " English"
        End If
        If chkJapan.Checked Then
            lan += " japan"
        End If
        If chkChina.Checked Then
            lan += " Chinese"
        End If
        If chkOther.Checked Then
            TextBoxOther.ReadOnly = False
            lan += TextBoxOther.Text = ""
        End If
        MessageBox.Show("Username: " & TextBoxUsername.Text & vbNewLine &
                         "Gender: " & gender & vbNewLine &
                         "You can speak: " & lan)
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        RDFemale.Checked = False
        RDMale.Checked = False
        chkThai.Checked = False
        chkEnglish.Checked = False
        chkJapan.Checked = False
        chkChina.Checked = False
    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged, TextBoxPassword.TabIndexChanged
        If TextBoxPassword.TextLength <= 5 Then
            LabelPassword.Text = "Quality: Low"
            LabelPassword.ForeColor = Color.Red
        End If
        If TextBoxPassword.TextLength <= 10 And TextBoxPassword.TextLength > 5 Then
            LabelPassword.Text = "Quality: Medium"
            LabelPassword.ForeColor = Color.Orange
        End If
        If TextBoxPassword.TextLength > 10 Then
            LabelPassword.Text = "Quality: High"
            LabelPassword.ForeColor = Color.Green
        End If
    End Sub

    Private Sub TextBoxConfirm_TextChanged(sender As Object, e As EventArgs) Handles TextBoxConfirm.TextChanged
        Dim pass As String = TextBoxPassword.Text
        If TextBoxConfirm.Text = pass Then
            LabelConfirm.Text = "Correct"
            LabelConfirm.ForeColor = Color.Green
        Else
            LabelConfirm.Text = "Incorrect"
            LabelConfirm.ForeColor = Color.Red
        End If
    End Sub
End Class
