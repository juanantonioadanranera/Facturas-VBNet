Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Imports System.Collections.Generic
Partial Friend Class Form_Intervalo
  Inherits System.Windows.Forms.Form

#Region "Código generado por el Diseñador de Windows Forms "
  Public Sub New()
    MyBase.New()
    'El Diseñador de Windows Forms requiere esta llamada.
    Me.cAnio = New System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
    Me.cMes = New System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
    Me.cDia = New System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
    InitializeComponent()
    Me.cAnio.Insert(0, Me._cAnio_0)
    Me.cMes.Insert(0, Me._cMes_0)
    Me.cDia.Insert(0, Me._cmbDia_0)
    Me.cAnio.Insert(1, Me._cAnio_1)
    Me.cMes.Insert(1, Me._cMes_1)
    Me.cDia.Insert(1, Me._cDia_1)

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
  Public WithEvents _cAnio_1 As System.Windows.Forms.ComboBox
  Public WithEvents _cMes_1 As System.Windows.Forms.ComboBox
  Public WithEvents _cDia_1 As System.Windows.Forms.ComboBox
  Public WithEvents _cAnio_0 As System.Windows.Forms.ComboBox
  Public WithEvents _cMes_0 As System.Windows.Forms.ComboBox
  Public WithEvents _cmbDia_0 As System.Windows.Forms.ComboBox
  Public WithEvents _Label2_1 As System.Windows.Forms.Label
  Public WithEvents _Label1_1 As System.Windows.Forms.Label
  Public WithEvents _Fecha_1 As System.Windows.Forms.Label
  Public WithEvents _Label2_0 As System.Windows.Forms.Label
  Public WithEvents _Label1_0 As System.Windows.Forms.Label
  Public WithEvents _Fecha_0 As System.Windows.Forms.Label
  Public WithEvents Marco_Intervalo As System.Windows.Forms.GroupBox
  Public WithEvents Aceptar As System.Windows.Forms.Button
  Public WithEvents Cancelar As System.Windows.Forms.Button
  Public WithEvents cAnio As System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
  Public WithEvents cMes As System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
  Public WithEvents cDia As System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
  'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
  'Se puede modificar mediante el Diseñador de Windows Forms.
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Marco_Intervalo = New System.Windows.Forms.GroupBox
    Me._cAnio_1 = New System.Windows.Forms.ComboBox
    Me._cMes_1 = New System.Windows.Forms.ComboBox
    Me._cDia_1 = New System.Windows.Forms.ComboBox
    Me._cAnio_0 = New System.Windows.Forms.ComboBox
    Me._cMes_0 = New System.Windows.Forms.ComboBox
    Me._cmbDia_0 = New System.Windows.Forms.ComboBox
    Me._Label2_1 = New System.Windows.Forms.Label
    Me._Label1_1 = New System.Windows.Forms.Label
    Me._Fecha_1 = New System.Windows.Forms.Label
    Me._Label2_0 = New System.Windows.Forms.Label
    Me._Label1_0 = New System.Windows.Forms.Label
    Me._Fecha_0 = New System.Windows.Forms.Label
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Marco_Intervalo.SuspendLayout()
    Me.SuspendLayout()
    '
    'Marco_Intervalo
    '
    Me.Marco_Intervalo.BackColor = System.Drawing.SystemColors.Control
    Me.Marco_Intervalo.Controls.Add(Me._cAnio_1)
    Me.Marco_Intervalo.Controls.Add(Me._cMes_1)
    Me.Marco_Intervalo.Controls.Add(Me._cDia_1)
    Me.Marco_Intervalo.Controls.Add(Me._cAnio_0)
    Me.Marco_Intervalo.Controls.Add(Me._cMes_0)
    Me.Marco_Intervalo.Controls.Add(Me._cmbDia_0)
    Me.Marco_Intervalo.Controls.Add(Me._Label2_1)
    Me.Marco_Intervalo.Controls.Add(Me._Label1_1)
    Me.Marco_Intervalo.Controls.Add(Me._Fecha_1)
    Me.Marco_Intervalo.Controls.Add(Me._Label2_0)
    Me.Marco_Intervalo.Controls.Add(Me._Label1_0)
    Me.Marco_Intervalo.Controls.Add(Me._Fecha_0)
    Me.Marco_Intervalo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco_Intervalo.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco_Intervalo.Location = New System.Drawing.Point(16, 16)
    Me.Marco_Intervalo.Name = "Marco_Intervalo"
    Me.Marco_Intervalo.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco_Intervalo.Size = New System.Drawing.Size(513, 161)
    Me.Marco_Intervalo.TabIndex = 2
    Me.Marco_Intervalo.TabStop = False
    Me.Marco_Intervalo.Text = "Intervalo de Fechas"
    '
    '_cAnio_1
    '
    Me._cAnio_1.BackColor = System.Drawing.SystemColors.Window
    Me._cAnio_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._cAnio_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cAnio_1.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cAnio_1.Location = New System.Drawing.Point(424, 104)
    Me._cAnio_1.Name = "_cAnio_1"
    Me._cAnio_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cAnio_1.Size = New System.Drawing.Size(65, 28)
    Me._cAnio_1.TabIndex = 11
    '
    '_cMes_1
    '
    Me._cMes_1.BackColor = System.Drawing.SystemColors.Window
    Me._cMes_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._cMes_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cMes_1.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cMes_1.Location = New System.Drawing.Point(344, 104)
    Me._cMes_1.Name = "_cMes_1"
    Me._cMes_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cMes_1.Size = New System.Drawing.Size(49, 28)
    Me._cMes_1.TabIndex = 10
    '
    '_cDia_1
    '
    Me._cDia_1.BackColor = System.Drawing.SystemColors.Window
    Me._cDia_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._cDia_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cDia_1.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cDia_1.Location = New System.Drawing.Point(264, 104)
    Me._cDia_1.Name = "_cDia_1"
    Me._cDia_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cDia_1.Size = New System.Drawing.Size(49, 28)
    Me._cDia_1.TabIndex = 9
    '
    '_cAnio_0
    '
    Me._cAnio_0.BackColor = System.Drawing.SystemColors.Window
    Me._cAnio_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._cAnio_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cAnio_0.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cAnio_0.Location = New System.Drawing.Point(424, 40)
    Me._cAnio_0.Name = "_cAnio_0"
    Me._cAnio_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cAnio_0.Size = New System.Drawing.Size(65, 28)
    Me._cAnio_0.TabIndex = 5
    '
    '_cMes_0
    '
    Me._cMes_0.BackColor = System.Drawing.SystemColors.Window
    Me._cMes_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._cMes_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cMes_0.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cMes_0.Location = New System.Drawing.Point(344, 40)
    Me._cMes_0.Name = "_cMes_0"
    Me._cMes_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cMes_0.Size = New System.Drawing.Size(49, 28)
    Me._cMes_0.TabIndex = 4
    '
    '_cmbDia_0
    '
    Me._cmbDia_0.BackColor = System.Drawing.SystemColors.Window
    Me._cmbDia_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._cmbDia_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cmbDia_0.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cmbDia_0.Location = New System.Drawing.Point(264, 40)
    Me._cmbDia_0.Name = "_cmbDia_0"
    Me._cmbDia_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cmbDia_0.Size = New System.Drawing.Size(49, 28)
    Me._cmbDia_0.TabIndex = 3
    '
    '_Label2_1
    '
    Me._Label2_1.BackColor = System.Drawing.SystemColors.Control
    Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label2_1.Location = New System.Drawing.Point(408, 104)
    Me._Label2_1.Name = "_Label2_1"
    Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label2_1.Size = New System.Drawing.Size(9, 25)
    Me._Label2_1.TabIndex = 14
    Me._Label2_1.Text = "/"
    '
    '_Label1_1
    '
    Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label1_1.Location = New System.Drawing.Point(328, 104)
    Me._Label1_1.Name = "_Label1_1"
    Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_1.Size = New System.Drawing.Size(9, 25)
    Me._Label1_1.TabIndex = 13
    Me._Label1_1.Text = "/"
    '
    '_Fecha_1
    '
    Me._Fecha_1.BackColor = System.Drawing.SystemColors.Control
    Me._Fecha_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Fecha_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Fecha_1.Location = New System.Drawing.Point(16, 112)
    Me._Fecha_1.Name = "_Fecha_1"
    Me._Fecha_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Fecha_1.Size = New System.Drawing.Size(233, 25)
    Me._Fecha_1.TabIndex = 12
    Me._Fecha_1.Text = "Introduzca la fecha de fin:"
    '
    '_Label2_0
    '
    Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
    Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label2_0.Location = New System.Drawing.Point(408, 40)
    Me._Label2_0.Name = "_Label2_0"
    Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label2_0.Size = New System.Drawing.Size(9, 25)
    Me._Label2_0.TabIndex = 8
    Me._Label2_0.Text = "/"
    '
    '_Label1_0
    '
    Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
    Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label1_0.Location = New System.Drawing.Point(328, 40)
    Me._Label1_0.Name = "_Label1_0"
    Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label1_0.Size = New System.Drawing.Size(9, 25)
    Me._Label1_0.TabIndex = 7
    Me._Label1_0.Text = "/"
    '
    '_Fecha_0
    '
    Me._Fecha_0.BackColor = System.Drawing.SystemColors.Control
    Me._Fecha_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Fecha_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Fecha_0.Location = New System.Drawing.Point(16, 48)
    Me._Fecha_0.Name = "_Fecha_0"
    Me._Fecha_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Fecha_0.Size = New System.Drawing.Size(233, 25)
    Me._Fecha_0.TabIndex = 6
    Me._Fecha_0.Text = "Introduzca la fecha de inicio:"
    '
    'Aceptar
    '
    Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
    Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Aceptar.Location = New System.Drawing.Point(544, 40)
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
    Me.Cancelar.Location = New System.Drawing.Point(544, 80)
    Me.Cancelar.Name = "Cancelar"
    Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Cancelar.Size = New System.Drawing.Size(89, 25)
    Me.Cancelar.TabIndex = 0
    Me.Cancelar.Text = "Cancelar"
    Me.Cancelar.UseVisualStyleBackColor = False
    '
    'Form_Intervalo
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(647, 192)
    Me.Controls.Add(Me.Marco_Intervalo)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Cancelar)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(3, 22)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Intervalo"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.Text = "Fecha"
    Me.Marco_Intervalo.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region

  Dim Preguntar As Boolean = False
  Dim cmdHayFacturasCompras As SqlCommand = _
  New SqlCommand("SELECT [Facturas].[dbo].[NumComprasPorFecha] (@FechaInicio,@FechaFin)", DBConnection)
  Dim cmdHayFacturasVentas As SqlCommand = _
  New SqlCommand("SELECT [Facturas].[dbo].[NumVentasPorFecha] (@FechaInicio,@FechaFin)", DBConnection)
  Dim ListadoCompras As Form_Listado_Compras
  Dim ListadoVentas As Form_Listado_Ventas


  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
    Dim dtFechaInicio, dtFechaFin As DateTime
    Dim numFacturas As Integer = 0
    Try
      FechaInicio = cDia(0).Text & "-" & cMes(0).Text & "-" & cAnio(0).Text
      FechaFin = cDia(1).Text & "-" & cMes(1).Text & "-" & cAnio(1).Text

      dtFechaInicio = CDate(Format(FechaInicio, "general date"))
      dtFechaFin = CDate(Format(FechaFin, "general date"))

      If EsListadoVentas Then
        With cmdHayFacturasVentas
          .CommandType = CommandType.Text
          .Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime))
          .Parameters("@FechaInicio").DbType = DbType.Date
          .Parameters("@FechaInicio").Value = dtFechaInicio
          .Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime))
          .Parameters("@FechaFin").DbType = DbType.Date
          .Parameters("@FechaFin").Value = dtFechaFin
          numFacturas = CInt(.ExecuteScalar())
        End With
        If numFacturas = 0 Then
          MsgBox("No hay facturas de ventas en ese intervalo de fechas", MsgBoxStyle.OkOnly)
          Exit Sub
        Else
		  ListadoVentas = New Form_Listado_Ventas(dtFechaInicio, dtFechaFin)
		  If ListadoVentas.Visible = False Then ListadoVentas.Show()
		  EsListadoVentas = False
		End If
	  End If

	  If EsListadoCompras Then
		With cmdHayFacturasCompras
		  .CommandType = CommandType.Text
		  .Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime))
		  .Parameters("@FechaInicio").DbType = DbType.Date
		  .Parameters("@FechaInicio").Value = dtFechaInicio
		  .Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime))
		  .Parameters("@FechaFin").DbType = DbType.Date
		  .Parameters("@FechaFin").Value = dtFechaFin
		  numFacturas = CInt(.ExecuteScalar())
		End With
		If numFacturas = 0 Then
		  MsgBox("No hay facturas de compras en ese intervalo de fechas", MsgBoxStyle.OkOnly)
		  Exit Sub
		Else
		  ListadoCompras = New Form_Listado_Compras(dtFechaInicio, dtFechaFin)
		  If ListadoCompras.Visible = False Then ListadoCompras.Show()
		  EsListadoCompras = False
		End If
	  End If
    Catch ex As Exception
      MsgBox("Error " & vbCrLf & ex.Message)
    Finally
      cmdHayFacturasCompras.Dispose()
      cmdHayFacturasCompras = Nothing
      cmdHayFacturasVentas.Dispose()
      cmdHayFacturasVentas = Nothing
    End Try
    Preguntar = False
    Me.Close()
  End Sub

  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
    Preguntar = True
    Me.Close()
  End Sub

  Private Sub cAnio_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _
    _cAnio_0.SelectedIndexChanged, _cAnio_1.SelectedIndexChanged
    Dim Index As Short = cAnio.IndexOf(eventSender)
    Call PresentaFecha(Index)
  End Sub

  Private Sub cMes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _
  _cMes_0.SelectedIndexChanged, _cMes_1.SelectedIndexChanged
    Dim Index As Short = cMes.IndexOf(eventSender)
    Call PresentaFecha(Index)
  End Sub

  Private Sub Form_Intervalo_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    PresentaFecha(0)
    PresentaFecha(1)

    For j As Integer = 0 To 1

      Me.cAnio(j).SelectedIndex = Today.Year - 1999
      Me.cMes(j).SelectedIndex = Today.Month - 1
      If Today.Day - 1 < Me.cDia(j).Items.Count Then
        Me.cDia(j).SelectedIndex = Today.Day - 1
      Else
        Me.cDia(j).SelectedIndex = Me.cDia(j).Items.Count - 1
      End If
    Next
  End Sub

  Private Sub PresentaFecha(ByRef Index As Short) 'Rellena la lista de los dias de la fecha con valores adecuados
    Dim i, j, LimDias As Short
    Dim EsBisiesto As Boolean = False

    For j = 0 To 1
      If cAnio(j).Items.Count = 0 Then
        For i = 1999 To 2099
          cAnio(j).Items.Add(i.ToString.PadLeft(4, "0"))
        Next
      End If

      If cMes(j).Items.Count = 0 Then
        For i = 1 To 12
          cMes(j).Items.Add(i.ToString.PadLeft(2, "0"))
        Next
      End If
    Next

    If cAnio(Index).SelectedIndex = -1 Then
      cAnio(Index).SelectedIndex = Today.Year - 1999
    Else
      If (CShort(cAnio(Index).Text) Mod 4 = 0 And CShort(cAnio(Index).Text) Mod 100 <> 0) Or _
      (CShort(cAnio(Index).Text) Mod 400 = 0) Then EsBisiesto = True
    End If

    If cMes(Index).SelectedIndex = -1 Then
      cMes(Index).SelectedIndex = Today.Month - 1
    End If

    Select Case cMes(Index).Text
      Case "11", "04", "06", "09"
        LimDias = 30
      Case "02"
        If EsBisiesto Then
          LimDias = 29
        Else
          LimDias = 28
        End If
      Case Else
        LimDias = 31
    End Select

    cDia(Index).Items.Clear()

    For i = 1 To LimDias
      cDia(Index).Items.Add(i.ToString.PadLeft(2, "0"))
    Next

    If cDia(Index).SelectedIndex = -1 Then
      cDia(Index).SelectedIndex = Today.Day - 1
    End If
  End Sub
  Private Sub Form_Intervalo_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
End Class