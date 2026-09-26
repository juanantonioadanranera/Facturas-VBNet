Option Strict Off
Option Explicit On
Friend Class Form_Prompt_Materiales
    Inherits System.Windows.Forms.Form
#Region "Propiedades"
  Private CodMaterial As Long = -1
  Public Property CodMat() As Long
    Get
      Return CodMaterial
    End Get
    Set(ByVal value As Long)
      CodMaterial = value
    End Set
  End Property
#End Region
  Private Preguntar As Boolean = False
  Private frmMaterial As Form_Materiales
#Region "Código generado por el Diseñador de Windows Forms "
  Public Sub New()
    MyBase.New()
    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()
  End Sub
  'Form reemplaza a Dispose para limpiar la lista de componentes.
  Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
    If Disposing Then
      'VB6_RemoveADODataBinding()
      If Not components Is Nothing Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(Disposing)
  End Sub
  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer
  'Private ADOBind_cmdMateriales As VB6.MBindingCollection
  Public WithEvents Cancelar As System.Windows.Forms.Button
  Public WithEvents Label_Prompt As System.Windows.Forms.Label
  Public WithEvents Marco As System.Windows.Forms.GroupBox
  Friend WithEvents dcMateriales As System.Windows.Forms.ComboBox
  Public WithEvents Aceptar As System.Windows.Forms.Button
  'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
  'Se puede modificar mediante el Diseñador de Windows Forms.
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Marco = New System.Windows.Forms.GroupBox
    Me.Label_Prompt = New System.Windows.Forms.Label
    Me.Aceptar = New System.Windows.Forms.Button
    Me.dcMateriales = New System.Windows.Forms.ComboBox
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
    'Marco
    '
    Me.Marco.BackColor = System.Drawing.SystemColors.Control
    Me.Marco.Controls.Add(Me.dcMateriales)
    Me.Marco.Controls.Add(Me.Label_Prompt)
    Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco.Location = New System.Drawing.Point(8, 16)
    Me.Marco.Name = "Marco"
    Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco.Size = New System.Drawing.Size(553, 113)
    Me.Marco.TabIndex = 0
    Me.Marco.TabStop = False
    '
    'Label_Prompt
    '
    Me.Label_Prompt.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Prompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Prompt.Location = New System.Drawing.Point(24, 48)
    Me.Label_Prompt.Name = "Label_Prompt"
    Me.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Prompt.Size = New System.Drawing.Size(177, 25)
    Me.Label_Prompt.TabIndex = 4
    Me.Label_Prompt.Text = "Seleccione el artículo:"
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
    'dcMateriales
    '
    Me.dcMateriales.FormattingEnabled = True
    Me.dcMateriales.Location = New System.Drawing.Point(207, 45)
    Me.dcMateriales.Name = "dcMateriales"
    Me.dcMateriales.Size = New System.Drawing.Size(326, 28)
    Me.dcMateriales.TabIndex = 5
    '
    'Form_Prompt_Materiales
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(678, 150)
    Me.Controls.Add(Me.Cancelar)
    Me.Controls.Add(Me.Marco)
    Me.Controls.Add(Me.Aceptar)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(140, 301)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Prompt_Materiales"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
    Me.Text = "Materiales"
    Me.Marco.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region
  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
	Try
	  If dcMateriales.SelectedValue <> Nothing Then
		Me.CodMat = dcMateriales.SelectedValue

		If Not Alta_Material Then
		  frmMaterial = New Form_Materiales(Me.CodMat)
		Else
		  frmMaterial = New Form_Materiales()
		End If

		frmMaterial.ShowDialog()
		Preguntar = False
		Me.Close()
	  Else
		MsgBox("Debe escoger un material", MsgBoxStyle.OkOnly, "Error")
		Me.dcMateriales.Focus()
	  End If
	Catch ex As Exception
	  MsgBox("Error al cargar Material: " & ex.Message)
	End Try
  End Sub

  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
    Preguntar = True
    Me.Close()
  End Sub

  Private Sub Form_Prompt_Materiales_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles Me.Closing
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
  Private Sub Form_Prompt_Materiales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	Dim dtMateriales As DataTable = New DataTable
	Dim daMateriales As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
	Try
	  daMateriales.SelectCommand = New SqlClient.SqlCommand("CONSULTA_MATERIALES", DBConnection)
	  daMateriales.SelectCommand.CommandType = CommandType.StoredProcedure
	  daMateriales.Fill(dtMateriales)
	  Me.dcMateriales.DataSource = dtMateriales
	  Me.dcMateriales.DisplayMember = "DESCRIPCION"
	  Me.dcMateriales.ValueMember = "COD_MAT"
	  Me.dcMateriales.SelectedIndex = Me.dcMateriales.Items.Count - 1
	Catch ex As Exception
	  MsgBox("Error al cargar materiales: " & ex.Message)
	Finally
	End Try
  End Sub
End Class