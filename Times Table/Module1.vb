'Jacob Horsley
'2/5/2025
'RCET 2206
'URL:

Option Explicit On
Option Strict On



Module Module1
    Sub Main()


        Dim userInput As String
        Dim justDoIt As Integer
        Dim result As String
        userInput = Console.ReadLine()

        justDoIt = CInt(userInput)
        Console.WriteLine($"You entered {userInput}!")




        For i = 1 To justDoIt

            For j = 1 To justDoIt
                result = (i * j).ToString
                'result = CStr(i * j)
                'result = (i * j).ToString()
                result = result.PadLeft(4)
                'result = StrReverse(result)
                Console.Write(result)
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
