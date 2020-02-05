Module Module1

    Sub Main()
        'Task1.1 Creating the file

        Dim mName As String
        Dim IDnumber As Integer
        Dim choice As String

        mName = ""
        IDnumber = 0
        choice = ""
        Do
            Console.Write("Enter the name: ")
            mName = Console.ReadLine

            Console.Write("Enter the member ID number please: ")
            IDnumber = Console.ReadLine

            Console.Write("Do you wish to enter more records? Press (Y/N) ")
            choice = Console.ReadLine


            FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Append)

            WriteLine(1, mName)
            WriteLine(1, IDnumber)

            FileClose(1)

            choice = UCase(choice)
        Loop Until choice = "N"
    End Sub

End Module
