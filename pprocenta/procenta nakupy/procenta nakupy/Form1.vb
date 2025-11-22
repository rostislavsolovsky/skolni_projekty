Public Class Form1
    Dim nl As String = Chr(13) & Chr(10)    'nový řádek
    Dim n As Integer = 15 'počet příkladů (15)
    Dim cena(2) As Integer ' dílčí ceny
    Dim cena1(2) As Integer ' nové dílčí ceny
    Dim zaznam(3) As String 'výpisy zadání a řešení pro jednotlivá pole
    Dim nabidka(19) As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' sleva z celkové ceny nákupu
        Dim sleva As Integer    ' výše slevy
        Dim celkem As Integer   ' součet původních cen
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "celková cena" & Chr(9) & "sleva" & Chr(9) & "sleva" & Chr(9) & "cena po slevě" & nl
        zaznam(2) = ""
        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            zaznam(2) = ""
            k = Int(20 * Rnd())     ' vybereme položku
            For j As Integer = 0 To 2
                'generujeme ceny
                k = k + j * 4
                If k > 19 Then k = k - 19

                If k < 6 Then cena(j) = Int(100 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1100 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & mez(cena(j)) & " Kč" & nl
            Next
            sleva = Int(2 + 20 * Rnd())
            celkem = cena(0) + cena(1) + cena(2)
            ' zápis do zadání

            zaznam(0) = zaznam(0) & "Každému zákazníkovi dnes poskytujeme slevu " & sleva & Chr(160) & "% z celkové ceny"
            zaznam(0) = zaznam(0) & " nákupu. Slevy a ceny se zaokrouhlují na koruny. Kolik u pokladny zaplatíte?"
            ' zápis do řešení
            zaznam(1) = zaznam(0) & nl & nl & "Sečteme jednotlivé ceny ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & celkem / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 - sleva) & " % ... " & (100 - sleva) & "." & celkem / 100 & " = " & (100 - sleva) * celkem / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & nl & "Zaplatíme " & mez(zao((100 - sleva) * celkem / 100)) & " Kč" & nl
            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena(2))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem) & Chr(9) & sleva & " % ze " & mez(celkem)
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((sleva) * celkem / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((100 - sleva) * celkem / 100)) & " Kč"
            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl
        Next

    End Sub
    Private Function zao(cislo As Double)
        'zaokrouhlí na jednotky
        Return Int(cislo + 0.5)
    End Function
    Private Function mez(cislo As Integer)
        ' vloží mezery do výpisu čísla - číslo musí být přirozené
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nabidka(0) = "sluchátka"
        nabidka(1) = "reproduktory"
        nabidka(2) = "flash disk"
        nabidka(3) = "svítilna"
        nabidka(4) = "usb kabel"
        nabidka(5) = "el. konvice"

        nabidka(6) = "telefon"
        nabidka(7) = "tablet"
        nabidka(8) = "kávovar"
        nabidka(9) = "mixér"
        nabidka(10) = "vysavač"
        nabidka(11) = "ext. disk"
        nabidka(12) = "dvd přehrávač"

        nabidka(13) = "pračka"
        nabidka(14) = "sušička"
        nabidka(15) = "počítač"
        nabidka(16) = "notebook"
        nabidka(17) = "televizor"
        nabidka(18) = "meteostanice"
        nabidka(19) = "kávovar"
        n = NumericUpDown1.Value
        Randomize()

        ' vše na 15 znaků
        For i As Integer = 0 To 19
            For j As Integer = 0 To 15 - Len(nabidka(i))
                nabidka(i) = nabidka(i) & " "
            Next
        Next
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        n = NumericUpDown1.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' sleva z nejdražší položky
        Dim sleva As Integer    ' výše slevy
        Dim celkem As Integer   ' součet původních cen
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "celková cena" & Chr(9) & "sleva" & Chr(9) & "sleva" & Chr(9) & "cena po slevě" & nl
        zaznam(2) = ""
        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            k = Int(20 * Rnd())     ' vybereme položku
            For j As Integer = 0 To 2
                'generujeme ceny
                k = k + j * 4
                If k > 19 Then k = k - 19
                If k < 6 Then cena(j) = Int(100 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1100 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & mez(cena(j)) & " Kč" & nl
            Next
            sleva = Int(2 + 20 * Rnd())
            celkem = cena(0) + cena(1) + cena(2)

            zaznam(0) = zaznam(0) & "Každému zákazníkovi dnes poskytujeme slevu " & sleva & Chr(160) & "% z ceny nejdražší "
            zaznam(0) = zaznam(0) & "položky nákupu. Slevy a ceny se zaokrouhlují na koruny. Kolik u pokladny zaplatíte?"
            zaznam(1) = zaznam(0) & nl & nl & "Sečteme jednotlivé ceny ..." & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "Najdeme nejdražší položku ... " & mez(cena.Max) & " Kč" & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(cena.Max) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & cena.Max / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & sleva & " % ... " & sleva & "." & cena.Max / 100 & " = " & sleva * cena.Max / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "zaplatíme ... " & mez(celkem) & " - " & mez(zao(sleva * cena.Max / 100)) & " = " & mez(celkem - sleva * cena.Max / 100) & " Kč" & nl
            zaznam(1) = zaznam(1) & nl & "Zaplatíme " & mez(celkem - sleva * cena.Max / 100) & " Kč" & nl

            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena(2))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem)
            zaznam(2) = zaznam(2) & Chr(9) & sleva & " % ze " & mez(cena.Max)
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao(sleva * cena.Max / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem - sleva * cena.Max / 100) & " Kč"
            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'vloží pole do scránky
        My.Computer.Clipboard.Clear()
        If TextBox1.Text <> "" Then My.Computer.Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'vloží pole do scránky
        My.Computer.Clipboard.Clear()
        If TextBox2.Text <> "" Then My.Computer.Clipboard.SetText(TextBox2.Text)
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' sleva z nejlevnější položky
        Dim sleva As Integer    ' výše slevy
        Dim celkem As Integer   ' součet původních cen
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "celková cena" & Chr(9) & "sleva" & Chr(9) & "sleva" & Chr(9) & "cena po slevě" & nl
        zaznam(2) = ""
        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            k = Int(20 * Rnd())     ' vybereme položku
            For j As Integer = 0 To 2
                'generujeme ceny

                k = k + j * 4
                If k > 19 Then k = k - 19

                If k < 6 Then cena(j) = Int(100 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1100 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & mez(cena(j)) & " Kč" & nl
            Next
            sleva = Int(2 + 20 * Rnd())
            celkem = cena(0) + cena(1) + cena(2)

            zaznam(0) = zaznam(0) & "Každému zákazníkovi dnes poskytujeme slevu " & sleva & Chr(160) & "% z ceny nejlevnější "
            zaznam(0) = zaznam(0) & "položky nákupu. Slevy a ceny se zaokrouhlují na koruny. Kolik u pokladny zaplatíte?"
            zaznam(1) = zaznam(0) & nl & nl & "Sečteme jednotlivé ceny ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "Najdeme nejlevnější položku ... " & mez(cena.Min) & " Kč" & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(cena.Min) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & cena.Min / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & sleva & " % ... " & sleva & "." & cena.Min / 100 & " = " & sleva * cena.Min / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "zaplatíme ... " & mez(celkem) & " - " & mez(zao(sleva * cena.Min / 100)) & " = " & mez(celkem - sleva * cena.Min / 100) & " Kč" & nl
            zaznam(1) = zaznam(1) & nl & "Zaplatíme " & mez(celkem - sleva * cena.Min / 100) & " Kč" & nl

            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena(2))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem)
            zaznam(2) = zaznam(2) & Chr(9) & sleva & " % ze " & mez(cena.Min)
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao(sleva * cena.Min / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem - sleva * cena.Min / 100) & " Kč"
            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' nejdražší zlevníme, nejlevnější zdražíme
        Dim sleva As Integer    ' výše slevy
        Dim zdraz As Integer    'výše zdražení
        Dim celkem As Integer   ' součet původních cen
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "zadání" & Chr(9) & "nová nejdražší" & Chr(9) & "zadání" & Chr(9) & "nová nejlevnější" & Chr(9) & "ceková cena" & nl
        zaznam(2) = ""
        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            k = Int(20 * Rnd())     ' vybereme položku
            For j As Integer = 0 To 2
                'generujeme ceny

                k = k + j * 4
                If k > 19 Then k = k - 19

                If k < 6 Then cena(j) = Int(100 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1100 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & mez(cena(j)) & " Kč" & nl
            Next
            sleva = Int(2 + 20 * Rnd())
            zdraz = Int(2 + 20 * Rnd())
            celkem = cena(0) + cena(1) + cena(2)

            zaznam(0) = zaznam(0) & "Každému zákazníkovi dnes zlevníme nejdražší položku nákupu o " & sleva & Chr(160) & "%, ale současně mu "
            zaznam(0) = zaznam(0) & "nejlevnější položku nákupu zdražíme o " & zdraz & Chr(160) & "%. Ceny se zaokrouhlují na koruny. Kolik u pokladny zaplatíte?"
            zaznam(0) = zaznam(0) & nl & nl
            zaznam(1) = zaznam(0) & "zlevníme nejdražší" & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(cena.Max) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & cena.Max / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 - sleva) & " % ... " & (100 - sleva) & "." & cena.Max / 100 & " = " & (100 - sleva) * cena.Max / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "nová cena nejdražší... " & mez(zao((100 - sleva) * cena.Max / 100)) & " Kč" & nl & nl

            zaznam(1) = zaznam(1) & "zdražíme nejlevnější" & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(cena.Min) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & cena.Min / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 + zdraz) & " % ... " & (100 + zdraz) & "." & cena.Min / 100 & " = " & (100 + zdraz) * cena.Min / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "nová cena nejlevnější... " & mez(zao((100 + zdraz) * cena.Min / 100)) & " Kč" & nl

            zaznam(1) = zaznam(1) & "sečteme aktuální ceny ... " & mez(zao((100 - sleva) * cena.Max / 100))
            zaznam(1) = zaznam(1) & " + " & mez(zao((100 + zdraz) * cena.Min / 100))
            zaznam(1) = zaznam(1) & " + " & mez(celkem - cena.Max - cena.Min) & " = "
            zaznam(1) = zaznam(1) & mez(zao((100 - sleva) * cena.Max / 100) + zao((100 + zdraz) * cena.Min / 100) + celkem - cena.Max - cena.Min) & " Kč" & nl

            zaznam(1) = zaznam(1) & nl & "Zaplatíme " & mez(zao((100 - sleva) * cena.Max / 100) + zao((100 + zdraz) * cena.Min / 100) + celkem - cena.Max - cena.Min) & " Kč." & nl

            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena(2))
            zaznam(2) = zaznam(2) & Chr(9) & " - " & sleva & " % ze " & mez(cena.Max)
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((100 - sleva) * cena.Max / 100))
            zaznam(2) = zaznam(2) & Chr(9) & " + " & zdraz & " % ze " & mez(cena.Min)
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((100 + zdraz) * cena.Min / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((100 - sleva) * cena.Max / 100) + zao((100 + zdraz) * cena.Min / 100) + celkem - cena.Max - cena.Min) & " Kč"
            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl

        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' sleva podle dnů v týdnu
        Dim sleva1 As Integer    ' výše slevy
        Dim sleva2 As Integer ' výše slevy
        Dim celkem As Integer   ' součet původních cen
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "zadání po+st+pá" & Chr(9) & "sleva po+st+pá" & Chr(9) & "zadání út+čt+so+ne" & Chr(9) & "sleva út+čt+so+ne" & Chr(9) & "nová cena po+st+pá" & Chr(9) & "nová cena út+čt+so+ne" & nl
        zaznam(2) = ""
        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            k = Int(20 * Rnd())     ' vybereme položku
            For j As Integer = 0 To 2
                'generujeme ceny
                k = k + j * 4
                If k > 19 Then k = k - 19

                If k < 6 Then cena(j) = Int(100 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1100 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & mez(cena(j)) & " Kč" & nl
            Next
            sleva1 = Int(2 + 20 * Rnd())
            sleva2 = sleva1 + Int(2 + 3 * Rnd())
            celkem = cena(0) + cena(1) + cena(2)

            zaznam(0) = zaznam(0) & "V pondělí, středu a pátek poskytujeme slevu " & sleva1 & Chr(160) & "% z celkové ceny"
            zaznam(0) = zaznam(0) & " nákupu. V ostatní dny poskytujeme slevu " & sleva2 & Chr(160) & "% z celkové ceny nákupu. "
            zaznam(0) = zaznam(0) & "Slevy a ceny se zaokrouhlují na koruny. Kolik u pokladny zaplatíte?"
            zaznam(1) = zaznam(0) & nl & nl & "Sečteme jednotlivé ceny ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "Pondělí, středa, pátek ..." & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & celkem / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 - sleva1) & " % ... " & (100 - sleva1) & "." & celkem / 100 & " = " & (100 - sleva1) * celkem / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & nl & "V pondělí, středu a v pátek zaplatíme " & mez(zao((100 - sleva1) * celkem / 100)) & " Kč" & nl

            zaznam(1) = zaznam(1) & "Úterý, čtvrtek, sobota a neděle ..." & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & celkem / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 - sleva2) & " % ... " & (100 - sleva2) & "." & celkem / 100 & " = " & (100 - sleva2) * celkem / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & nl & "V úterý, čtvrtek, sobotu a neděli zaplatíme " & mez(zao((100 - sleva2) * celkem / 100)) & " Kč" & nl

            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena(2))
            zaznam(2) = zaznam(2) & Chr(9) & sleva1 & " % ze " & mez(celkem)
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((sleva1) * celkem / 100))
            zaznam(2) = zaznam(2) & Chr(9) & sleva2 & " % ze " & mez(celkem)
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((sleva2) * celkem / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem - zao((sleva1) * celkem / 100)) & " Kč"
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem - zao((sleva2) * celkem / 100)) & " Kč"
            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl
        Next

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' vše jsme zdražili o ** %
        Dim sleva As Integer    ' výše zdtažení
        Dim celkem As Integer   ' součet původních cen
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "zdražení" & Chr(9) & "nová cena" & Chr(9) & "nová cena" & Chr(9) & "nová cena" & Chr(9) & "nová celková cena" & nl
        zaznam(2) = ""
        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            k = Int(20 * Rnd())     ' vybereme položku
            For j As Integer = 0 To 2
                'generujeme ceny
                k = k + j * 4
                If k > 19 Then k = k - 19

                If k < 6 Then cena(j) = Int(100 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1100 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & mez(cena(j)) & " Kč" & nl
            Next
            sleva = Int(2 + 20 * Rnd())


            zaznam(0) = zaznam(0) & "Veškeré zboží jsme právě zdražili o " & sleva & Chr(160) & "%, "
            zaznam(0) = zaznam(0) & "jen jsme ještě nestihli přepsat cenovky. Zatím jsou na nich staré ceny. "
            zaznam(0) = zaznam(0) & "Nové ceny se zaokrouhlují na koruny. Kolik u pokladny zaplatíte?"
            zaznam(1) = zaznam(0) & nl & nl & "Zdražíme každou položku zvlášť." & nl

            zaznam(1) = zaznam(1) & "100 % ... " & mez(cena(0)) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & cena(0) / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 + sleva) & " % ... " & (100 + sleva) & "." & cena(0) / 100 & " = " & (100 + sleva) * cena(0) / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "Zaokrouhlíme ..." & mez(zao((100 + sleva) * cena(0) / 100)) & " Kč" & nl & nl

            zaznam(1) = zaznam(1) & "100 % ... " & mez(cena(1)) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & cena(1) / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 + sleva) & " % ... " & (100 + sleva) & "." & cena(1) / 100 & " = " & (100 + sleva) * cena(1) / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "Zaokrouhlíme ..." & mez(zao((100 + sleva) * cena(1) / 100)) & " Kč" & nl & nl

            zaznam(1) = zaznam(1) & "100 % ... " & mez(cena(2)) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & cena(2) / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & (100 + sleva) & " % ... " & (100 + sleva) & "." & cena(2) / 100 & " = " & (100 + sleva) * cena(2) / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "Zaokrouhlíme ..." & mez(zao((100 + sleva) * cena(2) / 100)) & " Kč" & nl & nl

            zaznam(1) = zaznam(1) & "Sečteme nové ceny ..."
            celkem = zao((100 + sleva) * (cena(0) + cena(1) + cena(2)) / 100)
            zaznam(1) = zaznam(1) & nl & "Zaplatíme " & mez(celkem) & " Kč" & nl

            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena(2))
            zaznam(2) = zaznam(2) & Chr(9) & sleva & " %"
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((100 + sleva) * cena(0) / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((100 + sleva) * cena(1) / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(zao((100 + sleva) * cena(2) / 100))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem) & " Kč"

            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' vše zlevníme o 100 korun a zeptáme se, kolik procent z původní ceny jsme tak ušetřili
        Dim sleva As Integer    ' výše slevy
        Dim celkem As Integer   ' součet původních cen
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "cena" & Chr(9) & "celková cena" & Chr(9) & "zadání" & Chr(9) & "sleva" & Chr(9) & "cena po slevě" & nl
        zaznam(2) = ""
        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            k = Int(20 * Rnd())     ' vybereme položku
            For j As Integer = 0 To 2
                'generujeme ceny
                k = k + j * 4
                If k > 19 Then k = k - 19

                If k < 6 Then cena(j) = Int(300 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1300 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & mez(cena(j)) & " Kč" & nl
            Next
            sleva = 10 * Int(15 + 6 * Rnd())
            celkem = cena(0) + cena(1) + cena(2)

            zaznam(0) = zaznam(0) & "U pokladny každému zákazníkovi odečteme " & sleva & " korun z ceny každé položky jeho nákupu. "
            zaznam(0) = zaznam(0) & "Kolik procent z původní celkové ceny nákupu tak ušetří? "
            zaznam(0) = zaznam(0) & "Slevu zaokrouhli na jednotky procent."
            zaznam(1) = zaznam(0) & nl & nl & "Sečteme jednotlivé ceny ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "100 % ... " & mez(celkem) & " Kč" & nl
            zaznam(1) = zaznam(1) & "1 % ... " & celkem / 100 & " Kč" & nl
            zaznam(1) = zaznam(1) & "celková sleva ... " & 3 * sleva & " Kč" & nl
            zaznam(1) = zaznam(1) & "počet procent (zaokrouhleno)... " & 3 * sleva & " : " & celkem / 100 & " = " & zao((3 * sleva) / (celkem / 100)) & " %" & nl
            zaznam(1) = zaznam(1) & "Sleva činí " & zao((3 * sleva) / (celkem / 100)) & " %."

            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena(2))
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem) & Chr(9) & "3x " & sleva & " = " & 3 * sleva & " ze " & mez(celkem)
            zaznam(2) = zaznam(2) & Chr(9) & zao((3 * sleva) / (celkem / 100)) & " %"
            zaznam(2) = zaznam(2) & Chr(9) & mez(celkem - 3 * sleva) & " Kč"
            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ' co zlevnilo nejvíce?
        Dim sleva As Integer    ' výše slevy
        Dim celkem As Integer   ' součet původních cen
        Dim vysl(2) As Integer 'vypočtené slevy v precentech
        Dim k As Integer 'vybraná položka
        smazeme()
        TextBox3.Text = "číslo příkladu" & Chr(9) & "původní cena" & Chr(9) & "nová cena" & Chr(9) & "sleva" & Chr(9) & "původní cena" & Chr(9) & "nová cena" & Chr(9) & "sleva" & Chr(9) & "původní cena" & Chr(9) & "nová cena" & Chr(9) & "sleva" & nl
        zaznam(2) = ""

        For i As Integer = 1 To n
            zaznam(0) = "příklad č. " & i & nl
            k = Int(20 * Rnd())     ' vybereme položku

            For j As Integer = 0 To 2
                'generujeme ceny

                k = k + j * 4
                If k > 19 Then k = k - 19

                If k < 6 Then cena(j) = Int(300 + 999 * Rnd())
                If k >= 6 Then cena(j) = Int(1300 + 3999 * Rnd())
                If k >= 12 Then cena(j) = Int(10000 + 20000 * Rnd())
                sleva = Int(cena(j) / 5) - 10
                cena1(j) = cena(j) - sleva
                zaznam(0) = zaznam(0) & nabidka(k) & Chr(9) & "(" & mez(cena(j)) & " Kč)" & Chr(9) & mez(cena1(j)) & " Kč" & nl
            Next

            zaznam(0) = zaznam(0) & "Která položka vašeho nákupu byla zlevněna nejvíce? Slevy se porovnávají podle své výše v procentech. "
            zaznam(0) = zaznam(0) & "Původní ceny jsou uvedeny v závorkách! Slevy zaokrouhli na jednotky procent."
            zaznam(1) = zaznam(0) & nl & nl
            For j = 0 To 2
                ' vypočteme jdenotlivé clevy
                zaznam(1) = zaznam(1) & "vypočteme slevu v korunách ..." & mez(cena(j)) & " - " & mez(cena1(j)) & " = " & mez(cena(j) - cena1(j)) & " Kč" & nl
                zaznam(1) = zaznam(1) & "100 % ... " & mez(cena(j)) & " Kč" & nl
                zaznam(1) = zaznam(1) & "1 % ... " & cena(j) / 100 & " Kč" & nl
                zaznam(1) = zaznam(1) & "počet procent (zaokrouhleno) ... " & mez(cena(j) - cena1(j)) & " : " & cena(j) / 100 & " = " & zao((cena(j) - cena1(j)) / (cena(j) / 100)) & " %" & nl & nl
                vysl(j) = zao((cena(j) - cena1(j)) / (cena(j) / 100))
            Next
            For j = 0 To 2
                If vysl(j) = vysl.Max Then
                    zaznam(1) = zaznam(1) & "Nejvíce zlevněna byla " & j + 1 & ". položka nákupu." & nl
                End If
            Next

            ' řádek do excelu
            zaznam(2) = i & Chr(9) & mez(cena(0)) & Chr(9) & mez(cena1(0)) & Chr(9) & zao((cena(0) - cena1(0)) / (cena(0) / 100)) & " %"
            zaznam(2) = zaznam(2) & Chr(9) & mez(cena(1)) & Chr(9) & mez(cena1(1)) & Chr(9) & zao((cena(1) - cena1(1)) / (cena(1) / 100)) & " %"
            zaznam(2) = zaznam(2) & Chr(9) & mez(cena(2)) & Chr(9) & mez(cena1(2)) & Chr(9) & zao((cena(2) - cena1(2)) / (cena(2) / 100)) & " %"
            ' zapíšeme do polí
            TextBox1.Text = TextBox1.Text & zaznam(0) & nl & nl
            TextBox2.Text = TextBox2.Text & zaznam(1) & nl & nl
            TextBox3.Text = TextBox3.Text & zaznam(2) & nl
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'vloží pole do scránky
        My.Computer.Clipboard.Clear()
        If TextBox3.Text <> "" Then My.Computer.Clipboard.SetText(TextBox3.Text)
    End Sub



    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        smazeme()
    End Sub

    Private Sub smazeme()
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub
End Class
