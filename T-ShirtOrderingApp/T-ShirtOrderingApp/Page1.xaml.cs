using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace T_ShirtOrderingApp
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
    }

        public Page1(CustomerDetails customer)
        {
            Customer = customer;
        }

        public CustomerDetails Customer { get; }
    }
}