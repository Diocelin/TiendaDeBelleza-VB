<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVenta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVenta))
        Me.dgvdetalles = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BusquedaProductos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcabtidad = New System.Windows.Forms.NumericUpDown()
        Me.btnegregar = New System.Windows.Forms.Button()
        Me.cbproducto = New System.Windows.Forms.ComboBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnumdocu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Producto = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Producto.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvdetalles
        '
        Me.dgvdetalles.AllowUserToAddRows = False
        Me.dgvdetalles.AllowUserToDeleteRows = False
        Me.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvdetalles.EnableHeadersVisualStyles = False
        Me.dgvdetalles.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvdetalles.Location = New System.Drawing.Point(28, 336)
        Me.dgvdetalles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvdetalles.Name = "dgvdetalles"
        Me.dgvdetalles.ReadOnly = True
        Me.dgvdetalles.RowHeadersWidth = 51
        Me.dgvdetalles.Size = New System.Drawing.Size(630, 124)
        Me.dgvdetalles.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "codproducto"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "cantidad"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "descripcion"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "P. Unitario"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Importe"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 482)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total"
        '
        'BusquedaProductos
        '
        Me.BusquedaProductos.Location = New System.Drawing.Point(175, 127)
        Me.BusquedaProductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BusquedaProductos.Name = "BusquedaProductos"
        Me.BusquedaProductos.Size = New System.Drawing.Size(132, 26)
        Me.BusquedaProductos.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'txtcabtidad
        '
        Me.txtcabtidad.Enabled = False
        Me.txtcabtidad.Location = New System.Drawing.Point(175, 80)
        Me.txtcabtidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcabtidad.Name = "txtcabtidad"
        Me.txtcabtidad.Size = New System.Drawing.Size(191, 26)
        Me.txtcabtidad.TabIndex = 2
        Me.txtcabtidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnegregar
        '
        Me.btnegregar.BackgroundImage = Global.SistemaVentas.My.Resources.Resources.IMG_4222_removebg_preview
        Me.btnegregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnegregar.Enabled = False
        Me.btnegregar.Location = New System.Drawing.Point(388, 56)
        Me.btnegregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnegregar.Name = "btnegregar"
        Me.btnegregar.Size = New System.Drawing.Size(104, 73)
        Me.btnegregar.TabIndex = 1
        Me.btnegregar.UseVisualStyleBackColor = True
        '
        'cbproducto
        '
        Me.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbproducto.Enabled = False
        Me.cbproducto.FormattingEnabled = True
        Me.cbproducto.Location = New System.Drawing.Point(175, 26)
        Me.cbproducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbproducto.Name = "cbproducto"
        Me.cbproducto.Size = New System.Drawing.Size(189, 28)
        Me.cbproducto.TabIndex = 0
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnguardar.Enabled = False
        Me.btnguardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnguardar.Location = New System.Drawing.Point(484, 33)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(166, 62)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "Guardar Venta"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(509, 484)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(149, 22)
        Me.txttotal.TabIndex = 9
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 72)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(148, 72)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(227, 22)
        Me.txtfecha.TabIndex = 5
        '
        'txtnumdocu
        '
        Me.txtnumdocu.Enabled = False
        Me.txtnumdocu.Location = New System.Drawing.Point(148, 33)
        Me.txtnumdocu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnumdocu.Name = "txtnumdocu"
        Me.txtnumdocu.Size = New System.Drawing.Size(132, 22)
        Me.txtnumdocu.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Numero"
        '
        'Producto
        '
        Me.Producto.Controls.Add(Me.Label4)
        Me.Producto.Controls.Add(Me.BusquedaProductos)
        Me.Producto.Controls.Add(Me.Label3)
        Me.Producto.Controls.Add(Me.Label2)
        Me.Producto.Controls.Add(Me.txtcabtidad)
        Me.Producto.Controls.Add(Me.btnegregar)
        Me.Producto.Controls.Add(Me.cbproducto)
        Me.Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.Location = New System.Drawing.Point(16, 139)
        Me.Producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Producto.Name = "Producto"
        Me.Producto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Producto.Size = New System.Drawing.Size(515, 169)
        Me.Producto.TabIndex = 2
        Me.Producto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Codigo"
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(672, 519)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnumdocu)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdetalles)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FormVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Producto.ResumeLayout(False)
        Me.Producto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvdetalles As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcabtidad As NumericUpDown
    Friend WithEvents btnegregar As Button
    Friend WithEvents cbproducto As ComboBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BusquedaProductos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents txtnumdocu As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Producto As GroupBox
    Friend WithEvents Label4 As Label
End Class
