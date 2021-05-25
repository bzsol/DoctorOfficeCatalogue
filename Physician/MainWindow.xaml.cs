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
                window.ShowDialog();
                PatientList.UnselectAll();
                PatientList.ItemsSource = null;
                
            }
        }

        private void List_Load(object sender,RoutedEventArgs e) {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += Dt_Tick;
            dt.Start();

        }
        private void Dt_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
