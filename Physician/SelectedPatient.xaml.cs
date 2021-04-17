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

namespace Physician
{
    /// <summary>
    /// Interaction logic for SelectedPatient.xaml
    /// </summary>
    public partial class SelectedPatient : Window
    {
        public SelectedPatient()
        {
            InitializeComponent();
        }

        private void DeletePatient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SavePatientData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClosePatientDataWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
