﻿using System;
using System.Collections.Generic;
using System.Data;
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

namespace lab4
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    
    public partial class AdminWindow : Window
    {
        AppContext db;
        public AdminWindow()
        {
            InitializeComponent();

            db = new AppContext();
            List<Train> trains = db.Trains.ToList();
            dataGrid.ItemsSource = trains;
            dataGrid.Columns[0].IsReadOnly = true;


        }

        private void Button_OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            InputData inputData = new InputData();
            inputData.Show();
        }

        private void dataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {

        }
    }
}