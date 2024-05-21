<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalePrints
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		btnExportpdfXML = New Button()
		txtChange = New TextBox()
		btnExporttxtpaper = New Button()
		btnclearcontrols = New Button()
		btnpricepaper = New FontAwesome.Sharp.IconButton()
		btnsearchAvailablepaper = New FontAwesome.Sharp.IconButton()
		btncancel_purchase = New Button()
		btncalculate = New Button()
		label9 = New Label()
		txtPayment = New TextBox()
		label10 = New Label()
		txtTotal = New TextBox()
		label8 = New Label()
		txtIVA = New TextBox()
		label7 = New Label()
		txtSubtotal = New TextBox()
		label6 = New Label()
		txtNumberPrints = New TextBox()
		btnreset = New FontAwesome.Sharp.IconButton()
		btnAddsales = New Button()
		dgvSalePrint = New DataGridView()
		groupBox2 = New GroupBox()
		btnexportsalesexcel = New Button()
		groupBox1 = New GroupBox()
		label1 = New Label()
		label5 = New Label()
		cbsize = New ComboBox()
		txtPricesales = New TextBox()
		label2 = New Label()
		label3 = New Label()
		cbAvailablepaper = New ComboBox()
		cbSalesOptions = New ComboBox()
		label4 = New Label()
		CType(dgvSalePrint, ComponentModel.ISupportInitialize).BeginInit()
		groupBox2.SuspendLayout()
		groupBox1.SuspendLayout()
		SuspendLayout()
		' 
		' btnExportpdfXML
		' 
		btnExportpdfXML.BackColor = Color.DarkSalmon
		btnExportpdfXML.Font = New Font("Cambria", 13.8F, FontStyle.Bold)
		btnExportpdfXML.ForeColor = SystemColors.ButtonHighlight
		btnExportpdfXML.Location = New Point(154, 412)
		btnExportpdfXML.Name = "btnExportpdfXML"
		btnExportpdfXML.Size = New Size(223, 64)
		btnExportpdfXML.TabIndex = 13
		btnExportpdfXML.Text = "Export Invoice"
		btnExportpdfXML.UseVisualStyleBackColor = False
		' 
		' txtChange
		' 
		txtChange.Font = New Font("Cambria", 10.2F)
		txtChange.Location = New Point(205, 270)
		txtChange.Name = "txtChange"
		txtChange.ReadOnly = True
		txtChange.Size = New Size(186, 27)
		txtChange.TabIndex = 21
		' 
		' btnExporttxtpaper
		' 
		btnExporttxtpaper.BackColor = Color.SteelBlue
		btnExporttxtpaper.FlatStyle = FlatStyle.Flat
		btnExporttxtpaper.Font = New Font("Cambria", 12F, FontStyle.Bold)
		btnExporttxtpaper.ForeColor = SystemColors.ButtonHighlight
		btnExporttxtpaper.Location = New Point(551, 249)
		btnExporttxtpaper.Name = "btnExporttxtpaper"
		btnExporttxtpaper.Size = New Size(167, 64)
		btnExporttxtpaper.TabIndex = 16
		btnExporttxtpaper.Text = "Extract Paper" & vbCrLf & "Database"
		btnExporttxtpaper.UseVisualStyleBackColor = False
		' 
		' btnclearcontrols
		' 
		btnclearcontrols.BackColor = Color.LightSkyBlue
		btnclearcontrols.FlatStyle = FlatStyle.Flat
		btnclearcontrols.Font = New Font("Cambria", 12F, FontStyle.Bold)
		btnclearcontrols.ForeColor = SystemColors.ButtonHighlight
		btnclearcontrols.Location = New Point(369, 249)
		btnclearcontrols.Name = "btnclearcontrols"
		btnclearcontrols.Size = New Size(171, 64)
		btnclearcontrols.TabIndex = 18
		btnclearcontrols.Text = "Clear"
		btnclearcontrols.UseVisualStyleBackColor = False
		' 
		' btnpricepaper
		' 
		btnpricepaper.BackColor = Color.LightYellow
		btnpricepaper.IconChar = FontAwesome.Sharp.IconChar.Search
		btnpricepaper.IconColor = Color.Goldenrod
		btnpricepaper.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnpricepaper.IconSize = 30
		btnpricepaper.Location = New Point(639, 38)
		btnpricepaper.Name = "btnpricepaper"
		btnpricepaper.Size = New Size(41, 35)
		btnpricepaper.TabIndex = 17
		btnpricepaper.UseVisualStyleBackColor = False
		' 
		' btnsearchAvailablepaper
		' 
		btnsearchAvailablepaper.BackColor = Color.LightYellow
		btnsearchAvailablepaper.IconChar = FontAwesome.Sharp.IconChar.Search
		btnsearchAvailablepaper.IconColor = Color.Goldenrod
		btnsearchAvailablepaper.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnsearchAvailablepaper.IconSize = 30
		btnsearchAvailablepaper.Location = New Point(309, 111)
		btnsearchAvailablepaper.Name = "btnsearchAvailablepaper"
		btnsearchAvailablepaper.Size = New Size(41, 35)
		btnsearchAvailablepaper.TabIndex = 16
		btnsearchAvailablepaper.UseVisualStyleBackColor = False
		' 
		' btncancel_purchase
		' 
		btncancel_purchase.BackColor = Color.IndianRed
		btncancel_purchase.FlatStyle = FlatStyle.Flat
		btncancel_purchase.Font = New Font("Cambria", 12F, FontStyle.Bold)
		btncancel_purchase.ForeColor = SystemColors.ButtonHighlight
		btncancel_purchase.Location = New Point(186, 250)
		btncancel_purchase.Name = "btncancel_purchase"
		btncancel_purchase.Size = New Size(171, 64)
		btncancel_purchase.TabIndex = 15
		btncancel_purchase.Text = "Cancel purchase"
		btncancel_purchase.UseVisualStyleBackColor = False
		' 
		' btncalculate
		' 
		btncalculate.BackColor = Color.Firebrick
		btncalculate.Font = New Font("Cambria", 13.8F, FontStyle.Bold)
		btncalculate.ForeColor = SystemColors.ButtonHighlight
		btncalculate.Location = New Point(154, 333)
		btncalculate.Name = "btncalculate"
		btncalculate.Size = New Size(223, 64)
		btncalculate.TabIndex = 17
		btncalculate.Text = "Calculate"
		btncalculate.UseVisualStyleBackColor = False
		' 
		' label9
		' 
		label9.AutoSize = True
		label9.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label9.Location = New Point(115, 270)
		label9.Name = "label9"
		label9.Size = New Size(83, 27)
		label9.TabIndex = 20
		label9.Text = "Change"
		' 
		' txtPayment
		' 
		txtPayment.Font = New Font("Cambria", 10.2F)
		txtPayment.Location = New Point(205, 221)
		txtPayment.Name = "txtPayment"
		txtPayment.Size = New Size(186, 27)
		txtPayment.TabIndex = 19
		' 
		' label10
		' 
		label10.AutoSize = True
		label10.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label10.Location = New Point(44, 221)
		label10.Name = "label10"
		label10.Size = New Size(156, 27)
		label10.TabIndex = 18
		label10.Text = "Payment in full"
		' 
		' txtTotal
		' 
		txtTotal.Font = New Font("Cambria", 10.2F)
		txtTotal.Location = New Point(202, 168)
		txtTotal.Name = "txtTotal"
		txtTotal.ReadOnly = True
		txtTotal.Size = New Size(186, 27)
		txtTotal.TabIndex = 17
		' 
		' label8
		' 
		label8.AutoSize = True
		label8.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label8.Location = New Point(139, 172)
		label8.Name = "label8"
		label8.Size = New Size(61, 27)
		label8.TabIndex = 16
		label8.Text = "Total"
		' 
		' txtIVA
		' 
		txtIVA.Font = New Font("Cambria", 10.2F)
		txtIVA.Location = New Point(202, 120)
		txtIVA.Name = "txtIVA"
		txtIVA.ReadOnly = True
		txtIVA.Size = New Size(186, 27)
		txtIVA.TabIndex = 15
		' 
		' label7
		' 
		label7.AutoSize = True
		label7.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label7.Location = New Point(154, 124)
		label7.Name = "label7"
		label7.Size = New Size(44, 27)
		label7.TabIndex = 14
		label7.Text = "IVA"
		' 
		' txtSubtotal
		' 
		txtSubtotal.Font = New Font("Cambria", 10.2F)
		txtSubtotal.Location = New Point(205, 72)
		txtSubtotal.Name = "txtSubtotal"
		txtSubtotal.ReadOnly = True
		txtSubtotal.Size = New Size(186, 27)
		txtSubtotal.TabIndex = 13
		' 
		' label6
		' 
		label6.AutoSize = True
		label6.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label6.Location = New Point(105, 72)
		label6.Name = "label6"
		label6.Size = New Size(93, 27)
		label6.TabIndex = 12
		label6.Text = "Subtotal"
		' 
		' txtNumberPrints
		' 
		txtNumberPrints.Font = New Font("Cambria", 10.2F)
		txtNumberPrints.Location = New Point(462, 116)
		txtNumberPrints.Name = "txtNumberPrints"
		txtNumberPrints.Size = New Size(186, 27)
		txtNumberPrints.TabIndex = 9
		' 
		' btnreset
		' 
		btnreset.BackColor = Color.LightYellow
		btnreset.IconChar = FontAwesome.Sharp.IconChar.Redo
		btnreset.IconColor = Color.LightCoral
		btnreset.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnreset.Location = New Point(779, 284)
		btnreset.Name = "btnreset"
		btnreset.Size = New Size(61, 51)
		btnreset.TabIndex = 23
		btnreset.UseVisualStyleBackColor = False
		' 
		' btnAddsales
		' 
		btnAddsales.BackColor = Color.LightGreen
		btnAddsales.FlatStyle = FlatStyle.Flat
		btnAddsales.Font = New Font("Cambria", 12F, FontStyle.Bold)
		btnAddsales.ForeColor = SystemColors.ButtonHighlight
		btnAddsales.Location = New Point(9, 249)
		btnAddsales.Name = "btnAddsales"
		btnAddsales.Size = New Size(171, 64)
		btnAddsales.TabIndex = 14
		btnAddsales.Text = "Add"
		btnAddsales.UseVisualStyleBackColor = False
		' 
		' dgvSalePrint
		' 
		dgvSalePrint.BackgroundColor = Color.LightBlue
		dgvSalePrint.BorderStyle = BorderStyle.None
		dgvSalePrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvSalePrint.Location = New Point(12, 341)
		dgvSalePrint.Name = "dgvSalePrint"
		dgvSalePrint.RowHeadersWidth = 51
		dgvSalePrint.Size = New Size(832, 390)
		dgvSalePrint.TabIndex = 22
		' 
		' groupBox2
		' 
		groupBox2.Controls.Add(btnexportsalesexcel)
		groupBox2.Controls.Add(btnExportpdfXML)
		groupBox2.Controls.Add(btncalculate)
		groupBox2.Controls.Add(txtChange)
		groupBox2.Controls.Add(label9)
		groupBox2.Controls.Add(txtPayment)
		groupBox2.Controls.Add(label10)
		groupBox2.Controls.Add(txtTotal)
		groupBox2.Controls.Add(label8)
		groupBox2.Controls.Add(txtIVA)
		groupBox2.Controls.Add(label7)
		groupBox2.Controls.Add(txtSubtotal)
		groupBox2.Controls.Add(label6)
		groupBox2.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		groupBox2.ForeColor = Color.DarkRed
		groupBox2.Location = New Point(850, 21)
		groupBox2.Name = "groupBox2"
		groupBox2.Size = New Size(470, 710)
		groupBox2.TabIndex = 21
		groupBox2.TabStop = False
		groupBox2.Text = "Payment"
		' 
		' btnexportsalesexcel
		' 
		btnexportsalesexcel.BackColor = Color.YellowGreen
		btnexportsalesexcel.Font = New Font("Cambria", 13.8F, FontStyle.Bold)
		btnexportsalesexcel.ForeColor = SystemColors.ButtonHighlight
		btnexportsalesexcel.Location = New Point(154, 496)
		btnexportsalesexcel.Name = "btnexportsalesexcel"
		btnexportsalesexcel.Size = New Size(223, 64)
		btnexportsalesexcel.TabIndex = 22
		btnexportsalesexcel.Text = "Export Sales"
		btnexportsalesexcel.UseVisualStyleBackColor = False
		' 
		' groupBox1
		' 
		groupBox1.Controls.Add(btnExporttxtpaper)
		groupBox1.Controls.Add(btnclearcontrols)
		groupBox1.Controls.Add(btnpricepaper)
		groupBox1.Controls.Add(btnsearchAvailablepaper)
		groupBox1.Controls.Add(btncancel_purchase)
		groupBox1.Controls.Add(txtNumberPrints)
		groupBox1.Controls.Add(btnAddsales)
		groupBox1.Controls.Add(label1)
		groupBox1.Controls.Add(label5)
		groupBox1.Controls.Add(cbsize)
		groupBox1.Controls.Add(txtPricesales)
		groupBox1.Controls.Add(label2)
		groupBox1.Controls.Add(label3)
		groupBox1.Controls.Add(cbAvailablepaper)
		groupBox1.Controls.Add(cbSalesOptions)
		groupBox1.Controls.Add(label4)
		groupBox1.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		groupBox1.ForeColor = Color.DarkBlue
		groupBox1.Location = New Point(23, 12)
		groupBox1.Name = "groupBox1"
		groupBox1.Size = New Size(750, 323)
		groupBox1.TabIndex = 20
		groupBox1.TabStop = False
		groupBox1.Text = "Register Sale"
		' 
		' label1
		' 
		label1.AutoSize = True
		label1.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label1.Location = New Point(62, 41)
		label1.Name = "label1"
		label1.Size = New Size(50, 27)
		label1.TabIndex = 0
		label1.Text = "Size"
		' 
		' label5
		' 
		label5.AutoSize = True
		label5.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label5.Location = New Point(365, 116)
		label5.Name = "label5"
		label5.Size = New Size(95, 27)
		label5.TabIndex = 8
		label5.Text = "Quantity"
		' 
		' cbsize
		' 
		cbsize.Font = New Font("Cambria", 10.2F)
		cbsize.FormattingEnabled = True
		cbsize.Items.AddRange(New Object() {"Separador Tabloide 12 x 18 pulgadas", "Tabloide 11 x 17 pulgadas", "Carta 8.5 x 11 pulgadas", "Oficio 8.5 x 14 pulgadas ", "A4 8.27 x 11.69 pulgadas"})
		cbsize.Location = New Point(117, 42)
		cbsize.Name = "cbsize"
		cbsize.Size = New Size(186, 28)
		cbsize.TabIndex = 1
		' 
		' txtPricesales
		' 
		txtPricesales.Font = New Font("Cambria", 10.2F)
		txtPricesales.Location = New Point(447, 42)
		txtPricesales.Name = "txtPricesales"
		txtPricesales.ReadOnly = True
		txtPricesales.Size = New Size(186, 27)
		txtPricesales.TabIndex = 7
		' 
		' label2
		' 
		label2.AutoSize = True
		label2.BackColor = Color.Transparent
		label2.Font = New Font("Cambria", 13F, FontStyle.Italic)
		label2.Location = New Point(10, 94)
		label2.Name = "label2"
		label2.Size = New Size(102, 52)
		label2.TabIndex = 2
		label2.Text = "Available " & vbCrLf & "Paper"
		' 
		' label3
		' 
		label3.AutoSize = True
		label3.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label3.Location = New Point(378, 42)
		label3.Name = "label3"
		label3.Size = New Size(61, 27)
		label3.TabIndex = 6
		label3.Text = "Price"
		' 
		' cbAvailablepaper
		' 
		cbAvailablepaper.Font = New Font("Cambria", 10.2F)
		cbAvailablepaper.FormattingEnabled = True
		cbAvailablepaper.Location = New Point(117, 114)
		cbAvailablepaper.Name = "cbAvailablepaper"
		cbAvailablepaper.Size = New Size(186, 28)
		cbAvailablepaper.TabIndex = 3
		' 
		' cbSalesOptions
		' 
		cbSalesOptions.Font = New Font("Cambria", 10.2F)
		cbSalesOptions.FormattingEnabled = True
		cbSalesOptions.Items.AddRange(New Object() {"Pricepacket", "Priceprint", "WhitesheetPrice"})
		cbSalesOptions.Location = New Point(117, 181)
		cbSalesOptions.Name = "cbSalesOptions"
		cbSalesOptions.Size = New Size(186, 28)
		cbSalesOptions.TabIndex = 5
		' 
		' label4
		' 
		label4.AutoSize = True
		label4.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label4.Location = New Point(27, 174)
		label4.Name = "label4"
		label4.Size = New Size(85, 54)
		label4.TabIndex = 4
		label4.Text = "Sales " & vbCrLf & "Options"
		' 
		' SalePrints
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.AliceBlue
		ClientSize = New Size(1332, 743)
		Controls.Add(btnreset)
		Controls.Add(dgvSalePrint)
		Controls.Add(groupBox2)
		Controls.Add(groupBox1)
		Name = "SalePrints"
		Text = "SalePrints"
		CType(dgvSalePrint, ComponentModel.ISupportInitialize).EndInit()
		groupBox2.ResumeLayout(False)
		groupBox2.PerformLayout()
		groupBox1.ResumeLayout(False)
		groupBox1.PerformLayout()
		ResumeLayout(False)
	End Sub

	Private WithEvents btnExportpdfXML As Button
	Private WithEvents txtChange As TextBox
	Private WithEvents btnExporttxtpaper As Button
	Private WithEvents btnclearcontrols As Button
	Private WithEvents btnpricepaper As FontAwesome.Sharp.IconButton
	Private WithEvents btnsearchAvailablepaper As FontAwesome.Sharp.IconButton
	Private WithEvents btncancel_purchase As Button
	Private WithEvents btncalculate As Button
	Private WithEvents label9 As Label
	Private WithEvents txtPayment As TextBox
	Private WithEvents label10 As Label
	Private WithEvents txtTotal As TextBox
	Private WithEvents label8 As Label
	Private WithEvents txtIVA As TextBox
	Private WithEvents label7 As Label
	Private WithEvents txtSubtotal As TextBox
	Private WithEvents label6 As Label
	Private WithEvents txtNumberPrints As TextBox
	Private WithEvents btnreset As FontAwesome.Sharp.IconButton
	Private WithEvents btnAddsales As Button
	Private WithEvents dgvSalePrint As DataGridView
	Private WithEvents groupBox2 As GroupBox
	Private WithEvents btnexportsalesexcel As Button
	Private WithEvents groupBox1 As GroupBox
	Private WithEvents label1 As Label
	Private WithEvents label5 As Label
	Private WithEvents cbsize As ComboBox
	Private WithEvents txtPricesales As TextBox
	Private WithEvents label2 As Label
	Private WithEvents label3 As Label
	Private WithEvents cbAvailablepaper As ComboBox
	Private WithEvents cbSalesOptions As ComboBox
	Private WithEvents label4 As Label
End Class
