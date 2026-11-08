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

namespace ToyotaVehicleSystemWPF
{
    /// <summary>
    /// Логика взаимодействия для ServiceInformationWindow.xaml
    /// </summary>
    public partial class ServiceInformationWindow : Window
    {
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public ServiceInformationWindow()
        {
            InitializeComponent();
        }
    }
}
