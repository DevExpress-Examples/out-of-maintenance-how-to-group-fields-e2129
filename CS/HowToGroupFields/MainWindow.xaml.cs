using System.Windows;
using DevExpress.Xpf.PivotGrid;
using HowToBindToMDB.DataSet1TableAdapters;
using static HowToBindToMDB.DataSet1;

namespace HowToBindToMDB {
    public partial class MainWindow : Window {
        SalesPersonDataTable salesPersonDataTable = 
            new SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);

            // Create a group at run-time
            PivotGridGroup group = pivotGridControl1.Groups.Add(fieldCategoryName, fieldProductName);
        }
    }
}
