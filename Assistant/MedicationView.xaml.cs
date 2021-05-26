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
    /// Interaction logic for MedicationView.xaml
    /// </summary>
    public partial class MedicationView : Window
    {
        public MedicationView()
        {
            InitializeComponent();
        }

        private void AddMedication_Click(object sender, RoutedEventArgs e)
        {
            if (GetValidationResult())
            {
                MedicationDataProvider.CreateMedication(new Medication
                {
                    MedicationName = MedNameBox.Text,
                    MinimumAge = int.Parse(MinAgeBox.Text),
                    MaximumAge = int.Parse(MaxAgeBox.Text),
                    ActiveIngredient = ActIngredientBox.Text,
                    Dosage = DosageBox.Text,
                    Packaging = PackagingBox.Text
                });
                ClearFields();
            }
            else
            {
                MessageBox.Show("Hibás adatok!");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            MedNameBox.Text = string.Empty;
            MinAgeBox.Text = string.Empty;
            MaxAgeBox.Text = string.Empty;
            ActIngredientBox.Text = string.Empty;
            DosageBox.Text = string.Empty;
            PackagingBox.Text = string.Empty;
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
