Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop

Public Class ClsFunciones

    Public Sub exportar_A_OO_Calc(ByVal dt_datos As DataTable, ByVal Str_Titulo As String)
        Try


            Dim ServiceManager As Object
            Dim Desktop As Object
            Dim Document As Object
            Dim Feuille As Object


            Dim PrintArea(0)
            Dim PrintArgs(2)

            ' Creacion de un service OpenOffice
            ServiceManager = CreateObject("com.sun.star.ServiceManager")
            Desktop = ServiceManager.createInstance("com.sun.star.frame.Desktop")

            Dim args(-1) As Object
            'args = ServiceManager.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
            'args(0).Name = "Dummy!"
            'args(0).Value = 0

            Document = Desktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, args)
            Feuille = Document.getSheets().getByIndex(0)

            Const ROW_FIRST = 4
            Dim iRow As Int64 = 1
            Dim iCols As Int16 = dt_datos.Columns.Count

            Call Feuille.getcellbyposition(1, 1).setFormula(Str_Titulo)
            'oSheet.Cells(1, 1).font.bold = True


            'Llenamos la cabecera
            For i As Integer = 1 To iCols - 1
                Call Feuille.getcellbyposition(i, ROW_FIRST).setFormula(dt_datos.Columns(i).Caption)
            Next

            'Llenamos las filas
            For j As Integer = 0 To dt_datos.Rows.Count - 1
                Dim iCurrRow As Int64 = ROW_FIRST + iRow

                For iCol As Integer = 1 To iCols - 1
                    Call Feuille.getcellbyposition(iCol, iCurrRow).setFormula(dt_datos.Rows(j)(iCol))
                Next

                iRow += 1
            Next

            Call Document.getCurrentController.getFrame.getContainerWindow.setVisible(True)
            Call Document.getCurrentController.getFrame.getComponentWindow.setVisible(True)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub exportar_A_MS_Excel(ByVal dt_datos As DataTable, ByVal Str_Titulo As String)
        Dim oExcel As Excel.ApplicationClass
        Dim oBooks As Excel.Workbooks
        Dim oBook As Excel.WorkbookClass
        Dim oSheet As Excel.Worksheet

        ' Inicia Excel y abre el workbook
        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBooks = oExcel.Workbooks
        oBook = oExcel.Workbooks.Add
        oSheet = oBook.Sheets(1)

        'oBook = oBooks.Open( _
        '    "C:\DevCare\DevCareExcelAutomation\Data.xls")

        Const ROW_FIRST = 4
        Dim iRow As Int64 = 1
        Dim iCols As Int16 = dt_datos.Columns.Count


        oSheet.Cells(1, 1) = Str_Titulo
        oSheet.Cells(1, 1).font.bold = True

        'Llenamos la cabecera
        For i As Integer = 1 To iCols - 1
            oSheet.Cells(ROW_FIRST, i) = dt_datos.Columns(i).Caption
            oSheet.Cells(ROW_FIRST, i).font.bold = True
            oSheet.Columns(i).ColumnWidth = 15
        Next

        ' Encabezado
        'oSheet.Cells(ROW_FIRST, 1) = "ID"
        'oSheet.Cells(ROW_FIRST, 2) = "Compañía"
        'oSheet.Cells(ROW_FIRST, 3) = "Contacto"
        'oSheet.Cells(ROW_FIRST, 4) = "País"

        'oSheet.Cells(ROW_FIRST, 1).font.bold = True
        'oSheet.Cells(ROW_FIRST, 2).font.bold = True
        'oSheet.Cells(ROW_FIRST, 3).font.bold = True
        'oSheet.Cells(ROW_FIRST, 4).font.bold = True

        'oSheet.Columns(1).ColumnWidth = 10
        'oSheet.Columns(2).ColumnWidth = 40
        'oSheet.Columns(3).ColumnWidth = 30
        'oSheet.Columns(4).ColumnWidth = 15

        ' Loop que almacena los datos

        For j As Integer = 0 To dt_datos.Rows.Count - 1
            Dim iCurrRow As Int64 = ROW_FIRST + iRow

            For iCol As Integer = 1 To iCols - 1
                oSheet.Cells(iCurrRow, iCol) = dt_datos.Rows(j)(iCol)
            Next

            iRow += 1
        Next

        'Dim rowCustomer As dsCustomers.CustomersRow
        'For Each rowCustomer In Me.DsCustomers.Customers
        '    Dim iCurrRow As Int64 = ROW_FIRST + iRow
        '    oSheet.Cells(iCurrRow, 1) = rowCustomer.CustomerID
        '    oSheet.Cells(iCurrRow, 2) = rowCustomer.CompanyName
        '    oSheet.Cells(iCurrRow, 3) = rowCustomer.ContactName
        '    oSheet.Cells(iCurrRow, 4) = rowCustomer.Country

        '    iRow += 1
        'Next

        ' Fórmula
        'oSheet.Cells(ROW_FIRST + iRow + 1, 1) = "=counta(R" & (ROW_FIRST + 1) & "C1:R" & (ROW_FIRST + iRow - 1).ToString & "C1)"



        '' Cierra todo
        'oBook.Close(True)
        'System.Runtime.InteropServices.Marshal. _
        '    ReleaseComObject(oBook)
        'oBook = Nothing

        'System.Runtime.InteropServices.Marshal. _
        '    ReleaseComObject(oBooks)
        'oBooks = Nothing

        'oExcel.Quit()
        'System.Runtime.InteropServices.Marshal. _
        '    ReleaseComObject(oExcel)
        'oExcel = Nothing
    End Sub

    Public Function ReadBinaryFile(ByVal fileName As String) As Byte()
        'http://www.mvp-access.es/softjaen/bases/adonet/sjadonet13.htm
        ' Si no existe el archivo, abandono la función.
        '
        If Not System.IO.File.Exists(fileName) Then Return Nothing

        Try
            ' Creamos un objeto Stream para poder leer el archivo especificado.
            '
            Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)

            ' Creamos un array de bytes, cuyo límite superior se corresponderá
            ' con la longitud en bytes de la secuencia.
            '
            Dim data() As Byte = New Byte(Convert.ToInt32(fs.Length)) {}

            ' Al leer la secuencia, se rellenará la matriz.
            '
            fs.Read(data, 0, Convert.ToInt32(fs.Length))

            ' Cerramos la secuencia.
            '
            fs.Close()

            ' Devolvemos el array de bytes.
            '
            Return data

        Catch ex As Exception
            ' Cualquier excepción producida, hace que la
            ' función devuelva el valor Nothing.
            '
            Return Nothing

        End Try

    End Function

    Public Sub WriteBinaryFile(ByVal aByte() As Byte, _
                            ByVal fileName As String)
        'http://www.mvp-access.es/softjaen/bases/adonet/sjadonet14.htm
        ' El procedimiento creará un archivo con la secuencia de bytes
        ' especificada en el argumento.

        ' Compruebo los distintos parámetros pasados a la función.
        '
        If (aByte Is Nothing) OrElse (fileName = "") Then Return

        Try

            ' Compruebo si existe el archivo especificado.
            If System.IO.File.Exists(fileName) Then
                ' Elimino el archivo
                System.IO.File.Delete(fileName)
            End If

            ' Número de bytes que se van a escribir
            Dim data As Int64 = aByte.Length

            ' Obtengo el nombre de un archivo temporal, donde
            ' primeramente se guardará el documento.
            '
            Dim tempFileName As String = System.IO.Path.GetTempFileName

            ' Abrimos o creamos el archivo.
            Dim fs As New FileStream(tempFileName, FileMode.OpenOrCreate)

            ' Crea el escritor para los datos.
            Dim bw As New BinaryWriter(fs)

            ' Escribimos en el archivo los datos realmente leídos.
            bw.Write(aByte, 0, Convert.ToInt32(data))

            ' Borra todos los búferes del sistema de escritura actual y hace
            ' que todos los datos almacenados en el búfer se escriban en el
            ' dispositivo subyacente. 
            bw.Flush()

            ' Cerramos los distintos objetos.
            bw.Close()
            fs.Close()
            bw = Nothing
            fs = Nothing

            ' Muevo el archivo a la ruta indicada.
            System.IO.File.Move(tempFileName, fileName)

        Catch ex As Exception
            
        End Try

    End Sub
End Class
