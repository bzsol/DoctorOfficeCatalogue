using Common.Model;
using Physician.DataProvider;
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
        public Patient ChoosenOne = ((MainWindow)Application.Current.MainWindow).PatientList.SelectedItem as Patient;

        public SelectedPatient()
        {
            InitializeComponent();
            if (ChoosenOne != null)
            {
                var name = ChoosenOne.FullName.Split(" ");
                FirstNameTextBox.Text = name[0];
                SecondNameTextBox.Text = name[1];
                HISTextBox.Text = ChoosenOne.HIS;
                HomeAddressTextBox.Text = ChoosenOne.HomeAddress;
                ComplaintTextBox.Text = ChoosenOne.Complaint;
            }
        }

        private void DeletePatient_Click(object sender, RoutedEventArgs e)
        {
            PatientDataProvider.DeletePatient(ChoosenOne.ID);
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
