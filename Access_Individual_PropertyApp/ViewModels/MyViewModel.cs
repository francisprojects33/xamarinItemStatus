using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Access_Individual_PropertyApp.Models;
using Xamarin.Forms;

namespace Access_Individual_PropertyApp.ViewModels
{
    public class MyViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Item> MyItems { get; set; }
        public ICommand UpdateItemStatusCommand { get; set; }
        public MyViewModel()
        {
            MyItems = new ObservableCollection<Item>();

            MyItems.Add(new Item() { ItemId = 1, ItemDescription = "this is a Description 1", ItemStatus = "this is Status 1" });
            MyItems.Add(new Item() { ItemId = 2, ItemDescription = "this is a Description 2", ItemStatus = "this is Status 2" });
            MyItems.Add(new Item() { ItemId = 3, ItemDescription = "this is a Description 3", ItemStatus = "this is Status 3" });
            MyItems.Add(new Item() { ItemId = 4, ItemDescription = "this is a Description 4", ItemStatus = "this is Status 4" });

            UpdateItemStatusCommand = new Command(() =>
            {
                MyItems[1].ItemStatus = $"Completed !!!";
            });
        }

        // **************

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private string itemStatus = "Still in progress";

        public string ItemStatus
        {
            get => itemStatus;
            set
            {
                if (value == itemStatus)
                    return;

                itemStatus = value;
                OnPropertyChanged(nameof(ItemStatus));
            }
        }

        public int ItemId { get; set; }
        public string ItemDescription { get; set; }

    }
}
