using BlazorServerCrud.Data;
using BlazorServerCrud.Models;

namespace BlazorServerCrud.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Book> CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GellAllBooks()
        {
            throw new NotImplementedException();
        }

        public Task<Book?> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book?> UpdateBook(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
