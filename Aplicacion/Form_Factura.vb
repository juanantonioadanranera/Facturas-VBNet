Imports CrystalDecisions.CrystalReports.Engine
Public Class Form_Factura
  Inherits System.Windows.Forms.Form
  Private NumeroFactura As Long
#Region " Código generado por el Diseñador de Windows Forms "

  Public Sub New(ByVal NumFactura As Long)
    MyBase.New()

    'El Diseñador de Windows Forms requiere esta llamada.
    InitializeComponent()
    'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    Me.NumeroFactura = NumFactura
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
        Me.FacturasViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'FacturasViewer
        '
        Me.FacturasViewer.ActiveViewIndex = -1
        Me.FacturasViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FacturasViewer.CausesValidation = False
        Me.FacturasViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.FacturasViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FacturasViewer.Location = New System.Drawing.Point(0, 0)
        Me.FacturasViewer.Name = "FacturasViewer"
        Me.FacturasViewer.SelectionFormula = ""
        Me.FacturasViewer.Size = New System.Drawing.Size(640, 373)
        Me.FacturasViewer.TabIndex = 0
        Me.FacturasViewer.ToolPanelWidth = 320
        Me.FacturasViewer.ViewTimeSelectionFormula = ""
        '
        'Form_Factura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(640, 373)
        Me.Controls.Add(Me.FacturasViewer)
        Me.Name = "Form_Factura"
        Me.Text = "Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cargar_Datos(ByRef Informe As ReportDocument)
    Dim daFacturasVentas As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
	Dim dtFacturasVentas As DataTable = New DataTable

	daFacturasVentas.SelectCommand = _
	New SqlClient.SqlCommand("CONSULTA_FACTURA_VENTAS", DBConnection)
	Try
	  With daFacturasVentas.SelectCommand
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@NumFactura", SqlDbType.BigInt)
		  .Item("@NumFactura").Value = CLng(Me.NumeroFactura)
		End With
		.ExecuteNonQuery()
		daFacturasVentas.Fill(dtFacturasVentas)
	  End With

	  Informe.SetDataSource(dtFacturasVentas)
	  Me.FacturasViewer.ReportSource = Informe
	  Informe.SetParameterValue("@NumFactura", CLng(Me.NumeroFactura))
	  Me.FacturasViewer.RefreshReport()

	Catch ex As Exception
	  MsgBox("Error en Factura Ventas:" & ex.Message)
	Finally
	  daFacturasVentas.Dispose()
	  dtFacturasVentas.Dispose()
	End Try
  End Sub
  Private Sub Form_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.WindowState = FormWindowState.Maximized
    Me.Cargar_Datos(CType((New Aplicacion.Factura), ReportDocument))
  End Sub
  Public Function BajaFactura(ByVal Numero As Integer, Optional ByVal transaction As SqlClient.SqlTransaction = Nothing) As Single
    Dim cmdBajaFacturaVentas As SqlClient.SqlCommand = _
    New SqlClient.SqlCommand("BAJA_FACTURA_VENTAS", DBConnection)
    Try
      With cmdBajaFacturaVentas
        .Transaction = transaction
        .CommandType = CommandType.StoredProcedure
        .Parameters.Add("@NumFactura", SqlDbType.BigInt)
        .Parameters.Item("@NumFactura").Value = CLng(Numero)
        .ExecuteNonQuery()
        BajaFactura = 0
      End With
    Catch ex As Exception
      If transaction IsNot Nothing Then Throw
      MsgBox("Error al eliminar Factura: " & ex.Message)
      Return -1
    Finally
      cmdBajaFacturaVentas.Dispose()
    End Try
  End Function
  Public Sub AltaFactura(ByVal RegFactura As tFacturaVentas, Optional ByVal transaction As SqlClient.SqlTransaction = Nothing)
        Dim cmdAltaFacturaVentas As SqlClient.SqlCommand
        If RegFacturaVentas.Suministros = True Then
            cmdAltaFacturaVentas = New SqlClient.SqlCommand("ALTA_FACTURA_SUMINISTROS", DBConnection)
        Else
            cmdAltaFacturaVentas = New SqlClient.SqlCommand("ALTA_FACTURA_VENTAS", DBConnection)
        End If
        Try
      With cmdAltaFacturaVentas
        .Transaction = transaction
        .CommandType = CommandType.StoredProcedure
        With .Parameters
          .Add("@TipoIva", SqlDbType.Decimal)
          .Item("@TipoIva").Value = RegFactura.TipoIva
          .Add("@TipoDescuento", SqlDbType.Decimal)
          .Item("@TipoDescuento").Value = RegFactura.TipoDescuento
          .Add("@NumFactura", SqlDbType.BigInt)
                    .Item("@NumFactura").Value = RegFactura.Numero
                    .Add("@CodCli", SqlDbType.BigInt)
                    .Item("@CodCli").Value = RegFactura.Cod_Cli
                    .Add("@Destino", SqlDbType.NVarChar)
		  .Item("@Destino").Value = RegFactura.Destino
		  .Add("@FechaFactura", SqlDbType.Date)
		  .Item("@FechaFactura").Value = RegFactura.Fecha
        End With
        .ExecuteNonQuery()
      End With
    Catch ex As Exception
      If transaction IsNot Nothing Then Throw
	  MessageBox.Show("Error al crear factura: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
            cmdAltaFacturaVentas.Dispose()
        End Try
  End Sub
  Public Sub BajaHistorico(ByVal NumFactura As Integer, Optional ByVal transaction As SqlClient.SqlTransaction = Nothing)
	Dim cmdBajaHistorico As New SqlClient.SqlCommand("BAJA_HISTORICO", DBConnection)
	Try
	  With cmdBajaHistorico
        .Transaction = transaction
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@NumFactura", SqlDbType.Int)
		  .Item("@NumFactura").Value = NumFactura
		End With
		.ExecuteNonQuery()
	  End With
	Catch ex As Exception
      If transaction IsNot Nothing Then Throw
	  MessageBox.Show("Error al eliminar histórico: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	  cmdBajaHistorico.Dispose()
	End Try
  End Sub
  Public Sub AltaHistorico(ByVal RegFactura As tFacturaVentas, Optional ByVal transaction As SqlClient.SqlTransaction = Nothing)
        Dim cmdAltaHistorico As SqlClient.SqlCommand
        If RegFacturaVentas.Suministros = True Then
            cmdAltaHistorico = New SqlClient.SqlCommand("ALTA_HISTORICO_SUMINISTROS", DBConnection)
        Else
            cmdAltaHistorico = New SqlClient.SqlCommand("ALTA_HISTORICO", DBConnection)
        End If
        Try
	  With cmdAltaHistorico
        .Transaction = transaction
		.CommandType = CommandType.StoredProcedure
		With .Parameters
		  .Add("@CodCli", SqlDbType.Int)
		  .Item("@CodCli").Value = RegFactura.Cod_Cli
		  .Add("@NumFactura", SqlDbType.Int)
		  .Item("@NumFactura").Value = RegFactura.Numero
		  .Add("@Destino", SqlDbType.NVarChar)
		  .Item("@Destino").Value = RegFactura.Destino
		  .Add("@FechaFactura", SqlDbType.Date)
		  .Item("@FechaFactura").Value = RegFactura.Fecha
		End With
		.ExecuteNonQuery()
	  End With
	Catch ex As Exception
      If transaction IsNot Nothing Then Throw
	  MessageBox.Show("Error al crear histórico: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	  cmdAltaHistorico.Dispose()
	End Try
  End Sub

    Public Sub ActualizaAlbaranes(ByVal RegFactura As tFacturaVentas, Optional ByVal transaction As SqlClient.SqlTransaction = Nothing)
        Dim cmdUpdAlbaranes As SqlClient.SqlCommand
        If RegFacturaVentas.Suministros = True Then
            cmdUpdAlbaranes = New SqlClient.SqlCommand("ACTUALIZA_ALBARANES_SUMINISTROS_FACTURADO", DBConnection)
        Else
            cmdUpdAlbaranes = New SqlClient.SqlCommand("ACTUALIZA_ALBARANES_FACTURADO", DBConnection)
        End If
        Try
            With cmdUpdAlbaranes
                .Transaction = transaction
                .CommandType = CommandType.StoredProcedure
                With .Parameters
                    .Add("@Destino", SqlDbType.NVarChar)
                    .Item("@Destino").Value = RegFactura.Destino
                    .Add("@NumFactura", SqlDbType.Int)
                    .Item("@NumFactura").Value = RegFactura.Numero

                    .Add("@FechaFactura", SqlDbType.Date)
                    .Item("@FechaFactura").Value = RegFactura.Fecha
                    .Add("@CodCli", SqlDbType.Int)
                    .Item("@CodCli").Value = RegFactura.Cod_Cli
                End With
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            If transaction IsNot Nothing Then Throw
            MessageBox.Show("Error: " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmdUpdAlbaranes.Dispose()
        End Try
    End Sub
    Public Sub GuardarFactura(ByVal RegFactura As tFacturaVentas, ByVal esModificacion As Boolean, ByVal abono As Form_Abono)
        Using transaction As SqlClient.SqlTransaction = DBConnection.BeginTransaction()
            Try
                If esModificacion Then
                    If BajaFactura(CInt(RegFactura.Numero), transaction) <> 0 Then
                        Throw New InvalidOperationException("No se pudo eliminar la factura anterior.")
                    End If
                    BajaHistorico(CInt(RegFactura.Numero), transaction)
                End If
                AltaFactura(RegFactura, transaction)
                AltaHistorico(RegFactura, transaction)
                ActualizaAlbaranes(RegFactura, transaction)
                If abono IsNot Nothing Then
                    If abono.ExisteAbono(transaction) Then
                        If abono.BajaAbono(transaction) <> 0 Then Throw New InvalidOperationException("No se pudo eliminar el abono anterior.")
                    End If
                    abono.AltaAbono(transaction)
                End If
                transaction.Commit()
            Catch
                transaction.Rollback()
                Throw
            End Try
        End Using
    End Sub
End Class
