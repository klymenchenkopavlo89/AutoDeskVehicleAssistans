using System.Windows;
using System.Windows.Controls;

namespace ToyotaVehicleSystemWPF
{
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void ModelSearchButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ModelSearchPage());
        }

        private void VinSearchButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VinSearchPage());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
