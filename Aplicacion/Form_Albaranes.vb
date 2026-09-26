Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class Form_Albaranes
  Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
  Public Sub New()
    MyBase.New()
    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()
    Me.Activar = True
    ActivarControles()
    AsignarControles()
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
  Public WithEvents cmdAniadir As System.Windows.Forms.Button
  Public WithEvents cmdBorrar As System.Windows.Forms.Button
  Public WithEvents cmdAceptar As System.Windows.Forms.Button
  Public WithEvents cmdCancelar As System.Windows.Forms.Button
  Public WithEvents chkFacturado As System.Windows.Forms.CheckBox
  Public WithEvents txtDestino As System.Windows.Forms.TextBox
	Public WithEvents cmbAnio As System.Windows.Forms.ComboBox
	Public WithEvents txtNumero As System.Windows.Forms.TextBox
	Public WithEvents lblCliente As System.Windows.Forms.Label
	Public WithEvents lblDestino As System.Windows.Forms.Label
	Public WithEvents lblSeparador1 As System.Windows.Forms.Label
	Public WithEvents lblSeparador2 As System.Windows.Forms.Label
	Public WithEvents lblFecha As System.Windows.Forms.Label
	Public WithEvents Label_Numero As System.Windows.Forms.Label
	Public WithEvents Marco As System.Windows.Forms.GroupBox
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	Friend WithEvents dcDestino As System.Windows.Forms.ComboBox
	Friend WithEvents dcClientes As System.Windows.Forms.ComboBox
 Public WithEvents cmbMes As System.Windows.Forms.ComboBox
 Public WithEvents cmbDia As System.Windows.Forms.ComboBox
	Friend WithEvents dgMateriales As System.Windows.Forms.DataGridView
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.cmdAniadir = New System.Windows.Forms.Button
Me.cmdBorrar = New System.Windows.Forms.Button
Me.cmdAceptar = New System.Windows.Forms.Button
Me.cmdCancelar = New System.Windows.Forms.Button
Me.Marco = New System.Windows.Forms.GroupBox
Me.cmbDia = New System.Windows.Forms.ComboBox
Me.cmbMes = New System.Windows.Forms.ComboBox
Me.dcClientes = New System.Windows.Forms.ComboBox
Me.dgMateriales = New System.Windows.Forms.DataGridView
Me.dcDestino = New System.Windows.Forms.ComboBox
Me.chkFacturado = New System.Windows.Forms.CheckBox
Me.txtDestino = New System.Windows.Forms.TextBox
Me.cmbAnio = New System.Windows.Forms.ComboBox
Me.txtNumero = New System.Windows.Forms.TextBox
Me.lblCliente = New System.Windows.Forms.Label
Me.lblDestino = New System.Windows.Forms.Label
Me.lblSeparador1 = New System.Windows.Forms.Label
Me.lblSeparador2 = New System.Windows.Forms.Label
Me.lblFecha = New System.Windows.Forms.Label
Me.Label_Numero = New System.Windows.Forms.Label
Me.Marco.SuspendLayout()
CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'cmdAniadir
'
Me.cmdAniadir.BackColor = System.Drawing.SystemColors.Control
Me.cmdAniadir.Cursor = System.Windows.Forms.Cursors.Default
Me.cmdAniadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdAniadir.ForeColor = System.Drawing.SystemColors.ControlText
Me.cmdAniadir.Location = New System.Drawing.Point(475, 329)
Me.cmdAniadir.Name = "cmdAniadir"
Me.cmdAniadir.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmdAniadir.Size = New System.Drawing.Size(89, 25)
Me.cmdAniadir.TabIndex = 11
Me.cmdAniadir.Text = "Añadir"
Me.cmdAniadir.UseVisualStyleBackColor = False
Me.cmdAniadir.Visible = False
'
'cmdBorrar
'
Me.cmdBorrar.BackColor = System.Drawing.SystemColors.Control
Me.cmdBorrar.Cursor = System.Windows.Forms.Cursors.Default
Me.cmdBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdBorrar.ForeColor = System.Drawing.SystemColors.ControlText
Me.cmdBorrar.Location = New System.Drawing.Point(475, 279)
Me.cmdBorrar.Name = "cmdBorrar"
Me.cmdBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmdBorrar.Size = New System.Drawing.Size(89, 25)
Me.cmdBorrar.TabIndex = 10
Me.cmdBorrar.Text = "Borrar"
Me.cmdBorrar.UseVisualStyleBackColor = False
Me.cmdBorrar.Visible = False
'
'cmdAceptar
'
Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
Me.cmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
Me.cmdAceptar.Location = New System.Drawing.Point(475, 25)
Me.cmdAceptar.Name = "cmdAceptar"
Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmdAceptar.Size = New System.Drawing.Size(89, 25)
Me.cmdAceptar.TabIndex = 7
Me.cmdAceptar.Text = "Aceptar"
Me.cmdAceptar.UseVisualStyleBackColor = False
'
'cmdCancelar
'
Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
Me.cmdCancelar.Location = New System.Drawing.Point(475, 69)
Me.cmdCancelar.Name = "cmdCancelar"
Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmdCancelar.Size = New System.Drawing.Size(89, 25)
Me.cmdCancelar.TabIndex = 9
Me.cmdCancelar.Text = "Cancelar"
Me.cmdCancelar.UseVisualStyleBackColor = False
'
'Marco
'
Me.Marco.BackColor = System.Drawing.SystemColors.Control
Me.Marco.Controls.Add(Me.cmbDia)
Me.Marco.Controls.Add(Me.cmbMes)
Me.Marco.Controls.Add(Me.dcClientes)
Me.Marco.Controls.Add(Me.dgMateriales)
Me.Marco.Controls.Add(Me.cmdAceptar)
Me.Marco.Controls.Add(Me.cmdCancelar)
Me.Marco.Controls.Add(Me.cmdBorrar)
Me.Marco.Controls.Add(Me.cmdAniadir)
Me.Marco.Controls.Add(Me.dcDestino)
Me.Marco.Controls.Add(Me.chkFacturado)
Me.Marco.Controls.Add(Me.txtDestino)
Me.Marco.Controls.Add(Me.cmbAnio)
Me.Marco.Controls.Add(Me.txtNumero)
Me.Marco.Controls.Add(Me.lblCliente)
Me.Marco.Controls.Add(Me.lblDestino)
Me.Marco.Controls.Add(Me.lblSeparador1)
Me.Marco.Controls.Add(Me.lblSeparador2)
Me.Marco.Controls.Add(Me.lblFecha)
Me.Marco.Controls.Add(Me.Label_Numero)
Me.Marco.Dock = System.Windows.Forms.DockStyle.Fill
Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
Me.Marco.Location = New System.Drawing.Point(10, 10)
Me.Marco.Name = "Marco"
Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Marco.Size = New System.Drawing.Size(580, 445)
Me.Marco.TabIndex = 0
Me.Marco.TabStop = False
Me.Marco.Text = "Albaranes"
'
'cmbDia
'
Me.cmbDia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbDia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbDia.BackColor = System.Drawing.SystemColors.Window
Me.cmbDia.Cursor = System.Windows.Forms.Cursors.Default
Me.cmbDia.ForeColor = System.Drawing.SystemColors.WindowText
Me.cmbDia.Location = New System.Drawing.Point(136, 192)
Me.cmbDia.Name = "cmbDia"
Me.cmbDia.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmbDia.Size = New System.Drawing.Size(49, 28)
Me.cmbDia.TabIndex = 6
'
'cmbMes
'
Me.cmbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.cmbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.cmbMes.BackColor = System.Drawing.SystemColors.Window
Me.cmbMes.Cursor = System.Windows.Forms.Cursors.Default
Me.cmbMes.ForeColor = System.Drawing.SystemColors.WindowText
Me.cmbMes.Location = New System.Drawing.Point(212, 192)
Me.cmbMes.Name = "cmbMes"
Me.cmbMes.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmbMes.Size = New System.Drawing.Size(49, 28)
Me.cmbMes.TabIndex = 5
'
'dcClientes
'
Me.dcClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.dcClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.dcClientes.FormattingEnabled = True
Me.dcClientes.Location = New System.Drawing.Point(136, 87)
Me.dcClientes.Name = "dcClientes"
Me.dcClientes.Size = New System.Drawing.Size(288, 28)
Me.dcClientes.TabIndex = 22
'
'dgMateriales
'
Me.dgMateriales.AllowUserToAddRows = False
Me.dgMateriales.AllowUserToDeleteRows = False
Me.dgMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
Me.dgMateriales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
Me.dgMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
Me.dgMateriales.Location = New System.Drawing.Point(20, 279)
Me.dgMateriales.Name = "dgMateriales"
Me.dgMateriales.ReadOnly = True
Me.dgMateriales.Size = New System.Drawing.Size(439, 150)
Me.dgMateriales.TabIndex = 21
'
'dcDestino
'
Me.dcDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
Me.dcDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
Me.dcDestino.DisplayMember = "DESTINO"
Me.dcDestino.Location = New System.Drawing.Point(136, 136)
Me.dcDestino.Name = "dcDestino"
Me.dcDestino.Size = New System.Drawing.Size(288, 28)
Me.dcDestino.TabIndex = 3
'
'chkFacturado
'
Me.chkFacturado.BackColor = System.Drawing.SystemColors.Control
Me.chkFacturado.Cursor = System.Windows.Forms.Cursors.Default
Me.chkFacturado.ForeColor = System.Drawing.SystemColors.ControlText
Me.chkFacturado.Location = New System.Drawing.Point(20, 240)
Me.chkFacturado.Name = "chkFacturado"
Me.chkFacturado.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.chkFacturado.Size = New System.Drawing.Size(113, 33)
Me.chkFacturado.TabIndex = 7
Me.chkFacturado.Text = "Facturado"
Me.chkFacturado.UseVisualStyleBackColor = False
'
'txtDestino
'
Me.txtDestino.AcceptsReturn = True
Me.txtDestino.BackColor = System.Drawing.SystemColors.Window
Me.txtDestino.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtDestino.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtDestino.Location = New System.Drawing.Point(136, 136)
Me.txtDestino.MaxLength = 0
Me.txtDestino.Name = "txtDestino"
Me.txtDestino.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtDestino.Size = New System.Drawing.Size(289, 26)
Me.txtDestino.TabIndex = 19
Me.txtDestino.Visible = False
'
'cmbAnio
'
Me.cmbAnio.BackColor = System.Drawing.SystemColors.Window
Me.cmbAnio.Cursor = System.Windows.Forms.Cursors.Default
Me.cmbAnio.ForeColor = System.Drawing.SystemColors.WindowText
Me.cmbAnio.Location = New System.Drawing.Point(304, 192)
Me.cmbAnio.Name = "cmbAnio"
Me.cmbAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cmbAnio.Size = New System.Drawing.Size(65, 28)
Me.cmbAnio.TabIndex = 4
'
'txtNumero
'
Me.txtNumero.AcceptsReturn = True
Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
Me.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
Me.txtNumero.Enabled = False
Me.txtNumero.ForeColor = System.Drawing.SystemColors.WindowText
Me.txtNumero.Location = New System.Drawing.Point(136, 37)
Me.txtNumero.MaxLength = 0
Me.txtNumero.Name = "txtNumero"
Me.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.txtNumero.Size = New System.Drawing.Size(57, 26)
Me.txtNumero.TabIndex = 1
'
'lblCliente
'
Me.lblCliente.BackColor = System.Drawing.SystemColors.Control
Me.lblCliente.Cursor = System.Windows.Forms.Cursors.Default
Me.lblCliente.ForeColor = System.Drawing.SystemColors.ControlText
Me.lblCliente.Location = New System.Drawing.Point(16, 87)
Me.lblCliente.Name = "lblCliente"
Me.lblCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.lblCliente.Size = New System.Drawing.Size(89, 25)
Me.lblCliente.TabIndex = 17
Me.lblCliente.Text = "Cliente"
'
'lblDestino
'
Me.lblDestino.BackColor = System.Drawing.SystemColors.Control
Me.lblDestino.Cursor = System.Windows.Forms.Cursors.Default
Me.lblDestino.ForeColor = System.Drawing.SystemColors.ControlText
Me.lblDestino.Location = New System.Drawing.Point(16, 144)
Me.lblDestino.Name = "lblDestino"
Me.lblDestino.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.lblDestino.Size = New System.Drawing.Size(89, 25)
Me.lblDestino.TabIndex = 16
Me.lblDestino.Text = "Destino"
'
'lblSeparador1
'
Me.lblSeparador1.BackColor = System.Drawing.SystemColors.Control
Me.lblSeparador1.Cursor = System.Windows.Forms.Cursors.Default
Me.lblSeparador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSeparador1.ForeColor = System.Drawing.SystemColors.ControlText
Me.lblSeparador1.Location = New System.Drawing.Point(191, 192)
Me.lblSeparador1.Margin = New System.Windows.Forms.Padding(0)
Me.lblSeparador1.Name = "lblSeparador1"
Me.lblSeparador1.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.lblSeparador1.Size = New System.Drawing.Size(18, 28)
Me.lblSeparador1.TabIndex = 15
Me.lblSeparador1.Text = "/"
Me.lblSeparador1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
'
'lblSeparador2
'
Me.lblSeparador2.BackColor = System.Drawing.SystemColors.Control
Me.lblSeparador2.Cursor = System.Windows.Forms.Cursors.Default
Me.lblSeparador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.lblSeparador2.ForeColor = System.Drawing.SystemColors.ControlText
Me.lblSeparador2.Location = New System.Drawing.Point(279, 192)
Me.lblSeparador2.Margin = New System.Windows.Forms.Padding(0)
Me.lblSeparador2.Name = "lblSeparador2"
Me.lblSeparador2.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.lblSeparador2.Size = New System.Drawing.Size(18, 28)
Me.lblSeparador2.TabIndex = 14
Me.lblSeparador2.Text = "/"
Me.lblSeparador2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
'
'lblFecha
'
Me.lblFecha.BackColor = System.Drawing.SystemColors.Control
Me.lblFecha.Cursor = System.Windows.Forms.Cursors.Default
Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText
Me.lblFecha.Location = New System.Drawing.Point(16, 195)
Me.lblFecha.Name = "lblFecha"
Me.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.lblFecha.Size = New System.Drawing.Size(89, 25)
Me.lblFecha.TabIndex = 13
Me.lblFecha.Text = "Fecha"
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
Me.Label_Numero.TabIndex = 12
Me.Label_Numero.Text = "Número"
'
'Form_Albaranes
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.BackColor = System.Drawing.SystemColors.Control
Me.ClientSize = New System.Drawing.Size(600, 465)
Me.Controls.Add(Me.Marco)
Me.Cursor = System.Windows.Forms.Cursors.Default
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
Me.Location = New System.Drawing.Point(3, 22)
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "Form_Albaranes"
Me.Padding = New System.Windows.Forms.Padding(10)
Me.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.ShowInTaskbar = False
Me.Text = "Albaranes"
Me.Marco.ResumeLayout(False)
Me.Marco.PerformLayout()
CType(Me.dgMateriales, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
#End Region
#Region "Propiedades"
	Private ActivarEdicion As Boolean
	Public Property Activar() As Boolean
		Get
			Return ActivarEdicion
		End Get
		Set(ByVal value As Boolean)
			ActivarEdicion = value
		End Set
	End Property
	Private NomCli As String
	Public Property Nombre() As String
		Get
			Return NomCli
		End Get
		Set(ByVal value As String)
			NomCli = value
		End Set
	End Property
	Private NumAlbaran As Long = -1
	Public Property Numero() As Long
		Get
			Return NumAlbaran
		End Get
		Set(ByVal value As Long)
			NumAlbaran = value
		End Set
	End Property
	Private Obra As String
	Public Property Destino() As String
		Get
			Return Obra
		End Get
		Set(ByVal value As String)
			Obra = value
		End Set
	End Property
	Private Fecha As Date
	Public Property FechaAlbaran() As Date
		Get
			Return Fecha
		End Get
		Set(ByVal value As Date)
			Fecha = value
		End Set
	End Property
	Private EnFactura As Boolean
    Public Property Facturado() As Boolean
        Get
            Return EnFactura
        End Get
        Set(ByVal value As Boolean)
            EnFactura = value
        End Set
    End Property
    Private Precio_Venta As Single
    Public Property PrecioVenta() As Single
        Get
            Return Precio_Venta
        End Get
        Set(ByVal value As Single)
            Precio_Venta = value
        End Set
    End Property
    Private Unidades As Single
	Public Property Cantidad() As Single
		Get
			Return Unidades
		End Get
		Set(ByVal value As Single)
			Unidades = value
		End Set
	End Property
	Private CodCliente As Long
	Public Property CodCli() As Long
		Get
			Return CodCliente
		End Get
		Set(ByVal value As Long)
			CodCliente = value
		End Set
	End Property
	Private CodMaterial As Long
	Public Property CodMat() As Long
		Get
			Return CodMaterial
		End Get
		Set(ByVal value As Long)
			CodMaterial = value
		End Set
	End Property
	Private NuevoNumero As Long
	Public Property NuevoNumAlbaran() As Long
		Get
			Return NuevoNumero
		End Get
		Set(ByVal value As Long)
			NuevoNumero = value
		End Set
	End Property
	Private FechaFact As Date
	Public Property FechaFactura() As Date
		Get
			Return FechaFact
		End Get
		Set(ByVal value As Date)
			FechaFact = value
		End Set
	End Property
	Private NumeroFactura As Long
	Public Property NumFactura() As Long
		Get
			Return NumeroFactura
		End Get
		Set(ByVal value As Long)
			NumeroFactura = value
		End Set
	End Property
#End Region
	Private Preguntar As Boolean = False
		Private dtClientes, dtAlbaranes, dtDestinos As DataTable
		Private daClientes, daAlbaranes, daDestinos As SqlClient.SqlDataAdapter
	Protected Overrides Sub Finalize()
		dtClientes = Nothing
		daClientes = Nothing
		dtAlbaranes = Nothing
		daAlbaranes = Nothing
	End Sub
	Public Sub New(ByVal NumeroAlbaran As Long)
		MyBase.New()
		'El Diseñador de Windows Forms requiere esta llamada.
		InitializeComponent()
		Me.NumAlbaran = NumeroAlbaran
		dtAlbaranes = ConsultaAlbaran()
		AsignarPropiedades(dtAlbaranes)
		AsignarControles()
		If Not (Modificacion_Albaran) Then
			Activar = False
		Else
			Activar = True
		End If
		ActivarControles()
	End Sub
	Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		Dim Error_Code As Short
		If Alta_Albaran Then
			Error_Code = ValidarCampos()
			If Error_Code = 0 Then
				Me.NumAlbaran = CLng(Me.txtNumero.Text)
				If Not ExisteAlbaran() Then
					AsignarValoresUsuario()
					Dim frmCantidad As Form_Cantidad = New Form_Cantidad()
					frmCantidad.Owner = Me
					frmCantidad.ShowDialog()
				Else
					MessageBox.Show("Este número de albarán ya existe", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
				End If
			Else
				Call CompruebaError(Error_Code)
			End If
		Else
			If Baja_Albaran Then
				Call BajaAlbaran()
				Baja_Albaran = False
				Me.Close()
			Else
				If Modificacion_Albaran Then
					ValidarCampos()
					AsignarValoresUsuario()
					Call ModificacionAlbaran()
					Modificacion_Albaran = False
					Me.Close()
				Else
					If Consulta_Albaran Then
						Consulta_Albaran = False
						Me.Close()
					End If
				End If
			End If
		End If
	End Sub
	Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		If Not Consulta_Albaran Then Preguntar = True
		Me.Close()
	End Sub
	Private Sub cmdAniadir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAniadir.Click
		Dim frmCantidad As Form_Cantidad = New Form_Cantidad()
		frmCantidad.Owner = Me
		frmCantidad.ShowDialog()
	End Sub
	Private Sub cmdBorrar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBorrar.Click
		Dim Error_Code As Short
		On Error GoTo HayError
		Error_Code = ValidarCampos()
		If Error_Code = 0 Then
			If ExisteAlbaran() Then
				Dim Descripcion As String
				Descripcion = Me.dgMateriales.Item(1, Me.dgMateriales.CurrentRow.Index).Value
				BorrarLinea(Descripcion)
				If ExisteAlbaran() Then
					AsignarPropiedades(ConsultaAlbaran())
					AsignarControles()
				Else
					Me.Close()
				End If
			Else
				MsgBox("Este número de albarán no existe", MsgBoxStyle.OkOnly, "Facturas")
			End If
		Else
			Call CompruebaError(Error_Code)
		End If

		Exit Sub
HayError:
		MsgBox("Error " & vbCrLf & Err.Description & vbCrLf & Me.Name)
	End Sub
	Private Sub cMes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
		Call PresentaFecha()
	End Sub
	Private Sub Form_Albaranes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If Alta_Albaran Then
			With Me
				'.dgMateriales.Visible = False
				'.Marco.Height = VB6.TwipsToPixelsY(4215)
				'.Height = VB6.TwipsToPixelsY(5055)
				.dcDestino.Visible = True
				.txtDestino.Visible = False
			End With
		End If
	End Sub
	Private Sub PresentaFecha()

		Dim LimDias As Short = 0
		Dim i As Short
		Dim EsBisiesto As Boolean

		'Solo llenamos los combo si es la primera vez y no estamos actualizando con la fecha del albaran
		If cmbAnio.Items.Count = 0 Then
			For i = 1999 To 2099
				cmbAnio.Items.Add(i.ToString.PadLeft(4, "0"))
			Next
			Me.cmbAnio.SelectedIndex = Today.Year - 1999
		End If

		EsBisiesto = False

		If (((CShort(cmbAnio.Text)) Mod 4) = 0) And ((CShort(cmbAnio.Text) Mod 100 <> 0)) _
		Or ((CShort(cmbAnio.Text) Mod 400) = 0) Then
			EsBisiesto = True
		End If

		If cmbMes.Items.Count = 0 Then
			For i = 1 To 12
				cmbMes.Items.Add(i.ToString.PadLeft(2, "0"))
			Next
			Me.cmbMes.SelectedIndex = Today.Month - 1
		End If

		Select Case CShort(cmbMes.SelectedIndex)
			Case 10, 3, 5, 8 'Noviembre, Marzo, Mayo y Septiembre 'Nº mes - 1
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

		cmbDia.Items.Clear()

		For i = 1 To LimDias
			cmbDia.Items.Add(i.ToString.PadLeft(2, "0"))
		Next

		If Today.Day - 1 < Me.cmbDia.Items.Count Then
			Me.cmbDia.SelectedIndex = Today.Day - 1
		Else
			Me.cmbDia.SelectedIndex = Me.cmbDia.Items.Count - 1
		End If
	End Sub

	Private Sub Form_Albaranes_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim OK As MsgBoxResult
		If Preguntar Then
			OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
			If OK = MsgBoxResult.Yes Then
				If Alta_Albaran Then
					Alta_Albaran = False
				End If
			Else
				eventArgs.Cancel = True
			End If
		End If
		If Alta_Albaran Then Alta_Albaran = False
		If Baja_Albaran Then Baja_Albaran = False
		If Modificacion_Albaran Then Modificacion_Albaran = False
		If Consulta_Albaran Then Consulta_Albaran = False
		Aplicacion.frmMain.Focus()
	End Sub
	Public Sub LimpiarCampos()
		With Me
			.txtDestino.Text = ""
			.dcDestino.Text = ""
			.chkFacturado.CheckState = False
			.txtNumero.Text = ""
			.dcClientes.Text = ""
		End With
	End Sub
	Public Sub AsignarValoresUsuario()
		Try
			Me.CodCli = Me.dcClientes.SelectedValue
			If Me.NumAlbaran <> CLng(Me.txtNumero.Text) Then
				Me.NuevoNumAlbaran = CLng(Me.txtNumero.Text)
			Else
				Me.NuevoNumAlbaran = Me.NumAlbaran
			End If
			If Alta_Albaran Then
				Me.Destino = Me.dcDestino.SelectedValue
			Else
				Me.Destino = Me.txtDestino.Text
			End If
			Me.FechaAlbaran = _
					CDate(CStr(Me.cmbDia.SelectedIndex + 1) + "-" _
					+ CStr(Me.cmbMes.SelectedIndex + 1) + "-" _
					+ CStr(Me.cmbAnio.SelectedIndex + 1999))
			If Me.chkFacturado.Checked = True Then
				Me.Facturado = True
			Else
				Me.Facturado = False
			End If
		Catch ex As Exception
			MsgBox("Error al cargar Albaranes: " & ex.Message)
		End Try
	End Sub
	Public Sub AsignarPropiedades(ByVal dsAlbaran As DataTable)
		Try
			With dtAlbaranes.Rows(0)
				Me.CodCli = .Item("Cod_Cli")
				Me.Nombre = .Item("Nombre")
				Me.NumAlbaran = .Item("Numero")
				Me.txtDestino.Visible = True
				Me.dcDestino.Visible = False
				Me.Destino = .Item("Destino")
				Me.FechaAlbaran = .Item("Fecha_Albaran")
				Me.Facturado = .Item("Facturado")
			End With
		Catch ex As Exception
			MsgBox("Error al cargar Albaranes: " & ex.Message)
		End Try
	End Sub
	Public Function ValidarCampos() As Short
		With Me
			If ((.dcDestino.SelectedValue = Nothing) And Alta_Albaran) Or _
				((.txtDestino.Text = "") And Not Alta_Albaran) Then
				ValidarCampos = 1004
			Else
				If .dcClientes.SelectedValue = Nothing Then
					ValidarCampos = 1005
				Else
					If .txtNumero.Text = "" Then
						ValidarCampos = 1006
					Else
						If Not IsNumeric(.txtNumero.Text) Then
							ValidarCampos = 1007
						Else
							ValidarCampos = 0
						End If
					End If
				End If
			End If
		End With
	End Function
	Public Sub ActivarControles()
		With Me
			.cmbAnio.Enabled = Me.Activar
			.cmbDia.Enabled = Me.Activar
			.cmbMes.Enabled = Me.Activar
			.txtNumero.Enabled = Me.Activar
			.dcClientes.Enabled = Me.Activar
			.txtDestino.Enabled = Me.Activar
			.chkFacturado.Enabled = Me.Activar
			.dgMateriales.Enabled = Me.Activar
			If Modificacion_Albaran Then
				.cmdAniadir.Visible = True
				.cmdBorrar.Visible = True
			End If
		End With
	End Sub

	Public Function ConsultaAlbaran() As DataTable
		daAlbaranes = New SqlDataAdapter
		dtAlbaranes = New DataTable
		Try
			daAlbaranes.SelectCommand = New SqlClient.SqlCommand("CONSULTA_ALBARAN", DBConnection)
			daAlbaranes.SelectCommand.CommandType = CommandType.StoredProcedure
			daAlbaranes.SelectCommand.Parameters.Add("@NumAlbaran", SqlDbType.BigInt)
			daAlbaranes.SelectCommand.Parameters("@NumAlbaran").Value = Me.NumAlbaran
			daAlbaranes.SelectCommand.ExecuteNonQuery()
			daAlbaranes.Fill(dtAlbaranes)
			Return dtAlbaranes
		Catch ex As Exception
			MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return Nothing
		Finally
			daAlbaranes.Dispose()
			daAlbaranes = Nothing
		End Try
	End Function
	Public Sub AsignarControles()

		Call PresentaFecha()
		Try
			daClientes = New SqlDataAdapter
			dtClientes = New DataTable
			daClientes.SelectCommand = New SqlClient.SqlCommand("CONSULTA_CLIENTES", DBConnection)
			daClientes.SelectCommand.CommandType = CommandType.StoredProcedure
			daClientes.Fill(dtClientes)

			Me.dcClientes.DataSource = dtClientes
			Me.dcClientes.DisplayMember = "NOMBRE"
			Me.dcClientes.ValueMember = "COD_CLI"

			daDestinos = New SqlDataAdapter
			dtDestinos = New DataTable
			daDestinos.SelectCommand = New SqlClient.SqlCommand("CONSULTA_DESTINOS", DBConnection)
			daDestinos.SelectCommand.CommandType = CommandType.StoredProcedure
			daDestinos.Fill(dtDestinos)

			Me.dcDestino.DataSource = dtDestinos
			Me.dcDestino.DisplayMember = "DESTINO"
			Me.dcDestino.ValueMember = "DESTINO"

			If ExisteAlbaran() Then
				daAlbaranes = New SqlDataAdapter
				dtAlbaranes = New DataTable
				daAlbaranes.SelectCommand = New SqlClient.SqlCommand("CONSULTA_DESCRIPCION", DBConnection)
				daAlbaranes.SelectCommand.CommandType = CommandType.StoredProcedure
				daAlbaranes.SelectCommand.Parameters.Add("@NumAlbaran", SqlDbType.BigInt)
				daAlbaranes.SelectCommand.Parameters("@NumAlbaran").Value = Me.NumAlbaran
				daAlbaranes.Fill(dtAlbaranes)

				Me.dgMateriales.DataSource = dtAlbaranes
				Me.dgMateriales.MultiSelect = False
				Me.dgMateriales.AutoResizeColumns()
				Me.dgMateriales.Refresh()

				Me.dcClientes.SelectedIndex = Me.dcClientes.FindString(Me.Nombre)
				Me.txtNumero.Text = CStr(Me.Numero)
				Me.txtDestino.Visible = True
				Me.dcDestino.Visible = False
				Me.txtDestino.Text = Me.Destino
				Me.cmbAnio.SelectedIndex = Year(Me.FechaAlbaran) - 1999
				Me.cmbMes.SelectedIndex = Month(Me.FechaAlbaran) - 1
				Me.cmbDia.SelectedIndex = Me.FechaAlbaran.Day - 1
				If Me.Facturado Then
					Me.chkFacturado.CheckState = CheckState.Checked
				Else
					Me.chkFacturado.CheckState = CheckState.Unchecked
				End If
			End If
		Catch ex As Exception
			MsgBox("Error al cargar Albaranes: " & ex.Message)
		Finally
		End Try

	End Sub
  Public Sub BorrarLinea(ByVal Descripcion As String)
	Dim cmdBorrarLinea As SqlCommand = New SqlCommand("BORRAR_ALBARAN", DBConnection)
	Try
	  cmdBorrarLinea.CommandType = CommandType.StoredProcedure
	  cmdBorrarLinea.Parameters.Add("@Descripcion", SqlDbType.NVarChar)
	  cmdBorrarLinea.Parameters.Item("@Descripcion").Value = Descripcion

	  cmdBorrarLinea.Parameters.Add("@NumAlbaran", SqlDbType.BigInt)
	  cmdBorrarLinea.Parameters.Item("@NumAlbaran").Value = Me.NumAlbaran
	  cmdBorrarLinea.ExecuteNonQuery()
	Catch ex As Exception
	  MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	  cmdBorrarLinea.Dispose()
	  cmdBorrarLinea = Nothing
	End Try
  End Sub
  Public Sub BajaAlbaran()
	Dim cmdBajaAlbaran As SqlClient.SqlCommand = New SqlClient.SqlCommand("BAJA_ALBARAN", DBConnection)
	Try
	  With cmdBajaAlbaran
		.CommandType = CommandType.StoredProcedure
		.Parameters.Add("@NumAlbaran", SqlDbType.BigInt)
		.Parameters.Item("@NumAlbaran").Value = Me.NumAlbaran
		.ExecuteNonQuery()
	  End With
	Catch ex As Exception
	  MsgBox("Error al eliminar albarán: " & ex.Message)
	  Throw (ex)
	Finally
	  MsgBox("Baja realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	  cmdBajaAlbaran.Dispose()
	  cmdBajaAlbaran = Nothing
	End Try
  End Sub
  Public Function ExisteAlbaran() As Boolean
	Dim cmdAlbaran As SqlCommand = _
	New SqlClient.SqlCommand("SELECT [Facturas].[dbo].[ExisteAlbaran] (@NumAlbaran)", DBConnection)
	Try
	  With cmdAlbaran
		.CommandType = CommandType.Text
		.Parameters.Add("@NumAlbaran", SqlDbType.BigInt)
		.Parameters.Item("@NumAlbaran").Value = Me.NumAlbaran
	  End With
	  If CType(cmdAlbaran.ExecuteScalar, Integer) = 0 Then
		Return False
	  Else
		Return True
	  End If
	Catch ex As Exception
	  MsgBox("Error: " & ex.ToString)
	Finally
	  cmdAlbaran.Dispose()
	  cmdAlbaran = Nothing
	End Try
  End Function
    Public Sub AsignarMaterial(ByVal Cantidad As Single, ByVal CodMat As Long, ByVal PrecioVenta As Single)

        Me.Cantidad = Cantidad
        Me.CodMat = CodMat
        Me.PrecioVenta = PrecioVenta
    End Sub
    Public Sub AltaAlbaran()
	Dim cmdAltaAlbaran As SqlCommand = New SqlCommand("ALTA_ALBARAN", DBConnection)
	Try
	  With cmdAltaAlbaran
		.CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@COD_CLI", SqlDbType.BigInt)
                    .Item("@COD_CLI").Value = Me.CodCli
                    .Add("@NUMERO", SqlDbType.BigInt)
                    .Item("@NUMERO").Value = Me.Numero
                    .Add("@COD_MAT", SqlDbType.BigInt)
                    .Item("@COD_MAT").Value = Me.CodMat
                    .Add("@CANTIDAD", SqlDbType.Decimal)
                    .Item("@CANTIDAD").Value = Me.Cantidad
                    .Add("@DESTINO", SqlDbType.NVarChar)
                    .Item("@DESTINO").Value = Me.Destino
                    .Add("@FECHA_ALBARAN", SqlDbType.DateTime)
                    .Item("@FECHA_ALBARAN").Value = Me.FechaAlbaran
                    .Add("@PRECIO_VENTA", SqlDbType.Decimal)
                    If Me.CodMat = 30 Then
                        .Item("@PRECIO_VENTA").Value = Me.PrecioVenta
                    Else
                        .Item("@PRECIO_VENTA").Value = DBNull.Value
                    End If
                End With
                .ExecuteNonQuery()
			MessageBox.Show("Alta realizada con éxito", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information, _
		MessageBoxDefaultButton.Button1)
	End With
	Catch ex As Exception
	  MessageBox.Show("Error al crear albaran: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	  cmdAltaAlbaran.Dispose()
	  cmdAltaAlbaran = Nothing
	End Try
  End Sub
  Public Sub CompruebaError(ByVal Error_Code As Short)
	If Error_Code = 1004 Then
	  MsgBox("El destino no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
	Else
	  If Error_Code = 1005 Then
		MsgBox("El cliente no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
	  Else
		If Error_Code = 1006 Then
		  MsgBox("El número de albarán no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
		Else
		  If Error_Code = 1007 Then
			MsgBox("El número de albarán debe ser un número")
		  End If
		End If
	  End If
	End If
  End Sub
  Public Sub ModificacionAlbaran()
	Dim cmdUpdAlbaran As SqlCommand = New SqlCommand("MODIFICACION_ALBARAN", DBConnection)
	Try
	  With cmdUpdAlbaran
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@COD_CLI", SqlDbType.BigInt)
			.Item("@COD_CLI").Value = Me.CodCli
			.Add("@NUMERO", SqlDbType.BigInt)
		  .Item("@NUMERO").Value = Me.Numero
			.Add("@NUEVONUMERO", SqlDbType.BigInt)
		  .Item("@NUEVONUMERO").Value = Me.NuevoNumAlbaran
		  .Add("@DESTINO", SqlDbType.NVarChar)
		  .Item("@DESTINO").Value = Me.Destino
		  .Add("@FECHA_ALBARAN", SqlDbType.DateTime)
		  .Item("@FECHA_ALBARAN").Value = Me.FechaAlbaran
			.Add("@FACTURADO", SqlDbType.Bit)
		  .Item("@FACTURADO").Value = Me.Facturado
		End With
		.ExecuteNonQuery()
		MessageBox.Show("Modificación realizada con éxito", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
	  End With
	Catch ex As Exception
	  MessageBox.Show("Error al modificar albaran: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	  cmdUpdAlbaran.Dispose()
	  cmdUpdAlbaran = Nothing
	End Try
  End Sub

Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
	PresentaFecha()
End Sub
End Class