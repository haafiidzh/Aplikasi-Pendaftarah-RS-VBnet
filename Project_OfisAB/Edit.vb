Imports System.Data.OleDb

Public Class Edit
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim jk As String
    Dim nrmt As String

     Sub koneksi()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_rs.accdb")
    End Sub

    Sub tampildata()
        koneksi()
        con.Open()
        cmd = New OleDbCommand("SELECT * FROM [pasien] WHERE no_rm = '" & rm.Text & "' ", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            nama.Text = dr.Item("nama_pasien")
            alamat.Text = dr.Item("alamat")
            jk = dr.Item("jkelamin")
            tgl_lahir.Value = dr.Item("tgl_lahir")
            tmp_lahir.Text = dr.Item("tmp_lahir")
            telp.Text = dr.Item("telp")
            bangsal.SelectedItem = dr.Item("nama_bangsal")
            jpasien.SelectedItem = dr.Item("jpasien")
            If jk = "Laki-Laki" Then
                RadioButton1.Checked = True
            ElseIf jk = "Perempuan" Then
                RadioButton2.Checked = True
            End If
        End If
    End Sub

    Sub tampilbangsal()
        koneksi()
        con.Open()
        cmd = New OleDbCommand("SELECT nama_bangsal FROM [bangsal]", con)
        dr = cmd.ExecuteReader
        bangsal.Items.Clear()
        Do While dr.Read
            bangsal.Items.Add(dr.Item("nama_bangsal"))
        Loop
    End Sub

    Sub simpan()
        koneksi()
        con.Open()
        Dim sql As String = "UPDATE [pasien] SET nama_pasien = '" & nama.Text & "', alamat = '" & alamat.Text & "', jkelamin = '" & jk & "', tgl_lahir = '" & tgl_lahir.Value.Date & "', tmp_lahir='" & tmp_lahir.Text & "', telp='" & telp.Text & "', nama_bangsal='" & bangsal.SelectedItem & "', jpasien='" & jpasien.SelectedItem & "' WHERE no_rm = '" & rm.Text & "'"
        cmd = New OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
        DataPasien.tampil()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jk = "Laki-Laki"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jk = "Perempuan"
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgl_lahir.Format = DateTimePickerFormat.Custom
        tgl_lahir.CustomFormat = "dd/MM/yyyy"

        tampilbangsal()
        tampildata()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class