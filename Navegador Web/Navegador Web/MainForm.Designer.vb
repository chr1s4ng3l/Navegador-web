'
' Created by SharpDevelop.
' User: Christopher
' Date: 21/03/2019
' Time: 09:19 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.buttonDetener = New System.Windows.Forms.Button()
		Me.buttonInicio = New System.Windows.Forms.Button()
		Me.buttonRecargar = New System.Windows.Forms.Button()
		Me.buttonRegresar = New System.Windows.Forms.Button()
		Me.buttonAvanzar = New System.Windows.Forms.Button()
		Me.buttonIr = New System.Windows.Forms.Button()
		Me.textBoxBuscar = New System.Windows.Forms.TextBox()
		Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
		Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.listBoxHistorial = New System.Windows.Forms.ListBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.splitContainer1.Panel1.SuspendLayout
		Me.splitContainer1.Panel2.SuspendLayout
		Me.splitContainer1.SuspendLayout
		CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
		Me.splitContainer2.Panel1.SuspendLayout
		Me.splitContainer2.Panel2.SuspendLayout
		Me.splitContainer2.SuspendLayout
		Me.SuspendLayout
		'
		'splitContainer1
		'
		Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.splitContainer1.Name = "splitContainer1"
		Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'splitContainer1.Panel1
		'
		Me.splitContainer1.Panel1.BackColor = System.Drawing.Color.White
		Me.splitContainer1.Panel1.Controls.Add(Me.buttonDetener)
		Me.splitContainer1.Panel1.Controls.Add(Me.buttonInicio)
		Me.splitContainer1.Panel1.Controls.Add(Me.buttonRecargar)
		Me.splitContainer1.Panel1.Controls.Add(Me.buttonRegresar)
		Me.splitContainer1.Panel1.Controls.Add(Me.buttonAvanzar)
		Me.splitContainer1.Panel1.Controls.Add(Me.buttonIr)
		Me.splitContainer1.Panel1.Controls.Add(Me.textBoxBuscar)
		Me.splitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		AddHandler Me.splitContainer1.Panel1.Paint, AddressOf Me.Panel1Paint
		'
		'splitContainer1.Panel2
		'
		Me.splitContainer1.Panel2.Controls.Add(Me.splitContainer2)
		Me.splitContainer1.Size = New System.Drawing.Size(828, 482)
		Me.splitContainer1.SplitterDistance = 48
		Me.splitContainer1.TabIndex = 0
		'
		'buttonDetener
		'
		Me.buttonDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buttonDetener.ForeColor = System.Drawing.Color.White
		Me.buttonDetener.Image = CType(resources.GetObject("buttonDetener.Image"),System.Drawing.Image)
		Me.buttonDetener.Location = New System.Drawing.Point(168, 3)
		Me.buttonDetener.Name = "buttonDetener"
		Me.buttonDetener.Size = New System.Drawing.Size(45, 43)
		Me.buttonDetener.TabIndex = 7
		Me.buttonDetener.UseVisualStyleBackColor = true
		AddHandler Me.buttonDetener.Click, AddressOf Me.ButtonDetenerClick
		'
		'buttonInicio
		'
		Me.buttonInicio.BackColor = System.Drawing.Color.White
		Me.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buttonInicio.ForeColor = System.Drawing.Color.White
		Me.buttonInicio.Image = CType(resources.GetObject("buttonInicio.Image"),System.Drawing.Image)
		Me.buttonInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.buttonInicio.Location = New System.Drawing.Point(219, 3)
		Me.buttonInicio.Name = "buttonInicio"
		Me.buttonInicio.Size = New System.Drawing.Size(46, 42)
		Me.buttonInicio.TabIndex = 6
		Me.buttonInicio.UseVisualStyleBackColor = false
		AddHandler Me.buttonInicio.Click, AddressOf Me.ButtonInicioClick
		'
		'buttonRecargar
		'
		Me.buttonRecargar.BackColor = System.Drawing.Color.MintCream
		Me.buttonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buttonRecargar.ForeColor = System.Drawing.Color.White
		Me.buttonRecargar.Image = CType(resources.GetObject("buttonRecargar.Image"),System.Drawing.Image)
		Me.buttonRecargar.Location = New System.Drawing.Point(116, 3)
		Me.buttonRecargar.Name = "buttonRecargar"
		Me.buttonRecargar.Size = New System.Drawing.Size(46, 36)
		Me.buttonRecargar.TabIndex = 5
		Me.buttonRecargar.UseVisualStyleBackColor = false
		AddHandler Me.buttonRecargar.Click, AddressOf Me.ButtonRecargarClick
		'
		'buttonRegresar
		'
		Me.buttonRegresar.BackColor = System.Drawing.Color.MintCream
		Me.buttonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buttonRegresar.ForeColor = System.Drawing.Color.White
		Me.buttonRegresar.Image = CType(resources.GetObject("buttonRegresar.Image"),System.Drawing.Image)
		Me.buttonRegresar.Location = New System.Drawing.Point(3, 4)
		Me.buttonRegresar.Name = "buttonRegresar"
		Me.buttonRegresar.Size = New System.Drawing.Size(51, 35)
		Me.buttonRegresar.TabIndex = 4
		Me.buttonRegresar.UseVisualStyleBackColor = false
		AddHandler Me.buttonRegresar.Click, AddressOf Me.ButtonRegrearClick
		'
		'buttonAvanzar
		'
		Me.buttonAvanzar.BackColor = System.Drawing.Color.MintCream
		Me.buttonAvanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buttonAvanzar.ForeColor = System.Drawing.Color.White
		Me.buttonAvanzar.Image = CType(resources.GetObject("buttonAvanzar.Image"),System.Drawing.Image)
		Me.buttonAvanzar.Location = New System.Drawing.Point(60, 3)
		Me.buttonAvanzar.Name = "buttonAvanzar"
		Me.buttonAvanzar.Size = New System.Drawing.Size(51, 36)
		Me.buttonAvanzar.TabIndex = 3
		Me.buttonAvanzar.UseVisualStyleBackColor = false
		AddHandler Me.buttonAvanzar.Click, AddressOf Me.ButtonAvanzarClick
		'
		'buttonIr
		'
		Me.buttonIr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.buttonIr.BackColor = System.Drawing.Color.White
		Me.buttonIr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.buttonIr.ForeColor = System.Drawing.Color.Black
		Me.buttonIr.Location = New System.Drawing.Point(740, 9)
		Me.buttonIr.Name = "buttonIr"
		Me.buttonIr.Size = New System.Drawing.Size(68, 28)
		Me.buttonIr.TabIndex = 2
		Me.buttonIr.Text = "Ir"
		Me.buttonIr.UseVisualStyleBackColor = false
		AddHandler Me.buttonIr.Click, AddressOf Me.Button1Click
		'
		'textBoxBuscar
		'
		Me.textBoxBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.textBoxBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBoxBuscar.Location = New System.Drawing.Point(271, 11)
		Me.textBoxBuscar.Name = "textBoxBuscar"
		Me.textBoxBuscar.Size = New System.Drawing.Size(463, 26)
		Me.textBoxBuscar.TabIndex = 1
		AddHandler Me.textBoxBuscar.KeyPress, AddressOf Me.TextBoxBuscarKeyPress
		'
		'splitContainer2
		'
		Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
		Me.splitContainer2.Name = "splitContainer2"
		'
		'splitContainer2.Panel1
		'
		Me.splitContainer2.Panel1.BackColor = System.Drawing.Color.White
		Me.splitContainer2.Panel1.Controls.Add(Me.webBrowser1)
		'
		'splitContainer2.Panel2
		'
		Me.splitContainer2.Panel2.BackColor = System.Drawing.Color.White
		Me.splitContainer2.Panel2.Controls.Add(Me.listBoxHistorial)
		Me.splitContainer2.Panel2.Controls.Add(Me.label1)
		AddHandler Me.splitContainer2.Panel2.Paint, AddressOf Me.Panel2Paint
		Me.splitContainer2.Size = New System.Drawing.Size(828, 430)
		Me.splitContainer2.SplitterDistance = 649
		Me.splitContainer2.TabIndex = 0
		'
		'webBrowser1
		'
		Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.webBrowser1.Name = "webBrowser1"
		Me.webBrowser1.Size = New System.Drawing.Size(649, 430)
		Me.webBrowser1.TabIndex = 0
		Me.webBrowser1.Url = New System.Uri("https://www.google.com", System.UriKind.Absolute)
		'
		'listBoxHistorial
		'
		Me.listBoxHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.listBoxHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.listBoxHistorial.FormattingEnabled = true
		Me.listBoxHistorial.ItemHeight = 18
		Me.listBoxHistorial.Location = New System.Drawing.Point(2, 46)
		Me.listBoxHistorial.Name = "listBoxHistorial"
		Me.listBoxHistorial.Size = New System.Drawing.Size(173, 364)
		Me.listBoxHistorial.TabIndex = 2
		AddHandler Me.listBoxHistorial.SelectedIndexChanged, AddressOf Me.ListBoxHistorialSelectedIndexChanged
		'
		'label1
		'
		Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(41, 7)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(99, 25)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Historial"
		'
		'openFileDialog1
		'
		Me.openFileDialog1.DefaultExt = "txt"
		Me.openFileDialog1.FileName = "openFileDialog1"
		Me.openFileDialog1.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(828, 482)
		Me.Controls.Add(Me.splitContainer1)
		Me.MinimumSize = New System.Drawing.Size(835, 521)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Navegador Web"
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.splitContainer1.Panel1.ResumeLayout(false)
		Me.splitContainer1.Panel1.PerformLayout
		Me.splitContainer1.Panel2.ResumeLayout(false)
		CType(Me.splitContainer1,System.ComponentModel.ISupportInitialize).EndInit
		Me.splitContainer1.ResumeLayout(false)
		Me.splitContainer2.Panel1.ResumeLayout(false)
		Me.splitContainer2.Panel2.ResumeLayout(false)
		Me.splitContainer2.Panel2.PerformLayout
		CType(Me.splitContainer2,System.ComponentModel.ISupportInitialize).EndInit
		Me.splitContainer2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private buttonAvanzar As System.Windows.Forms.Button
	Private buttonRegresar As System.Windows.Forms.Button
	Private buttonRecargar As System.Windows.Forms.Button
	Private buttonInicio As System.Windows.Forms.Button
	Private buttonDetener As System.Windows.Forms.Button
	Private listBoxHistorial As System.Windows.Forms.ListBox
	Private textBoxBuscar As System.Windows.Forms.TextBox
	Private buttonIr As System.Windows.Forms.Button
	Private webBrowser1 As System.Windows.Forms.WebBrowser
	Private label1 As System.Windows.Forms.Label
	Private splitContainer2 As System.Windows.Forms.SplitContainer
	Private splitContainer1 As System.Windows.Forms.SplitContainer
End Class
