using System.Windows;
using System.Windows.Controls;
using ToyotaVehicleSystem;

namespace ToyotaVehicleSystemWPF
{
    public partial class VehicleInformationPage : Page
    {
        public VehicleInformationPage(Vehicle vehicle)
        {
            InitializeComponent();

            VinTextBlock.Text = "VIN: " + vehicle.Vin;
            ModelTextBlock.Text = "Model: " + vehicle.Model;
            YearTextBlock.Text = "Year: " + vehicle.Year;
            EngineTextBlock.Text = "Engine: " + vehicle.Engine;
        }

        private void ServiceButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServiceInformationPage());
        }

        private void PartsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PartsInformationPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
