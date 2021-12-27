﻿
using System.Windows;
using WpfAppDP.Model;
using WpfAppDP.View;

namespace WpfAppDP
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RoleViewModel vmRole = new RoleViewModel();
        private PersonViewModel vmPerson = new PersonViewModel();


        public static int IdRole { get; set; }
        public static int IdEmployee { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
             private void Employee_OnClick(object sender, RoutedEventArgs e)
        {
            WindowEmployee wEmployee = new WindowEmployee(vmPerson, vmRole);
            wEmployee.Title = "Сотрудники";
            wEmployee.Show();
        }
        private void Role_OnClick(object sender, RoutedEventArgs e)
        {
            WindowRole wRole = new WindowRole(vmRole);
            wRole.Show();
        }

    }
}

