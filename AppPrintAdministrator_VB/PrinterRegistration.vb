Imports AppPrintAdministrator_VB.AppPrintAdministrator_VB
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class PrinterRegistration
	Public Sub New()
		InitializeComponent()
		dvgprinter.Columns.Add("Brand", "Brand")
		dvgprinter.Columns.Add("Series", "Series")
		dvgprinter.Columns.Add("SalePrice", "Sale Price")
		dvgprinter.Columns.Add("RentPrice", "Rent Price")
		dvgprinter.Columns.Add("Condition", "Condition")
		dvgprinter.Columns.Add("Description", "Description")
		dvgprinter.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dvgprinter.[ReadOnly] = True
		txtbrand.Text = (New Printer()).Brand
	End Sub

	Private Sub btnAddprinter_Click(sender As Object, e As EventArgs) Handles btnAddprinter.Click
		Try
			Select Case cbTypeprinter.SelectedIndex
				Case 0
					Dim workcenter As New Workcenter(txtserienumber.Text, Convert.ToDecimal(txtsaleprice.Text), Convert.ToDecimal(txtrentprice.Text))
					dvgprinter.Rows.Add(workcenter.ShowBrand(), workcenter.Series, workcenter.SalePrice, workcenter.RentPrice, cbconditionprinter.Text, txtdescripcion.Text)

				Case 1
					Dim phaser As New Phaser(txtserienumber.Text, Convert.ToDecimal(txtsaleprice.Text), Convert.ToDecimal(txtrentprice.Text))
					dvgprinter.Rows.Add(phaser.ShowBrand(), phaser.Series, phaser.SalePrice, phaser.RentPrice, cbconditionprinter.Text, txtdescripcion.Text)

				Case 2
					Dim versaLink As New VersaLink(txtserienumber.Text, Convert.ToDecimal(txtsaleprice.Text), Convert.ToDecimal(txtrentprice.Text))
					dvgprinter.Rows.Add(versaLink.ShowBrand(), versaLink.Series, versaLink.SalePrice, versaLink.RentPrice, cbconditionprinter.Text, txtdescripcion.Text)

				Case Else
					MessageBox.Show("Please select a printer")

			End Select

		Catch ex As FormatException
			MessageBox.Show("Incorrect format. Please try again")

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub btnDeleteprinter_Click(sender As Object, e As EventArgs) Handles btnDeleteprinter.Click
		If dvgprinter.SelectedRows.Count > 0 Then
			dvgprinter.Rows.RemoveAt(dvgprinter.SelectedRows(0).Index)
		Else
			MessageBox.Show("Please select a row to delete")
		End If

	End Sub

	Private Sub btnSavewordprinter_Click(sender As Object, e As EventArgs) Handles btnSavewordprinter.Click
		Dim selectedRow As DataGridViewRow = dvgprinter.SelectedRows(0)
		Dim saveFileDialog As New SaveFileDialog()
		saveFileDialog.Filter = "Word Document (*.docx)|*.docx"
		saveFileDialog.FileName = selectedRow.Cells(1).Value.ToString() & ".docx"

		If saveFileDialog.ShowDialog() <> DialogResult.OK Then
			Return
		End If

		Dim filePath As String = saveFileDialog.FileName

		Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document)
			Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
			mainPart.Document = New Document()
			Dim body As Body = mainPart.Document.AppendChild(New Body())
			Dim titlePara As Paragraph = body.AppendChild(New Paragraph())
			Dim titleRun As Run = titlePara.AppendChild(New Run())
			titleRun.AppendChild(New Text("Printer Registration"))
			titleRun.RunProperties = New RunProperties(New Bold())

			For Each cell As DataGridViewCell In selectedRow.Cells
				Dim para As Paragraph = body.AppendChild(New Paragraph())
				Dim run As Run = para.AppendChild(New Run())
				Dim runProp As New RunProperties()
				Dim fontSize As New FontSize() With {.Val = "24"}
				runProp.Append(fontSize)
				run.RunProperties = runProp
				run.AppendChild(New Text(dvgprinter.Columns(cell.ColumnIndex).HeaderText & ": "))
				run.AppendChild(New Text(cell.Value.ToString()))
			Next
		End Using

		MessageBox.Show("File saved successfully")

	End Sub

	Private Sub btnsearchpricesPrinter_Click(sender As Object, e As EventArgs) Handles btnsearchpricesPrinter.Click
		Try
			Select Case cbTypeprinter.SelectedIndex
				Case 0
					Dim workcenter As New Workcenter()
					txtsaleprice.Text = workcenter.SalePrice.ToString()
					txtrentprice.Text = workcenter.RentPrice.ToString()

				Case 1
					Dim phaser As New Phaser()
					txtsaleprice.Text = phaser.SalePrice.ToString()
					txtrentprice.Text = phaser.RentPrice.ToString()

				Case 2
					Dim versaLink As New VersaLink()
					txtsaleprice.Text = versaLink.SalePrice.ToString()
					txtrentprice.Text = versaLink.RentPrice.ToString()

				Case Else
					MessageBox.Show("Please select a printer")

			End Select
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub
End Class