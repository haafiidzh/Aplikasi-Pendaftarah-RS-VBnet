Imports System.Data.OleDb

Public Class DataPasien
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
            con.Open()
            da = New OleDbDataAdapter("SELECT * FROM [pasien]", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL", MsgBoxStyle.Information)
        End Try
    End Sub

    Sub proses()
        koneksi()
        con.Open()
        Dim sql As String = "INSERT INTO [ex_pasien] VALUES('" & DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value & "','" & DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value & "','" & tgl_keluar.Text & "')"
        cmd = New OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub hapusdataotomatis()
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        koneksi()
        con.Open()
        cmd = New OleDbCommand("DELETE FROM [pasien] WHERE no_rm='" & a & "'", con)
        cmd.ExecuteNonQuery()
        con.Close()
        tampil()
    End Sub

    Private Sub DataPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgl_keluar.Text = Format(Now, "dd/MM/yyyy HH.mm")

        tampil()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pick_nama As String = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Dim pick_rm As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If pick_nama = "" Then
            MsgBox("Data Pasien yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data " & pick_nama & " ?", "Hapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                con.Open()
                cmd = New OleDbCommand("DELETE FROM [pasien] WHERE no_rm='" & pick_rm & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data Pasien BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Edit.rm.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Edit.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Home.tampil()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        proses()
        hapusdataotomatis()
    End Sub
End Class