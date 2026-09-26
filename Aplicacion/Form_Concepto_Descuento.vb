Option Strict Off
Option Explicit On
Friend Class Form_Concepto_Descuento
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
	Public WithEvents cConcepto As System.Windows.Forms.ComboBox
	Public WithEvents Otro As System.Windows.Forms.Button
	Public WithEvents Cancelar As System.Windows.Forms.Button
	Public WithEvents Aceptar As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label_Titulo As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.cConcepto = New System.Windows.Forms.ComboBox
Me.Otro = New System.Windows.Forms.Button
Me.Cancelar = New System.Windows.Forms.Button
Me.Aceptar = New System.Windows.Forms.Button
Me.Frame1 = New System.Windows.Forms.GroupBox
Me.Label1 = New System.Windows.Forms.Label
Me.Label_Titulo = New System.Windows.Forms.Label
Me.Frame1.SuspendLayout()
Me.SuspendLayout()
'
'cConcepto
'
Me.cConcepto.BackColor = System.Drawing.SystemColors.Window
Me.cConcepto.Cursor = System.Windows.Forms.Cursors.Default
Me.cConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.cConcepto.ForeColor = System.Drawing.SystemColors.WindowText
Me.cConcepto.Location = New System.Drawing.Point(176, 80)
Me.cConcepto.Name = "cConcepto"
Me.cConcepto.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cConcepto.Size = New System.Drawing.Size(289, 28)
Me.cConcepto.TabIndex = 6
'
'Otro
'
Me.Otro.BackColor = System.Drawing.SystemColors.Control
Me.Otro.Cursor = System.Windows.Forms.Cursors.Default
Me.Otro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Otro.ForeColor = System.Drawing.SystemColors.ControlText
Me.Otro.Location = New System.Drawing.Point(512, 96)
Me.Otro.Name = "Otro"
Me.Otro.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Otro.Size = New System.Drawing.Size(89, 25)
Me.Otro.TabIndex = 5
Me.Otro.Text = "Otro"
Me.Otro.UseVisualStyleBackColor = False
'
'Cancelar
'
Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
Me.Cancelar.Location = New System.Drawing.Point(512, 56)
Me.Cancelar.Name = "Cancelar"
Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Cancelar.Size = New System.Drawing.Size(89, 25)
Me.Cancelar.TabIndex = 4
Me.Cancelar.Text = "Cancelar"
Me.Cancelar.UseVisualStyleBackColor = False
'
'Aceptar
'
Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
Me.Aceptar.Location = New System.Drawing.Point(512, 16)
Me.Aceptar.Name = "Aceptar"
Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Aceptar.Size = New System.Drawing.Size(89, 25)
Me.Aceptar.TabIndex = 3
Me.Aceptar.Text = "Aceptar"
Me.Aceptar.UseVisualStyleBackColor = False
'
'Frame1
'
Me.Frame1.BackColor = System.Drawing.SystemColors.Control
Me.Frame1.Controls.Add(Me.Label1)
Me.Frame1.Controls.Add(Me.Label_Titulo)
Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
Me.Frame1.Location = New System.Drawing.Point(16, 16)
Me.Frame1.Name = "Frame1"
Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Frame1.Size = New System.Drawing.Size(473, 113)
Me.Frame1.TabIndex = 0
Me.Frame1.TabStop = False
Me.Frame1.Text = "Descuento"
'
'Label1
'
Me.Label1.BackColor = System.Drawing.SystemColors.Control
Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label1.Location = New System.Drawing.Point(16, 72)
Me.Label1.Name = "Label1"
Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label1.Size = New System.Drawing.Size(129, 25)
Me.Label1.TabIndex = 2
Me.Label1.Text = "Descuento por:"
'
'Label_Titulo
'
Me.Label_Titulo.BackColor = System.Drawing.SystemColors.Control
Me.Label_Titulo.Cursor = System.Windows.Forms.Cursors.Default
Me.Label_Titulo.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label_Titulo.Location = New System.Drawing.Point(16, 32)
Me.Label_Titulo.Name = "Label_Titulo"
Me.Label_Titulo.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label_Titulo.Size = New System.Drawing.Size(433, 33)
Me.Label_Titulo.TabIndex = 1
Me.Label_Titulo.Text = "Introduzca el concepto por que se hace el descuento:"
'
'Form_Concepto_Descuento
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.BackColor = System.Drawing.SystemColors.Control
Me.ClientSize = New System.Drawing.Size(615, 142)
Me.Controls.Add(Me.cConcepto)
Me.Controls.Add(Me.Otro)
Me.Controls.Add(Me.Cancelar)
Me.Controls.Add(Me.Aceptar)
Me.Controls.Add(Me.Frame1)
Me.Cursor = System.Windows.Forms.Cursors.Default
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
Me.Location = New System.Drawing.Point(3, 22)
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "Form_Concepto_Descuento"
Me.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.ShowInTaskbar = False
Me.Text = "Concepto de Descuento"
Me.Frame1.ResumeLayout(False)
Me.ResumeLayout(False)

End Sub
#End Region 
#Region "Soporte para la actualización "
	Private Shared m_vb6FormDefInstance As Form_Concepto_Descuento
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form_Concepto_Descuento
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form_Concepto_Descuento()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
Dim Preguntar As Boolean = False
Dim frmOtroDescuento As Form_Otro_Descuento
Dim frmPromptClientes As Form_Prompt_Clientes
Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
	RegFacturaVentas.ConceptoDescuento = Me.cConcepto.Items(Me.cConcepto.SelectedIndex)
	If frmPromptClientes Is Nothing OrElse frmPromptClientes.IsDisposed Then
		frmPromptClientes = New Form_Prompt_Clientes()
	End If
	frmPromptClientes.ShowDialog()
	Me.Close()
End Sub
Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
	Preguntar = True
	Me.Close()
End Sub
Private Sub Form_Concepto_Descuento_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
	Dim OK As MsgBoxResult
		If Preguntar Then
			OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
            If OK = MsgBoxResult.Yes Then
                [Global].Inicializar()
            Else
                eventArgs.Cancel = True
            End If
			Preguntar = False
		End If
End Sub
Private Sub Form_Concepto_Descuento_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
	Me.cConcepto.Items.Add(("cantidad"))
	Me.cConcepto.Items.Add(("pronto pago"))
	Me.cConcepto.SelectedIndex = Me.cConcepto.Items.Count - 1
End Sub
Private Sub Otro_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Otro.Click
	If frmOtroDescuento Is Nothing OrElse frmOtroDescuento.IsDisposed Then
		frmOtroDescuento = New Form_Otro_Descuento()
	End If
	frmOtroDescuento.ShowDialog()
	Preguntar = False
	Me.Close()
End Sub
End Class