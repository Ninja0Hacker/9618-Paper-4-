Module Module1
    Dim LoginEvents(0 To 9, 0 To 1) As String
    Sub Main()
        SearchFile()
        For x = 0 To 9
            Console.WriteLine(LoginEvents(x, 0) & "      " & LoginEvents(x, 1))
        Next
        Console.ReadKey()
    End Sub
    Sub SearchFile()
        Dim IDToSearch, Data As String
        Dim FileID, Portno, Timestamp As String
        Dim x As Integer
        x = 0
        Data = ""
        Portno = ""
        Timestamp = ""
        Console.Write("Enter UserID To Search: ")
        IDToSearch = Console.ReadLine()
        FileOpen(1, My.Application.Info.DirectoryPath & "/LoginFile.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, Data)
            FileID = Left(Data, 5)
            If FileID = IDToSearch Then
                Portno = Mid(Data, 6, 4)
                Timestamp = Right(Data, 14)
                LoginEvents(x, 0) = Portno
                LoginEvents(x, 1) = Timestamp
            End If
            x = x + 1
        End While
        FileClose(1)
    End Sub
End Module
