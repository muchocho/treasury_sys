Imports MySql.Data.MySqlClient
Module Module1
    Public conbin As New MySqlConnection("server=localhost;database=treasury_data;uid=root;pwd=root;")

    Public tax_due As Decimal
    Public penalty As Decimal
    Public total As Decimal
    Public Sub connect()
        If conbin.State = ConnectionState.Open Then
            conbin.Close()
            conbin.Open()
        Else
            conbin.Open()
        End If
    End Sub

    Public Function register(_pic As Integer, _lop As String, _doe As String, _name As String, _barangay As String, _munci As String, _province As String, _arp As String, _assessed As String, _type As String, _date As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO reg_data(apic,alop,adoe,NAME,barangay,municipality,province,aarp,assessed_val,type,date)VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11)", conbin)
        With cmd
            .Parameters.AddWithValue("@1", _pic)
            .Parameters.AddWithValue("@2", _lop)
            .Parameters.AddWithValue("@3", _doe)
            .Parameters.AddWithValue("@4", _name)
            .Parameters.AddWithValue("@5", _barangay)
            .Parameters.AddWithValue("@6", _munci)
            .Parameters.AddWithValue("@7", _province)
            .Parameters.AddWithValue("@8", _arp)
            .Parameters.AddWithValue("@9", _assessed)
            .Parameters.AddWithValue("@10", _type)
            .Parameters.AddWithValue("@11", _date)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

    Public Function per_bar(_arpp As String, _ass_val As String, _t_year As String, _orno As String, _dopay As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO per_barangay(arpp,ass_val,t_year,orno,dopay)VALUES(@1,@2,@3,@4,@5)", conbin)
        With cmd
            .Parameters.AddWithValue("@1", _arpp)
            .Parameters.AddWithValue("@2", _ass_val)
            .Parameters.AddWithValue("@3", _t_year)
            .Parameters.AddWithValue("@4", _orno)
            .Parameters.AddWithValue("@5", _dopay)
            .ExecuteNonQuery()
        End With
        Return True
    End Function
    Public Function payment(_pic As Integer, _arp As String, _assess_val As String, _tax_year As String, _td_basic As String, _td_sef As String, _td_total As String, _tc_basic As String, _tc_sef As String, _tc_penalty As String, _tc_total As String, _or_no As String, _date_payment As String)
        connect()
        Dim cmd As New MySqlCommand("INSERT INTO record_of_taxes(aapic,aarp,assessed_val,tax_year,td_basic,td_sef,td_total,tc_basic,tc_sef,tc_penalty,tc_total,or_no,date_payment)VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13)", conbin)
        With cmd
            .Parameters.AddWithValue("@1", _pic)
            .Parameters.AddWithValue("@2", _arp)
            .Parameters.AddWithValue("@3", _assess_val)
            .Parameters.AddWithValue("@4", _tax_year)
            .Parameters.AddWithValue("@5", _td_basic)
            .Parameters.AddWithValue("@6", _td_sef)
            .Parameters.AddWithValue("@7", _td_total)
            .Parameters.AddWithValue("@8", _tc_basic)
            .Parameters.AddWithValue("@9", _tc_sef)
            .Parameters.AddWithValue("@10", _tc_penalty)
            .Parameters.AddWithValue("@11", _tc_total)
            .Parameters.AddWithValue("@12", _or_no)
            .Parameters.AddWithValue("@13", _date_payment)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

    Public Function login(_id As Integer, _pass As String)
        connect()
        Dim cmd As New MySqlCommand("SELECT * FROM accounts WHERE id_ = @1 AND password = @2", conbin)
        cmd.Parameters.AddWithValue("@1", _id)
        cmd.Parameters.AddWithValue("@2", _pass)
        Dim dt As New DataTable
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        dt.Load(dr)
        Return dt
    End Function

    Public Function reass(_arp As String, _ass_val As String, _card_id As Integer)
        connect()
        Dim cmd As New MySqlCommand("UPDATE reg_data SET aarp = @1, assessed_val = @2 WHERE apic = @3", conbin)
        With cmd
            .Parameters.AddWithValue("@1", _arp)
            .Parameters.AddWithValue("@2", _ass_val)
            .Parameters.AddWithValue("@3", _card_id)
            .ExecuteNonQuery()
        End With
        Return True
    End Function

End Module
