﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TodoDataGrid
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<TodoDataGrid.Model.TodoModel> _todoDataGridList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _todoDataGridList = new BindingList<TodoDataGrid.Model.TodoModel>()
            { 
                new Model.TodoModel(){ Text="один"},
                new Model.TodoModel(){ Text="два"},
                new Model.TodoModel(){ Text="три"}
            };

            dgTodoList.ItemsSource = _todoDataGridList;
        }
    }
}
