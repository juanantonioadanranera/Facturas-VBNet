Option Strict Off
Option Explicit On
Friend Class Form_Prompt_Fecha
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
  Public WithEvents Cancelar As System.Windows.Forms.Button
  Public WithEvents Aceptar As System.Windows.Forms.Button
  Public WithEvents cAnio As System.Windows.Forms.ComboBox
  Public WithEvents cMes As System.Windows.Forms.ComboBox
  Public WithEvents cDia As System.Windows.Forms.ComboBox
  Public WithEvents Label2 As System.Windows.Forms.Label
  Public WithEvents Label1 As System.Windows.Forms.Label
  Public WithEvents Fecha As System.Windows.Forms.Label
  Public WithEvents Frame1 As System.Windows.Forms.GroupBox
  'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
  'Se puede modificar mediante el Diseñador de Windows Forms.
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Frame1 = New System.Windows.Forms.GroupBox
    Me.cAnio = New System.Windows.Forms.ComboBox
    Me.cMes = New System.Windows.Forms.ComboBox
    Me.cDia = New System.Windows.Forms.ComboBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.Fecha = New System.Windows.Forms.Label
    Me.Frame1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Cancelar
    '
    Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
    Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Cancelar.Location = New System.Drawing.Point(576, 72)
    Me.Cancelar.Name = "Cancelar"
    Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Cancelar.Size = New System.Drawing.Size(89, 25)
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
    Me.Aceptar.Location = New System.Drawing.Point(576, 32)
    Me.Aceptar.Name = "Aceptar"
    Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Aceptar.Size = New System.Drawing.Size(89, 25)
    Me.Aceptar.TabIndex = 2
    Me.Aceptar.Text = "Aceptar"
    Me.Aceptar.UseVisualStyleBackColor = False
    '
    'Frame1
    '
    Me.Frame1.BackColor = System.Drawing.SystemColors.Control
    Me.Frame1.Controls.Add(Me.cAnio)
    Me.Frame1.Controls.Add(Me.cMes)
    Me.Frame1.Controls.Add(Me.cDia)
    Me.Frame1.Controls.Add(Me.Label2)
    Me.Frame1.Controls.Add(Me.Label1)
    Me.Frame1.Controls.Add(Me.Fecha)
    Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Frame1.Location = New System.Drawing.Point(16, 16)
    Me.Frame1.Name = "Frame1"
    Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Frame1.Size = New System.Drawing.Size(545, 121)
    Me.Frame1.TabIndex = 0
    Me.Frame1.TabStop = False
    Me.Frame1.Text = "Fecha"
    '
    'cAnio
    '
    Me.cAnio.BackColor = System.Drawing.SystemColors.Window
    Me.cAnio.Cursor = System.Windows.Forms.Cursors.Default
    Me.cAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cAnio.ForeColor = System.Drawing.SystemColors.WindowText
    Me.cAnio.Location = New System.Drawing.Point(464, 40)
    Me.cAnio.Name = "cAnio"
    Me.cAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cAnio.Size = New System.Drawing.Size(65, 28)
    Me.cAnio.TabIndex = 8
    '
    'cMes
    '
    Me.cMes.BackColor = System.Drawing.SystemColors.Window
    Me.cMes.Cursor = System.Windows.Forms.Cursors.Default
    Me.cMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cMes.ForeColor = System.Drawing.SystemColors.WindowText
    Me.cMes.Location = New System.Drawing.Point(384, 40)
    Me.cMes.Name = "cMes"
    Me.cMes.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cMes.Size = New System.Drawing.Size(49, 28)
    Me.cMes.TabIndex = 7
    '
    'cDia
    '
    Me.cDia.BackColor = System.Drawing.SystemColors.Window
    Me.cDia.Cursor = System.Windows.Forms.Cursors.Default
    Me.cDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cDia.ForeColor = System.Drawing.SystemColors.WindowText
    Me.cDia.Location = New System.Drawing.Point(296, 40)
    Me.cDia.Name = "cDia"
    Me.cDia.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cDia.Size = New System.Drawing.Size(49, 28)
    Me.cDia.TabIndex = 6
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.SystemColors.Control
    Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label2.Location = New System.Drawing.Point(448, 40)
    Me.Label2.Name = "Label2"
    Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label2.Size = New System.Drawing.Size(9, 25)
    Me.Label2.TabIndex = 5
    Me.Label2.Text = "/"
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.SystemColors.Control
    Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label1.Location = New System.Drawing.Point(360, 40)
    Me.Label1.Name = "Label1"
    Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label1.Size = New System.Drawing.Size(9, 25)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "/"
    '
    'Fecha
    '
    Me.Fecha.BackColor = System.Drawing.SystemColors.Control
    Me.Fecha.Cursor = System.Windows.Forms.Cursors.Default
    Me.Fecha.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Fecha.Location = New System.Drawing.Point(16, 48)
    Me.Fecha.Name = "Fecha"
    Me.Fecha.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Fecha.Size = New System.Drawing.Size(297, 25)
    Me.Fecha.TabIndex = 1
    Me.Fecha.Text = "Introduzca la fecha de la factura:"
    '
    'Form_Prompt_Fecha
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(679, 152)
    Me.Controls.Add(Me.Cancelar)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Frame1)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(140, 255)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Prompt_Fecha"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Fecha de Factura"
    Me.Frame1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region
  Private Preguntar As Boolean = False
  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
    FechaFactura = cDia.Text & "/" & cMes.Text & "/" & cAnio.Text

    If EsFacturaVentas Then
      RegFacturaVentas.Fecha = CDate(FechaFactura)
    Else
      If EsFacturaCompras Then
        RegFacturaCompras.Fecha = CDate(FechaFactura)
      End If
    End If

    Dim frmPromptNumero As New Form_Prompt_Numero()
    frmPromptNumero.ShowDialog()
    Preguntar = False
    Me.Close()
  End Sub

  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
    Preguntar = True
    Me.Close()
  End Sub
  Private Sub cAño_Click()
    Call PresentaFecha()
  End Sub

  Private Sub cMes_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cMes.SelectedIndexChanged
    Call PresentaFecha()
  End Sub

  Private Sub Form_Prompt_Fecha_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
	cAnio.Items.Clear()
	cMes.Items.Clear()
	cDia.Items.Clear()

	Dim i As Short

	For i = 1999 To 2099
	  cAnio.Items.Add(i.ToString().PadLeft(4, "0"))
	Next

	For i = 1 To 12
	  cMes.Items.Add(i.ToString.PadLeft(2, "0"))
	Next
	Me.cAnio.SelectedIndex = CShort(Year(Today)) - 1999
	Me.cMes.SelectedIndex = CShort(Month(Today)) - 1

	Call PresentaFecha()
  End Sub
  Private Sub PresentaFecha() 'Rellena la lista de los dias de la fecha con valores adecuados
    Dim i, LimDias As Short
    Dim EsBisiesto As Boolean = False

    EsBisiesto = False

    If (CShort(cAnio.Text) Mod 4 = 0 And CShort(cAnio.Text) Mod 100 <> 0) _
      Or (CShort(cAnio.Text) Mod 400 = 0) Then EsBisiesto = True

    Select Case cMes.Text
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

    cDia.Items.Clear()

    For i = 1 To LimDias
      cDia.Items.Add(i.ToString().PadLeft(2, "0"))
    Next

    If Today.Day - 1 < Me.cDia.Items.Count Then
      Me.cDia.SelectedIndex = Today.Day - 1
    Else
      Me.cDia.SelectedIndex = Me.cDia.Items.Count - 1
    End If
  End Sub

  Private Sub Form_Prompt_Fecha_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    Dim Cancel As Short = eventArgs.Cancel
    Dim OK As MsgBoxResult
    If Preguntar Then
      OK = MsgBox("¿Desea cancelar la facturación?", MsgBoxStyle.YesNo, "Facturas")
      If OK = MsgBoxResult.Yes Then
        If EsFacturaVentas Then EsFacturaVentas = False
        If EsModificacionVentas Then EsModificacionVentas = False
        If EsFacturaCompras Then EsFacturaCompras = False
        If EsModificacionCompras Then EsModificacionCompras = False
      Else
        Cancel = OK
      End If
    End If
    eventArgs.Cancel = Cancel
  End Sub
End Class