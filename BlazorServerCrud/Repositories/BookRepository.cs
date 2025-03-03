using BlazorServerCrud.Data;
using BlazorServerCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrud.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> CreateBook(Book book)
        {
            if (book is null) return new Book() { Title = "" , Author = "" };

            book.CreationDate = DateTime.Now;
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            
            return book;
        }

        public async Task DeleteBook(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);

            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Book>> GellAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book is null) return null;

            return book;
        }

        public async Task<Book?> UpdateBook(int id, Book book)
        {
            var bookToUpdate = await _context.Books.FindAsync(id);
           
            if (bookToUpdate is null) return null;

            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Description = book.Description;
            bookToUpdate.Pages = book.Pages;
            bookToUpdate.Price = book.Price;
            bookToUpdate.CreationDate = book.CreationDate;

            await _context.SaveChangesAsync();

            return bookToUpdate;
        }
    }
}
