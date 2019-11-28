Public Class TE_PR_Lista_Auxi

    Public Dt_Data As DataTable
    Public Bol_Aceptar As Boolean = False
    Public mylista As New List(Of BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV_LISTAS)
    Private Sub TE_PR_Lista_Auxi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call LimpiaGrid(ug_Lista, uds_lista)

        For i As Integer = 0 To Dt_Data.Rows.Count - 1
            ug_Lista.DisplayLayout.Bands(0).AddNew()
            ug_Lista.Rows(i).Cells("Sel").Value = True
            ug_Lista.Rows(i).Cells("Item").Value = Dt_Data.Rows(i)("CL_ITEM")
            ug_Lista.Rows(i).Cells("Cuenta").Value = Dt_Data.Rows(i)("CL_CUENTA")
        Next

        ug_Lista.UpdateData()

        If ug_Lista.Rows.Count > 0 Then
            ug_Lista.Rows(0).Activate()
        End If


    End Sub

    Private Sub ubtn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_cancelar.Click
        Bol_Aceptar = False
        Me.Close()
    End Sub

    Private Sub ubtn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_aceptar.Click
        mylista.Clear()
        For i As Integer = 0 To ug_Lista.Rows.Count - 1
            If ug_Lista.Rows(i).Cells("Sel").Value Then
                mylista.Add(New BE.TesoreriaBE.SG_TE_TB_CONCEPTOS_MOV_LISTAS(0, ug_Lista.Rows(i).Cells("Item").Value, ug_Lista.Rows(i).Cells("Cuenta").Value))
            End If
        Next

        Bol_Aceptar = True
        Me.Close()
    End Sub
End Class