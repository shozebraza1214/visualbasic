Module Module1
    Sub Main()
        ' Prompt the user for the first number
        Console.Write("Please enter Number 1: ")
        Dim numberOne As Integer = CInt(Console.ReadLine())

        ' Prompt the user for the second number
        Console.Write("Please enter Number 2: ")
        Dim numberTwo As Integer = CInt(Console.ReadLine())

        ' Prompt the user for the arithmetic operation
        Console.Write("Enter The Operation (+, -, *, /): ")
        Dim arithmetic As String = Console.ReadLine()

        ' Variable to store the result
        Dim result As Double

        ' Perform the selected operation
        Select Case arithmetic
            Case "+"
                result = numberOne + numberTwo
            Case "-"
                result = numberOne - numberTwo
            Case "*"
                result = numberOne * numberTwo
            Case "/"
                ' Ensure that division by zero is handled
                If numberTwo <> 0 Then
                    result = numberOne / numberTwo
                Else
                    Console.WriteLine("Error: Division by zero is not allowed.")
                    Exit Sub
                End If
            Case Else
                Console.WriteLine("Invalid operation.")
                Exit Sub
        End Select

        ' Output the result
        Console.WriteLine("The result is: " & result)
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
