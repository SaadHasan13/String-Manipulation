Module Module1

    Sub Main()
        Dim HomeTeamName, AwayTeamName, WinningTeamName As String
        Dim HomeTeamRuns, AwayTeamRuns, RunDiff As Integer

        HomeTeamName = Console.ReadLine
        HomeTeamRuns = Console.ReadLine
        AwayTeamName = Console.ReadLine
        AwayTeamRuns = Console.ReadLine

        If HomeTeamRuns > AwayTeamRuns Then
            WinningTeamName = HomeTeamName
        Else
            WinningTeamName = AwayTeamName
        End If

        RunDiff = Math.Abs(HomeTeamRuns - AwayTeamRuns)

        Console.WriteLine("The winning team is " & WinningTeamName & " who managed to score " & RunDiff & " more runs")

        Console.ReadKey()

    End Sub

End Module
