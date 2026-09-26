Option Strict Off
Option Explicit On
Friend Class Form_Prompt_Numero
    Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        If EsFacturaVentas Then
            Me.dcFacturasVentas.Visible = True
            Me.Text_Numero.Visible = False
        Else
            If EsFacturaCompras Then
                Me.dcFacturasVentas.Visible = False
                Me.Text_Numero.Visible = True
            End If
        End If
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
    Public WithEvents Text_Numero As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dcFacturasVentas As System.Windows.Forms.ComboBox
    Public WithEvents Marco As System.Windows.Forms.GroupBox
    'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Marco = New System.Windows.Forms.GroupBox
        Me.Text_Numero = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dcFacturasVentas = New System.Windows.Forms.ComboBox
        Me.Marco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancelar.Location = New System.Drawing.Point(488, 72)
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
        Me.Aceptar.Location = New System.Drawing.Point(488, 32)
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
        Me.Marco.Controls.Add(Me.dcFacturasVentas)
        Me.Marco.Controls.Add(Me.Text_Numero)
        Me.Marco.Controls.Add(Me.Label1)
        Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Marco.Location = New System.Drawing.Point(16, 16)
        Me.Marco.Name = "Marco"
        Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Marco.Size = New System.Drawing.Size(457, 145)
        Me.Marco.TabIndex = 3
        Me.Marco.TabStop = False
        Me.Marco.Text = "Número de Factura"
        '
        'Text_Numero
        '
        Me.Text_Numero.AcceptsReturn = True
        Me.Text_Numero.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Numero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Numero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Numero.Location = New System.Drawing.Point(280, 64)
        Me.Text_Numero.MaxLength = 0
        Me.Text_Numero.Name = "Text_Numero"
        Me.Text_Numero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Numero.Size = New System.Drawing.Size(161, 26)
        Me.Text_Numero.TabIndex = 0
        Me.Text_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Introduzca el número de factura:"
        '
        'dcFacturasVentas
        '
        Me.dcFacturasVentas.FormattingEnabled = True
        Me.dcFacturasVentas.Location = New System.Drawing.Point(280, 64)
        Me.dcFacturasVentas.Name = "dcFacturasVentas"
        Me.dcFacturasVentas.Size = New System.Drawing.Size(161, 28)
        Me.dcFacturasVentas.TabIndex = 7
        '
        'Form_Prompt_Numero
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(590, 176)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Marco)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(162, 231)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Prompt_Numero"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Número de Factura"
        Me.Marco.ResumeLayout(False)
        Me.Marco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim Preguntar As Boolean = False
    Dim frmTipoIva As Form_Tipo_Iva
    Dim frmPromptProveedores As Form_Prompt_Proveedores
    Dim frmFactura As Form_Factura
    Dim Factura As Form_Facturas
    Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
        Dim Error_Code As Short = 0
        Dim OK As MsgBoxResult

        If EsFacturaVentas Then
            If Text_Numero.Text <> "" Then
                Error_Code = ValidarNumeroFacturaVentas((Me.Text_Numero).Text)
                OK = CompruebaErrorFacturaVentas(Error_Code)
                If OK <> MsgBoxResult.Ok Then
                    If OK = MsgBoxResult.Yes Then
                        EsModificacionVentas = True
                    Else
                        If OK = MsgBoxResult.No Then Exit Sub
                    End If
                    RegFacturaVentas.Numero = CLng(Me.Text_Numero.Text)
                    Me.Text_Numero.Text = ""
                    If frmTipoIva Is Nothing OrElse frmTipoIva.IsDisposed Then frmTipoIva = New Form_Tipo_Iva
                    frmTipoIva.ShowDialog()
                    Me.Close()
                    Me.Dispose()
                End If
            Else
                MsgBox("El número no puede ser nulo", MsgBoxStyle.OkOnly, "Error")
                Text_Numero.Focus()
            End If
        Else
            If EsFacturaCompras Then
                RegFacturaCompras.Numero = Me.Text_Numero.Text
                If frmPromptProveedores Is Nothing OrElse frmPromptProveedores.IsDisposed Then frmPromptProveedores = New Form_Prompt_Proveedores
                frmPromptProveedores.ShowDialog()
                Me.Close()
                Me.Dispose()
            Else
                If EsConsultaVentas Then
                    Error_Code = ValidarNumeroFacturaVentas((Me.dcFacturasVentas.SelectedValue.ToString))
                    OK = CompruebaErrorFacturaVentas(Error_Code)
                    If OK <> MsgBoxResult.Ok Then
                        'Call ConsultaFacturaVentas(CLng(Me.dcFacturasVentas.Text))

                        If frmFactura Is Nothing OrElse frmFactura.IsDisposed Then frmFactura = New Form_Factura(CLng(Me.dcFacturasVentas.SelectedValue))
                        frmFactura.ShowDialog()

                        EsConsultaVentas = False
                        Me.Close()
                        Me.Dispose()
                    End If
                End If
            End If
            If Modificacion_Factura Then
                If Factura Is Nothing OrElse Factura.IsDisposed Then Factura = New Form_Facturas(CLng(Me.dcFacturasVentas.SelectedValue))
                Factura.ShowDialog()
                Modificacion_Factura = False
                Me.Close()
                Me.Dispose()
            Else
                If EsBajaVentas Then
                    If frmFactura Is Nothing OrElse frmFactura.IsDisposed Then frmFactura = New Form_Factura(CLng(Me.dcFacturasVentas.SelectedValue))
                    frmFactura.BajaFactura(CLng(Me.dcFacturasVentas.SelectedValue))
                    EsBajaVentas = False
                    Me.Close()
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
        Preguntar = True
        Me.Close()
    End Sub
    Private Sub Form_Prompt_Numero_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim daFacturasVentas As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
        Dim dtFacturasVentas As DataTable = New DataTable
        Try
            With Me.dcFacturasVentas
                .DropDownStyle = ComboBoxStyle.DropDown
                .AutoCompleteMode = AutoCompleteMode.Append
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With

            daFacturasVentas.SelectCommand = New SqlClient.SqlCommand("CONSULTA_FACTURAS_VENTAS", DBConnection)
            daFacturasVentas.SelectCommand.CommandType = CommandType.StoredProcedure
            daFacturasVentas.SelectCommand.ExecuteNonQuery()
            daFacturasVentas.Fill(dtFacturasVentas)

            Me.dcFacturasVentas.DataSource = dtFacturasVentas
            Me.dcFacturasVentas.DisplayMember = "NUM_FACTURA"
            Me.dcFacturasVentas.ValueMember = "NUM_FACTURA"

            If EsFacturaVentas Then
                Me.Text_Numero.Visible = True
                Me.dcFacturasVentas.Visible = False
                dcFacturasVentas.SelectedIndex = dcFacturasVentas.Items.Count - 1
                Text_Numero.Text = CStr(NumeroFactura())
            Else
                If EsConsultaVentas Then
                    Me.dcFacturasVentas.Visible = True
                    Me.Text_Numero.Visible = False
                    dcFacturasVentas.SelectedIndex = dcFacturasVentas.Items.Count - 1
                Else
                    dcFacturasVentas.SelectedIndex = dcFacturasVentas.Items.Count - 1
                    Text_Numero.Text = "0001"
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al cargar Facturas: " & ex.Message)
        Finally
            daFacturasVentas.Dispose()
        End Try
    End Sub

    Private Sub Form_Prompt_Numero_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
    Public Function ValidarNumeroFacturaVentas(ByVal Numero As String) As Short
        Dim ExisteFactura As Integer = 0
        If Not IsNumeric(Numero) Then
            ValidarNumeroFacturaVentas = 1021
        Else
            If CDbl(Numero) = 0 Then
                ValidarNumeroFacturaVentas = 1020
            Else
                Dim cmdExisteFactura As SqlClient.SqlCommand = _
                 New SqlClient.SqlCommand("SELECT [Facturas].[dbo].[ExisteFacturaVentas] (@NumFactura)", DBConnection)
                With cmdExisteFactura
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@NumFactura", CSng(Numero))
                    ExisteFactura = .ExecuteScalar()
                End With
                If ExisteFactura = 2 Then
                    If EsFacturaVentas Then ValidarNumeroFacturaVentas = 1024
                Else
                    If ExisteFactura = 1 Then
                        If EsFacturaVentas Then ValidarNumeroFacturaVentas = 1022
                    Else
                        If ExisteFactura < 1 Then
                            If EsConsultaVentas Then ValidarNumeroFacturaVentas = 1023
                        Else
                            ValidarNumeroFacturaVentas = 0
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Public Function CompruebaErrorFacturaVentas(ByVal Error_Code As Short) As MsgBoxResult
        If Error_Code = 1020 Then
            CompruebaErrorFacturaVentas = MsgBox("El número de Factura no puede ser cero", MsgBoxStyle.OkOnly, "Error")
        Else
            If Error_Code = 1021 Then
                CompruebaErrorFacturaVentas = MsgBox("El número de Factura debe ser numérico", MsgBoxStyle.OkOnly, "Error")
            Else
                If Error_Code = 1022 Then
                    CompruebaErrorFacturaVentas = MsgBox("Ya existe una Factura con es número" & vbCrLf & "¿Desea actualizarla?", MsgBoxStyle.YesNo, "Factura Existente")
                Else
                    If Error_Code = 1023 Then
                        CompruebaErrorFacturaVentas = MsgBox("No existe en la base de datos una factura con ese número", MsgBoxStyle.OkOnly, "Error")
                    Else
                        If Error_Code = 1024 Then
                            CompruebaErrorFacturaVentas = MsgBox("Ya existe en la base de datos una factura de Abono con ese número", MsgBoxStyle.OkOnly, "Error")
                        Else
                            CompruebaErrorFacturaVentas = MsgBoxResult.Abort
                        End If
                    End If
                End If
            End If
        End If
    End Function
    Public Function NumeroFactura() As Long
        Dim daMaxAbono As New SqlClient.SqlDataAdapter("SELECT [Facturas].[dbo].[MAX_ABONO]()", DBConnection)
        Dim daMaxFactura As New SqlClient.SqlDataAdapter("SELECT [Facturas].[dbo].[MAX_FACTURA_VENTAS]()", DBConnection)
        Dim MaxAbono As Object
        Dim MaxFactura As Integer

        Try
            MaxAbono = daMaxAbono.SelectCommand.ExecuteScalar()
            MaxFactura = daMaxFactura.SelectCommand.ExecuteScalar()
            If MaxAbono > MaxFactura Then
                Return MaxAbono + 1
            Else
                Return MaxFactura + 1
            End If
        Catch ex As Exception
            MsgBox("Error al calcular abono: " & ex.Message)
        Finally
            daMaxFactura.Dispose()
            daMaxAbono.Dispose()
        End Try
    End Function
End Class