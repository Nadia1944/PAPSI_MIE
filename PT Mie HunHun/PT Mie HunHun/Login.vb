﻿Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksiDB()
        Dim cek As String
        cek = "Select * From login Where Username= '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "'"
        CMD = New OleDb.OleDbCommand(cek, Conn)
        CMD.ExecuteNonQuery()
        DM = CMD.ExecuteReader
        If DM.HasRows = True Then
            DM.Read()
            Main_Menu.Show()
            Me.Hide()
        Else
            MsgBox(" Maaf Username atau Password Anda Salah ")
            Me.Show()
        End If
        Main_Menu.Label2.Text = TextBox1.Text
    End Sub
    Private Sub Textbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksiDB()
            Dim cek As String
            cek = "Select * From login Where Username= '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "'"
            CMD = New OleDb.OleDbCommand(cek, Conn)
            CMD.ExecuteNonQuery()
            DM = CMD.ExecuteReader
            If DM.HasRows = True Then
                DM.Read()
                Main_Menu.Show()
                Me.Hide()
            Else
                MsgBox(" Maaf Username atau Password Anda Salah ")
                Me.Show()
            End If
            Main_Menu.labeluser.Text = TextBox1.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox2.PasswordChar = "*"
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class