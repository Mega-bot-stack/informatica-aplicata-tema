Imports System

Module Program
    Sub Main()
        Dim random As New Random()
        Dim numbers As New List(Of Integer)()

        While numbers.Count < 6
            Dim number As Integer = random.Next(1, 49)
            If Not numbers.Contains(number) Then
                numbers.Add(number)
            End If
        End While
        Console.WriteLine("Aplicatzia va genera niste numere:")
        For Each num In numbers
            Console.WriteLine(num)
        Next



    End Sub
End Module
