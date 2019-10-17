Module Module1

    Sub Main()
        Dim BinaryStr, NextStr, BinaryStr2, Binary As String
        Dim Counter, UpcomingNum, Denary As Integer
        Dim validBinaryStr As Boolean
      
        BinaryStr = " "
        BinaryStr2 = " "
        NextStr = " "
        Counter = 0
        validBinaryStr = True
        Binary = "01"
        Denary = 0
        UpcomingNum = 0

        Console.WriteLine("PLEASE ENTER A BINARY NUMBER: ")
        BinaryStr = Console.ReadLine

        If Len(BinaryStr) >= 8 Then
            validBinaryStr = True
            For Counter = 1 To 8
                If InStr(BinaryStr, Mid(NextStr, Counter, 1)) = 0 Then
                    validBinaryStr = False 
                End If
            Next
        Else : validBinaryStr = False

        End If

        If validBinaryStr = False Then
            Console.WriteLine("The entered string is not a binary number")
        End If

        If validBinaryStr Then
            For Counter = 1 To Len(BinaryStr)
                BinaryStr2 = Mid(BinaryStr, Counter, 1) & BinaryStr2
                If NextStr = "1" Then
                    UpcomingNum = 1
                End If

                If Counter = 1 Then
                    Denary = Denary + UpcomingNum
                End If
                If Counter = 2 Then
                    Denary = Denary + UpcomingNum * 2
                End If
                If Counter = 3 Then
                    Denary = Denary + UpcomingNum * 3
                End If
                If Counter = 4 Then
                    Denary = Denary + UpcomingNum * 4
                End If
            Next
            Console.WriteLine(BinaryStr & " = " & Denary)
        End If
        Console.ReadKey()
    End Sub

End Module
