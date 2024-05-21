<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		btn_notes = New FontAwesome.Sharp.IconButton()
		btnSales_print = New FontAwesome.Sharp.IconButton()
		btnPrinter_registration = New FontAwesome.Sharp.IconButton()
		btnPaper_register = New FontAwesome.Sharp.IconButton()
		SuspendLayout()
		' 
		' btn_notes
		' 
		btn_notes.BackColor = Color.DarkGray
		btn_notes.FlatStyle = FlatStyle.Flat
		btn_notes.Font = New Font("Cambria", 16.2F, FontStyle.Bold)
		btn_notes.ForeColor = SystemColors.ButtonHighlight
		btn_notes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
		btn_notes.IconColor = SystemColors.ButtonHighlight
		btn_notes.IconFont = FontAwesome.Sharp.IconFont.Auto
		btn_notes.Location = New Point(164, 285)
		btn_notes.Name = "btn_notes"
		btn_notes.Size = New Size(298, 121)
		btn_notes.TabIndex = 9
		btn_notes.Text = "Notes"
		btn_notes.TextImageRelation = TextImageRelation.ImageBeforeText
		btn_notes.UseVisualStyleBackColor = False
		' 
		' btnSales_print
		' 
		btnSales_print.BackColor = Color.MediumAquamarine
		btnSales_print.FlatStyle = FlatStyle.Flat
		btnSales_print.Font = New Font("Cambria", 16.2F, FontStyle.Bold)
		btnSales_print.ForeColor = Color.Ivory
		btnSales_print.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
		btnSales_print.IconColor = Color.Ivory
		btnSales_print.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnSales_print.Location = New Point(164, 125)
		btnSales_print.Name = "btnSales_print"
		btnSales_print.Size = New Size(298, 121)
		btnSales_print.TabIndex = 8
		btnSales_print.Text = "Sale of Prints "
		btnSales_print.TextImageRelation = TextImageRelation.ImageBeforeText
		btnSales_print.UseVisualStyleBackColor = False
		' 
		' btnPrinter_registration
		' 
		btnPrinter_registration.BackColor = Color.CornflowerBlue
		btnPrinter_registration.FlatStyle = FlatStyle.Flat
		btnPrinter_registration.Font = New Font("Cambria", 16.2F, FontStyle.Bold)
		btnPrinter_registration.ForeColor = Color.MintCream
		btnPrinter_registration.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
		btnPrinter_registration.IconColor = Color.WhiteSmoke
		btnPrinter_registration.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnPrinter_registration.Location = New Point(501, 125)
		btnPrinter_registration.Name = "btnPrinter_registration"
		btnPrinter_registration.Size = New Size(298, 121)
		btnPrinter_registration.TabIndex = 7
		btnPrinter_registration.Text = "Printer registration"
		btnPrinter_registration.TextImageRelation = TextImageRelation.ImageBeforeText
		btnPrinter_registration.UseVisualStyleBackColor = False
		' 
		' btnPaper_register
		' 
		btnPaper_register.BackColor = Color.LightGray
		btnPaper_register.FlatAppearance.BorderColor = Color.White
		btnPaper_register.FlatStyle = FlatStyle.Flat
		btnPaper_register.Font = New Font("Cambria", 16.2F, FontStyle.Bold)
		btnPaper_register.ForeColor = SystemColors.ButtonHighlight
		btnPaper_register.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
		btnPaper_register.IconColor = SystemColors.ButtonHighlight
		btnPaper_register.IconFont = FontAwesome.Sharp.IconFont.Auto
		btnPaper_register.Location = New Point(501, 285)
		btnPaper_register.Name = "btnPaper_register"
		btnPaper_register.Size = New Size(298, 121)
		btnPaper_register.TabIndex = 6
		btnPaper_register.Text = "Paper Register"
		btnPaper_register.TextImageRelation = TextImageRelation.ImageBeforeText
		btnPaper_register.UseVisualStyleBackColor = False
		' 
		' FrmMenu
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(982, 553)
		Controls.Add(btn_notes)
		Controls.Add(btnSales_print)
		Controls.Add(btnPrinter_registration)
		Controls.Add(btnPaper_register)
		Name = "FrmMenu"
		Text = "Form1"
		ResumeLayout(False)
	End Sub

	Private WithEvents btn_notes As FontAwesome.Sharp.IconButton
	Private WithEvents btnSales_print As FontAwesome.Sharp.IconButton
	Private WithEvents btnPrinter_registration As FontAwesome.Sharp.IconButton
	Private WithEvents btnPaper_register As FontAwesome.Sharp.IconButton

End Class
