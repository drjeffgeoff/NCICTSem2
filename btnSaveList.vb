Private Sub btnSaveList_Click(sender As Object, e As EventArgs) Handles btnSaveList.Click
    ' Show the Save File Dialog
    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
    saveFileDialog.Title = "Save Shopping List"
    
    If saveFileDialog.ShowDialog() = DialogResult.OK Then
        ' Open the file to write
        Dim writer As New System.IO.StreamWriter(saveFileDialog.FileName)
        
        ' Write each item in lstShopping to the file
        For Each item As String In lstShopping.Items
            writer.WriteLine(item)
        Next
        
        ' Close the writer
        writer.Close()

        ' Confirm that the file is saved
        MessageBox.Show("Shopping list saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
End Sub
