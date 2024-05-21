Public Class FrmMenu
	Public Sub New()
		InitializeComponent()
		ShowWelcomeMessage()
	End Sub

	Private Sub btnPrinter_registration_Click(sender As Object, e As EventArgs) Handles btnPrinter_registration.Click
		If Application.OpenForms.OfType(Of PrinterRegistration)().Count() = 0 Then
			Dim FrmprinterRegistration As New PrinterRegistration()
			PrinterRegistration.Show()
		End If

	End Sub

	Private Sub btnSales_print_Click(sender As Object, e As EventArgs) Handles btnSales_print.Click
		If Application.OpenForms.OfType(Of SalePrints)().Count() = 0 Then
			Dim frmsalePrints As New SalePrints()
			SalePrints.Show()
		End If

	End Sub

	Private Sub btn_notes_Click(sender As Object, e As EventArgs) Handles btn_notes.Click
		If Application.OpenForms.OfType(Of Notes)().Count() = 0 Then
			Dim notes As New Notes()
			notes.Show()
		End If

	End Sub

	Private Sub btnPaper_register_Click(sender As Object, e As EventArgs) Handles btnPaper_register.Click
		If Application.OpenForms.OfType(Of FrmPaperRegister)().Count() = 0 Then
			Dim paperRegister As New FrmPaperRegister()
			paperRegister.Show()
		End If

	End Sub
	Public Sub ShowWelcomeMessage()
		MessageBox.Show("Welcome to the application!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
	End Sub

End Class
