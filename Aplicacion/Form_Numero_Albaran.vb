Option Strict Off
Option Explicit On
Friend Class Form_Numero_Albaran
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
    Public WithEvents Label_Numero As System.Windows.Forms.Label
	Public WithEvents Marco As System.Windows.Forms.GroupBox
  Public WithEvents Aceptar As System.Windows.Forms.Button
  Friend WithEvents dcAlbaranes As System.Windows.Forms.ComboBox
	Public WithEvents Cancelar As System.Windows.Forms.Button
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Marco = New System.Windows.Forms.GroupBox
    Me.dcAlbaranes = New System.Windows.Forms.ComboBox
    Me.Label_Numero = New System.Windows.Forms.Label
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Marco.SuspendLayout()
    Me.SuspendLayout()
    '
    'Marco
    '
    Me.Marco.BackColor = System.Drawing.SystemColors.Control
    Me.Marco.Controls.Add(Me.dcAlbaranes)
    Me.Marco.Controls.Add(Me.Label_Numero)
    Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco.Location = New System.Drawing.Point(16, 16)
    Me.Marco.Name = "Marco"
    Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco.Size = New System.Drawing.Size(425, 145)
    Me.Marco.TabIndex = 2
    Me.Marco.TabStop = False
    Me.Marco.Text = "Número de Albarán"
    '
    'dcAlbaranes
    '
    Me.dcAlbaranes.FormattingEnabled = True
    Me.dcAlbaranes.Location = New System.Drawing.Point(284, 56)
    Me.dcAlbaranes.Name = "dcAlbaranes"
    Me.dcAlbaranes.Size = New System.Drawing.Size(121, 28)
    Me.dcAlbaranes.TabIndex = 6
    '
    'Label_Numero
    '
    Me.Label_Numero.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Numero.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Numero.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Numero.Location = New System.Drawing.Point(8, 64)
    Me.Label_Numero.Name = "Label_Numero"
    Me.Label_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Numero.Size = New System.Drawing.Size(281, 25)
    Me.Label_Numero.TabIndex = 3
    Me.Label_Numero.Text = "Introduzca el número de albarán:"
    '
    'Aceptar
    '
    Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
    Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Aceptar.Location = New System.Drawing.Point(456, 32)
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
    Me.Cancelar.Location = New System.Drawing.Point(456, 72)
    Me.Cancelar.Name = "Cancelar"
    Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Cancelar.Size = New System.Drawing.Size(89, 25)
    Me.Cancelar.TabIndex = 0
    Me.Cancelar.Text = "Cancelar"
    Me.Cancelar.UseVisualStyleBackColor = False
    '
    'Form_Numero_Albaran
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(559, 176)
    Me.Controls.Add(Me.Marco)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Cancelar)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(3, 22)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Numero_Albaran"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.Text = "Albaranes"
    Me.Marco.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region
  Private Preguntar As Boolean = False
  Private dtAlbaranes As DataTable = Nothing
  Private daAlbaranes As SqlClient.SqlDataAdapter = Nothing
  Private NumeroAlbaran As Long = 0
	Private frmAlbaran As Form_Albaranes
  Protected Overrides Sub Finalize()
	Me.dtAlbaranes.Dispose()
	Me.daAlbaranes.Dispose()
	Dispose(False)
	MyBase.Finalize()
End Sub

  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
	Me.NumeroAlbaran = CLng(Me.dcAlbaranes.Text)
	If Me.dcAlbaranes.Text = "" Then
	  MsgBox("El número no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
	Else
	  If Not IsNumeric(CInt(Me.dcAlbaranes.Text)) Then
		MsgBox("El número de albarán debe ser numérico", MsgBoxStyle.OkOnly, "Error")
	  Else
		If Me.dcAlbaranes.SelectedValue = Nothing Then
		  MsgBox("Este albarán no existe", MsgBoxStyle.OkOnly, "Error")
		Else
		  If frmAlbaran Is Nothing Then frmAlbaran = New Form_Albaranes(Me.NumeroAlbaran)
		  frmAlbaran.ShowDialog()
		  Me.Close()
		End If
	  End If
	End If
  End Sub
  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
	Preguntar = True
	Me.Close()
  End Sub
  Private Sub Form_Numero_Albaran_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
	Dim OK As MsgBoxResult
	If Preguntar Then
	  OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.OkCancel, "Facturas")
	  If OK = MsgBoxResult.Yes Then
		eventArgs.Cancel = True
	  Else
		[Global].Inicializar()
	  End If
	End If
  End Sub
  Private Sub Form_Numero_Albaran_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
	Try
	  With Me.dcAlbaranes
		.DropDownStyle = ComboBoxStyle.DropDown
		.AutoCompleteSource = AutoCompleteSource.ListItems
		.AutoCompleteMode = AutoCompleteMode.Append
	  End With
	  dtAlbaranes = New DataTable
	  daAlbaranes = New SqlClient.SqlDataAdapter()
	  daAlbaranes.SelectCommand = New SqlClient.SqlCommand("CONSULTA_ALBARANES", DBConnection)
	  daAlbaranes.SelectCommand.CommandType = CommandType.StoredProcedure
	  daAlbaranes.Fill(dtAlbaranes)

	  Me.dcAlbaranes.DataSource = dtAlbaranes
	  Me.dcAlbaranes.DisplayMember = "NUMERO"
	  Me.dcAlbaranes.ValueMember = "NUMERO"
	Catch ex As Exception
	  MsgBox("Error al cargar Albaranes: " & ex.Message)
	Finally
	End Try
  End Sub
End Class