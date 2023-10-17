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
using Угрюмова_практическая_7.Pages;

namespace Угрюмова_практическая_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Page[] pages = new Page[]
        {
            new DataGridPage(),
            new ListBoxPage(),
            new WrapPanelPage()
        };

        private void DataGridPage_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(pages[0]);
        }

        private void ListBoxPage_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(pages[1]);
        }

        private void WrapPanelPage_Click(object sender, RoutedEventArgs e)
        {
            Frame1.Navigate(pages[2]);
        }
    }
}
