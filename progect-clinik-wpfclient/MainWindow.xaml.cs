using Newtonsoft.Json.Linq;
using progect_clinik_models.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace progect_clinik_wpfclient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public ObservableCollection<Department> Departments { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        private async void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            using HttpClient client = new();
            var result = await client.GetAsync("http://localhost:5000/api/department");
            var json = await result.Content.ReadAsStringAsync();
            var jObj = JObject.Parse(json);
            if ((string?)jObj["status"] != "ok")
                throw new Exception();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid ?? throw new NotImplementedException();
            var depatment = (Department?)dataGrid.SelectedCells[0].Item;
            if (depatment is null)
                return;
            var departmentId = depatment.Id;
        }
    }
}
