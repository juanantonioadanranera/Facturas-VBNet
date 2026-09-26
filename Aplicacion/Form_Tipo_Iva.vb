Option Strict Off
Option Explicit On
Friend Class Form_Tipo_Iva
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
	Public WithEvents cTipoIVA As System.Windows.Forms.ComboBox
	Public WithEvents Label_IVA As System.Windows.Forms.Label
	Public WithEvents Marco As System.Windows.Forms.GroupBox
	Public WithEvents Aceptar As System.Windows.Forms.Button
	Public WithEvents Cancelar As System.Windows.Forms.Button
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.Marco = New System.Windows.Forms.GroupBox
Me.cTipoIVA = New System.Windows.Forms.ComboBox
Me.Label_IVA = New System.Windows.Forms.Label
Me.Aceptar = New System.Windows.Forms.Button
Me.Cancelar = New System.Windows.Forms.Button
Me.Marco.SuspendLayout()
Me.SuspendLayout()
'
'Marco
'
Me.Marco.BackColor = System.Drawing.SystemColors.Control
Me.Marco.Controls.Add(Me.cTipoIVA)
Me.Marco.Controls.Add(Me.Label_IVA)
Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
Me.Marco.Location = New System.Drawing.Point(16, 16)
Me.Marco.Name = "Marco"
Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Marco.Size = New System.Drawing.Size(417, 121)
Me.Marco.TabIndex = 3
Me.Marco.TabStop = False
Me.Marco.Text = "Tipo de IVA"
'
'cTipoIVA
'
Me.cTipoIVA.BackColor = System.Drawing.SystemColors.Window
Me.cTipoIVA.Cursor = System.Windows.Forms.Cursors.Default
Me.cTipoIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
Me.cTipoIVA.ForeColor = System.Drawing.SystemColors.WindowText
Me.cTipoIVA.Location = New System.Drawing.Point(312, 48)
Me.cTipoIVA.Name = "cTipoIVA"
Me.cTipoIVA.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.cTipoIVA.Size = New System.Drawing.Size(73, 28)
Me.cTipoIVA.TabIndex = 0
'
'Label_IVA
'
Me.Label_IVA.BackColor = System.Drawing.SystemColors.Control
Me.Label_IVA.Cursor = System.Windows.Forms.Cursors.Default
Me.Label_IVA.ForeColor = System.Drawing.SystemColors.ControlText
Me.Label_IVA.Location = New System.Drawing.Point(16, 56)
Me.Label_IVA.Name = "Label_IVA"
Me.Label_IVA.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Label_IVA.Size = New System.Drawing.Size(289, 25)
Me.Label_IVA.TabIndex = 4
Me.Label_IVA.Text = "Seleccione el tipo de IVA aplicable"
'
'Aceptar
'
Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
Me.Aceptar.Location = New System.Drawing.Point(448, 32)
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
Me.Cancelar.Location = New System.Drawing.Point(448, 72)
Me.Cancelar.Name = "Cancelar"
Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.Cancelar.Size = New System.Drawing.Size(89, 25)
Me.Cancelar.TabIndex = 2
Me.Cancelar.Text = "Cancelar"
Me.Cancelar.UseVisualStyleBackColor = False
'
'Form_Tipo_Iva
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.BackColor = System.Drawing.SystemColors.Control
Me.ClientSize = New System.Drawing.Size(546, 151)
Me.Controls.Add(Me.Marco)
Me.Controls.Add(Me.Aceptar)
Me.Controls.Add(Me.Cancelar)
Me.Cursor = System.Windows.Forms.Cursors.Default
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
Me.Location = New System.Drawing.Point(3, 22)
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "Form_Tipo_Iva"
Me.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.ShowInTaskbar = False
Me.Text = "Tipo de IVA"
Me.Marco.ResumeLayout(False)
Me.ResumeLayout(False)

End Sub
#End Region 
	Dim Preguntar As Boolean = False
	Dim frmDescuento As Form_Descuento
	Dim frmPromptClientes As Form_Prompt_Clientes
	Dim frmImporteFactura As Form_Importe_Factura
	Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
		Dim OK As MsgBoxResult
		Preguntar = True
		If Me.cTipoIVA.SelectedIndex <> -1 Then
			If EsFacturaVentas Then
				RegFacturaVentas.TipoIva = CDbl(Mid(cTipoIVA.Text, 1, 2)) / 100
                'OK = MsgBox("Desea establecer un descuento para esta factura?", MsgBoxStyle.YesNo, "Facturas")
                '            If OK = MsgBoxResult.Yes Then
                '                If frmDescuento Is Nothing OrElse frmDescuento.IsDisposed Then frmDescuento = New Form_Descuento()
                '                frmDescuento.ShowDialog()
                '                Preguntar = False
                '                Me.Close()
                '            Else
                '            End If
                HayDescuento = False
                RegFacturaVentas.TipoDescuento = CDbl(0)
                If frmPromptClientes Is Nothing OrElse frmPromptClientes.IsDisposed Then frmPromptClientes = New Form_Prompt_Clientes()
                frmPromptClientes.ShowDialog()
                Preguntar = False
                Me.Close()

            Else
				If EsFacturaCompras Then
					RegFacturaCompras.TipoIva = CShort(Mid(cTipoIVA.Text, 1, 2))
					If frmPromptClientes Is Nothing OrElse frmPromptClientes.IsDisposed Then frmImporteFactura = New Form_Importe_Factura()
					frmImporteFactura.ShowDialog()
					Preguntar = False
					Me.Close()
				End If
			End If
		Else
			MsgBox("Debe seleccionar un Tipo de IVA", MsgBoxStyle.OkOnly, "Facturas")
		End If
	End Sub
	Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
		Me.Close()
	End Sub

	Private Sub Form_Tipo_Iva_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
	Dim strTipo As String
		strTipo = "0 %"
		Me.cTipoIVA.Items.Add(strTipo)
		strTipo = "10 %"
		Me.cTipoIVA.Items.Add(strTipo)
		strTipo = "21 %"
		Me.cTipoIVA.Items.Add(strTipo)
		Me.cTipoIVA.SelectedIndex = Me.cTipoIVA.Items.Count - 1
	End Sub

	Private Sub Form_Tipo_Iva_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim Cancel As Short = eventArgs.Cancel
		Dim OK As MsgBoxResult
		If Preguntar Then
			OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
			If OK = MsgBoxResult.Yes Then
				[Global].Inicializar()
			Else
				Cancel = OK
			End If
		End If
		eventArgs.Cancel = Cancel
	End Sub
End Class