Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace AnimatedDropDown
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			comboBoxEdit1.ItemsSource = CreateData(10)
		End Sub

		Private Shared Function CreateData(ByVal listCnt As Integer) As List(Of String)
			Dim list As New List(Of String)()
			For i As Integer = 0 To listCnt - 1
				list.Add("Item" & (i + 1))
			Next i
			Return list
		End Function
	End Class
End Namespace