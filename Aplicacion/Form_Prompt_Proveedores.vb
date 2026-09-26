Option Strict Off
Option Explicit On
Friend Class Form_Prompt_Proveedores
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
    Public WithEvents Label_Prompt As System.Windows.Forms.Label
    Public WithEvents Marco As System.Windows.Forms.GroupBox
  Public WithEvents Aceptar As System.Windows.Forms.Button
  Friend WithEvents dcProveedores As System.Windows.Forms.ComboBox
    Public WithEvents Cancelar As System.Windows.Forms.Button
    'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Marco = New System.Windows.Forms.GroupBox
    Me.Label_Prompt = New System.Windows.Forms.Label
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Cancelar = New System.Windows.Forms.Button
    Me.dcProveedores = New System.Windows.Forms.ComboBox
    Me.Marco.SuspendLayout()
    Me.SuspendLayout()
    '
    'Marco
    '
    Me.Marco.BackColor = System.Drawing.SystemColors.Control
    Me.Marco.Controls.Add(Me.dcProveedores)
    Me.Marco.Controls.Add(Me.Label_Prompt)
    Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco.Location = New System.Drawing.Point(8, 16)
    Me.Marco.Name = "Marco"
    Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco.Size = New System.Drawing.Size(577, 121)
    Me.Marco.TabIndex = 3
    Me.Marco.TabStop = False
    Me.Marco.Text = "Proveedores"
    '
    'Label_Prompt
    '
    Me.Label_Prompt.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Prompt.Location = New System.Drawing.Point(16, 48)
    Me.Label_Prompt.Name = "Label_Prompt"
    Me.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Prompt.Size = New System.Drawing.Size(209, 25)
    Me.Label_Prompt.TabIndex = 4
    Me.Label_Prompt.Text = "Seleccione el proveedor:"
    '
    'Aceptar
    '
    Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
    Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Aceptar.Location = New System.Drawing.Point(600, 24)
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
    Me.Cancelar.Location = New System.Drawing.Point(600, 64)
    Me.Cancelar.Name = "Cancelar"
    Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Cancelar.Size = New System.Drawing.Size(89, 25)
    Me.Cancelar.TabIndex = 2
    Me.Cancelar.Text = "Cancelar"
    Me.Cancelar.UseVisualStyleBackColor = False
    '
    'dcProveedores
    '
    Me.dcProveedores.FormattingEnabled = True
    Me.dcProveedores.Location = New System.Drawing.Point(242, 45)
    Me.dcProveedores.Name = "dcProveedores"
    Me.dcProveedores.Size = New System.Drawing.Size(320, 28)
    Me.dcProveedores.TabIndex = 4
    '
    'Form_Prompt_Proveedores
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(703, 150)
    Me.Controls.Add(Me.Marco)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Cancelar)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(3, 22)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Prompt_Proveedores"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.Text = "Proveedores"
    Me.Marco.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region
  Dim Preguntar As Boolean = False
  Dim frmProveedor As Form_Proveedores

  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
	Dim CodProveedor As Long

	If Me.dcProveedores.SelectedValue <> Nothing Then
	  CodProveedor = Me.dcProveedores.SelectedValue
	  RegFacturaCompras.Cod_Pro = CStr(CodProveedor)
	  If Not Alta_Proveedor Then
		If frmProveedor Is Nothing OrElse frmProveedor.IsDisposed Then frmProveedor = New Form_Proveedores(CodProveedor)
	  Else
		If frmProveedor Is Nothing OrElse frmProveedor.IsDisposed Then frmProveedor = New Form_Proveedores()
	  End If

	  frmProveedor.ShowDialog()
	  Me.Close()
	Else
	  MsgBox("Debe escoger un Proveedor", MsgBoxStyle.OkOnly, "Error")
	  Me.dcProveedores.Focus()
	End If
  End Sub

  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
    Preguntar = True
    Me.Close()
  End Sub

  Private Sub Form_Prompt_Proveedores_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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

  Private Sub Form_Prompt_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    With Me.dcProveedores
      .DropDownStyle = ComboBoxStyle.DropDown
      .AutoCompleteSource = AutoCompleteSource.ListItems
      .AutoCompleteMode = AutoCompleteMode.Append
    End With
	Dim dtProveedorNombre As DataTable = New DataTable
	Dim daProveedores As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
	Try
	  daProveedores.SelectCommand = New SqlClient.SqlCommand("CONSULTA_PROVEEDORES", DBConnection)
	  daProveedores.SelectCommand.CommandType = CommandType.StoredProcedure
	  daProveedores.Fill(dtProveedorNombre)
	  Me.dcProveedores.DataSource = dtProveedorNombre
	  Me.dcProveedores.DisplayMember = "NOMBRE"
	  Me.dcProveedores.ValueMember = "COD_PRO"
	Catch ex As Exception
	  MsgBox("Error al cargar proveedores: " & ex.Message)
	Finally
	End Try
  End Sub
End Class