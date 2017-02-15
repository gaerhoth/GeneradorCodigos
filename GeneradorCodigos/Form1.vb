Imports System.Threading
Public Class Form1
    Public a As Boolean



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Dim i, j As Integer
        '   Dim Combinacion As String

        Dim i, x, z, s As Integer
        Dim i2, x2, z2, s2 As Integer
        Dim i3, x3, z3, s3 As Integer

        Dim REGISTRO As String

        Dim CONTADOR As Integer
        Dim CONTADOR2 As Integer
        Dim NumCodigos As Integer
        Dim NArchivo As Integer

        Dim A() As String = Nothing
        Dim J() As String = Nothing
        Dim K() As String = Nothing
        Dim M() As String = Nothing

        Dim A2() As String = Nothing
        Dim J2() As String = Nothing
        Dim K2() As String = Nothing
        Dim M2() As String = Nothing

        Dim A3() As String = Nothing
        Dim J3() As String = Nothing
        Dim K3() As String = Nothing
        Dim M3() As String = Nothing

        CONTADOR2 = 0
        Dim codigo As String
        If NumCod.Text <> "" Then
            NumCodigos = NumCod.Text
        Else
            NumCodigos = -1
        End If


        A = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                "u", "v", "w", "x", "y", "z"}

        J = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                          "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                              "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                              "u", "v", "w", "x", "y", "z"}

        K = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}

        M = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}



        A2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                           "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                           "u", "v", "w", "x", "y", "z"}

        J2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                          "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                              "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                              "u", "v", "w", "x", "y", "z"}

        K2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}

        M2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}


        A3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                           "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                           "u", "v", "w", "x", "y", "z"}

        J3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                          "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                              "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                              "u", "v", "w", "x", "y", "z"}

        K3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}

        M3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}





        'x = 0
        'z = 0
        's = 0

        If archivo.Text <> "" Then
            NArchivo = Me.archivo.Text
        Else
            NArchivo = 1
        End If


        s3 = Me.s3.Text
        z3 = Me.z3.Text
        x3 = Me.x3.Text
        i3 = Me.i3.Text
        s2 = Me.s2.Text
        z2 = Me.z2.Text
        x2 = Me.x2.Text
        i2 = Me.i2.Text
        s = Me.s.Text
        z = Me.z.Text
        x = Me.x.Text
        i = Me.i.Text

        While i <> 36

            codigo = M3(s3) + K3(z3) + J3(x3) + A3(i3) + M2(s2) + K2(z2) + J2(x2) + A2(i2) + M(s) + K(z) + J(x) + A(i)

            s3 = s3 + 1 ' el que corre
            If s3 = 36 Then
                z3 = z3 + 1
                s3 = 0
            End If

            If z3 = 36 Then
                x3 = x3 + 1
                z3 = 0
            End If

            If x3 = 36 Then
                i3 = i3 + 1
                x3 = 0
            End If

            If i3 = 36 Then
                s2 = s2 + 1
                i3 = 0
            End If

            If s2 = 36 Then
                z2 = z2 + 1
                s2 = 0
            End If

            If z2 = 36 Then
                x2 = x2 + 1
                z2 = 0
            End If

            If x2 = 36 Then
                i2 = i2 + 1
                x2 = 0
            End If

            If i2 = 36 Then
                s = s + 1
                i2 = 0
            End If




            If s = 36 Then
                z = z + 1
                s = 0
            End If
            If z = 36 Then
                x = x + 1
                z = 0
            End If
            If x = 36 Then
                i = i + 1
                x = 0
            End If




            'contador = 65572


            CONTADOR = CONTADOR + 1

            If CONTADOR <= 100000 Then
                My.Computer.FileSystem.WriteAllText("C:\PSN\" + CStr(NArchivo) + ".txt", codigo.ToUpper + Chr(10), True)
            Else


                REGISTRO = "s3=" + CStr(s3) + " z3=" + CStr(z3) + " x3=" + CStr(x3) + " i3=" + CStr(i3) + " s2=" + CStr(s2) + " z2=" + CStr(z2) + " x2=" + CStr(x2) + " i2=" + CStr(i2) + " s=" + CStr(s) + " z=" + CStr(z) + " x=" + CStr(x) + " i=" + CStr(i)

                NArchivo = NArchivo + 1

                My.Computer.FileSystem.WriteAllText("C:\PSN\Registro.txt", REGISTRO + Chr(10), True)

                My.Computer.FileSystem.WriteAllText("C:\PSN\" + CStr(NArchivo) + ".txt", codigo.ToUpper + Chr(10), True)
                CONTADOR = 0
            End If


        End While

        MsgBox("LISTO")






    End Sub

#Region "FUNCIONA4"
    'While i <> 36

    '     codigo = M(s) + K(z) + J(x) + A(i)
    '     s = s + 1 ' el que corre
    '     If s = 36 Then
    '         z = z + 1
    '         s = 0
    '     End If
    '     If z = 36 Then
    '         x = x + 1
    '         z = 0
    '     End If
    '     If x = 36 Then
    '         i = i + 1
    '         x = 0
    '     End If






    '     CONTADOR = CONTADOR + 1

    '     If CONTADOR <= 100000 Then
    '         My.Computer.FileSystem.WriteAllText("C:\PSN\" + NArchivo + ".txt", codigo.ToUpper + Chr(10), True)
    '     Else
    '         NArchivo = NArchivo + 1
    '         My.Computer.FileSystem.WriteAllText("C:\PSN\" + NArchivo + ".txt", codigo.ToUpper + Chr(10), True)
    '         CONTADOR = 0
    '     End If
    ' End While
#End Region
#Region "FORMA2"


    'forma 2
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    Dim Resultados As List(Of List(Of Char))
    '    Dim tx As String = TextBox1.Text
    '    Dim caracteres As List(Of Char)
    '    Dim CombinacionCadena As String = vbNullString
    '    Dim ListaAImprimir As New List(Of String)

    '    caracteres = tx.ToList

    '    Select Case tx.Length
    '        Case 2
    '            Resultados = Combina2(caracteres)
    '        Case 3
    '            Resultados = Combina3(caracteres)
    '        Case 4
    '            Resultados = Combina4(caracteres)
    '        Case 5
    '            Resultados = Combina5(caracteres)
    '        Case 6
    '            Resultados = Combina6(caracteres)
    '        Case 7
    '            Resultados = Combina7(caracteres)
    '        Case 8
    '            Resultados = Combina8(caracteres)
    '        Case 9
    '            Resultados = Combina9(caracteres)
    '        Case 10
    '            Resultados = Combina10(caracteres) '' hasta aqui lo probe con mi pc y funciona bien, 
    '            ''20-30 segundos aprox, despues lo probe con 12 y es practicamente inutil para cualquier pc.
    '        Case 11
    '            Resultados = Combina11(caracteres) '' aqui son ya casi 40 millones de listas de caracteres
    '            ''con una longitud de 12 seran 479 millones de listas de caracteres de 12 caracteres 
    '            ''cada lista lo que nos da un total de 5,748 millones de caracteres
    '    End Select


    '    ''Mostrar los resultados...
    '    For Each Combinacion In Resultados '' el imprimir los resultados en pantalla puede ser lento 
    '        CombinacionCadena = vbNullString
    '        For i = 0 To Combinacion.Count - 1 '' por lo que recomiento que no lo hagas...
    '            CombinacionCadena = CombinacionCadena & Combinacion(i).ToString
    '        Next
    '        ListaAImprimir.Add(CombinacionCadena)
    '    Next

    '    ListBox1.Items.AddRange(ListaAImprimir.ToArray)

    'End Sub
    'Function Combina11(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina10(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina10(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina9(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina9(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina8(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina8(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina7(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina7(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina6(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina6(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina5(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina5(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina4(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina4(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina3(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function
    'Function Combina3(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim ResultadoAnterior As List(Of List(Of Char))
    '    Dim ElementosAnteriores As New List(Of Char)
    '    Dim CaracterVariable As Char = vbNullChar
    '    Dim Lista As List(Of Char)
    '    Dim Vector() As Char

    '    CaracterVariable = Elementos(0)

    '    For i = 1 To Elementos.Count - 1
    '        ElementosAnteriores.Add(Elementos(i))
    '    Next

    '    ResultadoAnterior = Combina2(ElementosAnteriores)

    '    For i = 0 To Elementos.Count - 1
    '        For Each ListaAnterior In ResultadoAnterior
    '            Lista = New List(Of Char)
    '            Vector = ListaAnterior.ToArray
    '            Lista = Vector.ToList
    '            Lista.Insert(i, CaracterVariable)
    '            Resultado.Add(Lista)
    '        Next
    '    Next

    '    Return Resultado

    'End Function

    'Function Combina2(ByVal Elementos As List(Of Char)) As List(Of List(Of Char))
    '    Dim Resultado As New List(Of List(Of Char))
    '    Dim Lista As List(Of Char)

    '    Lista = New List(Of Char)
    '    Lista.Add(Elementos(0))
    '    Lista.Add(Elementos(1))
    '    Resultado.Add(Lista)

    '    Lista = New List(Of Char)
    '    Lista.Add(Elementos(1))
    '    Lista.Add(Elementos(0))
    '    Resultado.Add(Lista)

    '    Return Resultado
    'End Function

#End Region




    Private Sub ALE_Click(sender As Object, e As EventArgs) Handles ALE.Click
        ' Dim i, j As Integer
        '   Dim Combinacion As String

        Dim i, x, z, s As Integer
        Dim i2, x2, z2, s2 As Integer
        Dim i3, x3, z3, s3 As Integer

        Dim REGISTRO As String

        Dim CONTADOR As Integer
        Dim CONTADOR2 As Integer
        Dim NumCodigos As Integer
        Dim NArchivo As Integer

        Dim A() As String = Nothing
        Dim J() As String = Nothing
        Dim K() As String = Nothing
        Dim M() As String = Nothing

        Dim A2() As String = Nothing
        Dim J2() As String = Nothing
        Dim K2() As String = Nothing
        Dim M2() As String = Nothing

        Dim A3() As String = Nothing
        Dim J3() As String = Nothing
        Dim K3() As String = Nothing
        Dim M3() As String = Nothing

        CONTADOR2 = 0
        Dim codigo As String
        If NumCod.Text <> "" Then
            NumCodigos = NumCod.Text
        Else
            NumCodigos = -1
        End If


        A = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                "u", "v", "w", "x", "y", "z"}

        J = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                          "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                              "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                              "u", "v", "w", "x", "y", "z"}

        K = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}

        M = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}



        A2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                           "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                           "u", "v", "w", "x", "y", "z"}

        J2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                          "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                              "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                              "u", "v", "w", "x", "y", "z"}

        K2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}

        M2 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}


        A3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                           "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                           "u", "v", "w", "x", "y", "z"}

        J3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                          "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                              "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                              "u", "v", "w", "x", "y", "z"}

        K3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}

        M3 = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                  "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                                      "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                                      "u", "v", "w", "x", "y", "z"}





        'x = 0
        'z = 0
        's = 0
        If archivo.Text <> "" Then
            NArchivo = Me.archivo.Text
        Else
            NArchivo = 1
        End If
        While CONTADOR2 <= NumCodigos
            Randomize()
            s3 = CInt(Int((35 * Rnd()) + 1))
            z3 = CInt(Int((35 * Rnd()) + 1))
            x3 = CInt(Int((35 * Rnd()) + 1))
            i3 = CInt(Int((35 * Rnd()) + 1))
            s2 = CInt(Int((35 * Rnd()) + 1))
            z2 = CInt(Int((35 * Rnd()) + 1))
            x2 = CInt(Int((35 * Rnd()) + 1))
            i2 = CInt(Int((35 * Rnd()) + 1))
            s = CInt(Int((35 * Rnd()) + 1))
            z = CInt(Int((35 * Rnd()) + 1))
            x = CInt(Int((35 * Rnd()) + 1))
            i = CInt(Int((35 * Rnd()) + 1))


            codigo = M3(s3) + K3(z3) + J3(x3) + A3(i3) + M2(s2) + K2(z2) + J2(x2) + A2(i2) + M(s) + K(z) + J(x) + A(i)








            CONTADOR2 = CONTADOR2 + 1
            CONTADOR = CONTADOR + 1

            If CONTADOR <= 100000 Then
                My.Computer.FileSystem.WriteAllText("C:\PSN_ALE\" + CStr(NArchivo) + ".txt", codigo.ToUpper + Chr(10), True)
            Else


                REGISTRO = "s3=" + CStr(s3) + " z3=" + CStr(z3) + " x3=" + CStr(x3) + " i3=" + CStr(i3) + " s2=" + CStr(s2) + " z2=" + CStr(z2) + " x2=" + CStr(x2) + " i2=" + CStr(i2) + " s=" + CStr(s) + " z=" + CStr(z) + " x=" + CStr(x) + " i=" + CStr(i)

                NArchivo = NArchivo + 1

                My.Computer.FileSystem.WriteAllText("C:\PSN_ALE\Registro.txt", REGISTRO + Chr(10), True)

                My.Computer.FileSystem.WriteAllText("C:\PSN_ALE\" + CStr(NArchivo) + ".txt", codigo.ToUpper + Chr(10), True)
                CONTADOR = 0
            End If
        End While


        MsgBox("LISTO")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' WebBrowser1.Navigate("http://www.elotrolado.net")
    End Sub






End Class

