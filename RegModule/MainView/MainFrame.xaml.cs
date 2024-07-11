using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using RegModule.Pages;

namespace RegModule.MainView
{
    /// <summary>
    /// Логика взаимодействия для MainFrame.xaml
    /// </summary>
    public partial class MainFrame : Page
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void AddNewUserButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUserPage());
        }

        private void WatchUsersButtoon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddModuleforUserButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
