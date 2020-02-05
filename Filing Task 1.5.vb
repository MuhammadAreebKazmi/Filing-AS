Module Module1

    Sub Main()
        'Task 1.5 Save Additional information

        Dim TelephoneNum As String
        Dim MembershipStarting As String
        Dim mName As String
        Dim IDnumber As Integer

        TelephoneNum = ""
        mName = ""
        IDnumber = 0
        MembershipStarting = ""
        'Membershipstarting date missing due to no knowledge of initialising date

        FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Input)
        FileOpen(2, "C:\Filing Practice\ClubMembersNewFile.txt", OpenMode.Append)
        While Not EOF(1)
            Input(1, mName)
            Input(1, IDnumber)

            Console.Write("Enter the telephone number: ")
            TelephoneNum = Console.ReadLine

            Console.Write("Enter the Membership starting date: ")
            MembershipStarting = Console.ReadLine


            WriteLine(2, mName)
            WriteLine(2, IDnumber)
            WriteLine(2, TelephoneNum)
            WriteLine(2, MembershipStarting)

        End While
        FileClose(1)
        FileClose(2)

        Console.ReadKey()
    End Sub

End Module
