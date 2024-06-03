Imports System.Data.OleDb

Public Class Pendaftaran
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim jk As String
    Dim ttl As String
    Dim nrmt As String

    Sub koneksi()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_rs.accdb")
    End Sub

    Sub tampilbangsal()
        koneksi()
        con.Open()
        cmd = New OleDbCommand("SELECT nama_bangsal FROM [bangsal]", con)
        dr = cmd.ExecuteReader
        bangsal.Items.Clear()
        Do While dr.Read()
            bangsal.Items.Add(dr.Item("nama_bangsal"))
        Loop
    End Sub

    Sub no_rmterakhir()
        koneksi()
        con.Open()
        Dim query As String = "SELECT TOP 1 no_rm FROM [pasien]"

        cmd = New OleDbCommand(query, con)
        dr = cmd.ExecuteReader()

        If dr.Read() Then
            nrmt = dr("no_rm").ToString()
        End If

        ' Panggil fungsi untuk menghasilkan nomor rekam medis baru
        Dim nomorRekamMedisBaru As String = GenerateNextMedicalRecordNumber(nrmt)

        ' Set nilai nomor rekam medis baru ke dalam TextBox 'rm'
        rm.Text = nomorRekamMedisBaru

        con.Close()
    End Sub



    ' Fungsi untuk menghasilkan nomor rekam medis baru dengan format RM001
    Private Function GenerateNextMedicalRecordNumber(lastMedicalRecordNumber As String) As String
        ' Jika tidak ada nomor rekam medis sebelumnya, mulai dari RM001
        If String.IsNullOrEmpty(lastMedicalRecordNumber) Then
            Return "RM001"
        End If

        ' Ambil angka dari nomor rekam medis terakhir
        Dim numericPart As String = lastMedicalRecordNumber.Substring(2)
        Dim number As Integer

        If Integer.TryParse(numericPart, number) Then
            ' Tambahkan 1 ke nomor sebelumnya dan format ulang
            Dim nextNumber As String = (number + 1).ToString("000")
            Return "RM" & nextNumber
        End If

        ' Jika gagal mengambil angka, kembalikan nomor rekam medis terakhir
        Return lastMedicalRecordNumber
    End Function

    Sub simpan()
        koneksi()
        con.Open()
        Dim sql As String = "INSERT INTO [pasien] VALUES('" & rm.Text & "','" & nama.Text & "','" & alamat.Text & "','" & jk & "','" & ttl & "','" & tmp_lahir.Text & "','" & telp.Text & "','" & bangsal.SelectedItem & "','" & jpasien.SelectedItem & "','" & tgl_masuk.Text & "')"
        cmd = New OleDbCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL" & ex.Message, vbInformation, "PERINGATAN")
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Pendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' membuat semua field menjadi kosong 
        rm.Text = ""
        nama.Text = ""
        tmp_lahir.Text = ""
        alamat.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        telp.Text = ""
        bangsal.Text = "- Pilih Bangsal -"
        jpasien.Text = "- Pilih Jenis Pasien -"


        ' untuk membuat date menjadi format yang diinginkan
        tgl_lahir.Format = DateTimePickerFormat.Custom
        tgl_lahir.CustomFormat = "dd/MM/yyyy"

        ttl = Format(tgl_lahir.Value, "dd/MM/yyyy")

        tgl_masuk.Text = Format(Now, "dd/MM/yyyy HH.mm")

        ' pemanggilan fungsi yang sudah dibuat
        tampilbangsal()
        no_rmterakhir()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jk = "Laki-Laki"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jk = "Perempuan"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()

        Me.Close()
        Home.tampil()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        nama.Text = ""
        tmp_lahir.Text = ""
        alamat.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        telp.Text = ""
        bangsal.Text = "- Pilih Bangsal -"
        jpasien.Text = "- Pilih Jenis Pasien -"

    End Sub
End Class
