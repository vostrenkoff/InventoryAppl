using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;

namespace Inventory
{
    public class ItemPageViewModel : INotifyPropertyChanged
    {
        public MyItem MyItem { get; } = new MyItem();
        public ItemPageViewModel()
        {
            PostItem = new Command(AddItem);
        }
        public static string name;
        public static string counts;
        public ICommand PostItem { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public async void AddItem()
        {
            await Task.Delay(1000);
            //var itemsViewModel = new ItemsViewModel();
            //itemsViewModel.MyItem.Add(new MyItem { ItemName = "New Item", Count = "10" });
            ItemsViewModel.current.MyItem.Add(new MyItem { ItemName = name, Count = counts });
            await App.Current.MainPage.DisplayAlert("Success", "Your item added successfully", "OK");
            MyItem.ClearFields();
        }
    }
}
