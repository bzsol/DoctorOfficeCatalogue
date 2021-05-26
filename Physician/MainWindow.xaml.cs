using Assistant;
using Common.Model;
using Physician.DataProvider;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
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
using System.Windows.Threading;

namespace Physician
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void UpdateData()
        {
            PatientList.ItemsSource = PatientDataProvider.GetPatients().ToList();
        }

        public MainWindow()
        {
            InitializeComponent();
            UpdateData();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            PhysicianHelper physicianHelper = new PhysicianHelper
            {
                Owner = (Window)PresentationSource.FromVisual(this).RootVisual
            };
            physicianHelper.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Notification notification = new Notification
            {
                Owner = (Window)PresentationSource.FromVisual(this).RootVisual
            };
            notification.ShowDialog();
        }
       
        private void List_Selection(object sender, SelectionChangedEventArgs e)
        {
            var Patient = PatientList.SelectedItem as Patient;
            if (Patient != null) {
                var window = new SelectedPatient(Patient);
                window.Closed += Window_Closed;
                window.ShowDialog();
                PatientList.UnselectAll();
            }

            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                SearchTextBox.Text = string.Empty;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void SearchByCondition(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                var filteredList = PreferenceButton.Content.Equals("Név") ? PatientDataProvider.GetPatients().Where(x => x.FullName.Contains(SearchTextBox.Text)).ToList() :
                    PatientDataProvider.GetPatients().Where(x => x.HIS.Contains(SearchTextBox.Text)).ToList();
                PatientList.ItemsSource = filteredList;
                CountOfResultsLabel.Content = $"{filteredList.Count} találat";
                CountOfResultsLabel.Visibility = Visibility.Visible;
            } 
            else
            {
                UpdateData();
                CountOfResultsLabel.Visibility = Visibility.Hidden;
            }     
        }

        private void SearchPreference_Click(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            if (PreferenceButton.Content.Equals("Név"))
            {
                PreferenceButton.Content = "TAJ";
                PreferenceButton.Background = (Brush)bc.ConvertFromString("#45B3E7");
                PreferenceButton.BorderBrush = (Brush)bc.ConvertFromString("#45B3E7");
            }
            else
            {
                PreferenceButton.Content = "Név";
                PreferenceButton.Background = (Brush)bc.ConvertFromString("#F44336");
                PreferenceButton.BorderBrush = (Brush)bc.ConvertFromString("#F44336");
            }
            SearchTextBox.Text = string.Empty;
        }
    }
}
