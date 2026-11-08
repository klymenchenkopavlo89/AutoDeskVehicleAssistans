using System.Windows;
using System.Windows.Controls;

namespace ToyotaVehicleSystemWPF
{
    public partial class PartsInformationPage : Page
    {
        public PartsInformationPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
