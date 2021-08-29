Public Class Form5
    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please fill out the information needed!")
        Else
            reass(TextBox1.Text, TextBox2.Text, Form2.Label9.Text)
            MessageBox.Show("Information Saved!")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
            Form2.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Form2.Show()
        Me.Close()
    End Sub
End Class