using BookStoreApp.Models;

namespace BookStoreApp.Services
{
    public interface IBookService
    {
        public void AddBook(Book book);

        public List<Book> GetBooks();

        public void RemoveAllBooks();
    }
}