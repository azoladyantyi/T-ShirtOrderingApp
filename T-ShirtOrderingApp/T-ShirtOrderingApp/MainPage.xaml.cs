using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_ShirtOrderingApp;
using Xamarin.Forms;
using SQLite;
using System.IO;

namespace T_ShirtOrderingApp
{
    public partial class MainPage : ContentPage
    {
        public CustomerDetails customer;

        Orderdatabase Orderdatabase;

        public MainPage()
        {
            InitializeComponent();

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "order.db");

            Orderdatabase = new Orderdatabase(path);
        }

        public void SaveBottun_Clicked(object sender, EventArgs e)
        {
            customer = new CustomerDetails
            {
                Name = nameEntry.Text,
                DateofOrder = DateTime.Now,
                TshirtColor = tColorEntry.Text,
                ShippingAddress = shippingEntry.Text
            };

            var page = new Page1(customer);

            Navigation.PushAsync(page);
            }
            
        }

    }
