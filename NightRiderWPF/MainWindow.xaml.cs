﻿using NightRiderWPF.DeveloperView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using LogicLayer.AppData;

namespace NightRiderWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem is ListBoxItem item)
            {
                switch (item.Name)
                {
                    case "SamplePage":
                        PageViewer.Navigate(new SamplePage());
                        break;
                    // Your cases here
                    case "AdminViewClientList":
                        PageViewer.Navigate(new AdminViewClientList());
                        break;
                    case "AdminCreateEmployeePage":
                        PageViewer.Navigate(new AdminCreateNewEmployee());
                        break;
                    case "PartsPersonViewParts":
                        PageViewer.Navigate(new PartsInventoryPage());
                        break;
                    case "AddDependentPage":
                        PageViewer.Navigate(new AddDependent());
                        break;
                    case "AdminEmployeeListPage":
                        PageViewer.Navigate(new AdminEmployeeListPage());
                        break;
                    case "VehicleLookupListPage":
                        PageViewer.Navigate(new VehicleLookupListPage());
                        break;
                    case "EmployeeProfilePage":
                        PageViewer.Navigate(new EmployeeProfilePage(Authentication.AuthenticatedEmployee));
                        break;
                    case "ViewWorkOrderPage":
                        PageViewer.Navigate(new ViewWorkOrderPage());
                        break;
                    case "ClientPersonalPage":
                        PageViewer.Navigate(new ClientPersonalPage(Authentication.AuthenticatedClient));
                        break;
                }
            }
        }
    }
}
