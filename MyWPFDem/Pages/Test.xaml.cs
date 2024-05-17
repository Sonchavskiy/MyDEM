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

namespace MyWPFDem.Pages
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow maiWindow = Window.GetWindow(this) as MainWindow;
            maiWindow.frame.Navigate(new LogIn());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Singleton.DB.User.ToList();
            table.ItemsSource = Singleton.DB.User.Local;
        }

        private void filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Singleton.DB.User.Local.Where(u => u.Username.Contains(filter.Text));
        }
    }
}
