Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.DataSet1TableAdapters
Imports HowToBindToMDB.DataSet1

Namespace HowToBindToMDB

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As SalesPersonDataTable = New SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
            ' Create a group at run-time
            Dim group As PivotGridGroup = Me.pivotGridControl1.Groups.Add(Me.fieldCategoryName, Me.fieldProductName)
        End Sub
    End Class
End Namespace
