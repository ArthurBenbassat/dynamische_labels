Public Class frmBingo
    Dim trekkingNummer As Integer = 0
    Dim trekkingArray(74) As Integer
    Private Sub frmBingo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim naam As String

        ' maak 4 spelers aan
        For teller As Integer = 1 To 4
            ' vraag de naam
            naam = InputBox("Geef de naam in van speler " & teller, "Speler", "speler " & teller)

            ' maak de bingo kaart aan
            maakKaart(Me.Controls("pnl" & teller), naam)
        Next

        ' plaats de cursor op de knop
        btnVolgendGetal.Select()

        Randomize()
        For teller As Integer = 0 To 74
            Me.trekkingArray(teller) = teller + 1
        Next
        Me.Shuffle(Me.trekkingArray)
        naam = "ala"
    End Sub

    Private Sub maakKaart(ByRef p As Panel, naam As String)
        Dim nieuwlabel As Label
        Dim rij, kolom As Integer
        Dim rijHoogte As Integer = 30
        Dim kolomBreedte As Integer = 30
        Dim startX As Integer
        Const startY As Integer = 40
        Dim getal As Integer
        Dim ondergrens As Integer = 1
        Dim getal1(4, 4) As Integer
        Dim randomGetal(14, 4) As Integer
        Dim shuffleArray(14) As Integer
        Dim teller, teller2, teller3 As Integer

        teller3 = 1
        Randomize()
        startX = (p.Width - kolomBreedte * 5) / 2

        ' textbox voor de naam van de speler
        Dim txtNaam = New TextBox
        txtNaam.Text = naam
        txtNaam.Width = p.Width
        p.Controls.Add(txtNaam)

        ' kolomhoofding
        Dim bingo() As String = {"B", "I", "N", "G", "O"}
        For teller = 0 To 4
            nieuwlabel = New Label
            nieuwlabel.Name = "hoofding" & teller
            nieuwlabel.Text = bingo(teller)
            nieuwlabel.Width = kolomBreedte
            nieuwlabel.Font = New Font(nieuwlabel.Font, FontStyle.Bold)
            kolom = teller Mod 5
            nieuwlabel.Location = New Point(startX + (kolom * kolomBreedte), startY)
            p.Controls.Add(nieuwlabel)
        Next

        ' maak randomwaarden voor bingo-kaart
        For teller = 0 To 4
            ' maar array van 1..15, 16..30, enz
            For teller2 = 0 To 14
                shuffleArray(teller2) = teller2 + 1 + teller * 15
            Next

            'shuffle array
            Me.Shuffle(shuffleArray)

            ' vul random waarden in hoofdarray
            For teller2 = 0 To 14
                randomGetal(teller2, teller) = shuffleArray(teller2)
            Next

        Next

        ' bouw bingo-kaart op
        For teller = 0 To 24
            ' bepaal rij en kolom
            rij = teller \ 5
            kolom = teller Mod 5

            ' maak label (vakje op kaart)
            nieuwlabel = New Label
            nieuwlabel.Name = "label" & teller
            nieuwlabel.Width = kolomBreedte
            nieuwlabel.Location = New Point(startX + (kolom * kolomBreedte), startY + rijHoogte + (rij * rijHoogte))

            ' vul de waarde in van het vakje
            If teller = 12 Then
                nieuwlabel.Text = "*"
            Else
                nieuwlabel.Text = randomGetal(rij, kolom)
            End If

            ' voeg vakje toe aan controls collection
            p.Controls.Add(nieuwlabel)
        Next
    End Sub

    ' shuffle array volgens de methode van Fisher–Yates
    ' https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
    Public Sub Shuffle(items As Integer())
        Dim j As Int32
        Dim temp As Integer
        Dim ronde As Integer = 1
        Dim rndGetal As New Random()

        For n As Int32 = items.GetUpperBound(0) - 1 To 0 Step -1
            j = rndGetal.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
            ronde += 1
        Next n
    End Sub

    Private Sub btnVolgendGetal_Click(sender As Object, e As EventArgs) Handles btnVolgendGetal.Click

        If Me.trekkingNummer > 74 Then
            MessageBox.Show("Het spel is afgelopen", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' toon het getrokken getal
            lblGetal.Text = Me.trekkingArray(Me.trekkingNummer)

            ' kijk of een speler dit getal heeft
            For teller As Integer = 1 To 4
                controleerKaart(Me.Controls("pnl" & teller))
            Next
        End If
        lblBeurt.Text = Me.trekkingNummer
        Me.trekkingNummer += 1

    End Sub
    Private Sub controleerKaart(pnl As Panel)
        ' overloop alle vakken
        For teller As Integer = 0 To 24
            ' doe de speciale achtergrondkleur weg (= van vorige ronde)
            If pnl.Controls("label" & teller).BackColor = Color.GreenYellow Then
                pnl.Controls("label" & teller).BackColor = Label.DefaultBackColor
            End If

            ' kijk of we het getrokken getal hebben op deze kaart
            If pnl.Controls("label" & teller).Text = lblGetal.Text Then
                ' OK, geef speciale achtergrondkleur en doorstreep
                pnl.Controls("label" & teller).BackColor = Color.GreenYellow
                pnl.Controls("label" & teller).Font = New Font(pnl.Controls("label" & teller).Font, FontStyle.Strikeout)
                pnl.Controls("label" & teller).Font = New Font(pnl.Controls("label" & teller).Font, FontStyle.Italic)
            End If
        Next

    End Sub
End Class
