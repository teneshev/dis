﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dis
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        qwertEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new qwertEntities();
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            var user = context.Client.FirstOrDefault(u => (u.Email == Login.Text || u.Phone == Login.Text) && u.LastName == Password.Password);
            if (user == null)
            {
                MessageBox.Show("Неверные данные");
                return;
            }
            else
            {
                if (user.ID == 1)
                {
                    MessageBox.Show("Hello");
                    var admin = new Tables();
                    admin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hello");
                    var tables = new Tables();
                    tables.Show();
                    this.Close();
                }
            }
        }
    }
}
