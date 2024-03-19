using System;
using System.Collections.Generic;
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
using prak32_now_with_datasets.DSTableAdapters;

namespace prak32_now_with_datasets
{
    public partial class MainWindow : Window
    {
        SotrudnikiTableAdapter sotrudniki = new SotrudnikiTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

            DG.ItemsSource = sotrudniki.GetDataBy();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DG.Columns[0].Visibility = Visibility.Collapsed;
            DG.Columns[3].Visibility = Visibility.Collapsed;
            DG.Columns[4].Visibility = Visibility.Collapsed;
        }
    }
}
