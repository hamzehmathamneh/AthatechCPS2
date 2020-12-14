Imports System.Data.OleDb
Public Class Form1
    Private Sub NButton2_Click(sender As Object, e As EventArgs) Handles NButton2.Click
        Application.Exit()
    End Sub

    Private Sub NButton1_Click(sender As Object, e As EventArgs) Handles NButton1.Click
        If PasswordBox.Text = "123" Then
            MainForm.Show
            Me.Hide()

        Else
            PasswordBox.Clear()
            PasswordBox.Select()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
