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
using ToyotaVehicleSystem;

namespace ToyotaVehicleSystemWPF
{
    /// <summary>
    /// Логика взаимодействия для VinSearchPage.xaml
    /// </summary>
    public partial class VinSearchPage : Page
    {
        public VinSearchPage()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            VinSearch vinSearch = new VinSearch();

            Vehicle vehicle = vinSearch.FindByVin(VinTextBox.Text);

            if (vehicle != null)
            {
                NavigationService.Navigate(new VehicleInformationPage(vehicle));
            }
            else
            {
                MessageBox.Show("VIN not found.");
            }
        }



        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
