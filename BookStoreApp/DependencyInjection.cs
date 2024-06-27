using BookStoreApp.Views;
using BookStoreApp.Services;
using BookStoreApp.ViewModels;

namespace BookStoreApp
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton(FileSystem.Current);
            mauiAppBuilder.Services.AddSingleton<IBookService, BookService>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<BooksPage>();
            mauiAppBuilder.Services.AddTransient<AddBookPage>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<BooksViewModel>();
            mauiAppBuilder.Services.AddTransient<AddBookViewModel>();
            return mauiAppBuilder;
        }
    }
}