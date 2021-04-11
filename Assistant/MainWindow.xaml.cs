using Assistant.DataProvider;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearTextFields() {
            FirstNameTextBox.Text = "";
            SecondNameTextBox.Text = "";
            HomeAddressTextBox.Text = "";
            HISTextBox.Text = "";
            ComplaintTextBox.Text = "";
        }
        private void TemporaryDisableTextFields() {
            FirstNameTextBox.IsReadOnly = true;
            SecondNameTextBox.IsReadOnly = true;
            HomeAddressTextBox.IsReadOnly = true;
            HISTextBox.IsReadOnly = true;
            ComplaintTextBox.IsReadOnly = true;
        }
        private void OpenTextFields() {
            FirstNameTextBox.IsReadOnly = false;
            SecondNameTextBox.IsReadOnly = false;
            HomeAddressTextBox.IsReadOnly = false;
            HISTextBox.IsReadOnly = false;
            ComplaintTextBox.IsReadOnly = false;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearTextFields();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Would you like to close this application?", "Do you want to exit?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result.Equals(MessageBoxResult.Yes))
            {
                Environment.Exit(0);
            }
        }

        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = new Patient();
            if (Common.Validation.IsValidName(FirstNameTextBox.Text, SecondNameTextBox.Text) && (Common.Validation.IsValidHIS(HISTextBox.Text)))
            {
                patient.FirstName = FirstNameTextBox.Text;
                patient.LastName = SecondNameTextBox.Text;
                patient.HIS = HISTextBox.Text;
                patient.HomeAddress = HomeAddressTextBox.Text;
                patient.Complaint = ComplaintTextBox.Text;
                patient.Intake = DateTime.Now;
                patient.Diagnose = "";
                PatientDataProvider.CreatePatient(patient);
                ClearTextFields();
                TemporaryDisableTextFields();
                SnackbarOK.IsActive = true;

            }
            else {
                SnackbarPB.IsActive = true;
                TemporaryDisableTextFields();
            }
        }

        private void Message_Click(object sender, RoutedEventArgs e) {
            SnackbarOK.IsActive = false;
            SnackbarPB.IsActive = false;
            OpenTextFields();

        }
    }
}
