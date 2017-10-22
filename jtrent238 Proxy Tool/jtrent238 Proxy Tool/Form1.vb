Imports System.IO
Imports System.Text
Imports System.Net
Imports SharpRaven
Imports SharpRaven.Data

Public Class Form1

    Dim ravenClient = New RavenClient("https://61b0281c3d064f6b81ba045e025797d1:1d479dda15ed47fa8ad7f3e455a6fb90@sentry.io/233781")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If RadioButton1.Checked() Then
                TextBox9.Text() = TextBox1.Text.ToString
                TextBox10.Text() = TextBox2.Text.ToString
                TextBox11.Text() = TextBox3.Text.ToString
                TextBox12.Text() = TextBox4.Text.ToString
                TextBox15.Text() = TextBox13.Text.ToString
                Label6.Text() = "TRUE"
            End If
            If RadioButton2.Checked() Then
                TextBox9.Text() = TextBox5.Text.ToString
                TextBox10.Text() = TextBox6.Text.ToString
                TextBox11.Text() = TextBox7.Text.ToString
                TextBox12.Text() = TextBox8.Text.ToString
                TextBox15.Text() = TextBox14.Text.ToString
                Label6.Text() = "TRUE"
            End If
            If TextBox9.Text() + TextBox10.Text() + TextBox11.Text() + TextBox12.Text() + TextBox15.Text() = 0 Then
                MsgBox("*** PROXY ERROR!!! ***", MsgBoxStyle.Critical)
            End If

        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBox9.Text() = "000"
            TextBox10.Text() = "000"
            TextBox11.Text() = "000"
            TextBox12.Text() = "000"
            TextBox15.Text() = "00000"
            Label6.Text() = "FALSE"
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Try
            MsgBox("*** WORK IN PROGRESS!!! ***", MsgBoxStyle.Information, RadioButton2.Checked.Equals(False))
            RadioButton2.Checked.Equals(False)
            RadioButton1.Checked.Equals(True)
        Catch exception As Exception
            ravenClient.Capture(New SentryEvent(exception))
        End Try
    End Sub
End Class
