Option Strict Off
Option Explicit On

Imports Microsoft.Reporting.WinForms
Friend Class Form_Facturas
    Inherits System.Windows.Forms.Form
	Dim dtFacturas, dtDetalle As DataTable
	Dim daFacturas, daDetalle As SqlClient.SqlDataAdapter
	Dim Preguntar As Boolean = False
	Public WithEvents Text_Cliente As System.Windows.Forms.TextBox
		Friend WithEvents VerAlbaranes As System.Windows.Forms.Button
		Friend WithEvents btnVerAbono As System.Windows.Forms.Button
  Friend WithEvents btnVerFactura As System.Windows.Forms.Button
	Private NumFactura As Long
#Region "Código generado por el Diseñador de Windows Forms "
  Public Sub New(ByVal NumFactura As Long)
	MyBase.New()
	'El Diseñador de Windows Forms requiere esta llamada.
	InitializeComponent()
	Me.NumFactura = NumFactura
  End Sub
	'Form reemplaza a Dispose para limpiar la lista de componentes.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public WithEvents Text_Numero As System.Windows.Forms.TextBox
	Public WithEvents cAnio As System.Windows.Forms.ComboBox
	Public WithEvents cMes As System.Windows.Forms.ComboBox
	Public WithEvents cDia As System.Windows.Forms.ComboBox
	Public WithEvents Text_Destino As System.Windows.Forms.TextBox
  Public WithEvents Label_Numero As System.Windows.Forms.Label
	Public WithEvents Label_Fecha As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label_Destino As System.Windows.Forms.Label
	Public WithEvents Label_Cliente As System.Windows.Forms.Label
	Public WithEvents Marco As System.Windows.Forms.GroupBox
	Public WithEvents Cancelar As System.Windows.Forms.Button
	Public WithEvents Aceptar As System.Windows.Forms.Button
	Public WithEvents cmdBorrar As System.Windows.Forms.Button
	Public WithEvents cmdAniadir As System.Windows.Forms.Button
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	Friend WithEvents dgFacturas As System.Windows.Forms.DataGrid
	Friend WithEvents chkCobrada As System.Windows.Forms.CheckBox
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.Marco = New System.Windows.Forms.GroupBox
Me.Text_Cliente = New System.Windows.Forms.TextBox
Me.chkCobrada = New System.Windows.Forms.CheckBox
Me.Text_Numero = New System.Windows.Forms.TextBox
Me.cAnio = New System.Windows.Forms.ComboBox
Me.cMes = New System.Windows.Forms.ComboBox
Me.cDia = New System.Windows.Forms.ComboBox
Me.Text_Destino = New System.Windows.Forms.TextBox
Me.Label_Numero = New System.Windows.Forms.Label
Me.Label_Fecha = New System.Windows.Forms.Label
Me.Label2 = New System.Windows.Forms.Label
Me.Label1 = New System.Windows.Forms.Label
Me.Label_Destino = New System.Windows.Forms.Label
Me.Label_Cliente = New System.Windows.Forms.Label
Me.dgFacturas = New System.Windows.Forms.DataGrid
Me.Cancelar = New System.Windows.Forms.Button
Me.Aceptar = New System.Windows.Forms.Button
Me.cmdBorrar = New System.Windows.Forms.Button
Me.cmdAniadir = New System.Windows.Forms.Button
Me.VerAlbaranes = New System.Windows.Forms.Button
Me.btnVerAbono = New System.Windows.Forms.Button
Me.btnVerFactura = New System.Windows.Forms.Button
Me.Marco.SuspendLayout()
CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'Marco
'
Me.Marco.BackColor = System.Drawing.SystemColors.Control
Me.Marco.Controls.Add(Me.Text_Cliente)
Me.Marco.Controls.Add(Me.chkCobrada)
Me.Marco.Controls.Add(Me.Text_Numero)
Me.Marco.Controls.Add(Me.cAnio)
Me.Marco.Controls.Add(Me.cMes)
Me.Marco.Controls.Add(Me.cDia)
Me.Marco.Controls.Add(Me.Text_Destino)
Me.Marco.Controls.Add(Me.Label_Numero)
Me.Marco.Controls.Add(Me.Label_Fecha)
Me.Marco.Controls.Add(Me.Label2)
Me.Marco.Controls.Add(Me.Label1)
Me.Marco.Controls.Add(Me.Label_Destino)
Me.Marco.Controls.Add(Me.Label_Cliente)
Me.Marco.Controls.Add(Me.dgFacturas)
Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
Me.Marco.Location = New System.Drawing.Point(24, 8)
Me.Marco.Name = "Marco"
Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Marco.Size = New System.Drawing.Size(465, 487)
Me.Marco.TabIndex = 4
Me.Marco.TabStop = False
Me.Marco.Text = "Facturas"
'
'Text_Cliente
'
Me.Text_Cliente.AcceptsReturn = True
Me.Text_Cliente.BackColor = System.Drawing.SystemColors.Window
Me.Text_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam
Me.Text_Cliente.Enabled = False
Me.Text_Cliente.ForeColor = System.Drawing.SystemColors.WindowText
Me.Text_Cliente.Location = New System.Drawing.Point(136, 93)
Me.Text_Cliente.MaxLength = 0
Me.Text_Cliente.Name = "Text_Cliente"
Me.Text_Cliente.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Text_Cliente.Size = New System.Drawing.Size(289, 26)
Me.Text_Cliente.TabIndex = 21
'
'chkCobrada
'
Me.chkCobrada.AutoSize = True
Me.chkCobrada.Location = New System.Drawing.Point(20, 234)
Me.chkCobrada.Name = "chkCobrada"
Me.chkCobrada.Size = New System.Drawing.Size(96, 24)
Me.chkCobrada.TabIndex = 20
Me.chkCobrada.Text = "Cobrada"
Me.chkCobrada.UseVisualStyleBackColor = True
'
'Text_Numero
'
Me.Text_Numero.AcceptsReturn = True
Me.Text_Numero.BackColor = System.Drawing.SystemColors.Window
Me.Text_Numero.Cursor = System.Windows.Forms.Cursors.IBeam
Me.Text_Numero.Enabled = False
Me.Text_Numero.ForeColor = System.Drawing.SystemColors.WindowText
Me.Text_Numero.Location = New System.Drawing.Point(136, 37)
Me.Text_Numero.MaxLength = 0
Me.Text_Numero.Name = "Text_Numero"
Me.Text_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Text_Numero.Size = New System.Drawing.Size(57, 26)
Me.Text_Numero.TabIndex = 9
'
'cAnio
'
Me.cAnio.BackColor = System.Drawing.SystemColors.Window
Me.cAnio.Cursor = System.Windows.Forms.Cursors.Default
Me.cAnio.Enabled = False
Me.cAnio.ForeColor = System.Drawing.SystemColors.WindowText
Me.cAnio.Location = New System.Drawing.Point(304, 192)
Me.cAnio.Name = "cAnio"
Me.cAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cAnio.Size = New System.Drawing.Size(65, 28)
Me.cAnio.TabIndex = 8
'
'cMes
'
Me.cMes.BackColor = System.Drawing.SystemColors.Window
Me.cMes.Cursor = System.Windows.Forms.Cursors.Default
Me.cMes.Enabled = False
Me.cMes.ForeColor = System.Drawing.SystemColors.WindowText
Me.cMes.Location = New System.Drawing.Point(224, 192)
Me.cMes.Name = "cMes"
Me.cMes.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cMes.Size = New System.Drawing.Size(49, 28)
Me.cMes.TabIndex = 7
'
'cDia
'
Me.cDia.BackColor = System.Drawing.SystemColors.Window
Me.cDia.Cursor = System.Windows.Forms.Cursors.Default
Me.cDia.Enabled = False
Me.cDia.ForeColor = System.Drawing.SystemColors.WindowText
Me.cDia.Location = New System.Drawing.Point(136, 192)
Me.cDia.Name = "cDia"
Me.cDia.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cDia.Size = New System.Drawing.Size(49, 28)
Me.cDia.TabIndex = 6
'
'Text_Destino
'
Me.Text_Destino.AcceptsReturn = True
Me.Text_Destino.BackColor = System.Drawing.SystemColors.Window
Me.Text_Destino.Cursor = System.Windows.Forms.Cursors.IBeam
Me.Text_Destino.Enabled = False
Me.Text_Destino.ForeColor = System.Drawing.SystemColors.WindowText
Me.Text_Destino.Location = New System.Drawing.Point(136, 141)
Me.Text_Destino.MaxLength = 0
Me.Text_Destino.Name = "Text_Destino"
Me.Text_Destino.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Text_Destino.Size = New System.Drawing.Size(289, 26)
Me.Text_Destino.TabIndex = 5
'
'Label_Numero
'
Me.Label_Numero.AutoSize = True
Me.Label_Numero.BackColor = System.Drawing.SystemColors.Control
Me.Label_Numero.Cursor = System.Windows.Forms.Cursors.Default
Me.Label_Numero.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label_Numero.Location = New System.Drawing.Point(16, 40)
Me.Label_Numero.Name = "Label_Numero"
Me.Label_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label_Numero.Size = New System.Drawing.Size(71, 20)
Me.Label_Numero.TabIndex = 17
Me.Label_Numero.Text = "Número"
'
'Label_Fecha
'
Me.Label_Fecha.BackColor = System.Drawing.SystemColors.Control
Me.Label_Fecha.Cursor = System.Windows.Forms.Cursors.Default
Me.Label_Fecha.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label_Fecha.Location = New System.Drawing.Point(16, 192)
Me.Label_Fecha.Name = "Label_Fecha"
Me.Label_Fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label_Fecha.Size = New System.Drawing.Size(89, 25)
Me.Label_Fecha.TabIndex = 16
Me.Label_Fecha.Text = "Fecha"
'
'Label2
'
Me.Label2.BackColor = System.Drawing.SystemColors.Control
Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label2.Location = New System.Drawing.Point(288, 192)
Me.Label2.Name = "Label2"
Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label2.Size = New System.Drawing.Size(9, 25)
Me.Label2.TabIndex = 15
Me.Label2.Text = "/"
'
'Label1
'
Me.Label1.BackColor = System.Drawing.SystemColors.Control
Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label1.Location = New System.Drawing.Point(200, 192)
Me.Label1.Name = "Label1"
Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label1.Size = New System.Drawing.Size(9, 25)
Me.Label1.TabIndex = 14
Me.Label1.Text = "/"
'
'Label_Destino
'
Me.Label_Destino.BackColor = System.Drawing.SystemColors.Control
Me.Label_Destino.Cursor = System.Windows.Forms.Cursors.Default
Me.Label_Destino.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label_Destino.Location = New System.Drawing.Point(16, 144)
Me.Label_Destino.Name = "Label_Destino"
Me.Label_Destino.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label_Destino.Size = New System.Drawing.Size(89, 25)
Me.Label_Destino.TabIndex = 13
Me.Label_Destino.Text = "Destino"
'
'Label_Cliente
'
Me.Label_Cliente.BackColor = System.Drawing.SystemColors.Control
Me.Label_Cliente.Cursor = System.Windows.Forms.Cursors.Default
Me.Label_Cliente.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label_Cliente.Location = New System.Drawing.Point(16, 96)
Me.Label_Cliente.Name = "Label_Cliente"
Me.Label_Cliente.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label_Cliente.Size = New System.Drawing.Size(89, 25)
Me.Label_Cliente.TabIndex = 12
Me.Label_Cliente.Text = "Cliente"
'
'dgFacturas
'
Me.dgFacturas.DataMember = ""
Me.dgFacturas.Enabled = False
Me.dgFacturas.HeaderForeColor = System.Drawing.SystemColors.ControlText
Me.dgFacturas.Location = New System.Drawing.Point(20, 267)
Me.dgFacturas.Name = "dgFacturas"
Me.dgFacturas.PreferredColumnWidth = 250
Me.dgFacturas.ReadOnly = True
Me.dgFacturas.Size = New System.Drawing.Size(429, 203)
Me.dgFacturas.TabIndex = 6
'
'Cancelar
'
Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
Me.Cancelar.Location = New System.Drawing.Point(568, 72)
Me.Cancelar.Name = "Cancelar"
Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Cancelar.Size = New System.Drawing.Size(89, 29)
Me.Cancelar.TabIndex = 3
Me.Cancelar.Text = "Cancelar"
Me.Cancelar.UseVisualStyleBackColor = False
'
'Aceptar
'
Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
Me.Aceptar.Location = New System.Drawing.Point(568, 27)
Me.Aceptar.Name = "Aceptar"
Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Aceptar.Size = New System.Drawing.Size(89, 30)
Me.Aceptar.TabIndex = 2
Me.Aceptar.Text = "Aceptar"
Me.Aceptar.UseVisualStyleBackColor = False
'
'cmdBorrar
'
Me.cmdBorrar.BackColor = System.Drawing.SystemColors.Control
Me.cmdBorrar.Cursor = System.Windows.Forms.Cursors.Default
Me.cmdBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdBorrar.ForeColor = System.Drawing.SystemColors.ControlText
Me.cmdBorrar.Location = New System.Drawing.Point(568, 312)
Me.cmdBorrar.Name = "cmdBorrar"
Me.cmdBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmdBorrar.Size = New System.Drawing.Size(89, 25)
Me.cmdBorrar.TabIndex = 1
Me.cmdBorrar.Text = "Borrar"
Me.cmdBorrar.UseVisualStyleBackColor = False
Me.cmdBorrar.Visible = False
'
'cmdAniadir
'
Me.cmdAniadir.BackColor = System.Drawing.SystemColors.Control
Me.cmdAniadir.Cursor = System.Windows.Forms.Cursors.Default
Me.cmdAniadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdAniadir.ForeColor = System.Drawing.SystemColors.ControlText
Me.cmdAniadir.Location = New System.Drawing.Point(568, 352)
Me.cmdAniadir.Name = "cmdAniadir"
Me.cmdAniadir.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmdAniadir.Size = New System.Drawing.Size(89, 25)
Me.cmdAniadir.TabIndex = 0
Me.cmdAniadir.Text = "Añadir"
Me.cmdAniadir.UseVisualStyleBackColor = False
Me.cmdAniadir.Visible = False
'
'VerAlbaranes
'
Me.VerAlbaranes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.VerAlbaranes.Location = New System.Drawing.Point(523, 118)
Me.VerAlbaranes.Name = "VerAlbaranes"
Me.VerAlbaranes.Size = New System.Drawing.Size(134, 32)
Me.VerAlbaranes.TabIndex = 6
Me.VerAlbaranes.Text = "Ver Albaranes"
Me.VerAlbaranes.UseVisualStyleBackColor = True
'
'btnVerAbono
'
Me.btnVerAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnVerAbono.Location = New System.Drawing.Point(523, 168)
Me.btnVerAbono.Name = "btnVerAbono"
Me.btnVerAbono.Size = New System.Drawing.Size(134, 32)
Me.btnVerAbono.TabIndex = 7
Me.btnVerAbono.Text = "Ver Abono"
Me.btnVerAbono.UseVisualStyleBackColor = True
'
'btnVerFactura
'
Me.btnVerFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.btnVerFactura.Location = New System.Drawing.Point(523, 220)
Me.btnVerFactura.Name = "btnVerFactura"
Me.btnVerFactura.Size = New System.Drawing.Size(134, 32)
Me.btnVerFactura.TabIndex = 8
Me.btnVerFactura.Text = "Ver Factura"
Me.btnVerFactura.UseVisualStyleBackColor = True
'
'Form_Facturas
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.BackColor = System.Drawing.SystemColors.Control
Me.ClientSize = New System.Drawing.Size(680, 507)
Me.Controls.Add(Me.btnVerFactura)
Me.Controls.Add(Me.btnVerAbono)
Me.Controls.Add(Me.VerAlbaranes)
Me.Controls.Add(Me.Marco)
Me.Controls.Add(Me.Cancelar)
Me.Controls.Add(Me.Aceptar)
Me.Controls.Add(Me.cmdBorrar)
Me.Controls.Add(Me.cmdAniadir)
Me.Cursor = System.Windows.Forms.Cursors.Default
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
Me.Location = New System.Drawing.Point(3, 22)
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "Form_Facturas"
Me.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.ShowInTaskbar = False
Me.Text = "Facturas"
Me.Marco.ResumeLayout(False)
Me.Marco.PerformLayout()
CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
#End Region

  Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
	Try
	  daFacturas = New SqlClient.SqlDataAdapter
	  daFacturas.UpdateCommand = New SqlClient.SqlCommand("MODIFICACION_FACTURA", DBConnection)
	  With daFacturas.UpdateCommand
		.CommandType = CommandType.StoredProcedure
		.Parameters.Add("@NumFactura", SqlDbType.BigInt)
		.Parameters.Item("@NumFactura").Value = CLng(Me.Text_Numero.Text.ToString)
		.Parameters.Add("@Cobrada", SqlDbType.BigInt)
		.Parameters.Item("@Cobrada").Value = CLng(Me.chkCobrada.Checked)
		.ExecuteNonQuery()
	  End With
	Catch ex As Exception
	  MsgBox("Error al modificar factura: " & ex.Message)
	  Throw (ex)
	Finally
	  MsgBox("Modificacion realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	  dtFacturas = Nothing
	  daFacturas = Nothing
	End Try
	Me.Hide()
	Me.Dispose()
  End Sub
  Public Sub PresentaFecha()
	Dim LimDias, i As Integer, EsBisiesto As Boolean
	Call CargaFecha()
	EsBisiesto = False

	If (CInt(cAnio.Text) Mod 4 = 0 And CInt(cAnio.Text) Mod 100 <> 0) Or _
	(CInt(cAnio.Text) Mod 400 = 0) Then EsBisiesto = True

	Select Case cMes.SelectedIndex
	  Case 10, 3, 5, 8
		LimDias = 30
	  Case 1
		If EsBisiesto Then
		  LimDias = 29
		Else
		  LimDias = 28
		End If
	  Case Else
		LimDias = 31
	End Select

	'cDia.Clear()

	For i = 1 To LimDias
	  cDia.Items.Insert(i - 1, Format(i, "00"))
	Next

	If CInt(Now().Day) - 1 < Me.cDia.Items.Count Then
	  Me.cDia.SelectedIndex = CInt(Now().Day) - 1
	Else
	  Me.cDia.SelectedIndex = Me.cDia.Items.Count - 1
	End If
  End Sub

  Private Sub CargaFecha()
	Dim i As Integer

	For i = 1999 To 2099
	  cAnio.Items.Insert(i - 1999, Format(i, "0000"))
	Next

	For i = 1 To 12
	  cMes.Items.Insert(i - 1, Format(i, "00"))
	Next
	Me.cAnio.SelectedIndex = CInt(Year(Now())) - 1999
	Me.cMes.SelectedIndex = CInt(Month(Now())) - 1
	'Call PresentaFecha()
  End Sub
  Private Sub Form_Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	Try
	  dtFacturas = New DataTable
	  daFacturas = New SqlClient.SqlDataAdapter()
	  daFacturas.SelectCommand = New SqlClient.SqlCommand("CONSULTA_FACTURA_VENTAS", DBConnection)
	  daFacturas.SelectCommand.CommandType = CommandType.StoredProcedure
	  daFacturas.SelectCommand.Parameters.Add("@NumFactura", SqlDbType.BigInt)
	  daFacturas.SelectCommand.Parameters("@NumFactura").Value = Me.NumFactura
	  daFacturas.Fill(dtFacturas)

	  Me.Text_Numero.Text = Me.NumFactura.ToString
	  Me.Text_Destino.Text = dtFacturas.Rows(0).Item("DESTINO")
	  Me.Text_Cliente.Text = dtFacturas.Rows(0).Item("NOMBRE")
	  Me.PresentaFecha()
	  Me.cAnio.SelectedIndex = dtFacturas.Rows(0).Item("FECHA_FACTURA").Year - 1999
	  Me.cMes.SelectedIndex = dtFacturas.Rows(0).Item("FECHA_FACTURA").Month - 1
	  Me.cDia.SelectedIndex = dtFacturas.Rows(0).Item("FECHA_FACTURA").Day - 1
	  If dtFacturas.Rows(0).Item("COBRADA") = True Then
		Me.chkCobrada.Checked = True
	  Else
		Me.chkCobrada.Checked = False
	  End If

	  dtDetalle = New DataTable
	  daDetalle = New SqlClient.SqlDataAdapter()
	  daDetalle.SelectCommand = New SqlClient.SqlCommand("CONSULTA_DETALLE_FACTURA", DBConnection)
	  daDetalle.SelectCommand.CommandType = CommandType.StoredProcedure
	  daDetalle.SelectCommand.Parameters.Add("@NumFactura", SqlDbType.BigInt)
	  daDetalle.SelectCommand.Parameters("@NumFactura").Value = Me.NumFactura
	  daDetalle.Fill(dtDetalle)

	  Me.dgFacturas.DataSource = Me.dtDetalle

	Catch ex As Exception
	  MsgBox("Error al cargar Factura: " & ex.Message)
	Finally
	End Try
  End Sub

  Private Sub Cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancelar.Click
    Me.Hide()
    Me.Dispose()
  End Sub

  Private Sub VerAlbaranes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerAlbaranes.Click
    Dim frmListadoAlbaranes As New Form_Listado_Albaranes
    Dim serverReport As ServerReport
    serverReport = frmListadoAlbaranes.AlbaranesViewer.ServerReport

        serverReport.ReportServerUrl =
       New Uri("http://ganimedes/reportserver")
        serverReport.ReportPath = _
       "/Borradores/Borradores por Numero Factura"

    'Create the report parameter
    Dim NumFactura As New ReportParameter()
    NumFactura.Name = "NumFactura"
    NumFactura.Values.Add(CLng(Me.NumFactura))

    'Set the report parameters for the report
    Dim parameters() As ReportParameter = {NumFactura}
    serverReport.SetParameters(parameters)

	frmListadoAlbaranes.ShowDialog()
	Me.Close()

  End Sub

Private Sub btnVerAbono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerAbono.Click
	Dim frmAbono As Form_Abono = New Form_Abono(Me.NumFactura)
	frmAbono.ShowDialog()
	Me.Close()
End Sub

Private Sub btnVerFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFactura.Click
	Dim frmFactura As Form_Factura = New Form_Factura(Me.NumFactura)
	frmFactura.ShowDialog()
	Me.Close()
End Sub
End Class