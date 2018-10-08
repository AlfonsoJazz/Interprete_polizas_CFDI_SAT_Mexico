Imports System.Xml
Imports System.Data


Module Module1
    Public ds As New DataSet
    Private vc_pathSchemaPolizas As String = String.Empty

  
    Public Sub CargaXmlToDs()
        Dim oFileInfo As IO.FileInfo = Nothing

        Try
            ds.Clear()
            'Carga_Ds()
            vc_pathSchemaPolizas = Application.StartupPath & "\PolizasPeriodo_1_3.xsd"
            'ds.ReadXmlSchema("C:\Users\wsarabia\Documents\PROYECTOS\Interprete_XML\XMLReaderSample\Schema\PolizasPeriodo_1_1.xsd")
            ds.ReadXmlSchema(vc_pathSchemaPolizas)
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
            ds.ReadXml(oFileInfo.FullName)

            'ds.ReadXml("C:\Users\vcisneros\Documents\Visual Studio 2010\Projects\ContaElectronica\XMLReaderSample\XMLReaderSample\Schema\OME0308072T8201506PL.xml")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'MessageBox.Show("No se pudo completar la operación, Revise la estructura del XML.", "Fallo en carga del XML", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub OpenFileXml()
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
                                If oXmlTextReader.Name = "PLZ:Transaccion" Then ' 2018-08-30 Alfonso Mosco H Version 1.3 XML mod
                                    'If oXmlTextReader.Name = "Transaccion" Then
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
                        End Select
                    End While
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

End Module
