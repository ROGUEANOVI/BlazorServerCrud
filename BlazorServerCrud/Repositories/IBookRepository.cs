using BlazorServerCrud.Models;

namespace BlazorServerCrud.Repositories
{
    public interface IBookRepository
    {
        public Task<List<Book>> GellAllBooks();

        public Task<Book?> GetBookById(int id);

        public Task<Book> CreateBook(Book book);

        public Task<Book?> UpdateBook(int id, Book book);

        public Task DeleteBook(int id);
    }
}
