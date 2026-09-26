Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class Form_Materiales
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
    Public WithEvents Text_Codigo As System.Windows.Forms.TextBox
	Public WithEvents Text_Descripcion As System.Windows.Forms.TextBox
	Public WithEvents Text_Precio As System.Windows.Forms.TextBox
	Public WithEvents Label_Codigo As System.Windows.Forms.Label
	Public WithEvents Label_Descripcion As System.Windows.Forms.Label
	Public WithEvents Label_Precio As System.Windows.Forms.Label
	Public WithEvents Marco As System.Windows.Forms.GroupBox
	Public WithEvents Cancelar As System.Windows.Forms.Button
	Public WithEvents Aceptar As System.Windows.Forms.Button
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Marco = New System.Windows.Forms.GroupBox
        Me.Text_Codigo = New System.Windows.Forms.TextBox
        Me.Text_Descripcion = New System.Windows.Forms.TextBox
        Me.Text_Precio = New System.Windows.Forms.TextBox
        Me.Label_Codigo = New System.Windows.Forms.Label
        Me.Label_Descripcion = New System.Windows.Forms.Label
        Me.Label_Precio = New System.Windows.Forms.Label
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Marco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Marco
        '
        Me.Marco.BackColor = System.Drawing.SystemColors.Control
        Me.Marco.Controls.Add(Me.Text_Codigo)
        Me.Marco.Controls.Add(Me.Text_Descripcion)
        Me.Marco.Controls.Add(Me.Text_Precio)
        Me.Marco.Controls.Add(Me.Label_Codigo)
        Me.Marco.Controls.Add(Me.Label_Descripcion)
        Me.Marco.Controls.Add(Me.Label_Precio)
        Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Marco.Location = New System.Drawing.Point(16, 8)
        Me.Marco.Name = "Marco"
        Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Marco.Size = New System.Drawing.Size(449, 169)
        Me.Marco.TabIndex = 0
        Me.Marco.TabStop = False
        Me.Marco.Text = "Materiales"
        '
        'Text_Codigo
        '
        Me.Text_Codigo.AcceptsReturn = True
        Me.Text_Codigo.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Codigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Codigo.Enabled = False
        Me.Text_Codigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Codigo.Location = New System.Drawing.Point(136, 32)
        Me.Text_Codigo.MaxLength = 0
        Me.Text_Codigo.Name = "Text_Codigo"
        Me.Text_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Codigo.Size = New System.Drawing.Size(57, 26)
        Me.Text_Codigo.TabIndex = 4
        '
        'Text_Descripcion
        '
        Me.Text_Descripcion.AcceptsReturn = True
        Me.Text_Descripcion.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Descripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Descripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Descripcion.Location = New System.Drawing.Point(136, 80)
        Me.Text_Descripcion.MaxLength = 0
        Me.Text_Descripcion.Name = "Text_Descripcion"
        Me.Text_Descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Descripcion.Size = New System.Drawing.Size(297, 26)
        Me.Text_Descripcion.TabIndex = 5
        '
        'Text_Precio
        '
        Me.Text_Precio.AcceptsReturn = True
        Me.Text_Precio.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Precio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Precio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Precio.Location = New System.Drawing.Point(136, 128)
        Me.Text_Precio.MaxLength = 0
        Me.Text_Precio.Name = "Text_Precio"
        Me.Text_Precio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Precio.Size = New System.Drawing.Size(57, 26)
        Me.Text_Precio.TabIndex = 6
        '
        'Label_Codigo
        '
        Me.Label_Codigo.AutoSize = True
        Me.Label_Codigo.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Codigo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Codigo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Codigo.Location = New System.Drawing.Point(16, 32)
        Me.Label_Codigo.Name = "Label_Codigo"
        Me.Label_Codigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Codigo.Size = New System.Drawing.Size(65, 20)
        Me.Label_Codigo.TabIndex = 1
        Me.Label_Codigo.Text = "Código"
        '
        'Label_Descripcion
        '
        Me.Label_Descripcion.AutoSize = True
        Me.Label_Descripcion.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Descripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Descripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Descripcion.Location = New System.Drawing.Point(16, 80)
        Me.Label_Descripcion.Name = "Label_Descripcion"
        Me.Label_Descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Descripcion.Size = New System.Drawing.Size(103, 20)
        Me.Label_Descripcion.TabIndex = 2
        Me.Label_Descripcion.Text = "Descripción"
        '
        'Label_Precio
        '
        Me.Label_Precio.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Precio.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Precio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Precio.Location = New System.Drawing.Point(16, 128)
        Me.Label_Precio.Name = "Label_Precio"
        Me.Label_Precio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Precio.Size = New System.Drawing.Size(89, 25)
        Me.Label_Precio.TabIndex = 3
        Me.Label_Precio.Text = "Precio"
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancelar.Location = New System.Drawing.Point(480, 64)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cancelar.Size = New System.Drawing.Size(89, 25)
        Me.Cancelar.TabIndex = 8
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Aceptar.Location = New System.Drawing.Point(480, 24)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Aceptar.Size = New System.Drawing.Size(89, 25)
        Me.Aceptar.TabIndex = 7
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'Form_Materiales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(584, 200)
        Me.Controls.Add(Me.Marco)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(309, 372)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Materiales"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Materiales"
        Me.Marco.ResumeLayout(False)
        Me.Marco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region 

#Region "Propiedades"
  Private CodMat As Long
  Public Property CodMaterial() As Long
    Get
      Return CodMat
    End Get
    Set(ByVal value As Long)
      CodMat = value
    End Set
  End Property
  Private NombreMaterial As String
  Public Property Descripcion() As String
    Get
      Return NombreMaterial
    End Get
    Set(ByVal value As String)
      NombreMaterial = value
    End Set
  End Property
  Private Precio As Single
  Public Property PrecioVenta() As Single
    Get
      Return Precio
    End Get
    Set(ByVal value As Single)
      Precio = value
    End Set
  End Property
  Private ActivarEdicion As Boolean
  Public Property Activar() As Boolean
    Get
      Return ActivarEdicion
    End Get
    Set(ByVal value As Boolean)
      ActivarEdicion = value
    End Set
  End Property
  Private NuevoCodMat As Long
  Public Property NuevoCodMaterial() As Long
    Get
      Return NuevoCodMat
    End Get
    Set(ByVal value As Long)
      NuevoCodMat = value
    End Set
  End Property
#End Region
  Private Preguntar As Boolean = False
  Private frmMaterial As Form_Materiales
  Public Sub New(ByVal CodMat As Long)
    MyBase.New()
    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()
    Me.CodMaterial = CodMat
    ConsultaMaterial()
    AsignarControles()
    If Modificacion_Material Or Alta_Material Then
      Activar = True
    Else
      Activar = False
    End If
    ActivarControles()
  End Sub
  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
    Dim Error_Code As Short
    If Alta_Material Then
      Error_Code = ValidarCampos()
      If Error_Code = 0 Then
        Call AsignarValoresUsuario()
        Call AltaMaterial()
        Alta_Material = False
        Me.Close()
      Else
        Call CompruebaError(Error_Code)
      End If
    Else
      If Baja_Material Then
        Call BajaMaterial()
        Baja_Material = False
        Me.Close()
      Else
        If Modificacion_Material Then
          Error_Code = Me.ValidarCampos()
          If Error_Code = 0 Then
            Call AsignarValoresUsuario()
            Call ModificacionMaterial()
            Modificacion_Material = False
            Me.Close()
          Else
            Call CompruebaError(Error_Code)
          End If
        Else
          If Consulta_Material Then
            Consulta_Material = False
            Me.Close()
          End If
        End If
      End If
    End If
  End Sub
  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
    If Not Consulta_Material Then
      Preguntar = True
    Else
      Consulta_Material = False
    End If
    Me.Close()
  End Sub
  Private Sub Form_Materiales_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles Me.Closing
    Dim OK As MsgBoxResult
    If Preguntar Then
      OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
      If OK = MsgBoxResult.Yes Then
        If Alta_Material Then Alta_Material = False
        If Baja_Material Then Baja_Material = False
		If Modificacion_Material Then Modificacion_Material = False
		[Global].Inicializar()
        Me.Dispose()
      Else
        eventArgs.Cancel = True
      End If
    End If
  End Sub
  Public Sub ActivarControles()
    If Not Alta_Material Then Me.Text_Codigo.Enabled = Me.Activar
    Me.Text_Descripcion.Enabled = Me.Activar
    Me.Text_Precio.Enabled = Me.Activar
  End Sub
  Public Sub AsignarValoresUsuario()
    If Me.CodMaterial <> CLng(Me.Text_Codigo.Text) Then
      Me.NuevoCodMaterial = CLng(Me.Text_Codigo.Text)
    Else
      Me.NuevoCodMaterial = Me.CodMaterial
    End If
    Me.Descripcion = Me.Text_Descripcion.Text
        Me.PrecioVenta = CSng(Me.Text_Precio.Text.Replace(Punto, Coma))
    End Sub
  Public Function ValidarCampos() As Short
    If Me.Text_Descripcion.Text = "" Then
      Return 1001
    Else
      If Me.Text_Precio.Text = "" Then
        Return 1002
      Else
                If Not IsNumeric(Me.Text_Precio.Text.Replace(Punto, Coma).Replace(Coma, "")) Then
                    Return 1003
                Else
                    Return 0
                End If
      End If
    End If
  End Function
  Public Sub AsignarControles()
    Me.Text_Codigo.Text = CStr(Me.CodMaterial)
    Me.Text_Descripcion.Text = Me.Descripcion
    Me.Text_Precio.Text = CStr(Me.PrecioVenta)
  End Sub
  Private Sub Form_Materiales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If Alta_Material Then
      Dim cmdMaxCodMaterial As SqlCommand = _
          New SqlCommand("SELECT [Facturas].[dbo].[MAX_COD_MATERIAL] ()", DBConnection)
      Try
        With cmdMaxCodMaterial
          .CommandType = CommandType.Text
          Me.Text_Codigo.Text = (1 + .ExecuteScalar()).ToString
          Me.CodMaterial = 1 + .ExecuteScalar()
        End With
      Catch ex As Exception
		MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	  Finally
		cmdMaxCodMaterial.Dispose()
		cmdMaxCodMaterial = Nothing
	  End Try
	End If
  End Sub
  Public Sub AltaMaterial()
	Dim cmdInsMateriales As SqlClient.SqlCommand = New SqlClient.SqlCommand("ALTA_MATERIAL", DBConnection)
	Try
	  With cmdInsMateriales
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@CodMat", SqlDbType.Int)
		  .Item("@CodMat").Value = Me.CodMaterial
		  .Add("@Descripcion", SqlDbType.NVarChar)
		  .Item("@Descripcion").Value = Me.Descripcion
		  .Add("@PrecioVenta", SqlDbType.Decimal)
		  .Item("@PrecioVenta").Value = Me.PrecioVenta
		End With
		.ExecuteNonQuery()
	  End With
      MsgBox("Alta realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	Catch ex As Exception
	  MsgBox("Error al insertar Material: " & ex.Message)
	Finally
	  cmdInsMateriales.Dispose()
	  cmdInsMateriales = Nothing
	End Try
  End Sub
  Public Sub BajaMaterial()
	Dim cmdDelMateriales As SqlClient.SqlCommand = New SqlClient.SqlCommand("BAJA_MATERIAL", DBConnection)
	Try
	  With cmdDelMateriales
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@CodMat", SqlDbType.Int)
		  .Item("@CodMat").Value = Me.CodMaterial
		End With
		.ExecuteNonQuery()
	  End With
      MsgBox("Baja realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	Catch ex As Exception
	  MsgBox("Error al borrar Material: " & ex.Message)
	Finally
	  cmdDelMateriales.Dispose()
	  cmdDelMateriales = Nothing
	End Try
  End Sub
  Public Sub ModificacionMaterial()
	Dim cmdUpdMateriales As SqlClient.SqlCommand = New SqlClient.SqlCommand("MODIFICACION_MATERIAL", DBConnection)
	Try
	  With cmdUpdMateriales
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@CodMat", SqlDbType.Int)
		  .Item("@CodMat").Value = Me.CodMaterial
		  .Add("@Descripcion", SqlDbType.NVarChar)
		  .Item("@Descripcion").Value = Me.Descripcion
		  .Add("@PrecioVenta", SqlDbType.Float)
		  .Item("@PrecioVenta").Value = Me.PrecioVenta
		  .Add("@NuevoCodMat", SqlDbType.Int)
		  .Item("@NuevoCodMat").Value = Me.NuevoCodMaterial
		End With
		.ExecuteNonQuery()
	  End With
      MsgBox("Modificacion realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
	Catch ex As Exception
	  MsgBox("Error al actualizar Material: " & ex.Message)
	Finally
	  cmdUpdMateriales.Dispose()
	  cmdUpdMateriales = Nothing
	End Try
  End Sub
  Public Sub ConsultaMaterial()

	Dim daMateriales As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
	Dim dtMateriales As DataTable = New DataTable
	Try
	  daMateriales.SelectCommand = New SqlClient.SqlCommand
	  daMateriales.SelectCommand.Connection = DBConnection
	  daMateriales.SelectCommand.CommandText = "CONSULTA_MATERIAL"
	  daMateriales.SelectCommand.CommandType = CommandType.StoredProcedure
	  daMateriales.SelectCommand.Parameters.Add("@CodMaterial", SqlDbType.BigInt)
	  daMateriales.SelectCommand.Parameters("@CodMaterial").Value = Me.CodMaterial
	  daMateriales.SelectCommand.ExecuteNonQuery()
	  daMateriales.Fill(dtMateriales)
	  With dtMateriales.Rows(0)
		Me.CodMaterial = .Item("COD_MAT")
		Me.Descripcion = .Item("DESCRIPCION")
		Me.PrecioVenta = .Item("PRECIO_VENTA")
	  End With
	Catch ex As Exception
	  MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	End Try
  End Sub
  Public Sub CompruebaError(ByRef Error_Code As Short)
    If Error_Code = 1001 Then
      MsgBox("La descripción no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
    Else
      If Error_Code = 1002 Then
        MsgBox("El precio no puede estar en blanco", MsgBoxStyle.OkOnly, "Error")
      Else
        If Error_Code = 1003 Then
          MsgBox("El precio debe de ser numérico", MsgBoxStyle.OkOnly, "Error")
        End If
      End If
    End If
  End Sub
End Class