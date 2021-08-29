Imports MySql.Data.MySqlClient
Public Class Form2
    Private WithEvents _UserControl1 As New UserControl1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel5.Hide()
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


        FlowLayoutPanel1.Controls.Clear()





    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        Label9.Text = selectedRow.Cells(0).Value.ToString()
        Label12.Text = selectedRow.Cells(1).Value.ToString()
        Label13.Text = selectedRow.Cells(2).Value.ToString()
        Label14.Text = selectedRow.Cells(3).Value.ToString()
        Label15.Text = selectedRow.Cells(4).Value.ToString()
        Label16.Text = selectedRow.Cells(5).Value.ToString()
        Label17.Text = selectedRow.Cells(6).Value.ToString()
        Label18.Text = selectedRow.Cells(8).Value.ToString()
        Label19.Text = selectedRow.Cells(7).Value.ToString()
        Label21.Text = selectedRow.Cells(9).Value.ToString()


        FlowLayoutPanel1.Controls.Clear()


        connect()
        Dim cmd As New MySqlCommand("SELECT COUNT(assessed_val) FROM record_of_taxes WHERE aapic = '" & Label9.Text & "'", conbin)
        Dim sqlresult1 As Integer
        sqlresult1 = cmd.ExecuteScalar

        connect()
        Dim cmd1 As New MySqlDataAdapter("SELECT * FROM record_of_taxes WHERE aapic = '" & Label9.Text & "'", conbin)
        Dim table1 As New DataTable
        cmd1.Fill(table1)

        For q = 0 To sqlresult1 - 1
            _UserControl1 = New UserControl1
            FlowLayoutPanel1.Controls.Add(_UserControl1)
            _UserControl1._ass_val = table1.Rows(q).Item(2).ToString
            _UserControl1._tax_yeara = table1.Rows(q).Item(3).ToString
            _UserControl1._td_basse = table1.Rows(q).Item(4).ToString
            _UserControl1._td_sefs = table1.Rows(q).Item(5).ToString
            _UserControl1._td_totals = table1.Rows(q).Item(6).ToString
            _UserControl1._tc_base = table1.Rows(q).Item(7).ToString
            _UserControl1._tc_sefs = table1.Rows(q).Item(8).ToString
            _UserControl1._tc_penta = table1.Rows(q).Item(9).ToString
            _UserControl1._tc_total = table1.Rows(q).Item(10).ToString
            _UserControl1._or_r = table1.Rows(q).Item(11).ToString
            _UserControl1._date_times = table1.Rows(q).Item(12).ToString
            _UserControl1._arrp = table1.Rows(q).Item(1).ToString
        Next



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label22.Text = Date.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        If Label9.Text = "" Then
            MessageBox.Show("Please select a item before proceeding this process!")
        Else
            Form3.Show()
            Me.Hide()

        End If

    End Sub



    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Panel5.Show()
    End Sub

    Private Sub Panel6_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel6.MouseClick
        Form1.Show()
        Panel5.Hide()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
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
            Dim cmd1 As New MySqlDataAdapter("SELECT * FROM reg_data WHERE NAME LIKE '%" & TextBox1.Text & "%'", conbin)
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

    Private Sub Panel7_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick
        Panel5.Hide()
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

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If Label9.Text = "" Then
            MessageBox.Show("Please select a item before proceeding this process!")
        Else
            Form5.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Panel8_MouseClick_1(sender As Object, e As MouseEventArgs) Handles Panel8.MouseClick
        Form4.Show()
        Me.Close()
    End Sub
End Class