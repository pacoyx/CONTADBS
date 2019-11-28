Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinDataSource
Imports System.IO
Imports Infragistics.Win.UltraWinEditors
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Text.RegularExpressions

Module ModBasConta

    Public gInt_IdEmpresa As Integer = 0
    Public gStr_NomEmpresa As String = 0
    Public gDat_Fecha_Sis As Date = Date.Now.ToShortDateString
    Public gStr_Usuario_Sis As String = "Admin"
    Public gInt_IdUsuario_Sis As Integer = 0
    Public gInt_IdLog As Integer = 0
    Public gStr_RutaRep As String = ""

    Public gCInt_Ope_Compras As Integer = 1
    Public gCInt_Ope_Ventas As Integer = 2
    Public gCInt_Ope_CajaBancos As Integer = 3
    Public gCInt_Ope_Honorarios As Integer = 4
    Public gCInt_Ope_Generales As Integer = 5

    Public var_Titulo As String

    Public Function get_Descripcion_CtaContable(ByVal num_cta_ As String, ByVal ayo_ As Integer, ByVal empresa_ As Integer) As String

        Dim resultado As String = String.Empty

        Dim planctasBL As New BL.ContabilidadBL.SG_CO_TB_PLANCTAS
        Dim planctasBE As New BE.ContabilidadBE.SG_CO_TB_PLANCTAS

        planctasBE.PC_NUM_CUENTA = num_cta_
        planctasBE.PC_PERIODO = ayo_
        planctasBE.PC_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = empresa_}

        planctasBL.getCuenta_X_NumeroCta(planctasBE)


        If planctasBE.PC_DESCRIPCION.Length > 0 Then
            resultado = planctasBE.PC_DESCRIPCION
        Else
            resultado = "*No existe la cuenta!"
        End If

        planctasBE = Nothing
        planctasBL = Nothing

        Return resultado

    End Function
    

    Public Function Letras(ByVal numero As Double) As String

        If numero = 0 Then
            Return "00/100"
        End If

        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec & "/100"
            Else
                Letras = palabras & "con  00/100"
            End If
        Else
            Letras = ""
        End If
    End Function

    Public Function Verificar_Anho_Cerrado(ByVal ayo As Integer) As Boolean
        'validar año si esta cerrado o si no existe
        Dim controlBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
        If controlBL.Es_Periodo_Cerrado(ayo, gInt_IdEmpresa) Then
            Avisar("El año de la fecha no es valido")
            Verificar_Anho_Cerrado = True
        End If
        controlBL = Nothing
    End Function

    Public Sub Verificar_Mes_Cerrado(ByVal myFormulario As Form, ByVal ayo As Integer, ByVal mes As Integer, ByRef Bol_Cerrado As Boolean)
        Try
            Dim AdmMesBL As New BL.ContabilidadBL.SG_CO_TB_ADMMES
            Dim AdmMesBE As New BE.ContabilidadBE.SG_CO_TB_ADMMES

            With AdmMesBE
                .AM_ANHO = ayo
                .AM_MES = mes
                .AM_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            End With

            Bol_Cerrado = False

            If AdmMesBL.Esta_Cerrado_Mes(AdmMesBE) Then
                Bol_Cerrado = True
                Avisar("El mes esta cerrado y no se puede realizar operaciones.")

                For Each fff As Control In myFormulario.Controls
                    If TypeOf fff Is Infragistics.Win.Misc.UltraButton Then
                        fff.Enabled = False
                    End If
                    If TypeOf fff Is Infragistics.Win.Misc.UltraGroupBox Then
                        fff.Enabled = False
                    End If
                Next

            End If

            AdmMesBL = Nothing
            AdmMesBE = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Sub CargarCombo_ConMeses(ByVal uce_Mes As Infragistics.Win.UltraWinEditors.UltraComboEditor)

        uce_Mes.Items.Add(1, "Enero")
        uce_Mes.Items.Add(2, "Febrero")
        uce_Mes.Items.Add(3, "Marzo")
        uce_Mes.Items.Add(4, "Abril")
        uce_Mes.Items.Add(5, "Mayo")
        uce_Mes.Items.Add(6, "Junio")
        uce_Mes.Items.Add(7, "Julio")
        uce_Mes.Items.Add(8, "Agosto")
        uce_Mes.Items.Add(9, "Septiembre")
        uce_Mes.Items.Add(10, "Octubre")
        uce_Mes.Items.Add(11, "Noviembre")
        uce_Mes.Items.Add(12, "Diciembre")
        uce_Mes.MaxDropDownItems = 12

    End Sub

    Public Sub Formatear_Grilla_Selector(ByVal Ultragrilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Ultragrilla.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Ultragrilla.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Ultragrilla.DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.White
        Ultragrilla.DisplayLayout.Override.SelectedRowAppearance.BackColor = Color.LightSlateGray
        Ultragrilla.DisplayLayout.Override.SelectedRowAppearance.BackColor2 = Color.LightSlateGray
        Ultragrilla.DisplayLayout.Override.SelectedRowAppearance.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Ultragrilla.DisplayLayout.Override.SelectTypeRow = SelectType.Single
        Ultragrilla.DisplayLayout.ScrollBounds = ScrollBounds.ScrollToFill

        Dim rc As New Infragistics.Shared.ResourceCustomizer()
        rc = Infragistics.Win.UltraWinGrid.Resources.Customizer
        rc.SetCustomizedString("RowFilterDialogBlanksItem", "Esp.Blancos")
        rc.SetCustomizedString("RowFilterDropDown_Operator_Contains", "Contiene")
        rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotContain", "No Contiene")
        rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotEndWith", "No Termina con")
        rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotMatch", "No Coincide")
        rc.SetCustomizedString("RowFilterDropDown_Operator_DoesNotStartWith", "No empieza con")
        rc.SetCustomizedString("RowFilterDropDown_Operator_EndsWith", "Termina con")
        rc.SetCustomizedString("RowFilterDropDown_Operator_Equals", "Igual")
        rc.SetCustomizedString("RowFilterDropDown_Operator_GreaterThan", "Mayor que")
        rc.SetCustomizedString("RowFilterDropDown_Operator_GreaterThanOrEqualTo", "Mayor o igual a")
        rc.SetCustomizedString("RowFilterDropDown_Operator_LessThan", "Menor que")
        rc.SetCustomizedString("RowFilterDropDown_Operator_LessThanOrEqualTo", "Menor o igual a")
        rc.SetCustomizedString("RowFilterDropDown_Operator_Like", "Como")
        rc.SetCustomizedString("RowFilterDropDown_Operator_Match", "Coincide")
        rc.SetCustomizedString("RowFilterDropDown_Operator_NotEquals", "No igual")
        rc.SetCustomizedString("RowFilterDropDown_Operator_NotLike", "No Como")
        rc.SetCustomizedString("RowFilterDropDown_Operator_StartsWith", "Comienza con")
        rc.SetCustomizedString("RowFilterDropDownAllItem", "Todos los Item")
        rc.SetCustomizedString("RowFilterDropDownBlanksItem", "Item Blancos")
        rc.SetCustomizedString("RowFilterDropDownCustomItem", "Personalizado")
        rc.SetCustomizedString("RowFilterDropDownEquals", "Igual a")
        rc.SetCustomizedString("RowFilterDropDownGreaterThan", "Mayor que")
        rc.SetCustomizedString("RowFilterDropDownGreaterThanOrEqualTo", "Mayor o Igual a")
        rc.SetCustomizedString("RowFilterDropDownLessThan", "Menor que")
        rc.SetCustomizedString("RowFilterDropDownLessThanOrEqualTo", "Menor o Igual a")
        rc.SetCustomizedString("RowFilterDropDownLike", "Como")
        rc.SetCustomizedString("RowFilterDropDownNotEquals", "No es igual")
        rc.SetCustomizedString("RowFilterLogicalOperator_And", "Y")
        rc.SetCustomizedString("RowFilterLogicalOperator_Or", "O")
        rc.SetCustomizedString("FilterClearButtonToolTip_RowSelector", "Clic aqui para limpiar el filtro a {0}")
        rc.SetCustomizedString("FilterClearButtonToolTip_FilterCell", "Clic aqui para limpiar el filtro a todos los criterios")
    End Sub

    Public Sub Muestra_Reportex(ByVal STRnombreReporte As String, _
     ByVal myDatos As DataTable, _
     ByVal STRfiltro As String, ByVal ParamArray Parametros() As String)
        Try
            Dim f As New CO_RE_Reporte
            Dim myReporte As New ReportDocument

            'Cargo el reporte segun ruta
            myReporte.Load(STRnombreReporte)

            'Leo los parametros
            If Parametros.Length > 0 Then
                f.CRVisor.ParameterFieldInfo = Genera_Parametros(Parametros)
            End If
            f.CRVisor.SelectionFormula = STRfiltro

            myReporte.SetDataSource(myDatos)
            f.Titulo = STRnombreReporte
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            f.CRVisor.ShowGroupTreeButton = True
            f.Show()

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub Carga_Servicio_Crystal(ByVal STRnombreReporte As String)
        Try
            Dim f As New CO_RE_Reporte
            Dim myReporte As New ReportDocument

            'Cargo el reporte segun ruta
            myReporte.Load(gStr_RutaRep & "\SG_CO_02.rpt")

            Dim dt As DataTable
            myReporte.SetDataSource(dt)
            f.Titulo = ""
            'Levanto el formulario del reporte
            f.CRVisor.ReportSource = myReporte
            f.CRVisor.ShowGroupTreeButton = True
            'f.Show()

        Catch ex As Exception
            ShowError(ex.Message)
        End Try

    End Sub

    Private Function Genera_Parametros(ByVal ParamArray MyMatriz() As String) As ParameterFields
        Dim c As Long, STRnombre As String, STRvalor As String, l As Integer
        Dim parametros As New ParameterFields

        Try
            For c = 0 To MyMatriz.Length - 1
                l = InStr(MyMatriz(c), ";")
                If l > 0 Then
                    STRnombre = Mid(MyMatriz(c), 1, l - 1)
                    STRvalor = Mid(MyMatriz(c), l + 1, Len(MyMatriz(c)) - l)
                    Dim parametro As New ParameterField
                    Dim dVal As New ParameterDiscreteValue
                    parametro.ParameterFieldName = STRnombre
                    dVal.Value = STRvalor
                    parametro.CurrentValues.Add(dVal)
                    parametros.Add(parametro)
                End If
            Next
            Return (parametros)
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Sub MostrarTabs(ByVal Tab_Mostrar As Integer, ByVal TAB As UltraWinTabControl.UltraTabControl, Optional ByVal Tab_Adicional As Integer = 0)
        Try
            Dim I As Integer
            For I = 0 To TAB.Tabs.Count - 1
                If I = Tab_Mostrar Then
                    TAB.Tabs(I).Enabled = True
                    TAB.Tabs(I).Selected = True
                ElseIf I = Tab_Adicional Then
                    TAB.Tabs(I).Enabled = True
                Else
                    TAB.Tabs(I).Enabled = False
                End If
            Next

            If Tab_Adicional <> 0 Then
                For I = 0 To TAB.Tabs.Count - 1
                    If I = Tab_Adicional Then
                        TAB.Tabs(I).Enabled = True
                    End If
                Next
            End If

        Catch
            Exit Sub
        End Try
    End Sub

    Public Sub ShowError(ByVal S_Aviso As String)
        Try

            MessageBox.Show(S_Aviso, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Avisar(ByVal S_Aviso As String)
        Try
            MessageBox.Show(S_Aviso, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
    End Sub

    Public Function Preguntar(ByVal Pregunta As String) As Boolean
        Preguntar = False
        Try
            If MessageBox.Show(Pregunta, "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Return True
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Sub Limpiar_Controls_InGroupox(ByVal ugb_Datos As Infragistics.Win.Misc.UltraGroupBox)
        Try
            Dim elcontrol As Control
            For Each elcontrol In ugb_Datos.Controls
                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraTextEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraTextEditor).Text = String.Empty
                End If
                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraComboEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraComboEditor).SelectedIndex = -1
                End If

                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraCheckEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraCheckEditor).Checked = False
                End If

                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraNumericEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraNumericEditor).Value = Nothing
                End If

                Try
                    If TypeOf elcontrol Is Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Then
                        CType(elcontrol, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Value = 0.0R
                    End If
                Catch ex As Exception
                    If TypeOf elcontrol Is Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Then
                        CType(elcontrol, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Value = Nothing
                    End If
                End Try

                If TypeOf elcontrol Is Infragistics.Win.Misc.UltraGroupBox Then
                    Limpiar_Controls_InGroupox(elcontrol)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Limpiar_Controls_InGroupox_Nativo(ByVal ugb_Datos As GroupBox)
        Try
            Dim elcontrol As Control
            For Each elcontrol In ugb_Datos.Controls
                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraTextEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraTextEditor).Text = String.Empty
                End If
                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraComboEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraComboEditor).SelectedIndex = -1
                End If

                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraCheckEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraCheckEditor).Checked = False
                End If

                If TypeOf elcontrol Is Infragistics.Win.UltraWinEditors.UltraNumericEditor Then
                    CType(elcontrol, Infragistics.Win.UltraWinEditors.UltraNumericEditor).Value = Nothing
                End If

                Try
                    If TypeOf elcontrol Is Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Then
                        CType(elcontrol, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Value = 0.0R
                    End If
                Catch ex As Exception
                    If TypeOf elcontrol Is Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit Then
                        CType(elcontrol, Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit).Value = Nothing
                    End If
                End Try

                If TypeOf elcontrol Is GroupBox Then
                    Limpiar_Controls_InGroupox_Nativo(elcontrol)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LimpiaGrid(ByVal Grid As UltraGrid, ByVal DataSource As UltraDataSource)
        DataSource.Rows.Clear()
        Grid.DataSource = DataSource
    End Sub

    Public Sub CrearComboGrid(ByVal IdNombreColumna_Grilla As String, _
                          ByVal Campo_Tabla_Tmp As String, _
                          ByVal UltGrid As UltraWinGrid.UltraGrid, _
                          ByVal dtDatos As DataTable, _
                          ByVal boDropDownList As Boolean)
        Try
            'Si el Grid ya sido creado o igualada un Datatable 
            With UltGrid.DisplayLayout
                If .Bands(0).Columns.Exists(IdNombreColumna_Grilla) Then
                    .ValueLists.Clear()
                    .ValueLists.Add(IdNombreColumna_Grilla)
                Else
                    'Si el Grid recien se esta creando se Agregan Keys (Identificadores de Columna)
                    .Bands(0).Columns.Add().Key = IdNombreColumna_Grilla
                    .ValueLists.Clear()
                    .ValueLists.Add(IdNombreColumna_Grilla)
                End If
                With .ValueLists(IdNombreColumna_Grilla).ValueListItems
                    .Clear()
                    For I As Integer = 0 To dtDatos.Rows.Count - 1
                        .Add(dtDatos.Rows(I)(0), dtDatos.Rows(I)(Campo_Tabla_Tmp))
                    Next
                End With
                If boDropDownList = True Then
                    .Bands(0).Columns(IdNombreColumna_Grilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
                Else
                    .Bands(0).Columns(IdNombreColumna_Grilla).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
                End If
                .Bands(0).Columns(IdNombreColumna_Grilla).ValueList = .ValueLists(IdNombreColumna_Grilla)
            End With
        Catch
            Exit Sub
        End Try
    End Sub

    Public Function Image2Bytes(ByVal img As Image) As Byte()
        Dim sTemp As String = Path.GetTempFileName()
        Dim fs As New FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        img.Save(fs, System.Drawing.Imaging.ImageFormat.Png)
        fs.Position = 0

        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()
        Return bytes
    End Function

    Public Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then Return Nothing
        '
        Dim ms As New MemoryStream(bytes)
        Dim bm As Bitmap = Nothing
        Try
            bm = New Bitmap(ms)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
        Return bm
    End Function

    Public Function ObtenerPrimerDia(ByVal Fecha As Date) As String
        ObtenerPrimerDia = String.Empty
        Return DateSerial(Year(Fecha), Month(Fecha) + 0, 1)
    End Function

    Public Function ObtenerUltimoDia(ByVal Fecha As Date) As String
        ObtenerUltimoDia = String.Empty
        Return DateSerial(Year(Fecha), Month(Fecha) + 1, 0)
    End Function

    Public Sub Cargar_Estilo_Infra(ByVal resourceName As String)
        Dim stream As System.IO.Stream
        Try
            If resourceName = "Predeterminado" Then Exit Sub
            Dim Ruta As String
            Ruta = My.Application.Info.DirectoryPath
            stream = New System.IO.FileStream(String.Format("{0}\StyleLibraries\{1}", Ruta, resourceName), IO.FileMode.Open)
            If (Not stream Is Nothing) Then
                Infragistics.Win.AppStyling.StyleManager.Load(stream)
            End If
            stream.Close()
            stream.Dispose()
        Catch ex As Exception
            'stream.Close()
            'stream.Dispose()
        End Try
    End Sub

    Public Sub Guardar_Estilo_Infra_RegEdit(ByVal Str_Nom_Estilo_Infra As String)
        Try
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Helios", "Infra", Str_Nom_Estilo_Infra)
        Catch ex As Exception
            Throw New Exception("Error al guardar el estilo en regedir. - " & ex.Message)
        End Try
    End Sub

    Public Sub Guardar_Estilo_en_PerfilTabla(ByVal Str_Nom_Estilo_Infra As String)
        Try
            Dim Entidad As New BE.ContabilidadBE.SG_CO_TB_IMG_SIS
            Dim obj_ImgSisBL As New BL.ContabilidadBL.SG_CO_TB_IMG_SIS
            Dim Obj_UsuarioBL As New BL.ContabilidadBL.SG_CO_TB_USUARIO
            Dim Int_IdUsu As Integer = Obj_UsuarioBL.getIdUsu_x_NomUsu(gStr_Usuario_Sis)

            Entidad.IS_ESTILO_SKIN = Str_Nom_Estilo_Infra
            Entidad.IS_USUARIO = Int_IdUsu

            If obj_ImgSisBL.Existe_usuario(Int_IdUsu) Then
                obj_ImgSisBL.Update(Entidad)
            Else
                obj_ImgSisBL.Insert(Entidad)
            End If

            Obj_UsuarioBL = Nothing
            obj_ImgSisBL = Nothing
            Entidad = Nothing

        Catch ex As Exception
            ShowError(ex.Message)
        End Try
    End Sub

    Public Sub Cambiar_Estado_Botones_Tool(ByVal tool_ As ToolStrip)

        tool_.Items("Tool_Nuevo").Enabled = Not tool_.Items("Tool_Nuevo").Enabled
        tool_.Items("Tool_Grabar").Enabled = Not tool_.Items("Tool_Grabar").Enabled
        tool_.Items("Tool_Cancelar").Enabled = Not tool_.Items("Tool_Cancelar").Enabled
        tool_.Items("Tool_Editar").Enabled = Not tool_.Items("Tool_Editar").Enabled
        tool_.Items("Tool_Salir").Enabled = Not tool_.Items("Tool_Salir").Enabled
        tool_.Items("Tool_Eliminar").Enabled = Not tool_.Items("Tool_Eliminar").Enabled

    End Sub

    Public Sub Inicializar_Estado_Botones_Tool(ByVal tool_ As ToolStrip)

        tool_.Items("Tool_Nuevo").Enabled = True
        tool_.Items("Tool_Grabar").Enabled = False
        tool_.Items("Tool_Cancelar").Enabled = False
        'tool_.Items("Tool_Editar").Enabled = True
        tool_.Items("Tool_Salir").Enabled = True
        'tool_.Items("Tool_Eliminar").Enabled = True

    End Sub

    Public Function Obtener_Tipo_de_Anexo(ByVal Subdiario As String) As Integer
        Obtener_Tipo_de_Anexo = 0
        Try

            Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
            Dim E_SubDiario As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
            E_SubDiario.SD_ID = Subdiario
            E_SubDiario.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Return Obj_TipoAnexoBL.getTipoAnexo_x_SubDiario(E_SubDiario)

        Catch ex As Exception

        End Try
    End Function

    Public Function Obtener_Tipo_de_Anexo_Hono(ByVal Subdiario As String) As Integer
        Obtener_Tipo_de_Anexo_Hono = 0
        Try

            Dim Obj_TipoAnexoBL As New BL.ContabilidadBL.SG_CO_TB_TIPOANEXO
            Dim E_SubDiario As New BE.ContabilidadBE.SG_CO_TB_SUBDIARIO
            E_SubDiario.SD_ID = Subdiario
            E_SubDiario.SD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            Return Obj_TipoAnexoBL.getTipoAnexo_x_SubDiario_Hono(E_SubDiario)

        Catch ex As Exception

        End Try
    End Function

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Public Sub Ver_Impresion_Voucher(ByVal fecha As String, ByVal libro As String, ByVal subdiario As String, ByVal numVoucher As String, ByVal glosa As String, ByVal IdCabecera As Integer)
        Try
            Dim Obj_AsientoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
            Dim CabeceraBE As New BE.ContabilidadBE.SG_CO_TB_ASIENTO_CAB
            Dim Dt_Asiento As DataTable
            Dim EmpresaBE As New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}

            CabeceraBE.AC_IDEMPRESA = EmpresaBE
            CabeceraBE.AC_FEC_VOUCHER = fecha
            CabeceraBE.AC_ID = IdCabecera
            Dt_Asiento = Obj_AsientoBL.getVoucher_Impresion1(CabeceraBE)

            Dim EmpresaBL As New BL.ContabilidadBL.SG_CO_TB_EMPRESA
            EmpresaBL.getEmpresas_2(EmpresaBE)

            Dim ObjReporte As New LR.ClsReporte
            ObjReporte.Muestra_Reporte(gStr_RutaRep & "\SG_CO_01.rpt", Dt_Asiento, "", "", _
                                 String.Format("pFecha;{0}", fecha), String.Format("pLibro;{0}", libro), _
                                 String.Format("pSubdiario;{0}", subdiario), String.Format("pNumVoucher;{0}", numVoucher), _
                                 String.Format("pEmpresa;{0}", EmpresaBE.EM_NOMBRE), String.Format("pGlosa;{0}", glosa))
            Dt_Asiento.Dispose()
            ObjReporte.Dispose()
            EmpresaBE = Nothing
            Obj_AsientoBL = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Ultragrid_to_DataTable(ByVal Ug_data As Infragistics.Win.UltraWinGrid.UltraGrid) As DataTable
        Ultragrid_to_DataTable = Nothing
        Try
            Dim Dt As New DataTable
            Dim iCols As Int16 = Ug_data.DisplayLayout.Bands(0).Columns.Count
            Dim iRows As Int16 = Ug_data.Rows.Count

            For i As Integer = 0 To iCols - 1
                Dt.Columns.Add(New DataColumn(Ug_data.DisplayLayout.Bands(0).Columns(i).Header.Caption))
            Next

            Dim fila As DataRow
            Dim Nom_col As String = String.Empty

            For f As Int64 = 0 To iRows - 1
                fila = Dt.NewRow
                For c As Int16 = 0 To iCols - 1
                    fila(c) = Ug_data.Rows(f).Cells(c).Value.ToString
                Next
                Dt.Rows.Add(fila)
            Next


            Return Dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub mBuscar_Documento(ByVal td As String, ByVal sd As String, ByVal nd As String, ByVal empresa As Integer, ByVal anexo As Integer, ByVal cuenta As String, ByVal ayo As Integer)
        Dim mensaje As String = String.Empty
        Dim DocumentoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim Dt_documento As DataTable = DocumentoBL.getBuscar_Doc(td, sd, nd, empresa, anexo, cuenta, ayo)

        If Dt_documento.Rows.Count > 0 Then
            mensaje = "El comprobante  ya se encuentra registrado en el mes  " & Dt_documento.Rows(0)("AC_MES")
            mensaje += Chr(13) & " con el numero de voucher :" & Dt_documento.Rows(0)("AC_NUM_VOUCHER")
            Call Avisar(mensaje)
        End If

        Dt_documento = Nothing
        DocumentoBL = Nothing
    End Sub

    Public Sub mBuscar_Documento_Venta(ByVal td As String, ByVal sd As String, ByVal nd As String, ByVal empresa As Integer, ByVal anexo As Integer, ByVal cuenta As String, ByVal ayo As Integer)
        Dim mensaje As String = String.Empty
        Dim DocumentoBL As New BL.ContabilidadBL.SG_CO_TB_ASIENTO_CONTABLE
        Dim Dt_documento As DataTable = DocumentoBL.getBuscar_Doc(td, sd, nd, empresa, 0, cuenta, ayo)

        If Dt_documento.Rows.Count > 0 Then
            mensaje = "El comprobante  ya se encuentra registrado en el mes  " & Dt_documento.Rows(0)("AC_MES")
            mensaje += Chr(13) & " con el numero de voucher :" & Dt_documento.Rows(0)("AC_NUM_VOUCHER")
            Call Avisar(mensaje)
        End If

        Dt_documento = Nothing
        DocumentoBL = Nothing
    End Sub

End Module
