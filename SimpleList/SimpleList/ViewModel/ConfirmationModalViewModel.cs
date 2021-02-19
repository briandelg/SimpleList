using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SimpleList.Model;

namespace SimpleList.ViewModel
{
    public class ConfirmationModalViewModel : ContentPage
    {
        public ConfirmationModalViewModel(Customer customer)
        {
            this.customer = customer;
        }

        public ConfirmationModalViewModel() { }

        Customer customer;

        public Customer Customer { get => customer; }
    }
}