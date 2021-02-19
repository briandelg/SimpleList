using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.ComponentModel;
using SimpleList.Model;
using SimpleList.View;
using System.Collections.ObjectModel;

namespace SimpleList.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            Customers = new ObservableCollection<Customer>();
            ClearCommand = new Command(() =>
            {
                clearCustomer();
            });

            SaveCommand = new Command(async () =>
           {
               Customer customer = new Customer(name, address, balance);
               Customers.Add(customer);

               await App.Current.MainPage.DisplayAlert("Confirmation Message", "Thank you " + name, "OK");
               clearCustomer();
               await Application.Current.MainPage.Navigation.PushAsync(getcustomerListPage());
           });
        }

        public ObservableCollection<Customer> Customers { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;

                var args = new PropertyChangedEventArgs(nameof(Name));

                PropertyChanged.Invoke(this, args);
            }
        }

        string address;
        public string Address
        {
            get => address;
            set
            {
                address = value;

                var args = new PropertyChangedEventArgs(nameof(Address));

                PropertyChanged?.Invoke(this, args);
            }
        }

        double balance;
        public double Balance
        {
            get => balance;
            set
            {
                balance = value;

                var args = new PropertyChangedEventArgs(nameof(Balance));

                PropertyChanged?.Invoke(this, args);
            }
        }

       
        private CustomerListPage getcustomerListPage()
        {
            var customerListPage = new CustomerListPage()
            {
                BindingContext = new CustomerListPageViewModel(Customers)
            };

            return customerListPage;
        }
        private void clearCustomer()
        {
            Name = string.Empty;
            Address = string.Empty;
            Balance = 0;
        }

        public Command SaveCommand { get; }
        public Command ClearCommand { get; }

    }
}