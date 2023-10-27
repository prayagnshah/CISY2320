Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text

        ' Check if the input is not empty
        Dim numericValue As Double
        If String.IsNullOrEmpty(input) Or Not Double.TryParse(input, numericValue) Then
            MessageBox.Show("Please input a valid numeric value for the unit price")
            Return ' Exit the function early
        End If

        ' Check if ComboBox1 and ComboBox2 are set to valid values
        If ComboBox1.SelectedItem = 0 Then
            MessageBox.Show("Please select a valid quantity")
            Return
        End If


        If ComboBox2.SelectedItem = 0 Then
            MessageBox.Show("Please select a valid province")
            ' Exit the function early
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
