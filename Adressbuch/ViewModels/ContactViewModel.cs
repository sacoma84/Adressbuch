using Adressbuch.Classes;
using Adressbuch.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch.ViewModels
{
    public class ContactViewModel 
    {
        public ObservableCollection<Contact> ContactList { get; set; }
        private Contact _selectedContact;



        public Contact SelectedContact 
        { 
            get { return _selectedContact; } 
            set { _selectedContact = value; } 
        }

        public ContactViewModel()
        {

            DbModel dbModel = new DbModel();
            ContactList = dbModel.ContactList;

            //ContactList = new ObservableCollection<Contact>()
            //{
            //    new Contact() { Id = 1, FirstName = "Peter", LastName="Lustig", Street = "Bauwagenstr. 1", PostalCode="98765", City="Löwenzahn-Stadt", Country="Deutschland", Phone="987654321", Email="peter@lustig.de", Birthday= new DateTime(2001,2,3) },
            //    new Contact() { Id = 2, FirstName = "Willi", LastName="Willswissen", Street = "Wissengasse 2", PostalCode="78945", City="Wissens-Stadt", Country="Deutschland", Phone="456456456", Email="willi@willswissen.de", Birthday= new DateTime(2002,1,3) },
            //    new Contact() { Id = 3, FirstName = "Marta", LastName="Machts", Street = "Macherstr. 3", PostalCode="45698", City="Macher-Stadt", Country="Deutschland", Phone="987654321", Email="matar@machts.de", Birthday= new DateTime(2003,2,1) }
            //};
        }
    }
}
