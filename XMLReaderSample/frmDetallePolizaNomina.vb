Public Class frmDetallePolizaNomina

    Private dsPol As DataSet
    Private MontoAsientoContableTransferencias As Decimal
    Private MontoAsientoContableCompNal As Decimal
    Private TC As Decimal
    Private MontoCompNalMXN As Decimal


    Public Property dsPolizas As DataSet
        Set(ByVal value As DataSet)
            Me.dsPol = value
        End Set
        Get
            Return Me.dsPol
        End Get
    End Property

    Private Sub Limpiar()

        Me.txtNumeroPoliza.Text = ""
        Me.txtFechaPoliza.Text = ""
        Me.txtConceptoPoliza.Text = ""
        Me.DataGridView1.DataMember = Nothing
        Me.dgTransferencia.Rows.Clear()
        Me.dgCompNal.Rows.Clear()
        Me.dgTransferencia.Visible = False
        Me.dgCompNal.Visible = False

        Me.txtDebe.Text = ""
        Me.txtHaber.Text = ""
        Me.lblMontosCompNal.Text = ""
        Me.lblMontosTransferencia.Text = ""


    End Sub


    Private Sub frmDetallePolizaNomina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Not IsNothing(Me.dsPol) Then

        End If

    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim rs(), rA As DataRow
        Dim cond As String = String.Empty
        Dim cabecera As String = String.Empty
        Dim fila As Integer = 0
        Dim vd_Debe, vd_Haber As Decimal
        Dim tempD, tempH As Decimal

        vd_Debe = 0.0
        vd_Haber = 0.0
        Me.Limpiar()


        If Not IsNothing(Me.dsPol) Then

            If Me.dsPol.Tables.Count > 0 Then

                If Not IsNothing(Me.dsPol.Tables("Poliza")) Then

                    cond = "NumUnIdenPol='" & Me.txtNumUnIdenPol.Text.Trim & "'"

                    If Not String.IsNullOrEmpty(cond) Then

                        rs = Me.dsPol.Tables("Poliza").Select(cond)

                        If Not IsNothing(rs) Then

                            If rs.Length > 0 Then

                                cabecera = "NumUnIdenPol = " & rs(0)("NumUnIdenPol") & vbCrLf
                                cabecera &= "Fecha = " & rs(0)("Fecha") & vbCrLf
                                cabecera &= "Concepto = " & rs(0)("Concepto") & vbCrLf
                                cabecera &= "Pos4 = " & rs(0)(3) & vbCrLf
                                cabecera &= "Pos5 = " & rs(0)(4) & vbCrLf

                                Me.txtNumeroPoliza.Text = rs(0)("NumUnIdenPol")
                                Me.txtFechaPoliza.Text = rs(0)("Fecha")
                                Me.txtConceptoPoliza.Text = rs(0)("Concepto")


                                Dim AsientosContables As DataTable

                                AsientosContables = Me.dsPol.Tables("Transaccion")

                                If Not IsNothing(AsientosContables) Then

                                    Dim rsAsin() As DataRow

                                    rsAsin = AsientosContables.Select("Poliza_Id=" & rs(0)(3).ToString)

                                    MsgBox("Total asientos contables en la PolizaID  " & rs(0)(3).ToString & " : " & rsAsin.Count.ToString)

                                    Me.DataGridView1.RowCount = rsAsin.Count + 1

                                    If Not IsNothing(rsAsin) Then
                                       
                                        For Each rA In rsAsin


                                            Me.DataGridView1.Rows(fila).Cells("colAsientoID").Value = Me.txtNumUnIdenPol.Text.Trim
                                            Me.DataGridView1.Rows(fila).Cells("colDescAsiento").Value = rA("Concepto")
                                            Me.DataGridView1.Rows(fila).Cells("colDescCta").Value = rA("DesCta")
                                            Me.DataGridView1.Rows(fila).Cells("colCta").Value = rA("NumCta")
                                            Me.DataGridView1.Rows(fila).Cells("colDebe").Value = rA("Debe")
                                            Me.DataGridView1.Rows(fila).Cells("colHaber").Value = rA("Haber")

                                            Dim Keys(1) As Integer

                                            Keys(0) = (rA("Transaccion_Id"))
                                            Me.DataGridView1.Rows(fila).Tag = rA("Transaccion_Id")

                                            fila += 1


                                            Decimal.TryParse(rA("Debe"), tempD)
                                            vd_Debe += tempD

                                            Decimal.TryParse(rA("Haber"), tempH)
                                            vd_Haber += tempH

                                        Next

                                        tempD = 0.0
                                        tempH = 0.0
                                        fila = 0

                                        If vd_Debe <> vd_Haber Then

                                            For Each rA In rsAsin
                                                Me.DataGridView1.Rows(fila).Cells("colDebe").Style.ForeColor = Color.Crimson
                                                Me.DataGridView1.Rows(fila).Cells("colHaber").Style.ForeColor = Color.Crimson
                                                fila += 1
                                            Next
                                        Else
                                            For Each rA In rsAsin
                                                Me.DataGridView1.Rows(fila).Cells("colDebe").Style.ForeColor = Color.Green
                                                Me.DataGridView1.Rows(fila).Cells("colHaber").Style.ForeColor = Color.Green
                                                fila += 1
                                            Next
                                           
                                        End If

                                        Me.txtDebe.Text = FormatCurrency(vd_Debe.ToString, 2)
                                        Me.txtHaber.Text = FormatCurrency(vd_Haber.ToString, 2)

                                        If vd_Debe <> vd_Haber Then
                                            Me.txtDebe.ForeColor = Color.Crimson
                                            Me.txtHaber.ForeColor = Color.Crimson
                                        Else
                                            Me.txtDebe.ForeColor = Color.Green
                                            Me.txtHaber.ForeColor = Color.Green
                                        End If

                                    End If

                                   


                                End If

                            End If
                        Else

                            MsgBox("No se ha encontrado la poliza " & Me.txtNumUnIdenPol.Text)

                        End If

                    End If

                Else
                    'MsgBox("No fueron cargadas los Nodos Poliza, Comprobantes y Métodos de Pago")
                End If

            Else
                'MsgBox("No fueron cargadas los Nodos Poliza, Comprobantes y Métodos de Pago")
            End If

        Else

            MsgBox("No fueron cargadas las Pólizas")

        End If

        Me.DataGridView1.ClearSelection()


    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

        Me.lblMontosCompNal.Text = ""
        Me.lblMontosTransferencia.Text = ""

        If Me.DataGridView1.SelectedRows.Count > 0 Then

            Dim ID, fila As Integer
            Dim rwsTransferencia(), rA, rwsCompNal() As DataRow

            If Integer.TryParse(Me.DataGridView1.SelectedRows(0).Tag.ToString(), ID) Then


                rwsTransferencia = Me.dsPol.Tables("Transferencia").Select("Transaccion_Id=" & ID.ToString)
                rwsCompNal = Me.dsPol.Tables("CompNal").Select("Transaccion_Id=" & ID.ToString)

                If rwsTransferencia.Count > 0 Then
                    MsgBox("Número de Nodos TRANSFERENCIA creados : " & rwsTransferencia.Count.ToString)

                    Me.dgTransferencia.RowCount = rwsTransferencia.Count + 1

                    If Not IsNothing(rwsTransferencia) Then

                        For Each rA In rwsTransferencia


                            Me.dgTransferencia.Rows(fila).Cells("colRFC").Value = rA("RFC")
                            Me.dgTransferencia.Rows(fila).Cells("colFecha").Value = rA("Fecha")
                            Me.dgTransferencia.Rows(fila).Cells("colMonto").Value = rA("Monto")
                            Me.dgTransferencia.Rows(fila).Cells("colBenef").Value = rA("Benef")
                            Me.dgTransferencia.Rows(fila).Cells("colBancoDestExt").Value = rA("BancoDestExt")
                            Me.dgTransferencia.Rows(fila).Cells("colBancoDestNal").Value = rA("BancoDestNal")
                            Me.dgTransferencia.Rows(fila).Cells("colCtaDest").Value = rA("CtaDest")
                            Me.dgTransferencia.Rows(fila).Cells("colBancoOriExt").Value = rA("BancoOriExt")
                            Me.dgTransferencia.Rows(fila).Cells("colBancoOriNal").Value = rA("BancoOriNal")
                            Me.dgTransferencia.Rows(fila).Cells("colCtaOri").Value = rA("CtaOri")


                            fila += 1

                            Dim montoT As Decimal
                            Decimal.TryParse(rA("Monto"), montoT)
                            Me.MontoAsientoContableTransferencias += montoT

                        Next

                        Me.dgTransferencia.Visible = True
                        Me.lblMontosTransferencia.Text = FormatCurrency(Me.MontoAsientoContableTransferencias.ToString, 2)
                        Me.MontoAsientoContableTransferencias += 0.0
                        Me.dgTransferencia.Columns("colRFC").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colFecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colMonto").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colBenef").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colBancoDestExt").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colBancoDestNal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colCtaDest").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colBancoOriExt").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colBancoOriNal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Me.dgTransferencia.Columns("colCtaOri").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells



                    End If
                    
                Else
                    'MsgBox("Esta CUENTA CONTABLE no genera nodos adicionales")
                End If

                If rwsCompNal.Count > 0 Then

                    MsgBox("Número de Nodos Comprobante Nacional creados : " & rwsCompNal.Count.ToString)

                    Me.dgCompNal.RowCount = rwsCompNal.Count + 1



                    If Not IsNothing(rwsCompNal) Then

                        For Each rA In rwsCompNal


                            Me.dgCompNal.Rows(fila).Cells("RFC").Value = rA("RFC")
                            Me.dgCompNal.Rows(fila).Cells("Monto").Value = rA("MontoTotal")
                            Me.dgCompNal.Rows(fila).Cells("UUID").Value = rA("UUID_CFDI")

                            Me.dgCompNal.Rows(fila).Cells("Moneda").Value = rA("Moneda")
                            Me.dgCompNal.Rows(fila).Cells("TipCamb").Value = rA("TipCamb")

                            fila += 1

                            Dim montoT As Decimal
                            Decimal.TryParse(rA("MontoTotal"), montoT)
                            Me.MontoAsientoContableCompNal += montoT

                            If Not IsDBNull(rA("Moneda")) Then
                                Dim mon As String
                                mon = rA("Moneda")
                                If mon.Equals("USD") Then
                                    Decimal.TryParse(rA("TipCamb"), Me.TC)
                                    If Me.TC > 0.0 Then
                                        Dim temp1 As Decimal
                                        temp1 = Me.MontoAsientoContableCompNal * Me.TC
                                        Me.MontoCompNalMXN += temp1
                                    End If
                                End If

                            End If

                            Me.dgCompNal.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            Me.dgCompNal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            Me.dgCompNal.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                        Next

                        Me.dgCompNal.Visible = True
                        If Me.MontoCompNalMXN = 0 Then
                            Me.lblMontosCompNal.Text = FormatCurrency(Me.MontoAsientoContableCompNal.ToString, 2)
                        Else
                            Me.lblMontosCompNal.Text = FormatCurrency(Me.MontoAsientoContableCompNal.ToString, 2) & " / MXN " & FormatCurrency(Me.MontoCompNalMXN.ToString, 2)
                        End If

                        Me.MontoAsientoContableCompNal = 0.0
                        Me.MontoCompNalMXN = 0.0

                    End If

                Else
                    'MsgBox("Esta CUENTA CONTABLE no genera nodos adicionales")
                End If



            End If



        End If

        Me.dgTransferencia.ClearSelection()
        Me.dgCompNal.ClearSelection()

    End Sub
End Class