using Adressbuch.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch.Model
{

    public class DbModel
    {
        // public SqlConnection dbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security=True;Connect Timeout=30");
        // public SqlConnection dbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL16.MYSQLEXPRESS\MSSQL\DATA\Adressbuch.mdf;Integrated Security=True;Connect Timeout=30");
        // public SqlConnection dbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL16.MYSQLEXPRESS\MSSQL\DATA\addressbook_db.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlConnection dbCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\db_addressbook.mdf;Integrated Security=True;Connect Timeout=30");

        // C:\Program Files\Microsoft SQL Server\MSSQL16.MYSQLEXPRESS\MSSQL\DATA\addressbook_db.mdf

        public ObservableCollection<Contact> _contactList = new ObservableCollection<Contact>();

        public  ObservableCollection<Contact> ContactList { get { return _contactList; } set { _contactList = value; } }

        public DbModel()
        {
            ContactList = getSqlDatas();
        }
       
  

    public ObservableCollection<Contact> getSqlDatas()
    {
        ObservableCollection<Contact> contactList = new ObservableCollection<Contact>();

        string sqlSelect = "SELECT * FROM contact";
        dbCon.Open();
        SqlCommand cmd = new SqlCommand(sqlSelect, dbCon);

        SqlDataReader reader = cmd.ExecuteReader();

        Trace.WriteLine("Inhalt aus DB:\n***********");

        while (reader.Read())
        {

            string rowResult = string.Format("Id: {0}, FirstName: {1}, LastName: {2}, Street: {3}, PostalCode: {4}, City: {5}, " +
                "Country: {6}, Email: {7}, Phone: {8}, Birthday: {9}",
                            reader.GetValue(0), 
                            reader.GetValue(1), 
                            reader.GetValue(2), 
                            reader.GetValue(3), 
                            reader.GetValue(4),
                            reader.GetValue(5),
                            reader.GetValue(6),
                            reader.GetValue(7),
                            reader.GetValue(8),
                            reader.GetValue(9) 
                           );
                //  reader.GetName(1), reader.GetOrdinal("lastName")
            Trace.WriteLine($"{rowResult}");
                Trace.WriteLine("---");
            contactList.Add(new Contact()
            {
                Id = (int)reader.GetValue(0),
                FirstName = (string)reader.GetValue(1),
                LastName = (string)reader.GetValue(2),
                Street = reader.GetValue(3).ToString(),
                PostalCode = reader.GetValue(4).ToString(),
                City = reader.GetValue(5).ToString(),
                Country = reader.GetValue(6).ToString(),
                Email = reader.GetValue(7).ToString(),
                Phone = reader.GetValue(8).ToString(),
                Birthday = (DateTime) reader.GetValue(9)

            });
                //string rowResult2 = string.Format("Id: {0}, Name: {1}, Brand: {2}, Category: {3}, Price: {4}",
                //                reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
                //Trace.WriteLine($"{rowResult2}");
            }

            foreach (var item in contactList)
            {
                string rowResult = string.Format("Id: {0}, FirstName: {1}, " +
                    "LastName: {2}, Street: {3}, PostalCode: {4}, City: {5}, " +
                "Country: {6}, Email: {7}, Phone: {8}, Birthday: {9}",
                           item.Id, 
                           item.FirstName,
                           item.LastName,
                           item.Street,
                           item.PostalCode,
                           item.City,
                           item.Country,
                           item.Email,
                           item.Phone,
                           item.Birthday

                           );
                //  reader.GetName(1), reader.GetOrdinal("lastName")
                Trace.WriteLine($"{rowResult}");
            }

        // Alle Datenbank zugehörigen Objekte schließen

        reader.Close();
        cmd.Dispose();

        dbCon.Close();

            return contactList;
    }
    }
}
