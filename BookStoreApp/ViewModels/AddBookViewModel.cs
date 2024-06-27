using BookStoreApp.Models;
using BookStoreApp.Messages;
using BookStoreApp.Services;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BookStoreApp.ViewModels
{
    public class AddBookViewModel : ObservableObject
    {
        private readonly IBookService bookService;

        private Book newBook;
        public Book NewBook
        {
            get { return newBook; }
            set { SetProperty(ref newBook, value); }
        }

        public IRelayCommand InsertBookCommand { get; }

        public AddBookViewModel(IBookService bookService)
        {
            this.bookService = bookService;
            NewBook = new Book();
            InsertBookCommand = new RelayCommand(InsertBook);
        }

        private void InsertBook()
        {
            if (string.IsNullOrEmpty(NewBook.Title))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid book title.", "OK");
                return;
            }

            if (string.IsNullOrEmpty(NewBook.Author))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid author name.", "OK");
                return;
            }

            int currentYear = DateTime.Now.Year;
            int minYear = DateTime.MinValue.Year;
            if (NewBook.PublicationYear == null || NewBook.PublicationYear < minYear || NewBook.PublicationYear > currentYear)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid publication year.", "OK");
                return;
            }

            bookService.AddBook(NewBook);
            WeakReferenceMessenger.Default.Send(new InsertNewBookMessage(NewBook));
            Shell.Current.SendBackButtonPressed();
        }
    }
}