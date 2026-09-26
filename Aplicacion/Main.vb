Option Strict Off
Option Explicit On
Imports System.Windows.Media
Imports System.Threading
Imports System.Windows.Threading
Friend Class frmMain
    Inherits System.Windows.Forms.Form
    Dim frmPromptFecha As Form_Prompt_Fecha
    Dim frmPromptProveedores As Form_Prompt_Proveedores
    Dim frmPromptNumero As Form_Prompt_Numero
    Dim frmMaterial As Form_Materiales
    Dim frmProveedor As Form_Proveedores
    Dim frmAlbaran As Form_Albaranes
    Dim frmNumeroAlbaran As Form_Numero_Albaran
    Dim frmPromptMateriales As Form_Prompt_Materiales
    Dim frmIntervalo As Form_Intervalo
    Dim frmClientes As Form_Clientes
    Dim frmPromptCliente As Form_Prompt_Clientes
    Dim frmFactura As Form_Report_Factura

#Region "Código generado por el Diseñador de Windows Forms "
    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
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
    Public WithEvents cmdConsultaProveedor As System.Windows.Forms.Button
    Public WithEvents cmdModificacionProveedor As System.Windows.Forms.Button
    Public WithEvents cmdBajaProveedor As System.Windows.Forms.Button
    Public WithEvents cmdAltaProveedor As System.Windows.Forms.Button
    Public WithEvents TabControl_TabPage0 As System.Windows.Forms.TabPage
    Public WithEvents cmdConsultaCliente As System.Windows.Forms.Button
    Public WithEvents cmdModificacionCliente As System.Windows.Forms.Button
    Public WithEvents cmdBajaCliente As System.Windows.Forms.Button
    Public WithEvents cmdAltaCliente As System.Windows.Forms.Button
    Public WithEvents TabControl_TabPage1 As System.Windows.Forms.TabPage
    Public WithEvents cmdConsultaMaterial As System.Windows.Forms.Button
    Public WithEvents cmdModificacionMaterial As System.Windows.Forms.Button
    Public WithEvents cmdBajaMaterial As System.Windows.Forms.Button
    Public WithEvents cmdAltaMaterial As System.Windows.Forms.Button
    Public WithEvents TabControl_TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents cmdAltaAlbaran As System.Windows.Forms.Button
    Public WithEvents cmdBajaAlbaran As System.Windows.Forms.Button
    Public WithEvents cmdModificacionAlbaran As System.Windows.Forms.Button
    Public WithEvents cmdConsultaAlbaran As System.Windows.Forms.Button
    Public WithEvents TabControl_TabPage3 As System.Windows.Forms.TabPage
    Public WithEvents cmdConsultaFacturaVentas As System.Windows.Forms.Button
    Public WithEvents cmdAltaFacturaVentas As System.Windows.Forms.Button
    Public WithEvents TabControl_TabPage4 As System.Windows.Forms.TabPage
    Public WithEvents TabControl_TabPage5 As System.Windows.Forms.TabPage
    Public WithEvents cmdAltaFacturaCompras As System.Windows.Forms.Button
    Public WithEvents TabControl_TabPage6 As System.Windows.Forms.TabPage
    Public WithEvents TabControl As System.Windows.Forms.TabControl
    Public WithEvents Marco As System.Windows.Forms.GroupBox
    Public WithEvents Salir As System.Windows.Forms.MenuItem
    Public WithEvents Archivo As System.Windows.Forms.MenuItem
    Public WithEvents Alta_Proveedores As System.Windows.Forms.MenuItem
    Public WithEvents Baja_Proveedores As System.Windows.Forms.MenuItem
    Public WithEvents Modificacion_Proveedores As System.Windows.Forms.MenuItem
    Public WithEvents Consulta_Proveedores As System.Windows.Forms.MenuItem
    Public WithEvents Proveedores As System.Windows.Forms.MenuItem
    Public WithEvents Alta_Clientes As System.Windows.Forms.MenuItem
    Public WithEvents Baja_Clientes As System.Windows.Forms.MenuItem
    Public WithEvents Modificacion_Clientes As System.Windows.Forms.MenuItem
    Public WithEvents Consulta_Clientes As System.Windows.Forms.MenuItem
    Public WithEvents Clientes As System.Windows.Forms.MenuItem
    Public WithEvents Alta_Materiales As System.Windows.Forms.MenuItem
    Public WithEvents Baja_Materiales As System.Windows.Forms.MenuItem
    Public WithEvents Modificacion_Materiales As System.Windows.Forms.MenuItem
    Public WithEvents Consulta_Materiales As System.Windows.Forms.MenuItem
    Public WithEvents Materiales As System.Windows.Forms.MenuItem
    Public WithEvents Alta_Albaranes As System.Windows.Forms.MenuItem
    Public WithEvents Baja_Albaranes As System.Windows.Forms.MenuItem
    Public WithEvents Modificacion_Albaranes As System.Windows.Forms.MenuItem
    Public WithEvents Consulta_Albaranes As System.Windows.Forms.MenuItem
    Public WithEvents Albaranes As System.Windows.Forms.MenuItem
    Public WithEvents Alta_Factura_Ventas As System.Windows.Forms.MenuItem
    Public WithEvents Consulta_Factura_Ventas As System.Windows.Forms.MenuItem
    Public WithEvents Facturas As System.Windows.Forms.MenuItem
    Public WithEvents Alta_Factura_Compras As System.Windows.Forms.MenuItem
    Public WithEvents ListadoFacturasCompras As System.Windows.Forms.MenuItem
    Public WithEvents Apuntes As System.Windows.Forms.MenuItem
    Public WithEvents Listado_Ingresos As System.Windows.Forms.MenuItem
    Public WithEvents Listado_Gastos As System.Windows.Forms.MenuItem
    Public WithEvents Listados As System.Windows.Forms.MenuItem
    Friend WithEvents cmdModificacionFacturaVentas As System.Windows.Forms.Button
    Friend WithEvents Listado_Albaranes As System.Windows.Forms.MenuItem
    Public WithEvents Marco_Listados As System.Windows.Forms.GroupBox
    Public WithEvents cmdListadoAlbaranes As System.Windows.Forms.Button
    Friend WithEvents Marco_Albaranes As System.Windows.Forms.GroupBox
    Friend WithEvents Marco_Facturas_Compras As System.Windows.Forms.GroupBox
    Friend WithEvents Marco_Clientes As System.Windows.Forms.GroupBox
    Friend WithEvents Marco_Materiales As System.Windows.Forms.GroupBox
    Friend WithEvents Marco_Facturas_Ventas As System.Windows.Forms.GroupBox
    Friend WithEvents Marco_Proveedores As System.Windows.Forms.GroupBox
    Public WithEvents cmdListadoIngresos As System.Windows.Forms.Button
    Public WithEvents cmdListadoVentas As System.Windows.Forms.Button
    Public WithEvents cmdListadoVentasHacienda As System.Windows.Forms.Button
    Public WithEvents cmdListadoGastos As System.Windows.Forms.Button
    Public WithEvents cmdListadoCompras As System.Windows.Forms.Button
    Public WithEvents cmdBajaFacturaVentas As System.Windows.Forms.Button
    Public MainMenu1 As System.Windows.Forms.MainMenu
    'NOTA: el siguiente procedimiento es necesario para el Diseñador de Windows Forms
    'Se puede modificar mediante el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Marco = New System.Windows.Forms.GroupBox
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TabControl_TabPage0 = New System.Windows.Forms.TabPage
        Me.Marco_Proveedores = New System.Windows.Forms.GroupBox
        Me.cmdAltaProveedor = New System.Windows.Forms.Button
        Me.cmdBajaProveedor = New System.Windows.Forms.Button
        Me.cmdModificacionProveedor = New System.Windows.Forms.Button
        Me.cmdConsultaProveedor = New System.Windows.Forms.Button
        Me.TabControl_TabPage1 = New System.Windows.Forms.TabPage
        Me.Marco_Clientes = New System.Windows.Forms.GroupBox
        Me.cmdAltaCliente = New System.Windows.Forms.Button
        Me.cmdBajaCliente = New System.Windows.Forms.Button
        Me.cmdModificacionCliente = New System.Windows.Forms.Button
        Me.cmdConsultaCliente = New System.Windows.Forms.Button
        Me.TabControl_TabPage2 = New System.Windows.Forms.TabPage
        Me.Marco_Materiales = New System.Windows.Forms.GroupBox
        Me.cmdAltaMaterial = New System.Windows.Forms.Button
        Me.cmdBajaMaterial = New System.Windows.Forms.Button
        Me.cmdModificacionMaterial = New System.Windows.Forms.Button
        Me.cmdConsultaMaterial = New System.Windows.Forms.Button
        Me.TabControl_TabPage3 = New System.Windows.Forms.TabPage
        Me.Marco_Albaranes = New System.Windows.Forms.GroupBox
        Me.cmdAltaAlbaran = New System.Windows.Forms.Button
        Me.cmdBajaAlbaran = New System.Windows.Forms.Button
        Me.cmdModificacionAlbaran = New System.Windows.Forms.Button
        Me.cmdConsultaAlbaran = New System.Windows.Forms.Button
        Me.TabControl_TabPage4 = New System.Windows.Forms.TabPage
        Me.Marco_Facturas_Ventas = New System.Windows.Forms.GroupBox
        Me.cmdBajaFacturaVentas = New System.Windows.Forms.Button
        Me.cmdListadoIngresos = New System.Windows.Forms.Button
        Me.cmdConsultaFacturaVentas = New System.Windows.Forms.Button
        Me.cmdModificacionFacturaVentas = New System.Windows.Forms.Button
        Me.cmdAltaFacturaVentas = New System.Windows.Forms.Button
        Me.TabControl_TabPage5 = New System.Windows.Forms.TabPage
        Me.Marco_Listados = New System.Windows.Forms.GroupBox
        Me.cmdListadoCompras = New System.Windows.Forms.Button
        Me.cmdListadoVentas = New System.Windows.Forms.Button
        Me.cmdListadoVentasHacienda = New System.Windows.Forms.Button
        Me.cmdListadoAlbaranes = New System.Windows.Forms.Button
        Me.TabControl_TabPage6 = New System.Windows.Forms.TabPage
        Me.Marco_Facturas_Compras = New System.Windows.Forms.GroupBox
        Me.cmdListadoGastos = New System.Windows.Forms.Button
        Me.cmdAltaFacturaCompras = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.Archivo = New System.Windows.Forms.MenuItem
        Me.Salir = New System.Windows.Forms.MenuItem
        Me.Proveedores = New System.Windows.Forms.MenuItem
        Me.Alta_Proveedores = New System.Windows.Forms.MenuItem
        Me.Baja_Proveedores = New System.Windows.Forms.MenuItem
        Me.Modificacion_Proveedores = New System.Windows.Forms.MenuItem
        Me.Consulta_Proveedores = New System.Windows.Forms.MenuItem
        Me.Clientes = New System.Windows.Forms.MenuItem
        Me.Alta_Clientes = New System.Windows.Forms.MenuItem
        Me.Baja_Clientes = New System.Windows.Forms.MenuItem
        Me.Modificacion_Clientes = New System.Windows.Forms.MenuItem
        Me.Consulta_Clientes = New System.Windows.Forms.MenuItem
        Me.Materiales = New System.Windows.Forms.MenuItem
        Me.Alta_Materiales = New System.Windows.Forms.MenuItem
        Me.Baja_Materiales = New System.Windows.Forms.MenuItem
        Me.Modificacion_Materiales = New System.Windows.Forms.MenuItem
        Me.Consulta_Materiales = New System.Windows.Forms.MenuItem
        Me.Albaranes = New System.Windows.Forms.MenuItem
        Me.Alta_Albaranes = New System.Windows.Forms.MenuItem
        Me.Baja_Albaranes = New System.Windows.Forms.MenuItem
        Me.Modificacion_Albaranes = New System.Windows.Forms.MenuItem
        Me.Consulta_Albaranes = New System.Windows.Forms.MenuItem
        Me.Facturas = New System.Windows.Forms.MenuItem
        Me.Alta_Factura_Ventas = New System.Windows.Forms.MenuItem
        Me.Consulta_Factura_Ventas = New System.Windows.Forms.MenuItem
        Me.Apuntes = New System.Windows.Forms.MenuItem
        Me.Alta_Factura_Compras = New System.Windows.Forms.MenuItem
        Me.ListadoFacturasCompras = New System.Windows.Forms.MenuItem
        Me.Listados = New System.Windows.Forms.MenuItem
        Me.Listado_Ingresos = New System.Windows.Forms.MenuItem
        Me.Listado_Gastos = New System.Windows.Forms.MenuItem
        Me.Listado_Albaranes = New System.Windows.Forms.MenuItem
        Me.Marco.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabControl_TabPage0.SuspendLayout()
        Me.Marco_Proveedores.SuspendLayout()
        Me.TabControl_TabPage1.SuspendLayout()
        Me.Marco_Clientes.SuspendLayout()
        Me.TabControl_TabPage2.SuspendLayout()
        Me.Marco_Materiales.SuspendLayout()
        Me.TabControl_TabPage3.SuspendLayout()
        Me.Marco_Albaranes.SuspendLayout()
        Me.TabControl_TabPage4.SuspendLayout()
        Me.Marco_Facturas_Ventas.SuspendLayout()
        Me.TabControl_TabPage5.SuspendLayout()
        Me.Marco_Listados.SuspendLayout()
        Me.TabControl_TabPage6.SuspendLayout()
        Me.Marco_Facturas_Compras.SuspendLayout()
        Me.SuspendLayout()
        '
        'Marco
        '
        Me.Marco.BackColor = System.Drawing.SystemColors.Control
        Me.Marco.Controls.Add(Me.TabControl)
        Me.Marco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Marco.Location = New System.Drawing.Point(5, 5)
        Me.Marco.Name = "Marco"
        Me.Marco.Padding = New System.Windows.Forms.Padding(5)
        Me.Marco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Marco.Size = New System.Drawing.Size(755, 326)
        Me.Marco.TabIndex = 0
        Me.Marco.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabControl_TabPage0)
        Me.TabControl.Controls.Add(Me.TabControl_TabPage1)
        Me.TabControl.Controls.Add(Me.TabControl_TabPage2)
        Me.TabControl.Controls.Add(Me.TabControl_TabPage3)
        Me.TabControl.Controls.Add(Me.TabControl_TabPage4)
        Me.TabControl.Controls.Add(Me.TabControl_TabPage5)
        Me.TabControl.Controls.Add(Me.TabControl_TabPage6)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.ItemSize = New System.Drawing.Size(42, 18)
        Me.TabControl.Location = New System.Drawing.Point(5, 18)
        Me.TabControl.Multiline = True
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(3, 3)
        Me.TabControl.SelectedIndex = 3
        Me.TabControl.Size = New System.Drawing.Size(745, 303)
        Me.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl.TabIndex = 1
        '
        'TabControl_TabPage0
        '
        Me.TabControl_TabPage0.Controls.Add(Me.Marco_Proveedores)
        Me.TabControl_TabPage0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl_TabPage0.Location = New System.Drawing.Point(4, 40)
        Me.TabControl_TabPage0.Name = "TabControl_TabPage0"
        Me.TabControl_TabPage0.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl_TabPage0.Size = New System.Drawing.Size(737, 259)
        Me.TabControl_TabPage0.TabIndex = 0
        Me.TabControl_TabPage0.Text = "Proveedores"
        '
        'Marco_Proveedores
        '
        Me.Marco_Proveedores.AutoSize = True
        Me.Marco_Proveedores.Controls.Add(Me.cmdAltaProveedor)
        Me.Marco_Proveedores.Controls.Add(Me.cmdBajaProveedor)
        Me.Marco_Proveedores.Controls.Add(Me.cmdModificacionProveedor)
        Me.Marco_Proveedores.Controls.Add(Me.cmdConsultaProveedor)
        Me.Marco_Proveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco_Proveedores.Location = New System.Drawing.Point(3, 3)
        Me.Marco_Proveedores.Name = "Marco_Proveedores"
        Me.Marco_Proveedores.Size = New System.Drawing.Size(731, 253)
        Me.Marco_Proveedores.TabIndex = 17
        Me.Marco_Proveedores.TabStop = False
        '
        'cmdAltaProveedor
        '
        Me.cmdAltaProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAltaProveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAltaProveedor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAltaProveedor.Location = New System.Drawing.Point(22, 90)
        Me.cmdAltaProveedor.Name = "cmdAltaProveedor"
        Me.cmdAltaProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAltaProveedor.Size = New System.Drawing.Size(150, 60)
        Me.cmdAltaProveedor.TabIndex = 13
        Me.cmdAltaProveedor.Text = "Altas"
        Me.cmdAltaProveedor.UseVisualStyleBackColor = False
        '
        'cmdBajaProveedor
        '
        Me.cmdBajaProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBajaProveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBajaProveedor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBajaProveedor.Location = New System.Drawing.Point(203, 90)
        Me.cmdBajaProveedor.Name = "cmdBajaProveedor"
        Me.cmdBajaProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBajaProveedor.Size = New System.Drawing.Size(150, 60)
        Me.cmdBajaProveedor.TabIndex = 14
        Me.cmdBajaProveedor.Text = "Bajas"
        Me.cmdBajaProveedor.UseVisualStyleBackColor = False
        '
        'cmdModificacionProveedor
        '
        Me.cmdModificacionProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModificacionProveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModificacionProveedor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModificacionProveedor.Location = New System.Drawing.Point(381, 90)
        Me.cmdModificacionProveedor.Name = "cmdModificacionProveedor"
        Me.cmdModificacionProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModificacionProveedor.Size = New System.Drawing.Size(150, 60)
        Me.cmdModificacionProveedor.TabIndex = 15
        Me.cmdModificacionProveedor.Text = "Modificaciones"
        Me.cmdModificacionProveedor.UseVisualStyleBackColor = False
        '
        'cmdConsultaProveedor
        '
        Me.cmdConsultaProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultaProveedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultaProveedor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultaProveedor.Location = New System.Drawing.Point(564, 90)
        Me.cmdConsultaProveedor.Name = "cmdConsultaProveedor"
        Me.cmdConsultaProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultaProveedor.Size = New System.Drawing.Size(150, 60)
        Me.cmdConsultaProveedor.TabIndex = 16
        Me.cmdConsultaProveedor.Text = "Consultas"
        Me.cmdConsultaProveedor.UseVisualStyleBackColor = False
        '
        'TabControl_TabPage1
        '
        Me.TabControl_TabPage1.Controls.Add(Me.Marco_Clientes)
        Me.TabControl_TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabControl_TabPage1.Name = "TabControl_TabPage1"
        Me.TabControl_TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl_TabPage1.Size = New System.Drawing.Size(737, 259)
        Me.TabControl_TabPage1.TabIndex = 1
        Me.TabControl_TabPage1.Text = "Clientes"
        '
        'Marco_Clientes
        '
        Me.Marco_Clientes.Controls.Add(Me.cmdAltaCliente)
        Me.Marco_Clientes.Controls.Add(Me.cmdBajaCliente)
        Me.Marco_Clientes.Controls.Add(Me.cmdModificacionCliente)
        Me.Marco_Clientes.Controls.Add(Me.cmdConsultaCliente)
        Me.Marco_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco_Clientes.Location = New System.Drawing.Point(3, 3)
        Me.Marco_Clientes.Name = "Marco_Clientes"
        Me.Marco_Clientes.Size = New System.Drawing.Size(731, 253)
        Me.Marco_Clientes.TabIndex = 12
        Me.Marco_Clientes.TabStop = False
        '
        'cmdAltaCliente
        '
        Me.cmdAltaCliente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAltaCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAltaCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAltaCliente.Location = New System.Drawing.Point(6, 92)
        Me.cmdAltaCliente.Name = "cmdAltaCliente"
        Me.cmdAltaCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAltaCliente.Size = New System.Drawing.Size(150, 60)
        Me.cmdAltaCliente.TabIndex = 8
        Me.cmdAltaCliente.Text = "Altas"
        Me.cmdAltaCliente.UseVisualStyleBackColor = False
        '
        'cmdBajaCliente
        '
        Me.cmdBajaCliente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBajaCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBajaCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBajaCliente.Location = New System.Drawing.Point(162, 92)
        Me.cmdBajaCliente.Name = "cmdBajaCliente"
        Me.cmdBajaCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBajaCliente.Size = New System.Drawing.Size(150, 60)
        Me.cmdBajaCliente.TabIndex = 9
        Me.cmdBajaCliente.Text = "Bajas"
        Me.cmdBajaCliente.UseVisualStyleBackColor = False
        '
        'cmdModificacionCliente
        '
        Me.cmdModificacionCliente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModificacionCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModificacionCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModificacionCliente.Location = New System.Drawing.Point(415, 92)
        Me.cmdModificacionCliente.Name = "cmdModificacionCliente"
        Me.cmdModificacionCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModificacionCliente.Size = New System.Drawing.Size(150, 60)
        Me.cmdModificacionCliente.TabIndex = 10
        Me.cmdModificacionCliente.Text = "Modificaciones"
        Me.cmdModificacionCliente.UseVisualStyleBackColor = False
        '
        'cmdConsultaCliente
        '
        Me.cmdConsultaCliente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultaCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultaCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultaCliente.Location = New System.Drawing.Point(571, 92)
        Me.cmdConsultaCliente.Name = "cmdConsultaCliente"
        Me.cmdConsultaCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultaCliente.Size = New System.Drawing.Size(150, 60)
        Me.cmdConsultaCliente.TabIndex = 11
        Me.cmdConsultaCliente.Text = "Consultas"
        Me.cmdConsultaCliente.UseVisualStyleBackColor = False
        '
        'TabControl_TabPage2
        '
        Me.TabControl_TabPage2.Controls.Add(Me.Marco_Materiales)
        Me.TabControl_TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabControl_TabPage2.Name = "TabControl_TabPage2"
        Me.TabControl_TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl_TabPage2.Size = New System.Drawing.Size(737, 259)
        Me.TabControl_TabPage2.TabIndex = 2
        Me.TabControl_TabPage2.Text = "Materiales"
        '
        'Marco_Materiales
        '
        Me.Marco_Materiales.Controls.Add(Me.cmdAltaMaterial)
        Me.Marco_Materiales.Controls.Add(Me.cmdBajaMaterial)
        Me.Marco_Materiales.Controls.Add(Me.cmdModificacionMaterial)
        Me.Marco_Materiales.Controls.Add(Me.cmdConsultaMaterial)
        Me.Marco_Materiales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco_Materiales.Location = New System.Drawing.Point(3, 3)
        Me.Marco_Materiales.Name = "Marco_Materiales"
        Me.Marco_Materiales.Size = New System.Drawing.Size(731, 253)
        Me.Marco_Materiales.TabIndex = 7
        Me.Marco_Materiales.TabStop = False
        '
        'cmdAltaMaterial
        '
        Me.cmdAltaMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAltaMaterial.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAltaMaterial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAltaMaterial.Location = New System.Drawing.Point(6, 100)
        Me.cmdAltaMaterial.Name = "cmdAltaMaterial"
        Me.cmdAltaMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAltaMaterial.Size = New System.Drawing.Size(150, 60)
        Me.cmdAltaMaterial.TabIndex = 3
        Me.cmdAltaMaterial.Text = "Altas"
        Me.cmdAltaMaterial.UseVisualStyleBackColor = False
        '
        'cmdBajaMaterial
        '
        Me.cmdBajaMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBajaMaterial.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBajaMaterial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBajaMaterial.Location = New System.Drawing.Point(162, 100)
        Me.cmdBajaMaterial.Name = "cmdBajaMaterial"
        Me.cmdBajaMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBajaMaterial.Size = New System.Drawing.Size(150, 60)
        Me.cmdBajaMaterial.TabIndex = 4
        Me.cmdBajaMaterial.Text = "Bajas"
        Me.cmdBajaMaterial.UseVisualStyleBackColor = False
        '
        'cmdModificacionMaterial
        '
        Me.cmdModificacionMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModificacionMaterial.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModificacionMaterial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModificacionMaterial.Location = New System.Drawing.Point(415, 100)
        Me.cmdModificacionMaterial.Name = "cmdModificacionMaterial"
        Me.cmdModificacionMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModificacionMaterial.Size = New System.Drawing.Size(150, 60)
        Me.cmdModificacionMaterial.TabIndex = 5
        Me.cmdModificacionMaterial.Text = "Modificaciones"
        Me.cmdModificacionMaterial.UseVisualStyleBackColor = False
        '
        'cmdConsultaMaterial
        '
        Me.cmdConsultaMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultaMaterial.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultaMaterial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultaMaterial.Location = New System.Drawing.Point(571, 100)
        Me.cmdConsultaMaterial.Name = "cmdConsultaMaterial"
        Me.cmdConsultaMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultaMaterial.Size = New System.Drawing.Size(150, 60)
        Me.cmdConsultaMaterial.TabIndex = 6
        Me.cmdConsultaMaterial.Text = "Consultas"
        Me.cmdConsultaMaterial.UseVisualStyleBackColor = False
        '
        'TabControl_TabPage3
        '
        Me.TabControl_TabPage3.Controls.Add(Me.Marco_Albaranes)
        Me.TabControl_TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabControl_TabPage3.Name = "TabControl_TabPage3"
        Me.TabControl_TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl_TabPage3.Size = New System.Drawing.Size(737, 259)
        Me.TabControl_TabPage3.TabIndex = 3
        Me.TabControl_TabPage3.Text = "Albaranes"
        '
        'Marco_Albaranes
        '
        Me.Marco_Albaranes.Controls.Add(Me.cmdAltaAlbaran)
        Me.Marco_Albaranes.Controls.Add(Me.cmdBajaAlbaran)
        Me.Marco_Albaranes.Controls.Add(Me.cmdModificacionAlbaran)
        Me.Marco_Albaranes.Controls.Add(Me.cmdConsultaAlbaran)
        Me.Marco_Albaranes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco_Albaranes.Location = New System.Drawing.Point(3, 3)
        Me.Marco_Albaranes.Margin = New System.Windows.Forms.Padding(10)
        Me.Marco_Albaranes.Name = "Marco_Albaranes"
        Me.Marco_Albaranes.Padding = New System.Windows.Forms.Padding(10)
        Me.Marco_Albaranes.Size = New System.Drawing.Size(731, 253)
        Me.Marco_Albaranes.TabIndex = 25
        Me.Marco_Albaranes.TabStop = False
        '
        'cmdAltaAlbaran
        '
        Me.cmdAltaAlbaran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdAltaAlbaran.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAltaAlbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAltaAlbaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAltaAlbaran.Location = New System.Drawing.Point(13, 95)
        Me.cmdAltaAlbaran.Name = "cmdAltaAlbaran"
        Me.cmdAltaAlbaran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAltaAlbaran.Size = New System.Drawing.Size(150, 60)
        Me.cmdAltaAlbaran.TabIndex = 24
        Me.cmdAltaAlbaran.Text = "Altas"
        Me.cmdAltaAlbaran.UseVisualStyleBackColor = False
        '
        'cmdBajaAlbaran
        '
        Me.cmdBajaAlbaran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdBajaAlbaran.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBajaAlbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBajaAlbaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBajaAlbaran.Location = New System.Drawing.Point(203, 95)
        Me.cmdBajaAlbaran.Name = "cmdBajaAlbaran"
        Me.cmdBajaAlbaran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBajaAlbaran.Size = New System.Drawing.Size(150, 60)
        Me.cmdBajaAlbaran.TabIndex = 23
        Me.cmdBajaAlbaran.Text = "Bajas"
        Me.cmdBajaAlbaran.UseVisualStyleBackColor = False
        '
        'cmdModificacionAlbaran
        '
        Me.cmdModificacionAlbaran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdModificacionAlbaran.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModificacionAlbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModificacionAlbaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModificacionAlbaran.Location = New System.Drawing.Point(385, 95)
        Me.cmdModificacionAlbaran.Name = "cmdModificacionAlbaran"
        Me.cmdModificacionAlbaran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModificacionAlbaran.Size = New System.Drawing.Size(150, 60)
        Me.cmdModificacionAlbaran.TabIndex = 22
        Me.cmdModificacionAlbaran.Text = "Modificaciones"
        Me.cmdModificacionAlbaran.UseVisualStyleBackColor = False
        '
        'cmdConsultaAlbaran
        '
        Me.cmdConsultaAlbaran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdConsultaAlbaran.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultaAlbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultaAlbaran.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultaAlbaran.Location = New System.Drawing.Point(564, 95)
        Me.cmdConsultaAlbaran.Name = "cmdConsultaAlbaran"
        Me.cmdConsultaAlbaran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultaAlbaran.Size = New System.Drawing.Size(150, 60)
        Me.cmdConsultaAlbaran.TabIndex = 21
        Me.cmdConsultaAlbaran.Text = "Consultas"
        Me.cmdConsultaAlbaran.UseVisualStyleBackColor = False
        '
        'TabControl_TabPage4
        '
        Me.TabControl_TabPage4.Controls.Add(Me.Marco_Facturas_Ventas)
        Me.TabControl_TabPage4.Location = New System.Drawing.Point(4, 40)
        Me.TabControl_TabPage4.Name = "TabControl_TabPage4"
        Me.TabControl_TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl_TabPage4.Size = New System.Drawing.Size(737, 259)
        Me.TabControl_TabPage4.TabIndex = 4
        Me.TabControl_TabPage4.Text = "Emisión de Facturas"
        '
        'Marco_Facturas_Ventas
        '
        Me.Marco_Facturas_Ventas.Controls.Add(Me.cmdBajaFacturaVentas)
        Me.Marco_Facturas_Ventas.Controls.Add(Me.cmdListadoIngresos)
        Me.Marco_Facturas_Ventas.Controls.Add(Me.cmdConsultaFacturaVentas)
        Me.Marco_Facturas_Ventas.Controls.Add(Me.cmdModificacionFacturaVentas)
        Me.Marco_Facturas_Ventas.Controls.Add(Me.cmdAltaFacturaVentas)
        Me.Marco_Facturas_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco_Facturas_Ventas.Location = New System.Drawing.Point(3, 3)
        Me.Marco_Facturas_Ventas.Name = "Marco_Facturas_Ventas"
        Me.Marco_Facturas_Ventas.Size = New System.Drawing.Size(731, 253)
        Me.Marco_Facturas_Ventas.TabIndex = 29
        Me.Marco_Facturas_Ventas.TabStop = False
        '
        'cmdBajaFacturaVentas
        '
        Me.cmdBajaFacturaVentas.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBajaFacturaVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBajaFacturaVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBajaFacturaVentas.Location = New System.Drawing.Point(492, 178)
        Me.cmdBajaFacturaVentas.Name = "cmdBajaFacturaVentas"
        Me.cmdBajaFacturaVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBajaFacturaVentas.Size = New System.Drawing.Size(118, 60)
        Me.cmdBajaFacturaVentas.TabIndex = 31
        Me.cmdBajaFacturaVentas.Text = "Baja"
        Me.cmdBajaFacturaVentas.UseVisualStyleBackColor = False
        '
        'cmdListadoIngresos
        '
        Me.cmdListadoIngresos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdListadoIngresos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdListadoIngresos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdListadoIngresos.Location = New System.Drawing.Point(351, 34)
        Me.cmdListadoIngresos.Name = "cmdListadoIngresos"
        Me.cmdListadoIngresos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdListadoIngresos.Size = New System.Drawing.Size(118, 60)
        Me.cmdListadoIngresos.TabIndex = 30
        Me.cmdListadoIngresos.Text = "Listado de Ingresos"
        Me.cmdListadoIngresos.UseVisualStyleBackColor = False
        '
        'cmdConsultaFacturaVentas
        '
        Me.cmdConsultaFacturaVentas.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultaFacturaVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultaFacturaVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultaFacturaVentas.Location = New System.Drawing.Point(492, 100)
        Me.cmdConsultaFacturaVentas.Name = "cmdConsultaFacturaVentas"
        Me.cmdConsultaFacturaVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultaFacturaVentas.Size = New System.Drawing.Size(118, 60)
        Me.cmdConsultaFacturaVentas.TabIndex = 27
        Me.cmdConsultaFacturaVentas.Text = "Consulta"
        Me.cmdConsultaFacturaVentas.UseVisualStyleBackColor = False
        '
        'cmdModificacionFacturaVentas
        '
        Me.cmdModificacionFacturaVentas.Location = New System.Drawing.Point(492, 25)
        Me.cmdModificacionFacturaVentas.Name = "cmdModificacionFacturaVentas"
        Me.cmdModificacionFacturaVentas.Size = New System.Drawing.Size(118, 60)
        Me.cmdModificacionFacturaVentas.TabIndex = 28
        Me.cmdModificacionFacturaVentas.Text = "Modificación"
        Me.cmdModificacionFacturaVentas.UseVisualStyleBackColor = True
        '
        'cmdAltaFacturaVentas
        '
        Me.cmdAltaFacturaVentas.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAltaFacturaVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAltaFacturaVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAltaFacturaVentas.Location = New System.Drawing.Point(254, 178)
        Me.cmdAltaFacturaVentas.Name = "cmdAltaFacturaVentas"
        Me.cmdAltaFacturaVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAltaFacturaVentas.Size = New System.Drawing.Size(118, 60)
        Me.cmdAltaFacturaVentas.TabIndex = 26
        Me.cmdAltaFacturaVentas.Text = "Alta"
        Me.cmdAltaFacturaVentas.UseVisualStyleBackColor = False
        '
        'TabControl_TabPage5
        '
        Me.TabControl_TabPage5.Controls.Add(Me.Marco_Listados)
        Me.TabControl_TabPage5.Location = New System.Drawing.Point(4, 40)
        Me.TabControl_TabPage5.Name = "TabControl_TabPage5"
        Me.TabControl_TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl_TabPage5.Size = New System.Drawing.Size(737, 259)
        Me.TabControl_TabPage5.TabIndex = 5
        Me.TabControl_TabPage5.Text = "Listados"
        '
        'Marco_Listados
        '
        Me.Marco_Listados.BackColor = System.Drawing.SystemColors.Control
        Me.Marco_Listados.Controls.Add(Me.cmdListadoCompras)
        Me.Marco_Listados.Controls.Add(Me.cmdListadoVentas)
        Me.Marco_Listados.Controls.Add(Me.cmdListadoVentasHacienda)
        Me.Marco_Listados.Controls.Add(Me.cmdListadoAlbaranes)
        Me.Marco_Listados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco_Listados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Marco_Listados.Location = New System.Drawing.Point(3, 3)
        Me.Marco_Listados.Name = "Marco_Listados"
        Me.Marco_Listados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Marco_Listados.Size = New System.Drawing.Size(731, 253)
        Me.Marco_Listados.TabIndex = 17
        Me.Marco_Listados.TabStop = False
        '
        'cmdListadoCompras
        '
        Me.cmdListadoCompras.BackColor = System.Drawing.SystemColors.Control
        Me.cmdListadoCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdListadoCompras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdListadoCompras.Location = New System.Drawing.Point(318, 94)
        Me.cmdListadoCompras.Name = "cmdListadoCompras"
        Me.cmdListadoCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdListadoCompras.Size = New System.Drawing.Size(150, 60)
        Me.cmdListadoCompras.TabIndex = 33
        Me.cmdListadoCompras.Text = "Listado Compras Anual"
        Me.cmdListadoCompras.UseVisualStyleBackColor = False
        '
        'cmdListadoVentas
        '
        Me.cmdListadoVentas.BackColor = System.Drawing.SystemColors.Control
        Me.cmdListadoVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdListadoVentas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdListadoVentas.Location = New System.Drawing.Point(494, 94)
        Me.cmdListadoVentas.Name = "cmdListadoVentas"
        Me.cmdListadoVentas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdListadoVentas.Size = New System.Drawing.Size(150, 60)
        Me.cmdListadoVentas.TabIndex = 32
        Me.cmdListadoVentas.Text = "Listado Ventas Mensual"
        Me.cmdListadoVentas.UseVisualStyleBackColor = False
        '
        'cmdListadoVentasHacienda
        '
        Me.cmdListadoVentasHacienda.BackColor = System.Drawing.SystemColors.Control
        Me.cmdListadoVentasHacienda.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdListadoVentasHacienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdListadoVentasHacienda.Location = New System.Drawing.Point(494, 172)
        Me.cmdListadoVentasHacienda.Name = "cmdListadoVentasHacienda"
        Me.cmdListadoVentasHacienda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdListadoVentasHacienda.Size = New System.Drawing.Size(150, 60)
        Me.cmdListadoVentasHacienda.TabIndex = 31
        Me.cmdListadoVentasHacienda.Text = "Listado Ventas Anual"
        Me.cmdListadoVentasHacienda.UseVisualStyleBackColor = False
        '
        'cmdListadoAlbaranes
        '
        Me.cmdListadoAlbaranes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdListadoAlbaranes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdListadoAlbaranes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdListadoAlbaranes.Location = New System.Drawing.Point(318, 172)
        Me.cmdListadoAlbaranes.Name = "cmdListadoAlbaranes"
        Me.cmdListadoAlbaranes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdListadoAlbaranes.Size = New System.Drawing.Size(150, 60)
        Me.cmdListadoAlbaranes.TabIndex = 20
        Me.cmdListadoAlbaranes.Text = "Listado de Albaranes"
        Me.cmdListadoAlbaranes.UseVisualStyleBackColor = False
        '
        'TabControl_TabPage6
        '
        Me.TabControl_TabPage6.Controls.Add(Me.Marco_Facturas_Compras)
        Me.TabControl_TabPage6.Location = New System.Drawing.Point(4, 40)
        Me.TabControl_TabPage6.Name = "TabControl_TabPage6"
        Me.TabControl_TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabControl_TabPage6.Size = New System.Drawing.Size(737, 259)
        Me.TabControl_TabPage6.TabIndex = 6
        Me.TabControl_TabPage6.Text = "Apunte de Gastos"
        '
        'Marco_Facturas_Compras
        '
        Me.Marco_Facturas_Compras.AutoSize = True
        Me.Marco_Facturas_Compras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Marco_Facturas_Compras.Controls.Add(Me.cmdListadoGastos)
        Me.Marco_Facturas_Compras.Controls.Add(Me.cmdAltaFacturaCompras)
        Me.Marco_Facturas_Compras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Marco_Facturas_Compras.Location = New System.Drawing.Point(3, 3)
        Me.Marco_Facturas_Compras.Name = "Marco_Facturas_Compras"
        Me.Marco_Facturas_Compras.Padding = New System.Windows.Forms.Padding(5)
        Me.Marco_Facturas_Compras.Size = New System.Drawing.Size(731, 253)
        Me.Marco_Facturas_Compras.TabIndex = 31
        Me.Marco_Facturas_Compras.TabStop = False
        '
        'cmdListadoGastos
        '
        Me.cmdListadoGastos.BackColor = System.Drawing.SystemColors.Control
        Me.cmdListadoGastos.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdListadoGastos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdListadoGastos.Location = New System.Drawing.Point(537, 93)
        Me.cmdListadoGastos.Name = "cmdListadoGastos"
        Me.cmdListadoGastos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdListadoGastos.Size = New System.Drawing.Size(150, 60)
        Me.cmdListadoGastos.TabIndex = 31
        Me.cmdListadoGastos.Text = "Listado de Gastos"
        Me.cmdListadoGastos.UseVisualStyleBackColor = False
        '
        'cmdAltaFacturaCompras
        '
        Me.cmdAltaFacturaCompras.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAltaFacturaCompras.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAltaFacturaCompras.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAltaFacturaCompras.Location = New System.Drawing.Point(56, 93)
        Me.cmdAltaFacturaCompras.Name = "cmdAltaFacturaCompras"
        Me.cmdAltaFacturaCompras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAltaFacturaCompras.Size = New System.Drawing.Size(150, 60)
        Me.cmdAltaFacturaCompras.TabIndex = 29
        Me.cmdAltaFacturaCompras.Text = "Alta / Modificación"
        Me.cmdAltaFacturaCompras.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Archivo, Me.Proveedores, Me.Clientes, Me.Materiales, Me.Albaranes, Me.Facturas, Me.Apuntes, Me.Listados})
        '
        'Archivo
        '
        Me.Archivo.Index = 0
        Me.Archivo.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Salir})
        Me.Archivo.Text = "&Archivo"
        '
        'Salir
        '
        Me.Salir.Index = 0
        Me.Salir.Text = "&Salir"
        '
        'Proveedores
        '
        Me.Proveedores.Index = 1
        Me.Proveedores.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Alta_Proveedores, Me.Baja_Proveedores, Me.Modificacion_Proveedores, Me.Consulta_Proveedores})
        Me.Proveedores.Text = "&Proveedores"
        '
        'Alta_Proveedores
        '
        Me.Alta_Proveedores.Index = 0
        Me.Alta_Proveedores.Text = "&Altas"
        '
        'Baja_Proveedores
        '
        Me.Baja_Proveedores.Index = 1
        Me.Baja_Proveedores.Text = "&Bajas"
        '
        'Modificacion_Proveedores
        '
        Me.Modificacion_Proveedores.Index = 2
        Me.Modificacion_Proveedores.Text = "&Modificaciones"
        '
        'Consulta_Proveedores
        '
        Me.Consulta_Proveedores.Index = 3
        Me.Consulta_Proveedores.Text = "&Consultas"
        '
        'Clientes
        '
        Me.Clientes.Index = 2
        Me.Clientes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Alta_Clientes, Me.Baja_Clientes, Me.Modificacion_Clientes, Me.Consulta_Clientes})
        Me.Clientes.Text = "&Clientes"
        '
        'Alta_Clientes
        '
        Me.Alta_Clientes.Index = 0
        Me.Alta_Clientes.Text = "&Altas"
        '
        'Baja_Clientes
        '
        Me.Baja_Clientes.Index = 1
        Me.Baja_Clientes.Text = "&Bajas"
        '
        'Modificacion_Clientes
        '
        Me.Modificacion_Clientes.Index = 2
        Me.Modificacion_Clientes.Text = "&Modificaciones"
        '
        'Consulta_Clientes
        '
        Me.Consulta_Clientes.Index = 3
        Me.Consulta_Clientes.Text = "&Consultas"
        '
        'Materiales
        '
        Me.Materiales.Index = 3
        Me.Materiales.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Alta_Materiales, Me.Baja_Materiales, Me.Modificacion_Materiales, Me.Consulta_Materiales})
        Me.Materiales.Text = "&Materiales"
        '
        'Alta_Materiales
        '
        Me.Alta_Materiales.Index = 0
        Me.Alta_Materiales.Text = "&Altas"
        '
        'Baja_Materiales
        '
        Me.Baja_Materiales.Index = 1
        Me.Baja_Materiales.Text = "&Bajas"
        '
        'Modificacion_Materiales
        '
        Me.Modificacion_Materiales.Index = 2
        Me.Modificacion_Materiales.Text = "&Modificaciones"
        '
        'Consulta_Materiales
        '
        Me.Consulta_Materiales.Index = 3
        Me.Consulta_Materiales.Text = "&Consultas"
        '
        'Albaranes
        '
        Me.Albaranes.Index = 4
        Me.Albaranes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Alta_Albaranes, Me.Baja_Albaranes, Me.Modificacion_Albaranes, Me.Consulta_Albaranes})
        Me.Albaranes.Text = "&Albaranes"
        '
        'Alta_Albaranes
        '
        Me.Alta_Albaranes.Index = 0
        Me.Alta_Albaranes.Text = "&Altas"
        '
        'Baja_Albaranes
        '
        Me.Baja_Albaranes.Index = 1
        Me.Baja_Albaranes.Text = "&Bajas"
        '
        'Modificacion_Albaranes
        '
        Me.Modificacion_Albaranes.Index = 2
        Me.Modificacion_Albaranes.Text = "&Modificaciones"
        '
        'Consulta_Albaranes
        '
        Me.Consulta_Albaranes.Index = 3
        Me.Consulta_Albaranes.Text = "&Consultas"
        '
        'Facturas
        '
        Me.Facturas.Index = 5
        Me.Facturas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Alta_Factura_Ventas, Me.Consulta_Factura_Ventas})
        Me.Facturas.Text = "&Facturas"
        '
        'Alta_Factura_Ventas
        '
        Me.Alta_Factura_Ventas.Index = 0
        Me.Alta_Factura_Ventas.Text = "&Altas / Modificaciones"
        '
        'Consulta_Factura_Ventas
        '
        Me.Consulta_Factura_Ventas.Index = 1
        Me.Consulta_Factura_Ventas.Text = "&Consultas"
        '
        'Apuntes
        '
        Me.Apuntes.Index = 6
        Me.Apuntes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Alta_Factura_Compras, Me.ListadoFacturasCompras})
        Me.Apuntes.Text = "&Apuntes"
        '
        'Alta_Factura_Compras
        '
        Me.Alta_Factura_Compras.Index = 0
        Me.Alta_Factura_Compras.Text = "&Altas / Modificaciones"
        '
        'ListadoFacturasCompras
        '
        Me.ListadoFacturasCompras.Index = 1
        Me.ListadoFacturasCompras.Text = "&Consultas"
        '
        'Listados
        '
        Me.Listados.Index = 7
        Me.Listados.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Listado_Ingresos, Me.Listado_Gastos, Me.Listado_Albaranes})
        Me.Listados.Text = "&Listados"
        '
        'Listado_Ingresos
        '
        Me.Listado_Ingresos.Index = 0
        Me.Listado_Ingresos.Text = "&Ingresos"
        '
        'Listado_Gastos
        '
        Me.Listado_Gastos.Index = 1
        Me.Listado_Gastos.Text = "&Gastos"
        '
        'Listado_Albaranes
        '
        Me.Listado_Albaranes.Index = 2
        Me.Listado_Albaranes.Text = "Albaranes"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(765, 336)
        Me.Controls.Add(Me.Marco)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(10, 48)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(773, 364)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Facturas"
        Me.Marco.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabControl_TabPage0.ResumeLayout(False)
        Me.TabControl_TabPage0.PerformLayout()
        Me.Marco_Proveedores.ResumeLayout(False)
        Me.TabControl_TabPage1.ResumeLayout(False)
        Me.Marco_Clientes.ResumeLayout(False)
        Me.TabControl_TabPage2.ResumeLayout(False)
        Me.Marco_Materiales.ResumeLayout(False)
        Me.TabControl_TabPage3.ResumeLayout(False)
        Me.Marco_Albaranes.ResumeLayout(False)
        Me.TabControl_TabPage4.ResumeLayout(False)
        Me.Marco_Facturas_Ventas.ResumeLayout(False)
        Me.TabControl_TabPage5.ResumeLayout(False)
        Me.Marco_Listados.ResumeLayout(False)
        Me.TabControl_TabPage6.ResumeLayout(False)
        Me.TabControl_TabPage6.PerformLayout()
        Me.Marco_Facturas_Compras.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    Public Sub Consulta_Factura_Ventas_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Consulta_Factura_Ventas.Click
        EsConsultaVentas = True
        frmPromptNumero = New Form_Prompt_Numero()
        frmPromptNumero.ShowDialog()
    End Sub

    Public Sub Modificacion_Proveedores_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Modificacion_Proveedores.Click
        Modificacion_Proveedor = True
    frmPromptProveedores = New Form_Prompt_Proveedores
    frmPromptProveedores.Text = "Modificación de Proveedores"
        frmPromptProveedores.ShowDialog()
    End Sub

  Public Sub Alta_Factura_Compras_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alta_Factura_Compras.Click
    EsFacturaCompras = True
    frmPromptFecha = New Form_Prompt_Fecha()
    frmPromptFecha.ShowDialog()
  End Sub

    Public Sub Alta_Factura_Ventas_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alta_Factura_Ventas.Click
        Dim OK As MsgBoxResult
        EsFacturaVentas = True
        OK = MsgBox("Es una factura de suministros?", MsgBoxStyle.YesNo, "Facturas")
        If OK = MsgBoxResult.Yes Then
            RegFacturaVentas.Suministros = True
        Else
            RegFacturaVentas.Suministros = False
        End If
        frmPromptFecha = New Form_Prompt_Fecha()
        frmPromptFecha.ShowDialog()
    End Sub
    Public Sub Alta_Materiales_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alta_Materiales.Click
        Alta_Material = True
        frmMaterial = New Form_Materiales
        frmMaterial.Text = "Alta de Materiales"
        frmMaterial.ShowDialog()
    End Sub
    Public Sub Alta_Proveedores_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alta_Proveedores.Click
        Alta_Proveedor = True
        frmProveedor = New Form_Proveedores
        frmProveedor.Text = "Alta de Proveedores"
        frmProveedor.ShowDialog()
    End Sub
    Public Sub Alta_Albaranes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alta_Albaranes.Click
        Alta_Albaran = True
        frmAlbaran = New Form_Albaranes
        frmAlbaran.Text = "Alta de Albaranes"
        frmAlbaran.ShowDialog()
    End Sub
    Public Sub Baja_Albaranes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Baja_Albaranes.Click
    frmNumeroAlbaran = New Form_Numero_Albaran
    frmNumeroAlbaran.Text = "Baja de Albaranes"
        Baja_Albaran = True
        frmNumeroAlbaran.ShowDialog()
    End Sub
    Public Sub Baja_Materiales_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Baja_Materiales.Click
        Baja_Material = True
    frmPromptMateriales = New Form_Prompt_Materiales
    frmPromptMateriales.Text = "Baja de Materiales"
        frmPromptMateriales.ShowDialog()
    End Sub
    Public Sub Baja_Proveedores_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Baja_Proveedores.Click
        Baja_Proveedor = True
    frmPromptProveedores = New Form_Prompt_Proveedores
    frmPromptProveedores.Text = "Baja de Proveedores"
        frmPromptProveedores.ShowDialog()
    End Sub
    Private Sub cmdIngresos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Call Listado_Ingresos_Click(Listado_Ingresos, New System.EventArgs())
    End Sub
  Private Sub cmdListadoGastos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles _
    cmdListadoGastos.Click
    Call Listado_Gastos_Click(Listado_Gastos, New System.EventArgs())
  End Sub
    Public Sub Consulta_Albaranes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Consulta_Albaranes.Click
        Consulta_Albaran = True
    frmNumeroAlbaran = New Form_Numero_Albaran
    frmNumeroAlbaran.Text = "Consulta de Albaranes"
        frmNumeroAlbaran.ShowDialog()
    End Sub
    Public Sub Consulta_Materiales_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Consulta_Materiales.Click
        Consulta_Material = True
    frmPromptMateriales = New Form_Prompt_Materiales
    frmPromptMateriales.Text = "Consulta de Materiales"
        frmPromptMateriales.ShowDialog()
    End Sub
    Public Sub Consulta_Proveedores_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Consulta_Proveedores.Click
        Consulta_Proveedor = True
    frmPromptProveedores = New Form_Prompt_Proveedores
    frmPromptProveedores.Text = "Consulta de Proveedores"
        frmPromptProveedores.ShowDialog()
    End Sub
  Public Sub Listado_Gastos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Listado_Gastos.Click
    EsListadoCompras = True
    frmIntervalo = New Form_Intervalo
    frmIntervalo.Text = "Listado de Gastos"
    frmIntervalo.ShowDialog()
  End Sub
  Public Sub Listado_Ingresos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Listado_Ingresos.Click
    EsListadoVentas = True
    frmIntervalo = New Form_Intervalo
    frmIntervalo.Text = "Listado de Ingresos"
    frmIntervalo.ShowDialog()
  End Sub
    Private Sub Main_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        [Global].Inicializar()
        DBConnection = New SqlClient.SqlConnection _
        ("Data Source=GANIMEDES;Database=Facturas;User Id=sysdba;Password=CHANGE_ME")
        Try
            DBConnection.Open()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos: " & ex.Message, MsgBoxStyle.OkOnly, "Facturas Salva .NET")
        End Try
        Application.EnableVisualStyles()
    End Sub
    Private Sub Main_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim OK As Short
        OK = MessageBox.Show("¿Realmente desea salir?", "Facturas", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OK = MsgBoxResult.Yes Then
            DBConnection.Close()
            DBConnection.Dispose()
            DBConnection = Nothing
        Else
            eventArgs.Cancel = True
        End If
    End Sub
    Public Sub Modificacion_Albaranes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Modificacion_Albaranes.Click
        Modificacion_Albaran = True
    frmNumeroAlbaran = New Form_Numero_Albaran
    frmNumeroAlbaran.Text = "Modificación de Albaranes"
        frmNumeroAlbaran.ShowDialog()
    End Sub
    Public Sub Modificacion_Materiales_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Modificacion_Materiales.Click
        Modificacion_Material = True
    frmPromptMateriales = New Form_Prompt_Materiales
    frmPromptMateriales.Text = "Modificación de Materiales"
        frmPromptMateriales.ShowDialog()
    End Sub
    Public Sub Salir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
    Public Sub Alta_Clientes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Alta_Clientes.Click
        Alta_Cliente = True
        frmClientes = New Form_Clientes
        frmClientes.Text = "Alta de Clientes"
        frmClientes.ShowDialog()
    End Sub
    Public Sub Baja_Clientes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Baja_Clientes.Click
        Baja_Cliente = True
    frmPromptCliente = New Form_Prompt_Clientes
    frmPromptCliente.Text = "Baja de Clientes"
        frmPromptCliente.ShowDialog()
    End Sub
    Public Sub Consulta_Clientes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Consulta_Clientes.Click
        Consulta_Cliente = True
    frmPromptCliente = New Form_Prompt_Clientes
    frmPromptCliente.Text = "Consulta de Clientes"
        frmPromptCliente.ShowDialog()
    End Sub
    Public Sub Modificacion_Clientes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Modificacion_Clientes.Click
        Modificacion_Cliente = True
    frmPromptCliente = New Form_Prompt_Clientes
    frmPromptCliente.Text = "Modificación de Clientes"
        frmPromptCliente.ShowDialog()
    End Sub
    Private Sub ListadoFacturasCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoFacturasCompras.Click
        frmFactura = New Form_Report_Factura
        frmFactura.Text = "Informe Compras"
        frmFactura.Show()
    End Sub
    Private Sub Modificacion_Factura_Ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificacionFacturaVentas.Click
        Modificacion_Factura = True
        frmPromptNumero = New Form_Prompt_Numero
        frmPromptNumero.ShowDialog()
    End Sub
    Private Sub cmdListadoAlbaranes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListadoAlbaranes.Click
        Listado_Albaranes_Click()
    End Sub
    Private Sub Listado_Albaranes_Click()
        Form_Listado_Albaranes.Show()
    End Sub
    Private Sub Listado_Albaranes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Listado_Albaranes.Click
        Listado_Albaranes_Click()
    End Sub
    Private Sub cmdAltaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAltaProveedor.Click
        Alta_Proveedores_Click(sender, e)
    End Sub
    Private Sub cmdBajaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBajaProveedor.Click
        Call Baja_Proveedores_Click(sender, e)
    End Sub
    Private Sub cmdConsultaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaProveedor.Click
        Call Consulta_Proveedores_Click(sender, e)
    End Sub
    Private Sub cmdModificacionProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificacionProveedor.Click
        Call Modificacion_Proveedores_Click(sender, e)
    End Sub
    Private Sub cmdAltaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAltaCliente.Click
        Call Alta_Clientes_Click(sender, e)
    End Sub
    Private Sub cmdBajaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBajaCliente.Click
        Call Baja_Clientes_Click(sender, e)
    End Sub
    Private Sub cmdModificacionCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificacionCliente.Click
        Call Modificacion_Clientes_Click(sender, e)
    End Sub
    Private Sub cmdConsultaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaCliente.Click
        Call Consulta_Clientes_Click(sender, e)
    End Sub
    Private Sub cmdAltaMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAltaMaterial.Click
        Call Alta_Materiales_Click(sender, e)
    End Sub
    Private Sub cmdBajaMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBajaMaterial.Click
        Call Baja_Materiales_Click(sender, e)
    End Sub
    Private Sub cmdModificacionMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificacionMaterial.Click
        Call Modificacion_Materiales_Click(sender, e)
    End Sub
    Private Sub cmdConsultaMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaMaterial.Click
        Call Consulta_Materiales_Click(sender, e)
    End Sub
    Private Sub cmdAltaAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAltaAlbaran.Click
        Call Alta_Albaranes_Click(sender, e)
    End Sub
    Private Sub cmdBajaAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBajaAlbaran.Click
        Call Baja_Albaranes_Click(sender, e)
    End Sub
    Private Sub cmdModificacionAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificacionAlbaran.Click
        Call Modificacion_Albaranes_Click(sender, e)
    End Sub
    Private Sub cmdConsultaAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaAlbaran.Click
        Call Consulta_Albaranes_Click(sender, e)
    End Sub
    Private Sub cmdAltaFacturaVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAltaFacturaVentas.Click
        Call Alta_Factura_Ventas_Click(sender, e)
    End Sub
    Private Sub cmdConsultaFacturaVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultaFacturaVentas.Click
        Call Consulta_Factura_Ventas_Click(sender, e)
    End Sub
    Private Sub cmdAltaFacturaCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAltaFacturaCompras.Click
        Call Alta_Factura_Compras_Click(sender, e)
    End Sub
    Private Sub cmdListadoCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
   cmdListadoCompras.Click
        Call ListadoFacturasCompras_Click(sender, e)
    End Sub
    Private Sub Pintar_Botones()
        'Centrar los botones dentro del marco en altura y anchura
        Dim btn, marco, page As Control
        For Each page In Me.TabControl.TabPages
            Me.TabControl.SelectedTab = page
            For Each marco In page.Controls
                Dim count As Short = marco.Controls.Count
                Dim gap As Integer = (marco.Width - (count * marco.Controls.Item(0).Width)) \ (count + 1)
                For Each btn In marco.Controls
                    btn.Top = marco.Top + (marco.Height \ 2) - (btn.Height \ 2)
                    btn.Left = marco.Left + _
                    (gap + (marco.Controls.IndexOf(btn) * (btn.Width + gap)))
                Next
            Next
        Next
    End Sub
    Private Sub frmMain_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Dim selected As Short = Me.TabControl.SelectedIndex
        Call Me.Pintar_Botones()
        Me.TabControl.SelectedIndex = selected
    End Sub

    Private Sub cmdListadoVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
   cmdListadoVentas.Click
        Dim frmListadoVentas As New Form_Report_Ventas()
        frmListadoVentas.Show()
    End Sub

    Private Sub cmdListadoVentasHacienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
   cmdListadoVentasHacienda.Click
        Dim frmListadoVentas As New Form_Report_Ventas("Listado Hacienda Facturas de Ventas")
        frmListadoVentas.Show()
    End Sub

    Private Sub cmdListadoIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
   cmdListadoIngresos.Click
        Listado_Ingresos_Click(sender, e)
    End Sub

    Private Sub cmdBajaFacturaVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBajaFacturaVentas.Click
        EsBajaVentas = True
        Dim frmPromptNumero As New Form_Prompt_Numero()
        frmPromptNumero.ShowDialog()
    End Sub
End Class
