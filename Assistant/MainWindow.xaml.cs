using Assistant.DataProvider;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
        }

        private void ClearTextFields() {
            FirstNameTextBox.Text = "";
            SecondNameTextBox.Text = "";
            HomeAddressTextBox.Text = "";
            HISTextBox.Text = "";
            ComplaintTextBox.Text = "";
            DateOfBirth.SelectedDate = null;
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

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            AssistantHelper assistantHelper = new AssistantHelper
            {
                Owner = (Window)PresentationSource.FromVisual(this).RootVisual
            };
            assistantHelper.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Notification notification = new Notification
            {
                Owner = (Window)PresentationSource.FromVisual(this).RootVisual
            };
            notification.ShowDialog();
        }

        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = new Patient();
            if (Common.Validation.IsValidName(FirstNameTextBox.Text, SecondNameTextBox.Text) && Common.Validation.IsValidHIS(HISTextBox.Text)
                && !string.IsNullOrEmpty(HomeAddressTextBox.Text.Trim()) && !string.IsNullOrEmpty(ComplaintTextBox.Text.Trim()) && DateOfBirth.SelectedDate != null)
            {
                patient.FirstName = FirstNameTextBox.Text;
                patient.LastName = SecondNameTextBox.Text;
                patient.HIS = HISTextBox.Text;
                patient.HomeAddress = HomeAddressTextBox.Text.Trim();
                patient.Complaint = ComplaintTextBox.Text.Trim();
                patient.Intake = DateTime.Now.ToString("yyyy.MM.dd HH:mm");
                patient.Diagnose = string.Empty;
                patient.DateOfBirth = DateOfBirth.SelectedDate.Value;
                patient.Age = Patient.CalculateAge(patient.DateOfBirth);
                patient.Medications = new List<string>();
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
