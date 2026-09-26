<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Report_Ventas
  Inherits System.Windows.Forms.Form
Friend WithEvents VentasViewer As Microsoft.Reporting.WinForms.ReportViewer
  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.VentasViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'VentasViewer
        '
        Me.VentasViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VentasViewer.Location = New System.Drawing.Point(0, 0)
        Me.VentasViewer.Name = "VentasViewer"
        Me.VentasViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.VentasViewer.ServerReport.ReportPath = "/Facturas de Ventas/Facturas de Ventas"
        Me.VentasViewer.ServerReport.ReportServerUrl = New System.Uri("http://ganimedes/reportserver", System.UriKind.Absolute)
        Me.VentasViewer.Size = New System.Drawing.Size(292, 273)
        Me.VentasViewer.TabIndex = 0
        '
        'Form_Report_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.VentasViewer)
        Me.Name = "Form_Report_Ventas"
        Me.Text = "Informe Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

End Class
