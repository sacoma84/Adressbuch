using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch.Classes
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;

        private DateTime _birthday;
        private string _street;
        private string _postalCode;
        private string _city;
        private string _country;
        private string _email;
        private string _phone;

        public string FullName { get { return _lastName + ", " + _firstName; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
            }
        }

        public String Street
        {
            get { return _street; }
            set
            {
                _street = value;
            }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set
            {
                _postalCode = value;
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
            }
        }

        public string Country { get { return _country; } set { _country = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public string Phone { get { return _phone; } set { _phone = value; } }
    }
}
