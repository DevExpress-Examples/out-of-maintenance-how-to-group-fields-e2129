Imports System.Windows
Imports DataSet1
Imports DataSet1TableAdapters
Imports DevExpress.Xpf.PivotGrid

Namespace HowToBindToMDB
    Partial Public Class MainWindow
        Inherits Window
        Private salesPersonDataTable As New SalesPersonDataTable()
        Private salesPersonDataAdapter As New SalesPersonTableAdapter()
        Public Sub New()
            InitializeComponent()
            pivotGridControl1.DataSource = salesPersonDataTable
        End Sub
        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)

            ' Create a group at run-time
            Dim group As PivotGridGroup = pivotGridControl1.Groups.Add(fieldCategoryName, fieldProductName)
        End Sub
    End Class
End Namespace
