Imports System.IO

Module Module1


    Public Sub soloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    ' función que retorna el total de una columna 
    Public Function Sumar(ByVal nombreColumna As String, ByVal Dgv As DataGridView) As Double

        Dim total As Decimal = 0
        Dim i As Integer
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i = 0 To Dgv.RowCount - 1
                total = total + CDec(Dgv.Item(nombreColumna.ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total

    End Function

    '---------------------------------------------------------------------------------------------------------------
    'CONVERTIR BINARIO EN IMAGEN
    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'CONVERTIR IMAGEN EN BINARIO
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function


End Module
