using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleList.Model
{
    public class Customer
    {
        public string name { get; set; }
        public string address { get; set; }
        public double balance { get; set; }

        public Customer() 
        {
            this.name = "";
            this.address = "";
            this.balance = 0;
        }

        public Customer(string name, string address, double balance)
        {
            this.name = name;
            this.address = address;
            this.balance = balance;
        }

        public void clearCustomer()
        {
            name = string.Empty;
            address = string.Empty;
            balance = 0;
        }
    }
}
