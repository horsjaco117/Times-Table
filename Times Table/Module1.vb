Option Explicit On
Option Strict On
Option Compare Text

'Jacob Horsley
'2/5/2025
'RCET 2206
'URL:

Imports System.Diagnostics.Eventing.Reader

Module Module1
    Sub Main()


        Dim userInput As String
        Dim justDoIt As Integer
        Dim result As String
        Dim isValid As Boolean
        Dim getOutofHere As Boolean = False





        'Do
        '    'Console.WriteLine("Type something and press enter")
        '    'userInput = Console.ReadLine()
        '    Console.WriteLine($"In the Do, Loop Until: ")
        '    userInput = "Q"
        'Loop Until userInput = "Q"

        Do
            Console.WriteLine("Please enter a number to create your multiplication table.")
            userInput = Console.ReadLine()

            If userInput.Trim().ToUpper = "Q" Then
                Console.WriteLine("Exiting the program...")
                getOutofHere = True
            End If

            Console.WriteLine($"you entered {userInput}!")

            Try
                justDoIt = CInt(userInput)

                Console.WriteLine($"Multiplication Table for {justDoIt}:")

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

                Console.WriteLine(vbCrLf & "Would you like to create another table? (Press 'Q' to quit)")
                userInput = Console.ReadLine()
                If userInput.Trim().ToUpper() = "Q" Then
                    Console.WriteLine("Exiting...")
                    getOutofHere = True
                End If

            Catch ex As Exception
                Console.WriteLine("Unacceptable input.")
            End Try


        Loop Until getOutofHere = True


    End Sub

End Module
