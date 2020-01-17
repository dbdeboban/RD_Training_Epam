Imports System

Public Class Program
    Public Shared Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

    Public Shared Function Multiply(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x * y
    End Function

    Public Shared Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x - y
    End Function

    Public Shared Function Division(ByVal x As Integer, ByVal y As Integer) As Single
        Return x / y
    End Function

    Public Shared Sub Main(ByVal args As String())
        Console.WriteLine("Enter First Number:")
        Dim x As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter Second Number")
        Dim y As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine(Add(x, y))
        Console.WriteLine(Multiply(x, y))
        Console.WriteLine(Subtract(x, y))
        Console.WriteLine(Division(x, y))
    End Sub
End Class
