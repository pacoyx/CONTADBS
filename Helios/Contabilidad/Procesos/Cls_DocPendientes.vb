Public Class Cls_DocPendientes

    Private _fecha As String
    Private _tdoc As String
    Private _sdoc As String
    Private _ndoc As String
    Private _debe As Double
    Private _haber As Double
    Private _ID_MIN As Integer
    Private _ID_MAX As Integer
    Private _monto_ori As Double

    Public Sub New()

    End Sub

    Public Sub New(ByVal fecha_ As String, ByVal tipo_ As String, ByVal serio_ As String, ByVal num_ As String, ByVal debe_ As Double, ByVal haber_ As Double, ByVal ID_MIN_ As Integer, ByVal ID_MAX_ As Integer, ByVal monto_ori_ As Double)
        _fecha = fecha_
        _tdoc = tipo_
        _sdoc = serio_
        _ndoc = num_
        _debe = debe_
        _haber = haber_
        _ID_MIN = ID_MIN_
        _ID_MAX = ID_MAX_
        _monto_ori = monto_ori_
    End Sub

    Public Property monto_ori() As Double
        Get
            Return _monto_ori
        End Get
        Set(ByVal value As Double)
            _monto_ori = value
        End Set
    End Property

    Public Property ID_MIN() As Integer
        Get
            Return _ID_MIN
        End Get
        Set(ByVal value As Integer)
            _ID_MIN = value
        End Set
    End Property

    Public Property ID_MAX() As Integer
        Get
            Return _ID_MAX
        End Get
        Set(ByVal value As Integer)
            _ID_MAX = value
        End Set
    End Property

    Public Property haber() As Double
        Get
            Return _haber
        End Get
        Set(ByVal value As Double)
            _haber = value
        End Set
    End Property

    Public Property debe() As Double
        Get
            Return _debe
        End Get
        Set(ByVal value As Double)
            _debe = value
        End Set
    End Property

    Public Property ndoc() As String
        Get
            Return _ndoc
        End Get
        Set(ByVal value As String)
            _ndoc = value
        End Set
    End Property

    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Property tdoc() As String
        Get
            Return _tdoc
        End Get
        Set(ByVal value As String)
            _tdoc = value
        End Set
    End Property

    Public Property sdoc() As String
        Get
            Return _sdoc
        End Get
        Set(ByVal value As String)
            _sdoc = value
        End Set
    End Property


End Class
