Imports System
Imports System.Collections

' input product
' when done input name, price save to local store
' show questions for repeat buy new product
' when questions 'YES' buy new product
' when questions 'NO' loop calculate all price in local store
' and then showing total price

Module ModuleP4
    ' make structure of product
    Structure Product
        Dim name As String
        Dim price As Integer
    End Structure


    Sub Main()
        ' define main variable
        Dim Products As New ArrayList
        Dim p As Product
        Dim lineSpace As String = "========================================"

        Dim totalPrice As Integer
        Dim answer As String

        Dim i As Integer = &B10

        ' loop for input product
        Do While (i > 1)
            ' input product
            p = addProduct()

            ' add product to arraylist
            Products.Add(p)

            ' ask user to add new product
            Console.WriteLine("Tambah Belanja (YES/NO) : ")
            answer = Console.ReadLine()

            ' when user answer 'YES' repeat this action
            If answer = "YES" Then
                Console.WriteLine(lineSpace)
                Console.WriteLine("Tambah Belanjaan Baru")
                i += 1
            Else
                ' when user answer 'NO' stop this action
                i = 1
            End If
        Loop

        Console.WriteLine(lineSpace)
        Console.WriteLine("Semua Belanjaan : ")
        
        ' loop for showing all product and calculate total price
        For Each p In Products
            Console.WriteLine(p.name & " - " & p.price)
            totalPrice += p.price
        Next p

        ' show total price
        Console.WriteLine("Total Belanja : " & totalPrice)
    End Sub

    ' function for input product
    Function addProduct() As Product
        Dim p As Product

        Console.WriteLine("Barang yang dibeli : ")
        p.name = Console.ReadLine()

        Console.WriteLine("Harga Barang : ")
        p.price = Integer.Parse(Console.ReadLine())

        ' return product
        Return p
    End Function
End Module