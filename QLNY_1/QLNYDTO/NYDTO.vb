Public Class NYDTO
    Dim iId As Integer
    Dim strHoTen As String
    Dim strDiaChi As String
    Public Sub New()

    End Sub


    Public Sub New(iId As Integer,
                   strHoTen As String,
                   strDiaChi As String)
        Me.iId = iId
        Me.strHoTen = strHoTen
        Me.strDiaChi = strDiaChi

    End Sub


    Public Property IId1 As Integer
        Get
            Return iId
        End Get
        Set(value As Integer)
            iId = value
        End Set
    End Property

    Public Property StrHoTen1 As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property StrDiaChi1 As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property
End Class
