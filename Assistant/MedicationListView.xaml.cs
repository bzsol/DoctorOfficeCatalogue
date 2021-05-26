using Assistant.DataProvider;
using Common.Model;
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

namespace Assistant
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
            Medication med = MedicationList.SelectedItem as Medication;
            if (med != null)
            {
                var window = new SelectedMedication(med);
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
                var filteredList = MedicationDataProvider.GetMedications().Where(x => x.MedicationName.Contains(SearchTextBox.Text)).ToList();
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
    }
}
