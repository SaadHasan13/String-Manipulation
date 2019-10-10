Module Module1

    Sub Main()
        Dim WS1, WS2, Ch1, Ch2, NextChar As String
        Dim COUNTER As Integer

        WS1 = " "
        WS2 = " "
        Ch1 = " "
        Ch2 = " "
        NextChar = " "
        COUNTER = 0

        Console.Write("Enter a String: ")
        WS1 = Console.ReadLine

        Console.Write("Enter the character you want to be eliminated: ")
        Ch1 = Console.ReadLine

        Console.Write("Enter the character you want to replace with: ")
        Ch2 = Console.ReadLine

        For COUNTER = 1 To Len(WS1)
            NextChar = Mid(WS1, COUNTER, 1)
            If NextChar = Ch1 Then
                NextChar = Ch2
            End If
            WS2 = WS2 & NextChar
        Next


        Console.WriteLine("Final String = " & WS2)
        Console.ReadKey()
    End Sub

End Module
