Option Strict Off
Option Explicit On
Friend Class Form_Destino
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
	Friend WithEvents dcDestinos As System.Windows.Forms.ComboBox
	Public WithEvents Cancelar As System.Windows.Forms.Button
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Marco = New System.Windows.Forms.GroupBox()
        Me.dcDestinos = New System.Windows.Forms.ComboBox()
        Me.Label_Prompt = New System.Windows.Forms.Label()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Marco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Marco
        '
        Me.Marco.BackColor = System.Drawing.SystemColors.Control
        Me.Marco.Controls.Add(Me.dcDestinos)
        Me.Marco.Controls.Add(Me.Label_Prompt)
        Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Marco.Location = New System.Drawing.Point(32, 30)
        Me.Marco.Name = "Marco"
        Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Marco.Size = New System.Drawing.Size(1042, 223)
        Me.Marco.TabIndex = 2
        Me.Marco.TabStop = False
        Me.Marco.Text = "Destinos"
        '
        'dcDestinos
        '
        Me.dcDestinos.FormattingEnabled = True
        Me.dcDestinos.Location = New System.Drawing.Point(382, 83)
        Me.dcDestinos.Name = "dcDestinos"
        Me.dcDestinos.Size = New System.Drawing.Size(624, 45)
        Me.dcDestinos.TabIndex = 3
        '
        'Label_Prompt
        '
        Me.Label_Prompt.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Prompt.Location = New System.Drawing.Point(16, 89)
        Me.Label_Prompt.Name = "Label_Prompt"
        Me.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Prompt.Size = New System.Drawing.Size(354, 46)
        Me.Label_Prompt.TabIndex = 4
        Me.Label_Prompt.Text = "Seleccione el destino:"
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Aceptar.Location = New System.Drawing.Point(1104, 59)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Aceptar.Size = New System.Drawing.Size(178, 46)
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
        Me.Cancelar.Location = New System.Drawing.Point(1104, 133)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cancelar.Size = New System.Drawing.Size(178, 46)
        Me.Cancelar.TabIndex = 0
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Form_Destino
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(10, 24)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(655, 150)
        Me.Controls.Add(Me.Marco)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Cancelar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(140, 185)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Destino"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Destino"
        Me.Marco.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim Preguntar As Boolean = False
    Dim CodCli As Long = 0
    Dim EsSuministros As Boolean = False
    Dim frmFactura As Form_Factura
    Dim frmAbono As Form_Abono
    Public Sub New(ByVal CodCli As Long, EsSuministros As Boolean)
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Me.CodCli = CodCli
        Me.EsSuministros = EsSuministros
        Me.CargarDatos()
    End Sub
    Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click


        If frmFactura Is Nothing OrElse frmFactura.IsDisposed Then frmFactura = New Form_Factura(RegFacturaVentas.Numero)

        If Me.dcDestinos.SelectedValue <> Nothing Then
            RegFacturaVentas.Destino = Me.dcDestinos.Text
            If HayDescuento Then
                If frmAbono Is Nothing OrElse frmAbono.IsDisposed Then
                    frmAbono = New Form_Abono(RegFacturaVentas.Numero, RegFacturaVentas.ConceptoDescuento)
                End If
            End If
            Try
                frmFactura.GuardarFactura(RegFacturaVentas, EsModificacionVentas, frmAbono)
            Catch ex As Exception
                MessageBox.Show("Error al guardar la factura: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

            If frmFactura.Visible = False Then frmFactura.ShowDialog()

            If frmAbono IsNot Nothing AndAlso frmAbono.Visible = False Then frmAbono.ShowDialog()

            Me.Close()
        Else
            MsgBox("Debe seleccionar un destino", MsgBoxStyle.OkOnly, "Facturas")
        End If
    End Sub
    Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
        Preguntar = True
        Me.Close()
    End Sub
    Private Sub Form_Destino_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim OK As MsgBoxResult
        If Preguntar Then
            OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.OkCancel, "Facturas")
            If OK = MsgBoxResult.Ok Then
                [Global].Inicializar()
            Else
                eventArgs.Cancel = True
            End If
        End If
    End Sub
    Private Sub CargarDatos()
        Dim daDestinos As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
        Dim dtDestinos As DataTable = New DataTable
        Try
            daDestinos.SelectCommand = New SqlClient.SqlCommand("CONSULTA_DESTINO", DBConnection)
            daDestinos.SelectCommand.CommandType = CommandType.StoredProcedure
            daDestinos.SelectCommand.Parameters.Add("@CodCli", SqlDbType.Int)
            daDestinos.SelectCommand.Parameters("@CodCli").Value = Me.CodCli
            daDestinos.SelectCommand.Parameters.Add("@EsSuministros", SqlDbType.Bit)
            daDestinos.SelectCommand.Parameters("@EsSuministros").Value = Me.EsSuministros
            daDestinos.Fill(dtDestinos)

            Me.dcDestinos.DataSource = dtDestinos
            Me.dcDestinos.DisplayMember = "DESTINO"
            Me.dcDestinos.ValueMember = "DESTINO"
        Catch ex As Exception
            MsgBox("Error al cargar Obras: " & ex.Message)
        Finally
        End Try
    End Sub

    Private Sub Form_Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class