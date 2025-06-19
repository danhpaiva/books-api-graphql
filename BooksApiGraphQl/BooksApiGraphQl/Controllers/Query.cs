using BooksApiGraphQl.Models;

namespace BooksApiGraphQl.Controllers;

public class Query
{
    private static List<Book> books = new()
    {
        new Book { Id = Guid.NewGuid(), Title = "Code Clean", Author = "Robert C. Martin"},
        new Book { Id = Guid.NewGuid(), Title = "Domain-Driven Design", Author = "Eric Evans"},
    };

    public List<Book> GetBooks() => books;
}