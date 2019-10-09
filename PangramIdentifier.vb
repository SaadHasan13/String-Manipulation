Module Module1

    Sub Main()
        Dim WORDSTR1, NextAlpha As String
        Dim COUNTER As Integer
        Dim IsItAPangram As Boolean

        WORDSTR1 = " "
        NextAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        COUNTER = 0
        IsItAPangram = False

        Console.WriteLine("PLEASE ENTER A QUESTIONABLE PANGRAM")
        WORDSTR1 = Console.ReadLine
        WORDSTR1 = UCase(WORDSTR1)
        If Len(WORDSTR1) >= 26 Then
            IsItAPangram = True
            For COUNTER = 1 To 26
                If InStr(WORDSTR1, Mid(NextAlpha, COUNTER, 1)) = 0 Then
                    IsItAPangram = False 
                End If
            Next
        End If
        If IsItAPangram = True Then
            Console.WriteLine("The string entered above is a pangram")
        Else
            Console.WriteLine("The string entered above is not a pangram")
        End If
        Console.ReadKey()
    End Sub

End Module
