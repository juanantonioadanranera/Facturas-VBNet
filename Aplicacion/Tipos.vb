Option Strict Off
Option Explicit On
Public Module Tipos
  Public Structure tMaterial
    Dim Codigo As Integer
    Dim Descripcion As String
    Dim Precio As String
  End Structure

  Public Structure tCliente
    Dim Codigo As Integer
    Dim Nombre As String
    Dim NIF As String
    Dim Direccion As String
    Dim Localidad As String
    Dim CodPostal As String
    Dim Destino As String
    Dim Telefono As String
  End Structure

  Public Structure tProveedor
    Dim Codigo As Integer
    Dim Nombre As String
    Dim NIF As String
    Dim Direccion As String
    Dim Localidad As String
    Dim CodPostal As String
    Dim Telefono As String
  End Structure


  Public Structure tDetalle
    Dim Cod_Cli As Integer
    Dim Nombre As String
    Dim NIF As String
    Dim Direccion As String
    Dim Localidad As String
    Dim CodPostal As String
    Dim Destino As String
    Dim Descripcion As String
    Dim Precio As Double
    Dim Unidades As Double
    Dim Fecha As Date
    Dim Numero As Integer
    Dim Cod_Mat As Integer
  End Structure

  Public Structure tFacturaVentas
    Public Cod_Cli As Long
    Public Nombre As String
    Public Fecha As Date
	Public Numero As Long
    Public Total As Single
    Public Iva As Single
    Public TotalConIva As Single
    Public Destino As String
    Public Descuento As Single
    Public TipoIva As Double
    Public TipoDescuento As Double
    Public ConceptoDescuento As String
        Public Cobrada As Boolean
        Public Suministros As Boolean
    End Structure

  Public Structure tFacturaCompras
    Dim Cod_Pro As String
    Dim Fecha As Date
    Dim Numero As String
		Dim Total As Double
		Dim Iva As Double
		Dim TotalConIva As Double
    Dim TipoIva As Byte
  End Structure

  Public Structure tAlbaran
    Dim Cod_Cli As Integer
    Dim Cod_Mat As Integer
    Dim Fecha As Date
    Dim Numero As Integer
    Dim Descripcion As String
    Dim Cantidad As Single
    Dim Facturado As Boolean
    Dim Destino As String
    Dim Cliente As String
  End Structure
End Module