Public Class Enemy
    Public EnemyName As String
    Public carta1 As Carta = New Carta
    Public carta2 As Carta = New Carta

    Sub New(ByVal nome As String)
        Me.EnemyName = nome
    End Sub
    Sub New()
        Me.EnemyName = "desconhecido"
    End Sub
    Public Enum EnemyFirst
        The_Evil = 0
        The_Mad = 1
        The_Big = 2
        The_Dangerous = 3
        Captain = 4
        The_Ghostly = 5
        Professor = 6
        Doctor = 7
        Phantom = 8
        The_Brutal = 9
        The_Unstoppable = 10
        The_Vile = 11
        The_Dark = 12
        The_Crazy = 13
        The_Iron = 14
        The_Poison = 15
        The_Berserker = 16
        The_Bloody = 17
        The_King = 18
        The_Violent = 19
        The_Rancid = 20
        The_Invisible = 21
        The_Black = 22
        The_Atomic = 23
        The_Mega = 24
        The_Grand = 25
    End Enum
    Public Enum EnemyLast
        Shadow = 0
        Knight = 1
        Tarantula = 2
        Skull = 3
        Mastermind = 4
        Wizard = 5
        Ninja = 6
        Devil = 7
        Freak = 8
        Beast = 9
        Criminal = 10
        Master = 11
        Lord = 12
        Child = 13
        Corpse = 14
        Slayer = 15
        Spider = 16
        Creature = 17
        Werewolf = 18
        Monster = 19
        Vampire = 20
        Mutant = 21
        Robot = 22
        Claw = 23
        Machine = 24
        Clown = 25
    End Enum
    Public Sub randEnemyName()
        Dim firstName As EnemyFirst = New EnemyFirst
        Dim secondName As EnemyLast = New EnemyFirst
        firstName = CInt(Int((25 * Rnd()) + 0))
        secondName = CInt(Int((25 * Rnd()) + 0))
        Me.EnemyName = firstName.ToString() & " " & secondName.ToString()
    End Sub
    Public Function getName()
        Return Me.EnemyName
    End Function


End Class
