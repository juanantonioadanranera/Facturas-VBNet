Option Strict Off
Option Explicit On
Friend Class Form_Prompt_Clientes
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
  Public WithEvents Label_Prompt As System.Windows.Forms.Label
  Friend WithEvents dcClientes As System.Windows.Forms.ComboBox
  Public WithEvents Marco As System.Windows.Forms.GroupBox
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Marco = New System.Windows.Forms.GroupBox
    Me.dcClientes = New System.Windows.Forms.ComboBox
    Me.Label_Prompt = New System.Windows.Forms.Label
    Me.Marco.SuspendLayout()
    Me.SuspendLayout()
    '
    'Cancelar
    '
    Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
    Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Cancelar.Location = New System.Drawing.Point(576, 64)
    Me.Cancelar.Name = "Cancelar"
    Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Cancelar.Size = New System.Drawing.Size(89, 25)
    Me.Cancelar.TabIndex = 2
    Me.Cancelar.Text = "Cancelar"
    Me.Cancelar.UseVisualStyleBackColor = False
    '
    'Aceptar
    '
    Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
    Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Aceptar.Location = New System.Drawing.Point(576, 24)
    Me.Aceptar.Name = "Aceptar"
    Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Aceptar.Size = New System.Drawing.Size(89, 25)
    Me.Aceptar.TabIndex = 1
    Me.Aceptar.Text = "Aceptar"
    Me.Aceptar.UseVisualStyleBackColor = False
    '
    'Marco
    '
    Me.Marco.BackColor = System.Drawing.SystemColors.Control
    Me.Marco.Controls.Add(Me.dcClientes)
    Me.Marco.Controls.Add(Me.Label_Prompt)
    Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco.Location = New System.Drawing.Point(16, 8)
    Me.Marco.Name = "Marco"
    Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco.Size = New System.Drawing.Size(545, 121)
    Me.Marco.TabIndex = 0
    Me.Marco.TabStop = False
    Me.Marco.Text = "Clientes"
    '
    'dcClientes
    '
    Me.dcClientes.FormattingEnabled = True
    Me.dcClientes.Location = New System.Drawing.Point(191, 45)
    Me.dcClientes.Name = "dcClientes"
    Me.dcClientes.Size = New System.Drawing.Size(328, 28)
    Me.dcClientes.TabIndex = 5
    '
    'Label_Prompt
    '
    Me.Label_Prompt.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Prompt.Location = New System.Drawing.Point(8, 48)
    Me.Label_Prompt.Name = "Label_Prompt"
    Me.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Prompt.Size = New System.Drawing.Size(177, 25)
    Me.Label_Prompt.TabIndex = 3
    Me.Label_Prompt.Text = "Seleccione el cliente:"
    '
    'Form_Prompt_Clientes
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(678, 150)
    Me.Controls.Add(Me.Cancelar)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Marco)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(380, 448)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Prompt_Clientes"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Clientes"
    Me.Marco.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region
  Private Preguntar As Boolean = False
  Private CodCli As Long = 0
  Private daClientes As SqlClient.SqlDataAdapter
  Private dtClienteNombre As DataTable
  Private frmCliente As Form_Clientes
  Private frmDestino As Form_Destino
  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
	Try
	  If Me.dcClientes.SelectedValue <> Nothing Then
		CodCli = Me.dcClientes.SelectedValue

		If EsFacturaVentas Then
		  RegFacturaVentas.Cod_Cli = Me.CodCli
                    If frmDestino Is Nothing Then frmDestino = New Form_Destino(Me.CodCli, RegFacturaVentas.Suministros)
                    frmDestino.ShowDialog()
		  Me.Close()
		Else
		  If frmCliente Is Nothing Then frmCliente = New Form_Clientes(Me.CodCli)
		  frmCliente.ShowDialog()
		  Me.Close()
		End If
	  Else
		MsgBox("Debe escoger un cliente", MsgBoxStyle.OkOnly, "Error")
		Me.dcClientes.Focus()
	  End If
	Catch ex As Exception
	  MsgBox("Error al cargar clientes: " & ex.Message)
	Finally
	End Try
  End Sub
  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
	If Not Consulta_Cliente Then
	  Preguntar = True
	Else
	  Consulta_Cliente = False
        End If
        Me.Close()
  End Sub
    Private Sub Form_Prompt_Clientes_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles Me.Closing
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
  Private Sub Form_Prompt_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	Try
	  dtClienteNombre = New DataTable
	  daClientes = New SqlClient.SqlDataAdapter()
	  daClientes.SelectCommand = New SqlClient.SqlCommand("CONSULTA_CLIENTES", DBConnection)
	  daClientes.SelectCommand.CommandType = CommandType.StoredProcedure
	  daClientes.Fill(dtClienteNombre)
	  Me.dcClientes.DataSource = dtClienteNombre
	  Me.dcClientes.DisplayMember = "NOMBRE"
	  Me.dcClientes.ValueMember = "COD_CLI"
	Catch ex As Exception
	  MsgBox("Error al cargar clientes: " & ex.Message)
	Finally
	End Try
  End Sub
End Class