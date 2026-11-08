using System.Windows;

namespace ToyotaVehicleSystemWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new LoginPage());
        }

        public void OpenMainMenu()
        {
            MainFrame.Navigate(new MainMenuPage());
        }
    }
}
