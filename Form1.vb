Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub btnClickHere_Click(sender As Object, e As EventArgs) Handles btnClickHere.Click
        MessageBox.Show("WELCOME")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Turquoise

    End Sub
End Class
