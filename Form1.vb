Public Class Form1

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim a As Double = CDbl(txtNum1.Text)
        Dim b As Double = CDbl(txtNum2.Text)
        Dim c As Double = a + b
        MessageBox.Show($"The sum is {c}.", "Sum")
    End Sub
End Class
