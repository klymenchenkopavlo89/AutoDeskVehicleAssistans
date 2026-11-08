using System.Windows;
using System.Windows.Controls;

namespace ToyotaVehicleSystemWPF
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Password;

            if (username == "admin" && password == "12345")
            {
                MainWindow mainWindow = Window.GetWindow(this) as MainWindow;

                if (mainWindow != null)
                {
                    mainWindow.OpenMainMenu();
                }
            }
            else
            {
                StatusText.Text = "Invalid username or password!";
            }
        }
    }
}
