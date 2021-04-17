using Assistant;
using Common.Model;
using Physician.DataProvider;
using System;
using System.Collections.Generic;
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

namespace Physician
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public void UpdateData()
        {
            if (PatientDataProvider.GetPatients().ToList().Count > 0)
            {
                PatientList.ItemsSource = PatientDataProvider.GetPatients().ToList();
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            //PatientList.Items.Add(new Patient { FirstName = "Teszt", LastName = "Elek" });
            //var timer = new System.Threading.Timer(e => UpdateData(), null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
            UpdateData();
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


            SelectedPatient selected = new SelectedPatient()
            {
                
                Owner = (Window)PresentationSource.FromVisual(this).RootVisual
            };
            selected.ShowDialog();
        }
    }
}
