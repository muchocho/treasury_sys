Public Class Form4
    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please fill out the information needed!")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        Else
            Try
                Dim dt As DataTable = login(TextBox1.Text, TextBox2.Text)
                If dt.Rows.Count > 0 Then
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                    Form2.Show()
                    Me.Hide()
                Else
                    MsgBox("Invalid userid or password!!!", vbInformation)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbInformation)
            End Try
        End If
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Me.Close()
    End Sub
End Class