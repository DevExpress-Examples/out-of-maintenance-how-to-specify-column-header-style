Imports System.Windows
Imports System.Data

Namespace HeaderStyle

	Partial Public Class Window1
		Inherits Window

		Private Shared path As String = "..\..\Nwind.xml"
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = GetDataFromXML()
		End Sub
		Private Function GetDataFromXML() As DataTable
			Dim ds As New DataSet()
			ds.ReadXml(path)
			Return ds.Tables(0)
		End Function
	End Class

End Namespace
