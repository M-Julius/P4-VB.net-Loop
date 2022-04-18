Imports System
Imports System.Collections

' input product
' when done input name, price save to local store
' show questions for repeat buy new product
' when questions 'YES' buy new product
' when questions 'NO' loop calculate all price in local store
' and then showing total price

Module ModuleP4
    Structure Product
        Dim name As String
        Dim price As Integer
    End Structure


    Sub Main()
        Dim Products As New ArrayList
        Dim p As Product
        Dim lineSpace As String = "========================================"

        Dim totalPrice As Integer
        Dim answer As String

        Dim i As Integer = &B10

        Do While (i > 1)
            p = addProduct()
            Products.Add(p)

            Console.WriteLine("Tambah Belanja (YES/NO) : ")
            answer = Console.ReadLine()

            If answer = "YES" Then
                Console.WriteLine(lineSpace)
                Console.WriteLine("Tambah Belanjaan Baru")
                i += 1
            Else
                i = 1
            End If
        Loop

        Console.WriteLine(lineSpace)
        Console.WriteLine("Semua Belanjaan : ")
        For Each p In Products
            Console.WriteLine(p.name & " - " & p.price)
            totalPrice += p.price
        Next p

        Console.WriteLine("Total Belanja : " & totalPrice)
    End Sub

    Function addProduct() As Product
        Dim p As Product

        Console.WriteLine("Barang yang dibeli : ")
        p.name = Console.ReadLine()

        Console.WriteLine("Harga Barang : ")
        p.price = Integer.Parse(Console.ReadLine())

        Return p
    End Function
End Module