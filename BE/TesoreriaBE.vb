Public Class TesoreriaBE

    Public Class SG_TE_TB_CONCEPTOS_MOV_LISTAS
        Private _CL_IDCONCEPTO As Integer
        Private _CL_ITEM As String
        Private _CL_CUENTA As String

        Public Sub New(ByVal CL_IDCONCEPTO_ As Integer, ByVal CL_ITEM_ As String, ByVal CL_CUENTA_ As String)
            _CL_IDCONCEPTO = CL_IDCONCEPTO_
            _CL_ITEM = CL_ITEM_
            _CL_CUENTA = CL_CUENTA_
        End Sub

        Public Sub New()
            _CL_IDCONCEPTO = 0
            _CL_ITEM = String.Empty
            _CL_CUENTA = String.Empty
        End Sub

        Public Property CL_IDCONCEPTO() As Integer
            Get
                Return _CL_IDCONCEPTO
            End Get
            Set(ByVal value As Integer)
                _CL_IDCONCEPTO = value
            End Set
        End Property

        Public Property CL_ITEM() As String
            Get
                Return _CL_ITEM
            End Get
            Set(ByVal value As String)
                _CL_ITEM = value
            End Set
        End Property

        Public Property CL_CUENTA() As String
            Get
                Return _CL_CUENTA
            End Get
            Set(ByVal value As String)
                _CL_CUENTA = value
            End Set
        End Property


    End Class


    Public Class SG_TE_TB_MOVIMIENTO_D
        Private _MD_IDMC As SG_TE_TB_MOVIMIENTO_C
        Private _MD_SECUENCIA As Integer
        Private _MD_TIP_DOC As ContabilidadBE.SG_CO_TB_DOCUMENTO
        Private _MD_SER_DOC As String
        Private _MD_NUM_DOC As String
        Private _MD_FEC_DOC As String
        Private _MD_IMPORTE As Double
        Private _MD_COMENTARIO As String
        Private _MD_ES_CONCI As Integer
        Private _MD_ANHO_CONI As Integer
        Private _MD_MES_CONCI As Integer
        Private _MD_CUENTA As String 'este campo no pertence a la tabla original, solo esde ayuda para pasar un dato
        Private _MD_IMPORTE_ORI As Double 'este campo no pertence a la tabla original, solo esde ayuda para pasar un dato
        Private _MD_TC As Double 'este campo no pertence a la tabla original, solo esde ayuda para pasar un dato

        Public Sub New()
            _MD_TC = 0
            _MD_IMPORTE_ORI = 0
            _MD_IDMC = Nothing
            _MD_SECUENCIA = 0
            _MD_TIP_DOC = Nothing
            _MD_SER_DOC = String.Empty
            _MD_NUM_DOC = String.Empty
            _MD_FEC_DOC = String.Empty
            _MD_IMPORTE = 0
            _MD_COMENTARIO = String.Empty
            _MD_ES_CONCI = 0
            _MD_ANHO_CONI = 0
            _MD_MES_CONCI = 0
            _MD_CUENTA = String.Empty
        End Sub

        Public Sub New(ByVal MD_IDMC_ As SG_TE_TB_MOVIMIENTO_C, ByVal MD_SECUENCIA_ As Integer, ByVal MD_TIP_DOC_ As ContabilidadBE.SG_CO_TB_DOCUMENTO, ByVal MD_SER_DOC_ As String, ByVal MD_NUM_DOC_ As String, ByVal MD_FEC_DOC_ As String, ByVal MD_IMPORTE_ As Double, ByVal MD_COMENTARIO_ As String, ByVal MD_ES_CONCI_ As Integer, ByVal MD_ANHO_CONI_ As Integer, ByVal MD_MES_CONCI_ As Integer, ByVal MD_CUENTA_ As String, ByVal MD_TC_ As Double, ByVal MD_IMPORTE_ORI_ As Double)
            _MD_TC = MD_TC_
            _MD_IMPORTE_ORI = MD_IMPORTE_ORI_
            _MD_CUENTA = MD_CUENTA_
            _MD_IDMC = MD_IDMC_
            _MD_SECUENCIA = MD_SECUENCIA_
            _MD_TIP_DOC = MD_TIP_DOC_
            _MD_SER_DOC = MD_SER_DOC_
            _MD_NUM_DOC = MD_NUM_DOC_
            _MD_FEC_DOC = MD_FEC_DOC_
            _MD_IMPORTE = MD_IMPORTE_
            _MD_COMENTARIO = MD_COMENTARIO_
            _MD_ES_CONCI = MD_ES_CONCI_
            _MD_ANHO_CONI = MD_ANHO_CONI_
            _MD_MES_CONCI = MD_MES_CONCI_
        End Sub

        Public Property MD_IMPORTE_ORI() As Double
            Get
                Return _MD_IMPORTE_ORI
            End Get
            Set(ByVal value As Double)
                _MD_IMPORTE_ORI = value
            End Set
        End Property

        Public Property MD_TC() As Double
            Get
                Return _MD_TC
            End Get
            Set(ByVal value As Double)
                _MD_TC = value
            End Set
        End Property

        Public Property MD_CUENTA() As String
            Get
                Return _MD_CUENTA
            End Get
            Set(ByVal value As String)
                _MD_CUENTA = value
            End Set
        End Property

        Public Property MD_IDMC() As SG_TE_TB_MOVIMIENTO_C
            Get
                Return _MD_IDMC
            End Get
            Set(ByVal value As SG_TE_TB_MOVIMIENTO_C)
                _MD_IDMC = value
            End Set
        End Property

        Public Property MD_SECUENCIA() As Integer
            Get
                Return _MD_SECUENCIA
            End Get
            Set(ByVal value As Integer)
                _MD_SECUENCIA = value
            End Set
        End Property

        Public Property MD_TIP_DOC() As ContabilidadBE.SG_CO_TB_DOCUMENTO
            Get
                Return _MD_TIP_DOC
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_DOCUMENTO)
                _MD_TIP_DOC = value
            End Set
        End Property

        Public Property MD_SER_DOC() As String
            Get
                Return _MD_SER_DOC
            End Get
            Set(ByVal value As String)
                _MD_SER_DOC = value
            End Set
        End Property

        Public Property MD_NUM_DOC() As String
            Get
                Return _MD_NUM_DOC
            End Get
            Set(ByVal value As String)
                _MD_NUM_DOC = value
            End Set
        End Property

        Public Property MD_FEC_DOC() As String
            Get
                Return _MD_FEC_DOC
            End Get
            Set(ByVal value As String)
                _MD_FEC_DOC = value
            End Set
        End Property

        Public Property MD_IMPORTE() As Double
            Get
                Return _MD_IMPORTE
            End Get
            Set(ByVal value As Double)
                _MD_IMPORTE = value
            End Set
        End Property

        Public Property MD_COMENTARIO() As String
            Get
                Return _MD_COMENTARIO
            End Get
            Set(ByVal value As String)
                _MD_COMENTARIO = value
            End Set
        End Property

        Public Property MD_ES_CONCI() As Integer
            Get
                Return _MD_ES_CONCI
            End Get
            Set(ByVal value As Integer)
                _MD_ES_CONCI = value
            End Set
        End Property

        Public Property MD_ANHO_CONI() As Integer
            Get
                Return _MD_ANHO_CONI
            End Get
            Set(ByVal value As Integer)
                _MD_ANHO_CONI = value
            End Set
        End Property

        Public Property MD_MES_CONCI() As Integer
            Get
                Return _MD_MES_CONCI
            End Get
            Set(ByVal value As Integer)
                _MD_MES_CONCI = value
            End Set
        End Property

    End Class
    Public Class SG_TE_TB_MOVIMIENTO_C
        Private _MC_ID As Integer
        Private _MC_ANEXO As ContabilidadBE.SG_CO_TB_ANEXO
        Private _MC_IDCONCEPTO As SG_TE_TB_CONCEPTOS_MOV
        Private _MC_ID_COMPRO As ContabilidadBE.SG_CO_TB_DOCUMENTO
        Private _MC_SER_COMPRO As String
        Private _MC_NUM_COMPRO As String
        Private _MC_FECHA As String
        Private _MC_IMPORTE As Double
        Private _MC_TIPCAMBIO As Double
        Private _MC_COMENTARIO As String
        Private _MC_IDCENCOS As Integer
        Private _MC_IDMONEDA As ContabilidadBE.SG_CO_TB_MONEDA
        Private _MC_MEDIOPAGO As ContabilidadBE.SG_CO_TB_MEDIOPAGO
        Private _MC_PC_USUARIO As String
        Private _MC_PC_TERMINAL As String
        Private _MC_PC_FECREG As String
        Private _MC_IDEMPRESA As ContabilidadBE.SG_CO_TB_EMPRESA
        Private _MC_CUENTA_CORRI As ContabilidadBE.SG_CO_TB_BANCO_CTACTE
        Private _MC_IDCAB_CONTA As Integer
        Private _MC_NUM_VOU_CONTA As String
        Private _MC_ID_TIPOANEXO As Integer 'este campo no pertence a la tabla original, solo esde ayuda para pasar un dato
        Private _MC_IMPORTE_ORI As Double

        Public Sub New()
            _MC_IMPORTE_ORI = 0
            _MC_IDCAB_CONTA = 0
            _MC_NUM_VOU_CONTA = String.Empty
            _MC_ID_TIPOANEXO = 0
            _MC_CUENTA_CORRI = Nothing
            _MC_ID = 0
            _MC_ANEXO = Nothing
            _MC_IDCONCEPTO = Nothing
            _MC_ID_COMPRO = Nothing
            _MC_SER_COMPRO = String.Empty
            _MC_NUM_COMPRO = String.Empty
            _MC_FECHA = String.Empty
            _MC_IMPORTE = 0.0R
            _MC_TIPCAMBIO = 0.0R
            _MC_COMENTARIO = String.Empty
            _MC_IDCENCOS = 0
            _MC_IDMONEDA = Nothing
            _MC_MEDIOPAGO = Nothing
            _MC_PC_USUARIO = String.Empty
            _MC_PC_TERMINAL = String.Empty
            _MC_PC_FECREG = String.Empty
            _MC_IDEMPRESA = Nothing

        End Sub
        Public Sub New(ByVal MC_ID_ As Integer, ByVal MC_ANEXO_ As ContabilidadBE.SG_CO_TB_ANEXO, ByVal MC_IDCONCEPTO_ As SG_TE_TB_CONCEPTOS_MOV, ByVal MC_ID_COMPRO_ As ContabilidadBE.SG_CO_TB_DOCUMENTO, ByVal MC_SER_COMPRO_ As String, ByVal MC_NUM_COMPRO_ As String, ByVal MC_FECHA_ As String, ByVal MC_IMPORTE_ As Double, ByVal MC_TIPCAMBIO_ As Double, ByVal MC_COMENTARIO_ As String, ByVal MC_IDCENCOS_ As Integer, ByVal MC_IDMONEDA_ As ContabilidadBE.SG_CO_TB_MONEDA, ByVal MC_MEDIOPAGO_ As ContabilidadBE.SG_CO_TB_MEDIOPAGO, ByVal MC_PC_USUARIO_ As String, ByVal MC_PC_TERMINAL_ As String, ByVal MC_PC_FECREG_ As String, ByVal MC_IDEMPRESA_ As ContabilidadBE.SG_CO_TB_EMPRESA, ByVal MC_CUENTA_CORRI_ As ContabilidadBE.SG_CO_TB_BANCO_CTACTE, ByVal MC_ID_TIPOANEXO_ As Integer, ByVal MC_IDCAB_CONTA_ As Integer, ByVal MC_NUM_VOU_CONTA_ As String, ByVal MC_IMPORTE_ORI_ As Double)
            _MC_IMPORTE_ORI = MC_IMPORTE_ORI_
            _MC_IDCAB_CONTA = MC_IDCAB_CONTA_
            _MC_NUM_VOU_CONTA = MC_NUM_VOU_CONTA_
            _MC_ID_TIPOANEXO = MC_ID_TIPOANEXO_
            _MC_CUENTA_CORRI = MC_CUENTA_CORRI_
            _MC_ID = MC_ID_
            _MC_ANEXO = MC_ANEXO_
            _MC_IDCONCEPTO = MC_IDCONCEPTO_
            _MC_ID_COMPRO = MC_ID_COMPRO_
            _MC_SER_COMPRO = MC_SER_COMPRO_
            _MC_NUM_COMPRO = MC_NUM_COMPRO_
            _MC_FECHA = MC_FECHA_
            _MC_IMPORTE = MC_IMPORTE_
            _MC_TIPCAMBIO = MC_TIPCAMBIO_
            _MC_COMENTARIO = MC_COMENTARIO_
            _MC_IDCENCOS = MC_IDCENCOS_
            _MC_IDMONEDA = MC_IDMONEDA_
            _MC_MEDIOPAGO = MC_MEDIOPAGO_
            _MC_PC_USUARIO = MC_PC_USUARIO_
            _MC_PC_TERMINAL = MC_PC_TERMINAL_
            _MC_PC_FECREG = MC_PC_FECREG_
            _MC_IDEMPRESA = MC_IDEMPRESA_
        End Sub

        Public Property MC_IMPORTE_ORI() As Double
            Get
                Return _MC_IMPORTE_ORI
            End Get
            Set(ByVal value As Double)
                _MC_IMPORTE_ORI = value
            End Set
        End Property

        Public Property MC_NUM_VOU_CONTA() As String
            Get
                Return _MC_NUM_VOU_CONTA
            End Get
            Set(ByVal value As String)
                _MC_NUM_VOU_CONTA = value
            End Set
        End Property

        Public Property MC_IDCAB_CONTA() As Integer
            Get
                Return _MC_IDCAB_CONTA
            End Get
            Set(ByVal value As Integer)
                _MC_IDCAB_CONTA = value
            End Set
        End Property

        Public Property MC_ID_TIPOANEXO() As Integer
            Get
                Return _MC_ID_TIPOANEXO
            End Get
            Set(ByVal value As Integer)
                _MC_ID_TIPOANEXO = value
            End Set
        End Property

        Public Property MC_CUENTA_CORRI() As ContabilidadBE.SG_CO_TB_BANCO_CTACTE
            Get
                Return _MC_CUENTA_CORRI
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_BANCO_CTACTE)
                _MC_CUENTA_CORRI = value
            End Set
        End Property

        Public Property MC_ID() As Integer
            Get
                Return _MC_ID
            End Get
            Set(ByVal value As Integer)
                _MC_ID = value
            End Set
        End Property

        Public Property MC_ANEXO() As ContabilidadBE.SG_CO_TB_ANEXO
            Get
                Return _MC_ANEXO
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_ANEXO)
                _MC_ANEXO = value
            End Set
        End Property

        Public Property MC_IDCONCEPTO() As SG_TE_TB_CONCEPTOS_MOV
            Get
                Return _MC_IDCONCEPTO
            End Get
            Set(ByVal value As SG_TE_TB_CONCEPTOS_MOV)
                _MC_IDCONCEPTO = value
            End Set
        End Property

        Public Property MC_ID_COMPRO() As ContabilidadBE.SG_CO_TB_DOCUMENTO
            Get
                Return _MC_ID_COMPRO
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_DOCUMENTO)
                _MC_ID_COMPRO = value
            End Set
        End Property


        Public Property MC_SER_COMPRO() As String
            Get
                Return _MC_SER_COMPRO
            End Get
            Set(ByVal value As String)
                _MC_SER_COMPRO = value
            End Set
        End Property


        Public Property MC_NUM_COMPRO() As String
            Get
                Return _MC_NUM_COMPRO
            End Get
            Set(ByVal value As String)
                _MC_NUM_COMPRO = value
            End Set
        End Property


        Public Property MC_FECHA() As String
            Get
                Return _MC_FECHA
            End Get
            Set(ByVal value As String)
                _MC_FECHA = value
            End Set
        End Property

        Public Property MC_IMPORTE() As Double
            Get
                Return _MC_IMPORTE
            End Get
            Set(ByVal value As Double)
                _MC_IMPORTE = value
            End Set
        End Property

        Public Property MC_TIPCAMBIO() As Double
            Get
                Return _MC_TIPCAMBIO
            End Get
            Set(ByVal value As Double)
                _MC_TIPCAMBIO = value
            End Set
        End Property

        Public Property MC_COMENTARIO() As String
            Get
                Return _MC_COMENTARIO
            End Get
            Set(ByVal value As String)
                _MC_COMENTARIO = value
            End Set
        End Property

        Public Property MC_IDCENCOS() As Integer
            Get
                Return _MC_IDCENCOS
            End Get
            Set(ByVal value As Integer)
                _MC_IDCENCOS = value
            End Set
        End Property

        Public Property MC_IDMONEDA() As ContabilidadBE.SG_CO_TB_MONEDA
            Get
                Return _MC_IDMONEDA
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_MONEDA)
                _MC_IDMONEDA = value
            End Set
        End Property

        Public Property MC_MEDIOPAGO() As ContabilidadBE.SG_CO_TB_MEDIOPAGO
            Get
                Return _MC_MEDIOPAGO
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_MEDIOPAGO)
                _MC_MEDIOPAGO = value
            End Set
        End Property

        Public Property MC_PC_USUARIO() As String
            Get
                Return _MC_PC_USUARIO
            End Get
            Set(ByVal value As String)
                _MC_PC_USUARIO = value
            End Set
        End Property

        Public Property MC_PC_TERMINAL() As String
            Get
                Return _MC_PC_TERMINAL
            End Get
            Set(ByVal value As String)
                _MC_PC_TERMINAL = value
            End Set
        End Property

        Public Property MC_PC_FECREG() As String
            Get
                Return _MC_PC_FECREG
            End Get
            Set(ByVal value As String)
                _MC_PC_FECREG = value
            End Set
        End Property

        Public Property MC_IDEMPRESA() As ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _MC_IDEMPRESA
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_EMPRESA)
                _MC_IDEMPRESA = value
            End Set
        End Property

    End Class
    Public Class SG_TE_TB_CONCEPTOS_MOV
        Private _CM_ID As Integer
        Private _CM_DESCRIPCION As String
        Private _CM_IDSUBDIARIO As ContabilidadBE.SG_CO_TB_SUBDIARIO
        Private _CM_IDEMPRESA As ContabilidadBE.SG_CO_TB_EMPRESA
        Private _CM_IDTIPO_MOV As SG_TE_TB_TIPO_MOVIMIENTO
        Private _CM_ES_DETALLE As Integer
        Private _CM_ES_DOCUMENTO As Integer
        Private _CM_CUENTA_CONTA As String


        Public Sub New(ByVal CM_ID_ As Integer, ByVal CM_DESCRIPCION_ As String, ByVal CM_IDSUBDIARIO_ As ContabilidadBE.SG_CO_TB_SUBDIARIO, ByVal CM_IDEMPRESA_ As ContabilidadBE.SG_CO_TB_EMPRESA, ByVal CM_IDTIPO_MOV_ As SG_TE_TB_TIPO_MOVIMIENTO, ByVal CM_ES_DETALLE_ As Integer, ByVal CM_ES_DOCUMENTO_ As Integer, ByVal CM_CUENTA_CONTA_ As Integer)
            _CM_ES_DETALLE = CM_ES_DETALLE_
            _CM_ES_DOCUMENTO = CM_ES_DOCUMENTO_
            _CM_CUENTA_CONTA = CM_CUENTA_CONTA_
            _CM_ID = CM_ID_
            _CM_DESCRIPCION = CM_DESCRIPCION_
            _CM_IDSUBDIARIO = CM_IDSUBDIARIO_
            _CM_IDEMPRESA = CM_IDEMPRESA_
            _CM_IDTIPO_MOV = CM_IDTIPO_MOV_
        End Sub
        Public Sub New()
            _CM_ES_DETALLE = 0
            _CM_ES_DOCUMENTO = 0
            _CM_CUENTA_CONTA = String.Empty
            _CM_ID = 0
            _CM_DESCRIPCION = String.Empty
            _CM_IDSUBDIARIO = Nothing
            _CM_IDEMPRESA = Nothing
            _CM_IDTIPO_MOV = Nothing
        End Sub

        Public Property CM_CUENTA_CONTA() As String
            Get
                Return _CM_CUENTA_CONTA
            End Get
            Set(ByVal value As String)
                _CM_CUENTA_CONTA = value
            End Set
        End Property

        Public Property CM_ES_DOCUMENTO() As Integer
            Get
                Return _CM_ES_DOCUMENTO
            End Get
            Set(ByVal value As Integer)
                _CM_ES_DOCUMENTO = value
            End Set
        End Property

        Public Property CM_ES_DETALLE() As Integer
            Get
                Return _CM_ES_DETALLE
            End Get
            Set(ByVal value As Integer)
                _CM_ES_DETALLE = value
            End Set
        End Property

        Public Property CM_ID() As Integer
            Get
                Return _CM_ID
            End Get
            Set(ByVal value As Integer)
                _CM_ID = value
            End Set
        End Property

        Public Property CM_DESCRIPCION() As String
            Get
                Return _CM_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CM_DESCRIPCION = value
            End Set
        End Property

        Public Property CM_IDSUBDIARIO() As ContabilidadBE.SG_CO_TB_SUBDIARIO
            Get
                Return _CM_IDSUBDIARIO
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_SUBDIARIO)
                _CM_IDSUBDIARIO = value
            End Set
        End Property

        Public Property CM_IDEMPRESA() As ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _CM_IDEMPRESA
            End Get
            Set(ByVal value As ContabilidadBE.SG_CO_TB_EMPRESA)
                _CM_IDEMPRESA = value
            End Set
        End Property

        Public Property CM_IDTIPO_MOV() As SG_TE_TB_TIPO_MOVIMIENTO
            Get
                Return _CM_IDTIPO_MOV
            End Get
            Set(ByVal value As SG_TE_TB_TIPO_MOVIMIENTO)
                _CM_IDTIPO_MOV = value
            End Set
        End Property

    End Class
    Public Class SG_TE_TB_TIPO_MOVIMIENTO
        Private _TM_ID As Integer
        Private _TM_DESCRIPCION As String

        Public Sub New(ByVal TM_ID_ As Integer, ByVal TM_DESCRIPCION_ As String)
            _TM_ID = TM_ID_
            _TM_DESCRIPCION = TM_DESCRIPCION_
        End Sub

        Public Sub New()
            _TM_ID = 0
            _TM_DESCRIPCION = String.Empty
        End Sub

        Public Property TM_ID() As Integer
            Get
                Return _TM_ID
            End Get
            Set(ByVal value As Integer)
                _TM_ID = value
            End Set
        End Property

        Public Property TM_DESCRIPCION() As String
            Get
                Return _TM_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TM_DESCRIPCION = value
            End Set
        End Property
    End Class

End Class
