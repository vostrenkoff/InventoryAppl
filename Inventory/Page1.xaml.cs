using AndroidX.Lifecycle;
using MvvmHelpers;
namespace Inventory;

public partial class Page1 : ContentPage
{
    public ObservableRangeCollection<MyItem> MyLocalItems { get; set; }
    public Page1()
	{
		InitializeComponent();
        var oldviewModel = new ItemsViewModel();
        MyLocalItems = new ObservableRangeCollection<MyItem>();
        MyLocalItems = oldviewModel.MyItem;
    }
    private void Searchbar_textChanged(object sender, TextChangedEventArgs e)
	{
        
        
        var keyword = SearchBar.Text;
        var viewModel = MyLocalItems.Where(c => c.ItemName.Contains(keyword));
        listofitems.ItemsSource= viewModel;
    }
}