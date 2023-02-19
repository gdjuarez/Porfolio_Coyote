<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClienteRetira
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListBoxCliente = New System.Windows.Forms.ListBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVRetira = New System.Windows.Forms.DataGridView()
        Me.TxtDNIRetira = New System.Windows.Forms.TextBox()
        Me.TxtApellidoRetira = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregaRetira = New System.Windows.Forms.Button()
        Me.BtnGrabaRetira = New System.Windows.Forms.Button()
        Me.BtnBorraRetira = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVRetira, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxCliente
        '
        Me.ListBoxCliente.FormattingEnabled = True
        Me.ListBoxCliente.Location = New System.Drawing.Point(14, 55)
        Me.ListBoxCliente.Name = "ListBoxCliente"
        Me.ListBoxCliente.Size = New System.Drawing.Size(327, 381)
        Me.ListBoxCliente.TabIndex = 3
        '
        'TxtCliente
        '
        Me.TxtCliente.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCliente.Location = New System.Drawing.Point(85, 31)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(256, 20)
        Me.TxtCliente.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.LblIdCliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCliente)
        Me.Panel1.Controls.Add(Me.ListBoxCliente)
        Me.Panel1.Location = New System.Drawing.Point(12, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 445)
        Me.Panel1.TabIndex = 5
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.Location = New System.Drawing.Point(18, 35)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(0, 13)
        Me.LblIdCliente.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cliente"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.DGVRetira)
        Me.Panel2.Controls.Add(Me.TxtDNIRetira)
        Me.Panel2.Controls.Add(Me.TxtApellidoRetira)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnAgregaRetira)
        Me.Panel2.Controls.Add(Me.BtnGrabaRetira)
        Me.Panel2.Controls.Add(Me.BtnBorraRetira)
        Me.Panel2.Location = New System.Drawing.Point(387, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 445)
        Me.Panel2.TabIndex = 6
        '
        'DGVRetira
        '
        Me.DGVRetira.AllowUserToAddRows = False
        Me.DGVRetira.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGVRetira.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVRetira.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRetira.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVRetira.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVRetira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVRetira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVRetira.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVRetira.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGVRetira.Location = New System.Drawing.Point(71, 81)
        Me.DGVRetira.MultiSelect = False
        Me.DGVRetira.Name = "DGVRetira"
        Me.DGVRetira.ReadOnly = True
        Me.DGVRetira.RowHeadersVisible = False
        Me.DGVRetira.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRetira.Size = New System.Drawing.Size(266, 357)
        Me.DGVRetira.TabIndex = 27
        '
        'TxtDNIRetira
        '
        Me.TxtDNIRetira.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDNIRetira.Location = New System.Drawing.Point(125, 54)
        Me.TxtDNIRetira.Name = "TxtDNIRetira"
        Me.TxtDNIRetira.ReadOnly = True
        Me.TxtDNIRetira.Size = New System.Drawing.Size(212, 20)
        Me.TxtDNIRetira.TabIndex = 9
        '
        'TxtApellidoRetira
        '
        Me.TxtApellidoRetira.BackColor = System.Drawing.Color.LightGreen
        Me.TxtApellidoRetira.Location = New System.Drawing.Point(125, 29)
        Me.TxtApellidoRetira.Name = "TxtApellidoRetira"
        Me.TxtApellidoRetira.ReadOnly = True
        Me.TxtApellidoRetira.Size = New System.Drawing.Size(212, 20)
        Me.TxtApellidoRetira.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido y Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Retira"
        '
        'BtnAgregaRetira
        '
        Me.BtnAgregaRetira.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_add2_36
        Me.BtnAgregaRetira.Location = New System.Drawing.Point(10, 81)
        Me.BtnAgregaRetira.Name = "BtnAgregaRetira"
        Me.BtnAgregaRetira.Size = New System.Drawing.Size(55, 55)
        Me.BtnAgregaRetira.TabIndex = 0
        Me.BtnAgregaRetira.Text = "Agregar"
        Me.BtnAgregaRetira.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregaRetira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAgregaRetira.UseVisualStyleBackColor = True
        '
        'BtnGrabaRetira
        '
        Me.BtnGrabaRetira.Enabled = False
        Me.BtnGrabaRetira.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_disk_36
        Me.BtnGrabaRetira.Location = New System.Drawing.Point(10, 146)
        Me.BtnGrabaRetira.Name = "BtnGrabaRetira"
        Me.BtnGrabaRetira.Size = New System.Drawing.Size(55, 55)
        Me.BtnGrabaRetira.TabIndex = 1
        Me.BtnGrabaRetira.Text = "Grabar"
        Me.BtnGrabaRetira.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabaRetira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnGrabaRetira.UseVisualStyleBackColor = True
        '
        'BtnBorraRetira
        '
        Me.BtnBorraRetira.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_delete_36
        Me.BtnBorraRetira.Location = New System.Drawing.Point(10, 214)
        Me.BtnBorraRetira.Name = "BtnBorraRetira"
        Me.BtnBorraRetira.Size = New System.Drawing.Size(55, 55)
        Me.BtnBorraRetira.TabIndex = 2
        Me.BtnBorraRetira.Text = "Borrar"
        Me.BtnBorraRetira.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBorraRetira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBorraRetira.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(141, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(467, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Altas, bajas y modificación de personas que retiran articulos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 484)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(749, 27)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmClienteRetira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 511)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmClienteRetira"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Cliente Retira"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVRetira, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxCliente As System.Windows.Forms.ListBox
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregaRetira As System.Windows.Forms.Button
    Friend WithEvents BtnGrabaRetira As System.Windows.Forms.Button
    Friend WithEvents BtnBorraRetira As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents LblIdCliente As System.Windows.Forms.Label
    Friend WithEvents TxtDNIRetira As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidoRetira As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGVRetira As System.Windows.Forms.DataGridView
End Class
