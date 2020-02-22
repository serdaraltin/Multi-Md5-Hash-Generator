Imports System.Security
Imports System.Security.Cryptography
Public Class Form1
    Public Function md5(ByRef sifre As String) As String
        Try
            Dim sifreleme As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim bytes As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sifre)
            Dim hash As Byte() = sifreleme.ComputeHash(bytes)
            Dim kapasite As Integer = (hash.Length * 2 + (hash.Length / 8))
            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(kapasite)
            Dim I As Integer
            For I = 0 To hash.Length - 1
                sb.Append(BitConverter.ToString(hash, I, 1))
            Next
            Return sb.ToString().ToLower().TrimEnd(New Char() {""})
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = md5(TextBox1.Text + "1")
        TextBox3.Text = md5(TextBox1.Text + "2")
        TextBox4.Text = md5(TextBox1.Text + "3")
        TextBox5.Text = md5(TextBox1.Text + "4")
        TextBox6.Text = md5(TextBox1.Text + "5")
        TextBox7.Text = md5(TextBox1.Text + "6")
        TextBox8.Text = md5(TextBox1.Text + "7")
        TextBox9.Text = md5(TextBox1.Text + "8")
        TextBox10.Text = md5(TextBox1.Text + "9")
        TextBox11.Text = md5(TextBox1.Text + "10")
        TextBox12.Text = md5(TextBox1.Text + "11")
        TextBox13.Text = md5(TextBox1.Text + "12")
        TextBox14.Text = md5(TextBox1.Text + "13")
        TextBox15.Text = md5(TextBox1.Text + "14")
        TextBox16.Text = md5(TextBox1.Text + "15")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim rnd As Random = New Random()
        Label3.ForeColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clipboard.SetText(TextBox3.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox4.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Clipboard.SetText(TextBox5.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Clipboard.SetText(TextBox6.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Clipboard.SetText(TextBox7.Text)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Clipboard.SetText(TextBox8.Text)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Clipboard.SetText(TextBox9.Text)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Clipboard.SetText(TextBox10.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Clipboard.SetText(TextBox11.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Clipboard.SetText(TextBox12.Text)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Clipboard.SetText(TextBox13.Text)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Clipboard.SetText(TextBox14.Text)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Clipboard.SetText(TextBox15.Text)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Clipboard.SetText(TextBox16.Text)
    End Sub
End Class
