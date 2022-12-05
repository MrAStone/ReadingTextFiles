Imports System.IO

Module Module1

    Sub Main()
        Dim FileToRead As New StreamReader("U:\advent22\day1testdata.txt")
        ' read it all
        '    Console.WriteLine(FileToRead.ReadToEnd)

        ' read it all and save in a string
        '       Dim fileContents As String = FileToRead.ReadToEnd
        '      Console.WriteLine(fileContents)

        'read line by line
        '        Do
        '        Console.WriteLine(FileToRead.ReadLine)
        '        Loop Until FileToRead.EndOfStream

        'read line by line and store in a list
        Dim fileLines As New List(Of String)
        Do
            fileLines.Add(FileToRead.ReadLine)
        Loop
        Console.WriteLine(fileLines(0)) ' the first line in the text file
    End Sub

End Module
