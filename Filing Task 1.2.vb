Module Module1

    Sub Main()
        'Task 1.2 Output the file contents
        Dim mName As String = ""
        Dim IDnumber As Integer = 0
        FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, mName)
            Input(1, IDnumber)

            Console.WriteLine("Member name is: " & mName)
            Console.WriteLine("Member ID number is: " & IDnumber)

        End While
        Console.ReadKey()

        FileClose(1)
    End Sub

End Module
