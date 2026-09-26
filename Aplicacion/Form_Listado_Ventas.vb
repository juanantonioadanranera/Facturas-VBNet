
Imports CrystalDecisions.CrystalReports.Engine


Public Class Form_Listado_Ventas
    Inherits System.Windows.Forms.Form
    Private FechaInicio, FechaFin As Date
    Private daFacturasVentas As SqlClient.SqlDataAdapter
	Private dtFacturasVentas As DataTable

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
  Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
	Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
	Me.SuspendLayout()
	'
	'CrystalReportViewer1
	'
	Me.CrystalReportViewer1.ActiveViewIndex = -1
	Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
	Me.CrystalReportViewer1.DisplayGroupTree = False
	Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
	Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
	Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
	Me.CrystalReportViewer1.Size = New System.Drawing.Size(742, 397)
	Me.CrystalReportViewer1.TabIndex = 0
	'
	'Form_Listado_Ventas
	'
	Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
	Me.ClientSize = New System.Drawing.Size(742, 397)
	Me.Controls.Add(Me.CrystalReportViewer1)
	Me.Name = "Form_Listado_Ventas"
	Me.Text = "Listado Ventas"
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
  Public Sub Cargar_Datos(ByRef Informe As ReportDocument)
	daFacturasVentas = New SqlClient.SqlDataAdapter
	dtFacturasVentas = New DataTable
	daFacturasVentas.SelectCommand = New SqlClient.SqlCommand("LISTADO_VENTAS", DBConnection)
	Try
	  With daFacturasVentas.SelectCommand
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@FechaInicio", SqlDbType.DateTime)
		  .Item("@FechaInicio").Value = Me.FechaInicio

		  .Add("@FechaFin", SqlDbType.DateTime)
		  .Item("@FechaFin").Value = Me.FechaFin
		End With
		daFacturasVentas.SelectCommand.ExecuteNonQuery()
		daFacturasVentas.Fill(dtFacturasVentas)
	  End With

	  Informe.SetDataSource(dtFacturasVentas)
	  'Informe.SetParameterValue("@FechaInicio", Me.FechaInicio)
	  'Informe.SetParameterValue("@FechaFin", Me.FechaFin)
	  Me.CrystalReportViewer1.ReportSource = Informe
	  Me.CrystalReportViewer1.RefreshReport()
	Catch ex As Exception
	  MsgBox("Error en Listado Facturas Ventas: " & ex.Message)
	Finally
	  daFacturasVentas.Dispose()
	  dtFacturasVentas.Dispose()
	  daFacturasVentas = Nothing
	  dtFacturasVentas = Nothing
	End Try
  End Sub
  Public Sub SetFechaInicio(ByVal Fecha As Date)
    FechaInicio = Fecha
  End Sub
  Public Sub SetFechaFin(ByVal Fecha As Date)
    FechaFin = Fecha
  End Sub
  Private Sub Form_Listado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.WindowState = FormWindowState.Maximized
    Me.Cargar_Datos(CType(New Aplicacion.ListadoVentasEmpresa, ReportDocument))
  End Sub
End Class
