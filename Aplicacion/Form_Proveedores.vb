Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class Form_Proveedores
  Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
  Public Sub New()
    MyBase.New()
    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()
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
  Public WithEvents Text_Nombre As System.Windows.Forms.TextBox
  Public WithEvents Text_NIF As System.Windows.Forms.TextBox
  Public WithEvents Text_Direccion As System.Windows.Forms.TextBox
  Public WithEvents Text_CodPostal As System.Windows.Forms.TextBox
  Public WithEvents Text_Localidad As System.Windows.Forms.TextBox
  Public WithEvents Text_Telefono As System.Windows.Forms.TextBox
  Public WithEvents Text_Codigo As System.Windows.Forms.TextBox
  Public WithEvents Label_Codigo As System.Windows.Forms.Label
  Public WithEvents Label_Telefono As System.Windows.Forms.Label
  Public WithEvents Label_Localidad As System.Windows.Forms.Label
  Public WithEvents Label_CodPostal As System.Windows.Forms.Label
  Public WithEvents Label_Direccion As System.Windows.Forms.Label
  Public WithEvents Label_NIF As System.Windows.Forms.Label
  Public WithEvents Label_Nombre As System.Windows.Forms.Label
  Public WithEvents Marco As System.Windows.Forms.GroupBox
  Public WithEvents Aceptar As System.Windows.Forms.Button
  Public WithEvents Cancelar As System.Windows.Forms.Button
  'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
  'Se puede modificar mediante el Diseñador de Windows Forms.
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Text_Nombre = New System.Windows.Forms.TextBox
    Me.Text_NIF = New System.Windows.Forms.TextBox
    Me.Text_Direccion = New System.Windows.Forms.TextBox
    Me.Text_CodPostal = New System.Windows.Forms.TextBox
    Me.Text_Localidad = New System.Windows.Forms.TextBox
    Me.Text_Telefono = New System.Windows.Forms.TextBox
    Me.Marco = New System.Windows.Forms.GroupBox
    Me.Text_Codigo = New System.Windows.Forms.TextBox
    Me.Label_Codigo = New System.Windows.Forms.Label
    Me.Label_Telefono = New System.Windows.Forms.Label
    Me.Label_Localidad = New System.Windows.Forms.Label
    Me.Label_CodPostal = New System.Windows.Forms.Label
    Me.Label_Direccion = New System.Windows.Forms.Label
    Me.Label_NIF = New System.Windows.Forms.Label
    Me.Label_Nombre = New System.Windows.Forms.Label
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Marco.SuspendLayout()
    Me.SuspendLayout()
    '
    'Text_Nombre
    '
    Me.Text_Nombre.AcceptsReturn = True
    Me.Text_Nombre.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Text_Nombre.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Nombre.Location = New System.Drawing.Point(224, 80)
    Me.Text_Nombre.MaxLength = 0
    Me.Text_Nombre.Name = "Text_Nombre"
    Me.Text_Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Nombre.Size = New System.Drawing.Size(297, 23)
    Me.Text_Nombre.TabIndex = 1
    '
    'Text_NIF
    '
    Me.Text_NIF.AcceptsReturn = True
    Me.Text_NIF.BackColor = System.Drawing.SystemColors.Window
    Me.Text_NIF.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_NIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Text_NIF.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_NIF.Location = New System.Drawing.Point(224, 120)
    Me.Text_NIF.MaxLength = 0
    Me.Text_NIF.Name = "Text_NIF"
    Me.Text_NIF.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_NIF.Size = New System.Drawing.Size(129, 23)
    Me.Text_NIF.TabIndex = 2
    '
    'Text_Direccion
    '
    Me.Text_Direccion.AcceptsReturn = True
    Me.Text_Direccion.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Text_Direccion.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Direccion.Location = New System.Drawing.Point(224, 160)
    Me.Text_Direccion.MaxLength = 0
    Me.Text_Direccion.Name = "Text_Direccion"
    Me.Text_Direccion.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Direccion.Size = New System.Drawing.Size(297, 23)
    Me.Text_Direccion.TabIndex = 3
    '
    'Text_CodPostal
    '
    Me.Text_CodPostal.AcceptsReturn = True
    Me.Text_CodPostal.BackColor = System.Drawing.SystemColors.Window
    Me.Text_CodPostal.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_CodPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Text_CodPostal.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_CodPostal.Location = New System.Drawing.Point(224, 208)
    Me.Text_CodPostal.MaxLength = 0
    Me.Text_CodPostal.Name = "Text_CodPostal"
    Me.Text_CodPostal.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_CodPostal.Size = New System.Drawing.Size(81, 23)
    Me.Text_CodPostal.TabIndex = 4
    Me.Text_CodPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Text_Localidad
    '
    Me.Text_Localidad.AcceptsReturn = True
    Me.Text_Localidad.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Localidad.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Text_Localidad.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Localidad.Location = New System.Drawing.Point(224, 248)
    Me.Text_Localidad.MaxLength = 0
    Me.Text_Localidad.Name = "Text_Localidad"
    Me.Text_Localidad.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Localidad.Size = New System.Drawing.Size(297, 23)
    Me.Text_Localidad.TabIndex = 5
    '
    'Text_Telefono
    '
    Me.Text_Telefono.AcceptsReturn = True
    Me.Text_Telefono.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Text_Telefono.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Telefono.Location = New System.Drawing.Point(224, 288)
    Me.Text_Telefono.MaxLength = 0
    Me.Text_Telefono.Name = "Text_Telefono"
    Me.Text_Telefono.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Telefono.Size = New System.Drawing.Size(129, 23)
    Me.Text_Telefono.TabIndex = 6
    Me.Text_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Marco
    '
    Me.Marco.BackColor = System.Drawing.SystemColors.Control
    Me.Marco.Controls.Add(Me.Text_Codigo)
    Me.Marco.Controls.Add(Me.Label_Codigo)
    Me.Marco.Controls.Add(Me.Label_Telefono)
    Me.Marco.Controls.Add(Me.Label_Localidad)
    Me.Marco.Controls.Add(Me.Label_CodPostal)
    Me.Marco.Controls.Add(Me.Label_Direccion)
    Me.Marco.Controls.Add(Me.Label_NIF)
    Me.Marco.Controls.Add(Me.Label_Nombre)
    Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco.Location = New System.Drawing.Point(16, 16)
    Me.Marco.Name = "Marco"
    Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco.Size = New System.Drawing.Size(569, 313)
    Me.Marco.TabIndex = 9
    Me.Marco.TabStop = False
    Me.Marco.Text = "Proveedores"
    '
    'Text_Codigo
    '
    Me.Text_Codigo.AcceptsReturn = True
    Me.Text_Codigo.BackColor = System.Drawing.SystemColors.Window
    Me.Text_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam
    Me.Text_Codigo.Enabled = False
    Me.Text_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Text_Codigo.ForeColor = System.Drawing.SystemColors.WindowText
    Me.Text_Codigo.Location = New System.Drawing.Point(208, 24)
    Me.Text_Codigo.MaxLength = 0
    Me.Text_Codigo.Name = "Text_Codigo"
    Me.Text_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Text_Codigo.Size = New System.Drawing.Size(81, 23)
    Me.Text_Codigo.TabIndex = 0
    Me.Text_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label_Codigo
    '
    Me.Label_Codigo.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Codigo.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Codigo.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Codigo.Location = New System.Drawing.Point(40, 32)
    Me.Label_Codigo.Name = "Label_Codigo"
    Me.Label_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Codigo.Size = New System.Drawing.Size(81, 25)
    Me.Label_Codigo.TabIndex = 16
    Me.Label_Codigo.Text = "Código"
    '
    'Label_Telefono
    '
    Me.Label_Telefono.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Telefono.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Telefono.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Telefono.Location = New System.Drawing.Point(40, 272)
    Me.Label_Telefono.Name = "Label_Telefono"
    Me.Label_Telefono.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Telefono.Size = New System.Drawing.Size(81, 25)
    Me.Label_Telefono.TabIndex = 15
    Me.Label_Telefono.Text = "Teléfono"
    '
    'Label_Localidad
    '
    Me.Label_Localidad.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Localidad.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Localidad.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Localidad.Location = New System.Drawing.Point(40, 232)
    Me.Label_Localidad.Name = "Label_Localidad"
    Me.Label_Localidad.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Localidad.Size = New System.Drawing.Size(81, 25)
    Me.Label_Localidad.TabIndex = 14
    Me.Label_Localidad.Text = "Localidad"
    '
    'Label_CodPostal
    '
    Me.Label_CodPostal.BackColor = System.Drawing.SystemColors.Control
    Me.Label_CodPostal.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_CodPostal.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_CodPostal.Location = New System.Drawing.Point(40, 192)
    Me.Label_CodPostal.Name = "Label_CodPostal"
    Me.Label_CodPostal.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_CodPostal.Size = New System.Drawing.Size(113, 25)
    Me.Label_CodPostal.TabIndex = 13
    Me.Label_CodPostal.Text = "Código Postal"
    '
    'Label_Direccion
    '
    Me.Label_Direccion.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Direccion.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Direccion.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Direccion.Location = New System.Drawing.Point(40, 152)
    Me.Label_Direccion.Name = "Label_Direccion"
    Me.Label_Direccion.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Direccion.Size = New System.Drawing.Size(81, 17)
    Me.Label_Direccion.TabIndex = 12
    Me.Label_Direccion.Text = "Dirección"
    '
    'Label_NIF
    '
    Me.Label_NIF.BackColor = System.Drawing.SystemColors.Control
    Me.Label_NIF.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_NIF.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_NIF.Location = New System.Drawing.Point(40, 112)
    Me.Label_NIF.Name = "Label_NIF"
    Me.Label_NIF.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_NIF.Size = New System.Drawing.Size(81, 17)
    Me.Label_NIF.TabIndex = 11
    Me.Label_NIF.Text = "NIF"
    '
    'Label_Nombre
    '
    Me.Label_Nombre.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Nombre.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Nombre.Location = New System.Drawing.Point(40, 72)
    Me.Label_Nombre.Name = "Label_Nombre"
    Me.Label_Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Nombre.Size = New System.Drawing.Size(81, 25)
    Me.Label_Nombre.TabIndex = 10
    Me.Label_Nombre.Text = "Nombre"
    '
    'Aceptar
    '
    Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
    Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Aceptar.Location = New System.Drawing.Point(600, 32)
    Me.Aceptar.Name = "Aceptar"
    Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Aceptar.Size = New System.Drawing.Size(89, 25)
    Me.Aceptar.TabIndex = 7
    Me.Aceptar.Text = "Aceptar"
    Me.Aceptar.UseVisualStyleBackColor = False
    '
    'Cancelar
    '
    Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
    Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Cancelar.Location = New System.Drawing.Point(600, 72)
    Me.Cancelar.Name = "Cancelar"
    Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Cancelar.Size = New System.Drawing.Size(89, 25)
    Me.Cancelar.TabIndex = 8
    Me.Cancelar.Text = "Cancelar"
    Me.Cancelar.UseVisualStyleBackColor = False
    '
    'Form_Proveedores
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(702, 342)
    Me.Controls.Add(Me.Text_Nombre)
    Me.Controls.Add(Me.Text_NIF)
    Me.Controls.Add(Me.Text_Direccion)
    Me.Controls.Add(Me.Text_CodPostal)
    Me.Controls.Add(Me.Text_Localidad)
    Me.Controls.Add(Me.Text_Telefono)
    Me.Controls.Add(Me.Marco)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Cancelar)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(3, 22)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Proveedores"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.Text = "Proveedores"
    Me.Marco.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region
  Dim Preguntar As Boolean = False
  Dim dtProveedores As DataTable
  Dim daProveedores As SqlClient.SqlDataAdapter
  Dim frmPromptProveedores As Form_Prompt_Proveedores
  Dim frmTipoIva As Form_Tipo_Iva
#Region "Propiedades"
  Private CodPro As Long
  Public Property CodProveedor() As Long
    Get
      Return CodPro
    End Get
    Set(ByVal value As Long)
      CodPro = value
    End Set
  End Property
  Private NuevoCodPro As Long
  Public Property NuevoCodProveedor() As Long
    Get
      Return NuevoCodPro
    End Get
    Set(ByVal value As Long)
      NuevoCodPro = value
    End Set
  End Property
  Private CodigoPostal As String
  Private DireccionPostal As String
  Private Poblacion As String
  Private CIF As String
  Private NomCli As String
  Private NumTelefono As String
  Private Activar As Boolean
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
  Public Sub New(ByVal CodPro As Long)
    MyBase.New()
    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()
    Me.CodProveedor = CodPro
    ConsultaProveedor()
    AsignarControles()
    If Modificacion_Proveedor Then
      Me.Activar = True
    Else
      Me.Activar = False
    End If
    ActivarControles()
  End Sub
  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
    Dim Error_Code As Short
    Dim OK As MsgBoxResult
    On Error GoTo HayError
    If Alta_Proveedor Then
      Error_Code = ValidarCampos()
      If Error_Code = 0 Then
        Call AsignarPropiedades()
        Call AltaProveedor()
        Alta_Proveedor = False
        Me.Close()
      Else
        Call MostrarError(Error_Code)
      End If
    Else
      If Baja_Proveedor Then
        BajaProveedor()
        Baja_Proveedor = False
        Me.Close()
      Else
        If Modificacion_Proveedor Then
          Error_Code = ValidarCampos()

          If Error_Code = 0 Then
            Call AsignarPropiedades()
            Call ModificacionProveedor()
            Modificacion_Proveedor = False
            Me.Close()
          Else
            Call MostrarError(Error_Code)
          End If
        Else
          If Consulta_Proveedor Then
            Consulta_Proveedor = False
            Me.Close()
          Else
            If EsFacturaCompras Then
                            Error_Code = ValidarNumeroFacturaCompras(RegFacturaCompras.Numero, Me.CodProveedor, RegFacturaCompras.Fecha)
              If Error_Code <> 0 Then
                OK = CompruebaErrorFacturaCompras(Error_Code)
                If OK = MsgBoxResult.Yes Then
                  EsModificacionCompras = True
                  If frmTipoIva Is Nothing OrElse frmTipoIva.IsDisposed Then frmTipoIva = New Form_Tipo_Iva()
                  frmTipoIva.ShowDialog()
                End If
              Else
                If frmTipoIva Is Nothing OrElse frmTipoIva.IsDisposed Then frmTipoIva = New Form_Tipo_Iva()
                frmTipoIva.ShowDialog()
              End If
              Me.Close()
            End If
          End If
        End If
      End If
    End If
    Exit Sub
HayError:
    MsgBox("Error Número " & Err.Number & vbCrLf & Err.Description)
    Err.Clear()
  End Sub

  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
    If Not Consulta_Proveedor Then
      Preguntar = True
    Else
      Consulta_Proveedor = False
    End If
    Me.Close()
  End Sub
  Private Sub Form_Proveedores_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    Dim OK As MsgBoxResult
    If Preguntar Then
      If EsFacturaCompras Then
        OK = MsgBox("¿Desea seleccionar otro proveedor?", MsgBoxStyle.YesNo, "Facturas")
        If OK = MsgBoxResult.Yes Then
          If frmPromptProveedores Is Nothing OrElse frmPromptProveedores.IsDisposed Then
            frmPromptProveedores = New Form_Prompt_Proveedores()
          End If
          frmPromptProveedores.ShowDialog()
        Else
          OK = MsgBox("¿Desea cancelar el apunte?", MsgBoxStyle.YesNo, "Facturas")
          If OK = MsgBoxResult.Yes Then
            [Global].Inicializar()
          Else
            eventArgs.Cancel = True
          End If
        End If
      Else
        If Not Consulta_Proveedor Then
          OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
          If OK = MsgBoxResult.Yes Then
            [Global].Inicializar()
          Else
            eventArgs.Cancel = True
          End If
        Else
          [Global].Inicializar()
        End If
      End If
    End If
  End Sub
  Public Sub AsignarControles()
    With Me
      Me.Text_Codigo.Text = CStr(.CodProveedor)
      Me.Text_CodPostal.Text = .CodPostal
      Me.Text_Direccion.Text = .Direccion
      Me.Text_Localidad.Text = .Localidad
      Me.Text_NIF.Text = .NIF
      Me.Text_Nombre.Text = .Nombre
      Me.Text_Telefono.Text = .Telefono
    End With
  End Sub
  Public Sub ActivarControles()
    With Me
      .Text_Codigo.Enabled = Activar
      .Text_CodPostal.Enabled = Activar
      .Text_Direccion.Enabled = Activar
      .Text_Localidad.Enabled = Activar
      .Text_NIF.Enabled = Activar
      .Text_Nombre.Enabled = Activar
      .Text_Telefono.Enabled = Activar
    End With
  End Sub
  Public Sub AsignarPropiedades()
    With Me
      If Not (.CodProveedor = CInt(.Text_Codigo.Text)) Then
        .NuevoCodProveedor = CInt(.Text_Codigo.Text)
      Else
        .NuevoCodProveedor = .CodProveedor
      End If
      .CodPostal = .Text_CodPostal.Text
      .Direccion = .Text_Direccion.Text
      .Localidad = .Text_Localidad.Text
      .NIF = .Text_NIF.Text
      .Nombre = .Text_Nombre.Text
      .Telefono = .Text_Telefono.Text
    End With
  End Sub
  Public Function ValidarCampos() As Short
    With Me
      If Len(.Text_CodPostal.Text) <> 5 Then
        Return 1012
      Else
        If Not IsNumeric(.Text_CodPostal.Text) Then
          Return 1013
        Else
          If .Text_Direccion.Text = "" Then
            Return 1014
          Else
            If .Text_Localidad.Text = "" Then
              Return 1015
            Else
              If .Text_NIF.Text = "" Then
                Return 1016
              Else
                If .Text_Nombre.Text = "" Then
                  Return 1017
                Else
                  If Not IsNumeric(.Text_Telefono.Text) Then
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
    End With
  End Function
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

  Private Sub Form_Proveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim Max_Cod_Pro As Integer
    Dim cmdMaxCodPro As SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT [Facturas].[dbo].[MAX_COD_PROVEEDOR] ()", DBConnection)
    If Alta_Proveedor Then
      Try
        With cmdMaxCodPro
          Max_Cod_Pro = .ExecuteScalar()
          If Max_Cod_Pro = 0 Then
            Me.CodProveedor = 1
          Else
            Me.CodProveedor = (1 + Max_Cod_Pro).ToString
            Me.Text_Codigo.Text = CStr(Me.CodProveedor)
          End If
        End With

      Catch ex As Exception
        MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        cmdMaxCodPro.Dispose()
        cmdMaxCodPro = Nothing
      End Try
    End If
  End Sub
  Public Sub ConsultaProveedor()
    Dim daProveedores As SqlDataAdapter = New SqlDataAdapter()
    Dim dtProveedorNombre As DataTable = New DataTable
    Try
      daProveedores.SelectCommand = New SqlClient.SqlCommand()
      With daProveedores.SelectCommand
        .Connection = DBConnection
        .CommandText = "CONSULTA_PROVEEDOR"
        .CommandType = CommandType.StoredProcedure
        .Parameters.Add("@CodProveedor", SqlDbType.VarChar)
        .Parameters("@CodProveedor").Value = Me.CodProveedor
        .ExecuteNonQuery()
      End With
      daProveedores.Fill(dtProveedorNombre)

      With dtProveedorNombre.Rows(0)
        Me.CodProveedor = .Item("COD_PRO")
        Me.CodPostal = .Item("CODPOSTAL")
        Me.Direccion = .Item("DIRECCION")
        Me.Localidad = .Item("LOCALIDAD")
        Me.NIF = .Item("NIF")
        Me.Nombre = .Item("NOMBRE")
        Me.Telefono = .Item("TELEFONO")
      End With
    Catch ex As Exception
      MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
    End Try
  End Sub
  Public Sub AltaProveedor()
    Dim cmdAltaProveedor As SqlClient.SqlCommand = New SqlClient.SqlCommand("ALTA_PROVEEDOR", DBConnection)
    Try
      With cmdAltaProveedor
        .CommandType = CommandType.StoredProcedure
        With .Parameters
          .Add("@CodPro", SqlDbType.BigInt)
          .Item("@CodPro").Value = Me.CodProveedor
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
      End With
    Catch ex As Exception
      MsgBox("Error al insertar proveedor: " & ex.Message)
    Finally
      MsgBox("Alta realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
      cmdAltaProveedor.Dispose()
      cmdAltaProveedor = Nothing
    End Try
  End Sub
  Public Sub ModificacionProveedor()
    Dim cmdUpdProveedor As SqlClient.SqlCommand = New SqlClient.SqlCommand("MODIFICACION_PROVEEDOR", DBConnection)
    Try
      With cmdUpdProveedor
        .CommandType = CommandType.StoredProcedure
        With .Parameters
          .Add("@CodPro", SqlDbType.Int)
          .Item("@CodPro").Value = Me.CodProveedor
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
          .Add("@NuevoCodPro", SqlDbType.Int)
          .Item("@NuevoCodPro").Value = Me.NuevoCodProveedor
        End With
        .ExecuteNonQuery()
      End With
    Catch ex As Exception
      MsgBox("Error al modificar proveedor: " & ex.Message)
      Throw (ex)
    Finally
      MsgBox("Modificacion realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
      cmdUpdProveedor.Dispose()
      cmdUpdProveedor = Nothing
    End Try
  End Sub
  Public Sub BajaProveedor()
    Dim cmdBajaProveedor As SqlClient.SqlCommand = New SqlClient.SqlCommand("BAJA_PROVEEDOR", DBConnection)
    Try
      With cmdBajaProveedor
        .CommandType = CommandType.StoredProcedure
        With .Parameters
          .Add("@CodPro", SqlDbType.BigInt)
          .Item("@CodPro").Value = Me.CodProveedor
        End With
        .ExecuteNonQuery()
      End With
    Catch ex As Exception
      MsgBox("Error al eliminar proveedor: " & ex.Message)
    Finally
      MsgBox("Baja realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
      cmdBajaProveedor.Dispose()
      cmdBajaProveedor = Nothing
    End Try
  End Sub
    Function ValidarNumeroFacturaCompras(ByVal Numero As String, ByVal Codigo As Integer, ByVal Fecha As Date) As Short
        Dim ExisteFactura As Integer = 0
        Dim cmdExisteFactura As SqlClient.SqlCommand = _
          New SqlClient.SqlCommand("SELECT [Facturas].[dbo].[ExisteFacturaCompras] ( " & _
          "@NumFactura,@CodPro,@Fecha)", DBConnection)
        With cmdExisteFactura
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@NumFactura", Numero)
            .Parameters.AddWithValue("@CodPro", CLng(Codigo))
            .Parameters.AddWithValue("@Fecha", CDate(Fecha))
            ExisteFactura = .ExecuteScalar()
        End With
        If ExisteFactura > 0 Then
            If EsFacturaCompras Then ValidarNumeroFacturaCompras = 1025
        Else
            ValidarNumeroFacturaCompras = 0
        End If
    End Function

  Public Function CompruebaErrorFacturaCompras(ByRef Error_Code As Short) As MsgBoxResult
    If Error_Code = 1024 Then
      CompruebaErrorFacturaCompras = MsgBox("El número de Factura no puede ser cero", MsgBoxStyle.OkOnly, "Error")
    Else
      If Error_Code = 1025 Then
        CompruebaErrorFacturaCompras = MsgBox("Ya existe una Factura con ese número" & vbCrLf & "¿Desea actualizarla?", MsgBoxStyle.YesNo, "Facturas")
      Else
        CompruebaErrorFacturaCompras = MsgBoxResult.Abort
      End If
    End If
  End Function
End Class