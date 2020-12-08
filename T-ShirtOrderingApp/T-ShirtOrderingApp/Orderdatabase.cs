using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace T_ShirtOrderingApp
{


    class Orderdatabase
{
        readonly SQLiteConnection conn;
        public string StatusMessage { get; set; }

        public Orderdatabase(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<CustomerDetails>();
        }
        public void AddNewCustomer(string name, string gender, string Tshirt_Size, string Tshirt_color, string Shipping_address)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                result = conn.Insert(new CustomerDetails { Name = name, Gender = gender, TShirtSize = Tshirt_Size, TshirtColor = Tshirt_color, ShippingAddress = Shipping_address,  });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }
        }
        public List<CustomerDetails> GetAllPeople()
        {
            try
            {
                return conn.Table<CustomerDetails>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<CustomerDetails>();
        }

    }
}
