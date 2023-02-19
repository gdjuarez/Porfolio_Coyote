<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmActualizaPrecio
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
        Me.TBAumento = New System.Windows.Forms.TextBox()
        Me.DGVArticulos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBoxTodos = New System.Windows.Forms.CheckBox()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.CheckBoxMarca = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGVArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnActualiza
        '
        Me.BtnActualiza.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnActualiza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualiza.Location = New System.Drawing.Point(0, 474)
        Me.BtnActualiza.Name = "BtnActualiza"
        Me.BtnActualiza.Size = New System.Drawing.Size(711, 39)
        Me.BtnActualiza.TabIndex = 1
        Me.BtnActualiza.Text = "Actualiza precios"
        Me.BtnActualiza.UseVisualStyleBackColor = True
        '
        'TBAumento
        '
        Me.TBAumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAumento.Location = New System.Drawing.Point(601, 44)
        Me.TBAumento.Name = "TBAumento"
        Me.TBAumento.Size = New System.Drawing.Size(74, 22)
        Me.TBAumento.TabIndex = 2
        Me.TBAumento.Text = "0"
        Me.TBAumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGVArticulos
        '
        Me.DGVArticulos.AllowUserToAddRows = False
        Me.DGVArticulos.AllowUserToDeleteRows = False
        Me.DGVArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVArticulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DGVArticulos.Location = New System.Drawing.Point(12, 75)
        Me.DGVArticulos.Name = "DGVArticulos"
        Me.DGVArticulos.RowHeadersVisible = False
        Me.DGVArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVArticulos.Size = New System.Drawing.Size(687, 393)
        Me.DGVArticulos.StandardTab = True
        Me.DGVArticulos.TabIndex = 51
        '
        'Column1
        '
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.Name = "Column1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(516, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Porcentaje :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(203, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 24)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Actualizacion de precios grupal"
        '
        'CheckBoxTodos
        '
        Me.CheckBoxTodos.AutoSize = True
        Me.CheckBoxTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxTodos.Location = New System.Drawing.Point(15, 46)
        Me.CheckBoxTodos.Name = "CheckBoxTodos"
        Me.CheckBoxTodos.Size = New System.Drawing.Size(67, 20)
        Me.CheckBoxTodos.TabIndex = 54
        Me.CheckBoxTodos.Text = "Todos"
        Me.CheckBoxTodos.UseVisualStyleBackColor = True
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.Enabled = False
        Me.ComboBoxMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(239, 44)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(190, 24)
        Me.ComboBoxMarca.TabIndex = 55
        '
        'CheckBoxMarca
        '
        Me.CheckBoxMarca.AutoSize = True
        Me.CheckBoxMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxMarca.Location = New System.Drawing.Point(106, 46)
        Me.CheckBoxMarca.Name = "CheckBoxMarca"
        Me.CheckBoxMarca.Size = New System.Drawing.Size(137, 20)
        Me.CheckBoxMarca.TabIndex = 57
        Me.CheckBoxMarca.Text = "Selección x Marca"
        Me.CheckBoxMarca.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(681, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmActualizaPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 513)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxMarca)
        Me.Controls.Add(Me.CheckBoxTodos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGVArticulos)
        Me.Controls.Add(Me.TBAumento)
        Me.Controls.Add(Me.BtnActualiza)
        Me.Controls.Add(Me.CheckBoxMarca)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmActualizaPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualización de precios"
        CType(Me.DGVArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnActualiza As System.Windows.Forms.Button
    Friend WithEvents TBAumento As System.Windows.Forms.TextBox
    Friend WithEvents DGVArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents CheckBoxTodos As CheckBox
    Friend WithEvents ComboBoxMarca As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxMarca As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
