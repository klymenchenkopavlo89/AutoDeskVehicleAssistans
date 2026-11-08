using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ToyotaVehicleSystem;

namespace ToyotaVehicleSystemWPF
{
    public partial class ModelSearchPage : Page
    {
        private Vehicle selectedVehicle;

        public ModelSearchPage()
        {
            InitializeComponent();
        }

        private void ModelButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button == null)
                return;

            string selectedModel = button.Tag.ToString();

            selectedVehicle = VehicleDataBase.Vehicles
                .FirstOrDefault(v =>
                    v.Model.Equals(
                        selectedModel,
                        StringComparison.OrdinalIgnoreCase));

            if (selectedVehicle == null)
            {
                MessageBox.Show("Vehicle not found.");
                return;
            }

            SelectVehicleText.Visibility = Visibility.Collapsed;

            ModelTextBlock.Text = "Model: " + selectedVehicle.Model;
            YearTextBlock.Text = "Year: " + selectedVehicle.Year;
            EngineTextBlock.Text = "Engine: " + selectedVehicle.Engine;
            VinTextBlock.Text = "VIN: " + selectedVehicle.Vin;

            VehicleImage.Visibility = Visibility.Collapsed;

            if (selectedModel.Equals("Prius",
                StringComparison.OrdinalIgnoreCase))
            {
                VehicleImage.Source = new BitmapImage(
                    new Uri("pack://application:,,,/Images/Prius.png"));

                VehicleImage.Visibility = Visibility.Visible;
            }

            MoreInformationButton.Visibility = Visibility.Visible;
        }

        private void MoreInformationButton_Click(
            object sender, RoutedEventArgs e)
        {
            if (selectedVehicle == null)
                return;

            NavigationService.Navigate(
                new VehicleInformationPage(selectedVehicle));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
