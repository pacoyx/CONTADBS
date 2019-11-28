Public Class PlanillaBE

    Public Class SG_PL_TB_PERSONAL_HORAS_DET

        Private _PHD_IDPERSONAL As Integer
        Private _PHD_IDTIPO_TARIFA As Integer
        Private _PHD_VALOR_HORA As Double
        Private _PHD_ANHO As Integer
        Private _PHD_MES As Integer
        Private _PHD_IDEMPRESA As Integer
        Private _PHD_USUARIO As String
        Private _PHD_TERMINAL As String
        Private _PHD_FECREG As String

        Public Sub New(ByVal PHD_IDPERSONAL_ As Integer, ByVal PHD_IDTIPO_TARIFA_ As Integer, ByVal PHD_VALOR_HORA_ As Double, ByVal PHD_ANHO_ As Integer, ByVal PHD_MES_ As Integer, ByVal PHD_IDEMPRESA_ As Integer, ByVal PHD_USUARIO_ As String, ByVal PHD_TERMINAL_ As String, ByVal PHD_FECREG_ As String)
            _PHD_IDPERSONAL = PHD_IDPERSONAL_
            _PHD_IDTIPO_TARIFA = PHD_IDTIPO_TARIFA_
            _PHD_VALOR_HORA = PHD_VALOR_HORA_
            _PHD_ANHO = PHD_ANHO_
            _PHD_MES = PHD_MES_
            _PHD_IDEMPRESA = PHD_IDEMPRESA_
            _PHD_USUARIO = PHD_USUARIO_
            _PHD_TERMINAL = PHD_TERMINAL_
            _PHD_FECREG = PHD_FECREG_
        End Sub

        Public Property PHD_IDEMPRESA() As Integer
            Get
                Return _PHD_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PHD_IDEMPRESA = value
            End Set
        End Property

        Public Property PHD_USUARIO() As String
            Get
                Return _PHD_USUARIO
            End Get
            Set(ByVal value As String)
                _PHD_USUARIO = value
            End Set
        End Property

        Public Property PHD_TERMINAL() As String
            Get
                Return _PHD_TERMINAL
            End Get
            Set(ByVal value As String)
                _PHD_TERMINAL = value
            End Set
        End Property

        Public Property PHD_FECREG() As String
            Get
                Return _PHD_FECREG
            End Get
            Set(ByVal value As String)
                _PHD_FECREG = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_PERSONAL_HORAS_CAB
        Private _PHC_ANHO As Integer
        Private _PHC_MES As Integer
        Private _PHC_OK_SISTEMAS As Integer
        Private _PHC_OK_CONTABILIDAD As Integer
        Private _PHC_ESTADO As Integer
        Private _PHC_IDEMPRESA As Integer
        Private _PHC_USUARIO As String
        Private _PHC_TERMINAL As String
        Private _PHC_FECREG As String

        Public Sub New(ByVal PHC_ANHO_ As Integer, ByVal PHC_MES_ As Integer, ByVal PHC_OK_SISTEMAS_ As Integer, ByVal PHC_OK_CONTABILIDAD_ As Integer, ByVal PHC_ESTADO_ As Integer, ByVal PHC_IDEMPRESA_ As Integer, ByVal PHC_USUARIO_ As String, ByVal PHC_TERMINAL_ As String, ByVal PHC_FECREG_ As String)
            _PHC_ANHO = PHC_ANHO_
            _PHC_MES = PHC_MES_
            _PHC_OK_SISTEMAS = PHC_OK_SISTEMAS_
            _PHC_OK_CONTABILIDAD = PHC_OK_CONTABILIDAD_
            _PHC_ESTADO = PHC_ESTADO_
            _PHC_IDEMPRESA = PHC_IDEMPRESA_
            _PHC_USUARIO = PHC_USUARIO_
            _PHC_TERMINAL = PHC_TERMINAL_
            _PHC_FECREG = PHC_FECREG_
        End Sub

        Public Sub New()
            _PHC_ANHO = 0
            _PHC_MES = 0
            _PHC_OK_SISTEMAS = 0
            _PHC_OK_CONTABILIDAD = 0
            _PHC_ESTADO = 0
            _PHC_IDEMPRESA = 0
            _PHC_USUARIO = String.Empty
            _PHC_TERMINAL = String.Empty
            _PHC_FECREG = String.Empty
        End Sub

        Public Property PHC_ANHO() As Integer
            Get
                Return _PHC_ANHO
            End Get
            Set(ByVal value As Integer)
                _PHC_ANHO = value
            End Set
        End Property

        Public Property PHC_MES() As Integer
            Get
                Return _PHC_MES
            End Get
            Set(ByVal value As Integer)
                _PHC_MES = value
            End Set
        End Property

        Public Property PHC_OK_SISTEMAS() As Integer
            Get
                Return _PHC_OK_SISTEMAS
            End Get
            Set(ByVal value As Integer)
                _PHC_OK_SISTEMAS = value
            End Set
        End Property

        Public Property PHC_OK_CONTABILIDAD() As Integer
            Get
                Return _PHC_OK_CONTABILIDAD
            End Get
            Set(ByVal value As Integer)
                _PHC_OK_CONTABILIDAD = value
            End Set
        End Property

        Public Property PHC_ESTADO() As Integer
            Get
                Return _PHC_ESTADO
            End Get
            Set(ByVal value As Integer)
                _PHC_ESTADO = value
            End Set
        End Property

        Public Property PHC_IDEMPRESA() As Integer
            Get
                Return _PHC_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PHC_IDEMPRESA = value
            End Set
        End Property

        Public Property PHC_USUARIO() As String
            Get
                Return _PHC_USUARIO
            End Get
            Set(ByVal value As String)
                _PHC_USUARIO = value
            End Set
        End Property

        Public Property PHC_TERMINAL() As String
            Get
                Return _PHC_TERMINAL
            End Get
            Set(ByVal value As String)
                _PHC_TERMINAL = value
            End Set
        End Property

        Public Property PHC_FECREG() As String
            Get
                Return _PHC_FECREG
            End Get
            Set(ByVal value As String)
                _PHC_FECREG = value
            End Set
        End Property

    End Class



    Public Class SG_PL_TB_TOPE_MENSUAL
        Private _TM_PERIODO As Integer
        Private _TM_MES As Integer
        Private _TM_VALOR As Double
        Private _TM_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal TM_PERIODO_ As Integer, ByVal TM_MES_ As Integer, ByVal TM_VALOR_ As Double, ByVal TM_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _TM_PERIODO = TM_PERIODO_
            _TM_MES = TM_MES_
            _TM_VALOR = TM_VALOR_
            _TM_IDEMPRESA = TM_IDEMPRESA_
        End Sub

        Public Sub New()
            _TM_PERIODO = 0
            _TM_MES = 0
            _TM_VALOR = 0.0R
            _TM_IDEMPRESA = Nothing
        End Sub

        Public Property TM_PERIODO() As Integer
            Get
                Return _TM_PERIODO
            End Get
            Set(ByVal value As Integer)
                _TM_PERIODO = value
            End Set
        End Property

        Public Property TM_MES() As Integer
            Get
                Return _TM_MES
            End Get
            Set(ByVal value As Integer)
                _TM_MES = value
            End Set
        End Property

        Public Property TM_VALOR() As Double
            Get
                Return _TM_VALOR
            End Get
            Set(ByVal value As Double)
                _TM_VALOR = value
            End Set
        End Property

        Public Property TM_IDEMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _TM_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _TM_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_HISTORIAL
        Private _HI_ID_PERSONAL As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _HI_MES As Integer
        Private _HI_FEC_OPE As String
        Private _HI_COD_HD As BE.PlanillaBE.SG_PL_TB_CONCEPTOS
        Private _HI_MONTO As Double
        Private _HI_IDEN_HD As Integer '1=Debe;     2=Haber
        Private _HI_EST_ASI As Integer
        Private _HI_COD_AFP As Integer
        Private _HI_DES_HD As String
        Private _HI_HORAS As Double
        Private _HI_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _HI_USUARIO As String
        Private _HI_TERMINAL As String
        Private _HI_FECREG As String

        Public Sub New(ByVal HI_ID_PERSONAL_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal HI_MES_ As Integer, ByVal HI_FEC_OPE_ As String, ByVal HI_COD_HD_ As BE.PlanillaBE.SG_PL_TB_CONCEPTOS, ByVal HI_MONTO_ As Double, ByVal HI_IDEN_HD_ As Integer, ByVal HI_EST_ASI_ As Integer, ByVal HI_COD_AFP_ As Integer, ByVal HI_DES_HD_ As String, ByVal HI_HORAS_ As Double, ByVal HI_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal HI_USUARIO_ As String, ByVal HI_TERMINAL_ As String, ByVal HI_FECREG_ As String)
            _HI_ID_PERSONAL = HI_ID_PERSONAL_
            _HI_MES = HI_MES_
            _HI_FEC_OPE = HI_FEC_OPE_
            _HI_COD_HD = HI_COD_HD_
            _HI_MONTO = HI_MONTO_
            _HI_IDEN_HD = HI_IDEN_HD_
            _HI_EST_ASI = HI_EST_ASI_
            _HI_COD_AFP = HI_COD_AFP_
            _HI_DES_HD = HI_DES_HD_
            _HI_HORAS = HI_HORAS_
            _HI_ID_EMPRESA = HI_ID_EMPRESA_
            _HI_USUARIO = HI_USUARIO_
            _HI_TERMINAL = HI_TERMINAL_
            _HI_FECREG = HI_FECREG_
        End Sub

        Public Sub New()
            _HI_ID_PERSONAL = Nothing
            _HI_MES = 0
            _HI_FEC_OPE = String.Empty
            _HI_COD_HD = Nothing
            _HI_MONTO = 0.0R
            _HI_IDEN_HD = 0
            _HI_EST_ASI = 0
            _HI_COD_AFP = 0
            _HI_DES_HD = String.Empty
            _HI_HORAS = 0.0R
            _HI_ID_EMPRESA = Nothing
            _HI_USUARIO = String.Empty
            _HI_TERMINAL = String.Empty
            _HI_FECREG = String.Empty
        End Sub

        Public Property HI_ID_PERSONAL() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _HI_ID_PERSONAL
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _HI_ID_PERSONAL = value
            End Set
        End Property

        Public Property HI_MES() As Integer
            Get
                Return _HI_MES
            End Get
            Set(ByVal value As Integer)
                _HI_MES = value
            End Set
        End Property

        Public Property HI_FEC_OPE() As String
            Get
                Return _HI_FEC_OPE
            End Get
            Set(ByVal value As String)
                _HI_FEC_OPE = value
            End Set
        End Property

        Public Property HI_COD_HD() As BE.PlanillaBE.SG_PL_TB_CONCEPTOS
            Get
                Return _HI_COD_HD
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
                _HI_COD_HD = value
            End Set
        End Property

        Public Property HI_MONTO() As Double
            Get
                Return _HI_MONTO
            End Get
            Set(ByVal value As Double)
                _HI_MONTO = value
            End Set
        End Property


        Public Property HI_IDEN_HD() As Integer
            Get
                Return _HI_IDEN_HD
            End Get
            Set(ByVal value As Integer)
                _HI_IDEN_HD = value
            End Set
        End Property

        Public Property HI_EST_ASI() As Integer
            Get
                Return _HI_EST_ASI
            End Get
            Set(ByVal value As Integer)
                _HI_EST_ASI = value
            End Set
        End Property

        Public Property HI_COD_AFP() As Integer
            Get
                Return _HI_COD_AFP
            End Get
            Set(ByVal value As Integer)
                _HI_COD_AFP = value
            End Set
        End Property

        Public Property HI_DES_HD() As String
            Get
                Return _HI_DES_HD
            End Get
            Set(ByVal value As String)
                _HI_DES_HD = value
            End Set
        End Property

        Public Property HI_HORAS() As Double
            Get
                Return _HI_HORAS
            End Get
            Set(ByVal value As Double)
                _HI_HORAS = value
            End Set
        End Property

        Public Property HI_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _HI_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _HI_ID_EMPRESA = value
            End Set
        End Property

        Public Property HI_USUARIO() As String
            Get
                Return _HI_USUARIO
            End Get
            Set(ByVal value As String)
                _HI_USUARIO = value
            End Set
        End Property

        Public Property HI_TERMINAL() As String
            Get
                Return _HI_TERMINAL
            End Get
            Set(ByVal value As String)
                _HI_TERMINAL = value
            End Set
        End Property

        Public Property HI_FECREG() As String
            Get
                Return _HI_FECREG
            End Get
            Set(ByVal value As String)
                _HI_FECREG = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_PERSONAL_CONCEPTO
        Private _PC_ID_PERSONAL As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _PC_ID_CONCEPTO As BE.PlanillaBE.SG_PL_TB_CONCEPTOS
        Private _PC_VALOR As Double
        Private _PC_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal PC_ID_PERSONAL_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal PC_ID_CONCEPTO_ As BE.PlanillaBE.SG_PL_TB_CONCEPTOS, ByVal PC_VALOR_ As Double, ByVal PC_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _PC_ID_PERSONAL = PC_ID_PERSONAL_
            _PC_ID_CONCEPTO = PC_ID_CONCEPTO_
            _PC_VALOR = PC_VALOR_
            _PC_ID_EMPRESA = PC_ID_EMPRESA_
        End Sub

        Public Sub New()
            _PC_ID_PERSONAL = Nothing
            _PC_ID_CONCEPTO = Nothing
            _PC_VALOR = 0.0R
            _PC_ID_EMPRESA = Nothing
        End Sub

        Public Property PC_ID_PERSONAL() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _PC_ID_PERSONAL
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _PC_ID_PERSONAL = value
            End Set
        End Property

        Public Property PC_ID_CONCEPTO() As BE.PlanillaBE.SG_PL_TB_CONCEPTOS
            Get
                Return _PC_ID_CONCEPTO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
                _PC_ID_CONCEPTO = value
            End Set
        End Property

        Public Property PC_VALOR() As Double
            Get
                Return _PC_VALOR
            End Get
            Set(ByVal value As Double)
                _PC_VALOR = value
            End Set
        End Property

        Public Property PC_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _PC_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _PC_ID_EMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_CTA_CTE_CRONOGRAMA
        Private _CR_ID_CTACTE As BE.PlanillaBE.SG_PL_TB_CTA_CTE
        Private _CR_NUM_CUOTA As Integer
        Private _CR_FECHA_PAGO As String
        Private _CR_IMPORTE As Double
        Private _CR_ESTADO As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO

        Public Sub New(ByVal CR_ID_CTACTE_ As BE.PlanillaBE.SG_PL_TB_CTA_CTE, ByVal CR_NUM_CUOTA_ As Integer, ByVal CR_FECHA_PAGO_ As String, ByVal CR_IMPORTE_ As Double, ByVal CR_ESTADO_ As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO)
            _CR_ID_CTACTE = CR_ID_CTACTE_
            _CR_NUM_CUOTA = CR_NUM_CUOTA_
            _CR_FECHA_PAGO = CR_FECHA_PAGO_
            _CR_IMPORTE = CR_IMPORTE_
            _CR_ESTADO = CR_ESTADO_
        End Sub

        Public Sub New()
            _CR_ID_CTACTE = Nothing
            _CR_NUM_CUOTA = 0
            _CR_FECHA_PAGO = String.Empty
            _CR_IMPORTE = 0
            _CR_ESTADO = Nothing
        End Sub

        Public Property CR_ID_CTACTE() As BE.PlanillaBE.SG_PL_TB_CTA_CTE
            Get
                Return _CR_ID_CTACTE
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_CTA_CTE)
                _CR_ID_CTACTE = value
            End Set
        End Property

        Public Property CR_NUM_CUOTA() As Integer
            Get
                Return _CR_NUM_CUOTA
            End Get
            Set(ByVal value As Integer)
                _CR_NUM_CUOTA = value
            End Set
        End Property

        Public Property CR_FECHA_PAGO() As String
            Get
                Return _CR_FECHA_PAGO
            End Get
            Set(ByVal value As String)
                _CR_FECHA_PAGO = value
            End Set
        End Property

        Public Property CR_IMPORTE() As Double
            Get
                Return _CR_IMPORTE
            End Get
            Set(ByVal value As Double)
                _CR_IMPORTE = value
            End Set
        End Property

        Public Property CR_ESTADO() As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO
            Get
                Return _CR_ESTADO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO)
                _CR_ESTADO = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_MOTIVO_PRESTAMO
        Private _MP_ID As Integer
        Private _MP_DESCRIPCION As String

        Public Sub New(ByVal MP_ID_ As Integer, ByVal MP_DESCRIPCION_ As String)
            _MP_ID = MP_ID_
            _MP_DESCRIPCION = MP_DESCRIPCION_
        End Sub

        Public Sub New()
            _MP_ID = 0
            _MP_DESCRIPCION = String.Empty
        End Sub

        Public Property MP_ID() As Integer
            Get
                Return _MP_ID
            End Get
            Set(ByVal value As Integer)
                _MP_ID = value
            End Set
        End Property

        Public Property MP_DESCRIPCION() As String
            Get
                Return _MP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _MP_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_ESTADO_PRESTAMO
        Private _EP_ID As Integer
        Private _EP_DESCRIPCION As String

        Public Sub New(ByVal EP_ID_ As Integer, ByVal EP_DESCRIPCION_ As String)
            _EP_ID = EP_ID_
            _EP_DESCRIPCION = EP_DESCRIPCION_
        End Sub

        Public Sub New()
            _EP_ID = 0
            _EP_DESCRIPCION = String.Empty
        End Sub

        Public Property EP_ID() As Integer
            Get
                Return _EP_ID
            End Get
            Set(ByVal value As Integer)
                _EP_ID = value
            End Set
        End Property

        Public Property EP_DESCRIPCION() As String
            Get
                Return _EP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _EP_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_CTA_CTE
        Private _CC_ID As Integer
        Private _CC_NUMERO As Integer
        Private _CC_FECHA_REGISTRO As String
        Private _CC_ID_PERSONAL As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _CC_ID_MOTIVO As BE.PlanillaBE.SG_PL_TB_MOTIVO_PRESTAMO
        Private _CC_AFECTA_PLANILLA As Integer
        Private _CC_ID_MONEDA As BE.ContabilidadBE.SG_CO_TB_MONEDA
        Private _CC_IMPORTE As Double
        Private _CC_TC As Double
        Private _CC_NUM_CUOTAS As Integer
        Private _CC_OBSERVACIONES As String
        Private _CC_ESTADO As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO
        Private _CC_SALDO As Double
        Private _CC_USUARIO As String
        Private _CC_TERMINAL As String
        Private _CC_FECREG As String

        Public Sub New(ByVal CC_ID_ As Integer, ByVal CC_NUMERO_ As Integer, ByVal CC_FECHA_REGISTRO_ As String, ByVal CO_ID_PERSONAL_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal CO_ID_MOTIVO_ As BE.PlanillaBE.SG_PL_TB_MOTIVO_PRESTAMO, ByVal CO_AFECTA_PLANILLA_ As Integer, ByVal CO_ID_MONEDA_ As BE.ContabilidadBE.SG_CO_TB_MONEDA, ByVal CO_IMPORTE_ As Double, ByVal CO_TC_ As Double, ByVal CO_NUM_CUOTAS_ As Integer, ByVal CO_OBSERVACIONES_ As String, ByVal CO_ESTADO_ As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO, ByVal CO_SALDO_ As Double, ByVal CO_USUARIO_ As String, ByVal CO_TERMINAL_ As String, ByVal CO_FECREG_ As String)
            _CC_ID = CC_ID_
            _CC_NUMERO = CC_NUMERO_
            _CC_FECHA_REGISTRO = CC_FECHA_REGISTRO_
            _CC_ID_PERSONAL = CO_ID_PERSONAL_
            _CC_ID_MOTIVO = CO_ID_MOTIVO_
            _CC_AFECTA_PLANILLA = CO_AFECTA_PLANILLA_
            _CC_ID_MONEDA = CO_ID_MONEDA_
            _CC_IMPORTE = CO_IMPORTE_
            _CC_TC = CO_TC_
            _CC_NUM_CUOTAS = CO_NUM_CUOTAS_
            _CC_OBSERVACIONES = CO_OBSERVACIONES_
            _CC_ESTADO = CO_ESTADO_
            _CC_SALDO = CO_SALDO_
            _CC_USUARIO = CO_USUARIO_
            _CC_TERMINAL = CO_TERMINAL_
            _CC_FECREG = CO_FECREG_
        End Sub

        Public Sub New()
            _CC_ID = 0
            _CC_NUMERO = 0
            _CC_FECHA_REGISTRO = String.Empty
            _CC_ID_PERSONAL = Nothing
            _CC_ID_MOTIVO = Nothing
            _CC_AFECTA_PLANILLA = 0
            _CC_ID_MONEDA = Nothing
            _CC_IMPORTE = 0
            _CC_TC = 0
            _CC_NUM_CUOTAS = 0
            _CC_OBSERVACIONES = String.Empty
            _CC_ESTADO = Nothing
            _CC_SALDO = 0
            _CC_USUARIO = String.Empty
            _CC_TERMINAL = String.Empty
            _CC_FECREG = String.Empty
        End Sub


        Public Property CC_ID() As Integer
            Get
                Return _CC_ID
            End Get
            Set(ByVal value As Integer)
                _CC_ID = value
            End Set
        End Property

        Public Property CC_NUMERO() As Integer
            Get
                Return _CC_NUMERO
            End Get
            Set(ByVal value As Integer)
                _CC_NUMERO = value
            End Set
        End Property

        Public Property CC_FECHA_REGISTRO() As String
            Get
                Return _CC_FECHA_REGISTRO
            End Get
            Set(ByVal value As String)
                _CC_FECHA_REGISTRO = value
            End Set
        End Property

        Public Property CC_ID_PERSONAL() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _CC_ID_PERSONAL
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _CC_ID_PERSONAL = value
            End Set
        End Property

        Public Property CC_ID_MOTIVO() As BE.PlanillaBE.SG_PL_TB_MOTIVO_PRESTAMO
            Get
                Return _CC_ID_MOTIVO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_MOTIVO_PRESTAMO)
                _CC_ID_MOTIVO = value
            End Set
        End Property

        Public Property CC_AFECTA_PLANILLA() As Integer
            Get
                Return _CC_AFECTA_PLANILLA
            End Get
            Set(ByVal value As Integer)
                _CC_AFECTA_PLANILLA = value
            End Set
        End Property

        Public Property CC_ID_MONEDA() As BE.ContabilidadBE.SG_CO_TB_MONEDA
            Get
                Return _CC_ID_MONEDA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_MONEDA)
                _CC_ID_MONEDA = value
            End Set
        End Property

        Public Property CC_IMPORTE() As Double
            Get
                Return _CC_IMPORTE
            End Get
            Set(ByVal value As Double)
                _CC_IMPORTE = value
            End Set
        End Property

        Public Property CC_TC() As Double
            Get
                Return _CC_TC
            End Get
            Set(ByVal value As Double)
                _CC_TC = value
            End Set
        End Property

        Public Property CC_NUM_CUOTAS() As Integer
            Get
                Return _CC_NUM_CUOTAS
            End Get
            Set(ByVal value As Integer)
                _CC_NUM_CUOTAS = value
            End Set
        End Property

        Public Property CC_OBSERVACIONES() As String
            Get
                Return _CC_OBSERVACIONES
            End Get
            Set(ByVal value As String)
                _CC_OBSERVACIONES = value
            End Set
        End Property

        Public Property CC_ESTADO() As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO
            Get
                Return _CC_ESTADO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_ESTADO_PRESTAMO)
                _CC_ESTADO = value
            End Set
        End Property

        Public Property CC_SALDO() As Double
            Get
                Return _CC_SALDO
            End Get
            Set(ByVal value As Double)
                _CC_SALDO = value
            End Set
        End Property

        Public Property CC_USUARIO() As String
            Get
                Return _CC_USUARIO
            End Get
            Set(ByVal value As String)
                _CC_USUARIO = value
            End Set
        End Property

        Public Property CC_TERMINAL() As String
            Get
                Return _CC_TERMINAL
            End Get
            Set(ByVal value As String)
                _CC_TERMINAL = value
            End Set
        End Property

        Public Property CC_FECREG() As String
            Get
                Return _CC_FECREG
            End Get
            Set(ByVal value As String)
                _CC_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_SUSPENSIONES
        Private _SU_ID As Integer
        Private _SU_ID_TIPO_SUSPENSION As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION
        Private _SU_ID_PERSONAL As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _SU_FECHA_INI As String
        Private _SU_FECHA_FIN As String
        Private _SU_DIAS_VACA As Integer
        Private _SU_DIAS_TRABAJO As Integer
        Private _SU_USUARIO As String
        Private _SU_TERMINAL As String
        Private _SU_FECREG As String
        Private _SU_ID_TIPO_SUSPE_SUNAT As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT
        Private _SU_PROCESAR As Integer

        Public Sub New(ByVal SU_ID_ As Integer, ByVal SU_ID_TIPO_SUSPENSION_ As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION, ByVal SU_ID_PERSONAL_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal SU_FECHA_INI_ As String, ByVal SU_FECHA_FIN_ As String, ByVal SU_DIAS_VACA_ As Integer, ByVal SU_DIAS_TRABAJO_ As Integer, ByVal SU_USUARIO_ As String, ByVal SU_TERMINAL_ As String, ByVal SU_FECREG_ As String, ByVal SU_ID_TIPO_SUSPE_SUNAT_ As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT, ByVal SU_PROCESAR_ As Integer)
            _SU_ID = SU_ID_
            _SU_ID_TIPO_SUSPENSION = SU_ID_TIPO_SUSPENSION_
            _SU_ID_PERSONAL = SU_ID_PERSONAL_
            _SU_FECHA_INI = SU_FECHA_INI_
            _SU_FECHA_FIN = SU_FECHA_FIN_
            _SU_DIAS_VACA = SU_DIAS_VACA_
            _SU_DIAS_TRABAJO = SU_DIAS_TRABAJO_
            _SU_USUARIO = SU_USUARIO_
            _SU_TERMINAL = SU_TERMINAL_
            _SU_FECREG = SU_FECREG_
            _SU_ID_TIPO_SUSPE_SUNAT = SU_ID_TIPO_SUSPE_SUNAT_
            _SU_PROCESAR = SU_PROCESAR_
        End Sub

        Public Sub New()
            _SU_ID = 0
            _SU_ID_TIPO_SUSPENSION = Nothing
            _SU_ID_PERSONAL = Nothing
            _SU_FECHA_INI = String.Empty
            _SU_FECHA_FIN = String.Empty
            _SU_DIAS_VACA = 0
            _SU_DIAS_TRABAJO = 0
            _SU_USUARIO = String.Empty
            _SU_TERMINAL = String.Empty
            _SU_FECREG = String.Empty
            _SU_ID_TIPO_SUSPE_SUNAT = Nothing
            _SU_PROCESAR = 0
        End Sub

        Public Property SU_PROCESAR() As Integer
            Get
                Return _SU_PROCESAR
            End Get
            Set(ByVal value As Integer)
                _SU_PROCESAR = value
            End Set
        End Property

        Public Property SU_ID() As Integer
            Get
                Return _SU_ID
            End Get
            Set(ByVal value As Integer)
                _SU_ID = value
            End Set
        End Property

        Public Property SU_ID_TIPO_SUSPENSION() As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION
            Get
                Return _SU_ID_TIPO_SUSPENSION
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION)
                _SU_ID_TIPO_SUSPENSION = value
            End Set
        End Property

        Public Property SU_ID_PERSONAL() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _SU_ID_PERSONAL
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _SU_ID_PERSONAL = value
            End Set
        End Property

        Public Property SU_FECHA_INI() As String
            Get
                Return _SU_FECHA_INI
            End Get
            Set(ByVal value As String)
                _SU_FECHA_INI = value
            End Set
        End Property

        Public Property SU_FECHA_FIN() As String
            Get
                Return _SU_FECHA_FIN
            End Get
            Set(ByVal value As String)
                _SU_FECHA_FIN = value
            End Set
        End Property

        Public Property SU_DIAS_VACA() As Integer
            Get
                Return _SU_DIAS_VACA
            End Get
            Set(ByVal value As Integer)
                _SU_DIAS_VACA = value
            End Set
        End Property

        Public Property SU_DIAS_TRABAJO() As Integer
            Get
                Return _SU_DIAS_TRABAJO
            End Get
            Set(ByVal value As Integer)
                _SU_DIAS_TRABAJO = value
            End Set
        End Property

        Public Property SU_USUARIO() As String
            Get
                Return _SU_USUARIO
            End Get
            Set(ByVal value As String)
                _SU_USUARIO = value
            End Set
        End Property

        Public Property SU_TERMINAL() As String
            Get
                Return _SU_TERMINAL
            End Get
            Set(ByVal value As String)
                _SU_TERMINAL = value
            End Set
        End Property

        Public Property SU_FECREG() As String
            Get
                Return _SU_FECREG
            End Get
            Set(ByVal value As String)
                _SU_FECREG = value
            End Set
        End Property

        Public Property SU_ID_TIPO_SUSPE_SUNAT() As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT
            Get
                Return _SU_ID_TIPO_SUSPE_SUNAT
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_TIPO_SUSPENSION_SUNAT)
                _SU_ID_TIPO_SUSPE_SUNAT = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_SUSPENSION_SUNAT
        Private _TS_CODIGO As String
        Private _TS_DESCRIPCION As String

        Public Sub New(ByVal TS_CODIGO_ As String, ByVal TS_DESCRIPCION_ As String)
            _TS_CODIGO = _TS_CODIGO
            _TS_DESCRIPCION = TS_DESCRIPCION_
        End Sub

        Public Sub New()
            _TS_CODIGO = String.Empty
            _TS_DESCRIPCION = String.Empty
        End Sub

        Public Property TS_CODIGO() As String
            Get
                Return _TS_CODIGO
            End Get
            Set(ByVal value As String)
                _TS_CODIGO = value
            End Set
        End Property

        Public Property TS_DESCRIPCION() As String
            Get
                Return _TS_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TS_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_SUSPENSION
        Private _TS_ID As Integer
        Private _TS_DESCRIPCION As String

        Public Sub New(ByVal TS_ID_ As Integer, ByVal TS_DESCRIPCION_ As String)
            _TS_ID = TS_ID_
            _TS_DESCRIPCION = TS_DESCRIPCION_
        End Sub

        Public Sub New()
            _TS_ID = 0
            _TS_DESCRIPCION = String.Empty
        End Sub

        Public Property TS_ID() As Integer
            Get
                Return _TS_ID
            End Get
            Set(ByVal value As Integer)
                _TS_ID = value
            End Set
        End Property

        Public Property TS_DESCRIPCION() As String
            Get
                Return _TS_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TS_DESCRIPCION = value
            End Set
        End Property
    End Class

    Public Class SG_PL_TB_FOLIO
        Private _FO_ANHO As Integer
        Private _FO_MES As Integer
        Private _FO_ID_PERSONA As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _FO_ID_CONCEPTO As BE.PlanillaBE.SG_PL_TB_CONCEPTOS
        Private _FO_VALOR As Double
        Private _FO_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _FO_USUARIO As String
        Private _FO_TERMINAL As String
        Private _FO_FECREG As String
        Private _HasRow As Boolean

        Public Sub New(ByVal FO_ANHO_ As Integer, ByVal FO_MES_ As Integer, ByVal FO_ID_PERSONA_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal FO_ID_CONCEPTO_ As BE.PlanillaBE.SG_PL_TB_CONCEPTOS, ByVal FO_VALOR_ As Double, ByVal FO_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal FO_USUARIO_ As String, ByVal FO_TERMINAL_ As String, ByVal FO_FECREG_ As String)
            _FO_ANHO = FO_ANHO_
            _FO_MES = FO_MES_
            _FO_ID_PERSONA = FO_ID_PERSONA_
            _FO_ID_CONCEPTO = FO_ID_CONCEPTO_
            _FO_VALOR = FO_VALOR_
            _FO_ID_EMPRESA = FO_ID_EMPRESA_
            _FO_USUARIO = FO_USUARIO_
            _FO_TERMINAL = FO_TERMINAL_
            _FO_FECREG = FO_FECREG_
        End Sub

        Public Sub New()
            _FO_ANHO = 0
            _FO_MES = 0
            _FO_ID_PERSONA = Nothing
            _FO_ID_CONCEPTO = Nothing
            _FO_VALOR = 0.0R
            _FO_ID_EMPRESA = Nothing
            _FO_USUARIO = String.Empty
            _FO_TERMINAL = String.Empty
            _FO_FECREG = String.Empty
            _HasRow = False
        End Sub

        Public Property HasRow() As Boolean
            Get
                Return _HasRow
            End Get
            Set(ByVal value As Boolean)
                _HasRow = value
            End Set
        End Property

        Public Property FO_ANHO() As Integer
            Get
                Return _FO_ANHO
            End Get
            Set(ByVal value As Integer)
                _FO_ANHO = value
            End Set
        End Property

        Public Property FO_MES() As Integer
            Get
                Return _FO_MES
            End Get
            Set(ByVal value As Integer)
                _FO_MES = value
            End Set
        End Property

        Public Property FO_ID_PERSONA() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _FO_ID_PERSONA
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _FO_ID_PERSONA = value
            End Set
        End Property

        Public Property FO_ID_CONCEPTO() As BE.PlanillaBE.SG_PL_TB_CONCEPTOS
            Get
                Return _FO_ID_CONCEPTO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
                _FO_ID_CONCEPTO = value
            End Set
        End Property

        Public Property FO_VALOR() As Double
            Get
                Return _FO_VALOR
            End Get
            Set(ByVal value As Double)
                _FO_VALOR = value
            End Set
        End Property

        Public Property FO_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _FO_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _FO_ID_EMPRESA = value
            End Set
        End Property

        Public Property FO_USUARIO() As String
            Get
                Return _FO_USUARIO
            End Get
            Set(ByVal value As String)
                _FO_USUARIO = value
            End Set
        End Property

        Public Property FO_TERMINAL() As String
            Get
                Return _FO_TERMINAL
            End Get
            Set(ByVal value As String)
                _FO_TERMINAL = value
            End Set
        End Property

        Public Property FO_FECREG() As String
            Get
                Return _FO_FECREG
            End Get
            Set(ByVal value As String)
                _FO_FECREG = value
            End Set
        End Property



    End Class

    Public Class SG_PL_TB_IDENTIFICADOR
        Private _ID_ID As Integer
        Private _ID_DESCRIPCION As String

        Public Sub New(ByVal ID_ID_ As Integer, ByVal ID_DESCRIPCION_ As String)
            _ID_ID = ID_ID_
            _ID_DESCRIPCION = ID_DESCRIPCION_
        End Sub

        Public Sub New()
            _ID_ID = 0
            _ID_DESCRIPCION = String.Empty
        End Sub

        Public Property ID_ID() As Integer
            Get
                Return _ID_ID
            End Get
            Set(ByVal value As Integer)
                _ID_ID = value
            End Set
        End Property

        Public Property ID_DESCRIPCION() As String
            Get
                Return _ID_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _ID_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_CONCEPTO_SUNAT
        Private _CS_ID As String
        Private _CS_DESCRIPCION As String
        Private _CS_TIPO As Integer

        Public Sub New(ByVal CS_ID_ As String, ByVal CS_DESCRIPCION_ As String, ByVal CS_TIPO_ As Integer)
            _CS_ID = CS_ID_
            _CS_DESCRIPCION = CS_DESCRIPCION_
            _CS_TIPO = CS_TIPO_
        End Sub

        Public Sub New()
            _CS_ID = String.Empty
            _CS_DESCRIPCION = String.Empty
            _CS_TIPO = 0
        End Sub

        Public Property CS_ID() As String
            Get
                Return _CS_ID
            End Get
            Set(ByVal value As String)
                _CS_ID = value
            End Set
        End Property

        Public Property CS_DESCRIPCION() As String
            Get
                Return _CS_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CS_DESCRIPCION = value
            End Set
        End Property

        Public Property CS_TIPO() As Integer
            Get
                Return _CS_TIPO
            End Get
            Set(ByVal value As Integer)
                _CS_TIPO = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_TIPO_CONCEPTO
        Private _TC_ID As Integer
        Private _TC_DESCRIPCION As String

        Public Sub New(ByVal TC_ID_ As Integer, ByVal TC_DESCRIPCION_ As String)
            _TC_ID = TC_ID_
            _TC_DESCRIPCION = TC_DESCRIPCION_
        End Sub

        Public Sub New()
            _TC_ID = 0
            _TC_DESCRIPCION = String.Empty
        End Sub

        Public Property TC_ID() As Integer
            Get
                Return _TC_ID
            End Get
            Set(ByVal value As Integer)
                _TC_ID = value
            End Set
        End Property

        Public Property TC_DESCRIPCION() As String
            Get
                Return _TC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TC_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_ALCANCE_CONCEPTO
        Private _AC_ID As Integer
        Private _AC_DESCRIPCION As String

        Public Sub New(ByVal AC_ID_ As Integer, ByVal AC_DESCRIPCION_ As String)
            _AC_ID = AC_ID_
            _AC_DESCRIPCION = AC_DESCRIPCION_
        End Sub

        Public Sub New()
            _AC_ID = 0
            _AC_DESCRIPCION = String.Empty
        End Sub


        Public Property AC_ID() As Integer
            Get
                Return _AC_ID
            End Get
            Set(ByVal value As Integer)
                _AC_ID = value
            End Set
        End Property

        Public Property AC_DESCRIPCION() As String
            Get
                Return _AC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _AC_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_CONCEPTOS
        Private _CO_ID As String
        Private _CO_DESCRIPCION As String
        Private _CO_ID_TIPO As BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO
        Private _CO_VALOR As Double
        Private _CO_ESTADO As Integer
        Private _CO_ID_ALCANCE As BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO
        Private _CO_ID_IDENTIFICADOR As BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR
        Private _CO_ID_CUENTA_D As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        Private _CO_ID_CUENTA_H As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        Private _CO_ID_SUNAT As BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT
        Private _CO_NO_AFECT_AFP As Integer
        Private _CO_NO_AFECTA_QUINTA As Integer
        Private _CO_NO_PROYECTA_QUINTA As Integer
        Private _CO_AFECTA_GRATI As Integer
        Private _CO_ID_INTERNO As Integer
        Private _CO_USUARIO As String
        Private _CO_TERMINAL As String
        Private _CO_FECREG As String
        Private _CO_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal CO_ID_ As String, ByVal CO_DESCRIPCION_ As String, ByVal CO_ID_TIPO_ As BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO, ByVal CO_VALOR_ As Double, ByVal CO_ESTADO_ As Integer, ByVal CO_ID_ALCANCE_ As BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO, ByVal CO_ID_IDENTIFICADOR_ As BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR, ByVal CO_ID_CUENTA_D_ As BE.ContabilidadBE.SG_CO_TB_PLANCTAS, ByVal CO_ID_CUENTA_H_ As BE.ContabilidadBE.SG_CO_TB_PLANCTAS, ByVal CO_ID_SUNAT_ As BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT, ByVal CO_NO_AFECT_AFP_ As Integer, ByVal CO_NO_AFECTA_QUINTA_ As Integer, ByVal CO_NO_PROYECTA_QUINTA_ As Integer, ByVal CO_AFECTA_GRATI_ As Integer, ByVal CO_ID_INTERNO_ As Integer, ByVal CO_USUARIO_ As String, ByVal CO_TERMINAL_ As String, ByVal CO_FECREG_ As String, ByVal CO_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _CO_ID = CO_ID_
            _CO_DESCRIPCION = CO_DESCRIPCION_
            _CO_ID_TIPO = CO_ID_TIPO_
            _CO_VALOR = CO_VALOR_
            _CO_ESTADO = CO_ESTADO_
            _CO_ID_ALCANCE = CO_ID_ALCANCE_
            _CO_ID_IDENTIFICADOR = CO_ID_IDENTIFICADOR_
            _CO_ID_CUENTA_D = CO_ID_CUENTA_D_
            _CO_ID_CUENTA_H = CO_ID_CUENTA_H_
            _CO_ID_SUNAT = CO_ID_SUNAT_
            _CO_NO_AFECT_AFP = CO_NO_AFECT_AFP_
            _CO_NO_AFECTA_QUINTA = CO_NO_AFECTA_QUINTA_
            _CO_NO_PROYECTA_QUINTA = CO_NO_PROYECTA_QUINTA_
            _CO_AFECTA_GRATI = CO_AFECTA_GRATI_
            _CO_ID_INTERNO = CO_ID_INTERNO_
            _CO_USUARIO = CO_USUARIO_
            _CO_TERMINAL = CO_TERMINAL_
            _CO_FECREG = CO_FECREG_
            _CO_ID_EMPRESA = CO_ID_EMPRESA_
        End Sub

        Public Sub New()
            _CO_ID = 0
            _CO_DESCRIPCION = String.Empty
            _CO_ID_TIPO = Nothing
            _CO_VALOR = 0.0R
            _CO_ESTADO = 0
            _CO_ID_ALCANCE = Nothing
            _CO_ID_IDENTIFICADOR = Nothing
            _CO_ID_CUENTA_D = Nothing
            _CO_ID_CUENTA_H = Nothing
            _CO_ID_SUNAT = Nothing
            _CO_NO_AFECT_AFP = 0
            _CO_NO_AFECTA_QUINTA = 0
            _CO_NO_PROYECTA_QUINTA = 0
            _CO_AFECTA_GRATI = 0
            _CO_ID_INTERNO = 0
            _CO_USUARIO = String.Empty
            _CO_TERMINAL = String.Empty
            _CO_FECREG = String.Empty
            _CO_ID_EMPRESA = Nothing
        End Sub

        Public Property CO_ID() As Integer
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As Integer)
                _CO_ID = value
            End Set
        End Property

        Public Property CO_DESCRIPCION() As String
            Get
                Return _CO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CO_DESCRIPCION = value
            End Set
        End Property

        Public Property CO_ID_TIPO() As BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO
            Get
                Return _CO_ID_TIPO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_TIPO_CONCEPTO)
                _CO_ID_TIPO = value
            End Set
        End Property

        Public Property CO_VALOR() As Double
            Get
                Return _CO_VALOR
            End Get
            Set(ByVal value As Double)
                _CO_VALOR = value
            End Set
        End Property

        Public Property CO_ESTADO() As Integer
            Get
                Return _CO_ESTADO
            End Get
            Set(ByVal value As Integer)
                _CO_ESTADO = value
            End Set
        End Property

        Public Property CO_ID_ALCANCE() As BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO
            Get
                Return _CO_ID_ALCANCE
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_ALCANCE_CONCEPTO)
                _CO_ID_ALCANCE = value
            End Set
        End Property

        Public Property CO_ID_IDENTIFICADOR() As BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR
            Get
                Return _CO_ID_IDENTIFICADOR
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_IDENTIFICADOR)
                _CO_ID_IDENTIFICADOR = value
            End Set
        End Property

        Public Property CO_ID_CUENTA_D() As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            Get
                Return _CO_ID_CUENTA_D
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
                _CO_ID_CUENTA_D = value
            End Set
        End Property

        Public Property CO_ID_CUENTA_H() As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            Get
                Return _CO_ID_CUENTA_H
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
                _CO_ID_CUENTA_H = value
            End Set
        End Property

        Public Property CO_ID_SUNAT() As BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT
            Get
                Return _CO_ID_SUNAT
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_CONCEPTO_SUNAT)
                _CO_ID_SUNAT = value
            End Set
        End Property

        Public Property CO_NO_AFECT_AFP() As Integer
            Get
                Return _CO_NO_AFECT_AFP
            End Get
            Set(ByVal value As Integer)
                _CO_NO_AFECT_AFP = value
            End Set
        End Property

        Public Property CO_NO_AFECTA_QUINTA() As Integer
            Get
                Return _CO_NO_AFECTA_QUINTA
            End Get
            Set(ByVal value As Integer)
                _CO_NO_AFECTA_QUINTA = value
            End Set
        End Property

        Public Property CO_NO_PROYECTA_QUINTA() As Integer
            Get
                Return _CO_NO_PROYECTA_QUINTA
            End Get
            Set(ByVal value As Integer)
                _CO_NO_PROYECTA_QUINTA = value
            End Set
        End Property

        Public Property CO_AFECTA_GRATI() As Integer
            Get
                Return _CO_AFECTA_GRATI
            End Get
            Set(ByVal value As Integer)
                _CO_AFECTA_GRATI = value
            End Set
        End Property

        Public Property CO_ID_INTERNO() As Integer
            Get
                Return _CO_ID_INTERNO
            End Get
            Set(ByVal value As Integer)
                _CO_ID_INTERNO = value
            End Set
        End Property

        Public Property CO_USUARIO() As String
            Get
                Return _CO_USUARIO
            End Get
            Set(ByVal value As String)
                _CO_USUARIO = value
            End Set
        End Property

        Public Property CO_TERMINAL() As String
            Get
                Return _CO_TERMINAL
            End Get
            Set(ByVal value As String)
                _CO_TERMINAL = value
            End Set
        End Property

        Public Property CO_FECREG() As String
            Get
                Return _CO_FECREG
            End Get
            Set(ByVal value As String)
                _CO_FECREG = value
            End Set
        End Property

        Public Property CO_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _CO_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _CO_ID_EMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TARIFA
        Private _TA_ID_TIPO_PER As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA
        Private _TA_ID_TIPO_TARIFA As BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA
        Private _TA_VALOR As Double
        Private _TA_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal TA_ID_TIPO_PER_ As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA, ByVal TA_ID_TIPO_TARIFA_ As BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA, ByVal TA_VALOR_ As Double, ByVal TA_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _TA_ID_TIPO_PER = TA_ID_TIPO_PER_
            _TA_ID_TIPO_TARIFA = TA_ID_TIPO_TARIFA_
            _TA_VALOR = TA_VALOR_
            _TA_ID_EMPRESA = TA_ID_EMPRESA_
        End Sub

        Public Sub New()
            _TA_VALOR = 0.0R
            _TA_ID_TIPO_PER = Nothing
            _TA_ID_TIPO_TARIFA = Nothing
            _TA_ID_EMPRESA = Nothing
        End Sub

        Public Property TA_ID_TIPO_PER() As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA
            Get
                Return _TA_ID_TIPO_PER
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA)
                _TA_ID_TIPO_PER = value
            End Set
        End Property

        Public Property TA_ID_TIPO_TARIFA() As BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA
            Get
                Return _TA_ID_TIPO_TARIFA
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_TIPO_TARIFA)
                _TA_ID_TIPO_TARIFA = value
            End Set
        End Property

        Public Property TA_VALOR() As Double
            Get
                Return _TA_VALOR
            End Get
            Set(ByVal value As Double)
                _TA_VALOR = value
            End Set
        End Property

        Public Property TA_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _TA_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _TA_ID_EMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_TARIFA
        Private _TI_ID As Integer
        Private _TI_DESCRIPCION As String
        Private _TI_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _TI_IDCONCEPTO As BE.PlanillaBE.SG_PL_TB_CONCEPTOS


        Public Sub New(ByVal TI_ID_ As Integer, ByVal TI_DESCRIPCION_ As String, ByVal TI_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal TI_IDCONCEPTO_ As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
            _TI_ID = TI_ID_
            _TI_DESCRIPCION = TI_DESCRIPCION_
            _TI_ID_EMPRESA = TI_ID_EMPRESA_
            _TI_IDCONCEPTO = TI_IDCONCEPTO_
        End Sub

        Public Sub New()
            _TI_ID = 0
            _TI_DESCRIPCION = String.Empty
            _TI_ID_EMPRESA = Nothing
            _TI_IDCONCEPTO = Nothing
        End Sub

        Public Property TI_ID() As Integer
            Get
                Return _TI_ID
            End Get
            Set(ByVal value As Integer)
                _TI_ID = value
            End Set
        End Property

        Public Property TI_DESCRIPCION() As String
            Get
                Return _TI_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TI_DESCRIPCION = value
            End Set
        End Property

        Public Property TI_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _TI_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _TI_ID_EMPRESA = value
            End Set
        End Property

        Public Property TI_IDCONCEPTO() As BE.PlanillaBE.SG_PL_TB_CONCEPTOS
            Get
                Return _TI_IDCONCEPTO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_CONCEPTOS)
                _TI_IDCONCEPTO = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_PERSO_TARIFA
        Private _TT_ID As Integer
        Private _TT_DESCRIPCION As String
        Private _TT_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal TT_ID_ As Integer, ByVal TT_DESCRIPCION_ As String, ByVal TT_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _TT_ID = TT_ID_
            _TT_DESCRIPCION = TT_DESCRIPCION_
            _TT_ID_EMPRESA = TT_ID_EMPRESA_
        End Sub

        Public Sub New()
            _TT_ID = 0
            _TT_DESCRIPCION = String.Empty
            _TT_ID_EMPRESA = Nothing
        End Sub

        Public Property TT_ID() As Integer
            Get
                Return _TT_ID
            End Get
            Set(ByVal value As Integer)
                _TT_ID = value
            End Set
        End Property

        Public Property TT_DESCRIPCION() As String
            Get
                Return _TT_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TT_DESCRIPCION = value
            End Set
        End Property

        Public Property TT_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _TT_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _TT_ID_EMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_PERSONAL_CCOSTO
        Private _CC_CC As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
        Private _CC_ID_PERSONA As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _CC_PORCENTAJE As Double
        Private _CC_USUARIO As String
        Private _CC_TERMINAL As String
        Private _CC_FECREG As String

        Public Sub New(ByVal CC_CC_ As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO, ByVal CC_ID_PERSONA_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal CC_PORCENTAJE_ As Double, ByVal CC_USUARIO_ As String, ByVal CC_TERMINAL_ As String, ByVal CC_FECREG_ As String)
            _CC_CC = CC_CC_
            _CC_ID_PERSONA = CC_ID_PERSONA_
            _CC_PORCENTAJE = CC_PORCENTAJE_
            _CC_USUARIO = CC_USUARIO_
            _CC_TERMINAL = CC_TERMINAL_
            _CC_FECREG = CC_FECREG_
        End Sub

        Public Sub New()
            _CC_CC = Nothing
            _CC_ID_PERSONA = Nothing
            _CC_PORCENTAJE = 0
            _CC_USUARIO = String.Empty
            _CC_TERMINAL = String.Empty
            _CC_FECREG = String.Empty
        End Sub

        Public Property CC_CC() As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO
            Get
                Return _CC_CC
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_CENTROCOSTO)
                _CC_CC = value
            End Set
        End Property

        Public Property CC_ID_PERSONA() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _CC_ID_PERSONA
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _CC_ID_PERSONA = value
            End Set
        End Property

        Public Property CC_PORCENTAJE() As Double
            Get
                Return _CC_PORCENTAJE
            End Get
            Set(ByVal value As Double)
                _CC_PORCENTAJE = value
            End Set
        End Property

        Public Property CC_USUARIO() As String
            Get
                Return _CC_USUARIO
            End Get
            Set(ByVal value As String)
                _CC_USUARIO = value
            End Set
        End Property

        Public Property CC_TERMINAL() As String
            Get
                Return _CC_TERMINAL
            End Get
            Set(ByVal value As String)
                _CC_TERMINAL = value
            End Set
        End Property

        Public Property CC_FECREG() As String
            Get
                Return _CC_FECREG
            End Get
            Set(ByVal value As String)
                _CC_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_PERSONAL_CONTRATOS
        Private _CO_ID As Integer
        Private _CO_ID_PERSONAL As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _CO_ID_TIPO_CONTRATO As BE.PlanillaBE.SG_PL_TB_TIPO_CONTRATO
        Private _CO_FECHA_INI As String
        Private _CO_FECHA_FIN As String
        Private _CO_COMENTARIO As String
        Private _CO_USUARIO As String
        Private _CO_TERMINAL As String
        Private _CO_FECREG As String

        Public Sub New(ByVal CO_ID_ As Integer, ByVal CO_ID_PERSONAL_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal CO_ID_TIPO_CONTRATO_ As BE.PlanillaBE.SG_PL_TB_TIPO_CONTRATO, ByVal CO_FECHA_INI_ As String, ByVal CO_FECHA_FIN_ As String, ByVal CO_COMENTARIO_ As String, ByVal CO_USUARIO_ As String, ByVal CO_TERMINAL_ As String, ByVal CO_FECREG_ As String)
            _CO_COMENTARIO = CO_COMENTARIO_
            _CO_ID = CO_ID_
            _CO_ID_PERSONAL = CO_ID_PERSONAL_
            _CO_ID_TIPO_CONTRATO = CO_ID_TIPO_CONTRATO_
            _CO_FECHA_INI = CO_FECHA_INI_
            _CO_FECHA_FIN = CO_FECHA_FIN_
            _CO_USUARIO = CO_USUARIO_
            _CO_TERMINAL = CO_TERMINAL_
            _CO_FECREG = CO_FECREG_
        End Sub

        Public Sub New()
            _CO_ID = 0
            _CO_ID_PERSONAL = Nothing
            _CO_ID_TIPO_CONTRATO = Nothing
            _CO_FECHA_INI = String.Empty
            _CO_FECHA_FIN = String.Empty
            _CO_USUARIO = String.Empty
            _CO_TERMINAL = String.Empty
            _CO_FECREG = String.Empty
            _CO_COMENTARIO = String.Empty
        End Sub

        Public Property CO_COMENTARIO() As String
            Get
                Return _CO_COMENTARIO
            End Get
            Set(ByVal value As String)
                _CO_COMENTARIO = value
            End Set
        End Property

        Public Property CO_ID() As Integer
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As Integer)
                _CO_ID = value
            End Set
        End Property

        Public Property CO_ID_PERSONAL() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _CO_ID_PERSONAL
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _CO_ID_PERSONAL = value
            End Set
        End Property

        Public Property CO_ID_TIPO_CONTRATO() As BE.PlanillaBE.SG_PL_TB_TIPO_CONTRATO
            Get
                Return _CO_ID_TIPO_CONTRATO
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_TIPO_CONTRATO)
                _CO_ID_TIPO_CONTRATO = value
            End Set
        End Property

        Public Property CO_FECHA_INI() As String
            Get
                Return _CO_FECHA_INI
            End Get
            Set(ByVal value As String)
                _CO_FECHA_INI = value
            End Set
        End Property

        Public Property CO_FECHA_FIN() As String
            Get
                Return _CO_FECHA_FIN
            End Get
            Set(ByVal value As String)
                _CO_FECHA_FIN = value
            End Set
        End Property

        Public Property CO_USUARIO() As String
            Get
                Return _CO_USUARIO
            End Get
            Set(ByVal value As String)
                _CO_USUARIO = value
            End Set
        End Property

        Public Property CO_TERMINAL() As String
            Get
                Return _CO_TERMINAL
            End Get
            Set(ByVal value As String)
                _CO_TERMINAL = value
            End Set
        End Property

        Public Property CO_FECREG() As String
            Get
                Return _CO_FECREG
            End Get
            Set(ByVal value As String)
                _CO_FECREG = value
            End Set
        End Property
    End Class

    Public Class SG_PL_TB_TIPO_CONTRATO
        Private _TC_ID As String
        Private _TC_DESCRIPCION As String

        Public Sub New(ByVal TC_ID_ As String, ByVal TC_DESCRIPCION_ As String)
            _TC_ID = TC_ID_
            _TC_DESCRIPCION = TC_DESCRIPCION_
        End Sub

        Public Sub New()
            _TC_ID = String.Empty
            _TC_DESCRIPCION = String.Empty
        End Sub

        Public Property TC_ID() As String
            Get
                Return _TC_ID
            End Get
            Set(ByVal value As String)
                _TC_ID = value
            End Set
        End Property

        Public Property TC_DESCRIPCION() As String
            Get
                Return _TC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TC_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_PERSONAL_DOCUMENTOS
        Private _DO_ID As Integer
        Private _DO_ID_PERSONAL As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _DO_NOMBRE_ARCHIVO As String
        Private _DO_DESCRIPCION As String
        Private _DO_FILE As Byte()
        Private _DO_USUARIO As String
        Private _DO_TERMINAL As String
        Private _DO_FECREG As String

        Public Sub New(ByVal DO_ID_ As Integer, ByVal DO_ID_PERSONAL_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal DO_NOMBRE_ARCHIVO_ As String, ByVal DO_DESCRIPCION_ As String, ByVal DO_FILE_ As Byte(), ByVal DO_USUARIO_ As String, ByVal DO_TERMINAL_ As String, ByVal DO_FECREG_ As String)
            _DO_ID = DO_ID_
            _DO_ID_PERSONAL = DO_ID_PERSONAL_
            _DO_NOMBRE_ARCHIVO = DO_NOMBRE_ARCHIVO_
            _DO_DESCRIPCION = DO_DESCRIPCION_
            _DO_FILE = DO_FILE_
            _DO_USUARIO = DO_USUARIO_
            _DO_TERMINAL = DO_TERMINAL_
            _DO_FECREG = DO_FECREG_
        End Sub

        Public Sub New()
            _DO_ID = 0
            _DO_ID_PERSONAL = Nothing
            _DO_NOMBRE_ARCHIVO = String.Empty
            _DO_DESCRIPCION = String.Empty
            _DO_FILE = Nothing
            _DO_USUARIO = String.Empty
            _DO_TERMINAL = String.Empty
            _DO_FECREG = String.Empty
        End Sub

        Public Property DO_ID() As Integer
            Get
                Return _DO_ID
            End Get
            Set(ByVal value As Integer)
                _DO_ID = value
            End Set
        End Property

        Public Property DO_ID_PERSONAL() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _DO_ID_PERSONAL
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _DO_ID_PERSONAL = value
            End Set
        End Property

        Public Property DO_NOMBRE_ARCHIVO() As String
            Get
                Return _DO_NOMBRE_ARCHIVO
            End Get
            Set(ByVal value As String)
                _DO_NOMBRE_ARCHIVO = value
            End Set
        End Property

        Public Property DO_DESCRIPCION() As String
            Get
                Return _DO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DO_DESCRIPCION = value
            End Set
        End Property

        Public Property DO_FILE() As Byte()
            Get
                Return _DO_FILE
            End Get
            Set(ByVal value As Byte())
                _DO_FILE = value
            End Set
        End Property

        Public Property DO_USUARIO() As String
            Get
                Return _DO_USUARIO
            End Get
            Set(ByVal value As String)
                _DO_USUARIO = value
            End Set
        End Property

        Public Property DO_TERMINAL() As String
            Get
                Return _DO_TERMINAL
            End Get
            Set(ByVal value As String)
                _DO_TERMINAL = value
            End Set
        End Property

        Public Property DO_FECREG() As String
            Get
                Return _DO_FECREG
            End Get
            Set(ByVal value As String)
                _DO_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_PERSONA_COMUNICACION
        Private _PC_ID As Integer
        Private _PC_ID_PERSONA As BE.PlanillaBE.SG_PL_TB_PERSONAL
        Private _PC_ID_COMUNICACION As BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION
        Private _PC_NUMERO As String
        Private _PC_DESCRIPCION As String
        Private _PC_ISTATUS As Integer
        Private _PC_USUARIO As String
        Private _PC_TERMINAL As String
        Private _PC_FECREG As String

        Public Sub New(ByVal PC_ID_ As Integer, ByVal PC_ID_PERSONA_ As BE.PlanillaBE.SG_PL_TB_PERSONAL, ByVal PC_ID_COMUNICACION_ As BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION, ByVal PC_NUMERO_ As String, ByVal PC_DESCRIPCION_ As String, ByVal PC_ISTATUS_ As Integer, ByVal PC_USUARIO_ As String, ByVal PC_TERMINAL_ As String, ByVal PC_FECREG_ As String)
            _PC_ID = PC_ID_
            _PC_ID_PERSONA = PC_ID_PERSONA_
            _PC_ID_COMUNICACION = PC_ID_COMUNICACION_
            _PC_NUMERO = PC_NUMERO_
            _PC_DESCRIPCION = PC_DESCRIPCION_
            _PC_ISTATUS = PC_ISTATUS_
            _PC_USUARIO = PC_USUARIO_
            _PC_TERMINAL = PC_TERMINAL_
            _PC_FECREG = PC_FECREG_
        End Sub

        Public Sub New()
            _PC_ID = 0
            _PC_ID_PERSONA = Nothing
            _PC_ID_COMUNICACION = Nothing
            _PC_NUMERO = String.Empty
            _PC_DESCRIPCION = String.Empty
            _PC_ISTATUS = 0
            _PC_USUARIO = String.Empty
            _PC_TERMINAL = String.Empty
            _PC_FECREG = String.Empty
        End Sub

        Public Property PC_ID() As Integer
            Get
                Return _PC_ID
            End Get
            Set(ByVal value As Integer)
                _PC_ID = value
            End Set
        End Property

        Public Property PC_ID_PERSONA() As BE.PlanillaBE.SG_PL_TB_PERSONAL
            Get
                Return _PC_ID_PERSONA
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_PERSONAL)
                _PC_ID_PERSONA = value
            End Set
        End Property

        Public Property PC_ID_COMUNICACION() As BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION
            Get
                Return _PC_ID_COMUNICACION
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_TIPO_COMUNICACION)
                _PC_ID_COMUNICACION = value
            End Set
        End Property

        Public Property PC_NUMERO() As String
            Get
                Return _PC_NUMERO
            End Get
            Set(ByVal value As String)
                _PC_NUMERO = value
            End Set
        End Property

        Public Property PC_DESCRIPCION() As String
            Get
                Return _PC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _PC_DESCRIPCION = value
            End Set
        End Property

        Public Property PC_ISTATUS() As Integer
            Get
                Return _PC_ISTATUS
            End Get
            Set(ByVal value As Integer)
                _PC_ISTATUS = value
            End Set
        End Property

        Public Property PC_USUARIO() As String
            Get
                Return _PC_USUARIO
            End Get
            Set(ByVal value As String)
                _PC_USUARIO = value
            End Set
        End Property

        Public Property PC_TERMINAL() As String
            Get
                Return _PC_TERMINAL
            End Get
            Set(ByVal value As String)
                _PC_TERMINAL = value
            End Set
        End Property

        Public Property PC_FECREG() As String
            Get
                Return _PC_FECREG
            End Get
            Set(ByVal value As String)
                _PC_FECREG = value
            End Set
        End Property
    End Class

    Public Class SG_PL_TB_UBI_UBIGEO
        Private _UB_CODIGO As String
        Private _UB_DESCRIPCION As String

        Public Sub New(ByVal UB_CODIGO_ As String, ByVal UB_DESCRIPCION_ As String)
            _UB_CODIGO = UB_CODIGO_
            _UB_DESCRIPCION = UB_DESCRIPCION_
        End Sub

        Public Sub New()
            _UB_CODIGO = String.Empty
            _UB_DESCRIPCION = String.Empty
        End Sub

        Public Property UB_CODIGO() As String
            Get
                Return _UB_CODIGO
            End Get
            Set(ByVal value As String)
                _UB_CODIGO = value
            End Set
        End Property

        Public Property UB_DESCRIPCION() As String
            Get
                Return _UB_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _UB_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_UBI_PROVINCIA
        Private _PR_CODIGO As String
        Private _PR_DESCRIPCION As String

        Public Sub New(ByVal PR_CODIGO_ As String, ByVal PR_DESCRIPCION_ As String)
            _PR_CODIGO = PR_CODIGO_
            _PR_DESCRIPCION = PR_DESCRIPCION_
        End Sub

        Public Sub New()
            _PR_CODIGO = String.Empty
            _PR_DESCRIPCION = String.Empty
        End Sub

        Public Property PR_CODIGO() As String
            Get
                Return _PR_CODIGO
            End Get
            Set(ByVal value As String)
                _PR_CODIGO = value
            End Set
        End Property

        Public Property PR_DESCRIPCION() As String
            Get
                Return _PR_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _PR_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_UBI_DEPARTAMENTO
        Private _DE_CODIGO As String
        Private _DE_DESCRIPCION As String

        Public Sub New(ByVal DE_CODIGO_ As String, ByVal DE_DESCRIPCION_ As String)
            _DE_CODIGO = DE_CODIGO_
            _DE_DESCRIPCION = DE_DESCRIPCION_
        End Sub

        Public Sub New()
            _DE_CODIGO = String.Empty
            _DE_DESCRIPCION = String.Empty
        End Sub

        Public Property DE_CODIGO() As String
            Get
                Return _DE_CODIGO
            End Get
            Set(ByVal value As String)
                _DE_CODIGO = value
            End Set
        End Property

        Public Property DE_DESCRIPCION() As String
            Get
                Return _DE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DE_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_PENSIONES
        Private _PE_ID As Integer
        Private _PE_DESCRIPCION As String

        Public Sub New(ByVal PE_ID_ As Integer, ByVal PE_DESCRIPCION_ As String)
            _PE_ID = PE_ID_
            _PE_DESCRIPCION = PE_DESCRIPCION_
        End Sub
        Public Sub New()
            _PE_ID = 0
            _PE_DESCRIPCION = String.Empty
        End Sub

        Public Property PE_ID() As Integer
            Get
                Return _PE_ID
            End Get
            Set(ByVal value As Integer)
                _PE_ID = value
            End Set
        End Property

        Public Property PE_DESCRIPCION() As String
            Get
                Return _PE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _PE_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_AFP
        Private _AF_ID As Integer
        Private _AF_NOMBRE As String
        Private _AF_DIRECCION As String
        Private _AF_TELEFONO As String
        Private _AF_COMISION_FIJA As Double
        Private _AF_COMISION_VAR As Double
        Private _AF_SEGURO As Double
        Private _AF_TOPE_SEGURO As Double
        Private _AF_IDCUENTA_CONTA As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        Private _AF_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _AF_COD_SUNAT As SG_PL_TB_PENSIONES

        Public Sub New(ByVal AF_ID_ As Integer, ByVal AF_NOMBRE_ As String, ByVal AF_DIRECCION_ As String, ByVal AF_TELEFONO_ As String, ByVal AF_COMISION_FIJA_ As Double, ByVal AF_COMISION_VAR_ As Double, ByVal AF_SEGURO_ As Double, ByVal AF_TOPE_SEGURO_ As Double, ByVal AF_IDCUENTA_CONTA_ As BE.ContabilidadBE.SG_CO_TB_PLANCTAS, ByVal AF_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal AF_COD_SUNAT_ As SG_PL_TB_PENSIONES)
            _AF_ID = AF_ID_
            _AF_NOMBRE = AF_NOMBRE_
            _AF_DIRECCION = AF_DIRECCION_
            _AF_TELEFONO = AF_TELEFONO_
            _AF_COMISION_FIJA = AF_COMISION_FIJA_
            _AF_COMISION_VAR = AF_COMISION_VAR_
            _AF_SEGURO = AF_SEGURO_
            _AF_TOPE_SEGURO = AF_TOPE_SEGURO_
            _AF_IDCUENTA_CONTA = AF_IDCUENTA_CONTA_
            _AF_IDEMPRESA = AF_IDEMPRESA_
            _AF_COD_SUNAT = AF_COD_SUNAT_
        End Sub

        Public Sub New()
            _AF_ID = 0
            _AF_NOMBRE = String.Empty
            _AF_DIRECCION = String.Empty
            _AF_TELEFONO = String.Empty
            _AF_COMISION_FIJA = 0
            _AF_COMISION_VAR = 0
            _AF_SEGURO = 0
            _AF_TOPE_SEGURO = 0
            _AF_IDCUENTA_CONTA = Nothing
            _AF_IDEMPRESA = Nothing
            _AF_COD_SUNAT = Nothing
        End Sub


        Public Property AF_ID() As Integer
            Get
                Return _AF_ID
            End Get
            Set(ByVal value As Integer)
                _AF_ID = value
            End Set
        End Property

        Public Property AF_NOMBRE() As String
            Get
                Return _AF_NOMBRE
            End Get
            Set(ByVal value As String)
                _AF_NOMBRE = value
            End Set
        End Property

        Public Property AF_DIRECCION() As String
            Get
                Return _AF_DIRECCION
            End Get
            Set(ByVal value As String)
                _AF_DIRECCION = value
            End Set
        End Property

        Public Property AF_TELEFONO() As String
            Get
                Return _AF_TELEFONO
            End Get
            Set(ByVal value As String)
                _AF_TELEFONO = value
            End Set
        End Property

        Public Property AF_COMISION_FIJA() As Double
            Get
                Return _AF_COMISION_FIJA
            End Get
            Set(ByVal value As Double)
                _AF_COMISION_FIJA = value
            End Set
        End Property

        Public Property AF_COMISION_VAR() As Double
            Get
                Return _AF_COMISION_VAR
            End Get
            Set(ByVal value As Double)
                _AF_COMISION_VAR = value
            End Set
        End Property

        Public Property AF_SEGURO() As Double
            Get
                Return _AF_SEGURO
            End Get
            Set(ByVal value As Double)
                _AF_SEGURO = value
            End Set
        End Property

        Public Property AF_TOPE_SEGURO() As Double
            Get
                Return _AF_TOPE_SEGURO
            End Get
            Set(ByVal value As Double)
                _AF_TOPE_SEGURO = value
            End Set
        End Property

        Public Property AF_IDCUENTA_CONTA() As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            Get
                Return _AF_IDCUENTA_CONTA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
                _AF_IDCUENTA_CONTA = value
            End Set
        End Property

        Public Property AF_IDEMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _AF_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _AF_IDEMPRESA = value
            End Set
        End Property

        Public Property AF_COD_SUNAT() As SG_PL_TB_PENSIONES
            Get
                Return _AF_COD_SUNAT
            End Get
            Set(ByVal value As SG_PL_TB_PENSIONES)
                _AF_COD_SUNAT = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_AREA
        Private _AR_ID As Integer
        Private _AR_DESCRIPCION As String
        Private _AR_ID_EMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal AR_ID_ As Integer, ByVal AR_DESCRIPCION_ As String, ByVal AR_ID_EMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _AR_ID = AR_ID_
            _AR_DESCRIPCION = AR_DESCRIPCION_
            _AR_ID_EMPRESA = AR_ID_EMPRESA_
        End Sub

        Public Sub New()
            _AR_ID = 0
            _AR_DESCRIPCION = String.Empty
            _AR_ID_EMPRESA = Nothing
        End Sub

        Public Property AR_ID() As Integer
            Get
                Return _AR_ID
            End Get
            Set(ByVal value As Integer)
                _AR_ID = value
            End Set
        End Property

        Public Property AR_DESCRIPCION() As String
            Get
                Return _AR_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _AR_DESCRIPCION = value
            End Set
        End Property

        Public Property AR_ID_EMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _AR_ID_EMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _AR_ID_EMPRESA = value
            End Set
        End Property



    End Class

    Public Class SG_PL_TB_CARGO
        Private _EC_ID As Integer
        Private _EC_CARGO As String
        Private _EC_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal EC_ID_ As Integer, ByVal EC_CARGO_ As String, ByVal EC_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _EC_ID = EC_ID_
            _EC_CARGO = EC_CARGO_
            _EC_IDEMPRESA = EC_IDEMPRESA_
        End Sub

        Public Sub New()
            _EC_ID = 0
            _EC_CARGO = String.Empty
            _EC_IDEMPRESA = Nothing
        End Sub

        Public Property EC_ID() As Integer
            Get
                Return _EC_ID
            End Get
            Set(ByVal value As Integer)
                _EC_ID = value
            End Set
        End Property

        Public Property EC_CARGO() As String
            Get
                Return _EC_CARGO
            End Get
            Set(ByVal value As String)
                _EC_CARGO = value
            End Set
        End Property

        Public Property EC_IDEMPRESA() As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _EC_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _EC_IDEMPRESA = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_CLASIFICACION_PERSONAL
        Private _CP_ID As Integer
        Private _CP_DESCRIPCION As String

        Public Sub New(ByVal CP_ID_ As Integer, ByVal CP_DESCRIPCION_ As String)
            _CP_ID = CP_ID_
            _CP_DESCRIPCION = CP_DESCRIPCION_
        End Sub

        Public Sub New()
            _CP_ID = 0
            _CP_DESCRIPCION = String.Empty
        End Sub

        Public Property CP_ID() As Integer
            Get
                Return _CP_ID
            End Get
            Set(ByVal value As Integer)
                _CP_ID = value
            End Set
        End Property

        Public Property CP_DESCRIPCION() As String
            Get
                Return _CP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CP_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_DOCUMENTO_PERSONAL
        Private _DP_ID As Integer
        Private _DP_CODIGO As String
        Private _DP_DESCRIPCION As String

        Public Sub New(ByVal DP_ID_ As Integer, ByVal DP_CODIGO_ As String, ByVal DP_DESCRIPCION_ As String)
            _DP_ID = DP_ID_
            _DP_CODIGO = DP_CODIGO_
            _DP_DESCRIPCION = DP_DESCRIPCION_
        End Sub

        Public Sub New()
            _DP_ID = 0
            _DP_CODIGO = String.Empty
            _DP_DESCRIPCION = String.Empty
        End Sub

        Public Property DP_ID() As Integer
            Get
                Return _DP_ID
            End Get
            Set(ByVal value As Integer)
                _DP_ID = value
            End Set
        End Property

        Public Property DP_CODIGO() As String
            Get
                Return _DP_CODIGO
            End Get
            Set(ByVal value As String)
                _DP_CODIGO = value
            End Set
        End Property

        Public Property DP_DESCRIPCION() As String
            Get
                Return _DP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DP_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_EPS_SERVICIO_PROPIO
        Private _EP_ID As Integer
        Private _EP_RUC As String
        Private _EP_DESCRIPCION As String

        Public Sub New(ByVal EP_ID_ As Integer, ByVal EP_RUC_ As String, ByVal EP_DESCRIPCION_ As String)
            _EP_ID = EP_ID_
            _EP_RUC = EP_RUC_
            _EP_DESCRIPCION = EP_DESCRIPCION_
        End Sub

        Public Sub New()
            _EP_ID = 0
            _EP_RUC = String.Empty
            _EP_DESCRIPCION = String.Empty
        End Sub

        Public Property EP_ID() As Integer
            Get
                Return _EP_ID
            End Get
            Set(ByVal value As Integer)
                _EP_ID = value
            End Set
        End Property

        Public Property EP_RUC() As String
            Get
                Return _EP_RUC
            End Get
            Set(ByVal value As String)
                _EP_RUC = value
            End Set
        End Property

        Public Property EP_DESCRIPCION() As String
            Get
                Return _EP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _EP_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_ESTADO_TRABAJADOR
        Private _ET_ID As Integer
        Private _ET_DESCRIPCION As String

        Public Sub New(ByVal ET_ID_ As Integer, ByVal ET_DESCRIPCION_ As String)
            _ET_ID = ET_ID_
            _ET_DESCRIPCION = ET_DESCRIPCION_
        End Sub

        Public Sub New()
            _ET_ID = 0
            _ET_DESCRIPCION = String.Empty
        End Sub
        Public Property ET_ID() As Integer
            Get
                Return _ET_ID
            End Get
            Set(ByVal value As Integer)
                _ET_ID = value
            End Set
        End Property
        Public Property ET_DESCRIPCION() As String
            Get
                Return _ET_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _ET_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_ESTADO_VICIL
        Private _EC_ID As Integer
        Private _EC_DESCRIPCION As String

        Public Sub New(ByVal EC_ID_ As Integer, ByVal EC_DESCRIPCION_ As String)
            _EC_ID = EC_ID_
            _EC_DESCRIPCION = EC_DESCRIPCION_
        End Sub

        Public Sub New()
            _EC_ID = 0
            _EC_DESCRIPCION = String.Empty
        End Sub


        Public Property EC_ID() As Integer
            Get
                Return _EC_ID
            End Get
            Set(ByVal value As Integer)
                _EC_ID = value
            End Set
        End Property

        Public Property EC_DESCRIPCION() As String
            Get
                Return _EC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _EC_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_GRUPO_SANGUINEO
        Private _GS_ID As Integer
        Private _GS_TIPO As String
        Private _GS_DESCRIPCION As String

        Public Sub New(ByVal GS_ID_ As Integer, ByVal GS_TIPO_ As String, ByVal GS_DESCRIPCION_ As String)
            _GS_ID = GS_ID_
            _GS_TIPO = GS_TIPO_
            _GS_DESCRIPCION = GS_DESCRIPCION_
        End Sub

        Public Sub New()
            _GS_ID = 0
            _GS_TIPO = String.Empty
            _GS_DESCRIPCION = String.Empty
        End Sub

        Public Property GS_ID() As Integer
            Get
                Return _GS_ID
            End Get
            Set(ByVal value As Integer)
                _GS_ID = value
            End Set
        End Property

        Public Property GS_TIPO() As String
            Get
                Return _GS_TIPO
            End Get
            Set(ByVal value As String)
                _GS_TIPO = value
            End Set
        End Property

        Public Property GS_DESCRIPCION() As String
            Get
                Return _GS_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _GS_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_SP_S_NACIONALIDAD
        Private _NA_ID As String
        Private _NA_DESCRIPCION As String

        Public Sub New(ByVal NA_ID_ As String, ByVal NA_DESCRIPCION_ As String)
            _NA_ID = NA_ID_
            _NA_DESCRIPCION = NA_DESCRIPCION_
        End Sub
        Public Sub New()
            _NA_ID = String.Empty
            _NA_DESCRIPCION = String.Empty
        End Sub
        Public Property NA_ID() As String
            Get
                Return _NA_ID
            End Get
            Set(ByVal value As String)
                _NA_ID = value
            End Set
        End Property

        Public Property NA_DESCRIPCION() As String
            Get
                Return _NA_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _NA_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_NIVEL_EDUCATIVO
        Private _NE_ID As String
        Private _NE_DESCRIPCION As String

        Public Sub New(ByVal NE_ID_ As String, ByVal NE_DESCRIPCION_ As String)
            _NE_ID = NE_ID_
            _NE_DESCRIPCION = NE_DESCRIPCION_
        End Sub

        Public Sub New()
            _NE_ID = String.Empty
            _NE_DESCRIPCION = String.Empty
        End Sub

        Public Property NE_ID() As String
            Get
                Return _NE_ID
            End Get
            Set(ByVal value As String)
                _NE_ID = value
            End Set
        End Property

        Public Property NE_DESCRIPCION() As String
            Get
                Return _NE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _NE_DESCRIPCION = value
            End Set
        End Property



    End Class

    Public Class SG_PL_TB_OCUPACION
        Private _OC_ID As String
        Private _OC_DESCRIPCION As String

        Public Sub New(ByVal OC_ID_ As String, ByVal OC_DESCRIPCION_ As String)
            _OC_ID = OC_ID_
            _OC_DESCRIPCION = OC_DESCRIPCION_
        End Sub

        Public Sub New()
            _OC_ID = String.Empty
            _OC_DESCRIPCION = String.Empty
        End Sub

        Public Property OC_ID() As String
            Get
                Return _OC_ID
            End Get
            Set(ByVal value As String)
                _OC_ID = value
            End Set
        End Property


        Public Property OC_DESCRIPCION() As String
            Get
                Return _OC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _OC_DESCRIPCION = value
            End Set
        End Property



    End Class

    Public Class SG_PL_TB_PERIODO_REMUNERATIVO
        Private _PR_ID As Integer
        Private _PR_DESCRIPCION As String

        Public Sub New(ByVal PR_ID_ As Integer, ByVal PR_DESCRIPCION_ As String)
            _PR_ID = PR_ID_
            _PR_DESCRIPCION = PR_DESCRIPCION_
        End Sub

        Public Sub New()
            _PR_ID = 0
            _PR_DESCRIPCION = String.Empty
        End Sub

        Public Property PR_ID() As String
            Get
                Return _PR_ID
            End Get
            Set(ByVal value As String)
                _PR_ID = value
            End Set
        End Property

        Public Property PR_DESCRIPCION() As String
            Get
                Return _PR_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _PR_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_REGIMEN_LABORAL
        Private _RL_ID As Integer
        Private _RL_DESCRIPCION As String

        Public Sub New(ByVal RL_ID_ As Integer, ByVal RL_DESCRIPCION_ As String)
            _RL_ID = RL_ID_
            _RL_DESCRIPCION = RL_DESCRIPCION_
        End Sub

        Public Sub New()
            _RL_ID = 0
            _RL_DESCRIPCION = String.Empty
        End Sub

        Public Property RL_ID() As Integer
            Get
                Return _RL_ID
            End Get
            Set(ByVal value As Integer)
                _RL_ID = value
            End Set
        End Property

        Public Property RL_DESCRIPCION() As String
            Get
                Return _RL_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _RL_DESCRIPCION = value
            End Set
        End Property



    End Class

    Public Class SG_PL_TB_SCTR_PENSION
        Private _SP_ID As Integer
        Private _SP_DESCRIPCION As String

        Public Sub New(ByVal SP_ID_ As Integer, ByVal SP_DESCRIPCION_ As String)
            _SP_ID = SP_ID_
            _SP_DESCRIPCION = SP_DESCRIPCION_
        End Sub

        Public Sub New()
            _SP_ID = 0
            _SP_DESCRIPCION = String.Empty
        End Sub

        Public Property SP_ID() As Integer
            Get
                Return _SP_ID
            End Get
            Set(ByVal value As Integer)
                _SP_ID = value
            End Set
        End Property

        Public Property SP_DESCRIPCION() As String
            Get
                Return _SP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _SP_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_SCTR_SALUD
        Private _SS_ID As Integer
        Private _SS_DESCRIPCION As String

        Public Sub New(ByVal SS_ID_ As Integer, ByVal SS_DESCRIPCION_ As String)
            _SS_ID = SS_ID_
            _SS_DESCRIPCION = SS_DESCRIPCION_
        End Sub

        Public Sub New()
            _SS_ID = 0
            _SS_DESCRIPCION = String.Empty
        End Sub

        Public Property SS_ID() As Integer
            Get
                Return _SS_ID
            End Get
            Set(ByVal value As Integer)
                _SS_ID = value
            End Set
        End Property

        Public Property SS_DESCRIPCION() As String
            Get
                Return _SS_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _SS_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_SEXO
        Private _SE_ID As Integer
        Private _SE_DESCRIPCION As String

        Public Sub New(ByVal SE_ID_ As Integer, ByVal SE_DESCRIPCION_ As String)
            _SE_ID = SE_ID_
            _SE_DESCRIPCION = SE_DESCRIPCION_
        End Sub

        Public Sub New()
            _SE_ID = 0
            _SE_DESCRIPCION = String.Empty
        End Sub

        Public Property SE_ID() As Integer
            Get
                Return _SE_ID
            End Get
            Set(ByVal value As Integer)
                _SE_ID = value
            End Set
        End Property

        Public Property SE_DESCRIPCION() As String
            Get
                Return _SE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _SE_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_SITUACION_EPS
        Private _SE_ID As String
        Private _SE_DESCRIPCION As String
        Private _SE_TIPO As Integer

        Public Sub New(ByVal SE_ID_ As String, ByVal SE_DESCRIPCION_ As String, ByVal SE_TIPO_ As Integer)
            _SE_ID = SE_ID_
            _SE_DESCRIPCION = SE_DESCRIPCION_
            _SE_TIPO = SE_TIPO_
        End Sub

        Public Sub New()
            _SE_ID = String.Empty
            _SE_DESCRIPCION = String.Empty
            _SE_TIPO = 0
        End Sub

        Public Property SE_ID() As String
            Get
                Return _SE_ID
            End Get
            Set(ByVal value As String)
                _SE_ID = value
            End Set
        End Property

        Public Property SE_DESCRIPCION() As String
            Get
                Return _SE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _SE_DESCRIPCION = value
            End Set
        End Property

        Public Property SE_TIPO() As Integer
            Get
                Return _SE_TIPO
            End Get
            Set(ByVal value As Integer)
                _SE_TIPO = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_SITUACION_ESPECIAL
        Private _SE_ID As Integer
        Private _SE_DESCRIPCION As String

        Public Sub New(ByVal SE_ID_ As Integer, ByVal SE_DESCRIPCION_ As String)
            _SE_ID = SE_ID_
            _SE_DESCRIPCION = SE_DESCRIPCION_
        End Sub

        Public Sub New()
            _SE_ID = 0
            _SE_DESCRIPCION = String.Empty
        End Sub

        Public Property SE_ID() As Integer
            Get
                Return _SE_ID
            End Get
            Set(ByVal value As Integer)
                _SE_ID = value
            End Set
        End Property

        Public Property SE_DESCRIPCION() As String
            Get
                Return _SE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _SE_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_CESE
        Private _TC_ID As String
        Private _TC_DESCRIPCION As String

        Public Sub New(ByVal TC_ID_ As String, ByVal TC_DESCRIPCION_ As String)
            _TC_ID = TC_ID_
            _TC_DESCRIPCION = TC_DESCRIPCION_
        End Sub

        Public Sub New()
            _TC_ID = String.Empty
            _TC_DESCRIPCION = String.Empty
        End Sub

        Public Property TC_ID() As String
            Get
                Return _TC_ID
            End Get
            Set(ByVal value As String)
                _TC_ID = value
            End Set
        End Property

        Public Property TC_DESCRIPCION() As String
            Get
                Return _TC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TC_DESCRIPCION = value
            End Set
        End Property



    End Class

    Public Class SG_PL_TB_TIPO_CTA_BANCO
        Private _TC_ID As Integer
        Private _TC_DESCRIPCION As String

        Public Sub New(ByVal TC_ID_ As Integer, ByVal TC_DESCRIPCION_ As String)
            _TC_ID = TC_ID_
            _TC_DESCRIPCION = TC_DESCRIPCION_
        End Sub

        Public Sub New()
            _TC_ID = 0
            _TC_DESCRIPCION = String.Empty
        End Sub

        Public Property TC_ID() As Integer
            Get
                Return _TC_ID
            End Get
            Set(ByVal value As Integer)
                _TC_ID = value
            End Set
        End Property

        Public Property TC_DESCRIPCION() As String
            Get
                Return _TC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TC_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_PAGO
        Private _TP_ID As Integer
        Private _TP_DESCRIPCION As String

        Public Sub New(ByVal TP_ID_ As Integer, ByVal TP_DESCRIPCION_ As String)
            _TP_ID = TP_ID_
            _TP_DESCRIPCION = TP_DESCRIPCION_
        End Sub

        Public Sub New()
            _TP_ID = 0
            _TP_DESCRIPCION = String.Empty
        End Sub

        Public Property TP_ID() As Integer
            Get
                Return _TP_ID
            End Get
            Set(ByVal value As Integer)
                _TP_ID = value
            End Set
        End Property

        Public Property TP_DESCRIPCION() As String
            Get
                Return _TP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TP_DESCRIPCION = value
            End Set
        End Property
    End Class

    Public Class SG_PL_TB_TIPO_PERSONAL
        Private _TP_ID As Integer
        Private _TP_DESCRIPCION As String

        Public Sub New(ByVal TP_ID_ As Integer, ByVal TP_DESCRIPCION_ As String)
            _TP_ID = TP_ID_
            _TP_DESCRIPCION = TP_DESCRIPCION_
        End Sub

        Public Sub New()
            _TP_ID = 0
            _TP_DESCRIPCION = String.Empty
        End Sub

        Public Property TP_ID() As Integer
            Get
                Return _TP_ID
            End Get
            Set(ByVal value As Integer)
                _TP_ID = value
            End Set
        End Property

        Public Property TP_DESCRIPCION() As String
            Get
                Return _TP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TP_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_PERSONAL_CLI
        Private _TP_ID As Integer
        Private _TP_DESCRIPCION As String

        Public Sub New(ByVal TP_ID_ As Integer, ByVal TP_DESCRIPCION_ As String)
            _TP_ID = TP_ID_
            _TP_DESCRIPCION = TP_DESCRIPCION_
        End Sub

        Public Sub New()
            _TP_ID = 0
            _TP_DESCRIPCION = String.Empty
        End Sub

        Public Property TP_ID() As Integer
            Get
                Return _TP_ID
            End Get
            Set(ByVal value As Integer)
                _TP_ID = value
            End Set
        End Property

        Public Property TP_DESCRIPCION() As String
            Get
                Return _TP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TP_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_TIPO_REMUNERACION
        Private _TR_ID As Integer
        Private _TR_DESCRIPCION As String

        Public Sub New(ByVal TR_ID_ As Integer, ByVal TR_DESCRIPCION_ As String)
            _TR_ID = TR_ID_
            _TR_DESCRIPCION = TR_DESCRIPCION_
        End Sub

        Public Sub New()
            _TR_ID = 0
            _TR_DESCRIPCION = String.Empty
        End Sub

        Public Property TR_ID() As Integer
            Get
                Return _TR_ID
            End Get
            Set(ByVal value As Integer)
                _TR_ID = value
            End Set
        End Property

        Public Property TR_DESCRIPCION() As String
            Get
                Return _TR_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TR_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_TIPO_TRABAJADOR
        Private _TT_ID As String
        Private _TT_DESCRIPCION As String

        Public Sub New(ByVal TT_ID_ As String, ByVal TT_DESCRIPCION_ As String)
            _TT_ID = TT_ID_
            _TT_DESCRIPCION = TT_DESCRIPCION_
        End Sub

        Public Sub New()
            _TT_ID = String.Empty
            _TT_DESCRIPCION = String.Empty
        End Sub


        Public Property TT_ID() As String
            Get
                Return _TT_ID
            End Get
            Set(ByVal value As String)
                _TT_ID = value
            End Set
        End Property

        Public Property TT_DESCRIPCION() As String
            Get
                Return _TT_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TT_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_TIPO_VIA
        Private _TV_ID As String
        Private _TV_DESCRIPCION As String

        Public Sub New(ByVal TV_ID_ As String, ByVal TV_DESCRIPCION_ As String)
            _TV_ID = TV_ID_
            _TV_DESCRIPCION = TV_DESCRIPCION_
        End Sub

        Public Sub New()
            _TV_ID = String.Empty
            _TV_DESCRIPCION = String.Empty
        End Sub

        Public Property TV_ID() As String
            Get
                Return _TV_ID
            End Get
            Set(ByVal value As String)
                _TV_ID = value
            End Set
        End Property

        Public Property TV_DESCRIPCION() As String
            Get
                Return _TV_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TV_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_TIPO_ZONA
        Private _TZ_ID As String
        Private _TZ_DESCRIPCION As String

        Public Sub New(ByVal TZ_ID_ As String, ByVal TZ_DESCRIPCION_ As String)
            _TZ_ID = TZ_ID_
            _TZ_DESCRIPCION = TZ_DESCRIPCION_
        End Sub

        Public Sub New()
            _TZ_ID = String.Empty
            _TZ_DESCRIPCION = String.Empty
        End Sub

        Public Property TZ_ID() As String
            Get
                Return _TZ_ID
            End Get
            Set(ByVal value As String)
                _TZ_ID = value
            End Set
        End Property

        Public Property TZ_DESCRIPCION() As String
            Get
                Return _TZ_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TZ_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_PERSONAL
        Private _PE_ID As Integer
        Private _PE_CODIGO As String
        Private _PE_CODIGO_ALT As String
        Private _PE_ID_TIPO_PER As Integer
        Private _PE_APE_PAT As String
        Private _PE_APE_MAT As String
        Private _PE_NOM_PRI As String
        Private _PE_NOM_SEG As String
        Private _PE_ID_TIPO_DOC_PER As Integer
        Private _PE_NUM_DOC_PER As String
        Private _PE_FEC_NAC As String
        Private _PE_ID_EST_CIVIL As Integer
        Private _PE_ID_CARGO As Integer
        Private _PE_NUM_IPSS As String
        Private _PE_ID_AFP As Integer
        Private _PE_NUM_AFP As String
        Private _PE_ID_EST_TRABAJADOR As Integer
        Private _PE_IMPORTE_REMUNERACION As Double
        Private _PE_ID_MONEDA_REMU As Integer
        Private _PE_ID_TIPO_REMU As Integer
        Private _PE_ID_TIPO_CUENTA_REMU As Integer
        Private _PE_ID_MONEDA_CUENTA As Integer
        Private _PE_NUM_CUENTA As String
        Private _PE_ID_SEXO As Integer
        Private _PE_ID_NACIONALIDAD As String
        Private _PE_ID_ANEXO_CONTA As Integer
        Private _PE_ID_GRUPO_SANGUINEO As Integer
        Private _PE_HORAS_TRABAJO As Double
        Private _PE_DOMICILIADO As Integer
        Private _PE_ID_TIPO_VIA As String
        Private _PE_NOMBRE_VIA As String
        Private _PE_NUMERO_VIA As String
        Private _PE_INTERIOR As String
        Private _PE_ID_TIPO_ZONA As String
        Private _PE_NOMBRE_ZONA As String
        Private _PE_REFERENCIA As String
        Private _PE_UBIGEO As String
        Private _PE_ID_TIPO_TRABAJADOR As String
        Private _PE_ID_NIVEL_EDU As String
        Private _PE_ID_OCUPACION As String
        Private _PE_DISCAPACIDAD As Integer
        Private _PE_FEC_INSCRIP_REG_PEN As String
        Private _PE_ID_REGIMEN_LABORAL As Integer
        Private _PE_SUJETO_JOR_MAX As Integer
        Private _PE_SUJETO_REG_ALT As Integer
        Private _PE_FEC_ING As String
        Private _PE_FEC_CESE As String
        Private _PE_ID_TIPO_CESE As String
        Private _PE_ID_SCTR_SALUD As Integer
        Private _PE_ID_SCTR_PENSION As Integer
        Private _PE_SUJETO_HORA_NOC As Integer
        Private _PE_OTRO_ING_5TA As Integer
        Private _PE_ES_SINDICALIZADO As Integer
        Private _PE_ID_PERIODO_REMUNERA As Integer
        Private _PE_AFILIADO_EPS_SER_PRO As Integer
        Private _PE_ID_COD_EPS_SER_PRO As Integer
        Private _PE_ID_SITUACION_EPS As String
        Private _PE_ID_TIPO_PAGO As Integer
        Private _PE_ID_SITUACION_ESPECIAL As Integer
        Private _PE_ID_CLASIFI_PER As Integer
        Private _PE_ID_PERSONAL As Integer
        Private _PE_ID_AREA As Integer
        Private _PE_ASIGNACION_FAM As Integer
        Private _PE_NUM_HIJOS As Integer
        Private _PE_ID_BANCO_CTS As Integer
        Private _PE_ID_TIPO_CUENTA_CTS As Integer
        Private _PE_NUM_CUENTA_CTS As String
        Private _PE_ID_MONEDA_CTS As Integer
        Private _PE_AFECTO_QUINTA As Integer
        Private _PE_FOTO As Byte()
        Private _PE_ID_EMPRESA As Integer
        Private _PE_FICHA As String
        Private _PE_USUARIO As String
        Private _PE_TERMINAL As String
        Private _PE_FECREG As String
        Private _PE_ID_TIPO_PERSO_TARIFA As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA

        Public Sub New(ByVal PE_ID_ As Integer, ByVal PE_CODIGO_ As String, ByVal PE_CODIGO_ALT_ As String, ByVal PE_ID_TIPO_PER_ As Integer, ByVal PE_APE_PAT_ As String, ByVal PE_APE_MAT_ As String, ByVal PE_NOM_PRI_ As String, ByVal PE_NOM_SEG_ As String, ByVal PE_ID_TIPO_DOC_PER_ As Integer, ByVal PE_NUM_DOC_PER_ As String, ByVal PE_FEC_NAC_ As String, ByVal PE_ID_EST_CIVIL_ As Integer, ByVal PE_ID_CARGO_ As Integer, ByVal PE_NUM_IPSS_ As String, ByVal PE_ID_AFP_ As Integer, ByVal PE_NUM_AFP_ As String, ByVal PE_ID_EST_TRABAJADOR_ As Integer, ByVal PE_IMPORTE_REMUNERACION_ As Double, ByVal PE_ID_MONEDA_REMU_ As Integer, ByVal PE_ID_TIPO_REMU_ As Integer, ByVal PE_ID_TIPO_CUENTA_REMU_ As Integer, ByVal PE_ID_MONEDA_CUENTA_ As Integer, ByVal PE_NUM_CUENTA_ As String, ByVal PE_ID_SEXO_ As Integer, ByVal PE_ID_NACIONALIDAD_ As String, ByVal PE_ID_ANEXO_CONTA_ As Integer, ByVal PE_ID_GRUPO_SANGUINEO_ As Integer, ByVal PE_HORAS_TRABAJO_ As Double, ByVal PE_DOMICILIADO_ As Integer, ByVal PE_ID_TIPO_VIA_ As String, ByVal PE_NOMBRE_VIA_ As String, ByVal PE_NUMERO_VIA_ As String, ByVal PE_INTERIOR_ As String, ByVal PE_ID_TIPO_ZONA_ As String, ByVal PE_NOMBRE_ZONA_ As String, ByVal PE_REFERENCIA_ As String, ByVal PE_UBIGEO_ As String, ByVal PE_ID_TIPO_TRABAJADOR_ As String, ByVal PE_ID_NIVEL_EDU_ As String, ByVal PE_ID_OCUPACION_ As String, ByVal PE_DISCAPACIDAD_ As Integer, ByVal PE_FEC_INSCRIP_REG_PEN_ As String, ByVal PE_ID_REGIMEN_LABORAL_ As Integer, ByVal PE_SUJETO_JOR_MAX_ As Integer, ByVal PE_SUJETO_REG_ALT_ As Integer, ByVal PE_FEC_ING_ As String, ByVal PE_FEC_CESE_ As String, ByVal PE_ID_TIPO_CESE_ As String, ByVal PE_ID_SCTR_SALUD_ As Integer, ByVal PE_ID_SCTR_PENSION_ As Integer, ByVal PE_SUJETO_HORA_NOC_ As Integer, ByVal PE_OTRO_ING_5TA_ As Integer, ByVal PE_ES_SINDICALIZADO_ As Integer, ByVal PE_ID_PERIODO_REMUNERA_ As Integer, ByVal PE_AFILIADO_EPS_SER_PRO_ As Integer, ByVal PE_ID_COD_EPS_SER_PRO_ As Integer, ByVal PE_ID_SITUACION_EPS_ As String, ByVal PE_ID_TIPO_PAGO_ As Integer, ByVal PE_ID_SITUACION_ESPECIAL_ As Integer, ByVal PE_ID_CLASIFI_PER_ As Integer, ByVal PE_ID_PERSONAL_ As Integer, ByVal PE_ID_AREA_ As Integer, ByVal PE_ASIGNACION_FAM_ As Integer, ByVal PE_NUM_HIJOS_ As Integer, ByVal PE_ID_BANCO_CTS_ As Integer, ByVal PE_ID_TIPO_CUENTA_CTS_ As Integer, ByVal PE_NUM_CUENTA_CTS_ As String, ByVal PE_ID_MONEDA_CTS_ As Integer, ByVal PE_AFECTO_QUINTA_ As Integer, ByVal PE_FOTO_ As Byte(), ByVal PE_ID_EMPRESA_ As Integer, ByVal PE_FICHA_ As String, ByVal PE_USUARIO_ As String, ByVal PE_TERMINAL_ As String, ByVal PE_FECREG_ As String, ByVal PE_ID_TIPO_PERSO_TARIFA_ As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA)
            _PE_ID_TIPO_PERSO_TARIFA = PE_ID_TIPO_PERSO_TARIFA_
            _PE_FICHA = PE_FICHA_
            _PE_USUARIO = PE_USUARIO_
            _PE_TERMINAL = PE_TERMINAL_
            _PE_FECREG = PE_FECREG_
            _PE_ID = PE_ID_
            _PE_CODIGO = PE_CODIGO_
            _PE_CODIGO_ALT = PE_CODIGO_ALT_
            _PE_ID_TIPO_PER = PE_ID_TIPO_PER_
            _PE_APE_PAT = PE_APE_PAT_
            _PE_APE_MAT = PE_APE_MAT_
            _PE_NOM_PRI = PE_NOM_PRI_
            _PE_NOM_SEG = PE_NOM_SEG_
            _PE_ID_TIPO_DOC_PER = PE_ID_TIPO_DOC_PER_
            _PE_NUM_DOC_PER = PE_NUM_DOC_PER_
            _PE_FEC_NAC = PE_FEC_NAC_
            _PE_ID_EST_CIVIL = PE_ID_EST_CIVIL_
            _PE_ID_CARGO = PE_ID_CARGO_
            _PE_NUM_IPSS = PE_NUM_IPSS_
            _PE_ID_AFP = PE_ID_AFP_
            _PE_NUM_AFP = PE_NUM_AFP_
            _PE_ID_EST_TRABAJADOR = PE_ID_EST_TRABAJADOR_
            _PE_IMPORTE_REMUNERACION = PE_IMPORTE_REMUNERACION_
            _PE_ID_MONEDA_REMU = PE_ID_MONEDA_REMU_
            _PE_ID_TIPO_REMU = PE_ID_TIPO_REMU_
            _PE_ID_TIPO_CUENTA_REMU = PE_ID_TIPO_CUENTA_REMU_
            _PE_ID_MONEDA_CUENTA = PE_ID_MONEDA_CUENTA_
            _PE_NUM_CUENTA = PE_NUM_CUENTA_
            _PE_ID_SEXO = PE_ID_SEXO_
            _PE_ID_NACIONALIDAD = PE_ID_NACIONALIDAD_
            _PE_ID_ANEXO_CONTA = PE_ID_ANEXO_CONTA_
            _PE_ID_GRUPO_SANGUINEO = PE_ID_GRUPO_SANGUINEO_
            _PE_HORAS_TRABAJO = PE_HORAS_TRABAJO_
            _PE_DOMICILIADO = PE_DOMICILIADO_
            _PE_ID_TIPO_VIA = PE_ID_TIPO_VIA_
            _PE_NOMBRE_VIA = PE_NOMBRE_VIA_
            _PE_NUMERO_VIA = PE_NUMERO_VIA_
            _PE_INTERIOR = PE_INTERIOR_
            _PE_ID_TIPO_ZONA = PE_ID_TIPO_ZONA_
            _PE_NOMBRE_ZONA = PE_NOMBRE_ZONA_
            _PE_REFERENCIA = PE_REFERENCIA_
            _PE_UBIGEO = PE_UBIGEO_
            _PE_ID_TIPO_TRABAJADOR = PE_ID_TIPO_TRABAJADOR_
            _PE_ID_NIVEL_EDU = PE_ID_NIVEL_EDU_
            _PE_ID_OCUPACION = PE_ID_OCUPACION_
            _PE_DISCAPACIDAD = PE_DISCAPACIDAD_
            _PE_FEC_INSCRIP_REG_PEN = PE_FEC_INSCRIP_REG_PEN_
            _PE_ID_REGIMEN_LABORAL = PE_ID_REGIMEN_LABORAL_
            _PE_SUJETO_JOR_MAX = PE_SUJETO_JOR_MAX_
            _PE_SUJETO_REG_ALT = PE_SUJETO_REG_ALT_
            _PE_FEC_ING = PE_FEC_ING_
            _PE_FEC_CESE = PE_FEC_CESE_
            _PE_ID_TIPO_CESE = PE_ID_TIPO_CESE_
            _PE_ID_SCTR_SALUD = PE_ID_SCTR_SALUD_
            _PE_ID_SCTR_PENSION = PE_ID_SCTR_PENSION_
            _PE_SUJETO_HORA_NOC = PE_SUJETO_HORA_NOC_
            _PE_OTRO_ING_5TA = PE_OTRO_ING_5TA_
            _PE_ES_SINDICALIZADO = PE_ES_SINDICALIZADO_
            _PE_ID_PERIODO_REMUNERA = PE_ID_PERIODO_REMUNERA_
            _PE_AFILIADO_EPS_SER_PRO = PE_AFILIADO_EPS_SER_PRO_
            _PE_ID_COD_EPS_SER_PRO = PE_ID_COD_EPS_SER_PRO_
            _PE_ID_SITUACION_EPS = PE_ID_SITUACION_EPS_
            _PE_ID_TIPO_PAGO = PE_ID_TIPO_PAGO_
            _PE_ID_SITUACION_ESPECIAL = PE_ID_SITUACION_ESPECIAL_
            _PE_ID_CLASIFI_PER = PE_ID_CLASIFI_PER_
            _PE_ID_PERSONAL = PE_ID_PERSONAL_
            _PE_ID_AREA = PE_ID_AREA_
            _PE_ASIGNACION_FAM = PE_ASIGNACION_FAM_
            _PE_NUM_HIJOS = PE_NUM_HIJOS_
            _PE_ID_BANCO_CTS = PE_ID_BANCO_CTS_
            _PE_ID_TIPO_CUENTA_CTS = PE_ID_TIPO_CUENTA_CTS_
            _PE_NUM_CUENTA_CTS = PE_NUM_CUENTA_CTS_
            _PE_ID_MONEDA_CTS = PE_ID_MONEDA_CTS_
            _PE_AFECTO_QUINTA = PE_AFECTO_QUINTA_
            _PE_FOTO = PE_FOTO_
            _PE_ID_EMPRESA = PE_ID_EMPRESA_
        End Sub

        Public Sub New()
            _PE_ID_TIPO_PERSO_TARIFA = Nothing
            _PE_FICHA = String.Empty
            _PE_USUARIO = String.Empty
            _PE_TERMINAL = String.Empty
            _PE_FECREG = String.Empty
            _PE_ID = 0
            _PE_CODIGO = String.Empty
            _PE_CODIGO_ALT = String.Empty
            _PE_ID_TIPO_PER = 0
            _PE_APE_PAT = String.Empty
            _PE_APE_MAT = String.Empty
            _PE_NOM_PRI = String.Empty
            _PE_NOM_SEG = String.Empty
            _PE_ID_TIPO_DOC_PER = 0
            _PE_NUM_DOC_PER = String.Empty
            _PE_FEC_NAC = String.Empty
            _PE_ID_EST_CIVIL = 0
            _PE_ID_CARGO = 0
            _PE_NUM_IPSS = String.Empty
            _PE_ID_AFP = 0
            _PE_NUM_AFP = String.Empty
            _PE_ID_EST_TRABAJADOR = 0
            _PE_IMPORTE_REMUNERACION = 0
            _PE_ID_MONEDA_REMU = 0
            _PE_ID_TIPO_REMU = 0
            _PE_ID_TIPO_CUENTA_REMU = 0
            _PE_ID_MONEDA_CUENTA = 0
            _PE_NUM_CUENTA = String.Empty
            _PE_ID_SEXO = 0
            _PE_ID_NACIONALIDAD = String.Empty
            _PE_ID_ANEXO_CONTA = 0
            _PE_ID_GRUPO_SANGUINEO = 0
            _PE_HORAS_TRABAJO = 0
            _PE_DOMICILIADO = 0
            _PE_ID_TIPO_VIA = String.Empty
            _PE_NOMBRE_VIA = String.Empty
            _PE_NUMERO_VIA = String.Empty
            _PE_INTERIOR = String.Empty
            _PE_ID_TIPO_ZONA = String.Empty
            _PE_NOMBRE_ZONA = String.Empty
            _PE_REFERENCIA = String.Empty
            _PE_UBIGEO = String.Empty
            _PE_ID_TIPO_TRABAJADOR = String.Empty
            _PE_ID_NIVEL_EDU = String.Empty
            _PE_ID_OCUPACION = String.Empty
            _PE_DISCAPACIDAD = 0
            _PE_FEC_INSCRIP_REG_PEN = String.Empty
            _PE_ID_REGIMEN_LABORAL = 0
            _PE_SUJETO_JOR_MAX = 0
            _PE_SUJETO_REG_ALT = 0
            _PE_FEC_ING = String.Empty
            _PE_FEC_CESE = String.Empty
            _PE_ID_TIPO_CESE = String.Empty
            _PE_ID_SCTR_SALUD = 0
            _PE_ID_SCTR_PENSION = 0
            _PE_SUJETO_HORA_NOC = 0
            _PE_OTRO_ING_5TA = 0
            _PE_ES_SINDICALIZADO = 0
            _PE_ID_PERIODO_REMUNERA = 0
            _PE_AFILIADO_EPS_SER_PRO = 0
            _PE_ID_COD_EPS_SER_PRO = 0
            _PE_ID_SITUACION_EPS = String.Empty
            _PE_ID_TIPO_PAGO = 0
            _PE_ID_SITUACION_ESPECIAL = 0
            _PE_ID_CLASIFI_PER = 0
            _PE_ID_PERSONAL = 0
            _PE_ID_AREA = 0
            _PE_ASIGNACION_FAM = 0
            _PE_NUM_HIJOS = 0
            _PE_ID_BANCO_CTS = 0
            _PE_ID_TIPO_CUENTA_CTS = 0
            _PE_NUM_CUENTA_CTS = String.Empty
            _PE_ID_MONEDA_CTS = 0
            _PE_AFECTO_QUINTA = 0
            _PE_FOTO = Nothing
            _PE_ID_EMPRESA = 0

        End Sub

        Public Property PE_ID_TIPO_PERSO_TARIFA() As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA
            Get
                Return _PE_ID_TIPO_PERSO_TARIFA
            End Get
            Set(ByVal value As BE.PlanillaBE.SG_PL_TB_TIPO_PERSO_TARIFA)
                _PE_ID_TIPO_PERSO_TARIFA = value
            End Set
        End Property

        Public Property PE_FECREG() As String
            Get
                Return _PE_FECREG
            End Get
            Set(ByVal value As String)
                _PE_FECREG = value
            End Set
        End Property

        Public Property PE_TERMINAL() As String
            Get
                Return _PE_TERMINAL
            End Get
            Set(ByVal value As String)
                _PE_TERMINAL = value
            End Set
        End Property

        Public Property PE_USUARIO() As String
            Get
                Return _PE_USUARIO
            End Get
            Set(ByVal value As String)
                _PE_USUARIO = value
            End Set
        End Property

        Public Property PE_FICHA() As String
            Get
                Return _PE_FICHA
            End Get
            Set(ByVal value As String)
                _PE_FICHA = value
            End Set
        End Property

        Public Property PE_ID() As Integer
            Get
                Return _PE_ID
            End Get
            Set(ByVal value As Integer)
                _PE_ID = value
            End Set
        End Property

        Public Property PE_CODIGO() As String
            Get
                Return _PE_CODIGO
            End Get
            Set(ByVal value As String)
                _PE_CODIGO = value
            End Set
        End Property

        Public Property PE_CODIGO_ALT() As String
            Get
                Return _PE_CODIGO_ALT
            End Get
            Set(ByVal value As String)
                _PE_CODIGO_ALT = value
            End Set
        End Property

        Public Property PE_ID_TIPO_PER() As Integer
            Get
                Return _PE_ID_TIPO_PER
            End Get
            Set(ByVal value As Integer)
                _PE_ID_TIPO_PER = value
            End Set
        End Property

        Public Property PE_APE_PAT() As String
            Get
                Return _PE_APE_PAT
            End Get
            Set(ByVal value As String)
                _PE_APE_PAT = value
            End Set
        End Property

        Public Property PE_APE_MAT() As String
            Get
                Return _PE_APE_MAT
            End Get
            Set(ByVal value As String)
                _PE_APE_MAT = value
            End Set
        End Property

        Public Property PE_NOM_PRI() As String
            Get
                Return _PE_NOM_PRI
            End Get
            Set(ByVal value As String)
                _PE_NOM_PRI = value
            End Set
        End Property

        Public Property PE_NOM_SEG() As String
            Get
                Return _PE_NOM_SEG
            End Get
            Set(ByVal value As String)
                _PE_NOM_SEG = value
            End Set
        End Property

        Public Property PE_ID_TIPO_DOC_PER() As Integer
            Get
                Return _PE_ID_TIPO_DOC_PER
            End Get
            Set(ByVal value As Integer)
                _PE_ID_TIPO_DOC_PER = value
            End Set
        End Property

        Public Property PE_NUM_DOC_PER() As String
            Get
                Return _PE_NUM_DOC_PER
            End Get
            Set(ByVal value As String)
                _PE_NUM_DOC_PER = value
            End Set
        End Property

        Public Property PE_FEC_NAC() As String
            Get
                Return _PE_FEC_NAC
            End Get
            Set(ByVal value As String)
                _PE_FEC_NAC = value
            End Set
        End Property

        Public Property PE_ID_EST_CIVIL() As Integer
            Get
                Return _PE_ID_EST_CIVIL
            End Get
            Set(ByVal value As Integer)
                _PE_ID_EST_CIVIL = value
            End Set
        End Property

        Public Property PE_ID_CARGO() As Integer
            Get
                Return _PE_ID_CARGO
            End Get
            Set(ByVal value As Integer)
                _PE_ID_CARGO = value
            End Set
        End Property

        Public Property PE_NUM_IPSS() As String
            Get
                Return _PE_NUM_IPSS
            End Get
            Set(ByVal value As String)
                _PE_NUM_IPSS = value
            End Set
        End Property

        Public Property PE_ID_AFP() As Integer
            Get
                Return _PE_ID_AFP
            End Get
            Set(ByVal value As Integer)
                _PE_ID_AFP = value
            End Set
        End Property

        Public Property PE_NUM_AFP() As String
            Get
                Return _PE_NUM_AFP
            End Get
            Set(ByVal value As String)
                _PE_NUM_AFP = value
            End Set
        End Property

        Public Property PE_ID_EST_TRABAJADOR() As Integer
            Get
                Return _PE_ID_EST_TRABAJADOR
            End Get
            Set(ByVal value As Integer)
                _PE_ID_EST_TRABAJADOR = value
            End Set
        End Property

        Public Property PE_IMPORTE_REMUNERACION() As Double
            Get
                Return _PE_IMPORTE_REMUNERACION
            End Get
            Set(ByVal value As Double)
                _PE_IMPORTE_REMUNERACION = value
            End Set
        End Property

        Public Property PE_ID_MONEDA_REMU() As Integer
            Get
                Return _PE_ID_MONEDA_REMU
            End Get
            Set(ByVal value As Integer)
                _PE_ID_MONEDA_REMU = value
            End Set
        End Property

        Public Property PE_ID_TIPO_REMU() As Integer
            Get
                Return _PE_ID_TIPO_REMU
            End Get
            Set(ByVal value As Integer)
                _PE_ID_TIPO_REMU = value
            End Set
        End Property

        Public Property PE_ID_TIPO_CUENTA_REMU() As Integer
            Get
                Return _PE_ID_TIPO_CUENTA_REMU
            End Get
            Set(ByVal value As Integer)
                _PE_ID_TIPO_CUENTA_REMU = value
            End Set
        End Property

        Public Property PE_ID_MONEDA_CUENTA() As Integer
            Get
                Return _PE_ID_MONEDA_CUENTA
            End Get
            Set(ByVal value As Integer)
                _PE_ID_MONEDA_CUENTA = value
            End Set
        End Property

        Public Property PE_NUM_CUENTA() As String
            Get
                Return _PE_NUM_CUENTA
            End Get
            Set(ByVal value As String)
                _PE_NUM_CUENTA = value
            End Set
        End Property

        Public Property PE_ID_SEXO() As Integer
            Get
                Return _PE_ID_SEXO
            End Get
            Set(ByVal value As Integer)
                _PE_ID_SEXO = value
            End Set
        End Property

        Public Property PE_ID_NACIONALIDAD() As String
            Get
                Return _PE_ID_NACIONALIDAD
            End Get
            Set(ByVal value As String)
                _PE_ID_NACIONALIDAD = value
            End Set
        End Property

        Public Property PE_ID_ANEXO_CONTA() As Integer
            Get
                Return _PE_ID_ANEXO_CONTA
            End Get
            Set(ByVal value As Integer)
                _PE_ID_ANEXO_CONTA = value
            End Set
        End Property

        Public Property PE_ID_GRUPO_SANGUINEO() As Integer
            Get
                Return _PE_ID_GRUPO_SANGUINEO
            End Get
            Set(ByVal value As Integer)
                _PE_ID_GRUPO_SANGUINEO = value
            End Set
        End Property

        Public Property PE_HORAS_TRABAJO() As Double
            Get
                Return _PE_HORAS_TRABAJO
            End Get
            Set(ByVal value As Double)
                _PE_HORAS_TRABAJO = value
            End Set
        End Property

        Public Property PE_DOMICILIADO() As Integer
            Get
                Return _PE_DOMICILIADO
            End Get
            Set(ByVal value As Integer)
                _PE_DOMICILIADO = value
            End Set
        End Property

        Public Property PE_ID_TIPO_VIA() As String
            Get
                Return _PE_ID_TIPO_VIA
            End Get
            Set(ByVal value As String)
                _PE_ID_TIPO_VIA = value
            End Set
        End Property

        Public Property PE_NOMBRE_VIA() As String
            Get
                Return _PE_NOMBRE_VIA
            End Get
            Set(ByVal value As String)
                _PE_NOMBRE_VIA = value
            End Set
        End Property

        Public Property PE_NUMERO_VIA() As String
            Get
                Return _PE_NUMERO_VIA
            End Get
            Set(ByVal value As String)
                _PE_NUMERO_VIA = value
            End Set
        End Property

        Public Property PE_INTERIOR() As String
            Get
                Return _PE_INTERIOR
            End Get
            Set(ByVal value As String)
                _PE_INTERIOR = value
            End Set
        End Property

        Public Property PE_ID_TIPO_ZONA() As String
            Get
                Return _PE_ID_TIPO_ZONA
            End Get
            Set(ByVal value As String)
                _PE_ID_TIPO_ZONA = value
            End Set
        End Property

        Public Property PE_NOMBRE_ZONA() As String
            Get
                Return _PE_NOMBRE_ZONA
            End Get
            Set(ByVal value As String)
                _PE_NOMBRE_ZONA = value
            End Set
        End Property

        Public Property PE_REFERENCIA() As String
            Get
                Return _PE_REFERENCIA
            End Get
            Set(ByVal value As String)
                _PE_REFERENCIA = value
            End Set
        End Property

        Public Property PE_UBIGEO() As String
            Get
                Return _PE_UBIGEO
            End Get
            Set(ByVal value As String)
                _PE_UBIGEO = value
            End Set
        End Property


        Public Property PE_ID_TIPO_TRABAJADOR() As String
            Get
                Return _PE_ID_TIPO_TRABAJADOR
            End Get
            Set(ByVal value As String)
                _PE_ID_TIPO_TRABAJADOR = value
            End Set
        End Property

        Public Property PE_ID_NIVEL_EDU() As String
            Get
                Return _PE_ID_NIVEL_EDU
            End Get
            Set(ByVal value As String)
                _PE_ID_NIVEL_EDU = value
            End Set
        End Property

        Public Property PE_ID_OCUPACION() As String
            Get
                Return _PE_ID_OCUPACION
            End Get
            Set(ByVal value As String)
                _PE_ID_OCUPACION = value
            End Set
        End Property

        Public Property PE_DISCAPACIDAD() As Integer
            Get
                Return _PE_DISCAPACIDAD
            End Get
            Set(ByVal value As Integer)
                _PE_DISCAPACIDAD = value
            End Set
        End Property


        Public Property PE_FEC_INSCRIP_REG_PEN() As String
            Get
                Return _PE_FEC_INSCRIP_REG_PEN
            End Get
            Set(ByVal value As String)
                _PE_FEC_INSCRIP_REG_PEN = value
            End Set
        End Property

        Public Property PE_ID_REGIMEN_LABORAL() As Integer
            Get
                Return _PE_ID_REGIMEN_LABORAL
            End Get
            Set(ByVal value As Integer)
                _PE_ID_REGIMEN_LABORAL = value
            End Set
        End Property

        Public Property PE_SUJETO_JOR_MAX() As Integer
            Get
                Return _PE_SUJETO_JOR_MAX
            End Get
            Set(ByVal value As Integer)
                _PE_SUJETO_JOR_MAX = value
            End Set
        End Property

        Public Property PE_SUJETO_REG_ALT() As Integer
            Get
                Return _PE_SUJETO_REG_ALT
            End Get
            Set(ByVal value As Integer)
                _PE_SUJETO_REG_ALT = value
            End Set
        End Property

        Public Property PE_FEC_ING() As String
            Get
                Return _PE_FEC_ING
            End Get
            Set(ByVal value As String)
                _PE_FEC_ING = value
            End Set
        End Property

        Public Property PE_FEC_CESE() As String
            Get
                Return _PE_FEC_CESE
            End Get
            Set(ByVal value As String)
                _PE_FEC_CESE = value
            End Set
        End Property

        Public Property PE_ID_TIPO_CESE() As String
            Get
                Return _PE_ID_TIPO_CESE
            End Get
            Set(ByVal value As String)
                _PE_ID_TIPO_CESE = value
            End Set
        End Property

        Public Property PE_ID_SCTR_SALUD() As Integer
            Get
                Return _PE_ID_SCTR_SALUD
            End Get
            Set(ByVal value As Integer)
                _PE_ID_SCTR_SALUD = value
            End Set
        End Property

        Public Property PE_ID_SCTR_PENSION() As Integer
            Get
                Return _PE_ID_SCTR_PENSION
            End Get
            Set(ByVal value As Integer)
                _PE_ID_SCTR_PENSION = value
            End Set
        End Property

        Public Property PE_SUJETO_HORA_NOC() As Integer
            Get
                Return _PE_SUJETO_HORA_NOC
            End Get
            Set(ByVal value As Integer)
                _PE_SUJETO_HORA_NOC = value
            End Set
        End Property

        Public Property PE_OTRO_ING_5TA() As Integer
            Get
                Return _PE_OTRO_ING_5TA
            End Get
            Set(ByVal value As Integer)
                _PE_OTRO_ING_5TA = value
            End Set
        End Property

        Public Property PE_ES_SINDICALIZADO() As Integer
            Get
                Return _PE_ES_SINDICALIZADO
            End Get
            Set(ByVal value As Integer)
                _PE_ES_SINDICALIZADO = value
            End Set
        End Property

        Public Property PE_ID_PERIODO_REMUNERA() As Integer
            Get
                Return _PE_ID_PERIODO_REMUNERA
            End Get
            Set(ByVal value As Integer)
                _PE_ID_PERIODO_REMUNERA = value
            End Set
        End Property

        Public Property PE_AFILIADO_EPS_SER_PRO() As Integer
            Get
                Return _PE_AFILIADO_EPS_SER_PRO
            End Get
            Set(ByVal value As Integer)
                _PE_AFILIADO_EPS_SER_PRO = value
            End Set
        End Property

        Public Property PE_ID_COD_EPS_SER_PRO() As Integer
            Get
                Return _PE_ID_COD_EPS_SER_PRO
            End Get
            Set(ByVal value As Integer)
                _PE_ID_COD_EPS_SER_PRO = value
            End Set
        End Property


        Public Property PE_ID_SITUACION_EPS() As String
            Get
                Return _PE_ID_SITUACION_EPS
            End Get
            Set(ByVal value As String)
                _PE_ID_SITUACION_EPS = value
            End Set
        End Property

        Public Property PE_ID_TIPO_PAGO() As Integer
            Get
                Return _PE_ID_TIPO_PAGO
            End Get
            Set(ByVal value As Integer)
                _PE_ID_TIPO_PAGO = value
            End Set
        End Property

        Public Property PE_ID_SITUACION_ESPECIAL() As Integer
            Get
                Return _PE_ID_SITUACION_ESPECIAL
            End Get
            Set(ByVal value As Integer)
                _PE_ID_SITUACION_ESPECIAL = value
            End Set
        End Property

        Public Property PE_ID_CLASIFI_PER() As Integer
            Get
                Return _PE_ID_CLASIFI_PER
            End Get
            Set(ByVal value As Integer)
                _PE_ID_CLASIFI_PER = value
            End Set
        End Property

        Public Property PE_ID_PERSONAL() As Integer
            Get
                Return _PE_ID_PERSONAL
            End Get
            Set(ByVal value As Integer)
                _PE_ID_PERSONAL = value
            End Set
        End Property

        Public Property PE_ID_AREA() As Integer
            Get
                Return _PE_ID_AREA
            End Get
            Set(ByVal value As Integer)
                _PE_ID_AREA = value
            End Set
        End Property

        Public Property PE_ASIGNACION_FAM() As Integer
            Get
                Return _PE_ASIGNACION_FAM
            End Get
            Set(ByVal value As Integer)
                _PE_ASIGNACION_FAM = value
            End Set
        End Property

        Public Property PE_NUM_HIJOS() As Integer
            Get
                Return _PE_NUM_HIJOS
            End Get
            Set(ByVal value As Integer)
                _PE_NUM_HIJOS = value
            End Set
        End Property

        Public Property PE_ID_BANCO_CTS() As Integer
            Get
                Return _PE_ID_BANCO_CTS
            End Get
            Set(ByVal value As Integer)
                _PE_ID_BANCO_CTS = value
            End Set
        End Property

        Public Property PE_ID_TIPO_CUENTA_CTS() As Integer
            Get
                Return _PE_ID_TIPO_CUENTA_CTS
            End Get
            Set(ByVal value As Integer)
                _PE_ID_TIPO_CUENTA_CTS = value
            End Set
        End Property

        Public Property PE_NUM_CUENTA_CTS() As String
            Get
                Return _PE_NUM_CUENTA_CTS
            End Get
            Set(ByVal value As String)
                _PE_NUM_CUENTA_CTS = value
            End Set
        End Property

        Public Property PE_ID_MONEDA_CTS() As Integer
            Get
                Return _PE_ID_MONEDA_CTS
            End Get
            Set(ByVal value As Integer)
                _PE_ID_MONEDA_CTS = value
            End Set
        End Property

        Public Property PE_AFECTO_QUINTA() As Integer
            Get
                Return _PE_AFECTO_QUINTA
            End Get
            Set(ByVal value As Integer)
                _PE_AFECTO_QUINTA = value
            End Set
        End Property

        Public Property PE_FOTO() As Byte()
            Get
                Return _PE_FOTO
            End Get
            Set(ByVal value As Byte())
                _PE_FOTO = value
            End Set
        End Property

        Public Property PE_ID_EMPRESA() As Integer
            Get
                Return _PE_ID_EMPRESA
            End Get
            Set(ByVal value As Integer)
                _PE_ID_EMPRESA = value
            End Set
        End Property




    End Class


End Class
