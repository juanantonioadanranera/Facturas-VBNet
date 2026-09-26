Option Strict Off
Option Explicit On
Friend Class Form_Prompt_Destino
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
	Public WithEvents Text_Destino As System.Windows.Forms.TextBox
	Public WithEvents Label_Destino As System.Windows.Forms.Label
	Public WithEvents Marco As System.Windows.Forms.GroupBox
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form_Prompt_Destino))
		Me.components = New System.ComponentModel.Container()
		Me.Cancelar = New System.Windows.Forms.Button
		Me.Aceptar = New System.Windows.Forms.Button
		Me.Marco = New System.Windows.Forms.GroupBox
		Me.Text_Destino = New System.Windows.Forms.TextBox
		Me.Label_Destino = New System.Windows.Forms.Label
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Facturas"
		Me.ClientSize = New System.Drawing.Size(543, 167)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleBaseSize = New System.Drawing.Size(0, 0)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form_Prompt_Destino"
		Me.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Cancelar.Text = "Cancelar"
		Me.Cancelar.Size = New System.Drawing.Size(89, 25)
		Me.Cancelar.Location = New System.Drawing.Point(440, 64)
		Me.Cancelar.TabIndex = 4
		Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
		Me.Cancelar.CausesValidation = True
		Me.Cancelar.Enabled = True
		Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Cancelar.TabStop = True
		Me.Cancelar.Name = "Cancelar"
		Me.Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Aceptar.Text = "Aceptar"
		Me.Aceptar.Size = New System.Drawing.Size(89, 25)
		Me.Aceptar.Location = New System.Drawing.Point(440, 24)
		Me.Aceptar.TabIndex = 3
		Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
		Me.Aceptar.CausesValidation = True
		Me.Aceptar.Enabled = True
		Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Aceptar.TabStop = True
		Me.Aceptar.Name = "Aceptar"
		Me.Marco.Text = "Destino"
		Me.Marco.Size = New System.Drawing.Size(409, 129)
		Me.Marco.Location = New System.Drawing.Point(16, 16)
		Me.Marco.TabIndex = 0
		Me.Marco.BackColor = System.Drawing.SystemColors.Control
		Me.Marco.Enabled = True
		Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Marco.Visible = True
		Me.Marco.Name = "Marco"
		Me.Text_Destino.AutoSize = False
		Me.Text_Destino.Size = New System.Drawing.Size(297, 28)
		Me.Text_Destino.Location = New System.Drawing.Point(96, 48)
		Me.Text_Destino.TabIndex = 2
		Me.Text_Destino.AcceptsReturn = True
		Me.Text_Destino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text_Destino.BackColor = System.Drawing.SystemColors.Window
		Me.Text_Destino.CausesValidation = True
		Me.Text_Destino.Enabled = True
		Me.Text_Destino.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text_Destino.HideSelection = True
		Me.Text_Destino.ReadOnly = False
		Me.Text_Destino.Maxlength = 0
		Me.Text_Destino.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text_Destino.MultiLine = False
		Me.Text_Destino.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text_Destino.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text_Destino.TabStop = True
		Me.Text_Destino.Visible = True
		Me.Text_Destino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text_Destino.Name = "Text_Destino"
		Me.Label_Destino.Text = "Destino"
		Me.Label_Destino.Size = New System.Drawing.Size(81, 25)
		Me.Label_Destino.Location = New System.Drawing.Point(16, 56)
		Me.Label_Destino.TabIndex = 1
		Me.Label_Destino.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label_Destino.BackColor = System.Drawing.SystemColors.Control
		Me.Label_Destino.Enabled = True
		Me.Label_Destino.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label_Destino.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label_Destino.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label_Destino.UseMnemonic = True
		Me.Label_Destino.Visible = True
		Me.Label_Destino.AutoSize = False
		Me.Label_Destino.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label_Destino.Name = "Label_Destino"
		Me.Controls.Add(Cancelar)
		Me.Controls.Add(Aceptar)
		Me.Controls.Add(Marco)
		Me.Marco.Controls.Add(Text_Destino)
		Me.Marco.Controls.Add(Label_Destino)
	End Sub
#End Region 
#Region "Soporte para la actualización "
	Private Shared m_vb6FormDefInstance As Form_Prompt_Destino
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form_Prompt_Destino
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form_Prompt_Destino()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim Preguntar As Boolean
	Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
		Preguntar = True
		RegFacturaVentas.Destino = Me.Text_Destino.Text
		Me.Text_Destino.Text = ""
		Dim frmPromptMaterial As New Form_Prompt_Materiales()
		frmPromptMaterial.ShowDialog()
		Preguntar = False
		Me.Close()
	End Sub
	
	Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
		Me.Close()
	End Sub
	
	Private Sub Form_Prompt_Destino_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim Cancel As Short = eventArgs.Cancel
		Dim OK As MsgBoxResult
		If Preguntar Then
			OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
			If OK = MsgBoxResult.Yes Then
				EsFacturaVentas = False
				If EsModificacionVentas Then EsModificacionVentas = False
			End If
			Preguntar = False
		End If
		eventArgs.Cancel = Cancel
	End Sub
End Class