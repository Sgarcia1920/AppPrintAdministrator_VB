<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaperRegister
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
		btnsavefilepaper = New FontAwesome.Sharp.IconButton()
		btnopenfilepaper = New FontAwesome.Sharp.IconButton()
		dgvPaperdata = New DataGridView()
		btndeletepaper = New FontAwesome.Sharp.IconButton()
		btnaddpaper = New FontAwesome.Sharp.IconButton()
		txtwhitesheetprice = New TextBox()
		label5 = New Label()
		txtpritingpricepaper = New TextBox()
		label4 = New Label()
		cbnamespaper = New ComboBox()
		cbsizepaper = New ComboBox()
		txtpackegepricepaper = New TextBox()
		label3 = New Label()
		label2 = New Label()
		label1 = New Label()
		CType(dgvPaperdata, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' btnsavefilepaper
		' 
		btnsavefilepaper.BackColor = Color.Teal
		btnsavefilepaper.FlatStyle = FlatStyle.Flat
		btnsavefilepaper.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnsavefilepaper.ForeColor = SystemColors.ButtonHighlight
		btnsavefilepaper.IconChar = FontAwesome.Sharp.IconChar.None
		btnsavefilepaper.IconColor = Color.Black
		btnsavefilepaper.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnsavefilepaper.Location = New Point(1052, 37)
		btnsavefilepaper.Name = "btnsavefilepaper"
		btnsavefilepaper.Size = New Size(221, 61)
		btnsavefilepaper.TabIndex = 35
		btnsavefilepaper.Text = "Save as txt"
		btnsavefilepaper.UseVisualStyleBackColor = False
		' 
		' btnopenfilepaper
		' 
		btnopenfilepaper.BackColor = Color.PowderBlue
		btnopenfilepaper.FlatStyle = FlatStyle.Flat
		btnopenfilepaper.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnopenfilepaper.ForeColor = SystemColors.ButtonHighlight
		btnopenfilepaper.IconChar = FontAwesome.Sharp.IconChar.None
		btnopenfilepaper.IconColor = Color.Black
		btnopenfilepaper.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnopenfilepaper.Location = New Point(598, 37)
		btnopenfilepaper.Name = "btnopenfilepaper"
		btnopenfilepaper.Size = New Size(221, 61)
		btnopenfilepaper.TabIndex = 34
		btnopenfilepaper.Text = "Open File "
		btnopenfilepaper.UseVisualStyleBackColor = False
		' 
		' dgvPaperdata
		' 
		dgvPaperdata.BackgroundColor = Color.LightBlue
		dgvPaperdata.BorderStyle = BorderStyle.None
		dgvPaperdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvPaperdata.Location = New Point(563, 116)
		dgvPaperdata.Name = "dgvPaperdata"
		dgvPaperdata.RowHeadersWidth = 51
		dgvPaperdata.Size = New Size(725, 589)
		dgvPaperdata.TabIndex = 33
		' 
		' btndeletepaper
		' 
		btndeletepaper.BackColor = Color.LightCoral
		btndeletepaper.FlatStyle = FlatStyle.Flat
		btndeletepaper.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btndeletepaper.ForeColor = SystemColors.ButtonHighlight
		btndeletepaper.IconChar = FontAwesome.Sharp.IconChar.None
		btndeletepaper.IconColor = Color.Black
		btndeletepaper.IconFont = FontAwesome.Sharp.IconFont.Auto
		btndeletepaper.Location = New Point(171, 644)
		btndeletepaper.Name = "btndeletepaper"
		btndeletepaper.Size = New Size(185, 49)
		btndeletepaper.TabIndex = 32
		btndeletepaper.Text = "Delete"
		btndeletepaper.UseVisualStyleBackColor = False
		' 
		' btnaddpaper
		' 
		btnaddpaper.BackColor = Color.LightGreen
		btnaddpaper.FlatStyle = FlatStyle.Flat
		btnaddpaper.Font = New Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnaddpaper.ForeColor = SystemColors.ButtonHighlight
		btnaddpaper.IconChar = FontAwesome.Sharp.IconChar.None
		btnaddpaper.IconColor = Color.Black
		btnaddpaper.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnaddpaper.Location = New Point(171, 582)
		btnaddpaper.Name = "btnaddpaper"
		btnaddpaper.Size = New Size(185, 49)
		btnaddpaper.TabIndex = 31
		btnaddpaper.Text = "Add"
		btnaddpaper.UseVisualStyleBackColor = False
		' 
		' txtwhitesheetprice
		' 
		txtwhitesheetprice.Font = New Font("Cambria", 16.2F)
		txtwhitesheetprice.Location = New Point(202, 506)
		txtwhitesheetprice.Name = "txtwhitesheetprice"
		txtwhitesheetprice.Size = New Size(249, 39)
		txtwhitesheetprice.TabIndex = 30
		' 
		' label5
		' 
		label5.AutoSize = True
		label5.Font = New Font("Cambria", 16.2F, FontStyle.Italic)
		label5.Location = New Point(44, 479)
		label5.Name = "label5"
		label5.Size = New Size(162, 66)
		label5.TabIndex = 29
		label5.Text = "White Sheet " & vbCrLf & "Price"
		' 
		' txtpritingpricepaper
		' 
		txtpritingpricepaper.Font = New Font("Cambria", 16.2F)
		txtpritingpricepaper.Location = New Point(202, 388)
		txtpritingpricepaper.Name = "txtpritingpricepaper"
		txtpritingpricepaper.Size = New Size(249, 39)
		txtpritingpricepaper.TabIndex = 28
		' 
		' label4
		' 
		label4.AutoSize = True
		label4.Font = New Font("Cambria", 16.2F, FontStyle.Italic)
		label4.Location = New Point(87, 361)
		label4.Name = "label4"
		label4.Size = New Size(119, 66)
		label4.TabIndex = 27
		label4.Text = "Printing " & vbCrLf & "Price"
		' 
		' cbnamespaper
		' 
		cbnamespaper.Font = New Font("Cambria", 16.2F)
		cbnamespaper.FormattingEnabled = True
		cbnamespaper.Items.AddRange(New Object() {"Couche Delgado", "Couche Grueso ", "Opalina", "Adhesivo", "Hoja de Máquina"})
		cbnamespaper.Location = New Point(203, 80)
		cbnamespaper.Name = "cbnamespaper"
		cbnamespaper.Size = New Size(248, 40)
		cbnamespaper.TabIndex = 26
		' 
		' cbsizepaper
		' 
		cbsizepaper.Font = New Font("Cambria", 16.2F)
		cbsizepaper.FormattingEnabled = True
		cbsizepaper.Items.AddRange(New Object() {"Separador Tabloide 12 x 18 pulgadas", "Tabloide 11 x 17 pulgadas", "Carta 8.5 x 11 pulgadas", "Oficio 8.5 x 14 pulgadas ", "A4 8.27 x 11.69 pulgadas"})
		cbsizepaper.Location = New Point(203, 162)
		cbsizepaper.Name = "cbsizepaper"
		cbsizepaper.Size = New Size(248, 40)
		cbsizepaper.TabIndex = 25
		' 
		' txtpackegepricepaper
		' 
		txtpackegepricepaper.Font = New Font("Cambria", 16.2F)
		txtpackegepricepaper.Location = New Point(202, 271)
		txtpackegepricepaper.Name = "txtpackegepricepaper"
		txtpackegepricepaper.Size = New Size(249, 39)
		txtpackegepricepaper.TabIndex = 24
		' 
		' label3
		' 
		label3.AutoSize = True
		label3.Font = New Font("Cambria", 16.2F, FontStyle.Italic)
		label3.Location = New Point(87, 244)
		label3.Name = "label3"
		label3.Size = New Size(115, 66)
		label3.TabIndex = 23
		label3.Text = "Package" & vbCrLf & "Price"
		' 
		' label2
		' 
		label2.AutoSize = True
		label2.Font = New Font("Cambria", 16.2F, FontStyle.Italic)
		label2.Location = New Point(124, 165)
		label2.Name = "label2"
		label2.Size = New Size(62, 33)
		label2.TabIndex = 22
		label2.Text = "Size"
		' 
		' label1
		' 
		label1.AutoSize = True
		label1.Font = New Font("Cambria", 16.2F, FontStyle.Italic)
		label1.Location = New Point(102, 83)
		label1.Name = "label1"
		label1.Size = New Size(84, 33)
		label1.TabIndex = 21
		label1.Text = "Name"
		' 
		' FrmPaperRegister
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.AliceBlue
		ClientSize = New Size(1332, 743)
		Controls.Add(btnsavefilepaper)
		Controls.Add(btnopenfilepaper)
		Controls.Add(dgvPaperdata)
		Controls.Add(btndeletepaper)
		Controls.Add(btnaddpaper)
		Controls.Add(txtwhitesheetprice)
		Controls.Add(label5)
		Controls.Add(txtpritingpricepaper)
		Controls.Add(label4)
		Controls.Add(cbnamespaper)
		Controls.Add(cbsizepaper)
		Controls.Add(txtpackegepricepaper)
		Controls.Add(label3)
		Controls.Add(label2)
		Controls.Add(label1)
		Name = "FrmPaperRegister"
		Text = "FrmPaperRegister"
		CType(dgvPaperdata, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Private WithEvents btnsavefilepaper As FontAwesome.Sharp.IconButton
	Private WithEvents btnopenfilepaper As FontAwesome.Sharp.IconButton
	Private WithEvents dgvPaperdata As DataGridView
	Private WithEvents btndeletepaper As FontAwesome.Sharp.IconButton
	Private WithEvents btnaddpaper As FontAwesome.Sharp.IconButton
	Private WithEvents txtwhitesheetprice As TextBox
	Private WithEvents label5 As Label
	Private WithEvents txtpritingpricepaper As TextBox
	Private WithEvents label4 As Label
	Private WithEvents cbnamespaper As ComboBox
	Private WithEvents cbsizepaper As ComboBox
	Private WithEvents txtpackegepricepaper As TextBox
	Private WithEvents label3 As Label
	Private WithEvents label2 As Label
	Private WithEvents label1 As Label
End Class
