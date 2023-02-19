<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtVentas = New System.Windows.Forms.TextBox()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.TxtRazonsocial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnAnularVenta = New System.Windows.Forms.Button()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtVentas
        '
        Me.TxtVentas.Location = New System.Drawing.Point(186, 68)
        Me.TxtVentas.Name = "TxtVentas"
        Me.TxtVentas.Size = New System.Drawing.Size(98, 20)
        Me.TxtVentas.TabIndex = 50
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.AllowUserToAddRows = False
        Me.DataGridViewVentas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Location = New System.Drawing.Point(10, 99)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.ReadOnly = True
        Me.DataGridViewVentas.RowHeadersVisible = False
        Me.DataGridViewVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVentas.Size = New System.Drawing.Size(946, 410)
        Me.DataGridViewVentas.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 48)
        Me.Panel1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busqueda de Venta"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(907, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 51
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_print_36
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(10, 59)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(120, 36)
        Me.BtnImprimir.TabIndex = 53
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'TxtRazonsocial
        '
        Me.TxtRazonsocial.Location = New System.Drawing.Point(383, 68)
        Me.TxtRazonsocial.Name = "TxtRazonsocial"
        Me.TxtRazonsocial.Size = New System.Drawing.Size(246, 20)
        Me.TxtRazonsocial.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Razon Social"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(659, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Apellido"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(709, 68)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(246, 20)
        Me.TxtApellido.TabIndex = 57
        '
        'BtnAnularVenta
        '
        Me.BtnAnularVenta.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAnularVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnularVenta.Location = New System.Drawing.Point(355, 515)
        Me.BtnAnularVenta.Name = "BtnAnularVenta"
        Me.BtnAnularVenta.Size = New System.Drawing.Size(256, 31)
        Me.BtnAnularVenta.TabIndex = 59
        Me.BtnAnularVenta.Text = "Seleccionar Venta para ANULAR"
        Me.BtnAnularVenta.UseVisualStyleBackColor = False
        '
        'FrmBusquedaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 554)
        Me.Controls.Add(Me.BtnAnularVenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtRazonsocial)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtVentas)
        Me.Controls.Add(Me.DataGridViewVentas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de venta"
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtVentas As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewVentas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents TxtRazonsocial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents BtnAnularVenta As Button
End Class
