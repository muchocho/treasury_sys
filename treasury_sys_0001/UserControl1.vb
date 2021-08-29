Public Class UserControl1
    Private ass_val As String
    Private tax_yeara As String
    Private td_base As Decimal
    Private td_sefs As Decimal
    Private td_totals As Decimal
    Private tc_base As Decimal
    Private tc_sefs As Decimal
    Private tc_penta As Decimal
    Private tc_total As Decimal
    Private or_r As String
    Private date_times As String
    Private arrp As String
    Public Property _ass_val As String
        Get
            Return ass_val
        End Get
        Set(value As String)
            ass_val = value
            Label1.Text = value
        End Set
    End Property

    Public Property _tax_yeara As String
        Get
            Return tax_yeara
        End Get
        Set(value As String)
            tax_yeara = value
            Label2.Text = value
        End Set
    End Property

    Public Property _td_basse As Decimal
        Get
            Return td_base
        End Get
        Set(value As Decimal)
            td_base = value
            Label3.Text = value
        End Set
    End Property

    Public Property _td_sefs As Decimal
        Get
            Return td_sefs
        End Get
        Set(value As Decimal)
            td_sefs = value
            Label4.Text = value
        End Set
    End Property

    Public Property _td_totals As Decimal
        Get
            Return td_totals
        End Get
        Set(value As Decimal)
            td_totals = value
            Label5.Text = value
        End Set
    End Property

    Public Property _tc_base As Decimal
        Get
            Return tc_base
        End Get
        Set(value As Decimal)
            tc_base = value
            Label6.Text = value
        End Set
    End Property

    Public Property _tc_sefs As Decimal
        Get
            Return tc_sefs
        End Get
        Set(value As Decimal)
            tc_sefs = value
            Label7.Text = value
        End Set
    End Property

    Public Property _tc_penta As Decimal
        Get
            Return tc_penta
        End Get
        Set(value As Decimal)
            tc_penta = value
            Label8.Text = value
        End Set
    End Property

    Public Property _tc_total As Decimal
        Get
            Return tc_total
        End Get
        Set(value As Decimal)
            tc_total = value
            Label9.Text = value
        End Set
    End Property

    Public Property _or_r As String
        Get
            Return or_r
        End Get
        Set(value As String)
            or_r = value
            Label10.Text = value
        End Set
    End Property

    Public Property _date_times As String
        Get
            Return date_times
        End Get
        Set(value As String)
            date_times = value
            Label11.Text = value
        End Set
    End Property

    Public Property _arrp As String
        Get
            Return arrp
        End Get
        Set(value As String)
            arrp = value
            Label12.Text = value
        End Set
    End Property

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class
