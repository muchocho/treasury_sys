Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tax_due = Form2.Label18.Text * 0.01
        Label12.Text = Form2.Label18.Text
        Label13.Text = tax_due
        Label14.Text = tax_due
        Label15.Text = tax_due * 2
        Label16.Text = tax_due
        Label17.Text = tax_due


    End Sub



    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If TextBox2.Text = "" Then
            MessageBox.Show("Please fill out the data needed!")
        Else
            If ComboBox1.Text = "Penalty" Then
                penalty = Label15.Text * TextBox2.Text
                total = Label15.Text + penalty
                Label19.Text = total
            ElseIf ComboBox1.Text = "Discount" Then
                penalty = Label15.Text * TextBox2.Text
                total = Label15.Text - penalty
                Label19.Text = total
            ElseIf ComboBox1.Text = "None" Then
                total = Label15.Text
                Label19.Text = total
            End If
        End If


    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Please fill out the information needed!")
        Else
            per_bar(Form2.Label19.Text, Label12.Text, TextBox1.Text, TextBox3.Text, Form2.Label22.Text)
            payment(Form2.Label9.Text, Form2.Label19.Text, Label12.Text, TextBox1.Text, Label13.Text, Label14.Text, Label15.Text, Label16.Text, Label17.Text, penalty, total, TextBox3.Text, Form2.Label22.Text)
            MessageBox.Show("Payment Successfull!")
            TextBox2.Clear()
            TextBox3.Clear()
            Form2.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Form2.Show()
        Me.Close()
    End Sub
End Class