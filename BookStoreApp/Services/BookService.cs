using System.Text.Json;
using BookStoreApp.Models;

namespace BookStoreApp.Services
{
    public class BookService : IBookService
    {
        public const string FILE_NAME = "books.json";

        private readonly IFileSystem fileSystem;

        public BookService(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public void AddBook(Book book)
        {
            string fileName = Path.Combine(fileSystem.AppDataDirectory, FILE_NAME);
            List<Book> existingData;
            try
            {
                existingData = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(fileName));
            }
            catch
            {
                existingData = new List<Book>();
            }
            existingData.Add(book);
            File.WriteAllText(fileName, JsonSerializer.Serialize(existingData, new JsonSerializerOptions { WriteIndented = true }));
        }

        public List<Book> GetBooks()
        {
            string fileName = Path.Combine(fileSystem.AppDataDirectory, FILE_NAME);
            try
            {
                return JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(fileName));
            }
            catch
            {
                return null;
            }
        }

        public void RemoveAllBooks()
        {
            string fileName = Path.Combine(fileSystem.AppDataDirectory, FILE_NAME);
            File.WriteAllText(fileName, "");
        }
    }
}