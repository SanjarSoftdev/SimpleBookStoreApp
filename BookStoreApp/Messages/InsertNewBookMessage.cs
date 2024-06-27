using BookStoreApp.Models;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace BookStoreApp.Messages
{
    public class InsertNewBookMessage : ValueChangedMessage<Book>
    {
        public InsertNewBookMessage(Book newNook) : base(newNook)
        {
        }
    }
}