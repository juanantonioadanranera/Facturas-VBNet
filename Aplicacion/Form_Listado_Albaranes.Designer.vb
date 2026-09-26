<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Listado_Albaranes
    Inherits System.Windows.Forms.Form

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
        Me.AlbaranesViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'AlbaranesViewer
        '
        Me.AlbaranesViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.AlbaranesViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlbaranesViewer.Location = New System.Drawing.Point(0, 0)
        Me.AlbaranesViewer.Name = "AlbaranesViewer"
        Me.AlbaranesViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.AlbaranesViewer.ServerReport.ReportPath = "/Borradores/Borradores"
        Me.AlbaranesViewer.ServerReport.ReportServerUrl = New System.Uri("http://ganimedes/reportserver", System.UriKind.Absolute)
        Me.AlbaranesViewer.Size = New System.Drawing.Size(292, 273)
        Me.AlbaranesViewer.TabIndex = 0
        '
        'Form_Listado_Albaranes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.AlbaranesViewer)
        Me.Name = "Form_Listado_Albaranes"
        Me.Text = "Informe Albaranes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AlbaranesViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
