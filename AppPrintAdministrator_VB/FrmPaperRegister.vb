Imports AppPrintAdministrator_VB.AppPrintAdministrator_VB

Public Class FrmPaperRegister
	Public paper As TypePaper()

	Private currentindex As Integer
	Public Sub New()
		InitializeComponent()
		dgvPaperdata.Columns.Add("Name", "Name")
		dgvPaperdata.Columns.Add("Size", "Size")
		dgvPaperdata.Columns.Add("PricePacket", "PricePacket")
		dgvPaperdata.Columns.Add("PricePrint", "PricePrint")
		dgvPaperdata.Columns.Add("WhiteSheetPrice", "WhiteSheetPrice")
		dgvPaperdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvPaperdata.[ReadOnly] = True
		ReDim paper(19)
		currentindex = 0
	End Sub

	Private Sub btnaddpaper_Click(sender As Object, e As EventArgs) Handles btnaddpaper.Click
		If currentindex = paper.Length Then
			MessageBox.Show("Full base")
			Return
		End If

		Try
			Dim newTypePaper As New TypePaper()
			newTypePaper.Name = cbnamespaper.Text
			newTypePaper.Size = cbsizepaper.Text
			newTypePaper.PricePacket = Convert.ToDecimal(txtpackegepricepaper.Text)
			newTypePaper.PricePrint = Convert.ToDecimal(txtpritingpricepaper.Text)
			newTypePaper.WhiteSheetPrice = Convert.ToDecimal(txtwhitesheetprice.Text)
			paper(currentindex) = newTypePaper
			currentindex += 1
			dgvPaperdata.Rows.Add(newTypePaper.Name, newTypePaper.Size, newTypePaper.PricePacket, newTypePaper.PricePrint, newTypePaper.WhiteSheetPrice)
		Catch ex As FormatException
			MessageBox.Show("Incorrect format. Please try again")
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub btndeletepaper_Click(sender As Object, e As EventArgs) Handles btndeletepaper.Click
		If dgvPaperdata.SelectedRows.Count = 0 Then
			MessageBox.Show("Select a row to delete")
			Return
		End If

		Dim selectedRow As DataGridViewRow = dgvPaperdata.SelectedRows(0)
		dgvPaperdata.Rows.Remove(selectedRow)

		For i As Integer = 0 To currentindex - 1
			If paper(i).Name = selectedRow.Cells(0).Value.ToString() Then
				For j As Integer = i To currentindex - 2
					paper(j) = paper(j + 1)
				Next
				currentindex -= 1
				Exit For
			End If
		Next

		dgvPaperdata.Rows.Clear()

		For i As Integer = 0 To currentindex - 1
			dgvPaperdata.Rows.Add(paper(i).Name, paper(i).Size, paper(i).PricePacket, paper(i).PricePrint, paper(i).WhiteSheetPrice)
		Next

	End Sub

	Private Sub btnopenfilepaper_Click(sender As Object, e As EventArgs) Handles btnopenfilepaper.Click
		Dim openFile As New OpenFileDialog()
		openFile.Filter = "Text files (*.txt)|*.txt"
		openFile.Title = "Open file"

		If openFile.ShowDialog() <> DialogResult.OK Then
			MessageBox.Show("No file selected")
			Return
		End If

		dgvPaperdata.Rows.Clear()
		currentindex = 0

		Dim lines As String() = System.IO.File.ReadAllLines(openFile.FileName)

		For i As Integer = 0 To lines.Length - 1
			Dim parts As String() = lines(i).Split(","c)
			Dim newTypePaper As New TypePaper()
			newTypePaper.Name = parts(0)
			newTypePaper.Size = parts(1)
			newTypePaper.PricePacket = Convert.ToDecimal(parts(2))
			newTypePaper.PricePrint = Convert.ToDecimal(parts(3))
			newTypePaper.WhiteSheetPrice = Convert.ToDecimal(parts(4))
			paper(currentindex) = newTypePaper
			currentindex += 1
			dgvPaperdata.Rows.Add(newTypePaper.Name, newTypePaper.Size, newTypePaper.PricePacket, newTypePaper.PricePrint, newTypePaper.WhiteSheetPrice)
		Next

	End Sub

	Private Sub btnsavefilepaper_Click(sender As Object, e As EventArgs) Handles btnsavefilepaper.Click
		Dim saveFile As New SaveFileDialog()
		saveFile.Filter = "Text files (*.txt)|*.txt"
		saveFile.Title = "Save file"

		Try
			If saveFile.ShowDialog() <> DialogResult.OK Then
				MessageBox.Show("No file selected")
				Return
			End If

			Using file As New System.IO.StreamWriter(saveFile.FileName)
				For i As Integer = 0 To currentindex - 1
					file.WriteLine(paper(i).Name & "," & paper(i).Size & "," & paper(i).PricePacket & "," & paper(i).PricePrint & "," & paper(i).WhiteSheetPrice)
				Next
			End Using

			MessageBox.Show("File saved")
		Catch ex As Exception
			MessageBox.Show("The document could not be saved. Try again. " & ex.Message)
		End Try

	End Sub
End Class