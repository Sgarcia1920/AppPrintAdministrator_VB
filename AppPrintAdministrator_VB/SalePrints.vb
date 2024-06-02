Imports System.IO
Imports System.Xml
Imports AppPrintAdministrator_VB.AppPrintAdministrator_VB
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Public Class SalePrints

	Private paper() As TypePaper
	Private sales(,) As Sales
	Private currentindex As Integer
	Private searchprice As Decimal
	Private currentRowIndex As Integer

	Public Sub New()
		InitializeComponent()
		dgvSalePrint.Columns.Add("Size", "Size")
		dgvSalePrint.Columns.Add("Name", "Name")
		dgvSalePrint.Columns.Add("SalesOptions", "SalesOptions")
		dgvSalePrint.Columns.Add("Price", "Price")
		dgvSalePrint.Columns.Add("Quantity", "Quantity")
		dgvSalePrint.Columns.Add("Total", "Total")

		dgvSalePrint.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvSalePrint.[ReadOnly] = True

		paper = New TypePaper(19) {}
		sales = New Sales(14, 4) {}
		currentindex = 0
		searchprice = 0D
		currentRowIndex = 0
	End Sub

	Private Sub btnAddsales_Click(sender As Object, e As EventArgs) Handles btnAddsales.Click
		Try
			Dim newSale As New Sales()
			newSale.Size = cbsize.Text
			newSale.AvailablePaperSales = cbAvailablepaper.Text
			newSale.SalesOptions = cbSalesOptions.Text
			newSale.PriceSale = Convert.ToDecimal(txtPricesales.Text)
			newSale.NumberPrints = Convert.ToInt32(txtNumberPrints.Text)

			If currentindex >= sales.Length Then
				MessageBox.Show("No more sales can be added.")
				Return
			End If

			sales(currentRowIndex, 0) = newSale
			dgvSalePrint.Rows.Add(newSale.Size, newSale.AvailablePaperSales, newSale.SalesOptions, newSale.PriceSale, newSale.NumberPrints, newSale.CalculateTotalSale())
			currentRowIndex += 1

			Dim totalVentas As Decimal = AddTotalsSales(sales)
			txtSubtotal.Text = totalVentas.ToString("F2")
			CalculateIVA(totalVentas, txtIVA)
			Dim totalWithIva As Decimal = totalVentas * 1.16D
			txtTotal.Text = totalWithIva.ToString("F2")
		Catch ex As FormatException
			MessageBox.Show("Incorrect format. Please try again.")
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub btncancel_purchase_Click(sender As Object, e As EventArgs) Handles btncancel_purchase.Click
		For i As Integer = 0 To sales.GetLength(0) - 1
			For j As Integer = 0 To sales.GetLength(1) - 1
				sales(i, j) = Nothing
			Next
		Next

		dgvSalePrint.Rows.Clear()
		txtSubtotal.Text = ""
		txtIVA.Text = ""
		txtTotal.Text = ""
		txtPayment.Text = ""
		txtChange.Text = ""

	End Sub

	Private Sub btnclearcontrols_Click(sender As Object, e As EventArgs) Handles btnclearcontrols.Click
		cbsize.Text = ""
		cbAvailablepaper.Text = ""
		cbSalesOptions.Text = ""
		txtPricesales.Text = ""
		txtNumberPrints.Text = ""

	End Sub

	Private Sub btnExporttxtpaper_Click(sender As Object, e As EventArgs) Handles btnExporttxtpaper.Click
		Dim openFile As New OpenFileDialog()
		openFile.Filter = "Text files (*.txt)|*.txt"
		openFile.Title = "Open file"

		If openFile.ShowDialog() <> DialogResult.OK Then
			MessageBox.Show("No file selected")
			Return
		End If

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
		Next

	End Sub

	Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
		If Convert.ToDecimal(txtPayment.Text) < Convert.ToDecimal(txtTotal.Text) Then
			MessageBox.Show("The payment must be greater than the total")
			Return
		End If

		txtChange.Text = (Convert.ToDecimal(txtPayment.Text) - Convert.ToDecimal(txtTotal.Text)).ToString()

	End Sub

	Private Sub btnexportsalesexcel_Click(sender As Object, e As EventArgs) Handles btnexportsalesexcel.Click
		Dim saveFile As New SaveFileDialog()
		saveFile.Filter = "Excel files (*.xlsx)|*.xlsx"
		saveFile.Title = "Save file"

		If saveFile.ShowDialog() <> DialogResult.OK Then
			MessageBox.Show("No file selected")
			Return
		End If

		Dim filePath As String = saveFile.FileName

		Using package As New ExcelPackage()
			Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Sales Report")

			worksheet.Cells(1, 1).Value = "Size"
			worksheet.Cells(1, 2).Value = "Available Paper"
			worksheet.Cells(1, 3).Value = "Sales Option"
			worksheet.Cells(1, 4).Value = "Price Sale"
			worksheet.Cells(1, 5).Value = "Number of Prints"
			worksheet.Cells(1, 6).Value = "Total Sale"

			Using range = worksheet.Cells(1, 1, 1, 6)
				range.Style.Font.Bold = True
				range.Style.Fill.PatternType = ExcelFillStyle.Solid
				range.Style.Fill.BackgroundColor.SetColor(Color.LightGray)
				range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center
			End Using

			Dim currentRow As Integer = 2
			For i As Integer = 0 To sales.GetLength(0) - 1
				For j As Integer = 0 To sales.GetLength(1) - 1
					If sales(i, j) IsNot Nothing Then
						worksheet.Cells(currentRow, 1).Value = sales(i, j).Size
						worksheet.Cells(currentRow, 2).Value = sales(i, j).AvailablePaperSales
						worksheet.Cells(currentRow, 3).Value = sales(i, j).SalesOptions
						worksheet.Cells(currentRow, 4).Value = sales(i, j).PriceSale
						worksheet.Cells(currentRow, 5).Value = sales(i, j).NumberPrints
						worksheet.Cells(currentRow, 6).Value = sales(i, j).CalculateTotalSale()
						currentRow += 1
					End If
				Next
			Next

			worksheet.Cells.AutoFitColumns()

			Dim fileInfo As New FileInfo(filePath)
			package.SaveAs(fileInfo)
		End Using

		MessageBox.Show("File saved successfully!")

	End Sub

	Private Sub btnsearchAvailablepaper_Click(sender As Object, e As EventArgs) Handles btnsearchAvailablepaper.Click
		cbAvailablepaper.Items.Clear()
		For i As Integer = 0 To currentindex - 1
			If paper(i).Size = cbsize.Text Then
				cbAvailablepaper.Items.Add(paper(i).Name)
			End If
		Next

	End Sub

	Private Sub btnpricepaper_Click(sender As Object, e As EventArgs) Handles btnpricepaper.Click
		For i As Integer = 0 To currentindex - 1
			If paper(i).Name = cbAvailablepaper.Text Then
				Select Case cbSalesOptions.Text
					Case "Pricepacket"
						searchprice = paper(i).PricePacket
					Case "Priceprint"
						searchprice = paper(i).PricePrint
					Case "WhitesheetPrice"
						searchprice = paper(i).WhiteSheetPrice
				End Select
				Exit For
			End If
		Next

		txtPricesales.Text = searchprice.ToString()

	End Sub

	Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
		dgvSalePrint.Rows.Clear()
		txtSubtotal.Text = ""
		txtIVA.Text = ""
		txtTotal.Text = ""
		txtPayment.Text = ""
		txtChange.Text = ""

	End Sub
	Public Shared Function AddTotalsSales(ByVal allSales(,) As Sales) As Decimal
		Dim totalVentas As Decimal = 0
		For i As Integer = 0 To allSales.GetLength(0) - 1
			For j As Integer = 0 To allSales.GetLength(1) - 1
				If allSales(i, j) IsNot Nothing Then
					totalVentas += allSales(i, j).CalculateTotalSale()
				End If
			Next
		Next
		Return totalVentas
	End Function

	Public Shared Sub CalculateIVA(ByVal totalventas As Decimal, ByVal txtIVA As TextBox)
		Dim iva As Decimal = totalventas * 0.16D
		txtIVA.Text = iva.ToString("F2")
	End Sub

	Private Sub btnExportinvoice_Click(sender As Object, e As EventArgs) Handles btnExportinvoice.Click

		Select Case cb_ExportInvoice.Text.ToUpper()
			Case "XML"
				Try
					Dim saveFileexport As New SaveFileDialog()
					saveFileexport.Filter = "XML files (*.xml)|*.xml"
					saveFileexport.Title = "Save file"
					If saveFileexport.ShowDialog() <> DialogResult.OK Then
						MessageBox.Show("No file selected")
						Return
					End If
					Dim filePathXML As String = saveFileexport.FileName
					Using xmlWriter As XmlWriter = XmlWriter.Create(filePathXML)
						xmlWriter.WriteStartDocument()
						xmlWriter.WriteStartElement("Sales")

						For Each row As DataGridViewRow In dgvSalePrint.Rows
							If Not row.IsNewRow Then
								xmlWriter.WriteStartElement("Sale")

								xmlWriter.WriteElementString("Size", If(row.Cells("Size").Value?.ToString(), String.Empty))
								xmlWriter.WriteElementString("Name", If(row.Cells("Name").Value?.ToString(), String.Empty))
								xmlWriter.WriteElementString("SalesOptions", If(row.Cells("SalesOptions").Value?.ToString(), String.Empty))

								Dim price As Double = 0.0
								Double.TryParse(row.Cells("Price").Value?.ToString(), price)
								xmlWriter.WriteElementString("Price", price.ToString("F2"))

								Dim quantity As Integer = 0
								Integer.TryParse(row.Cells("Quantity").Value?.ToString(), quantity)
								xmlWriter.WriteElementString("Quantity", quantity.ToString())

								Dim total As Double = 0.0
								Double.TryParse(row.Cells("Total").Value?.ToString(), total)
								xmlWriter.WriteElementString("Total", total.ToString("F2"))

								xmlWriter.WriteEndElement()
							End If
						Next

						xmlWriter.WriteStartElement("Summary")
						xmlWriter.WriteElementString("Subtotal", If(String.IsNullOrEmpty(txtSubtotal.Text), "0.00", txtSubtotal.Text))
						xmlWriter.WriteElementString("IVA", If(String.IsNullOrEmpty(txtIVA.Text), "0.00", txtIVA.Text))
						xmlWriter.WriteElementString("Total", If(String.IsNullOrEmpty(txtTotal.Text), "0.00", txtTotal.Text))
						xmlWriter.WriteEndElement()

						xmlWriter.WriteEndElement()
						xmlWriter.WriteEndDocument()
					End Using
					MessageBox.Show("File saved successfully!")
				Catch ex As Exception
					MessageBox.Show("An error occurred while saving the file: " & ex.Message)
				End Try

			Case "JSON"
				Dim saveFilejson As New SaveFileDialog()
				saveFilejson.Filter = "Json files (*.json)|*.json"
				saveFilejson.Title = "Save file"

				If saveFilejson.ShowDialog() <> DialogResult.OK Then
					MessageBox.Show("No file selected")
					Return
				End If
				Dim filePath As String = saveFilejson.FileName
				Dim salesList As New List(Of Object)()

				For Each row As DataGridViewRow In dgvSalePrint.Rows
					If Not row.IsNewRow Then
						Dim sale = New With {
					.Size = If(row.Cells("Size").Value?.ToString(), String.Empty),
					.Name = If(row.Cells("Name").Value?.ToString(), String.Empty),
					.SalesOptions = If(row.Cells("SalesOptions").Value?.ToString(), String.Empty),
					.Price = Convert.ToDouble(row.Cells("Price").Value),
					.Quantity = Convert.ToInt32(row.Cells("Quantity").Value),
					.Total = Convert.ToDouble(row.Cells("Total").Value)
				}

						Dim saleInfo As String = $"Size: {sale.Size}{Environment.NewLine}" &
										 $"Name: {sale.Name}{Environment.NewLine}" &
										 $"Sales Options: {sale.SalesOptions}{Environment.NewLine}" &
										 $"Price: {sale.Price}{Environment.NewLine}" &
										 $"Quantity: {sale.Quantity}{Environment.NewLine}" &
										 $"Total: {sale.Total}{Environment.NewLine}"

						salesList.Add(saleInfo)
					End If
				Next

				Dim jsonString As String = System.Text.Json.JsonSerializer.Serialize(salesList)
				File.WriteAllText(filePath, jsonString)

				MessageBox.Show("File successfully saved as JSON ")

			Case "PDF"
				Dim document As New Document()
				Dim saveFilePDF As New SaveFileDialog()
				saveFilePDF.Filter = "PDF files (*.PDF)|*.PDF"
				saveFilePDF.Title = "Save file"

				If saveFilePDF.ShowDialog() <> DialogResult.OK Then
					MessageBox.Show("No file selected")
					Return
				End If
				Dim filePathPDF As String = saveFilePDF.FileName
				Try
					PdfWriter.GetInstance(document, New FileStream(filePathPDF, FileMode.Create))
					document.Open()
					Dim table As New PdfPTable(dgvSalePrint.Columns.Count)
					For i As Integer = 0 To dgvSalePrint.Columns.Count - 1
						table.AddCell(New PdfPCell(New Phrase(dgvSalePrint.Columns(i).HeaderText)))
					Next


					For i As Integer = 0 To dgvSalePrint.Rows.Count - 1
						If Not dgvSalePrint.Rows(i).IsNewRow Then
							For j As Integer = 0 To dgvSalePrint.Columns.Count - 1
								table.AddCell(New PdfPCell(New Phrase(dgvSalePrint.Rows(i).Cells(j).Value.ToString())))
							Next
						End If
					Next
					table.AddCell("")
					table.AddCell("")
					table.AddCell("")
					table.AddCell("")
					table.AddCell("Total:")
					table.AddCell(txtTotal.Text)
					table.AddCell("")
					table.AddCell("")
					table.AddCell("")
					table.AddCell("")
					table.AddCell("IVA:")
					table.AddCell(txtIVA.Text)
					table.AddCell("")
					table.AddCell("")
					table.AddCell("")
					table.AddCell("")
					table.AddCell("Total Final:")
					table.AddCell(txtTotal.Text)

					document.Add(table)
					document.Close()

					MessageBox.Show("File saved successfully!")

				Catch ex As Exception
					MessageBox.Show("An error occurred while saving the file: " & ex.Message)
				End Try
			Case Else
				MessageBox.Show("No data entry")

		End Select





	End Sub
End Class

