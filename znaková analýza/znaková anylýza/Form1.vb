Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'zjistíme délku řetězce
        Dim delka As Integer
        delka = Len(TextBox1.Text)


        'vypustíme případné mezery
        Dim slovo As String
        Dim slovo1 As String
        Dim slovo2 As String
        slovo = TextBox1.Text
        slovo1 = ""
        Dim znak As String
        For i As Integer = 1 To delka
            znak = Mid(slovo, i, 1)
            If Asc(znak) <> 32 And Asc(znak) <> 10 And Asc(znak) <> 13 Then
                slovo1 = slovo1 & znak
            End If
        Next
        TextBox3.Text = slovo1
        delka = Len(TextBox3.Text)


        'nahradíme znaky s diakritikou
        slovo2 = ""

        For i = 1 To delka
            znak = Mid(slovo1, i, 1)
            If znak = "á" Then znak = "a"
            If znak = "é" Then znak = "e"
            If znak = "ě" Then znak = "e"
            If znak = "í" Then znak = "i"
            If znak = "ú" Then znak = "u"
            If znak = "ů" Then znak = "u"
            If znak = "ý" Then znak = "y"
            If znak = "č" Then znak = "c"
            If znak = "ď" Then znak = "d"
            If znak = "ř" Then znak = "r"
            If znak = "š" Then znak = "s"
            If znak = "ž" Then znak = "z"
            If znak = "ť" Then znak = "t"
            If znak = "ň" Then znak = "n"
            slovo2 = slovo2 & znak

        Next
        TextBox4.Text = slovo2

        'analýza výskytu
        Dim vyskyt(0 To 26) As Integer
        Dim pp As Integer
        Dim slovo3 As String
        Dim nl As String
        Dim znak1 As String
        nl = Chr(13) & Chr(10)
        slovo3 = ""
        For i = 0 To delka - 1
            znak = Mid(slovo2, i + 1, 1)
            If znak <> "c" Then
                ' tady nehrozí ch!
                pp = Asc(znak)
                vyskyt(pp - 97) = vyskyt(pp - 97) + 1
            Else
                'tady by mohlo být ch!
                znak1 = Mid(slovo2, i + 2, 1)
                If znak1 <> "h" Then
                    'tohle není ch!
                    pp = Asc(znak)
                    vyskyt(pp - 97) = vyskyt(pp - 97) + 1
                Else
                    'tohle je ch!
                    vyskyt(26) = vyskyt(26) + 1
                    i = i + 1
                End If

            End If
        Next
        For i = 0 To 7
            slovo3 = slovo3 & Chr(97 + i) & Chr(9) & vyskyt(i) & nl

        Next
        slovo3 = slovo3 & "ch" & Chr(9) & vyskyt(26) & nl
        For i = 8 To 25
            slovo3 = slovo3 & Chr(97 + i) & Chr(9) & vyskyt(i) & nl

        Next
        TextBox2.Text = slovo3
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox4.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox2.Text)
        End If

    End Sub
End Class
