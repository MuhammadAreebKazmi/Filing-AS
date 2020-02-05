Module Module1

    Sub Main()
        'Task 1.4 New members data input

        Dim choice2 As String
        choice2 = ""
        Dim IDnumber As Integer = 0
        Dim mName As String = ""

        Do


            Console.Write(" Please enter the name: ")
            mName = Console.ReadLine

            Console.Write(" Please enter the member ID number: ")
            IDnumber = Console.ReadLine

            Console.Write("Do you wish to enter more new members? (Y/N)")
            choice2 = Console.ReadLine

            FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Append)

            WriteLine(1, mName)
            WriteLine(1, IDnumber)

            FileClose(1)

            choice2 = UCase(choice2)
        Loop Until (choice2 = "N")

    End Sub

End Module
