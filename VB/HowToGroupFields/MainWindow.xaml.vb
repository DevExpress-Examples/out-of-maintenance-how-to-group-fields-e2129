Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.DataSet1TableAdapters
Imports HowToBindToMDB.DataSet1

Namespace HowToBindToMDB
	Partial Public Class MainWindow
		Inherits Window

'INSTANT VB NOTE: The variable salesPersonDataTable was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private salesPersonDataTable_Conflict As New HowToBindToMDB.DataSet1.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable_Conflict
		End Sub
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable_Conflict)

			' Create a group at run-time
			Dim group As PivotGridGroup = pivotGridControl1.Groups.Add(fieldCategoryName, fieldProductName)
		End Sub
	End Class
End Namespace
