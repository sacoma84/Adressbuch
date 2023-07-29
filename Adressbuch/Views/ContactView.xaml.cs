using Adressbuch.ViewModels;
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
using System.Windows.Shapes;

namespace Adressbuch.Views
{
    /// <summary>
    /// Interaction logic for ContactView.xaml
    /// </summary>
    public partial class ContactView : Window
    {
        ContactViewModel _contactViewModel;
        public ContactView()
        {
            InitializeComponent();
            //_contactViewModel = DataContext as ContactViewModel;
            _contactViewModel = (ContactViewModel) this.Resources["cvm"];

            foreach (var item in _contactViewModel.ContactList)
            {
                Trace.WriteLine(item.Id + " | " + item.FullName + " | " + item.Email);
            }
            Trace.WriteLine("FERTIG");
        }
    }
}
