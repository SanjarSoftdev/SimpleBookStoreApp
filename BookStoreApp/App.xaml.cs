namespace BookStoreApp;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();
        MainPage = new AppShell();
	}
}