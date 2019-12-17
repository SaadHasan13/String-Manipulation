Module Module1

    Sub Main()
        Dim MyString As String
        Dim StringTotal, I, NextNum As Integer

        Console.Write("Enter a string : ")
        MyString = Console.ReadLine
        StringTotal = 0

        For I = 1 To Len(MyString)
            NextNum = Asc(Mid(MyString, I, 1))
            StringTotal = StringTotal + NextNum
        Next

        Console.WriteLine(MyString & " " & Str(StringTotal))

        Console.ReadKey()


    End Sub

End Module
