<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notes
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
		txtnotes = New TextBox()
		btnSaveNotes = New Button()
		btnOpennotes = New Button()
		SuspendLayout()
		' 
		' txtnotes
		' 
		txtnotes.BorderStyle = BorderStyle.None
		txtnotes.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtnotes.ForeColor = Color.DarkBlue
		txtnotes.Location = New Point(89, 176)
		txtnotes.Multiline = True
		txtnotes.Name = "txtnotes"
		txtnotes.Size = New Size(1154, 501)
		txtnotes.TabIndex = 5
		' 
		' btnSaveNotes
		' 
		btnSaveNotes.BackColor = Color.Teal
		btnSaveNotes.Font = New Font("Cambria", 12F, FontStyle.Bold)
		btnSaveNotes.ForeColor = SystemColors.ButtonHighlight
		btnSaveNotes.Location = New Point(766, 66)
		btnSaveNotes.Name = "btnSaveNotes"
		btnSaveNotes.Size = New Size(224, 86)
		btnSaveNotes.TabIndex = 4
		btnSaveNotes.Text = "Save Notes"
		btnSaveNotes.UseVisualStyleBackColor = False
		' 
		' btnOpennotes
		' 
		btnOpennotes.BackColor = Color.LightBlue
		btnOpennotes.Font = New Font("Cambria", 12F, FontStyle.Bold)
		btnOpennotes.ForeColor = SystemColors.ButtonHighlight
		btnOpennotes.Location = New Point(408, 66)
		btnOpennotes.Name = "btnOpennotes"
		btnOpennotes.Size = New Size(224, 86)
		btnOpennotes.TabIndex = 3
		btnOpennotes.Text = "Open Notes"
		btnOpennotes.UseVisualStyleBackColor = False
		' 
		' Notes
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.AliceBlue
		ClientSize = New Size(1332, 743)
		Controls.Add(txtnotes)
		Controls.Add(btnSaveNotes)
		Controls.Add(btnOpennotes)
		Name = "Notes"
		Text = "Notes"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Private WithEvents txtnotes As TextBox
	Private WithEvents btnSaveNotes As Button
	Private WithEvents btnOpennotes As Button
End Class
