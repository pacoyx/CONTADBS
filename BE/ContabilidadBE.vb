Public Class ContabilidadBE

    Public Class SG_CO_TB_CTAS_CIERRE
        Private _CC_CUENTA_MARGEN_COMER As String
        Private _CC_CUENTA_VALOR_AGREGADO As String
        Private _CC_CUENTA_VALOR_EXCEDENTE As String
        Private _CC_CUENTA_RESUL_EXPLOTACION As String
        Private _CC_CUENTA_RESUL_ANTES_PARTI As String
        Private _CC_CUENTA_RESULTADO_EJER As String
        Private _CC_ANHO As Integer
        Private _CC_IDEMPRESA As Integer

        Public Sub New(ByVal CC_CUENTA_MARGEN_COMER_ As String, ByVal CC_CUENTA_VALOR_AGREGADO_ As String, ByVal CC_CUENTA_VALOR_EXCEDENTE_ As String, ByVal CC_CUENTA_RESUL_EXPLOTACION_ As String, ByVal CC_CUENTA_RESUL_ANTES_PARTI_ As String, ByVal CC_CUENTA_RESULTADO_EJER_ As String, ByVal CC_ANHO_ As Integer, ByVal CC_IDEMPRESA_ As Integer)
            _CC_CUENTA_MARGEN_COMER = CC_CUENTA_MARGEN_COMER_
            _CC_CUENTA_VALOR_AGREGADO = CC_CUENTA_VALOR_AGREGADO_
            _CC_CUENTA_VALOR_EXCEDENTE = CC_CUENTA_VALOR_EXCEDENTE_
            _CC_CUENTA_RESUL_EXPLOTACION = CC_CUENTA_RESUL_EXPLOTACION_
            _CC_CUENTA_RESUL_ANTES_PARTI = CC_CUENTA_RESUL_ANTES_PARTI_
            _CC_CUENTA_RESULTADO_EJER = CC_CUENTA_RESULTADO_EJER_
            _CC_ANHO = CC_ANHO_
            _CC_IDEMPRESA = CC_IDEMPRESA_
        End Sub

        Public Sub New()
            _CC_CUENTA_MARGEN_COMER = String.Empty
            _CC_CUENTA_VALOR_AGREGADO = String.Empty
            _CC_CUENTA_VALOR_EXCEDENTE = String.Empty
            _CC_CUENTA_RESUL_EXPLOTACION = String.Empty
            _CC_CUENTA_RESUL_ANTES_PARTI = String.Empty
            _CC_CUENTA_RESULTADO_EJER = String.Empty
            _CC_ANHO = 0
            _CC_IDEMPRESA = 0
        End Sub

        Public Property CC_CUENTA_MARGEN_COMER() As String
            Get
                Return _CC_CUENTA_MARGEN_COMER
            End Get
            Set(ByVal value As String)
                _CC_CUENTA_MARGEN_COMER = value
            End Set
        End Property

        Public Property CC_CUENTA_VALOR_AGREGADO() As String
            Get
                Return _CC_CUENTA_VALOR_AGREGADO
            End Get
            Set(ByVal value As String)
                _CC_CUENTA_VALOR_AGREGADO = value
            End Set
        End Property

        Public Property CC_CUENTA_VALOR_EXCEDENTE() As String
            Get
                Return _CC_CUENTA_VALOR_EXCEDENTE
            End Get
            Set(ByVal value As String)
                _CC_CUENTA_VALOR_EXCEDENTE = value
            End Set
        End Property

        Public Property CC_CUENTA_RESUL_EXPLOTACION() As String
            Get
                Return _CC_CUENTA_RESUL_EXPLOTACION
            End Get
            Set(ByVal value As String)
                _CC_CUENTA_RESUL_EXPLOTACION = value
            End Set
        End Property

        Public Property CC_CUENTA_RESUL_ANTES_PARTI() As String
            Get
                Return _CC_CUENTA_RESUL_ANTES_PARTI
            End Get
            Set(ByVal value As String)
                _CC_CUENTA_RESUL_ANTES_PARTI = value
            End Set
        End Property

        Public Property CC_CUENTA_RESULTADO_EJER() As String
            Get
                Return _CC_CUENTA_RESULTADO_EJER
            End Get
            Set(ByVal value As String)
                _CC_CUENTA_RESULTADO_EJER = value
            End Set
        End Property

        Public Property CC_ANHO() As Integer
            Get
                Return _CC_ANHO
            End Get
            Set(ByVal value As Integer)
                _CC_ANHO = value
            End Set
        End Property

        Public Property CC_IDEMPRESA() As Integer
            Get
                Return _CC_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _CC_IDEMPRESA = value
            End Set
        End Property

    End Class


    Public Class SG_CO_TB_REP_EGP
        Private _EGP_IDCONCEPTO_EGP As Int16
        Private _EGP_VALOR1 As Double
        Private _EGP_VALOR2 As Double
        Private _EGP_IDEMPRESA As Integer

        Public Sub New(ByVal EGP_IDCONCEPTO_EGP_ As Int16, ByVal EGP_VALOR1_ As Double, ByVal EGP_VALOR2_ As Double, ByVal EGP_IDEMPRESA_ As Int16)
            _EGP_IDCONCEPTO_EGP = EGP_IDCONCEPTO_EGP_
            _EGP_VALOR1 = EGP_VALOR1_
            _EGP_VALOR2 = EGP_VALOR2_
            _EGP_IDEMPRESA = EGP_IDEMPRESA_
        End Sub

        Public Sub New()
            _EGP_IDCONCEPTO_EGP = 0
            _EGP_VALOR1 = 0.0R
            _EGP_VALOR2 = 0.0R
            _EGP_IDEMPRESA = 0
        End Sub

        Public Property EGP_IDCONCEPTO_EGP() As Int16
            Get
                Return _EGP_IDCONCEPTO_EGP
            End Get
            Set(ByVal value As Int16)
                _EGP_IDCONCEPTO_EGP = value
            End Set
        End Property

        Public Property EGP_VALOR1() As Double
            Get
                Return _EGP_VALOR1
            End Get
            Set(ByVal value As Double)
                _EGP_VALOR1 = value
            End Set
        End Property

        Public Property EGP_VALOR2() As Double
            Get
                Return _EGP_VALOR2
            End Get
            Set(ByVal value As Double)
                _EGP_VALOR2 = value
            End Set
        End Property

        Public Property EGP_IDEMPRESA() As Int16
            Get
                Return _EGP_IDEMPRESA
            End Get
            Set(ByVal value As Int16)
                _EGP_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_CONCEPTO_EGP
        Private _CO_ID As Integer
        Private _CO_DESCRIPCION As String
        Private _CO_TITULO As Int16
        Private _CO_CTAS As Int16

        Public Sub New(ByVal CO_ID_ As Int16, ByVal CO_DESCRIPCION_ As String, ByVal CO_TITULO_ As Int16, ByVal CO_CTAS_ As Int16)
            _CO_ID = CO_ID_
            _CO_DESCRIPCION = CO_DESCRIPCION_
            _CO_TITULO = CO_TITULO_
            _CO_CTAS = CO_CTAS_
        End Sub

        Public Sub New()
            _CO_ID = 0
            _CO_DESCRIPCION = String.Empty
            _CO_TITULO = 0
            _CO_CTAS = 0
        End Sub

        Public Property CO_ID() As Int16
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As Int16)
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

        Public Property CO_TITULO() As Int16
            Get
                Return _CO_TITULO
            End Get
            Set(ByVal value As Int16)
                _CO_TITULO = value
            End Set
        End Property

        Public Property CO_CTAS() As Int16
            Get
                Return _CO_CTAS
            End Get
            Set(ByVal value As Int16)
                _CO_CTAS = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_CTA_CONCEPTO_EGP
        Private _CC_CUENTA As String
        Private _CC_CONCEPTO As Int16
        Private _CC_IDEMPRESA As Int16

        Public Sub New(ByVal CC_CUENTA_ As String, ByVal CC_CONCEPTO_ As Integer, ByVal CC_IDEMPRESA_ As Integer)
            _CC_CUENTA = CC_CUENTA_
            _CC_CONCEPTO = CC_CONCEPTO_
            _CC_IDEMPRESA = CC_IDEMPRESA_
        End Sub

        Public Sub New()
            _CC_CUENTA = String.Empty
            _CC_CONCEPTO = 0
            _CC_IDEMPRESA = 0
        End Sub

        Public Property CC_CUENTA() As String
            Get
                Return _CC_CUENTA
            End Get
            Set(ByVal value As String)
                _CC_CUENTA = value
            End Set
        End Property

        Public Property CC_CONCEPTO() As Integer
            Get
                Return _CC_CONCEPTO
            End Get
            Set(ByVal value As Integer)
                _CC_CONCEPTO = value
            End Set
        End Property

        Public Property CC_IDEMPRESA() As Integer
            Get
                Return _CC_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _CC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_CONF_CORREO_MENSAJE
        Private _CCM_CORREO_PARA As String
        Private _CCM_CORREO_DE As String
        Private _CCM_CORREO_DE_NOMBRE As String
        Private _CCM_ASUNTO As String
        Private _CCM_MENSAJE As String

        Public Sub New(ByVal CCM_CORREO_PARA_ As String, ByVal CCM_CORREO_DE_ As String, ByVal CCM_CORREO_DE_NOMBRE_ As String, ByVal CCM_ASUNTO_ As String, ByVal CCM_MENSAJE_ As String)
            _CCM_CORREO_PARA = CCM_CORREO_PARA_
            _CCM_CORREO_DE = CCM_CORREO_DE_
            _CCM_CORREO_DE_NOMBRE = CCM_CORREO_DE_NOMBRE_
            _CCM_ASUNTO = CCM_ASUNTO_
            _CCM_MENSAJE = CCM_MENSAJE_
        End Sub

        Public Sub New()
            _CCM_CORREO_PARA = String.Empty
            _CCM_CORREO_DE = String.Empty
            _CCM_CORREO_DE_NOMBRE = String.Empty
            _CCM_ASUNTO = String.Empty
            _CCM_MENSAJE = String.Empty
        End Sub

        Public Property CCM_CORREO_PARA() As String
            Get
                Return _CCM_CORREO_PARA
            End Get
            Set(ByVal value As String)
                _CCM_CORREO_PARA = value
            End Set
        End Property

        Public Property CCM_CORREO_DE() As String
            Get
                Return _CCM_CORREO_DE
            End Get
            Set(ByVal value As String)
                _CCM_CORREO_DE = value
            End Set
        End Property

        Public Property CCM_CORREO_DE_NOMBRE() As String
            Get
                Return _CCM_CORREO_DE_NOMBRE
            End Get
            Set(ByVal value As String)
                _CCM_CORREO_DE_NOMBRE = value
            End Set
        End Property

        Public Property CCM_ASUNTO() As String
            Get
                Return _CCM_ASUNTO
            End Get
            Set(ByVal value As String)
                _CCM_ASUNTO = value
            End Set
        End Property

        Public Property CCM_MENSAJE() As String
            Get
                Return _CCM_MENSAJE
            End Get
            Set(ByVal value As String)
                _CCM_MENSAJE = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_CONF_CORREO_HOST
        Private _CC_HOST As String
        Private _CC_USUARIO As String
        Private _CC_CLAVE As String

        Public Sub New(ByVal CC_HOST_ As String, ByVal CC_USUARIO_ As String, ByVal CC_CLAVE_ As String)
            _CC_HOST = CC_HOST_
            _CC_USUARIO = CC_USUARIO_
            _CC_CLAVE = CC_CLAVE_
        End Sub

        Public Sub New()
            CC_HOST = String.Empty
            CC_USUARIO = String.Empty
            CC_CLAVE = String.Empty
        End Sub

        Public Property CC_HOST() As String
            Get
                Return _CC_HOST
            End Get
            Set(ByVal value As String)
                _CC_HOST = value
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

        Public Property CC_CLAVE() As String
            Get
                Return _CC_CLAVE
            End Get
            Set(ByVal value As String)
                _CC_CLAVE = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_GRUPOBG_CUENTAS
        Private _GC_IDGRUPO As SG_CO_TB_GRUPOS_BG
        Private _GC_IDCUENTA As SG_CO_TB_PLANCTAS
        Private _GC_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal GC_IDGRUPO_ As SG_CO_TB_GRUPOS_BG, ByVal GC_IDCUENTA_ As SG_CO_TB_PLANCTAS, ByVal GC_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _GC_IDGRUPO = GC_IDGRUPO_
            _GC_IDCUENTA = GC_IDCUENTA_
            _GC_IDEMPRESA = GC_IDEMPRESA_
        End Sub

        Public Sub New()
            _GC_IDGRUPO = Nothing
            _GC_IDCUENTA = Nothing
            _GC_IDEMPRESA = Nothing
        End Sub

        Public Property GC_IDGRUPO() As SG_CO_TB_GRUPOS_BG
            Get
                Return _GC_IDGRUPO
            End Get
            Set(ByVal value As SG_CO_TB_GRUPOS_BG)
                _GC_IDGRUPO = value
            End Set
        End Property

        Public Property GC_IDCUENTA() As SG_CO_TB_PLANCTAS
            Get
                Return _GC_IDCUENTA
            End Get
            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _GC_IDCUENTA = value
            End Set
        End Property

        Public Property GC_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _GC_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _GC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_RUBRO_CUENTA
        Private _RC_IDRUBRO As SG_CO_TB_RUBRO
        Private _RC_IDCUENTA As SG_CO_TB_PLANCTAS

        Private Sub New(ByVal RC_IDRUBRO_ As SG_CO_TB_RUBRO, ByVal RC_IDCUENTA_ As SG_CO_TB_PLANCTAS)
            _RC_IDRUBRO = RC_IDRUBRO_
            _RC_IDCUENTA = RC_IDCUENTA_
        End Sub

        Public Sub New()
            _RC_IDRUBRO = Nothing
            _RC_IDCUENTA = Nothing
        End Sub

        Public Property RC_IDRUBRO() As SG_CO_TB_RUBRO
            Get
                Return _RC_IDRUBRO
            End Get
            Set(ByVal value As SG_CO_TB_RUBRO)
                _RC_IDRUBRO = value
            End Set
        End Property

        Public Property RC_IDCUENTA() As SG_CO_TB_PLANCTAS
            Get
                Return _RC_IDCUENTA
            End Get
            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _RC_IDCUENTA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_GRUPOBG_RUBRO
        Private _GR_IDGRUPO As SG_CO_TB_GRUPOS_BG
        Private _GR_IDRUBRO As SG_CO_TB_RUBRO

        Public Sub New(ByVal GR_IDGRUPO_ As SG_CO_TB_GRUPOS_BG, ByVal GR_IDRUBRO_ As SG_CO_TB_RUBRO)
            _GR_IDGRUPO = GR_IDGRUPO_
            _GR_IDRUBRO = GR_IDRUBRO_
        End Sub

        Public Sub New()
            _GR_IDGRUPO = Nothing
            _GR_IDRUBRO = Nothing
        End Sub

        Public Property GR_IDGRUPO() As SG_CO_TB_GRUPOS_BG
            Get
                Return _GR_IDGRUPO
            End Get
            Set(ByVal value As SG_CO_TB_GRUPOS_BG)
                _GR_IDGRUPO = value
            End Set
        End Property

        Public Property GR_IDRUBRO() As SG_CO_TB_RUBRO
            Get
                Return _GR_IDRUBRO
            End Get
            Set(ByVal value As SG_CO_TB_RUBRO)
                _GR_IDRUBRO = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_RUBRO
        Private _RU_ID As Integer
        Private _RU_CODIGO As String
        Private _RU_DESCRIPCION As String


        Public Sub New(ByVal RU_ID_ As Integer, ByVal RU_CODIGO_ As String, ByVal RU_DESCRIPCION_ As String)
            _RU_ID = RU_ID_
            _RU_DESCRIPCION = RU_DESCRIPCION_
            _RU_CODIGO = RU_CODIGO_
        End Sub

        Public Sub New()
            _RU_ID = 0
            _RU_DESCRIPCION = String.Empty
            _RU_CODIGO = String.Empty
        End Sub

        Public Property RU_ID() As Integer
            Get
                Return _RU_ID
            End Get
            Set(ByVal value As Integer)
                _RU_ID = value
            End Set
        End Property

        Public Property RU_DESCRIPCION() As String
            Get
                Return _RU_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _RU_DESCRIPCION = value
            End Set
        End Property

        Public Property RU_CODIGO() As String
            Get
                Return _RU_CODIGO
            End Get
            Set(ByVal value As String)
                _RU_CODIGO = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_GRUPOS_BG
        Private _GBG_IDCLASE As SG_CO_TB_CLASES_BG
        Private _GBG_ID As Integer
        Private _GBG_DESCRIPCION As String

        Public Sub New(ByVal GBG_IDCLASE_ As SG_CO_TB_CLASES_BG, ByVal GBG_ID_ As Integer, ByVal GBG_DESCRIPCION_ As String)
            _GBG_IDCLASE = GBG_IDCLASE_
            _GBG_ID = GBG_ID_
            _GBG_DESCRIPCION = GBG_DESCRIPCION_
        End Sub

        Public Sub New()
            _GBG_IDCLASE = Nothing
            _GBG_ID = 0
            _GBG_DESCRIPCION = String.Empty
        End Sub

        Public Property GBG_IDCLASE() As SG_CO_TB_CLASES_BG
            Get 
                Return _GBG_IDCLASE
            End Get
            Set(ByVal value As SG_CO_TB_CLASES_BG)
                _GBG_IDCLASE = value
            End Set
        End Property

        Public Property GBG_ID() As Integer
            Get
                Return _GBG_ID
            End Get
            Set(ByVal value As Integer)
                _GBG_ID = value
            End Set
        End Property

        Public Property GBG_DESCRIPCION() As String
            Get
                Return _GBG_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _GBG_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_CLASES_BG
        Private _CBG_ID As Integer
        Private _CBG_DESCRIPCION As String

        Public Sub New(ByVal CBG_ID_ As Integer, ByVal CBG_DESCRIPCION_ As String)
            _CBG_ID = CBG_ID_
            _CBG_DESCRIPCION = CBG_DESCRIPCION_
        End Sub

        Public Sub New()
            _CBG_ID = 0
            _CBG_DESCRIPCION = String.Empty
        End Sub

        Public Property CBG_ID() As Integer
            Get
                Return _CBG_ID
            End Get
            Set(ByVal value As Integer)
                _CBG_ID = value
            End Set
        End Property

        Public Property CBG_DESCRIPCION() As String
            Get
                Return _CBG_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CBG_DESCRIPCION = value
            End Set
        End Property


    End Class

    Public Class SG_CO_TB_TIPO_ASIENTO_ITF
        Private _TI_ID As Integer
        Private _TI_DESCRIPCION As String

        Public Sub New(ByVal TI_ID_ As Integer, ByVal TI_DESCRIPCION_ As String)
            _TI_ID = TI_ID_
            _TI_DESCRIPCION = TI_DESCRIPCION_
        End Sub
        Public Sub New()
            _TI_ID = 0
            _TI_DESCRIPCION = String.Empty
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

    End Class

    Public Class SG_CO_TB_PARAMETROSGENERALES
        Private _PG_CLAVE_CONTROL_MES As String
        Private _PG_CORREO_CTA_WEB As String
        Private _PG_MARCADOR_PRORATEO As Integer


        Public Sub New(ByVal PG_CLAVE_CONTROL_MES_ As String, ByVal PG_CORREO_CTA_WEB_ As String, ByVal PG_MARCADOR_PRORATEO_ As Integer)
            _PG_CLAVE_CONTROL_MES = PG_CLAVE_CONTROL_MES_
            _PG_CORREO_CTA_WEB = PG_CORREO_CTA_WEB_
            _PG_MARCADOR_PRORATEO = PG_MARCADOR_PRORATEO_
        End Sub

        Public Sub New()
            _PG_CLAVE_CONTROL_MES = String.Empty
            _PG_CORREO_CTA_WEB = String.Empty
            _PG_MARCADOR_PRORATEO = 0
        End Sub

        Public Property PG_MARCADOR_PRORATEO() As Integer
            Get
                Return _PG_MARCADOR_PRORATEO
            End Get
            Set(ByVal value As Integer)
                _PG_MARCADOR_PRORATEO = value
            End Set
        End Property

        Public Property PG_CORREO_CTA_WEB() As String
            Get
                Return _PG_CORREO_CTA_WEB
            End Get
            Set(ByVal value As String)
                _PG_CORREO_CTA_WEB = value
            End Set
        End Property

        Public Property PG_CLAVE_CONTROL_MES() As String
            Get
                Return _PG_CLAVE_CONTROL_MES
            End Get
            Set(ByVal value As String)
                _PG_CLAVE_CONTROL_MES = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_EMP_ITF
        Private _EI_IDEMP As SG_CO_TB_EMPRESA
        Private _EI_ES_ITF As Integer
        Private _EI_IDSUBDIARIO As SG_CO_TB_SUBDIARIO
        Private _EI_IDTIPO_ITF As SG_CO_TB_TIPO_ASIENTO_ITF
        Private _EI_CTA6 As String
        Private _EI_CTA9 As String
        Private _EI_CTA7 As String

        Public Sub New(ByVal EI_IDEMP_ As SG_CO_TB_EMPRESA, ByVal EI_ES_ITF_ As Integer, ByVal EI_IDSUBDIARIO_ As SG_CO_TB_SUBDIARIO, ByVal EI_IDTIPO_ITF_ As SG_CO_TB_TIPO_ASIENTO_ITF, ByVal EI_CTA6_ As String, ByVal EI_CTA9_ As String, ByVal EI_CTA7_ As String)
            _EI_CTA6 = EI_CTA6_
            _EI_CTA9 = EI_CTA9_
            _EI_CTA7 = EI_CTA7_
            _EI_IDEMP = EI_IDEMP_
            _EI_ES_ITF = EI_ES_ITF_
            _EI_IDSUBDIARIO = EI_IDSUBDIARIO_
            _EI_IDTIPO_ITF = EI_IDTIPO_ITF_
        End Sub

        Public Sub New()
            _EI_IDEMP = Nothing
            _EI_ES_ITF = 0
            _EI_IDSUBDIARIO = Nothing
            _EI_IDTIPO_ITF = Nothing
            _EI_CTA6 = String.Empty
            _EI_CTA9 = String.Empty
            _EI_CTA7 = String.Empty
        End Sub

        Public Property EI_CTA6() As String
            Get
                Return _EI_CTA6
            End Get
            Set(ByVal value As String)
                _EI_CTA6 = value
            End Set
        End Property

        Public Property EI_CTA9() As String
            Get
                Return _EI_CTA9
            End Get
            Set(ByVal value As String)
                _EI_CTA9 = value
            End Set
        End Property

        Public Property EI_CTA7() As String
            Get
                Return _EI_CTA7
            End Get
            Set(ByVal value As String)
                _EI_CTA7 = value
            End Set
        End Property

        Public Property EI_IDTIPO_ITF() As SG_CO_TB_TIPO_ASIENTO_ITF
            Get
                Return _EI_IDTIPO_ITF
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_ASIENTO_ITF)
                _EI_IDTIPO_ITF = value
            End Set
        End Property

        Public Property EI_IDEMP() As SG_CO_TB_EMPRESA
            Get
                Return _EI_IDEMP
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _EI_IDEMP = value
            End Set
        End Property

        Public Property EI_ES_ITF() As Integer
            Get
                Return _EI_ES_ITF
            End Get
            Set(ByVal value As Integer)
                _EI_ES_ITF = value
            End Set
        End Property


        Public Property EI_IDSUBDIARIO() As SG_CO_TB_SUBDIARIO
            Get
                Return _EI_IDSUBDIARIO
            End Get
            Set(ByVal value As SG_CO_TB_SUBDIARIO)
                _EI_IDSUBDIARIO = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_PROVINCIA
        Private _DE_ID As String
        Private _DE_DESCRIPCION As String


        Public Sub New(ByVal DE_ID_ As String, ByVal DE_DESCRIPCION_ As String)
            _DE_ID = DE_ID_
            _DE_DESCRIPCION = DE_DESCRIPCION_

        End Sub

        Public Sub New()
            _DE_ID = String.Empty
            _DE_DESCRIPCION = String.Empty

        End Sub

        Public Property DE_ID() As String
            Get
                Return _DE_ID
            End Get
            Set(ByVal value As String)
                _DE_ID = value
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

    Public Class SG_CO_TB_DEPARTAMENTO
        Private _DE_ID As String
        Private _DE_DESCRIPCION As String

        Public Sub New(ByVal DE_ID_ As String, ByVal DE_DESCRIPCION_ As String)
            _DE_ID = DE_ID_
            _DE_DESCRIPCION = DE_DESCRIPCION_
        End Sub
        Public Sub New()
            _DE_ID = String.Empty
            _DE_DESCRIPCION = String.Empty
        End Sub

        Public Property DE_ID() As String
            Get
                Return _DE_ID
            End Get
            Set(ByVal value As String)
                _DE_ID = value
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

    Public Class SG_CO_TB_PERFIL_OPCION
        Private _PG_IDPERFIL As Integer
        Private _PG_IDEMPRESA As Integer
        Private _PG_IDMODULO As Integer
        Private _PG_IDGRUPO As Integer
        Private _PG_IDOPCION As Integer

        Public Sub New(ByVal PG_IDPERFIL_ As Integer, ByVal PG_IDEMPRESA_ As Integer, ByVal PG_IDMODULO_ As Integer, ByVal PG_IDGRUPO_ As Integer, ByVal PG_IDOPCION_ As Integer)
            _PG_IDPERFIL = PG_IDPERFIL_
            _PG_IDEMPRESA = PG_IDEMPRESA_
            _PG_IDMODULO = PG_IDMODULO_
            _PG_IDGRUPO = PG_IDGRUPO_
            _PG_IDOPCION = PG_IDOPCION_
        End Sub

        Public Sub New()
            _PG_IDPERFIL = 0
            _PG_IDEMPRESA = 0
            _PG_IDMODULO = 0
            _PG_IDGRUPO = 0
            _PG_IDOPCION = 0
        End Sub

        Public Property PG_IDPERFIL() As Integer
            Get
                Return _PG_IDPERFIL
            End Get
            Set(ByVal value As Integer)
                _PG_IDPERFIL = value
            End Set
        End Property

        Public Property PG_IDEMPRESA() As Integer
            Get
                Return _PG_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PG_IDEMPRESA = value
            End Set
        End Property

        Public Property PG_IDMODULO() As Integer
            Get
                Return _PG_IDMODULO
            End Get
            Set(ByVal value As Integer)
                _PG_IDMODULO = value
            End Set
        End Property

        Public Property PG_IDGRUPO() As Integer
            Get
                Return _PG_IDGRUPO
            End Get
            Set(ByVal value As Integer)
                _PG_IDGRUPO = value
            End Set
        End Property

        Public Property PG_IDOPCION() As Integer
            Get
                Return _PG_IDOPCION
            End Get
            Set(ByVal value As Integer)
                _PG_IDOPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_PERFIL_GRUPO
        Private _PG_IDPERFIL As Integer
        Private _PG_IDEMPRESA As Integer
        Private _PG_IDMODULO As Integer
        Private _PG_IDGRUPO As Integer

        Public Sub New(ByVal PG_IDPERFIL_ As Integer, ByVal PG_IDEMPRESA_ As Integer, ByVal PG_IDMODULO_ As Integer, ByVal PG_IDGRUPO_ As Integer)
            _PG_IDPERFIL = PG_IDPERFIL_
            _PG_IDEMPRESA = PG_IDEMPRESA_
            _PG_IDMODULO = PG_IDMODULO_
            _PG_IDGRUPO = PG_IDGRUPO_
        End Sub

        Public Sub New()
            _PG_IDPERFIL = 0
            _PG_IDEMPRESA = 0
            _PG_IDMODULO = 0
            _PG_IDGRUPO = 0
        End Sub

        Public Property PG_IDPERFIL() As Integer
            Get
                Return _PG_IDPERFIL
            End Get
            Set(ByVal value As Integer)
                _PG_IDPERFIL = value
            End Set
        End Property

        Public Property PG_IDEMPRESA() As Integer
            Get
                Return _PG_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PG_IDEMPRESA = value
            End Set
        End Property

        Public Property PG_IDMODULO() As Integer
            Get
                Return _PG_IDMODULO
            End Get
            Set(ByVal value As Integer)
                _PG_IDMODULO = value
            End Set
        End Property

        Public Property PG_IDGRUPO() As Integer
            Get
                Return _PG_IDGRUPO
            End Get
            Set(ByVal value As Integer)
                _PG_IDGRUPO = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_PERFIL_MODULO
        Private _PM_IDPERFIL As Integer
        Private _PM_IDMODULO As Integer
        Private _PM_IDEMPRESA As Integer
        Public Sub New(ByVal PM_IDPERFIL_ As Integer, ByVal PM_IDMODULO_ As Integer, ByVal PM_IDEMPRESA_ As Integer)
            _PM_IDPERFIL = PM_IDPERFIL_
            _PM_IDMODULO = PM_IDMODULO_
            _PM_IDEMPRESA = PM_IDEMPRESA_
        End Sub
        Public Sub New()
            _PM_IDPERFIL = 0
            _PM_IDMODULO = 0
            _PM_IDEMPRESA = 0
        End Sub
        Public Property PM_IDPERFIL() As Integer
            Get
                Return _PM_IDPERFIL
            End Get
            Set(ByVal value As Integer)
                _PM_IDPERFIL = value
            End Set
        End Property

        Public Property PM_IDMODULO() As Integer
            Get
                Return _PM_IDMODULO
            End Get
            Set(ByVal value As Integer)
                _PM_IDMODULO = value
            End Set
        End Property
        Public Property PM_IDEMPRESA() As Integer
            Get
                Return _PM_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PM_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_PERFIL_EMPRESA
        Private _PU_IDPERFIL As Integer
        Private _PU_IDEMPRESA As Integer

        Public Sub New(ByVal PU_IDPERFIL_ As Integer, ByVal PU_IDEMPRESA_ As Integer)
            _PU_IDPERFIL = PU_IDPERFIL_
            _PU_IDEMPRESA = PU_IDEMPRESA_
        End Sub
        Public Sub New()
            _PU_IDPERFIL = 0
            _PU_IDEMPRESA = 0
        End Sub
        Public Property PU_IDPERFIL() As Integer
            Get
                Return _PU_IDPERFIL
            End Get
            Set(ByVal value As Integer)
                _PU_IDPERFIL = value
            End Set
        End Property

        Public Property PU_IDEMPRESA() As Integer
            Get
                Return _PU_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PU_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_REG_COM_VTA_HON
        Private _RE_ID_OPERACION As SG_CO_TB_OPERACION
        Private _RE_ID_TIPOCUENTA As SG_CO_TB_TIPO_CUENTA
        Private _RE_NUM_CTA As SG_CO_TB_PLANCTAS
        Private _RE_ANHO As Integer
        Private _RE_ID_EMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal RE_ID_OPERACION_ As SG_CO_TB_OPERACION, ByVal RE_ID_TIPOCUENTA_ As SG_CO_TB_TIPO_CUENTA, ByVal RE_NUM_CTA_ As SG_CO_TB_PLANCTAS, ByVal RE_ANHO_ As Integer, ByVal RE_ID_EMPRESA_ As SG_CO_TB_EMPRESA)
            _RE_ID_OPERACION = RE_ID_OPERACION_
            _RE_ID_TIPOCUENTA = RE_ID_TIPOCUENTA_
            _RE_NUM_CTA = RE_NUM_CTA_
            _RE_ANHO = RE_ANHO_
            _RE_ID_EMPRESA = RE_ID_EMPRESA_
        End Sub
        Public Sub New()
            _RE_ID_OPERACION = Nothing
            _RE_ID_TIPOCUENTA = Nothing
            _RE_ID_EMPRESA = Nothing
            _RE_NUM_CTA = Nothing
            _RE_ANHO = 0
        End Sub

        Public Property RE_ID_OPERACION() As SG_CO_TB_OPERACION
            Get
                Return _RE_ID_OPERACION
            End Get
            Set(ByVal value As SG_CO_TB_OPERACION)
                _RE_ID_OPERACION = value
            End Set
        End Property

        Public Property RE_ID_TIPOCUENTA() As SG_CO_TB_TIPO_CUENTA
            Get
                Return _RE_ID_TIPOCUENTA
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_CUENTA)
                _RE_ID_TIPOCUENTA = value
            End Set
        End Property

        Public Property RE_NUM_CTA() As SG_CO_TB_PLANCTAS
            Get
                Return _RE_NUM_CTA
            End Get
            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _RE_NUM_CTA = value
            End Set
        End Property

        Public Property RE_ANHO() As Integer
            Get
                Return _RE_ANHO
            End Get
            Set(ByVal value As Integer)
                _RE_ANHO = value
            End Set
        End Property

        Public Property RE_ID_EMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _RE_ID_EMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _RE_ID_EMPRESA = value
            End Set
        End Property


    End Class

    Public Class SG_CO_TB_TIPO_CUENTA
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

    Public Class SG_CO_TB_ADMMES
        Private _AM_ANHO As Integer
        Private _AM_MES As Integer
        Private _AM_ESTADO As Integer
        Private _AM_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _AM_USUARIO As String
        Private _AM_TERMINAL As String
        Private _AM_FECREG As String

        Public Sub New(ByVal AM_ANHO_ As Integer, ByVal AM_MES_ As Integer, ByVal AM_ESTADO_ As Integer, ByVal AM_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal AM_USUARIO_ As String, ByVal AM_TERMINAL_ As String, ByVal AM_FECREG_ As String)
            _AM_ANHO = AM_ANHO_
            _AM_MES = AM_MES_
            _AM_ESTADO = AM_ESTADO_
            _AM_IDEMPRESA = AM_IDEMPRESA_
            _AM_USUARIO = AM_USUARIO_
            _AM_TERMINAL = AM_TERMINAL_
            _AM_FECREG = AM_FECREG_
        End Sub

        Public Sub New()
            _AM_ANHO = 0
            _AM_MES = 0
            _AM_ESTADO = 0
            _AM_IDEMPRESA = Nothing
            _AM_USUARIO = String.Empty
            _AM_TERMINAL = String.Empty
            _AM_FECREG = String.Empty
        End Sub


        Public Property AM_ANHO() As Integer
            Get
                Return _AM_ANHO
            End Get
            Set(ByVal value As Integer)
                _AM_ANHO = value
            End Set
        End Property

        Public Property AM_MES() As Integer
            Get
                Return _AM_MES
            End Get
            Set(ByVal value As Integer)
                _AM_MES = value
            End Set
        End Property

        Public Property AM_ESTADO() As Integer
            Get
                Return _AM_ESTADO
            End Get
            Set(ByVal value As Integer)
                _AM_ESTADO = value
            End Set
        End Property

        Public Property AM_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _AM_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _AM_IDEMPRESA = value
            End Set
        End Property

        Public Property AM_USUARIO() As String
            Get
                Return _AM_USUARIO
            End Get
            Set(ByVal value As String)
                _AM_USUARIO = value
            End Set
        End Property

        Public Property AM_TERMINAL() As String
            Get
                Return _AM_TERMINAL
            End Get
            Set(ByVal value As String)
                _AM_TERMINAL = value
            End Set
        End Property

        Public Property AM_FECREG() As String
            Get
                Return _AM_FECREG
            End Get
            Set(ByVal value As String)
                _AM_FECREG = value
            End Set
        End Property



    End Class

    Public Class SG_CO_TB_SERVI_DETRA
        Private _SD_CODIGO As Integer
        Private _SD_DESCRICPION As String
        Private _SD_IDTIPOSERVIDETRA As SG_CO_TB_TIPO_SERVI_DETRA

        Sub New(ByVal SD_CODIGO_ As Integer, ByVal SD_DESCRICPION_ As String, ByVal SD_IDTIPOSERVIDETRA_ As SG_CO_TB_TIPO_SERVI_DETRA)
            _SD_CODIGO = SD_CODIGO_
            _SD_DESCRICPION = SD_DESCRICPION_
            _SD_IDTIPOSERVIDETRA = SD_IDTIPOSERVIDETRA_
        End Sub
        Sub New()
            _SD_CODIGO = 0
            _SD_DESCRICPION = String.Empty
            _SD_IDTIPOSERVIDETRA = Nothing
        End Sub

        Public Property SD_CODIGO() As Integer
            Get
                Return _SD_CODIGO
            End Get
            Set(ByVal value As Integer)
                _SD_CODIGO = value
            End Set
        End Property

        Public Property SD_DESCRICPION() As String
            Get
                Return _SD_DESCRICPION
            End Get
            Set(ByVal value As String)
                _SD_DESCRICPION = value
            End Set
        End Property

        Public Property SD_IDTIPOSERVIDETRA() As SG_CO_TB_TIPO_SERVI_DETRA
            Get
                Return _SD_IDTIPOSERVIDETRA
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_SERVI_DETRA)
                _SD_IDTIPOSERVIDETRA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_TIPO_SERVI_DETRA
        Private _TS_CODIGO As Integer
        Private _TS_DESCRIPCION As String

        Sub New(ByVal TS_CODIGO_ As Integer, ByVal TS_DESCRIPCION_ As String)
            _TS_CODIGO = TS_CODIGO_
            _TS_DESCRIPCION = TS_DESCRIPCION_
        End Sub
        Sub New()
            _TS_CODIGO = 0
            _TS_DESCRIPCION = String.Empty
        End Sub

        Public Property TS_CODIGO() As Integer
            Get
                Return _TS_CODIGO
            End Get
            Set(ByVal value As Integer)
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

    Public Class SG_CO_TB_IMG_SIS
        Private _IS_PC As String
        Private _IS_IMG As Byte()
        Private _IS_USUARIO As Integer
        Private _IS_ESTILO_SKIN As String

        Sub New()
            _IS_USUARIO = 0
            _IS_IMG = Nothing
            _IS_PC = String.Empty
            _IS_ESTILO_SKIN = String.Empty
        End Sub

        Sub New(ByVal IS_PC_ As String, ByVal IS_IMG_ As Byte(), ByVal IS_USUARIO_ As Integer, ByVal IS_ESTILO_SKIN_ As String)
            _IS_PC = IS_PC_
            _IS_IMG = IS_IMG_
            _IS_USUARIO = IS_USUARIO_
            _IS_ESTILO_SKIN = IS_ESTILO_SKIN_
        End Sub

        Public Property IS_ESTILO_SKIN() As String
            Get
                Return _IS_ESTILO_SKIN
            End Get
            Set(ByVal value As String)
                _IS_ESTILO_SKIN = value
            End Set
        End Property


        Public Property IS_PC() As String
            Get
                Return _IS_PC
            End Get
            Set(ByVal value As String)
                _IS_PC = value
            End Set
        End Property

        Public Property IS_IMG() As Byte()
            Get
                Return _IS_IMG
            End Get
            Set(ByVal value As Byte())
                _IS_IMG = value
            End Set
        End Property

        Public Property IS_USUARIO() As Integer
            Get
                Return _IS_USUARIO
            End Get
            Set(ByVal value As Integer)
                _IS_USUARIO = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_OPERACION

        Private _OP_CODIGO As Integer
        Private _OP_DESCRIPCION As String
        Private _OP_ES_CAJABANCO As Integer


        Public Sub New()
            _OP_CODIGO = 0
            _OP_DESCRIPCION = String.Empty
            _OP_ES_CAJABANCO = 0
        End Sub
        Public Sub New(ByVal OP_CODIGO_ As Integer, ByVal OP_DESCRIPCION_ As String, ByVal OP_ES_CAJABANCO_ As Integer)
            _OP_CODIGO = OP_CODIGO_
            _OP_DESCRIPCION = OP_DESCRIPCION_
            _OP_ES_CAJABANCO = OP_ES_CAJABANCO_
        End Sub

        Public Property OP_ES_CAJABANCO() As Integer
            Get
                Return _OP_ES_CAJABANCO
            End Get
            Set(ByVal value As Integer)
                _OP_ES_CAJABANCO = value
            End Set
        End Property

        Public Property OP_CODIGO() As Integer
            Get
                Return _OP_CODIGO
            End Get
            Set(ByVal value As Integer)
                _OP_CODIGO = value
            End Set
        End Property

        Public Property OP_DESCRIPCION() As String
            Get
                Return _OP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _OP_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_EMPRESA

        Private _EM_ID As Integer
        Private _EM_NOMBRE As String
        Private _EM_RUC As String
        Private _EM_FEC_INS As String
        Private _EM_IDPAIS As String
        Private _EM_IDDEPARTAMENTO As String
        Private _EM_DOCREPRE As String
        Private _EM_IDCIUDAD As String
        Private _EM_DIR1 As String
        Private _EM_DIR2 As String
        Private _EM_POST1 As String
        Private _EM_POST2 As String
        Private _EM_REPRESENTANTE As String
        Private _EM_NUMTELF1 As String
        Private _EM_NUMTELF2 As String
        Private _EM_FAX1 As String
        Private _EM_FAX2 As String
        Private _EM_MOVIL1 As String
        Private _EM_MOVIL2 As String
        Private _EM_EMAIL1 As String
        Private _EM_EMAIL2 As String
        Private _EM_WEB_SITE As String
        Private _EM_ES_AGENTE_RETENCION As Integer
        Private _EM_ES_AGENTE_PER_VTA_INT As Integer
        Private _EM_ES_AGENTE_PER_COMBUS As Integer
        Private _EM_USUARIO As String
        Private _EM_TERMINAL As String
        Private _EM_FECREG As String
        Private _EM_IMAGEN() As Byte
        Private _EM_LOGO() As Byte
        Private _EM_CARGO_REPRE As String

        Public Sub New()
            _EM_CARGO_REPRE = String.Empty
            _EM_ID = 0
            _EM_NOMBRE = String.Empty
            _EM_RUC = String.Empty
            _EM_FEC_INS = String.Empty
            _EM_IDPAIS = String.Empty
            _EM_IDDEPARTAMENTO = String.Empty
            _EM_DOCREPRE = String.Empty
            _EM_IDCIUDAD = String.Empty
            _EM_DIR1 = String.Empty
            _EM_DIR2 = String.Empty
            _EM_POST1 = String.Empty
            _EM_POST2 = String.Empty
            _EM_REPRESENTANTE = String.Empty
            _EM_NUMTELF1 = String.Empty
            _EM_NUMTELF2 = String.Empty
            _EM_FAX1 = String.Empty
            _EM_FAX2 = String.Empty
            _EM_MOVIL1 = String.Empty
            _EM_MOVIL2 = String.Empty
            _EM_EMAIL1 = String.Empty
            _EM_EMAIL2 = String.Empty
            _EM_WEB_SITE = String.Empty
            _EM_ES_AGENTE_RETENCION = 0
            _EM_ES_AGENTE_PER_VTA_INT = 0
            _EM_ES_AGENTE_PER_COMBUS = 0
            _EM_USUARIO = String.Empty
            _EM_TERMINAL = String.Empty
            _EM_FECREG = String.Empty
            _EM_IMAGEN = Nothing
            _EM_LOGO = Nothing
        End Sub

        Public Sub New(ByVal EM_ID_ As Integer, ByVal EM_NOMBRE_ As String, ByVal EM_RUC_ As String, ByVal EM_FEC_INS_ As String, ByVal EM_IDPAIS_ As String, ByVal EM_IDDEPARTAMENTO_ As String, ByVal EM_DOCREPRE_ As String, ByVal EM_IDCIUDAD_ As String, ByVal EM_DIR1_ As String, ByVal EM_DIR2_ As String, ByVal EM_POST1_ As String, ByVal EM_POST2_ As String, ByVal EM_REPRESENTANTE_ As String, ByVal EM_NUMTELF1_ As String, ByVal EM_NUMTELF2_ As String, ByVal EM_FAX1_ As String, ByVal EM_FAX2_ As String, ByVal EM_MOVIL1_ As String, ByVal EM_MOVIL2_ As String, ByVal EM_EMAIL1_ As String, ByVal EM_EMAIL2_ As String, ByVal EM_WEB_SITE_ As String, ByVal EM_ES_AGENTE_RETENCION_ As Integer, ByVal EM_ES_AGENTE_PER_VTA_INT_ As Integer, ByVal EM_ES_AGENTE_PER_COMBUS_ As Integer, ByVal EM_USUARIO_ As String, ByVal EM_TERMINAL_ As String, ByVal EM_FECREG_ As String, ByVal EM_IMAGEN_() As Byte, ByVal EM_LOGO_() As Byte, ByVal EM_CARGO_REPRE_ As String)
            _EM_LOGO = EM_LOGO_
            _EM_IMAGEN = EM_IMAGEN_
            _EM_ID = EM_ID_
            _EM_NOMBRE = EM_NOMBRE_
            _EM_RUC = EM_RUC_
            _EM_FEC_INS = EM_FEC_INS_
            _EM_IDPAIS = EM_IDPAIS_
            _EM_IDDEPARTAMENTO = EM_IDDEPARTAMENTO_
            _EM_DOCREPRE = EM_DOCREPRE_
            _EM_IDCIUDAD = EM_IDCIUDAD_
            _EM_DIR1 = EM_DIR1_
            _EM_DIR2 = EM_DIR2_
            _EM_POST1 = EM_POST1_
            _EM_POST2 = EM_POST2_
            _EM_REPRESENTANTE = EM_REPRESENTANTE_
            _EM_NUMTELF1 = EM_NUMTELF1_
            _EM_NUMTELF2 = EM_NUMTELF2_
            _EM_FAX1 = EM_FAX1_
            _EM_FAX2 = EM_FAX2_
            _EM_MOVIL1 = EM_MOVIL1_
            _EM_MOVIL2 = EM_MOVIL2_
            _EM_EMAIL1 = EM_EMAIL1_
            _EM_EMAIL2 = EM_EMAIL2_
            _EM_WEB_SITE = EM_WEB_SITE_
            _EM_ES_AGENTE_RETENCION = EM_ES_AGENTE_RETENCION_
            _EM_ES_AGENTE_PER_VTA_INT = EM_ES_AGENTE_PER_VTA_INT_
            _EM_ES_AGENTE_PER_COMBUS = EM_ES_AGENTE_PER_COMBUS_
            _EM_USUARIO = EM_USUARIO_
            _EM_TERMINAL = EM_TERMINAL_
            _EM_FECREG = EM_FECREG_
            _EM_CARGO_REPRE = EM_CARGO_REPRE_
        End Sub

        Public Property EM_CARGO_REPRE() As String
            Get
                Return _EM_CARGO_REPRE
            End Get
            Set(ByVal value As String)
                _EM_CARGO_REPRE = value
            End Set
        End Property

        Public Property EM_LOGO() As Byte()
            Get
                Return _EM_LOGO
            End Get
            Set(ByVal value As Byte())
                _EM_LOGO = value
            End Set
        End Property

        Public Property EM_IMAGEN() As Byte()
            Get
                Return _EM_IMAGEN
            End Get
            Set(ByVal value As Byte())
                _EM_IMAGEN = value
            End Set
        End Property

        Public Property EM_ID() As Integer
            Get
                Return _EM_ID
            End Get
            Set(ByVal value As Integer)
                _EM_ID = value
            End Set
        End Property

        Public Property EM_NOMBRE() As String
            Get
                Return _EM_NOMBRE
            End Get
            Set(ByVal value As String)
                _EM_NOMBRE = value
            End Set
        End Property

        Public Property EM_RUC() As String
            Get
                Return _EM_RUC
            End Get
            Set(ByVal value As String)
                _EM_RUC = value
            End Set
        End Property

        Public Property EM_FEC_INS() As String
            Get
                Return _EM_FEC_INS
            End Get
            Set(ByVal value As String)
                _EM_FEC_INS = value
            End Set
        End Property

        Public Property EM_IDPAIS() As String
            Get
                Return _EM_IDPAIS
            End Get
            Set(ByVal value As String)
                _EM_IDPAIS = value
            End Set
        End Property

        Public Property EM_IDDEPARTAMENTO() As String
            Get
                Return _EM_IDDEPARTAMENTO
            End Get
            Set(ByVal value As String)
                _EM_IDDEPARTAMENTO = value
            End Set
        End Property

        Public Property EM_DOCREPRE() As String
            Get
                Return _EM_DOCREPRE
            End Get
            Set(ByVal value As String)
                _EM_DOCREPRE = value
            End Set
        End Property

        Public Property EM_IDCIUDAD() As String
            Get
                Return _EM_IDCIUDAD
            End Get
            Set(ByVal value As String)
                _EM_IDCIUDAD = value
            End Set
        End Property

        Public Property EM_DIR1() As String
            Get
                Return _EM_DIR1
            End Get
            Set(ByVal value As String)
                _EM_DIR1 = value
            End Set
        End Property

        Public Property EM_DIR2() As String
            Get
                Return _EM_DIR2
            End Get
            Set(ByVal value As String)
                _EM_DIR2 = value
            End Set
        End Property

        Public Property EM_POST1() As String
            Get
                Return _EM_POST1
            End Get
            Set(ByVal value As String)
                _EM_POST1 = value
            End Set
        End Property

        Public Property EM_POST2() As String
            Get
                Return _EM_POST2
            End Get
            Set(ByVal value As String)
                _EM_POST2 = value
            End Set
        End Property

        Public Property EM_REPRESENTANTE() As String
            Get
                Return _EM_REPRESENTANTE
            End Get
            Set(ByVal value As String)
                _EM_REPRESENTANTE = value
            End Set
        End Property

        Public Property EM_NUMTELF1() As String
            Get
                Return _EM_NUMTELF1
            End Get
            Set(ByVal value As String)
                _EM_NUMTELF1 = value
            End Set
        End Property

        Public Property EM_NUMTELF2() As String
            Get
                Return _EM_NUMTELF2
            End Get
            Set(ByVal value As String)
                _EM_NUMTELF2 = value
            End Set
        End Property

        Public Property EM_FAX1() As String
            Get
                Return _EM_FAX1
            End Get
            Set(ByVal value As String)
                _EM_FAX1 = value
            End Set
        End Property

        Public Property EM_FAX2() As String
            Get
                Return _EM_FAX2
            End Get
            Set(ByVal value As String)
                _EM_FAX2 = value
            End Set
        End Property

        Public Property EM_MOVIL1() As String
            Get
                Return _EM_MOVIL1
            End Get
            Set(ByVal value As String)
                _EM_MOVIL1 = value
            End Set
        End Property

        Public Property EM_MOVIL2() As String
            Get
                Return _EM_MOVIL2
            End Get
            Set(ByVal value As String)
                _EM_MOVIL2 = value
            End Set
        End Property

        Public Property EM_EMAIL1() As String
            Get
                Return _EM_EMAIL1
            End Get
            Set(ByVal value As String)
                _EM_EMAIL1 = value
            End Set
        End Property

        Public Property EM_EMAIL2() As String
            Get
                Return _EM_EMAIL2
            End Get
            Set(ByVal value As String)
                _EM_EMAIL2 = value
            End Set
        End Property

        Public Property EM_WEB_SITE() As String
            Get
                Return _EM_WEB_SITE
            End Get
            Set(ByVal value As String)
                _EM_WEB_SITE = value
            End Set
        End Property

        Public Property EM_ES_AGENTE_RETENCION() As Integer
            Get
                Return _EM_ES_AGENTE_RETENCION
            End Get
            Set(ByVal value As Integer)
                _EM_ES_AGENTE_RETENCION = value
            End Set
        End Property

        Public Property EM_ES_AGENTE_PER_VTA_INT() As Integer
            Get
                Return _EM_ES_AGENTE_PER_VTA_INT
            End Get
            Set(ByVal value As Integer)
                _EM_ES_AGENTE_PER_VTA_INT = value
            End Set
        End Property

        Public Property EM_ES_AGENTE_PER_COMBUS() As Integer
            Get
                Return _EM_ES_AGENTE_PER_COMBUS
            End Get
            Set(ByVal value As Integer)
                _EM_ES_AGENTE_PER_COMBUS = value
            End Set
        End Property

        Public Property EM_USUARIO() As String
            Get
                Return _EM_USUARIO
            End Get
            Set(ByVal value As String)
                _EM_USUARIO = value
            End Set
        End Property

        Public Property EM_TERMINAL() As String
            Get
                Return _EM_TERMINAL
            End Get
            Set(ByVal value As String)
                _EM_TERMINAL = value
            End Set
        End Property

        Public Property EM_FECREG() As String
            Get
                Return _EM_FECREG
            End Get
            Set(ByVal value As String)
                _EM_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_SUBOPERACION

        Private _SO_CODIGO As Integer
        Private _SO_DESCRIPCION As String
        Private _SO_IDOPERACION As SG_CO_TB_OPERACION


        Public Sub New(ByVal SO_CODIGO_ As Integer, ByVal SO_DESCRIPCION_ As String, ByVal SO_IDOPERACION_ As SG_CO_TB_OPERACION)
            _SO_CODIGO = SO_CODIGO_
            _SO_DESCRIPCION = SO_DESCRIPCION_
            _SO_IDOPERACION = SO_IDOPERACION_
        End Sub
        Public Sub New()
            _SO_CODIGO = 0
            _SO_DESCRIPCION = String.Empty
            _SO_IDOPERACION = Nothing
        End Sub

        Public Property SO_CODIGO() As Integer
            Get
                Return _SO_CODIGO
            End Get
            Set(ByVal value As Integer)
                _SO_CODIGO = value
            End Set
        End Property

        Public Property SO_DESCRIPCION() As String
            Get
                Return _SO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _SO_DESCRIPCION = value
            End Set
        End Property

        Public Property SO_IDOPERACION() As SG_CO_TB_OPERACION
            Get
                Return _SO_IDOPERACION
            End Get
            Set(ByVal value As SG_CO_TB_OPERACION)
                _SO_IDOPERACION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_SUBDIARIO

        Private _SD_ID As String
        Private _SD_DESCRIPCION As String
        Private _SD_ABREVIATURA As String
        Private _SD_ES_APER As Integer
        Private _SD_ES_CIER As Integer
        Private _SD_ISTATUS As Integer
        Private _SD_IDOPERACION As SG_CO_TB_OPERACION
        Private _SD_IDSUBOPE As SG_CO_TB_SUBOPERACION
        Private _SD_USUARIO As String
        Private _SD_TERMINAL As String
        Private _SD_FECREG As String
        Private _SD_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New()
            _SD_IDSUBOPE = Nothing
            _SD_IDEMPRESA = Nothing
            _SD_FECREG = String.Empty
            _SD_TERMINAL = String.Empty
            _SD_USUARIO = String.Empty
            _SD_IDOPERACION = Nothing
            _SD_ISTATUS = 0
            _SD_ES_CIER = 0
            _SD_ES_APER = 0
            _SD_ABREVIATURA = String.Empty
            _SD_DESCRIPCION = String.Empty
            _SD_ID = String.Empty
        End Sub
        Public Sub New(ByVal SD_ID_ As Integer, ByVal SD_DESCRIPCION_ As String, ByVal SD_ABREVIATURA_ As String, ByVal SD_ES_APER_ As Integer, ByVal SD_ES_CIER_ As Integer, ByVal SD_ISTATUS_ As Integer, ByVal SD_IDOPERACION_ As SG_CO_TB_OPERACION, ByVal SD_USUARIO_ As String, ByVal SD_TERMINAL_ As String, ByVal SD_FECREG_ As String, ByVal SD_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal SD_IDSUBOPE_ As SG_CO_TB_SUBOPERACION)
            _SD_IDSUBOPE = SD_IDSUBOPE_
            _SD_ID = SD_ID_
            _SD_DESCRIPCION = SD_DESCRIPCION_
            _SD_ABREVIATURA = SD_ABREVIATURA_
            _SD_ES_APER = SD_ES_APER_
            _SD_ES_CIER = SD_ES_CIER_
            _SD_ISTATUS = SD_ISTATUS_
            _SD_IDOPERACION = SD_IDOPERACION_
            _SD_USUARIO = SD_USUARIO_
            _SD_TERMINAL = SD_TERMINAL_
            _SD_FECREG = SD_FECREG_
            _SD_IDEMPRESA = SD_IDEMPRESA_
        End Sub

        Public Property SD_IDSUBOPE() As SG_CO_TB_SUBOPERACION
            Get
                Return _SD_IDSUBOPE
            End Get
            Set(ByVal value As SG_CO_TB_SUBOPERACION)
                _SD_IDSUBOPE = value
            End Set
        End Property

        Public Property SD_ID() As String
            Get
                Return _SD_ID
            End Get
            Set(ByVal value As String)
                _SD_ID = value
            End Set
        End Property

        Public Property SD_DESCRIPCION() As String
            Get
                Return _SD_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _SD_DESCRIPCION = value
            End Set
        End Property

        Public Property SD_ABREVIATURA() As String
            Get
                Return _SD_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _SD_ABREVIATURA = value
            End Set
        End Property

        Public Property SD_ES_APER() As Integer
            Get
                Return _SD_ES_APER
            End Get
            Set(ByVal value As Integer)
                _SD_ES_APER = value
            End Set
        End Property

        Public Property SD_ES_CIER() As Integer
            Get
                Return _SD_ES_CIER
            End Get
            Set(ByVal value As Integer)
                _SD_ES_CIER = value
            End Set
        End Property

        Public Property SD_ISTATUS() As Integer
            Get
                Return _SD_ISTATUS
            End Get
            Set(ByVal value As Integer)
                _SD_ISTATUS = value
            End Set
        End Property

        Public Property SD_IDOPERACION() As SG_CO_TB_OPERACION
            Get
                Return _SD_IDOPERACION
            End Get
            Set(ByVal value As SG_CO_TB_OPERACION)
                _SD_IDOPERACION = value
            End Set
        End Property

        Public Property SD_USUARIO() As String
            Get
                Return _SD_USUARIO
            End Get
            Set(ByVal value As String)
                _SD_USUARIO = value
            End Set
        End Property

        Public Property SD_TERMINAL() As String
            Get
                Return _SD_TERMINAL
            End Get
            Set(ByVal value As String)
                _SD_TERMINAL = value
            End Set
        End Property

        Public Property SD_FECREG() As String
            Get
                Return _SD_FECREG
            End Get
            Set(ByVal value As String)
                _SD_FECREG = value
            End Set
        End Property

        Public Property SD_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _SD_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _SD_IDEMPRESA = value
            End Set
        End Property

    End Class

    Enum TipoA
        Cliente = 1
        Proveedor = 2
        Personal = 3
        Honorarios = 4
        Terceros = 5
    End Enum

    Public Class SG_CO_TB_TIPOANEXO
        Private _TA_CODIGO As TipoA
        Private _TA_DESCRIPCION As String
        Private _TA_IMG() As Byte

        Public Sub New(ByVal TA_CODIGO_ As TipoA, ByVal TA_DESCRIPCION_ As String, ByVal TA_IMG_() As Byte)
            _TA_CODIGO = TA_CODIGO_
            _TA_DESCRIPCION = TA_DESCRIPCION_
            _TA_IMG = TA_IMG_
        End Sub
        Public Sub New()
            _TA_DESCRIPCION = String.Empty
            _TA_CODIGO = 0
            _TA_IMG = Nothing
        End Sub

        Public Property TA_IMG() As Byte()
            Get
                Return _TA_IMG
            End Get
            Set(ByVal value As Byte())
                _TA_IMG = value
            End Set
        End Property

        Public Property TA_CODIGO() As TipoA
            Get
                Return _TA_CODIGO
            End Get
            Set(ByVal value As TipoA)
                _TA_CODIGO = value
            End Set
        End Property

        Public Property TA_DESCRIPCION() As String
            Get
                Return _TA_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TA_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_CENTROCOSTO
        Private _CC_CODIGO As Integer
        Private _CC_DESCRIPCION As String
        Private _CC_USUARIO As String
        Private _CC_TERMINAL As String
        Private _cc_FECREG As String
        Private _CC_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal CC_CODIGO_ As Integer, ByVal CC_DESCRIPCION_ As String, ByVal CC_USUARIO_ As String, ByVal CC_TERMINAL_ As String, ByVal CC_FECREG_ As String, ByVal CC_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _cc_FECREG = String.Empty
            _CC_TERMINAL = String.Empty
            _CC_USUARIO = String.Empty
            _CC_CODIGO = CC_CODIGO_
            _CC_DESCRIPCION = CC_DESCRIPCION_
            _CC_USUARIO = CC_USUARIO_
            _CC_TERMINAL = CC_TERMINAL_
            _cc_FECREG = CC_FECREG_
            _CC_IDEMPRESA = CC_IDEMPRESA_
        End Sub
        Public Sub New()
            _CC_IDEMPRESA = Nothing
            _cc_FECREG = String.Empty
            _CC_TERMINAL = String.Empty
            _CC_USUARIO = String.Empty
            _CC_DESCRIPCION = String.Empty
            _CC_CODIGO = 0
        End Sub

        Public Property CC_CODIGO() As Integer
            Get
                Return _CC_CODIGO
            End Get
            Set(ByVal value As Integer)
                _CC_CODIGO = value
            End Set
        End Property

        Public Property CC_DESCRIPCION() As String
            Get
                Return _CC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CC_DESCRIPCION = value
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
                Return _cc_FECREG
            End Get
            Set(ByVal value As String)
                _cc_FECREG = value
            End Set
        End Property

        Public Property CC_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _CC_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _CC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_TIPOMOV_DET
        Private _TM_CODIGO As Integer
        Private _TM_DESCRIPCION As String

        Public Sub New(ByVal TM_CODIGO_ As Integer, ByVal TM_DESCRIPCION_ As String)
            _TM_CODIGO = TM_CODIGO_
            _TM_DESCRIPCION = TM_DESCRIPCION_
        End Sub
        Public Sub New()
            _TM_DESCRIPCION = String.Empty
            _TM_CODIGO = 0
        End Sub

        Public Property TM_CODIGO() As Integer
            Get
                Return _TM_CODIGO
            End Get
            Set(ByVal value As Integer)
                _TM_CODIGO = value
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

    Public Class SG_CO_TB_TIPOMOV
        Private _TM_CODIGO As Integer
        Private _TM_DESCRIPCION As String

        Public Sub New(ByVal TM_CODIGO_ As Integer, ByVal TM_DESCRIPCION_ As String)
            _TM_CODIGO = TM_CODIGO_
            _TM_DESCRIPCION = TM_DESCRIPCION_
        End Sub

        Public Sub New()
            _TM_DESCRIPCION = String.Empty
            _TM_CODIGO = 0
        End Sub

        Public Property TM_CODIGO() As Integer
            Get
                Return _TM_CODIGO
            End Get
            Set(ByVal value As Integer)
                _TM_CODIGO = value
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

    Public Class SG_CO_TB_CLASE_CTA
        Private _CC_CODIGO As Integer
        Private _CC_DESCRIPCION As String
        Private _CC_ABREVIATURA As String

        Public Sub New(ByVal CC_CODIGO_ As Integer, ByVal CC_DESCRIPCION_ As String, ByVal CC_ABREVIATURA_ As String)
            _CC_CODIGO = CC_CODIGO_
            _CC_DESCRIPCION = CC_DESCRIPCION_
            _CC_ABREVIATURA = CC_ABREVIATURA_
        End Sub
        Public Sub New()
            _CC_ABREVIATURA = String.Empty
            _CC_DESCRIPCION = String.Empty
            _CC_CODIGO = 0
        End Sub

        Public Property CC_CODIGO() As Integer
            Get
                Return _CC_CODIGO
            End Get
            Set(ByVal value As Integer)
                _CC_CODIGO = value
            End Set
        End Property

        Public Property CC_DESCRIPCION() As String
            Get
                Return _CC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CC_DESCRIPCION = value
            End Set
        End Property

        Public Property CC_ABREVIATURA() As String
            Get
                Return _CC_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _CC_ABREVIATURA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_PLANCTAS

        Private _PC_IDCUENTA As Integer
        Private _PC_NUM_CUENTA As String
        Private _PC_IDMONEDA As SG_CO_TB_MONEDA
        Private _PC_IDCLASE As SG_CO_TB_CLASE_CTA
        Private _PC_IDTIPO_MOV As SG_CO_TB_TIPOMOV
        Private _PC_IDTIPO_MOV_DET As SG_CO_TB_TIPOMOV_DET
        Private _PC_IDTIPO_ANEXO As SG_CO_TB_TIPOANEXO
        Private _PC_DESCRIPCION As String
        Private _PC_PERIODO As Integer
        Private _PC_ES_CC As Integer
        Private _PC_ES_AUTO As Integer
        Private _PC_ISTATUS As Integer
        Private _PC_USUARIO As String
        Private _PC_TERMINAL As String
        Private _PC_FECREG As String
        Private _PC_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal PC_IDCUENTA_ As Integer, ByVal PC_NUM_CUENTA_ As String, ByVal PC_IDMONEDA_ As SG_CO_TB_MONEDA, ByVal PC_IDCLASE_ As SG_CO_TB_CLASE_CTA, ByVal PC_IDTIPO_MOV_ As SG_CO_TB_TIPOMOV, ByVal PC_IDTIPO_MOV_DET_ As SG_CO_TB_TIPOMOV_DET, ByVal PC_IDTIPO_ANEXO_ As SG_CO_TB_TIPOANEXO, ByVal PC_DESCRIPCION_ As String, ByVal PC_PERIODO_ As Integer, ByVal PC_ES_CC_ As Integer, ByVal PC_ES_AUTO_ As Integer, ByVal PC_ISTATUS_ As Integer, ByVal PC_USUARIO_ As String, ByVal PC_TERMINAL_ As String, ByVal PC_FECREG_ As String, ByVal PC_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _PC_IDCUENTA = PC_IDCUENTA_
            _PC_NUM_CUENTA = PC_NUM_CUENTA_
            _PC_IDMONEDA = PC_IDMONEDA_
            _PC_IDCLASE = PC_IDCLASE_
            _PC_IDTIPO_MOV = PC_IDTIPO_MOV_
            _PC_IDTIPO_MOV_DET = PC_IDTIPO_MOV_DET_
            _PC_IDTIPO_ANEXO = PC_IDTIPO_ANEXO_
            _PC_DESCRIPCION = PC_DESCRIPCION_
            _PC_PERIODO = PC_PERIODO_
            _PC_ES_CC = PC_ES_CC_
            _PC_ES_AUTO = PC_ES_AUTO_
            _PC_ISTATUS = PC_ISTATUS_
            _PC_USUARIO = PC_USUARIO_
            _PC_TERMINAL = PC_TERMINAL_
            _PC_FECREG = PC_FECREG_
            _PC_IDEMPRESA = PC_IDEMPRESA_
        End Sub
        Public Sub New()
            _PC_IDEMPRESA = Nothing
            _PC_FECREG = String.Empty
            _PC_TERMINAL = String.Empty
            _PC_USUARIO = String.Empty
            _PC_ISTATUS = 0
            _PC_ES_AUTO = 0
            _PC_ES_CC = 0
            _PC_PERIODO = 0
            _PC_DESCRIPCION = String.Empty
            _PC_IDTIPO_ANEXO = Nothing
            _PC_IDTIPO_MOV_DET = Nothing
            _PC_IDTIPO_MOV = Nothing
            _PC_IDCLASE = Nothing
            _PC_IDMONEDA = Nothing
            _PC_NUM_CUENTA = String.Empty
            _PC_IDCUENTA = 0
        End Sub

        Public Property PC_IDCUENTA() As Integer
            Get
                Return _PC_IDCUENTA
            End Get
            Set(ByVal value As Integer)
                _PC_IDCUENTA = value
            End Set
        End Property

        Public Property PC_NUM_CUENTA() As String
            Get
                Return _PC_NUM_CUENTA
            End Get
            Set(ByVal value As String)
                _PC_NUM_CUENTA = value
            End Set
        End Property

        Public Property PC_IDMONEDA() As SG_CO_TB_MONEDA
            Get
                Return _PC_IDMONEDA
            End Get
            Set(ByVal value As SG_CO_TB_MONEDA)
                _PC_IDMONEDA = value
            End Set
        End Property

        Public Property PC_IDCLASE() As SG_CO_TB_CLASE_CTA
            Get
                Return _PC_IDCLASE
            End Get
            Set(ByVal value As SG_CO_TB_CLASE_CTA)
                _PC_IDCLASE = value
            End Set
        End Property

        Public Property PC_IDTIPO_MOV() As SG_CO_TB_TIPOMOV
            Get
                Return _PC_IDTIPO_MOV
            End Get
            Set(ByVal value As SG_CO_TB_TIPOMOV)
                _PC_IDTIPO_MOV = value
            End Set
        End Property

        Public Property PC_IDTIPO_MOV_DET() As SG_CO_TB_TIPOMOV_DET
            Get
                Return _PC_IDTIPO_MOV_DET
            End Get
            Set(ByVal value As SG_CO_TB_TIPOMOV_DET)
                _PC_IDTIPO_MOV_DET = value
            End Set
        End Property

        Public Property PC_IDTIPO_ANEXO() As SG_CO_TB_TIPOANEXO
            Get
                Return _PC_IDTIPO_ANEXO
            End Get
            Set(ByVal value As SG_CO_TB_TIPOANEXO)
                _PC_IDTIPO_ANEXO = value
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

        Public Property PC_PERIODO() As Integer
            Get
                Return _PC_PERIODO
            End Get
            Set(ByVal value As Integer)
                _PC_PERIODO = value
            End Set
        End Property

        Public Property PC_ES_CC() As Integer
            Get
                Return _PC_ES_CC
            End Get
            Set(ByVal value As Integer)
                _PC_ES_CC = value
            End Set
        End Property

        Public Property PC_ES_AUTO() As Integer
            Get
                Return _PC_ES_AUTO
            End Get
            Set(ByVal value As Integer)
                _PC_ES_AUTO = value
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

        Public Property PC_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _PC_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _PC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_CTA_DESTINO
        Private _CD_IDCUENTA As SG_CO_TB_PLANCTAS
        Private _CD_CTA_DESTINO As String
        Private _CD_DH As String
        Private _CD_PORCE As Double
        Private _CD_PC_USUARIO As String
        Private _CD_PC_TERMINAL As String
        Private _CD_PC_FECREG As String
        Private _CD_SECUENCIA As Integer


        Public Sub New(ByVal CD_IDCUENTA_ As SG_CO_TB_PLANCTAS, ByVal CD_CTA_DESTINO_ As String, ByVal CD_DH_ As String, ByVal CD_PORCE_ As Double, ByVal CD_PC_USUARIO_ As String, ByVal CD_PC_TERMINAL_ As String, ByVal CD_PC_FECREG_ As String, ByVal CD_SECUENCIA_ As Integer)
            _CD_IDCUENTA = CD_IDCUENTA_
            _CD_CTA_DESTINO = CD_CTA_DESTINO_
            _CD_DH = CD_DH_
            _CD_PORCE = CD_PORCE_
            _CD_PC_USUARIO = CD_PC_USUARIO_
            _CD_PC_TERMINAL = CD_PC_TERMINAL_
            _CD_PC_FECREG = CD_PC_FECREG_
            _CD_SECUENCIA = CD_SECUENCIA_
        End Sub
        Public Sub New()
            _CD_IDCUENTA = Nothing
            _CD_CTA_DESTINO = String.Empty
            _CD_DH = String.Empty
            _CD_PORCE = 0.0R
            _CD_PC_USUARIO = String.Empty
            _CD_PC_TERMINAL = String.Empty
            _CD_PC_FECREG = String.Empty
            _CD_SECUENCIA = 0
        End Sub

        Public Property CD_IDCUENTA() As SG_CO_TB_PLANCTAS
            Get
                Return _CD_IDCUENTA
            End Get
            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _CD_IDCUENTA = value
            End Set
        End Property

        Public Property CD_CTA_DESTINO() As String
            Get
                Return _CD_CTA_DESTINO
            End Get
            Set(ByVal value As String)
                _CD_CTA_DESTINO = value
            End Set
        End Property

        Public Property CD_DH() As String
            Get
                Return _CD_DH
            End Get
            Set(ByVal value As String)
                _CD_DH = value
            End Set
        End Property

        Public Property CD_PORCE() As Double
            Get
                Return _CD_PORCE
            End Get
            Set(ByVal value As Double)
                _CD_PORCE = value
            End Set
        End Property

        Public Property CD_PC_USUARIO() As String
            Get
                Return _CD_PC_USUARIO
            End Get
            Set(ByVal value As String)
                _CD_PC_USUARIO = value
            End Set
        End Property

        Public Property CD_PC_TERMINAL() As String
            Get
                Return _CD_PC_TERMINAL
            End Get
            Set(ByVal value As String)
                _CD_PC_TERMINAL = value
            End Set
        End Property

        Public Property CD_PC_FECREG() As String
            Get
                Return _CD_PC_FECREG
            End Get
            Set(ByVal value As String)
                _CD_PC_FECREG = value
            End Set
        End Property

        Public Property CD_SECUENCIA() As Integer
            Get
                Return _CD_SECUENCIA
            End Get
            Set(ByVal value As Integer)
                _CD_SECUENCIA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_MONEDA

        Private _MO_CODIGO As Integer
        Private _MO_DESCRIPCION As String
        Private _MO_SIMBOLO As String
        Private _MO_ES_PRINCIPAL As Integer
        Private _MO_IDPAIS As SG_CO_TB_PAIS
        Private _MO_CUENTA_GANANCIA As String
        Private _MO_CUENTA_PERDIDA As String
        Private _MO_CODIGO_SUNAT As String
        Private _MO_USUARIO As String
        Private _MO_TERMINAL As String
        Private _MO_FECREG As String
        Private _MO_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal MO_CODIGO_ As Integer, ByVal MO_DESCRIPCION_ As String, ByVal MO_SIMBOLO_ As String, ByVal MO_ES_PRINCIPAL_ As Integer, ByVal MO_IDPAIS_ As SG_CO_TB_PAIS, ByVal MO_CUENTA_GANANCIA_ As String, ByVal MO_CUENTA_PERDIDA_ As String, ByVal MO_CODIGO_SUNAT_ As String, ByVal MO_USUARIO_ As String, ByVal MO_TERMINAL_ As String, ByVal MO_FECREG_ As String, ByVal MO_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _MO_CODIGO = MO_CODIGO_
            _MO_DESCRIPCION = MO_DESCRIPCION_
            _MO_SIMBOLO = MO_SIMBOLO_
            _MO_ES_PRINCIPAL = MO_ES_PRINCIPAL_
            _MO_IDPAIS = MO_IDPAIS_
            _MO_CUENTA_GANANCIA = MO_CUENTA_GANANCIA_
            _MO_CUENTA_PERDIDA = MO_CUENTA_PERDIDA_
            _MO_CODIGO_SUNAT = MO_CODIGO_SUNAT_
            _MO_USUARIO = MO_USUARIO_
            _MO_TERMINAL = MO_TERMINAL_
            _MO_FECREG = MO_FECREG_
            _MO_IDEMPRESA = MO_IDEMPRESA_
        End Sub
        Public Sub New()
        End Sub

        Public Property MO_CODIGO() As Integer
            Get
                Return _MO_CODIGO
            End Get
            Set(ByVal value As Integer)
                _MO_CODIGO = value
            End Set
        End Property

        Public Property MO_DESCRIPCION() As String
            Get
                Return _MO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _MO_DESCRIPCION = value
            End Set
        End Property

        Public Property MO_SIMBOLO() As String
            Get
                Return _MO_SIMBOLO
            End Get
            Set(ByVal value As String)
                _MO_SIMBOLO = value
            End Set
        End Property

        Public Property MO_ES_PRINCIPAL() As Integer
            Get
                Return _MO_ES_PRINCIPAL
            End Get
            Set(ByVal value As Integer)
                _MO_ES_PRINCIPAL = value
            End Set
        End Property

        Public Property MO_IDPAIS() As SG_CO_TB_PAIS
            Get
                Return _MO_IDPAIS
            End Get
            Set(ByVal value As SG_CO_TB_PAIS)
                _MO_IDPAIS = value
            End Set
        End Property

        Public Property MO_CUENTA_GANANCIA() As String
            Get
                Return _MO_CUENTA_GANANCIA
            End Get
            Set(ByVal value As String)
                _MO_CUENTA_GANANCIA = value
            End Set
        End Property

        Public Property MO_CUENTA_PERDIDA() As String
            Get
                Return _MO_CUENTA_PERDIDA
            End Get
            Set(ByVal value As String)
                _MO_CUENTA_PERDIDA = value
            End Set
        End Property

        Public Property MO_CODIGO_SUNAT() As String
            Get
                Return _MO_CODIGO_SUNAT
            End Get
            Set(ByVal value As String)
                _MO_CODIGO_SUNAT = value
            End Set
        End Property

        Public Property MO_USUARIO() As String
            Get
                Return _MO_USUARIO
            End Get
            Set(ByVal value As String)
                _MO_USUARIO = value
            End Set
        End Property

        Public Property MO_TERMINAL() As String
            Get
                Return _MO_TERMINAL
            End Get
            Set(ByVal value As String)
                _MO_TERMINAL = value
            End Set
        End Property

        Public Property MO_FECREG() As String
            Get
                Return _MO_FECREG
            End Get
            Set(ByVal value As String)
                _MO_FECREG = value
            End Set
        End Property

        Public Property MO_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _MO_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _MO_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_PAIS

        Private _PA_CODIGO As String
        Private _PA_DESCRIPCION As String
        Private _PA_COD_SUNAT As String
        Private _PA_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New()
        End Sub
        Public Sub New(ByVal PA_CODIGO_ As String, ByVal PA_DESCRIPCION_ As String, ByVal PA_COD_SUNAT_ As String, ByVal PA_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _PA_CODIGO = PA_CODIGO_
            _PA_DESCRIPCION = PA_DESCRIPCION_
            _PA_COD_SUNAT = PA_COD_SUNAT_
            _PA_IDEMPRESA = PA_IDEMPRESA_
        End Sub

        Public Property PA_CODIGO() As String
            Get
                Return _PA_CODIGO
            End Get
            Set(ByVal value As String)
                _PA_CODIGO = value
            End Set
        End Property

        Public Property PA_DESCRIPCION() As String
            Get
                Return _PA_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _PA_DESCRIPCION = value
            End Set
        End Property

        Public Property PA_COD_SUNAT() As String
            Get
                Return _PA_COD_SUNAT
            End Get
            Set(ByVal value As String)
                _PA_COD_SUNAT = value
            End Set
        End Property

        Public Property PA_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _PA_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _PA_IDEMPRESA = value
            End Set
        End Property


    End Class

    Enum TipoEmpresa
        Natural = 1
        Juridica = 2
    End Enum

    Public Class SG_CO_TB_TIPOEMPRESA
        Private _TE_CODIGO As TipoEmpresa
        Private _TE_DESCRIPCION As String

        Public Sub New(ByVal TE_CODIGO_ As TipoEmpresa, ByVal TE_DESCRIPCION_ As String)
            _TE_CODIGO = TE_CODIGO_
            _TE_DESCRIPCION = TE_DESCRIPCION_
        End Sub
        Public Sub New()
            _TE_DESCRIPCION = String.Empty
            _TE_CODIGO = 0
        End Sub

        Public Property TE_CODIGO() As TipoEmpresa
            Get
                Return _TE_CODIGO
            End Get
            Set(ByVal value As TipoEmpresa)
                _TE_CODIGO = value
            End Set
        End Property

        Public Property TE_DESCRIPCION() As String
            Get
                Return _TE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TE_DESCRIPCION = value
            End Set
        End Property

    End Class

    Enum TipoDocPersonal
        Otros = 0
        Dni = 1
        CE = 4
        Ruc = 6
        Pasaporte = 7
    End Enum

    Public Class SG_CO_TB_TIPO_DOC_IDENTIDAD
        Private _DI_CODIGO As TipoDocPersonal
        Private _DI_DESCRIPCION As String
        Private _DI_ABREVIATURA As String

        Public Sub New(ByVal DI_CODIGO_ As TipoDocPersonal, ByVal DI_DESCRIPCION_ As String, ByVal DI_ABREVIATURA_ As String)
            _DI_CODIGO = DI_CODIGO_
            _DI_DESCRIPCION = DI_DESCRIPCION_
            _DI_ABREVIATURA = DI_ABREVIATURA_
        End Sub
        Public Sub New()
            _DI_DESCRIPCION = String.Empty
            _DI_CODIGO = 0
            _DI_ABREVIATURA = String.Empty
        End Sub

        Public Property DI_CODIGO() As TipoDocPersonal
            Get
                Return _DI_CODIGO
            End Get
            Set(ByVal value As TipoDocPersonal)
                _DI_CODIGO = value
            End Set
        End Property

        Public Property DI_DESCRIPCION() As String
            Get
                Return _DI_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DI_DESCRIPCION = value
            End Set
        End Property
        Public Property DI_ABREVIATURA() As String
            Get
                Return _DI_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _DI_ABREVIATURA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_ANE_DIRECCION
        Private _CD_IDANEXO As SG_CO_TB_ANEXO
        Private _CD_SECUENCIA As Integer
        Private _CD_DESCRIPCION As String
        Private _CD_DIR_FISCAL As String
        Private _CD_DIR_LEGAL As String
        Private _CD_IDPAIS As SG_CO_TB_PAIS
        Private _CD_CIUDAD As String
        Private _CD_DEPARTAMENTO As String
        Private _CD_PROVINCIA As String
        Private _CD_DISTRITO As String
        Private _CD_CODIGO_POSTAL As String
        Private _CD_REFERENCIA As String
        Private _CD_TELF_FIJO1 As String
        Private _CD_TELF_FIJO2 As String
        Private _CD_MOBIL As String
        Private _CD_EMAIL As String
        Private _CD_USUARIO As String
        Private _CD_TERMINAL As String
        Private _CD_FECREG As String

        Public Sub New(ByVal CD_IDANEXo_ As SG_CO_TB_ANEXO, ByVal CD_SECUENCIA_ As Integer, ByVal CD_DESCRIPCION_ As String, ByVal CD_DIR_FISCAL_ As String, ByVal CD_DIR_LEGAL_ As String, ByVal CD_IDPAIS_ As SG_CO_TB_PAIS, ByVal CD_CIUDAD_ As String, ByVal CD_DEPARTAMENTO_ As String, ByVal CD_PROVINCIA_ As String, ByVal CD_DISTRITO_ As String, ByVal CD_CODIGO_POSTAL_ As String, ByVal CD_REFERENCIA_ As String, ByVal CD_TELF_FIJO1_ As String, ByVal CD_TELF_FIJO2_ As String, ByVal CD_MOBIL_ As String, ByVal CD_EMAIL_ As String, ByVal CD_USUARIO_ As String, ByVal CD_TERMINAL_ As String, ByVal CD_FECREG_ As String)
            _CD_IDANEXO = CD_IDANEXo_
            _CD_SECUENCIA = CD_SECUENCIA_
            _CD_DESCRIPCION = CD_DESCRIPCION_
            _CD_DIR_FISCAL = CD_DIR_FISCAL_
            _CD_DIR_LEGAL = CD_DIR_LEGAL_
            _CD_IDPAIS = CD_IDPAIS_
            _CD_CIUDAD = CD_CIUDAD_
            _CD_DEPARTAMENTO = CD_DEPARTAMENTO_
            _CD_PROVINCIA = CD_PROVINCIA_
            _CD_DISTRITO = CD_DISTRITO_
            _CD_CODIGO_POSTAL = CD_CODIGO_POSTAL_
            _CD_REFERENCIA = CD_REFERENCIA_
            _CD_TELF_FIJO1 = CD_TELF_FIJO1_
            _CD_TELF_FIJO2 = CD_TELF_FIJO2_
            _CD_MOBIL = CD_MOBIL_
            _CD_EMAIL = CD_EMAIL_
            _CD_USUARIO = CD_USUARIO_
            _CD_TERMINAL = CD_TERMINAL_
            _CD_FECREG = CD_FECREG_
        End Sub
        Public Sub New()
            _CD_FECREG = String.Empty
            _CD_TERMINAL = String.Empty
            _CD_USUARIO = String.Empty
            _CD_EMAIL = String.Empty
            _CD_MOBIL = String.Empty
            _CD_TELF_FIJO2 = String.Empty
            _CD_TELF_FIJO1 = String.Empty
            _CD_REFERENCIA = String.Empty
            _CD_CODIGO_POSTAL = String.Empty
            _CD_DISTRITO = String.Empty
            _CD_PROVINCIA = String.Empty
            _CD_DEPARTAMENTO = String.Empty
            _CD_CIUDAD = String.Empty
            _CD_DIR_LEGAL = String.Empty
            _CD_IDPAIS = Nothing
            _CD_DIR_FISCAL = String.Empty
            _CD_DESCRIPCION = String.Empty
            _CD_SECUENCIA = 0
            _CD_IDANEXO = Nothing
        End Sub

        Public Property CD_IDANEXO() As SG_CO_TB_ANEXO
            Get
                Return _CD_IDANEXO
            End Get
            Set(ByVal value As SG_CO_TB_ANEXO)
                _CD_IDANEXO = value
            End Set
        End Property

        Public Property CD_SECUENCIA() As Integer
            Get
                Return _CD_SECUENCIA
            End Get
            Set(ByVal value As Integer)
                _CD_SECUENCIA = value
            End Set
        End Property

        Public Property CD_DESCRIPCION() As String
            Get
                Return _CD_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CD_DESCRIPCION = value
            End Set
        End Property

        Public Property CD_DIR_FISCAL() As String
            Get
                Return _CD_DIR_FISCAL
            End Get
            Set(ByVal value As String)
                _CD_DIR_FISCAL = value
            End Set
        End Property

        Public Property CD_DIR_LEGAL() As String
            Get
                Return _CD_DIR_LEGAL
            End Get
            Set(ByVal value As String)
                _CD_DIR_LEGAL = value
            End Set
        End Property

        Public Property CD_IDPAIS() As SG_CO_TB_PAIS
            Get
                Return _CD_IDPAIS
            End Get
            Set(ByVal value As SG_CO_TB_PAIS)
                _CD_IDPAIS = value
            End Set
        End Property

        Public Property CD_CIUDAD() As String
            Get
                Return _CD_CIUDAD
            End Get
            Set(ByVal value As String)
                _CD_CIUDAD = value
            End Set
        End Property

        Public Property CD_DEPARTAMENTO() As String
            Get
                Return _CD_DEPARTAMENTO
            End Get
            Set(ByVal value As String)
                _CD_DEPARTAMENTO = value
            End Set
        End Property

        Public Property CD_PROVINCIA() As String
            Get
                Return _CD_PROVINCIA
            End Get
            Set(ByVal value As String)
                _CD_PROVINCIA = value
            End Set
        End Property

        Public Property CD_DISTRITO() As String
            Get
                Return _CD_DISTRITO
            End Get
            Set(ByVal value As String)
                _CD_DISTRITO = value
            End Set
        End Property

        Public Property CD_CODIGO_POSTAL() As String
            Get
                Return _CD_CODIGO_POSTAL
            End Get
            Set(ByVal value As String)
                _CD_CODIGO_POSTAL = value
            End Set
        End Property

        Public Property CD_REFERENCIA() As String
            Get
                Return _CD_REFERENCIA
            End Get
            Set(ByVal value As String)
                _CD_REFERENCIA = value
            End Set
        End Property

        Public Property CD_TELF_FIJO1() As String
            Get
                Return _CD_TELF_FIJO1
            End Get
            Set(ByVal value As String)
                _CD_TELF_FIJO1 = value
            End Set
        End Property

        Public Property CD_TELF_FIJO2() As String
            Get
                Return _CD_TELF_FIJO2
            End Get
            Set(ByVal value As String)
                _CD_TELF_FIJO2 = value
            End Set
        End Property

        Public Property CD_MOBIL() As String
            Get
                Return _CD_MOBIL
            End Get
            Set(ByVal value As String)
                _CD_MOBIL = value
            End Set
        End Property

        Public Property CD_EMAIL() As String
            Get
                Return _CD_EMAIL
            End Get
            Set(ByVal value As String)
                _CD_EMAIL = value
            End Set
        End Property

        Public Property CD_USUARIO() As String
            Get
                Return _CD_USUARIO
            End Get
            Set(ByVal value As String)
                _CD_USUARIO = value
            End Set
        End Property

        Public Property CD_TERMINAL() As String
            Get
                Return _CD_TERMINAL
            End Get
            Set(ByVal value As String)
                _CD_TERMINAL = value
            End Set
        End Property

        Public Property CD_FECREG() As String
            Get
                Return _CD_FECREG
            End Get
            Set(ByVal value As String)
                _CD_FECREG = value
            End Set
        End Property
    End Class
    Public Class SG_CO_TB_ANE_DATO_FINANZA

        Private _DF_IDANEXO As SG_CO_TB_ANEXO
        Private _DF_SECUENCIA As Integer
        Private _DF_MONTO_ASIGANDO As Double
        Private _DF_FEC_ASIG As String
        Private _DF_FEC_VENC As String
        Private _DF_PORCENTAJE_EXCE As Double
        Private _DF_IDMONEDA As SG_CO_TB_MONEDA
        Private _DF_IDFORMA_PAGO As SG_CO_TB_FORMAPAGO
        Private _DF_SALDO_ACTUAL As Double
        Private _DF_SALDO_DISPONIBLE As Double
        Private _DF_TERMINAL As String
        Private _DF_FECREG As String
        Private _DF_IDEMPRESA As SG_CO_TB_EMPRESA


        Public Sub New(ByVal DF_IDANEXO_ As SG_CO_TB_ANEXO, ByVal DF_SECUENCIA_ As Integer, ByVal DF_MONTO_ASIGANDO_ As Double, ByVal DF_FEC_ASIG_ As String, ByVal DF_FEC_VENC_ As String, ByVal DF_PORCENTAJE_EXCE_ As Double, ByVal DF_IDMONEDA_ As SG_CO_TB_MONEDA, ByVal DF_IDFORMA_PAGO_ As SG_CO_TB_FORMAPAGO, ByVal DF_SALDO_ACTUAL_ As Double, ByVal DF_SALDO_DISPONIBLE_ As Double, ByVal DF_TERMINAL_ As String, ByVal DF_FECREG_ As String, ByVal DF_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _DF_IDANEXO = DF_IDANEXO_
            _DF_SECUENCIA = DF_SECUENCIA_
            _DF_MONTO_ASIGANDO = DF_MONTO_ASIGANDO_
            _DF_FEC_ASIG = DF_FEC_ASIG_
            _DF_FEC_VENC = DF_FEC_VENC_
            _DF_PORCENTAJE_EXCE = DF_PORCENTAJE_EXCE_
            _DF_IDMONEDA = DF_IDMONEDA_
            _DF_IDFORMA_PAGO = DF_IDFORMA_PAGO_
            _DF_SALDO_ACTUAL = DF_SALDO_ACTUAL_
            _DF_SALDO_DISPONIBLE = DF_SALDO_DISPONIBLE_
            _DF_TERMINAL = DF_TERMINAL_
            _DF_FECREG = DF_FECREG_
            _DF_IDEMPRESA = DF_IDEMPRESA_
        End Sub
        Public Sub New()
            _DF_IDEMPRESA = Nothing
            _DF_FECREG = String.Empty
            _DF_TERMINAL = String.Empty
            _DF_SALDO_DISPONIBLE = 0.0R
            _DF_SALDO_ACTUAL = 0.0R
            _DF_IDFORMA_PAGO = Nothing
            _DF_IDMONEDA = Nothing
            _DF_PORCENTAJE_EXCE = 0.0R
            _DF_FEC_VENC = String.Empty
            _DF_FEC_ASIG = String.Empty
            _DF_MONTO_ASIGANDO = 0.0R
            _DF_SECUENCIA = 0
            _DF_IDANEXO = Nothing
        End Sub

        Public Property DF_IDANEXO() As SG_CO_TB_ANEXO
            Get
                Return _DF_IDANEXO
            End Get
            Set(ByVal value As SG_CO_TB_ANEXO)
                _DF_IDANEXO = value
            End Set
        End Property

        Public Property DF_SECUENCIA() As Integer
            Get
                Return _DF_SECUENCIA
            End Get
            Set(ByVal value As Integer)
                _DF_SECUENCIA = value
            End Set
        End Property

        Public Property DF_MONTO_ASIGANDO() As Double
            Get
                Return _DF_MONTO_ASIGANDO
            End Get
            Set(ByVal value As Double)
                _DF_MONTO_ASIGANDO = value
            End Set
        End Property

        Public Property DF_FEC_ASIG() As String
            Get
                Return _DF_FEC_ASIG
            End Get
            Set(ByVal value As String)
                _DF_FEC_ASIG = value
            End Set
        End Property

        Public Property DF_FEC_VENC() As String
            Get
                Return _DF_FEC_VENC
            End Get
            Set(ByVal value As String)
                _DF_FEC_VENC = value
            End Set
        End Property

        Public Property DF_PORCENTAJE_EXCE() As String
            Get
                Return _DF_PORCENTAJE_EXCE
            End Get
            Set(ByVal value As String)
                _DF_PORCENTAJE_EXCE = value
            End Set
        End Property

        Public Property DF_IDMONEDA() As SG_CO_TB_MONEDA
            Get
                Return _DF_IDMONEDA
            End Get
            Set(ByVal value As SG_CO_TB_MONEDA)
                _DF_IDMONEDA = value
            End Set
        End Property

        Public Property DF_IDFORMA_PAGO() As SG_CO_TB_FORMAPAGO
            Get
                Return _DF_IDFORMA_PAGO
            End Get
            Set(ByVal value As SG_CO_TB_FORMAPAGO)
                _DF_IDFORMA_PAGO = value
            End Set
        End Property

        Public Property DF_SALDO_ACTUAL() As Double
            Get
                Return _DF_SALDO_ACTUAL
            End Get
            Set(ByVal value As Double)
                _DF_SALDO_ACTUAL = value
            End Set
        End Property

        Public Property DF_SALDO_DISPONIBLE() As Double
            Get
                Return _DF_SALDO_DISPONIBLE
            End Get
            Set(ByVal value As Double)
                _DF_SALDO_DISPONIBLE = value
            End Set
        End Property

        Public Property DF_TERMINAL() As String
            Get
                Return _DF_TERMINAL
            End Get
            Set(ByVal value As String)
                _DF_TERMINAL = value
            End Set
        End Property

        Public Property DF_FECREG() As String
            Get
                Return _DF_FECREG
            End Get
            Set(ByVal value As String)
                _DF_FECREG = value
            End Set
        End Property

        Public Property DF_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _DF_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _DF_IDEMPRESA = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_ANE_CONTACTOS

        Private _CC_IDANEXO As SG_CO_TB_ANEXO
        Private _CC_IDCONTACTO As Integer
        Private _CC_APELLIDOS As String
        Private _CC_NOMBRES As String
        Private _CC_CARGO As String
        Private _CC_NUM_DOC As String
        Private _CC_TEL_FIJO As String
        Private _CC_TEL_MOVIL As String
        Private _CC_FAX As String
        Private _CC_IDPERSONAL As Integer
        Private _CC_EMAIL As String
        Private _CC_PC_USUARIO As String
        Private _CC_PC_TERMINAL As String
        Private _CC_PC_FECREG As String

        Public Sub New(ByVal CC_IDANEXO_ As SG_CO_TB_ANEXO, ByVal CC_IDCONTACTO_ As Integer, ByVal CC_APELLIDOS_ As String, ByVal CC_NOMBRES_ As String, ByVal CC_CARGO_ As String, ByVal CC_NUM_DOC_ As String, ByVal CC_TEL_FIJO_ As String, ByVal CC_TEL_MOVIL_ As String, ByVal CC_FAX_ As String, ByVal CC_IDPERSONAL_ As Integer, ByVal CC_EMAIL_ As String, ByVal CC_PC_USUARIO_ As String, ByVal CC_PC_TERMINAL_ As String, ByVal CC_PC_FECREG_ As String)
            _CC_IDANEXO = CC_IDANEXO_
            _CC_IDCONTACTO = CC_IDCONTACTO_
            _CC_APELLIDOS = CC_APELLIDOS_
            _CC_NOMBRES = CC_NOMBRES_
            _CC_CARGO = CC_CARGO_
            _CC_NUM_DOC = CC_NUM_DOC_
            _CC_TEL_FIJO = CC_TEL_FIJO_
            _CC_TEL_MOVIL = CC_TEL_MOVIL_
            _CC_FAX = CC_FAX_
            _CC_IDPERSONAL = CC_IDPERSONAL_
            _CC_EMAIL = CC_EMAIL_
            _CC_PC_USUARIO = CC_PC_USUARIO_
            _CC_PC_TERMINAL = CC_PC_TERMINAL_
            _CC_PC_FECREG = CC_PC_FECREG_
        End Sub
        Public Sub New()
            _CC_PC_FECREG = String.Empty
            _CC_PC_TERMINAL = String.Empty
            _CC_PC_USUARIO = String.Empty
            _CC_EMAIL = String.Empty
            _CC_IDPERSONAL = String.Empty
            _CC_FAX = String.Empty
            _CC_TEL_MOVIL = String.Empty
            _CC_TEL_FIJO = String.Empty
            _CC_NUM_DOC = String.Empty
            _CC_CARGO = String.Empty
            _CC_NOMBRES = String.Empty
            _CC_APELLIDOS = String.Empty
            _CC_IDCONTACTO = 0
            _CC_IDANEXO = Nothing
        End Sub

        Public Property CC_IDANEXO() As SG_CO_TB_ANEXO
            Get
                Return _CC_IDANEXO
            End Get
            Set(ByVal value As SG_CO_TB_ANEXO)
                _CC_IDANEXO = value
            End Set
        End Property

        Public Property CC_IDCONTACTO() As Integer
            Get
                Return _CC_IDCONTACTO
            End Get
            Set(ByVal value As Integer)
                _CC_IDCONTACTO = value
            End Set
        End Property

        Public Property CC_APELLIDOS() As String
            Get
                Return _CC_APELLIDOS
            End Get
            Set(ByVal value As String)
                _CC_APELLIDOS = value
            End Set
        End Property

        Public Property CC_NOMBRES() As String
            Get
                Return _CC_NOMBRES
            End Get
            Set(ByVal value As String)
                _CC_NOMBRES = value
            End Set
        End Property

        Public Property CC_CARGO() As String
            Get
                Return _CC_CARGO
            End Get
            Set(ByVal value As String)
                _CC_CARGO = value
            End Set
        End Property

        Public Property CC_NUM_DOC() As String
            Get
                Return _CC_NUM_DOC
            End Get
            Set(ByVal value As String)
                _CC_NUM_DOC = value
            End Set
        End Property

        Public Property CC_TEL_FIJO() As String
            Get
                Return _CC_TEL_FIJO
            End Get
            Set(ByVal value As String)
                _CC_TEL_FIJO = value
            End Set
        End Property

        Public Property CC_TEL_MOVIL() As String
            Get
                Return _CC_TEL_MOVIL
            End Get
            Set(ByVal value As String)
                _CC_TEL_MOVIL = value
            End Set
        End Property

        Public Property CC_FAX() As String
            Get
                Return _CC_FAX
            End Get
            Set(ByVal value As String)
                _CC_FAX = value
            End Set
        End Property

        Public Property CC_IDPERSONAL() As Integer
            Get
                Return _CC_IDPERSONAL
            End Get
            Set(ByVal value As Integer)
                _CC_IDPERSONAL = value
            End Set
        End Property

        Public Property CC_EMAIL() As String
            Get
                Return _CC_EMAIL
            End Get
            Set(ByVal value As String)
                _CC_EMAIL = value
            End Set
        End Property

        Public Property CC_PC_USUARIO() As String
            Get
                Return _CC_PC_USUARIO
            End Get
            Set(ByVal value As String)
                _CC_PC_USUARIO = value
            End Set
        End Property

        Public Property CC_PC_TERMINAL() As String
            Get
                Return _CC_PC_TERMINAL
            End Get
            Set(ByVal value As String)
                _CC_PC_TERMINAL = value
            End Set
        End Property

        Public Property CC_PC_FECREG() As String
            Get
                Return _CC_PC_FECREG
            End Get
            Set(ByVal value As String)
                _CC_PC_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_ANE_CTABANCARIA
        Private _CB_IDANEXO As SG_CO_TB_ANEXO
        Private _CB_SECUENCIA As Integer
        Private _CB_NUM_CTA As String
        Private _CB_DES_CTA As String
        Private _CB_IDBANCO As SG_CO_TB_BANCO
        Private _CB_IDPAIS As SG_CO_TB_PAIS
        Private _CB_IDMONEDA As SG_CO_TB_MONEDA
        Private _CB_USUARIO As String
        Private _CB_TERMINAL As String
        Private _CB_FECREG As String

        Public Sub New(ByVal CB_IDANEXO_ As SG_CO_TB_ANEXO, ByVal CB_SECUENCIA_ As Integer, ByVal CB_NUM_CTA_ As String, ByVal CB_DES_CTA_ As String, ByVal CB_IDBANCO_ As SG_CO_TB_BANCO, ByVal CB_IDPAIS_ As SG_CO_TB_PAIS, ByVal CB_IDMONEDA_ As SG_CO_TB_MONEDA, ByVal CB_USUARIO_ As String, ByVal CB_TERMINAL_ As String, ByVal CB_FECREG_ As String)
            _CB_IDANEXO = CB_IDANEXO_
            _CB_SECUENCIA = CB_SECUENCIA_
            _CB_NUM_CTA = CB_NUM_CTA_
            _CB_DES_CTA = CB_DES_CTA_
            _CB_IDBANCO = CB_IDBANCO_
            _CB_IDPAIS = CB_IDPAIS_
            _CB_IDMONEDA = CB_IDMONEDA_
            _CB_USUARIO = CB_USUARIO_
            _CB_TERMINAL = CB_TERMINAL_
            _CB_FECREG = CB_FECREG_
        End Sub
        Public Sub New()
            _CB_FECREG = String.Empty
            _CB_TERMINAL = String.Empty
            _CB_USUARIO = String.Empty
            _CB_IDMONEDA = Nothing
            _CB_IDPAIS = Nothing
            _CB_IDBANCO = Nothing
            _CB_DES_CTA = String.Empty
            _CB_NUM_CTA = String.Empty
            _CB_SECUENCIA = 0
            _CB_IDANEXO = Nothing
        End Sub

        Public Property CB_IDANEXO() As SG_CO_TB_ANEXO
            Get
                Return _CB_IDANEXO
            End Get
            Set(ByVal value As SG_CO_TB_ANEXO)
                _CB_IDANEXO = value
            End Set
        End Property

        Public Property CB_SECUENCIA() As Integer
            Get
                Return _CB_SECUENCIA
            End Get
            Set(ByVal value As Integer)
                _CB_SECUENCIA = value
            End Set
        End Property

        Public Property CB_NUM_CTA() As String
            Get
                Return _CB_NUM_CTA
            End Get
            Set(ByVal value As String)
                _CB_NUM_CTA = value
            End Set
        End Property

        Public Property CB_DES_CTA() As String
            Get
                Return _CB_DES_CTA
            End Get
            Set(ByVal value As String)
                _CB_DES_CTA = value
            End Set
        End Property

        Public Property CB_IDBANCO() As SG_CO_TB_BANCO
            Get
                Return _CB_IDBANCO
            End Get
            Set(ByVal value As SG_CO_TB_BANCO)
                _CB_IDBANCO = value
            End Set
        End Property

        Public Property CB_IDPAIS() As SG_CO_TB_PAIS
            Get
                Return _CB_IDPAIS
            End Get
            Set(ByVal value As SG_CO_TB_PAIS)
                _CB_IDPAIS = value
            End Set
        End Property

        Public Property CB_IDMONEDA() As SG_CO_TB_MONEDA
            Get
                Return _CB_IDMONEDA
            End Get
            Set(ByVal value As SG_CO_TB_MONEDA)
                _CB_IDMONEDA = value
            End Set
        End Property

        Public Property CB_USUARIO() As String
            Get
                Return _CB_USUARIO
            End Get
            Set(ByVal value As String)
                _CB_USUARIO = value
            End Set
        End Property

        Public Property CB_TERMINAL() As String
            Get
                Return _CB_TERMINAL
            End Get
            Set(ByVal value As String)
                _CB_TERMINAL = value
            End Set
        End Property

        Public Property CB_FECREG() As String
            Get
                Return _CB_FECREG
            End Get
            Set(ByVal value As String)
                _CB_FECREG = value
            End Set
        End Property


    End Class
    Public Class SG_CO_TB_PROVEEDOR

        Private _PR_IDPROVEEDOR As SG_CO_TB_ANEXO
        Private _PR_RAZON_SOCIAL As String
        Private _PR_APE_PAT As String
        Private _PR_APE_MAT As String
        Private _PR_NOMBRES As String
        Private _PR_GIRO_NEGOCIO As String
        Private _PR_DIR_FISCAL As String
        Private _PR_DIR_LEGAL As String
        Private _PR_IDPAIS As SG_CO_TB_PAIS
        Private _PR_CITY As String
        Private _PR_CODIGO_POSTAL As String
        Private _PR_REFERENCIA As String
        Private _PR_TELEF As String
        Private _PR_TELEF2 As String
        Private _PR_MOVIL1 As String
        Private _PR_FAX1 As String
        Private _PR_FAX2 As String
        Private _PR_EMAIL As String
        Private _PR_WEBSITE As String
        Private _PR_CODIGO_INDUSTRIAL As String
        Private _PR_IDFORMA_PAGO As SG_CO_TB_FORMAPAGO
        Private _PR_REPRESENTANTE_LEGAL As String
        Private _PR_REPRESENTANTE_DNI As String
        Private _PR_DESCUENTO As Double
        Private _PR_ES_AGENTE_PERCEPCION As Integer
        Private _PR_ES_AGENTE_RETENCION As Integer
        Private _PR_ES_BUEN_CONTRIBUYENTE As Integer
        Private _PR_DIAS_CREDITO As Int32
        Private _PR_PC_USUARIO As String
        Private _PR_PC_TERMINAL As String
        Private _PR_PC_FECREG As String

        Public Sub New(ByVal PR_IDPROVEEDOR_ As SG_CO_TB_ANEXO, ByVal PR_RAZON_SOCIAL_ As String, ByVal PR_APE_PAT_ As String, ByVal PR_APE_MAT_ As String, ByVal PR_NOMBRES_ As String, ByVal PR_GIRO_NEGOCIO_ As String, ByVal PR_DIR_FISCAL_ As String, ByVal PR_DIR_LEGAL_ As String, ByVal PR_IDPAIS_ As SG_CO_TB_PAIS, ByVal PR_CITY_ As String, ByVal PR_CODIGO_POSTAL_ As String, ByVal PR_REFERENCIA_ As String, ByVal PR_TELEF_ As String, ByVal PR_TELEF2_ As String, ByVal PR_MOVIL1_ As String, ByVal PR_FAX1_ As String, ByVal PR_FAX2_ As String, ByVal PR_EMAIL_ As String, ByVal PR_WEBSITE_ As String, ByVal PR_CODIGO_INDUSTRIAL_ As String, ByVal PR_IDFORMA_PAGO_ As SG_CO_TB_FORMAPAGO, ByVal PR_REPRESENTANTE_LEGAL_ As String, ByVal PR_REPRESENTANTE_DNI_ As String, ByVal PR_DESCUENTO_ As Double, ByVal PR_ES_AGENTE_PERCEPCION_ As Integer, ByVal PR_ES_AGENTE_RETENCION_ As Integer, ByVal PR_ES_BUEN_CONTRIBUYENTE_ As Integer, ByVal PR_DIAS_CREDITO_ As Integer, ByVal PR_PC_USUARIO_ As String, ByVal PR_PC_TERMINAL_ As String, ByVal PR_PC_FECREG_ As String)
            _PR_PC_FECREG = PR_PC_FECREG_
            _PR_PC_TERMINAL = PR_PC_TERMINAL_
            _PR_PC_USUARIO = PR_PC_USUARIO_
            _PR_DIAS_CREDITO = PR_DIAS_CREDITO_
            _PR_ES_BUEN_CONTRIBUYENTE = PR_ES_BUEN_CONTRIBUYENTE_
            _PR_ES_AGENTE_RETENCION = PR_ES_AGENTE_RETENCION_
            _PR_ES_AGENTE_PERCEPCION = PR_ES_AGENTE_PERCEPCION_
            _PR_DESCUENTO = PR_DESCUENTO_
            _PR_REPRESENTANTE_DNI = PR_REPRESENTANTE_DNI_
            _PR_REPRESENTANTE_LEGAL = PR_REPRESENTANTE_LEGAL_
            _PR_IDFORMA_PAGO = PR_IDFORMA_PAGO_
            _PR_CODIGO_INDUSTRIAL = PR_CODIGO_INDUSTRIAL_
            _PR_WEBSITE = PR_WEBSITE_
            _PR_EMAIL = PR_EMAIL_
            _PR_FAX2 = PR_FAX2_
            _PR_FAX1 = PR_FAX1_
            _PR_MOVIL1 = PR_MOVIL1_
            _PR_TELEF2 = PR_TELEF2_
            _PR_TELEF = PR_TELEF_
            _PR_REFERENCIA = PR_REFERENCIA_
            _PR_CODIGO_POSTAL = PR_CODIGO_POSTAL_
            _PR_CITY = PR_CITY_
            _PR_IDPAIS = PR_IDPAIS_
            _PR_DIR_LEGAL = PR_DIR_LEGAL_
            _PR_DIR_FISCAL = PR_DIR_FISCAL_
            _PR_GIRO_NEGOCIO = PR_GIRO_NEGOCIO_
            _PR_NOMBRES = PR_NOMBRES_
            _PR_APE_MAT = PR_APE_MAT_
            _PR_APE_PAT = PR_APE_PAT_
            _PR_RAZON_SOCIAL = PR_RAZON_SOCIAL_
            _PR_IDPROVEEDOR = PR_IDPROVEEDOR_
        End Sub
        Public Sub New()
            _PR_PC_FECREG = String.Empty
            _PR_PC_TERMINAL = String.Empty
            _PR_PC_USUARIO = String.Empty
            _PR_DIAS_CREDITO = 0
            _PR_ES_BUEN_CONTRIBUYENTE = 0
            _PR_ES_AGENTE_RETENCION = 0
            _PR_ES_AGENTE_PERCEPCION = 0
            _PR_DESCUENTO = 0.0R
            _PR_REPRESENTANTE_DNI = String.Empty
            _PR_REPRESENTANTE_LEGAL = String.Empty
            _PR_IDFORMA_PAGO = Nothing
            _PR_CODIGO_INDUSTRIAL = String.Empty
            _PR_WEBSITE = String.Empty
            _PR_EMAIL = String.Empty
            _PR_FAX2 = String.Empty
            _PR_FAX1 = String.Empty
            _PR_MOVIL1 = String.Empty
            _PR_TELEF2 = String.Empty
            _PR_TELEF = String.Empty
            _PR_REFERENCIA = String.Empty
            _PR_CODIGO_POSTAL = String.Empty
            _PR_CITY = String.Empty
            _PR_IDPAIS = Nothing
            _PR_DIR_LEGAL = String.Empty
            _PR_DIR_FISCAL = String.Empty
            _PR_GIRO_NEGOCIO = String.Empty
            _PR_NOMBRES = String.Empty
            _PR_APE_MAT = String.Empty
            _PR_APE_PAT = String.Empty
            _PR_RAZON_SOCIAL = String.Empty
            _PR_IDPROVEEDOR = Nothing

        End Sub

        Public Property PR_IDPROVEEDOR() As SG_CO_TB_ANEXO
            Get
                Return _PR_IDPROVEEDOR
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _PR_IDPROVEEDOR = value
            End Set
        End Property

        Public Property PR_RAZON_SOCIAL() As String
            Get
                Return _PR_RAZON_SOCIAL
            End Get

            Set(ByVal value As String)
                _PR_RAZON_SOCIAL = value
            End Set
        End Property

        Public Property PR_APE_PAT() As String
            Get
                Return _PR_APE_PAT
            End Get

            Set(ByVal value As String)
                _PR_APE_PAT = value
            End Set
        End Property

        Public Property PR_APE_MAT() As String
            Get
                Return _PR_APE_MAT
            End Get

            Set(ByVal value As String)
                _PR_APE_MAT = value
            End Set
        End Property

        Public Property PR_NOMBRES() As String
            Get
                Return _PR_NOMBRES
            End Get

            Set(ByVal value As String)
                _PR_NOMBRES = value
            End Set
        End Property

        Public Property PR_GIRO_NEGOCIO() As String
            Get
                Return _PR_GIRO_NEGOCIO
            End Get

            Set(ByVal value As String)
                _PR_GIRO_NEGOCIO = value
            End Set
        End Property

        Public Property PR_DIR_FISCAL() As String
            Get
                Return _PR_DIR_FISCAL
            End Get

            Set(ByVal value As String)
                _PR_DIR_FISCAL = value
            End Set
        End Property

        Public Property PR_DIR_LEGAL() As String
            Get
                Return _PR_DIR_LEGAL
            End Get

            Set(ByVal value As String)
                _PR_DIR_LEGAL = value
            End Set
        End Property

        Public Property PR_IDPAIS() As SG_CO_TB_PAIS
            Get
                Return _PR_IDPAIS
            End Get

            Set(ByVal value As SG_CO_TB_PAIS)
                _PR_IDPAIS = value
            End Set
        End Property

        Public Property PR_CITY() As String
            Get
                Return _PR_CITY
            End Get

            Set(ByVal value As String)
                _PR_CITY = value
            End Set
        End Property

        Public Property PR_CODIGO_POSTAL() As String
            Get
                Return _PR_CODIGO_POSTAL
            End Get

            Set(ByVal value As String)
                _PR_CODIGO_POSTAL = value
            End Set
        End Property

        Public Property PR_REFERENCIA() As String
            Get
                Return _PR_REFERENCIA
            End Get

            Set(ByVal value As String)
                _PR_REFERENCIA = value
            End Set
        End Property

        Public Property PR_TELEF() As String
            Get
                Return _PR_TELEF
            End Get

            Set(ByVal value As String)
                _PR_TELEF = value
            End Set
        End Property

        Public Property PR_TELEF2() As String
            Get
                Return _PR_TELEF2
            End Get

            Set(ByVal value As String)
                _PR_TELEF2 = value
            End Set
        End Property

        Public Property PR_MOVIL1() As String
            Get
                Return _PR_MOVIL1
            End Get

            Set(ByVal value As String)
                _PR_MOVIL1 = value
            End Set
        End Property

        Public Property PR_FAX1() As String
            Get
                Return _PR_FAX1
            End Get

            Set(ByVal value As String)
                _PR_FAX1 = value
            End Set
        End Property

        Public Property PR_FAX2() As String
            Get
                Return _PR_FAX2
            End Get

            Set(ByVal value As String)
                _PR_FAX2 = value
            End Set
        End Property

        Public Property PR_EMAIL() As String
            Get
                Return _PR_EMAIL
            End Get

            Set(ByVal value As String)
                _PR_EMAIL = value
            End Set
        End Property

        Public Property PR_WEBSITE() As String
            Get
                Return _PR_WEBSITE
            End Get

            Set(ByVal value As String)
                _PR_WEBSITE = value
            End Set
        End Property

        Public Property PR_CODIGO_INDUSTRIAL() As String
            Get
                Return _PR_CODIGO_INDUSTRIAL
            End Get

            Set(ByVal value As String)
                _PR_CODIGO_INDUSTRIAL = value
            End Set
        End Property

        Public Property PR_IDFORMA_PAGO() As SG_CO_TB_FORMAPAGO
            Get
                Return _PR_IDFORMA_PAGO
            End Get

            Set(ByVal value As SG_CO_TB_FORMAPAGO)
                _PR_IDFORMA_PAGO = value
            End Set
        End Property

        Public Property PR_REPRESENTANTE_LEGAL() As String
            Get
                Return _PR_REPRESENTANTE_LEGAL
            End Get

            Set(ByVal value As String)
                _PR_REPRESENTANTE_LEGAL = value
            End Set
        End Property

        Public Property PR_REPRESENTANTE_DNI() As String
            Get
                Return _PR_REPRESENTANTE_DNI
            End Get

            Set(ByVal value As String)
                _PR_REPRESENTANTE_DNI = value
            End Set
        End Property

        Public Property PR_DESCUENTO() As Double
            Get
                Return _PR_DESCUENTO
            End Get

            Set(ByVal value As Double)
                _PR_DESCUENTO = value
            End Set
        End Property

        Public Property PR_ES_AGENTE_PERCEPCION() As Integer
            Get
                Return _PR_ES_AGENTE_PERCEPCION
            End Get

            Set(ByVal value As Integer)
                _PR_ES_AGENTE_PERCEPCION = value
            End Set
        End Property

        Public Property PR_ES_AGENTE_RETENCION() As Integer
            Get
                Return _PR_ES_AGENTE_RETENCION
            End Get

            Set(ByVal value As Integer)
                _PR_ES_AGENTE_RETENCION = value
            End Set
        End Property

        Public Property PR_ES_BUEN_CONTRIBUYENTE() As Integer
            Get
                Return _PR_ES_BUEN_CONTRIBUYENTE
            End Get

            Set(ByVal value As Integer)
                _PR_ES_BUEN_CONTRIBUYENTE = value
            End Set
        End Property

        Public Property PR_DIAS_CREDITO() As Integer
            Get
                Return _PR_DIAS_CREDITO
            End Get

            Set(ByVal value As Integer)
                _PR_DIAS_CREDITO = value
            End Set
        End Property

        Public Property PR_PC_USUARIO() As String
            Get
                Return _PR_PC_USUARIO
            End Get

            Set(ByVal value As String)
                _PR_PC_USUARIO = value
            End Set
        End Property

        Public Property PR_PC_TERMINAL() As String
            Get
                Return _PR_PC_TERMINAL
            End Get

            Set(ByVal value As String)
                _PR_PC_TERMINAL = value
            End Set
        End Property

        Public Property PR_PC_FECREG() As String
            Get
                Return _PR_PC_FECREG
            End Get

            Set(ByVal value As String)
                _PR_PC_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_CLIENTES

        Private _CL_IDCLIENTE As SG_CO_TB_ANEXO
        Private _CL_APE_PAT As String
        Private _CL_APE_MAT As String
        Private _CL_NOMBRES As String
        Private _CL_RAZON_SOCIAL As String
        Private _CL_GIRO_NEGOCIO As SG_CO_TB_GIRONEGOCIO
        Private _CL_DIR_FISCAL As String
        Private _CL_DIR_LEGAL As String
        Private _CL_IDPAIS As SG_CO_TB_PAIS
        Private _CL_CODIGO_POSTAL As String
        Private _CL_CIUDAD As String
        Private _CL_REFERENCIA As String
        Private _CL_TELEF1 As String
        Private _CL_TELEF2 As String
        Private _CL_MOVIL1 As String
        Private _CL_MOVIL2 As String
        Private _CL_FAX1 As String
        Private _CL_FAX2 As String
        Private _CL_EMAIL As String
        Private _CL_WEBSITE As String
        Private _CL_CODIGO_INDUSTRIAL As String
        Private _CL_FORMA_COBRO As SG_CO_TB_FORMACOBRANZA
        Private _CL_IDMONEDA As SG_CO_TB_MONEDA
        Private _CL_FORMA_ENVIO As SG_CO_TB_FORMAENVIO
        Private _CL_FORMA_DESPACHO As SG_CO_TB_FORMADESPACHO
        Private _CL_REPRESENTANTE_LEGAL As String
        Private _CL_REPRESENTANTE_LEGAL_DOC As String
        Private _CL_AGENTE_PERCEPCION As Int32
        Private _CL_AGENTE_RETENCION As Int32
        Private _CL_BUENOS_CONTRIBUYENTES As Int32
        Private _CL_IDVENDEDOR As SG_CO_TB_VENDEDOR
        Private _CL_IDCOBRADOR As SG_CO_TB_COBRADOR
        Private _CL_ES_PRINCIPAL As Int32
        Private _CL_DESCUENTO As Double
        Private _CL_USUARIO As String
        Private _CL_TERMINAL As String
        Private _CL_FECREG As String


        Public Sub New()
            _CL_IDCLIENTE = Nothing
            _CL_APE_PAT = String.Empty
            _CL_APE_MAT = String.Empty
            _CL_NOMBRES = String.Empty
            _CL_RAZON_SOCIAL = String.Empty
            _CL_GIRO_NEGOCIO = Nothing
            _CL_DIR_FISCAL = String.Empty
            _CL_DIR_LEGAL = String.Empty
            _CL_IDPAIS = Nothing
            _CL_CODIGO_POSTAL = String.Empty
            _CL_CIUDAD = String.Empty
            _CL_REFERENCIA = String.Empty
            _CL_TELEF1 = String.Empty
            _CL_TELEF2 = String.Empty
            _CL_MOVIL1 = String.Empty
            _CL_MOVIL2 = String.Empty
            _CL_FAX1 = String.Empty
            _CL_FAX2 = String.Empty
            _CL_EMAIL = String.Empty
            _CL_WEBSITE = String.Empty
            _CL_CODIGO_INDUSTRIAL = String.Empty
            _CL_FORMA_COBRO = Nothing
            _CL_IDMONEDA = Nothing
            _CL_FORMA_ENVIO = Nothing
            _CL_FORMA_DESPACHO = Nothing
            _CL_REPRESENTANTE_LEGAL = String.Empty
            _CL_REPRESENTANTE_LEGAL_DOC = Nothing
            _CL_AGENTE_PERCEPCION = 0
            _CL_AGENTE_RETENCION = 0
            _CL_BUENOS_CONTRIBUYENTES = 0
            _CL_IDVENDEDOR = Nothing
            _CL_IDCOBRADOR = Nothing
            _CL_ES_PRINCIPAL = 0
            _CL_DESCUENTO = 0.0R
            _CL_USUARIO = String.Empty
            _CL_TERMINAL = String.Empty
            _CL_FECREG = String.Empty
        End Sub
        Public Sub New(ByVal CL_IDCLIENTE_ As SG_CO_TB_ANEXO, ByVal CL_APE_PAT_ As String, ByVal CL_APE_MAT_ As String, ByVal CL_NOMBRES_ As String, ByVal CL_RAZON_SOCIAL_ As String, ByVal CL_GIRO_NEGOCIO_ As SG_CO_TB_GIRONEGOCIO, ByVal CL_DIR_FISCAL_ As String, ByVal CL_DIR_LEGAL_ As String, ByVal CL_IDPAIS_ As SG_CO_TB_PAIS, ByVal CL_CODIGO_POSTAL_ As String, ByVal CL_CIUDAD_ As String, ByVal CL_REFERENCIA_ As String, ByVal CL_TELEF1_ As String, ByVal CL_TELEF2_ As String, ByVal CL_MOVIL1_ As String, ByVal CL_MOVIL2_ As String, ByVal CL_FAX1_ As String, ByVal CL_FAX2_ As String, ByVal CL_EMAIL_ As String, ByVal CL_WEBSITE_ As String, ByVal CL_CODIGO_INDUSTRIAL_ As String, ByVal CL_FORMA_COBRO_ As SG_CO_TB_FORMACOBRANZA, ByVal CL_IDMONEDA_ As SG_CO_TB_MONEDA, ByVal CL_FORMA_ENVIO_ As SG_CO_TB_FORMAENVIO, ByVal CL_FORMA_DESPACHO_ As SG_CO_TB_FORMADESPACHO, ByVal CL_REPRESENTANTE_LEGAL_ As String, ByVal CL_REPRESENTANTE_LEGAL_DOC_ As String, ByVal CL_AGENTE_PERCEPCION_ As Int32, ByVal CL_AGENTE_RETENCION_ As Int32, ByVal CL_BUENOS_CONTRIBUYENTES_ As Int32, ByVal CL_IDVENDEDOR_ As SG_CO_TB_VENDEDOR, ByVal CL_IDCOBRADOR_ As SG_CO_TB_COBRADOR, ByVal CL_ES_PRINCIPAL_ As Int32, ByVal CL_DESCUENTO_ As Double, ByVal CL_USUARIO_ As String, ByVal CL_TERMINAL_ As String, ByVal CL_FECREG_ As String)
            _CL_IDCLIENTE = CL_IDCLIENTE_
            _CL_APE_PAT = CL_APE_PAT_
            _CL_APE_MAT = CL_APE_MAT_
            _CL_NOMBRES = CL_NOMBRES_
            _CL_RAZON_SOCIAL = CL_RAZON_SOCIAL_
            _CL_GIRO_NEGOCIO = CL_GIRO_NEGOCIO_
            _CL_DIR_FISCAL = CL_DIR_FISCAL_
            _CL_DIR_LEGAL = CL_DIR_LEGAL_
            _CL_IDPAIS = CL_IDPAIS_
            _CL_CODIGO_POSTAL = CL_CODIGO_POSTAL_
            _CL_CIUDAD = CL_CIUDAD_
            _CL_REFERENCIA = CL_REFERENCIA_
            _CL_TELEF1 = CL_TELEF1_
            _CL_TELEF2 = CL_TELEF2_
            _CL_MOVIL1 = CL_MOVIL1_
            _CL_MOVIL2 = CL_MOVIL2_
            _CL_FAX1 = CL_FAX1_
            _CL_FAX2 = CL_FAX2_
            _CL_EMAIL = CL_EMAIL_
            _CL_WEBSITE = CL_WEBSITE_
            _CL_CODIGO_INDUSTRIAL = CL_CODIGO_INDUSTRIAL_
            _CL_FORMA_COBRO = CL_FORMA_COBRO_
            _CL_IDMONEDA = CL_IDMONEDA_
            _CL_FORMA_ENVIO = CL_FORMA_ENVIO_
            _CL_FORMA_DESPACHO = CL_FORMA_DESPACHO_
            _CL_REPRESENTANTE_LEGAL = CL_REPRESENTANTE_LEGAL_
            _CL_REPRESENTANTE_LEGAL_DOC = CL_REPRESENTANTE_LEGAL_DOC_
            _CL_AGENTE_PERCEPCION = CL_AGENTE_PERCEPCION_
            _CL_AGENTE_RETENCION = CL_AGENTE_RETENCION_
            _CL_BUENOS_CONTRIBUYENTES = CL_BUENOS_CONTRIBUYENTES_
            _CL_IDVENDEDOR = CL_IDVENDEDOR_
            _CL_IDCOBRADOR = CL_IDCOBRADOR_
            _CL_ES_PRINCIPAL = CL_ES_PRINCIPAL_
            _CL_DESCUENTO = CL_DESCUENTO_
            _CL_USUARIO = CL_USUARIO_
            _CL_TERMINAL = CL_TERMINAL_
            _CL_FECREG = CL_FECREG_

        End Sub

        Public Property CL_IDCLIENTE() As SG_CO_TB_ANEXO
            Get
                Return _CL_IDCLIENTE
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _CL_IDCLIENTE = value
            End Set
        End Property

        Public Property CL_APE_PAT() As String
            Get
                Return _CL_APE_PAT
            End Get

            Set(ByVal value As String)
                _CL_APE_PAT = value
            End Set
        End Property

        Public Property CL_APE_MAT() As String
            Get
                Return _CL_APE_MAT
            End Get

            Set(ByVal value As String)
                _CL_APE_MAT = value
            End Set
        End Property

        Public Property CL_NOMBRES() As String
            Get
                Return _CL_NOMBRES
            End Get

            Set(ByVal value As String)
                _CL_NOMBRES = value
            End Set
        End Property

        Public Property CL_RAZON_SOCIAL() As String
            Get
                Return _CL_RAZON_SOCIAL
            End Get

            Set(ByVal value As String)
                _CL_RAZON_SOCIAL = value
            End Set
        End Property

        Public Property CL_GIRO_NEGOCIO() As SG_CO_TB_GIRONEGOCIO
            Get
                Return _CL_GIRO_NEGOCIO
            End Get

            Set(ByVal value As SG_CO_TB_GIRONEGOCIO)
                _CL_GIRO_NEGOCIO = value
            End Set
        End Property

        Public Property CL_DIR_FISCAL() As String
            Get
                Return _CL_DIR_FISCAL
            End Get

            Set(ByVal value As String)
                _CL_DIR_FISCAL = value
            End Set
        End Property

        Public Property CL_DIR_LEGAL() As String
            Get
                Return _CL_DIR_LEGAL
            End Get

            Set(ByVal value As String)
                _CL_DIR_LEGAL = value
            End Set
        End Property

        Public Property CL_IDPAIS() As SG_CO_TB_PAIS
            Get
                Return _CL_IDPAIS
            End Get

            Set(ByVal value As SG_CO_TB_PAIS)
                _CL_IDPAIS = value
            End Set
        End Property

        Public Property CL_CODIGO_POSTAL() As String
            Get
                Return _CL_CODIGO_POSTAL
            End Get

            Set(ByVal value As String)
                _CL_CODIGO_POSTAL = value
            End Set
        End Property

        Public Property CL_CIUDAD() As String
            Get
                Return _CL_CIUDAD
            End Get

            Set(ByVal value As String)
                _CL_CIUDAD = value
            End Set
        End Property

        Public Property CL_REFERENCIA() As String
            Get
                Return _CL_REFERENCIA
            End Get

            Set(ByVal value As String)
                _CL_REFERENCIA = value
            End Set
        End Property

        Public Property CL_TELEF1() As String
            Get
                Return _CL_TELEF1
            End Get

            Set(ByVal value As String)
                _CL_TELEF1 = value
            End Set
        End Property

        Public Property CL_TELEF2() As String
            Get
                Return _CL_TELEF2
            End Get

            Set(ByVal value As String)
                _CL_TELEF2 = value
            End Set
        End Property

        Public Property CL_MOVIL1() As String
            Get
                Return _CL_MOVIL1
            End Get

            Set(ByVal value As String)
                _CL_MOVIL1 = value
            End Set
        End Property

        Public Property CL_MOVIL2() As String
            Get
                Return _CL_MOVIL2
            End Get

            Set(ByVal value As String)
                _CL_MOVIL2 = value
            End Set
        End Property

        Public Property CL_FAX1() As String
            Get
                Return _CL_FAX1
            End Get

            Set(ByVal value As String)
                _CL_FAX1 = value
            End Set
        End Property

        Public Property CL_FAX2() As String
            Get
                Return _CL_FAX2
            End Get

            Set(ByVal value As String)
                _CL_FAX2 = value
            End Set
        End Property

        Public Property CL_EMAIL() As String
            Get
                Return _CL_EMAIL
            End Get

            Set(ByVal value As String)
                _CL_EMAIL = value
            End Set
        End Property

        Public Property CL_WEBSITE() As String
            Get
                Return _CL_WEBSITE
            End Get

            Set(ByVal value As String)
                _CL_WEBSITE = value
            End Set
        End Property

        Public Property CL_CODIGO_INDUSTRIAL() As String
            Get
                Return _CL_CODIGO_INDUSTRIAL
            End Get

            Set(ByVal value As String)
                _CL_CODIGO_INDUSTRIAL = value
            End Set
        End Property

        Public Property CL_FORMA_COBRO() As SG_CO_TB_FORMACOBRANZA
            Get
                Return _CL_FORMA_COBRO
            End Get

            Set(ByVal value As SG_CO_TB_FORMACOBRANZA)
                _CL_FORMA_COBRO = value
            End Set
        End Property

        Public Property CL_IDMONEDA() As SG_CO_TB_MONEDA
            Get
                Return _CL_IDMONEDA
            End Get

            Set(ByVal value As SG_CO_TB_MONEDA)
                _CL_IDMONEDA = value
            End Set
        End Property

        Public Property CL_FORMA_ENVIO() As SG_CO_TB_FORMAENVIO
            Get
                Return _CL_FORMA_ENVIO
            End Get

            Set(ByVal value As SG_CO_TB_FORMAENVIO)
                _CL_FORMA_ENVIO = value
            End Set
        End Property

        Public Property CL_FORMA_DESPACHO() As SG_CO_TB_FORMADESPACHO
            Get
                Return _CL_FORMA_DESPACHO
            End Get

            Set(ByVal value As SG_CO_TB_FORMADESPACHO)
                _CL_FORMA_DESPACHO = value
            End Set
        End Property

        Public Property CL_REPRESENTANTE_LEGAL() As String
            Get
                Return _CL_REPRESENTANTE_LEGAL
            End Get

            Set(ByVal value As String)
                _CL_REPRESENTANTE_LEGAL = value
            End Set
        End Property

        Public Property CL_REPRESENTANTE_LEGAL_DOC() As String
            Get
                Return _CL_REPRESENTANTE_LEGAL_DOC
            End Get
            Set(ByVal value As String)
                _CL_REPRESENTANTE_LEGAL_DOC = value
            End Set
        End Property

        Public Property CL_AGENTE_PERCEPCION() As Int32
            Get
                Return _CL_AGENTE_PERCEPCION
            End Get

            Set(ByVal value As Int32)
                _CL_AGENTE_PERCEPCION = value
            End Set
        End Property

        Public Property CL_AGENTE_RETENCION() As Int32
            Get
                Return _CL_AGENTE_RETENCION
            End Get

            Set(ByVal value As Int32)
                _CL_AGENTE_RETENCION = value
            End Set
        End Property

        Public Property CL_BUENOS_CONTRIBUYENTES() As Int32
            Get
                Return _CL_BUENOS_CONTRIBUYENTES
            End Get

            Set(ByVal value As Int32)
                _CL_BUENOS_CONTRIBUYENTES = value
            End Set
        End Property

        Public Property CL_IDVENDEDOR() As SG_CO_TB_VENDEDOR
            Get
                Return _CL_IDVENDEDOR
            End Get

            Set(ByVal value As SG_CO_TB_VENDEDOR)
                _CL_IDVENDEDOR = value
            End Set
        End Property

        Public Property CL_IDCOBRADOR() As SG_CO_TB_COBRADOR
            Get
                Return _CL_IDCOBRADOR
            End Get

            Set(ByVal value As SG_CO_TB_COBRADOR)
                _CL_IDCOBRADOR = value
            End Set
        End Property

        Public Property CL_ES_PRINCIPAL() As Int32
            Get
                Return _CL_ES_PRINCIPAL
            End Get

            Set(ByVal value As Int32)
                _CL_ES_PRINCIPAL = value
            End Set
        End Property

        Public Property CL_DESCUENTO() As Double
            Get
                Return _CL_DESCUENTO
            End Get

            Set(ByVal value As Double)
                _CL_DESCUENTO = value
            End Set
        End Property

        Public Property CL_USUARIO() As String
            Get
                Return _CL_USUARIO
            End Get

            Set(ByVal value As String)
                _CL_USUARIO = value
            End Set
        End Property

        Public Property CL_TERMINAL() As String
            Get
                Return _CL_TERMINAL
            End Get

            Set(ByVal value As String)
                _CL_TERMINAL = value
            End Set
        End Property

        Public Property CL_FECREG() As String
            Get
                Return _CL_FECREG
            End Get

            Set(ByVal value As String)
                _CL_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_HONORARIO_PROFE

        Private _HP_IDHONORARIO As SG_CO_TB_ANEXO
        Private _HP_PRI_NOM As String
        Private _HP_SEC_NOM As String
        Private _HP_NOMBRE As String
        Private _HP_DIR As String
        Private _HP_IDPAIS As SG_CO_TB_PAIS
        Private _HP_CIUDAD As String
        Private _HP_TELF_FIJO As String
        Private _HP_TELF_MOVIL As String
        Private _HP_EMAIL As String
        Private _HP_PROFESION As String
        Private _HP_IDCUENTA As SG_CO_TB_PLANCTAS
        Private _HP_ES_AFECTO_RENTA As Int32
        Private _HP_USUARIO As String
        Private _HP_TERMINAL As String
        Private _HP_FECREG As String

        Public Sub New(ByVal HP_IDHONORARIO_ As SG_CO_TB_ANEXO, ByVal HP_PRI_NOM_ As String, ByVal HP_SEC_NOM_ As String, ByVal HP_NOMBRE_ As String, ByVal HP_DIR_ As String, ByVal HP_IDPAIS_ As SG_CO_TB_PAIS, ByVal HP_CIUDAD_ As String, ByVal HP_TELF_FIJO_ As String, ByVal HP_TELF_MOVIL_ As String, ByVal HP_EMAIL_ As String, ByVal HP_PROFESION_ As String, ByVal HP_IDCUENTA_ As SG_CO_TB_PLANCTAS, ByVal HP_ES_AFECTO_RENTA_ As Int32, ByVal HP_USUARIO_ As String, ByVal HP_TERMINAL_ As String, ByVal HP_FECREG_ As String)
            _HP_IDHONORARIO = HP_IDHONORARIO_
            _HP_PRI_NOM = HP_PRI_NOM_
            _HP_SEC_NOM = HP_SEC_NOM_
            _HP_NOMBRE = HP_NOMBRE_
            _HP_DIR = HP_DIR_
            _HP_IDPAIS = HP_IDPAIS_
            _HP_CIUDAD = HP_CIUDAD_
            _HP_TELF_FIJO = HP_TELF_FIJO_
            _HP_TELF_MOVIL = HP_TELF_MOVIL_
            _HP_EMAIL = HP_EMAIL_
            _HP_PROFESION = HP_PROFESION_
            _HP_IDCUENTA = HP_IDCUENTA_
            _HP_ES_AFECTO_RENTA = HP_ES_AFECTO_RENTA_
            _HP_USUARIO = HP_USUARIO_
            _HP_TERMINAL = HP_TERMINAL_
            _HP_FECREG = HP_FECREG_
        End Sub
        Public Sub New()
            _HP_IDHONORARIO = Nothing
            _HP_PRI_NOM = String.Empty
            _HP_SEC_NOM = String.Empty
            _HP_NOMBRE = String.Empty
            _HP_DIR = String.Empty
            _HP_IDPAIS = Nothing
            _HP_CIUDAD = String.Empty
            _HP_TELF_FIJO = String.Empty
            _HP_TELF_MOVIL = String.Empty
            _HP_EMAIL = String.Empty
            _HP_PROFESION = String.Empty
            _HP_IDCUENTA = Nothing
            _HP_ES_AFECTO_RENTA = 0
            _HP_USUARIO = String.Empty
            _HP_TERMINAL = String.Empty
            _HP_FECREG = String.Empty
        End Sub

        Public Property HP_IDHONORARIO() As SG_CO_TB_ANEXO
            Get
                Return _HP_IDHONORARIO
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _HP_IDHONORARIO = value
            End Set
        End Property

        Public Property HP_PRI_NOM() As String
            Get
                Return _HP_PRI_NOM
            End Get

            Set(ByVal value As String)
                _HP_PRI_NOM = value
            End Set
        End Property

        Public Property HP_SEC_NOM() As String
            Get
                Return _HP_SEC_NOM
            End Get

            Set(ByVal value As String)
                _HP_SEC_NOM = value
            End Set
        End Property

        Public Property HP_NOMBRE() As String
            Get
                Return _HP_NOMBRE
            End Get

            Set(ByVal value As String)
                _HP_NOMBRE = value
            End Set
        End Property

        Public Property HP_DIR() As String
            Get
                Return _HP_DIR
            End Get

            Set(ByVal value As String)
                _HP_DIR = value
            End Set
        End Property

        Public Property HP_IDPAIS() As SG_CO_TB_PAIS
            Get
                Return _HP_IDPAIS
            End Get

            Set(ByVal value As SG_CO_TB_PAIS)
                _HP_IDPAIS = value
            End Set
        End Property

        Public Property HP_CIUDAD() As String
            Get
                Return _HP_CIUDAD
            End Get

            Set(ByVal value As String)
                _HP_CIUDAD = value
            End Set
        End Property

        Public Property HP_TELF_FIJO() As String
            Get
                Return _HP_TELF_FIJO
            End Get

            Set(ByVal value As String)
                _HP_TELF_FIJO = value
            End Set
        End Property

        Public Property HP_TELF_MOVIL() As String
            Get
                Return _HP_TELF_MOVIL
            End Get

            Set(ByVal value As String)
                _HP_TELF_MOVIL = value
            End Set
        End Property

        Public Property HP_EMAIL() As String
            Get
                Return _HP_EMAIL
            End Get

            Set(ByVal value As String)
                _HP_EMAIL = value
            End Set
        End Property

        Public Property HP_PROFESION() As String
            Get
                Return _HP_PROFESION
            End Get

            Set(ByVal value As String)
                _HP_PROFESION = value
            End Set
        End Property

        Public Property HP_IDCUENTA() As SG_CO_TB_PLANCTAS
            Get
                Return _HP_IDCUENTA
            End Get

            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _HP_IDCUENTA = value
            End Set
        End Property

        Public Property HP_ES_AFECTO_RENTA() As Int32
            Get
                Return _HP_ES_AFECTO_RENTA
            End Get

            Set(ByVal value As Int32)
                _HP_ES_AFECTO_RENTA = value
            End Set
        End Property

        Public Property HP_USUARIO() As String
            Get
                Return _HP_USUARIO
            End Get

            Set(ByVal value As String)
                _HP_USUARIO = value
            End Set
        End Property

        Public Property HP_TERMINAL() As String
            Get
                Return _HP_TERMINAL
            End Get

            Set(ByVal value As String)
                _HP_TERMINAL = value
            End Set
        End Property

        Public Property HP_FECREG() As String
            Get
                Return _HP_FECREG
            End Get
            Set(ByVal value As String)
                _HP_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_PERSONAL

        Private _PE_IDPERSONAL As SG_CO_TB_ANEXO
        Private _PE_APE_PAT As String
        Private _PE_APE_MAT As String
        Private _PE_PRI_NOMBRE As String
        Private _PE_SEG_NOMBRE As String
        Private _PE_ISTATUS As Int32
        Private _PE_USUARIO As String
        Private _PE_TERMINAL As String
        Private _PE_FECREG As String


        Public Sub New(ByVal PE_IDPERSONAL_ As SG_CO_TB_ANEXO, ByVal PE_APE_PAT_ As String, ByVal PE_APE_MAT_ As String, ByVal PE_PRI_NOMBRE_ As String, ByVal PE_SEG_NOMBRE_ As String, ByVal PE_ISTATUS_ As Int32, ByVal PE_USUARIO_ As String, ByVal PE_TERMINAL_ As String, ByVal PE_FECREG_ As String)
            _PE_IDPERSONAL = PE_IDPERSONAL_
            _PE_APE_PAT = PE_APE_PAT_
            _PE_APE_MAT = PE_APE_MAT_
            _PE_PRI_NOMBRE = PE_PRI_NOMBRE_
            _PE_SEG_NOMBRE = PE_SEG_NOMBRE_
            _PE_ISTATUS = PE_ISTATUS_
            _PE_USUARIO = PE_USUARIO_
            _PE_TERMINAL = PE_TERMINAL_
            _PE_FECREG = PE_FECREG_
        End Sub
        Public Sub New()
            _PE_IDPERSONAL = Nothing
            _PE_APE_PAT = String.Empty
            _PE_APE_MAT = String.Empty
            _PE_PRI_NOMBRE = String.Empty
            _PE_SEG_NOMBRE = String.Empty
            _PE_ISTATUS = 0
            _PE_USUARIO = String.Empty
            _PE_TERMINAL = String.Empty
            _PE_FECREG = String.Empty
        End Sub

        Public Property PE_IDPERSONAL() As SG_CO_TB_ANEXO
            Get
                Return _PE_IDPERSONAL
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _PE_IDPERSONAL = value
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

        Public Property PE_PRI_NOMBRE() As String
            Get
                Return _PE_PRI_NOMBRE
            End Get

            Set(ByVal value As String)
                _PE_PRI_NOMBRE = value
            End Set
        End Property

        Public Property PE_SEG_NOMBRE() As String
            Get
                Return _PE_SEG_NOMBRE
            End Get

            Set(ByVal value As String)
                _PE_SEG_NOMBRE = value
            End Set
        End Property

        Public Property PE_ISTATUS() As Int32
            Get
                Return _PE_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _PE_ISTATUS = value
            End Set
        End Property

        Public Property pe_USUARIO() As String
            Get
                Return _PE_USUARIO
            End Get

            Set(ByVal value As String)
                _PE_USUARIO = value
            End Set
        End Property

        Public Property pe_TERMINAL() As String
            Get
                Return _PE_TERMINAL
            End Get

            Set(ByVal value As String)
                _PE_TERMINAL = value
            End Set
        End Property

        Public Property pe_FECREG() As DateTime
            Get
                Return _PE_FECREG
            End Get

            Set(ByVal value As DateTime)
                _PE_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_ANEXO
        Private _AN_IDANEXO As Integer
        Private _AN_TIPO_ANEXO As SG_CO_TB_TIPOANEXO
        Private _AN_TIPO_EMPRESA As SG_CO_TB_TIPOEMPRESA
        Private _AN_TIPO_DOC As SG_CO_TB_TIPO_DOC_IDENTIDAD
        Private _AN_NUM_DOC As String
        Private _AN_DESCRIPCION As String
        Private _AN_PC_USUARIO As String
        Private _AN_PC_TERMINAL As String
        Private _AN_PC_FECREG As String
        Private _AN_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _AN_ES_RELACIONADO As Integer
        Private _AN_ES_NO_DOMI As Integer

        Public Sub New(ByVal AN_IDANEXO_ As Integer, ByVal AN_TIPO_ANEXO_ As SG_CO_TB_TIPOANEXO, ByVal AN_TIPO_EMPRESA_ As SG_CO_TB_TIPOEMPRESA, ByVal AN_TIPO_DOC_ As SG_CO_TB_TIPO_DOC_IDENTIDAD, ByVal AN_NUM_DOC_ As String, ByVal AN_DESCRIPCION_ As String, ByVal AN_PC_USUARIO_ As String, ByVal AN_PC_TERMINAL_ As String, ByVal AN_PC_FECREG_ As String, ByVal AN_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal AN_ES_RELACIONADO_ As Integer, ByVal AN_ES_NO_DOMI_ As Integer)
            _AN_ES_NO_DOMI = AN_ES_NO_DOMI_
            _AN_IDANEXO = AN_IDANEXO_
            _AN_TIPO_ANEXO = AN_TIPO_ANEXO_
            _AN_TIPO_EMPRESA = AN_TIPO_EMPRESA_
            _AN_TIPO_DOC = AN_TIPO_DOC_
            _AN_NUM_DOC = AN_NUM_DOC_
            _AN_DESCRIPCION = AN_DESCRIPCION_
            _AN_PC_USUARIO = AN_PC_USUARIO_
            _AN_PC_TERMINAL = AN_PC_TERMINAL_
            _AN_PC_FECREG = AN_PC_FECREG_
            _AN_IDEMPRESA = AN_IDEMPRESA_

        End Sub
        Public Sub New()
            _AN_IDEMPRESA = Nothing
            _AN_PC_FECREG = String.Empty
            _AN_PC_TERMINAL = String.Empty
            _AN_PC_USUARIO = String.Empty
            _AN_DESCRIPCION = String.Empty
            _AN_NUM_DOC = String.Empty
            _AN_TIPO_DOC = Nothing
            _AN_TIPO_EMPRESA = Nothing
            _AN_TIPO_ANEXO = Nothing
            _AN_IDANEXO = 0
            _AN_ES_RELACIONADO = 0
            _AN_ES_NO_DOMI = 0
        End Sub

        Public Property AN_ES_NO_DOMI() As Integer
            Get
                Return _AN_ES_NO_DOMI
            End Get
            Set(ByVal value As Integer)
                _AN_ES_NO_DOMI = value
            End Set
        End Property

        Public Property AN_ES_RELACIONADO() As Integer
            Get
                Return _AN_ES_RELACIONADO
            End Get
            Set(ByVal value As Integer)
                _AN_ES_RELACIONADO = value
            End Set
        End Property

        Public Property AN_IDANEXO() As Integer
            Get
                Return _AN_IDANEXO
            End Get
            Set(ByVal value As Integer)
                _AN_IDANEXO = value
            End Set
        End Property

        Public Property AN_TIPO_ANEXO() As SG_CO_TB_TIPOANEXO
            Get
                Return _AN_TIPO_ANEXO
            End Get
            Set(ByVal value As SG_CO_TB_TIPOANEXO)
                _AN_TIPO_ANEXO = value
            End Set
        End Property

        Public Property AN_TIPO_EMPRESA() As SG_CO_TB_TIPOEMPRESA
            Get
                Return _AN_TIPO_EMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_TIPOEMPRESA)
                _AN_TIPO_EMPRESA = value
            End Set
        End Property

        Public Property AN_TIPO_DOC() As SG_CO_TB_TIPO_DOC_IDENTIDAD
            Get
                Return _AN_TIPO_DOC
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_DOC_IDENTIDAD)
                _AN_TIPO_DOC = value
            End Set
        End Property

        Public Property AN_NUM_DOC() As String
            Get
                Return _AN_NUM_DOC
            End Get
            Set(ByVal value As String)
                _AN_NUM_DOC = value
            End Set
        End Property

        Public Property AN_DESCRIPCION() As String
            Get
                Return _AN_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _AN_DESCRIPCION = value
            End Set
        End Property

        Public Property AN_PC_USUARIO() As String
            Get
                Return _AN_PC_USUARIO
            End Get
            Set(ByVal value As String)
                _AN_PC_USUARIO = value
            End Set
        End Property

        Public Property AN_PC_TERMINAL() As String
            Get
                Return _AN_PC_TERMINAL
            End Get
            Set(ByVal value As String)
                _AN_PC_TERMINAL = value
            End Set
        End Property

        Public Property AN_PC_FECREG() As String
            Get
                Return _AN_PC_FECREG
            End Get
            Set(ByVal value As String)
                _AN_PC_FECREG = value
            End Set
        End Property

        Public Property AN_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _AN_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _AN_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_BANCO_CTACTE

        Private _BC_IDBANCO As SG_CO_TB_BANCO
        Private _BC_ID_CTA As Int32
        Private _BC_NUMERO_CTA As String
        Private _BC_DESCRIPCION As String
        Private _BC_IDCUENTA As SG_CO_TB_PLANCTAS
        Private _BC_ULTIMO_CHEQUE As String
        Private _BC_FECHA_APERTURA As String
        Private _BC_FECHA_CIERRE As String
        Private _BC_ISTATUS As Int32
        Private _BC_USUARIO As String
        Private _BC_TERMINAL As String
        Private _BC_FECREG As String
        Private _BC_FORMATO_CHEQUE As String
        Private _BC_PERIODO As Integer

        Public Sub New(ByVal BC_IDBANCO_ As SG_CO_TB_BANCO, ByVal BC_ID_CTA_ As Int32, ByVal BC_NUMERO_CTA_ As String, ByVal BC_DESCRIPCION_ As String, ByVal BC_IDCUENTA_ As SG_CO_TB_PLANCTAS, ByVal BC_ULTIMO_CHEQUE_ As String, ByVal BC_FECHA_APERTURA_ As String, ByVal BC_FECHA_CIERRE_ As String, ByVal BC_ISTATUS_ As Int32, ByVal BC_USUARIO_ As String, ByVal BC_TERMINAL_ As String, ByVal BC_FECREG_ As String, ByVal BC_FORMATO_CHEQUE_ As String)
            _BC_FORMATO_CHEQUE = BC_FORMATO_CHEQUE_
            _BC_IDBANCO = BC_IDBANCO_
            _BC_ID_CTA = BC_ID_CTA_
            _BC_NUMERO_CTA = BC_NUMERO_CTA_
            _BC_DESCRIPCION = BC_DESCRIPCION_
            _BC_IDCUENTA = BC_IDCUENTA_
            _BC_ULTIMO_CHEQUE = BC_ULTIMO_CHEQUE_
            _BC_FECHA_APERTURA = BC_FECHA_APERTURA_
            _BC_FECHA_CIERRE = BC_FECHA_CIERRE_
            _BC_ISTATUS = BC_ISTATUS_
            _BC_USUARIO = BC_USUARIO_
            _BC_TERMINAL = BC_TERMINAL_
            _BC_FECREG = BC_FECREG_
        End Sub
        Public Sub New()
            _BC_FORMATO_CHEQUE = String.Empty
            _BC_IDBANCO = Nothing
            _BC_ID_CTA = 0
            _BC_NUMERO_CTA = String.Empty
            _BC_DESCRIPCION = String.Empty
            _BC_IDCUENTA = Nothing
            _BC_ULTIMO_CHEQUE = String.Empty
            _BC_FECHA_APERTURA = String.Empty
            _BC_FECHA_CIERRE = String.Empty
            _BC_ISTATUS = 0
            _BC_USUARIO = String.Empty
            _BC_TERMINAL = String.Empty
            _BC_FECREG = String.Empty
            _BC_PERIODO = 0
        End Sub

        Public Property BC_PERIODO() As Integer
            Get
                Return _BC_PERIODO
            End Get
            Set(ByVal value As Integer)
                _BC_PERIODO = value
            End Set
        End Property

        Public Property BC_FORMATO_CHEQUE() As String
            Get
                Return _BC_FORMATO_CHEQUE
            End Get
            Set(ByVal value As String)
                _BC_FORMATO_CHEQUE = value
            End Set
        End Property

        Public Property BC_IDBANCO() As SG_CO_TB_BANCO
            Get
                Return _BC_IDBANCO
            End Get

            Set(ByVal value As SG_CO_TB_BANCO)
                _BC_IDBANCO = value
            End Set
        End Property

        Public Property BC_ID_CTA() As Int32
            Get
                Return _BC_ID_CTA
            End Get

            Set(ByVal value As Int32)
                _BC_ID_CTA = value
            End Set
        End Property

        Public Property BC_NUMERO_CTA() As String
            Get
                Return _BC_NUMERO_CTA
            End Get

            Set(ByVal value As String)
                _BC_NUMERO_CTA = value
            End Set
        End Property

        Public Property BC_DESCRIPCION() As String
            Get
                Return _BC_DESCRIPCION
            End Get

            Set(ByVal value As String)
                _BC_DESCRIPCION = value
            End Set
        End Property

        Public Property BC_IDCUENTA() As SG_CO_TB_PLANCTAS
            Get
                Return _BC_IDCUENTA
            End Get

            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _BC_IDCUENTA = value
            End Set
        End Property

        Public Property BC_ULTIMO_CHEQUE() As String
            Get
                Return _BC_ULTIMO_CHEQUE
            End Get

            Set(ByVal value As String)
                _BC_ULTIMO_CHEQUE = value
            End Set
        End Property

        Public Property BC_FECHA_APERTURA() As String
            Get
                Return _BC_FECHA_APERTURA
            End Get

            Set(ByVal value As String)
                _BC_FECHA_APERTURA = value
            End Set
        End Property

        Public Property BC_FECHA_CIERRE() As String
            Get
                Return _BC_FECHA_CIERRE
            End Get

            Set(ByVal value As String)
                _BC_FECHA_CIERRE = value
            End Set
        End Property

        Public Property BC_ISTATUS() As Int32
            Get
                Return _BC_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _BC_ISTATUS = value
            End Set
        End Property

        Public Property BC_USUARIO() As String
            Get
                Return _BC_USUARIO
            End Get

            Set(ByVal value As String)
                _BC_USUARIO = value
            End Set
        End Property

        Public Property BC_TERMINAL() As String
            Get
                Return _BC_TERMINAL
            End Get

            Set(ByVal value As String)
                _BC_TERMINAL = value
            End Set
        End Property

        Public Property BC_FECREG() As String
            Get
                Return _BC_FECREG
            End Get

            Set(ByVal value As String)
                _BC_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_BANCO_CONTACTO
        Private _BC_IDBANCO As SG_CO_TB_BANCO
        Private _BC_IDCONTACTO As Int32
        Private _BC_NOMBRES As String
        Private _BC_APELLIDOS As String
        Private _BC_CARGO As String
        Private _BC_USUARIO As String
        Private _BC_TERMINAL As String
        Private _BC_FECREG As DateTime
        Private _BC_EMAIL As String

        Public Sub New(ByVal BC_IDBANCO_ As SG_CO_TB_BANCO, ByVal BC_IDCONTACTO_ As Int32, ByVal BC_NOMBRES_ As String, ByVal BC_APELLIDOS_ As String, ByVal BC_CARGO_ As String, ByVal BC_USUARIO_ As String, ByVal BC_TERMINAL_ As String, ByVal BC_FECREG_ As String, ByVal BC_EMAIL_ As String)
            _BC_EMAIL = BC_EMAIL_
            _BC_IDBANCO = BC_IDBANCO_
            _BC_IDCONTACTO = BC_IDCONTACTO_
            _BC_NOMBRES = BC_NOMBRES_
            _BC_APELLIDOS = BC_APELLIDOS_
            _BC_CARGO = BC_CARGO_
            _BC_USUARIO = BC_USUARIO_
            _BC_TERMINAL = BC_TERMINAL_
            _BC_FECREG = BC_FECREG_
        End Sub
        Public Sub New()
            _BC_IDBANCO = Nothing
            _BC_IDCONTACTO = 0
            _BC_NOMBRES = String.Empty
            _BC_APELLIDOS = String.Empty
            _BC_CARGO = String.Empty
            _BC_USUARIO = String.Empty
            _BC_TERMINAL = String.Empty
            _BC_FECREG = DateTime.MinValue
            _BC_EMAIL = String.Empty
        End Sub

        Public Property BC_EMAIL() As String
            Get
                Return _BC_EMAIL
            End Get
            Set(ByVal value As String)
                _BC_EMAIL = value
            End Set
        End Property

        Public Property BC_IDBANCO() As SG_CO_TB_BANCO
            Get
                Return _BC_IDBANCO
            End Get

            Set(ByVal value As SG_CO_TB_BANCO)
                _BC_IDBANCO = value
            End Set
        End Property

        Public Property BC_IDCONTACTO() As Int32
            Get
                Return _BC_IDCONTACTO
            End Get

            Set(ByVal value As Int32)
                _BC_IDCONTACTO = value
            End Set
        End Property

        Public Property BC_NOMBRES() As String
            Get
                Return _BC_NOMBRES
            End Get

            Set(ByVal value As String)
                _BC_NOMBRES = value
            End Set
        End Property

        Public Property BC_APELLIDOS() As String
            Get
                Return _BC_APELLIDOS
            End Get

            Set(ByVal value As String)
                _BC_APELLIDOS = value
            End Set
        End Property

        Public Property BC_CARGO() As String
            Get
                Return _BC_CARGO
            End Get

            Set(ByVal value As String)
                _BC_CARGO = value
            End Set
        End Property

        Public Property BC_USUARIO() As String
            Get
                Return _BC_USUARIO
            End Get

            Set(ByVal value As String)
                _BC_USUARIO = value
            End Set
        End Property

        Public Property BC_TERMINAL() As String
            Get
                Return _BC_TERMINAL
            End Get

            Set(ByVal value As String)
                _BC_TERMINAL = value
            End Set
        End Property

        Public Property BC_FECREG() As String
            Get
                Return _BC_FECREG
            End Get
            Set(ByVal value As String)
                _BC_FECREG = value
            End Set
        End Property
    End Class
    Public Class SG_CO_TB_BANCO_TELEF
        Private _BT_IDBANCO As SG_CO_TB_BANCO
        Private _BT_IDTEL As Integer
        Private _BT_IDCOMUNICACION As SG_CO_TB_TIPO_COMUNICACION
        Private _BT_NUMERO As String
        Private _BT_DESCRIPCION As String
        Private _BT_ISTATUS As Int32
        Private _BT_USUARIO As String
        Private _BT_TERMINAL As String
        Private _BT_FECREG As String

        Public Sub New(ByVal BT_IDBANCO_ As SG_CO_TB_BANCO, ByVal BT_IDCOMUNICACION_ As SG_CO_TB_TIPO_COMUNICACION, ByVal BT_NUMERO_ As String, ByVal BT_DESCRIPCION_ As String, ByVal BT_ISTATUS_ As Int32, ByVal BT_USUARIO_ As String, ByVal BT_TERMINAL_ As String, ByVal BT_FECREG_ As String, ByVal BT_IDTEL_ As Integer)
            _BT_IDTEL = BT_IDTEL_
            _BT_IDBANCO = BT_IDBANCO_
            _BT_IDCOMUNICACION = BT_IDCOMUNICACION_
            _BT_NUMERO = BT_NUMERO_
            _BT_DESCRIPCION = BT_DESCRIPCION_
            _BT_ISTATUS = BT_ISTATUS_
            _BT_USUARIO = BT_USUARIO_
            _BT_TERMINAL = BT_TERMINAL_
            _BT_FECREG = BT_FECREG_
        End Sub
        Public Sub New()
            _BT_IDBANCO = Nothing
            _BT_IDCOMUNICACION = Nothing
            _BT_NUMERO = String.Empty
            _BT_DESCRIPCION = String.Empty
            _BT_ISTATUS = 0
            _BT_USUARIO = String.Empty
            _BT_TERMINAL = String.Empty
            _BT_FECREG = String.Empty
            _BT_IDTEL = 0
        End Sub

        Public Property BT_IDTEL() As Integer
            Get
                Return _BT_IDTEL
            End Get
            Set(ByVal value As Integer)
                _BT_IDTEL = value
            End Set
        End Property

        Public Property BT_IDBANCO() As SG_CO_TB_BANCO
            Get
                Return _BT_IDBANCO
            End Get

            Set(ByVal value As SG_CO_TB_BANCO)
                _BT_IDBANCO = value
            End Set
        End Property

        Public Property BT_IDCOMUNICACION() As SG_CO_TB_TIPO_COMUNICACION
            Get
                Return _BT_IDCOMUNICACION
            End Get

            Set(ByVal value As SG_CO_TB_TIPO_COMUNICACION)
                _BT_IDCOMUNICACION = value
            End Set
        End Property

        Public Property BT_NUMERO() As String
            Get
                Return _BT_NUMERO
            End Get

            Set(ByVal value As String)
                _BT_NUMERO = value
            End Set
        End Property

        Public Property BT_DESCRIPCION() As String
            Get
                Return _BT_DESCRIPCION
            End Get

            Set(ByVal value As String)
                _BT_DESCRIPCION = value
            End Set
        End Property

        Public Property BT_ISTATUS() As Int32
            Get
                Return _BT_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _BT_ISTATUS = value
            End Set
        End Property

        Public Property BT_USUARIO() As String
            Get
                Return _BT_USUARIO
            End Get

            Set(ByVal value As String)
                _BT_USUARIO = value
            End Set
        End Property

        Public Property BT_TERMINAL() As String
            Get
                Return _BT_TERMINAL
            End Get

            Set(ByVal value As String)
                _BT_TERMINAL = value
            End Set
        End Property

        Public Property BT_FECREG() As String
            Get
                Return _BT_FECREG
            End Get

            Set(ByVal value As String)
                _BT_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_BANCO
        Private _BA_ID As Integer
        Private _BA_CODIGO As String
        Private _BA_NOMBRE As String
        Private _BA_RUC As String
        Private _BA_DIRECCION As String
        Private _BA_CODIGO_ZIP As String
        Private _BA_WEBSITE As String
        Private _BA_LIMITE_CREDITO As Double
        Private _BA_ES_PRINCIPAL As Integer
        Private _BA_IDBANCO_PRIN As String
        Private _BA_IDPAIS As SG_CO_TB_PAIS
        Private _BA_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _BA_ISTATUS As Integer
        Private _BA_USUARIO As String
        Private _BA_TERMINAL As String
        Private _BA_FECREG As String

        Public Sub New(ByVal BA_ID_ As Integer, ByVal BA_CODIGO_ As String, ByVal BA_NOMBRE_ As String, ByVal BA_RUC_ As String, ByVal BA_DIRECCION_ As String, ByVal BA_CODIGO_ZIP_ As String, ByVal BA_WEBSITE_ As String, ByVal BA_LIMITE_CREDITO_ As Double, ByVal BA_ES_PRINCIPAL_ As Integer, ByVal BA_IDBANCO_PRIN_ As String, ByVal BA_IDPAIS_ As SG_CO_TB_PAIS, ByVal BA_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal BA_ISTATUS_ As Integer, ByVal BA_USUARIO_ As String, ByVal BA_TERMINAL_ As String, ByVal BA_FECREG_ As String)
            _BA_ID = BA_ID_
            _BA_CODIGO = BA_CODIGO_
            _BA_NOMBRE = BA_NOMBRE_
            _BA_RUC = BA_RUC_
            _BA_DIRECCION = BA_DIRECCION_
            _BA_CODIGO_ZIP = BA_CODIGO_ZIP_
            _BA_WEBSITE = BA_WEBSITE_
            _BA_LIMITE_CREDITO = BA_LIMITE_CREDITO_
            _BA_ES_PRINCIPAL = BA_ES_PRINCIPAL_
            _BA_IDBANCO_PRIN = BA_IDBANCO_PRIN_
            _BA_IDPAIS = BA_IDPAIS_
            _BA_IDEMPRESA = BA_IDEMPRESA_
            _BA_ISTATUS = BA_ISTATUS_
            _BA_USUARIO = BA_USUARIO_
            _BA_TERMINAL = BA_TERMINAL_
            _BA_FECREG = BA_FECREG_
        End Sub
        Public Sub New()
            _BA_FECREG = String.Empty
            _BA_TERMINAL = String.Empty
            _BA_USUARIO = String.Empty
            _BA_ISTATUS = 0
            _BA_IDEMPRESA = Nothing
            _BA_IDPAIS = Nothing
            _BA_IDBANCO_PRIN = String.Empty
            _BA_ES_PRINCIPAL = 0
            _BA_LIMITE_CREDITO = 0.0R
            _BA_WEBSITE = String.Empty
            _BA_CODIGO_ZIP = String.Empty
            _BA_DIRECCION = String.Empty
            _BA_RUC = String.Empty
            _BA_NOMBRE = String.Empty
            _BA_CODIGO = String.Empty
            _BA_ID = 0
        End Sub

        Public Property BA_ID() As Integer
            Get
                Return _BA_ID
            End Get
            Set(ByVal value As Integer)
                _BA_ID = value
            End Set
        End Property

        Public Property BA_CODIGO() As String
            Get
                Return _BA_CODIGO
            End Get
            Set(ByVal value As String)
                _BA_CODIGO = value
            End Set
        End Property

        Public Property BA_NOMBRE() As String
            Get
                Return _BA_NOMBRE
            End Get
            Set(ByVal value As String)
                _BA_NOMBRE = value
            End Set
        End Property

        Public Property BA_RUC() As String
            Get
                Return _BA_RUC
            End Get
            Set(ByVal value As String)
                _BA_RUC = value
            End Set
        End Property

        Public Property BA_DIRECCION() As String
            Get
                Return _BA_DIRECCION
            End Get
            Set(ByVal value As String)
                _BA_DIRECCION = value
            End Set
        End Property

        Public Property BA_CODIGO_ZIP() As String
            Get
                Return _BA_CODIGO_ZIP
            End Get
            Set(ByVal value As String)
                _BA_CODIGO_ZIP = value
            End Set
        End Property

        Public Property BA_WEBSITE() As String
            Get
                Return _BA_WEBSITE
            End Get
            Set(ByVal value As String)
                _BA_WEBSITE = value
            End Set
        End Property

        Public Property BA_LIMITE_CREDITO() As Double
            Get
                Return _BA_LIMITE_CREDITO
            End Get
            Set(ByVal value As Double)
                _BA_LIMITE_CREDITO = value
            End Set
        End Property

        Public Property BA_ES_PRINCIPAL() As Integer
            Get
                Return _BA_ES_PRINCIPAL
            End Get
            Set(ByVal value As Integer)
                _BA_ES_PRINCIPAL = value
            End Set
        End Property

        Public Property BA_IDBANCO_PRIN() As String
            Get
                Return _BA_IDBANCO_PRIN
            End Get
            Set(ByVal value As String)
                _BA_IDBANCO_PRIN = value
            End Set
        End Property

        Public Property BA_IDPAIS() As SG_CO_TB_PAIS
            Get
                Return _BA_IDPAIS
            End Get
            Set(ByVal value As SG_CO_TB_PAIS)
                _BA_IDPAIS = value
            End Set
        End Property

        Public Property BA_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _BA_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _BA_IDEMPRESA = value
            End Set
        End Property

        Public Property BA_ISTATUS() As Integer
            Get
                Return _BA_ISTATUS
            End Get
            Set(ByVal value As Integer)
                _BA_ISTATUS = value
            End Set
        End Property

        Public Property BA_USUARIO() As String
            Get
                Return _BA_USUARIO
            End Get
            Set(ByVal value As String)
                _BA_USUARIO = value
            End Set
        End Property

        Public Property BA_TERMINAL() As String
            Get
                Return _BA_TERMINAL
            End Get
            Set(ByVal value As String)
                _BA_TERMINAL = value
            End Set
        End Property

        Public Property BA_FECREG() As String
            Get
                Return _BA_FECREG
            End Get
            Set(ByVal value As String)
                _BA_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_MEDIOPAGO
        Private _MP_CODIGO As String
        Private _MP_DESCRIPCION As String

        Public Sub New(ByVal MP_CODIGO_ As String, ByVal MP_DESCRIPCION_ As String)
            _MP_CODIGO = MP_CODIGO_
            _MP_DESCRIPCION = MP_DESCRIPCION_
        End Sub
        Public Sub New()
            _MP_CODIGO = String.Empty
            _MP_DESCRIPCION = String.Empty
        End Sub

        Public Property MP_CODIGO() As String
            Get
                Return _MP_CODIGO
            End Get
            Set(ByVal value As String)
                _MP_CODIGO = value
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
    Public Class SG_CO_TB_CONTACTO_TELEF
        Private _CT_IDREG As Integer
        Private _CT_IDCONTACTO As SG_CO_TB_BANCO_CONTACTO
        Private _CT_IDCOMUNICACION As SG_CO_TB_TIPO_COMUNICACION
        Private _CT_NUMERO As String
        Private _CT_DESCRIPCION As String
        Private _CT_ISTATUS As Integer
        Private _CT_USUARIO As String
        Private _CT_TERMINAL As String
        Private _CT_FECREG As String

        Public Sub New(ByVal CT_IDREG_ As Integer, ByVal CT_IDCONTACTO_ As SG_CO_TB_BANCO_CONTACTO, ByVal CT_IDCOMUNICACION_ As SG_CO_TB_TIPO_COMUNICACION, ByVal CT_NUMERO_ As String, ByVal CT_DESCRIPCION_ As String, ByVal CT_ISTATUS_ As Integer, ByVal CT_USUARIO_ As String, ByVal CT_TERMINAL_ As String, ByVal CT_FECREG_ As String)
            _CT_IDREG = CT_IDREG_
            _CT_IDCONTACTO = CT_IDCONTACTO_
            _CT_IDCOMUNICACION = CT_IDCOMUNICACION_
            _CT_NUMERO = CT_NUMERO_
            _CT_DESCRIPCION = CT_DESCRIPCION_
            _CT_ISTATUS = CT_ISTATUS_
            _CT_USUARIO = CT_USUARIO_
            _CT_TERMINAL = CT_TERMINAL_
            _CT_FECREG = CT_FECREG_
        End Sub

        Public Sub New()
            _CT_IDREG = 0
            _CT_IDCONTACTO = Nothing
            _CT_IDCOMUNICACION = Nothing
            _CT_NUMERO = String.Empty
            _CT_DESCRIPCION = String.Empty
            _CT_ISTATUS = 0
            _CT_USUARIO = String.Empty
            _CT_TERMINAL = String.Empty
            _CT_FECREG = String.Empty
        End Sub

        Public Property CT_IDREG() As Integer
            Get
                Return _CT_IDREG
            End Get
            Set(ByVal value As Integer)
                _CT_IDREG = value
            End Set
        End Property

        Public Property CT_IDCONTACTO() As SG_CO_TB_BANCO_CONTACTO
            Get
                Return _CT_IDCONTACTO
            End Get
            Set(ByVal value As SG_CO_TB_BANCO_CONTACTO)
                _CT_IDCONTACTO = value
            End Set
        End Property

        Public Property CT_IDCOMUNICACION() As SG_CO_TB_TIPO_COMUNICACION
            Get
                Return _CT_IDCOMUNICACION
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_COMUNICACION)
                _CT_IDCOMUNICACION = value
            End Set
        End Property

        Public Property CT_NUMERO() As String
            Get
                Return _CT_NUMERO
            End Get
            Set(ByVal value As String)
                _CT_NUMERO = value
            End Set
        End Property

        Public Property CT_DESCRIPCION() As String
            Get
                Return _CT_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CT_DESCRIPCION = value
            End Set
        End Property

        Public Property CT_ISTATUS() As Integer
            Get
                Return _CT_ISTATUS
            End Get
            Set(ByVal value As Integer)
                _CT_ISTATUS = value
            End Set
        End Property

        Public Property CT_USUARIO() As String
            Get
                Return _CT_USUARIO
            End Get
            Set(ByVal value As String)
                _CT_USUARIO = value
            End Set
        End Property

        Public Property CT_TERMINAL() As String
            Get
                Return _CT_TERMINAL
            End Get
            Set(ByVal value As String)
                _CT_TERMINAL = value
            End Set
        End Property

        Public Property CT_FECREG() As String
            Get
                Return _CT_FECREG
            End Get
            Set(ByVal value As String)
                _CT_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_SALDO_MOV_BANCO
        Private _SMB_ANHO As Integer
        Private _SMB_MES As Integer
        Private _SMB_CUENTA As Integer
        Private _SMB_SALDO As Double
        Private _SMB_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal SMB_ANHO_ As Integer, ByVal SMB_MES_ As Integer, ByVal SMB_CUENTA_ As Integer, ByVal SMB_SALDO_ As Double, ByVal SMB_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _SMB_ANHO = SMB_ANHO_
            _SMB_MES = SMB_MES_
            _SMB_CUENTA = SMB_CUENTA_
            _SMB_SALDO = SMB_SALDO_
            _SMB_IDEMPRESA = SMB_IDEMPRESA_
        End Sub

        Public Sub New()
            _SMB_ANHO = 0
            _SMB_MES = 0
            _SMB_CUENTA = 0
            _SMB_SALDO = 0.0R
            _SMB_IDEMPRESA = Nothing
        End Sub

        Public Property SMB_ANHO() As Integer
            Get
                Return _SMB_ANHO
            End Get
            Set(ByVal value As Integer)
                _SMB_ANHO = value
            End Set
        End Property

        Public Property SMB_MES() As Integer
            Get
                Return _SMB_MES
            End Get
            Set(ByVal value As Integer)
                _SMB_MES = value
            End Set
        End Property

        Public Property SMB_CUENTA() As Integer
            Get
                Return _SMB_CUENTA
            End Get
            Set(ByVal value As Integer)
                _SMB_CUENTA = value
            End Set
        End Property

        Public Property SMB_SALDO() As Double
            Get
                Return _SMB_SALDO
            End Get
            Set(ByVal value As Double)
                _SMB_SALDO = value
            End Set
        End Property

        Public Property SMB_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _SMB_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _SMB_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_FORMAPAGO
        Private _ID As Integer
        Private _DESCRIPCION As String
        Private _IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal ID_ As Integer, ByVal DESCRIPCION_ As String, ByVal IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _ID = ID_
            _DESCRIPCION = DESCRIPCION_
            _IDEMPRESA = IDEMPRESA_
        End Sub
        Public Sub New()
            _IDEMPRESA = Nothing
            _DESCRIPCION = String.Empty
            _ID = 0
        End Sub

        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Public Property DESCRIPCION() As String
            Get
                Return _DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DESCRIPCION = value
            End Set
        End Property

        Public Property IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_GIRONEGOCIO
        Private _GN_ID As Integer
        Private _GN_DESCRIPCION As String
        Private _GN_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal GN_ID_ As Integer, ByVal GN_DESCRIPCION_ As String, ByVal GN_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _GN_ID = GN_ID_
            _GN_DESCRIPCION = GN_DESCRIPCION_
            _GN_IDEMPRESA = GN_IDEMPRESA_
        End Sub
        Public Sub New()
            _GN_ID = 0
            _GN_DESCRIPCION = String.Empty
            _GN_IDEMPRESA = Nothing
        End Sub

        Public Property GN_ID() As Integer
            Get
                Return _GN_ID
            End Get
            Set(ByVal value As Integer)
                _GN_ID = value
            End Set
        End Property

        Public Property GN_DESCRIPCION() As String
            Get
                Return _GN_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _GN_DESCRIPCION = value
            End Set
        End Property

        Public Property GN_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _GN_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _GN_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_FORMACOBRANZA
        Private _FC_ID As Integer
        Private _FC_DESCRIPCION As String
        Private _FC_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal FC_ID_ As Integer, ByVal FC_DESCRIPCION_ As String, ByVal FC_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _FC_ID = FC_ID_
            _FC_DESCRIPCION = FC_DESCRIPCION_
            _FC_IDEMPRESA = FC_IDEMPRESA_
        End Sub
        Public Sub New()
            _FC_ID = 0
            _FC_DESCRIPCION = String.Empty
            _FC_IDEMPRESA = Nothing
        End Sub

        Public Property FC_ID() As Integer
            Get
                Return _FC_ID
            End Get
            Set(ByVal value As Integer)
                _FC_ID = value
            End Set
        End Property

        Public Property FC_DESCRIPCION() As String
            Get
                Return _FC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _FC_DESCRIPCION = value
            End Set
        End Property

        Public Property FC_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _FC_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _FC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_FORMAENVIO
        Private _FE_ID As Integer
        Private _FE_DESCRIPCION As String
        Private _FE_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal FE_ID_ As Integer, ByVal FE_DESCRIPCION_ As String, ByVal FE_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _FE_ID = FE_ID_
            _FE_DESCRIPCION = FE_DESCRIPCION_
            _FE_IDEMPRESA = FE_IDEMPRESA_
        End Sub
        Public Sub New()
            _FE_ID = 0
            _FE_DESCRIPCION = String.Empty
            _FE_IDEMPRESA = Nothing
        End Sub

        Public Property FE_ID() As Integer
            Get
                Return _FE_ID
            End Get
            Set(ByVal value As Integer)
                _FE_ID = value
            End Set
        End Property

        Public Property FE_DESCRIPCION() As String
            Get
                Return _FE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _FE_DESCRIPCION = value
            End Set
        End Property

        Public Property FE_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _FE_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _FE_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_FORMADESPACHO
        Private _FD_ID As Integer
        Private _FD_DESCRIPCION As String
        Private _FD_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New()
            _FD_ID = 0
            _FD_DESCRIPCION = String.Empty
            _FD_IDEMPRESA = Nothing
        End Sub
        Public Sub New(ByVal FD_ID_ As Integer, ByVal FD_DESCRIPCION_ As String, ByVal FD_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _FD_ID = FD_ID_
            _FD_DESCRIPCION = FD_DESCRIPCION_
            _FD_IDEMPRESA = FD_IDEMPRESA_
        End Sub

        Public Property FD_ID() As Integer
            Get
                Return _FD_ID
            End Get
            Set(ByVal value As Integer)
                _FD_ID = value
            End Set
        End Property

        Public Property FD_DESCRIPCION() As String
            Get
                Return _FD_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _FD_DESCRIPCION = value
            End Set
        End Property

        Public Property FD_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _FD_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _FD_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_VENDEDOR
        Private _VE_ID As Integer
        Private _VE_DESCRIPCION As String
        Private _VE_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal VE_ID_ As Integer, ByVal VE_DESCRIPCION_ As String, ByVal VE_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _VE_ID = VE_ID_
            _VE_DESCRIPCION = VE_DESCRIPCION_
            _VE_IDEMPRESA = VE_IDEMPRESA_
        End Sub
        Public Sub New()
            _VE_ID = 0
            _VE_DESCRIPCION = String.Empty
            _VE_IDEMPRESA = Nothing
        End Sub

        Public Property VE_ID() As Integer
            Get
                Return _VE_ID
            End Get
            Set(ByVal value As Integer)
                _VE_ID = value
            End Set
        End Property

        Public Property VE_DESCRIPCION() As String
            Get
                Return _VE_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _VE_DESCRIPCION = value
            End Set
        End Property

        Public Property VE_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _VE_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _VE_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_COBRADOR
        Private _CO_ID As Integer
        Private _CO_DESCRIPCION As String
        Private _CO_IDEMPRESA As SG_CO_TB_EMPRESA
        Public Sub New(ByVal CO_ID_ As Integer, ByVal CO_DESCRIPCION_ As String, ByVal CO_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _CO_ID = CO_ID_
            _CO_DESCRIPCION = CO_DESCRIPCION_
            _CO_IDEMPRESA = CO_IDEMPRESA_
        End Sub
        Public Sub New()
            _CO_ID = 0
            _CO_DESCRIPCION = String.Empty
            _CO_IDEMPRESA = Nothing
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

        Public Property CO_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _CO_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _CO_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_DOCUMENTO_VENTANA
        Private _DV_IDDOC As SG_CO_TB_DOCUMENTO
        Private _DV_IDVENTANA As SG_CO_TB_OPERACION
        Private _DV_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _DV_USUARIO As String
        Private _DV_TERMINAL As String
        Private _DV_FECREG As String

        Public Sub New(ByVal DV_IDDOC_ As SG_CO_TB_DOCUMENTO, ByVal DV_IDVENTANA_ As SG_CO_TB_OPERACION, ByVal DV_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal DV_USUARIO_ As String, ByVal DV_TERMINAL_ As String, ByVal DV_FECREG_ As String)
            _DV_IDDOC = DV_IDDOC_
            _DV_IDVENTANA = DV_IDVENTANA_
            _DV_IDEMPRESA = DV_IDEMPRESA_
            _DV_USUARIO = DV_USUARIO_
            _DV_TERMINAL = DV_TERMINAL_
            _DV_FECREG = DV_FECREG_
        End Sub

        Public Sub New()
            _DV_IDDOC = Nothing
            _DV_IDVENTANA = Nothing
            _DV_IDEMPRESA = Nothing
            _DV_USUARIO = String.Empty
            _DV_TERMINAL = String.Empty
            _DV_FECREG = String.Empty
        End Sub

        Public Property DV_IDDOC() As SG_CO_TB_DOCUMENTO
            Get
                Return _DV_IDDOC
            End Get

            Set(ByVal value As SG_CO_TB_DOCUMENTO)
                _DV_IDDOC = value
            End Set
        End Property

        Public Property DV_IDVENTANA() As SG_CO_TB_OPERACION
            Get
                Return _DV_IDVENTANA
            End Get

            Set(ByVal value As SG_CO_TB_OPERACION)
                _DV_IDVENTANA = value
            End Set
        End Property

        Public Property DV_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _DV_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _DV_IDEMPRESA = value
            End Set
        End Property

        Public Property DV_USUARIO() As String
            Get
                Return _DV_USUARIO
            End Get

            Set(ByVal value As String)
                _DV_USUARIO = value
            End Set
        End Property

        Public Property DV_TERMINAL() As String
            Get
                Return _DV_TERMINAL
            End Get

            Set(ByVal value As String)
                _DV_TERMINAL = value
            End Set
        End Property

        Public Property DV_FECREG() As String
            Get
                Return _DV_FECREG
            End Get

            Set(ByVal value As String)
                _DV_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_DOCUMENTO
        Private _DO_CODIGO As String
        Private _DO_DESCRIPCION As String
        Private _DO_ABREVIATURA As String
        Private _DO_ES_RESTA As Int32
        Private _DO_ISTATUS As Int32
        Private _DO_CODIGO_SUNAT As String
        Private _DO_PC_USUARIO As String
        Private _DO_PC_TERMINAL As String
        Private _DO_PC_FECREG As String
        Private _DO_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _DO_COLOR_DOC As String


        Public Sub New(ByVal DO_CODIGO_ As String, ByVal DO_DESCRIPCION_ As String, ByVal DO_ABREVIATURA_ As String, ByVal DO_ES_RESTA_ As Int32, ByVal DO_ISTATUS_ As Int32, ByVal DO_CODIGO_SUNAT_ As String, ByVal DO_PC_USUARIO_ As String, ByVal DO_PC_TERMINAL_ As String, ByVal DO_PC_FECREG_ As String, ByVal DO_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal DO_COLOR_DOC_ As String)
            _DO_COLOR_DOC = DO_COLOR_DOC_
            _DO_CODIGO = DO_CODIGO_
            _DO_DESCRIPCION = DO_DESCRIPCION_
            _DO_ABREVIATURA = DO_ABREVIATURA_
            _DO_ES_RESTA = DO_ES_RESTA_
            _DO_ISTATUS = DO_ISTATUS_
            _DO_CODIGO_SUNAT = DO_CODIGO_SUNAT_
            _DO_PC_USUARIO = DO_PC_USUARIO_
            _DO_PC_TERMINAL = DO_PC_TERMINAL_
            _DO_PC_FECREG = DO_PC_FECREG_
            _DO_IDEMPRESA = DO_IDEMPRESA_
        End Sub
        Public Sub New()
            _DO_CODIGO = String.Empty
            _DO_DESCRIPCION = String.Empty
            _DO_ABREVIATURA = String.Empty
            _DO_ES_RESTA = 0
            _DO_ISTATUS = 0
            _DO_CODIGO_SUNAT = String.Empty
            _DO_PC_USUARIO = String.Empty
            _DO_PC_TERMINAL = String.Empty
            _DO_PC_FECREG = String.Empty
            _DO_IDEMPRESA = Nothing
            _DO_COLOR_DOC = String.Empty
        End Sub

        Public Property DO_COLOR_DOC() As String
            Get
                Return _DO_COLOR_DOC
            End Get
            Set(ByVal value As String)
                _DO_COLOR_DOC = value
            End Set
        End Property

        Public Property DO_CODIGO() As String
            Get
                Return _DO_CODIGO
            End Get

            Set(ByVal value As String)
                _DO_CODIGO = value
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

        Public Property DO_ABREVIATURA() As String
            Get
                Return _DO_ABREVIATURA
            End Get

            Set(ByVal value As String)
                _DO_ABREVIATURA = value
            End Set
        End Property

        Public Property DO_ES_RESTA() As Int32
            Get
                Return _DO_ES_RESTA
            End Get

            Set(ByVal value As Int32)
                _DO_ES_RESTA = value
            End Set
        End Property

        Public Property DO_ISTATUS() As Int32
            Get
                Return _DO_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _DO_ISTATUS = value
            End Set
        End Property

        Public Property DO_CODIGO_SUNAT() As String
            Get
                Return _DO_CODIGO_SUNAT
            End Get

            Set(ByVal value As String)
                _DO_CODIGO_SUNAT = value
            End Set
        End Property

        Public Property DO_PC_USUARIO() As String
            Get
                Return _DO_PC_USUARIO
            End Get

            Set(ByVal value As String)
                _DO_PC_USUARIO = value
            End Set
        End Property

        Public Property DO_PC_TERMINAL() As String
            Get
                Return _DO_PC_TERMINAL
            End Get

            Set(ByVal value As String)
                _DO_PC_TERMINAL = value
            End Set
        End Property

        Public Property DO_PC_FECREG() As String
            Get
                Return _DO_PC_FECREG
            End Get

            Set(ByVal value As String)
                _DO_PC_FECREG = value
            End Set
        End Property

        Public Property DO_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _DO_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _DO_IDEMPRESA = value
            End Set
        End Property


    End Class

    Public Class SG_CO_TB_CONCEPTO_REGISTRO
        Private _CR_ID As Int32
        Private _CR_DESCRIPCION As String
        Private _CR_DESCRIPCION2 As String

        Public Sub New(ByVal CR_ID_ As Int32, ByVal CR_DESCRIPCION_ As String, ByVal CR_DESCRIPCION2_ As String)
            _CR_ID = CR_ID_
            _CR_DESCRIPCION = CR_DESCRIPCION_
            _CR_DESCRIPCION2 = CR_DESCRIPCION2_
        End Sub
        Public Sub New()
            _CR_ID = 0
            _CR_DESCRIPCION = String.Empty
            _CR_DESCRIPCION2 = String.Empty
        End Sub

        Public Property CR_ID() As Integer
            Get
                Return _CR_ID
            End Get
            Set(ByVal value As Integer)
                _CR_ID = value
            End Set
        End Property

        Public Property CR_DESCRIPCION() As String
            Get
                Return _CR_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CR_DESCRIPCION = value
            End Set
        End Property

        Public Property CR_DESCRIPCION2() As String
            Get
                Return _CR_DESCRIPCION2
            End Get
            Set(ByVal value As String)
                _CR_DESCRIPCION2 = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_ASIENTO_AUTO_DET
        Private _AA_IDCAB As SG_CO_TB_ASIENTO_AUTO_CAB
        Private _AA_IDCUENTA As SG_CO_TB_PLANCTAS
        Private _AA_IDCONPCETO As SG_CO_TB_CONCEPTO_REGISTRO
        Private _AA_DH As Int32
        Private _AA_ISTATUS As Int32
        Private _AA_USUARIO As String
        Private _AA_TERMINAL As String
        Private _AA_FECREG As String
        Private _AA_IDCUENTA_R As SG_CO_TB_PLANCTAS
        Private _AA_IDMONEDA As SG_CO_TB_MONEDA

        Public Sub New(ByVal AA_IDCAB_ As SG_CO_TB_ASIENTO_AUTO_CAB, ByVal AA_IDCUENTA_ As SG_CO_TB_PLANCTAS, ByVal AA_IDCONPCETO_ As SG_CO_TB_CONCEPTO_REGISTRO, ByVal AA_DH_ As Int32, ByVal AA_ISTATUS_ As Int32, ByVal AA_USUARIO_ As String, ByVal AA_TERMINAL_ As String, ByVal AA_FECREG_ As String, ByVal AA_IDCUENTA_R_ As SG_CO_TB_PLANCTAS, ByVal AA_IDMONEDA_ As BE.ContabilidadBE.SG_CO_TB_MONEDA)
            _AA_IDCAB = AA_IDCAB_
            _AA_IDCUENTA = AA_IDCUENTA_
            _AA_IDCONPCETO = AA_IDCONPCETO_
            _AA_DH = AA_DH_
            _AA_ISTATUS = AA_ISTATUS_
            _AA_USUARIO = AA_USUARIO_
            _AA_TERMINAL = AA_TERMINAL_
            _AA_FECREG = AA_FECREG_
            _AA_IDCUENTA_R = AA_IDCUENTA_R_
            _AA_IDMONEDA = AA_IDMONEDA_
        End Sub
        Public Sub New()
            _AA_IDCAB = Nothing
            _AA_IDCUENTA = Nothing
            _AA_IDCONPCETO = Nothing
            _AA_DH = 0
            _AA_ISTATUS = 0
            _AA_USUARIO = String.Empty
            _AA_TERMINAL = String.Empty
            _AA_FECREG = String.Empty
            _AA_IDCUENTA_R = Nothing
            _AA_IDMONEDA = Nothing
        End Sub

        Public Property AA_IDMONEDA() As BE.ContabilidadBE.SG_CO_TB_MONEDA
            Get
                Return _AA_IDMONEDA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_MONEDA)
                _AA_IDMONEDA = value
            End Set
        End Property

        Public Property AA_IDCUENTA_R() As SG_CO_TB_PLANCTAS
            Get
                Return _AA_IDCUENTA_R
            End Get
            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _AA_IDCUENTA_R = value
            End Set
        End Property

        Public Property AA_IDCAB() As SG_CO_TB_ASIENTO_AUTO_CAB
            Get
                Return _AA_IDCAB
            End Get
            Set(ByVal value As SG_CO_TB_ASIENTO_AUTO_CAB)
                _AA_IDCAB = value
            End Set
        End Property

        Public Property AA_IDCUENTA() As SG_CO_TB_PLANCTAS
            Get
                Return _AA_IDCUENTA
            End Get

            Set(ByVal value As SG_CO_TB_PLANCTAS)
                _AA_IDCUENTA = value
            End Set
        End Property

        Public Property AA_IDCONPCETO() As SG_CO_TB_CONCEPTO_REGISTRO
            Get
                Return _AA_IDCONPCETO
            End Get

            Set(ByVal value As SG_CO_TB_CONCEPTO_REGISTRO)
                _AA_IDCONPCETO = value
            End Set
        End Property

        Public Property AA_DH() As Int32
            Get
                Return _AA_DH
            End Get

            Set(ByVal value As Int32)
                _AA_DH = value
            End Set
        End Property

        Public Property AA_ISTATUS() As Int32
            Get
                Return _AA_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _AA_ISTATUS = value
            End Set
        End Property

        Public Property AA_USUARIO() As String
            Get
                Return _AA_USUARIO
            End Get

            Set(ByVal value As String)
                _AA_USUARIO = value
            End Set
        End Property

        Public Property AA_TERMINAL() As String
            Get
                Return _AA_TERMINAL
            End Get

            Set(ByVal value As String)
                _AA_TERMINAL = value
            End Set
        End Property

        Public Property AA_FECREG() As DateTime
            Get
                Return _AA_FECREG
            End Get

            Set(ByVal value As DateTime)
                _AA_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_ASIENTO_AUTO_CAB
        Private _AA_ID As Int32
        Private _AA_IDSUBDIARIO As SG_CO_TB_SUBDIARIO
        Private _AA_ANHO As Int32
        Private _AA_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _AA_ISTATUS As Int32
        Private _AA_USUARIO As String
        Private _AA_TERMINAL As String
        Private _AA_FECREG As String

        Public Sub New(ByVal AA_ID_ As Integer, ByVal AA_IDSUBDIARIO_ As SG_CO_TB_SUBDIARIO, ByVal AA_ANHO_ As Int32, ByVal AA_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal AA_ISTATUS_ As Int32, ByVal AA_USUARIO_ As String, ByVal AA_TERMINAL_ As String, ByVal AA_FECREG_ As String)
            _AA_ID = AA_ID_
            _AA_IDSUBDIARIO = AA_IDSUBDIARIO_
            _AA_ANHO = AA_ANHO_
            _AA_IDEMPRESA = AA_IDEMPRESA_
            _AA_ISTATUS = AA_ISTATUS_
            _AA_USUARIO = AA_USUARIO_
            _AA_TERMINAL = AA_TERMINAL_
            _AA_FECREG = AA_FECREG_
        End Sub
        Public Sub New()
            _AA_ID = 0
            _AA_IDSUBDIARIO = Nothing
            _AA_ANHO = 0
            _AA_IDEMPRESA = Nothing
            _AA_ISTATUS = 0
            _AA_USUARIO = String.Empty
            _AA_TERMINAL = String.Empty
            _AA_FECREG = String.Empty
        End Sub

        Public Property AA_ID() As Int32
            Get
                Return _AA_ID
            End Get
            Set(ByVal value As Int32)
                _AA_ID = value
            End Set
        End Property

        Public Property AA_IDSUBDIARIO() As SG_CO_TB_SUBDIARIO
            Get
                Return _AA_IDSUBDIARIO
            End Get
            Set(ByVal value As SG_CO_TB_SUBDIARIO)
                _AA_IDSUBDIARIO = value
            End Set
        End Property

        Public Property AA_ANHO() As Int32
            Get
                Return _AA_ANHO
            End Get

            Set(ByVal value As Int32)
                _AA_ANHO = value
            End Set
        End Property

        Public Property AA_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _AA_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _AA_IDEMPRESA = value
            End Set
        End Property

        Public Property AA_ISTATUS() As Int32
            Get
                Return _AA_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _AA_ISTATUS = value
            End Set
        End Property

        Public Property AA_USUARIO() As String
            Get
                Return _AA_USUARIO
            End Get

            Set(ByVal value As String)
                _AA_USUARIO = value
            End Set
        End Property

        Public Property AA_TERMINAL() As String
            Get
                Return _AA_TERMINAL
            End Get

            Set(ByVal value As String)
                _AA_TERMINAL = value
            End Set
        End Property

        Public Property AA_FECREG() As String
            Get
                Return _AA_FECREG
            End Get

            Set(ByVal value As String)
                _AA_FECREG = value
            End Set
        End Property
    End Class

    Public Class SG_CO_TB_NUMVOUCHER
        Private _NV_ANHO As Int32
        Private _NV_MES As Int32
        Private _NV_IDSUBDIARIO As SG_CO_TB_SUBDIARIO
        Private _NV_ULTIMO_NUMERO As String
        Private _NV_USUARIO As String
        Private _NV_TERMINAL As String
        Private _NV_FECREG As String
        Private _NV_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal NV_ANHO_ As Int32, ByVal NV_MES_ As Integer, ByVal NV_IDSUBDIARIO_ As SG_CO_TB_SUBDIARIO, ByVal NV_ULTIMO_NUMERO_ As String, ByVal NV_USUARIO_ As String, ByVal NV_TERMINAL_ As String, ByVal NV_FECREG_ As String, ByVal NV_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _NV_ANHO = NV_ANHO_
            _NV_MES = NV_MES_
            _NV_IDSUBDIARIO = NV_IDSUBDIARIO_
            _NV_ULTIMO_NUMERO = NV_ULTIMO_NUMERO_
            _NV_USUARIO = NV_USUARIO_
            _NV_TERMINAL = NV_TERMINAL_
            _NV_FECREG = NV_FECREG_
            _NV_IDEMPRESA = NV_IDEMPRESA_
        End Sub
        Public Sub New()
            _NV_ANHO = 0
            _NV_MES = 0
            _NV_IDSUBDIARIO = Nothing
            _NV_ULTIMO_NUMERO = String.Empty
            _NV_USUARIO = String.Empty
            _NV_TERMINAL = String.Empty
            _NV_FECREG = String.Empty
            _NV_IDEMPRESA = Nothing
        End Sub

        Public Property NV_ANHO() As Int32
            Get
                Return _NV_ANHO
            End Get

            Set(ByVal value As Int32)
                _NV_ANHO = value
            End Set
        End Property

        Public Property NV_MES() As Int32
            Get
                Return _NV_MES
            End Get

            Set(ByVal value As Int32)
                _NV_MES = value
            End Set
        End Property

        Public Property NV_IDSUBDIARIO() As SG_CO_TB_SUBDIARIO
            Get
                Return _NV_IDSUBDIARIO
            End Get

            Set(ByVal value As SG_CO_TB_SUBDIARIO)
                _NV_IDSUBDIARIO = value
            End Set
        End Property

        Public Property NV_ULTIMO_NUMERO() As String
            Get
                Return _NV_ULTIMO_NUMERO
            End Get

            Set(ByVal value As String)
                _NV_ULTIMO_NUMERO = value
            End Set
        End Property

        Public Property NV_USUARIO() As String
            Get
                Return _NV_USUARIO
            End Get

            Set(ByVal value As String)
                _NV_USUARIO = value
            End Set
        End Property

        Public Property NV_TERMINAL() As String
            Get
                Return _NV_TERMINAL
            End Get

            Set(ByVal value As String)
                _NV_TERMINAL = value
            End Set
        End Property

        Public Property NV_FECREG() As String
            Get
                Return _NV_FECREG
            End Get

            Set(ByVal value As String)
                _NV_FECREG = value
            End Set
        End Property

        Public Property NV_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _NV_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _NV_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_IMPUESTO_SUNAT
        Private _IS_CODIGO As String
        Private _IS_DESCRIPCION As String

        Public Sub New(ByVal IS_CODIGO_ As String, ByVal IS_DESCRIPCION_ As String)
            _IS_CODIGO = IS_CODIGO_
            _IS_DESCRIPCION = IS_DESCRIPCION_
        End Sub
        Public Sub New()
            _IS_CODIGO = String.Empty
            _IS_DESCRIPCION = String.Empty
        End Sub

        Public Property IS_CODIGO() As String
            Get
                Return _IS_CODIGO
            End Get
            Set(ByVal value As String)
                _IS_CODIGO = value
            End Set
        End Property

        Public Property IS_DESCRIPCION() As String
            Get
                Return _IS_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _IS_DESCRIPCION = value
            End Set
        End Property
    End Class

    Public Class SG_CO_TB_IMPUESTO

        Private _IM_CODIGO As String
        Private _IM_CODIGO_SUNAT As SG_CO_TB_IMPUESTO_SUNAT
        Private _IM_DESCRIPCION As String
        Private _IM_ABREVIATURA As String
        Private _IM_TASA As Double
        Private _IM_CUENTA As String
        Private _IM_ISTATUS As Int32
        Private _IM_PERIODO As Int32
        Private _IM_MES As Int32
        Private _IM_USUARIO As String
        Private _IM_TERMINAL As String
        Private _IM_FECREG As String
        Private _IM_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _IM_IDTIPOIMPUESTO As SG_CO_TB_TIPO_IMPUESTO


        Public Sub New(ByVal IM_CODIGO_ As String, ByVal IM_CODIGO_SUNAT_ As SG_CO_TB_IMPUESTO_SUNAT, ByVal IM_DESCRIPCION_ As String, ByVal IM_ABREVIATURA_ As String, ByVal IM_TASA_ As Double, ByVal IM_CUENTA_ As String, ByVal IM_ISTATUS_ As Int32, ByVal IM_PERIODO_ As Int32, ByVal IM_MES_ As Int32, ByVal IM_USUARIO_ As String, ByVal IM_TERMINAL_ As String, ByVal IM_FECREG_ As String, ByVal IM_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal IM_IDTIPOIMPUESTO_ As SG_CO_TB_TIPO_IMPUESTO)
            _IM_IDTIPOIMPUESTO = IM_IDTIPOIMPUESTO_
            _IM_CODIGO = IM_CODIGO_
            _IM_CODIGO_SUNAT = IM_CODIGO_SUNAT_
            _IM_DESCRIPCION = IM_DESCRIPCION_
            _IM_ABREVIATURA = IM_ABREVIATURA_
            _IM_TASA = IM_TASA_
            _IM_CUENTA = IM_CUENTA_
            _IM_ISTATUS = IM_ISTATUS_
            _IM_PERIODO = IM_PERIODO_
            _IM_MES = IM_MES_
            _IM_USUARIO = IM_USUARIO_
            _IM_TERMINAL = IM_TERMINAL_
            _IM_FECREG = IM_FECREG_
            _IM_IDEMPRESA = IM_IDEMPRESA_
        End Sub
        Public Sub New()
            _IM_CODIGO = String.Empty
            _IM_CODIGO_SUNAT = Nothing
            _IM_DESCRIPCION = String.Empty
            _IM_ABREVIATURA = String.Empty
            _IM_TASA = 0.0R
            _IM_CUENTA = String.Empty
            _IM_ISTATUS = 0
            _IM_PERIODO = 0
            _IM_MES = 0
            _IM_USUARIO = String.Empty
            _IM_TERMINAL = String.Empty
            _IM_FECREG = String.Empty
            _IM_IDEMPRESA = Nothing
            _IM_IDTIPOIMPUESTO = Nothing
        End Sub

        Public Property IM_IDTIPOIMPUESTO() As SG_CO_TB_TIPO_IMPUESTO
            Get
                Return _IM_IDTIPOIMPUESTO
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_IMPUESTO)
                _IM_IDTIPOIMPUESTO = value
            End Set
        End Property

        Public Property IM_CODIGO() As String
            Get
                Return _IM_CODIGO
            End Get

            Set(ByVal value As String)
                _IM_CODIGO = value
            End Set
        End Property

        Public Property IM_CODIGO_SUNAT() As SG_CO_TB_IMPUESTO_SUNAT
            Get
                Return _IM_CODIGO_SUNAT
            End Get
            Set(ByVal value As SG_CO_TB_IMPUESTO_SUNAT)
                _IM_CODIGO_SUNAT = value
            End Set
        End Property

        Public Property IM_DESCRIPCION() As String
            Get
                Return _IM_DESCRIPCION
            End Get

            Set(ByVal value As String)
                _IM_DESCRIPCION = value
            End Set
        End Property

        Public Property IM_ABREVIATURA() As String
            Get
                Return _IM_ABREVIATURA
            End Get

            Set(ByVal value As String)
                _IM_ABREVIATURA = value
            End Set
        End Property

        Public Property IM_TASA() As Double
            Get
                Return _IM_TASA
            End Get
            Set(ByVal value As Double)
                _IM_TASA = value
            End Set
        End Property

        Public Property IM_CUENTA() As String
            Get
                Return _IM_CUENTA
            End Get

            Set(ByVal value As String)
                _IM_CUENTA = value
            End Set
        End Property

        Public Property IM_ISTATUS() As Int32
            Get
                Return _IM_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _IM_ISTATUS = value
            End Set
        End Property

        Public Property IM_PERIODO() As Int32
            Get
                Return _IM_PERIODO
            End Get

            Set(ByVal value As Int32)
                _IM_PERIODO = value
            End Set
        End Property

        Public Property IM_MES() As Int32
            Get
                Return _IM_MES
            End Get

            Set(ByVal value As Int32)
                _IM_MES = value
            End Set
        End Property

        Public Property IM_USUARIO() As String
            Get
                Return _IM_USUARIO
            End Get

            Set(ByVal value As String)
                _IM_USUARIO = value
            End Set
        End Property

        Public Property IM_TERMINAL() As String
            Get
                Return _IM_TERMINAL
            End Get

            Set(ByVal value As String)
                _IM_TERMINAL = value
            End Set
        End Property

        Public Property IM_FECREG() As DateTime
            Get
                Return _IM_FECREG
            End Get

            Set(ByVal value As DateTime)
                _IM_FECREG = value
            End Set
        End Property

        Public Property IM_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _IM_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _IM_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_TIPO_COMUNICACION
        Private _TC_ID As Int32
        Private _TC_DESCRIPCION As String

        Public Sub New(ByVal TC_ID_ As Int32, ByVal TC_DESCRIPCION_ As String)
            _TC_ID = TC_ID_
            _TC_DESCRIPCION = TC_DESCRIPCION_
        End Sub
        Public Sub New()
            _TC_ID = 0
            _TC_DESCRIPCION = String.Empty
        End Sub

        Public Property TC_ID() As Int32
            Get
                Return _TC_ID
            End Get
            Set(ByVal value As Int32)
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

    Public Class SG_CO_TB_FORM_TIPCAMB
        Private _FT_CODIGO As Integer
        Private _FT_DESCRIPCION As String

        Public Sub New(ByVal FT_CODIGO_ As Integer, ByVal FT_DESCRIPCION_ As String)
            _FT_CODIGO = FT_CODIGO_
            _FT_DESCRIPCION = FT_DESCRIPCION_
        End Sub
        Public Sub New()
            _FT_CODIGO = 0
            _FT_DESCRIPCION = String.Empty
        End Sub

        Public Property FT_CODIGO() As Integer
            Get
                Return _FT_CODIGO
            End Get
            Set(ByVal value As Integer)
                _FT_CODIGO = value
            End Set
        End Property

        Public Property FT_DESCRIPCION() As String
            Get
                Return _FT_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _FT_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_TIPOCAMBIO
        Private _TC_FECHA As String
        Private _TC_IDMONEDA As SG_CO_TB_MONEDA
        Private _TC_COMPRA As Double
        Private _TC_VENTA As Double
        Private _TC_USUARIO As String
        Private _TC_TERMINAL As String
        Private _TC_FECREG As String
        Private _TC_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal TC_FECHA_ As String, ByVal TC_IDMONEDA_ As SG_CO_TB_MONEDA, ByVal TC_COMPRA_ As Double, ByVal TC_VENTA_ As Double, ByVal TC_USUARIO_ As String, ByVal TC_TERMINAL_ As String, ByVal TC_FECREG_ As String, ByVal TC_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _TC_FECHA = TC_FECHA_
            _TC_IDMONEDA = TC_IDMONEDA_
            _TC_COMPRA = TC_COMPRA_
            _TC_VENTA = TC_VENTA_
            _TC_USUARIO = TC_USUARIO_
            _TC_TERMINAL = TC_TERMINAL_
            _TC_FECREG = TC_FECREG_
            _TC_IDEMPRESA = TC_IDEMPRESA_
        End Sub
        Public Sub New()
            _TC_FECHA = String.Empty
            _TC_IDMONEDA = Nothing
            _TC_COMPRA = 0.0R
            _TC_VENTA = 0.0R
            _TC_USUARIO = String.Empty
            _TC_TERMINAL = String.Empty
            _TC_FECREG = String.Empty
            _TC_IDEMPRESA = Nothing
        End Sub

        Public Property TC_FECHA() As String
            Get
                Return _TC_FECHA
            End Get

            Set(ByVal value As String)
                _TC_FECHA = value
            End Set
        End Property
        Public Property TC_IDMONEDA() As SG_CO_TB_MONEDA
            Get
                Return _TC_IDMONEDA
            End Get

            Set(ByVal value As SG_CO_TB_MONEDA)
                _TC_IDMONEDA = value
            End Set
        End Property
        Public Property TC_COMPRA() As Double
            Get
                Return _TC_COMPRA
            End Get

            Set(ByVal value As Double)
                _TC_COMPRA = value
            End Set
        End Property
        Public Property TC_VENTA() As Double
            Get
                Return _TC_VENTA
            End Get

            Set(ByVal value As Double)
                _TC_VENTA = value
            End Set
        End Property
        Public Property TC_USUARIO() As String
            Get
                Return _TC_USUARIO
            End Get

            Set(ByVal value As String)
                _TC_USUARIO = value
            End Set
        End Property
        Public Property TC_TERMINAL() As String
            Get
                Return _TC_TERMINAL
            End Get

            Set(ByVal value As String)
                _TC_TERMINAL = value
            End Set
        End Property
        Public Property TC_FECREG() As String
            Get
                Return _TC_FECREG
            End Get

            Set(ByVal value As String)
                _TC_FECREG = value
            End Set
        End Property
        Public Property TC_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _TC_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _TC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_USUARIO_PAGWEB
        Private _UP_IDUSUARIO As SG_CO_TB_USUARIO
        Private _UP_DIR_WEB As String
        Private _UP_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _UP_USUARIO As String
        Private _UP_TERMINAL As String
        Private _UP_FECREG As String

        Public Sub New(ByVal UP_IDUSUARIO_ As SG_CO_TB_USUARIO, ByVal UP_DIR_WEB_ As String, ByVal UP_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal UP_USUARIO_ As String, ByVal UP_TERMINAL_ As String, ByVal UP_FECREG_ As String)
            _UP_IDUSUARIO = UP_IDUSUARIO_
            _UP_DIR_WEB = UP_DIR_WEB_
            _UP_IDEMPRESA = UP_IDEMPRESA_
            _UP_USUARIO = UP_USUARIO_
            _UP_TERMINAL = UP_TERMINAL_
            _UP_FECREG = UP_FECREG_
        End Sub
        Public Sub New()
            _UP_IDUSUARIO = Nothing
            _UP_DIR_WEB = String.Empty
            _UP_IDEMPRESA = Nothing
            _UP_USUARIO = String.Empty
            _UP_TERMINAL = String.Empty
            _UP_FECREG = String.Empty
        End Sub

        Public Property UP_IDUSUARIO() As SG_CO_TB_USUARIO
            Get
                Return _UP_IDUSUARIO
            End Get
            Set(ByVal value As SG_CO_TB_USUARIO)
                _UP_IDUSUARIO = value
            End Set
        End Property

        Public Property UP_DIR_WEB() As String
            Get
                Return _UP_DIR_WEB
            End Get
            Set(ByVal value As String)
                _UP_DIR_WEB = value
            End Set
        End Property

        Public Property UP_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _UP_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _UP_IDEMPRESA = value
            End Set
        End Property

        Public Property UP_USUARIO() As String
            Get
                Return _UP_USUARIO
            End Get
            Set(ByVal value As String)
                _UP_USUARIO = value
            End Set
        End Property

        Public Property UP_TERMINAL() As String
            Get
                Return _UP_TERMINAL
            End Get
            Set(ByVal value As String)
                _UP_TERMINAL = value
            End Set
        End Property

        Public Property UP_FECREG() As String
            Get
                Return _UP_FECREG
            End Get
            Set(ByVal value As String)
                _UP_FECREG = value
            End Set
        End Property



    End Class

    Public Class SG_CO_TB_SALDO_CC
        Private _SC_ANHO As Int32
        Private _SC_MES As Int32
        Private _SC_CC_ID As SG_CO_TB_CENTROCOSTO
        Private _SC_CUENTA As String
        Private _SC_DEBE As Double
        Private _SC_HABER As Double
        Private _SC_DEBE_ACU As Double
        Private _SC_HABER_ACU As Double
        Private _SC_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal SC_ANHO_ As Int32, ByVal SC_MES_ As Int32, ByVal SC_CC_ID_ As SG_CO_TB_CENTROCOSTO, ByVal SC_CUENTA_ As String, ByVal SC_DEBE_ As Double, ByVal SC_HABER_ As Double, ByVal SC_DEBE_ACU_ As Double, ByVal SC_HABER_ACU_ As Double)
            _SC_IDEMPRESA = Nothing
            _SC_ANHO = SC_ANHO_
            _SC_MES = SC_MES_
            _SC_CC_ID = SC_CC_ID_
            _SC_CUENTA = SC_CUENTA_
            _SC_DEBE = SC_DEBE_
            _SC_HABER = SC_HABER_
            _SC_DEBE_ACU = SC_DEBE_ACU_
            _SC_HABER_ACU = SC_HABER_ACU_
        End Sub
        Public Sub New()
            _SC_ANHO = 0
            _SC_MES = 0
            _SC_CC_ID = Nothing
            _SC_CUENTA = String.Empty
            _SC_DEBE = 0.0R
            _SC_HABER = 0.0R
            _SC_DEBE_ACU = 0.0R
            _SC_HABER_ACU = 0.0R
            _SC_IDEMPRESA = Nothing
        End Sub

        Public Property SC_ANHO() As Int32
            Get
                Return _SC_ANHO
            End Get

            Set(ByVal value As Int32)
                _SC_ANHO = value
            End Set
        End Property
        Public Property SC_MES() As Int32
            Get
                Return _SC_MES
            End Get

            Set(ByVal value As Int32)
                _SC_MES = value
            End Set
        End Property
        Public Property SC_CC_ID() As SG_CO_TB_CENTROCOSTO
            Get
                Return _SC_CC_ID
            End Get

            Set(ByVal value As SG_CO_TB_CENTROCOSTO)
                _SC_CC_ID = value
            End Set
        End Property
        Public Property SC_CUENTA() As String
            Get
                Return _SC_CUENTA
            End Get

            Set(ByVal value As String)
                _SC_CUENTA = value
            End Set
        End Property
        Public Property SC_DEBE() As Double
            Get
                Return _SC_DEBE
            End Get

            Set(ByVal value As Double)
                _SC_DEBE = value
            End Set
        End Property
        Public Property SC_HABER() As Double
            Get
                Return _SC_HABER
            End Get

            Set(ByVal value As Double)
                _SC_HABER = value
            End Set
        End Property
        Public Property SC_DEBE_ACU() As Double
            Get
                Return _SC_DEBE_ACU
            End Get

            Set(ByVal value As Double)
                _SC_DEBE_ACU = value
            End Set
        End Property
        Public Property SC_HABER_ACU() As Double
            Get
                Return _SC_HABER_ACU
            End Get

            Set(ByVal value As Double)
                _SC_HABER_ACU = value
            End Set
        End Property
        Public Property SC_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _SC_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _SC_IDEMPRESA = value
            End Set
        End Property
    End Class
    Public Class SG_CO_TB_SALDO_CUENTA
        Private _SD_ANHO As Int32
        Private _SD_MES As Int32
        Private _SD_CUENTA As String
        Private _SD_DEBE As Double
        Private _SD_HABER As Double
        Private _SD_DEBE_ACU As Double
        Private _SD_HABER_ACU As Double
        Private _SD_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal SD_ANHO_ As Int32, ByVal SD_MES_ As Int32, ByVal SD_CUENTA_ As String, ByVal SD_DEBE_ As Double, ByVal SD_HABER_ As Double, ByVal SD_DEBE_ACU_ As Double, ByVal SD_HABER_ACU_ As Double, ByVal SD_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _SD_ANHO = SD_ANHO_
            _SD_MES = SD_MES_
            _SD_CUENTA = SD_CUENTA_
            _SD_DEBE = SD_DEBE_
            _SD_HABER = SD_HABER_
            _SD_DEBE_ACU = SD_DEBE_ACU_
            _SD_HABER_ACU = SD_HABER_ACU_
            _SD_IDEMPRESA = SD_IDEMPRESA_
        End Sub
        Public Sub New()
            _SD_ANHO = 0
            _SD_MES = 0
            _SD_CUENTA = String.Empty
            _SD_DEBE = 0.0R
            _SD_HABER = 0.0R
            _SD_DEBE_ACU = 0.0R
            _SD_HABER_ACU = 0.0R
            _SD_IDEMPRESA = Nothing
        End Sub

        Public Property SD_ANHO() As Int32
            Get
                Return _SD_ANHO
            End Get

            Set(ByVal value As Int32)
                _SD_ANHO = value
            End Set
        End Property
        Public Property SD_MES() As Int32
            Get
                Return _SD_MES
            End Get

            Set(ByVal value As Int32)
                _SD_MES = value
            End Set
        End Property
        Public Property SD_CUENTA() As String
            Get
                Return _SD_CUENTA
            End Get

            Set(ByVal value As String)
                _SD_CUENTA = value
            End Set
        End Property
        Public Property SD_DEBE() As Double
            Get
                Return _SD_DEBE
            End Get

            Set(ByVal value As Double)
                _SD_DEBE = value
            End Set
        End Property
        Public Property SD_HABER() As Double
            Get
                Return _SD_HABER
            End Get

            Set(ByVal value As Double)
                _SD_HABER = value
            End Set
        End Property
        Public Property SD_DEBE_ACU() As Double
            Get
                Return _SD_DEBE_ACU
            End Get

            Set(ByVal value As Double)
                _SD_DEBE_ACU = value
            End Set
        End Property
        Public Property SD_HABER_ACU() As Double
            Get
                Return _SD_HABER_ACU
            End Get

            Set(ByVal value As Double)
                _SD_HABER_ACU = value
            End Set
        End Property
        Public Property SD_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _SD_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _SD_IDEMPRESA = value
            End Set
        End Property
    End Class
    Public Class SG_CO_TB_SALDO_ANEXO

        Private _SA_IDCAB As SG_CO_TB_ASIENTO_CAB
        Private _SA_TIPO_ANEXO As SG_CO_TB_TIPOANEXO
        Private _SA_IDANEXO As SG_CO_TB_ANEXO
        Private _SA_CUENTA As String
        Private _SA_IDMONEDA As SG_CO_TB_MONEDA
        Private _SA_FECHA_DOC As String
        Private _SA_TIPO_DOC As SG_CO_TB_DOCUMENTO
        Private _SA_SERIE_DOC As String
        Private _SA_NUMERO_DOC As String
        Private _SA_DEBE As Double
        Private _SA_HABER As Double
        Private _SA_GLOSA As String
        Private _SA_ISTATUS As Int32
        Private _SA_EMP_ID As SG_CO_TB_EMPRESA
        Private _SA_TC As Double

        Public Sub New(ByVal SA_IDCAB_ As SG_CO_TB_ASIENTO_CAB, ByVal SA_TIPO_ANEXO_ As SG_CO_TB_TIPOANEXO, ByVal SA_IDANEXO_ As SG_CO_TB_ANEXO, ByVal SA_CUENTA_ As String, ByVal SA_IDMONEDA_ As SG_CO_TB_MONEDA, ByVal SA_FECHA_DOC_ As String, ByVal SA_TIPO_DOC_ As SG_CO_TB_DOCUMENTO, ByVal SA_SERIE_DOC_ As String, ByVal SA_NUMERO_DOC_ As String, ByVal SA_DEBE_ As Double, ByVal SA_HABER_ As Double, ByVal SA_GLOSA_ As String, ByVal SA_ISTATUS_ As Int32, ByVal SA_EMP_ID_ As SG_CO_TB_EMPRESA, ByVal SA_TC_ As Double)
            _SA_IDCAB = SA_IDCAB_
            _SA_TIPO_ANEXO = SA_TIPO_ANEXO_
            _SA_IDANEXO = SA_IDANEXO_
            _SA_CUENTA = SA_CUENTA_
            _SA_IDMONEDA = SA_IDMONEDA_
            _SA_FECHA_DOC = SA_FECHA_DOC_
            _SA_TIPO_DOC = SA_TIPO_DOC_
            _SA_SERIE_DOC = SA_SERIE_DOC_
            _SA_NUMERO_DOC = SA_NUMERO_DOC_
            _SA_DEBE = SA_DEBE_
            _SA_HABER = SA_HABER_
            _SA_GLOSA = SA_GLOSA_
            _SA_ISTATUS = SA_ISTATUS_
            _SA_EMP_ID = SA_EMP_ID_
            _SA_TC = SA_TC_
        End Sub
        Public Sub New()
            _SA_IDCAB = Nothing
            _SA_TIPO_ANEXO = Nothing
            _SA_IDANEXO = Nothing
            _SA_CUENTA = String.Empty
            _SA_IDMONEDA = Nothing
            _SA_FECHA_DOC = String.Empty
            _SA_TIPO_DOC = Nothing
            _SA_SERIE_DOC = String.Empty
            _SA_NUMERO_DOC = String.Empty
            _SA_DEBE = 0.0R
            _SA_HABER = 0.0R
            _SA_GLOSA = String.Empty
            _SA_ISTATUS = 0
            _SA_EMP_ID = Nothing
            _SA_TC = 0.0R
        End Sub

        Public Property SA_IDCAB() As SG_CO_TB_ASIENTO_CAB
            Get
                Return _SA_IDCAB
            End Get

            Set(ByVal value As SG_CO_TB_ASIENTO_CAB)
                _SA_IDCAB = value
            End Set
        End Property
        Public Property SA_TIPO_ANEXO() As SG_CO_TB_TIPOANEXO
            Get
                Return _SA_TIPO_ANEXO
            End Get

            Set(ByVal value As SG_CO_TB_TIPOANEXO)
                _SA_TIPO_ANEXO = value
            End Set
        End Property
        Public Property SA_IDANEXO() As SG_CO_TB_ANEXO
            Get
                Return _SA_IDANEXO
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _SA_IDANEXO = value
            End Set
        End Property
        Public Property SA_CUENTA() As String
            Get
                Return _SA_CUENTA
            End Get

            Set(ByVal value As String)
                _SA_CUENTA = value
            End Set
        End Property
        Public Property SA_IDMONEDA() As SG_CO_TB_MONEDA
            Get
                Return _SA_IDMONEDA
            End Get

            Set(ByVal value As SG_CO_TB_MONEDA)
                _SA_IDMONEDA = value
            End Set
        End Property
        Public Property SA_FECHA_DOC() As String
            Get
                Return _SA_FECHA_DOC
            End Get

            Set(ByVal value As String)
                _SA_FECHA_DOC = value
            End Set
        End Property
        Public Property SA_TIPO_DOC() As SG_CO_TB_DOCUMENTO
            Get
                Return _SA_TIPO_DOC
            End Get

            Set(ByVal value As SG_CO_TB_DOCUMENTO)
                _SA_TIPO_DOC = value
            End Set
        End Property
        Public Property SA_SERIE_DOC() As String
            Get
                Return _SA_SERIE_DOC
            End Get

            Set(ByVal value As String)
                _SA_SERIE_DOC = value
            End Set
        End Property
        Public Property SA_NUMERO_DOC() As String
            Get
                Return _SA_NUMERO_DOC
            End Get

            Set(ByVal value As String)
                _SA_NUMERO_DOC = value
            End Set
        End Property
        Public Property SA_DEBE() As Double
            Get
                Return _SA_DEBE
            End Get

            Set(ByVal value As Double)
                _SA_DEBE = value
            End Set
        End Property
        Public Property SA_HABER() As Double
            Get
                Return _SA_HABER
            End Get

            Set(ByVal value As Double)
                _SA_HABER = value
            End Set
        End Property
        Public Property SA_GLOSA() As String
            Get
                Return _SA_GLOSA
            End Get

            Set(ByVal value As String)
                _SA_GLOSA = value
            End Set
        End Property
        Public Property SA_ISTATUS() As Int32
            Get
                Return _SA_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _SA_ISTATUS = value
            End Set
        End Property
        Public Property SA_EMP_ID() As SG_CO_TB_EMPRESA
            Get
                Return _SA_EMP_ID
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _SA_EMP_ID = value
            End Set
        End Property
        Public Property SA_TC() As Double
            Get
                Return _SA_TC
            End Get

            Set(ByVal value As Double)
                _SA_TC = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_ASIENTO_DET

        Private _AD_IDCAB As SG_CO_TB_ASIENTO_CAB
        Private _AD_IDDET As Integer
        Private _AD_SECUENCIA As Int32
        Private _AD_CUENTA As String
        Private _AD_TANEXO As SG_CO_TB_TIPOANEXO
        Private _AD_IDANEXO As SG_CO_TB_ANEXO
        Private _AD_TDOC As SG_CO_TB_DOCUMENTO
        Private _AD_SDOC As String
        Private _AD_NDOC As String
        Private _AD_FDOC As String
        Private _AD_VDOC As String
        Private _AD_DEBE As Double
        Private _AD_HABER As Double
        Private _AD_TCAM As Double
        Private _AD_SEC_ORI_DESTINO As Int32
        Private _AD_GLOSA As String
        Private _AD_IDCC As SG_CO_TB_CENTROCOSTO
        Private _AD_ES_DESTINO As Int32
        Private _AD_USUARIO As String
        Private _AD_TERMINAL As String
        Private _AD_FECREG As String
        Private _AD_IDMEDIOPAGO As SG_CO_TB_MEDIOPAGO
        Private _AD_MONTO_ORI As Double
        Private _AD_PORCE_DESTINO As Double
        Private _AD_ES_CONCI As Integer
        Private _AD_ANHO_CONI As Integer
        Private _AD_MES_CONCI As Integer
        Private _AD_ES_INAFECTO As Integer
        Private _AD_ES_CONCI_ITF As Integer
        Private _AD_ES_DETRA As Integer


        Public Sub New(ByVal AD_IDCAB_ As SG_CO_TB_ASIENTO_CAB, ByVal AD_SECUENCIA_ As Int32, ByVal AD_CUENTA_ As String, ByVal AD_TANEXO_ As SG_CO_TB_TIPOANEXO, ByVal AD_IDANEXO_ As SG_CO_TB_ANEXO, ByVal AD_TDOC_ As SG_CO_TB_DOCUMENTO, ByVal AD_SDOC_ As String, ByVal AD_NDOC_ As String, ByVal AD_FDOC_ As String, ByVal AD_VDOC_ As String, ByVal AD_DEBE_ As Double, ByVal AD_HABER_ As Double, ByVal AD_TCAM_ As Double, ByVal AD_SEC_ORI_DESTINO_ As Int32, ByVal AD_GLOSA_ As String, ByVal AD_IDCC_ As SG_CO_TB_CENTROCOSTO, ByVal AD_ES_DESTINO_ As Int32, ByVal AD_USUARIO_ As String, ByVal AD_TERMINAL_ As String, ByVal AD_FECREG_ As String, ByVal AD_IDMEDIOPAGO_ As SG_CO_TB_MEDIOPAGO, ByVal AD_MONTO_ORI_ As Double, ByVal AD_PORCE_DESTINO_ As Double, ByVal AD_IDDET_ As Integer, ByVal AD_ES_CONCI_ As Integer, ByVal AD_ANHO_CONI_ As Integer, ByVal AD_MES_CONCI_ As Integer, ByVal AD_ES_INAFECTO_ As Integer, ByVal AD_ES_CONCI_ITF_ As Integer, ByVal AD_ES_DETRA_ As Integer)
            _AD_ES_DETRA = AD_ES_DETRA_
            _AD_ES_CONCI_ITF = AD_ES_CONCI_ITF_
            _AD_ES_INAFECTO = AD_ES_INAFECTO_
            _AD_ANHO_CONI = AD_ANHO_CONI_
            _AD_MES_CONCI = AD_MES_CONCI_
            _AD_IDDET = AD_IDDET_
            _AD_ES_CONCI = AD_ES_CONCI_
            _AD_PORCE_DESTINO = AD_PORCE_DESTINO_
            _AD_MONTO_ORI = AD_MONTO_ORI_
            _AD_IDMEDIOPAGO = AD_IDMEDIOPAGO_
            _AD_IDCAB = AD_IDCAB_
            _AD_SECUENCIA = AD_SECUENCIA_
            _AD_CUENTA = AD_CUENTA_
            _AD_TANEXO = AD_TANEXO_
            _AD_IDANEXO = AD_IDANEXO_
            _AD_TDOC = AD_TDOC_
            _AD_SDOC = AD_SDOC_
            _AD_NDOC = AD_NDOC_
            _AD_FDOC = AD_FDOC_
            _AD_VDOC = AD_VDOC_
            _AD_DEBE = AD_DEBE_
            _AD_HABER = AD_HABER_
            _AD_TCAM = AD_TCAM_
            _AD_SEC_ORI_DESTINO = AD_SEC_ORI_DESTINO_
            _AD_GLOSA = AD_GLOSA_
            _AD_IDCC = AD_IDCC_
            _AD_ES_DESTINO = AD_ES_DESTINO_
            _AD_USUARIO = AD_USUARIO_
            _AD_TERMINAL = AD_TERMINAL_
            _AD_FECREG = AD_FECREG_
        End Sub
        Public Sub New()
            _AD_ES_DETRA = 0
            _AD_ES_CONCI_ITF = 0
            _AD_ES_INAFECTO = 0
            _AD_ANHO_CONI = 0
            _AD_MES_CONCI = 0
            _AD_ES_CONCI = 0
            _AD_IDDET = 0
            _AD_IDCAB = Nothing
            _AD_SECUENCIA = 0
            _AD_CUENTA = String.Empty
            _AD_TANEXO = Nothing
            _AD_IDANEXO = Nothing
            _AD_TDOC = Nothing
            _AD_SDOC = String.Empty
            _AD_NDOC = String.Empty
            _AD_FDOC = String.Empty
            _AD_VDOC = String.Empty
            _AD_DEBE = 0.0R
            _AD_HABER = 0.0R
            _AD_TCAM = 0.0R
            _AD_SEC_ORI_DESTINO = 0
            _AD_GLOSA = String.Empty
            _AD_IDCC = Nothing
            _AD_ES_DESTINO = 0
            _AD_USUARIO = String.Empty
            _AD_TERMINAL = String.Empty
            _AD_FECREG = String.Empty
            _AD_IDMEDIOPAGO = Nothing
            _AD_MONTO_ORI = 0.0R
            _AD_PORCE_DESTINO = 0.0R
        End Sub

        Public Property AD_ES_DETRA() As Integer
            Get
                Return _AD_ES_DETRA
            End Get
            Set(ByVal value As Integer)
                _AD_ES_DETRA = value
            End Set
        End Property

        Public Property AD_ES_CONCI_ITF() As Integer
            Get
                Return _AD_ES_CONCI_ITF
            End Get
            Set(ByVal value As Integer)
                _AD_ES_CONCI_ITF = value
            End Set
        End Property

        Public Property AD_ES_INAFECTO() As Integer
            Get
                Return _AD_ES_INAFECTO
            End Get
            Set(ByVal value As Integer)
                _AD_ES_INAFECTO = value
            End Set
        End Property

        Public Property AD_ANHO_CONI() As Integer
            Get
                Return _AD_ANHO_CONI
            End Get
            Set(ByVal value As Integer)
                _AD_ANHO_CONI = value
            End Set
        End Property

        Public Property AD_MES_CONCI() As Integer
            Get
                Return _AD_MES_CONCI
            End Get
            Set(ByVal value As Integer)
                _AD_MES_CONCI = value
            End Set
        End Property

        Public Property AD_IDDET() As Integer
            Get
                Return _AD_IDDET
            End Get
            Set(ByVal value As Integer)
                _AD_IDDET = value
            End Set
        End Property

        Public Property AD_ES_CONCI() As Integer
            Get
                Return _AD_ES_CONCI
            End Get
            Set(ByVal value As Integer)
                _AD_ES_CONCI = value
            End Set
        End Property

        Public Property AD_PORCE_DESTINO() As Double
            Get
                Return _AD_PORCE_DESTINO
            End Get
            Set(ByVal value As Double)
                _AD_PORCE_DESTINO = value
            End Set
        End Property

        Public Property AD_MONTO_ORI() As Double
            Get
                Return _AD_MONTO_ORI
            End Get
            Set(ByVal value As Double)
                _AD_MONTO_ORI = value
            End Set
        End Property

        Public Property AD_IDMEDIOPAGO() As SG_CO_TB_MEDIOPAGO
            Get
                Return _AD_IDMEDIOPAGO
            End Get
            Set(ByVal value As SG_CO_TB_MEDIOPAGO)
                _AD_IDMEDIOPAGO = value
            End Set
        End Property

        Public Property AD_TCAM() As Double
            Get
                Return _AD_TCAM
            End Get
            Set(ByVal value As Double)
                _AD_TCAM = value
            End Set
        End Property

        Public Property AD_IDCAB() As SG_CO_TB_ASIENTO_CAB
            Get
                Return _AD_IDCAB
            End Get

            Set(ByVal value As SG_CO_TB_ASIENTO_CAB)
                _AD_IDCAB = value
            End Set
        End Property

        Public Property AD_SECUENCIA() As Int32
            Get
                Return _AD_SECUENCIA
            End Get

            Set(ByVal value As Int32)
                _AD_SECUENCIA = value
            End Set
        End Property

        Public Property AD_CUENTA() As String
            Get
                Return _AD_CUENTA
            End Get

            Set(ByVal value As String)
                _AD_CUENTA = value
            End Set
        End Property

        Public Property AD_TANEXO() As SG_CO_TB_TIPOANEXO
            Get
                Return _AD_TANEXO
            End Get

            Set(ByVal value As SG_CO_TB_TIPOANEXO)
                _AD_TANEXO = value
            End Set
        End Property

        Public Property AD_IDANEXO() As SG_CO_TB_ANEXO
            Get
                Return _AD_IDANEXO
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _AD_IDANEXO = value
            End Set
        End Property

        Public Property AD_TDOC() As SG_CO_TB_DOCUMENTO
            Get
                Return _AD_TDOC
            End Get

            Set(ByVal value As SG_CO_TB_DOCUMENTO)
                _AD_TDOC = value
            End Set
        End Property

        Public Property AD_SDOC() As String
            Get
                Return _AD_SDOC
            End Get

            Set(ByVal value As String)
                _AD_SDOC = value
            End Set
        End Property

        Public Property AD_NDOC() As String
            Get
                Return _AD_NDOC
            End Get

            Set(ByVal value As String)
                _AD_NDOC = value
            End Set
        End Property

        Public Property AD_FDOC() As String
            Get
                Return _AD_FDOC
            End Get

            Set(ByVal value As String)
                _AD_FDOC = value
            End Set
        End Property

        Public Property AD_VDOC() As String
            Get
                Return _AD_VDOC
            End Get

            Set(ByVal value As String)
                _AD_VDOC = value
            End Set
        End Property

        Public Property AD_DEBE() As Double
            Get
                Return _AD_DEBE
            End Get

            Set(ByVal value As Double)
                _AD_DEBE = value
            End Set
        End Property

        Public Property AD_HABER() As Double
            Get
                Return _AD_HABER
            End Get

            Set(ByVal value As Double)
                _AD_HABER = value
            End Set
        End Property

        Public Property AD_SEC_ORI_DESTINO() As Int32
            Get
                Return _AD_SEC_ORI_DESTINO
            End Get

            Set(ByVal value As Int32)
                _AD_SEC_ORI_DESTINO = value
            End Set
        End Property

        Public Property AD_GLOSA() As String
            Get
                Return _AD_GLOSA
            End Get

            Set(ByVal value As String)
                _AD_GLOSA = value
            End Set
        End Property

        Public Property AD_IDCC() As SG_CO_TB_CENTROCOSTO
            Get
                Return _AD_IDCC
            End Get

            Set(ByVal value As SG_CO_TB_CENTROCOSTO)
                _AD_IDCC = value
            End Set
        End Property

        Public Property AD_ES_DESTINO() As Int32
            Get
                Return _AD_ES_DESTINO
            End Get

            Set(ByVal value As Int32)
                _AD_ES_DESTINO = value
            End Set
        End Property

        Public Property AD_USUARIO() As String
            Get
                Return _AD_USUARIO
            End Get

            Set(ByVal value As String)
                _AD_USUARIO = value
            End Set
        End Property

        Public Property AD_TERMINAL() As String
            Get
                Return _AD_TERMINAL
            End Get

            Set(ByVal value As String)
                _AD_TERMINAL = value
            End Set
        End Property

        Public Property AD_FECREG() As String
            Get
                Return _AD_FECREG
            End Get

            Set(ByVal value As String)
                _AD_FECREG = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_COMPRAS

        Private _CO_IDCAB As SG_CO_TB_ASIENTO_CAB
        Private _CO_TIPO_ANEXO As SG_CO_TB_TIPOANEXO
        Private _CO_ANEXO_ID As SG_CO_TB_ANEXO
        Private _CO_TIP_DOC As SG_CO_TB_DOCUMENTO
        Private _CO_SER_DOC As String
        Private _CO_NUM_DOC As String
        Private _CO_INDICADOR_DESTINO As String
        Private _CO_FEC_EMI As String
        Private _CO_FEC_VEN As String
        Private _CO_FEC_VOU As String
        Private _CO_TIP_DOC_REF As SG_CO_TB_DOCUMENTO
        Private _CO_SER_DOC_REF As String
        Private _CO_NUM_DOC_REF As String
        Private _CO_FEC_EMI_REF As String
        Private _CO_TASA_IGV As Double
        Private _CO_MONTO_IGV As Double
        Private _CO_MONTO_EXONERADO As Double
        Private _CO_TASA_ISC As Double
        Private _CO_MONTO_ISC As Double
        Private _CO_OTROS_TRIBUTOS As Double
        Private _CO_IMPORTE_COMPRA As Double
        Private _CO_IMPORTE_VENTA As Double
        Private _CO_ES_AFECTO_DETRA As Int32
        Private _CO_TASA_DETRA As Double
        Private _CO_IMPORTE_DETRA As Double
        Private _CO_VALOR_RAZ_DETRA As Double
        Private _CO_NUMERO_DETRA As String
        Private _CO_FEC_EMI_DETRA As String
        Private _CO_TIPO_SERV_DETRA As String
        Private _CO_SERV_DETRA As String
        Private _CO_ES_AFECTO_PERCEP As Int32
        Private _CO_TASA_PERCEP As Double
        Private _CO_ISTATUS As Int32
        Private _CO_IMPORTE_PAGAR As Double
        Private _CO_TASA_4TA As Double
        Private _CO_TOTAL_HONO As Double
        Private _CO_MONTO_RET As Double
        Private _CO_MONTO_PERCI As Double

        Public Sub New(ByVal CO_IDCAB_ As SG_CO_TB_ASIENTO_CAB, ByVal CO_TIPO_ANEXO_ As SG_CO_TB_TIPOANEXO, ByVal CO_ANEXO_ID_ As SG_CO_TB_ANEXO, ByVal CO_TIP_DOC_ As SG_CO_TB_DOCUMENTO, _
                       ByVal CO_SER_DOC_ As String, ByVal CO_NUM_DOC_ As String, ByVal CO_INDICADOR_DESTINO_ As String, ByVal CO_FEC_EMI_ As String, ByVal CO_FEC_VEN_ As String, ByVal CO_FEC_VOU_ As String, ByVal CO_TIP_DOC_REF_ As SG_CO_TB_DOCUMENTO, ByVal CO_SER_DOC_REF_ As String, ByVal CO_NUM_DOC_REF_ As String, ByVal CO_FEC_EMI_REF_ As String, ByVal CO_TASA_IGV_ As Double, ByVal CO_MONTO_IGV_ As Double, ByVal CO_MONTO_EXONERADO_ As Double, ByVal CO_TASA_ISC_ As Double, ByVal CO_MONTO_ISC_ As Double, ByVal CO_OTROS_TRIBUTOS_ As Double, ByVal CO_IMPORTE_COMPRA_ As Double, ByVal CO_IMPORTE_VENTA_ As Double, ByVal CO_ES_AFECTO_DETRA_ As Int32, ByVal CO_TASA_DETRA_ As Double, ByVal CO_IMPORTE_DETRA_ As Double, ByVal CO_VALOR_RAZ_DETRA_ As Double, ByVal CO_NUMERO_DETRA_ As String, ByVal CO_FEC_EMI_DETRA_ As String, ByVal CO_TIPO_SERV_DETRA_ As String, ByVal CO_SERV_DETRA_ As String, ByVal CO_ES_AFECTO_PERCEP_ As Int32, ByVal CO_TASA_PERCEP_ As Double, ByVal CO_ISTATUS_ As Int32, ByVal CO_IMPORTE_PAGAR_ As Double, ByVal CO_TASA_4TA_ As Double, ByVal CO_TOTAL_HONO_ As Double, ByVal CO_MONTO_RET_ As Double, ByVal CO_MONTO_PERCI_ As Double)
            _CO_IDCAB = CO_IDCAB_
            _CO_TIPO_ANEXO = CO_TIPO_ANEXO_
            _CO_ANEXO_ID = CO_ANEXO_ID_
            _CO_TIP_DOC = CO_TIP_DOC_
            _CO_SER_DOC = CO_SER_DOC_
            _CO_NUM_DOC = CO_NUM_DOC_
            _CO_INDICADOR_DESTINO = CO_INDICADOR_DESTINO_
            _CO_FEC_EMI = CO_FEC_EMI_
            _CO_FEC_VEN = CO_FEC_VEN_
            _CO_FEC_VOU = CO_FEC_VOU_
            _CO_TIP_DOC_REF = CO_TIP_DOC_REF_
            _CO_SER_DOC_REF = CO_SER_DOC_REF_
            _CO_NUM_DOC_REF = CO_NUM_DOC_REF_
            _CO_FEC_EMI_REF = CO_FEC_EMI_REF_
            _CO_TASA_IGV = CO_TASA_IGV_
            _CO_MONTO_IGV = CO_MONTO_IGV_
            _CO_MONTO_EXONERADO = CO_MONTO_EXONERADO_
            _CO_TASA_ISC = CO_TASA_ISC_
            _CO_MONTO_ISC = CO_MONTO_ISC_
            _CO_OTROS_TRIBUTOS = CO_OTROS_TRIBUTOS_
            _CO_IMPORTE_COMPRA = CO_IMPORTE_COMPRA_
            _CO_IMPORTE_VENTA = CO_IMPORTE_VENTA_
            _CO_ES_AFECTO_DETRA = CO_ES_AFECTO_DETRA_
            _CO_TASA_DETRA = CO_TASA_DETRA_
            _CO_IMPORTE_DETRA = CO_IMPORTE_DETRA_
            _CO_VALOR_RAZ_DETRA = CO_VALOR_RAZ_DETRA_
            _CO_NUMERO_DETRA = CO_NUMERO_DETRA_
            _CO_FEC_EMI_DETRA = CO_FEC_EMI_DETRA_
            _CO_TIPO_SERV_DETRA = CO_TIPO_SERV_DETRA_
            _CO_SERV_DETRA = CO_SERV_DETRA_
            _CO_ES_AFECTO_PERCEP = CO_ES_AFECTO_PERCEP_
            _CO_TASA_PERCEP = CO_TASA_PERCEP_
            _CO_ISTATUS = CO_ISTATUS_
            _CO_IMPORTE_PAGAR = CO_IMPORTE_PAGAR_
            _CO_TASA_4TA = CO_TASA_4TA_
            _CO_TOTAL_HONO = CO_TOTAL_HONO_
            _CO_MONTO_RET = CO_MONTO_RET_
            _CO_MONTO_PERCI = CO_MONTO_PERCI_
        End Sub
        Public Sub New()
            _CO_IDCAB = Nothing
            _CO_TIPO_ANEXO = Nothing
            _CO_ANEXO_ID = Nothing
            _CO_TIP_DOC = Nothing
            _CO_SER_DOC = String.Empty
            _CO_NUM_DOC = String.Empty
            _CO_INDICADOR_DESTINO = String.Empty
            _CO_FEC_EMI = String.Empty
            _CO_FEC_VEN = String.Empty
            _CO_FEC_VOU = String.Empty
            _CO_TIP_DOC_REF = Nothing
            _CO_SER_DOC_REF = String.Empty
            _CO_NUM_DOC_REF = String.Empty
            _CO_FEC_EMI_REF = String.Empty
            _CO_TASA_IGV = 0.0R
            _CO_MONTO_IGV = 0.0R
            _CO_MONTO_EXONERADO = 0.0R
            _CO_TASA_ISC = 0.0R
            _CO_MONTO_ISC = 0.0R
            _CO_OTROS_TRIBUTOS = 0.0R
            _CO_IMPORTE_COMPRA = 0.0R
            _CO_IMPORTE_VENTA = 0.0R
            _CO_ES_AFECTO_DETRA = 0
            _CO_TASA_DETRA = 0.0R
            _CO_IMPORTE_DETRA = 0.0R
            _CO_VALOR_RAZ_DETRA = 0.0R
            _CO_NUMERO_DETRA = String.Empty
            _CO_FEC_EMI_DETRA = String.Empty
            _CO_TIPO_SERV_DETRA = String.Empty
            _CO_SERV_DETRA = String.Empty
            _CO_ES_AFECTO_PERCEP = 0
            _CO_TASA_PERCEP = 0.0R
            _CO_ISTATUS = 0
            _CO_IMPORTE_PAGAR = 0.0R
            _CO_TASA_4TA = 0.0R
            _CO_TOTAL_HONO = 0.0R
            _CO_MONTO_RET = 0.0R
            _CO_MONTO_PERCI = 0.0R
        End Sub

        Public Property CO_IDCAB() As SG_CO_TB_ASIENTO_CAB
            Get
                Return _CO_IDCAB
            End Get

            Set(ByVal value As SG_CO_TB_ASIENTO_CAB)
                _CO_IDCAB = value
            End Set
        End Property

        Public Property CO_TIPO_ANEXO() As SG_CO_TB_TIPOANEXO
            Get
                Return _CO_TIPO_ANEXO
            End Get

            Set(ByVal value As SG_CO_TB_TIPOANEXO)
                _CO_TIPO_ANEXO = value
            End Set
        End Property

        Public Property CO_ANEXO_ID() As SG_CO_TB_ANEXO
            Get
                Return _CO_ANEXO_ID
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _CO_ANEXO_ID = value
            End Set
        End Property

        Public Property CO_TIP_DOC() As SG_CO_TB_DOCUMENTO
            Get
                Return _CO_TIP_DOC
            End Get

            Set(ByVal value As SG_CO_TB_DOCUMENTO)
                _CO_TIP_DOC = value
            End Set
        End Property

        Public Property CO_SER_DOC() As String
            Get
                Return _CO_SER_DOC
            End Get

            Set(ByVal value As String)
                _CO_SER_DOC = value
            End Set
        End Property

        Public Property CO_NUM_DOC() As String
            Get
                Return _CO_NUM_DOC
            End Get

            Set(ByVal value As String)
                _CO_NUM_DOC = value
            End Set
        End Property

        Public Property CO_INDICADOR_DESTINO() As String
            Get
                Return _CO_INDICADOR_DESTINO
            End Get

            Set(ByVal value As String)
                _CO_INDICADOR_DESTINO = value
            End Set
        End Property

        Public Property CO_FEC_EMI() As String
            Get
                Return _CO_FEC_EMI
            End Get

            Set(ByVal value As String)
                _CO_FEC_EMI = value
            End Set
        End Property

        Public Property CO_FEC_VEN() As String
            Get
                Return _CO_FEC_VEN
            End Get

            Set(ByVal value As String)
                _CO_FEC_VEN = value
            End Set
        End Property

        Public Property CO_FEC_VOU() As String
            Get
                Return _CO_FEC_VOU
            End Get

            Set(ByVal value As String)
                _CO_FEC_VOU = value
            End Set
        End Property

        Public Property CO_TIP_DOC_REF() As SG_CO_TB_DOCUMENTO
            Get
                Return _CO_TIP_DOC_REF
            End Get

            Set(ByVal value As SG_CO_TB_DOCUMENTO)
                _CO_TIP_DOC_REF = value
            End Set
        End Property

        Public Property CO_SER_DOC_REF() As String
            Get
                Return _CO_SER_DOC_REF
            End Get

            Set(ByVal value As String)
                _CO_SER_DOC_REF = value
            End Set
        End Property

        Public Property CO_NUM_DOC_REF() As String
            Get
                Return _CO_NUM_DOC_REF
            End Get

            Set(ByVal value As String)
                _CO_NUM_DOC_REF = value
            End Set
        End Property

        Public Property CO_FEC_EMI_REF() As String
            Get
                Return _CO_FEC_EMI_REF
            End Get

            Set(ByVal value As String)
                _CO_FEC_EMI_REF = value
            End Set
        End Property

        Public Property CO_TASA_IGV() As Double
            Get
                Return _CO_TASA_IGV
            End Get

            Set(ByVal value As Double)
                _CO_TASA_IGV = value
            End Set
        End Property

        Public Property CO_MONTO_IGV() As Double
            Get
                Return _CO_MONTO_IGV
            End Get

            Set(ByVal value As Double)
                _CO_MONTO_IGV = value
            End Set
        End Property

        Public Property CO_MONTO_EXONERADO() As Double
            Get
                Return _CO_MONTO_EXONERADO
            End Get

            Set(ByVal value As Double)
                _CO_MONTO_EXONERADO = value
            End Set
        End Property

        Public Property CO_TASA_ISC() As Double
            Get
                Return _CO_TASA_ISC
            End Get

            Set(ByVal value As Double)
                _CO_TASA_ISC = value
            End Set
        End Property

        Public Property CO_MONTO_ISC() As Double
            Get
                Return _CO_MONTO_ISC
            End Get

            Set(ByVal value As Double)
                _CO_MONTO_ISC = value
            End Set
        End Property

        Public Property CO_OTROS_TRIBUTOS() As Double
            Get
                Return _CO_OTROS_TRIBUTOS
            End Get

            Set(ByVal value As Double)
                _CO_OTROS_TRIBUTOS = value
            End Set
        End Property

        Public Property CO_IMPORTE_COMPRA() As Double
            Get
                Return _CO_IMPORTE_COMPRA
            End Get

            Set(ByVal value As Double)
                _CO_IMPORTE_COMPRA = value
            End Set
        End Property

        Public Property CO_IMPORTE_VENTA() As Double
            Get
                Return _CO_IMPORTE_VENTA
            End Get

            Set(ByVal value As Double)
                _CO_IMPORTE_VENTA = value
            End Set
        End Property

        Public Property CO_ES_AFECTO_DETRA() As Int32
            Get
                Return _CO_ES_AFECTO_DETRA
            End Get

            Set(ByVal value As Int32)
                _CO_ES_AFECTO_DETRA = value
            End Set
        End Property

        Public Property CO_TASA_DETRA() As Double
            Get
                Return _CO_TASA_DETRA
            End Get

            Set(ByVal value As Double)
                _CO_TASA_DETRA = value
            End Set
        End Property

        Public Property CO_IMPORTE_DETRA() As Double
            Get
                Return _CO_IMPORTE_DETRA
            End Get

            Set(ByVal value As Double)
                _CO_IMPORTE_DETRA = value
            End Set
        End Property

        Public Property CO_VALOR_RAZ_DETRA() As Double
            Get
                Return _CO_VALOR_RAZ_DETRA
            End Get

            Set(ByVal value As Double)
                _CO_VALOR_RAZ_DETRA = value
            End Set
        End Property

        Public Property CO_NUMERO_DETRA() As String
            Get
                Return _CO_NUMERO_DETRA
            End Get

            Set(ByVal value As String)
                _CO_NUMERO_DETRA = value
            End Set
        End Property

        Public Property CO_FEC_EMI_DETRA() As String
            Get
                Return _CO_FEC_EMI_DETRA
            End Get

            Set(ByVal value As String)
                _CO_FEC_EMI_DETRA = value
            End Set
        End Property

        Public Property CO_TIPO_SERV_DETRA() As String
            Get
                Return _CO_TIPO_SERV_DETRA
            End Get

            Set(ByVal value As String)
                _CO_TIPO_SERV_DETRA = value
            End Set
        End Property

        Public Property CO_SERV_DETRA() As String
            Get
                Return _CO_SERV_DETRA
            End Get

            Set(ByVal value As String)
                _CO_SERV_DETRA = value
            End Set
        End Property

        Public Property CO_ES_AFECTO_PERCEP() As Int32
            Get
                Return _CO_ES_AFECTO_PERCEP
            End Get

            Set(ByVal value As Int32)
                _CO_ES_AFECTO_PERCEP = value
            End Set
        End Property

        Public Property CO_TASA_PERCEP() As Double
            Get
                Return _CO_TASA_PERCEP
            End Get

            Set(ByVal value As Double)
                _CO_TASA_PERCEP = value
            End Set
        End Property

        Public Property CO_ISTATUS() As Int32
            Get
                Return _CO_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _CO_ISTATUS = value
            End Set
        End Property

        Public Property CO_IMPORTE_PAGAR() As Double
            Get
                Return _CO_IMPORTE_PAGAR
            End Get

            Set(ByVal value As Double)
                _CO_IMPORTE_PAGAR = value
            End Set
        End Property

        Public Property CO_TASA_4TA() As Double
            Get
                Return _CO_TASA_4TA
            End Get

            Set(ByVal value As Double)
                _CO_TASA_4TA = value
            End Set
        End Property

        Public Property CO_TOTAL_HONO() As Double
            Get
                Return _CO_TOTAL_HONO
            End Get

            Set(ByVal value As Double)
                _CO_TOTAL_HONO = value
            End Set
        End Property

        Public Property CO_MONTO_RET() As Double
            Get
                Return _CO_MONTO_RET
            End Get

            Set(ByVal value As Double)
                _CO_MONTO_RET = value
            End Set
        End Property

        Public Property CO_MONTO_PERCI() As Double
            Get
                Return _CO_MONTO_PERCI
            End Get

            Set(ByVal value As Double)
                _CO_MONTO_PERCI = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_VENTAS

        Private _VE_IDCAB As SG_CO_TB_ASIENTO_CAB
        Private _VE_TIPO_ANEXO As SG_CO_TB_TIPOANEXO
        Private _VE_ANEXO_ID As SG_CO_TB_ANEXO
        Private _VE_TIP_DOC As SG_CO_TB_DOCUMENTO
        Private _VE_SER_DOC As String
        Private _VE_NUM_DOC As String
        Private _VE_INDICADOR_DESTINO As String
        Private _VE_FEC_EMI As String
        Private _VE_FEC_VEN As String
        Private _VE_FEC_VOU As String
        Private _VE_TIP_DOC_REF As SG_CO_TB_DOCUMENTO
        Private _VE_SER_DOC_REF As String
        Private _VE_NUM_DOC_REF As String
        Private _VE_FEC_EMI_REF As String
        Private _VE_TASA_IGV As Double
        Private _VE_MONTO_IGV As Double
        Private _VE_MONTO_EXONERADO As Double
        Private _VE_TASA_ISC As Double
        Private _VE_MONTO_ISC As Double
        Private _VE_OTROS_TRIBUTOS As Double
        Private _VE_VALOR_INAFECTO As Double
        Private _VE_DESCUENTO As Double
        Private _VE_VALOR_VENTA As Double
        Private _VE_VALOR_BRUTO As Double
        Private _VE_PRECIO_VENTA As Double
        Private _VE_ISTATUS As Int32
        Private _VE_IDSUBOPE As SG_CO_TB_SUBOPERACION

        Public Sub New(ByVal VE_IDCAB_ As SG_CO_TB_ASIENTO_CAB, ByVal VE_TIPO_ANEXO_ As SG_CO_TB_TIPOANEXO, ByVal VE_ANEXO_ID_ As SG_CO_TB_ANEXO, ByVal VE_TIP_DOC_ As SG_CO_TB_DOCUMENTO, ByVal VE_SER_DOC_ As String, ByVal VE_NUM_DOC_ As String, ByVal VE_INDICADOR_DESTINO_ As String, ByVal VE_FEC_EMI_ As String, ByVal VE_FEC_VEN_ As String, ByVal VE_FEC_VOU_ As String, ByVal VE_TIP_DOC_REF_ As SG_CO_TB_DOCUMENTO, ByVal VE_SER_DOC_REF_ As String, ByVal VE_NUM_DOC_REF_ As String, ByVal VE_FEC_EMI_REF_ As String, ByVal VE_TASA_IGV_ As Double, ByVal VE_MONTO_IGV_ As Double, ByVal VE_MONTO_EXONERADO_ As Double, ByVal VE_TASA_ISC_ As Double, ByVal VE_MONTO_ISC_ As Double, ByVal VE_OTROS_TRIBUTOS_ As Double, ByVal VE_VALOR_INAFECTO_ As Double, ByVal VE_DESCUENTO_ As Double, ByVal VE_VALOR_VENTA_ As Double, ByVal VE_VALOR_BRUTO_ As Double, ByVal VE_PRECIO_VENTA_ As Double, ByVal VE_ISTATUS_ As Int32, ByVal VE_IDSUBOPE_ As SG_CO_TB_SUBOPERACION)
            _VE_IDCAB = VE_IDCAB_
            _VE_TIPO_ANEXO = VE_TIPO_ANEXO_
            _VE_ANEXO_ID = VE_ANEXO_ID_
            _VE_TIP_DOC = VE_TIP_DOC_
            _VE_SER_DOC = VE_SER_DOC_
            _VE_NUM_DOC = VE_NUM_DOC_
            _VE_INDICADOR_DESTINO = VE_INDICADOR_DESTINO_
            _VE_FEC_EMI = VE_FEC_EMI_
            _VE_FEC_VEN = VE_FEC_VEN_
            _VE_FEC_VOU = VE_FEC_VOU_
            _VE_TIP_DOC_REF = VE_TIP_DOC_REF_
            _VE_SER_DOC_REF = VE_SER_DOC_REF_
            _VE_NUM_DOC_REF = VE_NUM_DOC_REF_
            _VE_FEC_EMI_REF = VE_FEC_EMI_REF_
            _VE_TASA_IGV = VE_TASA_IGV_
            _VE_MONTO_IGV = VE_MONTO_IGV_
            _VE_MONTO_EXONERADO = VE_MONTO_EXONERADO_
            _VE_TASA_ISC = VE_TASA_ISC_
            _VE_MONTO_ISC = VE_MONTO_ISC_
            _VE_OTROS_TRIBUTOS = VE_OTROS_TRIBUTOS_
            _VE_VALOR_INAFECTO = VE_VALOR_INAFECTO_
            _VE_DESCUENTO = VE_DESCUENTO_
            _VE_VALOR_VENTA = VE_VALOR_VENTA_
            _VE_VALOR_BRUTO = VE_VALOR_BRUTO_
            _VE_PRECIO_VENTA = VE_PRECIO_VENTA_
            _VE_ISTATUS = VE_ISTATUS_
            _VE_IDSUBOPE = VE_IDSUBOPE_
        End Sub
        Public Sub New()
            _VE_IDCAB = Nothing
            _VE_TIPO_ANEXO = Nothing
            _VE_ANEXO_ID = Nothing
            _VE_TIP_DOC = Nothing
            _VE_SER_DOC = String.Empty
            _VE_NUM_DOC = String.Empty
            _VE_INDICADOR_DESTINO = String.Empty
            _VE_FEC_EMI = String.Empty
            _VE_FEC_VEN = String.Empty
            _VE_FEC_VOU = String.Empty
            _VE_TIP_DOC_REF = Nothing
            _VE_SER_DOC_REF = String.Empty
            _VE_NUM_DOC_REF = String.Empty
            _VE_FEC_EMI_REF = String.Empty
            _VE_TASA_IGV = 0.0R
            _VE_MONTO_IGV = 0.0R
            _VE_MONTO_EXONERADO = 0.0R
            _VE_TASA_ISC = 0.0R
            _VE_MONTO_ISC = 0.0R
            _VE_OTROS_TRIBUTOS = 0.0R
            _VE_VALOR_INAFECTO = 0.0R
            _VE_DESCUENTO = 0.0R
            _VE_VALOR_VENTA = 0.0R
            _VE_VALOR_BRUTO = 0.0R
            _VE_PRECIO_VENTA = 0.0R
            _VE_ISTATUS = 0
            _VE_IDSUBOPE = Nothing
        End Sub

        Public Property VE_IDSUBOPE() As SG_CO_TB_SUBOPERACION
            Get
                Return _VE_IDSUBOPE
            End Get
            Set(ByVal value As SG_CO_TB_SUBOPERACION)
                _VE_IDSUBOPE = value
            End Set
        End Property

        Public Property VE_IDCAB() As SG_CO_TB_ASIENTO_CAB
            Get
                Return _VE_IDCAB
            End Get

            Set(ByVal value As SG_CO_TB_ASIENTO_CAB)
                _VE_IDCAB = value
            End Set
        End Property
        Public Property VE_TIPO_ANEXO() As SG_CO_TB_TIPOANEXO
            Get
                Return _VE_TIPO_ANEXO
            End Get

            Set(ByVal value As SG_CO_TB_TIPOANEXO)
                _VE_TIPO_ANEXO = value
            End Set
        End Property
        Public Property VE_ANEXO_ID() As SG_CO_TB_ANEXO
            Get
                Return _VE_ANEXO_ID
            End Get

            Set(ByVal value As SG_CO_TB_ANEXO)
                _VE_ANEXO_ID = value
            End Set
        End Property
        Public Property VE_TIP_DOC() As SG_CO_TB_DOCUMENTO
            Get
                Return _VE_TIP_DOC
            End Get

            Set(ByVal value As SG_CO_TB_DOCUMENTO)
                _VE_TIP_DOC = value
            End Set
        End Property
        Public Property VE_SER_DOC() As String
            Get
                Return _VE_SER_DOC
            End Get

            Set(ByVal value As String)
                _VE_SER_DOC = value
            End Set
        End Property
        Public Property VE_NUM_DOC() As String
            Get
                Return _VE_NUM_DOC
            End Get

            Set(ByVal value As String)
                _VE_NUM_DOC = value
            End Set
        End Property
        Public Property VE_INDICADOR_DESTINO() As String
            Get
                Return _VE_INDICADOR_DESTINO
            End Get

            Set(ByVal value As String)
                _VE_INDICADOR_DESTINO = value
            End Set
        End Property
        Public Property VE_FEC_EMI() As String
            Get
                Return _VE_FEC_EMI
            End Get

            Set(ByVal value As String)
                _VE_FEC_EMI = value
            End Set
        End Property
        Public Property VE_FEC_VEN() As String
            Get
                Return _VE_FEC_VEN
            End Get

            Set(ByVal value As String)
                _VE_FEC_VEN = value
            End Set
        End Property
        Public Property VE_FEC_VOU() As String
            Get
                Return _VE_FEC_VOU
            End Get

            Set(ByVal value As String)
                _VE_FEC_VOU = value
            End Set
        End Property
        Public Property VE_TIP_DOC_REF() As SG_CO_TB_DOCUMENTO
            Get
                Return _VE_TIP_DOC_REF
            End Get

            Set(ByVal value As SG_CO_TB_DOCUMENTO)
                _VE_TIP_DOC_REF = value
            End Set
        End Property
        Public Property VE_SER_DOC_REF() As String
            Get
                Return _VE_SER_DOC_REF
            End Get

            Set(ByVal value As String)
                _VE_SER_DOC_REF = value
            End Set
        End Property
        Public Property VE_NUM_DOC_REF() As String
            Get
                Return _VE_NUM_DOC_REF
            End Get

            Set(ByVal value As String)
                _VE_NUM_DOC_REF = value
            End Set
        End Property
        Public Property VE_FEC_EMI_REF() As String
            Get
                Return _VE_FEC_EMI_REF
            End Get

            Set(ByVal value As String)
                _VE_FEC_EMI_REF = value
            End Set
        End Property
        Public Property VE_TASA_IGV() As Double
            Get
                Return _VE_TASA_IGV
            End Get

            Set(ByVal value As Double)
                _VE_TASA_IGV = value
            End Set
        End Property
        Public Property VE_MONTO_IGV() As Double
            Get
                Return _VE_MONTO_IGV
            End Get

            Set(ByVal value As Double)
                _VE_MONTO_IGV = value
            End Set
        End Property
        Public Property VE_MONTO_EXONERADO() As Double
            Get
                Return _VE_MONTO_EXONERADO
            End Get

            Set(ByVal value As Double)
                _VE_MONTO_EXONERADO = value
            End Set
        End Property
        Public Property VE_TASA_ISC() As Double
            Get
                Return _VE_TASA_ISC
            End Get

            Set(ByVal value As Double)
                _VE_TASA_ISC = value
            End Set
        End Property
        Public Property VE_MONTO_ISC() As Double
            Get
                Return _VE_MONTO_ISC
            End Get

            Set(ByVal value As Double)
                _VE_MONTO_ISC = value
            End Set
        End Property
        Public Property VE_OTROS_TRIBUTOS() As Double
            Get
                Return _VE_OTROS_TRIBUTOS
            End Get

            Set(ByVal value As Double)
                _VE_OTROS_TRIBUTOS = value
            End Set
        End Property
        Public Property VE_VALOR_INAFECTO() As Double
            Get
                Return _VE_VALOR_INAFECTO
            End Get

            Set(ByVal value As Double)
                _VE_VALOR_INAFECTO = value
            End Set
        End Property
        Public Property VE_DESCUENTO() As Double
            Get
                Return _VE_DESCUENTO
            End Get

            Set(ByVal value As Double)
                _VE_DESCUENTO = value
            End Set
        End Property
        Public Property VE_VALOR_VENTA() As Double
            Get
                Return _VE_VALOR_VENTA
            End Get

            Set(ByVal value As Double)
                _VE_VALOR_VENTA = value
            End Set
        End Property
        Public Property VE_VALOR_BRUTO() As Double
            Get
                Return _VE_VALOR_BRUTO
            End Get

            Set(ByVal value As Double)
                _VE_VALOR_BRUTO = value
            End Set
        End Property
        Public Property VE_PRECIO_VENTA() As Double
            Get
                Return _VE_PRECIO_VENTA
            End Get

            Set(ByVal value As Double)
                _VE_PRECIO_VENTA = value
            End Set
        End Property
        Public Property VE_ISTATUS() As Int32
            Get
                Return _VE_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _VE_ISTATUS = value
            End Set
        End Property

    End Class
    Public Class SG_CO_TB_ASIENTO_CAB

        Private _AC_ID As Integer
        Private _AC_IDSUBDIARIO As SG_CO_TB_SUBDIARIO
        Private _AC_NUM_VOUCHER As String
        Private _AC_MES As Int32
        Private _AC_ANHO As Int32
        Private _AC_FEC_VOUCHER As String
        Private _AC_IDMONEDA As SG_CO_TB_MONEDA
        Private _AC_DEBE As Double
        Private _AC_HABER As Double
        Private _AC_TC_OPE As Double
        Private _AC_TC_ESPECIAL As Double
        Private _AC_ESTADO As Int32
        Private _AC_GLOSA_VOU As String
        Private _AC_ES_INTERFACE As Int32
        Private _AC_TC_FORMATO As SG_CO_TB_FORM_TIPCAMB
        Private _AC_USUARIO As String
        Private _AC_TERMINAL As String
        Private _AC_FECREG As String
        Private _AC_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _AC_ES_IMPRESO As Integer

        Public Sub New(ByVal AC_ID_ As Integer, ByVal AC_IDSUBDIARIO_ As SG_CO_TB_SUBDIARIO, ByVal AC_NUM_VOUCHER_ As String, ByVal AC_ANHO_ As Int32, ByVal AC_MES_ As Int32, ByVal AC_FEC_VOUCHER_ As String, ByVal AC_IDMONEDA_ As SG_CO_TB_MONEDA, ByVal AC_DEBE_ As Double, ByVal AC_HABER_ As Double, ByVal AC_TC_OPE_ As Double, ByVal AC_TC_ESPECIAL_ As Double, ByVal AC_ESTADO_ As Int32, ByVal AC_GLOSA_VOU_ As String, ByVal AC_ES_INTERFACE_ As Int32, ByVal AC_TC_FORMATO_ As SG_CO_TB_FORM_TIPCAMB, ByVal AC_USUARIO_ As String, ByVal AC_TERMINAL_ As String, ByVal AC_FECREG_ As String, ByVal AC_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal AC_ES_IMPRESO_ As Integer)
            _AC_ID = AC_ID_
            _AC_IDSUBDIARIO = AC_IDSUBDIARIO_
            _AC_NUM_VOUCHER = AC_NUM_VOUCHER_
            _AC_ANHO = AC_ANHO_
            _AC_MES = AC_MES_
            _AC_FEC_VOUCHER = AC_FEC_VOUCHER_
            _AC_IDMONEDA = AC_IDMONEDA_
            _AC_DEBE = AC_DEBE_
            _AC_HABER = AC_HABER_
            _AC_TC_OPE = AC_TC_OPE_
            _AC_TC_ESPECIAL = AC_TC_ESPECIAL_
            _AC_ESTADO = AC_ESTADO_
            _AC_GLOSA_VOU = AC_GLOSA_VOU_
            _AC_ES_INTERFACE = AC_ES_INTERFACE_
            _AC_TC_FORMATO = AC_TC_FORMATO_
            _AC_USUARIO = AC_USUARIO_
            _AC_TERMINAL = AC_TERMINAL_
            _AC_FECREG = AC_FECREG_
            _AC_IDEMPRESA = AC_IDEMPRESA_
            _AC_ES_IMPRESO = AC_ES_IMPRESO_
        End Sub
        Public Sub New()
            _AC_ES_IMPRESO = 0
            _AC_ID = 0
            _AC_IDSUBDIARIO = Nothing
            _AC_NUM_VOUCHER = String.Empty
            _AC_MES = 0
            _AC_ANHO = 0
            _AC_FEC_VOUCHER = String.Empty
            _AC_IDMONEDA = Nothing
            _AC_DEBE = 0.0R
            _AC_HABER = 0.0R
            _AC_TC_OPE = 0.0R
            _AC_TC_ESPECIAL = 0.0R
            _AC_ESTADO = 0
            _AC_GLOSA_VOU = String.Empty
            _AC_ES_INTERFACE = 0
            _AC_TC_FORMATO = Nothing
            _AC_USUARIO = String.Empty
            _AC_TERMINAL = String.Empty
            _AC_FECREG = String.Empty
            _AC_IDEMPRESA = Nothing
        End Sub

        Public Property AC_ES_IMPRESO() As Integer
            Get
                Return _AC_ES_IMPRESO
            End Get
            Set(ByVal value As Integer)
                _AC_ES_IMPRESO = value
            End Set
        End Property

        Public Property AC_ID() As Integer
            Get
                Return _AC_ID
            End Get
            Set(ByVal value As Integer)
                _AC_ID = value
            End Set
        End Property

        Public Property AC_IDSUBDIARIO() As SG_CO_TB_SUBDIARIO
            Get
                Return _AC_IDSUBDIARIO
            End Get

            Set(ByVal value As SG_CO_TB_SUBDIARIO)
                _AC_IDSUBDIARIO = value
            End Set
        End Property

        Public Property AC_NUM_VOUCHER() As String
            Get
                Return _AC_NUM_VOUCHER
            End Get

            Set(ByVal value As String)
                _AC_NUM_VOUCHER = value
            End Set
        End Property

        Public Property AC_ANHO() As Int32
            Get
                Return _AC_ANHO
            End Get

            Set(ByVal value As Int32)
                _AC_ANHO = value
            End Set
        End Property

        Public Property AC_MES() As Int32
            Get
                Return _AC_MES
            End Get

            Set(ByVal value As Int32)
                _AC_MES = value
            End Set
        End Property

        Public Property AC_FEC_VOUCHER() As String
            Get
                Return _AC_FEC_VOUCHER
            End Get

            Set(ByVal value As String)
                _AC_FEC_VOUCHER = value
            End Set
        End Property

        Public Property AC_IDMONEDA() As SG_CO_TB_MONEDA
            Get
                Return _AC_IDMONEDA
            End Get

            Set(ByVal value As SG_CO_TB_MONEDA)
                _AC_IDMONEDA = value
            End Set
        End Property

        Public Property AC_DEBE() As Double
            Get
                Return _AC_DEBE
            End Get

            Set(ByVal value As Double)
                _AC_DEBE = value
            End Set
        End Property

        Public Property AC_HABER() As Double
            Get
                Return _AC_HABER
            End Get

            Set(ByVal value As Double)
                _AC_HABER = value
            End Set
        End Property

        Public Property AC_TC_OPE() As Double
            Get
                Return _AC_TC_OPE
            End Get

            Set(ByVal value As Double)
                _AC_TC_OPE = value
            End Set
        End Property

        Public Property AC_TC_ESPECIAL() As Double
            Get
                Return _AC_TC_ESPECIAL
            End Get

            Set(ByVal value As Double)
                _AC_TC_ESPECIAL = value
            End Set
        End Property

        Public Property AC_ESTADO() As Int32
            Get
                Return _AC_ESTADO
            End Get

            Set(ByVal value As Int32)
                _AC_ESTADO = value
            End Set
        End Property

        Public Property AC_GLOSA_VOU() As String
            Get
                Return _AC_GLOSA_VOU
            End Get

            Set(ByVal value As String)
                _AC_GLOSA_VOU = value
            End Set
        End Property

        Public Property AC_ES_INTERFACE() As Int32
            Get
                Return _AC_ES_INTERFACE
            End Get

            Set(ByVal value As Int32)
                _AC_ES_INTERFACE = value
            End Set
        End Property

        Public Property AC_TC_FORMATO() As SG_CO_TB_FORM_TIPCAMB
            Get
                Return _AC_TC_FORMATO
            End Get

            Set(ByVal value As SG_CO_TB_FORM_TIPCAMB)
                _AC_TC_FORMATO = value
            End Set
        End Property

        Public Property AC_USUARIO() As String
            Get
                Return _AC_USUARIO
            End Get

            Set(ByVal value As String)
                _AC_USUARIO = value
            End Set
        End Property

        Public Property AC_TERMINAL() As String
            Get
                Return _AC_TERMINAL
            End Get

            Set(ByVal value As String)
                _AC_TERMINAL = value
            End Set
        End Property

        Public Property AC_FECREG() As String
            Get
                Return _AC_FECREG
            End Get

            Set(ByVal value As String)
                _AC_FECREG = value
            End Set
        End Property

        Public Property AC_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _AC_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _AC_IDEMPRESA = value
            End Set
        End Property
    End Class

    Public Class SG_CO_TB_CODIGOS_TMP
        Private _CODIGO As String
        Private _PC As String
        Private _EMPRESA As Integer

        Public Sub New(ByVal CODIGO_ As String, ByVal PC_ As String, ByVal EMPRESA_ As Integer)
            _CODIGO = CODIGO_
            _PC = PC_
            _EMPRESA = EMPRESA_
        End Sub
        Public Sub New()
            _CODIGO = String.Empty
            _PC = String.Empty
            _EMPRESA = 0
        End Sub

        Public Property CODIGO() As String
            Get
                Return _CODIGO
            End Get
            Set(ByVal value As String)
                _CODIGO = value
            End Set
        End Property

        Public Property PC() As String
            Get
                Return _PC
            End Get
            Set(ByVal value As String)
                _PC = value
            End Set
        End Property

        Public Property EMPRESA() As Integer
            Get
                Return _EMPRESA
            End Get
            Set(ByVal value As Integer)
                _EMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_TIPO_USUARIO
        Private _TU_CODIGO As Integer
        Private _TU_DESCRIPCION As String

        Public Sub New(ByVal TU_CODIGO_ As Integer, ByVal TU_DESCRIPCION_ As String)
            _TU_CODIGO = TU_CODIGO_
            _TU_DESCRIPCION = TU_DESCRIPCION_
        End Sub
        Public Sub New()
            _TU_CODIGO = 0
            _TU_DESCRIPCION = String.Empty
        End Sub

        Public Property TU_CODIGO() As Integer
            Get
                Return _TU_CODIGO
            End Get
            Set(ByVal value As Integer)
                _TU_CODIGO = value
            End Set
        End Property

        Public Property TU_DESCRIPCION() As String
            Get
                Return _TU_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TU_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_USUARIO
        Private _US_ID As Int32
        Private _US_NOMBRE As String
        Private _US_CLAVE As String
        Private _US_DESCRIPCION As String
        Private _US_ISTATUS As Int32
        Private _US_USUARIO As String
        Private _US_TERMINAL As String
        Private _US_FECREG As String
        Private _US_IDTIPO_USU As SG_CO_TB_TIPO_USUARIO
        Private _US_FOTO() As Byte
        Private _US_TIPO_ACCESO As Integer
        Private _US_ES_WEB As Integer

        Public Sub New(ByVal US_ID_ As Int32, ByVal US_NOMBRE_ As String, ByVal US_CLAVE_ As String, ByVal US_DESCRIPCION_ As String, ByVal US_ISTATUS_ As String, ByVal US_USUARIO_ As String, ByVal US_TERMINAL_ As String, ByVal US_FECREG_ As String, ByVal US_IDTIPO_USU_ As SG_CO_TB_TIPO_USUARIO, ByVal US_FOTO_ As Byte(), ByVal US_TIPO_ACCESO_ As Integer, ByVal US_ES_WEB_ As Integer)
            _US_ES_WEB = US_ES_WEB_
            _US_TIPO_ACCESO = US_TIPO_ACCESO_
            _US_ID = US_ID_
            _US_NOMBRE = US_NOMBRE_
            _US_CLAVE = US_CLAVE_
            _US_DESCRIPCION = US_DESCRIPCION_
            _US_ISTATUS = US_ISTATUS_
            _US_USUARIO = US_USUARIO_
            _US_TERMINAL = US_TERMINAL_
            _US_FECREG = US_FECREG_
            _US_IDTIPO_USU = US_IDTIPO_USU_
            _US_FOTO = US_FOTO_
        End Sub

        Public Sub New()
            _US_ES_WEB = 0
            _US_TIPO_ACCESO = 0
            _US_FOTO = Nothing
            _US_ID = 0
            _US_NOMBRE = String.Empty
            _US_CLAVE = String.Empty
            _US_DESCRIPCION = String.Empty
            _US_ISTATUS = 0
            _US_USUARIO = String.Empty
            _US_TERMINAL = String.Empty
            _US_FECREG = String.Empty
            _US_IDTIPO_USU = Nothing
        End Sub

        Public Property US_ES_WEB() As Integer
            Get
                Return _US_ES_WEB
            End Get
            Set(ByVal value As Integer)
                _US_ES_WEB = value
            End Set
        End Property

        Public Property US_TIPO_ACCESO() As Integer
            Get
                Return _US_TIPO_ACCESO
            End Get
            Set(ByVal value As Integer)
                _US_TIPO_ACCESO = value
            End Set
        End Property

        Public Property US_FOTO() As Byte()
            Get
                Return _US_FOTO
            End Get
            Set(ByVal value As Byte())
                _US_FOTO = value
            End Set
        End Property

        Public Property US_IDTIPO_USU() As SG_CO_TB_TIPO_USUARIO
            Get
                Return _US_IDTIPO_USU
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_USUARIO)
                _US_IDTIPO_USU = value
            End Set
        End Property

        Public Property US_ID() As Int32
            Get
                Return _US_ID
            End Get

            Set(ByVal value As Int32)
                _US_ID = value
            End Set
        End Property

        Public Property US_NOMBRE() As String
            Get
                Return _US_NOMBRE
            End Get

            Set(ByVal value As String)
                _US_NOMBRE = value
            End Set
        End Property

        Public Property US_CLAVE() As String
            Get
                Return _US_CLAVE
            End Get

            Set(ByVal value As String)
                _US_CLAVE = value
            End Set
        End Property

        Public Property US_DESCRIPCION() As String
            Get
                Return _US_DESCRIPCION
            End Get

            Set(ByVal value As String)
                _US_DESCRIPCION = value
            End Set
        End Property

        Public Property US_ISTATUS() As Int32
            Get
                Return _US_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _US_ISTATUS = value
            End Set
        End Property

        Public Property US_USUARIO() As String
            Get
                Return _US_USUARIO
            End Get

            Set(ByVal value As String)
                _US_USUARIO = value
            End Set
        End Property

        Public Property US_TERMINAL() As String
            Get
                Return _US_TERMINAL
            End Get

            Set(ByVal value As String)
                _US_TERMINAL = value
            End Set
        End Property

        Public Property US_FECREG() As String
            Get
                Return _US_FECREG
            End Get

            Set(ByVal value As String)
                _US_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_MODULO
        Private _MO_ID As Int32
        Private _MO_DESCRIPCION As String

        Public Sub New(ByVal MO_ID_ As Int32, ByVal MO_DESCRIPCION_ As String)
            _MO_ID = MO_ID_
            _MO_DESCRIPCION = MO_DESCRIPCION_
        End Sub
        Public Sub New()
            _MO_ID = 0
            _MO_DESCRIPCION = String.Empty
        End Sub

        Public Property MO_ID() As Int32
            Get
                Return _MO_ID
            End Get
            Set(ByVal value As Int32)
                _MO_ID = value
            End Set
        End Property
        Public Property MO_DESCRIPCION() As String
            Get
                Return _MO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _MO_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_MODULO_USUARIO
        Private _MU_IDMODULO As SG_CO_TB_MODULO
        Private _MU_IDUSUARIO As SG_CO_TB_USUARIO
        Private _MU_ISTATUS As Int32
        Private _MU_IDEMPRESA As SG_CO_TB_EMPRESA
        Private _MU_USUARIO As String
        Private _MU_TERMINAL As String
        Private _MU_FECREG As String

        Public Sub New(ByVal MU_IDMODULO_ As SG_CO_TB_MODULO, ByVal MU_IDUSUARIO_ As SG_CO_TB_USUARIO, ByVal MU_ISTATUS_ As Int32, ByVal MU_IDEMPRESA_ As SG_CO_TB_EMPRESA, ByVal MU_USUARIO_ As String, ByVal MU_TERMINAL_ As String, ByVal MU_FECREG_ As String)
            _MU_IDMODULO = MU_IDMODULO_
            _MU_IDUSUARIO = MU_IDUSUARIO_
            _MU_ISTATUS = MU_ISTATUS_
            _MU_IDEMPRESA = MU_IDEMPRESA_
            _MU_USUARIO = MU_USUARIO_
            _MU_TERMINAL = MU_TERMINAL_
            _MU_FECREG = MU_FECREG_
        End Sub
        Public Sub New()
        End Sub

        Public Property MU_IDMODULO() As SG_CO_TB_MODULO
            Get
                Return _MU_IDMODULO
            End Get
            Set(ByVal value As SG_CO_TB_MODULO)
                _MU_IDMODULO = value
            End Set
        End Property
        Public Property MU_IDUSUARIO() As SG_CO_TB_USUARIO
            Get
                Return _MU_IDUSUARIO
            End Get

            Set(ByVal value As SG_CO_TB_USUARIO)
                _MU_IDUSUARIO = value
            End Set
        End Property
        Public Property MU_ISTATUS() As Int32
            Get
                Return _MU_ISTATUS
            End Get

            Set(ByVal value As Int32)
                _MU_ISTATUS = value
            End Set
        End Property
        Public Property MU_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _MU_IDEMPRESA
            End Get

            Set(ByVal value As SG_CO_TB_EMPRESA)
                _MU_IDEMPRESA = value
            End Set
        End Property
        Public Property MU_USUARIO() As String
            Get
                Return _MU_USUARIO
            End Get

            Set(ByVal value As String)
                _MU_USUARIO = value
            End Set
        End Property
        Public Property MU_TERMINAL() As String
            Get
                Return _MU_TERMINAL
            End Get

            Set(ByVal value As String)
                _MU_TERMINAL = value
            End Set
        End Property
        Public Property MU_FECREG() As String
            Get
                Return _MU_FECREG
            End Get

            Set(ByVal value As String)
                _MU_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_LOG_SIS
        Private _LS_ID As Integer
        Private _LS_USU_DOM As String
        Private _LS_USU_SIS As String
        Private _LS_TERMINAL As String
        Private _LS_MODULO As Integer
        Private _LS_FEC_ING As String
        Private _LS_FEC_SAL As String

        Public Sub New(ByVal LS_ID_ As Integer, ByVal LS_USU_DOM_ As String, ByVal LS_USU_SIS_ As String, ByVal LS_TERMINAL_ As String, ByVal LS_MODULO_ As Integer, ByVal LS_FEC_ING_ As String, ByVal LS_FEC_SAL_ As String)
            _LS_ID = LS_ID_
            _LS_USU_DOM = LS_USU_DOM_
            _LS_USU_SIS = LS_USU_SIS_
            _LS_TERMINAL = LS_TERMINAL_
            _LS_MODULO = LS_MODULO_
            _LS_FEC_ING = LS_FEC_ING_
            _LS_FEC_SAL = LS_FEC_SAL_
        End Sub
        Public Sub New()
            _LS_ID = 0
            _LS_USU_DOM = String.Empty
            _LS_USU_SIS = String.Empty
            _LS_TERMINAL = String.Empty
            _LS_MODULO = 0
            _LS_FEC_ING = String.Empty
            _LS_FEC_SAL = String.Empty
        End Sub

        Public Property LS_ID() As Integer
            Get
                Return _LS_ID
            End Get
            Set(ByVal value As Integer)
                _LS_ID = value
            End Set
        End Property

        Public Property LS_USU_DOM() As String
            Get
                Return _LS_USU_DOM
            End Get
            Set(ByVal value As String)
                _LS_USU_DOM = value
            End Set
        End Property

        Public Property LS_USU_SIS() As String
            Get
                Return _LS_USU_SIS
            End Get
            Set(ByVal value As String)
                _LS_USU_SIS = value
            End Set
        End Property

        Public Property LS_TERMINAL() As String
            Get
                Return _LS_TERMINAL
            End Get
            Set(ByVal value As String)
                _LS_TERMINAL = value
            End Set
        End Property

        Public Property LS_MODULO() As Integer
            Get
                Return _LS_MODULO
            End Get
            Set(ByVal value As Integer)
                _LS_MODULO = value
            End Set
        End Property

        Public Property LS_FEC_ING() As String
            Get
                Return _LS_FEC_ING
            End Get
            Set(ByVal value As String)
                _LS_FEC_ING = value
            End Set
        End Property

        Public Property LS_FEC_SAL() As String
            Get
                Return _LS_FEC_SAL
            End Get
            Set(ByVal value As String)
                _LS_FEC_SAL = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_USUARIO_EMPRESA
        Private _UE_IDUSUARIO As SG_CO_TB_USUARIO
        Private _UE_IDEMPRESA As SG_CO_TB_EMPRESA

        Public Sub New(ByVal UE_IDUSUARIO_ As SG_CO_TB_USUARIO, ByVal UE_IDEMPRESA_ As SG_CO_TB_EMPRESA)
            _UE_IDUSUARIO = UE_IDUSUARIO_
            _UE_IDEMPRESA = UE_IDEMPRESA_
        End Sub
        Public Sub New()
            _UE_IDUSUARIO = Nothing
            _UE_IDEMPRESA = Nothing
        End Sub

        Public Property UE_IDUSUARIO() As SG_CO_TB_USUARIO
            Get
                Return _UE_IDUSUARIO
            End Get
            Set(ByVal value As SG_CO_TB_USUARIO)
                _UE_IDUSUARIO = value
            End Set
        End Property

        Public Property UE_IDEMPRESA() As SG_CO_TB_EMPRESA
            Get
                Return _UE_IDEMPRESA
            End Get
            Set(ByVal value As SG_CO_TB_EMPRESA)
                _UE_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_GRUPO_MENU
        Private _GM_ID As Integer
        Private _GM_NOMBRE As String
        Private _GM_IDMODULO As SG_CO_TB_MODULO

        Public Sub New(ByVal GM_ID_ As Integer, ByVal GM_NOMBRE_ As String, ByVal GM_IDMODULO_ As SG_CO_TB_MODULO)
            _GM_ID = GM_ID_
            _GM_NOMBRE = GM_NOMBRE_
            _GM_IDMODULO = GM_IDMODULO_
        End Sub
        Public Sub New()
            _GM_ID = 0
            _GM_NOMBRE = String.Empty
            _GM_IDMODULO = Nothing
        End Sub

        Public Property GM_ID() As Integer
            Get
                Return _GM_ID
            End Get
            Set(ByVal value As Integer)
                _GM_ID = value
            End Set
        End Property

        Public Property GM_NOMBRE() As String
            Get
                Return _GM_NOMBRE
            End Get
            Set(ByVal value As String)
                _GM_NOMBRE = value
            End Set
        End Property

        Public Property GM_IDMODULO() As SG_CO_TB_MODULO
            Get
                Return _GM_IDMODULO
            End Get
            Set(ByVal value As SG_CO_TB_MODULO)
                _GM_IDMODULO = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_USUARIO_GRUPO_MNU
        Private _GU_IDUSUARIO As SG_CO_TB_USUARIO
        Private _GU_IDGRUPO As SG_CO_TB_GRUPO_MENU
        Private _GU_IDMODULO As SG_CO_TB_MODULO

        Public Sub New(ByVal GU_IDUSUARIO_ As SG_CO_TB_USUARIO, ByVal GU_IDGRUPO_ As SG_CO_TB_GRUPO_MENU, ByVal GU_IDMODULO_ As SG_CO_TB_MODULO)
            _GU_IDMODULO = GU_IDMODULO_
            _GU_IDUSUARIO = GU_IDUSUARIO_
            _GU_IDGRUPO = GU_IDGRUPO_
        End Sub
        Public Sub New()
            _GU_IDUSUARIO = Nothing
            _GU_IDGRUPO = Nothing
            _GU_IDMODULO = Nothing
        End Sub

        Public Property GU_IDUSUARIO() As SG_CO_TB_USUARIO
            Get
                Return _GU_IDUSUARIO
            End Get
            Set(ByVal value As SG_CO_TB_USUARIO)
                _GU_IDUSUARIO = value
            End Set
        End Property

        Public Property GU_IDGRUPO() As SG_CO_TB_GRUPO_MENU
            Get
                Return _GU_IDGRUPO
            End Get
            Set(ByVal value As SG_CO_TB_GRUPO_MENU)
                _GU_IDGRUPO = value
            End Set
        End Property

        Public Property GU_IDMODULO() As SG_CO_TB_MODULO
            Get
                Return _GU_IDMODULO
            End Get
            Set(ByVal value As SG_CO_TB_MODULO)
                _GU_IDMODULO = value
            End Set
        End Property
    End Class

    Public Class SG_CO_TB_OPCIONES_MNU
        Private _OM_ID As Integer
        Private _OM_DESCRIPCION As String
        Private _OM_TIPO As SG_CO_TB_TIPO_BOTON_MENU
        Private _OM_IDGRUPO As SG_CO_TB_GRUPO_MENU
        Private _OM_TAMANO_IMG As SG_CO_TB_TAMANO_ICON
        Private _OM_IMG As Byte()
        Private _OM_IDPADRE As SG_CO_TB_OPCIONES_MNU
        Private _OM_NOM_FORM As String

        Public Sub New(ByVal OM_ID_ As Integer, ByVal OM_DESCRIPCION_ As String, ByVal OM_TIPO_ As SG_CO_TB_TIPO_BOTON_MENU, ByVal OM_IDGRUPO_ As SG_CO_TB_GRUPO_MENU, ByVal OM_TAMANO_IMG_ As SG_CO_TB_TAMANO_ICON, ByVal OM_IMG_ As Byte(), ByVal OM_IDPADRE_ As SG_CO_TB_OPCIONES_MNU, ByVal OM_NOM_FORM_ As String)
            _OM_NOM_FORM = OM_NOM_FORM_
            _OM_IDPADRE = OM_IDPADRE_
            _OM_IMG = OM_IMG_
            _OM_TAMANO_IMG = OM_TAMANO_IMG_
            _OM_ID = OM_ID_
            _OM_DESCRIPCION = OM_DESCRIPCION_
            _OM_TIPO = OM_TIPO_
            _OM_IDGRUPO = OM_IDGRUPO_
        End Sub

        Public Sub New()
            _OM_NOM_FORM = String.Empty
            _OM_IDPADRE = Nothing
            _OM_TAMANO_IMG = Nothing
            _OM_IMG = Nothing
            _OM_ID = 0
            _OM_DESCRIPCION = String.Empty
            _OM_TIPO = Nothing
            _OM_IDGRUPO = Nothing
        End Sub

        Public Property OM_NOM_FORM() As String
            Get
                Return _OM_NOM_FORM
            End Get
            Set(ByVal value As String)
                _OM_NOM_FORM = value
            End Set
        End Property

        Public Property OM_IDPADRE() As SG_CO_TB_OPCIONES_MNU
            Get
                Return _OM_IDPADRE
            End Get
            Set(ByVal value As SG_CO_TB_OPCIONES_MNU)
                _OM_IDPADRE = value
            End Set
        End Property

        Public Property OM_IMG() As Byte()
            Get
                Return _OM_IMG
            End Get
            Set(ByVal value As Byte())
                _OM_IMG = value
            End Set
        End Property

        Public Property OM_TAMANO_IMG() As SG_CO_TB_TAMANO_ICON
            Get
                Return _OM_TAMANO_IMG
            End Get
            Set(ByVal value As SG_CO_TB_TAMANO_ICON)
                _OM_TAMANO_IMG = value
            End Set
        End Property

        Public Property OM_ID() As Integer
            Get
                Return _OM_ID
            End Get
            Set(ByVal value As Integer)
                _OM_ID = value
            End Set
        End Property

        Public Property OM_DESCRIPCION() As String
            Get
                Return _OM_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _OM_DESCRIPCION = value
            End Set
        End Property

        Public Property OM_TIPO() As SG_CO_TB_TIPO_BOTON_MENU
            Get
                Return _OM_TIPO
            End Get
            Set(ByVal value As SG_CO_TB_TIPO_BOTON_MENU)
                _OM_TIPO = value
            End Set
        End Property

        Public Property OM_IDGRUPO() As SG_CO_TB_GRUPO_MENU
            Get
                Return _OM_IDGRUPO
            End Get
            Set(ByVal value As SG_CO_TB_GRUPO_MENU)
                _OM_IDGRUPO = value
            End Set
        End Property



    End Class

    Public Class SG_CO_TB_TAMANO_ICON
        Private _TI_ID As Integer
        Private _TI_DESCRIPCION As String

        Public Sub New()
            _TI_ID = 0
            _TI_DESCRIPCION = String.Empty
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

    End Class

    Public Class SG_CO_TB_TIPO_BOTON_MENU
        Private _TB_ID As Integer
        Private _TB_DESCRIPCION As String

        Public Sub New()
            _TB_ID = 0
            _TB_DESCRIPCION = String.Empty
        End Sub

        Public Property TB_ID() As Integer
            Get
                Return _TB_ID
            End Get
            Set(ByVal value As Integer)
                _TB_ID = value
            End Set
        End Property

        Public Property TB_DESCRIPCION() As String
            Get
                Return _TB_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TB_DESCRIPCION = value
            End Set
        End Property
    End Class

    Public Class SG_CO_TB_USU_GRU_OPC
        Private _UGO_IDUSUARIO As SG_CO_TB_USUARIO
        Private _UGO_IDGRUPO As SG_CO_TB_GRUPO_MENU
        Private _UGO_IDOPCION As SG_CO_TB_OPCIONES_MNU

        Public Sub New(ByVal UGO_IDUSUARIO_ As SG_CO_TB_USUARIO, ByVal UGO_IDGRUPO_ As SG_CO_TB_GRUPO_MENU, ByVal UGO_IDOPCION_ As SG_CO_TB_OPCIONES_MNU)
            _UGO_IDUSUARIO = UGO_IDUSUARIO_
            _UGO_IDGRUPO = UGO_IDGRUPO_
            _UGO_IDOPCION = UGO_IDOPCION_
        End Sub
        Public Sub New()
            _UGO_IDUSUARIO = Nothing
            _UGO_IDGRUPO = Nothing
            _UGO_IDOPCION = Nothing
        End Sub

        Public Property UGO_IDUSUARIO() As SG_CO_TB_USUARIO
            Get
                Return _UGO_IDUSUARIO
            End Get
            Set(ByVal value As SG_CO_TB_USUARIO)
                _UGO_IDUSUARIO = value
            End Set
        End Property

        Public Property UGO_IDGRUPO() As SG_CO_TB_GRUPO_MENU
            Get
                Return _UGO_IDGRUPO
            End Get
            Set(ByVal value As SG_CO_TB_GRUPO_MENU)
                _UGO_IDGRUPO = value
            End Set
        End Property

        Public Property UGO_IDOPCION() As SG_CO_TB_OPCIONES_MNU
            Get
                Return _UGO_IDOPCION
            End Get
            Set(ByVal value As SG_CO_TB_OPCIONES_MNU)
                _UGO_IDOPCION = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_BTN_CMD
        Private _BC_ID As Integer
        Private _BC_DESCRIPCION As String
        Private _BC_NOMBRE_BTN_SIS As String

        Public Sub New(ByVal BC_ID_ As Integer, ByVal BC_DESCRIPCION_ As String, ByVal BC_NOMBRE_BTN_SIS_ As String)
            _BC_ID = BC_ID_
            _BC_DESCRIPCION = BC_DESCRIPCION_
            _BC_NOMBRE_BTN_SIS = BC_NOMBRE_BTN_SIS_
        End Sub
        Public Sub New()
            _BC_ID = 0
            _BC_DESCRIPCION = String.Empty
            _BC_NOMBRE_BTN_SIS = String.Empty
        End Sub

        Public Property BC_ID() As Integer
            Get
                Return _BC_ID
            End Get
            Set(ByVal value As Integer)
                _BC_ID = value
            End Set
        End Property

        Public Property BC_DESCRIPCION() As String
            Get
                Return _BC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _BC_DESCRIPCION = value
            End Set
        End Property

        Public Property BC_NOMBRE_BTN_SIS() As String
            Get
                Return _BC_NOMBRE_BTN_SIS
            End Get
            Set(ByVal value As String)
                _BC_NOMBRE_BTN_SIS = value
            End Set
        End Property


    End Class

    Public Class SG_CO_TB_USU_OPC_CMD
        Private _UOC_IDUSU As SG_CO_TB_USUARIO
        Private _UOC_IDOPC As SG_CO_TB_OPCIONES_MNU
        Private _UOC_IDCMD As SG_CO_TB_BTN_CMD

        Public Sub New(ByVal UOC_IDUSU_ As SG_CO_TB_USUARIO, ByVal UOC_IDOPC_ As SG_CO_TB_OPCIONES_MNU, ByVal UOC_IDCMD_ As SG_CO_TB_BTN_CMD)
            _UOC_IDUSU = UOC_IDUSU_
            _UOC_IDOPC = UOC_IDOPC_
            _UOC_IDCMD = UOC_IDCMD_
        End Sub
        Public Sub New()
            _UOC_IDUSU = Nothing
            _UOC_IDOPC = Nothing
            _UOC_IDCMD = Nothing
        End Sub

        Public Property UOC_IDUSU() As SG_CO_TB_USUARIO
            Get
                Return _UOC_IDUSU
            End Get
            Set(ByVal value As SG_CO_TB_USUARIO)
                _UOC_IDUSU = value
            End Set
        End Property

        Public Property UOC_IDOPC() As SG_CO_TB_OPCIONES_MNU
            Get
                Return _UOC_IDOPC
            End Get
            Set(ByVal value As SG_CO_TB_OPCIONES_MNU)
                _UOC_IDOPC = value
            End Set
        End Property

        Public Property UOC_IDCMD() As SG_CO_TB_BTN_CMD
            Get
                Return _UOC_IDCMD
            End Get
            Set(ByVal value As SG_CO_TB_BTN_CMD)
                _UOC_IDCMD = value
            End Set
        End Property

    End Class

    Public Class SG_CO_TB_INDICADOR_DESTINO

        Private _ID_CODIGO As String
        Private _ID_DESCRIPCION As String

        Public Sub New(ByVal ID_CODIGO_ As String, ByVal ID_DESCRIPCION_ As String)
            _ID_CODIGO = ID_CODIGO_
            _ID_DESCRIPCION = ID_DESCRIPCION_
        End Sub
        Public Sub New()
            _ID_CODIGO = String.Empty
            _ID_DESCRIPCION = String.Empty
        End Sub

        Public Property ID_CODIGO() As String
            Get
                Return _ID_CODIGO
            End Get
            Set(ByVal value As String)
                _ID_CODIGO = value
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

    Public Class SG_CO_TB_TIPO_IMPUESTO

        Private _TI_CODIGO As String
        Private _TI_DESCRIPCION As String

        Public Sub New(ByVal TI_CODIGO_ As String, ByVal TI_DESCRIPCION_ As String)
            _TI_CODIGO = TI_CODIGO_
            _TI_DESCRIPCION = TI_DESCRIPCION_
        End Sub
        Public Sub New()
            _TI_CODIGO = String.Empty
            _TI_DESCRIPCION = String.Empty
        End Sub

        Public Property TI_CODIGO() As String
            Get
                Return _TI_CODIGO
            End Get
            Set(ByVal value As String)
                _TI_CODIGO = value
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


    End Class

End Class

