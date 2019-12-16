Module Module1
    'Created by Konrad Wila
    'Checks if a string is Palindrome. So the same is spelled in both directions for example a racecar
    Sub Main()
        Dim testString As New List(Of String)
        Dim word As String = ""
        Dim input As String
        Dim Buffer() As Char = ""
        Dim MaxWords As Integer = 0
        Dim AntalPalinDrome As Integer = 0

        Do
            Console.WriteLine("Enter the words/numbers to be checked for being a palindrome")
            input = Console.ReadLine()
            testString.Add(input)
        Loop Until input = ""

        MaxWords = testString.Count
        Console.WriteLine("Look through a list of words" & vbNewLine)
        For Each word In testString
            Buffer = word
            Array.Reverse(Buffer)
            If Buffer = word Then
                AntalPalinDrome = AntalPalinDrome + 1
                Console.WriteLine(Buffer)
            End If
        Next

        Console.WriteLine(vbNewLine & "Found " & AntalPalinDrome & " palindromes" & vbNewLine)
        Console.WriteLine("Press a button to exit")
        Console.ReadKey()
    End Sub

End Module
