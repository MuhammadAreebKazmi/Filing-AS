Module Module1

    Sub Main()
        Dim mName As String = ""
        Dim IDnumber As Integer = 0
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
    End Sub

End Module
