Public Class BBQ
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim num_customer As Integer
        Dim total1 As Double
        Dim total2 As Double
        Dim Sale As Double
        Try
            num_customer = CInt(TextBoxNum.Text)
        Catch ex As Exception
            MessageBox.Show("กรุุณาป้อนจำนวนลูกค้าเป็นตัวเลข", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxNum.Text = ""
            ButtonCalculate.Enabled = False
            ButtonClear.Enabled = False
            Exit Sub
        End Try
        If RDFriends.Checked = False And RDBuddy.Checked = False And RDNo.Checked = False Then
            MessageBox.Show("กรุุณาเลือกประเภทบัตรสมาชิก", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If RDFriends.Checked = True Then
            total1 = (num_customer * 299)
            Sale = (total1 * 5) / 100
            total2 = total1 - Sale
            LabelTotal.Text = Format(total2, "#,###.00 Baht")
        End If
        If RDBuddy.Checked = True Then
            total1 = (num_customer * 299)
            Sale = (total1 * 10) / 100
            total2 = total1 - Sale
            LabelTotal.Text = Format(total2, "#,###.00 Baht")
        End If
        If RDNo.Checked = True Then
            total1 = (num_customer * 299)
            total2 = total1
            LabelTotal.Text = Format(total2, "#,###.00 Baht")
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNum.Text = ""
        RDFriends.Checked = False
        RDBuddy.Checked = False
        RDNo.Checked = False
        ButtonCalculate.Enabled = False
        ButtonClear.Enabled = False
    End Sub

    Private Sub RDNo_CheckedChanged(sender As Object, e As EventArgs) Handles RDNo.CheckedChanged, RDFriends.CheckedChanged, RDBuddy.CheckedChanged

    End Sub

    Private Sub TextBoxNum_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNum.TextChanged
        If TextBoxNum.TextLength >= 1 Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = True
        Else
            ButtonCalculate.Enabled = False
            ButtonClear.Enabled = False
        End If
    End Sub
End Class
