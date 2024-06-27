using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int? PublicationYear { get; set; }
    }
}