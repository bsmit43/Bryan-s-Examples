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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Monitor.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //navigate to Dashboard view when initialized
            InitializeComponent();
            _mainFrame.Navigate(new Dashboard());
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            //navigate to dashboard view when clicked
            _mainFrame.Navigate(new Dashboard());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //navigate to search view when clicked
            _mainFrame.Navigate(new Search());
        }

        private void _mainFrame_Navigated_2(object sender, RoutedEventArgs e)
        {
            //navigated to Monitor view when clicked
            _mainFrame.Navigate(new Monitor());
        }
    }
}
