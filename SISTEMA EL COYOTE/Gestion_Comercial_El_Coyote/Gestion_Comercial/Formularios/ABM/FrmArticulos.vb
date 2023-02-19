Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmArticulos

    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim miArticulo As New ClassArticulo
    Dim dtMarca As New DataTable
    Dim miConexion As New MySqlConnection(Global_Conexion_Local)

    Private Sub FrmArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Llenargrid()
        Inicio()
        TxtIdArticulo.Select()
        llenarComboxMarca("marcaarticulo", "Marca", "Marca")
    End Sub

    Private Sub HabilitarTXT()

        TxtIdArticulo.BackColor = Color.White
        TxtDescripcion.BackColor = Color.White
        TxtPrecioCompra.BackColor = Color.White
        TxtPrecioVenta.BackColor = Color.White
        TxtStock.BackColor = Color.White
        TxtStockMinimo.BackColor = Color.White
        ComboBoxMarca.BackColor = Color.White
        TxtRubro.BackColor = Color.White
        TxtSituado.BackColor = Color.White

        TxtIdArticulo.ReadOnly = False
        TxtDescripcion.ReadOnly = False
        TxtPrecioCompra.ReadOnly = False
        TxtPrecioVenta.ReadOnly = False
        TxtStock.ReadOnly = False
        TxtStockMinimo.ReadOnly = False
        TxtRubro.ReadOnly = False
        TxtSituado.ReadOnly = False

    End Sub

    Private Sub InhabilitatTXT()

        TxtIdArticulo.BackColor = Color.LightGreen
        TxtDescripcion.BackColor = Color.LightGreen
        TxtPrecioCompra.BackColor = Color.LightGreen
        TxtPrecioVenta.BackColor = Color.LightGreen
        TxtStock.BackColor = Color.LightGreen
        TxtStockMinimo.BackColor = Color.LightGreen
        ComboBoxMarca.BackColor = Color.LightGreen
        TxtRubro.BackColor = Color.LightGreen
        TxtSituado.BackColor = Color.LightGreen

        TxtIdArticulo.ReadOnly = True
        TxtDescripcion.ReadOnly = True
        TxtPrecioCompra.ReadOnly = True
        TxtPrecioVenta.ReadOnly = True
        TxtStock.ReadOnly = True
        TxtStockMinimo.ReadOnly = True
        TxtRubro.ReadOnly = True
        TxtSituado.ReadOnly = True

    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("vistaConsultarArticuloStock")
        'con el dt devuelto lleno el datagriedview
        DGVArticulos.DataSource = dtMitabla
        CType(DGVArticulos.Columns("Imagen"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom

    End Sub

    Private Sub Inicio()
        tsbtnNew.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = False
        tsbtnCancelar.Enabled = True
        TxtDescripcion.Select()
    End Sub

    Private Sub Limpiar()
        TxtIdArticulo.Text = ""
        TxtDescripcion.Clear()
        TxtPrecioCompra.Text = "0,00"
        TxtPrecioVenta.Text = "0,00"

        TxtRubro.Clear()
        TxtSituado.Clear()
        TxtStock.Text = "0"
        TxtStockMinimo.Text = "0"
        InhabilitatTXT()

    End Sub

    Private Sub TsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        tsbtnGuardar.Enabled = True
        TxtIdArticulo.Enabled = True
        tsbtnCancelar.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        HabilitarTXT()
    End Sub

    Private Sub TsbtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditar.Click
        tsbtnNew.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = True
        HabilitarTXT()
    End Sub

    Private Sub TsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click

        If TxtIdArticulo.Text = "" Or TxtDescripcion.Text = "" Then
            MsgBox("Ingrese los datos " & vbNewLine & " del Articulo")
            TxtDescripcion.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim miGestionMySQLStock As New GestionMySQL
            Dim sql As String

            miArticulo.IdArticulo = Me.TxtIdArticulo.Text.Trim
            miArticulo.Descripcion = Me.TxtDescripcion.Text.Trim
            miArticulo.PrecioCompra = Me.TxtPrecioCompra.Text.Trim
            miArticulo.PrecioVenta = Me.TxtPrecioVenta.Text.Trim
            miArticulo.Marca = Me.ComboBoxMarca.Text.Trim

            miArticulo.Rubro = Me.TxtRubro.Text.Trim
            miArticulo.Stock = Convert.ToInt32(TxtStock.Text)
            miArticulo.StockMinimo = Convert.ToInt32(TxtStockMinimo.Text)
            miArticulo.Situado = Me.TxtSituado.Text.Trim

            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then

                Try
                    sql = "INSERT INTO articulo (idArticulo,descripcion, precioCompra, precioventa, marca, rubro,situado)"
                    sql += "VALUES ('" & miArticulo.IdArticulo & "','" & miArticulo.Descripcion & "'," & Replace(miArticulo.PrecioCompra, ",", ".") & "," & Replace(miArticulo.PrecioVenta, ",", ".") & ",'" & miArticulo.Marca & "','" & miArticulo.Rubro & "','" & miArticulo.Situado & "')"

                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()

                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                End Try

                '//--- grabo Alta de stock en Cero para poder subir o bajar el stock con un UPDATE--------------------

                Try
                    sql = ""
                    sql = "INSERT INTO stockarticulos (idArticulo,Stock,StockMinimo)"
                    sql += "VALUES ('" & miArticulo.IdArticulo & "','" & miArticulo.Stock & "','" & miArticulo.StockMinimo & "')"

                    miGestionMySQLStock.EjecutarSQL(sql)
                    miGestionMySQLStock.Dispose()

                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                End Try

                '***************** GRABO LA IMAGEN actualizando el campo null **********************
                Try
                    Dim ms2 As New MemoryStream
                    PictureBox1.Image.Save(ms2, PictureBox1.Image.RawFormat)

                    Dim command As New MySqlCommand("Update articulo SET Imagen = @img Where idArticulo = '" & miArticulo.IdArticulo & "'", miConexion)

                    command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms2.ToArray()

                    miConexion.Open()

                    If command.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Image Actualizada")
                    Else
                        MessageBox.Show("Image No actualizada")
                    End If

                    miConexion.Close()

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                    miConexion.Close()
                End Try
                '*******************************************************************************************
            End If

            If tsbtnNew.Enabled = False And tsbtnEditar.Enabled = True Then
                'Actualizen tabla articulos
                Try
                    sql = "Update Articulo SET "
                    sql += "descripcion ='" & miArticulo.Descripcion & "', "
                    sql += "precioCompra =" & Replace(miArticulo.PrecioCompra, ",", ".") & ", "
                    sql += "precioventa = " & Replace(miArticulo.PrecioVenta, ",", ".") & ", "
                    sql += "marca = '" & miArticulo.Marca & "', "
                    sql += "rubro = '" & miArticulo.Rubro & "', "
                    sql += "situado = '" & miArticulo.Situado & "' "
                    sql += "WHERE idArticulo = '" & miArticulo.IdArticulo & "'; "

                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()

                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                End Try

                'Actualizo tabla stock
                Try
                    sql = "Update stockarticulos SET "
                    sql += "Stock = '" & miArticulo.Stock & "', "
                    sql += "StockMinimo = '" & miArticulo.StockMinimo & "' "
                    sql += "WHERE idArticulo = '" & miArticulo.IdArticulo & "'; "

                    miGestionMySQLStock.EjecutarSQL(sql)

                    miGestionMySQLStock.Dispose()

                    'MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos Stock")

                End Try

                '***************** uPDATE IMAGEN SOLAMENTE **********************
                Try
                    Dim ms2 As New MemoryStream
                    PictureBox1.Image.Save(ms2, PictureBox1.Image.RawFormat)

                    Dim command As New MySqlCommand("Update articulo SET Imagen = @img Where idArticulo = '" & miArticulo.IdArticulo & "'", miConexion)

                    command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms2.ToArray()

                    miConexion.Open()

                    If command.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Image Actualizada")
                    Else
                        MessageBox.Show("Image No actualizada")
                    End If

                    miConexion.Close()

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                    miConexion.Close()
                End Try
                '*******************************************************************************************

            End If
        End If

        Limpiar()
        Llenargrid()
        Inicio()

    End Sub

    Private Sub TsbtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelar.Click
        Limpiar()
        Inicio()
    End Sub

    Private Sub TsbtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscar.Click
        MsgBox("Para buscar un Articulo escriba la descripcion en el recuadro", MsgBoxStyle.Information)
        TxtIdArticulo.BackColor = Color.White
        TxtIdArticulo.ReadOnly = False
        TxtDescripcion.BackColor = Color.White
        TxtDescripcion.ReadOnly = False
        TxtIdArticulo.Select()

    End Sub

    Private Sub BtnImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagem.Click

        'abrir dialogo para seleccionar una image
        Dim EX As New OpenFileDialog With {
            .Title = "BUSCAR IMAGEN"
        }
        'CREAMOS UN FILTRO PRA QUE SOLO SE MUESTRE IMAGENES 
        Dim FILTRAR As String
        FILTRAR = "IMAGENES JPG|*.jpg|"
        FILTRAR += "TODAS LAS IMAGENES|*.png;*.jpg;*.gif;*.b­mp"
        EX.Filter = FILTRAR
        If EX.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = EX.FileName


        End If

    End Sub

    Private Sub TxtIdArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtIdArticulo.KeyDown

        Select Case e.KeyData
            Case Keys.Enter
                'If IsNumeric(TxtIdArticulo.Text) Then
                Dim tabla As New DataTable
                'conecto a base de datos
                Dim miGestionMySQL As New GestionMySQL
                'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
                tabla = miGestionMySQL.BuscarArtStockID(TxtIdArticulo.Text)
                'con el dt devuelto lleno el datagriedview
                DGVArticulos.DataSource = tabla

                TxtDescripcion.Text = ""
                TxtPrecioCompra.Text = "0,00"
                TxtPrecioVenta.Text = "0,00"

                PictureBox1.Image = Nothing
                'Else
                'MsgBox("Debe ingresar solo NUMEROS")
                'End If

        End Select
    End Sub


    Private Sub TxtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescripcion.TextChanged
        Dim tabla As New DataTable
        'conecto
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion ConsultarArticuloStock() de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarArtStockDescripcion(TxtDescripcion.Text)
        'con el dt devuelto lleno el datagriedview
        DGVArticulos.DataSource = tabla

    End Sub

    Private Sub BtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionar.Click

        Dim miImagen As Image = PictureBox1.Image

        If DGVArticulos.RowCount > 0 Then

            miArticulo.IdArticulo = DGVArticulos.SelectedCells(0).Value

            If IsDBNull(DGVArticulos.SelectedCells(1).Value) Then
                miArticulo.Descripcion = ""
            Else
                miArticulo.Descripcion = DGVArticulos.SelectedCells(1).Value
            End If

            If IsDBNull(DGVArticulos.SelectedCells(2).Value) Then
                miArticulo.PrecioCompra = 0
            Else
                miArticulo.PrecioCompra = DGVArticulos.SelectedCells(2).Value
            End If
            If IsDBNull(DGVArticulos.SelectedCells(3).Value) Then
                miArticulo.PrecioVenta = 0
            Else
                miArticulo.PrecioVenta = DGVArticulos.SelectedCells(3).Value
            End If
            If IsDBNull(DGVArticulos.SelectedCells(4).Value) Then
                miArticulo.Marca = ""
            Else
                miArticulo.Marca = DGVArticulos.SelectedCells(4).Value
            End If
            If IsDBNull(DGVArticulos.SelectedCells(5).Value) Then
                miArticulo.Foto = Nothing
            Else
                miImagen = Bytes_Imagen(DGVArticulos.SelectedCells(5).Value)

            End If
            If IsDBNull(DGVArticulos.SelectedCells(6).Value) Then
                miArticulo.Rubro = ""
            Else
                miArticulo.Rubro = DGVArticulos.SelectedCells(6).Value
            End If

            If IsDBNull(DGVArticulos.SelectedCells(7).Value) Then
                miArticulo.Stock = 0
            Else
                miArticulo.Stock = CInt(DGVArticulos.SelectedCells(7).Value)
            End If
            If IsDBNull(DGVArticulos.SelectedCells(8).Value) Then
                miArticulo.StockMinimo = 0
            Else
                miArticulo.StockMinimo = CInt(DGVArticulos.SelectedCells(8).Value)
            End If

            If IsDBNull(DGVArticulos.SelectedCells(9).Value) Then
                miArticulo.Situado = ""
            Else
                miArticulo.Situado = DGVArticulos.SelectedCells(9).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdArticulo.Text = miArticulo.IdArticulo
            Me.TxtDescripcion.Text = miArticulo.Descripcion
            Me.TxtPrecioCompra.Text = miArticulo.PrecioCompra
            Me.TxtPrecioVenta.Text = miArticulo.PrecioVenta
            Me.ComboBoxMarca.Text = miArticulo.Marca

            Me.TxtRubro.Text = miArticulo.Rubro
            Me.TxtSituado.Text = miArticulo.Situado
            Me.TxtStock.Text = miArticulo.Stock
            Me.TxtStockMinimo.Text = miArticulo.StockMinimo

            PictureBox1.Image = miImagen
            'xtImagen.Text = EX.FileName

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False

    End Sub



    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Limpiar()
        Llenargrid()
    End Sub

    Private Sub TxtPrecioCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioCompra.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
    End Sub

    Private Sub TxtPrecioCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrecioCompra.TextChanged
        If IsNumeric(TxtPrecioCompra.Text) Then
            'Nada
        Else
            MsgBox("DEBE CARGAR SOLO NUMEROS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TxtPrecioVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioVenta.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
    End Sub

    Private Sub TxtPrecioVenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrecioVenta.TextChanged
        If IsNumeric(TxtPrecioVenta.Text) Then
            'Nada
        Else
            MsgBox("DEBE CARGAR SOLO NUMEROS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TxtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStock.TextChanged
        If IsNumeric(TxtStock.Text) Then
            'Nada
        Else
            MsgBox("DEBE CARGAR SOLO NUMEROS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TxtStockMinimo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStockMinimo.TextChanged
        If IsNumeric(TxtStockMinimo.Text) Then
            'Nada
        Else
            MsgBox("DEBE CARGAR SOLO NUMEROS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BrnAgregaArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrnAgregaArticulo.Click

        If DGVArticulos.RowCount > 0 Then
            miArticulo.IdArticulo = DGVArticulos.SelectedCells(0).Value
            miArticulo.Descripcion = DGVArticulos.SelectedCells(1).Value
            If IsDBNull(DGVArticulos.SelectedCells(2).Value) Then
                miArticulo.PrecioCompra = 0
            Else
                miArticulo.PrecioCompra = DGVArticulos.SelectedCells(2).Value
            End If

            If IsDBNull(DGVArticulos.SelectedCells(3).Value) Then
                miArticulo.PrecioVenta = 0
            Else
                miArticulo.PrecioVenta = DGVArticulos.SelectedCells(3).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK

            frmCompras.TxtCodArticulo.Text = miArticulo.IdArticulo
            frmCompras.TxtDescArticulo.Text = miArticulo.Descripcion
            frmCompras.TxtPVentaO.Text = miArticulo.PrecioVenta
            frmCompras.TxtPVentaM.Text = miArticulo.PrecioVenta
            frmCompras.txtprecioUnitario.Text = (miArticulo.PrecioCompra * 1).ToString("0.00")
        End If
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        FrmMarca.MdiParent = MDIMenu
        FrmMarca.Show()

    End Sub

    'Lleno combobox Marca
    Public Sub llenarComboxMarca(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLMarca As New GestionMySQL
        dtMarca = miGestionMySQLMarca.ConsultarTabla("marcaarticulo")
        With ComboBoxMarca
            .DataSource = dtMarca              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLMarca.Dispose()
    End Sub


End Class