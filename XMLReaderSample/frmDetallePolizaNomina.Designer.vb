<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePolizaNomina
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumUnIdenPol = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colAsientoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescAsiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDebe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHaber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTransferencia = New System.Windows.Forms.DataGridView()
        Me.dgCompNal = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumeroPoliza = New System.Windows.Forms.TextBox()
        Me.txtFechaPoliza = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConceptoPoliza = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.colRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBenef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBancoDestExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBancoDestNal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCtaDest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBancoOriExt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBancoOriNal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCtaOri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMontosTransferencia = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMontosCompNal = New System.Windows.Forms.Label()
        Me.txtDebe = New System.Windows.Forms.TextBox()
        Me.txtHaber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipCamb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTransferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCompNal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de Póliza"
        '
        'txtNumUnIdenPol
        '
        Me.txtNumUnIdenPol.Location = New System.Drawing.Point(108, 6)
        Me.txtNumUnIdenPol.Name = "txtNumUnIdenPol"
        Me.txtNumUnIdenPol.Size = New System.Drawing.Size(502, 20)
        Me.txtNumUnIdenPol.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(616, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAsientoID, Me.colDescAsiento, Me.colDescCta, Me.colCta, Me.colDebe, Me.colHaber})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(925, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'colAsientoID
        '
        Me.colAsientoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colAsientoID.HeaderText = "Num Asiento"
        Me.colAsientoID.Name = "colAsientoID"
        Me.colAsientoID.ReadOnly = True
        Me.colAsientoID.Width = 85
        '
        'colDescAsiento
        '
        Me.colDescAsiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colDescAsiento.HeaderText = "Descripción Asiento"
        Me.colDescAsiento.Name = "colDescAsiento"
        Me.colDescAsiento.ReadOnly = True
        Me.colDescAsiento.Width = 115
        '
        'colDescCta
        '
        Me.colDescCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colDescCta.HeaderText = "Descripcion Cuenta"
        Me.colDescCta.Name = "colDescCta"
        Me.colDescCta.ReadOnly = True
        Me.colDescCta.Width = 114
        '
        'colCta
        '
        Me.colCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCta.HeaderText = "Cuenta Contable"
        Me.colCta.Name = "colCta"
        Me.colCta.ReadOnly = True
        Me.colCta.Width = 102
        '
        'colDebe
        '
        Me.colDebe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colDebe.DefaultCellStyle = DataGridViewCellStyle1
        Me.colDebe.HeaderText = "Debe"
        Me.colDebe.Name = "colDebe"
        Me.colDebe.ReadOnly = True
        Me.colDebe.Width = 58
        '
        'colHaber
        '
        Me.colHaber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colHaber.DefaultCellStyle = DataGridViewCellStyle2
        Me.colHaber.HeaderText = "Haber"
        Me.colHaber.Name = "colHaber"
        Me.colHaber.ReadOnly = True
        Me.colHaber.Width = 61
        '
        'dgTransferencia
        '
        Me.dgTransferencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransferencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRFC, Me.colFecha, Me.colMonto, Me.colBenef, Me.colBancoDestExt, Me.colBancoDestNal, Me.colCtaDest, Me.colBancoOriExt, Me.colBancoOriNal, Me.colCtaOri})
        Me.dgTransferencia.Location = New System.Drawing.Point(15, 322)
        Me.dgTransferencia.Name = "dgTransferencia"
        Me.dgTransferencia.Size = New System.Drawing.Size(925, 150)
        Me.dgTransferencia.TabIndex = 5
        Me.dgTransferencia.Visible = False
        '
        'dgCompNal
        '
        Me.dgCompNal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCompNal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompNal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RFC, Me.Moneda, Me.TipCamb, Me.Monto, Me.UUID})
        Me.dgCompNal.Location = New System.Drawing.Point(15, 322)
        Me.dgCompNal.Name = "dgCompNal"
        Me.dgCompNal.Size = New System.Drawing.Size(925, 150)
        Me.dgCompNal.TabIndex = 6
        Me.dgCompNal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NumUnIdenPol"
        '
        'txtNumeroPoliza
        '
        Me.txtNumeroPoliza.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPoliza.ForeColor = System.Drawing.Color.Green
        Me.txtNumeroPoliza.Location = New System.Drawing.Point(12, 49)
        Me.txtNumeroPoliza.Name = "txtNumeroPoliza"
        Me.txtNumeroPoliza.ReadOnly = True
        Me.txtNumeroPoliza.Size = New System.Drawing.Size(379, 32)
        Me.txtNumeroPoliza.TabIndex = 8
        '
        'txtFechaPoliza
        '
        Me.txtFechaPoliza.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaPoliza.ForeColor = System.Drawing.Color.Green
        Me.txtFechaPoliza.Location = New System.Drawing.Point(397, 49)
        Me.txtFechaPoliza.Name = "txtFechaPoliza"
        Me.txtFechaPoliza.ReadOnly = True
        Me.txtFechaPoliza.Size = New System.Drawing.Size(129, 32)
        Me.txtFechaPoliza.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha"
        '
        'txtConceptoPoliza
        '
        Me.txtConceptoPoliza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConceptoPoliza.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConceptoPoliza.ForeColor = System.Drawing.Color.Green
        Me.txtConceptoPoliza.Location = New System.Drawing.Point(556, 49)
        Me.txtConceptoPoliza.Name = "txtConceptoPoliza"
        Me.txtConceptoPoliza.ReadOnly = True
        Me.txtConceptoPoliza.Size = New System.Drawing.Size(384, 32)
        Me.txtConceptoPoliza.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(709, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Concepto"
        '
        'colRFC
        '
        Me.colRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colRFC.HeaderText = "RFC"
        Me.colRFC.Name = "colRFC"
        Me.colRFC.ReadOnly = True
        Me.colRFC.Width = 53
        '
        'colFecha
        '
        Me.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        Me.colFecha.Width = 62
        '
        'colMonto
        '
        Me.colMonto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colMonto.DefaultCellStyle = DataGridViewCellStyle3
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.ReadOnly = True
        Me.colMonto.Width = 62
        '
        'colBenef
        '
        Me.colBenef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colBenef.HeaderText = "Beneficiario"
        Me.colBenef.Name = "colBenef"
        Me.colBenef.ReadOnly = True
        Me.colBenef.Width = 87
        '
        'colBancoDestExt
        '
        Me.colBancoDestExt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colBancoDestExt.HeaderText = "BancoDestExt"
        Me.colBancoDestExt.Name = "colBancoDestExt"
        Me.colBancoDestExt.ReadOnly = True
        '
        'colBancoDestNal
        '
        Me.colBancoDestNal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colBancoDestNal.HeaderText = "BancoDestNal"
        Me.colBancoDestNal.Name = "colBancoDestNal"
        Me.colBancoDestNal.ReadOnly = True
        Me.colBancoDestNal.Width = 101
        '
        'colCtaDest
        '
        Me.colCtaDest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCtaDest.HeaderText = "CtaDest"
        Me.colCtaDest.Name = "colCtaDest"
        Me.colCtaDest.ReadOnly = True
        Me.colCtaDest.Width = 70
        '
        'colBancoOriExt
        '
        Me.colBancoOriExt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colBancoOriExt.HeaderText = "BancoOriExt"
        Me.colBancoOriExt.Name = "colBancoOriExt"
        Me.colBancoOriExt.ReadOnly = True
        Me.colBancoOriExt.Width = 91
        '
        'colBancoOriNal
        '
        Me.colBancoOriNal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colBancoOriNal.HeaderText = "BancoOriNal"
        Me.colBancoOriNal.Name = "colBancoOriNal"
        Me.colBancoOriNal.ReadOnly = True
        Me.colBancoOriNal.Width = 92
        '
        'colCtaOri
        '
        Me.colCtaOri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCtaOri.HeaderText = "CtaOri"
        Me.colCtaOri.Name = "colCtaOri"
        Me.colCtaOri.ReadOnly = True
        Me.colCtaOri.Width = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Suma Montos  Transferencia :"
        '
        'lblMontosTransferencia
        '
        Me.lblMontosTransferencia.AutoSize = True
        Me.lblMontosTransferencia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontosTransferencia.ForeColor = System.Drawing.Color.Green
        Me.lblMontosTransferencia.Location = New System.Drawing.Point(167, 297)
        Me.lblMontosTransferencia.Name = "lblMontosTransferencia"
        Me.lblMontosTransferencia.Size = New System.Drawing.Size(0, 19)
        Me.lblMontosTransferencia.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Suma Montos Comprobante Nacional"
        '
        'lblMontosCompNal
        '
        Me.lblMontosCompNal.AutoSize = True
        Me.lblMontosCompNal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontosCompNal.ForeColor = System.Drawing.Color.Green
        Me.lblMontosCompNal.Location = New System.Drawing.Point(599, 297)
        Me.lblMontosCompNal.Name = "lblMontosCompNal"
        Me.lblMontosCompNal.Size = New System.Drawing.Size(0, 19)
        Me.lblMontosCompNal.TabIndex = 16
        '
        'txtDebe
        '
        Me.txtDebe.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDebe.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebe.ForeColor = System.Drawing.SystemColors.Info
        Me.txtDebe.Location = New System.Drawing.Point(227, 99)
        Me.txtDebe.Name = "txtDebe"
        Me.txtDebe.ReadOnly = True
        Me.txtDebe.Size = New System.Drawing.Size(196, 26)
        Me.txtDebe.TabIndex = 17
        '
        'txtHaber
        '
        Me.txtHaber.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHaber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHaber.ForeColor = System.Drawing.SystemColors.Info
        Me.txtHaber.Location = New System.Drawing.Point(556, 99)
        Me.txtHaber.Name = "txtHaber"
        Me.txtHaber.ReadOnly = True
        Me.txtHaber.Size = New System.Drawing.Size(207, 26)
        Me.txtHaber.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(188, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Debe"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(514, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Haber"
        '
        'RFC
        '
        Me.RFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RFC.HeaderText = "RFC"
        Me.RFC.Name = "RFC"
        Me.RFC.ReadOnly = True
        Me.RFC.Width = 53
        '
        'Moneda
        '
        Me.Moneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Moneda.DefaultCellStyle = DataGridViewCellStyle4
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        Me.Moneda.Width = 71
        '
        'TipCamb
        '
        Me.TipCamb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.TipCamb.DefaultCellStyle = DataGridViewCellStyle5
        Me.TipCamb.HeaderText = "Tipo de Cambio"
        Me.TipCamb.Name = "TipCamb"
        Me.TipCamb.ReadOnly = True
        Me.TipCamb.Width = 97
        '
        'Monto
        '
        Me.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle6
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 62
        '
        'UUID
        '
        Me.UUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UUID.HeaderText = "UUID"
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        Me.UUID.Width = 59
        '
        'frmDetallePolizaNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 484)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHaber)
        Me.Controls.Add(Me.txtDebe)
        Me.Controls.Add(Me.lblMontosCompNal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMontosTransferencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConceptoPoliza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaPoliza)
        Me.Controls.Add(Me.txtNumeroPoliza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgCompNal)
        Me.Controls.Add(Me.dgTransferencia)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtNumUnIdenPol)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDetallePolizaNomina"
        Me.Text = "frmDetallePolizaNomina"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTransferencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCompNal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumUnIdenPol As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents colAsientoID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescAsiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgTransferencia As System.Windows.Forms.DataGridView
    Friend WithEvents dgCompNal As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroPoliza As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConceptoPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colRFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBenef As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBancoDestExt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBancoDestNal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCtaDest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBancoOriExt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBancoOriNal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCtaOri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMontosTransferencia As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMontosCompNal As System.Windows.Forms.Label
    Friend WithEvents txtDebe As System.Windows.Forms.TextBox
    Friend WithEvents txtHaber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipCamb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UUID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
