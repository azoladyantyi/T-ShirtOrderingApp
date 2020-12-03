using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_ShirtOrderingApp;
using Xamarin.Forms;
using SQLite;

namespace T_ShirtOrderingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void SaveBottun_Clicked(object sender, EventArgs e)
        {
            CustomerDetails CustomerDetails = new CustomerDetails()
            {
                Name = nameEntry.Text,
                Gender = genderEntry.Text,
                TShirtSize = TsizeEntry.Text,
                DateofOrder = dateOdreEntry.Text,
                TShirtColor = TSirtColorEntry.Text,
                shippingAddress = shippingEntry.Text,
            };
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<CustomerDetails>();
                int rowsAdded = conn.Insert(CustomerDetails);
            }
        }
    }
}
