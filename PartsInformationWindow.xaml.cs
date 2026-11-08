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
    /// Логика взаимодействия для PartsInformationWindow.xaml
    /// </summary>
    public partial class PartsInformationWindow : Window
    {
        public PartsInformationWindow()
        {
            InitializeComponent();
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
