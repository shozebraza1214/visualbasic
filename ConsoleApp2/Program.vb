Imports System

Module Program
    Dim num1, num2, sum, min, muil, div As Integer
    Sub Main(args As String())
        Console.WriteLine("Enter num 1 ")
        num1 = Console.ReadLine

        Console.WriteLine("Enter num 2 ")
        num2 = Console.ReadLine

        sum = num1 + num2
        min = num1 - num2
        muil = num1 * num2
        div = num1 / num2

        Console.WriteLine("sum is equal to " & sum)
        Console.WriteLine("subratction is equal to " & min)
        Console.WriteLine("product is equal to " & muil)
        \


    End Sub
End Module
