﻿Module Module1

    Sub Main()
        'Task1.1 Creating the file

        Dim mName As String
        Dim IDnumber As String
        Dim choice As String

            mName = ""
            IDnumber = ""
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

        'Task 1.2 Output the file contents

        FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Input)

        Do
            Input(1, mName)
            Input(1, IDnumber)

            Console.WriteLine("Member name is: " & mName)
            Console.WriteLine("Member ID number is: " & IDnumber)

        Loop Until EOF(1)
        Console.ReadKey()

        FileClose(1)

        'Task 1.3 Name searching in file
        Dim Isfound As Boolean
        Dim SearchName As String

        Isfound = False
        SearchName = ""

        Console.Write("Enter the name you want to search: ")
        SearchName = Console.ReadLine

        FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, mName)
            Input(1, IDnumber)

            If UCase(mName) = UCase(SearchName) Then
                Isfound = True
                Console.WriteLine("The Member ID number is: " & IDnumber)
            End If

        End While

        FileClose(1)

        If Isfound = False Then
            Console.WriteLine("The Name was not found...")
        End If
        Console.ReadKey()

        'Task 1.4 New members data input

        Dim choice2 As String
        choice2 = ""

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


        'Task 1.5 Save Additional information

        Dim TelephoneNum As String
        'Dim MembershipStarting As Date

        TelephoneNum = ""
        'Membershipstarting date missing due to no knowledge of initialising date

        'Do
        'FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Input)
        'Input(1, mName)
        'Input(1, IDnumber)

        'Loop Until EOF(1)

        'FileClose(1)

        Do

            Console.Write("Enter the telephone number: ")
            TelephoneNum = Console.ReadLine

            'Console.Write("Enter the Membership starting date: ")
            'MembershipStarting = Console.ReadLine

            FileOpen(1, "C:\Filing Practice\ClubMembers.txt", OpenMode.Append)
            FileOpen(2, "C:\Filing Practice\ClubMembersNewFile.txt", OpenMode.Append)

            WriteLine(1, TelephoneNum)
            'WriteLine(1, MembershipStarting)

            Input(1, mName)
            Input(1, IDnumber)
            Input(1, TelephoneNum)
            'Input(1, MembershipStarting)

            WriteLine(2, mName)
            WriteLine(2, IDnumber)
            WriteLine(2, TelephoneNum)
            'WriteLine(2, MembershipStarting)


        Loop Until EOF(1)
        FileClose(1)
        FileClose(2)

        Console.ReadKey()



    End Sub

End Module
