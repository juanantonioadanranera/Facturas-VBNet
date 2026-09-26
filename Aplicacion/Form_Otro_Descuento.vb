Option Strict Off
Option Explicit On
Friend Class Form_Otro_Descuento
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
    Public WithEvents Aceptar As System.Windows.Forms.Button
	Public WithEvents Cancelar As System.Windows.Forms.Button
	Public WithEvents Text_Concepto As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label_Titulo As System.Windows.Forms.Label
	Public WithEvents Marco As System.Windows.Forms.GroupBox
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Marco = New System.Windows.Forms.GroupBox
        Me.Text_Concepto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label_Titulo = New System.Windows.Forms.Label
        Me.Marco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Aceptar.Location = New System.Drawing.Point(488, 24)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Aceptar.Size = New System.Drawing.Size(89, 25)
        Me.Aceptar.TabIndex = 5
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancelar.Location = New System.Drawing.Point(488, 64)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cancelar.Size = New System.Drawing.Size(89, 25)
        Me.Cancelar.TabIndex = 4
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Marco
        '
        Me.Marco.BackColor = System.Drawing.SystemColors.Control
        Me.Marco.Controls.Add(Me.Text_Concepto)
        Me.Marco.Controls.Add(Me.Label1)
        Me.Marco.Controls.Add(Me.Label_Titulo)
        Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Marco.Location = New System.Drawing.Point(8, 8)
        Me.Marco.Name = "Marco"
        Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Marco.Size = New System.Drawing.Size(465, 145)
        Me.Marco.TabIndex = 0
        Me.Marco.TabStop = False
        '
        'Text_Concepto
        '
        Me.Text_Concepto.AcceptsReturn = True
        Me.Text_Concepto.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Concepto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Concepto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Concepto.Location = New System.Drawing.Point(168, 88)
        Me.Text_Concepto.MaxLength = 0
        Me.Text_Concepto.Name = "Text_Concepto"
        Me.Text_Concepto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Concepto.Size = New System.Drawing.Size(249, 28)
        Me.Text_Concepto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(32, 96)
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
        'Form_Otro_Descuento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(590, 171)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Marco)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Otro_Descuento"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Concepto de Descuento"
        Me.Marco.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Soporte para la actualización "
	Private Shared m_vb6FormDefInstance As Form_Otro_Descuento
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form_Otro_Descuento
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form_Otro_Descuento()
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
	Dim frmPromptClientes As Form_Prompt_Clientes

	Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
		RegFacturaVentas.ConceptoDescuento = Me.Text_Concepto.Text
		If frmPromptClientes Is Nothing Then frmPromptClientes = Form_Prompt_Clientes
		frmPromptClientes.ShowDialog()
		Me.Close()
	End Sub
	
    Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
        Preguntar = True
        Me.Close()
    End Sub
    Private Sub Form_Otro_Descuento_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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