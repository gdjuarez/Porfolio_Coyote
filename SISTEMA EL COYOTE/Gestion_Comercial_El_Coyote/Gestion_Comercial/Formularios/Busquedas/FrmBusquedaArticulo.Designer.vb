﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaArticulo))
        Me.TxtProductos = New System.Windows.Forms.TextBox()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCopiarVenta = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCopiarPresupuesto = New System.Windows.Forms.Button()
        Me.btnCopiarVentacc = New System.Windows.Forms.Button()
        Me.BtnCopiarPrecio = New System.Windows.Forms.Button()
        Me.BtnCopiarVentaTouch = New System.Windows.Forms.Button()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtProductos
        '
        Me.TxtProductos.Location = New System.Drawing.Point(282, 60)
        Me.TxtProductos.Name = "TxtProductos"
        Me.TxtProductos.Size = New System.Drawing.Size(246, 20)
        Me.TxtProductos.TabIndex = 50
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AllowUserToAddRows = False
        Me.DataGridViewProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(10, 93)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.ReadOnly = True
        Me.DataGridViewProductos.RowHeadersVisible = False
        Me.DataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProductos.Size = New System.Drawing.Size(804, 485)
        Me.DataGridViewProductos.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 38)
        Me.Panel1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busqueda de Articulo"
        '
        'btnCopiarVenta
        '
        Me.btnCopiarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopiarVenta.Image = CType(resources.GetObject("btnCopiarVenta.Image"), System.Drawing.Image)
        Me.btnCopiarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarVenta.Location = New System.Drawing.Point(614, 51)
        Me.btnCopiarVenta.Name = "btnCopiarVenta"
        Me.btnCopiarVenta.Size = New System.Drawing.Size(100, 36)
        Me.btnCopiarVenta.TabIndex = 52
        Me.btnCopiarVenta.Text = "Copiar"
        Me.btnCopiarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarVenta.UseVisualStyleBackColor = True
        Me.btnCopiarVenta.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.Gestion_Comercial.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(766, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 51
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCopiarPresupuesto
        '
        Me.btnCopiarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopiarPresupuesto.Image = CType(resources.GetObject("btnCopiarPresupuesto.Image"), System.Drawing.Image)
        Me.btnCopiarPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarPresupuesto.Location = New System.Drawing.Point(162, 51)
        Me.btnCopiarPresupuesto.Name = "btnCopiarPresupuesto"
        Me.btnCopiarPresupuesto.Size = New System.Drawing.Size(100, 36)
        Me.btnCopiarPresupuesto.TabIndex = 53
        Me.btnCopiarPresupuesto.Text = "Copiar"
        Me.btnCopiarPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarPresupuesto.UseVisualStyleBackColor = True
        Me.btnCopiarPresupuesto.Visible = False
        '
        'btnCopiarVentacc
        '
        Me.btnCopiarVentacc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopiarVentacc.Image = CType(resources.GetObject("btnCopiarVentacc.Image"), System.Drawing.Image)
        Me.btnCopiarVentacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarVentacc.Location = New System.Drawing.Point(670, 51)
        Me.btnCopiarVentacc.Name = "btnCopiarVentacc"
        Me.btnCopiarVentacc.Size = New System.Drawing.Size(100, 36)
        Me.btnCopiarVentacc.TabIndex = 54
        Me.btnCopiarVentacc.Text = "Copiar"
        Me.btnCopiarVentacc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarVentacc.UseVisualStyleBackColor = True
        Me.btnCopiarVentacc.Visible = False
        '
        'BtnCopiarPrecio
        '
        Me.BtnCopiarPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiarPrecio.Image = CType(resources.GetObject("BtnCopiarPrecio.Image"), System.Drawing.Image)
        Me.BtnCopiarPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiarPrecio.Location = New System.Drawing.Point(67, 51)
        Me.BtnCopiarPrecio.Name = "BtnCopiarPrecio"
        Me.BtnCopiarPrecio.Size = New System.Drawing.Size(100, 36)
        Me.BtnCopiarPrecio.TabIndex = 55
        Me.BtnCopiarPrecio.Text = "Copiar"
        Me.BtnCopiarPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiarPrecio.UseVisualStyleBackColor = True
        Me.BtnCopiarPrecio.Visible = False
        '
        'BtnCopiarVentaTouch
        '
        Me.BtnCopiarVentaTouch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopiarVentaTouch.Image = CType(resources.GetObject("BtnCopiarVentaTouch.Image"), System.Drawing.Image)
        Me.BtnCopiarVentaTouch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiarVentaTouch.Location = New System.Drawing.Point(534, 51)
        Me.BtnCopiarVentaTouch.Name = "BtnCopiarVentaTouch"
        Me.BtnCopiarVentaTouch.Size = New System.Drawing.Size(100, 36)
        Me.BtnCopiarVentaTouch.TabIndex = 53
        Me.BtnCopiarVentaTouch.Text = "Copiar"
        Me.BtnCopiarVentaTouch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiarVentaTouch.UseVisualStyleBackColor = True
        Me.BtnCopiarVentaTouch.Visible = False
        '
        'FrmBusquedaArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 590)
        Me.Controls.Add(Me.BtnCopiarVentaTouch)
        Me.Controls.Add(Me.BtnCopiarPrecio)
        Me.Controls.Add(Me.btnCopiarVentacc)
        Me.Controls.Add(Me.btnCopiarPresupuesto)
        Me.Controls.Add(Me.btnCopiarVenta)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtProductos)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de articulo"
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCopiarVenta As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtProductos As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCopiarPresupuesto As System.Windows.Forms.Button
    Friend WithEvents btnCopiarVentacc As Button
    Friend WithEvents BtnCopiarPrecio As System.Windows.Forms.Button
    Friend WithEvents BtnCopiarVentaTouch As Button
End Class
