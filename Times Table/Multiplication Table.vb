Option Explicit On
Option Strict On
Option Compare Text

'Jacob Horsley
'2/5/2025
'RCET 2206
'URL:https://github.com/horsjaco117/Times-Table

Imports System.Diagnostics.Eventing.Reader

Module multiplicationTable
    Sub Main()


        Dim userInput As String
        Dim justDoIt As Integer
        Dim result As String
        Dim getOutofHere As Boolean = False

        Do
            Console.WriteLine("Please enter a number to create your multiplication table.")
            Console.WriteLine("Or enter 'Q' to quit.")
            userInput = Console.ReadLine()

            Console.WriteLine($"you entered {userInput}!")

            Try
                justDoIt = CInt(userInput) 'User's number to conversion

                Console.WriteLine($"Multiplication Table for {justDoIt}:")

                For i = 1 To justDoIt 'Helps make columns

                    For j = 1 To justDoIt 'helps make rows too
                        result = (i * j).ToString
                        result = result.PadLeft(4)
                        Console.Write(result)
                    Next
                    Console.WriteLine()
                Next

            Catch ex As Exception 'Code to exit the program
                If userInput.Trim().ToUpper() = "Q" Then
                    Console.WriteLine("Exiting...")
                    getOutofHere = True

                Else
                    Console.WriteLine("Unacceptable input.")
                End If

            End Try

        Loop Until getOutofHere = True

    End Sub

End Module
