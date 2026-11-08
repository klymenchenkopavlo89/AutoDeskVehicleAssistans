using System.Windows;
using System.Windows.Controls;

namespace ToyotaVehicleSystemWPF
{
    public partial class ServiceInformationPage : Page
    {
        public ServiceInformationPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
