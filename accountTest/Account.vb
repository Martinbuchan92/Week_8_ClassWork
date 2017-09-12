Public Class Account
    Private m_accountName As String
    Private m_accountBalance As Double
    Private m_accountNumber As Integer
    Private Shared acctNumber As Integer = 1
    Private Shared ReadOnly minBalance As Double = 50.0

    Public Sub New()
        Me.New("Blank", minBalance)
    End Sub

    Public Sub New(ByVal accountName As String, accountBalance As Double)
        m_accountName = accountName
        m_accountBalance = accountBalance
        m_accountNumber = acctNumber
        acctNumber += 1
    End Sub

    Public Sub Withdraw(ByVal amount As Double)
        m_accountBalance += amount
    End Sub

    Public Sub AddInterest(ByVal rate As Double)
        m_accountBalance = rate * AccountBalance
    End Sub


    Public Overrides Function ToString() As String
        Return m_accountName + ", " + m_accountBalance.ToString() + ", " + m_accountNumber.ToString
    End Function

    Public Property AccountName() As String
        Get
            Return m_accountName
        End Get
        Set(value As String)
            m_accountName = value
        End Set
    End Property

    Public Property AccountBalance As Double
        Get
            Return m_accountBalance
        End Get
        Set(value As Double)
            m_accountBalance = value
        End Set
    End Property

End Class
