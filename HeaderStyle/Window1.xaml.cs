using System.Windows;
using System.Data;

namespace HeaderStyle {
  
    public partial class Window1 : Window {
        static string path = @"..\..\Nwind.xml";
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = GetDataFromXML();
        }
        private DataTable GetDataFromXML() {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds.Tables[0];
        }
    }
   
}
