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
using System.Windows.Threading;
using Physician.DataProvider;

namespace Physician.Medication
{
    /// <summary>
    /// Interaction logic for MedicationListView.xaml
    /// </summary>
    public partial class MedicationListView : Window
    {
        public MedicationListView()
        {
            InitializeComponent();
            UpdateData();
        }

        public void UpdateData()
        {
            MedicationList.ItemsSource = MedicationDataProvider.GetMedications().ToList();
        }
        private void List_Selection(object sender, SelectionChangedEventArgs e)
        {
            Common.Model.Medication med = MedicationList.SelectedItem as Common.Model.Medication;
            if (med != null)
            {
                var window = new SelectedMedication(med)
                {
                    Owner = (Window)PresentationSource.FromVisual(this).RootVisual
                };
                window.Closed += Window_Closed;
                window.ShowDialog();
                MedicationList.UnselectAll();
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
                var filteredList = PreferenceButton.Content.Equals("Név") ? MedicationDataProvider.GetMedications().Where(x => x.MedicationName.Contains(SearchTextBox.Text)).ToList() :
                    MedicationDataProvider.GetMedications().Where(x => x.Description.Contains(SearchTextBox.Text)).ToList();
                MedicationList.ItemsSource = filteredList;
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
                PreferenceButton.Content = "Leírás";
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
