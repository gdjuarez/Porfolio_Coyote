<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionCompras
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
        Me.BtnActualiza = New System.Windows.Forms.Button()
        Me.DGVCompras = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxProveedor = New System.Windows.Forms.ComboBox()
        Me.CheckBoxProveedor = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnActualiza
        '
        Me.BtnActualiza.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnActualiza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualiza.Location = New System.Drawing.Point(0, 472)
        Me.BtnActualiza.Name = "BtnActualiza"
        Me.BtnActualiza.Size = New System.Drawing.Size(844, 39)
        Me.BtnActualiza.TabIndex = 1
        Me.BtnActualiza.Text = "Pagar factura"
        Me.BtnActualiza.UseVisualStyleBackColor = True
        '
        'DGVCompras
        '
        Me.DGVCompras.AllowUserToAddRows = False
        Me.DGVCompras.AllowUserToDeleteRows = False
        Me.DGVCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVCompras.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DGVCompras.Location = New System.Drawing.Point(12, 75)
        Me.DGVCompras.Name = "DGVCompras"
        Me.DGVCompras.RowHeadersVisible = False
        Me.DGVCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCompras.Size = New System.Drawing.Size(820, 393)
        Me.DGVCompras.StandardTab = True
        Me.DGVCompras.TabIndex = 51
        '
        'Column1
        '
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.Name = "Column1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 24)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Gestion de pago de compras"
        '
        'ComboBoxProveedor
        '
        Me.ComboBoxProveedor.Enabled = False
        Me.ComboBoxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProveedor.FormattingEnabled = True
        Me.ComboBoxProveedor.Location = New System.Drawing.Point(176, 39)
        Me.ComboBoxProveedor.Name = "ComboBoxProveedor"
        Me.ComboBoxProveedor.Size = New System.Drawing.Size(190, 24)
        Me.ComboBoxProveedor.TabIndex = 55
        '
        'CheckBoxProveedor
        '
        Me.CheckBoxProveedor.AutoSize = True
        Me.CheckBoxProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxProveedor.Location = New System.Drawing.Point(12, 41)
        Me.CheckBoxProveedor.Name = "CheckBoxProveedor"
        Me.CheckBoxProveedor.Size = New System.Drawing.Size(163, 20)
        Me.CheckBoxProveedor.TabIndex = 57
        Me.CheckBoxProveedor.Text = "Selección x Proveedor"
        Me.CheckBoxProveedor.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(707, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 22)
        Me.DateTimePicker1.TabIndex = 58
        '
        'FrmGestionCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 511)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBoxProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVCompras)
        Me.Controls.Add(Me.BtnActualiza)
        Me.Controls.Add(Me.CheckBoxProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Compras"
        CType(Me.DGVCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnActualiza As System.Windows.Forms.Button
    Friend WithEvents DGVCompras As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents ComboBoxProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxProveedor As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
