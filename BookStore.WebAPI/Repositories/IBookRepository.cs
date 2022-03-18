using BookStore.API.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace BookStore.API.Repositories
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> GetAllBooksAsync();
        public Task<BookModel?> GetBookByIdAsync(int id);
        public Task<int> AddBookAsync(BookModel bookModel);
        public Task UpdateBookAsync(int id, BookModel bookModel);
        public Task UpdateBookByPatchAsync(int id, JsonPatchDocument jsonObject);
        public Task DeleteBookAsync(int id);
    }
}
