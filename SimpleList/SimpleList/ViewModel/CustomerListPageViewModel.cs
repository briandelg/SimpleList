using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.ComponentModel;
using SimpleList.Model;
using System.Collections.ObjectModel;

namespace SimpleList.ViewModel
{
    public class CustomerListPageViewModel : INotifyPropertyChanged
    {
        public CustomerListPageViewModel(ObservableCollection<Customer> customers)
        {
            this.customers = customers;
        }

        ObservableCollection<Customer> customers;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Customer> Customers { get => customers; } 

    }
}