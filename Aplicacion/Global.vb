Option Strict Off
Option Explicit On
Imports System.Data.SqlClient

Module [Global]
	
	Public DBConnection As SqlClient.SqlConnection

	Public EsFacturaCompras, EsListadoCompras, Consulta_Proveedor, Baja_Proveedor, EsModificacionCompras, _
	Consulta_Cliente, Baja_Cliente, Consulta_Albaran, Baja_Albaran, Consulta_Material, Baja_Material, Alta_Material, _
	Modificacion_Material, Alta_Albaran, Modificacion_Albaran, Alta_Cliente, Modificacion_Cliente, EsModificacionVentas, _
	Alta_Proveedor, Modificacion_Proveedor, EsListadoVentas, EsFacturaVentas, HayDescuento, Modificacion_Factura, _
	EsBajaVentas, EsConsultaVentas As Boolean
	
	Public FechaFactura, FechaFin, FechaInicio, Destino As String
	Public Const Coma As String = ","
	Public Const Punto As String = "."
	Public RegFacturaVentas As tFacturaVentas
	Public RegFacturaCompras As tFacturaCompras
	Public Sub Inicializar()
		EsFacturaCompras = False
		EsListadoCompras = False
		Consulta_Proveedor = False
		Baja_Proveedor = False
		EsModificacionCompras = False
		Consulta_Cliente = False
		Baja_Cliente = False
		Consulta_Albaran = False
		Baja_Albaran = False
		Consulta_Material = False
		Baja_Material = False
		Alta_Material = False
		Modificacion_Material = False
		Alta_Albaran = False
		Modificacion_Albaran = False
		Alta_Cliente = False
		Modificacion_Cliente = False
		EsModificacionVentas = False
		Alta_Proveedor = False
		Modificacion_Proveedor = False
		EsListadoVentas = False
		EsFacturaVentas = False
		HayDescuento = False
		Modificacion_Factura = False
		EsBajaVentas = False
		EsConsultaVentas = False
	End Sub
End Module