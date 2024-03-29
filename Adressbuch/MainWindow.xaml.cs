﻿using Adressbuch.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Net.Mime.MediaTypeNames;

namespace Adressbuch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContactViewModel contactViewModel;

        public MainWindow()
        {
            InitializeComponent();

            contactViewModel = new ContactViewModel();
            var dataSet = contactViewModel.ContactList;
            dgAdressliste.ItemsSource = dataSet; // .DefaultView;

        }

        private void BtnCloseProgram_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DgAdressliste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // var row = dgAdressliste.ColumnFromDisplayIndex().ToString();
            int lastIndex = dgAdressliste.SelectedIndex; // Index-Zahl des DataGrid-Array
            var selectedItem = dgAdressliste.SelectedItem; // ?
            var selectedValue = dgAdressliste.SelectedValue; // ?
            var dsRow = dgAdressliste.CurrentCell;
            Trace.WriteLine("dsRow: " + dsRow);
            //dgAdressliste.Columns.
            // string userID = (string)(((DataRowView)(DataGrid.SelectedItem)).Row[1]);
            var ds = contactViewModel.ContactList.ToArray();

            if (lastIndex < ds.Count())
            {
                tbxVorname.Text = ds[lastIndex].FirstName;
                tbxNachname.Text = ds[lastIndex].LastName;
                tbxStrasse.Text = ds[lastIndex].Street;
                tbxPlz.Text = ds[lastIndex].PostalCode;
                tbxOrt.Text = ds[lastIndex].City;
                tbxLand.Text = ds[lastIndex].Country;
                tbxTelefon.Text = ds[lastIndex].Phone;
                tbxEmail.Text = ds[lastIndex].Email;
                tbxGeburtsdatum.Text = ds[lastIndex].Birthday.ToString();
                Trace.WriteLine(ds[lastIndex].Id + " | " + ds[lastIndex].FullName);
            }
        

            
            //string selectItem = dgAdressliste.;
            //MessageBox.Show(selectItem);            
        }

        private void BtnPreviewPrint_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPrevious_Click(object sender, RoutedEventArgs e)
        {
            int lastIndex = dgAdressliste.SelectedIndex; // Index-Zahl des DataGrid-Array
            
            if (lastIndex > 0)
            {
                lastIndex--;
                dgAdressliste.SelectedIndex = lastIndex;
            }
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            int lastIndex = dgAdressliste.SelectedIndex; // Index-Zahl des DataGrid-Array
            Trace.WriteLine("dgAdressliste.AlternationCount: " + dgAdressliste.AlternationCount);
            if (lastIndex < contactViewModel.ContactList.Count()-1)
            {
                lastIndex++;
                dgAdressliste.SelectedIndex = lastIndex;
            }
        }
    }
}
