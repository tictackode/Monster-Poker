Imports System.Windows.Forms

Public Class Carta
    Public n As Naipe
    Public v As Valor
    Public Enum Naipe
        OUROS = 0
        COPAS = 1
        ESPADAS = 2
        PAUS = 3
        NENHUM = -1
    End Enum
    Public Enum Valor
        DOIS = 2
        TRES = 3
        QUATRO = 4
        CINCO = 5
        SEIS = 6
        SETE = 7
        OITO = 8
        NOVE = 9
        DEZ = 10
        VALETE = 11
        DAMA = 12
        REI = 13
        _AS = 14
        NENHUM = -1
    End Enum
    Sub New()

    End Sub
    Public Sub init()
        Me.n = -1
        Me.v = -1
    End Sub
    Public Function printCarta() As String
        Return Me.v.ToString + " de " + Me.n.ToString
    End Function

    Public Function retornaNaipe() As Carta.Naipe
        Return Me.n
    End Function
    Public Function retornaValor() As Carta.Valor
        Return Me.v
    End Function
    Public Sub RandCartaByRef(ByRef c As Carta)
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 3 and 0.
        c.n = CInt(Int((3 * Rnd()) + 0))
        c.v = CInt(Int((13 * Rnd()) + 2))
    End Sub
    Public Shared Sub mostraCarta(ByVal c As Carta, ByVal l As Label)


        Select Case (c.n)
            'se o naipe for NENHUM sera mostrada a parte de tras da carta
            Case (Naipe.NENHUM)
                l.Image = Image.FromFile("deck1/flipside.png")
            Case (Naipe.PAUS)
                Select Case (c.v)
                    Case Valor.DOIS
                        l.Image = Image.FromFile("deck1/2p.png")
                    Case Valor.TRES
                        l.Image = (Image.FromFile("deck1/3p.png"))
                    Case Valor.QUATRO
                        l.Image = (Image.FromFile("deck1/4p.png"))
                    Case Valor.CINCO
                        l.Image = Image.FromFile("deck1/5p.png")
                    Case Valor.SEIS
                        l.Image = Image.FromFile("deck1/6p.png")
                    Case Valor.SETE
                        l.Image = Image.FromFile("deck1/7p.png")
                    Case Valor.OITO
                        l.Image = Image.FromFile("deck1/8p.png")
                    Case Valor.NOVE
                        l.Image = Image.FromFile("deck1/9p.png")
                    Case Valor.DEZ
                        l.Image = Image.FromFile("deck1/10p.png")
                    Case Valor.VALETE
                        l.Image = Image.FromFile("deck1/jp.png")
                    Case Valor.DAMA
                        l.Image = Image.FromFile("deck1/qp.png")
                    Case Valor.REI
                        l.Image = Image.FromFile("deck1/kp.png")
                    Case Valor._AS
                        l.Image = Image.FromFile("deck1/ap.png")
                End Select
            Case (Naipe.OUROS)
                Select Case (c.v)
                    Case Valor.DOIS
                        l.Image = Image.FromFile("deck1/2o.png")
                    Case Valor.TRES
                        l.Image = Image.FromFile("deck1/3o.png")
                    Case Valor.QUATRO
                        l.Image = Image.FromFile("deck1/4o.png")
                    Case Valor.CINCO
                        l.Image = Image.FromFile("deck1/5o.png")
                    Case Valor.SEIS
                        l.Image = Image.FromFile("deck1/6o.png")
                    Case Valor.SETE
                        l.Image = Image.FromFile("deck1/7o.png")
                    Case Valor.OITO
                        l.Image = Image.FromFile("deck1/8o.png")
                    Case Valor.NOVE
                        l.Image = Image.FromFile("deck1/9o.png")
                    Case Valor.DEZ
                        l.Image = Image.FromFile("deck1/10o.png")
                    Case Valor.VALETE
                        l.Image = Image.FromFile("deck1/jo.png")
                    Case Valor.DAMA
                        l.Image = Image.FromFile("deck1/qo.png")
                    Case Valor.REI
                        l.Image = Image.FromFile("deck1/ko.png")
                    Case Valor._AS
                        l.Image = Image.FromFile("deck1/ao.png")
                End Select
            Case (Naipe.ESPADAS)
                Select Case (c.v)
                    Case Valor.DOIS
                        l.Image = Image.FromFile("deck1/2e.png")
                    Case Valor.TRES
                        l.Image = Image.FromFile("deck1/3e.png")
                    Case Valor.QUATRO
                        l.Image = Image.FromFile("deck1/4e.png")
                    Case Valor.CINCO
                        l.Image = Image.FromFile("deck1/5e.png")
                    Case Valor.SEIS
                        l.Image = Image.FromFile("deck1/6e.png")
                    Case Valor.SETE
                        l.Image = Image.FromFile("deck1/7e.png")
                    Case Valor.OITO
                        l.Image = Image.FromFile("deck1/8e.png")
                    Case Valor.NOVE
                        l.Image = Image.FromFile("deck1/9e.png")
                    Case Valor.DEZ
                        l.Image = Image.FromFile("deck1/10e.png")
                    Case Valor.VALETE
                        l.Image = Image.FromFile("deck1/je.png")
                    Case Valor.DAMA
                        l.Image = Image.FromFile("deck1/qe.png")
                    Case Valor.REI
                        l.Image = Image.FromFile("deck1/ke.png")
                    Case Valor._AS
                        l.Image = Image.FromFile("deck1/ao.png")
                End Select
            Case (Naipe.COPAS)
                Select Case (c.v)
                    Case Valor.DOIS
                        l.Image = Image.FromFile("deck1/2c.png")
                    Case Valor.TRES
                        l.Image = Image.FromFile("deck1/3c.png")
                    Case Valor.QUATRO
                        l.Image = Image.FromFile("deck1/4c.png")
                    Case Valor.CINCO
                        l.Image = Image.FromFile("deck1/5c.png")
                    Case Valor.SEIS
                        l.Image = Image.FromFile("deck1/6c.png")
                    Case Valor.SETE
                        l.Image = Image.FromFile("deck1/7c.png")
                    Case Valor.OITO
                        l.Image = Image.FromFile("deck1/8c.png")
                    Case Valor.NOVE
                        l.Image = Image.FromFile("deck1/9c.png")
                    Case Valor.DEZ
                        l.Image = Image.FromFile("deck1/10c.png")
                    Case Valor.VALETE
                        l.Image = Image.FromFile("deck1/jc.png")
                    Case Valor.DAMA
                        l.Image = Image.FromFile("deck1/qc.png")
                    Case Valor.REI
                        l.Image = Image.FromFile("deck1/kc.png")
                    Case Valor._AS
                        l.Image = Image.FromFile("deck1/ac.png")
                End Select
        End Select
    End Sub
End Class
