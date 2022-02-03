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

namespace dis
{
    /// <summary>
    /// Логика взаимодействия для Tables.xaml
    /// </summary>
    public partial class Tables : Window
    {
        qwertEntities context;
        public Tables()
        {
            InitializeComponent();
            context = new qwertEntities();
            ShowTable();
        }

        private void ShowTable()
        {
            DataGridClientService.ItemsSource = context.ClientService.ToList();
        }

        private void BtnAddtableData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGridRental_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAddData_Click_1(object sender, RoutedEventArgs e)
        {
            var NewClientServ = new ClientService();
            context.ClientService.Add(NewClientServ);
            var btnAddClientServ2 = new BtnAddClientServ2(context, NewClientServ);
            btnAddClientServ2.ShowDialog();
        }

        private void BtnDeleteData_Click_1(object sender, RoutedEventArgs e)
        {
            var currentClientService = DataGridClientService.SelectedItem as ClientService;
            if (currentClientService == null)
            {
                MessageBox.Show("Выберите строку!");
                return;

            }
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.ClientService.Remove(currentClientService);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnEditData_Click_1(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var currentRental = BtnEdit.DataContext as ClientService;
            var EdiWindow = new BtnAddClientServ(context, currentRental);
            EdiWindow.ShowDialog();
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            var RentalSelect = new ClientAdd();
            RentalSelect.ShowDialog();
        }

        private void DataGridClientService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
