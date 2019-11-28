Module ModBasFactu


    Public Sub Completar_Lineas(nombre_doc_lineas_ As String, ByRef dt_data As DataTable, bol_es_Nc_ As Boolean, texto_nc_ As String)

        'Obtenemos el numero de lineas del detalle para la impresion
        Dim lineas As Integer = 10
        Dim paraetrosBL As New BL.FacturacionBL.SG_FA_TB_PARAMETROS
        Dim paraetrosBE As New BE.FacturacionBE.SG_FA_TB_PARAMETROS

        paraetrosBE.AD_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        paraetrosBE.AD_TIPO = "REPO"
        paraetrosBE.AD_NOMBRE = nombre_doc_lineas_

        lineas = paraetrosBL.get_Valor(paraetrosBE)

        paraetrosBE = Nothing
        paraetrosBL = Nothing


        If bol_es_Nc_ Then
            If dt_data.Rows.Count > 0 Then
                dt_data.Rows(0)("AR_DESCRIPCION") = texto_nc_
            End If
        End If

        Dim total As Double = 0
        Dim bol_texto_detra As Boolean = False
        total = IIf(dt_data.Rows(0)("CO_IDMONEDA") = "01", dt_data.Rows(0)("CO_TOTAL"), dt_data.Rows(0)("CO_TOTAL") * dt_data.Rows(0)("CO_TCAM"))
        If total > 700 Then bol_texto_detra = True


        Dim bol_es_inafecto_igv As Boolean = False
        For x As Integer = 0 To dt_data.Rows.Count - 1
            If dt_data.Rows(x)("AR_ES_NO_AFEC_IGV") = 1 Then
                bol_es_inafecto_igv = True
                Exit For
            End If
        Next


        Dim fila As DataRow

        For i As Integer = 0 To (5 - dt_data.Rows.Count) - 1
            fila = dt_data.NewRow
            fila("CO_TDOC") = ""
            fila("CO_SDOC") = ""
            fila("CO_NDOC") = ""
            fila("CO_FEC_EMI") = DBNull.Value
            fila("CO_FEC_VEN") = DBNull.Value
            fila("CO_SUBTOTAL") = DBNull.Value
            fila("CO_IGV") = DBNull.Value
            fila("CO_TOTAL") = DBNull.Value
            fila("CO_IDMONEDA") = DBNull.Value
            fila("CO_TCAM") = DBNull.Value
            fila("CO_TDOC_REF") = DBNull.Value
            fila("CO_SDOC_REF") = ""
            fila("CO_NDOC_REF") = ""
            fila("CO_FEC_EMI_REF") = DBNull.Value
            fila("CO_FEC_VEN_REF") = DBNull.Value
            fila("CO_IDCLIENTE") = 0
            fila("CL_NOMBRE") = ""
            fila("CL_NDOC") = ""
            fila("CO_NOTAS") = DBNull.Value
            fila("CO_IDFORMA_PAGO") = ""
            fila("FP_DESCRIPCION") = ""
            fila("CD_ITEM") = dt_data.Rows.Count + 1
            fila("CD_IDARTICULO") = DBNull.Value
            fila("AR_DESCRIPCION") = ""
            fila("CD_CANT") = DBNull.Value
            fila("CD_PRECIO") = DBNull.Value
            fila("CD_DSCTO") = DBNull.Value
            fila("CD_SUBTOTAL") = DBNull.Value
            fila("CD_IGV") = DBNull.Value
            fila("CD_TOTAL") = DBNull.Value
            fila("EM_RUC") = ""
            dt_data.Rows.Add(fila)
        Next




        For i As Integer = 0 To (lineas - dt_data.Rows.Count)
            fila = dt_data.NewRow

            fila("CO_TDOC") = ""
            fila("CO_SDOC") = ""
            fila("CO_NDOC") = ""
            fila("CO_FEC_EMI") = dt_data(0)("CO_FEC_EMI")
            fila("CO_FEC_VEN") = dt_data(0)("CO_FEC_VEN")
            fila("CO_SUBTOTAL") = dt_data(0)("CO_SUBTOTAL")
            fila("CO_IGV") = dt_data(0)("CO_IGV")
            fila("CO_TOTAL") = dt_data(0)("CO_TOTAL")
            fila("CO_IDMONEDA") = DBNull.Value
            fila("CO_TCAM") = DBNull.Value
            fila("CO_TDOC_REF") = DBNull.Value
            fila("CO_SDOC_REF") = ""
            fila("CO_NDOC_REF") = ""
            fila("CO_FEC_EMI_REF") = DBNull.Value
            fila("CO_FEC_VEN_REF") = DBNull.Value
            fila("CO_IDCLIENTE") = 0
            fila("CL_NOMBRE") = ""
            fila("CL_NDOC") = ""
            fila("CO_NOTAS") = dt_data(0)("CO_NOTAS")
            fila("CO_IDFORMA_PAGO") = ""
            fila("FP_DESCRIPCION") = ""
            fila("CD_ITEM") = dt_data.Rows.Count + 1
            fila("CD_IDARTICULO") = DBNull.Value

            If bol_es_inafecto_igv Then
                Select Case i
                    Case 1
                        fila("AR_DESCRIPCION") = "Exonerado del IGV D.Lrg.021 TUO aprobado por D.S. 055-99-EF Art.33"
                    Case 2
                        fila("AR_DESCRIPCION") = "Apendice V.D.S.#029-94-EF Modificado por el D.S.#136-96-EF Art.9"
                End Select
            Else
                If bol_texto_detra And bol_es_inafecto_igv = False Then
                    Select Case i
                        Case 1
                            fila("AR_DESCRIPCION") = "Operacion Sujeta al Sistema de Pago de Obligaciones"
                        Case 2
                            fila("AR_DESCRIPCION") = "Tributarias con El Gobierno Central 10%"
                        Case 3
                            fila("AR_DESCRIPCION") = "cta cte N°0000-488860 Banco de la Nacion"
                        Case 4
                            fila("AR_DESCRIPCION") = "Tipo Operacion: 01 ; Bien ó Servicio: 022"
                    End Select

                Else
                    fila("AR_DESCRIPCION") = ""
                End If

            End If


            fila("CD_CANT") = DBNull.Value
            fila("CD_PRECIO") = DBNull.Value
            fila("CD_DSCTO") = DBNull.Value
            fila("CD_SUBTOTAL") = DBNull.Value
            fila("CD_IGV") = DBNull.Value
            fila("CD_TOTAL") = DBNull.Value
            fila("EM_RUC") = ""

            dt_data.Rows.Add(fila)

        Next


    End Sub

End Module
