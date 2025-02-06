Option Explicit On
Option Strict On
Option Compare Text On  

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
        Dim getOutofHere As Boolean





        'Do
        '    'Console.WriteLine("Type something and press enter")
        '    'userInput = Console.ReadLine()
        '    Console.WriteLine($"In the Do, Loop Until: ")
        '    userInput = "Q"
        'Loop Until userInput = "Q"

        Do
            Console.WriteLine("Please enter a number to create your multiplication table.")
            userInput = Console.ReadLine()

            Console.WriteLine($"you entered {userInput}!")

            Try
                justDoIt = CInt(userInput)
                getOutofHere = True

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


            Catch ex As Exception
                If userInput <> "Q" Then
                    Console.WriteLine($"Userinput is not a whole number")
                Else
                    getOutofHere = True
                End If
            End Try

        Loop Until getOutofHere = True


    End Sub

End Module
