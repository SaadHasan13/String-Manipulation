Module Module1

    Sub Main()
        Dim RaceHRS, RaceMINS, RaceSECONDS, RaceTimeInSeconds, PersonalBestTime As Integer

        Console.Write("TIME IN HRS . . . ") : RaceHRS = Console.ReadLine
        Console.Write("TIME IN MINS . . . ") : RaceMINS = Console.ReadLine
        Console.Write("TIME IN Secs . . . ")
        RaceSECONDS = Console.ReadLine
        Console.Write("Enter Personal Best in seconds . . . ")
        PersonalBestTime = Console.ReadLine
        RaceTimeInSeconds = (RaceHRS * 60 * 60) + (RaceMINS * 60) + RaceSECONDS
        Console.WriteLine(RaceTimeInSeconds)

        If RaceTimeInSeconds < PersonalBestTime Then
            Console.WriteLine("Your new personal best time")
        Else
            If RaceTimeInSeconds = PersonalBestTime Then
                Console.WriteLine("Your time taken  is equal to the personal best time")
            Else
                Console.WriteLine("Personal best time is unchanged")
            End If
        End If

        Console.ReadKey()

    End Sub

End Module
