<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formmenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formmenu))
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblcantv = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblcantpro = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.ClenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(626, 185)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(55, 16)
        Me.lbltotal.TabIndex = 9
        Me.lbltotal.Text = "Label10"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(663, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 29)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "INGRESOS"
        '
        'lblcantv
        '
        Me.lblcantv.AutoSize = True
        Me.lblcantv.Location = New System.Drawing.Point(228, 106)
        Me.lblcantv.Name = "lblcantv"
        Me.lblcantv.Size = New System.Drawing.Size(53, 16)
        Me.lblcantv.TabIndex = 7
        Me.lblcantv.Text = "lblcantv"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(206, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 29)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "VENTAS"
        '
        'lblcantpro
        '
        Me.lblcantpro.AutoSize = True
        Me.lblcantpro.Location = New System.Drawing.Point(233, 293)
        Me.lblcantpro.Name = "lblcantpro"
        Me.lblcantpro.Size = New System.Drawing.Size(48, 16)
        Me.lblcantpro.TabIndex = 7
        Me.lblcantpro.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(226, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 29)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "PRODUCTOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(827, 450)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Actualizar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClenteToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.EmpleadoToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.VentaToolStripMenuItem, Me.AlmacenToolStripMenuItem, Me.TiendasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(837, 48)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Panel15)
        Me.Panel9.Controls.Add(Me.lbltotal)
        Me.Panel9.Controls.Add(Me.lblcantpro)
        Me.Panel9.Controls.Add(Me.Panel6)
        Me.Panel9.Controls.Add(Me.Label8)
        Me.Panel9.Controls.Add(Me.Panel12)
        Me.Panel9.Controls.Add(Me.lblcantv)
        Me.Panel9.Controls.Add(Me.Label11)
        Me.Panel9.Location = New System.Drawing.Point(39, 70)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(767, 411)
        Me.Panel9.TabIndex = 18
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Transparent
        Me.Panel15.BackgroundImage = Global.SistemaVentas.My.Resources.Resources.IMG_4220_removebg_preview
        Me.Panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel15.Location = New System.Drawing.Point(416, 130)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(184, 142)
        Me.Panel15.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImage = Global.SistemaVentas.My.Resources.Resources.IMG_4216_removebg_preview_3
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Location = New System.Drawing.Point(31, 247)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(184, 142)
        Me.Panel6.TabIndex = 1
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.BackgroundImage = Global.SistemaVentas.My.Resources.Resources.IMG_4221_removebg_preview1
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel12.Location = New System.Drawing.Point(31, 19)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(159, 140)
        Me.Panel12.TabIndex = 1
        '
        'Panel19
        '
        Me.Panel19.BackgroundImage = CType(resources.GetObject("Panel19.BackgroundImage"), System.Drawing.Image)
        Me.Panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel19.Location = New System.Drawing.Point(840, 468)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(55, 49)
        Me.Panel19.TabIndex = 16
        '
        'Panel17
        '
        Me.Panel17.BackgroundImage = CType(resources.GetObject("Panel17.BackgroundImage"), System.Drawing.Image)
        Me.Panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel17.Location = New System.Drawing.Point(876, 12)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(33, 33)
        Me.Panel17.TabIndex = 9
        '
        'Panel16
        '
        Me.Panel16.BackgroundImage = CType(resources.GetObject("Panel16.BackgroundImage"), System.Drawing.Image)
        Me.Panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel16.Location = New System.Drawing.Point(829, 12)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(33, 33)
        Me.Panel16.TabIndex = 8
        '
        'ClenteToolStripMenuItem
        '
        Me.ClenteToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4217_removebg_preview
        Me.ClenteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClenteToolStripMenuItem.Name = "ClenteToolStripMenuItem"
        Me.ClenteToolStripMenuItem.Size = New System.Drawing.Size(109, 44)
        Me.ClenteToolStripMenuItem.Text = "Cliente"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4216_removebg_preview
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(123, 44)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4223_removebg_preview
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(131, 44)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4215_removebg_preview
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(131, 44)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirVentaToolStripMenuItem, Me.ListaDeVentasToolStripMenuItem})
        Me.VentaToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4218_removebg_preview
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(100, 44)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'AñadirVentaToolStripMenuItem
        '
        Me.AñadirVentaToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4222_removebg_preview
        Me.AñadirVentaToolStripMenuItem.Name = "AñadirVentaToolStripMenuItem"
        Me.AñadirVentaToolStripMenuItem.Size = New System.Drawing.Size(244, 46)
        Me.AñadirVentaToolStripMenuItem.Text = "Añadir Venta"
        '
        'ListaDeVentasToolStripMenuItem
        '
        Me.ListaDeVentasToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4227_removebg_preview
        Me.ListaDeVentasToolStripMenuItem.Name = "ListaDeVentasToolStripMenuItem"
        Me.ListaDeVentasToolStripMenuItem.Size = New System.Drawing.Size(244, 46)
        Me.ListaDeVentasToolStripMenuItem.Text = "Lista De Ventas"
        '
        'AlmacenToolStripMenuItem
        '
        Me.AlmacenToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4225_removebg_preview2
        Me.AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        Me.AlmacenToolStripMenuItem.Size = New System.Drawing.Size(121, 44)
        Me.AlmacenToolStripMenuItem.Text = "Almacen"
        '
        'TiendasToolStripMenuItem
        '
        Me.TiendasToolStripMenuItem.Image = Global.SistemaVentas.My.Resources.Resources.IMG_4226_removebg_preview
        Me.TiendasToolStripMenuItem.Name = "TiendasToolStripMenuItem"
        Me.TiendasToolStripMenuItem.Size = New System.Drawing.Size(114, 44)
        Me.TiendasToolStripMenuItem.Text = "Tiendas"
        '
        'Formmenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(915, 529)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Formmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formmenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblcantpro As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents lblcantv As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel9 As Panel
End Class
