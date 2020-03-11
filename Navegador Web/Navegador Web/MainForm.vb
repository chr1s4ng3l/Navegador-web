'
' Created by SharpDevelop.
' User: Christopher
' Date: 21/03/2019
' Time: 09:19 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports System.IO
Public Partial Class MainForm

	Public Sub New()
		
		Me.InitializeComponent()
		
		
	End Sub
	
	Sub Panel2Paint(sender As Object, e As PaintEventArgs)
	
	End Sub
	
	Sub Panel1Paint(sender As Object, e As PaintEventArgs)
		
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		try
		If Not textBoxBuscar.Text.StartsWith("http") Then
			textBoxBuscar.Text = "http://" + textBoxBuscar.Text 
		End If
		webBrowser1.Url = New Uri(textBoxBuscar.Text)
			If Not listBoxHistorial.Items.Contains(textBoxBuscar.Text) Then
				listBoxHistorial.Items.Add(textBoxBuscar.Text)	
		
			End If
				Catch ex As Exception
			MsgBox(ex.Message)
End Try
	End Sub
	
	Sub TextBoxBuscarKeyPress(sender As Object, e As KeyPressEventArgs)
		try
		If e.KeyChar = vbCr Then
			Button1Click(sender, e)
	
	
			'si no esta en la lista del historial lo agrega pero si esta no lo agrega 
			If Not listBoxHistorial.Items.Contains(textBoxBuscar.Text) Then
				listBoxHistorial.Items.Add(textBoxBuscar.Text)	
			End If
		End If
			Catch ex As Exception
			MsgBox(ex.Message)
End Try
		
	End Sub
	
	
	
	Sub ListBoxHistorialSelectedIndexChanged(sender As Object, e As EventArgs)
		try
		'si le das click a un historial del lisbox te lo muestra en el webbrowser
		webBrowser1.Url = New Uri(listBoxHistorial.Text)
		
		textBoxBuscar.Text = listBoxHistorial.Text
			Catch ex As Exception
			MsgBox(ex.Message)
End Try
	End Sub
	
	Sub ButtonRegrearClick(sender As Object, e As EventArgs)
		WEBBROWSER1.GoBack()
			
	End Sub
	
	Sub ButtonAvanzarClick(sender As Object, e As EventArgs)
		WEBBROWSER1.GoForward()
		
	End Sub
	
	Sub ButtonRecargarClick(sender As Object, e As EventArgs)
		WebBrowser1.Refresh
		
	End Sub
	
	Sub ButtonInicioClick(sender As Object, e As EventArgs)
		webbrowser1.GoHome()
	End Sub
	
	Sub ButtonDetenerClick(sender As Object, e As EventArgs)
		webBrowser1.Stop()	
		
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		'cargar txt en listbox
		Try
textBoxBuscar.Focus()
Dim DATOS As String = "prueba.txt" 
For Each LINEA In IO.File.ReadAllLines(DATOS)
listBoxHistorial.Items.Add(LINEA)
Next		
		Catch ex As Exception
			MsgBox(ex.Message)
End Try
	End Sub
	
	
	
	Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
		Try
			Dim DATOS As String = "prueba.txt" 
	 Dim strListado As String = ""
        'Intruduce la lista en 'Listado'
        For x = 0 To listBoxHistorial.Items.Count - 1
            strListado = strListado & listBoxHistorial.Items(x).ToString.Trim & vbCrLf
        Next x
        'Guarda la lista
        Guardar_Archivo_Texto(strListado,DATOS )
        '////Notas:
        'Guardar_Archivo_Texto (Lista, directorio y archivo)
        'System.Windows.Forms.Application.StartupPath <---Es el directorio donde se encuentra  esta apliación
		Catch ex As Exception
			MsgBox(ex.Message)
        End try
	End Sub
	

	
    Public Shared Function Guardar_Archivo_Texto(ByVal strTexto As String, ByVal FileName As String) As Long
        Guardar_Archivo_Texto = 0
        Dim sw As New System.IO.StreamWriter(FileName)
        sw.WriteLine(strTexto)
        sw.Close()
        Return Guardar_Archivo_Texto
    End Function
'	
End Class

