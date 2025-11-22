
Public Class Form1
    Private nl As String = Chr(13) & Chr(10)
    Private z As Double  'základ
    Private pp As Double 'počet procent
    Private pc As Double 'procentová část
    Private k As Integer 'počáteční operace
    Private jednotka As String
    Private slovo As String
    Private slovo1 As String
    Private zadani As String
    Private reseni As String
    Private n As Integer = 1 'počet příkladů
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Randomize()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'generuje příklady na procenta
        zadani = ""
        reseni = ""
        For i As Integer = 1 To n
            zadani = zadani & "Skupina " & Chr(64 + i) & nl
            reseni = reseni & "Skupina " & Chr(64 + i) & nl
            jedna()
            zadani = zadani & nl
            reseni = reseni & nl
        Next
    End Sub
    Private Sub jedna()
        k = Int(3 * Rnd() + 1)
        For i As Integer = 1 To 3

            'vybereme základ
            Select Case Int(4 * Rnd())
                Case 0
                    z = 100 * Int(100 * Rnd() + 2)
                Case 1
                    z = 10 * Int(100 * Rnd() + 2)
                Case 2
                    z = Int(100 * Rnd() + 2)
                Case 3
                    z = (Int(100 * Rnd() + 1)) / 10
            End Select
            'vybereme počet procent
            pp = Int(98 * Rnd() + 2)
            'vypočeteme procentovou část
            pc = pp * z / 100
            Select Case k
                'jednnotlivé typy úloh
                Case 1
                    'počítáme procentovou část
                    slovo = i & ". Kolik je " & pp & " % z "
                    If z>1000 Then
                        slovo = slovo & mez(z) & jednotka & "?"
                    Else
                        slovo = slovo & z & jednotka & "?"
                    End If

                    slovo1 = "100 % ... "
                    If z > 1000 Then
                        slovo1 = slovo1 & mez(z) & jednotka & nl
                    Else
                        slovo1 = slovo1 & z & jednotka & nl
                    End If

                    slovo1 = slovo1 & "1 % ... " & z / 100 & jednotka & nl
                    slovo1 = slovo1 & pp & " % ... " & pp & " . " & z / 100 & " = "
                    If z > 1000 Then
                        slovo1 = slovo1 & mez(pc) & jednotka
                    Else
                        slovo1 = slovo1 & pc & jednotka
                    End If
                Case 2
                    'počítáme základ
                    slovo = i & ". Jak velký je základ, je-li " & pp & " % " & "ze základu  "
                    If pc > 1000 Then
                        slovo = slovo & mez(pc) & jednotka & "?"
                    Else
                        slovo = slovo & pc & jednotka & "?"
                    End If
                    slovo1 = pp & " % ... "
                    If pc > 1000 Then
                        slovo1 = slovo1 & mez(pc) & jednotka & nl
                    Else
                        slovo1 = slovo1 & pc & jednotka & nl
                    End If

                    slovo1 = slovo1 & "1 % ... " & pc & " : " & pp & " = " & z / 100 & jednotka & nl
                    slovo1 = slovo1 & "100 % ... "
                    If z > 1000 Then
                        slovo1 = slovo1 & mez(z) & jednotka
                    Else
                        slovo1 = slovo1 & z & jednotka
                    End If
                Case 3
                    'počítáme počet procent
                    slovo = i & ". Kolik procent je "
                    If pc > 1000 Then
                        slovo = slovo & mez(pc) & jednotka & " z "
                    Else
                        slovo = slovo & pc & jednotka & " z "
                    End If
                    If z > 1000 Then
                        slovo = slovo & mez(z) & jednotka & "?"
                    Else
                        slovo = slovo & z & jednotka & "?"
                    End If
                    slovo1 = "100 % ... "
                    If z > 1000 Then
                        slovo1 = slovo1 & mez(z) & jednotka & nl
                    Else
                        slovo1 = slovo1 & z & jednotka & nl
                    End If
                    slovo1 = slovo1 & "1 % ... " & z / 100 & jednotka & nl
                    slovo1 = slovo1 & "x % ... " & pc & " : " & z / 100 & " = " & pp & " %"
            End Select
            zadani = zadani & slovo & nl
            reseni = reseni & slovo & nl & slovo1 & nl & nl
            k = k + 1
            If k = 4 Then k = 1
        Next
        TextBox1.Text = zadani
        TextBox2.Text = reseni
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jednotka = " m"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jednotka = " kg"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        jednotka = " Kč"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        jednotka = " cm"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        jednotka = " g"
    End Sub
    Private Function mez(cislo As Integer)
        Dim delk As Integer = Len(Str(cislo))
        Dim qq As String = ""
        For u As Integer = 1 To (delk - 1)
            qq = Mid(Str(cislo), delk - u + 1, 1) & qq
            If u Mod 3 = 0 And u <> delk - 1 Then
                qq = " " & qq
            End If
        Next u
        Return qq
    End Function

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        n = NumericUpDown2.Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cesta As String
        If TextBox1.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox2.Text)

            'zapíšeme do souboru
            Dim pokus As String
            Dim znak As String
            Dim pokus1 As String = ""
            pokus = Now
            For i As Integer = 1 To Len(pokus)
                znak = Mid(pokus, i, 1)
                If znak = ":" Or znak = "." Then znak = "-"
                pokus1 = pokus1 & znak
            Next
            cesta = "C:\pokus\procenta-" & pokus1 & ".txt"
            My.Computer.FileSystem.WriteAllText(cesta, TextBox2.Text, True)

        End If
    End Sub
End Class
