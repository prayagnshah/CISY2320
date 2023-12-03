Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text

        ' Check if the input is not empty
        Dim numericValue As Double
        If String.IsNullOrEmpty(input) Or Not Double.TryParse(input, numericValue) Then
            MessageBox.Show("You must input a numeric value for the unit price")
            Return
        End If

        ' Check if ComboBox1 and ComboBox2 are set to valid values
        If ComboBox1.SelectedItem = 0 Then
            MessageBox.Show("You must choose a quantity")
            Return
        Else If ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("You must select a province")
            Exit Sub
        End If

       

        ' Calculate ComboBox1 selection into numeric value
        Dim quantity As Integer = Integer.Parse(ComboBox1.SelectedItem.ToString())

        ' Calculating the total value
        Dim total As Double = numericValue * quantity

        ' Getting the selected province into string
        Dim selectedProvince As String = ComboBox2.SelectedItem.ToString()

        ' Check ComboBox2 dropdown is selected
        If ComboBox2.SelectedItem IsNot Nothing Then
            selectedProvince = ComboBox2.SelectedItem.ToString()
        End If

        ' Calculate tax rate based on province selection
        Dim taxRate As Double
        Select Case selectedProvince
            Case "Ontario"
                taxRate = 0.13
            Case "New Brunswick", "Newfoundland and Labrador", "Nova Scotia", "Prince Edward Island"
                taxRate = 0.15
            Case Else
                taxRate = 0.05
        End Select

        ' Calculate tax amount
        Dim taxAmount As Double = total * taxRate

        ' Calculate the total with Tax
        Dim taxableAmount As Double = total + taxAmount

        ' Displaying message at end after all the inputs 
        MessageBox.Show("Subtotal before GST/HST: " & total.ToString("C") & vbCrlf &
                        "GST/HST: " & taxAmount.ToString("C") & vbCrlf &
                        "Total with GST/HST: " & taxableAmount.ToString("C")) 

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
