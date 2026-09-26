Option Strict Off
Option Explicit On
Friend Class Form_Importe_Factura
	Inherits System.Windows.Forms.Form
#Region "Código generado por el Diseñador de Windows Forms "
	Public Sub New()
		MyBase.New()
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
    Public WithEvents Text_Cantidad As System.Windows.Forms.TextBox
	Public WithEvents Label_Cantidad As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Aceptar As System.Windows.Forms.Button
	Public WithEvents Cancelar As System.Windows.Forms.Button
	'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Text_Cantidad = New System.Windows.Forms.TextBox
        Me.Label_Cantidad = New System.Windows.Forms.Label
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Text_Cantidad)
        Me.Frame1.Controls.Add(Me.Label_Cantidad)
        Me.Frame1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(537, 121)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Importe"
        '
        'Text_Cantidad
        '
        Me.Text_Cantidad.AcceptsReturn = True
        Me.Text_Cantidad.BackColor = System.Drawing.SystemColors.Window
        Me.Text_Cantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text_Cantidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text_Cantidad.Location = New System.Drawing.Point(432, 56)
        Me.Text_Cantidad.MaxLength = 0
        Me.Text_Cantidad.Name = "Text_Cantidad"
        Me.Text_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text_Cantidad.Size = New System.Drawing.Size(89, 23)
        Me.Text_Cantidad.TabIndex = 0
        Me.Text_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_Cantidad
        '
        Me.Label_Cantidad.BackColor = System.Drawing.SystemColors.Control
        Me.Label_Cantidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label_Cantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Cantidad.Location = New System.Drawing.Point(16, 56)
        Me.Label_Cantidad.Name = "Label_Cantidad"
        Me.Label_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label_Cantidad.Size = New System.Drawing.Size(417, 25)
        Me.Label_Cantidad.TabIndex = 4
        Me.Label_Cantidad.Text = "Introduzca el importe de la factura sin incluir el iva:"
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Aceptar.Location = New System.Drawing.Point(568, 32)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Aceptar.Size = New System.Drawing.Size(89, 25)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.Cancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cancelar.Location = New System.Drawing.Point(568, 72)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cancelar.Size = New System.Drawing.Size(89, 25)
        Me.Cancelar.TabIndex = 2
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Form_Importe_Factura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(671, 150)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Cancelar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Importe_Factura"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "Importe Factura"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
  Dim Preguntar As Boolean = False
  Private Sub Aceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Aceptar.Click
	If Me.Text_Cantidad.Text <> "" Then
		If IsNumeric(Me.Text_Cantidad.Text) Then
			If CDbl(Me.Text_Cantidad.Text) <> 0 Then
				RegFacturaCompras.Total = Val(Replace(Me.Text_Cantidad.Text, Coma, Punto))
				Me.Text_Cantidad.Text = ""

				If EsModificacionCompras Then
					Call ModificacionFacturaCompras(RegFacturaCompras)
					MsgBox("Modificación realizada con éxito", MsgBoxStyle.OkOnly, "Facturas")
					EsModificacionCompras = False
				Else
					Call AltaFacturaCompras(RegFacturaCompras)
					MsgBox("Apunte realizado con éxito", MsgBoxStyle.OkOnly, "Facturas")
					EsFacturaCompras = False
				End If
				Me.Close()
			Else
				MsgBox("La cantidad no puede ser cero", MsgBoxStyle.OkOnly, "Error")
			End If
		Else
			MsgBox("La cantidad debe ser numérica", MsgBoxStyle.OkOnly, "Error")
		End If
	Else
		MsgBox("La cantidad no puede ser nula", MsgBoxStyle.OkOnly, "Error")
	End If
  End Sub

  Private Sub Cancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cancelar.Click
    Preguntar = True
    Me.Close()
  End Sub

  Private Sub Form_Importe_Factura_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    Dim OK As MsgBoxResult
    If Preguntar Then
      OK = MsgBox("¿Desea cancelar el proceso?", MsgBoxStyle.YesNo, "Facturas")
      If OK = MsgBoxResult.Yes Then
        EsFacturaCompras = False
        If EsModificacionCompras Then EsModificacionCompras = False
      Else
        eventArgs.Cancel = True
      End If
      Preguntar = False
    End If
  End Sub
  Public Sub AltaFacturaCompras(ByRef RegFactura As tFacturaCompras)
		Dim cmdAltaFacturaCompras As SqlClient.SqlCommand = _
				New SqlClient.SqlCommand("ALTA_FACTURA_COMPRAS", DBConnection)
	Try
	  With cmdAltaFacturaCompras
		.CommandType = CommandType.StoredProcedure
			.Parameters.Add("@CodPro", SqlDbType.BigInt)
			.Parameters("@CodPro").Value = CLng(RegFactura.Cod_Pro)
			.Parameters.Add("@NumFactura", SqlDbType.NVarChar)
			.Parameters("@NumFactura").Value = RegFactura.Numero
			.Parameters.Add("@Fecha", SqlDbType.DateTime)
			.Parameters("@Fecha").Value = RegFactura.Fecha
			.Parameters.Add("@TipoIva", SqlDbType.SmallInt)
			.Parameters("@TipoIva").Value = RegFactura.TipoIva
			.Parameters.Add("@Base", SqlDbType.Real)
			.Parameters("@Base").Value = RegFactura.Total
		.ExecuteNonQuery()
	  End With
	Catch ex As ApplicationException
	  MessageBox.Show("Error " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	  cmdAltaFacturaCompras.Dispose()
	  cmdAltaFacturaCompras = Nothing
	End Try
  End Sub
  Public Sub ModificacionFacturaCompras(ByRef RegFactura As tFacturaCompras)
	Dim cmdUpdFacturaCompras As SqlClient.SqlCommand = _
	New SqlClient.SqlCommand("MODIFICACION_FACTURA_COMPRAS", DBConnection)
	Try
	  With cmdUpdFacturaCompras
		.CommandType = CommandType.StoredProcedure
		.Parameters.Add("@CodPro", SqlDbType.BigInt)
		.Parameters("@CodPro").Value = CLng(RegFactura.Cod_Pro)
		.Parameters.Add("@NumFactura", SqlDbType.NVarChar)
		.Parameters("@NumFactura").Value = RegFactura.Numero
		.Parameters.Add("@NuevoNumFactura", SqlDbType.NVarChar)
		.Parameters("@NuevoNumFactura").Value = RegFactura.Numero
		.Parameters.Add("@Fecha", SqlDbType.Date)
		.Parameters("@Fecha").Value = RegFactura.Fecha
		.Parameters.Add("@TipoIva", SqlDbType.Real)
		.Parameters("@TipoIva").Value = RegFactura.TipoIva
		.Parameters.Add("@Base", SqlDbType.Real)
		.Parameters("@Base").Value = RegFactura.Total
		Dim num As Integer = .ExecuteNonQuery()
	  End With
	Catch ex As ApplicationException
	  MessageBox.Show("Error " & ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
	Finally
	  cmdUpdFacturaCompras.Dispose()
	  cmdUpdFacturaCompras = Nothing
	End Try
  End Sub
End Class