Public Class Notes
	Private Sub btnOpennotes_Click(sender As Object, e As EventArgs) Handles btnOpennotes.Click
		Dim openFileDialog As New OpenFileDialog()
		openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

		If openFileDialog.ShowDialog() <> DialogResult.OK Then
			MessageBox.Show("No data entry")
		Else
			Using file As New System.IO.StreamReader(openFileDialog.FileName)
				txtnotes.Text = file.ReadToEnd()
			End Using
		End If

	End Sub

	Private Sub btnSaveNotes_Click(sender As Object, e As EventArgs) Handles btnSaveNotes.Click
		Dim saveFileDialog As New SaveFileDialog()
		saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

		If saveFileDialog.ShowDialog() <> DialogResult.OK Then
			MessageBox.Show("No data entry")
		Else
			Using file As New System.IO.StreamWriter(saveFileDialog.FileName)
				file.WriteLine(txtnotes.Text)
			End Using
		End If

	End Sub
End Class