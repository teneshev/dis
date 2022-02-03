using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для BtnAddClient.xaml
    /// </summary>
    public partial class BtnAddClient : Window
    {
        qwertEntities context;
        public BtnAddClient(qwertEntities context, Client client)
        {
            InitializeComponent();
            Cmb.ItemsSource = context.Gender.ToList();
            this.context = context;
            this.DataContext = client;
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            //    OpenFileDialog openFile = new OpenFileDialog();
            //    openFile.Filter = "Image files: *.jpeg, *.jpg, *.png| *.jpeg; *.jpg; *.png";
            //    openFile.ShowDialog();
            //    if (openFile.FileName.Length != 0)
            //    {
            //        string nameFile = openFile.FileName;
            //        byte[] image = File.ReadAllBytes(nameFile);
            //        var clothe = (Client)this.DataContext;
            //        clothe.PhotoPath = image;
            //        Img.Source = new BitmapImage(new Uri(nameFile));
            //    }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
