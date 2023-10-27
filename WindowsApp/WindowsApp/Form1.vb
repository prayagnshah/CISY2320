Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text

        ' Check if the input is not empty
        Dim numericValue As Double
        If Double.TryParse(input, numericValue) Then
            MessageBox.Show("This is your input ", input)

        Else
            MessageBox.Show("Please input a numeric value for the unit price")
        End If



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "1", "2"
                Label1.Text = "There are 31 days" & ComboBox1.SelectedItem.ToString()
            Case Else
                Label1.Text = "" ' Clear the label if a value other than 1 or 2

        End Select
    End Sub
End Class
