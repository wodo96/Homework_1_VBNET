Imports System.Runtime.CompilerServices

Public Class Form1


    Dim isBeenSaved As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RichTextBox1.Visible = False
        Me.RichTextBox1.Enabled = False
        Me.Button1.Visible = False
        Me.Button1.AutoSize = True
        Me.Button2.Visible = False

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If (CheckBox1.Checked) Then
            Me.RichTextBox1.Visible = True
            Me.RichTextBox1.Enabled = True
        Else
            Me.RichTextBox1.Enabled = False
        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

        If (RichTextBox1.Text = "" & Not (Me.isBeenSaved)) Then
            Me.Button1.Visible = False
            Me.Button2.Visible = False
        Else
            Me.Button1.Visible = True
            Me.Button2.Visible = True
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Not (Me.RichTextBox1.Text = "")) Then
            Me.isBeenSaved = True
            Me.TextBox2.Visible = True
            Me.TextBox2.Text = Me.RichTextBox1.Text
            Me.Button1.BackColor = System.Drawing.Color.Green
            Me.Button1.Text = "Saved!"

        Else

            Me.Button1.Text = "You should write something at least!"

        End If

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.Button1.Text = "Click me!"
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        If (Not (Me.Button1.BackColor.Equals(System.Drawing.Color.Green))) Then

            Me.Button1.Text = "Save"

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.RichTextBox1.Text = ""
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Text = "Save"
        Me.TextBox2.Visible = False

    End Sub
End Class
