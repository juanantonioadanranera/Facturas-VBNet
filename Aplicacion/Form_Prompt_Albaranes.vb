Option Strict Off
Option Explicit On
Friend Class Form_Prompt_Albaranes
	Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'Para el formulario de inicio, la primera instancia creada es la instancia predeterminada.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
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
  Friend WithEvents dcAlbaranes As System.Windows.Forms.ComboBox
	Public WithEvents Marco As System.Windows.Forms.GroupBox
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.Cancelar = New System.Windows.Forms.Button
    Me.Aceptar = New System.Windows.Forms.Button
    Me.Marco = New System.Windows.Forms.GroupBox
    Me.Label_Prompt = New System.Windows.Forms.Label
    Me.dcAlbaranes = New System.Windows.Forms.ComboBox
    Me.Marco.SuspendLayout()
    Me.SuspendLayout()
    '
    'Cancelar
    '
    Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
    Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
    Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Cancelar.Location = New System.Drawing.Point(464, 72)
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
    Me.Aceptar.Location = New System.Drawing.Point(464, 32)
    Me.Aceptar.Name = "Aceptar"
    Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Aceptar.Size = New System.Drawing.Size(89, 25)
    Me.Aceptar.TabIndex = 3
    Me.Aceptar.Text = "Aceptar"
    Me.Aceptar.UseVisualStyleBackColor = False
    '
    'Marco
    '
    Me.Marco.BackColor = System.Drawing.SystemColors.Control
    Me.Marco.Controls.Add(Me.dcAlbaranes)
    Me.Marco.Controls.Add(Me.Label_Prompt)
    Me.Marco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Marco.Location = New System.Drawing.Point(16, 16)
    Me.Marco.Name = "Marco"
    Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Marco.Size = New System.Drawing.Size(433, 121)
    Me.Marco.TabIndex = 0
    Me.Marco.TabStop = False
    Me.Marco.Text = "Albaranes"
    '
    'Label_Prompt
    '
    Me.Label_Prompt.BackColor = System.Drawing.SystemColors.Control
    Me.Label_Prompt.Cursor = System.Windows.Forms.Cursors.Default
    Me.Label_Prompt.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Label_Prompt.Location = New System.Drawing.Point(16, 48)
    Me.Label_Prompt.Name = "Label_Prompt"
    Me.Label_Prompt.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Label_Prompt.Size = New System.Drawing.Size(273, 25)
    Me.Label_Prompt.TabIndex = 2
    Me.Label_Prompt.Text = "Seleccione el número de albarán:"
    '
    'dcAlbaranes
    '
    Me.dcAlbaranes.FormattingEnabled = True
    Me.dcAlbaranes.Location = New System.Drawing.Point(295, 45)
    Me.dcAlbaranes.Name = "dcAlbaranes"
    Me.dcAlbaranes.Size = New System.Drawing.Size(121, 28)
    Me.dcAlbaranes.TabIndex = 4
    '
    'Form_Prompt_Albaranes
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(567, 150)
    Me.Controls.Add(Me.Cancelar)
    Me.Controls.Add(Me.Aceptar)
    Me.Controls.Add(Me.Marco)
    Me.Cursor = System.Windows.Forms.Cursors.Default
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Location = New System.Drawing.Point(3, 22)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Form_Prompt_Albaranes"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.ShowInTaskbar = False
    Me.Text = "Albaranes"
    Me.Marco.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region
#Region "Soporte para la actualización "
  Private Shared m_vb6FormDefInstance As Form_Prompt_Albaranes
  Private Shared m_InitializingDefInstance As Boolean
  Public Shared Property DefInstance() As Form_Prompt_Albaranes
    Get
      If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
        m_InitializingDefInstance = True
        m_vb6FormDefInstance = New Form_Prompt_Albaranes()
        m_InitializingDefInstance = False
      End If
      DefInstance = m_vb6FormDefInstance
    End Get
    Set(ByVal value As Form_Prompt_Albaranes)
      m_vb6FormDefInstance = value
    End Set
  End Property
#End Region

  Private Sub Form_Prompt_Albaranes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Me.SqlDataAdapter1.Fill(Me.DataSet71)
  End Sub

  Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click

  End Sub
End Class