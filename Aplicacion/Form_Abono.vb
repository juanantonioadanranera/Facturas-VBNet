Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.Data.SqlClient

Public Class Form_Abono
	Inherits System.Windows.Forms.Form
	Private NumFactura, NumAbono As Long
	Private ConceptoDescuento As String
#Region " Código generado por el Diseñador de Windows Forms "

	Public Sub New(ByVal NumFactura As Long, ByVal ConceptoDescuento As String)
		MyBase.New()

		'El Diseñador de Windows Forms requiere esta llamada.
		InitializeComponent()
		'Agregar cualquier inicialización después de la llamada a InitializeComponent()
		Me.NumFactura = NumFactura
		Me.NumAbono = NumFactura + 1
		Me.ConceptoDescuento = ConceptoDescuento
	End Sub
		Public Sub New(ByVal NumFactura As Long)
		MyBase.New()

		'El Diseñador de Windows Forms requiere esta llamada.
		InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.NumFactura = NumFactura
		Me.NumAbono = NumFactura + 1
        'Me.NumAbono = NumeroAbono()
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
	Friend WithEvents FacturasViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Me.FacturasViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
Me.SuspendLayout()
'
'FacturasViewer
'
Me.FacturasViewer.ActiveViewIndex = -1
Me.FacturasViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.FacturasViewer.CausesValidation = False
Me.FacturasViewer.DisplayGroupTree = False
Me.FacturasViewer.Dock = System.Windows.Forms.DockStyle.Fill
Me.FacturasViewer.Location = New System.Drawing.Point(0, 0)
Me.FacturasViewer.Name = "FacturasViewer"
Me.FacturasViewer.Size = New System.Drawing.Size(640, 373)
Me.FacturasViewer.TabIndex = 0
'
'Form_Abono
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.ClientSize = New System.Drawing.Size(640, 373)
Me.Controls.Add(Me.FacturasViewer)
Me.Name = "Form_Abono"
Me.Text = "Facturas"
Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
Me.ResumeLayout(False)

End Sub

#End Region
	Private Sub Cargar_Datos(ByRef Informe As ReportDocument)
		Dim daAbonos As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
		Dim dtAbonos As DataTable = New DataTable

		daAbonos.SelectCommand = _
		New SqlClient.SqlCommand("CONSULTA_ABONO", DBConnection)
		Try
			With daAbonos.SelectCommand
				.CommandType = CommandType.StoredProcedure
				With .Parameters
					.Add("@NumFactura", SqlDbType.BigInt)
					.Item("@NumFactura").Value = CLng(Me.NumFactura)
				End With
				.ExecuteNonQuery()
				daAbonos.Fill(dtAbonos)
			End With

			Informe.SetDataSource(dtAbonos)
			Informe.SetParameterValue("@NumFactura", CLng(Me.NumFactura))
			Informe.ParameterFields("@NumFactura").HasCurrentValue = True
			'FacturasViewer.EnableParameterPrompt = False
			Me.FacturasViewer.ReportSource = Informe
			'Me.FacturasViewer.RefreshReport()

		Catch ex As Exception
			MsgBox("Error en Abono: " & ex.Message)
		Finally
			daAbonos.Dispose()
			dtAbonos.Dispose()
		End Try
	End Sub
	Private Sub Form_Abono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.WindowState = FormWindowState.Maximized
		Me.Cargar_Datos(CType((New Aplicacion.Abono), ReportDocument))
	End Sub
	Public Function BajaAbono(Optional ByVal transaction As SqlClient.SqlTransaction = Nothing) As Single
		Dim cmdBajaAbono As SqlClient.SqlCommand = _
		New SqlClient.SqlCommand("BAJA_ABONO", DBConnection)
		Try
			With cmdBajaAbono
                .Transaction = transaction
				.CommandType = CommandType.StoredProcedure
				.Parameters.Add("@Numero", SqlDbType.BigInt)
				.Parameters.Item("@Numero").Value = Me.NumAbono
				.ExecuteNonQuery()
				BajaAbono = 0
			End With
		Catch ex As Exception
            If transaction IsNot Nothing Then Throw
			MsgBox("Error al eliminar Abono: " & ex.Message)
			Return -1
		Finally
			cmdBajaAbono.Dispose()
		End Try
	End Function
	Public Sub AltaAbono(Optional ByVal transaction As SqlClient.SqlTransaction = Nothing)
		Dim cmdAltaAbono As New SqlClient.SqlCommand("ALTA_ABONO", DBConnection)
		Try
			With cmdAltaAbono
                .Transaction = transaction
				.CommandType = CommandType.StoredProcedure
				With .Parameters
					.Add("@ConceptoDescuento", SqlDbType.NVarChar)
					.Item("@ConceptoDescuento").Value = Me.ConceptoDescuento
					.Add("@NumAbono", SqlDbType.BigInt)
					.Item("@NumAbono").Value = Me.NumAbono
					.Add("@NumFactura", SqlDbType.BigInt)
					.Item("@NumFactura").Value = RegFacturaVentas.Numero
				End With
				.ExecuteNonQuery()
			End With
		Catch ex As Exception
            If transaction IsNot Nothing Then Throw
			MessageBox.Show("Error al crear abono: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Finally
			cmdAltaAbono.Dispose()
		End Try
	End Sub
	Public Function ExisteAbono(Optional ByVal transaction As SqlClient.SqlTransaction = Nothing) As Boolean
		Dim daExisteAbono As New SqlDataAdapter("SELECT [Facturas].[dbo].[ExisteAbono] (@NumFactura)", DBConnection)
		Try
			daExisteAbono.SelectCommand.Transaction = transaction
            daExisteAbono.SelectCommand.Parameters.Add("@NumFactura", SqlDbType.BigInt)
			daExisteAbono.SelectCommand.Parameters("@NumFactura").Value = Me.NumFactura
			ExisteAbono = CBool(daExisteAbono.SelectCommand.ExecuteScalar())
		Catch ex As Exception
            If transaction IsNot Nothing Then Throw
			MsgBox("Error al calcular abono: " & ex.Message)
		Finally
			daExisteAbono.Dispose()
		End Try
	End Function
	Public Function NumeroAbono() As Long
		Dim daMaxAbono As New SqlDataAdapter("SELECT [Facturas].[dbo].[MAX_ABONO]()", DBConnection)
		Dim daMaxFactura As New SqlDataAdapter("SELECT [Facturas].[dbo].[MAX_FACTURA_VENTAS]()", DBConnection)
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
