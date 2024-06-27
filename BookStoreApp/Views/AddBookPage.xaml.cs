using BookStoreApp.ViewModels;

namespace BookStoreApp.Views;

public partial class AddBookPage : ContentPage
{
	public AddBookPage(AddBookViewModel addBookViewModel)
	{
		InitializeComponent();
        BindingContext = addBookViewModel;
    }
}