Public Class Form_Report_Factura
    Friend WithEvents ListadoComprasViewer As Microsoft.Reporting.WinForms.ReportViewer

    Private Sub Form_Report_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.ReportViewer1.RefreshReport()
        Me.ListadoComprasViewer.RefreshReport()
    End Sub
End Class