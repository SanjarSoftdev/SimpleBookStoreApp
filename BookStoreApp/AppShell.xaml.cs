using BookStoreApp.Views;

namespace BookStoreApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddBookPage), typeof(AddBookPage));
	}
}