Public Class BossAIs
    Public Class PoisonousPotato
        Public Structure BossAI
            ''' <summary>
            ''' Boss' maximum health.
            ''' </summary>
            Shared ReadOnly MaxHealthPts = 250
            ''' <summary>
            ''' Maximum damage dealable.
            ''' </summary>
            Shared ReadOnly MaxDamagePts = 20 '1 must be added to this value using Random Nexts for random generation.
            ''' <summary>
            ''' Minumum damage dealable.
            ''' </summary>
            Shared ReadOnly MinDamagePts = 17
            ''' <summary>
            ''' Maximum magic points at any given moment.
            ''' </summary>
            Shared ReadOnly Max_MagicPts = 15
            ''' <summary>
            ''' Maximum magic usable at once.
            ''' </summary>
            Shared ReadOnly MaxUseMagPts = 3 '1 must be added to this value using Random Nexts for random generation.
            ''' <summary>
            ''' Minimum magic usable at once.
            ''' </summary>
            Shared ReadOnly MinUseMagPts = 0 'If using 0 magic, use a physical attack.
            ''' <summary>
            ''' Are you allowed to battle the boss if you haven't beaten other bosses?
            ''' If not, set ReqdBossBeat as a string collection for bosses to have beaten.
            ''' </summary>
            Shared ReadOnly BossBeatReqd = False
            ''' <summary>
            ''' Does the boss start with full HP?
            ''' If not, set BossStartsHP to an integer value that it will start with.
            ''' </summary>
            Shared ReadOnly StartsFullHP = True
        End Structure
    End Class
End Class
Public Structure BossAI
    ''' <summary>
    ''' Boss' maximum health.
    ''' </summary>
    Shared MaxHealthPts As Integer
    ''' <summary>
    ''' Maximum damage dealable.
    ''' </summary>
    Shared MaxDamagePts As Integer '1 must be added to this value using Random Nexts for random generation.
    ''' <summary>
    ''' Minumum damage dealable.
    ''' </summary>
    Shared MinDamagePts As Integer
    ''' <summary>
    ''' Maximum magic points at any given moment.
    ''' </summary>
    Shared Max_MagicPts As Integer
    ''' <summary>
    ''' Maximum magic usable at once.
    ''' </summary>
    Shared MaxUseMagPts As Integer '1 must be added to this value using Random Nexts for random generation.
    ''' <summary>
    ''' Minimum magic usable at once.
    ''' </summary>
    Shared MinUseMagPts As Integer 'If using 0 magic, use a physical attack.
    ''' <summary>
    ''' Are you allowed to battle the boss if you haven't beaten other bosses?
    ''' If not, set ReqdBossBeat as a string collection for bosses to have beaten.
    ''' </summary>
    Shared BossBeatReqd As Boolean
    Shared ReqdBossBeat As Collection
    ''' <summary>
    ''' Does the boss start with full HP?
    ''' If not, set BossStartsHP to an integer value that it will start with.
    ''' </summary>
    Shared StartsFullHP As Boolean
    Shared BossStartsHP As Integer
End Structure 'Type: Boss AI