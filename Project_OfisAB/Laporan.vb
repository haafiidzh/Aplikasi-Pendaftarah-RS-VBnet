Imports System.Data.OleDb

Public Class Laporan
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable

    Sub koneksi()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_rs.accdb")
    End Sub

    Sub tampilpasien()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            con.Open()
            da = New OleDbDataAdapter("SELECT no_rm,nama_pasien,alamat,jkelamin,tgl_lahir,tmp_lahir,telp,nama_bangsal,jpasien,tgl_masuk FROM pasien", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Sub tampilex_pasien()
        DataGridView2.Rows.Clear()
        Try
            koneksi()
            da = New OleDbDataAdapter("SELECT nama_pasien,alamat,jkelamin,tgl_lahir,tmp_lahir,telp,nama_bangsal,jpasien,tgl_masuk,tgl_keluar FROM [ex_pasien]", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView2.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilpasien()
        tampilex_pasien()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class