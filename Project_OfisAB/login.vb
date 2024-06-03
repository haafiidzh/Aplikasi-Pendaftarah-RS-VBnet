Imports System.Data.OleDb

Public Class login
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Sub koneksi()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_rs.accdb")
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pw.PasswordChar = "*"
    End Sub

    Private Sub logginbtt_Click(sender As Object, e As EventArgs) Handles logginbtt.Click
        koneksi()
        con.Open()
        cmd = New OleDbCommand("SELECT * FROM [user] WHERE username='" & username.Text & "' AND pw='" & pw.Text & "'", con)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Dim role As String = dr("nama_role").ToString()
            If role = "RM" Then
                Me.Hide()
                Home.ShowDialog()
            ElseIf role = "Kepala RM" Then
                Me.Hide()
                Kepala.ShowDialog()
            End If
        Else
            MessageBox.Show("Username / Password Anda Salah!!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        dr.Close()
        con.Close()
    End Sub

    Private Sub showpw_CheckedChanged(sender As Object, e As EventArgs) Handles showpw.CheckedChanged
        If showpw.Checked = True Then
            pw.PasswordChar = ""
        Else
            pw.PasswordChar = "*"
        End If
    End Sub
End Class
