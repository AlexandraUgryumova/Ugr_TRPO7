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
using Угрюмова_практическая_7.Converters;

namespace Угрюмова_практическая_7.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListBoxPage.xaml
    /// </summary>
    public partial class ListBoxPage : Page
    {
        public ListBoxPage()
        {
            InitializeComponent();
            DataContext = DataBase.DataBaseInstance.ToursData;
        }
    }
}
