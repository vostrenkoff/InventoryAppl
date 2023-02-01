using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace Inventory
{
    public class ItemsViewModel
    {
        public static ItemsViewModel current;
        public ObservableRangeCollection<MyItem> MyItem { get; set; }
        
        public ObservableRangeCollection<Grouping<string, MyItem>> ItemsGrouping { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public ItemsViewModel() 
        {
            current = this;
            MyItem = new ObservableRangeCollection<MyItem>();
            ItemsGrouping = new ObservableRangeCollection<Grouping<string, MyItem>>();

            MyItem.Add(new MyItem { ItemName = "Crate", Count = "10"});
            MyItem.Add(new MyItem { ItemName = "Crate", Count = "10"});
            MyItem.Add(new MyItem { ItemName = "Crate", Count = "10"});
            MyItem.Add(new MyItem { ItemName = "Crate", Count = "10"});
            MyItem.Add(new MyItem { ItemName = "Crate", Count = "10"});
            MyItem.Add(new MyItem { ItemName = "Crate", Count = "10"});
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "56"});
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "1" });
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Carrot", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            MyItem.Add(new MyItem { ItemName = "Car", Count = "1"});
            //Refresh();

            //ItemsGrouping.Add(new Grouping<string,MyItem>());
        }
        async Task Refresh()
        {
            //IsBusy = true;
            
            //IsBusy = false;
        }
    }
}
