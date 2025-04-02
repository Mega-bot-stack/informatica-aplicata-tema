Public Class Form1

    Private rnd As New Random()


    Private Sub Butongenerare_click(sender As Object, e As EventArgs) Handles Butongenerare.Click

        Dim numbers(5) As Integer

        Dim count As Integer = 0

        While count < 6

            Dim num As Integer = rnd.Next(1, 50)


            Dim exists As Boolean = False


            For i As Integer = 0 To count - 1
                If numbers(i) = num Then

                    exists = True
                    Exit For
                End If
            Next

            If Not exists Then
                numbers(count) = num

                count += 1
            End If
        End While


        Array.Sort(numbers)


        labelnumere.Text = "Numerele tale: " & String.Join(", ", numbers)
    End Sub

    Private Sub casutatext_Click(sender As Object, e As EventArgs) Handles casutatext.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class