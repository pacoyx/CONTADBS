﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CO_PR_VouCompras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha Emi")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha ven")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tip_Doc")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Anexo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Debe")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Haber")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCam")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CenCosto")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedioPago")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Soles")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAnexo")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Es_Destino")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cc_id")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sec_Ori_Destino")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("porce_destino")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("es_inafecto")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Item")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha Emi")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha ven")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tip_Doc")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Anexo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Debe")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Haber")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCam")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CenCosto")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MedioPago")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Soles")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAnexo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Es_Destino")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("cc_id")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sec_Ori_Destino")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("porce_destino")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("es_inafecto")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_IDCUENTA")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_NUM_CUENTA")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PC_DESCRIPCION")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_IDCUENTA")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_NUM_CUENTA")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PC_DESCRIPCION")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CO_PR_VouCompras))
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Habilita la ventana inferior para ingresar cuenta contable al asiento", Infragistics.Win.ToolTipImage.Info, "Agregar Cuenta", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Muestra la ventana para ingresar los datos de la detraccion", Infragistics.Win.ToolTipImage.Info, "Doc. Detraccion", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraToolTipInfo3 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Muestra la ventana para ingresar los datos del documento de referencia", Infragistics.Win.ToolTipImage.Info, "Doc. de Refencia", Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Ayuda")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("btn_get_anexo")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.ug_asiento = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.uds_Asiento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ume_ValorTipoCambio_Det = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.uce_cc = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uchk_Inafecto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txt_Cod_Mon_Det = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uce_Moneda_Det = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_cod_Doc_Det = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uc_Cuentas = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.uds_Cuentas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.txt_idAnexoDet = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btn_CancelarDet = New Infragistics.Win.Misc.UltraButton
        Me.btn_GrabarDet = New Infragistics.Win.Misc.UltraButton
        Me.txt_Glosa_Det = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel
        Me.ume_Haber_Det = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_Debe_Det = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel
        Me.ume_FecVen_Det = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel
        Me.ume_FecEmi_Det = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_TipoDoc_Det = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.txt_NumDoc_Det = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_SerieDoc_Det = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel30 = New Infragistics.Win.Misc.UltraLabel
        Me.lbl_des_cta = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lbl_Des_Anexo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_Anexo_Det = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel31 = New Infragistics.Win.Misc.UltraLabel
        Me.ugb_Cabecera = New Infragistics.Win.Misc.UltraGroupBox
        Me.uchk_dividir9 = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txt_IdCabecera = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.ubtn_CrearAnexo = New Infragistics.Win.Misc.UltraButton
        Me.uchkRelacionado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.txt_cod_Doc_Cab = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.uchk_Ocultar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ume_Imp_Pagar = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_Tasa_ISC = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txt_IdAnexo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btn_Nuevo = New Infragistics.Win.Misc.UltraButton
        Me.ume_Precioventa = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Num_Voucher = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_Cod_Mon_Cab = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btn_DatosDetra = New Infragistics.Win.Misc.UltraButton
        Me.btn_VerRef = New Infragistics.Win.Misc.UltraButton
        Me.ume_Valor_ISC = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_OtrosTributos = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_ValorCompra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_ValorNoGrabado = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_Tasa_Igv = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_Imp_Detra = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_Monto_Igv = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.uce_TipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel32 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Indicador = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_NumDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel
        Me.lbl_Imp_Detra = New Infragistics.Win.Misc.UltraLabel
        Me.txt_SerieDoc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel
        Me.txt_Des_Prove = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txt_ruc_anexo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btn_ListoCab = New Infragistics.Win.Misc.UltraButton
        Me.ume_ValorTipoCambio = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.txt_Glosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_Moneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_TipoCambio = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel
        Me.udte_Fec_Ven = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.udte_Fec_Emi = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.udte_fec_Vou = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.lbludte_Fec_Ven = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel
        Me.uce_SubOperacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.uce_Subdiario = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.utc_Asiento = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.ume_tot_d = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_tot_h = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ume_dif = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
        Me.ubtn_GrabarVoucher = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Cancelar = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Salir = New Infragistics.Win.Misc.UltraButton
        Me.ubtn_Impresion = New Infragistics.Win.Misc.UltraButton
        Me.uttm_AnexoRapido = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ug_asiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.uce_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Cod_Mon_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Moneda_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_Doc_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uc_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_idAnexoDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Glosa_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerieDoc_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_des_cta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_Des_Anexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Anexo_Det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugb_Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugb_Cabecera.SuspendLayout()
        CType(Me.txt_IdCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cod_Doc_Cab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_IdAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Num_Voucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Cod_Mon_Cab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Indicador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Des_Prove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ruc_anexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_TipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_Fec_Ven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_Fec_Emi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udte_fec_Vou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_SubOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uce_Subdiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utc_Asiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utc_Asiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ug_asiento)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(953, 189)
        '
        'ug_asiento
        '
        Me.ug_asiento.DataSource = Me.uds_Asiento
        Me.ug_asiento.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Width = 47
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 88
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 260
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance34
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance35
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance36
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance37
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn18.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn19.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn20.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn21.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn22.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn23.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        Me.ug_asiento.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ug_asiento.DisplayLayout.MaxColScrollRegions = 1
        Me.ug_asiento.DisplayLayout.MaxRowScrollRegions = 1
        Me.ug_asiento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ug_asiento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ug_asiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ug_asiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ug_asiento.Location = New System.Drawing.Point(0, 0)
        Me.ug_asiento.Name = "ug_asiento"
        Me.ug_asiento.Size = New System.Drawing.Size(953, 189)
        Me.ug_asiento.TabIndex = 0
        '
        'uds_Asiento
        '
        UltraDataColumn23.DataType = GetType(Boolean)
        Me.uds_Asiento.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(953, 189)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.ume_ValorTipoCambio_Det)
        Me.UltraGroupBox3.Controls.Add(Me.uce_cc)
        Me.UltraGroupBox3.Controls.Add(Me.uchk_Inafecto)
        Me.UltraGroupBox3.Controls.Add(Me.txt_Cod_Mon_Det)
        Me.UltraGroupBox3.Controls.Add(Me.uce_Moneda_Det)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox3.Controls.Add(Me.txt_cod_Doc_Det)
        Me.UltraGroupBox3.Controls.Add(Me.uc_Cuentas)
        Me.UltraGroupBox3.Controls.Add(Me.txt_idAnexoDet)
        Me.UltraGroupBox3.Controls.Add(Me.btn_CancelarDet)
        Me.UltraGroupBox3.Controls.Add(Me.btn_GrabarDet)
        Me.UltraGroupBox3.Controls.Add(Me.txt_Glosa_Det)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox3.Controls.Add(Me.ume_Haber_Det)
        Me.UltraGroupBox3.Controls.Add(Me.ume_Debe_Det)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox3.Controls.Add(Me.ume_FecVen_Det)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox3.Controls.Add(Me.ume_FecEmi_Det)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel27)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox3.Controls.Add(Me.uce_TipoDoc_Det)
        Me.UltraGroupBox3.Controls.Add(Me.txt_NumDoc_Det)
        Me.UltraGroupBox3.Controls.Add(Me.txt_SerieDoc_Det)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel29)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel30)
        Me.UltraGroupBox3.Controls.Add(Me.lbl_des_cta)
        Me.UltraGroupBox3.Controls.Add(Me.lbl_Des_Anexo)
        Me.UltraGroupBox3.Controls.Add(Me.txt_Anexo_Det)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel31)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(953, 189)
        Me.UltraGroupBox3.TabIndex = 0
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ume_ValorTipoCambio_Det
        '
        Appearance44.TextHAlignAsString = "Right"
        Me.ume_ValorTipoCambio_Det.Appearance = Appearance44
        Me.ume_ValorTipoCambio_Det.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_ValorTipoCambio_Det.InputMask = "{double:1.3}"
        Me.ume_ValorTipoCambio_Det.Location = New System.Drawing.Point(620, 63)
        Me.ume_ValorTipoCambio_Det.Name = "ume_ValorTipoCambio_Det"
        Me.ume_ValorTipoCambio_Det.Size = New System.Drawing.Size(57, 20)
        Me.ume_ValorTipoCambio_Det.TabIndex = 111
        '
        'uce_cc
        '
        Me.uce_cc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_cc.Location = New System.Drawing.Point(101, 131)
        Me.uce_cc.Name = "uce_cc"
        Me.uce_cc.Size = New System.Drawing.Size(358, 21)
        Me.uce_cc.TabIndex = 11
        '
        'uchk_Inafecto
        '
        Me.uchk_Inafecto.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Inafecto.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Inafecto.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.uchk_Inafecto.Location = New System.Drawing.Point(495, 104)
        Me.uchk_Inafecto.Name = "uchk_Inafecto"
        Me.uchk_Inafecto.Size = New System.Drawing.Size(85, 20)
        Me.uchk_Inafecto.TabIndex = 110
        Me.uchk_Inafecto.Text = "Inafecto"
        '
        'txt_Cod_Mon_Det
        '
        Me.txt_Cod_Mon_Det.Location = New System.Drawing.Point(495, 61)
        Me.txt_Cod_Mon_Det.Name = "txt_Cod_Mon_Det"
        Me.txt_Cod_Mon_Det.Size = New System.Drawing.Size(20, 21)
        Me.txt_Cod_Mon_Det.TabIndex = 5
        '
        'uce_Moneda_Det
        '
        Me.uce_Moneda_Det.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Moneda_Det.DropDownListWidth = 200
        Me.uce_Moneda_Det.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda_Det.Location = New System.Drawing.Point(515, 61)
        Me.uce_Moneda_Det.Name = "uce_Moneda_Det"
        Me.uce_Moneda_Det.Size = New System.Drawing.Size(99, 21)
        Me.uce_Moneda_Det.TabIndex = 6
        '
        'UltraLabel10
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance4
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(444, 65)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel10.TabIndex = 109
        Me.UltraLabel10.Text = "Moneda"
        '
        'txt_cod_Doc_Det
        '
        Me.txt_cod_Doc_Det.Location = New System.Drawing.Point(101, 59)
        Me.txt_cod_Doc_Det.Name = "txt_cod_Doc_Det"
        Me.txt_cod_Doc_Det.Size = New System.Drawing.Size(26, 21)
        Me.txt_cod_Doc_Det.TabIndex = 2
        '
        'uc_Cuentas
        '
        Me.uc_Cuentas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.uc_Cuentas.DataSource = Me.uds_Cuentas
        Appearance12.BackColor = System.Drawing.Color.White
        Me.uc_Cuentas.DisplayLayout.Appearance = Appearance12
        Me.uc_Cuentas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn
        UltraGridColumn24.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn24.Header.VisiblePosition = 0
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn25.Header.Caption = "Cuenta"
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn26.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn26.Header.Caption = "Descripcion"
        UltraGridColumn26.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        Me.uc_Cuentas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.uc_Cuentas.DisplayLayout.Override.CardAreaAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance14.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.FontData.BoldAsString = "True"
        Appearance14.FontData.Name = "Arial"
        Appearance14.FontData.SizeInPoints = 10.0!
        Appearance14.ForeColor = System.Drawing.Color.White
        Appearance14.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
        Me.uc_Cuentas.DisplayLayout.Override.HeaderAppearance = Appearance14
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(191, Byte), Integer))
        Appearance15.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(145, Byte), Integer))
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.uc_Cuentas.DisplayLayout.Override.RowSelectorAppearance = Appearance15
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(148, Byte), Integer))
        Appearance16.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(21, Byte), Integer))
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Me.uc_Cuentas.DisplayLayout.Override.SelectedRowAppearance = Appearance16
        Me.uc_Cuentas.DisplayMember = "PC_NUM_CUENTA"
        Me.uc_Cuentas.DropDownWidth = 400
        Me.uc_Cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uc_Cuentas.Location = New System.Drawing.Point(101, 10)
        Me.uc_Cuentas.Name = "uc_Cuentas"
        Me.uc_Cuentas.Size = New System.Drawing.Size(144, 22)
        Me.uc_Cuentas.TabIndex = 0
        Me.uc_Cuentas.ValueMember = "PC_IDCUENTA"
        '
        'uds_Cuentas
        '
        Me.uds_Cuentas.AllowDelete = False
        UltraDataColumn24.DataType = GetType(Integer)
        Me.uds_Cuentas.Band.Columns.AddRange(New Object() {UltraDataColumn24, UltraDataColumn25, UltraDataColumn26})
        '
        'txt_idAnexoDet
        '
        Me.txt_idAnexoDet.Location = New System.Drawing.Point(245, 34)
        Me.txt_idAnexoDet.Name = "txt_idAnexoDet"
        Me.txt_idAnexoDet.Size = New System.Drawing.Size(53, 21)
        Me.txt_idAnexoDet.TabIndex = 15
        '
        'btn_CancelarDet
        '
        Appearance2.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance2.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_CancelarDet.Appearance = Appearance2
        Me.btn_CancelarDet.Location = New System.Drawing.Point(655, 154)
        Me.btn_CancelarDet.Name = "btn_CancelarDet"
        Me.btn_CancelarDet.Size = New System.Drawing.Size(29, 24)
        Me.btn_CancelarDet.TabIndex = 14
        '
        'btn_GrabarDet
        '
        Appearance10.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance10.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_GrabarDet.Appearance = Appearance10
        Me.btn_GrabarDet.Location = New System.Drawing.Point(620, 154)
        Me.btn_GrabarDet.Name = "btn_GrabarDet"
        Me.btn_GrabarDet.Size = New System.Drawing.Size(29, 24)
        Me.btn_GrabarDet.TabIndex = 13
        '
        'txt_Glosa_Det
        '
        Me.txt_Glosa_Det.Location = New System.Drawing.Point(101, 155)
        Me.txt_Glosa_Det.Name = "txt_Glosa_Det"
        Me.txt_Glosa_Det.Size = New System.Drawing.Size(511, 21)
        Me.txt_Glosa_Det.TabIndex = 12
        '
        'UltraLabel22
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel22.Appearance = Appearance3
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Location = New System.Drawing.Point(57, 159)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel22.TabIndex = 45
        Me.UltraLabel22.Text = "Glosa"
        '
        'ume_Haber_Det
        '
        Appearance30.TextHAlignAsString = "Right"
        Me.ume_Haber_Det.Appearance = Appearance30
        Me.ume_Haber_Det.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Haber_Det.InputMask = "{double:-9.3}"
        Me.ume_Haber_Det.Location = New System.Drawing.Point(359, 106)
        Me.ume_Haber_Det.Name = "ume_Haber_Det"
        Me.ume_Haber_Det.Size = New System.Drawing.Size(100, 20)
        Me.ume_Haber_Det.TabIndex = 10
        '
        'ume_Debe_Det
        '
        Appearance61.TextHAlignAsString = "Right"
        Me.ume_Debe_Det.Appearance = Appearance61
        Me.ume_Debe_Det.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Debe_Det.InputMask = "{double:-9.3}"
        Me.ume_Debe_Det.Location = New System.Drawing.Point(101, 106)
        Me.ume_Debe_Det.Name = "ume_Debe_Det"
        Me.ume_Debe_Det.Size = New System.Drawing.Size(91, 20)
        Me.ume_Debe_Det.TabIndex = 9
        '
        'UltraLabel23
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel23.Appearance = Appearance86
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Location = New System.Drawing.Point(50, 14)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel23.TabIndex = 43
        Me.UltraLabel23.Text = "Cuenta"
        '
        'ume_FecVen_Det
        '
        Appearance22.Image = CType(resources.GetObject("Appearance22.Image"), Object)
        Appearance22.TextHAlignAsString = "Right"
        Me.ume_FecVen_Det.Appearance = Appearance22
        Me.ume_FecVen_Det.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Date]
        Me.ume_FecVen_Det.InputMask = "{date}"
        Me.ume_FecVen_Det.Location = New System.Drawing.Point(359, 83)
        Me.ume_FecVen_Det.Name = "ume_FecVen_Det"
        Me.ume_FecVen_Det.Size = New System.Drawing.Size(100, 20)
        Me.ume_FecVen_Det.TabIndex = 8
        Me.ume_FecVen_Det.Text = "UltraMaskedEdit1"
        '
        'UltraLabel25
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel25.Appearance = Appearance73
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UltraLabel25.Location = New System.Drawing.Point(255, 86)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(98, 15)
        Me.UltraLabel25.TabIndex = 37
        Me.UltraLabel25.Text = "Fecha Vencimiento"
        '
        'ume_FecEmi_Det
        '
        Appearance21.Image = CType(resources.GetObject("Appearance21.Image"), Object)
        Appearance21.TextHAlignAsString = "Right"
        Me.ume_FecEmi_Det.Appearance = Appearance21
        Me.ume_FecEmi_Det.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Date]
        Me.ume_FecEmi_Det.InputMask = "{date}"
        Me.ume_FecEmi_Det.Location = New System.Drawing.Point(101, 83)
        Me.ume_FecEmi_Det.Name = "ume_FecEmi_Det"
        Me.ume_FecEmi_Det.Size = New System.Drawing.Size(91, 20)
        Me.ume_FecEmi_Det.TabIndex = 7
        Me.ume_FecEmi_Det.Text = "UltraMaskedEdit1"
        '
        'UltraLabel26
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel26.Appearance = Appearance87
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UltraLabel26.Location = New System.Drawing.Point(319, 109)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(34, 15)
        Me.UltraLabel26.TabIndex = 35
        Me.UltraLabel26.Text = "Haber"
        '
        'UltraLabel27
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel27.Appearance = Appearance46
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UltraLabel27.Location = New System.Drawing.Point(61, 109)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(30, 15)
        Me.UltraLabel27.TabIndex = 35
        Me.UltraLabel27.Text = "Debe"
        '
        'UltraLabel28
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel28.Appearance = Appearance47
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UltraLabel28.Location = New System.Drawing.Point(15, 86)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(76, 15)
        Me.UltraLabel28.TabIndex = 35
        Me.UltraLabel28.Text = "Fecha Emision"
        '
        'uce_TipoDoc_Det
        '
        Me.uce_TipoDoc_Det.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc_Det.DropDownListWidth = 200
        Me.uce_TipoDoc_Det.Location = New System.Drawing.Point(127, 59)
        Me.uce_TipoDoc_Det.Name = "uce_TipoDoc_Det"
        Me.uce_TipoDoc_Det.Size = New System.Drawing.Size(118, 21)
        Me.uce_TipoDoc_Det.TabIndex = 2
        '
        'txt_NumDoc_Det
        '
        Me.txt_NumDoc_Det.Location = New System.Drawing.Point(298, 59)
        Me.txt_NumDoc_Det.Name = "txt_NumDoc_Det"
        Me.txt_NumDoc_Det.Size = New System.Drawing.Size(102, 21)
        Me.txt_NumDoc_Det.TabIndex = 4
        '
        'txt_SerieDoc_Det
        '
        Appearance9.TextHAlignAsString = "Left"
        Me.txt_SerieDoc_Det.Appearance = Appearance9
        Me.txt_SerieDoc_Det.Location = New System.Drawing.Point(245, 59)
        Me.txt_SerieDoc_Det.Name = "txt_SerieDoc_Det"
        Me.txt_SerieDoc_Det.Size = New System.Drawing.Size(53, 21)
        Me.txt_SerieDoc_Det.TabIndex = 3
        '
        'UltraLabel29
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel29.Appearance = Appearance23
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Location = New System.Drawing.Point(29, 63)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel29.TabIndex = 31
        Me.UltraLabel29.Text = "Documento"
        '
        'UltraLabel30
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel30.Appearance = Appearance24
        Me.UltraLabel30.AutoSize = True
        Me.UltraLabel30.Location = New System.Drawing.Point(20, 135)
        Me.UltraLabel30.Name = "UltraLabel30"
        Me.UltraLabel30.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel30.TabIndex = 28
        Me.UltraLabel30.Text = "Centro Costo"
        '
        'lbl_des_cta
        '
        Appearance18.TextHAlignAsString = "Left"
        Me.lbl_des_cta.Appearance = Appearance18
        Me.lbl_des_cta.Location = New System.Drawing.Point(245, 10)
        Me.lbl_des_cta.Name = "lbl_des_cta"
        Me.lbl_des_cta.ReadOnly = True
        Me.lbl_des_cta.Size = New System.Drawing.Size(369, 21)
        Me.lbl_des_cta.TabIndex = 14
        '
        'lbl_Des_Anexo
        '
        Appearance43.TextHAlignAsString = "Left"
        Me.lbl_Des_Anexo.Appearance = Appearance43
        Me.lbl_Des_Anexo.Location = New System.Drawing.Point(298, 34)
        Me.lbl_Des_Anexo.Name = "lbl_Des_Anexo"
        Me.lbl_Des_Anexo.ReadOnly = True
        Me.lbl_Des_Anexo.Size = New System.Drawing.Size(316, 21)
        Me.lbl_Des_Anexo.TabIndex = 16
        '
        'txt_Anexo_Det
        '
        Appearance41.TextHAlignAsString = "Left"
        Me.txt_Anexo_Det.Appearance = Appearance41
        Appearance60.Image = Global.Contabilidad.My.Resources.Resources._104
        EditorButton1.Appearance = Appearance60
        Me.txt_Anexo_Det.ButtonsRight.Add(EditorButton1)
        Me.txt_Anexo_Det.Location = New System.Drawing.Point(101, 34)
        Me.txt_Anexo_Det.Name = "txt_Anexo_Det"
        Me.txt_Anexo_Det.Size = New System.Drawing.Size(144, 21)
        Me.txt_Anexo_Det.TabIndex = 1
        '
        'UltraLabel31
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel31.Appearance = Appearance42
        Me.UltraLabel31.AutoSize = True
        Me.UltraLabel31.Location = New System.Drawing.Point(55, 38)
        Me.UltraLabel31.Name = "UltraLabel31"
        Me.UltraLabel31.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel31.TabIndex = 25
        Me.UltraLabel31.Text = "Anexo"
        '
        'ugb_Cabecera
        '
        Me.ugb_Cabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ugb_Cabecera.Controls.Add(Me.uchk_dividir9)
        Me.ugb_Cabecera.Controls.Add(Me.txt_IdCabecera)
        Me.ugb_Cabecera.Controls.Add(Me.ubtn_CrearAnexo)
        Me.ugb_Cabecera.Controls.Add(Me.uchkRelacionado)
        Me.ugb_Cabecera.Controls.Add(Me.txt_cod_Doc_Cab)
        Me.ugb_Cabecera.Controls.Add(Me.uchk_Ocultar)
        Me.ugb_Cabecera.Controls.Add(Me.ume_Imp_Pagar)
        Me.ugb_Cabecera.Controls.Add(Me.ume_Tasa_ISC)
        Me.ugb_Cabecera.Controls.Add(Me.txt_IdAnexo)
        Me.ugb_Cabecera.Controls.Add(Me.btn_Nuevo)
        Me.ugb_Cabecera.Controls.Add(Me.ume_Precioventa)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel15)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel16)
        Me.ugb_Cabecera.Controls.Add(Me.txt_Num_Voucher)
        Me.ugb_Cabecera.Controls.Add(Me.txt_Cod_Mon_Cab)
        Me.ugb_Cabecera.Controls.Add(Me.btn_DatosDetra)
        Me.ugb_Cabecera.Controls.Add(Me.btn_VerRef)
        Me.ugb_Cabecera.Controls.Add(Me.ume_Valor_ISC)
        Me.ugb_Cabecera.Controls.Add(Me.ume_OtrosTributos)
        Me.ugb_Cabecera.Controls.Add(Me.ume_ValorCompra)
        Me.ugb_Cabecera.Controls.Add(Me.ume_ValorNoGrabado)
        Me.ugb_Cabecera.Controls.Add(Me.ume_Tasa_Igv)
        Me.ugb_Cabecera.Controls.Add(Me.ume_Imp_Detra)
        Me.ugb_Cabecera.Controls.Add(Me.ume_Monto_Igv)
        Me.ugb_Cabecera.Controls.Add(Me.uce_TipoDoc)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel20)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel32)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel18)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel19)
        Me.ugb_Cabecera.Controls.Add(Me.uce_Indicador)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel17)
        Me.ugb_Cabecera.Controls.Add(Me.txt_NumDoc)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel24)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel21)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel14)
        Me.ugb_Cabecera.Controls.Add(Me.lbl_Imp_Detra)
        Me.ugb_Cabecera.Controls.Add(Me.txt_SerieDoc)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel13)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel12)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel11)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel9)
        Me.ugb_Cabecera.Controls.Add(Me.txt_Des_Prove)
        Me.ugb_Cabecera.Controls.Add(Me.txt_ruc_anexo)
        Me.ugb_Cabecera.Controls.Add(Me.btn_ListoCab)
        Me.ugb_Cabecera.Controls.Add(Me.ume_ValorTipoCambio)
        Me.ugb_Cabecera.Controls.Add(Me.txt_Glosa)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel4)
        Me.ugb_Cabecera.Controls.Add(Me.uce_Moneda)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel5)
        Me.ugb_Cabecera.Controls.Add(Me.uce_TipoCambio)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel6)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel7)
        Me.ugb_Cabecera.Controls.Add(Me.udte_Fec_Ven)
        Me.ugb_Cabecera.Controls.Add(Me.udte_Fec_Emi)
        Me.ugb_Cabecera.Controls.Add(Me.udte_fec_Vou)
        Me.ugb_Cabecera.Controls.Add(Me.lbludte_Fec_Ven)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel3)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel2)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel8)
        Me.ugb_Cabecera.Controls.Add(Me.UltraLabel1)
        Me.ugb_Cabecera.Controls.Add(Me.uce_SubOperacion)
        Me.ugb_Cabecera.Controls.Add(Me.uce_Subdiario)
        Me.ugb_Cabecera.Location = New System.Drawing.Point(4, 1)
        Me.ugb_Cabecera.Name = "ugb_Cabecera"
        Me.ugb_Cabecera.Size = New System.Drawing.Size(955, 248)
        Me.ugb_Cabecera.TabIndex = 0
        '
        'uchk_dividir9
        '
        Appearance20.FontData.BoldAsString = "False"
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.uchk_dividir9.Appearance = Appearance20
        Me.uchk_dividir9.BackColor = System.Drawing.Color.Transparent
        Me.uchk_dividir9.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_dividir9.Checked = True
        Me.uchk_dividir9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.uchk_dividir9.Location = New System.Drawing.Point(646, 217)
        Me.uchk_dividir9.Name = "uchk_dividir9"
        Me.uchk_dividir9.Size = New System.Drawing.Size(120, 20)
        Me.uchk_dividir9.TabIndex = 119
        Me.uchk_dividir9.Text = "Dividir en 9's"
        '
        'txt_IdCabecera
        '
        Me.txt_IdCabecera.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_IdCabecera.Location = New System.Drawing.Point(539, 16)
        Me.txt_IdCabecera.Name = "txt_IdCabecera"
        Me.txt_IdCabecera.Size = New System.Drawing.Size(42, 21)
        Me.txt_IdCabecera.TabIndex = 118
        Me.txt_IdCabecera.Visible = False
        '
        'ubtn_CrearAnexo
        '
        Appearance19.Image = Global.Contabilidad.My.Resources.Resources.User_01_48x48_32
        Me.ubtn_CrearAnexo.Appearance = Appearance19
        Me.ubtn_CrearAnexo.Location = New System.Drawing.Point(501, 42)
        Me.ubtn_CrearAnexo.Name = "ubtn_CrearAnexo"
        Me.ubtn_CrearAnexo.Size = New System.Drawing.Size(25, 23)
        Me.ubtn_CrearAnexo.TabIndex = 117
        '
        'uchkRelacionado
        '
        Me.uchkRelacionado.BackColor = System.Drawing.Color.Transparent
        Me.uchkRelacionado.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchkRelacionado.Enabled = False
        Me.uchkRelacionado.Location = New System.Drawing.Point(530, 44)
        Me.uchkRelacionado.Name = "uchkRelacionado"
        Me.uchkRelacionado.Size = New System.Drawing.Size(101, 20)
        Me.uchkRelacionado.TabIndex = 103
        Me.uchkRelacionado.Text = "Relacionado"
        '
        'txt_cod_Doc_Cab
        '
        Me.txt_cod_Doc_Cab.Location = New System.Drawing.Point(91, 95)
        Me.txt_cod_Doc_Cab.Name = "txt_cod_Doc_Cab"
        Me.txt_cod_Doc_Cab.Size = New System.Drawing.Size(26, 21)
        Me.txt_cod_Doc_Cab.TabIndex = 10
        '
        'uchk_Ocultar
        '
        Me.uchk_Ocultar.BackColor = System.Drawing.Color.Transparent
        Me.uchk_Ocultar.BackColorInternal = System.Drawing.Color.Transparent
        Me.uchk_Ocultar.Location = New System.Drawing.Point(646, 200)
        Me.uchk_Ocultar.Name = "uchk_Ocultar"
        Me.uchk_Ocultar.Size = New System.Drawing.Size(120, 20)
        Me.uchk_Ocultar.TabIndex = 25
        Me.uchk_Ocultar.Text = "Ocultar Columnas"
        Me.uchk_Ocultar.Visible = False
        '
        'ume_Imp_Pagar
        '
        Appearance68.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance68.TextHAlignAsString = "Right"
        Me.ume_Imp_Pagar.Appearance = Appearance68
        Me.ume_Imp_Pagar.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Imp_Pagar.InputMask = "{double:-9.3}"
        Me.ume_Imp_Pagar.Location = New System.Drawing.Point(504, 191)
        Me.ume_Imp_Pagar.Name = "ume_Imp_Pagar"
        Me.ume_Imp_Pagar.Size = New System.Drawing.Size(95, 20)
        Me.ume_Imp_Pagar.TabIndex = 18
        '
        'ume_Tasa_ISC
        '
        Appearance65.TextHAlignAsString = "Right"
        Me.ume_Tasa_ISC.Appearance = Appearance65
        Me.ume_Tasa_ISC.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Tasa_ISC.InputMask = "nn"
        Me.ume_Tasa_ISC.Location = New System.Drawing.Point(504, 172)
        Me.ume_Tasa_ISC.Name = "ume_Tasa_ISC"
        Me.ume_Tasa_ISC.ReadOnly = True
        Me.ume_Tasa_ISC.Size = New System.Drawing.Size(29, 20)
        Me.ume_Tasa_ISC.TabIndex = 77
        '
        'txt_IdAnexo
        '
        Me.txt_IdAnexo.Location = New System.Drawing.Point(220, 43)
        Me.txt_IdAnexo.Name = "txt_IdAnexo"
        Me.txt_IdAnexo.Size = New System.Drawing.Size(57, 21)
        Me.txt_IdAnexo.TabIndex = 26
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance88.Image = Global.Contabilidad.My.Resources.Resources._16__File_new_2_
        Appearance88.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance88.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_Nuevo.Appearance = Appearance88
        Me.btn_Nuevo.Location = New System.Drawing.Point(909, 203)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(40, 35)
        Me.btn_Nuevo.TabIndex = 19
        Appearance32.ForeColor = System.Drawing.Color.Navy
        UltraToolTipInfo1.Appearance = Appearance32
        UltraToolTipInfo1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo1.ToolTipText = "Habilita la ventana inferior para ingresar cuenta contable al asiento"
        UltraToolTipInfo1.ToolTipTitle = "Agregar Cuenta"
        Me.uttm_AnexoRapido.SetUltraToolTip(Me.btn_Nuevo, UltraToolTipInfo1)
        '
        'ume_Precioventa
        '
        Appearance64.BackColor = System.Drawing.Color.White
        Appearance64.TextHAlignAsString = "Right"
        Me.ume_Precioventa.Appearance = Appearance64
        Me.ume_Precioventa.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Precioventa.InputMask = "{double:-9.3}"
        Me.ume_Precioventa.Location = New System.Drawing.Point(111, 191)
        Me.ume_Precioventa.Name = "ume_Precioventa"
        Me.ume_Precioventa.Size = New System.Drawing.Size(109, 20)
        Me.ume_Precioventa.TabIndex = 20
        '
        'UltraLabel15
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance74
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(36, 194)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(69, 14)
        Me.UltraLabel15.TabIndex = 102
        Me.UltraLabel15.Text = "Precio Venta"
        '
        'UltraLabel16
        '
        Me.UltraLabel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel16.Appearance = Appearance6
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Location = New System.Drawing.Point(703, 15)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel16.TabIndex = 99
        Me.UltraLabel16.Text = "Num. Voucher"
        '
        'txt_Num_Voucher
        '
        Me.txt_Num_Voucher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance8.TextHAlignAsString = "Center"
        Me.txt_Num_Voucher.Appearance = Appearance8
        Me.txt_Num_Voucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Num_Voucher.Location = New System.Drawing.Point(785, 10)
        Me.txt_Num_Voucher.Name = "txt_Num_Voucher"
        Me.txt_Num_Voucher.Size = New System.Drawing.Size(162, 24)
        Me.txt_Num_Voucher.TabIndex = 100
        '
        'txt_Cod_Mon_Cab
        '
        Me.txt_Cod_Mon_Cab.Location = New System.Drawing.Point(91, 69)
        Me.txt_Cod_Mon_Cab.Name = "txt_Cod_Mon_Cab"
        Me.txt_Cod_Mon_Cab.Size = New System.Drawing.Size(26, 21)
        Me.txt_Cod_Mon_Cab.TabIndex = 6
        '
        'btn_DatosDetra
        '
        Appearance27.Image = Global.Contabilidad.My.Resources.Resources._16__Credit_card_
        Appearance27.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance27.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_DatosDetra.Appearance = Appearance27
        Me.btn_DatosDetra.Location = New System.Drawing.Point(413, 94)
        Me.btn_DatosDetra.Name = "btn_DatosDetra"
        Me.btn_DatosDetra.Size = New System.Drawing.Size(24, 24)
        Me.btn_DatosDetra.TabIndex = 97
        UltraToolTipInfo2.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo2.ToolTipText = "Muestra la ventana para ingresar los datos de la detraccion"
        UltraToolTipInfo2.ToolTipTitle = "Doc. Detraccion"
        Me.uttm_AnexoRapido.SetUltraToolTip(Me.btn_DatosDetra, UltraToolTipInfo2)
        '
        'btn_VerRef
        '
        Appearance59.Image = Global.Contabilidad.My.Resources.Resources._16__Page_numbers_
        Appearance59.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance59.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_VerRef.Appearance = Appearance59
        Me.btn_VerRef.Location = New System.Drawing.Point(390, 94)
        Me.btn_VerRef.Name = "btn_VerRef"
        Me.btn_VerRef.Size = New System.Drawing.Size(24, 24)
        Me.btn_VerRef.TabIndex = 69
        UltraToolTipInfo3.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        UltraToolTipInfo3.ToolTipText = "Muestra la ventana para ingresar los datos del documento de referencia"
        UltraToolTipInfo3.ToolTipTitle = "Doc. de Refencia"
        Me.uttm_AnexoRapido.SetUltraToolTip(Me.btn_VerRef, UltraToolTipInfo3)
        '
        'ume_Valor_ISC
        '
        Appearance91.TextHAlignAsString = "Right"
        Me.ume_Valor_ISC.Appearance = Appearance91
        Me.ume_Valor_ISC.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Valor_ISC.InputMask = "{double:-9.3}"
        Me.ume_Valor_ISC.Location = New System.Drawing.Point(309, 153)
        Me.ume_Valor_ISC.Name = "ume_Valor_ISC"
        Me.ume_Valor_ISC.Size = New System.Drawing.Size(109, 20)
        Me.ume_Valor_ISC.TabIndex = 23
        '
        'ume_OtrosTributos
        '
        Appearance92.TextHAlignAsString = "Right"
        Me.ume_OtrosTributos.Appearance = Appearance92
        Me.ume_OtrosTributos.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_OtrosTributos.InputMask = "{double:-9.3}"
        Me.ume_OtrosTributos.Location = New System.Drawing.Point(111, 172)
        Me.ume_OtrosTributos.Name = "ume_OtrosTributos"
        Me.ume_OtrosTributos.Size = New System.Drawing.Size(109, 20)
        Me.ume_OtrosTributos.TabIndex = 21
        '
        'ume_ValorCompra
        '
        Me.ume_ValorCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance93.TextHAlignAsString = "Right"
        Me.ume_ValorCompra.Appearance = Appearance93
        Me.ume_ValorCompra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_ValorCompra.InputMask = "{double:-9.3}"
        Me.ume_ValorCompra.Location = New System.Drawing.Point(838, 150)
        Me.ume_ValorCompra.Name = "ume_ValorCompra"
        Me.ume_ValorCompra.Size = New System.Drawing.Size(109, 20)
        Me.ume_ValorCompra.TabIndex = 15
        '
        'ume_ValorNoGrabado
        '
        Appearance95.TextHAlignAsString = "Right"
        Me.ume_ValorNoGrabado.Appearance = Appearance95
        Me.ume_ValorNoGrabado.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_ValorNoGrabado.InputMask = "{double:-9.3}"
        Me.ume_ValorNoGrabado.Location = New System.Drawing.Point(111, 153)
        Me.ume_ValorNoGrabado.Name = "ume_ValorNoGrabado"
        Me.ume_ValorNoGrabado.Size = New System.Drawing.Size(109, 20)
        Me.ume_ValorNoGrabado.TabIndex = 22
        '
        'ume_Tasa_Igv
        '
        Appearance66.TextHAlignAsString = "Right"
        Me.ume_Tasa_Igv.Appearance = Appearance66
        Me.ume_Tasa_Igv.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Tasa_Igv.InputMask = "nn"
        Me.ume_Tasa_Igv.Location = New System.Drawing.Point(504, 153)
        Me.ume_Tasa_Igv.Name = "ume_Tasa_Igv"
        Me.ume_Tasa_Igv.ReadOnly = True
        Me.ume_Tasa_Igv.Size = New System.Drawing.Size(29, 20)
        Me.ume_Tasa_Igv.TabIndex = 80
        '
        'ume_Imp_Detra
        '
        Appearance67.TextHAlignAsString = "Right"
        Me.ume_Imp_Detra.Appearance = Appearance67
        Me.ume_Imp_Detra.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Imp_Detra.InputMask = "{double:-9.3}"
        Me.ume_Imp_Detra.Location = New System.Drawing.Point(309, 191)
        Me.ume_Imp_Detra.Name = "ume_Imp_Detra"
        Me.ume_Imp_Detra.Size = New System.Drawing.Size(109, 20)
        Me.ume_Imp_Detra.TabIndex = 19
        '
        'ume_Monto_Igv
        '
        Appearance96.TextHAlignAsString = "Right"
        Me.ume_Monto_Igv.Appearance = Appearance96
        Me.ume_Monto_Igv.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_Monto_Igv.InputMask = "{double:-9.3}"
        Me.ume_Monto_Igv.Location = New System.Drawing.Point(309, 172)
        Me.ume_Monto_Igv.Name = "ume_Monto_Igv"
        Me.ume_Monto_Igv.Size = New System.Drawing.Size(109, 20)
        Me.ume_Monto_Igv.TabIndex = 24
        '
        'uce_TipoDoc
        '
        Me.uce_TipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoDoc.DropDownListWidth = 200
        Me.uce_TipoDoc.Location = New System.Drawing.Point(117, 95)
        Me.uce_TipoDoc.Name = "uce_TipoDoc"
        Me.uce_TipoDoc.Size = New System.Drawing.Size(109, 21)
        Me.uce_TipoDoc.TabIndex = 11
        '
        'UltraLabel20
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel20.Appearance = Appearance70
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Location = New System.Drawing.Point(31, 174)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(76, 14)
        Me.UltraLabel20.TabIndex = 88
        Me.UltraLabel20.Text = "Otros Tributos"
        '
        'UltraLabel32
        '
        Me.UltraLabel32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel32.Appearance = Appearance72
        Me.UltraLabel32.AutoSize = True
        Me.UltraLabel32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel32.Location = New System.Drawing.Point(773, 153)
        Me.UltraLabel32.Name = "UltraLabel32"
        Me.UltraLabel32.Size = New System.Drawing.Size(60, 16)
        Me.UltraLabel32.TabIndex = 89
        Me.UltraLabel32.Text = "Base Imp."
        '
        'UltraLabel18
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel18.Appearance = Appearance71
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Location = New System.Drawing.Point(253, 156)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel18.TabIndex = 90
        Me.UltraLabel18.Text = "Valor ISC"
        '
        'UltraLabel19
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel19.Appearance = Appearance89
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Location = New System.Drawing.Point(14, 156)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(95, 14)
        Me.UltraLabel19.TabIndex = 85
        Me.UltraLabel19.Text = "Valor No Gravado"
        '
        'uce_Indicador
        '
        Me.uce_Indicador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Indicador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Indicador.Location = New System.Drawing.Point(111, 123)
        Me.uce_Indicador.Name = "uce_Indicador"
        Me.uce_Indicador.Size = New System.Drawing.Size(161, 21)
        Me.uce_Indicador.TabIndex = 14
        '
        'UltraLabel17
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel17.Appearance = Appearance75
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(449, 174)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel17.TabIndex = 86
        Me.UltraLabel17.Text = "Tasa ISC"
        '
        'txt_NumDoc
        '
        Me.txt_NumDoc.Location = New System.Drawing.Point(278, 95)
        Me.txt_NumDoc.Name = "txt_NumDoc"
        Me.txt_NumDoc.Size = New System.Drawing.Size(102, 21)
        Me.txt_NumDoc.TabIndex = 13
        '
        'UltraLabel24
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel24.Appearance = Appearance76
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Location = New System.Drawing.Point(539, 176)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel24.TabIndex = 87
        Me.UltraLabel24.Text = "%"
        '
        'UltraLabel21
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel21.Appearance = Appearance57
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Location = New System.Drawing.Point(539, 156)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel21.TabIndex = 94
        Me.UltraLabel21.Text = "%"
        '
        'UltraLabel14
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance58
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(448, 156)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(52, 14)
        Me.UltraLabel14.TabIndex = 95
        Me.UltraLabel14.Text = "Tasa IGV"
        '
        'lbl_Imp_Detra
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.lbl_Imp_Detra.Appearance = Appearance78
        Me.lbl_Imp_Detra.AutoSize = True
        Me.lbl_Imp_Detra.Location = New System.Drawing.Point(224, 194)
        Me.lbl_Imp_Detra.Name = "lbl_Imp_Detra"
        Me.lbl_Imp_Detra.Size = New System.Drawing.Size(83, 14)
        Me.lbl_Imp_Detra.TabIndex = 96
        Me.lbl_Imp_Detra.Text = "Imp. Detraccion"
        '
        'txt_SerieDoc
        '
        Appearance77.TextHAlignAsString = "Left"
        Me.txt_SerieDoc.Appearance = Appearance77
        Me.txt_SerieDoc.Location = New System.Drawing.Point(226, 95)
        Me.txt_SerieDoc.Name = "txt_SerieDoc"
        Me.txt_SerieDoc.Size = New System.Drawing.Size(53, 21)
        Me.txt_SerieDoc.TabIndex = 12
        '
        'UltraLabel13
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance97
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(247, 175)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel13.TabIndex = 91
        Me.UltraLabel13.Text = "Monto IGV"
        '
        'UltraLabel12
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance79
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(15, 127)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel12.TabIndex = 92
        Me.UltraLabel12.Text = "Indicador Destino"
        '
        'UltraLabel11
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance80
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(466, 192)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel11.TabIndex = 93
        Me.UltraLabel11.Text = "Total"
        '
        'UltraLabel9
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance81
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(23, 99)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel9.TabIndex = 84
        Me.UltraLabel9.Text = "Documento"
        '
        'txt_Des_Prove
        '
        Me.txt_Des_Prove.Location = New System.Drawing.Point(276, 43)
        Me.txt_Des_Prove.Name = "txt_Des_Prove"
        Me.txt_Des_Prove.ReadOnly = True
        Me.txt_Des_Prove.Size = New System.Drawing.Size(223, 21)
        Me.txt_Des_Prove.TabIndex = 27
        '
        'txt_ruc_anexo
        '
        Appearance111.Image = Global.Contabilidad.My.Resources.Resources._104
        Appearance111.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance111.ImageVAlign = Infragistics.Win.VAlign.Middle
        EditorButton2.Appearance = Appearance111
        EditorButton2.Key = "Ayuda"
        Me.txt_ruc_anexo.ButtonsRight.Add(EditorButton2)
        Me.txt_ruc_anexo.Location = New System.Drawing.Point(91, 43)
        Me.txt_ruc_anexo.MaxLength = 11
        Me.txt_ruc_anexo.Name = "txt_ruc_anexo"
        Me.txt_ruc_anexo.Size = New System.Drawing.Size(129, 21)
        Me.txt_ruc_anexo.TabIndex = 2
        '
        'btn_ListoCab
        '
        Appearance94.Image = Global.Contabilidad.My.Resources.Resources._16__Ok_
        Appearance94.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance94.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btn_ListoCab.Appearance = Appearance94
        Me.btn_ListoCab.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007RibbonButton
        Me.btn_ListoCab.Location = New System.Drawing.Point(602, 214)
        Me.btn_ListoCab.Name = "btn_ListoCab"
        Me.btn_ListoCab.Size = New System.Drawing.Size(29, 24)
        Me.btn_ListoCab.TabIndex = 17
        '
        'ume_ValorTipoCambio
        '
        Appearance38.TextHAlignAsString = "Right"
        Me.ume_ValorTipoCambio.Appearance = Appearance38
        Me.ume_ValorTipoCambio.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_ValorTipoCambio.InputMask = "{double:1.3}"
        Me.ume_ValorTipoCambio.Location = New System.Drawing.Point(429, 70)
        Me.ume_ValorTipoCambio.Name = "ume_ValorTipoCambio"
        Me.ume_ValorTipoCambio.Size = New System.Drawing.Size(57, 20)
        Me.ume_ValorTipoCambio.TabIndex = 9
        '
        'txt_Glosa
        '
        Appearance33.Image = Global.Contabilidad.My.Resources.Resources._16__Fill_left_
        EditorButton3.Appearance = Appearance33
        EditorButton3.Key = "btn_get_anexo"
        Me.txt_Glosa.ButtonsRight.Add(EditorButton3)
        Me.txt_Glosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Glosa.Location = New System.Drawing.Point(111, 217)
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(485, 21)
        Me.txt_Glosa.TabIndex = 16
        '
        'UltraLabel4
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Appearance1.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance1
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(69, 221)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel4.TabIndex = 62
        Me.UltraLabel4.Text = "Glosa"
        '
        'uce_Moneda
        '
        Me.uce_Moneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_Moneda.DropDownListWidth = 200
        Me.uce_Moneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Moneda.Location = New System.Drawing.Point(117, 69)
        Me.uce_Moneda.Name = "uce_Moneda"
        Me.uce_Moneda.Size = New System.Drawing.Size(109, 21)
        Me.uce_Moneda.TabIndex = 7
        '
        'UltraLabel5
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance98
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(40, 73)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(45, 14)
        Me.UltraLabel5.TabIndex = 59
        Me.UltraLabel5.Text = "Moneda"
        '
        'uce_TipoCambio
        '
        Me.uce_TipoCambio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.uce_TipoCambio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_TipoCambio.Location = New System.Drawing.Point(326, 69)
        Me.uce_TipoCambio.Name = "uce_TipoCambio"
        Me.uce_TipoCambio.Size = New System.Drawing.Size(100, 21)
        Me.uce_TipoCambio.TabIndex = 8
        '
        'UltraLabel6
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance5
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(241, 73)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(84, 14)
        Me.UltraLabel6.TabIndex = 58
        Me.UltraLabel6.Text = "Tipo de Cambio"
        '
        'UltraLabel7
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance29
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(29, 47)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel7.TabIndex = 61
        Me.UltraLabel7.Text = "Proveedor"
        '
        'udte_Fec_Ven
        '
        Me.udte_Fec_Ven.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udte_Fec_Ven.Location = New System.Drawing.Point(850, 80)
        Me.udte_Fec_Ven.Name = "udte_Fec_Ven"
        Me.udte_Fec_Ven.Size = New System.Drawing.Size(97, 21)
        Me.udte_Fec_Ven.TabIndex = 5
        '
        'udte_Fec_Emi
        '
        Me.udte_Fec_Emi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udte_Fec_Emi.Location = New System.Drawing.Point(850, 60)
        Me.udte_Fec_Emi.Name = "udte_Fec_Emi"
        Me.udte_Fec_Emi.Size = New System.Drawing.Size(97, 21)
        Me.udte_Fec_Emi.TabIndex = 4
        '
        'udte_fec_Vou
        '
        Me.udte_fec_Vou.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.udte_fec_Vou.Location = New System.Drawing.Point(850, 40)
        Me.udte_fec_Vou.Name = "udte_fec_Vou"
        Me.udte_fec_Vou.Size = New System.Drawing.Size(97, 21)
        Me.udte_fec_Vou.TabIndex = 3
        '
        'lbludte_Fec_Ven
        '
        Me.lbludte_Fec_Ven.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.lbludte_Fec_Ven.Appearance = Appearance7
        Me.lbludte_Fec_Ven.AutoSize = True
        Me.lbludte_Fec_Ven.Location = New System.Drawing.Point(773, 84)
        Me.lbludte_Fec_Ven.Name = "lbludte_Fec_Ven"
        Me.lbludte_Fec_Ven.Size = New System.Drawing.Size(70, 14)
        Me.lbludte_Fec_Ven.TabIndex = 1
        Me.lbludte_Fec_Ven.Text = "Fec. Vencim."
        '
        'UltraLabel3
        '
        Me.UltraLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance28
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(773, 64)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel3.TabIndex = 1
        Me.UltraLabel3.Text = "Fec. Emision"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance56
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(773, 44)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Fec. Voucher"
        '
        'UltraLabel8
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance69
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(331, 20)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel8.TabIndex = 1
        Me.UltraLabel8.Text = "Tipo Compra"
        '
        'UltraLabel1
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance90
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(31, 20)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "SubDiario"
        '
        'uce_SubOperacion
        '
        Me.uce_SubOperacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_SubOperacion.Location = New System.Drawing.Point(407, 16)
        Me.uce_SubOperacion.Name = "uce_SubOperacion"
        Me.uce_SubOperacion.Size = New System.Drawing.Size(123, 21)
        Me.uce_SubOperacion.TabIndex = 1
        '
        'uce_Subdiario
        '
        Me.uce_Subdiario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.uce_Subdiario.Location = New System.Drawing.Point(91, 16)
        Me.uce_Subdiario.Name = "uce_Subdiario"
        Me.uce_Subdiario.Size = New System.Drawing.Size(230, 21)
        Me.uce_Subdiario.TabIndex = 0
        '
        'utc_Asiento
        '
        Me.utc_Asiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.utc_Asiento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utc_Asiento.Controls.Add(Me.UltraTabPageControl1)
        Me.utc_Asiento.Controls.Add(Me.UltraTabPageControl2)
        Me.utc_Asiento.Location = New System.Drawing.Point(4, 255)
        Me.utc_Asiento.Name = "utc_Asiento"
        Me.utc_Asiento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utc_Asiento.Size = New System.Drawing.Size(955, 212)
        Me.utc_Asiento.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.utc_Asiento.TabIndex = 23
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Asiento Contable"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Ingreso de Datos"
        Me.utc_Asiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.utc_Asiento.TextOrientation = Infragistics.Win.UltraWinTabs.TextOrientation.Horizontal
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(953, 189)
        '
        'ume_tot_d
        '
        Me.ume_tot_d.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance45.FontData.SizeInPoints = 9.0!
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextHAlignAsString = "Right"
        Me.ume_tot_d.Appearance = Appearance45
        Me.ume_tot_d.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tot_d.InputMask = "{double:-9.2}"
        Me.ume_tot_d.Location = New System.Drawing.Point(621, 475)
        Me.ume_tot_d.Name = "ume_tot_d"
        Me.ume_tot_d.ReadOnly = True
        Me.ume_tot_d.Size = New System.Drawing.Size(116, 21)
        Me.ume_tot_d.TabIndex = 26
        '
        'ume_tot_h
        '
        Me.ume_tot_h.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance63.FontData.SizeInPoints = 9.0!
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Appearance63.TextHAlignAsString = "Right"
        Me.ume_tot_h.Appearance = Appearance63
        Me.ume_tot_h.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_tot_h.InputMask = "{double:-9.2}"
        Me.ume_tot_h.Location = New System.Drawing.Point(743, 475)
        Me.ume_tot_h.Name = "ume_tot_h"
        Me.ume_tot_h.ReadOnly = True
        Me.ume_tot_h.Size = New System.Drawing.Size(103, 21)
        Me.ume_tot_h.TabIndex = 25
        '
        'ume_dif
        '
        Me.ume_dif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance62.FontData.SizeInPoints = 9.0!
        Appearance62.ForeColor = System.Drawing.Color.Red
        Appearance62.TextHAlignAsString = "Right"
        Me.ume_dif.Appearance = Appearance62
        Me.ume_dif.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.ume_dif.InputMask = "{double:-9.2}"
        Me.ume_dif.Location = New System.Drawing.Point(852, 475)
        Me.ume_dif.Name = "ume_dif"
        Me.ume_dif.ReadOnly = True
        Me.ume_dif.Size = New System.Drawing.Size(107, 21)
        Me.ume_dif.TabIndex = 24
        '
        'ubtn_GrabarVoucher
        '
        Me.ubtn_GrabarVoucher.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance82.Image = Global.Contabilidad.My.Resources.Resources._003
        Me.ubtn_GrabarVoucher.Appearance = Appearance82
        Me.ubtn_GrabarVoucher.Location = New System.Drawing.Point(5, 473)
        Me.ubtn_GrabarVoucher.Name = "ubtn_GrabarVoucher"
        Me.ubtn_GrabarVoucher.Size = New System.Drawing.Size(84, 27)
        Me.ubtn_GrabarVoucher.TabIndex = 27
        Me.ubtn_GrabarVoucher.Text = "&Grabar"
        '
        'ubtn_Cancelar
        '
        Me.ubtn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance48.Image = Global.Contabilidad.My.Resources.Resources._16__Cancel_
        Me.ubtn_Cancelar.Appearance = Appearance48
        Me.ubtn_Cancelar.Location = New System.Drawing.Point(95, 473)
        Me.ubtn_Cancelar.Name = "ubtn_Cancelar"
        Me.ubtn_Cancelar.Size = New System.Drawing.Size(85, 27)
        Me.ubtn_Cancelar.TabIndex = 27
        Me.ubtn_Cancelar.Text = "&Cancelar"
        '
        'ubtn_Salir
        '
        Me.ubtn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance83.Image = Global.Contabilidad.My.Resources.Resources._28
        Me.ubtn_Salir.Appearance = Appearance83
        Me.ubtn_Salir.Location = New System.Drawing.Point(214, 473)
        Me.ubtn_Salir.Name = "ubtn_Salir"
        Me.ubtn_Salir.Size = New System.Drawing.Size(85, 27)
        Me.ubtn_Salir.TabIndex = 28
        Me.ubtn_Salir.Text = "&Salir"
        '
        'ubtn_Impresion
        '
        Me.ubtn_Impresion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance11.Image = Global.Contabilidad.My.Resources.Resources.klpq_24x24_32
        Me.ubtn_Impresion.Appearance = Appearance11
        Me.ubtn_Impresion.Location = New System.Drawing.Point(305, 473)
        Me.ubtn_Impresion.Name = "ubtn_Impresion"
        Me.ubtn_Impresion.Size = New System.Drawing.Size(75, 27)
        Me.ubtn_Impresion.TabIndex = 29
        Me.ubtn_Impresion.Text = "Imprimir"
        '
        'uttm_AnexoRapido
        '
        Me.uttm_AnexoRapido.ContainingControl = Me
        Me.uttm_AnexoRapido.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.Office2007
        Me.uttm_AnexoRapido.ToolTipTitle = "Registro de Anexo"
        '
        'CO_PR_VouCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(967, 502)
        Me.Controls.Add(Me.ubtn_Impresion)
        Me.Controls.Add(Me.ubtn_Salir)
        Me.Controls.Add(Me.ubtn_Cancelar)
        Me.Controls.Add(Me.ubtn_GrabarVoucher)
        Me.Controls.Add(Me.ume_tot_d)
        Me.Controls.Add(Me.ume_tot_h)
        Me.Controls.Add(Me.ume_dif)
        Me.Controls.Add(Me.utc_Asiento)
        Me.Controls.Add(Me.ugb_Cabecera)
        Me.MaximizeBox = False
        Me.Name = "CO_PR_VouCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher de Compras"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ug_asiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.uce_cc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Cod_Mon_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Moneda_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_Doc_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uc_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uds_Cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_idAnexoDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Glosa_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerieDoc_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_des_cta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_Des_Anexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Anexo_Det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugb_Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugb_Cabecera.ResumeLayout(False)
        Me.ugb_Cabecera.PerformLayout()
        CType(Me.txt_IdCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cod_Doc_Cab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_IdAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Num_Voucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Cod_Mon_Cab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Indicador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NumDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SerieDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Des_Prove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ruc_anexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Moneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_TipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_Fec_Ven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_Fec_Emi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udte_fec_Vou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_SubOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uce_Subdiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utc_Asiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utc_Asiento.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugb_Cabecera As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udte_Fec_Ven As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_Fec_Emi As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents udte_fec_Vou As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lbludte_Fec_Ven As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_DatosDetra As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_VerRef As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_Valor_ISC As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_OtrosTributos As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_ValorCompra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_ValorNoGrabado As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Tasa_ISC As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Tasa_Igv As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Imp_Detra As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Monto_Igv As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Imp_Pagar As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents uce_TipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel32 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Indicador As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_NumDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_Imp_Detra As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_SerieDoc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ruc_anexo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btn_ListoCab As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ume_ValorTipoCambio As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txt_Glosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_Moneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoCambio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_cod_Doc_Cab As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Cod_Mon_Cab As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Num_Voucher As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Des_Prove As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_Subdiario As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents uds_Asiento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents utc_Asiento As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_CancelarDet As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btn_GrabarDet As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_Glosa_Det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_Haber_Det As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Debe_Det As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_FecVen_Det As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_FecEmi_Det As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_TipoDoc_Det As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_NumDoc_Det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_SerieDoc_Det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel30 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Anexo_Det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel31 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ume_tot_d As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_tot_h As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_dif As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents ume_Precioventa As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btn_Nuevo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_IdAnexo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_idAnexoDet As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbl_Des_Anexo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ubtn_GrabarVoucher As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Cancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lbl_des_cta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uc_Cuentas As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents uds_Cuentas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txt_cod_Doc_Det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uce_SubOperacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txt_Cod_Mon_Det As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uce_Moneda_Det As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents uchk_Ocultar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ug_asiento As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uchkRelacionado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ubtn_Salir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents uchk_Inafecto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ubtn_CrearAnexo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ubtn_Impresion As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_IdCabecera As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uttm_AnexoRapido As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents uchk_dividir9 As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents uce_cc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ume_ValorTipoCambio_Det As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
End Class
