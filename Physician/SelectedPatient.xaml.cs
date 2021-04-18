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
        private Patient patient;

        public SelectedPatient(Patient ChoosenOne)
        {
            InitializeComponent();
            patient = ChoosenOne;
            HISTextBox.Text = patient.HIS;
            ComplaintTextBox.Text = patient.Complaint;
            FirstNameTextBox.Text = patient.FirstName;
            SecondNameTextBox.Text = patient.LastName;
            HomeAddressTextBox.Text = patient.HomeAddress;
            
        }

        private void DeletePatient_Click(object sender, RoutedEventArgs e)
        {
            PatientDataProvider.DeletePatient(patient.ID);
            Close();
        }

        private void SavePatientData_Click(object sender, RoutedEventArgs e)
        {
            patient.Diagnose = DiagnosisTextBox.Text;
            patient.HomeAddress = HomeAddressTextBox.Text;
            patient.HIS = HISTextBox.Text;
            patient.FirstName = FirstNameTextBox.Text;
            patient.LastName = SecondNameTextBox.Text;
            PatientDataProvider.UpdatePatient(patient);
            Close();
        }

        private void ClosePatientDataWindow_Click(object sender, RoutedEventArgs e)
        { 
            Close();
        }
    }
}
