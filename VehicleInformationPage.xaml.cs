using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ToyotaVehicleSystem;

namespace ToyotaVehicleSystemWPF
{
    public partial class VehicleInformationPage : Page
    {
        public VehicleInformationPage(Vehicle vehicle)
        {
            InitializeComponent();

            // VEHICLE INFORMATION
            VinTextBlock.Text = "VIN: " + vehicle.Vin;
            ModelTextBlock.Text = "Model: " + vehicle.Model;
            YearTextBlock.Text = "Year: " + vehicle.Year;
            EngineTextBlock.Text = "Engine: " + vehicle.Engine;

            // VEHICLE IMAGE
            string imageName = vehicle.Model + ".png";

            VehicleImage.Source = new BitmapImage(
                new Uri("pack://application:,,,/Images/" + imageName));
        }

        // SERVICE BUTTON
        private void ServiceButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new ServiceInformationPage());
        }

        // PARTS BUTTON
        private void PartsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
                new PartsInformationPage());
        }

        // BACK BUTTON
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
