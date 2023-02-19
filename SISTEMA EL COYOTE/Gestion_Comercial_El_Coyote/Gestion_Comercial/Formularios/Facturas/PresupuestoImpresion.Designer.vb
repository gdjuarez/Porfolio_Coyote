<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PresupuestoImpresion
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportPresupuesto = New Microsoft.Reporting.WinForms.ReportViewer()
        'Me.libreria_bigognoDataSetPresupuestoMisDatos = New Gestion_Comercial.libreria_bigognoDataSetPresupuestoMisDatos()
        'Me.misdatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.misdatosTableAdapter = New Gestion_Comercial.libreria_bigognoDataSetPresupuestoMisDatosTableAdapters.misdatosTableAdapter()
        'Me.libreria_bigognoDataSetPresupuestoDetalles = New Gestion_Comercial.libreria_bigognoDataSetPresupuestoDetalles()
        'Me.mipresuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.mipresuTableAdapter = New Gestion_Comercial.libreria_bigognoDataSetPresupuestoDetallesTableAdapters.mipresuTableAdapter()
        'CType(Me.libreria_bigognoDataSetPresupuestoMisDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.libreria_bigognoDataSetPresupuestoDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mipresuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportPresupuesto
        '
        Me.ReportPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetPresupuesto"
        ReportDataSource1.Value = Me.misdatosBindingSource
        ReportDataSource2.Name = "DataSetPresupuestoDetalles"
        ReportDataSource2.Value = Me.mipresuBindingSource
        Me.ReportPresupuesto.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportPresupuesto.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportPresupuesto.LocalReport.ReportEmbeddedResource = "Gestion_Comercial.ReportPresu.rdlc"
        Me.ReportPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.ReportPresupuesto.Name = "ReportPresupuesto"
        Me.ReportPresupuesto.Size = New System.Drawing.Size(694, 621)
        Me.ReportPresupuesto.TabIndex = 0
        '
        'libreria_bigognoDataSetPresupuestoMisDatos
        '
        'Me.libreria_bigognoDataSetPresupuestoMisDatos.DataSetName = "libreria_bigognoDataSetPresupuestoMisDatos"
        'Me.libreria_bigognoDataSetPresupuestoMisDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'misdatosBindingSource
        '
        Me.misdatosBindingSource.DataMember = "misdatos"
        'Me.misdatosBindingSource.DataSource = Me.libreria_bigognoDataSetPresupuestoMisDatos
        '
        'misdatosTableAdapter
        '
        'Me.misdatosTableAdapter.ClearBeforeFill = True
        '
        'libreria_bigognoDataSetPresupuestoDetalles
        '
        'Me.libreria_bigognoDataSetPresupuestoDetalles.DataSetName = "libreria_bigognoDataSetPresupuestoDetalles"
        'Me.libreria_bigognoDataSetPresupuestoDetalles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mipresuBindingSource
        '
        Me.mipresuBindingSource.DataMember = "mipresu"
        'Me.mipresuBindingSource.DataSource = Me.libreria_bigognoDataSetPresupuestoDetalles
        '
        'mipresuTableAdapter
        '
        'Me.mipresuTableAdapter.ClearBeforeFill = True
        '
        'PresupuestoImpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 621)
        Me.Controls.Add(Me.ReportPresupuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PresupuestoImpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PresupuestoImpresion"
        'CType(Me.libreria_bigognoDataSetPresupuestoMisDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.misdatosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.libreria_bigognoDataSetPresupuestoDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mipresuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportPresupuesto As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents misdatosBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents libreria_bigognoDataSetPresupuestoMisDatos As Gestion_Comercial.libreria_bigognoDataSetPresupuestoMisDatos
    Friend WithEvents mipresuBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents libreria_bigognoDataSetPresupuestoDetalles As Gestion_Comercial.libreria_bigognoDataSetPresupuestoDetalles
    'Friend WithEvents misdatosTableAdapter As Gestion_Comercial.libreria_bigognoDataSetPresupuestoMisDatosTableAdapters.misdatosTableAdapter
    'Friend WithEvents mipresuTableAdapter As Gestion_Comercial.libreria_bigognoDataSetPresupuestoDetallesTableAdapters.mipresuTableAdapter
End Class
