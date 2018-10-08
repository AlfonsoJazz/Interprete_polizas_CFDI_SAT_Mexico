Imports System.Xml
Imports System.Data


''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class Form1

    Private frmDetalleNomina As frmDetallePolizaNomina


    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenXML()
    End Sub

    ''' <summary>
    ''' Simple XML reader
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenXML()

        Dim oXmlTextReader As XmlTextReader 'need to Imports System.Xml
        Dim oFileInfo As IO.FileInfo = Nothing
        Dim curHaber As Decimal
        Dim curDebe As Decimal
        Dim intPos As Integer

        Try
            'get a XML file
            Using oOpenFileDialog As New OpenFileDialog
                oOpenFileDialog.Filter = "xml file|*.xml|All files|*.*"
                oOpenFileDialog.Multiselect = False
                If oOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If IO.File.Exists(oOpenFileDialog.FileName) Then
                        oFileInfo = New IO.FileInfo(oOpenFileDialog.FileName)
                        'sPath = oOpenFileDialog.FileName

                    End If
                End If

            End Using


            'read the XML file
            If oFileInfo IsNot Nothing Then
                If IO.File.Exists(oFileInfo.FullName) Then
                    oXmlTextReader = New XmlTextReader(oFileInfo.FullName)
                    While oXmlTextReader.Read
                        Select Case oXmlTextReader.NodeType
                            Case XmlNodeType.Element
                                If oXmlTextReader.Name = "PLZ:Transaccion" Then
                                    'MsgBox(oXmlTextReader.Name & "ELEMENTO")
                                    If oXmlTextReader.HasAttributes = True Then
                                        oXmlTextReader.MoveToFirstAttribute()
                                        For intPos = 1 To oXmlTextReader.AttributeCount
                                            If oXmlTextReader.Name = "Haber" Then
                                                curHaber = curHaber + oXmlTextReader.Value

                                            ElseIf oXmlTextReader.Name = "Debe" Then
                                                curDebe = curDebe + oXmlTextReader.Value
                                            End If

                                            'MsgBox(oXmlTextReader.Name & ": " & oXmlTextReader.Value)

                                            oXmlTextReader.MoveToNextAttribute()
                                        Next
                                        'MsgBox(oXmlTextReader.Name & "ELEMENTO")
                                    End If
                                End If
                                'Case XmlNodeType.Attribute
                                '    'MsgBox(oXmlTextReader.Name & "Atributo")
                                '    If oXmlTextReader.Name = "Haber" Then
                                '        curHaber = curHaber + oXmlTextReader.Value
                                '        'MsgBox(oXmlTextReader.Name & "ELEMENTO")
                                '    ElseIf oXmlTextReader.Name = "Debe" Then
                                '        curDebe = curDebe + oXmlTextReader.Value
                                '    End If

                                'Case XmlNodeType.Text
                                '    MsgBox(oXmlTextReader.Value & "TEXTO")
                                'Case XmlNodeType.EndElement
                                '    MsgBox(oXmlTextReader.Name & "FIN TEXTO")
                        End Select
                    End While
                End If
            End If
            txtDebito.Text = Format(curDebe, "###,###,###.#0")
            txtCredito.Text = Format(curHaber, "###,###,###.#0")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        End

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim ds As DataSet
        Dim ren As Integer
        Dim dcDebe As Decimal
        Dim dcHaber As Decimal

        dcDebe = 0
        dcHaber = 0
        Try
            CargaXmlToDs()
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            DataGridView4.Visible = False

            txtPolizas.Text = ds.Tables(1).Rows.Count
            txtEmpresa.Text = ds.Tables(0).Rows(0).ItemArray(1)
            For ren = 0 To ds.Tables(2).Rows.Count - 1
                dcDebe = dcDebe + ds.Tables(2).Rows(ren).ItemArray(3)
                dcHaber = dcHaber + ds.Tables(2).Rows(ren).ItemArray(4)
            Next
            txtDebito.Text = Format(dcDebe, "###,###,###,###.#0")
            txtCredito.Text = Format(dcHaber, "###,###,###,###.#0")
            DataGridView3.DataSource = ds
            'Transacciones
            DataGridView3.DataMember = ds.Tables(2).ToString

            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub LimpiaGid()
        Try
            Dim n As Integer ' variables para el for
            Dim fila As DataGridViewRow ' representa una fila del datagridview
            ' ciclo para limpiar el datagrid de cualquier dato y evitar que se repitan
            If DataGridView1.Rows.Count > 0 Then
                For n = DataGridView1.Rows.Count - 2 To 0 Step -1
                    fila = DataGridView1.Rows(n)
                    DataGridView1.Rows.Remove(fila) ' Eliminamos la fila de la colección
                Next
            End If

            DataGridView1.Rows.Add("NUM POLIZA", "CONCEPTO", "FECHA", "DEBE", "HABER", "SALDO")
            'DataGridView1.Rows(0).Cells(1).Value = "NUM POLIZA"
            'DataGridView1.Rows(0).Cells(2).Value = "CONCEPTO"
            'DataGridView1.Rows(0).Cells(3).Value = "FECHA"
            'DataGridView1.Rows(0).Cells(4).Value = "DEBE"
            'DataGridView1.Rows(0).Cells(5).Value = "HABER"
            'DataGridView1.Rows(0).Cells(6).Value = "SALDO"

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'TOTAL POR POLIZA

        Dim ren, Fila, Fila2 As Integer
        Dim id_Poliza As Integer
        Dim numPoliza As String
        Dim strFecha As String
        Dim strConcepto As String
        Dim dcDebe As Decimal
        Dim dcHaber As Decimal
        Dim cdSaldo As Decimal

        Try
            Fila2 = -1
            DataGridView1.Visible = True
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            DataGridView4.Visible = False

            DataGridView1.RowCount = ds.Tables(1).Rows.Count + 1
            For ren = 0 To ds.Tables(1).Rows.Count - 1
                id_Poliza = ds.Tables(1).Rows(ren).ItemArray(3)
                numPoliza = ds.Tables(1).Rows(ren).ItemArray(0)
                strFecha = ds.Tables(1).Rows(ren).ItemArray(1)
                strConcepto = ds.Tables(1).Rows(ren).ItemArray(2)
                For Fila = 0 To ds.Tables(2).Rows.Count - 1
                    If ds.Tables(2).Rows(Fila).ItemArray(6) = id_Poliza Then
                        dcDebe = dcDebe + ds.Tables(2).Rows(Fila).ItemArray(3)
                        dcHaber = dcHaber + ds.Tables(2).Rows(Fila).ItemArray(4)
                    End If
                Next
                cdSaldo = dcDebe - dcHaber
                DataGridView1.Rows(Fila2 + 1).Cells(0).Value = numPoliza
                DataGridView1.Rows(Fila2 + 1).Cells(1).Value = strConcepto
                DataGridView1.Rows(Fila2 + 1).Cells(2).Value = strFecha
                DataGridView1.Rows(Fila2 + 1).Cells(3).Value = dcDebe
                DataGridView1.Rows(Fila2 + 1).Cells(4).Value = dcHaber
                DataGridView1.Rows(Fila2 + 1).Cells(5).Value = cdSaldo
                If cdSaldo <> 0 Then
                    DataGridView1.Rows(Fila2 + 1).Cells(6).Value = "Póliza Descuadrada"
                Else
                    DataGridView1.Rows(Fila2 + 1).Cells(6).Value = "Póliza Cuadrada"
                End If
                Fila2 = Fila2 + 1
                dcDebe = 0
                dcHaber = 0
            Next

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'TOTAL POR CUENTA CONTABLE
        Try
            Dim ren, Fila, pos, renglon As Integer
            Dim dcDebe As Decimal
            Dim dcHaber As Decimal
            Dim numCta, DesCta, Concepto As String
            Dim array() As String
            Dim bandera As Boolean

            ReDim array(0)
            DataGridView1.Visible = False
            DataGridView2.Visible = True
            DataGridView3.Visible = False
            DataGridView4.Visible = False
            'LimpiaGridView()
            DataGridView2.RowCount = ds.Tables(2).Rows.Count + 1
            renglon = 0
            For Fila = 0 To ds.Tables(2).Rows.Count - 1
                dcDebe = 0
                dcHaber = 0
                numCta = ds.Tables(2).Rows(Fila).ItemArray(0)
                bandera = False
                For pos = 0 To UBound(array)
                    If numCta = array(pos) Then
                        bandera = True
                        Exit For
                    End If
                Next

                If bandera = False Then
                    array(UBound(array)) = numCta
                    ReDim Preserve array(UBound(array) + 1)
                    DesCta = ds.Tables(2).Rows(Fila).ItemArray(1)
                    For ren = 0 To ds.Tables(2).Rows.Count - 1
                        If numCta = ds.Tables(2).Rows(ren).ItemArray(0) Then
                            dcDebe = dcDebe + ds.Tables(2).Rows(ren).ItemArray(3)
                            dcHaber = dcHaber + ds.Tables(2).Rows(ren).ItemArray(4)
                        End If
                    Next
                    DataGridView2.Rows(renglon).Cells(0).Value = numCta
                    DataGridView2.Rows(renglon).Cells(1).Value = DesCta
                    DataGridView2.Rows(renglon).Cells(3).Value = dcDebe
                    DataGridView2.Rows(renglon).Cells(4).Value = dcHaber
                    renglon = renglon + 1
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(Err.Description)
            'MessageBox.Show("No se pudo completar la operación, Revise la estructura del XML.", "Fallo en carga del XML", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button10.Enabled = False


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'CHEQUE
        Try
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            DataGridView4.Visible = False

            'LimpiaGridView()
            'ASIGNA EL DATASET
            'DataGridView3.DataSource = ds
            'Cheques
            DataGridView3.DataMember = ds.Tables(6).ToString

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'TRNASFERENCIAS
        Try
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            DataGridView4.Visible = False

            'LimpiaGridView()
            'ASIGNA EL DATASET
            DataGridView3.DataSource = ds
            'Cheques
            DataGridView3.DataMember = ds.Tables(7).ToString
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'OTROS METODOS
        Try
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            DataGridView4.Visible = False

            'LimpiaGridView()
            'ASIGNA EL DATASET
            DataGridView3.DataSource = ds
            'Cheques
            DataGridView3.DataMember = ds.Tables(8).ToString

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub
    Private Sub LimpiaGridView()
        'Limpia el Grid View
        Try
            Dim n As Integer ' variables para el for
            Dim fila As DataGridViewRow ' representa una fila del datagridview
            ' ciclo para limpiar el datagrid de cualquier dato y evitar que se repitan
            If DataGridView3.Rows.Count > 0 Then
                For n = DataGridView3.Rows.Count - 2 To 0 Step -1
                    fila = DataGridView3.Rows(n)
                    DataGridView3.Rows.Remove(fila) ' Eliminamos la fila de la colección
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'COMPROBANTES NACIONAL 
        Try
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            DataGridView4.Visible = False

            'LimpiaGridView()
            'ASIGNA EL DATASET
            'DataGridView3.DataSource = ds
            'Cheques
            DataGridView3.DataMember = ds.Tables(3).ToString

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'COMPROBANTES EXTRAJERO
        Try
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            DataGridView4.Visible = False

            'LimpiaGridView()
            'ASIGNA EL DATASET
            'DataGridView3.DataSource = ds
            'Cheques
            DataGridView3.DataMember = ds.Tables(5).ToString

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'OTROS COMPROBANTES NACIONALES
        Try
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            DataGridView4.Visible = False

            'LimpiaGridView()
            'ASIGNA EL DATASET
            'DataGridView3.DataSource = ds
            'Cheques
            DataGridView3.DataMember = ds.Tables(4).ToString

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'EXPORTA EXCEL
        Try
            Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
            Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
            Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
            Dim x As Integer
            worksheet = workbook.Sheets("Hoja1")
            worksheet = workbook.ActiveSheet

            If Me.DataGridView1.Visible Then
                'Agregan las cabeceras de nuestro datagrid.
                For i As Integer = 1 To Me.DataGridView1.Columns.Count
                    worksheet.Cells(1, i) = Me.DataGridView1.Columns(i - 1).HeaderText
                Next

                'Ingresa el detalle recorrera la tabla celda por celda
                For i As Integer = 0 To Me.DataGridView1.Rows.Count - 2
                    For j As Integer = 0 To Me.DataGridView1.Columns.Count - 1
                        worksheet.Cells(i + 2, j + 1) = Me.DataGridView1.Rows(i).Cells(j).Value.ToString()
                    Next
                    'If x = 17 Then
                    '    MsgBox("alto")
                    'End If
                    x = x + 1
                Next
            End If
            If Me.DataGridView2.Visible Then
                'Agregan las cabeceras de nuestro datagrid.
                For i As Integer = 1 To Me.DataGridView2.Columns.Count
                    worksheet.Cells(1, i) = Me.DataGridView2.Columns(i - 1).HeaderText
                Next

                'Ingresa el detalle recorrera la tabla celda por celda
                For i As Integer = 0 To Me.DataGridView2.Rows.Count - 2
                    For j As Integer = 0 To Me.DataGridView2.Columns.Count - 1
                        worksheet.Cells(i + 2, j + 1) = Me.DataGridView2.Rows(i).Cells(j).Value.ToString()
                    Next
                    'If x = 17 Then
                    '    MsgBox("alto")
                    'End If
                    x = x + 1
                Next
            End If
            If Me.DataGridView3.Visible Then
                'Agregan las cabeceras de nuestro datagrid.
                For i As Integer = 1 To Me.DataGridView3.Columns.Count
                    worksheet.Cells(1, i) = Me.DataGridView3.Columns(i - 1).HeaderText
                Next

                'Ingresa el detalle recorrera la tabla celda por celda
                For i As Integer = 0 To Me.DataGridView3.Rows.Count - 2
                    For j As Integer = 0 To Me.DataGridView3.Columns.Count - 1
                        worksheet.Cells(i + 2, j + 1) = Me.DataGridView3.Rows(i).Cells(j).Value.ToString()
                    Next
                    'If x = 17 Then
                    '    MsgBox("alto")
                    'End If
                    x = x + 1
                Next
            End If
            If Me.DataGridView4.Visible Then
                'Agregan las cabeceras de nuestro datagrid.
                For i As Integer = 1 To Me.DataGridView4.Columns.Count
                    worksheet.Cells(1, i) = Me.DataGridView4.Columns(i - 1).HeaderText
                Next

                'Ingresa el detalle recorrera la tabla celda por celda
                For i As Integer = 0 To Me.DataGridView4.Rows.Count - 2
                    For j As Integer = 0 To Me.DataGridView4.Columns.Count - 1
                        worksheet.Cells(i + 2, j + 1) = Me.DataGridView4.Rows(i).Cells(j).Value.ToString()
                    Next
                    'If x = 17 Then
                    '    MsgBox("alto")
                    'End If
                    x = x + 1
                Next
            End If

            'Damos el formato a nuestro excel
            worksheet.Rows.Item(1).Font.Bold = 1
            worksheet.Rows.Item(1).HorizontalAlignment = 3
            worksheet.Columns.AutoFit()
            worksheet.Columns.HorizontalAlignment = 2

            app.Visible = True
            app = Nothing
            workbook = Nothing

            worksheet = Nothing
            FileClose(1)
            GC.Collect()


        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'MUESTRA TODO EL DETALLE DEL XML
        Dim ren, Fila, Fila2, Fila3, Fila4, Fila5, Fila6 As Integer
        Dim id_Poliza, id_Transaccion As Integer
        Dim numPoliza As String
        Dim strFecha As String
        Dim strConcepto As String
        Dim dcDebe As Decimal
        Dim dcHaber As Decimal
        Dim cdSaldo As Decimal
        Dim row As DataRow

        Try
            Fila2 = 0
            Fila3 = 0
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            DataGridView4.Visible = True

            DataGridView4.RowCount = ds.Tables(2).Rows.Count + 1
            For ren = 0 To ds.Tables(1).Rows.Count - 1
                id_Poliza = ds.Tables(1).Rows(ren).ItemArray(3)
                numPoliza = ds.Tables(1).Rows(ren).ItemArray(0)
                'If numPoliza = "CUENTAS A PAGAR.396900" Then
                '    MsgBox("Tiene comprobante")
                'End If
                strFecha = ds.Tables(1).Rows(ren).ItemArray(1)
                strConcepto = ds.Tables(1).Rows(ren).ItemArray(2)
                For Fila = Fila2 To ds.Tables(2).Rows.Count - 1
                    If ds.Tables(2).Rows(Fila).ItemArray(6) = id_Poliza Then
                        id_Transaccion = ds.Tables(2).Rows(Fila).ItemArray(5)
                        DataGridView4.Rows(Fila).Cells(0).Value = numPoliza
                        DataGridView4.Rows(Fila).Cells(1).Value = strConcepto
                        DataGridView4.Rows(Fila).Cells(2).Value = strFecha
                        DataGridView4.Rows(Fila).Cells(3).Value = ds.Tables(2).Rows(Fila).ItemArray(0)
                        DataGridView4.Rows(Fila).Cells(4).Value = ds.Tables(2).Rows(Fila).ItemArray(1)
                        DataGridView4.Rows(Fila).Cells(5).Value = ds.Tables(2).Rows(Fila).ItemArray(2)
                        DataGridView4.Rows(Fila).Cells(6).Value = ds.Tables(2).Rows(Fila).ItemArray(3)
                        DataGridView4.Rows(Fila).Cells(7).Value = ds.Tables(2).Rows(Fila).ItemArray(4)

                        'NODO COMPROBANTES
                        If Fila3 <= ds.Tables(3).Rows.Count - 1 Then
                            If ds.Tables(3).Rows(Fila3).ItemArray(5) = id_Transaccion Then
                                'comprobante nacional
                                DataGridView4.Rows(Fila).Cells(8).Value = ds.Tables(3).Rows(Fila3).ItemArray(0)
                                DataGridView4.Rows(Fila).Cells(9).Value = ds.Tables(3).Rows(Fila3).ItemArray(1)
                                DataGridView4.Rows(Fila).Cells(10).Value = ds.Tables(3).Rows(Fila3).ItemArray(2)
                                DataGridView4.Rows(Fila).Cells(11).Value = ds.Tables(3).Rows(Fila3).ItemArray(3)
                                DataGridView4.Rows(Fila).Cells(12).Value = ds.Tables(3).Rows(Fila3).ItemArray(4)
                                Fila3 = Fila3 + 1
                            Else
                                DataGridView4.Rows(Fila).Cells(8).Value = " "
                                DataGridView4.Rows(Fila).Cells(9).Value = " "
                                DataGridView4.Rows(Fila).Cells(10).Value = " "
                                DataGridView4.Rows(Fila).Cells(11).Value = " "
                                DataGridView4.Rows(Fila).Cells(12).Value = " "
                            End If
                        End If
                        If Fila4 <= ds.Tables(5).Rows.Count - 1 Then
                            If ds.Tables(5).Rows(Fila4).ItemArray(5) = id_Transaccion Then
                                'comprobante Extranjero
                                DataGridView4.Rows(Fila).Cells(8).Value = ds.Tables(5).Rows(Fila4).ItemArray(0)
                                DataGridView4.Rows(Fila).Cells(9).Value = ds.Tables(5).Rows(Fila4).ItemArray(1)
                                DataGridView4.Rows(Fila).Cells(10).Value = ds.Tables(5).Rows(Fila4).ItemArray(2)
                                DataGridView4.Rows(Fila).Cells(11).Value = ds.Tables(5).Rows(Fila4).ItemArray(3)
                                DataGridView4.Rows(Fila).Cells(12).Value = ds.Tables(5).Rows(Fila4).ItemArray(4)
                                Fila4 = Fila4 + 1
                            Else
                                DataGridView4.Rows(Fila).Cells(8).Value = " "
                                DataGridView4.Rows(Fila).Cells(9).Value = " "
                                DataGridView4.Rows(Fila).Cells(10).Value = " "
                                DataGridView4.Rows(Fila).Cells(11).Value = " "
                                DataGridView4.Rows(Fila).Cells(12).Value = " "
                            End If
                        End If
                    Else
                        Fila2 = Fila
                        Exit For
                    End If
                Next
            Next

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.frmDetalleNomina = New frmDetallePolizaNomina
        Me.frmDetalleNomina.dsPolizas = ds
        Me.frmDetalleNomina.ShowDialog(Me)
    End Sub
End Class
