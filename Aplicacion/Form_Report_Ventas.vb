Public Class Form_Report_Ventas
  Private Sub Form_Report_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.VentasViewer.RefreshReport()
  End Sub

  Public Sub New()

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

  End Sub
  Public Sub New(ByVal tipoInforme As String)

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    Me.VentasViewer.ServerReport.ReportPath = "/Facturas de Ventas/" & tipoInforme
  End Sub

End Class