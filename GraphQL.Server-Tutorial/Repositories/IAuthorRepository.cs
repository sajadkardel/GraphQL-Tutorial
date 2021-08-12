using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL.Server_Tutorial.Entities;

namespace GraphQL.Server_Tutorial.Repositories
{
    public interface IAuthorRepository
    {
        Task<List<Author>> GetAllAuthorAsync();
        Task<Author> GetByIdAuthorAsync(int authorId);
        Task<Author> AddAuthorAsync(Author author);
        Task<Author> UpdateAuthorAsync(Author author);
        Task<bool> RemoveAuthorAsync(Author author);
    }
}
