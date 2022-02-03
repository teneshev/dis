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
    /// Логика взаимодействия для BtnAddClientServ2.xaml
    /// </summary>
    public partial class BtnAddClientServ2 : Window
    {
        qwertEntities context;
        public BtnAddClientServ2(qwertEntities context, ClientService nClientService)
        {
            InitializeComponent();
            this.context = context;
            CmbClient.ItemsSource = context.Client.ToList();
            CmbService.ItemsSource = context.Service.ToList();
            this.DataContext = nClientService;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
