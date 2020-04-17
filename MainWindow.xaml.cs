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
        public MainWindow()
        {
            InitializeComponent();
            List<TickerModel> Tickers = new List<TickerModel>(50)
            {   new TickerModel {Name = "SiM0", Supply = 80, Demand = 70, Pinbar = true },
                new TickerModel {Name = "EuM0", Supply = 80, Demand = 70, Pinbar = true }
            };
            string path = System.IO.Directory.GetCurrentDirectory() + "TickerData.bin";
            FileInfo fdata = new FileInfo(path);
            if (fdata.Exists)
            {
                Tickers = Serializer.LoadListFromBinnary<TickerModel>(path);
            }
            TickersTable.ItemsSource = Tickers;

        }
    }
}
