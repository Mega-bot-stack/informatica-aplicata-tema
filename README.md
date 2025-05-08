Imports System.Math
Imports System.Drawing

Public Class Form1
    Private Sub btnDeseneaza_Click(sender As Object, e As EventArgs) Handles btnDeseneaza.Click
        Dim frecventa As Double
        Dim durata As Double = 2.0
        Dim amplitudine As Double = 100.0
        Dim width As Integer = picGrafic.Width
        Dim height As Integer = picGrafic.Height


        Dim frecventaMaxima As Double = width / durata


        If Not Double.TryParse(txtFrecventa.Text, frecventa) Then
            MessageBox.Show("Introduceți o valoare numerică validă pentru frecvență.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If frecventa > frecventaMaxima Then
            MessageBox.Show("Frecvența este prea mare pentru a fi reprezentată corect pe grafic. Limita maximă este " & frecventaMaxima.ToString("0.00") & " Hz.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim bmp As New Bitmap(width, height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)


            Dim penAxe As New Pen(Color.Black, 1)
            Dim fontEticheta As New Font("Arial", 10)
            Dim brushText As New SolidBrush(Color.Black)

            Dim zeroY As Single = height / 2
            Dim margineStanga As Integer = 40


            g.DrawLine(penAxe, margineStanga, zeroY, width, zeroY)
            g.DrawString("0", fontEticheta, brushText, margineStanga, zeroY + 5)
            g.DrawString(durata.ToString("0.0") & " s", fontEticheta, brushText, width - 60, zeroY + 5)
            g.DrawString("Timp (s)", fontEticheta, brushText, CSng(width / 2 - 30), height - 20)


            g.DrawLine(penAxe, margineStanga, 0, margineStanga, height)
            g.DrawString("+" & amplitudine.ToString(), fontEticheta, brushText, 0, 0)
            g.DrawString("0", fontEticheta, brushText, 10, zeroY - 10)
            g.DrawString("-" & amplitudine.ToString(), fontEticheta, brushText, 0, height - 20)
            g.DrawString("Amplitudine", fontEticheta, brushText, 5, 5)

            For a As Integer = -CInt(amplitudine) To CInt(amplitudine) Step 10
                Dim yCoord As Single = CSng(zeroY - a)


                If a <> 0 Then
                    g.DrawLine(Pens.LightGray, margineStanga, yCoord, width, yCoord)
                End If

                ' Etichete pe axa Y
                g.DrawString(a.ToString(), fontEticheta, brushText, 5, yCoord - 7)
            Next


            Dim puncte As New List(Of PointF)
            For x As Integer = margineStanga To width - 1
                Dim t As Double = (x - margineStanga) / (width - margineStanga) * durata
                Dim y As Double = amplitudine * Sin(2 * PI * frecventa * t)
                Dim screenY As Single = CSng(zeroY - y)
                puncte.Add(New PointF(x, screenY))
            Next

            If puncte.Count > 1 Then
                g.DrawLines(Pens.Blue, puncte.ToArray())
            End If
        End Using

        picGrafic.Image = bmp
    End Sub
End Class
