Imports MySql.Data.MySqlClient
Public Class Form1



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = Date.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Hide()
        Timer1.Enabled = True
        connect()
        Dim cmd As New MySqlDataAdapter("SELECT * FROM reg_data", conbin)
        Dim table As New DataTable
        cmd.Fill(table)

        DataGridView1.DataSource = table
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MessageBox.Show("Please fill out all the information needed!")
        Else
            register(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, ComboBox1.Text, Label9.Text)
            MessageBox.Show("Successfully Registered!")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox1.Focus()
            connect()
            Dim cmd As New MySqlDataAdapter("SELECT * FROM reg_data", conbin)
            Dim table As New DataTable
            cmd.Fill(table)

            DataGridView1.DataSource = table
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False


        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = "" Then
            connect()
            Dim cmd As New MySqlDataAdapter("SELECT * FROM reg_data", conbin)
            Dim table As New DataTable
            cmd.Fill(table)

            DataGridView1.DataSource = table
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
        Else
            connect()
            Dim cmd1 As New MySqlDataAdapter("SELECT * FROM reg_data WHERE NAME LIKE '%" & TextBox10.Text & "%'", conbin)
            Dim table1 As New DataTable
            cmd1.Fill(table1)
            DataGridView1.DataSource = table1
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
        End If
    End Sub

    Private Sub Panel6_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel6.MouseClick
        Panel3.Hide()
    End Sub

    Private Sub Panel7_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick
        Form2.Show()
        Panel3.Hide()

        connect()
        Dim cmd As New MySqlDataAdapter("SELECT * FROM reg_data", conbin)
        Dim table As New DataTable
        cmd.Fill(table)

        Form2.DataGridView1.DataSource = table
        Form2.DataGridView1.Columns(0).Visible = False
        Form2.DataGridView1.Columns(1).Visible = False
        Form2.DataGridView1.Columns(2).Visible = False
        Form2.DataGridView1.Columns(4).Visible = False
        Form2.DataGridView1.Columns(5).Visible = False
        Form2.DataGridView1.Columns(6).Visible = False
        Form2.DataGridView1.Columns(7).Visible = False
        Form2.DataGridView1.Columns(8).Visible = False
        Form2.DataGridView1.Columns(9).Visible = False
        Form2.DataGridView1.Columns(10).Visible = False
        Me.Hide()
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Panel3.Show()
    End Sub

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel8.MouseClick
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class
