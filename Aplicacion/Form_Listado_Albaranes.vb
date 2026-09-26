Public Class Form_Listado_Albaranes

    Private Sub Form_Listado_Albaranes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AlbaranesViewer.RefreshReport()
    End Sub

	Public Sub New()

		' Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

	End Sub

	Protected Overrides Sub Finalize()
		MyBase.Finalize()
	End Sub
End Class