Public Class Form_Listado_Compras
    Inherits System.Windows.Forms.Form
    Private FechaInicio, FechaFin As Date
    Private daFacturasCompras As SqlClient.SqlDataAdapter
	Private dtFacturasCompras As DataTable
#Region " Código generado por el Diseñador de Windows Forms "

  Public Sub New()
	MyBase.New()

	'El Diseñador de Windows Forms requiere esta llamada.
	InitializeComponent()

	'Agregar cualquier inicialización después de la llamada a InitializeComponent()

  End Sub
  'Form reemplaza a Dispose para limpiar la lista de componentes.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
	If disposing Then
	  If Not (components Is Nothing) Then
		components.Dispose()
	  End If
	End If
	MyBase.Dispose(disposing)
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
  'Puede modificarse utilizando el Diseñador de Windows Forms. 
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(496, 397)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelWidth = 320
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'Form_Listado_Compras
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(496, 397)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Form_Listado_Compras"
        Me.Text = "Listado Compras"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal fInicio As Date, ByVal fFin As Date)
	MyBase.New()

	'El Diseñador de Windows Forms requiere esta llamada.
	InitializeComponent()

	'Agregar cualquier inicialización después de la llamada a InitializeComponent()
	Me.FechaInicio = fInicio
	Me.FechaFin = fFin
  End Sub
  Public Sub Cargar_Datos(ByRef Informe As  _
  CrystalDecisions.CrystalReports.Engine.ReportDocument)
	daFacturasCompras = New SqlClient.SqlDataAdapter
	dtFacturasCompras = New DataTable
	daFacturasCompras.SelectCommand = New SqlClient.SqlCommand("LISTADO_COMPRAS", DBConnection)
	Try
	  With daFacturasCompras.SelectCommand
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@FechaInicio", SqlDbType.DateTime)
		  .Item("@FechaInicio").Value = Me.FechaInicio

		  .Add("@FechaFin", SqlDbType.DateTime)
		  .Item("@FechaFin").Value = Me.FechaFin
		End With
		daFacturasCompras.SelectCommand.ExecuteNonQuery()
		daFacturasCompras.Fill(dtFacturasCompras)
	  End With

	  Informe.SetDataSource(dtFacturasCompras)
	  Me.CrystalReportViewer1.ReportSource = Informe
	  Informe.SetParameterValue("@FechaInicio", Me.FechaInicio)
	  Informe.SetParameterValue("@FechaFin", Me.FechaFin)
	  'Me.CrystalReportViewer1.RefreshReport()
	Catch ex As Exception
	  MsgBox("Error en Listado Facturas Compras: " & ex.Message)
	Finally
	  daFacturasCompras.Dispose()
	  dtFacturasCompras.Dispose()
	  daFacturasCompras = Nothing
	  dtFacturasCompras = Nothing
	End Try
  End Sub
  Private Sub Form_Listado_Compras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.WindowState = FormWindowState.Maximized
    Me.Cargar_Datos(CType(New ListadoComprasEmpresa, _
    CrystalDecisions.CrystalReports.Engine.ReportDocument))
  End Sub
End Class
