using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T_ShirtOrderingApp
{
    class CustomerDetails
    {
        public int Id 
        { 
            get; set; 
        }
        public string Name 
        { 
            get; set; 
        }
        public string Gender 
        { 
            get; set; 
        }
        public string TShirtSize 
        { 
            get; set; 
        }
        public DateTime DateofOrder 
        {
            get; set; 
        }
        public string ShippingAddress 
        {
            get; set; 
        }


    }
}