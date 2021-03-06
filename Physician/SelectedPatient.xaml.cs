using Assistant;
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
            PatientObserver.Instance = patient;
            PatientNameTextBlock.Text = $"{patient.FullName} adatai";
            HISTextBox.Text = patient.HIS;
            ComplaintTextBox.Text = patient.Complaint;
            FirstNameTextBox.Text = patient.FirstName;
            SecondNameTextBox.Text = patient.LastName;
            HomeAddressTextBox.Text = patient.HomeAddress;
            DiagnosisTextBox.Text = patient.Diagnose;
            AllergyTextBox.Text = patient.Allergy;
            DateOfBirth.SelectedDate = patient.DateOfBirth.Date;    
        }

        private void DeletePatient_Click(object sender, RoutedEventArgs e)
        {
            PatientDataProvider.DeletePatient(patient.ID);
            PatientObserver.Instance = null;
            Close();
        }

        private void SavePatientData_Click(object sender, RoutedEventArgs e)
        {
            if (Common.Validation.IsValidHIS(HISTextBox.Text) && Common.Validation.IsValidName(FirstNameTextBox.Text, SecondNameTextBox.Text))
            {
                patient.Diagnose = DiagnosisTextBox.Text;
                patient.HomeAddress = HomeAddressTextBox.Text;
                patient.HIS = HISTextBox.Text;
                patient.FirstName = FirstNameTextBox.Text;
                patient.LastName = SecondNameTextBox.Text;
                patient.DateOfBirth = DateOfBirth.SelectedDate.Value;
                patient.Age = Patient.CalculateAge(patient.DateOfBirth);
                patient.Allergy = AllergyTextBox.Text;
                PatientDataProvider.UpdatePatient(patient);
                ErrorLabel.Visibility = Visibility.Collapsed;
                PatientObserver.Instance = null;
                Close();
            }

            ErrorLabel.Visibility = Visibility.Visible;
        }

        private void MedicationListShow(object sender, RoutedEventArgs e)
        {
            Medication.MedicationListView medlist = new Medication.MedicationListView
            {
                Owner = (Window)PresentationSource.FromVisual(this).RootVisual
            };
            medlist.ShowDialog();
        }

        private void ClosePatientDataWindow_Click(object sender, RoutedEventArgs e)
        {
            PatientObserver.Instance = null;
            Close();
        }
    }
}
