using Adressbuch.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch.ViewModels
{
    public class ContactViewModel
    {
        public ObservableCollection<Contact> ContaktListe { get; set; }

        public ContactViewModel()
        {
            ContaktListe = new ObservableCollection<Contact>()
            {
                new Contact() { FirstName = "Peter", LastName="Lustig", Street = "Bauwagenstr. 1", PostalCode="98765", City="Löwenzahn-Stadt", Country="Deutschland", Phone="987654321", Email="peter@lustig.de", Birthday= DateTime.Now },
                new Contact() { FirstName = "Willi", LastName="Willswissen", Street = "Wissengasse 2", PostalCode="78945", City="Wissens-Stadt", Country="Deutschland", Phone="456456456", Email="willi@willswissen.de", Birthday= DateTime.Now },
                new Contact() { FirstName = "Marta", LastName="Machts", Street = "Macherstr. 3", PostalCode="45698", City="Macher-Stadt", Country="Deutschland", Phone="987654321", Email="matar@machts.de", Birthday= DateTime.Now }
            };
        }
    }
}
