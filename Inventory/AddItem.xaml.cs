namespace Inventory;

public partial class AddItem : ContentPage
{
	public AddItem()
	{
		InitializeComponent();
        BindingContext = new ItemPageViewModel();
    }
	public void ButtonIsClicked(object sender, EventArgs e)
	{
		string name = _name.Text;
        string cnt = _cnt.Text;
        ItemPageViewModel.name = name;
        ItemPageViewModel.counts = cnt;
        //ItemPageViewModel.PostItemStatic.Execute(null);
        
    }
}