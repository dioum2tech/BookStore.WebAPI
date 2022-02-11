using AutoMapper;
using BookStore.API.Data;
using BookStore.API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext context;
        private readonly IMapper mapper;

        public BookRepository(BookStoreContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var books = await context.Books!.ToListAsync();
            return mapper.Map<List<BookModel>>(books);
        }

        public async Task<BookModel?> GetBookByIdAsync(int id)
        {
            var book = await context.Books!.FindAsync(id);
            return mapper.Map<BookModel>(book);
        }

        public async Task<int> AddBookAsync(BookModel bookModel)
        {
            var book = new Book()
            {
                Name = bookModel.Name,
                Description = bookModel.Description
            };

            context.Books!.Add(book);
            await context.SaveChangesAsync();

            return book.Id;
        }

        public async Task UpdateBookAsync(int id, BookModel bookModel)
        {
            var book = new Book()
            {
                Id = id,
                Name = bookModel.Name,
                Description = bookModel.Description
            };

            context.Books!.Update(book);
            await context.SaveChangesAsync();
        }

        public async Task UpdateBookByPatchAsync(int id, JsonPatchDocument jsonObject)
        {
            var book = await context.Books!.FindAsync(id);

            if (book != null)
            {
                jsonObject.ApplyTo(book);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = new Book() { Id = id };

            context.Books!.Remove(book);
            await context.SaveChangesAsync();
        }
    }
}
