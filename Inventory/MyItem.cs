using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory;

    public class MyItem : INotifyPropertyChanged
    {
        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; OnPropertyChanged(nameof(ItemName)); }
        }
        private string count;
        public string Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged(nameof(Count)); }
        }
    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public void SetProperty(string name, object value)
        {

        }

        public void ClearFields()
        {
            ItemName= string.Empty;
            Count= string.Empty;
        }
    }

