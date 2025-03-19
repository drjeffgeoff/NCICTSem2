Public Class Form1
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        ' Check if the text box is not empty
        If txtAddItem.Text.Trim() <> "" Then
            ' Add item from txtAddItem to lstShopping
            lstShopping.Items.Add(txtAddItem.Text)
            ' Clear the text box after adding the item
            txtAddItem.Clear()
            ' Set focus back to the input field
            txtAddItem.Focus()
        Else
            ' Show a message if text box is empty
            MessageBox.Show("Please enter an item to add!", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
