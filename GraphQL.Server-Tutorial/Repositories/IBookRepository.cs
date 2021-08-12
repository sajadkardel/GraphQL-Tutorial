using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Server_Tutorial.Entities;

namespace GraphQL.Server_Tutorial.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBookAsync();
        Task<Book> GetByIdBookAsync(int bookId);
        Task<Book> AddBookAsync(Book book);
        Task<Book> UpdateBookAsync(Book book);
        Task<bool> RemoveBookAsync(Book book);
    }
}
