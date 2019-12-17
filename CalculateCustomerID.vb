Module Module1

    Sub Main()
        Dim Surname As String
        Dim SLength, CustomerID, NextCodeNumber, i As Integer
        Dim NextChar As Char

        Console.Write("Key in surname : ")
        Surname = Console.ReadLine

        SLength = Len(Surname)

        CustomerID = 0

        For i = 1 To SLength
            NextChar = Mid(Surname, i, 1)
            NextCodeNumber = Asc(NextChar)
            CustomerID = CustomerID + NextCodeNumber
        Next
        Console.WriteLine("Customer ID is " & CustomerID)

        Console.ReadKey()

    End Sub

End Module
