<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrinterRegistration
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
		btnsearchpricesPrinter = New FontAwesome.Sharp.IconButton()
		cbTypeprinter = New ComboBox()
		label6 = New Label()
		btnSavewordprinter = New Button()
		btnDeleteprinter = New FontAwesome.Sharp.IconButton()
		btnAddprinter = New FontAwesome.Sharp.IconButton()
		dvgprinter = New DataGridView()
		cbconditionprinter = New ComboBox()
		label7 = New Label()
		txtdescripcion = New TextBox()
		label5 = New Label()
		txtsaleprice = New TextBox()
		txtrentprice = New TextBox()
		label3 = New Label()
		label4 = New Label()
		txtserienumber = New TextBox()
		label2 = New Label()
		txtbrand = New TextBox()
		label1 = New Label()
		CType(dvgprinter, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' btnsearchpricesPrinter
		' 
		btnsearchpricesPrinter.BackColor = Color.LightYellow
		btnsearchpricesPrinter.ForeColor = SystemColors.ButtonHighlight
		btnsearchpricesPrinter.IconChar = FontAwesome.Sharp.IconChar.Search
		btnsearchpricesPrinter.IconColor = Color.Goldenrod
		btnsearchpricesPrinter.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnsearchpricesPrinter.IconSize = 30
		btnsearchpricesPrinter.Location = New Point(413, 169)
		btnsearchpricesPrinter.Name = "btnsearchpricesPrinter"
		btnsearchpricesPrinter.Size = New Size(41, 35)
		btnsearchpricesPrinter.TabIndex = 44
		btnsearchpricesPrinter.UseVisualStyleBackColor = False
		' 
		' cbTypeprinter
		' 
		cbTypeprinter.Font = New Font("Cambria", 13.8F)
		cbTypeprinter.FormattingEnabled = True
		cbTypeprinter.Items.AddRange(New Object() {"Phaser", "Workcenter", "VersaLink"})
		cbTypeprinter.Location = New Point(158, 101)
		cbTypeprinter.Name = "cbTypeprinter"
		cbTypeprinter.Size = New Size(249, 35)
		cbTypeprinter.TabIndex = 43
		' 
		' label6
		' 
		label6.AutoSize = True
		label6.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label6.Location = New Point(86, 104)
		label6.Name = "label6"
		label6.Size = New Size(59, 27)
		label6.TabIndex = 42
		label6.Text = "Type"
		label6.TextAlign = ContentAlignment.TopCenter
		' 
		' btnSavewordprinter
		' 
		btnSavewordprinter.BackColor = Color.Teal
		btnSavewordprinter.FlatAppearance.BorderColor = Color.White
		btnSavewordprinter.FlatStyle = FlatStyle.Flat
		btnSavewordprinter.Font = New Font("Cambria", 13.8F, FontStyle.Bold)
		btnSavewordprinter.ForeColor = SystemColors.ButtonHighlight
		btnSavewordprinter.Location = New Point(782, 603)
		btnSavewordprinter.Name = "btnSavewordprinter"
		btnSavewordprinter.Size = New Size(233, 66)
		btnSavewordprinter.TabIndex = 41
		btnSavewordprinter.Text = "Save printer word"
		btnSavewordprinter.UseVisualStyleBackColor = False
		' 
		' btnDeleteprinter
		' 
		btnDeleteprinter.BackColor = Color.LightCoral
		btnDeleteprinter.Font = New Font("Cambria", 13.8F, FontStyle.Bold)
		btnDeleteprinter.ForeColor = SystemColors.ButtonHighlight
		btnDeleteprinter.IconChar = FontAwesome.Sharp.IconChar.None
		btnDeleteprinter.IconColor = Color.Black
		btnDeleteprinter.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnDeleteprinter.Location = New Point(256, 650)
		btnDeleteprinter.Name = "btnDeleteprinter"
		btnDeleteprinter.Size = New Size(166, 50)
		btnDeleteprinter.TabIndex = 40
		btnDeleteprinter.Text = "Delete"
		btnDeleteprinter.UseVisualStyleBackColor = False
		' 
		' btnAddprinter
		' 
		btnAddprinter.BackColor = Color.LightGreen
		btnAddprinter.Font = New Font("Cambria", 13.8F, FontStyle.Bold)
		btnAddprinter.ForeColor = SystemColors.ButtonHighlight
		btnAddprinter.IconChar = FontAwesome.Sharp.IconChar.None
		btnAddprinter.IconColor = Color.Black
		btnAddprinter.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnAddprinter.Location = New Point(69, 650)
		btnAddprinter.Name = "btnAddprinter"
		btnAddprinter.Size = New Size(166, 50)
		btnAddprinter.TabIndex = 39
		btnAddprinter.Text = "Add"
		btnAddprinter.UseVisualStyleBackColor = False
		' 
		' dvgprinter
		' 
		dvgprinter.BackgroundColor = Color.LightBlue
		dvgprinter.BorderStyle = BorderStyle.None
		dvgprinter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dvgprinter.Location = New Point(531, 42)
		dvgprinter.Name = "dvgprinter"
		dvgprinter.RowHeadersWidth = 51
		dvgprinter.Size = New Size(748, 530)
		dvgprinter.TabIndex = 38
		' 
		' cbconditionprinter
		' 
		cbconditionprinter.Font = New Font("Cambria", 13.8F)
		cbconditionprinter.FormattingEnabled = True
		cbconditionprinter.Items.AddRange(New Object() {"Completely new", "Used", "Damaged", "Unusable"})
		cbconditionprinter.Location = New Point(158, 388)
		cbconditionprinter.Name = "cbconditionprinter"
		cbconditionprinter.Size = New Size(256, 35)
		cbconditionprinter.TabIndex = 37
		' 
		' label7
		' 
		label7.AutoSize = True
		label7.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label7.Location = New Point(53, 391)
		label7.Name = "label7"
		label7.Size = New Size(104, 27)
		label7.TabIndex = 36
		label7.Text = "Condition"
		label7.TextAlign = ContentAlignment.TopCenter
		' 
		' txtdescripcion
		' 
		txtdescripcion.Font = New Font("Cambria", 13.8F)
		txtdescripcion.Location = New Point(53, 478)
		txtdescripcion.Multiline = True
		txtdescripcion.Name = "txtdescripcion"
		txtdescripcion.Size = New Size(416, 151)
		txtdescripcion.TabIndex = 35
		' 
		' label5
		' 
		label5.AutoSize = True
		label5.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label5.Location = New Point(103, 448)
		label5.Name = "label5"
		label5.Size = New Size(319, 27)
		label5.TabIndex = 34
		label5.Text = "Physical condition observations "
		label5.TextAlign = ContentAlignment.TopCenter
		' 
		' txtsaleprice
		' 
		txtsaleprice.Enabled = False
		txtsaleprice.Font = New Font("Cambria", 13.8F)
		txtsaleprice.Location = New Point(158, 239)
		txtsaleprice.Name = "txtsaleprice"
		txtsaleprice.ReadOnly = True
		txtsaleprice.Size = New Size(249, 34)
		txtsaleprice.TabIndex = 33
		' 
		' txtrentprice
		' 
		txtrentprice.Enabled = False
		txtrentprice.Font = New Font("Cambria", 13.8F)
		txtrentprice.Location = New Point(160, 325)
		txtrentprice.Name = "txtrentprice"
		txtrentprice.ReadOnly = True
		txtrentprice.Size = New Size(247, 34)
		txtrentprice.TabIndex = 32
		' 
		' label3
		' 
		label3.AutoSize = True
		label3.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label3.Location = New Point(86, 305)
		label3.Name = "label3"
		label3.Size = New Size(61, 54)
		label3.TabIndex = 31
		label3.Text = "Rent" & vbCrLf & "Price"
		label3.TextAlign = ContentAlignment.TopCenter
		' 
		' label4
		' 
		label4.AutoSize = True
		label4.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label4.Location = New Point(85, 219)
		label4.Name = "label4"
		label4.Size = New Size(61, 54)
		label4.TabIndex = 30
		label4.Text = "Sale" & vbCrLf & "Price"
		label4.TextAlign = ContentAlignment.TopCenter
		' 
		' txtserienumber
		' 
		txtserienumber.Font = New Font("Cambria", 13.8F)
		txtserienumber.Location = New Point(160, 170)
		txtserienumber.Name = "txtserienumber"
		txtserienumber.Size = New Size(247, 34)
		txtserienumber.TabIndex = 29
		' 
		' label2
		' 
		label2.AutoSize = True
		label2.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label2.Location = New Point(90, 173)
		label2.Name = "label2"
		label2.Size = New Size(60, 27)
		label2.TabIndex = 28
		label2.Text = "Serie"
		label2.TextAlign = ContentAlignment.TopCenter
		' 
		' txtbrand
		' 
		txtbrand.Enabled = False
		txtbrand.Font = New Font("Cambria", 13.8F)
		txtbrand.ForeColor = Color.Red
		txtbrand.Location = New Point(158, 42)
		txtbrand.Name = "txtbrand"
		txtbrand.ReadOnly = True
		txtbrand.Size = New Size(249, 34)
		txtbrand.TabIndex = 27
		' 
		' label1
		' 
		label1.AutoSize = True
		label1.Font = New Font("Cambria", 13.8F, FontStyle.Italic)
		label1.Location = New Point(79, 42)
		label1.Name = "label1"
		label1.Size = New Size(71, 27)
		label1.TabIndex = 26
		label1.Text = "Brand"
		label1.TextAlign = ContentAlignment.TopCenter
		' 
		' PrinterRegistration
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.AliceBlue
		ClientSize = New Size(1332, 743)
		Controls.Add(btnsearchpricesPrinter)
		Controls.Add(cbTypeprinter)
		Controls.Add(label6)
		Controls.Add(btnSavewordprinter)
		Controls.Add(btnDeleteprinter)
		Controls.Add(btnAddprinter)
		Controls.Add(dvgprinter)
		Controls.Add(cbconditionprinter)
		Controls.Add(label7)
		Controls.Add(txtdescripcion)
		Controls.Add(label5)
		Controls.Add(txtsaleprice)
		Controls.Add(txtrentprice)
		Controls.Add(label3)
		Controls.Add(label4)
		Controls.Add(txtserienumber)
		Controls.Add(label2)
		Controls.Add(txtbrand)
		Controls.Add(label1)
		Name = "PrinterRegistration"
		Text = "PrinterRegistration"
		CType(dvgprinter, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Private WithEvents btnsearchpricesPrinter As FontAwesome.Sharp.IconButton
	Private WithEvents cbTypeprinter As ComboBox
	Private WithEvents label6 As Label
	Private WithEvents btnSavewordprinter As Button
	Private WithEvents btnDeleteprinter As FontAwesome.Sharp.IconButton
	Private WithEvents btnAddprinter As FontAwesome.Sharp.IconButton
	Private WithEvents dvgprinter As DataGridView
	Private WithEvents cbconditionprinter As ComboBox
	Private WithEvents label7 As Label
	Private WithEvents txtdescripcion As TextBox
	Private WithEvents label5 As Label
	Private WithEvents txtsaleprice As TextBox
	Private WithEvents txtrentprice As TextBox
	Private WithEvents label3 As Label
	Private WithEvents label4 As Label
	Private WithEvents txtserienumber As TextBox
	Private WithEvents label2 As Label
	Private WithEvents txtbrand As TextBox
	Private WithEvents label1 As Label
End Class
