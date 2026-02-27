Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Label4.Text = "Faltan datos"
        Else
            Dim x As Double = Double.Parse(TextBox1.Text)
            Dim y As Double = Double.Parse(TextBox2.Text)
            Dim r As Double = (x + y) / 2
            Label4.Text = "El promedio es" & " " & r.ToString
        End If

    End Sub


End Class
