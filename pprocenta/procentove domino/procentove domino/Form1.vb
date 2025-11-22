Public Class Form1
    Private nl As String = Chr(13) & Chr(10)
    Private n As Integer = 10 ' počet kostek
    Private zaklad As Integer  'základ pro výpočty
    Private jednotka As String = "kg"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'připraví domino
        Dim prvni(n) As String
        Dim druhy(n) As String
        Dim stred(n) As String

        Dim leva(n) As Integer
        Dim prava(n) As Double

        Dim j As Integer
        Dim pomoc As String
        Dim pomoc1(n) As String
        Dim nalez As Integer

        'vypíšeme hlavičku domina
        TextBox1.Text = "Základ je " & zaklad & " " & jednotka & nl
        TextBox2.Text = "Základ je " & zaklad & " " & jednotka & nl
        TextBox3.Text = "Řešení domina: "
        'sestavíme příklady
        j = 1
        For i As Integer = 1 To n
zpet:
            nalez = 0
            If j > 1000 Then Exit Sub
            leva(i) = Int(99 * Rnd() + 1) 'počet procent
            For j = 1 To i - 1
                If leva(i) = leva(j) Then nalez = 1
            Next
            j = j + 1
            If nalez = 1 Then GoTo zpet
            prava(i) = zaklad / 100 * leva(i) 'procentová část
            stred(i) = Chr(64 + i)
        Next
        ' zamícháme středová označení
        For i = 1 To n
            j = Int(n * Rnd() + 1)
            If i <> j Then
                pomoc = stred(i)
                stred(i) = stred(j)
                stred(j) = pomoc
            End If
        Next
        prvni(1) = "start"
        For i = 1 To n - 1
            druhy(i) = Str(leva(i)) & " %"
            prvni(i + 1) = Str(prava(i)) & " " & jednotka
        Next
        druhy(n) = "konec"
        'vypíšeme učitelskou verzi (nezamíchaná)
        For i = 1 To n
            pomoc = prvni(i) & Chr(9) & stred(i) & Chr(9) & druhy(i)
            pomoc1(i) = ""
            For j = 1 To Len(pomoc)
                If Mid(pomoc, j, 1) = "." Then
                    pomoc1(i) = pomoc1(i) & ","
                Else
                    pomoc1(i) = pomoc1(i) & Mid(pomoc, j, 1)
                End If
            Next
            TextBox1.Text = TextBox1.Text & pomoc1(i) & nl
            TextBox3.Text = TextBox3.Text & stred(i) & ", "
        Next
        'zamícháme
        For i = 1 To n
            j = Int(n * Rnd() + 1)
            If i <> j Then
                pomoc = pomoc1(i)
                pomoc1(i) = pomoc1(j)
                pomoc1(j) = pomoc
            End If
        Next
        For i = 1 To n
            TextBox2.Text = TextBox2.Text & pomoc1(i) & nl
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Randomize()
        zaklad = 10 * Int(80 * Rnd() + 10)
        NumericUpDown2.Value = zaklad
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        n = NumericUpDown1.Value
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        zaklad = NumericUpDown2.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'zkopíruje pole do schránky
        If TextBox1.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox1.Text)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'zkopíruje pole do schránky
        If TextBox2.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox2.Text)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        jednotka = "kg"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        jednotka = "m"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        jednotka = "cm"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        jednotka = "t"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        jednotka = "Kč"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        zaklad = 10 * Int(80 * Rnd() + 10)
        NumericUpDown2.Value = zaklad
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'zkopíruje pole do schránky
        If TextBox3.Text <> "" Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(TextBox3.Text)
        End If
    End Sub
End Class
