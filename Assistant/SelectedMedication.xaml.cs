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
    /// Interaction logic for SelectedMedication.xaml
    /// </summary>
    public partial class SelectedMedication : Window
    {
        private Medication medication;

        public SelectedMedication(Medication med)
        {
            InitializeComponent();
            medication = med;
            SetupShownDatas();
        }

        private void SetupShownDatas()
        {
            MedicationNameTextBlock.Text = $"{medication.MedicationName} adatai";
            MedNameBox.Text = medication.MedicationName;
            ActIngredientBox.Text = medication.ActiveIngredient;
            MinAgeBox.Text = medication.MinimumAge.ToString();
            MaxAgeBox.Text = medication.MaximumAge.ToString();
            DosageBox.Text = medication.Dosage;
            PackagingBox.Text = medication.Packaging;
        }

        private void DeleteMedication_Click(object sender, RoutedEventArgs e)
        {
            MedicationDataProvider.DeleteMedication(medication.ID);
            Close();
        }

        private void SaveMedicationData_Click(object sender, RoutedEventArgs e)
        {
            if (GetValidationResult())
            {
                medication.ActiveIngredient = ActIngredientBox.Text;
                medication.MedicationName = MedNameBox.Text;
                medication.MinimumAge = int.Parse(MinAgeBox.Text);
                medication.MaximumAge = int.Parse(MaxAgeBox.Text);
                medication.Dosage = DosageBox.Text;
                medication.Packaging = PackagingBox.Text;
                MedicationDataProvider.UpdateMedication(medication);
                ErrorLabel.Visibility = Visibility.Collapsed;
                Close();
            }

            ErrorLabel.Visibility = Visibility.Visible;
        }

        private void CloseMedicationDataWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool GetValidationResult()
        {
            if (string.IsNullOrEmpty(MedNameBox.Text.Trim()) || string.IsNullOrEmpty(MinAgeBox.Text.Trim()) || string.IsNullOrEmpty(MaxAgeBox.Text.Trim()) ||
                string.IsNullOrEmpty(ActIngredientBox.Text.Trim()) || string.IsNullOrEmpty(DosageBox.Text.Trim()) || string.IsNullOrEmpty(PackagingBox.Text.Trim()))
            {
                return false;
            }

            bool minvalid = int.TryParse(MinAgeBox.Text, out int minage);
            bool maxvalid = int.TryParse(MaxAgeBox.Text, out int maxage);
            if (!minvalid || !maxvalid || minage > maxage || minage < 0)
            {
                return false;
            }

            return true;
        }
    }
}
