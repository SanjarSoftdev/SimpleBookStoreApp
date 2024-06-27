using BookStoreApp.ViewModels;

namespace BookStoreApp.Views;

public partial class BooksPage : ContentPage
{
	public BooksPage(BooksViewModel booksViewModel)
	{
		InitializeComponent();
		BindingContext = booksViewModel;
    }
}