Public Class Form1
    Dim monster1 As Enemy = New Enemy
    Dim monster2 As Enemy = New Enemy
    Sub New()
        InitializeComponent()
        m1c1.Image = Image.FromFile("deck1/flipside.png")
        m1c2.Image = Image.FromFile("deck1/flipside.png")
        m2c1.Image = Image.FromFile("deck1/flipside.png")
        m2c2.Image = Image.FromFile("deck1/flipside.png")


    End Sub
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lbresultado.Text = " "
        monster1.randEnemyName()
        monster2.randEnemyName()
        lnome.Text = monster1.getName
        lnome2.Text = monster2.getName
        ' gerando cartas randomicamente
        monster1.carta1.RandCartaByRef(monster1.carta1)
        monster1.carta2.RandCartaByRef(monster1.carta2)
        monster2.carta1.RandCartaByRef(monster2.carta1)
        monster2.carta2.RandCartaByRef(monster2.carta2)
       
        Carta.mostraCarta(monster1.carta1, m1c1)
        Carta.mostraCarta(monster1.carta2, m1c2)
        Carta.mostraCarta(monster2.carta1, m2c1)
        Carta.mostraCarta(monster2.carta2, m2c2)
    End Sub
    'Aqui tentarei escrever algumas funcoes de comparacoes de cartas
    Public Function onePair() As Boolean
        Dim m1v1 As Carta.Valor = monster1.carta1.v
        Dim m1v2 As Carta.Valor = monster1.carta2.v
        Dim m2v1 As Carta.Valor = monster2.carta1.v
        Dim m2v2 As Carta.Valor = monster2.carta2.v
        Dim aux As Boolean = False

        If (m1v1 = m1v2) Then
           
            lbresultado.Text = monster1.getName() & " venceu - Par"
            aux = True
        End If

        If (m2v1 = m2v2) Then
           
            lbresultado.Text = monster2.getName() & " venceu - par"
            aux = True
        End If
        Return aux
    End Function
    Sub highCard()
        Dim m1v1 As Carta.Valor = monster1.carta1.v
        Dim m1v2 As Carta.Valor = monster1.carta2.v
        Dim m2v1 As Carta.Valor = monster2.carta1.v
        Dim m2v2 As Carta.Valor = monster2.carta2.v

        If (m1v1 > m2v1) And (m1v1 > m2v2) Then
            lbresultado.Text = monster1.getName() & " venceu - High Card " & m1v1.ToString
        End If
        If (m1v2 > m2v1) And (m1v2 > m2v2) Then
            lbresultado.Text = monster1.getName() & " venceu - High Card " & m1v2.ToString
        End If
        If (m2v1 > m1v1) And (m2v1 > m1v2) Then
            lbresultado.Text = monster2.getName() & " venceu - High Card " & m2v1.ToString
        End If
        If (m2v2 > m1v1) And (m2v2 > m1v2) Then
            lbresultado.Text = monster2.getName() & " venceu - High Card " & m2v2.ToString
        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If onePair() = False Then
            highCard()
        End If
    End Sub
End Class
