Option Strict Off
Option Explicit On
Friend Class Form_Clientes
  Inherits System.Windows.Forms.Form

#Region "Código generado por el Diseñador de Windows Forms "
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
  Public WithEvents Text_Telefono As System.Windows.Forms.TextBox
  Public WithEvents Text_Localidad As System.Windows.Forms.TextBox
  Public WithEvents Text_CodPostal As System.Windows.Forms.TextBox
  Public WithEvents Text_Direccion As System.Windows.Forms.TextBox
  Public WithEvents Text_NIF As System.Windows.Forms.TextBox
  Public WithEvents Text_Nombre As System.Windows.Forms.TextBox
  Public WithEvents Text_Codigo As System.Windows.Forms.TextBox
  Public WithEvents Label_Codigo As System.Windows.Forms.Label
  Public WithEvents Label_Nombre As System.Windows.Forms.Label
  Public WithEvents Label_NIF As System.Windows.Forms.Label
  Public WithEvents Label_Direccion As System.Windows.Forms.Label
  Public WithEvents Label_CodPostal As System.Windows.Forms.Label
  Public WithEvents Label_Localidad As System.Windows.Forms.Label
  Public WithEvents Label_Telefono As System.Windows.Forms.Label
  Public WithEvents Marco As System.Windows.Forms.GroupBox
  Public WithEvents Aceptar As System.Windows.Forms.Button
  Public WithEvents Cancelar As System.Windows.Forms.Button
  'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
  'Se puede modificar mediante el Diseñador de Windows Forms.
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Marco = New System.Windows.Forms.GroupBox
    Me.Text_Telefono = New System.Windows.Forms.TextBox
    Me.Text_Localidad = New System.Windows.Forms.TextBox
    Me.Text_CodPostal = New System.Windows.Forms.TextBox
    Me.Text_Direccion = New System.Windows.Forms.TextBox
    Me.Text_NIF = New System.Windows.Forms.TextBox
    Me.Text_Nombre = New System.Windows.Forms.TextBox
    Me.Text_Codigo = New System.Windows.Forms.TextBox
    Me.Label_Codigo = New System.Windows.Forms.Label
    Me.Label_Nombre = New System.Windows.Forms.Label
    Me.Label_NIF = New System.Windows.Forms.Label
    Me.Label_Direccion = New System.Windows.Forms.Label
    Me.Label_CodPostal = New System.Windows.Forms.Label
    Me.Label_Localidad = New System.Windows.Forms.Label
    Me.Label_Telefono = New System.Windows.Forms.Label
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Marco.SuspendLayout()
    Me.SuspendLayout()
    '
    'Marco
    '
    Me.Marco.BackColor = System.Drawing.SystemColors.Control
    Me.Marco.Controls.Add(Me.Text_Telefono)
    Me.Marco.Controls.Add(Me.Text_Localidad)
    Me.Marco.Controls.Add(Me.Text_CodPostal)
    Me.Marco.Controls.Add(Me.Text_Direccion)
    Me.Marco.Controls.Add(Me.Text_NIF)
    Me.Marco.Controls.Add(Me.Text_Nombre)
    Me.Marco.Controls.Add(Me.Text_Codigo)
    Me.Marco.Controls.Add(Me.Label_Codigo)
    Me.Marco.Controls.Add(Me.Label_Nombre)
    Me.Marco.Controls.Add(Me.Label_NIF)
    Me.Marco.Controls.Add(Me.Label_Direccion)
    Me.Marco.Controls.Add(Me.Label_CodPostal)
    Me.Marco.Controls.Add(Me.Label_Localidad)
    Me.Marco.Controls.Add(Me.Label_Telefono)
    Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco.Location = New System.Drawing.Point(16, 8)
    Me.Marco.Name = "Marco"
    Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco.Size = New System.Drawing.Size(537, 329)
    Me.Marco.TabIndex = 2
    Me.Marco.TabStop = False
    Me.Marco.Text = "Clientes"
    '
    'Text_Telefono
    '
    Me.Text_Telefono.AcceptsReturn = True
    Me.Text_Telefono.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Telefono.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Telefono.Location = New System.Drawing.Point(208, 288)
    Me.Text_Telefono.MaxLength = 0
    Me.Text_Telefono.Name = "Text_Telefono"
    Me.Text_Telefono.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Telefono.Size = New System.Drawing.Size(129, 26)
    Me.Text_Telefono.TabIndex = 9
    Me.Text_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Text_Localidad
    '
    Me.Text_Localidad.AcceptsReturn = True
    Me.Text_Localidad.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Localidad.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Localidad.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Localidad.Location = New System.Drawing.Point(208, 248)
    Me.Text_Localidad.MaxLength = 0
    Me.Text_Localidad.Name = "Text_Localidad"
    Me.Text_Localidad.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Localidad.Size = New System.Drawing.Size(297, 26)
    Me.Text_Localidad.TabIndex = 8
    '
    'Text_CodPostal
    '
    Me.Text_CodPostal.AcceptsReturn = True
    Me.Text_CodPostal.BackColor = System.Drawing.SystemColors.Window
    Me.Text_CodPostal.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_CodPostal.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_CodPostal.Location = New System.Drawing.Point(208, 208)
    Me.Text_CodPostal.MaxLength = 0
    Me.Text_CodPostal.Name = "Text_CodPostal"
    Me.Text_CodPostal.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_CodPostal.Size = New System.Drawing.Size(81, 26)
    Me.Text_CodPostal.TabIndex = 7
    Me.Text_CodPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Text_Direccion
    '
    Me.Text_Direccion.AcceptsReturn = True
    Me.Text_Direccion.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Direccion.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Direccion.Location = New System.Drawing.Point(208, 160)
    Me.Text_Direccion.MaxLength = 0
    Me.Text_Direccion.Name = "Text_Direccion"
    Me.Text_Direccion.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Direccion.Size = New System.Drawing.Size(297, 26)
    Me.Text_Direccion.TabIndex = 6
    '
    'Text_NIF
    '
    Me.Text_NIF.AcceptsReturn = True
    Me.Text_NIF.BackColor = System.Drawing.SystemColors.Window
    Me.Text_NIF.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_NIF.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_NIF.Location = New System.Drawing.Point(208, 120)
    Me.Text_NIF.MaxLength = 0
    Me.Text_NIF.Name = "Text_NIF"
    Me.Text_NIF.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_NIF.Size = New System.Drawing.Size(129, 26)
    Me.Text_NIF.TabIndex = 5
    '
    'Text_Nombre
    '
    Me.Text_Nombre.AcceptsReturn = True
    Me.Text_Nombre.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Nombre.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Nombre.Location = New System.Drawing.Point(208, 80)
    Me.Text_Nombre.MaxLength = 0
    Me.Text_Nombre.Name = "Text_Nombre"
    Me.Text_Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Nombre.Size = New System.Drawing.Size(297, 26)
    Me.Text_Nombre.TabIndex = 4
    '
    'Text_Codigo
    '
    Me.Text_Codigo.AcceptsReturn = True
    Me.Text_Codigo.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Codigo.Enabled = False
    Me.Text_Codigo.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Codigo.Location = New System.Drawing.Point(208, 40)
    Me.Text_Codigo.MaxLength = 0
    Me.Text_Codigo.Name = "Text_Codigo"
    Me.Text_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Codigo.Size = New System.Drawing.Size(81, 26)
    Me.Text_Codigo.TabIndex = 3
    Me.Text_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label_Codigo
    '
    Me.Label_Codigo.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Codigo.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Codigo.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Codigo.Location = New System.Drawing.Point(40, 48)
    Me.Label_Codigo.Name = "Label_Codigo"
    Me.Label_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Codigo.Size = New System.Drawing.Size(81, 25)
    Me.Label_Codigo.TabIndex = 16
    Me.Label_Codigo.Text = "Código"
    '
    'Label_Nombre
    '
    Me.Label_Nombre.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Nombre.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Nombre.Location = New System.Drawing.Point(40, 88)
    Me.Label_Nombre.Name = "Label_Nombre"
    Me.Label_Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Nombre.Size = New System.Drawing.Size(81, 25)
    Me.Label_Nombre.TabIndex = 15
    Me.Label_Nombre.Text = "Nombre"
    '
    'Label_NIF
    '
    Me.Label_NIF.BackColor = System.Drawing.SystemColors.Control
    Me.Label_NIF.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_NIF.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_NIF.Location = New System.Drawing.Point(40, 128)
    Me.Label_NIF.Name = "Label_NIF"
    Me.Label_NIF.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_NIF.Size = New System.Drawing.Size(81, 17)
    Me.Label_NIF.TabIndex = 14
    Me.Label_NIF.Text = "NIF"
    '
    'Label_Direccion
    '
    Me.Label_Direccion.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Direccion.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Direccion.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Direccion.Location = New System.Drawing.Point(40, 168)
    Me.Label_Direccion.Name = "Label_Direccion"
    Me.Label_Direccion.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Direccion.Size = New System.Drawing.Size(81, 17)
    Me.Label_Direccion.TabIndex = 13
    Me.Label_Direccion.Text = "Dirección"
    '
    'Label_CodPostal
    '
    Me.Label_CodPostal.BackColor = System.Drawing.SystemColors.Control
    Me.Label_CodPostal.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_CodPostal.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_CodPostal.Location = New System.Drawing.Point(40, 208)
    Me.Label_CodPostal.Name = "Label_CodPostal"
    Me.Label_CodPostal.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_CodPostal.Size = New System.Drawing.Size(113, 25)
    Me.Label_CodPostal.TabIndex = 12
    Me.Label_CodPostal.Text = "Código Postal"
    '
    'Label_Localidad
    '
    Me.Label_Localidad.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Localidad.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Localidad.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Localidad.Location = New System.Drawing.Point(40, 248)
    Me.Label_Localidad.Name = "Label_Localidad"
    Me.Label_Localidad.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Localidad.Size = New System.Drawing.Size(81, 25)
    Me.Label_Localidad.TabIndex = 11
    Me.Label_Localidad.Text = "Localidad"
    '
    'Label_Telefono
    '
    Me.Label_Telefono.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Telefono.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Telefono.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Telefono.Location = New System.Drawing.Point(40, 288)
    Me.Label_Telefono.Name = "Label_Telefono"
    Me.Label_Telefono.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Telefono.Size = New System.Drawing.Size(81, 25)
    Me.Label_Telefono.TabIndex = 10
    Me.Label_Telefono.Text = "Teléfono"
    '
    'Aceptar
    '
    Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
    Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Aceptar.Location = New System.Drawing.Point(568, 32)
    Me.Aceptar.Name = "Aceptar"
    Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Aceptar.Size = New System.Drawing.Size(89, 25)
    Me.Aceptar.TabIndex = 1
    Me.Aceptar.Text = "Aceptar"
    Me.Aceptar.UseVisualStyleBackColor = False
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
    Me.Cancelar.Size = New System.Drawing.Size(89, 25)
    Me.Cancelar.TabIndex = 0
    Me.Cancelar.Text = "Cancelar"
    Me.Cancelar.UseVisualStyleBackColor = False
    '
    'Form_Clientes
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(670, 351)
    Me.Controls.Add(Me.Marco)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Cancelar)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Location = New System.Drawing.Point(140, 231)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Clientes"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Clientes"
    Me.Marco.ResumeLayout(False)
    Me.Marco.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
#End Region

#Region "Propiedades"
  Private CodCli As Long
  Private CodigoPostal As String
  Private DireccionPostal As String
  Private Poblacion As String
  Private CIF As String
  Private NomCli As String
  Private NumTelefono As String
  Private Activar As Boolean
  Private NuevoCodCli As Long
  Public Property NuevoCodCliente() As Long
    Get
      Return NuevoCodCli
    End Get
    Set(ByVal value As Long)
      NuevoCodCli = value
    End Set
  End Property
  Public Property CodCliente() As Long
    Get
      Return CodCli
    End Get
    Set(ByVal value As Long)
      CodCli = value
    End Set
  End Property
  Public Property CodPostal() As String
    Get
      Return CodigoPostal
    End Get
    Set(ByVal value As String)
      CodigoPostal = value
    End Set
  End Property
  Public Property Direccion() As String
    Get
      Return DireccionPostal
    End Get
    Set(ByVal value As String)
      DireccionPostal = value
    End Set
  End Property
  Public Property Localidad() As String
    Get
      Return Poblacion
    End Get
    Set(ByVal value As String)
      Poblacion = value
    End Set
  End Property
  Public Property NIF() As String
    Get
      Return CIF
    End Get
    Set(ByVal value As String)
      CIF = value
    End Set
  End Property
  Public Property Nombre() As String
    Get
      Return NomCli
    End Get
    Set(ByVal value As String)
      NomCli = value
    End Set
  End Property
  Public Property Telefono() As String
    Get
      Return NumTelefono
    End Get
    Set(ByVal value As String)
      NumTelefono = value
    End Set
  End Property
  Public Property ActivarEdicion() As Boolean
    Get
      Return Activar
    End Get
    Set(ByVal value As Boolean)
      Activar = value
    End Set
  End Property
#End Region

  Private Preguntar As Boolean = False
  Private daClientes As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("CONSULTA_CLIENTE", DBConnection)
  Private dtClientes As DataTable = New DataTable
  Protected Overrides Sub Finalize()
	  daClientes.Dispose()
	  daClientes = Nothing
	  dtClientes.Dispose()
	  dtClientes = Nothing
  End Sub

  Public Sub New()
	MyBase.New()
	'El Diseñador de Windows Forms requiere esta llamada.
	InitializeComponent()
	Me.ActivarEdicion = True
	ActivarCampos()
  End Sub
  Public Sub New(ByVal CodCliente As Long)
	MyBase.New()
	'El Diseñador de Windows Forms requiere esta llamada.
	InitializeComponent()
	Me.CodCli = CodCliente

	If Modificacion_Cliente Then
	  Me.ActivarEdicion = True
	Else
	  Me.ActivarEdicion = False
	End If

	ConsultaCliente()
	AsignarControles()
	ActivarCampos()
  End Sub

  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
	Dim Error_Code As Short = 0
	If Alta_Cliente Then
	  Error_Code = ValidarCampos()
	  If Error_Code = 0 Then
		Call AsignarValoresUsuario()
		Call AltaCliente()
		Alta_Cliente = False
		Me.Close()
	  Else
		Call MostrarError(Error_Code)
	  End If
	Else
	  If Baja_Cliente Then
		Call BajaCliente()
		Baja_Cliente = False
		Preguntar = False
		Me.Close()
	  Else
		If Modificacion_Cliente Then
		  Error_Code = ValidarCampos()
		  If Error_Code = 0 Then
			Call AsignarValoresUsuario()
			Call ModificacionCliente()
			Modificacion_Cliente = False
			Me.Close()
		  Else
			Call MostrarError(Error_Code)
		  End If
		Else
		  If Consulta_Cliente Then
			Consulta_Cliente = False
			Preguntar = False
			Me.Close()
		  End If
		End If
	  End If
	End If
  End Sub
  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
	If Not Consulta_Cliente Then
	  Preguntar = True
	Else
	  Consulta_Cliente = False
	End If
	Me.Close()
  End Sub
  Private Sub Form_Clientes_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
	Dim OK As MsgBoxResult
	If Preguntar Then
	  OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
	  If OK = MsgBoxResult.Yes Then
		[Global].Inicializar()
	  Else
		eventArgs.Cancel = True
	  End If
	End If
  End Sub
  Public Function ValidarCampos() As Short
	If Len(Me.Text_CodPostal.Text) <> 5 Then
	  Return 1012
	Else
	  If Not IsNumeric(Me.Text_CodPostal.Text) Then
		Return 1013
	  Else
		If Me.Text_Direccion.Text = "" Then
		  Return 1014
		Else
		  If Me.Text_Localidad.Text = "" Then
			Return 1015
		  Else
			If Me.Text_NIF.Text = "" Then
			  Return 1016
			Else
			  If Me.Text_Nombre.Text = "" Then
				Return 1017
			  Else
				If Not IsNumeric(Me.Text_Telefono.Text) Then
				  Return 1018
				Else
				  Return 0
				End If
			  End If
			End If
		  End If
		End If
	  End If
	End If
  End Function
  Public Sub AsignarValoresUsuario()
	If Not (Me.CodCli = CLng(Me.Text_Codigo.Text)) Then
	  Me.NuevoCodCli = CLng(Me.Text_Codigo.Text)
	Else
	  Me.NuevoCodCli = Me.CodCli
	End If
	Me.CodPostal = Me.Text_CodPostal.Text
	Me.Direccion = Me.Text_Direccion.Text
	Me.Localidad = Me.Text_Localidad.Text
	Me.NIF = Me.Text_NIF.Text
	Me.Nombre = Me.Text_Nombre.Text
	Me.Telefono = Me.Text_Telefono.Text
  End Sub
  Public Sub AsignarControles()
	Me.Text_Codigo.Text = CStr(Me.CodCli)
	Me.Text_CodPostal.Text = Me.CodPostal
	Me.Text_Direccion.Text = Me.Direccion
	Me.Text_Localidad.Text = Me.Localidad
	Me.Text_NIF.Text = Me.NIF
	Me.Text_Nombre.Text = Me.Nombre
	Me.Text_Telefono.Text = Me.Telefono
  End Sub
  Public Sub ActivarCampos()
	Me.Text_CodPostal.Enabled = Me.Activar
	Me.Text_Direccion.Enabled = Me.Activar
	Me.Text_Localidad.Enabled = Me.Activar
	Me.Text_NIF.Enabled = Me.Activar
	Me.Text_Nombre.Enabled = Me.Activar
	Me.Text_Telefono.Enabled = Me.Activar
  End Sub

  Private Sub Form_Clientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	If Alta_Cliente Then
	  Dim Max_Cod_Cliente As Integer = 0
	  Dim cmdMaxCodCliente As SqlClient.SqlCommand
	  cmdMaxCodCliente = New SqlClient.SqlCommand("SELECT [dbo].[MAX_COD_CLIENTE]()", DBConnection)
	  Try
		Max_Cod_Cliente = cmdMaxCodCliente.ExecuteScalar()
		Me.CodCli = 1 + Max_Cod_Cliente
		Me.Text_Codigo.Text = (1 + Max_Cod_Cliente).ToString
	  Catch ex As Exception
		MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	  Finally
		cmdMaxCodCliente.Dispose()
		cmdMaxCodCliente = Nothing
	  End Try
	End If
  End Sub

  Public Sub ConsultaCliente()
	Try
	  daClientes.SelectCommand = New SqlClient.SqlCommand("CONSULTA_CLIENTE")
	  daClientes.SelectCommand.Connection = DBConnection
	  daClientes.SelectCommand.CommandText = "CONSULTA_CLIENTE"
	  daClientes.SelectCommand.CommandType = CommandType.StoredProcedure
	  daClientes.SelectCommand.Parameters.Add("@CodCli", SqlDbType.BigInt)
	  daClientes.SelectCommand.Parameters("@CodCli").Value = Me.CodCli
	  daClientes.SelectCommand.ExecuteNonQuery()
	  daClientes.Fill(dtClientes)

	  With dtClientes.Rows(0)
		Me.CodCli = .Item("COD_CLI")
		Me.CodPostal = .Item("CODPOSTAL")
		Me.Direccion = .Item("DIRECCION")
		Me.Localidad = .Item("LOCALIDAD")
		Me.NIF = .Item("NIF")
		Me.Nombre = .Item("NOMBRE")
		Me.Telefono = .Item("TELEFONO")
	  End With
	Catch ex As Exception
	  MsgBox("Error al consultar cliente: " & ex.Message)
	Finally
	  daClientes.Dispose()
	  dtClientes.Dispose()
	  daClientes = Nothing
	  dtClientes = Nothing
	End Try
  End Sub
  Public Sub AltaCliente()
	Dim cmdAltaCliente As SqlClient.SqlCommand = New SqlClient.SqlCommand("ALTA_CLIENTE", DBConnection)
	Try
	  With cmdAltaCliente
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@CodCli", SqlDbType.Int)
		  .Item("@CodCli").Value = Me.CodCliente
		  .Add("@Nombre", SqlDbType.NVarChar)
		  .Item("@Nombre").Value = Me.Nombre
		  .Add("@Direccion", SqlDbType.NVarChar)
		  .Item("@Direccion").Value = Me.Direccion
		  .Add("@Localidad", SqlDbType.NVarChar)
		  .Item("@Localidad").Value = Me.Localidad
		  .Add("@CodPostal", SqlDbType.NVarChar)
		  .Item("@CodPostal").Value = Me.CodPostal
		  .Add("@Telefono", SqlDbType.NVarChar)
		  .Item("@Telefono").Value = Me.Telefono
		  .Add("@NIF", SqlDbType.NVarChar)
		  .Item("@NIF").Value = Me.NIF
		End With
		.ExecuteNonQuery()
		MsgBox("Alta realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	  End With
	Catch ex As Exception
	  MsgBox("Error al insertar cliente: " & ex.Message)
	Finally
	  cmdAltaCliente.Dispose()
	  cmdAltaCliente = Nothing
	End Try
  End Sub
  Public Sub BajaCliente()
	Dim cmdBajaCliente As SqlClient.SqlCommand = New SqlClient.SqlCommand("BAJA_CLIENTE", DBConnection)
	Try
	  With cmdBajaCliente
		.CommandType = CommandType.StoredProcedure
		.Parameters.Add("@CodCli", SqlDbType.Int)
		.Parameters.Item("@CodCli").Value = Me.CodCliente
		.ExecuteNonQuery()
	  End With
	  MsgBox("Baja realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	Catch ex As Exception
	  MsgBox("Error al eliminar cliente: " & ex.Message)
	Finally
	  cmdBajaCliente.Dispose()
	  cmdBajaCliente = Nothing
	End Try
  End Sub
  Public Sub ModificacionCliente()
	Dim cmdUpdCliente As SqlClient.SqlCommand = New SqlClient.SqlCommand("MODIFICACION_CLIENTE", DBConnection)
	Try
	  With cmdUpdCliente
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@CodCli", SqlDbType.BigInt)
		  .Item("@CodCli").Value = Me.CodCliente
		  .Add("@NuevoCodCli", SqlDbType.BigInt)
		  .Item("@NuevoCodCli").Value = Me.NuevoCodCliente
		  .Add("@Nombre", SqlDbType.NVarChar)
		  .Item("@Nombre").Value = Me.Nombre
		  .Add("@Direccion", SqlDbType.NVarChar)
		  .Item("@Direccion").Value = Me.Direccion
		  .Add("@Localidad", SqlDbType.NVarChar)
		  .Item("@Localidad").Value = Me.Localidad
		  .Add("@CodPostal", SqlDbType.NVarChar)
		  .Item("@CodPostal").Value = Me.CodPostal
		  .Add("@Telefono", SqlDbType.NVarChar)
		  .Item("@Telefono").Value = Me.Telefono
		  .Add("@NIF", SqlDbType.NVarChar)
		  .Item("@NIF").Value = Me.NIF
		End With
		.ExecuteNonQuery()
		MsgBox("Modificacion realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	  End With
	Catch ex As Exception
	  MsgBox("Error al modificar cliente: " & ex.Message)
	Finally
	  cmdUpdCliente.Dispose()
	  cmdUpdCliente = Nothing
	End Try
  End Sub
  Public Sub MostrarError(ByVal Error_Code As Short)
	If Error_Code = 1011 Then
	  MsgBox("Este cliente ya existe en la base de datos", MsgBoxStyle.OkOnly, "Error")
	Else
	  If Error_Code = 1012 Then
		MsgBox("La longitud del código postal debe ser cinco", MsgBoxStyle.OkOnly, "Error")
	  Else
		If Error_Code = 1013 Then
		  MsgBox("El código postal debe ser numérico", MsgBoxStyle.OkOnly, "Error")
		Else
		  If Error_Code = 1014 Then
			MsgBox("La dirección no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
		  Else
			If Error_Code = 1015 Then
			  MsgBox("La localidad no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
			Else
			  If Error_Code = 1016 Then
				MsgBox("El NIF no puede estar en blanco", MsgBoxStyle.OkOnly, CStr(Error_Code))
			  Else
				If Error_Code = 1017 Then
				  MsgBox("El nombre no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
				Else
				  If Error_Code = 1018 Then
					MsgBox("El teléfono debe ser numérico", MsgBoxStyle.OkOnly, "Error")
				  End If
				End If
			  End If
			End If
		  End If
		End If
	  End If
	End If
  End Sub
End Class