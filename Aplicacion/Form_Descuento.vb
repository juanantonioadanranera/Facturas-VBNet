Option Strict Off
Option Explicit On
Friend Class Form_Descuento
  Inherits System.Windows.Forms.Form
  Public WithEvents cDescuento As System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
#Region "Código generado por el Diseñador de Windows Forms "
	Public Sub New()
    MyBase.New()
    Me.cDescuento = New System.Collections.Generic.List(Of System.Windows.Forms.ComboBox)
    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()

    Me.cDescuento.Insert(0, Me._cDescuento_0)
    Me.cDescuento.Insert(1, Me._cDescuento_1)
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
	Public WithEvents _cDescuento_1 As System.Windows.Forms.ComboBox
	Public WithEvents _cDescuento_0 As System.Windows.Forms.ComboBox
	Public WithEvents _Label_1 As System.Windows.Forms.Label
	Public WithEvents _Label_0 As System.Windows.Forms.Label
	Public WithEvents Label_Cantidad As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
  'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
  'Se puede modificar mediante el Diseñador de Windows Forms.
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Frame1 = New System.Windows.Forms.GroupBox
    Me._cDescuento_1 = New System.Windows.Forms.ComboBox
    Me._cDescuento_0 = New System.Windows.Forms.ComboBox
    Me._Label_1 = New System.Windows.Forms.Label
    Me._Label_0 = New System.Windows.Forms.Label
    Me.Label_Cantidad = New System.Windows.Forms.Label
    Me.Frame1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Cancelar
    '
    Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
    Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Cancelar.Location = New System.Drawing.Point(536, 72)
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
    Me.Aceptar.Location = New System.Drawing.Point(536, 32)
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
    Me.Frame1.Controls.Add(Me._cDescuento_1)
    Me.Frame1.Controls.Add(Me._cDescuento_0)
    Me.Frame1.Controls.Add(Me._Label_1)
    Me.Frame1.Controls.Add(Me._Label_0)
    Me.Frame1.Controls.Add(Me.Label_Cantidad)
    Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Frame1.Location = New System.Drawing.Point(16, 16)
    Me.Frame1.Name = "Frame1"
    Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Frame1.Size = New System.Drawing.Size(505, 121)
    Me.Frame1.TabIndex = 4
    Me.Frame1.TabStop = False
    Me.Frame1.Text = "Tipo de Descuento"
    '
    '_cDescuento_1
    '
    Me._cDescuento_1.BackColor = System.Drawing.SystemColors.Window
    Me._cDescuento_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._cDescuento_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cDescuento_1.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cDescuento_1.Location = New System.Drawing.Point(400, 48)
    Me._cDescuento_1.Name = "_cDescuento_1"
    Me._cDescuento_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cDescuento_1.Size = New System.Drawing.Size(57, 28)
    Me._cDescuento_1.Sorted = True
    Me._cDescuento_1.TabIndex = 0
    '
    '_cDescuento_0
    '
    Me._cDescuento_0.BackColor = System.Drawing.SystemColors.Window
    Me._cDescuento_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._cDescuento_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me._cDescuento_0.ForeColor = System.Drawing.SystemColors.WindowText
    Me._cDescuento_0.Location = New System.Drawing.Point(312, 48)
    Me._cDescuento_0.Name = "_cDescuento_0"
    Me._cDescuento_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._cDescuento_0.Size = New System.Drawing.Size(57, 28)
    Me._cDescuento_0.Sorted = True
    Me._cDescuento_0.TabIndex = 1
    '
    '_Label_1
    '
    Me._Label_1.BackColor = System.Drawing.SystemColors.Control
    Me._Label_1.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label_1.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label_1.Location = New System.Drawing.Point(376, 48)
    Me._Label_1.Name = "_Label_1"
    Me._Label_1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label_1.Size = New System.Drawing.Size(25, 57)
    Me._Label_1.TabIndex = 7
    Me._Label_1.Text = ","
    '
    '_Label_0
    '
    Me._Label_0.BackColor = System.Drawing.SystemColors.Control
    Me._Label_0.Cursor = System.Windows.Forms.Cursors.Default
    Me._Label_0.ForeColor = System.Drawing.SystemColors.ControlText
    Me._Label_0.Location = New System.Drawing.Point(464, 48)
    Me._Label_0.Name = "_Label_0"
    Me._Label_0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me._Label_0.Size = New System.Drawing.Size(33, 33)
    Me._Label_0.TabIndex = 6
    Me._Label_0.Text = "%"
    '
    'Label_Cantidad
    '
    Me.Label_Cantidad.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Cantidad.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Cantidad.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Cantidad.Location = New System.Drawing.Point(16, 56)
    Me.Label_Cantidad.Name = "Label_Cantidad"
    Me.Label_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Cantidad.Size = New System.Drawing.Size(289, 25)
    Me.Label_Cantidad.TabIndex = 5
    Me.Label_Cantidad.Text = "Seleccione el descuento aplicable"
    '
    'Form_Descuento
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(638, 151)
    Me.Controls.Add(Me.Cancelar)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Frame1)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(117, 348)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Descuento"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Descuento"
    Me.Frame1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region 
#Region "Soporte para la actualización "
	Private Shared m_vb6FormDefInstance As Form_Descuento
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form_Descuento
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form_Descuento()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private frmConceptoDescuento As Form_Concepto_Descuento
	Private frmPromptClientes As Form_Prompt_Clientes
	Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
		If cDescuento(0).Text <> "" Then
			If cDescuento(1).Text <> "" Then
				RegFacturaVentas.TipoDescuento = CDbl(cDescuento(0).Text & cDescuento(1).Text) / 10000
				HayDescuento = True
				frmConceptoDescuento = New Form_Concepto_Descuento()
				frmConceptoDescuento.ShowDialog()
				Me.Close()
			Else
				MsgBox("Debe seleccionar un tipo de descuento", MsgBoxStyle.OkOnly, "Facturas")
			End If
		Else
			MsgBox("Debe seleccionar un tipo de descuento", MsgBoxStyle.OkOnly, "Facturas")
		End If
	End Sub

	Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
		Me.Close()
	End Sub

	Private Sub Form_Descuento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Byte
		Dim j As Byte
		For j = 0 To 1
			For i = 0 To 99
                Me.cDescuento(j).Items.Add(i.ToString.PadLeft(2, "0"))
			Next i
		Next j
		Me.cDescuento(0).SelectedIndex = 2
		Me.cDescuento(1).SelectedIndex = 0
	End Sub

	Private Sub Form_Descuento_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Cancel As Boolean = eventArgs.Cancel
		Dim OK As MsgBoxResult
		If HayDescuento = False Then
			OK = MsgBox("¿Quiere hacer la factura sin descuento?", MsgBoxStyle.YesNo, "Facturas")
			If OK = MsgBoxResult.Yes Then
				RegFacturaVentas.TipoDescuento = CDbl(0)
				If frmPromptClientes Is Nothing OrElse frmPromptClientes.IsDisposed Then
					frmPromptClientes = New Form_Prompt_Clientes()
				End If
				frmPromptClientes.ShowDialog()
			Else
                OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
                If OK = MsgBoxResult.Yes Then
                    Cancel = False
                Else
                    Cancel = True
                End If
			End If
		End If
		eventArgs.Cancel = Cancel
	End Sub
End Class