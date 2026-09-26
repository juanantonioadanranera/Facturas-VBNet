Option Strict Off
Option Explicit On
Imports System.Windows.Forms
Friend Class Form_Cantidad
	Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
	Public Sub New()
		MyBase.New()
		'El Diseñador de Windows Forms requiere esta llamada.
		InitializeComponent()
		AddHandler Me.FormClosed, AddressOf Me.Form_Cantidad_FormClosed
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
	Public WithEvents Text_Cantidad As System.Windows.Forms.TextBox
  Public WithEvents Label_Articulo As System.Windows.Forms.Label
  Public WithEvents Label_Cantidad As System.Windows.Forms.Label
  Friend WithEvents dcMateriales As System.Windows.Forms.ComboBox
    Public WithEvents Text_Precio As TextBox
    Public WithEvents Label_Precio As Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Text_Precio = New System.Windows.Forms.TextBox()
        Me.Label_Precio = New System.Windows.Forms.Label()
        Me.dcMateriales = New System.Windows.Forms.ComboBox()
        Me.Text_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label_Articulo = New System.Windows.Forms.Label()
        Me.Label_Cantidad = New System.Windows.Forms.Label()
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancelar.Location = New System.Drawing.Point(560, 72)
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
        Me.Aceptar.Location = New System.Drawing.Point(560, 32)
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
        Me.Frame1.Controls.Add(Me.Text_Precio)
        Me.Frame1.Controls.Add(Me.Label_Precio)
        Me.Frame1.Controls.Add(Me.dcMateriales)
        Me.Frame1.Controls.Add(Me.Text_Cantidad)
        Me.Frame1.Controls.Add(Me.Label_Articulo)
        Me.Frame1.Controls.Add(Me.Label_Cantidad)
        Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(529, 220)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Cantidad"
        '
        'Text_Precio
        '
        Me.Text_Precio.AcceptsReturn = True
        Me.Text_Precio.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Precio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Precio.Enabled = False
        Me.Text_Precio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Precio.Location = New System.Drawing.Point(216, 152)
        Me.Text_Precio.MaxLength = 0
        Me.Text_Precio.Name = "Text_Precio"
        Me.Text_Precio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Precio.Size = New System.Drawing.Size(73, 26)
        Me.Text_Precio.TabIndex = 2
        Me.Text_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_Precio
        '
        Me.Label_Precio.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Precio.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Precio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Precio.Location = New System.Drawing.Point(16, 155)
        Me.Label_Precio.Name = "Label_Precio"
        Me.Label_Precio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Precio.Size = New System.Drawing.Size(193, 25)
        Me.Label_Precio.TabIndex = 9
        Me.Label_Precio.Text = "Introduzca el precio:"
        '
        'dcMateriales
        '
        Me.dcMateriales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.dcMateriales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dcMateriales.FormattingEnabled = True
        Me.dcMateriales.Location = New System.Drawing.Point(216, 101)
        Me.dcMateriales.Name = "dcMateriales"
        Me.dcMateriales.Size = New System.Drawing.Size(288, 28)
        Me.dcMateriales.TabIndex = 1
        '
        'Text_Cantidad
        '
        Me.Text_Cantidad.AcceptsReturn = True
        Me.Text_Cantidad.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Cantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Cantidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Cantidad.Location = New System.Drawing.Point(216, 53)
        Me.Text_Cantidad.MaxLength = 0
        Me.Text_Cantidad.Name = "Text_Cantidad"
        Me.Text_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Cantidad.Size = New System.Drawing.Size(73, 26)
        Me.Text_Cantidad.TabIndex = 0
        Me.Text_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_Articulo
        '
        Me.Label_Articulo.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Articulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Articulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Articulo.Location = New System.Drawing.Point(16, 104)
        Me.Label_Articulo.Name = "Label_Articulo"
        Me.Label_Articulo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Articulo.Size = New System.Drawing.Size(193, 25)
        Me.Label_Articulo.TabIndex = 6
        Me.Label_Articulo.Text = "Seleccione el artículo:"
        '
        'Label_Cantidad
        '
        Me.Label_Cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Cantidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Cantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Cantidad.Location = New System.Drawing.Point(16, 56)
        Me.Label_Cantidad.Name = "Label_Cantidad"
        Me.Label_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Cantidad.Size = New System.Drawing.Size(193, 25)
        Me.Label_Cantidad.TabIndex = 5
        Me.Label_Cantidad.Text = "Introduzca la cantidad:"
        '
        'Form_Cantidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(670, 279)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(185, 301)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Cantidad"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Albaranes"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Soporte para la actualización "
    Private Shared m_vb6FormDefInstance As Form_Cantidad
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Form_Cantidad
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Form_Cantidad()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Form_Cantidad)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region
    Private dtMateriales As DataTable
    Private daMateriales As SqlClient.SqlDataAdapter
    Private Preguntar As Boolean = False
#Region "Propiedades"
    Private CodMaterial As Long
    Public Property CodMat() As Long
        Get
            Return CodMaterial
        End Get
        Set(ByVal value As Long)
            CodMaterial = value
        End Set
    End Property
    Private Precio_Venta As Single
    Public Property PrecioVenta() As Single
        Get
            Return Precio_Venta
        End Get
        Set(ByVal value As Single)
            Precio_Venta = value
        End Set
    End Property
    Private Unidades As Single
    Public Property Cantidad() As Single
        Get
            Return Unidades
        End Get
        Set(ByVal value As Single)
            Unidades = value
        End Set
    End Property
#End Region
    Protected Overrides Sub Finalize()
        Me.dtMateriales.Dispose()
        Me.daMateriales.Dispose()
        Dispose(False)
        MyBase.Finalize()
    End Sub

    Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
        Dim OK As Short
        On Error GoTo HayError
        Dim Error_Code As Short

        Me.Text_Cantidad.Focus()
        Error_Code = ComprobarCampos()
        If Error_Code = 0 Then
            Me.CodMat = Me.dcMateriales.SelectedValue
            If Me.CodMat = 30 Then Me.PrecioVenta = CSng(Me.Text_Precio.Text.Replace(Punto, Coma)) / 1.21
            '    If RegFacturaVentas.Cod_Cli = 31 Then
            '        Me.PrecioVenta = CSng(Me.Text_Precio.Text.Replace(Punto, Coma)) / 1.21
            '    Else
            '        Me.PrecioVenta = CSng(Me.Text_Precio.Text.Replace(Punto, Coma))
            '    End If
            'End If
            Me.Cantidad = CSng(Replace(Me.Text_Cantidad.Text, Punto, Coma))
            Call CType(Me.Owner, Form_Albaranes).AsignarMaterial(Me.Cantidad, Me.CodMat, Me.PrecioVenta)
            Call CType(Me.Owner, Form_Albaranes).ValidarCampos()
            'Call CType(Me.Owner, Form_Albaranes).AsignarValoresUsuario()
            Call CType(Me.Owner, Form_Albaranes).AltaAlbaran()
            CType(Me.Owner, Form_Albaranes).AsignarPropiedades(CType(Me.Owner, Form_Albaranes).ConsultaAlbaran())
            CType(Me.Owner, Form_Albaranes).AsignarControles()
            OK = MessageBox.Show("¿Desea añadir algún artículo más?", "Facturas", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)
            If OK <> Windows.Forms.DialogResult.Yes Then
                With Me
                    If Not Alta_Albaran Then
                        .Owner.Focus()
                    Else
                        .Owner.Close()
                    End If
                    .Close()
                End With
            Else
                Me.Text_Cantidad.Text = ""
                Me.dcMateriales.SelectedIndex = 0
            End If
        Else
            Call MostrarError(Error_Code)
        End If
        Exit Sub
HayError:
        MessageBox.Show("Error Número " & Err.Number & vbCrLf & Err.Description, "Facturas", MessageBoxButtons.OK,
    MessageBoxIcon.Error)
        Err.Clear()
    End Sub
    Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
        Preguntar = True
        Me.Close()
    End Sub
    Private Sub Form_Cantidad_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim OK As MsgBoxResult
        If Preguntar Then
            OK = MessageBox.Show("¿Desea cancelar el proceso?", "Facturas", MessageBoxButtons.YesNo,
      MessageBoxIcon.Question)
            If OK <> MsgBoxResult.Yes Then
                eventArgs.Cancel = True
            Else
                Me.Owner.Close()
            End If
        End If
    End Sub
    Private Sub Form_Cantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text_Cantidad.Focus()
            dtMateriales = New DataTable
            daMateriales = New SqlClient.SqlDataAdapter()
            daMateriales.SelectCommand = New SqlClient.SqlCommand("CONSULTA_MATERIALES", DBConnection)
            daMateriales.SelectCommand.CommandType = CommandType.StoredProcedure
            daMateriales.Fill(dtMateriales)

            Me.dcMateriales.DataSource = dtMateriales
            Me.dcMateriales.DisplayMember = "DESCRIPCION"
            Me.dcMateriales.ValueMember = "COD_MAT"
            Me.dcMateriales.Refresh()
            AddHandler dcMateriales.SelectedIndexChanged, AddressOf dcMateriales_SelectedIndexChanged
        Catch ex As Exception
            MsgBox("Error al cargar Materiales: " & ex.Message)
        Finally
        End Try
    End Sub
    Private Sub Form_Cantidad_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Text_Cantidad.Focus()
    End Sub
    Private Sub Form_Cantidad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Alta_Albaran Then Aplicacion.frmMain.Focus()
    End Sub
    Public Function ComprobarCampos() As Short
        With Me
            If .Text_Cantidad.Text = "" Then
                ComprobarCampos = 1030
            Else
                If Not IsNumeric(.Text_Cantidad.Text) Then
                    ComprobarCampos = 1031
                Else
                    If Val(.Text_Cantidad.Text) = 0 Then
                        ComprobarCampos = 1032
                    Else
                        If .dcMateriales.SelectedValue = Nothing Then
                            ComprobarCampos = 1033
                        Else
                            ComprobarCampos = 0
                        End If
                    End If
                End If
            End If
        End With
    End Function
    Public Sub MostrarError(ByVal Error_Code As Short)
        If Error_Code = 1030 Then
            MsgBox("La cantidad no puede ser nula", MsgBoxStyle.OkOnly, "Error")
        Else
            If Error_Code = 1031 Then
                MsgBox("La cantidad debe ser numérica", MsgBoxStyle.OkOnly, "Error")
            Else
                If Error_Code = 1032 Then
                    MsgBox("La cantidad no puede ser cero", MsgBoxStyle.OkOnly, "Error")
                Else
                    If Error_Code = 1033 Then
                        MsgBox("Debe seleccionar un artículo", MsgBoxStyle.OkOnly, "Error")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dcMateriales_SelectedIndexChanged(sender As Object, e As EventArgs)
        Me.CodMat = dcMateriales.SelectedValue
        If Me.CodMat = 30 Then
            Me.Text_Precio.Enabled = True
            Me.Text_Precio.Focus()
        Else
            Me.Text_Precio.Enabled = False
            Me.dcMateriales.Focus()
        End If
    End Sub
End Class