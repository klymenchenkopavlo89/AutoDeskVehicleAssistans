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
using System.Windows.Shapes;
using ToyotaVehicleSystem;

namespace ToyotaVehicleSystemWPF
{
    /// <summary>
    /// Логика взаимодействия для VehicleInformationWindow.xaml
    /// </summary>
    public partial class VehicleInformationWindow : Window
    {
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PartsButton_Click(object sender, RoutedEventArgs e)
        {
            PartsInformationWindow window = new PartsInformationWindow();
            window.Show();
        }

        private void ServiceButton_Click(object sender, RoutedEventArgs e)
        {
            ServiceInformationWindow window = new ServiceInformationWindow();
            window.Show();
        }
        public VehicleInformationWindow(Vehicle vehicle)
        {
            InitializeComponent();

            VinTextBlock.Text = "VIN: " + vehicle.Vin;
            ModelTextBlock.Text = "Model: " + vehicle.Model;
            YearTextBlock.Text = "Year: " + vehicle.Year;
            EngineTextBlock.Text = "Engine: " + vehicle.Engine;
        }
        public VehicleInformationWindow()
        {
            InitializeComponent();
        }
    }
}
