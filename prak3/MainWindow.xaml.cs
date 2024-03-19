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

namespace prak3
{
    public partial class MainWindow : Window
    {
        private RibolovnieSnasti2Entities a = new RibolovnieSnasti2Entities();
        public MainWindow()
        {
            InitializeComponent();

            DG.ItemsSource = a.Sotrudniki.ToList();
        }
    }
}
