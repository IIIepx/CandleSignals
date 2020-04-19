using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using TickerData;
using WinFormsSerialization;


namespace CandlesSignal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TickerList Tickers = new TickerList();
        public bool isDataChanged = false;
        public MainWindow()
        {

            InitializeComponent();
            string path = System.IO.Directory.GetCurrentDirectory() + "\\TickerData.bin";

            FileInfo fdata = new FileInfo(path);
            if (fdata.Exists)
            {
                Tickers.List = Serializer.LoadListFromBinnary<TickerModel>(path);
            }
            TickersTable.ItemsSource = Tickers.List;
            

        }

        private void btnSaveOnClick(object sender, RoutedEventArgs e)
        {
            WinFormsSerialization.Serializer.SaveListToBinnary<TickerModel>("TickerData.bin", Tickers.List);
        }
    }
}
