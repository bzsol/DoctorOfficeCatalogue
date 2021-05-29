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

namespace Physician.Medication
{
    /// <summary>
    /// Interaction logic for SelectedMedication.xaml
    /// </summary>
    public partial class SelectedMedication : Window
    {
        private Common.Model.Medication medication;

        public SelectedMedication(Common.Model.Medication med)
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
            DescriptionBox.Text = medication.Description;
            if (PatientObserver.Instance.Medications.Contains(medication.MedicationName))
            {
                AddMedication.Content = "Eltávolítás";
            }
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
                medication.Description = DescriptionBox.Text;
                MedicationDataProvider.UpdateMedication(medication);
                ErrorLabel.Visibility = Visibility.Hidden;
                Close();
            }
            ErrorLabel.Content = "Az adatok kitöltése hibás!";
            ErrorLabel.Visibility = Visibility.Visible;
        }

        private void AddMedication_Click(object sender, RoutedEventArgs e)
        {
            if (MedReview())
            {
                if (PatientObserver.Instance.Medications.Contains(medication.MedicationName))
                {
                    PatientObserver.Instance.Medications.Remove(medication.MedicationName);
                }
                else
                {
                    PatientObserver.Instance.Medications.Add(medication.MedicationName);
                }
                ErrorLabel.Visibility = Visibility.Hidden;
                Close();
            }
            else
            {
                ErrorLabel.Visibility = Visibility.Visible;
                ErrorLabel.Content = "A gyógyszer felírása ellenjavallt!";
            }
        }

        private void CloseMedicationDataWindow_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool MedReview()
        {
            if (PatientObserver.Instance.Age < medication.MinimumAge || PatientObserver.Instance.Age > medication.MaximumAge)
            {
                return false;
            }

            foreach (var allergy in PatientObserver.Instance.Allergy.Split(", "))
            {
                foreach (var ingredient in medication.ActiveIngredient.Split(", "))
                {
                    if (allergy.Equals(ingredient))
                    {
                        return false;
                    }
                }
            }

            return true;
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
