Imports System.Data.OleDb

Public Class Home
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable

    Sub koneksi()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_rs.accdb")
    End Sub

    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OleDbDataAdapter("SELECT no_rm,nama_pasien,alamat,jkelamin,nama_bangsal FROM [pasien]", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL", MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub pbtt_Click(sender As Object, e As EventArgs) Handles pbtt.Click
        Pendaftaran.ShowDialog()
    End Sub

    Private Sub dbtt_Click(sender As Object, e As EventArgs) Handles dbtt.Click
        DataPasien.ShowDialog()
    End Sub

    Private Sub lbtt_Click(sender As Object, e As EventArgs) Handles lbtt.Click
        Laporan.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String
        a = MessageBox.Show("Apakah Anda yakin ingin keluar?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If a = vbYes Then
            Me.Close()
            login.Show()
        Else
            Me.Focus()
        End If
    End Sub
End Class