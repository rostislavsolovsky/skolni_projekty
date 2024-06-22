Public Class Form1
    Dim nl As String = Chr(13) & Chr(10)
    Dim imax As Integer = 0     'celá část
    Dim imin As Integer = 0
    Dim jmax As Integer = 1    'čitatel
    Dim jmin As Integer = 1
    Dim kmax As Integer = 2     'jmenovatel
    Dim kmin As Integer = 2
    Dim cesta As String = System.Environment.CurrentDirectory
    Dim pocetp As Integer = 10
    Dim prvni(0 To 1000) As String
    Dim druhy(0 To 1000) As String

    Dim a1 As Integer
    Dim a2 As Integer
    Dim a3 As Integer
    Dim a4 As Integer
    Dim b1 As Integer
    Dim b2 As Integer
    Dim b3 As Integer
    Dim b4 As Integer
    Dim c1 As Integer
    Dim c2 As Integer
    Dim c3 As Integer
    Dim c4 As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'generátor zlomků pro výpočty
        On Error GoTo chyba
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Dim slovo1 As String
        Dim slovo2 As String
        For i As Integer = imin To imax ' celá část
            For j As Integer = jmin To jmax  ' čitatel
                For k As Integer = kmin To kmax  'jmenovatel
                    For l As Integer = 1 To 2   'znaménko, 1 - plus, 2 - mínus
                        If j <> k And j < k And del1(j, k) = 1 Then
                            If i = 0 Then
                                slovo1 = "{" & j & "} over {" & k & "}"
                                slovo2 = slovo1
                            Else
                                slovo1 = i & " {" & j & "} over {" & k & "}"
                                slovo2 = slovo1
                            End If
                            If l = 2 Then

                                slovo2 = "left ( " & Chr(34) & "-" & Chr(34) & slovo1 & " right )"
                                slovo1 = Chr(34) & "-" & Chr(34) & slovo1
                            End If

                            'zapíše zlomek do seznamu
                            TextBox1.Text = TextBox1.Text & slovo1 & "*" & i & "*" & j & "*" & k & "*" & l & nl
                            TextBox2.Text = TextBox2.Text & slovo2 & "*" & i & "*" & j & "*" & k & "*" & l & nl
                        End If
                    Next
                Next
            Next
        Next
        'uloží do souboru
        My.Computer.FileSystem.WriteAllText(cesta & "/prvni.txt", TextBox1.Text, False)
        My.Computer.FileSystem.WriteAllText(cesta & "/druhy.txt", TextBox2.Text, False)

        MsgBox("Vegeneroval jsem sadu zlomků a uložil je do souborů")
        Exit Sub
chyba:
        MsgBox("Někde je chyba!")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Function del1(u, v) As Integer
        'vypočte největšího společného dělitele
        Dim w As Integer
        If v > u Then
            w = v
            v = u
            u = w
        End If
        While u Mod v <> 0
            w = u Mod v
            u = v
            v = w
        End While
        Return v
    End Function
    Private Function nas1(u, v) As Integer
        ' vypočte nejmenší společný násobek
        For i As Integer = 1 To v
            If i * u Mod v = 0 Then
                Return i * u
                Exit Function
            End If
        Next
        Return u * v
    End Function

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label1.Text = "Celá část je minimálně " & TrackBar1.Value
        imin = TrackBar1.Value
        Label2.Text = "Celá část je maximálně " & TrackBar2.Value + 1
        imax = TrackBar2.Value + 1
        TrackBar2.Minimum = imin
        TrackBar2.Value = imin + 1
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label2.Text = "Celá část je maximálně " & TrackBar2.Value
        imax = TrackBar2.Value
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Label3.Text = "Čitatel je minimálně " & TrackBar3.Value
        jmin = TrackBar3.Value
        Label4.Text = "Celá část je maximálně " & TrackBar3.Value + 1
        jmax = TrackBar3.Value + 1
        TrackBar4.Minimum = jmin
        TrackBar4.Value = jmin + 1
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Label4.Text = "Čitatel je maximálně " & TrackBar4.Value
        jmax = TrackBar4.Value
    End Sub

    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        Label5.Text = "Jmenovatel je minimálně " & TrackBar5.Value
        kmin = TrackBar5.Value
        Label6.Text = "Jmenovatel je maximálně " & TrackBar5.Value + 1
        kmax = TrackBar5.Value + 1
        TrackBar6.Minimum = kmin
        TrackBar6.Value = kmin + 1
    End Sub

    Private Sub TrackBar6_Scroll(sender As Object, e As EventArgs) Handles TrackBar6.Scroll
        Label6.Text = "Jmenovatel je maximálně " & TrackBar6.Value
        kmax = TrackBar6.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo chyba
        'načte data
        TextBox3.Text = ""
        TextBox4.Text = ""
        Dim stringReader As String
        Dim i As Integer = 1
        Dim j As Integer
        Dim pocet As Integer
        Dim slovo As String
        Dim citatel As String
        Dim jmenovatel As String
        Dim suma As Integer
        Dim suma1 As Integer
        Dim suma2 As Integer
        Dim cela As Integer

        Dim fileReader As System.IO.StreamReader

        'první část příkladu, první zlomek
        fileReader = My.Computer.FileSystem.OpenTextFileReader(cesta & "/prvni.txt", System.Text.Encoding.Default)
        stringReader = fileReader.ReadLine()

        While stringReader <> ""
            slovo = stringReader
            prvni(i) = slovo
            i = i + 1
            stringReader = fileReader.ReadLine()
        End While

        'druhá část příkladu, druhý zlomek
        i = 1
        fileReader = My.Computer.FileSystem.OpenTextFileReader(cesta & "/druhy.txt", System.Text.Encoding.Default)
        stringReader = fileReader.ReadLine()
        While stringReader <> ""
            slovo = stringReader
            druhy(i) = slovo
            i = i + 1
            stringReader = fileReader.ReadLine()
        End While
        pocet = i - 1

        'zamícháme
        For i = 1 To pocet
            j = Int(pocet * Rnd())
            If i <> j Then
                slovo = prvni(i)
                prvni(i) = prvni(j)
                prvni(j) = slovo
            End If
        Next
        For i = 1 To pocet
            j = Int(pocet * Rnd())
            If i <> j Then
                slovo = druhy(i)
                druhy(i) = druhy(j)
                druhy(j) = slovo
            End If
        Next
        For i = 1 To pocetp
            'sestavíme příklad a zapíšeme do pole se zadáním
            If i Mod 2 = 0 Then
                'sčítáme
                slovo = rozloz(prvni(i)) & Chr(34) & " + " & Chr(34) & rozloz(druhy(i)) & " " & Chr(34) & " = " & Chr(34)
            Else
                'odčítáme
                slovo = rozloz(prvni(i)) & Chr(34) & " - " & Chr(34) & rozloz(druhy(i)) & " " & Chr(34) & " = " & Chr(34)
            End If

            TextBox3.Text = TextBox3.Text & Chr(34) & Chr(96 + i) & Chr(34) & Chr(34) & ") " & Chr(34) & " " & slovo & nl
            TextBox3.Text = TextBox3.Text & "newline" & nl
            'zapíšeme do pole se řešením
            TextBox4.Text = TextBox4.Text & Chr(34) & Chr(96 + i) & Chr(34) & Chr(34) & ") " & Chr(34) & " " & slovo
            'načteme první
            rozloz1(prvni(i))
            a1 = c1
            a2 = c2
            a3 = c3
            a4 = c4
            rozloz1(druhy(i))
            b1 = c1
            b2 = c2
            b3 = c3
            b4 = c4
            a2 = a1 * a3 + a2
            If a4 = 2 Then a2 = (-1) * a2
            b2 = b1 * b3 + b2
            If b4 = 2 Then b2 = (-1) * b2
            'vyřešíme převod na zlomky
            If a1 <> 0 Or b1 <> 0 Then
                If i Mod 2 = 0 Then
                    'sčítáme
                    TextBox4.Text = TextBox4.Text & nazlomek1(a2, a3, a4) & Chr(34) & " + " & Chr(34) & nazlomek2(b2, b3, b4) & Chr(34) & " = " & Chr(34)
                Else
                    'odčítáme
                    TextBox4.Text = TextBox4.Text & nazlomek1(a2, a3, a4) & Chr(34) & " - " & Chr(34) & nazlomek2(b2, b3, b4) & Chr(34) & " = " & Chr(34)
                End If
            End If

            'vyřešíme přepis na společného jmenovatele
            If b2 * (nas1(a3, b3) / b3) > 0 And i Mod 2 = 0 Then
                'přičítáme kladný
                slovo = "{" & CStr(a2 * (nas1(a3, b3) / a3)) & Chr(34) & " + " & Chr(34) & CStr(b2 * (nas1(a3, b3) / b3)) & "} over {" & nas1(a3, b3) & "}"
                TextBox4.Text = TextBox4.Text & slovo & Chr(34) & " = " & Chr(34)
            End If

            If b2 * (nas1(a3, b3) / b3) > 0 And i Mod 2 = 1 Then
                'odčítáme kladný
                slovo = "{" & CStr(a2 * (nas1(a3, b3) / a3)) & Chr(34) & " - " & Chr(34) & CStr(b2 * (nas1(a3, b3) / b3)) & "} over {" & nas1(a3, b3) & "}"
                TextBox4.Text = TextBox4.Text & slovo & Chr(34) & " = " & Chr(34)
            End If

            If b2 * (nas1(a3, b3) / b3) < 0 And i Mod 2 = 0 Then
                'přičítáme záporný
                slovo = "{" & CStr(a2 * (nas1(a3, b3) / a3)) & Chr(34) & " - " & Chr(34) & CStr(-1 * b2 * (nas1(a3, b3) / b3)) & "} over {" & nas1(a3, b3) & "}"
                TextBox4.Text = TextBox4.Text & slovo & Chr(34) & " = " & Chr(34)
            End If
            If b2 * (nas1(a3, b3) / b3) < 0 And i Mod 2 = 1 Then
                'odčítáme záporný
                slovo = "{" & CStr(a2 * (nas1(a3, b3) / a3)) & Chr(34) & " + " & Chr(34) & CStr(-1 * b2 * (nas1(a3, b3) / b3)) & "} over {" & nas1(a3, b3) & "}"
                TextBox4.Text = TextBox4.Text & slovo & Chr(34) & " = " & Chr(34)
            End If

            'spočítáme mezivýsledek
            If i Mod 2 = 0 Then
                suma = a2 * (nas1(a3, b3) / a3) + b2 * (nas1(a3, b3) / b3)
            Else
                suma = a2 * (nas1(a3, b3) / a3) - b2 * (nas1(a3, b3) / b3)
            End If

            citatel = CStr(suma)
            jmenovatel = CStr(nas1(a3, b3))
            If suma > 0 Then
                'kladný
                TextBox4.Text = TextBox4.Text & "{" & citatel & "}" & " over " & "{" & jmenovatel & "}"

            Else
                'záporný
                TextBox4.Text = TextBox4.Text & Chr(34) & "-" & Chr(34)
                TextBox4.Text = TextBox4.Text & "{" & CStr(-1 * suma) & "}" & " over " & "{" & jmenovatel & "}"

            End If
            suma1 = nas1(a3, b3)

            'vyřešíme krácení výsledku
            suma2 = del1(Math.Abs(suma), suma1)
            If suma2 <> 1 Then
                'jde to krátit
                suma = suma / suma2
                suma1 = suma1 / suma2
                citatel = CStr(suma)
                jmenovatel = CStr(suma1)
                TextBox4.Text = TextBox4.Text & Chr(34) & " = " & Chr(34)
                If suma > 0 Then
                    'kladný
                    TextBox4.Text = TextBox4.Text & "{" & citatel & "}" & " over " & "{" & jmenovatel & "}"
                Else
                    'záporný
                    TextBox4.Text = TextBox4.Text & Chr(34) & "-" & Chr(34) & "{" & CStr(-1 * suma) & "}" & " over " & "{" & jmenovatel & "}"

                End If
                If suma1 = 1 Then
                        'nový jmenovatek je číslo jedna
                        TextBox4.Text = TextBox4.Text & Chr(34) & " = " & Chr(34) & suma
                        GoTo dokonceni

                    End If
                Else
                    'nejde krátit
                    suma1 = nas1(a3, b3)
                jmenovatel = CStr(suma1)

            End If

            'vyřešíme smíšená čísla
            If Math.Abs(suma) > suma1 Then
                If suma > 0 Then
                    'výsledek je kladný
                    cela = Int(suma / suma1)
                    citatel = suma - cela * suma1
                    If cela <> 0 Then
                        TextBox4.Text = TextBox4.Text & Chr(34) & " = " & Chr(34)
                        TextBox4.Text = TextBox4.Text & cela & " " & "{" & citatel & "}" & " over " & "{" & jmenovatel & "}"
                    Else
                        TextBox4.Text = TextBox4.Text & Chr(34) & " = " & Chr(34)
                        TextBox4.Text = TextBox4.Text & "{" & citatel & "}" & " over " & "{" & jmenovatel & "}"
                    End If
                Else
                    'výsledek je záporný
                    suma = -1 * suma
                    cela = Int(suma / suma1)
                    citatel = suma - cela * suma1
                    If cela <> 0 Then
                        TextBox4.Text = TextBox4.Text & Chr(34) & " = " & Chr(34)
                        TextBox4.Text = TextBox4.Text & "-" & cela & " " & "{" & citatel & "}" & " over " & "{" & jmenovatel & "}"
                    Else
                        TextBox4.Text = TextBox4.Text & Chr(34) & " = " & Chr(34)
                        TextBox4.Text = TextBox4.Text & Chr(34) & "-" & Chr(34) & "{" & citatel & "}" & " over " & "{" & jmenovatel & "}"
                    End If
                End If
            End If

dokonceni:
            TextBox4.Text = TextBox4.Text & nl
            TextBox4.Text = TextBox4.Text & "newline" & nl
        Next
        Exit Sub
chyba:
        MsgBox("Někde je chyba")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        'vyčištění dat
        For i As Integer = 0 To 1000
            prvni(i) = ""
            druhy(i) = ""
        Next
        imax = 0     'celá část
        imin = 0
        jmax = 1    'čitatel
        jmin = 1
        kmax = 2     'jmenovatel
        kmin = 2
    End Sub

    Private Function rozloz(text) As String
        Dim i As Integer
        Dim znak As String
        Dim slovo As String = ""
        For i = 1 To Len(text)
            znak = Mid(text, i, 1)
            If znak <> "*" Then
                slovo = slovo & znak
            Else
                Exit For
            End If
        Next
        Return slovo
    End Function

    Private Sub rozloz1(text As String)
        Dim i As Integer
        Dim znak As String
        Dim poradi(0 To 5) As Integer
        Dim j As Integer = 1
        For i = 1 To Len(text)
            znak = Mid(text, i, 1)
            If znak = "*" Then
                poradi(j) = i
                j = j + 1
            End If
        Next
        c1 = CInt(Mid(text, poradi(1) + 1, poradi(2) - poradi(1) - 1))
        c2 = CInt(Mid(text, poradi(2) + 1, poradi(3) - poradi(2) - 1))
        c3 = CInt(Mid(text, poradi(3) + 1, poradi(4) - poradi(3) - 1))
        c4 = CInt(Mid(text, poradi(4) + 1, Len(text) - poradi(4)))
    End Sub

    Private Sub TrackBar7_Scroll(sender As Object, e As EventArgs) Handles TrackBar7.Scroll
        Label7.Text = "Počet příkladů je " & TrackBar7.Value
        pocetp = TrackBar7.Value
    End Sub
    Private Function nazlomek1(k2, k3, k4)
        Dim slovo As String

        If k4 = 2 Then
            slovo = Chr(34) & "-" & Chr(34) & " {" & -1 * k2 & "} over {" & k3 & "}"
        Else
            slovo = "{" & k2 & "} over {" & k3 & "}"
        End If

        Return slovo
    End Function
    Private Function nazlomek2(k2, k3, k4)
        Dim slovo As String

        If k4 = 2 Then
            slovo = "left (" & Chr(34) & "-" & Chr(34) & " {" & -1 * k2 & "} over {" & k3 & "}" & "right )"
        Else
            slovo = "{" & k2 & "} over {" & k3 & "}"
        End If

        Return slovo
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'uložíme pole do schránky
        If TextBox4.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox4.Text)
            MsgBox("Obsah pole je ve schránce")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'uložíme pole do schránky
        If TextBox3.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox3.Text)
            MsgBox("Obsah pole je ve schránce")
        End If
    End Sub
End Class
